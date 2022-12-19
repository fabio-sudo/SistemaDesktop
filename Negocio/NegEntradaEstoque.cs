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
    public class NegEntradaEstoque
    {
        private ConexaoSqlServer sqlServer = new ConexaoSqlServer();

        //Metodo para cadastrar Entrada Estoque
        public Boolean CadastrarEntradaEstoque(EntradaEstoque EntradaEstoque)
        {
            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@notaFiscal", EntradaEstoque.notaFiscal));
                sqlServer.AdicionarParametro(new SqlParameter("@codigoFornecedor", EntradaEstoque.Fornecedor.codigoFornecedor));
                sqlServer.AdicionarParametro(new SqlParameter("@quantidadeNota", EntradaEstoque.quantidadeProdutosNota));
                sqlServer.AdicionarParametro(new SqlParameter("@totalNota", EntradaEstoque.valorTotalNota));
                sqlServer.AdicionarParametro(new SqlParameter("@dataEntrada", EntradaEstoque.dataEntrada));


                string comandoSql = "exec uspCadastrarEntradaEstoque @notaFiscal, @codigoFornecedor, @quantidadeNota, @totalNota, @dataEntrada";

                sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível cadastrar o Entrada de Estoque. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Metodo para excluir entrada estoque
        public Boolean ExcluirEntradaEstoque(EntradaEstoque EntradaEstoque)
        {
            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@codigoEntrada", EntradaEstoque.codigoEntradaEstoque));

                string comandoSql = "exec uspExcluirEntradaEstoque @codigoEntrada ";

                object Resposta = sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                if (Convert.ToInt32(Resposta) == 1)
                {
                    return false;//Existem itens vinculados com a entrada de estoque
                }
                else
                    return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível cadastrar o Entrada de Estoque. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //método para alterar entrada estoque
        public Boolean AtualizarEntradaEstoque(EntradaEstoque EntradaEstoque)
        {
            try
            {
                sqlServer.LimparParametros();
                this.sqlServer.AdicionarParametro(new SqlParameter("@codigoEntrada", EntradaEstoque.codigoEntradaEstoque));
                this.sqlServer.AdicionarParametro(new SqlParameter("@notaFiscal", EntradaEstoque.notaFiscal));
                this.sqlServer.AdicionarParametro(new SqlParameter("@fonercedor", EntradaEstoque.Fornecedor.codigoFornecedor));
                this.sqlServer.AdicionarParametro(new SqlParameter("@quantidadeNota", EntradaEstoque.quantidadeProdutosNota));
                this.sqlServer.AdicionarParametro(new SqlParameter("@totalNota", EntradaEstoque.valorTotalNota));
                this.sqlServer.AdicionarParametro(new SqlParameter("@dataEntrada", EntradaEstoque.dataEntrada));

                string comando = "exec uspAlterarEntradaEstoque @codigoEntrada, @notaFiscal, @fonercedor, @quantidadeNota, @totalNota, @dataEntrada ";

                sqlServer.ExecutarScalar(comando, CommandType.Text);

                return true;
            }
            catch (Exception ex)
            {

                return false;
                throw new Exception("Não foi possível alterar o Entrada de Estoque. [Negócios]. Motivo: " + ex.Message);

            }

        }

        //método atualiza o estatus da entrada de estoque Pendente - Finalizado

        //--------------------------Consultas

        //Buscar e retornar ultimo registro do sqlServer
        public int BuscarUltimoRegistro()
        {
            try
            {
                string comando = " exec uspEntradaEstoqueUltimoRegistro ";

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

        //Buscar Entrada de estoque por NF e Fornecedor
        public EntradaEstoqueLista BuscarEntradaEstoquePorNotaFiscalEFornecedor(string notaFiscal, int codigoFornecedor)
        {
            try
            {
                DataTable tabelaResultado;
                EntradaEstoque entradaEstoque;
                EntradaEstoqueLista entradaEstoques = new EntradaEstoqueLista();

                this.sqlServer.LimparParametros();

                this.sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@notaFiscal", notaFiscal));
                this.sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@Fornecedor", codigoFornecedor));

                string comando = "exec uspBuscarEntradaEstoquePorNotaFiscalEForecedor @notaFiscal, @Fornecedor";

                tabelaResultado = this.sqlServer.ExecutarConsulta(comando, CommandType.Text);

                foreach (DataRow registro in tabelaResultado.Rows)
                {

                    entradaEstoque = new EntradaEstoque();
                    entradaEstoque.Fornecedor = new Fornecedor();

                    entradaEstoque.codigoEntradaEstoque = Convert.ToInt32(registro[0]);
                    entradaEstoque.notaFiscal = (registro[1].ToString());
                    entradaEstoque.Fornecedor.codigoFornecedor = Convert.ToInt32(registro[2]);
                    entradaEstoque.Fornecedor.nomeFantasiaFornecedor = registro[3].ToString();
                    entradaEstoque.quantidadeProdutosNota = Convert.ToInt32(registro[4]);
                    entradaEstoque.valorTotalNota = Convert.ToDouble(registro[5]);
                    entradaEstoque.dataEntrada = Convert.ToDateTime(registro[6]);
                    entradaEstoque.estatusEntrada = (registro[7].ToString());

                    entradaEstoques.Add(entradaEstoque);
                }

                return entradaEstoques;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar o Entrada de Estoque por NF e Fornecedor. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Buscar Entrada de estoque por NF
        public EntradaEstoqueLista BuscarEntradaEstoquePorNotaFiscal(string notaFiscal)
        {
            try
            {
                DataTable tabelaResultado;
                EntradaEstoque entradaEstoque;
                EntradaEstoqueLista entradaEstoques = new EntradaEstoqueLista();

                this.sqlServer.LimparParametros();

                this.sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@notaFiscal", notaFiscal));

                string comando = "exec uspBuscarEntradaEstoquePorNotaFiscal @notaFiscal";

                tabelaResultado = this.sqlServer.ExecutarConsulta(comando, CommandType.Text);

                foreach (DataRow registro in tabelaResultado.Rows)
                {

                    entradaEstoque = new EntradaEstoque();
                    entradaEstoque.Fornecedor = new Fornecedor();

                    entradaEstoque.codigoEntradaEstoque = Convert.ToInt32(registro[0]);
                    entradaEstoque.notaFiscal = (registro[1].ToString());
                    entradaEstoque.Fornecedor.codigoFornecedor = Convert.ToInt32(registro[2]);
                    entradaEstoque.Fornecedor.nomeFantasiaFornecedor = registro[3].ToString();
                    entradaEstoque.quantidadeProdutosNota = Convert.ToInt32(registro[4]);
                    entradaEstoque.valorTotalNota = Convert.ToDouble(registro[5]);
                    entradaEstoque.dataEntrada = Convert.ToDateTime(registro[6]);
                    entradaEstoque.estatusEntrada = (registro[7].ToString());

                    entradaEstoques.Add(entradaEstoque);
                }

                return entradaEstoques;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar o Entrada de Estoque por NF. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Buscar Entrada de estoque por Data
        public EntradaEstoqueLista BuscarEntradaEstoquePorData(DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                DataTable tabelaResultado;
                EntradaEstoque entradaEstoque;
                EntradaEstoqueLista entradaEstoques = new EntradaEstoqueLista();

                this.sqlServer.LimparParametros();

                this.sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@dataInicial", dataInicial));
                this.sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@dataFinal", dataFinal));


                string comando = "exec uspBuscarEntradaEstoquePorData @dataInicial, @dataFinal";

                tabelaResultado = this.sqlServer.ExecutarConsulta(comando, CommandType.Text);

                foreach (DataRow registro in tabelaResultado.Rows)
                {

                    entradaEstoque = new EntradaEstoque();
                    entradaEstoque.Fornecedor = new Fornecedor();

                    entradaEstoque.codigoEntradaEstoque = Convert.ToInt32(registro[0]);
                    entradaEstoque.notaFiscal = (registro[1].ToString());
                    entradaEstoque.Fornecedor.codigoFornecedor = Convert.ToInt32(registro[2]);
                    entradaEstoque.Fornecedor.nomeFantasiaFornecedor = registro[3].ToString();
                    entradaEstoque.quantidadeProdutosNota = Convert.ToInt32(registro[4]);
                    entradaEstoque.valorTotalNota = Convert.ToDouble(registro[5]);
                    entradaEstoque.dataEntrada = Convert.ToDateTime(registro[6]);
                    entradaEstoque.estatusEntrada = (registro[7].ToString());

                    entradaEstoques.Add(entradaEstoque);
                }

                return entradaEstoques;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar o Entrada de Estoque por Data. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Buscar Entrada de estoque por Fornecedor
        public EntradaEstoqueLista BuscarEntradaEstoquePorFornecedor(int codigoFornecedor)
        {
            try
            {
                DataTable tabelaResultado;
                EntradaEstoque entradaEstoque;
                EntradaEstoqueLista entradaEstoques = new EntradaEstoqueLista();

                this.sqlServer.LimparParametros();

                this.sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@fornecedor", codigoFornecedor));

                string comando = "exec uspBuscarEntradaEstoquePorFornecedor @fornecedor";

                tabelaResultado = this.sqlServer.ExecutarConsulta(comando, CommandType.Text);

                foreach (DataRow registro in tabelaResultado.Rows)
                {

                    entradaEstoque = new EntradaEstoque();
                    entradaEstoque.Fornecedor = new Fornecedor();

                    entradaEstoque.codigoEntradaEstoque = Convert.ToInt32(registro[0]);
                    entradaEstoque.notaFiscal = (registro[1].ToString());
                    entradaEstoque.Fornecedor.codigoFornecedor = Convert.ToInt32(registro[2]);
                    entradaEstoque.Fornecedor.nomeFantasiaFornecedor = registro[3].ToString();
                    entradaEstoque.quantidadeProdutosNota = Convert.ToInt32(registro[4]);
                    entradaEstoque.valorTotalNota = Convert.ToDouble(registro[5]);
                    entradaEstoque.dataEntrada = Convert.ToDateTime(registro[6]);
                    entradaEstoque.estatusEntrada = (registro[7].ToString());

                    entradaEstoques.Add(entradaEstoque);
                }

                return entradaEstoques;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar o Entrada de Estoque por Fornecedor. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Buscar Entrada de estoque por Fornecedor
        public EntradaEstoqueLista BuscarEntradaEstoquePorProduto(int codigoProdutoCor, int codigoTamanho)
        {
            try
            {
                DataTable tabelaResultado;
                EntradaEstoque entradaEstoque;
                EntradaEstoqueLista entradaEstoques = new EntradaEstoqueLista();

                this.sqlServer.LimparParametros();

                this.sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoProdutoCor", codigoProdutoCor));
                this.sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigoTamanho", codigoTamanho));

                string comando = "exec uspBuscarEntradaEstoquePorProduto @codigoProdutoCor, @codigoTamanho";

                tabelaResultado = this.sqlServer.ExecutarConsulta(comando, CommandType.Text);

                foreach (DataRow registro in tabelaResultado.Rows)
                {

                    entradaEstoque = new EntradaEstoque();
                    entradaEstoque.Fornecedor = new Fornecedor();

                    entradaEstoque.codigoEntradaEstoque = Convert.ToInt32(registro[0]);
                    entradaEstoque.notaFiscal = (registro[1].ToString());
                    entradaEstoque.Fornecedor.codigoFornecedor = Convert.ToInt32(registro[2]);
                    entradaEstoque.Fornecedor.nomeFantasiaFornecedor = registro[3].ToString();
                    entradaEstoque.quantidadeProdutosNota = Convert.ToInt32(registro[4]);
                    entradaEstoque.valorTotalNota = Convert.ToDouble(registro[5]);
                    entradaEstoque.dataEntrada = Convert.ToDateTime(registro[6]);
                    entradaEstoque.estatusEntrada = (registro[7].ToString());

                    entradaEstoques.Add(entradaEstoque);
                }

                return entradaEstoques;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar o Entrada de Estoque por Produto. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Buscar Entrada de estoque todas
        public EntradaEstoqueLista BuscarEntradaEstoqueTodas()
        {
            try
            {
                DataTable tabelaResultado;
                EntradaEstoque entradaEstoque;
                EntradaEstoqueLista entradaEstoques = new EntradaEstoqueLista();

                this.sqlServer.LimparParametros();

                string comando = "exec uspBuscarEntradaEstoqueTodas";

                tabelaResultado = this.sqlServer.ExecutarConsulta(comando, CommandType.Text);

                foreach (DataRow registro in tabelaResultado.Rows)
                {

                    entradaEstoque = new EntradaEstoque();
                    entradaEstoque.Fornecedor = new Fornecedor();

                    entradaEstoque.codigoEntradaEstoque = Convert.ToInt32(registro[0]);
                    entradaEstoque.notaFiscal = (registro[1].ToString());
                    entradaEstoque.Fornecedor.codigoFornecedor = Convert.ToInt32(registro[2]);
                    entradaEstoque.Fornecedor.nomeFantasiaFornecedor = registro[3].ToString();
                    entradaEstoque.quantidadeProdutosNota = Convert.ToInt32(registro[4]);
                    entradaEstoque.valorTotalNota = Convert.ToDouble(registro[5]);
                    entradaEstoque.dataEntrada = Convert.ToDateTime(registro[6]);
                    entradaEstoque.estatusEntrada = (registro[7].ToString());

                    entradaEstoques.Add(entradaEstoque);
                }

                return entradaEstoques;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar o Entrada de Estoque. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //------------------------Validação
        public EntradaEstoque ValidaEntradaEstoque(string notaFiscal, int codigoFornecedor)
        {
            try
            {
                DataTable tabelaRetorno = new DataTable();
                EntradaEstoque entrada;

                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@notaFiscal", notaFiscal));
                sqlServer.AdicionarParametro(new SqlParameter("@codigoFornecedor", codigoFornecedor));

                string comando = "exec uspValidaEntradaEstoque @notaFiscal, @codigoFornecedor";

                tabelaRetorno = this.sqlServer.ExecutarConsulta(comando, CommandType.Text);

                if (tabelaRetorno.Rows.Count > 0)
                {
                    DataRow registro = tabelaRetorno.Rows[0];//Consulta só retorna uma objeto

                    entrada = new EntradaEstoque();
                    entrada.Fornecedor = new Fornecedor();

                    entrada.codigoEntradaEstoque = Convert.ToInt32(registro[0]);
                    entrada.notaFiscal = (registro[1].ToString());
                    entrada.Fornecedor.codigoFornecedor = Convert.ToInt32(registro[2]);
                    entrada.Fornecedor.nomeFantasiaFornecedor = (registro[3].ToString());
                    entrada.quantidadeProdutosNota = Convert.ToInt32(registro[4]);
                    entrada.valorTotalNota = Convert.ToDouble(registro[5]);
                    entrada.dataEntrada = Convert.ToDateTime(registro[6]);

                    return entrada;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível validar a Referencia do Produto. [Negócios]. Motivo: " + ex.Message);
            }
        }
    }
}
