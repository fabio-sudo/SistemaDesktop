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
   public class NegEstoque
    {

        private ConexaoSqlServer sqlServer = new ConexaoSqlServer();

   
        //Busca estoque totais
        public EstoqueLista BuscarEstoque(string strProduto)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@produto", strProduto));
            string comandoSql = "exec uspBuscarEstoque @produto";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

            EstoqueLista estoqueLista = new EstoqueLista();
            Estoque estoque;

            foreach (DataRow registro in tabelaRetorno.Rows)
            {
                //define o objeto para não mantelo nullo
                estoque = new Estoque();
                estoque.ProdutoCor = new ProdutoCor();
                estoque.tamanhoProduto = new Tamanho();
                estoque.ProdutoCor.Cor = new Cor();
                estoque.ProdutoCor.Produto = new Produto();
                estoque.ProdutoCor.Produto.Genero = new Genero();
                estoque.ProdutoCor.Produto.Grade = new Grade();
                estoque.ProdutoCor.Produto.Fornecedor = new Fornecedor();


                estoque.ProdutoCor.codigoProdutoCor = Convert.ToInt32(registro[0]);
                estoque.ProdutoCor.Produto.codigoProduto = Convert.ToInt32(registro[1]);
                estoque.ProdutoCor.Produto.descricaoProduto = registro[2].ToString();
                estoque.ProdutoCor.Produto.referenciaProduto = registro[3].ToString();
                estoque.ProdutoCor.Produto.sexoProduto = registro[4].ToString();
                estoque.ProdutoCor.Produto.Genero.nomeGenero = registro[5].ToString();
                estoque.ProdutoCor.Cor.nomeCor = registro[6].ToString();
                estoque.ProdutoCor.Produto.Grade.nomeGrade = registro[7].ToString();
                estoque.ProdutoCor.Produto.Fornecedor.nomeFantasiaFornecedor = registro[8].ToString();

                estoque.quantidadeEstoque = Convert.ToInt32(registro[9]);
                estoque.precoCustoEstoque = Convert.ToDouble(registro[10]);
                estoque.precoVendaEstoque = Convert.ToDouble(registro[11]);

                estoque.ProdutoCor.ImagemProduto = (registro[12].ToString());

                estoqueLista.Add(estoque);
            }

            return estoqueLista;
        }
             
        //Buscar Estoque total buscar tamanhos e quantidades por itens
        public EstoqueLista BuscarEstoqueDetalhado(string strProduto)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@produto", strProduto));
            string comandoSql = "exec uspBuscarEstoqueDetalhado @produto";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

            EstoqueLista estoqueLista = new EstoqueLista();
            Estoque estoque;

            foreach (DataRow registro in tabelaRetorno.Rows)
            {
                //define o objeto para não mantelo nullo
                estoque = new Estoque();
                estoque.ProdutoCor = new ProdutoCor();
                estoque.tamanhoProduto = new Tamanho();
                estoque.ProdutoCor.Cor = new Cor();
                estoque.ProdutoCor.Produto = new Produto();
                estoque.ProdutoCor.Produto.Genero = new Genero();
                estoque.ProdutoCor.Produto.Grade = new Grade();
                estoque.ProdutoCor.Produto.Fornecedor = new Fornecedor();


                estoque.ProdutoCor.codigoProdutoCor = Convert.ToInt32(registro[0]);
                estoque.ProdutoCor.Produto.codigoProduto = Convert.ToInt32(registro[1]);
                estoque.ProdutoCor.Produto.descricaoProduto = registro[2].ToString();
                estoque.ProdutoCor.Produto.referenciaProduto = registro[3].ToString();
                estoque.ProdutoCor.Produto.sexoProduto = registro[4].ToString();
                estoque.ProdutoCor.Produto.Genero.nomeGenero = registro[5].ToString();
                estoque.ProdutoCor.Cor.nomeCor = registro[6].ToString();
                estoque.ProdutoCor.Produto.Grade.nomeGrade = registro[7].ToString();
                estoque.ProdutoCor.Produto.Fornecedor.nomeFantasiaFornecedor = registro[8].ToString();

                estoque.tamanhoProduto.nometamanho = (registro[9].ToString());
                estoque.quantidadeEstoque = Convert.ToInt32(registro[10]);
                estoque.precoCustoEstoque = Convert.ToDouble(registro[11]);
                estoque.precoVendaEstoque = Convert.ToDouble(registro[12]);

                estoque.codigoBarrasProduto = (registro[13].ToString());
                estoque.ProdutoCor.ImagemProduto = (registro[14].ToString());

                estoqueLista.Add(estoque);
            }

            return estoqueLista;
        }

        //Buscar Estoque com todos os filtros
        public EstoqueLista BuscarEstoqueFiltros(Estoque objEstoque)
        {

            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@descricao", objEstoque.ProdutoCor.Produto.descricaoProduto));
            this.sqlServer.AdicionarParametro(new SqlParameter("@sexo", objEstoque.ProdutoCor.Produto.sexoProduto));
            this.sqlServer.AdicionarParametro(new SqlParameter("@cor", objEstoque.ProdutoCor.Cor.nomeCor));
            this.sqlServer.AdicionarParametro(new SqlParameter("@genero", objEstoque.ProdutoCor.Produto.Genero.nomeGenero));
            this.sqlServer.AdicionarParametro(new SqlParameter("@grade", objEstoque.ProdutoCor.Produto.Grade.nomeGrade));
            this.sqlServer.AdicionarParametro(new SqlParameter("@tamanho", objEstoque.tamanhoProduto.nometamanho));
            this.sqlServer.AdicionarParametro(new SqlParameter("@fornecedor", objEstoque.ProdutoCor.Produto.Fornecedor.nomeFantasiaFornecedor));

            string comandoSql = "exec uspBuscarEstoquePorFiltros @descricao, @sexo, @cor, @genero, @grade, @tamanho, @fornecedor";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

            EstoqueLista estoqueLista = new EstoqueLista();
            Estoque estoque;

            foreach (DataRow registro in tabelaRetorno.Rows)
            {
                //define o objeto para não mantelo nullo
                estoque = new Estoque();
                estoque.ProdutoCor = new ProdutoCor();
                estoque.tamanhoProduto = new Tamanho();
                estoque.ProdutoCor.Cor = new Cor();
                estoque.ProdutoCor.Produto = new Produto();
                estoque.ProdutoCor.Produto.Genero = new Genero();
                estoque.ProdutoCor.Produto.Grade = new Grade();
                estoque.ProdutoCor.Produto.Fornecedor = new Fornecedor();

                estoque.codigoEstoque = Convert.ToInt32(registro[0]);
                estoque.ProdutoCor.codigoProdutoCor = Convert.ToInt32(registro[1]);
                estoque.ProdutoCor.Produto.codigoProduto = Convert.ToInt32(registro[2]);
                estoque.ProdutoCor.Produto.descricaoProduto = registro[3].ToString();
                estoque.ProdutoCor.Produto.referenciaProduto = registro[4].ToString();
                estoque.ProdutoCor.Produto.sexoProduto = registro[5].ToString();
                estoque.ProdutoCor.Produto.Genero.nomeGenero = registro[6].ToString();
                estoque.ProdutoCor.Cor.nomeCor = registro[7].ToString();
                estoque.ProdutoCor.Produto.Grade.nomeGrade = registro[8].ToString();
                estoque.ProdutoCor.Produto.Fornecedor.nomeFantasiaFornecedor = registro[9].ToString();

                estoque.tamanhoProduto.codigoTamanho = Convert.ToInt32(registro[10]);
                estoque.tamanhoProduto.nometamanho = (registro[11].ToString());
                estoque.quantidadeEstoque = Convert.ToInt32(registro[12]);
                estoque.precoCustoEstoque = Convert.ToDouble(registro[13]);
                estoque.precoVendaEstoque = Convert.ToDouble(registro[14]);

                estoque.codigoBarrasProduto = (registro[15].ToString());
                estoque.ProdutoCor.ImagemProduto = (registro[16].ToString());
                estoque.dataEstoque = Convert.ToDateTime(registro[17]);

                estoqueLista.Add(estoque);
            }

            return estoqueLista;
        }
        
       //uspBuscarEstoquePorData
        //Buscar Estoque com todos os filtros
        public EstoqueLista BuscarEstoquePorData(DateTime dataInicial, DateTime dataFinal)
        {

            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@DataInicial", dataInicial));
            this.sqlServer.AdicionarParametro(new SqlParameter("@DataFinal", dataFinal));

            string comandoSql = "exec uspBuscarEstoquePorData @DataInicial, @DataFinal";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

            EstoqueLista estoqueLista = new EstoqueLista();
            Estoque estoque;

            foreach (DataRow registro in tabelaRetorno.Rows)
            {
                //define o objeto para não mantelo nullo
                estoque = new Estoque();
                estoque.ProdutoCor = new ProdutoCor();
                estoque.tamanhoProduto = new Tamanho();
                estoque.ProdutoCor.Cor = new Cor();
                estoque.ProdutoCor.Produto = new Produto();
                estoque.ProdutoCor.Produto.Genero = new Genero();
                estoque.ProdutoCor.Produto.Grade = new Grade();
                estoque.ProdutoCor.Produto.Fornecedor = new Fornecedor();

                estoque.codigoEstoque = Convert.ToInt32(registro[0]);
                estoque.ProdutoCor.codigoProdutoCor = Convert.ToInt32(registro[1]);
                estoque.ProdutoCor.Produto.codigoProduto = Convert.ToInt32(registro[2]);
                estoque.ProdutoCor.Produto.descricaoProduto = registro[3].ToString();
                estoque.ProdutoCor.Produto.referenciaProduto = registro[4].ToString();
                estoque.ProdutoCor.Produto.sexoProduto = registro[5].ToString();
                estoque.ProdutoCor.Produto.Genero.nomeGenero = registro[6].ToString();
                estoque.ProdutoCor.Cor.nomeCor = registro[7].ToString();
                estoque.ProdutoCor.Produto.Grade.nomeGrade = registro[8].ToString();
                estoque.ProdutoCor.Produto.Fornecedor.nomeFantasiaFornecedor = registro[9].ToString();

                estoque.tamanhoProduto.codigoTamanho = Convert.ToInt32(registro[10]);
                estoque.tamanhoProduto.nometamanho = (registro[11].ToString());
                estoque.quantidadeEstoque = Convert.ToInt32(registro[12]);
                estoque.precoCustoEstoque = Convert.ToDouble(registro[13]);
                estoque.precoVendaEstoque = Convert.ToDouble(registro[14]);

                estoque.codigoBarrasProduto = (registro[15].ToString());
                estoque.ProdutoCor.ImagemProduto = (registro[16].ToString());
                estoque.dataEstoque = Convert.ToDateTime(registro[17]);

                estoqueLista.Add(estoque);
            }

            return estoqueLista;
        }

        //Buscar estoque por Produto separadamente 
        public EstoqueLista BuscarEstoquePorProduto(int codProduto)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@produto", codProduto));
            string comandoSql = "exec uspBuscarEstoquePorProduto @produto";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

            EstoqueLista estoqueLista = new EstoqueLista();
            Estoque estoque;

            foreach (DataRow registro in tabelaRetorno.Rows)
            {
                //define o objeto para não mantelo nullo
                estoque = new Estoque();
                estoque.ProdutoCor = new ProdutoCor();
                estoque.tamanhoProduto = new Tamanho();
                estoque.ProdutoCor.Cor = new Cor();

                estoque.ProdutoCor.Cor.nomeCor = registro[0].ToString();
                estoque.tamanhoProduto.nometamanho = (registro[1].ToString());
                estoque.quantidadeEstoque = Convert.ToInt32(registro[2]);
                estoque.precoCustoEstoque = Convert.ToDouble(registro[3]);
                estoque.precoVendaEstoque = Convert.ToDouble(registro[4]);

                estoque.codigoBarrasProduto = (registro[5].ToString());
                estoque.ProdutoCor.ImagemProduto = (registro[6].ToString());

                estoqueLista.Add(estoque);
            }

            return estoqueLista;
        }

       //Buscar por produtoCor separadamente
        public EstoqueLista BuscarEstoquePorProdutoCor(int codProduto)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@produto", codProduto));
            string comandoSql = "exec uspBuscarEstoquePorProdutoCor @produto";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

            EstoqueLista estoqueLista = new EstoqueLista();
            Estoque estoque;

            foreach (DataRow registro in tabelaRetorno.Rows)
            {
                //define o objeto para não mantelo nullo
                estoque = new Estoque();
                estoque.ProdutoCor = new ProdutoCor();
                estoque.tamanhoProduto = new Tamanho();
                estoque.ProdutoCor.Cor = new Cor();

                estoque.ProdutoCor.Cor.nomeCor = registro[0].ToString();
                estoque.tamanhoProduto.nometamanho = (registro[1].ToString());
                estoque.quantidadeEstoque = Convert.ToInt32(registro[2]);
                estoque.precoCustoEstoque = Convert.ToDouble(registro[3]);
                estoque.precoVendaEstoque = Convert.ToDouble(registro[4]);

                estoque.codigoBarrasProduto = (registro[5].ToString());
                estoque.ProdutoCor.ImagemProduto = (registro[6].ToString());

                estoqueLista.Add(estoque);
            }

            return estoqueLista;
        }

        //----------------------------Estoque Inserção de Código de Barras
       //Busca Produtos e com cores e tamanhos para realizar as atualizações (CódigoBarras,Preço ETC...)
        public EstoqueLista BuscarTamanhoProdutoCorPorProduto(int codigoProdutoCor)
        {
            try
            {
                DataTable tabelaResultado;

                EstoqueLista itemEstoqueLista = new EstoqueLista();


                this.sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@codigoProdutoCor", codigoProdutoCor));

                string comando = "exec uspBuscarTamanhoProdutoCorPorProduto @codigoProdutoCor";

                tabelaResultado = this.sqlServer.ExecutarConsulta(comando, CommandType.Text);

                foreach (DataRow registro in tabelaResultado.Rows)
                {

                    Estoque itemEstoque = new Estoque();
                    itemEstoque.ProdutoCor = new ProdutoCor();
                    itemEstoque.ProdutoCor.Produto = new Produto();
                    itemEstoque.ProdutoCor.Cor = new Cor();
                    itemEstoque.ProdutoCor.Produto.Genero = new Genero();
                    itemEstoque.tamanhoProduto = new Tamanho();

                    itemEstoque.codigoEstoque = (Convert.ToInt32(registro[0]));
                    itemEstoque.ProdutoCor.Produto.codigoProduto = (Convert.ToInt32(registro[1]));
                    itemEstoque.ProdutoCor.codigoProdutoCor = (Convert.ToInt32(registro[2]));
                    itemEstoque.ProdutoCor.Cor.codigoCor = (Convert.ToInt32(registro[3]));
                    itemEstoque.ProdutoCor.Cor.nomeCor = (registro[4].ToString());
                    itemEstoque.tamanhoProduto.codigoTamanho = (Convert.ToInt32(registro[5]));
                    itemEstoque.tamanhoProduto.nometamanho = (registro[6].ToString());
                    itemEstoque.quantidadeEstoque = Convert.ToInt32(registro[7]);
                    itemEstoque.precoCustoEstoque = Convert.ToDouble(registro[8]);
                    itemEstoque.precoVendaEstoque = Convert.ToDouble(registro[9]);
                    itemEstoque.codigoBarrasProduto = (registro[10].ToString());
                    itemEstoque.ProdutoCor.ImagemProduto = (registro[11].ToString());

                    itemEstoqueLista.Add(itemEstoque);
                }

                return itemEstoqueLista;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar os Cores do Item. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //metodo para realizar o lançamento Atualização do estoque
        public Boolean CadastraEstoqueLista(EstoqueLista itemEstoqueLista)
        {
            try
            {
                foreach (Estoque itemEstoque in itemEstoqueLista)
                {

                    sqlServer.LimparParametros();

                    sqlServer.AdicionarParametro(new SqlParameter("@codigoProdutoCor", itemEstoque.ProdutoCor.codigoProdutoCor));
                    sqlServer.AdicionarParametro(new SqlParameter("@precoCusto", itemEstoque.precoCustoEstoque));
                    sqlServer.AdicionarParametro(new SqlParameter("@precoVenda", itemEstoque.precoVendaEstoque));
                    sqlServer.AdicionarParametro(new SqlParameter("@quantidade", itemEstoque.quantidadeEstoque));
                    sqlServer.AdicionarParametro(new SqlParameter("@tamanho", itemEstoque.tamanhoProduto.codigoTamanho));
                    sqlServer.AdicionarParametro(new SqlParameter("@codigoBarras", itemEstoque.codigoBarrasProduto));


                    string comandoSql = "exec uspCadastrarEstoque  @codigoProdutoCor, @precoCusto, @precoVenda, @quantidade, @tamanho, @codigoBarras";

                    sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível Atualizar o dados do Produto. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Atualiza valor precoCustoProduto
        public Boolean AtualizarPrecoCustoEstoque(int codigoProdutoCor, double precoCusto, int tamanho)
        {
            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@codigoProdutoCor", codigoProdutoCor));
                sqlServer.AdicionarParametro(new SqlParameter("@precoCusto", precoCusto));
                sqlServer.AdicionarParametro(new SqlParameter("@tamanhoProduto", tamanho));

                string comandoSql = "exec uspAlterarPrecoCustoEstoque @codigoProdutoCor, @precoCusto, @tamanhoProduto";
                sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                return true;

            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possivel Atualizar valores do Produto!" + ex.Message);
            }
        }

        //Atualiza valor precoVendaProduto
        public Boolean AtualizarPrecoVendaEstoque(int codigoProdutoCor, double precoVenda, int tamanho)
        {
            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@codigoProdutoCor", codigoProdutoCor));
                sqlServer.AdicionarParametro(new SqlParameter("@precoVenda", precoVenda));
                sqlServer.AdicionarParametro(new SqlParameter("@tamanhoProduto", tamanho));

                string comandoSql = "exec uspAlterarPrecoVendaEstoque @codigoProdutoCor, @precoVenda, @tamanhoProduto";
                sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                return true;

            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possivel Atualizar valores do Produto!" + ex.Message);
            }
        }

        //Atualiza valor todos os preços do estoque Lista de valores
        public Boolean AtualizarPrecoEstoque(EstoqueLista listaEstoque)
        {
            try
            {
                foreach (Estoque item in listaEstoque)
                {
                    sqlServer.LimparParametros();
                    sqlServer.AdicionarParametro(new SqlParameter("@codigoEstoque", item.codigoEstoque));
                    sqlServer.AdicionarParametro(new SqlParameter("@precoCusto", item.precoCustoEstoque));
                    sqlServer.AdicionarParametro(new SqlParameter("@precoVenda", item.precoVendaEstoque));

                    string comandoSql = "exec uspAlterarPrecoEstoque @codigoEstoque, @precoCusto, @precoVenda";
                    sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);                  
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possivel Atualizar valores do Produto!" + ex.Message);
            }
        }

    }
}
