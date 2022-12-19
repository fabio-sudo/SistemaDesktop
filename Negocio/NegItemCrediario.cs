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
   public class NegItemCrediario

    {

       ConexaoSqlServer sqlServer = new ConexaoSqlServer();

        //------------------------ItemCrediario
        //Cadastrar itemCrediario
        public Boolean CadastrarItemCrediarioLista(ItemCrediarioLista itemlista)
        {
            try
            {
                foreach (ItemCrediario item in itemlista)
                {

                    sqlServer.LimparParametros();

                    sqlServer.AdicionarParametro(new SqlParameter("@codigoCrediario", item.Crediario.codigoCrediario));   
                    sqlServer.AdicionarParametro(new SqlParameter("@codigoVenda", item.Venda.codigoVenda));
                    sqlServer.AdicionarParametro(new SqlParameter("@codigoFormaPagamento", item.formaPagamento.codigoFormaPagamento));
                    sqlServer.AdicionarParametro(new SqlParameter("@codigoProdutoCor", item.ProdutoCor.codigoProdutoCor));
                    sqlServer.AdicionarParametro(new SqlParameter("@PrecoItem", item.valorItemCrediario));
                    sqlServer.AdicionarParametro(new SqlParameter("@quantidadeItem", item.quantidadeItemCrediario));
                    sqlServer.AdicionarParametro(new SqlParameter("@tamanhoItem", item.Tamanho.codigoTamanho));
                    sqlServer.AdicionarParametro(new SqlParameter("@dataVencimento", item.dataVencimentoItemCrediario));

                    string comandoSql = "exec uspCadastrarItemCrediario @codigoCrediario, @codigoVenda, @codigoFormaPagamento, @codigoProdutoCor, @PrecoItem, @quantidadeItem, @tamanhoItem, @dataVencimento";

                    sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível cadastrar o Item Crediario da Venda. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Excluir item crediario Estatus = Pago realiza cadastro item crediario Pago ou Pendente retorna estoque
        public Boolean ExcluirItemCrediario(ItemCrediarioLista itemLista)
        {
            try
            {

                foreach (ItemCrediario item in itemLista)
                {

                    sqlServer.LimparParametros();
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoItem", item.codigoItemCrediario));

                    string comando = "exec uspExcluirItemCrediario @codigoItem";

                    sqlServer.ExecutarScalar(comando, System.Data.CommandType.Text);

                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Erro na camada de negócios Item Crediario - Exclusão. " + ex.Message);
            }
        }

        //Excluir item crediario Voltando as quantidades para tabela estoque retirando o valor da venda e atualizado valor do estoque
        public Boolean ExcluirItemCrediarioCancela(ItemCrediarioLista itemLista)
        {
            try
            {

                foreach (ItemCrediario item in itemLista)
                {

                    sqlServer.LimparParametros();
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoItem", item.codigoItemCrediario));

                    string comando = "exec uspExcluirItemCrediarioCancela @codigoItem";

                    object Resposta = sqlServer.ExecutarScalar(comando, System.Data.CommandType.Text);

                    if (Convert.ToInt16(Resposta) == 2)
                    {
                        return false;//Erro
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Erro na camada de negócios Item Crediario - Exclusão. " + ex.Message);
            }
        }

        //Informa que o item foi pago coloca a forma de pagamento e desconto  -> Para Cad ItemCrediarioPago 
        public Boolean AlterarEstatusItemCrediario(ItemCrediarioLista itemLista)
        {
            try
            {

                // int indice=0;
                foreach (ItemCrediario item in itemLista)
                {

                    //int itematual = item[indice];

                    sqlServer.LimparParametros();
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoItem", item.codigoItemCrediario));
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@formaPagamento", item.formaPagamento));
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@descontoItem", item.descontoItemCrediario));//Usado Para descontos do cartão

                    string comandoSql = "exec uspAlterarItemCrediarioEstatus @codigoItem, @formaPagamento, @descontoItem";

                    sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Erro na camada de negócios - Alteração de Estatus. " + ex.Message);
            }
        }

        //Informa que o item foi pago coloca a forma de pagamento e desconto  -> Para Cad ItemCrediarioPago 
        public Boolean AlterarVencimentoItemCrediario(ItemCrediarioLista itemLista)
        {
            try
            {

                // int indice=0;
                foreach (ItemCrediario item in itemLista)
                {
                    sqlServer.LimparParametros();
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoItem", item.codigoItemCrediario));
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@vencimentoItem", item.dataVencimentoItemCrediario));

                    string comandoSql = "exec uspAlterarItemCrediarioVencimento @codigoItem, @vencimentoItem";

                    sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Erro na camada de negócios - Alteração de Vencimento. " + ex.Message);
            }
        }

       //--------------------------Consultas
       //Buscar itens do Crediario por codigo da Vedna -> Para Cancelamento
       public ItemCrediarioLista BuscarItemCrediarioPorVenda(int codigoVenda)
        {
            try
            {

                this.sqlServer.LimparParametros();

                sqlServer.AdicionarParametro(new SqlParameter("@codigoVenda", codigoVenda));
                string comandoSql = "exec uspBuscarItemCrediarioPorVenda @codigoVenda";

                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

                ItemCrediarioLista itemLista = new ItemCrediarioLista();
                ItemCrediario item = new ItemCrediario();

                foreach (DataRow registro in tabelaRetorno.Rows)
                {


                    item = new ItemCrediario();
                    item.Venda = new Venda();
                    item.Tamanho = new Tamanho();
                    item.ProdutoCor = new ProdutoCor();
                    item.ProdutoCor.Cor = new Cor();
                    item.ProdutoCor.Produto = new Produto();
                    item.ProdutoCor.Produto.Genero = new Genero();
                    //-------------Códigos
                    item.codigoItemCrediario = Convert.ToInt32(registro[0]);
                    item.Venda.codigoVenda = Convert.ToInt32(registro[1]);
                    item.ProdutoCor.Produto.codigoProduto = Convert.ToInt32(registro[2]);//Arrumar
                    item.ProdutoCor.codigoProdutoCor = Convert.ToInt32(registro[3]);
                    //-----------Descrição produto
                    item.ProdutoCor.Produto.descricaoProduto = (registro[4].ToString());
                    item.ProdutoCor.Produto.referenciaProduto = (registro[5].ToString());
                    item.ProdutoCor.Produto.sexoProduto = (registro[6].ToString());
                    item.ProdutoCor.Cor.nomeCor = (registro[7].ToString());
                    item.ProdutoCor.Produto.Genero.nomeGenero = (registro[8].ToString());
                    item.Tamanho.codigoTamanho = Convert.ToInt32(registro[9]);
                    item.Tamanho.nometamanho = (registro[10].ToString());
                    //----------Valores
                    item.quantidadeItemCrediario = Convert.ToInt32(registro[11]);
                    item.valorItemCrediario = Convert.ToDouble(registro[12]);
                    item.parcialItemCrediario = Convert.ToDouble(registro[13]);
                    item.descontoItemCrediario = Convert.ToDouble(registro[14]);
                    item.jurosItemCrediario = Convert.ToDouble(registro[15]);
                    //---------Descrição
                    item.codigoBarrasItem = (registro[16].ToString());//Arrumar
                    item.ProdutoCor.ImagemProduto = (registro[17].ToString());
                    //Estatus
                    item.estatusItem = (registro[18].ToString());
                    item.dataItemCrediario = Convert.ToDateTime(registro[19]);

                    itemLista.Add(item);
                }

                return itemLista;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel buscar itens! " + ex.Message);
            }
        }

       //Buscar itens do Crediario por codigo do crediario
       public ItemCrediarioLista BuscarItemCrediarioPorCrediario(int codigoCrediario)
       {
           try
           {

               this.sqlServer.LimparParametros();

               sqlServer.AdicionarParametro(new SqlParameter("@codigoCrediario", codigoCrediario));
               string comandoSql = "exec uspBuscarItemCrediarioPorCrediario @codigoCrediario";

               DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

               ItemCrediarioLista itemLista = new ItemCrediarioLista();
               ItemCrediario item = new ItemCrediario();


               foreach (DataRow registro in tabelaRetorno.Rows)
               {
                    item = new ItemCrediario();
                    item.Venda = new Venda();
                    item.Tamanho = new Tamanho();
                    item.ProdutoCor = new ProdutoCor();
                    item.ProdutoCor.Cor = new Cor();
                    item.ProdutoCor.Produto = new Produto();
                    item.ProdutoCor.Produto.Genero = new Genero();
                    //-------------Códigos
                    item.codigoItemCrediario = Convert.ToInt32(registro[0]);
                    item.Venda.codigoVenda = Convert.ToInt32(registro[1]);
                    item.ProdutoCor.Produto.codigoProduto = Convert.ToInt32(registro[3]);//Arrumar
                    item.ProdutoCor.codigoProdutoCor = Convert.ToInt32(registro[2]);
                    //-----------Descrição produto
                    item.ProdutoCor.Produto.descricaoProduto = (registro[4].ToString());
                    item.ProdutoCor.Produto.referenciaProduto = (registro[5].ToString());
                    item.ProdutoCor.Produto.sexoProduto = (registro[6].ToString());
                    item.ProdutoCor.Cor.nomeCor = (registro[7].ToString());
                    item.ProdutoCor.Produto.Genero.nomeGenero = (registro[8].ToString());
                    item.Tamanho.codigoTamanho = Convert.ToInt32(registro[9]);
                    item.Tamanho.nometamanho = (registro[10].ToString());
                    //----------Valores
                    item.quantidadeItemCrediario = Convert.ToInt32(registro[11]);
                    item.valorItemCrediario = Convert.ToDouble(registro[12]);
                    item.parcialItemCrediario = Convert.ToDouble(registro[13]);
                    item.descontoItemCrediario = Convert.ToDouble(registro[14]);
                    item.jurosItemCrediario = Convert.ToDouble(registro[15]);
                    //---------Descrição
                    item.codigoBarrasItem = (registro[16].ToString());//Arrumar
                    item.ProdutoCor.ImagemProduto = (registro[17].ToString());
                    //Estatus
                    item.estatusItem = (registro[18].ToString());
                    item.dataItemCrediario = Convert.ToDateTime(registro[19]);
                    item.dataVencimentoItemCrediario = Convert.ToDateTime(registro[20]);

                   itemLista.Add(item);
               }

               return itemLista;

           }
           catch (Exception ex)
           {
               throw new Exception("Não foi possivel buscar itens! " + ex.Message);
           }
       }

       //------------------------ItemCrediarioPago -> 

       //Cadastrar itemCrediario
       public Boolean CadastrarItemCrediarioPagoLista(ItemCrediarioLista itemlista)
       {
           try
           {
               foreach (ItemCrediario item in itemlista)
               {

                   sqlServer.LimparParametros();

                   sqlServer.AdicionarParametro(new SqlParameter("@codigoCrediario", item.Crediario.codigoCrediario));
                   sqlServer.AdicionarParametro(new SqlParameter("@codigoVenda", item.Venda.codigoVenda));
                   sqlServer.AdicionarParametro(new SqlParameter("@codigoFormaPagamento", item.formaPagamento.codigoFormaPagamento));
                   sqlServer.AdicionarParametro(new SqlParameter("@codigoProdutoCor", item.ProdutoCor.codigoProdutoCor));
                   sqlServer.AdicionarParametro(new SqlParameter("@PrecoItem", item.valorItemCrediario));
                   sqlServer.AdicionarParametro(new SqlParameter("@quantidadeItem", item.quantidadeItemCrediario));
                   sqlServer.AdicionarParametro(new SqlParameter("@tamanhoItem", item.Tamanho.codigoTamanho));
                   sqlServer.AdicionarParametro(new SqlParameter("@ParcialItem", item.parcialItemCrediario));
                   sqlServer.AdicionarParametro(new SqlParameter("@DescontoItem", item.descontoItemCrediario));
                   sqlServer.AdicionarParametro(new SqlParameter("@JurosItem", item.jurosItemCrediario));
                   sqlServer.AdicionarParametro(new SqlParameter("@DescontoVenda", item.Venda.descontoVenda));
                   sqlServer.AdicionarParametro(new SqlParameter("@JurosVenda", item.Venda.jurosVenda));

                   string comandoSql = "exec uspCadastrarItemCrediarioPago @codigoCrediario, @codigoVenda, @codigoFormaPagamento, @codigoProdutoCor, @PrecoItem, @quantidadeItem, @tamanhoItem, @ParcialItem, @DescontoItem, @JurosItem, @DescontoVenda, @JurosVenda";

                   sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);
               }

               return true;
           }
           catch (Exception ex)
           {
               return false;
               throw new Exception("Não foi possível cadastrar o Item Crediario da Venda. [Negócios]. Motivo: " + ex.Message);
           }
       }

       //Excluir ItemCrediarioPago Retorna ESTOQUE & VENDA
       public Boolean ExcluirItemCrediarioPago(ItemCrediarioLista itemLista)
       {
           try
           {

               foreach (ItemCrediario item in itemLista)
               {

                   sqlServer.LimparParametros();
                   sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoItem", item.codigoItemCrediario));

                   string comando = "exec uspExcluirItemCrediarioPago @codigoItem";

                   sqlServer.ExecutarScalar(comando, System.Data.CommandType.Text);

               }
               return true;
           }
           catch (Exception ex)
           {
               return false;
               throw new Exception("Erro na camada de negócios Item Crediario - Exclusão. " + ex.Message);
           }
       }

       //Excluir ItemCrediarioPago -> Retornando Item para ItemCrediario
       public Boolean ExcluirItemCrediarioPagoCancela(ItemCrediarioLista itemLista)
       {
           try
           {

               foreach (ItemCrediario item in itemLista)
               {

                   sqlServer.LimparParametros();
                   sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoItem", item.codigoItemCrediario));

                   string comando = "exec uspExcluirItemCrediarioPagoCancela @codigoItem";

                   object Resposta = sqlServer.ExecutarScalar(comando, System.Data.CommandType.Text);

                   if (Convert.ToInt16(Resposta) == 2)
                   {
                       return false;//Erro
                   }
               }
               return true;
           }
           catch (Exception ex)
           {
               return false;
               throw new Exception("Erro na camada de negócios Item Crediario - Exclusão. " + ex.Message);
           }
       }

       //------------------------Consultas
       //Buscar Itens do Crediario Pago por codigo do Crediario/Cliente
       public ItemCrediarioLista BuscarItemCrediarioPagoPorCrediario(int codigoCrediario)
       {
           try
           {

               this.sqlServer.LimparParametros();

               sqlServer.AdicionarParametro(new SqlParameter("@codigoCrediario", codigoCrediario));
               string comandoSql = "exec uspBuscarItemCrediarioPagoPorCrediario @codigoCrediario";

               DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

               ItemCrediarioLista itemLista = new ItemCrediarioLista();
               ItemCrediario item = new ItemCrediario();


               foreach (DataRow registro in tabelaRetorno.Rows)
               {
                   item = new ItemCrediario();
                   item.Venda = new Venda();
                   item.formaPagamento = new FormaPagamento();
                   item.Tamanho = new Tamanho();
                   item.ProdutoCor = new ProdutoCor();
                   item.ProdutoCor.Cor = new Cor();
                   item.ProdutoCor.Produto = new Produto();
                   item.ProdutoCor.Produto.Genero = new Genero();

                   //-------------Códigos
                   item.codigoItemCrediario = Convert.ToInt32(registro[0]);
                   item.Venda.codigoVenda = Convert.ToInt32(registro[1]);
                   item.ProdutoCor.Produto.codigoProduto = Convert.ToInt32(registro[3]);//Arrumar
                   item.ProdutoCor.codigoProdutoCor = Convert.ToInt32(registro[2]);
                   //-----------Descrição produto
                   item.ProdutoCor.Produto.descricaoProduto = (registro[4].ToString());
                   item.ProdutoCor.Produto.referenciaProduto = (registro[5].ToString());
                   item.ProdutoCor.Produto.sexoProduto = (registro[6].ToString());
                   item.ProdutoCor.Cor.nomeCor = (registro[7].ToString());
                   item.ProdutoCor.Produto.Genero.nomeGenero = (registro[8].ToString());
                   item.Tamanho.codigoTamanho = Convert.ToInt32(registro[9]);
                   item.Tamanho.nometamanho = (registro[10].ToString());
                   //----------Valores
                   item.quantidadeItemCrediario = Convert.ToInt32(registro[11]);
                   item.valorItemCrediario = Convert.ToDouble(registro[12]);
                   item.recebidoItemCrediario = Convert.ToDouble(registro[13]);//Valor realmente recebido
                   item.parcialItemCrediario = Convert.ToDouble(registro[14]);//Valor Liquido da parcial

                   item.formaPagamento.codigoFormaPagamento = Convert.ToInt32(registro[15]);
                   item.formaPagamento.formaPagamento = registro[16].ToString();
                   item.descontoItemCrediario = Convert.ToDouble(registro[17]);
                   item.jurosItemCrediario = Convert.ToDouble(registro[18]);
                   //---------Descrição
                   item.codigoBarrasItem = (registro[19].ToString());//Arrumar
                   item.ProdutoCor.ImagemProduto = (registro[20].ToString());
                   //Estatus
                   item.estatusItem = (registro[21].ToString());
                   item.dataItemCrediario = Convert.ToDateTime(registro[22]);

                   itemLista.Add(item);
               }

               return itemLista;

           }
           catch (Exception ex)
           {
               throw new Exception("Não foi possivel buscar itens! " + ex.Message);
           }
       }

        //Buscar itens do Crediario Pago por codigo da Vedna -> Para Cancelamento
       public ItemCrediarioLista BuscarItemCrediarioPagoPorVenda(int codigoVenda)
       {
           try
           {

               this.sqlServer.LimparParametros();

               sqlServer.AdicionarParametro(new SqlParameter("@codigoVenda", codigoVenda));
               string comandoSql = "exec uspBuscarItemCrediarioPagoPorVenda @codigoVenda";

               DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

               ItemCrediarioLista itemLista = new ItemCrediarioLista();
               ItemCrediario item = new ItemCrediario();

               foreach (DataRow registro in tabelaRetorno.Rows)
               {


                   item = new ItemCrediario();
                   item.Venda = new Venda();
                   item.Tamanho = new Tamanho();
                   item.ProdutoCor = new ProdutoCor();
                   item.ProdutoCor.Cor = new Cor();
                   item.ProdutoCor.Produto = new Produto();
                   item.ProdutoCor.Produto.Genero = new Genero();

                   item.codigoItemCrediario = Convert.ToInt32(registro[0]);
                   item.Venda.codigoVenda = Convert.ToInt32(registro[1]);
                   item.ProdutoCor.codigoProdutoCor = Convert.ToInt32(registro[2]);
                   item.ProdutoCor.Produto.descricaoProduto = (registro[3].ToString());
                   item.ProdutoCor.Produto.referenciaProduto = (registro[4].ToString());
                   item.ProdutoCor.Produto.sexoProduto = (registro[5].ToString());
                   item.ProdutoCor.Produto.Genero.nomeGenero = (registro[6].ToString());
                   item.ProdutoCor.Cor.nomeCor = (registro[7].ToString());
                   item.Tamanho.codigoTamanho = Convert.ToInt32(registro[8]);
                   item.Tamanho.nometamanho = (registro[9].ToString());
                   item.quantidadeItemCrediario = Convert.ToInt32(registro[10]);
                   item.valorItemCrediario = Convert.ToDouble(registro[11]);
                   item.parcialItemCrediario = Convert.ToDouble(registro[12]);
                   //item.formaPagamento = (registro[13].ToString());
                   item.descontoItemCrediario = Convert.ToDouble(registro[14]);
                   //item.ProdutoCor.Produto.codigoBarrasProduto = (registro[15].ToString());
                   item.ProdutoCor.ImagemProduto = (registro[16].ToString());
                   item.estatusItem = (registro[17].ToString());
                   item.dataItemCrediario = Convert.ToDateTime(registro[18]);

                   itemLista.Add(item);
               }

               return itemLista;

           }
           catch (Exception ex)
           {
               throw new Exception("Não foi possivel buscar itens! " + ex.Message);
           }
       }

       //Buscar Itens do Crediario Pago por codigo do Filtros Crediario, Produto, FormaPagamento, DataInicial e DataFinal
       public ItemCrediarioLista BuscarItemCrediarioPagoPorFiltros(int codigoCrediario, string nomeProduto, string formaPagamento, DateTime dataInicial, DateTime dataFinal)
       {
           try
           {

               this.sqlServer.LimparParametros();

               sqlServer.AdicionarParametro(new SqlParameter("@codigoCrediario", codigoCrediario));
               sqlServer.AdicionarParametro(new SqlParameter("@nomeProduto", nomeProduto));
               sqlServer.AdicionarParametro(new SqlParameter("@formaPagamento", formaPagamento));
               sqlServer.AdicionarParametro(new SqlParameter("@dataInicial", dataInicial));
               sqlServer.AdicionarParametro(new SqlParameter("@dataFinal", dataFinal));

               string comandoSql = "exec uspBuscarItemCrediarioPagoPorFiltros @codigoCrediario, @nomeProduto, @formaPagamento, @dataInicial, @dataFinal";

               DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

               ItemCrediarioLista itemLista = new ItemCrediarioLista();
               ItemCrediario item = new ItemCrediario();


               foreach (DataRow registro in tabelaRetorno.Rows)
               {
                   item = new ItemCrediario();
                   item.Venda = new Venda();
                   item.formaPagamento = new FormaPagamento();
                   item.Tamanho = new Tamanho();
                   item.ProdutoCor = new ProdutoCor();
                   item.ProdutoCor.Cor = new Cor();
                   item.ProdutoCor.Produto = new Produto();
                   item.ProdutoCor.Produto.Genero = new Genero();

                   //-------------Códigos
                   item.codigoItemCrediario = Convert.ToInt32(registro[0]);
                   item.Venda.codigoVenda = Convert.ToInt32(registro[1]);
                   item.ProdutoCor.Produto.codigoProduto = Convert.ToInt32(registro[3]);//Arrumar
                   item.ProdutoCor.codigoProdutoCor = Convert.ToInt32(registro[2]);
                   //-----------Descrição produto
                   item.ProdutoCor.Produto.descricaoProduto = (registro[4].ToString());
                   item.ProdutoCor.Produto.referenciaProduto = (registro[5].ToString());
                   item.ProdutoCor.Produto.sexoProduto = (registro[6].ToString());
                   item.ProdutoCor.Cor.nomeCor = (registro[7].ToString());
                   item.ProdutoCor.Produto.Genero.nomeGenero = (registro[8].ToString());
                   item.Tamanho.codigoTamanho = Convert.ToInt32(registro[9]);
                   item.Tamanho.nometamanho = (registro[10].ToString());
                   //----------Valores
                   item.quantidadeItemCrediario = Convert.ToInt32(registro[11]);
                   item.valorItemCrediario = Convert.ToDouble(registro[12]);
                   item.recebidoItemCrediario = Convert.ToDouble(registro[13]);//Valor realmente recebido
                   item.parcialItemCrediario = Convert.ToDouble(registro[14]);//Valor Liquido da parcial

                   item.formaPagamento.formaPagamento = registro[15].ToString();
                   item.descontoItemCrediario = Convert.ToDouble(registro[16]);
                   item.jurosItemCrediario = Convert.ToDouble(registro[17]);
                   //---------Descrição
                   item.codigoBarrasItem = (registro[18].ToString());//Arrumar
                   item.ProdutoCor.ImagemProduto = (registro[19].ToString());
                   //Estatus
                   item.estatusItem = (registro[20].ToString());
                   item.dataItemCrediario = Convert.ToDateTime(registro[21]);

                   itemLista.Add(item);
               }

               return itemLista;

           }
           catch (Exception ex)
           {
               throw new Exception("Não foi possivel buscar itens! " + ex.Message);
           }
       }
       


        //------------------------ItemCrediarioParcial

       //-------Cadastrar -> Pagamento ItemCrediario Tela 
       public Boolean CadastrarItemCrediarioParcial(ItemCrediarioParcial item)
       {
           try
           {

               sqlServer.LimparParametros();
               sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoItemCrediario", item.ItemCrediario.codigoItemCrediario));
               sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoCrediario", item.ItemCrediario.Crediario.codigoCrediario));
               sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@formaPagamento", item.FormaPagamento.codigoFormaPagamento));
               sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoProdutoCor", item.ProdutoCor.codigoProdutoCor));
               sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@tamanhoItem", item.Tamanho.codigoTamanho));
               sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@valorBruto", item.valorParcialBruto));//Valor que realmente foi recebido com Taxas e Desconto se houver  
               sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@valorPago", item.valorPagoParcial));  
               sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@descontoParcial", item.descontoParcial));
               sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@jurosParcial", item.jurosParcial));
               //------------Venda
               sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@descontoVenda", item.ItemCrediario.Venda.descontoVenda));
               sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@jurosVenda", item.ItemCrediario.Venda.jurosVenda));


               string comandoSql = "exec uspCadastrarItemCrediarioParcial @codigoItemCrediario, @codigoCrediario, @formaPagamento, @codigoProdutoCor, @tamanhoItem, @valorBruto, @valorPago, @descontoParcial, @jurosParcial, @descontoVenda, @jurosVenda";
               object Resposta =  sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

               if (Convert.ToInt16(Resposta) != 2)
               {

                   return true;
               }
               else { return false; }
           }
           catch (Exception ex)
           {
               return false;
               throw new Exception("Erro no camada de negocios - Cadastrar: " + ex.Message);
           }
       }

       //-------Cadastrar -> Pagamento ItemCrediario Tela 
       public Boolean CadastrarItemCrediarioParcialLista(ItemCrediarioParcialLista itemLista)
       {
           try
           {
               foreach (ItemCrediarioParcial item in itemLista)
               {

                   sqlServer.LimparParametros();
                   sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoItemCrediario", item.ItemCrediario.codigoItemCrediario));
                   sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoCrediario", item.ItemCrediario.Crediario.codigoCrediario));
                   sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@formaPagamento", item.FormaPagamento.codigoFormaPagamento));
                   sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoProdutoCor", item.ProdutoCor.codigoProdutoCor));
                   sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@tamanhoItem", item.Tamanho.codigoTamanho));
                   sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@valorBruto", item.valorParcialBruto));//Valor que realmente foi recebido com Taxas e Desconto se houver  
                   sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@valorPago", item.valorPagoParcial));
                   sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@descontoParcial", item.descontoParcial));
                   sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@jurosParcial", item.jurosParcial));
                   //------------Venda
                   sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@descontoVenda", item.ItemCrediario.Venda.descontoVenda));
                   sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@jurosVenda", item.ItemCrediario.Venda.jurosVenda));


                   string comandoSql = "exec uspCadastrarItemCrediarioParcial @codigoItemCrediario, @codigoCrediario, @formaPagamento, @codigoProdutoCor, @tamanhoItem, @valorBruto, @valorPago, @descontoParcial, @jurosParcial, @descontoVenda, @jurosVenda";
                   object Resposta = sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                   if (Convert.ToInt16(Resposta) != 2)
                   {

                       return true;
                   }
                   else { return false; }
               }

               return true;
           }
           catch (Exception ex)
           {
               return false;
               throw new Exception("Erro no camada de negocios - Cadastrar: " + ex.Message);
           }
       }

       //-------Alterar -> Pagamento ItemCrediario Tela-> Quando Item já tem Parcial realiza o cadastro de uma nova parcial para 0 o ITEM
       public Boolean AlterarItemCrediarioParcial(ItemCrediarioParcial item)
       {
           try
           {
               sqlServer.LimparParametros();
               sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoItemCrediario", item.ItemCrediario.codigoItemCrediario));
               sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoCliente", item.ItemCrediario.Crediario.codigoCrediario));
               sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoProdutoCor", item.ProdutoCor.codigoProdutoCor));
               sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@tamanhoItem", item.Tamanho.codigoTamanho));
               sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@valorPago", item.valorPagoParcial));
               //sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@formaPagamentoItem", item.formaPagamento));
               sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@descontoParcial", item.descontoParcial));//Usado Para descontos do cartão

               string comandoSql = "exec uspAlterarItemCrediarioParcial @codigoItemCrediario, @codigoCliente, @codigoProdutoCor, @tamanhoItem, @valorPago, @formaPagamentoItem, @descontoParcial ";

               object Resposta = sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

               if (Convert.ToInt16(Resposta) == 1 || Convert.ToInt16(Resposta) == 2)
               {
                   return false;
               }

               return true;
           }
           catch (Exception ex)
           {
               return false;
               throw new Exception("Erro no camada de negocios - Alterar: " + ex.Message);
           }
       }

       //-------Excluir Parcial por item
       public Boolean ExcluirItemCrediarioParcialLista(ItemCrediarioParcialLista items)//Lista de items a excluir
       {
           try
           {
               foreach (ItemCrediarioParcial item in items)
               {
                   sqlServer.LimparParametros();
                   sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigo", item.CodigoParcial));

                   string comando = "exec uspExcluirItemCrediarioParcial @codigo";

                   sqlServer.ExecutarScalar(comando, System.Data.CommandType.Text);

                   object Resposta = sqlServer.ExecutarScalar(comando, System.Data.CommandType.Text);

                   if (Convert.ToInt16(Resposta) == 2)
                   {
                       return false;//Erro
                   }
               }
               return true;
           }
           catch (Exception ex)
           {
               return false;
               throw new Exception("Erro na camada de negócios - Exclusão. " + ex.Message);
           }
       }

       //Excluir Parcial Por ITem
       public Boolean ExcluirItemCrediarioParcialPorItemCrediario(ItemCrediarioParcialLista items)//Lista de items a excluir
       {
           try
           {

               foreach (ItemCrediarioParcial item in items)
               {

                       sqlServer.LimparParametros();
                       sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigo", item.ItemCrediario.codigoItemCrediario));

                       string comando = "exec uspExcluirItemCrediarioParcialPorItemCrediario @codigo";


                       object Resposta = sqlServer.ExecutarScalar(comando, System.Data.CommandType.Text);

                       if (Convert.ToInt16(Resposta) == 2)
                       {
                           return false;//Erro
                       }
                   }
                   return true;
           }
           catch (Exception ex)
           {
               return false;
               throw new Exception("Erro na camada de negócios - Exclusão. " + ex.Message);
           }
       }

       
       //----------------------Consultas
       
       //Por codigo Cliente
       public ItemCrediarioParcialLista BuscarItemCrediarioParcialPorCliente(string nomeCliente)
       {
           try
           {

               this.sqlServer.LimparParametros();
               this.sqlServer.AdicionarParametro(new SqlParameter("@nomeCliente", nomeCliente));
               string comandoSql = "exec uspBuscarItemCrediarioParcialPorCliente @nomeCliente";

               DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

               ItemCrediarioParcialLista itemsParcial = new ItemCrediarioParcialLista();
               ItemCrediarioParcial parcial;

               foreach (DataRow registro in tabelaRetorno.Rows)
               {

                   parcial = new ItemCrediarioParcial();
                   parcial.ItemCrediario = new ItemCrediario();
                   parcial.ItemCrediario.Crediario = new Crediario();
                   parcial.Cliente = new Cliente();
                   parcial.Tamanho = new Tamanho();
                   parcial.ProdutoCor = new ProdutoCor();
                   parcial.ProdutoCor.Cor = new Cor();
                   parcial.ProdutoCor.Produto = new Produto();
                   parcial.ProdutoCor.Produto.Genero = new Genero();
                   parcial.FormaPagamento = new FormaPagamento();

                   //----UK e FK
                   parcial.Cliente.codigoCliente = Convert.ToInt32(registro[0]);
                   parcial.ItemCrediario.codigoItemCrediario = Convert.ToInt32(registro[1]);
                   parcial.CodigoParcial = Convert.ToInt32(registro[2]);
                   parcial.ProdutoCor.codigoProdutoCor = Convert.ToInt32(registro[3]);
                  //-----Produto
                   parcial.ProdutoCor.Produto.codigoProduto = Convert.ToInt32(registro[4]);
                   parcial.ProdutoCor.Produto.descricaoProduto = registro[5].ToString();
                   parcial.ProdutoCor.Produto.referenciaProduto = registro[6].ToString();
                   parcial.Tamanho.codigoTamanho = Convert.ToInt32(registro[7]);
                   parcial.Tamanho.nometamanho = registro[8].ToString();
                   //------Valores
                   parcial.parcelaParcial = Convert.ToInt32(registro[9]);
                   parcial.valorParcialBruto = Convert.ToDouble(registro[10]);
                   parcial.valorPagoParcial = Convert.ToDouble(registro[11]);
                   //------FormaPagamento
                   parcial.FormaPagamento.codigoFormaPagamento = Convert.ToInt32(registro[12]);
                   parcial.FormaPagamento.formaPagamento = registro[13].ToString();
                   //-------Taxas e Desconto
                   parcial.descontoParcial = Convert.ToDouble(registro[14]);
                   parcial.jurosParcial = Convert.ToDouble(registro[15]);
                   //------Parcial
                   parcial.ProdutoCor.ImagemProduto = registro[16].ToString();
                   parcial.dataParcial = Convert.ToDateTime(registro[17]);
                   parcial.estatusParcial = registro[18].ToString();

                   itemsParcial.Add(parcial);
               }

               return itemsParcial;

           }
           catch (Exception ex) {
               throw new Exception("Erro ao buscar Parcial Por Cliente/Crediario: "+ex.Message);
           }
       }
       
       //Por Data
       public ItemCrediarioParcialLista BuscarItemCrediarioParcialPorData(DateTime dataInicial, DateTime dataFinal)
       {
           try
           {

               this.sqlServer.LimparParametros();
               this.sqlServer.AdicionarParametro(new SqlParameter("@dataInicial", dataInicial));
               this.sqlServer.AdicionarParametro(new SqlParameter("@dataIFinal", dataFinal));

               string comandoSql = "exec uspBuscarItemCrediarioParcialPorData @dataInicial, @dataIFinal";

               DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

               ItemCrediarioParcialLista itemsParcial = new ItemCrediarioParcialLista();
               ItemCrediarioParcial parcial;

               foreach (DataRow registro in tabelaRetorno.Rows)
               {

                   parcial = new ItemCrediarioParcial();
                   parcial.ItemCrediario = new ItemCrediario();
                   parcial.ItemCrediario.Crediario = new Crediario();
                   parcial.Cliente = new Cliente();
                   parcial.Tamanho = new Tamanho();
                   parcial.ProdutoCor = new ProdutoCor();
                   parcial.ProdutoCor.Cor = new Cor();
                   parcial.ProdutoCor.Produto = new Produto();
                   parcial.ProdutoCor.Produto.Genero = new Genero();
                   parcial.FormaPagamento = new FormaPagamento();

                   //----UK e FK
                   parcial.Cliente.codigoCliente = Convert.ToInt32(registro[0]);
                   parcial.ItemCrediario.codigoItemCrediario = Convert.ToInt32(registro[1]);
                   parcial.CodigoParcial = Convert.ToInt32(registro[2]);
                   parcial.ProdutoCor.codigoProdutoCor = Convert.ToInt32(registro[3]);
                   //-----Produto
                   parcial.ProdutoCor.Produto.codigoProduto = Convert.ToInt32(registro[4]);
                   parcial.ProdutoCor.Produto.descricaoProduto = registro[5].ToString();
                   parcial.ProdutoCor.Produto.referenciaProduto = registro[6].ToString();
                   parcial.Tamanho.codigoTamanho = Convert.ToInt32(registro[7]);
                   parcial.Tamanho.nometamanho = registro[8].ToString();
                   //------Valores
                   parcial.parcelaParcial = Convert.ToInt32(registro[9]);
                   parcial.valorParcialBruto = Convert.ToDouble(registro[10]);
                   parcial.valorPagoParcial = Convert.ToDouble(registro[11]);
                   //------FormaPagamento
                   parcial.FormaPagamento.codigoFormaPagamento = Convert.ToInt32(registro[12]);
                   parcial.FormaPagamento.formaPagamento = registro[13].ToString();
                   //-------Taxas e Desconto
                   parcial.descontoParcial = Convert.ToDouble(registro[14]);
                   parcial.jurosParcial = Convert.ToDouble(registro[15]);
                   //------Parcial
                   parcial.ProdutoCor.ImagemProduto = registro[16].ToString();
                   parcial.dataParcial = Convert.ToDateTime(registro[17]);
                   parcial.estatusParcial = registro[18].ToString();

                   itemsParcial.Add(parcial);
               }

               return itemsParcial;

           }
           catch (Exception ex)
           {
               throw new Exception("Erro ao buscar Parcial Por Cliente/Crediario: " + ex.Message);
           }
       }
      
       //Por Cliente e Data
       public ItemCrediarioParcialLista BuscarItemCrediarioParcialPorClienteEData(string nomeCliente, DateTime dataInicial, DateTime dataFinal)
       {
           try
           {

               this.sqlServer.LimparParametros();
               this.sqlServer.AdicionarParametro(new SqlParameter("@nomeCliente", nomeCliente));
               this.sqlServer.AdicionarParametro(new SqlParameter("@dataInicial", dataInicial));
               this.sqlServer.AdicionarParametro(new SqlParameter("@dataIFinal", dataFinal));

               string comandoSql = "exec uspBuscarItemCrediarioParcialPorClienteEData @nomeCliente, @dataInicial, @dataIFinal";

               DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

               ItemCrediarioParcialLista itemsParcial = new ItemCrediarioParcialLista();
               ItemCrediarioParcial parcial;

               foreach (DataRow registro in tabelaRetorno.Rows)
               {

                   parcial = new ItemCrediarioParcial();
                   parcial.ItemCrediario = new ItemCrediario();
                   parcial.ItemCrediario.Crediario = new Crediario();
                   parcial.Cliente = new Cliente();
                   parcial.Tamanho = new Tamanho();
                   parcial.ProdutoCor = new ProdutoCor();
                   parcial.ProdutoCor.Cor = new Cor();
                   parcial.ProdutoCor.Produto = new Produto();
                   parcial.ProdutoCor.Produto.Genero = new Genero();
                   parcial.FormaPagamento = new FormaPagamento();

                   //----UK e FK
                   parcial.Cliente.codigoCliente = Convert.ToInt32(registro[0]);
                   parcial.ItemCrediario.codigoItemCrediario = Convert.ToInt32(registro[1]);
                   parcial.CodigoParcial = Convert.ToInt32(registro[2]);
                   parcial.ProdutoCor.codigoProdutoCor = Convert.ToInt32(registro[3]);
                   //-----Produto
                   parcial.ProdutoCor.Produto.codigoProduto = Convert.ToInt32(registro[4]);
                   parcial.ProdutoCor.Produto.descricaoProduto = registro[5].ToString();
                   parcial.ProdutoCor.Produto.referenciaProduto = registro[6].ToString();
                   parcial.Tamanho.codigoTamanho = Convert.ToInt32(registro[7]);
                   parcial.Tamanho.nometamanho = registro[8].ToString();
                   //------Valores
                   parcial.parcelaParcial = Convert.ToInt32(registro[9]);
                   parcial.valorParcialBruto = Convert.ToDouble(registro[10]);
                   parcial.valorPagoParcial = Convert.ToDouble(registro[11]);
                   //------FormaPagamento
                   parcial.FormaPagamento.codigoFormaPagamento = Convert.ToInt32(registro[12]);
                   parcial.FormaPagamento.formaPagamento = registro[13].ToString();
                   //-------Taxas e Desconto
                   parcial.descontoParcial = Convert.ToDouble(registro[14]);
                   parcial.jurosParcial = Convert.ToDouble(registro[15]);
                   //------Parcial
                   parcial.ProdutoCor.ImagemProduto = registro[16].ToString();
                   parcial.dataParcial = Convert.ToDateTime(registro[17]);
                   parcial.estatusParcial = registro[18].ToString();

                   itemsParcial.Add(parcial);
               }

               return itemsParcial;

           }
           catch (Exception ex)
           {
               throw new Exception("Erro ao buscar Parcial Por Cliente/Crediario: " + ex.Message);
           }
       }

       //-------Buscar Parcial Por ItemCrediario
       public ItemCrediarioParcialLista BuscarItemCrediarioParcialPorItemCrediario(int ItemCrediario)
       {
           try
           {
          
           this.sqlServer.LimparParametros();
           this.sqlServer.AdicionarParametro(new SqlParameter("@codigoItemCrediario", ItemCrediario));
           
           string comandoSql = "exec uspBuscarItemCrediarioParcialPorItemCrediario @codigoItemCrediario";

           DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

           ItemCrediarioParcialLista itemsParcial = new ItemCrediarioParcialLista();
           ItemCrediarioParcial parcial;

           foreach (DataRow registro in tabelaRetorno.Rows)
           {

               parcial = new ItemCrediarioParcial();
               parcial.ItemCrediario = new ItemCrediario();
               parcial.ItemCrediario.Crediario = new Crediario();
               parcial.Cliente = new Cliente();
               parcial.Tamanho = new Tamanho();
               parcial.ProdutoCor = new ProdutoCor();
               parcial.ProdutoCor.Cor = new Cor();
               parcial.ProdutoCor.Produto = new Produto();
               parcial.ProdutoCor.Produto.Genero = new Genero();
               parcial.FormaPagamento = new FormaPagamento();

               //----UK e FK
               parcial.Cliente.codigoCliente = Convert.ToInt32(registro[0]);
               parcial.ItemCrediario.codigoItemCrediario = Convert.ToInt32(registro[1]);
               parcial.CodigoParcial = Convert.ToInt32(registro[2]);
               parcial.ProdutoCor.codigoProdutoCor = Convert.ToInt32(registro[3]);
               //-----Produto
               parcial.ProdutoCor.Produto.codigoProduto = Convert.ToInt32(registro[4]);
               parcial.ProdutoCor.Produto.descricaoProduto = registro[5].ToString();
               parcial.ProdutoCor.Produto.referenciaProduto = registro[6].ToString();
               parcial.Tamanho.codigoTamanho = Convert.ToInt32(registro[7]);
               parcial.Tamanho.nometamanho = registro[8].ToString();
               //------Valores
               parcial.parcelaParcial = Convert.ToInt32(registro[9]);
               parcial.valorParcialBruto = Convert.ToDouble(registro[10]);
               parcial.valorPagoParcial = Convert.ToDouble(registro[11]);
               //------FormaPagamento
               parcial.FormaPagamento.codigoFormaPagamento = Convert.ToInt32(registro[12]);
               parcial.FormaPagamento.formaPagamento = registro[13].ToString();
               //-------Taxas e Desconto
               parcial.descontoParcial = Convert.ToDouble(registro[14]);
               parcial.jurosParcial = Convert.ToDouble(registro[15]);
               //------Parcial
               parcial.ProdutoCor.ImagemProduto = registro[16].ToString();
               parcial.dataParcial = Convert.ToDateTime(registro[17]);
               parcial.estatusParcial = registro[18].ToString();

               itemsParcial.Add(parcial);
           }

           return itemsParcial;

           }
           catch (Exception ex)
           {
               throw new Exception("Erro ao buscar Parcial Por ItemCrediario/Crediario: " + ex.Message);
           }
       }

       //-----------------------Validação
       //-------Valida se o item ainda tem parcial -> Para cancelamento do ItemCrediario
       public Boolean ValidaParcial(int ItemCrediario)
       {

           try
           {

               sqlServer.LimparParametros();
               sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigo", ItemCrediario));

               string comando = "exec uspValidaParcial @codigo";

               object Resposta = sqlServer.ExecutarScalar(comando, System.Data.CommandType.Text);

               if (Convert.ToInt16(Resposta) == 3 || Convert.ToInt16(Resposta) == 2)
               {
                   return false;//Item tem Parcial 
               }
               else
                   return true;//Pode proceguir com a exclusão

           }
           catch (Exception ex)
           {
               return false;
               throw new Exception("Erro na camada de negócios - Valida. " + ex.Message);
           }

       }

    }
}
