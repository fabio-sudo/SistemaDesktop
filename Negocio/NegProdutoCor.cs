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
   public class NegProdutoCor
    {

        private ConexaoSqlServer sqlServer = new ConexaoSqlServer();

        //Metodo para cadastrar produto Cor
        public Boolean CadastrarProdutoCor(ProdutoCor produtoCor)
        {
            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@produto", produtoCor.Produto.codigoProduto));
                sqlServer.AdicionarParametro(new SqlParameter("@cor", produtoCor.Cor.codigoCor));
                sqlServer.AdicionarParametro(new SqlParameter("@imagem", produtoCor.ImagemProduto));


                string comandoSql = "exec uspCadastrarProdutoCor @produto, @cor, @imagem";

                object Resposta = sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);
                
                if (Convert.ToInt16(Resposta) == 1 || Convert.ToInt16(Resposta) == 2)
                {
                    return false;//A cor já esta vinculada ao produto
                }
                else
                    return true;


            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível cadastrar o produto. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //metodo para alterar produto Cor
        public Boolean AtualizarProdutoCor(ProdutoCor produtoCor)
        {
            try
            {

                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@codigo", produtoCor.codigoProdutoCor));
                sqlServer.AdicionarParametro(new SqlParameter("@produto", produtoCor.Produto.codigoProduto));
                sqlServer.AdicionarParametro(new SqlParameter("@cor", produtoCor.Cor.codigoCor));
                sqlServer.AdicionarParametro(new SqlParameter("@imagem", produtoCor.ImagemProduto));


                string comandoSql = "exec uspAlterarProdutoCor @codigo, @produto, @cor, @imagem";

                sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível alterar os dados do Produto. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Metodo excluir produto Cor
        public Boolean ExcluirProdutoCor(ProdutoCor produtoCor)
        {
            try
            {

                sqlServer.LimparParametros();

                sqlServer.AdicionarParametro(new SqlParameter("@codigo", produtoCor.codigoProdutoCor));

                string comandoSql = "exec uspExcluirProdutoCor @codigo";

                object Resposta = sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                if (Convert.ToInt16(Resposta) == 1 || Convert.ToInt16(Resposta) == 2 || Convert.ToInt16(Resposta) == 3)
                {
                    return false;//1 itemEntrada 2 ItemVenda 3 ItemCrediario
                }
                else
                    return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível excluir os dados do Produto. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Metodo para cadastrar produto Cor
        public Boolean CadastrarProdutoCorLista(ProdutoCorLista produtoCorLista)
        {
            try
            {

                foreach (ProdutoCor produtoCor in produtoCorLista)
                {

                    sqlServer.LimparParametros();
                    sqlServer.AdicionarParametro(new SqlParameter("@produto", produtoCor.Produto.codigoProduto));
                    sqlServer.AdicionarParametro(new SqlParameter("@cor", produtoCor.Cor.codigoCor));
                    sqlServer.AdicionarParametro(new SqlParameter("@imagem", produtoCor.ImagemProduto));

                    string comandoSql = "exec uspCadastrarProdutoCor @produto, @cor, @imagem";

                    object Resposta = sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                    if (Convert.ToInt16(Resposta) == 1 || Convert.ToInt16(Resposta) == 2)
                    {
                        return false;//A cor já esta vinculada ao produto
                    }
                }
                return true;

            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível cadastrar cores do produto. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //--------------------------Consultas

        //metodo para buscar produto Cor por nome
        public ProdutoCorLista BuscarProdutoCorPorNome(string nome)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@descricao", nome));
            string comandoSql = "exec uspBuscarProdutoCorPorNome @descricao";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

            if (tabelaRetorno.Rows.Count == 0)
            {
                //throw new Exception("Não foram retornados dados na consulta.");
            }

            ProdutoCorLista produtoCores = new ProdutoCorLista();
            ProdutoCor produtoCor;

            foreach (DataRow registro in tabelaRetorno.Rows)
            {
                //define o objeto para não mantelo nullo
                produtoCor = new ProdutoCor();
                produtoCor.Cor = new Cor();

                produtoCor.Produto = new Produto();
                produtoCor.Produto.Genero = new Genero();
                produtoCor.Produto.Grade = new Grade();
                produtoCor.Produto.Fornecedor = new Fornecedor();


                produtoCor.codigoProdutoCor = Convert.ToInt32(registro[0]);

                produtoCor.Produto.codigoProduto = Convert.ToInt32(registro[1]);
                produtoCor.Produto.descricaoProduto = registro[2].ToString();
                produtoCor.Produto.referenciaProduto = registro[3].ToString();
                produtoCor.Produto.sexoProduto = registro[4].ToString();

                produtoCor.Produto.Genero.codigoGenero = Convert.ToInt32(registro[5]);
                produtoCor.Produto.Genero.nomeGenero = registro[6].ToString();

                produtoCor.Cor.codigoCor = Convert.ToInt32(registro[7]);
                produtoCor.Cor.nomeCor = registro[8].ToString();

                produtoCor.Produto.Grade.codigoGrade = Convert.ToInt32(registro[9]);
                produtoCor.Produto.Grade.nomeGrade = registro[10].ToString();

                produtoCor.Produto.Fornecedor.codigoFornecedor = Convert.ToInt32(registro[11]);
                produtoCor.Produto.Fornecedor.nomeFantasiaFornecedor = registro[12].ToString();

                produtoCor.Produto.quantidadeProduto = Convert.ToInt32(registro[13]);
                produtoCor.Produto.precoCustoProduto = Convert.ToDouble(registro[14]);
                produtoCor.Produto.precoVendaProduto = Convert.ToDouble(registro[15]);

                produtoCor.ImagemProduto = (registro[16].ToString());

                produtoCores.Add(produtoCor);
            }

            return produtoCores;
        }

        //metodo para buscar produto Cor por nome
        public ProdutoCor BuscarProdutoCorPorCodigo(int codigo)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@codigo", codigo));
            string comandoSql = "exec uspBuscarProdutoCorPorCodigo @codigo";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

            ProdutoCor produtoCor = new ProdutoCor();

            if (tabelaRetorno.Rows.Count > 0)
            {
                DataRow registro = tabelaRetorno.Rows[0];
                //define o objeto para não mantelo nullo
                produtoCor = new ProdutoCor();
                produtoCor.Cor = new Cor();

                produtoCor.Produto = new Produto();
                produtoCor.Produto.Genero = new Genero();
                produtoCor.Produto.Grade = new Grade();
                produtoCor.Produto.Fornecedor = new Fornecedor();


                produtoCor.codigoProdutoCor = Convert.ToInt32(registro[0]);

                produtoCor.Produto.codigoProduto = Convert.ToInt32(registro[1]);
                produtoCor.Produto.descricaoProduto = registro[2].ToString();
                produtoCor.Produto.referenciaProduto = registro[3].ToString();
                produtoCor.Produto.sexoProduto = registro[4].ToString();

                produtoCor.Produto.Genero.codigoGenero = Convert.ToInt32(registro[5]);
                produtoCor.Produto.Genero.nomeGenero = registro[6].ToString();

                produtoCor.Cor.codigoCor = Convert.ToInt32(registro[7]);
                produtoCor.Cor.nomeCor = registro[8].ToString();

                produtoCor.Produto.Grade.codigoGrade = Convert.ToInt32(registro[9]);
                produtoCor.Produto.Grade.nomeGrade = registro[10].ToString();

                produtoCor.Produto.Fornecedor.codigoFornecedor = Convert.ToInt32(registro[11]);
                produtoCor.Produto.Fornecedor.nomeFantasiaFornecedor = registro[12].ToString();

                produtoCor.Produto.quantidadeProduto = Convert.ToInt32(registro[13]);
                produtoCor.Produto.precoCustoProduto = Convert.ToDouble(registro[14]);
                produtoCor.Produto.precoVendaProduto = Convert.ToDouble(registro[15]);

                produtoCor.ImagemProduto = (registro[16].ToString());


            return produtoCor;
            }
            else
            {
                return null;
            }
        }

       //-----------------------Metodos Buscar cores do Produto para Cadastro e Alteração

        //metodo para buscar produto por nome da cor -> Busca só cores que não estão na tabela ProdutoCor com codigo do Produto
        public CorLista BuscarCorProdutoPorNome(string nomeCor, int codigoProduto)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@nomeCor", nomeCor));
            this.sqlServer.AdicionarParametro(new SqlParameter("@codigoProduto", codigoProduto));

            string comandoSql = "exec uspBuscarCorProdutoPorNome @nomeCor, @codigoProduto";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

            CorLista corLista = new CorLista();
            Cor cor;

            foreach (DataRow registro in tabelaRetorno.Rows)
            {
                cor = new Cor();

                cor.codigoCor = Convert.ToInt32(registro[0]);
                cor.nomeCor = registro[1].ToString();

                corLista.Add(cor);
            }

            return corLista;
        }

        //Buscar Cores que estão no Produto Cor
        public ProdutoCorLista BuscarCorProdutoPorCodigo(int codigoProduto)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@codigoProduto", codigoProduto));
            string comandoSql = "exec uspBuscarCorProdutoPorCodigo @codigoProduto";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);


            ProdutoCorLista produtoCorLista = new ProdutoCorLista();
            ProdutoCor produtoCor;

            foreach (DataRow registro in tabelaRetorno.Rows)
            {
                produtoCor = new ProdutoCor();
                produtoCor.Cor = new Cor();
                produtoCor.Produto = new Produto();

                produtoCor.Produto.codigoProduto = Convert.ToInt32(registro[0]);
                produtoCor.Cor.codigoCor = Convert.ToInt32(registro[1]);
                produtoCor.Cor.nomeCor = registro[2].ToString();
                produtoCor.ImagemProduto = registro[3].ToString();

                produtoCorLista.Add(produtoCor);

                //-----------Lista esta trazendo o codigoProduto e imagem do Produto
            }

            return produtoCorLista;
        }

        //Buscar Cores que estão no Produto Cor
        public ProdutoCorLista BuscarCoresProdutoPorCodigo(int codigoProduto)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@codigoProduto", codigoProduto));
            string comandoSql = "exec uspBuscarCoresProdutoPorCodigo @codigoProduto";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);


            ProdutoCorLista produtoCorLista = new ProdutoCorLista();
            ProdutoCor produtoCor;

            foreach (DataRow registro in tabelaRetorno.Rows)
            {
                produtoCor = new ProdutoCor();
                produtoCor.Cor = new Cor();
                produtoCor.Produto = new Produto();

                produtoCor.codigoProdutoCor = Convert.ToInt32(registro[0]);
                produtoCor.Cor.codigoCor = Convert.ToInt32(registro[1]);
                produtoCor.Cor.nomeCor = registro[2].ToString();
                produtoCor.ImagemProduto = registro[3].ToString();

                produtoCorLista.Add(produtoCor);

                //-----------Lista esta trazendo o codigoProduto e imagem do Produto
            }

            return produtoCorLista;
        }

       //---------------------------Cores Produto
        //Metodo excluir produto Cor
        public Boolean ExcluirCorProduto(ProdutoCor produtoCor)
        {
            try
            {

                sqlServer.LimparParametros();

                sqlServer.AdicionarParametro(new SqlParameter("@codigoProduto", produtoCor.Produto.codigoProduto));
                sqlServer.AdicionarParametro(new SqlParameter("@codigoCor", produtoCor.Cor.codigoCor));

                string comandoSql = "exec uspExcluirCorProduto @codigoProduto, @codigoCor";

                object Resposta = sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                if (Convert.ToInt16(Resposta) == 1 || Convert.ToInt16(Resposta) == 2 || Convert.ToInt16(Resposta) == 3)
                {
                    return false;//1 itemEntrada 2 ItemVenda 3 ItemCrediario
                }
                else
                    return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível excluir as cores do Produto. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Metodo excluir Lista de produto cpr
        public Boolean ExcluirListaCorProduto(ProdutoCorLista produtoCorLista, string imgLocal)
        {
            try
            {
                foreach (ProdutoCor produtoCor in produtoCorLista)
                {
                    sqlServer.LimparParametros();
                    sqlServer.AdicionarParametro(new SqlParameter("@codigoProduto", produtoCor.Produto.codigoProduto));
                    sqlServer.AdicionarParametro(new SqlParameter("@codigoCor", produtoCor.Cor.codigoCor));

                    string comandoSql = "exec uspExcluirCorProduto @codigoProduto, @codigoCor";

                    object Resposta = sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                    if (Convert.ToInt16(Resposta) == 1 || Convert.ToInt16(Resposta) == 2 || Convert.ToInt16(Resposta) == 3)
                    {
                        return false;//1 itemEntrada 2 ItemVenda 3 ItemCrediario
                    }
                    //Verifica se a imagem existe e exclui a mesma
                    if (System.IO.File.Exists(imgLocal + produtoCor.ImagemProduto + ".jpeg") == true)
                    {
                        System.IO.File.Delete((imgLocal + produtoCor.ImagemProduto + ".jpeg"));
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

        //metodo para alterar cor imagem Produto -> adiciona imagem no Formulario ALT&EXC 
        public Boolean AtualizarImagemProdutoCor(int codigoProduto, int codigoCor, string ImgProduto)
        {
            try
            {

                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@produto", codigoProduto));
                sqlServer.AdicionarParametro(new SqlParameter("@cor", codigoCor));
                sqlServer.AdicionarParametro(new SqlParameter("@imagem", ImgProduto));


                string comandoSql = "exec uspAlterarImagemCorProduto @produto, @cor, @imagem";

                sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível adicionar nova Imagem no Produto. [Negócios]. Motivo: " + ex.Message);
            }
        }

       //----------------------------Venda
        //Buscar Cores que estão no Produto Cor
        public ProdutoCorLista BuscarCoresProdutoVendaPorCodigo(int codigoProduto, int codigoVenda)
        {
            try
            {
                this.sqlServer.LimparParametros();
                this.sqlServer.AdicionarParametro(new SqlParameter("@codigoProduto", codigoProduto));
                this.sqlServer.AdicionarParametro(new SqlParameter("@codigoVenda", codigoVenda));

                string comandoSql = "exec uspBuscarCoresProdutoVendaPorCodigo @codigoProduto, @codigoVenda";

                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);


                ProdutoCorLista produtoCorLista = new ProdutoCorLista();
                ProdutoCor produtoCor;

                foreach (DataRow registro in tabelaRetorno.Rows)
                {
                    produtoCor = new ProdutoCor();
                    produtoCor.Cor = new Cor();
                    produtoCor.Produto = new Produto();

                    produtoCor.codigoProdutoCor = Convert.ToInt32(registro[0]);
                    produtoCor.Cor.codigoCor = Convert.ToInt32(registro[1]);
                    produtoCor.Cor.nomeCor = registro[2].ToString();
                    produtoCor.ImagemProduto = registro[3].ToString();

                    produtoCorLista.Add(produtoCor);

                    //-----------Lista esta trazendo o codigoProduto e imagem do Produto
                }

                return produtoCorLista;
            }
            catch (Exception ex)
            {
                return null;
                throw new Exception("Não foi possível adicionar nova Imagem no Produto. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //----------------------Crediario Pago
        //metodo para buscar produto por nome
        public ProdutoCorLista uspBuscarProdutoItemCrediarioPago(string nome, int codigoCrediario)
        {
            try
            {
                this.sqlServer.LimparParametros();
                this.sqlServer.AdicionarParametro(new SqlParameter("@descricao", nome));
                this.sqlServer.AdicionarParametro(new SqlParameter("@crediario", codigoCrediario));

                string comandoSql = "exec uspBuscarItemCrediarioPagoPorProduto @descricao, @crediario";

                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

                if (tabelaRetorno.Rows.Count == 0)
                {
                    //throw new Exception("Não foram retornados dados na consulta.");
                }

                ProdutoCorLista produtos = new ProdutoCorLista();
                ProdutoCor produtoCor;

                foreach (DataRow registro in tabelaRetorno.Rows)
                {
                    //define o objeto para não mantelo nullo
                    produtoCor = new ProdutoCor();
                    produtoCor.Cor = new Cor();
                    produtoCor.Produto = new Produto();

                    produtoCor.Produto.Genero = new Genero();
                    produtoCor.Produto.Grade = new Grade();
                    produtoCor.Produto.Fornecedor = new Fornecedor();

                    produtoCor.Produto.codigoProduto = Convert.ToInt32(registro[0]);
                    produtoCor.Produto.descricaoProduto = registro[1].ToString();
                    produtoCor.Produto.referenciaProduto = registro[2].ToString();
                    produtoCor.Produto.sexoProduto = registro[3].ToString();

                    produtoCor.Produto.Genero.codigoGenero = Convert.ToInt32(registro[4]);
                    produtoCor.Produto.Genero.nomeGenero = registro[5].ToString();

                    produtoCor.Produto.Grade.codigoGrade = Convert.ToInt32(registro[6]);
                    produtoCor.Produto.Grade.nomeGrade = registro[7].ToString();

                    produtoCor.Produto.Fornecedor.codigoFornecedor = Convert.ToInt32(registro[8]);
                    produtoCor.Produto.Fornecedor.nomeFantasiaFornecedor = registro[9].ToString();

                    produtoCor.Produto.quantidadeProduto = Convert.ToInt32(registro[10]);
                    produtoCor.Produto.precoCustoProduto = Convert.ToDouble(registro[11]);
                    produtoCor.Produto.precoVendaProduto = Convert.ToDouble(registro[12]);

                    produtoCor.Produto.dataProduto = Convert.ToDateTime(registro[13]);
                    produtoCor.ImagemProduto = (registro[14]).ToString();


                    produtos.Add(produtoCor);
                }

                return produtos;
            }
            catch (Exception ex)
            {
                return null;
                throw new Exception("Não foi possível adicionar nova Imagem no Produto. [Negócios]. Motivo: " + ex.Message);
            }
        }

        public ProdutoCor uspBuscarProdutoItemCrediarioPagoPorCodigo(int codigo, int codigoCrediario)
        {
            try
            {
                this.sqlServer.LimparParametros();
                this.sqlServer.AdicionarParametro(new SqlParameter("@codigo", codigo));
                this.sqlServer.AdicionarParametro(new SqlParameter("@crediario", codigoCrediario));

                string comandoSql = "exec uspBuscarItemCrediarioPagoPorCodigoProduto @codigo, @crediario";

                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

                if (tabelaRetorno.Rows.Count == 0)
                {
                    //throw new Exception("Não foram retornados dados na consulta.");
                }

                ProdutoCorLista produtos = new ProdutoCorLista();
                ProdutoCor produtoCor;

                if (tabelaRetorno.Rows.Count > 0)
                {
                    DataRow registro = tabelaRetorno.Rows[0];

                    //define o objeto para não mantelo nullo
                    produtoCor = new ProdutoCor();
                    produtoCor.Cor = new Cor();
                    produtoCor.Produto = new Produto();

                    produtoCor.Produto.Genero = new Genero();
                    produtoCor.Produto.Grade = new Grade();
                    produtoCor.Produto.Fornecedor = new Fornecedor();

                    produtoCor.Produto.codigoProduto = Convert.ToInt32(registro[0]);
                    produtoCor.Produto.descricaoProduto = registro[1].ToString();
                    produtoCor.Produto.referenciaProduto = registro[2].ToString();
                    produtoCor.Produto.sexoProduto = registro[3].ToString();

                    produtoCor.Produto.Genero.codigoGenero = Convert.ToInt32(registro[4]);
                    produtoCor.Produto.Genero.nomeGenero = registro[5].ToString();

                    produtoCor.Produto.Grade.codigoGrade = Convert.ToInt32(registro[6]);
                    produtoCor.Produto.Grade.nomeGrade = registro[7].ToString();

                    produtoCor.Produto.Fornecedor.codigoFornecedor = Convert.ToInt32(registro[8]);
                    produtoCor.Produto.Fornecedor.nomeFantasiaFornecedor = registro[9].ToString();

                    produtoCor.Produto.quantidadeProduto = Convert.ToInt32(registro[10]);
                    produtoCor.Produto.precoCustoProduto = Convert.ToDouble(registro[11]);
                    produtoCor.Produto.precoVendaProduto = Convert.ToDouble(registro[12]);

                    produtoCor.Produto.dataProduto = Convert.ToDateTime(registro[13]);
                    produtoCor.ImagemProduto = (registro[14]).ToString();


                    return produtoCor;
                }
                else { return null; }

   
            }
            catch (Exception ex)
            {
                return null;
                throw new Exception("Não foi possível adicionar nova Imagem no Produto. [Negócios]. Motivo: " + ex.Message);
            }
        }

       //-----------------------ItemVendaCancelamento
        //metodo para buscar produto por nome
        public ProdutoCorLista BuscarProdutoItemVenda(string nome, int codigoVenda)
        {
            try
            {
                this.sqlServer.LimparParametros();
                this.sqlServer.AdicionarParametro(new SqlParameter("@descricao", nome));
                this.sqlServer.AdicionarParametro(new SqlParameter("@venda", codigoVenda));

                string comandoSql = "exec uspBuscarItemVendaPorProduto @descricao, @venda";

                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

                if (tabelaRetorno.Rows.Count == 0)
                {
                    //throw new Exception("Não foram retornados dados na consulta.");
                }

                ProdutoCorLista produtos = new ProdutoCorLista();
                ProdutoCor produtoCor;

                foreach (DataRow registro in tabelaRetorno.Rows)
                {
                    //define o objeto para não mantelo nullo
                    produtoCor = new ProdutoCor();
                    produtoCor.Cor = new Cor();
                    produtoCor.Produto = new Produto();

                    produtoCor.Produto.Genero = new Genero();
                    produtoCor.Produto.Grade = new Grade();
                    produtoCor.Produto.Fornecedor = new Fornecedor();

                    produtoCor.Produto.codigoProduto = Convert.ToInt32(registro[0]);
                    produtoCor.Produto.descricaoProduto = registro[1].ToString();
                    produtoCor.Produto.referenciaProduto = registro[2].ToString();
                    produtoCor.Produto.sexoProduto = registro[3].ToString();

                    produtoCor.Produto.Genero.codigoGenero = Convert.ToInt32(registro[4]);
                    produtoCor.Produto.Genero.nomeGenero = registro[5].ToString();

                    produtoCor.Produto.Grade.codigoGrade = Convert.ToInt32(registro[6]);
                    produtoCor.Produto.Grade.nomeGrade = registro[7].ToString();

                    produtoCor.Produto.Fornecedor.codigoFornecedor = Convert.ToInt32(registro[8]);
                    produtoCor.Produto.Fornecedor.nomeFantasiaFornecedor = registro[9].ToString();

                    produtoCor.Produto.quantidadeProduto = Convert.ToInt32(registro[10]);
                    produtoCor.Produto.precoCustoProduto = Convert.ToDouble(registro[11]);
                    produtoCor.Produto.precoVendaProduto = Convert.ToDouble(registro[12]);

                    produtoCor.Produto.dataProduto = Convert.ToDateTime(registro[13]);
                    produtoCor.ImagemProduto = (registro[14]).ToString();


                    produtos.Add(produtoCor);
                }

                return produtos;
            }
            catch (Exception ex)
            {
                return null;
                throw new Exception("Não foi possível adicionar nova Imagem no Produto. [Negócios]. Motivo: " + ex.Message);
            }
        }

        public ProdutoCor BuscarProdutoItemVendaPorCodigo(int codigo, int codigoVenda)
        {
            try
            {
                this.sqlServer.LimparParametros();
                this.sqlServer.AdicionarParametro(new SqlParameter("@codigo", codigo));
                this.sqlServer.AdicionarParametro(new SqlParameter("@venda", codigoVenda));

                string comandoSql = "exec uspBuscarItemVendaPorCodigoProduto @codigo, @venda";

                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

                if (tabelaRetorno.Rows.Count == 0)
                {
                    //throw new Exception("Não foram retornados dados na consulta.");
                }

                ProdutoCorLista produtos = new ProdutoCorLista();
                ProdutoCor produtoCor;

                if (tabelaRetorno.Rows.Count > 0)
                {
                    DataRow registro = tabelaRetorno.Rows[0];

                    //define o objeto para não mantelo nullo
                    produtoCor = new ProdutoCor();
                    produtoCor.Cor = new Cor();
                    produtoCor.Produto = new Produto();

                    produtoCor.Produto.Genero = new Genero();
                    produtoCor.Produto.Grade = new Grade();
                    produtoCor.Produto.Fornecedor = new Fornecedor();

                    produtoCor.Produto.codigoProduto = Convert.ToInt32(registro[0]);
                    produtoCor.Produto.descricaoProduto = registro[1].ToString();
                    produtoCor.Produto.referenciaProduto = registro[2].ToString();
                    produtoCor.Produto.sexoProduto = registro[3].ToString();

                    produtoCor.Produto.Genero.codigoGenero = Convert.ToInt32(registro[4]);
                    produtoCor.Produto.Genero.nomeGenero = registro[5].ToString();

                    produtoCor.Produto.Grade.codigoGrade = Convert.ToInt32(registro[6]);
                    produtoCor.Produto.Grade.nomeGrade = registro[7].ToString();

                    produtoCor.Produto.Fornecedor.codigoFornecedor = Convert.ToInt32(registro[8]);
                    produtoCor.Produto.Fornecedor.nomeFantasiaFornecedor = registro[9].ToString();

                    produtoCor.Produto.quantidadeProduto = Convert.ToInt32(registro[10]);
                    produtoCor.Produto.precoCustoProduto = Convert.ToDouble(registro[11]);
                    produtoCor.Produto.precoVendaProduto = Convert.ToDouble(registro[12]);

                    produtoCor.Produto.dataProduto = Convert.ToDateTime(registro[13]);
                    produtoCor.ImagemProduto = (registro[14]).ToString();


                    return produtoCor;
                }
                else { return null; }


            }
            catch (Exception ex)
            {
                return null;
                throw new Exception("Não foi possível adicionar nova Imagem no Produto. [Negócios]. Motivo: " + ex.Message);
            }
        }


    }
}
