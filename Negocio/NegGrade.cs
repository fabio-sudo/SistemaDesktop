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
  public class NegGrade
    {

        private ConexaoSqlServer sqlServer = new ConexaoSqlServer();

        //Metodo para cadastrar produto
        public Boolean CadastrarGrade(Grade grade)
        {
            try
            {
                sqlServer.LimparParametros();

                sqlServer.AdicionarParametro(new SqlParameter("@nomeGrade", grade.nomeGrade));

                string comandoSql = "exec uspCadastrarGrade @nomeGrade";

                sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível cadastrar o Grade. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //metodo para alterar produto
        public Boolean AtualizarGrade(Grade grade)
        {
            try
            {

                sqlServer.LimparParametros();



                sqlServer.AdicionarParametro(new SqlParameter("@codigoGrade", grade.codigoGrade));
                sqlServer.AdicionarParametro(new SqlParameter("@nomeGrade", grade.nomeGrade));

                string comandoSql = "exec uspAlterarGrade @codigoGrade, @nomeGrade";

                sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível alterar os dados do Grade. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //metodo excluir genero
        public Boolean ExcluirGrade(Grade grade)
        {
            try
            {

                sqlServer.LimparParametros();

                sqlServer.AdicionarParametro(new SqlParameter("@codigo", grade.codigoGrade));

                string comandoSql = "exec uspExcluirGrade @codigo";

                object Resposta = sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                if (Convert.ToInt16(Resposta) == 1)
                {
                    return false;//grade está vinculado a tabela produto
                }
                else if (Convert.ToInt16(Resposta) == 2)
                {
                    return false;//grade está vinculado a tabela tamanho

                }

                else
                {
                    return true;//caso não haja vinculação com nenhuma tabela 
                }
                }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível excluir os dados do Grade. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //----------------------------------Consulta
        
        //Busca Grade Produto por nome da Grade
        public GradeLista BuscarGradePorNome(string nome)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@nomeGrade", nome));
            string comandoSql = "exec uspBuscarGradePorNome @nomeGrade";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

            GradeLista grades = new GradeLista();
            Grade grade;

            foreach (DataRow registro in tabelaRetorno.Rows)
            {
                grade = new Grade();

                grade.codigoGrade = Convert.ToInt32(registro[0]);
                grade.nomeGrade = registro[1].ToString();

                grades.Add(grade);
            }

            return grades;
        }

        //Busca Grade Produto por nome da Grade
        public Grade BuscarGradePorCodigo(int codigo)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@codigo", codigo));
            string comandoSql = "exec uspBuscarGradePorCodigo @codigo";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

            if (tabelaRetorno.Rows.Count > 0)
            {
                DataRow registro = tabelaRetorno.Rows[0];
                Grade grade = new Grade();

                grade.codigoGrade = Convert.ToInt32(registro[0]);
                grade.nomeGrade = registro[1].ToString();

                return grade;
            }
            else
                return null;
        }

        //Valida cadastro Grade
        public Grade ValidarCadastroGrade(String strGrade)
        {
            try
            {
                DataTable tabelaRetorno;
                Grade grade;

                this.sqlServer.LimparParametros();
                this.sqlServer.AdicionarParametro(new SqlParameter("@grade", strGrade));

                string comando = "exec uspValidaCadastroGrade @grade";

                tabelaRetorno = this.sqlServer.ExecutarConsulta(comando, CommandType.Text);
                if (tabelaRetorno.Rows.Count > 0)
                {
                    DataRow registro = tabelaRetorno.Rows[0];//Consulta só retorna uma objeto

                    grade = new Grade();

                    grade.codigoGrade = Convert.ToInt32(registro[0]);
                    grade.nomeGrade = (registro[1].ToString());

                    return grade;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível validar o grade. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Buscar e retornar ultimo registro do sqlServer
        public int BuscarUltimoRegistroGrade()
        {
            try
            {
                string comando = " exec uspGradeUltimoRegistro ";

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

      //--------------------------------------GradeTamanho

        //Metodo para cadastrar produto
        public Boolean CadastrarGradeTamanho(Grade grade, Tamanho tamanho)
        {
            try
            {
                sqlServer.LimparParametros();

                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@codigoGrade", grade.codigoGrade));
                sqlServer.AdicionarParametro(new SqlParameter("@codigoTamanho", tamanho.codigoTamanho));

                string comandoSql = "exec uspCadastrarGradeTamanho @codigoGrade, @codigoTamanho";

                sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível cadastrar o Tamanho na Grade. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Cadastrar Tamanhos na Grade LISTA
        public Boolean CadastrarGradeTamanhoLista(Grade grade, TamanhoLista tamanhoLista)
        {
            try
            {
                foreach (Tamanho tamanho in tamanhoLista)
                {

                    sqlServer.LimparParametros();

                    sqlServer.LimparParametros();
                    sqlServer.AdicionarParametro(new SqlParameter("@codigoGrade", grade.codigoGrade));
                    sqlServer.AdicionarParametro(new SqlParameter("@codigoTamanho", tamanho.codigoTamanho));

                    string comandoSql = "exec uspCadastrarGradeTamanho @codigoGrade, @codigoTamanho";

                    sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível Cadastrar os Tamanhos na Grade. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //metodo excluir Tamanhos da Grade
        public Boolean ExcluirGradeTamanho(Grade grade, Tamanho tamanho)
        {
            try
            {

                sqlServer.LimparParametros();

                sqlServer.AdicionarParametro(new SqlParameter("@codigoGrade", grade.codigoGrade));
                sqlServer.AdicionarParametro(new SqlParameter("@codigoTamanho", tamanho.codigoTamanho));

                string comandoSql = "exec uspExcluirGradeTamanho @codigoGrade, @codigoTamanho";

                object Resposta = sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                if (Convert.ToInt16(Resposta) == 1)
                {
                    return false;//grade e tamanhos está vinculado a tabela produto
                }
                else
                {
                    return true;//caso não haja vinculação com nenhuma tabela 
                }
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível excluir os dados do Grade. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //metodo excluir Todos os Tamanhos da Grade
        public Boolean ExcluirGradeTamanhoTodos(Grade grade)
        {
            try
            {

                sqlServer.LimparParametros();

                sqlServer.AdicionarParametro(new SqlParameter("@codigoGrade", grade.codigoGrade));

                string comandoSql = "exec uspExcluirGradeTamanhoTodos @codigoGrade";

                object Resposta = sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                if (Convert.ToInt16(Resposta) == 1)
                {
                    return false;//grade e tamanhos está vinculado a tabela produto
                }
                else
                {
                    return true;//caso não haja vinculação com nenhuma tabela 
                }
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível excluir os dados do Grade. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //metodo excluir Todos os Tamanhos da Grade
        public Boolean ExcluirGradeTamanhoDesfazer(Grade grade)
        {
            try
            {

                sqlServer.LimparParametros();

                sqlServer.AdicionarParametro(new SqlParameter("@codigoGrade", grade.codigoGrade));

                string comandoSql = "exec uspExcluirGradeTamanhoDesfazer @codigoGrade";

                object Resposta = sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                if (Convert.ToInt16(Resposta) == 1)
                {
                    return false;//grade e tamanhos está vinculado a tabela produto
                }
                else
                {
                    return true;//caso não haja vinculação com nenhuma tabela 
                }
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível excluir os dados do Grade. [Negócios]. Motivo: " + ex.Message);
            }
        }

      //-----------------------------------------Validação
      //uspValidaExclusaoGrade
      //Verifica se grade está vinculada a produto
        public Produto ValidaExclusaoGrade(int codigo)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@codigo", codigo));
            string comandoSql = "exec uspValidaExclusaoGrade @codigo";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

            if (tabelaRetorno.Rows.Count > 0)
            {
                DataRow registro = tabelaRetorno.Rows[0];
                Produto grade = new Produto();

                grade.codigoProduto = Convert.ToInt32(registro[0]);
                grade.descricaoProduto = registro[1].ToString();
                grade.referenciaProduto = registro[2].ToString();
                return grade;
            }
            else
                return null;
        }
    }
}
