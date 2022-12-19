using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AcessoDados;
using ObjetoTransferencia;
using System.Data.SqlClient;
using System.Data;

namespace Negocio
{
    public class NegCor
    {
        ConexaoSqlServer sqlserver = new ConexaoSqlServer();

        //Cadastra cor
        public Boolean CadastrarCor(Cor cor) {
            try
            {
                sqlserver.LimparParametros();
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@nomeCor", cor.nomeCor));

                string comando = "exec uspCadastrarCor @nomeCor";
                
                object Resposta = sqlserver.ExecutarScalar(comando, System.Data.CommandType.Text);
                if (Convert.ToInt16(Resposta) == 2)
                {
                    return false;//Erro ao cadastrar cor
                }
                else
                    return true;

            }
            catch (Exception ex) {
                return false;
                throw new Exception("Erro na camada de negócios. Cadastro de Cor " + ex.Message); 
            }
       }

        //Alterar cor
        public Boolean AtualizarCor(Cor cor) {
            try
            {
                sqlserver.LimparParametros();
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoCor",cor.codigoCor));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@nomeCor",cor.nomeCor));

                string comando = "exec uspAlterarCor @codigoCor,@nomeCor";
                object resposta = sqlserver.ExecutarScalar(comando, System.Data.CommandType.Text);

                if (Convert.ToInt32(resposta) == 2)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex) {
                return false;
                throw new Exception("Erro na camada de negócios Alterar Cor "+ex.Message); 
            }
        }

        //Excluir cor
        public Boolean ExcluirCor(Cor cor)
        {
            try
            {

                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigo", cor.codigoCor));

                string comando = "exec uspExcluirCor @codigo";

                object Resposta = sqlserver.ExecutarScalar(comando, System.Data.CommandType.Text);

                if (Convert.ToInt16(Resposta) == 1)
                {
                    return false;//Caso estiver vinculado tabela Produto cor
                }
                else
                    return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Erro na camada de negócios - Exclusão. " + ex.Message);
            }
        }

        //--------------------------Consultas

        public CorLista BuscarCorPorNome(String nomeCor) {
            try {
                sqlserver.LimparParametros();
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@nome",nomeCor));

                CorLista listaCor = new CorLista();
                Cor cor = new Cor();
                DataTable tabelaResultado;

                string comando = "exec uspBuscarCorPorNome @nome";
                tabelaResultado = sqlserver.ExecutarConsulta(comando, CommandType.Text);

                foreach (DataRow registro in tabelaResultado.Rows)
                { 
                  cor = new Cor();
                  cor.codigoCor = Convert.ToInt32(registro[0]);
                  cor.nomeCor = registro[1].ToString();
                  listaCor.Add(cor);
                }
                return listaCor;
            
            }
            catch (Exception ex) { throw new Exception("Erro na camada de negócios Buscar Cor Por Nome "+ex.Message); }
        }

        public CorLista BuscarCorProdutoPorNome(int codigoProduto,String nomeCor)
        {
            try
            {
                sqlserver.LimparParametros();
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoProduto", codigoProduto));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@nomeCor", nomeCor));

                CorLista listaCor = new CorLista();
                Cor cor = new Cor();
                DataTable tabelaResultado;

                string comando = "exec uspBuscarCorProdutoPorNomeCor @codigoProduto, @nomeCor";
                tabelaResultado = sqlserver.ExecutarConsulta(comando, CommandType.Text);

                foreach (DataRow registro in tabelaResultado.Rows)
                {
                    cor = new Cor();
                    cor.codigoCor = Convert.ToInt32(registro[0]);
                    cor.nomeCor = registro[1].ToString();
                    listaCor.Add(cor);
                }
                return listaCor;

            }
            catch (Exception ex) { throw new Exception("Erro na camada de negócios Buscar Cor Por Nome " + ex.Message); }
        }

        //realiza a validação se ja a o produto cadastrado de acordo com a referencia
        public Cor ValidarCadastroCor(String strCor)
        {
            try
            {
                DataTable tabelaRetorno;
                Cor cor;

                this.sqlserver.LimparParametros();
                this.sqlserver.AdicionarParametro(new SqlParameter("@cor", strCor));

                string comando = "exec uspValidaCadastroCor @cor";

                tabelaRetorno = this.sqlserver.ExecutarConsulta(comando, CommandType.Text);
                if (tabelaRetorno.Rows.Count > 0)
                {
                    DataRow registro = tabelaRetorno.Rows[0];//Consulta só retorna uma objeto

                    cor = new Cor();

                    cor.codigoCor = Convert.ToInt32(registro[0]);
                    cor.nomeCor = (registro[1].ToString());

                    return cor;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível validar a cor. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //metodo para buscar Cor por Codigo
        public Cor BuscarCorPorCodigo(int codigo)
        {
            this.sqlserver.LimparParametros();
            this.sqlserver.AdicionarParametro(new SqlParameter("@codigoCor", codigo));
            string comandoSql = "exec uspBuscarCorPorCodigo @codigoCor";

            DataTable tabelaRetorno = this.sqlserver.ExecutarConsulta(comandoSql, CommandType.Text);


            if (tabelaRetorno.Rows.Count > 0)
            {
                Cor cor = new Cor();
                DataRow registro = tabelaRetorno.Rows[0];


                cor.codigoCor = Convert.ToInt32(registro[0]);
                cor.nomeCor = registro[1].ToString();

                return cor;
            }
            else
                return null;

        }
        //--------------------------Tabela Temporária

        //Tabela temporária de cores
        public CorLista BuscarCorTempPorNome(String nomeCor, int ordem)
        {
            try
            {
                sqlserver.LimparParametros();
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@nome", nomeCor));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@ordem", ordem));

                CorLista listaCor = new CorLista();
                Cor cor = new Cor();
                DataTable tabelaResultado;

                string comando = "exec uspBuscarCorTempPorNome @nome, @ordem";
                tabelaResultado = sqlserver.ExecutarConsulta(comando, CommandType.Text);

                foreach (DataRow registro in tabelaResultado.Rows)
                {
                    cor = new Cor();
                    cor.codigoCor = Convert.ToInt32(registro[0]);
                    cor.nomeCor = registro[1].ToString();
                    listaCor.Add(cor);
                }
                return listaCor;

            }
            catch (Exception ex) { throw new Exception("Erro na camada de negócios Buscar Cor Por Nome " + ex.Message); }
        }

        //metodo para buscar produto por nome
        public CorLista BuscarCorTemp(int ordem)
        {
            try
            {
                sqlserver.LimparParametros();
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@ordem", ordem));

                CorLista listaCor = new CorLista();
                Cor cor = new Cor();
                DataTable tabelaResultado;

                string comando = "exec uspBuscarCorTemp @ordem";
                tabelaResultado = sqlserver.ExecutarConsulta(comando, CommandType.Text);

                foreach (DataRow registro in tabelaResultado.Rows)
                {
                    cor = new Cor();
                    cor.codigoCor = Convert.ToInt32(registro[0]);
                    cor.nomeCor = registro[1].ToString();
                    cor.ordemCor = Convert.ToInt32(registro[2]);

                    listaCor.Add(cor);
                }
                return listaCor;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro na camada de negócios Buscar Cor " + ex.Message);
            }
        }

        //Cadastra cor Temporária
        public Boolean CadastrarCorTemp(Cor cor)
        {
            try
            {
                sqlserver.LimparParametros();
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoCor", cor.codigoCor));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@nomeCor", cor.nomeCor));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@ordem", cor.ordemCor));

                string comando = "exec uspCadastrarCorTemp @codigoCor, @nomeCor, @ordem";

                object Resposta = sqlserver.ExecutarScalar(comando, System.Data.CommandType.Text);
                if (Convert.ToInt16(Resposta) == 2)
                {
                    return false;//Erro ao cadastrar cor
                }
                else
                    return true;

            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Erro na camada de negócios. Cadastro de Cor " + ex.Message);
            }
        }

        //Excluir cor Temporária
        public Boolean ExcluirCorTemp(Cor cor)
        {
            try
            {
                sqlserver.LimparParametros();
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigo", cor.codigoCor));

                string comando = "exec uspExcluirCorTemp @codigo";

                object Resposta = sqlserver.ExecutarScalar(comando, System.Data.CommandType.Text);

                if (Convert.ToInt16(Resposta) == 1)
                {
                    return false;//Caso estiver vinculado tabela Produto cor
                }
                else
                    return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Erro na camada de negócios - Exclusão. " + ex.Message);
            }
        }

        //metodo para zerar a venda temporaria
        public void ExcluirDadosTabelaTemporaria(int ordem)
        {
            try
            {
                sqlserver.LimparParametros();
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@ordem", ordem));
                string comando = " exec uspLimparTabelaCorTemp @ordem";

                sqlserver.ExecutarScalar(comando, System.Data.CommandType.Text);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro na camada de negócios - Retorno. " + ex.Message);

            }
        }

        //Buscar e retornar ultimo registro do sqlServer
        public int BuscarUltimoRegistroCor()
        {
            try
            {
                string comando = " exec uspCorUltimoRegistro ";

                object Resposta = sqlserver.ExecutarScalar(comando, System.Data.CommandType.Text);

                return Convert.ToInt16(Resposta);

            }
            catch (Exception ex)
            {
                //caso não houver nenhum registro retorna 1 para o primeiro cadastro
                return 1;
                throw new Exception("Erro na camada de negócios - Retorno. " + ex.Message);

            }
        }
    }
}
