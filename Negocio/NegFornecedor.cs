using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AcessoDados;
using ObjetoTransferencia;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class NegFornecedor
    {

        ConexaoSqlServer sqlserver = new ConexaoSqlServer();

        //Metodo para cadastrar Fornecedor
        public Boolean CadastrarFornecedor(Fornecedor fornecedor)
        {
            try
            {

                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@razaosocial", fornecedor.razaoSocialFornecedor));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@nomefantasia", fornecedor.nomeFantasiaFornecedor));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@cnpj", fornecedor.cnpjFornecedor));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@inscricaoestadual", fornecedor.inscricaoEstadualFornecedor));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@endereco", fornecedor.enderecoFornecedor));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@bairro", fornecedor.bairroFornecedor));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@numero", fornecedor.numeroFornecedor));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@cidade", fornecedor.cidadeFornecedor));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@estado", fornecedor.estadoFornecedor));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@cep", fornecedor.cepFornecedor));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@telefone", fornecedor.telefoneFornecedor));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@celular", fornecedor.celularFornecedor));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@email", fornecedor.emailFornecedor));


                string comando = " exec uspCadastrarFornecedor " +
                    "@razaosocial, @nomefantasia, @cnpj, @inscricaoestadual, @endereco, @bairro, @numero, @cidade, @estado, @cep, @telefone, @celular, @email";

                sqlserver.ExecutarScalar(comando, System.Data.CommandType.Text);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Erro na camada de negócios - Cadastro. " + ex.Message);
            }
        }

        //Metodo para atualizar fornecedor
        public Boolean AtualizarFornecedor(Fornecedor fornecedor)
        {
            try
            {
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigo", fornecedor.codigoFornecedor));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@razaosocial", fornecedor.razaoSocialFornecedor));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@nomefantasia", fornecedor.nomeFantasiaFornecedor));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@cnpj", fornecedor.cnpjFornecedor));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@inscricaoestadual", fornecedor.inscricaoEstadualFornecedor));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@endereco", fornecedor.enderecoFornecedor));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@bairro", fornecedor.bairroFornecedor));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@numero", fornecedor.numeroFornecedor));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@cidade", fornecedor.cidadeFornecedor));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@estado", fornecedor.estadoFornecedor));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@cep", fornecedor.cepFornecedor));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@telefone", fornecedor.telefoneFornecedor));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@celular", fornecedor.celularFornecedor));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@email", fornecedor.emailFornecedor));


                string comando = "exec uspAlterarFornecedor " +
                    "@codigo,@razaosocial, @nomefantasia, @cnpj, @inscricaoestadual, @endereco, @bairro, @numero, @cidade, @estado, @cep, @telefone, @celular, @email";


                sqlserver.ExecutarScalar(comando, System.Data.CommandType.Text);

                return true;

            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível atualizar os dados do fornecedor. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Metodo excluir fornecedor
        public Boolean ExcluirFornecedor(Fornecedor fornecedor)
        {
            try
            {
                sqlserver.LimparParametros();

                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigo", fornecedor.codigoFornecedor));

                string comandoSql = "exec uspExcluirFornecedor @codigo";

                object Resposta = sqlserver.ExecutarScalar(comandoSql, System.Data.CommandType.Text);

                if (Convert.ToInt16(Resposta) == 1)
                {
                    return false;//erro ao cadastrar fornecedor o mesmo está vinculado com Esntrada de estoque
                }
                if (Convert.ToInt16(Resposta) == 2)
                {
                    return false;//erro ao cadastrar fornecedor o mesmo está vinculado com Produto Cadastrado
                }
                else
                    return true;

            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível excluir os dados do Fornecedor. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //----------------------------Consultas
        //Buscando Fornecedor por nome
        public FornecedorLista BuscarFornecedorPorNome(string nomeABuscar)
        {
            try
            {
                DataTable tabelaResultado;
                Fornecedor fornecedor;
                FornecedorLista fornecedores = new FornecedorLista();

                this.sqlserver.LimparParametros();
                this.sqlserver.AdicionarParametro(new SqlParameter("@nome", nomeABuscar));

                string comando = "exec uspBuscarFornecedorPorNome @nome";

                tabelaResultado = this.sqlserver.ExecutarConsulta(comando, CommandType.Text);

                if (tabelaResultado.Rows.Count == 0)
                {
                    //  throw new Exception("Não foram encontrados registros.");
                }

                foreach (DataRow registro in tabelaResultado.Rows)
                {
                    fornecedor = new Fornecedor();


                    fornecedor.codigoFornecedor = Convert.ToInt32(registro[0]);
                    fornecedor.razaoSocialFornecedor = registro[1].ToString();
                    fornecedor.nomeFantasiaFornecedor = registro[2].ToString();
                    fornecedor.cnpjFornecedor = registro[3].ToString();
                    fornecedor.inscricaoEstadualFornecedor = registro[4].ToString();
                    fornecedor.enderecoFornecedor = registro[5].ToString();
                    fornecedor.bairroFornecedor = registro[6].ToString();
                    fornecedor.numeroFornecedor = Convert.ToInt32(registro[7]);
                    fornecedor.cidadeFornecedor = registro[8].ToString();
                    fornecedor.estadoFornecedor = registro[9].ToString();
                    fornecedor.cepFornecedor = registro[10].ToString();
                    fornecedor.telefoneFornecedor = registro[11].ToString();
                    fornecedor.celularFornecedor = registro[12].ToString();
                    fornecedor.emailFornecedor = registro[13].ToString();


                    fornecedores.Add(fornecedor);
                }

                return fornecedores;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar o fornecedor pelo nome. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Buscando Fornecedor por nome
        public Fornecedor BuscarFornecedorPorCodigo(int codigoABuscar)
        {
            try
            {
                DataTable tabelaResultado;

                this.sqlserver.LimparParametros();
                this.sqlserver.AdicionarParametro(new SqlParameter("@codigo", codigoABuscar));

                string comando = "exec uspBuscarFornecedorPorCodigo @codigo";

                tabelaResultado = this.sqlserver.ExecutarConsulta(comando, CommandType.Text);
                
                if (tabelaResultado.Rows.Count > 0)
                {
                Fornecedor fornecedor = new Fornecedor();
                DataRow registro = tabelaResultado.Rows[0];

                    fornecedor.codigoFornecedor = Convert.ToInt32(registro[0]);
                    fornecedor.razaoSocialFornecedor = registro[1].ToString();
                    fornecedor.nomeFantasiaFornecedor = registro[2].ToString();
                    fornecedor.cnpjFornecedor = registro[3].ToString();
                    fornecedor.inscricaoEstadualFornecedor = registro[4].ToString();
                    fornecedor.enderecoFornecedor = registro[5].ToString();
                    fornecedor.bairroFornecedor = registro[6].ToString();
                    fornecedor.numeroFornecedor = Convert.ToInt32(registro[7]);
                    fornecedor.cidadeFornecedor = registro[8].ToString();
                    fornecedor.estadoFornecedor = registro[9].ToString();
                    fornecedor.cepFornecedor = registro[10].ToString();
                    fornecedor.telefoneFornecedor = registro[11].ToString();
                    fornecedor.celularFornecedor = registro[12].ToString();
                    fornecedor.emailFornecedor = registro[13].ToString();
                
                return fornecedor;
                    }
                else
                    return null;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar o fornecedor pelo nome. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //realiza a validação se ja a o produto cadastrado de acordo com a referencia
        public Fornecedor ValidarNovoCadastroCnpj(String Cnpj)
        {
            try
            {
                DataTable tabelaRetorno;
                Fornecedor fornecedor;

                this.sqlserver.LimparParametros();
                this.sqlserver.AdicionarParametro(new SqlParameter("@Cnpj", Cnpj));

                string comando = "exec uspValidaCadastroFornecedorCnpj @Cnpj";

                tabelaRetorno = this.sqlserver.ExecutarConsulta(comando, CommandType.Text);
                if (tabelaRetorno.Rows.Count > 0)
                {
                    DataRow registro = tabelaRetorno.Rows[0];//Consulta só retorna uma objeto

                    fornecedor = new Fornecedor();

                    fornecedor.codigoFornecedor = Convert.ToInt32(registro[0]);
                    fornecedor.nomeFantasiaFornecedor = (registro[1].ToString());
                    fornecedor.cnpjFornecedor = (registro[2].ToString());

                    return fornecedor;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível validar o fornecedor. [Negócios]. Motivo: " + ex.Message);
            }
        }
    }
}
