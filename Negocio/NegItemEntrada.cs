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
    public class NegItemEntrada
    {
        private ConexaoSqlServer sqlServer = new ConexaoSqlServer();

        //metodo para realizar o lançamento no estoque  Obs: 1:P/2:M/3:GG  adicionados na hora 
        public Boolean CadastrarItemEntradaLista(ItemEntradaLista itemlista)
        {
            try
            {
                foreach (ItemEntrada item in itemlista)
                {

                    sqlServer.LimparParametros();

                    sqlServer.AdicionarParametro(new SqlParameter("@codigoEntradaEstoque", item.EntradaEstoque.codigoEntradaEstoque));
                    sqlServer.AdicionarParametro(new SqlParameter("@codigoProdutoCor", item.ProdutoCor.codigoProdutoCor));
                    sqlServer.AdicionarParametro(new SqlParameter("@precoCusto", item.precoCustoItem));
                    sqlServer.AdicionarParametro(new SqlParameter("@precoVenda", item.precoVendaItem));
                    sqlServer.AdicionarParametro(new SqlParameter("@quantidade", item.quantidadeItem));
                    sqlServer.AdicionarParametro(new SqlParameter("@tamanho", item.Tamanho.codigoTamanho));
                    sqlServer.AdicionarParametro(new SqlParameter("@codigoBarras", item.codigoBarrasItem));


                    string comandoSql = "exec uspCadastrarItemEntrada @codigoEntradaEstoque, @codigoProdutoCor, @precoCusto, @precoVenda, @quantidade, @tamanho, @codigoBarras";

                    sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível cadastrar o Item da Entrada de Estoque. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Exclui todos os itens da entrada de estoque
        public Boolean ExcluirItemEntradaPorEntrada(ItemEntradaLista itemlista)
        {
            try
            {

                foreach (ItemEntrada item in itemlista)
                {

                    sqlServer.LimparParametros();

                    sqlServer.AdicionarParametro(new SqlParameter("@codigo", item.codigoItemEntrada));

                    string comandoSql = "exec uspExcluirItemEntradaPorEntrada @codigo";

                    object Resposta = sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                    if (Convert.ToInt16(Resposta) == 1)
                    {
                        //Estoque atendido não possivel remover retorna código item que não pode ser removido
                        return false;
                    }
                }

                //Foram Removidos com sucesso
                return true;//Numeros retornados são os codigos dos item que não ja foram atendidos 
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível excluir Item da Entrada de Estoque. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Excluir item entrada
        public Boolean ExcluirItemEntrada(ItemEntradaLista itemlista)
        {
            try
            {
                foreach (ItemEntrada item in itemlista)
                {
                    sqlServer.LimparParametros();
                    sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoItem", item.codigoItemEntrada));

                    string comando = "exec uspExcluirItemEntrada @codigoItem";

                    object Resposta = sqlServer.ExecutarScalar(comando, System.Data.CommandType.Text);

                    if (Convert.ToInt16(Resposta) == 1)
                    {
                        return false;//Caso estiver vinculado tabela Produto cor
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

        //metodo para excluir o item   #Colocar valores em uma lista deixar para dar retorno so no final
        public Boolean ExcluirItemEntradaPorCodigo(int item)
        {
            try
            {
                    sqlServer.LimparParametros();
                    sqlServer.AdicionarParametro(new SqlParameter("@codigo", item));

                    string comandoSql = "exec uspExcluirItemEntradaPorCodigo @codigo";
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
                throw new Exception("Não foi possível excluir Item da Entrada de Estoque. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Atualiza valor itemEntrada verificando quantidade do estoque
        public string AtualizarItemEntrada(ItemEntrada item)
        {
            string retorno;
            try
            {
                sqlServer.AdicionarParametro(new SqlParameter("@codigoItemEntrada", item.codigoItemEntrada));
                sqlServer.AdicionarParametro(new SqlParameter("@codigoEntradaEstoque", item.EntradaEstoque.codigoEntradaEstoque));
                sqlServer.AdicionarParametro(new SqlParameter("@codigoProdutoCor", item.ProdutoCor.codigoProdutoCor));
                sqlServer.AdicionarParametro(new SqlParameter("@precoCusto", item.precoCustoItem));
                sqlServer.AdicionarParametro(new SqlParameter("@precoVenda", item.precoVendaItem));
                sqlServer.AdicionarParametro(new SqlParameter("@quantidade", item.quantidadeItem));
                sqlServer.AdicionarParametro(new SqlParameter("@tamanho", item.Tamanho.codigoTamanho));
                sqlServer.AdicionarParametro(new SqlParameter("@codigoBarras", item.codigoBarrasItem));


                string comandoSql = "exec uspAlterarItemEntrada @codigoItemEntrada, @codigoEntradaEstoque, @codigoProdutoCor, @precoCusto, @precoVenda, @quantidade, @tamanho, @codigoBarras";
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

        //Atualiza valor itemEntrada verificando quantidade do estoque
        public Boolean AtualizarCodigoBarrasItem(int codigoProdutoCor,int tamnhoItem , string codigoBarras)
        {
            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@codigoProdutoCor", codigoProdutoCor));
                sqlServer.AdicionarParametro(new SqlParameter("@tamanhoItem", tamnhoItem));
                sqlServer.AdicionarParametro(new SqlParameter("@codigoBarras", codigoBarras));

                string comandoSql = "exec uspAlterarCodigoBarrasItemEntrada @codigoProdutoCor, @tamanhoItem, @codigoBarras"; 
                sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                return true;

            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possivel Atualizar CodigoBarras ItemEntrada" + ex.Message);
            }
        }

        //-------------------------------------Consulta
        //Buscar itens por entrada de estoque
        public ItemEntradaLista BuscarItemEntradaEstoque(int codigoEntradaEstoque)
        {
            try
            {
                DataTable tabelaResultado;

                ItemEntradaLista itemEntradaLista = new ItemEntradaLista();


                this.sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@codigoEntradaEstoque", codigoEntradaEstoque));

                string comando = "exec uspBuscarItemEntradaEstoque @codigoEntradaEstoque";

                tabelaResultado = this.sqlServer.ExecutarConsulta(comando, CommandType.Text);

                foreach (DataRow registro in tabelaResultado.Rows)
                {

                    ItemEntrada itemEntrada = new ItemEntrada();
                    itemEntrada.ProdutoCor = new ProdutoCor();
                    itemEntrada.ProdutoCor.Produto = new Produto();
                    itemEntrada.ProdutoCor.Cor = new Cor();
                    itemEntrada.ProdutoCor.Produto.Genero = new Genero();
                    itemEntrada.Tamanho = new Tamanho();
                    itemEntrada.EntradaEstoque = new EntradaEstoque();

                    itemEntrada.codigoItemEntrada = (Convert.ToInt32(registro[0]));
                    itemEntrada.EntradaEstoque.codigoEntradaEstoque = (Convert.ToInt32(registro[1]));

                    itemEntrada.ProdutoCor.Produto.codigoProduto = (Convert.ToInt32(registro[2]));
                    itemEntrada.ProdutoCor.codigoProdutoCor = (Convert.ToInt32(registro[3]));
                    itemEntrada.ProdutoCor.Produto.descricaoProduto = (registro[4].ToString());
                    itemEntrada.ProdutoCor.Produto.referenciaProduto = (registro[5].ToString());
                    itemEntrada.ProdutoCor.Produto.sexoProduto = (registro[6].ToString());
                    itemEntrada.ProdutoCor.Produto.Genero.nomeGenero = (registro[7].ToString());
                    itemEntrada.ProdutoCor.Cor.nomeCor = (registro[8].ToString());
                    itemEntrada.Tamanho.codigoTamanho = (Convert.ToInt32(registro[9]));
                    itemEntrada.Tamanho.nometamanho = (registro[10].ToString());

                    itemEntrada.quantidadeItem = Convert.ToInt32(registro[11]);
                    itemEntrada.precoCustoItem = Convert.ToDouble(registro[12]);
                    itemEntrada.precoVendaItem = Convert.ToDouble(registro[13]);
                    itemEntrada.codigoBarrasItem = (registro[14].ToString());

                    itemEntrada.ProdutoCor.ImagemProduto = (registro[15].ToString());

                    itemEntradaLista.Add(itemEntrada);
                }

                return itemEntradaLista;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar os Itens da Entrada de Estoque. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Busca cores do produto caso o mesmo não tiver cores -> Apresentação mostrar produto nao tem cores OBS:Form Colocar informação prod
        public ProdutoCorLista BuscarCorItemEntrada(int codigoProduto)
        {
            try
            {
                DataTable tabelaResultado;

                ProdutoCorLista produtoCorLista = new ProdutoCorLista();


                this.sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@codigoProduto", codigoProduto));

                string comando = "exec uspBuscarCorItemEntrada @codigoProduto";

                tabelaResultado = this.sqlServer.ExecutarConsulta(comando, CommandType.Text);

                foreach (DataRow registro in tabelaResultado.Rows)
                {

                    ProdutoCor produtoCor = new ProdutoCor();
                    produtoCor.Produto = new Produto();
                    produtoCor.Cor = new Cor();
                    produtoCor.Produto.Genero = new Genero();


                    produtoCor.codigoProdutoCor = Convert.ToInt32(registro[0]);
                    produtoCor.Produto.codigoProduto = Convert.ToInt32(registro[1]);
                    produtoCor.Cor.codigoCor = Convert.ToInt32(registro[2]);
                    produtoCor.Cor.nomeCor = (registro[3].ToString());
                    produtoCor.Produto.precoCustoProduto = Convert.ToDouble(registro[4]);
                    produtoCor.Produto.precoVendaProduto = Convert.ToDouble(registro[5]);
                    produtoCor.ImagemProduto = (registro[6].ToString());


                    produtoCorLista.Add(produtoCor);
                }

                return produtoCorLista;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar os Cores do Item. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //--------------------------Código de Barras
        //realiza a validação se ja existe o código de barras no EStoque, ItemEntrada e ItemEntradaTemp
        public ItemEntrada BuscarItemPorBarras(String strCodigoBarras)
        {
            try
            {
                DataTable tabelaRetorno;
                ItemEntrada item;

                this.sqlServer.LimparParametros();
                this.sqlServer.AdicionarParametro(new SqlParameter("@Barras", strCodigoBarras));

                string comando = "exec uspBuscarItemEntradaPorBarras @Barras";

                tabelaRetorno = this.sqlServer.ExecutarConsulta(comando, CommandType.Text);


                if (tabelaRetorno.Rows.Count > 0)
                {
                    DataRow registro = tabelaRetorno.Rows[0];//Consulta só retorna uma objeto
                    item = new ItemEntrada();
                    item.ProdutoCor = new ProdutoCor();
                    item.ProdutoCor.Produto = new Produto();
                    item.Tamanho = new Tamanho();

                    item.ProdutoCor.codigoProdutoCor = Convert.ToInt32(registro[0]);
                    item.ProdutoCor.Produto.descricaoProduto = registro[1].ToString();
                    item.precoCustoItem = Convert.ToDouble(registro[2]);
                    item.precoVendaItem = Convert.ToDouble(registro[3]);
                    item.Tamanho.codigoTamanho = Convert.ToInt32(registro[4]);
                    item.codigoBarrasItem = (registro[5].ToString());

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

        public Boolean CadastrarItemEntradaBarras(ItemEntrada item)
        {
            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@codigoEntradaEstoque", item.EntradaEstoque.codigoEntradaEstoque));
                sqlServer.AdicionarParametro(new SqlParameter("@codigoProdutoCor", item.ProdutoCor.codigoProdutoCor));
                sqlServer.AdicionarParametro(new SqlParameter("@precoCusto", item.precoCustoItem));
                sqlServer.AdicionarParametro(new SqlParameter("@precoVenda", item.precoVendaItem));
                sqlServer.AdicionarParametro(new SqlParameter("@quantidade", item.quantidadeItem));
                sqlServer.AdicionarParametro(new SqlParameter("@tamanho", item.Tamanho.codigoTamanho));
                sqlServer.AdicionarParametro(new SqlParameter("@codigoBarras", item.codigoBarrasItem));

                string comandoSql = "exec uspCadastrarItemEntrada @codigoEntradaEstoque, @codigoProdutoCor, @precoCusto, @precoVenda, @quantidade, @tamanho, @codigoBarras";

                sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível cadastrar o Item da Entrada de Estoque. [Negócios]. Motivo: " + ex.Message);
            }
        }
            
        //--------------------------------------NegItemEntradaTemp

        //----------------------------BuscarItensEntradaEstoque
        //Busca tamanhos dos produtos para realizar a inserção nos tamanhos desejados OBS:Form Colocar informação prod
        public ItemEntradaLista BuscarEntradaItemEntradaTemp(int codigoEntrada)
        {
            try
            {
                DataTable tabelaResultado;
                ItemEntradaLista itemEntradaLista = new ItemEntradaLista();

                this.sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@codigoEntrada", codigoEntrada));

                string comando = "exec uspBuscarEntradaItemEntradaTemp @codigoEntrada";

                tabelaResultado = this.sqlServer.ExecutarConsulta(comando, CommandType.Text);

                if (tabelaResultado.Rows.Count == 0)
                {
                    //  throw new Exception("Não foram encontrados registros.");
                }

                foreach (DataRow registro in tabelaResultado.Rows)
                {
                    ItemEntrada itemEntrada = new ItemEntrada();
                    itemEntrada.ProdutoCor = new ProdutoCor();
                    itemEntrada.ProdutoCor.Produto = new Produto();
                    itemEntrada.ProdutoCor.Cor = new Cor();
                    itemEntrada.ProdutoCor.Produto.Genero = new Genero();
                    itemEntrada.Tamanho = new Tamanho();
                    itemEntrada.EntradaEstoque = new EntradaEstoque();

                    itemEntrada.codigoItemEntrada = (Convert.ToInt32(registro[0]));
                    itemEntrada.EntradaEstoque.codigoEntradaEstoque = (Convert.ToInt32(registro[1]));

                    itemEntrada.ProdutoCor.Produto.codigoProduto = (Convert.ToInt32(registro[2]));
                    itemEntrada.ProdutoCor.codigoProdutoCor = (Convert.ToInt32(registro[3]));
                    itemEntrada.ProdutoCor.Produto.descricaoProduto = (registro[4].ToString());
                    itemEntrada.ProdutoCor.Produto.referenciaProduto = (registro[5].ToString());
                    itemEntrada.ProdutoCor.Produto.sexoProduto = (registro[6].ToString());
                    itemEntrada.ProdutoCor.Produto.Genero.nomeGenero = (registro[7].ToString());
                    itemEntrada.ProdutoCor.Cor.nomeCor = (registro[8].ToString());
                    itemEntrada.Tamanho.codigoTamanho = (Convert.ToInt32(registro[9]));
                    itemEntrada.Tamanho.nometamanho = (registro[10].ToString());

                    itemEntrada.quantidadeItem = Convert.ToInt32(registro[11]);
                    itemEntrada.precoCustoItem = Convert.ToDouble(registro[12]);
                    itemEntrada.precoVendaItem = Convert.ToDouble(registro[13]);
                    itemEntrada.codigoBarrasItem = (registro[14].ToString());

                    itemEntrada.ProdutoCor.ImagemProduto = (registro[15].ToString());

                    itemEntradaLista.Add(itemEntrada);
                }

                return itemEntradaLista;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar os Items da Entrada de Estoque. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //-----------------------------Cadastros
        //metodo para realizar o lançamento no estoque  Obs: 1:P/2:M/3:GG  adicionados na hora 
        public Boolean CadastrarItemEntradaListaTemp(ItemEntradaLista itemlista)
        {
            try
            {
                foreach (ItemEntrada item in itemlista)
                {

                    sqlServer.LimparParametros();

                    sqlServer.AdicionarParametro(new SqlParameter("@codigoEntradaEstoque", item.EntradaEstoque.codigoEntradaEstoque));
                    sqlServer.AdicionarParametro(new SqlParameter("@codigoProdutoCor", item.ProdutoCor.codigoProdutoCor));
                    sqlServer.AdicionarParametro(new SqlParameter("@precoCusto", item.precoCustoItem));
                    sqlServer.AdicionarParametro(new SqlParameter("@precoVenda", item.precoVendaItem));
                    sqlServer.AdicionarParametro(new SqlParameter("@quantidade", item.quantidadeItem));
                    sqlServer.AdicionarParametro(new SqlParameter("@tamanho", item.Tamanho.codigoTamanho));
                    sqlServer.AdicionarParametro(new SqlParameter("@codigoBarras", item.codigoBarrasItem));


                    string comandoSql = "exec uspCadastrarItemEntradaTemp @codigoEntradaEstoque, @codigoProdutoCor, @precoCusto, @precoVenda, @quantidade, @tamanho, @codigoBarras";

                    sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível cadastrar o Item da Entrada de Estoque. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Excluir item entrada temp
        public Boolean ExcluirItemEntradaTemp(int codigoItem)
        {
            try
            {
                sqlServer.LimparParametros();

                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoItem", codigoItem));

                string comando = "exec uspExcluirItemEntradaTemp @codigoItem";

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

        //metodo para zerar a venda temporaria
        public Boolean ExcluirDadosTabelaTemporaria(int codigoEntrada)
        {
            try
            {

                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigo", codigoEntrada));

                string comando = "exec uspExcluirItemEntradaTempPorEntrada @codigo";

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

        //Exclui todos os itens da entrada de estoque
        public Boolean ExcluirItemEntradaTempPorEntrada(ItemEntradaLista itemlista)
        {
            try
            {

                foreach (ItemEntrada item in itemlista)
                {

                    sqlServer.LimparParametros();

                    sqlServer.AdicionarParametro(new SqlParameter("@codigo", item.codigoItemEntrada));

                    string comandoSql = "exec uspExcluirItemEntradaTemp @codigo";

                    object Resposta = sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                    if (Convert.ToInt16(Resposta) == 1)
                    {
                        //Estoque atendido não possivel remover retorna código item que não pode ser removido
                        return false;
                    }
                }

                //Foram Removidos com sucesso
                return true;//Numeros retornados são os codigos dos item que não ja foram atendidos 
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível excluir Item da Entrada de Estoque. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //---------------------------Validações

        //realiza a validação se ja existe o código de barras no EStoque, ItemEntrada e ItemEntradaTemp
        public ProdutoCor ValidarCodigoBarras(String strCodigoBarras)
        {
            try
            {
                DataTable tabelaRetorno;
                ProdutoCor produtoCor;

                this.sqlServer.LimparParametros();
                this.sqlServer.AdicionarParametro(new SqlParameter("@Barras", strCodigoBarras));

                string comando = "exec uspValidaCodigoBarras @Barras";

                tabelaRetorno = this.sqlServer.ExecutarConsulta(comando, CommandType.Text);


                if (tabelaRetorno.Rows.Count > 0)
                {
                    DataRow registro = tabelaRetorno.Rows[0];//Consulta só retorna uma objeto
                    produtoCor = new ProdutoCor();
                    produtoCor.Produto = new Produto();
                    produtoCor.Cor = new Cor();
                    produtoCor.codigoProdutoCor = Convert.ToInt32(registro[0]);
                    produtoCor.Produto.codigoProduto = Convert.ToInt32(registro[1]);
                    produtoCor.Produto.descricaoProduto = (registro[2].ToString());
                    produtoCor.Cor.nomeCor = (registro[3].ToString());
                    produtoCor.Cor.codigoCor = Convert.ToInt32(registro[4]);//Codigo do Tamanho

                    return produtoCor;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível validar a Código de Barras do Produto. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //---------------------------Cadastra Codigo Barras
        public Boolean CadastrarItemEntradaBarrasTemp(ItemEntrada item)
        {
            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@codigoEntradaEstoque", item.EntradaEstoque.codigoEntradaEstoque));
                sqlServer.AdicionarParametro(new SqlParameter("@codigoProdutoCor", item.ProdutoCor.codigoProdutoCor));
                sqlServer.AdicionarParametro(new SqlParameter("@precoCusto", item.precoCustoItem));
                sqlServer.AdicionarParametro(new SqlParameter("@precoVenda", item.precoVendaItem));
                sqlServer.AdicionarParametro(new SqlParameter("@quantidade", item.quantidadeItem));
                sqlServer.AdicionarParametro(new SqlParameter("@tamanho", item.Tamanho.codigoTamanho));
                sqlServer.AdicionarParametro(new SqlParameter("@codigoBarras", item.codigoBarrasItem));

                string comandoSql = "exec uspCadastrarItemEntradaTemp @codigoEntradaEstoque, @codigoProdutoCor, @precoCusto, @precoVenda, @quantidade, @tamanho, @codigoBarras";

                sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível cadastrar o Item da Entrada de Estoque. [Negócios]. Motivo: " + ex.Message);
            }
        }


        //----------------------------Lançamento
        //Busca tamanhos dos produtos para realizar a inserção nos tamanhos desejados OBS:Form Colocar informação prod
        public ItemEntradaLista BuscarTamanhoItemEntrada(int codigoProdutoCor, int codigoEntrada)
        {
            try
            {
                DataTable tabelaResultado;

                ItemEntradaLista itemEntradaLista = new ItemEntradaLista();


                this.sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@codigoProdutoCor", codigoProdutoCor));
                sqlServer.AdicionarParametro(new SqlParameter("@codigoEntrada", codigoEntrada));

                string comando = "exec uspBuscarTamanhoItemEntrada @codigoProdutoCor, @codigoEntrada";

                tabelaResultado = this.sqlServer.ExecutarConsulta(comando, CommandType.Text);

                foreach (DataRow registro in tabelaResultado.Rows)
                {

                    ItemEntrada itemEntrada = new ItemEntrada();
                    itemEntrada.ProdutoCor = new ProdutoCor();
                    itemEntrada.ProdutoCor.Produto = new Produto();
                    itemEntrada.ProdutoCor.Cor = new Cor();
                    itemEntrada.ProdutoCor.Produto.Genero = new Genero();
                    itemEntrada.Tamanho = new Tamanho();

                    itemEntrada.codigoItemEntrada = (Convert.ToInt32(registro[0]));
                    itemEntrada.ProdutoCor.Cor.nomeCor = (registro[1].ToString());
                    itemEntrada.Tamanho.codigoTamanho = (Convert.ToInt32(registro[2]));
                    itemEntrada.Tamanho.nometamanho = (registro[3].ToString());
                    itemEntrada.quantidadeItem = Convert.ToInt32(registro[4]);
                    itemEntrada.ProdutoCor.Produto.quantidadeProduto = (Convert.ToInt32(registro[5]));//Quantidade Estoque
                    itemEntrada.precoCustoItem = Convert.ToDouble(registro[6]);
                    itemEntrada.precoVendaItem = Convert.ToDouble(registro[7]);
                    itemEntrada.codigoBarrasItem = (registro[8].ToString());
                    itemEntrada.ProdutoCor.ImagemProduto = (registro[9].ToString());

                    itemEntradaLista.Add(itemEntrada);
                }

                return itemEntradaLista;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar os Cores do Item. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Busca tamanhos dos produtos para realizar a inserção nos tamanhos desejados OBS:Form Colocar informação prod
        public ItemEntradaLista BuscarItemEntradaTemp(int codigoProdutoCor)
        {
            try
            {
                DataTable tabelaResultado;

                ItemEntradaLista itemEntradaLista = new ItemEntradaLista();


                this.sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@codigoProdutoCor", codigoProdutoCor));

                string comando = "exec uspBuscarItemEntradaTemp @codigoProdutoCor";

                tabelaResultado = this.sqlServer.ExecutarConsulta(comando, CommandType.Text);

                foreach (DataRow registro in tabelaResultado.Rows)
                {

                    ItemEntrada itemEntrada = new ItemEntrada();
                    itemEntrada.ProdutoCor = new ProdutoCor();
                    itemEntrada.ProdutoCor.Produto = new Produto();
                    itemEntrada.ProdutoCor.Cor = new Cor();
                    itemEntrada.ProdutoCor.Produto.Genero = new Genero();
                    itemEntrada.Tamanho = new Tamanho();
                    itemEntrada.EntradaEstoque = new EntradaEstoque();

                    itemEntrada.codigoItemEntrada = (Convert.ToInt32(registro[0]));
                    itemEntrada.ProdutoCor.Cor.nomeCor = (registro[1].ToString());
                    itemEntrada.Tamanho.codigoTamanho = (Convert.ToInt32(registro[2]));
                    itemEntrada.Tamanho.nometamanho = (registro[3].ToString());
                    itemEntrada.quantidadeItem = Convert.ToInt32(registro[4]);
                    itemEntrada.ProdutoCor.Produto.quantidadeProduto = (Convert.ToInt32(registro[5]));//Quantidade Estoque
                    itemEntrada.precoCustoItem = Convert.ToDouble(registro[6]);
                    itemEntrada.precoVendaItem = Convert.ToDouble(registro[7]);
                    itemEntrada.codigoBarrasItem = (registro[8].ToString());
                    itemEntrada.ProdutoCor.ImagemProduto = (registro[9].ToString());

                    itemEntradaLista.Add(itemEntrada);
                }

                return itemEntradaLista;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar os Cores do Item. [Negócios]. Motivo: " + ex.Message);
            }
        }
        
        //-------------------------------***Não estão sendo utilizados***
        //Busca tamanhos dos produtos para realizar a inserção nos tamanhos desejados OBS:Form Colocar informação prod
        public ItemEntradaLista BuscarItemEntrada(int codigoProdutoCor)
        {
            try
            {
                DataTable tabelaResultado;

                ItemEntradaLista itemEntradaLista = new ItemEntradaLista();


                this.sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@codigoProdutoCor", codigoProdutoCor));

                string comando = "exec uspBuscarItemEntrada @codigoProdutoCor";

                tabelaResultado = this.sqlServer.ExecutarConsulta(comando, CommandType.Text);

                foreach (DataRow registro in tabelaResultado.Rows)
                {

                    ItemEntrada itemEntrada = new ItemEntrada();
                    itemEntrada.ProdutoCor = new ProdutoCor();
                    itemEntrada.ProdutoCor.Produto = new Produto();
                    itemEntrada.ProdutoCor.Cor = new Cor();
                    itemEntrada.ProdutoCor.Produto.Genero = new Genero();
                    itemEntrada.Tamanho = new Tamanho();
                    itemEntrada.EntradaEstoque = new EntradaEstoque();

                    itemEntrada.codigoItemEntrada = (Convert.ToInt32(registro[0]));
                    itemEntrada.ProdutoCor.Cor.nomeCor = (registro[1].ToString());
                    itemEntrada.Tamanho.codigoTamanho = (Convert.ToInt32(registro[2]));
                    itemEntrada.Tamanho.nometamanho = (registro[3].ToString());
                    itemEntrada.quantidadeItem = Convert.ToInt32(registro[4]);
                    itemEntrada.ProdutoCor.Produto.quantidadeProduto = (Convert.ToInt32(registro[5]));//Quantidade Estoque
                    itemEntrada.precoCustoItem = Convert.ToDouble(registro[6]);
                    itemEntrada.precoVendaItem = Convert.ToDouble(registro[7]);
                    itemEntrada.codigoBarrasItem = (registro[8].ToString());
                    itemEntrada.ProdutoCor.ImagemProduto = (registro[9].ToString());

                    itemEntradaLista.Add(itemEntrada);
                }

                return itemEntradaLista;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar os Cores do Item. [Negócios]. Motivo: " + ex.Message);
            }
        }
     
        //Busca tamanhos dos produtos para realizar a inserção nos tamanhos desejados OBS:Form Colocar informação prod
        public ItemEntradaLista BuscarTamanhoItemEntradaTemp(int codigoProdutoCor, int codigoEntrada)
        {
            try
            {
                DataTable tabelaResultado;

                ItemEntradaLista itemEntradaLista = new ItemEntradaLista();


                this.sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@codigoProdutoCor", codigoProdutoCor));
                sqlServer.AdicionarParametro(new SqlParameter("@codigoEntrada", codigoEntrada));

                string comando = "exec uspBuscarTamanhoItemEntradaTemp @codigoProdutoCor, @codigoEntrada";

                tabelaResultado = this.sqlServer.ExecutarConsulta(comando, CommandType.Text);

                if (tabelaResultado.Rows.Count == 0)
                {
                    //  throw new Exception("Não foram encontrados registros.");
                }

                foreach (DataRow registro in tabelaResultado.Rows)
                {
                    ItemEntrada itemEntrada = new ItemEntrada();
                    itemEntrada.ProdutoCor = new ProdutoCor();
                    itemEntrada.ProdutoCor.Produto = new Produto();
                    itemEntrada.ProdutoCor.Cor = new Cor();
                    itemEntrada.ProdutoCor.Produto.Genero = new Genero();
                    itemEntrada.Tamanho = new Tamanho();
                    itemEntrada.EntradaEstoque = new EntradaEstoque();

                    itemEntrada.codigoItemEntrada = (Convert.ToInt32(registro[0]));
                    itemEntrada.ProdutoCor.Cor.nomeCor = (registro[1].ToString());
                    itemEntrada.Tamanho.codigoTamanho = (Convert.ToInt32(registro[2]));
                    itemEntrada.Tamanho.nometamanho = (registro[3].ToString());
                    itemEntrada.quantidadeItem = Convert.ToInt32(registro[4]);
                    itemEntrada.ProdutoCor.Produto.quantidadeProduto = (Convert.ToInt32(registro[5]));//Quantidade Estoque
                    itemEntrada.precoCustoItem = Convert.ToDouble(registro[6]);
                    itemEntrada.precoVendaItem = Convert.ToDouble(registro[7]);
                    itemEntrada.codigoBarrasItem = (registro[8].ToString());
                    itemEntrada.ProdutoCor.ImagemProduto = (registro[9].ToString());

                    itemEntradaLista.Add(itemEntrada);
                }

                return itemEntradaLista;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar os Cores do Item. [Negócios]. Motivo: " + ex.Message);
            }
        }

    }
}
