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
    public class NegItemVenda
    {
        private ConexaoSqlServer sqlServer = new ConexaoSqlServer();

        //--------------Metodos Para ItemVenda

        //Cadastrar itens da Venda
        public Boolean CadastrarItemVendaLista(ItemVendaLista itemlista)
        {
            try
            {
                foreach (ItemVenda item in itemlista)
                {

                    sqlServer.LimparParametros();

                    sqlServer.LimparParametros();
                    sqlServer.AdicionarParametro(new SqlParameter("@codigoProdutoCor", item.ProdutoCor.codigoProdutoCor));
                    sqlServer.AdicionarParametro(new SqlParameter("@codigoVenda", item.Venda.codigoVenda));
                    sqlServer.AdicionarParametro(new SqlParameter("@codigoTamanho", item.Tamanho.codigoTamanho));
                    sqlServer.AdicionarParametro(new SqlParameter("@quantidadeVenda", item.quantidadeVenda));
                    sqlServer.AdicionarParametro(new SqlParameter("@precoCusto", item.precoCusto));
                    sqlServer.AdicionarParametro(new SqlParameter("@precoVenda", item.precoVenda));               
                    sqlServer.AdicionarParametro(new SqlParameter("@descontoItem", item.descontoItem));
                    sqlServer.AdicionarParametro(new SqlParameter("@jurosItem", item.JurosItem));

                    string comandoSql = "exec uspCadastrarItemVenda @codigoProdutoCor, @codigoVenda, @codigoTamanho, @quantidadeVenda, @precoCusto, @precoVenda, @descontoItem, @jurosItem";

                    sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível Cadastrar o Item da Venda. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Excluir item Venda
        public Boolean ExcluirItemVenda(ItemVendaLista itens)
        {
            try
            {

                foreach (ItemVenda item in itens)
                {

                    sqlServer.LimparParametros();
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoVenda", item.Venda.codigoVenda));
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoItem", item.codigoItemVenda));
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoProdutoCor", item.ProdutoCor.codigoProdutoCor));
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@precoCusto", item.precoCusto));
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@precoVenda", item.precoVenda));
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@quantidadeVenda", item.quantidadeVenda));
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@tamanhoItem", item.Tamanho.codigoTamanho));
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@descontoItem", item.descontoItem));
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@jurosItem", item.JurosItem));

                    string comando = "exec uspExcluirItemVenda @codigoItem, @codigoVenda, @codigoProdutoCor, @precoCusto, @precoVenda, @quantidadeVenda, @tamanhoItem, @descontoItem, @jurosItem";

                    sqlServer.ExecutarScalar(comando, System.Data.CommandType.Text);

                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Erro na camada de negócios Item Venda Temp - Exclusão. " + ex.Message);
            }
        }

        //----------------------------Consultas

        //Buscar itens da Venda pelo codigo da venda -> Para Cancelamento
        public ItemVendaLista BuscarItemVendaPorVenda(int codigoVenda)
        {
            try
            {

                this.sqlServer.LimparParametros();

                sqlServer.AdicionarParametro(new SqlParameter("@codigoVenda",codigoVenda));
                string comandoSql = "exec uspBuscarItemVendaPorVenda @codigoVenda";

                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

                ItemVendaLista itemLista = new ItemVendaLista();
                ItemVenda item = new ItemVenda();

                foreach (DataRow registro in tabelaRetorno.Rows)
                {
                    item = new ItemVenda();
                    item.Venda = new Venda();
                    item.Venda.formaPagamento = new FormaPagamento();
                    item.Tamanho = new Tamanho();
                    item.ProdutoCor = new ProdutoCor();
                    item.ProdutoCor.Cor = new Cor();
                    item.ProdutoCor.Produto = new Produto();
                    item.ProdutoCor.Produto.Genero = new Genero();

                    item.codigoItemVenda = Convert.ToInt32(registro[0]);
                    item.Venda.codigoVenda = Convert.ToInt32(registro[1]);
                    item.ProdutoCor.Produto.codigoProduto = Convert.ToInt32(registro[2]);
                    item.ProdutoCor.codigoProdutoCor = Convert.ToInt32(registro[3]);

                    item.ProdutoCor.Produto.descricaoProduto = (registro[4].ToString());
                    item.ProdutoCor.Produto.referenciaProduto = (registro[5].ToString());
                    item.ProdutoCor.Produto.sexoProduto = (registro[6].ToString());
                    item.ProdutoCor.Cor.nomeCor = (registro[7].ToString());
                    item.ProdutoCor.Produto.Genero.nomeGenero = (registro[8].ToString());
                    item.Tamanho.codigoTamanho = Convert.ToInt32(registro[9]);
                    item.Tamanho.nometamanho = (registro[10].ToString());

                    item.quantidadeVenda = Convert.ToInt32(registro[11]);
                    item.precoCusto = Convert.ToDouble(registro[12]);
                    item.precoVenda = Convert.ToDouble(registro[13]);
                    //TotalVenda -> Calculado no formulário
                    //ValoreRecebido -> Caalculado no formulário

                    item.Venda.formaPagamento.codigoFormaPagamento = Convert.ToInt32(registro[14]);
                    item.Venda.formaPagamento.formaPagamento = (registro[15].ToString());
                    item.descontoItem = Convert.ToDouble(registro[16]);
                    item.JurosItem = Convert.ToDouble(registro[17]);

                    item.codigoBarrasItem = registro[18].ToString();
                    item.ProdutoCor.ImagemProduto = registro[19].ToString();
                    item.estatusItem = registro[20].ToString();
                    item.dataItemVenda = Convert.ToDateTime(registro[21]);

                    itemLista.Add(item);
                }

                return itemLista;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel buscar itens! " + ex.Message);
            }
        }

        //Buscar Itens do Venda por codigo do Filtros Crediario, Produto, FormaPagamento, DataInicial e DataFinal
        public ItemVendaLista BuscarItemVendaPorFiltros(int codigoVenda, string nomeProduto, string formaPagamento, DateTime dataInicial, DateTime dataFinal)
        {
            try
            {

                this.sqlServer.LimparParametros();

                sqlServer.AdicionarParametro(new SqlParameter("@codigoVenda", codigoVenda));
                sqlServer.AdicionarParametro(new SqlParameter("@nomeProduto", nomeProduto));
                sqlServer.AdicionarParametro(new SqlParameter("@formaPagamento", formaPagamento));
                sqlServer.AdicionarParametro(new SqlParameter("@dataInicial", dataInicial));
                sqlServer.AdicionarParametro(new SqlParameter("@dataFinal", dataFinal));

                string comandoSql = "exec uspBuscarItemVendaPorFiltros @codigoVenda, @nomeProduto, @formaPagamento, @dataInicial, @dataFinal";

                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

                ItemVendaLista itemLista = new ItemVendaLista();
                ItemVenda item = new ItemVenda();

                foreach (DataRow registro in tabelaRetorno.Rows)
                {
                    item = new ItemVenda();
                    item.Venda = new Venda();
                    item.Venda.formaPagamento = new FormaPagamento();
                    item.Tamanho = new Tamanho();
                    item.ProdutoCor = new ProdutoCor();
                    item.ProdutoCor.Cor = new Cor();
                    item.ProdutoCor.Produto = new Produto();
                    item.ProdutoCor.Produto.Genero = new Genero();

                    item.codigoItemVenda = Convert.ToInt32(registro[0]);
                    item.Venda.codigoVenda = Convert.ToInt32(registro[1]);
                    item.ProdutoCor.Produto.codigoProduto = Convert.ToInt32(registro[2]);
                    item.ProdutoCor.codigoProdutoCor = Convert.ToInt32(registro[3]);

                    item.ProdutoCor.Produto.descricaoProduto = (registro[4].ToString());
                    item.ProdutoCor.Produto.referenciaProduto = (registro[5].ToString());
                    item.ProdutoCor.Produto.sexoProduto = (registro[6].ToString());
                    item.ProdutoCor.Cor.nomeCor = (registro[7].ToString());
                    item.ProdutoCor.Produto.Genero.nomeGenero = (registro[8].ToString());
                    item.Tamanho.codigoTamanho = Convert.ToInt32(registro[9]);
                    item.Tamanho.nometamanho = (registro[10].ToString());

                    item.quantidadeVenda = Convert.ToInt32(registro[11]);
                    item.precoVenda = Convert.ToDouble(registro[12]);

                    //TotalVenda -> Calculado no formulário
                    //ValoreRecebido -> Caalculado no formulário

                    item.Venda.formaPagamento.formaPagamento = (registro[13].ToString());
                    item.descontoItem = Convert.ToDouble(registro[14]);
                    item.JurosItem = Convert.ToDouble(registro[15]);

                    item.codigoBarrasItem = registro[16].ToString();
                    item.ProdutoCor.ImagemProduto = registro[17].ToString();
                    item.estatusItem = registro[18].ToString();
                    item.dataItemVenda = Convert.ToDateTime(registro[19]);

                    itemLista.Add(item);
                }

                return itemLista;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel buscar itens! " + ex.Message);
            }
        }
       
        //------------Metodos Para a Tabela Temporaria

        //metodo para zerar a venda temporaria
        public void ExcluirDadosTabelaTemporaria()
        {
            try
            {
                string comando = " exec uspLimparTabelaItemVendaTemp ";

                sqlServer.ExecutarScalar(comando, System.Data.CommandType.Text);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro na camada de negócios - Retorno. " + ex.Message);

            }
        }

        //Alterar itens da tabela temporária
        public string AtualizarItemVendaTemp(ItemVenda itemTemp)
        {
            string retorno;
            try
            {

                sqlServer.LimparParametros();

                //Dados para atualização
                sqlServer.AdicionarParametro(new SqlParameter("@codigoItemVendaTemp", itemTemp.codigoItemVenda));
                sqlServer.AdicionarParametro(new SqlParameter("@codigoVenda", itemTemp.Venda.codigoVenda));
                sqlServer.AdicionarParametro(new SqlParameter("@codigoProdutoCor", itemTemp.ProdutoCor.codigoProdutoCor));
                sqlServer.AdicionarParametro(new SqlParameter("@PrecoVenda", itemTemp.precoVenda));
                sqlServer.AdicionarParametro(new SqlParameter("@quantidadeVenda", itemTemp.quantidadeVenda));
                sqlServer.AdicionarParametro(new SqlParameter("@codigoTamanho", itemTemp.Tamanho.codigoTamanho));

                string comandoSql = "exec uspAlterarItemVendaTemp @codigoItemVendaTemp, @codigoVenda, @codigoProdutoCor, @PrecoVenda, @quantidadeVenda, @codigoTamanho ";
               
                Object Resposta = sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);


                if ((Resposta == null))
                {
                    retorno = "true";//Item Atualizado com sucesso
                    return retorno;
                }
                else if ((Resposta).ToString() == "Erro")
                {
                    retorno = "false";//Erro ao realizar o cadastro
                    return retorno;
                }
                else
                {
                    return Resposta.ToString(); //Retorna quantidade atual de estoque 
                }

            }
            catch (Exception ex)
            {
                retorno = "false";//Erro 
                return retorno;
                throw new Exception("Não foi possivel Atualizar ItemEntrada" + ex.Message);
            }
        }

        //--------------------------Consultas ItemVendaTemp Para Venda
       //Busca itens temporários para realizar a venda
        public ItemVendaLista BuscarItemVendaTemp()
        {
            try
            {

                this.sqlServer.LimparParametros();
                string comandoSql = "exec uspBuscarItemVendaTemp";

                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

                ItemVendaLista itemLista = new ItemVendaLista();
                ItemVenda item = new ItemVenda();

                foreach (DataRow registro in tabelaRetorno.Rows)
                {
                    item = new ItemVenda();
                    item.Venda = new Venda();
                    item.Tamanho = new Tamanho();
                    item.ProdutoCor = new ProdutoCor();
                    item.ProdutoCor.Cor = new Cor();
                    item.ProdutoCor.Produto = new Produto();
                    item.ProdutoCor.Produto.Genero = new Genero();

                    item.codigoItemVenda = Convert.ToInt32(registro[0]);
                    item.Venda.codigoVenda = Convert.ToInt32(registro[1]);
                    item.ProdutoCor.codigoProdutoCor = Convert.ToInt32(registro[2]);
                    item.ProdutoCor.Produto.descricaoProduto = (registro[3].ToString());
                    item.ProdutoCor.Produto.referenciaProduto = (registro[4].ToString());
                    item.ProdutoCor.Produto.sexoProduto = (registro[5].ToString());
                    item.ProdutoCor.Produto.Genero.nomeGenero = (registro[6].ToString());
                    item.ProdutoCor.Cor.nomeCor = (registro[7].ToString());
                    item.Tamanho.codigoTamanho = Convert.ToInt32(registro[8]);
                    item.Tamanho.nometamanho = (registro[9].ToString());
                    item.quantidadeVenda = Convert.ToInt32(registro[10]);
                    item.precoVenda = Convert.ToDouble(registro[11]);
                    //item.ProdutoCor.Produto.codigoBarrasProduto = (registro[12].ToString());
                    item.ProdutoCor.ImagemProduto = (registro[13].ToString());

                    itemLista.Add(item);
                }

                return itemLista;

            }
            catch (Exception ex) {
                throw new Exception("Não foi possivel buscar itens! "+ex.Message);
            }
        }

        //Lista de produtos que tem estoque disponivel
        public ProdutoCorLista BuscarEstoqueProdutoParaItemVendaTemp(string descriacaoProduto)
        {
            try
            {

                this.sqlServer.LimparParametros();
                this.sqlServer.AdicionarParametro(new SqlParameter("@descricaoProduto", descriacaoProduto));

                string comandoSql = "exec uspBuscarEstoqueProdutoParaItemVendaTemp @descricaoProduto";

                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

                ProdutoCorLista itemLista = new ProdutoCorLista();
                ProdutoCor item = new ProdutoCor();

                foreach (DataRow registro in tabelaRetorno.Rows)
                {
                    item = new ProdutoCor();
                    item.Produto = new Produto();
                    item.Cor = new Cor();
                    item.Produto.Genero = new Genero();

                    item.codigoProdutoCor = Convert.ToInt32(registro[0]);
                    item.Produto.descricaoProduto = (registro[1].ToString());
                    item.Produto.referenciaProduto = (registro[2].ToString());
                    item.Produto.sexoProduto = (registro[3].ToString());
                    item.Produto.Genero.nomeGenero = (registro[4].ToString());
                    item.Cor.nomeCor = (registro[5].ToString());
                    item.Produto.quantidadeProduto = Convert.ToInt32(registro[6]);//Quantidade Estoque
                    item.Produto.precoVendaProduto = Convert.ToDouble(registro[7]);
                    item.ImagemProduto = (registro[8].ToString());

                    itemLista.Add(item);
                }

                return itemLista;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel buscar Estoque Items ! " + ex.Message);
            }
        }

        //Busca itens temporários para realizar a venda
        public ItemVendaLista BuscarEstoqueProdutoCorParaItemVendaTemp(int codigoProdutoCor)
        {
            try
            {

                this.sqlServer.LimparParametros();
                this.sqlServer.AdicionarParametro(new SqlParameter("@codigoProdutoCor", codigoProdutoCor));
                string comandoSql = "exec uspBuscarEstoqueProdutoCorParaItemVendaTemp @codigoProdutoCor";

                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

                ItemVendaLista itemLista = new ItemVendaLista();
                ItemVenda item = new ItemVenda();

                foreach (DataRow registro in tabelaRetorno.Rows)
                {
                    item = new ItemVenda();
                    item.Tamanho = new Tamanho();
                    item.ProdutoCor = new ProdutoCor();
                    item.ProdutoCor.Cor = new Cor();
                    item.ProdutoCor.Produto = new Produto();
                    item.ProdutoCor.Produto.Genero = new Genero();

                    item.codigoItemVenda = Convert.ToInt32(registro[0]);
                    item.ProdutoCor.codigoProdutoCor = Convert.ToInt32(registro[1]);
                    item.ProdutoCor.Produto.descricaoProduto = (registro[2].ToString());
                    item.ProdutoCor.Produto.referenciaProduto = (registro[3].ToString());
                    item.ProdutoCor.Produto.sexoProduto = (registro[4].ToString());
                    item.ProdutoCor.Produto.Genero.nomeGenero = (registro[5].ToString());
                    item.ProdutoCor.Cor.nomeCor = (registro[6].ToString());
                    item.Tamanho.codigoTamanho = Convert.ToInt32(registro[7]);
                    item.Tamanho.nometamanho = (registro[8].ToString());
                    item.ProdutoCor.Produto.quantidadeProduto = Convert.ToInt32(registro[9]);//Quantidade Estoque
                    item.quantidadeVenda = Convert.ToInt32(registro[10]);
                    item.precoVenda = Convert.ToDouble(registro[11]);
                    //item.ProdutoCor.Produto.codigoBarrasProduto = (registro[12].ToString());
                    item.ProdutoCor.ImagemProduto = (registro[13].ToString());

                    itemLista.Add(item);
                }

                return itemLista;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel buscar item para realizar a Venda ! " + ex.Message);
            }
        }

        //Cancela Itens da venda
        //No banco de dados está funcionado em ficando 92,39 na Venda
        public Boolean ExcluirItemVendaCancela(ItemVendaLista Listaitem)
        {
            try
            {

                foreach (ItemVenda item in Listaitem)
                {
                    this.sqlServer.LimparParametros();

                    this.sqlServer.AdicionarParametro(new SqlParameter("@codigoItemVenda", item.codigoItemVenda));
                    this.sqlServer.AdicionarParametro(new SqlParameter("@codigoVenda", item.Venda.codigoVenda));
                    this.sqlServer.AdicionarParametro(new SqlParameter("@codigoProdutoCor", item.ProdutoCor.codigoProdutoCor));
                    this.sqlServer.AdicionarParametro(new SqlParameter("@precoCusto", item.precoCusto));
                    this.sqlServer.AdicionarParametro(new SqlParameter("@precoVenda", item.precoVenda));
                    this.sqlServer.AdicionarParametro(new SqlParameter("@quantidadeItem", item.quantidadeVenda));
                    this.sqlServer.AdicionarParametro(new SqlParameter("@tamanhoItem", item.Tamanho.codigoTamanho));

                    string comandoSql = "exec uspExcluirItemVendaCancela @codigoItemVenda, @codigoVenda, @codigoProdutoCor, @precoCusto, @precoVenda, @quantidadeItem, @tamanhoItem";

                    sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);
                }
                    return true;

                }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possivel cancelar itens da Venda ! " + ex.Message);
            }
        }


        //-------------------------------ItemVendaTemp Para Tela de Lançamento
        //Busca tamanhos dos produtos para realizar a inserção nos tamanhos desejados OBS:Form Colocar informação prod
        public ItemVendaLista BuscarTamanhoItemVendaTemp(int codigoProdutoCor, int codigoVenda)
        {
            try
            {
                DataTable tabelaResultado;
                ItemVendaLista itemVendaLista = new ItemVendaLista();


                this.sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@codigoProdutoCor", codigoProdutoCor));
                sqlServer.AdicionarParametro(new SqlParameter("@codigoVenda", codigoVenda));

                string comando = "exec uspBuscarTamanhoItemVendaTemp @codigoProdutoCor, @codigoVenda";

                tabelaResultado = this.sqlServer.ExecutarConsulta(comando, CommandType.Text);

                if (tabelaResultado.Rows.Count == 0)
                {
                    //  throw new Exception("Não foram encontrados registros.");
                }

                foreach (DataRow registro in tabelaResultado.Rows)
                {
                    ItemVenda itemVenda= new ItemVenda();
                    itemVenda.ProdutoCor = new ProdutoCor();
                    itemVenda.ProdutoCor.Produto = new Produto();
                    itemVenda.ProdutoCor.Cor = new Cor();
                    itemVenda.ProdutoCor.Produto.Genero = new Genero();
                    itemVenda.Tamanho = new Tamanho();
                    itemVenda.Venda = new Venda();

                    itemVenda.codigoItemVenda = (Convert.ToInt32(registro[0]));
                    itemVenda.ProdutoCor.Cor.nomeCor = (registro[1].ToString());
                    itemVenda.Tamanho.codigoTamanho = (Convert.ToInt32(registro[2]));
                    itemVenda.Tamanho.nometamanho = (registro[3].ToString());
                    itemVenda.quantidadeVenda = Convert.ToInt32(registro[4]);
                    itemVenda.ProdutoCor.Produto.quantidadeProduto = (Convert.ToInt32(registro[5]));//Quantidade Estoque
                    itemVenda.precoCusto = Convert.ToDouble(registro[6]);
                    itemVenda.precoVenda = Convert.ToDouble(registro[7]);
                    itemVenda.codigoBarrasItem = (registro[8].ToString());
                    itemVenda.ProdutoCor.ImagemProduto = (registro[9].ToString());

                    itemVendaLista.Add(itemVenda);
                }

                return itemVendaLista;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar os Cores do Item. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Busca tamanhos dos produtos para realizar a inserção nos tamanhos desejados OBS:Form Colocar informação prod
        public ItemVendaLista BuscarItemVendaTempPorProduto(int codigoProdutoCor)
        {
            try
            {
                DataTable tabelaResultado;

                ItemVendaLista itemVendaLista = new ItemVendaLista();


                this.sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@codigoProdutoCor", codigoProdutoCor));

                string comando = "exec [uspBuscarItemVendaTempPorProduto] @codigoProdutoCor";

                tabelaResultado = this.sqlServer.ExecutarConsulta(comando, CommandType.Text);

                foreach (DataRow registro in tabelaResultado.Rows)
                {

                    ItemVenda itemVenda = new ItemVenda();
                    itemVenda.ProdutoCor = new ProdutoCor();
                    itemVenda.ProdutoCor.Produto = new Produto();
                    itemVenda.ProdutoCor.Cor = new Cor();
                    itemVenda.ProdutoCor.Produto.Genero = new Genero();
                    itemVenda.Tamanho = new Tamanho();
                    itemVenda.Venda = new Venda();

                    itemVenda.codigoItemVenda = (Convert.ToInt32(registro[0]));
                    itemVenda.ProdutoCor.Cor.nomeCor = (registro[1].ToString());
                    itemVenda.Tamanho.codigoTamanho = (Convert.ToInt32(registro[2]));
                    itemVenda.Tamanho.nometamanho = (registro[3].ToString());
                    itemVenda.quantidadeVenda = Convert.ToInt32(registro[4]);
                    itemVenda.ProdutoCor.Produto.quantidadeProduto = (Convert.ToInt32(registro[5]));//Quantidade Estoque
                    itemVenda.precoCusto = Convert.ToDouble(registro[6]);
                    itemVenda.precoVenda = Convert.ToDouble(registro[7]);
                    itemVenda.codigoBarrasItem = (registro[8].ToString());
                    itemVenda.ProdutoCor.ImagemProduto = (registro[9].ToString());

                    itemVendaLista.Add(itemVenda);
                }

                return itemVendaLista;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar os Cores do Item. [Negócios]. Motivo: " + ex.Message);
            }
        }
        
        //Excluir item venda temp
        public Boolean ExcluirItemVendaTemp(int codigoItem)
        {
            try
            {
                sqlServer.LimparParametros();

                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoItem", codigoItem));

                string comando = "exec uspExcluirItemVendatemp @codigoItem";

                object Resposta = sqlServer.ExecutarScalar(comando, System.Data.CommandType.Text);

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

        //metodo para realizar o lançamento no estoque  Obs: 1:P/2:M/3:GG  adicionados na hora 
        public Boolean CadastrarItemVendaListaTemp(ItemVendaLista itemlista)
        {
            try
            {
                foreach (ItemVenda item in itemlista)
                {

                    sqlServer.LimparParametros();

                    sqlServer.AdicionarParametro(new SqlParameter("@codigoVenda", item.Venda.codigoVenda));
                    sqlServer.AdicionarParametro(new SqlParameter("@codigoProdutoCor", item.ProdutoCor.codigoProdutoCor));
                    sqlServer.AdicionarParametro(new SqlParameter("@precoCusto", item.precoCusto));
                    sqlServer.AdicionarParametro(new SqlParameter("@precoVenda", item.precoVenda));
                    sqlServer.AdicionarParametro(new SqlParameter("@quantidade", item.quantidadeVenda));
                    sqlServer.AdicionarParametro(new SqlParameter("@tamanho", item.Tamanho.codigoTamanho));


                    string comandoSql = "exec uspCadastrarItemVendaTemp @codigoVenda, @codigoProdutoCor, @precoCusto, @precoVenda, @quantidade, @tamanho";

                    sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível cadastrar o Item da Venda. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Para Formulário de Venda
        public ItemVendaLista BuscarItemVendaTempPorVenda(int codigoVenda)
        {
            try
            {

                this.sqlServer.LimparParametros();

                sqlServer.AdicionarParametro(new SqlParameter("@codigoVenda", codigoVenda));
                string comandoSql = "exec uspBuscarItemVendaTempPorVenda @codigoVenda";

                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

                ItemVendaLista itemLista = new ItemVendaLista();

                foreach (DataRow registro in tabelaRetorno.Rows)
                {
                    ItemVenda item = new ItemVenda();
                    item.Venda = new Venda();
                    item.Tamanho = new Tamanho();
                    item.ProdutoCor = new ProdutoCor();
                    item.ProdutoCor.Cor = new Cor();
                    item.ProdutoCor.Produto = new Produto();
                    item.ProdutoCor.Produto.Genero = new Genero();

                    item.codigoItemVenda = (Convert.ToInt32(registro[0]));
                    item.Venda.codigoVenda = (Convert.ToInt32(registro[1]));

                    item.ProdutoCor.Produto.codigoProduto = (Convert.ToInt32(registro[2]));
                    item.ProdutoCor.codigoProdutoCor = (Convert.ToInt32(registro[3]));
                    item.ProdutoCor.Produto.descricaoProduto = (registro[4].ToString());
                    item.ProdutoCor.Produto.referenciaProduto = (registro[5].ToString());
                    item.ProdutoCor.Produto.sexoProduto = (registro[6].ToString());
                    item.ProdutoCor.Produto.Genero.nomeGenero = (registro[7].ToString());
                    item.ProdutoCor.Cor.nomeCor = (registro[8].ToString());
                    item.Tamanho.codigoTamanho = (Convert.ToInt32(registro[9]));
                    item.Tamanho.nometamanho = (registro[10].ToString());

                    item.quantidadeVenda = Convert.ToInt32(registro[11]);
                    item.precoCusto = Convert.ToDouble(registro[12]);
                    item.precoVenda = Convert.ToDouble(registro[13]);
                    item.codigoBarrasItem = (registro[14].ToString());

                    item.ProdutoCor.ImagemProduto = (registro[15].ToString());

                    itemLista.Add(item);
                    }

                return itemLista;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel buscar itens! " + ex.Message);
            }
        }

        //busca código de barras para realizar a venda
        public ItemVenda BuscarItemVendaTempPorBarras(String strCodigoBarras, int codigoVenda)
        {
            try
            {
                DataTable tabelaRetorno;
                ItemVenda item;

                this.sqlServer.LimparParametros();
                this.sqlServer.AdicionarParametro(new SqlParameter("@Barras", strCodigoBarras));
                this.sqlServer.AdicionarParametro(new SqlParameter("@codigoVenda", codigoVenda));

                string comando = "exec uspBuscarItemVendaTempPorBarras @Barras, @codigoVenda";

                tabelaRetorno = this.sqlServer.ExecutarConsulta(comando, CommandType.Text);


                if (tabelaRetorno.Rows.Count > 0)
                {
                    DataRow registro = tabelaRetorno.Rows[0];//Consulta só retorna uma objeto
                    item = new ItemVenda();
                    item.ProdutoCor = new ProdutoCor();
                    item.ProdutoCor.Produto = new Produto();
                    item.Tamanho = new Tamanho();

                    item.ProdutoCor.codigoProdutoCor = Convert.ToInt32(registro[0]);
                    item.ProdutoCor.Produto.descricaoProduto = (registro[1]).ToString();
                    item.precoCusto = Convert.ToDouble(registro[2]);
                    item.precoVenda = Convert.ToDouble(registro[3]);
                    item.ProdutoCor.Produto.quantidadeProduto = Convert.ToInt32(registro[4]); //Quantidade no estoque
                    item.Tamanho.codigoTamanho = Convert.ToInt32(registro[5]);
                    item.codigoBarrasItem = (registro[6]).ToString();

                    return item;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar o Código de Barras do Produto. [Negócios]. Motivo: " + ex.Message);
            }
        }
        
        //Cadastrar itemVenda temp por código de barras
        public Boolean CadastrarItemVendaTempBarras(ItemVenda item)
        {
            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@codigoVenda", item.Venda.codigoVenda));
                sqlServer.AdicionarParametro(new SqlParameter("@codigoProdutoCor", item.ProdutoCor.codigoProdutoCor));
                sqlServer.AdicionarParametro(new SqlParameter("@precoCusto", item.precoCusto));
                sqlServer.AdicionarParametro(new SqlParameter("@precoVenda", item.precoVenda));
                sqlServer.AdicionarParametro(new SqlParameter("@quantidade", item.quantidadeVenda));
                sqlServer.AdicionarParametro(new SqlParameter("@tamanho", item.Tamanho.codigoTamanho));

                string comandoSql = "exec uspCadastrarItemVendaTemp @codigoVenda, @codigoProdutoCor, @precoCusto, @precoVenda, @quantidade, @tamanho";

                sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível cadastrar o Item da Venda. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //metodo para excluir o item  
        public Boolean ExcluirItemVendaTempPorCodigo(int item)
        {
            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@codigo", item));

                string comandoSql = "exec uspExcluirItemVendaTempPorCodigo @codigo";
                object Resposta = sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                if (Convert.ToInt16(Resposta) == 1)
                {
                    //Estoque atendido não possivel remover retorna código item que não pode ser removido
                    return false;
                }

                //Foram Removidos com sucesso
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível excluir Item da Venda. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //metodo para excluir o item  por CodigoDaVeda
        public Boolean ExcluirItemVendaTempPorVenda(int codigoVenda)
        {
            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@codigoVenda", codigoVenda));

                string comandoSql = "exec uspExcluirItemVendaTempPorVenda @codigoVenda";
                object Resposta = sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                if (Convert.ToInt16(Resposta) == 1)
                {
                    //Estoque atendido não possivel remover retorna código item que não pode ser removido
                    return false;
                }

                //Foram Removidos com sucesso
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível excluir Itens da Venda. [Negócios]. Motivo: " + ex.Message);
            }
        }//Não aciona o gatilho
    }
}
