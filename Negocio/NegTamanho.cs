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
   public class NegTamanho
    {
        private ConexaoSqlServer sqlServer = new ConexaoSqlServer();

        //Metodo para cadastrar produto
        public Boolean CadastrarTamanho(Tamanho tamanho)
        {
            try
            {
                sqlServer.LimparParametros();

                sqlServer.AdicionarParametro(new SqlParameter("@nomeTamanho", tamanho.nometamanho));


                string comandoSql = "exec uspCadastrarTamanho @nomeTamanho";

                sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível cadastrar o tamanho. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //metodo para alterar produto
        public Boolean AtualizarTamanho(Tamanho tamanho)
        {
            try
            {

                sqlServer.LimparParametros();



                sqlServer.AdicionarParametro(new SqlParameter("@codigoTamanho", tamanho.codigoTamanho));
                sqlServer.AdicionarParametro(new SqlParameter("@nomeTamanho", tamanho.nometamanho));

                string comandoSql = "exec uspAlterarTamanho @codigoTamanho, @nomeTamanho";

                sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível alterar os dados do Tamanho. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //metodo excluir genero
        public Boolean ExcluirTamanho(Tamanho tamanho)
        {
            try
            {

                sqlServer.LimparParametros();



                sqlServer.AdicionarParametro(new SqlParameter("@codigo", tamanho.codigoTamanho));

                string comandoSql = "exec uspExcluirTamanho @codigo";

                object Resposta = sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                if (Convert.ToInt16(Resposta) == 1 || Convert.ToInt16(Resposta) == 2)
                {
                    return false;//tamanho está vinculado com algum produto tabela GradeTamanho
                }
                else
                    return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível excluir os dados do tamanho. [Negócios]. Motivo: " + ex.Message);
            }
        }

       //----------------------------------Consulta
      
       //metodo para buscar produto por nome 
        public TamanhoLista BuscarTamanhoPorNome(string nome)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@nomeTamanho", nome));
            string comandoSql = "exec uspBuscarTamanhoPorNome @nomeTamanho";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

            TamanhoLista tamanhos = new TamanhoLista();
            Tamanho tamanho;

            foreach (DataRow registro in tabelaRetorno.Rows)
            {
                tamanho = new Tamanho();

                tamanho.codigoTamanho = Convert.ToInt32(registro[0]);
                tamanho.nometamanho = registro[1].ToString();

                tamanhos.Add(tamanho);
            }

            return tamanhos;
        }

        //metodo para buscar produto por nome 
        public TamanhoLista BuscarTamanhoPorNomeNaGrade(int codigoGrade,string nomeTamanho)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@codigoGrade", codigoGrade));
            this.sqlServer.AdicionarParametro(new SqlParameter("@nomeTamanho", nomeTamanho));
            string comandoSql = "exec uspBuscarTamanhoDaGradePorNome @codigoGrade, @nomeTamanho";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

            TamanhoLista tamanhos = new TamanhoLista();
            Tamanho tamanho;

            foreach (DataRow registro in tabelaRetorno.Rows)
            {
                tamanho = new Tamanho();

                tamanho.codigoTamanho = Convert.ToInt32(registro[0]);
                tamanho.nometamanho = registro[1].ToString();

                tamanhos.Add(tamanho);
            }

            return tamanhos;
        }
             
       //realiza a validação se ja a o produto cadastrado de acordo com a referencia
        public Tamanho ValidarCadastroTamanho(String strTamanho)
        {
            try
            {
                DataTable tabelaRetorno;
                Tamanho tamanho;

                this.sqlServer.LimparParametros();
                this.sqlServer.AdicionarParametro(new SqlParameter("@tamanho", strTamanho));

                string comando = "exec uspValidaCadastroTamanho @tamanho";

                tabelaRetorno = this.sqlServer.ExecutarConsulta(comando, CommandType.Text);
                if (tabelaRetorno.Rows.Count > 0)
                {
                    DataRow registro = tabelaRetorno.Rows[0];//Consulta só retorna uma objeto

                    tamanho = new Tamanho();

                    tamanho.codigoTamanho = Convert.ToInt32(registro[0]);
                    tamanho.nometamanho = (registro[1].ToString());

                    return tamanho;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível validar o tamanho. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //metodo para buscar Tamanho por Codigo
        public Tamanho BuscarTamanhoPorCodigo(int codigo)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@codigoTamanho", codigo));
            string comandoSql = "exec uspBuscarTamanhoPorCodigo @codigoTamanho";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);


            if (tabelaRetorno.Rows.Count > 0)
            {
                Tamanho tamanho = new Tamanho();
                DataRow registro = tabelaRetorno.Rows[0];


                tamanho.codigoTamanho = Convert.ToInt32(registro[0]);
                tamanho.nometamanho = registro[1].ToString();

                return tamanho;
            }
            else
                return null;

        }

       //---------------------------------Tamanho Temporário

        //Metodo para cadastrar produto
        public Boolean CadastrarTamanhoTemp(Tamanho tamanho)
        {
            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@codigoTamanho", tamanho.codigoTamanho));
                sqlServer.AdicionarParametro(new SqlParameter("@nomeTamanho", tamanho.nometamanho));
                sqlServer.AdicionarParametro(new SqlParameter("@ordemTamanho", tamanho.ordemtamanho));

                string comandoSql = "exec uspCadastrarTamanhoTemp @codigoTamanho, @nomeTamanho, @ordemTamanho";

                sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível cadastrar o tamanho. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //metodo excluir genero
        public Boolean ExcluirTamanhoTemp(Tamanho tamanho)
        {
            try
            {

                sqlServer.LimparParametros();



                sqlServer.AdicionarParametro(new SqlParameter("@codigo", tamanho.codigoTamanho));

                string comandoSql = "exec uspExcluirTamanhoTemp @codigo";

                object Resposta = sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                if (Convert.ToInt16(Resposta) == 1 || Convert.ToInt16(Resposta) == 2)
                {
                    return false;//tamanho está vinculado com algum produto
                }
                else
                    return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível excluir os dados do tamanho. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //metodo para zerar a venda temporaria
        public void ExcluirDadosTabelaTemporaria( int ordemTamanho)
        {
            try
            {
                sqlServer.LimparParametros();

                sqlServer.AdicionarParametro(new SqlParameter("@ordemTamanho", ordemTamanho));
                string comando = " exec uspLimparTabelaTamanhoTemp @ordemTamanho";

                sqlServer.ExecutarScalar(comando, System.Data.CommandType.Text);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro na camada de negócios - Retorno. " + ex.Message);

            }
        }

        //metodo para buscar produto por nome
        public TamanhoLista BuscarTamanhoTemp(int ordemTamanho)
        {
            sqlServer.LimparParametros();
            sqlServer.AdicionarParametro(new SqlParameter("@ordemTamanho", ordemTamanho));

            string comandoSql = "exec uspBuscarTamanhoTemp @ordemTamanho";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

            TamanhoLista tamanhos = new TamanhoLista();
            Tamanho tamanho;

            foreach (DataRow registro in tabelaRetorno.Rows)
            {
                tamanho = new Tamanho();

                tamanho.codigoTamanho = Convert.ToInt32(registro[0]);
                tamanho.nometamanho = registro[1].ToString();
                tamanho.ordemtamanho = Convert.ToInt32(registro[2]);

                tamanhos.Add(tamanho);
            }

            return tamanhos;
        }

        //metodo para buscar produto por nome -> Busca só tamanhos que não estão na tabela temporária
        public TamanhoLista BuscarTamanhoTempPorNome(string nome, int ordemTamanho)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@nomeTamanho", nome));
            this.sqlServer.AdicionarParametro(new SqlParameter("@ordemTamanho", ordemTamanho));

            string comandoSql = "exec uspBuscarTamanhoTempPorNome @nomeTamanho, @ordemTamanho";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

            TamanhoLista tamanhos = new TamanhoLista();
            Tamanho tamanho;

            foreach (DataRow registro in tabelaRetorno.Rows)
            {
                tamanho = new Tamanho();

                tamanho.codigoTamanho = Convert.ToInt32(registro[0]);
                tamanho.nometamanho = registro[1].ToString();
                tamanhos.Add(tamanho);
            }

            return tamanhos;
        }

        //Buscar e retornar ultimo registro do sqlServer
        public int BuscarUltimoRegistroTamanho()
        {
            try
            {
                string comando = " exec uspTamanhoUltimoRegistro ";

                object Resposta = sqlServer.ExecutarScalar(comando, System.Data.CommandType.Text);

                return Convert.ToInt16(Resposta);

            }
            catch (Exception ex)
            {
                //caso não houver nenhum registro retorna 1 para o primeiro cadastro
                return 1;
                throw new Exception("Erro na camada de negócios - Retorno. " + ex.Message);

            }
        }

       //--------------------------------GradeTamanho

        //metodo para buscar produto por nome -> Busca só tamanhos que não estão na tabela Grade Tamanho
        public TamanhoLista BuscarGradeTamanhoPorNome(string nomeTamanho, int codigoGrade)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@nomeTamanho", nomeTamanho));
            this.sqlServer.AdicionarParametro(new SqlParameter("@codigoGrade", codigoGrade));

            string comandoSql = "exec uspBuscarGradeTamanhoPorNome @nomeTamanho, @codigoGrade";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

            TamanhoLista tamanhos = new TamanhoLista();
            Tamanho tamanho;

            foreach (DataRow registro in tabelaRetorno.Rows)
            {
                tamanho = new Tamanho();

                tamanho.codigoTamanho = Convert.ToInt32(registro[0]);
                tamanho.nometamanho = registro[1].ToString();

                tamanhos.Add(tamanho);
            }

            return tamanhos;
        }

        //Buscar Tamanhos que estão na Grade
        public TamanhoLista BuscarGradeTamanhoPorCodigo(int codigoGrade)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@codigoGrade", codigoGrade));
            string comandoSql = "exec uspBuscarGradeTamanhoPorCodigo @codigoGrade";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

            TamanhoLista tamanhos = new TamanhoLista();
            Tamanho tamanho;

            foreach (DataRow registro in tabelaRetorno.Rows)
            {
                tamanho = new Tamanho();

                tamanho.codigoTamanho = Convert.ToInt32(registro[0]);
                tamanho.nometamanho = registro[1].ToString();

                tamanhos.Add(tamanho);
            }

            return tamanhos;
        }

    }
}
