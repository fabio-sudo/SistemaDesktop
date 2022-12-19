using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AcessoDados;
using ObjetoTransferencia;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class NegGenero
    {
        private ConexaoSqlServer sqlServer = new ConexaoSqlServer();

        //Metodo para cadastrar produto
        public Boolean CadastrarGenero(Genero genero)
        {
            try
            {
                sqlServer.LimparParametros();

                sqlServer.AdicionarParametro(new SqlParameter("@nomeGenero", genero.nomeGenero));

                string comandoSql = "exec uspCadastrarGenero @nomeGenero";

                sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível cadastrar o genero. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //metodo excluir genero
        public Boolean ExcluirGenero(Genero genero)
        {
            try
            {

                sqlServer.LimparParametros();

                sqlServer.AdicionarParametro(new SqlParameter("@codigo", genero.codigoGenero));

                string comandoSql = "exec uspExcluirGenero @codigo";

                object Resposta = sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                if (Convert.ToInt16(Resposta) == 1 || Convert.ToInt16(Resposta) == 2)
                {
                    return false;//está vinculado ao cadastro do produto
                }
                else
                    return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível excluir os dados do genero. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //metodo para alterar produto
        public Boolean AtualizarGenero(Genero genero)
        {
            try
            {

                sqlServer.LimparParametros();


                sqlServer.AdicionarParametro(new SqlParameter("@codigoGenero", genero.codigoGenero));
                sqlServer.AdicionarParametro(new SqlParameter("@nomeGenero", genero.nomeGenero));

                string comandoSql = "exec uspAlterarGenero @codigoGenero, @nomeGenero";

                sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível alterar os dados do Genero. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //------------------------Consultas

        //metodo para buscar produto por nome
        public GeneroLista BuscarGeneroPorNome(string nome)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@nomeGenero", nome));
            string comandoSql = "exec uspBuscarGeneroPorNome @nomeGenero";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

            GeneroLista generos = new GeneroLista();
            Genero genero;

            foreach (DataRow registro in tabelaRetorno.Rows)
            {
                genero = new Genero();
                genero.codigoGenero = Convert.ToInt32(registro[0]);
                genero.nomeGenero = registro[1].ToString();

                generos.Add(genero);
            }

            return generos;
        }

        //metodo para buscar produto por Codigo
        public Genero BuscarGeneroPorCodigo(int codigo)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@codigoGenero", codigo));
            string comandoSql = "exec uspBuscarGeneroPorCodigo @codigoGenero";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);


            if (tabelaRetorno.Rows.Count > 0)
            {
                Genero genero = new Genero();
                DataRow registro = tabelaRetorno.Rows[0];


                genero.codigoGenero = Convert.ToInt32(registro[0]);
                genero.nomeGenero = registro[1].ToString();

                return genero;
            }
            else
                return null;

        }

        //realiza a validação se ja a o produto cadastrado de acordo com a referencia
        public Genero ValidarCadastroGenero(String strGenero)
        {
            try
            {
                DataTable tabelaRetorno;
                Genero genero;

                this.sqlServer.LimparParametros();
                this.sqlServer.AdicionarParametro(new SqlParameter("@genero", strGenero));

                string comando = "exec uspValidaCadastroGenero @genero";

                tabelaRetorno = this.sqlServer.ExecutarConsulta(comando, CommandType.Text);
                if (tabelaRetorno.Rows.Count > 0)
                {
                    DataRow registro = tabelaRetorno.Rows[0];//Consulta só retorna uma objeto

                    genero = new Genero();

                    genero.codigoGenero = Convert.ToInt32(registro[0]);
                    genero.nomeGenero = (registro[1].ToString());

                    return genero;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível validar o genero. [Negócios]. Motivo: " + ex.Message);
            }
        }

    }
}
