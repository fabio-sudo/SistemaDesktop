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
    public class NegFormaPagamento
    {


        private ConexaoSqlServer sqlServer = new ConexaoSqlServer();

        //Metodo para cadastrar forma de pagamento
        public Boolean CadastrarFormaPagamento(ListaFormaPagamento formaPagamentoLista)
        {
            try
            {

                foreach (FormaPagamento formaPagamento in formaPagamentoLista)
                {

                    sqlServer.LimparParametros();

                    sqlServer.AdicionarParametro(new SqlParameter("@formaPagamento", formaPagamento.formaPagamento));
                    sqlServer.AdicionarParametro(new SqlParameter("@taxaFormaPagamento", formaPagamento.taxaFormaPagamento));

                    string comandoSql = "exec uspCadastrarFormaPagamento @formaPagamento, @taxaFormaPagamento";

                    object Resposta = sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);
                    
                    if (Convert.ToInt16(Resposta) == 1)
                    {
                        return false;//Forma de pagamento não foi cadastrada
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível cadastrar a forma de pagamento. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //metodo excluir forma de pagamento
        public Boolean ExcluirFormaPagamento(FormaPagamento formaPagamento)
        {
            try
            {

                sqlServer.LimparParametros();

                sqlServer.AdicionarParametro(new SqlParameter("@codigo", formaPagamento.codigoFormaPagamento));

                string comandoSql = "exec uspExcluirFormaPagamento @codigo";

                object Resposta = sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                if (Convert.ToInt16(Resposta) == 1)
                {
                    return false;//está vinculado ao cadastro do produto
                }
                else
                    return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível excluir os dados da Forma de Pagamento. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //metodo para alterar forma de pagamento
        public Boolean AtualizarFormaPagamento(ListaFormaPagamento formaPagamentoLista)
        {
            try
            {
              foreach (FormaPagamento formaPagamento in formaPagamentoLista)
                {
                sqlServer.LimparParametros();

                sqlServer.AdicionarParametro(new SqlParameter("@codigoFormaPagamento", formaPagamento.codigoFormaPagamento));
                sqlServer.AdicionarParametro(new SqlParameter("@formaPagamento", formaPagamento.formaPagamento));
                sqlServer.AdicionarParametro(new SqlParameter("@taxaFormaPagamento", formaPagamento.taxaFormaPagamento));

                string comandoSql = "exec uspAlterarFormaPagamento @codigoFormaPagamento, @formaPagamento, @taxaFormaPagamento";


                object Resposta = sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);
                
                   if (Convert.ToInt16(Resposta) == 1)
                   {
                    return false;//Forma de pagamento não foi cadastrada
                   }
                }

              return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível alterar os dados da Forma de Pagamento. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //------------------------Consultas

        //metodo para buscar forma pagamento por nome
        public ListaFormaPagamento BuscarFormaPagamentoPorNome(string nome)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@formaPagamento", nome));

            string comandoSql = "exec uspBuscarFormaPagamentoPorNome @formaPagamento";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

            ListaFormaPagamento pagamentos = new ListaFormaPagamento();
            FormaPagamento pagamento;

            foreach (DataRow registro in tabelaRetorno.Rows)
            {
                pagamento = new FormaPagamento();
                pagamento.codigoFormaPagamento = Convert.ToInt32(registro[0]);
                pagamento.formaPagamento = registro[1].ToString();
                pagamento.taxaFormaPagamento = Convert.ToDouble(registro[2]);

                pagamentos.Add(pagamento);
            }

            return pagamentos;
        }

        public ListaFormaPagamento BuscarFormaPagamentoCombobox()
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@formaPagamento", ""));

            string comandoSql = "exec uspBuscarFormaPagamentoPorNome @formaPagamento";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

            ListaFormaPagamento pagamentos = new ListaFormaPagamento();
            FormaPagamento pagamento;

            foreach (DataRow registro in tabelaRetorno.Rows)
            {
                pagamento = new FormaPagamento();
                pagamento.codigoFormaPagamento = Convert.ToInt32(registro[0]);
                pagamento.formaPagamento = registro[1].ToString();
                pagamento.taxaFormaPagamento = Convert.ToDouble(registro[2]);

                if (pagamento.formaPagamento != "CREDIARIO" || pagamento.formaPagamento != "PARCIAL")
                {
                    pagamentos.Add(pagamento);
                }
            }

            return pagamentos;
        }

        public ListaFormaPagamento BuscarFormaPagamentoComboboxPorData(DateTime data)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@dataPagamento", data));

            string comandoSql = "exec uspBuscarFormaPagamentoPorData @dataPagamento";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

            ListaFormaPagamento pagamentos = new ListaFormaPagamento();
            FormaPagamento pagamento;

            foreach (DataRow registro in tabelaRetorno.Rows)
            {
                pagamento = new FormaPagamento();
                pagamento.codigoFormaPagamento = Convert.ToInt32(registro[0]);
                pagamento.formaPagamento = registro[1].ToString();

                if (pagamento.formaPagamento != "CREDIARIO" || pagamento.formaPagamento != "PARCIAL")
                {
                    pagamentos.Add(pagamento);
                }
            }

            return pagamentos;
        }

        //metodo para buscar forma pagamento por Codigo
        public FormaPagamento BuscarFormaPagamentoPorCodigo(int codigo)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@codigoFormaPagamento", codigo));

            string comandoSql = "exec uspBuscarFormaPagamentoPorCodigo @codigoFormaPagamento";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);


            if (tabelaRetorno.Rows.Count > 0)
            {
                FormaPagamento pagamento = new FormaPagamento();
                DataRow registro = tabelaRetorno.Rows[0];

                pagamento = new FormaPagamento();
                pagamento.codigoFormaPagamento = Convert.ToInt32(registro[0]);
                pagamento.formaPagamento = registro[1].ToString();
                pagamento.taxaFormaPagamento = Convert.ToDouble(registro[0]);

                return pagamento;
            }
            else
                return null;

        }

        //realiza a validação se a Forma de pagamento já foi cadastrada
        public FormaPagamento ValidarCadastroFormaPagamento(String strFormaPagamento)
        {
            try
            {
                DataTable tabelaRetorno;
                FormaPagamento pagamento;

                this.sqlServer.LimparParametros();
                this.sqlServer.AdicionarParametro(new SqlParameter("@formaPagamento", strFormaPagamento));

                string comando = "exec uspValidaFormaPagamento @formaPagamento";

                tabelaRetorno = this.sqlServer.ExecutarConsulta(comando, CommandType.Text);
                if (tabelaRetorno.Rows.Count > 0)
                {
                    DataRow registro = tabelaRetorno.Rows[0];//Consulta só retorna uma objeto

                    pagamento = new FormaPagamento();

                    pagamento.codigoFormaPagamento = Convert.ToInt32(registro[0]);
                    pagamento.formaPagamento = (registro[1].ToString());

                    return pagamento;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível validar a Forma de Pagamento. [Negócios]. Motivo: " + ex.Message);
            }
        }

        public FormaPagamento BuscarFormaPagamentoPorTipo(String strFormaPagamento)
        {
            try
            {
                DataTable tabelaRetorno;
                FormaPagamento pagamento;

                this.sqlServer.LimparParametros();
                this.sqlServer.AdicionarParametro(new SqlParameter("@formaPagamento", strFormaPagamento));

                string comando = "exec uspBuscarFormaPagamentoPorTipo @formaPagamento";

                tabelaRetorno = this.sqlServer.ExecutarConsulta(comando, CommandType.Text);
                if (tabelaRetorno.Rows.Count > 0)
                {
                    DataRow registro = tabelaRetorno.Rows[0];//Consulta só retorna uma objeto

                    pagamento = new FormaPagamento();

                    pagamento.codigoFormaPagamento = Convert.ToInt32(registro[0]);
                    pagamento.formaPagamento = (registro[1].ToString());

                    return pagamento;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível validar a Forma de Pagamento. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //--------------------Forma De Pagamento CrediarioPago
        public ListaFormaPagamento BuscarFormaPagamentoCrediarioPago(String descricaoProduto, int codigoCrediario)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@descricaoProduto", descricaoProduto));
            this.sqlServer.AdicionarParametro(new SqlParameter("@codigoCrediario", codigoCrediario));

            string comandoSql = "exec uspBuscarFormaPagamentoCrediarioPago @descricaoProduto, @codigoCrediario";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

            ListaFormaPagamento pagamentos = new ListaFormaPagamento();
            FormaPagamento pagamento;

            foreach (DataRow registro in tabelaRetorno.Rows)
            {
                pagamento = new FormaPagamento();
                pagamento.codigoFormaPagamento = Convert.ToInt32(registro[0]);
                pagamento.formaPagamento = registro[1].ToString();

                pagamentos.Add(pagamento);
            }

            return pagamentos;
        }

        //--------------------Forma De Pagamento ItemVenda
        public ListaFormaPagamento BuscarFormaPagamentoItemVenda(String descricaoProduto, int codigoVenda)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@descricaoProduto", descricaoProduto));
            this.sqlServer.AdicionarParametro(new SqlParameter("@codigoVenda", codigoVenda));

            string comandoSql = "exec uspBuscarFormaPagamentoItemVenda @descricaoProduto, @codigoVenda";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

            ListaFormaPagamento pagamentos = new ListaFormaPagamento();
            FormaPagamento pagamento;

            foreach (DataRow registro in tabelaRetorno.Rows)
            {
                pagamento = new FormaPagamento();
                pagamento.codigoFormaPagamento = Convert.ToInt32(registro[0]);
                pagamento.formaPagamento = registro[1].ToString();

                pagamentos.Add(pagamento);
            }

            return pagamentos;
        }

        //--------------------Forma De Pagamento Cancelamento
        public ListaFormaPagamento BuscarFormaPagamentoCancelamento(String AVista, String CrediarioPago, String Crediario
            , String nomeCliente, String sobrenomeCliente, String nomeFuncionario, DateTime dataInicial, DateTime dataFinal)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@AVista", AVista));
            this.sqlServer.AdicionarParametro(new SqlParameter("@CrediarioPago", CrediarioPago));
            this.sqlServer.AdicionarParametro(new SqlParameter("@Crediario", Crediario));
            this.sqlServer.AdicionarParametro(new SqlParameter("@nomeCliente", nomeCliente));
            this.sqlServer.AdicionarParametro(new SqlParameter("@sobrenomeCliente", sobrenomeCliente));
            this.sqlServer.AdicionarParametro(new SqlParameter("@nomeFuncionario", nomeFuncionario));
            this.sqlServer.AdicionarParametro(new SqlParameter("@dataInicial", dataInicial));
            this.sqlServer.AdicionarParametro(new SqlParameter("@dataFinal", dataFinal));

            string comandoSql = "exec uspBuscarFormaPagamentoCancelamento @AVista, @CrediarioPago, @Crediario, @nomeCliente, @sobrenomeCliente, @nomeFuncionario, @dataInicial, @dataFinal";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

            ListaFormaPagamento pagamentos = new ListaFormaPagamento();
            FormaPagamento pagamento;

            foreach (DataRow registro in tabelaRetorno.Rows)
            {
                pagamento = new FormaPagamento();
                pagamento.codigoFormaPagamento = Convert.ToInt32(registro[0]);
                pagamento.formaPagamento = registro[1].ToString();

                pagamentos.Add(pagamento);
            }

            return pagamentos;
        }

    }
}
