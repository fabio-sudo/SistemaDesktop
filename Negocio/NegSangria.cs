using AcessoDados;
using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Negocio
{
   public class NegSangria
    {

        ConexaoSqlServer sqlServer = new ConexaoSqlServer();

        //Cadastrar -> Cadastra sangria para cada retirada de valor do caixa Lista cada um tipo de valor retirado
        public Boolean CadastrarSangria(SangriaLista Listasangria)
        {
            try
            {
                foreach (Sangria sangria in Listasangria)
                {
                    sqlServer.LimparParametros();

                    sqlServer.AdicionarParametro(new SqlParameter("@sangriaCaixa", sangria.valorSangria));
                    sqlServer.AdicionarParametro(new SqlParameter("@codigoFuncionario", sangria.funcionarioSangria.codigoFuncionario));
                    sqlServer.AdicionarParametro(new SqlParameter("@codigoFormaPagamento", sangria.pagamentoSangria.codigoFormaPagamento));
                    sqlServer.AdicionarParametro(new SqlParameter("@dataSangria", sangria.dataSangria));
                    sqlServer.AdicionarParametro(new SqlParameter("@ordemSangria", sangria.ordemSangra));

                    string comandoSql = "exec uspCadastrarSangria @sangriaCaixa, @codigoFuncionario, @codigoFormaPagamento, @dataSangria, @ordemSangria";

                    sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível cadastrar a Sangria. [Negócios]. Motivo: " + ex.Message);
            }
        }

        public Boolean AlterarSangria(SangriaLista Listasangria)
        {
            try
            {
                foreach (Sangria sangria in Listasangria)
                {
                    sqlServer.LimparParametros();

                    sqlServer.AdicionarParametro(new SqlParameter("@sangriaCaixa", sangria.valorSangria));
                    sqlServer.AdicionarParametro(new SqlParameter("@codigoFuncionario", sangria.funcionarioSangria.codigoFuncionario));
                    sqlServer.AdicionarParametro(new SqlParameter("@codigoFormaPagamento", sangria.pagamentoSangria.codigoFormaPagamento));
                    sqlServer.AdicionarParametro(new SqlParameter("@dataSangria", sangria.dataSangria));
                    sqlServer.AdicionarParametro(new SqlParameter("@ordemSangria", sangria.ordemSangra));

                    string comandoSql = "exec uspAlterarSangria @sangriaCaixa, @codigoFuncionario, @codigoFormaPagamento, @dataSangria, @ordemSangria";

                    sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível alterar a Sangria. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Excluir Sangria
        public Boolean ExcluirSangria(SangriaLista Listasangria, int codigoFuncionario, int ordemSangria)
        {
            try
            {

                foreach (Sangria item in Listasangria)
                {

                    sqlServer.LimparParametros();
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@ordem", ordemSangria));
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@data", item.dataSangria));
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoFuncionario", codigoFuncionario));
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@formaPagamento", item.pagamentoSangria.codigoFormaPagamento));

                    string comando = "exec uspExcluirSangria @ordem, @data, @codigoFuncionario, @formaPagamento ";

                    sqlServer.ExecutarScalar(comando, System.Data.CommandType.Text);

                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Erro na camada de negócios Sangria  - Exclusão. " + ex.Message);
            }
        }


        //Excluir Sangria Cancelamento
        public Boolean ExcluirSangriaCancelamento(SangriaLista Listasangria)
        {
            try
            {

                foreach (Sangria item in Listasangria)
                {

                    sqlServer.LimparParametros();
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@ordem", item.ordemSangra));
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@data", item.dataSangria));
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoFuncionario", item.funcionarioSangria.codigoFuncionario));
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@formaPagamento", item.pagamentoSangria.codigoFormaPagamento));

                    string comando = "exec uspExcluirSangria @ordem, @data, @codigoFuncionario, @formaPagamento ";

                    sqlServer.ExecutarScalar(comando, System.Data.CommandType.Text);

                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Erro na camada de negócios Sangria  - Exclusão. " + ex.Message);
            }
        }

       //---------------------------Consultas
        //CADASTRO
        //Busca os valores que tem movimentação no caixa para realizar o cadastro da sangria
        public SangriaLista BuscarSangriaValores(DateTime data)
        {
            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@data",data));

                string comandoSql = "exec uspBuscarSangriaValores @data";

                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

                SangriaLista listaSangria = new SangriaLista();
                Sangria sangria;

                foreach (DataRow registro in tabelaRetorno.Rows)
                {

                    sangria = new Sangria();
                    sangria.funcionarioSangria = new Funcionario();
                    sangria.pagamentoSangria = new FormaPagamento();

                    sangria.valorSangria = Convert.ToDouble(registro[0]);
                    sangria.JurosItem = Convert.ToDouble(registro[1]);
                    sangria.descontoItem = Convert.ToDouble(registro[2]);

                    sangria.pagamentoSangria.codigoFormaPagamento = Convert.ToInt32(registro[3]);
                    sangria.pagamentoSangria.formaPagamento = (registro[4]).ToString();
                    sangria.dataSangria = Convert.ToDateTime(registro[5]);
                    sangria.estatusSangria = (registro[6]).ToString();

                    listaSangria.Add(sangria);
                }
                return listaSangria;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar dados da Sangria. [Negócios]. Motivo: " + ex.Message);
            }

        }

        //Buscar Valores que já foram lançados na sangria no caso de nova retirada
        public SangriaLista BuscarSangriaRetirada(DateTime data)
        {
            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@data", data));

                string comandoSql = "exec uspBuscarSangriaRetirada @data";

                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

                SangriaLista listaSangria = new SangriaLista();
                Sangria sangria;

                foreach (DataRow registro in tabelaRetorno.Rows)
                {

                    sangria = new Sangria();
                    sangria.pagamentoSangria = new FormaPagamento();

                    sangria.valorSangria = Convert.ToDouble(registro[0]);
                    sangria.pagamentoSangria.codigoFormaPagamento = Convert.ToInt32(registro[1]);
                    sangria.pagamentoSangria.formaPagamento = (registro[2]).ToString();
                    sangria.ordemSangra = Convert.ToInt32(registro[3])+1;

                    listaSangria.Add(sangria);
                }
                return listaSangria;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar dados da Sangria. [Negócios]. Motivo: " + ex.Message);
            }

        }

        //SELEÇÃO
        //Busca sangria por DATA
        public SangriaLista BuscarPagamentoSangriaPorData(DateTime dataInicial, DateTime dataFinal, string nomeFuncionarioData)
        {
            try
            {
                sqlServer.LimparParametros();

                sqlServer.AdicionarParametro(new SqlParameter("@dataInicial",dataInicial));
                sqlServer.AdicionarParametro(new SqlParameter("@dataFinal", dataFinal));
                sqlServer.AdicionarParametro(new SqlParameter("@nomeFuncionario", nomeFuncionarioData));

                string comandoSql = "exec uspBuscarSangriaPagamentoPorData @dataInicial, @dataFinal, @nomeFuncionario";

                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

                SangriaLista listaSangria = new SangriaLista();
                Sangria sangria;

                if (tabelaRetorno.Rows.Count > 0)
                {

                    foreach (DataRow registro in tabelaRetorno.Rows)
                    {
                        sangria = new Sangria();
                        sangria.funcionarioSangria = new Funcionario();
                        sangria.pagamentoSangria = new FormaPagamento();

                        sangria.codigoSangria = Convert.ToInt32(registro[0]);
                        sangria.ordemSangra = Convert.ToInt32(registro[1]);
                        sangria.dataSangria = Convert.ToDateTime(registro[2]);

                        sangria.valorSangria = Convert.ToDouble(registro[3]);

                        sangria.pagamentoSangria.codigoFormaPagamento = Convert.ToInt32(registro[4]);
                        sangria.pagamentoSangria.formaPagamento = (registro[5]).ToString();

                        sangria.funcionarioSangria.codigoFuncionario = Convert.ToInt32(registro[6]);
                        sangria.funcionarioSangria.nomeFuncionario = (registro[7]).ToString();

                        sangria.estatusSangria = (registro[8]).ToString();

                        listaSangria.Add(sangria);
                    }
                    return listaSangria;
                }
                else { return null; }
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar dados da Sangria. [Negócios]. Motivo: " + ex.Message);
            }

        }

        public SangriaLista BuscarSangriaPorData(DateTime dataInicial, DateTime dataFinal, string nomeFuncionario)
        {
            try
            {
                sqlServer.LimparParametros();

                sqlServer.AdicionarParametro(new SqlParameter("@dataInicial", dataInicial));
                sqlServer.AdicionarParametro(new SqlParameter("@dataFinal", dataFinal));
                sqlServer.AdicionarParametro(new SqlParameter("@nomeFuncionario", nomeFuncionario));

                string comandoSql = "exec uspBuscarSangriaPorData @dataInicial, @dataFinal, @nomeFuncionario";

                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

                SangriaLista listaSangria = new SangriaLista();
                Sangria sangria;

                if (tabelaRetorno.Rows.Count > 0)
                {
                    foreach (DataRow registro in tabelaRetorno.Rows)
                    {
                        sangria = new Sangria();
                        sangria.funcionarioSangria = new Funcionario();
                        sangria.pagamentoSangria = new FormaPagamento();

                        sangria.ordemSangra = Convert.ToInt32(registro[0]);
                        sangria.dataSangria = Convert.ToDateTime(registro[1]);

                        sangria.funcionarioSangria.codigoFuncionario = Convert.ToInt32(registro[2]);
                        sangria.funcionarioSangria.nomeFuncionario = (registro[3]).ToString();

                        sangria.estatusSangria = (registro[4]).ToString();

                        listaSangria.Add(sangria);
                    }
                    return listaSangria;
                }
                else { return null; }
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar dados da Sangria. [Negócios]. Motivo: " + ex.Message);
            }

        }

        public SangriaLista BuscarSangriaRealizada(int ordemSangria ,DateTime dataInicial, int codigoFuncionario)
        {
            try
            {
                sqlServer.LimparParametros();

                sqlServer.AdicionarParametro(new SqlParameter("@ordemSangria", ordemSangria));
                sqlServer.AdicionarParametro(new SqlParameter("@codigoFuncionario", codigoFuncionario));
                sqlServer.AdicionarParametro(new SqlParameter("@dataInicial", dataInicial));


                string comandoSql = "exec uspBuscarSangriaRealizada @ordemSangria, @codigoFuncionario, @dataInicial";

                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

                SangriaLista listaSangria = new SangriaLista();
                Sangria sangria;

                if (tabelaRetorno.Rows.Count > 0)
                {
                    foreach (DataRow registro in tabelaRetorno.Rows)
                    {
                        sangria = new Sangria();
                        sangria.funcionarioSangria = new Funcionario();
                        sangria.pagamentoSangria = new FormaPagamento();

                        sangria.ordemSangra = Convert.ToInt32(registro[0]);
                        sangria.funcionarioSangria.codigoFuncionario = Convert.ToInt32(registro[1]);
                        sangria.funcionarioSangria.nomeFuncionario = (registro[2]).ToString();
                        
                        sangria.valorSangria = Convert.ToDouble(registro[3]);
                        sangria.pagamentoSangria.codigoFormaPagamento = Convert.ToInt32(registro[4]);
                        sangria.pagamentoSangria.formaPagamento = (registro[5]).ToString();
                        
                        listaSangria.Add(sangria);
                    }
                    return listaSangria;
                }
                else { return null; }
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar dados da Sangria. [Negócios]. Motivo: " + ex.Message);
            }

        }
       
       //Validação Exclusão das Vendas

        public Boolean BuscarCancelamentoSangriaPorData(DateTime data)
        {
            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@data", data));

                string comandoSql = "exec uspValidaCancelamentoSangriaPorData @data";

                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);
                Sangria sangria;


                tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

                if (tabelaRetorno.Rows.Count > 0)
                {
                    DataRow registro = tabelaRetorno.Rows[0];//Consulta só retorna uma objeto

                    sangria = new Sangria();
                    sangria.pagamentoSangria = new FormaPagamento();

                    sangria.valorSangria = Convert.ToDouble(registro[0]); //Valor restante Caixa
                    sangria.pagamentoSangria.codigoFormaPagamento = Convert.ToInt32(registro[1]);
                    sangria.pagamentoSangria.formaPagamento = (registro[2].ToString());


                    return true;
                }
                else
                    return false;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar dados da Sangria. [Negócios]. Motivo: " + ex.Message);
            }

        }
       
        public Sangria BuscarCancelamentoSangria(DateTime data,int codigoPagamento)
        {
            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@data",data));
                sqlServer.AdicionarParametro(new SqlParameter("@pagamento", codigoPagamento));

                string comandoSql = "exec uspValidaCancelamentoSangriaVenda @data, @pagamento";

                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);
                Sangria sangria;


                tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);
                
                if (tabelaRetorno.Rows.Count > 0)
                {
                    DataRow registro = tabelaRetorno.Rows[0];//Consulta só retorna uma objeto

                    sangria = new Sangria();
                    sangria.pagamentoSangria = new FormaPagamento();

                    sangria.valorSangria = Convert.ToDouble(registro[0]); //Valor restante Caixa
                    sangria.pagamentoSangria.codigoFormaPagamento = Convert.ToInt32(registro[1]);
                    sangria.pagamentoSangria.formaPagamento = (registro[2].ToString());


                    return sangria;
                }
                else
                    return null;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar dados da Sangria. [Negócios]. Motivo: " + ex.Message);
            }

        }

        public Sangria BuscarCancelamentoSangriaCrediario(DateTime data, DateTime dataFinal, int codigoPagamento)
        {
            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@data", data));
                sqlServer.AdicionarParametro(new SqlParameter("@dataFinal", dataFinal));
                sqlServer.AdicionarParametro(new SqlParameter("@pagamento", codigoPagamento));

                string comandoSql = "exec uspValidaCancelamentoSangriaCrediario @data, @dataFinal, @pagamento";

                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);
                Sangria sangria;


                tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

                if (tabelaRetorno.Rows.Count > 0)
                {
                    DataRow registro = tabelaRetorno.Rows[0];//Consulta só retorna uma objeto

                    sangria = new Sangria();
                    sangria.pagamentoSangria = new FormaPagamento();

                    sangria.valorSangria = Convert.ToDouble(registro[0]); //Valor restante Caixa
                    sangria.pagamentoSangria.codigoFormaPagamento = Convert.ToInt32(registro[1]);
                    sangria.pagamentoSangria.formaPagamento = (registro[2].ToString());


                    return sangria;
                }
                else
                    return null;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar dados da Sangria. [Negócios]. Motivo: " + ex.Message);
            }

        }

        //Buscar Valores que já foram lançados na sangria no caso de nova retirada
        public SangriaLista BuscarSangriaParaCancelamento(DateTime data)
        {
            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@data", data));

                string comandoSql = "exec uspBuscarSangriaCancelamento @data";

                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

                SangriaLista listaSangria = new SangriaLista();
                Sangria sangria;

                foreach (DataRow registro in tabelaRetorno.Rows)
                {

                    sangria = new Sangria();
                    sangria.pagamentoSangria = new FormaPagamento();
                    sangria.funcionarioSangria = new Funcionario();

                    sangria.funcionarioSangria.codigoFuncionario = Convert.ToInt32(registro[0]);
                    sangria.funcionarioSangria.nomeFuncionario = (registro[1]).ToString();
                    sangria.funcionarioSangria.sobrenomeFuncionario = (registro[2]).ToString();
                    
                    sangria.ordemSangra = Convert.ToInt32(registro[3]);
                    sangria.valorSangria = Convert.ToDouble(registro[4]);
                    sangria.pagamentoSangria.codigoFormaPagamento = Convert.ToInt32(registro[5]);
                    sangria.pagamentoSangria.formaPagamento = (registro[6]).ToString();
                    sangria.estatusSangria = (registro[7]).ToString();
                    sangria.dataSangria = Convert.ToDateTime(registro[8]);

                    listaSangria.Add(sangria);
                }
                return listaSangria;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar dados da Sangria. [Negócios]. Motivo: " + ex.Message);
            }

        }

        //Buscar Valores que já foram lançados na sangria no caso de nova retirada
        public SangriaLista BuscarSangriaParaCancelamentoCrediario(DateTime data, DateTime dataFinal)
        {
            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@data", data));
                sqlServer.AdicionarParametro(new SqlParameter("@dataFinal", data));

                string comandoSql = "exec uspBuscarSangriaCancelamentoCrediario @data, @dataFinal";

                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

                SangriaLista listaSangria = new SangriaLista();
                Sangria sangria;

                foreach (DataRow registro in tabelaRetorno.Rows)
                {

                    sangria = new Sangria();
                    sangria.pagamentoSangria = new FormaPagamento();
                    sangria.funcionarioSangria = new Funcionario();

                    sangria.funcionarioSangria.codigoFuncionario = Convert.ToInt32(registro[0]);
                    sangria.funcionarioSangria.nomeFuncionario = (registro[1]).ToString();
                    sangria.funcionarioSangria.sobrenomeFuncionario = (registro[2]).ToString();

                    sangria.ordemSangra = Convert.ToInt32(registro[3]);
                    sangria.valorSangria = Convert.ToDouble(registro[4]);
                    sangria.pagamentoSangria.codigoFormaPagamento = Convert.ToInt32(registro[5]);
                    sangria.pagamentoSangria.formaPagamento = (registro[6]).ToString();
                    sangria.estatusSangria = (registro[7]).ToString();

                    listaSangria.Add(sangria);
                }
                return listaSangria;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar dados da Sangria. [Negócios]. Motivo: " + ex.Message);
            }

        }

    }
}
