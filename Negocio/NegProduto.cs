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
   public class NegProduto
    {
        private ConexaoSqlServer sqlServer = new ConexaoSqlServer();

        //Metodo para cadastrar produto
        public Boolean CadastrarProduto(Produto produto)
        {
            try
            {
                sqlServer.LimparParametros();

                sqlServer.AdicionarParametro(new SqlParameter("@descricao", produto.descricaoProduto));
                sqlServer.AdicionarParametro(new SqlParameter("@referencia", produto.referenciaProduto));
                sqlServer.AdicionarParametro(new SqlParameter("@sexo", produto.sexoProduto));
                sqlServer.AdicionarParametro(new SqlParameter("@quantidade", produto.quantidadeProduto));
                sqlServer.AdicionarParametro(new SqlParameter("@genero", produto.Genero.codigoGenero));
                sqlServer.AdicionarParametro(new SqlParameter("@grade", produto.Grade.codigoGrade));
                sqlServer.AdicionarParametro(new SqlParameter("@fornecedor", produto.Fornecedor.codigoFornecedor));
                sqlServer.AdicionarParametro(new SqlParameter("@precoCusto", produto.precoCustoProduto));
                sqlServer.AdicionarParametro(new SqlParameter("@precoVenda", produto.precoVendaProduto));

                string comandoSql = "exec uspCadastrarProduto @descricao, @referencia, @sexo, @quantidade, @genero, @grade, @fornecedor, @precoCusto, @precoVenda";

                sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível cadastrar o produto. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //metodo para alterar produto
        public Boolean AtualizarProduto(Produto produto)
        {
            try
            {

                sqlServer.LimparParametros();

                sqlServer.AdicionarParametro(new SqlParameter("@codigo", produto.codigoProduto));
                sqlServer.AdicionarParametro(new SqlParameter("@descricao", produto.descricaoProduto));
                sqlServer.AdicionarParametro(new SqlParameter("@referencia", produto.referenciaProduto));
                sqlServer.AdicionarParametro(new SqlParameter("@sexo", produto.sexoProduto));
                sqlServer.AdicionarParametro(new SqlParameter("@quantidade", produto.quantidadeProduto));
                sqlServer.AdicionarParametro(new SqlParameter("@genero", produto.Genero.codigoGenero));
                sqlServer.AdicionarParametro(new SqlParameter("@grade", produto.Grade.codigoGrade));
                sqlServer.AdicionarParametro(new SqlParameter("@fornecedor", produto.Fornecedor.codigoFornecedor));
                sqlServer.AdicionarParametro(new SqlParameter("@precoCusto", produto.precoCustoProduto));
                sqlServer.AdicionarParametro(new SqlParameter("@precoVenda", produto.precoVendaProduto));

                string comandoSql = "exec uspAlterarProduto @codigo, @descricao, @referencia, @sexo, @quantidade, @genero, @grade, @fornecedor, @precoCusto, @precoVenda";

                sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível alterar os dados do Produto. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Metodo excluir produto
        public Boolean ExcluirProduto(Produto produto)
        {
            try
            {

                sqlServer.LimparParametros();

                sqlServer.AdicionarParametro(new SqlParameter("@codigo", produto.codigoProduto));

                string comandoSql = "exec uspExcluirProduto @codigo";

                object Resposta = sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                if (Convert.ToInt16(Resposta) == 1 || Convert.ToInt16(Resposta) == 2)
                {
                    return false;//Produto tem cores vinculadas
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

       //--------------------------Consultas

        //metodo para buscar produto por nome
        public ProdutoLista BuscarProdutoPorNome(string nome)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@descricao", nome));
            string comandoSql = "exec uspBuscarProdutoPorNome @descricao";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

            if (tabelaRetorno.Rows.Count == 0)
            {
                //throw new Exception("Não foram retornados dados na consulta.");
            }

            ProdutoLista produtos = new ProdutoLista();
            Produto produto;

            foreach (DataRow registro in tabelaRetorno.Rows)
            {
                //define o objeto para não mantelo nullo
                produto = new Produto();
                produto.Genero = new Genero();
                produto.Grade = new Grade();
                produto.Fornecedor = new Fornecedor();

                produto.codigoProduto = Convert.ToInt32(registro[0]);
                produto.descricaoProduto = registro[1].ToString();
                produto.referenciaProduto = registro[2].ToString();
                produto.sexoProduto = registro[3].ToString();

                produto.Genero.codigoGenero = Convert.ToInt32(registro[4]);
                produto.Genero.nomeGenero = registro[5].ToString();

                produto.Grade.codigoGrade = Convert.ToInt32(registro[6]);
                produto.Grade.nomeGrade = registro[7].ToString();

                produto.Fornecedor.codigoFornecedor = Convert.ToInt32(registro[8]);
                produto.Fornecedor.nomeFantasiaFornecedor = registro[9].ToString();

                produto.quantidadeProduto = Convert.ToInt32(registro[10]);
                produto.precoCustoProduto = Convert.ToDouble(registro[11]);
                produto.precoVendaProduto = Convert.ToDouble(registro[12]);

                produto.dataProduto = Convert.ToDateTime(registro[13]);
                
                produtos.Add(produto);
            }

            return produtos;
        }

        //metodo para buscar produto por codigo
        public Produto BuscarProdutoPorCodigo(int codigo)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@codigo", codigo));
            string comandoSql = "exec uspBuscarProdutoPorCodigo @codigo";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);
            Produto produto = new Produto();

            if (tabelaRetorno.Rows.Count > 0)
            {
                DataRow registro = tabelaRetorno.Rows[0];

                //define o objeto para não mantelo nullo
                produto = new Produto();
                produto.Genero = new Genero();
                produto.Grade = new Grade();
                produto.Fornecedor = new Fornecedor();

                produto.codigoProduto = Convert.ToInt32(registro[0]);
                produto.descricaoProduto = registro[1].ToString();
                produto.referenciaProduto = registro[2].ToString();
                produto.sexoProduto = registro[3].ToString();

                produto.Genero.codigoGenero = Convert.ToInt32(registro[4]);
                produto.Genero.nomeGenero = registro[5].ToString();

                produto.Grade.codigoGrade = Convert.ToInt32(registro[6]);
                produto.Grade.nomeGrade = registro[7].ToString();

                produto.Fornecedor.codigoFornecedor = Convert.ToInt32(registro[8]);
                produto.Fornecedor.nomeFantasiaFornecedor = registro[9].ToString();

                produto.quantidadeProduto = Convert.ToInt32(registro[10]);
                produto.precoCustoProduto = Convert.ToDouble(registro[11]);
                produto.precoVendaProduto = Convert.ToDouble(registro[12]);

                produto.dataProduto = Convert.ToDateTime(registro[13]);

                return produto;
            }
            else
            {
                return null;
            }
        }

        //metodo para buscar produto por codigo
        public Produto BuscarProdutoPorReferencia(string referencia)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@referencia", referencia));
            string comandoSql = "exec uspBuscarProdutoPorReferencia @referencia";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);
            Produto produto = new Produto();

            if (tabelaRetorno.Rows.Count > 0)
            {
                DataRow registro = tabelaRetorno.Rows[0];

                //define o objeto para não mantelo nullo
                produto = new Produto();
                produto.Genero = new Genero();
                produto.Grade = new Grade();
                produto.Fornecedor = new Fornecedor();

                produto.codigoProduto = Convert.ToInt32(registro[0]);
                produto.descricaoProduto = registro[1].ToString();
                produto.referenciaProduto = registro[2].ToString();
                produto.sexoProduto = registro[3].ToString();

                produto.Genero.codigoGenero = Convert.ToInt32(registro[4]);
                produto.Genero.nomeGenero = registro[5].ToString();

                produto.Grade.codigoGrade = Convert.ToInt32(registro[6]);
                produto.Grade.nomeGrade = registro[7].ToString();

                produto.Fornecedor.codigoFornecedor = Convert.ToInt32(registro[8]);
                produto.Fornecedor.nomeFantasiaFornecedor = registro[9].ToString();

                produto.quantidadeProduto = Convert.ToInt32(registro[10]);
                produto.precoCustoProduto = Convert.ToDouble(registro[11]);
                produto.precoVendaProduto = Convert.ToDouble(registro[12]);

                produto.dataProduto = Convert.ToDateTime(registro[13]);

                return produto;
            }
            else
            {
                return null;
            }
        }

       //---------------------------Estoque
       //metodo Buscar imagens do Produto
        public ImagemProdutoLista BuscarImagensProduto(int codigoProduto)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@codigoProduto", codigoProduto));
            string comandoSql = "exec uspBuscarImagemProduto @codigoProduto";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

            if (tabelaRetorno.Rows.Count == 0)
            {
                //throw new Exception("Não foram retornados dados na consulta.");
            }

            ImagemProdutoLista imgProdutoLista = new ImagemProdutoLista();
            string imgProduto;

            foreach (DataRow registro in tabelaRetorno.Rows)
            {

                imgProduto = (registro[0].ToString());
                imgProdutoLista.Add(imgProduto);
            }

            return imgProdutoLista;
        }

        //Buscar e retornar ultimo registro do sqlServer
        public int BuscarUltimoRegistroProduto()
        {
            try
            {
                string comando = " exec uspProdutoUltimoRegistro ";

                object Resposta = sqlServer.ExecutarScalar(comando, System.Data.CommandType.Text);

                return Convert.ToInt16(Resposta);

            }
            catch (Exception ex)
            {
                //caso não houver nenhum registro retorna 1 para o primeiro cadastro
                return 1;
                throw new Exception("Erro na camada de negócios - Retorno. " + ex.Message);

            }
        }


        //Atualiza valor todos os preços do estoque
        public Boolean AtualizarPrecoProduto(int codigoProduto, double precoCusto, double precoVenda)
        {
            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@codigoProduto", codigoProduto));
                sqlServer.AdicionarParametro(new SqlParameter("@precoCusto", precoCusto));
                sqlServer.AdicionarParametro(new SqlParameter("@precoVenda", precoVenda));

                string comandoSql = "exec uspAlterarPrecoProduto @codigoProduto, @precoCusto, @precoVenda";
                sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                return true;

            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possivel Atualizar valores do Produto!" + ex.Message);
            }
        }

       //--------------------------Validações

        //realiza a validação se ja a o produto cadastrado de acordo com a referencia
        public Produto ValidarCadastroProdutoPorReferencia(String strReferencia)
        {
            try
            {
                DataTable tabelaRetorno;
                Produto produto;

                this.sqlServer.LimparParametros();
                this.sqlServer.AdicionarParametro(new SqlParameter("@referencia", strReferencia));

                string comando = "exec uspValidaCadastroProduto @referencia";

                tabelaRetorno = this.sqlServer.ExecutarConsulta(comando, CommandType.Text);
                if (tabelaRetorno.Rows.Count > 0)
                {
                    DataRow registro = tabelaRetorno.Rows[0];//Consulta só retorna uma objeto

                    produto = new Produto();

                    produto.codigoProduto = Convert.ToInt32(registro[0]);
                    produto.descricaoProduto = (registro[1].ToString());

                    return produto;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível validar a Referencia do Produto. [Negócios]. Motivo: " + ex.Message);
            }
        }

       //-------------------------Venda
        //metodo Buscar imagens do Produto
        public ImagemProdutoLista BuscarImagensProdutoVenda(int codigoProduto, int codigoVenda)
        {
            this.sqlServer.LimparParametros();

            this.sqlServer.AdicionarParametro(new SqlParameter("@codigoProduto", codigoProduto));
            this.sqlServer.AdicionarParametro(new SqlParameter("@codigoVenda", codigoVenda));

            string comandoSql = "exec uspBuscarImagemProdutoVenda @codigoProduto, @codigoVenda";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

            if (tabelaRetorno.Rows.Count == 0)
            {
                //throw new Exception("Não foram retornados dados na consulta.");
            }

            ImagemProdutoLista imgProdutoLista = new ImagemProdutoLista();
            string imgProduto;

            foreach (DataRow registro in tabelaRetorno.Rows)
            {

                imgProduto = (registro[0].ToString());
                imgProdutoLista.Add(imgProduto);
            }

            return imgProdutoLista;
        }

        //metodo para buscar produto por nome para realizar a venda busca somente produtos que tem estoque
        public ProdutoLista BuscarProdutoVendaPorNome(string nome,int codigoVenda)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@descricao", nome));
            this.sqlServer.AdicionarParametro(new SqlParameter("@codigoVenda", codigoVenda));

            string comandoSql = "exec uspBuscarProdutoVendaPorNome @descricao, @codigoVenda";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

            if (tabelaRetorno.Rows.Count == 0)
            {
                //throw new Exception("Não foram retornados dados na consulta.");
            }

            ProdutoLista produtos = new ProdutoLista();
            Produto produto;

            foreach (DataRow registro in tabelaRetorno.Rows)
            {
                //define o objeto para não mantelo nullo
                produto = new Produto();
                produto.Genero = new Genero();
                produto.Grade = new Grade();
                produto.Fornecedor = new Fornecedor();

                produto.codigoProduto = Convert.ToInt32(registro[0]);
                produto.descricaoProduto = registro[1].ToString();
                produto.referenciaProduto = registro[2].ToString();
                produto.sexoProduto = registro[3].ToString();

                produto.Genero.codigoGenero = Convert.ToInt32(registro[4]);
                produto.Genero.nomeGenero = registro[5].ToString();

                produto.Grade.codigoGrade = Convert.ToInt32(registro[6]);
                produto.Grade.nomeGrade = registro[7].ToString();

                produto.Fornecedor.codigoFornecedor = Convert.ToInt32(registro[8]);
                produto.Fornecedor.nomeFantasiaFornecedor = registro[9].ToString();

                produto.quantidadeProduto = Convert.ToInt32(registro[10]);
                produto.precoCustoProduto = Convert.ToDouble(registro[11]);
                produto.precoVendaProduto = Convert.ToDouble(registro[12]);

                produto.dataProduto = Convert.ToDateTime(registro[13]);

                produtos.Add(produto);
            }

            return produtos;
        }

        //metodo para buscar produto por codigo
        public Produto BuscarProdutoVendaPorCodigo(int codigoProduto, int codigoVenda)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@codigoProduto", codigoProduto));
            this.sqlServer.AdicionarParametro(new SqlParameter("@codigoVenda", codigoVenda));

            string comandoSql = "exec uspBuscarProdutoVendaPorCodigo @codigoProduto, @codigoVenda";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);
            Produto produto = new Produto();

            if (tabelaRetorno.Rows.Count > 0)
            {
                DataRow registro = tabelaRetorno.Rows[0];

                //define o objeto para não mantelo nullo
                produto = new Produto();
                produto.Genero = new Genero();
                produto.Grade = new Grade();
                produto.Fornecedor = new Fornecedor();

                produto.codigoProduto = Convert.ToInt32(registro[0]);
                produto.descricaoProduto = registro[1].ToString();
                produto.referenciaProduto = registro[2].ToString();
                produto.sexoProduto = registro[3].ToString();

                produto.Genero.codigoGenero = Convert.ToInt32(registro[4]);
                produto.Genero.nomeGenero = registro[5].ToString();

                produto.Grade.codigoGrade = Convert.ToInt32(registro[6]);
                produto.Grade.nomeGrade = registro[7].ToString();

                produto.Fornecedor.codigoFornecedor = Convert.ToInt32(registro[8]);
                produto.Fornecedor.nomeFantasiaFornecedor = registro[9].ToString();

                produto.quantidadeProduto = Convert.ToInt32(registro[10]);
                produto.precoCustoProduto = Convert.ToDouble(registro[11]);
                produto.precoVendaProduto = Convert.ToDouble(registro[12]);

                produto.dataProduto = Convert.ToDateTime(registro[13]);

                return produto;
            }
            else
            {
                return null;
            }
        }

        //metodo para buscar produto por codigo
        public Produto BuscarProdutoVendaPorReferencia(string referencia, int codigoVenda)
        {
            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@referencia", referencia));
            this.sqlServer.AdicionarParametro(new SqlParameter("@codigoVenda", codigoVenda));

            string comandoSql = "exec uspBuscarProdutoVendaPorReferencia @referencia, @codigoVenda";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);
            Produto produto = new Produto();

            if (tabelaRetorno.Rows.Count > 0)
            {
                DataRow registro = tabelaRetorno.Rows[0];

                //define o objeto para não mantelo nullo
                produto = new Produto();
                produto.Genero = new Genero();
                produto.Grade = new Grade();
                produto.Fornecedor = new Fornecedor();

                produto.codigoProduto = Convert.ToInt32(registro[0]);
                produto.descricaoProduto = registro[1].ToString();
                produto.referenciaProduto = registro[2].ToString();
                produto.sexoProduto = registro[3].ToString();

                produto.Genero.codigoGenero = Convert.ToInt32(registro[4]);
                produto.Genero.nomeGenero = registro[5].ToString();

                produto.Grade.codigoGrade = Convert.ToInt32(registro[6]);
                produto.Grade.nomeGrade = registro[7].ToString();

                produto.Fornecedor.codigoFornecedor = Convert.ToInt32(registro[8]);
                produto.Fornecedor.nomeFantasiaFornecedor = registro[9].ToString();

                produto.quantidadeProduto = Convert.ToInt32(registro[10]);
                produto.precoCustoProduto = Convert.ToDouble(registro[11]);
                produto.precoVendaProduto = Convert.ToDouble(registro[12]);

                produto.dataProduto = Convert.ToDateTime(registro[13]);

                return produto;
            }
            else
            {
                return null;
            }
        }

    }
}
