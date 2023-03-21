using AcessoDados;
using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
  public class NegDespesa
    {

      //----------------------------------------------Tabela temporária
        ConexaoSqlServer sqlserver = new ConexaoSqlServer();

        //Cadastra despesa temporaria
        public Boolean CadastrarDespesaTemp(DespesaCaixa despesa)
        {
            try
            {
                sqlserver.LimparParametros();
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@descricaoDespesa", despesa.descricaoDespesa));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@funcionario", despesa.funcionario.codigoFuncionario));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@formaPagamento", despesa.formaPagamento.codigoFormaPagamento));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@valorDespesa", despesa.valorDespesa));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@dataDespesa", despesa.dataDespesa));



                string comando = "exec uspCadastrarDespesaTemporaria @descricaoDespesa, @funcionario, @formaPagamento, @valorDespesa, @dataDespesa";

                object Resposta = sqlserver.ExecutarScalar(comando, System.Data.CommandType.Text);
                if (Convert.ToInt16(Resposta) == 2)
                {
                    return false;//Erro ao cadastrar Despesa
                }
                else
                    return true;

            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Erro na camada de negócios. Cadastro de Despesa " + ex.Message);
            }
        }

        //Alterar despesa temporaria
        public Boolean AtualizarDespesaTemp(DespesaCaixa despesa)
        {
            try
            {
                sqlserver.LimparParametros();
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoDespesa", despesa.codigoDespesa));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@descricaoDespesa", despesa.descricaoDespesa));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@funcionario", despesa.funcionario.codigoFuncionario));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@formaPagamento", despesa.formaPagamento.codigoFormaPagamento));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@valorDespesa", despesa.valorDespesa));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@dataDespesa", despesa.dataDespesa));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@statusDespesa", despesa.statusDespesa));

                string comando = "exec uspAlterarDespesaTemporaria @codigoDespesa, @descricaoDespesa, @funcionario, @formaPagamento, @valorDespesa, @dataDespesa, @statusDespesa";
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
            catch (Exception ex)
            {
                return false;
                throw new Exception("Erro na camada de negócios Alterar Despesa " + ex.Message);
            }
        }

        //Excluir despesa temporaria
        public Boolean ExcluirDespesaTemp(DespesaCaixa despesa)
        {
            try
            {

                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigo", despesa.codigoDespesa));

                string comando = "exec uspExcluirDespesaTemporariaPorCodigo @codigo";

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

        //Excluir despesa por Data - Limpa lançamentos feitos na data da tabela temporaria
        public Boolean ExcluirDespesaTempPorData(DateTime dataCaixa)
        {
            try
            {

                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@dataDespesa", dataCaixa));

                string comando = "exec uspExcluirDespesaTemporariaPorData @dataDespesa";

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
                throw new Exception("Erro na camada de negócios - Exclusão Por Data. " + ex.Message);
            }
        }

      //Buscar despesa temporária por Data
        public ListaDespesas BuscarDespesaPorData(DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                sqlserver.LimparParametros();
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@dataInicial", dataInicial));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@dataFinal", dataFinal));

                ListaDespesas listaDespesa = new ListaDespesas();
                DespesaCaixa despesa = new DespesaCaixa();
                DataTable tabelaResultado;

                string comando = "exec uspBuscarDespesaTemporariaPorData @dataInicial, @dataFinal";
                tabelaResultado = sqlserver.ExecutarConsulta(comando, CommandType.Text);

                foreach (DataRow registro in tabelaResultado.Rows)
                {
                    despesa = new DespesaCaixa();
                    despesa.formaPagamento = new FormaPagamento();
                    despesa.funcionario = new Funcionario();

                    despesa.codigoDespesa = Convert.ToInt32(registro[0]);
                    despesa.descricaoDespesa = registro[1].ToString();
                    despesa.funcionario.codigoFuncionario = Convert.ToInt32(registro[2]);
                    despesa.funcionario.nomeFuncionario = (registro[3].ToString());
                    despesa.formaPagamento.codigoFormaPagamento = Convert.ToInt32(registro[4]);
                    despesa.formaPagamento.formaPagamento = registro[5].ToString();
                    despesa.valorDespesa = Convert.ToDouble(registro[6]);
                    despesa.dataDespesa = Convert.ToDateTime(registro[7]);
                    despesa.statusDespesa = (registro[8]).ToString();

                    listaDespesa.Add(despesa);
                }
                return listaDespesa;

            }
            catch (Exception ex) { throw new Exception("Erro na camada de negócios Buscar Despesa Por Data " + ex.Message); }
        }

        //[uspBuscarDespesaTemporariaPorNome]
        public ListaDespesas BuscarDespesaPorDescricao(string nomeDespesa)
        {
            try
            {
                sqlserver.LimparParametros();
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@descricao", nomeDespesa));

                ListaDespesas listaDespesa = new ListaDespesas();
                DespesaCaixa despesa = new DespesaCaixa();
                DataTable tabelaResultado;

                string comando = "exec uspBuscarDespesaTemporariaPorNome @descricao";
                tabelaResultado = sqlserver.ExecutarConsulta(comando, CommandType.Text);

                foreach (DataRow registro in tabelaResultado.Rows)
                {
                    despesa = new DespesaCaixa();
                    despesa.formaPagamento = new FormaPagamento();
                    despesa.funcionario = new Funcionario();

                    despesa.codigoDespesa = Convert.ToInt32(registro[0]);
                    despesa.descricaoDespesa = registro[1].ToString();
                    despesa.funcionario.codigoFuncionario = Convert.ToInt32(registro[2]);
                    despesa.funcionario.nomeFuncionario = (registro[3].ToString());
                    despesa.formaPagamento.codigoFormaPagamento = Convert.ToInt32(registro[4]);
                    despesa.formaPagamento.formaPagamento = registro[5].ToString();
                    despesa.valorDespesa = Convert.ToDouble(registro[6]);
                    despesa.dataDespesa = Convert.ToDateTime(registro[7]);
                    despesa.statusDespesa = (registro[8]).ToString();

                    listaDespesa.Add(despesa);
                }
                return listaDespesa;

            }
            catch (Exception ex) { throw new Exception("Erro na camada de negócios Buscar Despesa Por Nome " + ex.Message); }
        }

      //---------------------------------Cancelamento Validações
      //Retorna se há alguma despesa na data
      public Boolean BuscarCancelamentoDespesaPorData(DateTime data)
        {
            try
            {
                sqlserver.LimparParametros();
                sqlserver.AdicionarParametro(new SqlParameter("@data", data));

                string comandoSql = "exec uspValidaCancelamentoDespesaPorData @data";

                DataTable tabelaRetorno = this.sqlserver.ExecutarConsulta(comandoSql, CommandType.Text);
                DespesaCaixa despesa;


                tabelaRetorno = this.sqlserver.ExecutarConsulta(comandoSql, CommandType.Text);

                if (tabelaRetorno.Rows.Count > 0)
                {
                    DataRow registro = tabelaRetorno.Rows[0];//Consulta só retorna uma objeto

                    despesa = new DespesaCaixa();
                    despesa.formaPagamento = new FormaPagamento();

                    despesa.valorDespesa = Convert.ToDouble(registro[0]); //Valor restante Caixa
                    despesa.formaPagamento.codigoFormaPagamento = Convert.ToInt32(registro[1]);
                    despesa.formaPagamento.formaPagamento = (registro[2].ToString());


                    return true;
                }
                else
                    return false;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar dados da Despesa. [Negócios]. Motivo: " + ex.Message);
            }

        }

      //Verifica se há necessidade de cancelar a despesa
      public DespesaCaixa BuscarCancelamentoDespesa(DateTime data, int codigoPagamento)
      {
          try
          {
              sqlserver.LimparParametros();
              sqlserver.AdicionarParametro(new SqlParameter("@data", data));
              sqlserver.AdicionarParametro(new SqlParameter("@pagamento", codigoPagamento));

              string comandoSql = "exec uspValidaCancelamentoDespesaVenda @data, @pagamento";

              DataTable tabelaRetorno = this.sqlserver.ExecutarConsulta(comandoSql, CommandType.Text);
              DespesaCaixa despesa;


              tabelaRetorno = this.sqlserver.ExecutarConsulta(comandoSql, CommandType.Text);

              if (tabelaRetorno.Rows.Count > 0)
              {
                  DataRow registro = tabelaRetorno.Rows[0];//Consulta só retorna uma objeto

                  despesa = new DespesaCaixa();
                  despesa.formaPagamento = new FormaPagamento();

                  despesa.valorDespesa = Convert.ToDouble(registro[0]); //Valor restante Caixa
                  despesa.formaPagamento.codigoFormaPagamento = Convert.ToInt32(registro[1]);
                  despesa.formaPagamento.formaPagamento = (registro[2].ToString());


                  return despesa;
              }
              else
                  return null;

          }
          catch (Exception ex)
          {
              throw new Exception("Não foi possível buscar dados da Sangria. [Negócios]. Motivo: " + ex.Message);
          }

      }

    }
}
