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
   public class NegCaixa
    {
        private ConexaoSqlServer sqlServer = new ConexaoSqlServer();


        //Busca os valores que tem movimentação no caixa para realizar o cadastro da sangria
        public CaixaLista BuscarCaixaValores(DateTime data)
        {
            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@data", data));

                string comandoSql = "exec uspBuscarCaixaValores @data";

                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

                CaixaLista listaCaixa = new CaixaLista();
                Caixa caixa;

                foreach (DataRow registro in tabelaRetorno.Rows)
                {

                    caixa = new Caixa();
                    caixa.formaPagamento = new FormaPagamento();

                    caixa.valorCaixa = Convert.ToDouble(registro[0]);
                    caixa.jurosCaixa = Convert.ToDouble(registro[1]);
                    caixa.descontoCaixa = Convert.ToDouble(registro[2]);

                    caixa.formaPagamento.codigoFormaPagamento = Convert.ToInt32(registro[3]);
                    caixa.formaPagamento.formaPagamento = (registro[4]).ToString();
                    caixa.dataCaixa = Convert.ToDateTime(registro[5]);
                    caixa.estatusCaixa = (registro[6]).ToString();

                    listaCaixa.Add(caixa);
                }
                return listaCaixa;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar dados do Caixa. [Negócios]. Motivo: " + ex.Message);
            }

        }

        //uspBuscarCaixaDetalhado Itens Vendidos no Caixa
        public ItemCaixaLista BuscarCaixaDetalhado(string Avista, string CrediarioPendente, string CrediarioPago, string nomeCliente, string nomeFuncionario, 
            string strDinheiro, string strPix, string strCredito, string strDebito, string strCheque, string strParcial,DateTime dataInicio, DateTime dataFim) {

                try
                {
                    sqlServer.LimparParametros();
                    sqlServer.AdicionarParametro(new SqlParameter("@Avista", Avista));
                    sqlServer.AdicionarParametro(new SqlParameter("@CrediarioPendente", CrediarioPendente));
                    sqlServer.AdicionarParametro(new SqlParameter("@CrediarioPago", CrediarioPago));
                    sqlServer.AdicionarParametro(new SqlParameter("@nomeCliente", nomeCliente));
                    sqlServer.AdicionarParametro(new SqlParameter("@nomeFuncionario", nomeFuncionario));

                    sqlServer.AdicionarParametro(new SqlParameter("@strDinheiro", strDinheiro));
                    sqlServer.AdicionarParametro(new SqlParameter("@strPix", strPix));
                    sqlServer.AdicionarParametro(new SqlParameter("@strCredito", strCredito));
                    sqlServer.AdicionarParametro(new SqlParameter("@strDebito", strDebito));
                    sqlServer.AdicionarParametro(new SqlParameter("@strCheque", strCheque));
                    sqlServer.AdicionarParametro(new SqlParameter("@strParcial", strParcial));

                    sqlServer.AdicionarParametro(new SqlParameter("@dataInicio", dataInicio));
                    sqlServer.AdicionarParametro(new SqlParameter("@dataFim", dataFim));

                    string comandoSql = "exec uspBuscarCaixaDetalhado @Avista, @CrediarioPendente, @CrediarioPago, @nomeCliente, @nomeFuncionario," +
                       "@strDinheiro, @strPix, @strCredito, @strDebito, @strCheque, @strParcial, @dataInicio, @dataFim";

                    DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

                    ItemCaixaLista listaItemCaixa = new ItemCaixaLista();
                    ItemCaixa caixa;

                    foreach (DataRow registro in tabelaRetorno.Rows)
                    {
                        caixa = new ItemCaixa();
                        caixa.Venda = new Venda();
                        caixa.formaPagamento = new FormaPagamento();
                        caixa.ProdutoCor = new ProdutoCor();
                        caixa.ProdutoCor.Produto = new Produto();
                        caixa.ProdutoCor.Produto.Genero = new Genero();
                        caixa.ProdutoCor.Cor = new Cor();
                        caixa.tamanho = new Tamanho();
                        caixa.ProdutoCor.Produto.Grade = new Grade();
                        caixa.cliente = new Cliente();
                        caixa.funcionario = new Funcionario();
                        caixa.fornecedor = new Fornecedor();

                    caixa.Venda.codigoVenda = Convert.ToInt32(registro[0]);
                    caixa.tipoVenda = (registro[1]).ToString();
                    caixa.formaPagamento.codigoFormaPagamento = Convert.ToInt32(registro[2]);
                    caixa.formaPagamento.formaPagamento = (registro[3]).ToString();

                    caixa.ProdutoCor.Produto.codigoProduto = Convert.ToInt32(registro[4]);
                    caixa.ProdutoCor.codigoProdutoCor = Convert.ToInt32(registro[5]);
                    caixa.ProdutoCor.Produto.descricaoProduto = (registro[6]).ToString();
                    caixa.ProdutoCor.Produto.referenciaProduto = (registro[7]).ToString();
                    caixa.ProdutoCor.Produto.sexoProduto = (registro[8]).ToString();

                    caixa.ProdutoCor.Cor.nomeCor = (registro[9]).ToString();
                    caixa.ProdutoCor.Produto.Genero.nomeGenero = (registro[10]).ToString();
                    caixa.ProdutoCor.Produto.Grade.nomeGrade = (registro[11]).ToString();
                    caixa.tamanho.codigoTamanho = Convert.ToInt32(registro[12]);
                    caixa.tamanho.nometamanho = (registro[13]).ToString();

                    caixa.quantidadeItem = Convert.ToInt32(registro[14]);
                    caixa.custoItem = Convert.ToDouble(registro[15]);
                    caixa.vendaItem = Convert.ToDouble(registro[16]);
                    caixa.totalItem = Convert.ToDouble(registro[17]);
                    caixa.recebidoItem = Convert.ToDouble(registro[18]);

                    caixa.ProdutoCor.ImagemProduto = (registro[19]).ToString();

                    caixa.descontoItem = Convert.ToDouble(registro[20]);
                    caixa.jurosItem = Convert.ToDouble(registro[21]);

                    caixa.cliente.nomeCliente = (registro[22]).ToString();
                    caixa.funcionario.nomeFuncionario = (registro[23]).ToString();
                    caixa.fornecedor.nomeFantasiaFornecedor = (registro[24]).ToString();

                    caixa.dataItem = Convert.ToDateTime(registro[25]);
                    caixa.estatusItem = (registro[26]).ToString();

                    listaItemCaixa.Add(caixa);
                }
               
                    return listaItemCaixa;
                }
                catch (Exception ex){

                    throw new Exception("Não foi possível buscar dados do Caixa Detalhado. [Negócios]. Motivo: " + ex.Message);
                }
         }

        //uspBuscarCaixaDetalhado Itens Vendidos no Caixa
        public ItemCaixaLista BuscarCaixaDetalhadoParciais(string Avista, string CrediarioPendente, string CrediarioPago, string nomeCliente, string nomeFuncionario,
            string strDinheiro, string strPix, string strCredito, string strDebito, string strCheque, string strParcial, DateTime dataInicio, DateTime dataFim)
        {

            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@Avista", Avista));
                sqlServer.AdicionarParametro(new SqlParameter("@CrediarioPendente", CrediarioPendente));
                sqlServer.AdicionarParametro(new SqlParameter("@CrediarioPago", CrediarioPago));
                sqlServer.AdicionarParametro(new SqlParameter("@nomeCliente", nomeCliente));
                sqlServer.AdicionarParametro(new SqlParameter("@nomeFuncionario", nomeFuncionario));

                sqlServer.AdicionarParametro(new SqlParameter("@strDinheiro", strDinheiro));
                sqlServer.AdicionarParametro(new SqlParameter("@strPix", strPix));
                sqlServer.AdicionarParametro(new SqlParameter("@strCredito", strCredito));
                sqlServer.AdicionarParametro(new SqlParameter("@strDebito", strDebito));
                sqlServer.AdicionarParametro(new SqlParameter("@strCheque", strCheque));
                sqlServer.AdicionarParametro(new SqlParameter("@strParcial", strParcial));

                sqlServer.AdicionarParametro(new SqlParameter("@dataInicio", dataInicio));
                sqlServer.AdicionarParametro(new SqlParameter("@dataFim", dataFim));

                string comandoSql = "exec uspBuscarCaixaDetalhadoParcial @Avista, @CrediarioPendente, @CrediarioPago, @nomeCliente, @nomeFuncionario," +
                   "@strDinheiro, @strPix, @strCredito, @strDebito, @strCheque, @strParcial, @dataInicio, @dataFim";

                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

                ItemCaixaLista listaItemCaixa = new ItemCaixaLista();
                ItemCaixa caixa;

                foreach (DataRow registro in tabelaRetorno.Rows)
                {
                    caixa = new ItemCaixa();
                    caixa.Venda = new Venda();
                    caixa.formaPagamento = new FormaPagamento();
                    caixa.ProdutoCor = new ProdutoCor();
                    caixa.ProdutoCor.Produto = new Produto();
                    caixa.ProdutoCor.Produto.Genero = new Genero();
                    caixa.ProdutoCor.Cor = new Cor();
                    caixa.tamanho = new Tamanho();
                    caixa.ProdutoCor.Produto.Grade = new Grade();
                    caixa.cliente = new Cliente();
                    caixa.funcionario = new Funcionario();
                    caixa.fornecedor = new Fornecedor();

                    caixa.codigoItem = Convert.ToInt32(registro[0]);
                    caixa.Venda.codigoVenda = Convert.ToInt32(registro[1]);
                    caixa.tipoVenda = (registro[2]).ToString();
                    caixa.formaPagamento.codigoFormaPagamento = Convert.ToInt32(registro[3]);
                    caixa.formaPagamento.formaPagamento = (registro[4]).ToString();

                    caixa.ProdutoCor.Produto.codigoProduto = Convert.ToInt32(registro[5]);
                    caixa.ProdutoCor.codigoProdutoCor = Convert.ToInt32(registro[6]);
                    caixa.ProdutoCor.Produto.descricaoProduto = (registro[7]).ToString();
                    caixa.ProdutoCor.Produto.referenciaProduto = (registro[8]).ToString();
                    caixa.ProdutoCor.Produto.sexoProduto = (registro[9]).ToString();

                    caixa.ProdutoCor.Cor.nomeCor = (registro[10]).ToString();
                    caixa.ProdutoCor.Produto.Genero.nomeGenero = (registro[11]).ToString();
                    caixa.ProdutoCor.Produto.Grade.nomeGrade = (registro[12]).ToString();
                    caixa.tamanho.codigoTamanho = Convert.ToInt32(registro[13]);
                    caixa.tamanho.nometamanho = (registro[14]).ToString();

                    caixa.quantidadeItem = Convert.ToInt32(registro[15]);
                    caixa.custoItem = Convert.ToDouble(registro[16]);
                    caixa.vendaItem = Convert.ToDouble(registro[17]);
                    caixa.totalItem = Convert.ToDouble(registro[18]);
                    caixa.recebidoItem = Convert.ToDouble(registro[19]);

                    caixa.ProdutoCor.ImagemProduto = (registro[20]).ToString();

                    caixa.descontoItem = Convert.ToDouble(registro[21]);
                    caixa.jurosItem = Convert.ToDouble(registro[22]);

                    caixa.cliente.nomeCliente = (registro[23]).ToString();
                    caixa.funcionario.nomeFuncionario = (registro[24]).ToString();
                    caixa.fornecedor.nomeFantasiaFornecedor = (registro[25]).ToString();

                    caixa.dataItem = Convert.ToDateTime(registro[26]);
                    caixa.estatusItem = (registro[27]).ToString();

                    listaItemCaixa.Add(caixa);
                }

                return listaItemCaixa;
            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possível buscar dados do Caixa Detalhado. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //uspBuscarCaixaDetalhado Itens Vendidos no Caixa
        public CaixaLista BuscarCaixa(string Avista, string CrediarioPendente, string CrediarioPago,
            string strDinheiro, string strPix, string strCredito, string strDebito, string strCheque, string strParcial, DateTime dataInicio, DateTime dataFim)
        {

            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@Avista", Avista));
                sqlServer.AdicionarParametro(new SqlParameter("@CrediarioPendente", CrediarioPendente));
                sqlServer.AdicionarParametro(new SqlParameter("@CrediarioPago", CrediarioPago));

                sqlServer.AdicionarParametro(new SqlParameter("@strDinheiro", strDinheiro));
                sqlServer.AdicionarParametro(new SqlParameter("@strPix", strPix));
                sqlServer.AdicionarParametro(new SqlParameter("@strCredito", strCredito));
                sqlServer.AdicionarParametro(new SqlParameter("@strDebito", strDebito));
                sqlServer.AdicionarParametro(new SqlParameter("@strCheque", strCheque));
                sqlServer.AdicionarParametro(new SqlParameter("@strParcial", strParcial));

                sqlServer.AdicionarParametro(new SqlParameter("@dataInicio", dataInicio));
                sqlServer.AdicionarParametro(new SqlParameter("@dataFim", dataFim));

                string comandoSql = "exec uspBuscarCaixa @Avista, @CrediarioPendente, @CrediarioPago," +
                   "@strDinheiro, @strPix, @strCredito, @strDebito, @strCheque, @strParcial, @dataInicio, @dataFim";

                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

                CaixaLista listaCaixa = new CaixaLista();
                Caixa caixa;

                foreach (DataRow registro in tabelaRetorno.Rows)
                {
                    caixa = new Caixa();
                    caixa.formaPagamento = new FormaPagamento();

                    caixa.tipoVenda = (registro[0]).ToString();
                    caixa.recebidoCaixa = Convert.ToDouble(registro[1]);
                    caixa.valorCaixa = Convert.ToDouble(registro[2]);
                    caixa.jurosCaixa = Convert.ToDouble(registro[3]);
                    caixa.descontoCaixa = Convert.ToDouble(registro[4]);

                    caixa.formaPagamento.codigoFormaPagamento = Convert.ToInt32(registro[5]);
                    caixa.formaPagamento.formaPagamento = (registro[6]).ToString();

                    caixa.dataCaixa = Convert.ToDateTime(registro[7]);
                    caixa.estatusCaixa = (registro[8]).ToString();

                    listaCaixa.Add(caixa);
                }

                return listaCaixa;
            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possível buscar dados do Caixa Detalhado. [Negócios]. Motivo: " + ex.Message);
            }
        }
    
//----------------------------------Caixa Finalização
        public CaixaLista BuscarMovimentacaoCaixa(string statusCaixa, DateTime dataInicial, DateTime dataFinal) {
            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@estatusCaixa",statusCaixa));
                sqlServer.AdicionarParametro(new SqlParameter("@dataInicial", dataInicial)); 
                sqlServer.AdicionarParametro(new SqlParameter("@dataFinal", dataFinal));

                string comando = "exec uspBuscarMovimentacaoCaixa @estatusCaixa, @dataInicial, @dataFinal";

                DataTable tabelaRetorno = sqlServer.ExecutarConsulta(comando, CommandType.Text);

                CaixaLista lista = new CaixaLista();
                Caixa caixa = new Caixa();

                foreach (DataRow registro in tabelaRetorno.Rows) {
                    
                    caixa = new Caixa();

                    caixa.recebidoCaixa = Convert.ToDouble(registro[0]);
                    caixa.totalCaixa = Convert.ToDouble(registro[1]);
                    caixa.trocoCaixa = Convert.ToDouble(registro[2]);
                    caixa.estornoCaixa = Convert.ToDouble(registro[3]);
                    caixa.jurosCaixa = Convert.ToDouble(registro[4]);
                    caixa.descontoCaixa = Convert.ToDouble(registro[5]);
                    caixa.dataCaixa = Convert.ToDateTime(registro[6]);
                    caixa.estatusCaixa = registro[7].ToString();

                    lista.Add(caixa);              
                }

                return lista;

            }
            catch (Exception ex) { throw new Exception("Não foi possível buscar dados do Movimentação do Caixa. [Negócios]. Motivo: " + ex.Message); }
        
        }

    }
}
