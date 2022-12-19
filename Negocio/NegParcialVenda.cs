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
   public class NegParcialVenda
    {
       ConexaoSqlServer sqlServer = new ConexaoSqlServer();

        //Cadastrar itens da Venda
        public Boolean CadastrarParcialLista(ParcialVendaLista parcialLista)
        {
            try
            {
                foreach (ParcialVenda parcial in parcialLista)
                {

                    sqlServer.LimparParametros();

                    sqlServer.LimparParametros();
                    sqlServer.AdicionarParametro(new SqlParameter("@codigoVenda", parcial.Venda.codigoVenda));
                    sqlServer.AdicionarParametro(new SqlParameter("@codigoFormaPagamento", parcial.formaPagamentoVenda.codigoFormaPagamento));
                    sqlServer.AdicionarParametro(new SqlParameter("@valorParcial", parcial.valorParcialVenda));
                    sqlServer.AdicionarParametro(new SqlParameter("@descontoParcial", parcial.descontoParcialVenda));
                    sqlServer.AdicionarParametro(new SqlParameter("@jurosParcial", parcial.jurosParcialVenda));
                    sqlServer.AdicionarParametro(new SqlParameter("@acrescimoJuros",parcial.acrescimoTaxa));
                    sqlServer.AdicionarParametro(new SqlParameter("@acrescimoDesconto", parcial.acrescimoDesconto));

                    string comandoSql = "exec uspCadastrarParcialVenda @codigoVenda, @codigoFormaPagamento, @valorParcial, @descontoParcial, @jurosParcial, @acrescimoJuros, @acrescimoDesconto";

                    sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível Cadastrar o Parcial da Venda. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //metodo para buscar produto Cor por nome
        public ParcialVendaLista BuscarParcialVendaPorCodigoDaVenda(int codigoVenda)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@codigo", codigoVenda));
            string comandoSql = "exec uspBuscarParcialVenda @codigo";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

            ParcialVenda parcialVenda = new ParcialVenda();
            ParcialVendaLista listaParcial = new ParcialVendaLista();

            foreach (DataRow registro in tabelaRetorno.Rows)
            {
                
                //define o objeto para não mantelo nullo
                parcialVenda = new ParcialVenda();
                parcialVenda.Venda = new Venda();
                parcialVenda.formaPagamentoVenda = new FormaPagamento();

                parcialVenda.CodigoParcial = Convert.ToInt32(registro[0]);
                parcialVenda.Venda.codigoVenda = Convert.ToInt32(registro[1]);

                parcialVenda.valorParcialVenda = Convert.ToDouble(registro[2]);

                parcialVenda.formaPagamentoVenda.formaPagamento = registro[3].ToString();
                parcialVenda.formaPagamentoVenda.codigoFormaPagamento = Convert.ToInt32(registro[4]);

                parcialVenda.descontoParcialVenda = Convert.ToDouble(registro[5]);
                parcialVenda.jurosParcialVenda = Convert.ToDouble(registro[6]);
                parcialVenda.formaPagamentoVenda.taxaFormaPagamento = Convert.ToDouble(registro[7]);

                listaParcial.Add(parcialVenda);
            }

            return listaParcial;
        }

        //Metodo excluir Lista 
        public Boolean ExcluirListaParcial(ParcialVendaLista listaParcial)
        {
            try
            {
                foreach (ParcialVenda parcial in listaParcial)
                {
                    sqlServer.LimparParametros();
                    sqlServer.AdicionarParametro(new SqlParameter("@codigoParcial", parcial.CodigoParcial));

                    string comandoSql = "exec uspExcluirParcialVenda @codigoParcial";

                    object Resposta = sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                    if (Convert.ToInt16(Resposta) == 2)
                    {
                        return false;//1 itemEntrada 2 ItemVenda 3 ItemCrediario
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível excluir as cores do Produto. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Metodo excluir Parciais da VEnda por codigo da venda 
        public Boolean ExcluirParcialPorVenda(Venda objVenda)
        {
            try
            {

                    sqlServer.LimparParametros();
                    sqlServer.AdicionarParametro(new SqlParameter("@codigoVenda", objVenda.codigoVenda));

                    string comandoSql = "exec uspExcluirParcialVendaTodas @codigoVenda";

                    object Resposta = sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                    if (Convert.ToInt16(Resposta) == 2)
                    {
                        return false;//1 itemEntrada 2 ItemVenda 3 ItemCrediario
                    }

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível excluir as parciais da Venda. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Atualizar Valores da Parcial
        public Boolean AltualizarParcialLista(ParcialVendaLista parcialLista)
        {
            try
            {
                foreach (ParcialVenda parcial in parcialLista)
                {

                    sqlServer.LimparParametros();

                    sqlServer.LimparParametros();
                    sqlServer.AdicionarParametro(new SqlParameter("@codigoParcial", parcial.CodigoParcial));
                    sqlServer.AdicionarParametro(new SqlParameter("@codigoVenda", parcial.Venda.codigoVenda));//erro
                    sqlServer.AdicionarParametro(new SqlParameter("@codigoFormaPagamento", parcial.formaPagamentoVenda.codigoFormaPagamento));
                    sqlServer.AdicionarParametro(new SqlParameter("@valorParcial", parcial.valorParcialVenda));
                    sqlServer.AdicionarParametro(new SqlParameter("@descontoParcial", parcial.descontoParcialVenda));
                    sqlServer.AdicionarParametro(new SqlParameter("@jurosParcial", parcial.jurosParcialVenda));
                    sqlServer.AdicionarParametro(new SqlParameter("@acrescimoJuros", parcial.acrescimoTaxa));
                    sqlServer.AdicionarParametro(new SqlParameter("@acrescimoDesconto", parcial.acrescimoDesconto));

                    string comandoSql = "exec uspAlterarParcialVenda @codigoParcial, @codigoVenda, @codigoFormaPagamento, @valorParcial, @descontoParcial, @jurosParcial, @acrescimoJuros, @acrescimoDesconto";

                    sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível Cadastrar o Parcial da Venda. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Atualizar Valores da Venda e Items da Venda
        public Boolean AtualizarParcialValoresItemEVenda(double totalVenda,double descontoVenda,double jurosVenda,Venda venda)
        {
            try
            {

                    sqlServer.LimparParametros();

                    sqlServer.LimparParametros();
                    sqlServer.AdicionarParametro(new SqlParameter("@codigoVenda", venda.codigoVenda));

                    sqlServer.AdicionarParametro(new SqlParameter("@varTotalAtualizado", totalVenda));
                    sqlServer.AdicionarParametro(new SqlParameter("@varDescontoAtualizado", descontoVenda));
                    sqlServer.AdicionarParametro(new SqlParameter("@varJurosAtualizado", jurosVenda));
                
                    sqlServer.AdicionarParametro(new SqlParameter("@valorAtualizado", venda.totalVenda));
                    sqlServer.AdicionarParametro(new SqlParameter("@descontoAtualizado", venda.descontoVenda));
                    sqlServer.AdicionarParametro(new SqlParameter("@jurosAtualizado", venda.jurosVenda));

                    string comandoSql = "exec uspAlterarValoresItemEVenda @codigoVenda, @varTotalAtualizado, @varDescontoAtualizado, @varJurosAtualizado, @valorAtualizado, @descontoAtualizado, @jurosAtualizado";

                    sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível Atualizadr os dados da Venda. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //--------------------------Cancelamento
        public ParcialVendaLista BuscarParcialVendaCancelamento(string nomeCliente, string cpfCliente)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@nomeCliente", nomeCliente));
            this.sqlServer.AdicionarParametro(new SqlParameter("@cpfCliente", cpfCliente));

            string comandoSql = "exec uspBuscarParcialVendaCancelamento @nomeCliente, @cpfCliente";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

            ParcialVenda parcialVenda = new ParcialVenda();
            ParcialVendaLista listaParcial = new ParcialVendaLista();

            foreach (DataRow registro in tabelaRetorno.Rows)
            {

                //define o objeto para não mantelo nullo
                parcialVenda = new ParcialVenda();
                parcialVenda.Venda = new Venda();
                parcialVenda.Venda.Cliente = new Cliente();
                parcialVenda.formaPagamentoVenda = new FormaPagamento();

                parcialVenda.Venda.codigoVenda = Convert.ToInt32(registro[0]);
                parcialVenda.CodigoParcial = Convert.ToInt32(registro[1]);
                parcialVenda.Venda.Cliente.codigoCliente = Convert.ToInt32(registro[2]);

                parcialVenda.Venda.Cliente.nomeCliente = (registro[3].ToString());
                parcialVenda.Venda.Cliente.sobrenomeCliente = (registro[4].ToString());
                parcialVenda.Venda.Cliente.cpfCliente = (registro[5].ToString());
                parcialVenda.Venda.Cliente.celularCliente = (registro[6].ToString());

                parcialVenda.formaPagamentoVenda.codigoFormaPagamento = Convert.ToInt32(registro[7]);
                parcialVenda.formaPagamentoVenda.formaPagamento = registro[8].ToString();

                parcialVenda.Venda.totalVenda = Convert.ToDouble(registro[9]);
                parcialVenda.valorParcialVenda = Convert.ToDouble(registro[10]);
                parcialVenda.jurosParcialVenda = Convert.ToDouble(registro[11]);
                parcialVenda.descontoParcialVenda = Convert.ToDouble(registro[12]);

                parcialVenda.Venda.dataVenda = Convert.ToDateTime(registro[13]);
                parcialVenda.Venda.estatusVenda = (registro[14].ToString());

                listaParcial.Add(parcialVenda);
            }

            return listaParcial;
        }
    
        public ParcialVendaLista BuscarParcialVendaCancelamentoPorData(DateTime dataInicio, DateTime dataFinal)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@dataInicial", dataInicio));
            this.sqlServer.AdicionarParametro(new SqlParameter("@dataFinal", dataFinal));

            string comandoSql = "exec uspBuscarParcialVendaCancelamentoPorData @dataInicial, @dataFinal";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

            ParcialVenda parcialVenda = new ParcialVenda();
            ParcialVendaLista listaParcial = new ParcialVendaLista();

            foreach (DataRow registro in tabelaRetorno.Rows)
            {

                //define o objeto para não mantelo nullo
                parcialVenda = new ParcialVenda();
                parcialVenda.Venda = new Venda();
                parcialVenda.Venda.Cliente = new Cliente();
                parcialVenda.formaPagamentoVenda = new FormaPagamento();

                parcialVenda.Venda.codigoVenda = Convert.ToInt32(registro[0]);
                parcialVenda.CodigoParcial = Convert.ToInt32(registro[1]);
                parcialVenda.Venda.Cliente.codigoCliente = Convert.ToInt32(registro[2]);

                parcialVenda.Venda.Cliente.nomeCliente = (registro[3].ToString());
                parcialVenda.Venda.Cliente.sobrenomeCliente = (registro[4].ToString());
                parcialVenda.Venda.Cliente.cpfCliente = (registro[5].ToString());
                parcialVenda.Venda.Cliente.celularCliente = (registro[6].ToString());

                parcialVenda.formaPagamentoVenda.codigoFormaPagamento = Convert.ToInt32(registro[7]);
                parcialVenda.formaPagamentoVenda.formaPagamento = registro[8].ToString();

                parcialVenda.Venda.totalVenda = Convert.ToDouble(registro[9]);
                parcialVenda.valorParcialVenda = Convert.ToDouble(registro[10]);
                parcialVenda.jurosParcialVenda = Convert.ToDouble(registro[11]);
                parcialVenda.descontoParcialVenda = Convert.ToDouble(registro[12]);

                parcialVenda.Venda.dataVenda = Convert.ToDateTime(registro[13]);
                parcialVenda.Venda.estatusVenda = (registro[14].ToString());

                listaParcial.Add(parcialVenda);
            }

            return listaParcial;
        } 


    }
}
