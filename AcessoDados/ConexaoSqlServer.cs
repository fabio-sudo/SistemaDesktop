using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AcessoDados.Properties;

namespace AcessoDados
{
    public class ConexaoSqlServer
    {


        //Define a maneira com que o objeto AcessoDadosSqlServer será inicializado.
        public ConexaoSqlServer()
        {
            //Inicializa-se a listaParametros.
            this.listaParametros = new SqlCommand().Parameters;
        }

        //A classe representa um conjunto de parâmetros sql (nome do parâmetro, valor).
        //@Nome = "Fabio Henrique";
        //@Sobrenome = "Trevezane"
        private SqlParameterCollection listaParametros;

        //Adiciona a listaParametros um novo elemento (item).
        public void AdicionarParametro(SqlParameter parametro)
        {
            try
            {
                //É adicionado a lista um novo elemento.
                this.listaParametros.Add(parametro);
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao adicionar parâmetro. Motivo: " + ex.Message);
            }
        }

        //Limpa todos os elementos contidos dentro da listaParametros.
        public void LimparParametros()
        {
            try
            {
                //Remove todos os elementos da coleção.
                this.listaParametros.Clear();
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao limpar parâmetros. Motivo: " + ex.Message);
            }
        }

        //A classe SqlConnection representa a conexão aberta.
        private SqlConnection ObterConexao()
        {
            try
            {
                //Na linha abaixo está sendo inicializada uma nova conexão com o BD.
                //Esta conexão deve receber os parâmetros de conexão: nome do servidor,
                //nome do banco de dados, usuário e senha.
                return new SqlConnection(Settings.Default.strConexao);//Settings.Default.StringConexao);******************
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao abrir conexão com o BD. Motivo: " + ex.Message);
            }
        }

        // Este método adiciona os parâmetros contidos na listaParametros ao comando que 
        // será executado (SqlCommand).
        private void SetarParametros(SqlCommand comando)
        {
            //Limpa os parâmetros do comando (somente para garantir)
            comando.Parameters.Clear();
            //Percorre todos os elementos (SqlParameter) contidos na listaParametros.
            foreach (SqlParameter parametro in this.listaParametros)
            {
                //Adiciona um novo parâmetro ao comando (Nome, Valor).
                comando.Parameters.Add(new SqlParameter(parametro.ParameterName,
                    parametro.Value));
            }
        }

        //Método que envia ao banco de dados comandos de insert, update e delete.
        public object ExecutarScalar(string comando, CommandType tipoComando)
        {
            try
            {
                //Using: indica que o coletor de lixo não deve remover da memória a conexao.
                using (SqlConnection conexao = ObterConexao())
                {
                    //Abre a conexão com o banco de dados.
                    conexao.Open();
                    //Adiciona a conexão um comando sql (SqlCommand).
                    SqlCommand comandoSql = conexao.CreateCommand();
                    //Define qual o texto do comando. Ex: insert into tblCliente ...
                    comandoSql.CommandText = comando;
                    //Define qual o tipo do comando. Ex.: texto e stored procedure.
                    comandoSql.CommandType = tipoComando;
                    //Define o tempo máximo para execução do comando em segundos.
                    comandoSql.CommandTimeout = 7200;
                    //Adiciona os parâmetros ao comandoSql.
                    SetarParametros(comandoSql);
                    //Envia o comandoSql ao banco de dados e aguarda a execução do mesmo.
                    //Caso o comando retorne valor o mesmo será enviado a camada de negócios.
                    return comandoSql.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao executar comando. Motivo : " + ex.Message);
            }
        }

        //Método que envia comandos de consulta ao banco de dados (select).
        //Este método retorna uma tabela (DataTable)
        public DataTable ExecutarConsulta(string comando, CommandType tipoComando)
        {
            try
            {
                using (SqlConnection conexao = ObterConexao())
                {
                    conexao.Open();

                    SqlCommand comandoSql = conexao.CreateCommand();
                    comandoSql.CommandText = comando;
                    comandoSql.CommandType = tipoComando;
                    comandoSql.CommandTimeout = 7200;
                    SetarParametros(comandoSql);
                    //SqlDataAdapter é a classe responsável por enviar um comando de consulta
                    //ao banco de dados.
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comandoSql);
                    //DataSet: conjunto de tabelas
                    DataSet dataSet = new DataSet();
                    //Método Fill preenche o dataSet com o resultado da execução da consulta.
                    //Retorna uma ou mais tabelas.
                    sqlDataAdapter.Fill(dataSet);
                    //No dataSet retornamos a primeira tabela contida no mesmo Tables[0].
                    return dataSet.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao executar consulta. Motivo: " + ex.Message);
            }
        }
    }
}
