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
    public class NegCliente
    {

        ConexaoSqlServer sqlserver = new ConexaoSqlServer();
        
        //--------------------------Métodos 

        //Cadastro Cliente
        public Boolean CadastrarCliente(Cliente cliente)
        {
            try
            {
                sqlserver.LimparParametros();
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@nome", cliente.nomeCliente));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@sobrenome", cliente.sobrenomeCliente));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@dataNascimento", cliente.dataNascimentoCliente));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@sexo", cliente.sexoCliente));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@rg", cliente.rgCliente));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@cpf", cliente.cpfCliente));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@endereco", cliente.enderecoCliente));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@bairro", cliente.bairroCliente));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@numero", cliente.numeroCliente));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@cidade", cliente.cidadeCliente));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@estado", cliente.estadoCliente));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@cep", cliente.cepCliente));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@telefone", cliente.telefoneCliente));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@celular", cliente.celularCliente));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@email", cliente.emailCliente));


                string comando = "exec uspCadastrarCliente " +
                    "@nome, @sobrenome, @dataNascimento, @sexo, @rg, @cpf, @endereco, @bairro, @numero, @cidade, @estado, " +
                    "@cep, @telefone, @celular, @email";

                object Resposta = sqlserver.ExecutarScalar(comando, System.Data.CommandType.Text);
                if (Convert.ToInt16(Resposta) == 1)
                {
                    return false;//Já existe o cliente cadastrado
                }
                else
                    return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Erro na camada de negócios - Cadastro Cliente. " + ex.Message);
            }

        }

        //Metodo para Alterar cliente
        public Boolean AtualizarCliente(Cliente cliente)
        {
            try
            {
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigo", cliente.codigoCliente));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@nome", cliente.nomeCliente));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@sobrenome", cliente.sobrenomeCliente));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@dataNascimento", cliente.dataNascimentoCliente));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@sexo", cliente.sexoCliente));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@rg", cliente.rgCliente));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@cpf", cliente.cpfCliente));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@endereco", cliente.enderecoCliente));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@bairro", cliente.bairroCliente));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@numero", cliente.numeroCliente));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@cidade", cliente.cidadeCliente));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@estado", cliente.estadoCliente));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@cep", cliente.cepCliente));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@telefone", cliente.telefoneCliente));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@celular", cliente.celularCliente));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@email", cliente.emailCliente));

                string comando = "exec uspAlterarCliente @codigo, @nome, @sobrenome, @dataNascimento, @sexo, @rg, @cpf, @endereco, @bairro, @numero, @cidade, " +
                    "@estado, @cep, @telefone, @celular, @email";

               sqlserver.ExecutarScalar(comando, System.Data.CommandType.Text);

                    return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Erro na camada de negócios - Alteração Cliente. " + ex.Message);
            }
        }

        //Excluir Cliente
        public Boolean ExcluirCliente(Cliente cliente) {
            try {

                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigo", cliente.codigoCliente));
           
                string comando = "exec uspExcluirCliente @codigo";

                object Resposta = sqlserver.ExecutarScalar(comando, System.Data.CommandType.Text);
                if (Convert.ToInt16(Resposta) == 1)
                {
                    return false;//Cliente está vinculado com histórico de vendas
                }
                else
                    return true;
            }

            catch (Exception ex)
             {
              return false;
              throw new Exception("Erro na camada de negócios = Excluir Clienete. " + ex.Message);
             } 


        }

        //--------------------------Consultas
        public ClienteLista BuscarClientePorNome(string nomeCliente) {
            try
            {
                DataTable tabelaResultado;//Recebe dados table SQL
                Cliente cliente;//
                ClienteLista clienteLista = new ClienteLista();

                this.sqlserver.LimparParametros();
                this.sqlserver.AdicionarParametro(new SqlParameter("@nome", nomeCliente));

                string comando = "exec uspBuscarClientePorNome @nome";

                tabelaResultado = this.sqlserver.ExecutarConsulta(comando, CommandType.Text);

                if (tabelaResultado.Rows.Count == 0)
                {
                  //  throw new Exception("Não foram encontrados registros.");
                }

                foreach (DataRow registro in tabelaResultado.Rows)
                {
                    cliente = new Cliente();//Cria novo cliente no loop

                    cliente.codigoCliente = Convert.ToInt32(registro[0]);
                    cliente.nomeCliente = registro[1].ToString();
                    cliente.sobrenomeCliente = registro[2].ToString();
                    cliente.dataNascimentoCliente = Convert.ToDateTime(registro[3]);
                    cliente.sexoCliente = registro[4].ToString();
                    cliente.rgCliente = registro[5].ToString();
                    cliente.cpfCliente = registro[6].ToString();
                    cliente.enderecoCliente = registro[7].ToString();
                    cliente.bairroCliente = registro[8].ToString();
                    cliente.numeroCliente = Convert.ToInt32(registro[9]);
                    cliente.cidadeCliente = registro[10].ToString();
                    cliente.estadoCliente = registro[11].ToString();
                    cliente.cepCliente = registro[12].ToString();
                    cliente.telefoneCliente = registro[13].ToString();
                    cliente.celularCliente = registro[14].ToString();
                    cliente.emailCliente = registro[16].ToString();

                    clienteLista.Add(cliente);
                }

                return clienteLista;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar o cliente pelo nome. [Negócios]. Motivo: " + ex.Message);
            }
        
        }

        //Buscando Funcioanario por codigo
        public Cliente BuscarClientePorCodigo(int codigoABuscar)
        {
            try
            {
                DataTable tabelaResultado;

                this.sqlserver.LimparParametros();
                this.sqlserver.AdicionarParametro(new SqlParameter("@codigo", codigoABuscar));

                string comando = "exec uspBuscarClientePorCodigo @codigo";

                tabelaResultado = this.sqlserver.ExecutarConsulta(comando, CommandType.Text);

                if (tabelaResultado.Rows.Count > 0)
                {
                    Cliente cliente = new Cliente();
                    DataRow registro = tabelaResultado.Rows[0];

                    cliente.codigoCliente = Convert.ToInt32(registro[0]);
                    cliente.nomeCliente = registro[1].ToString();
                    cliente.sobrenomeCliente = registro[2].ToString();
                    cliente.dataNascimentoCliente = Convert.ToDateTime(registro[3]);
                    cliente.sexoCliente = registro[4].ToString();
                    cliente.rgCliente = registro[5].ToString();
                    cliente.cpfCliente = registro[6].ToString();
                    cliente.enderecoCliente = registro[7].ToString();
                    cliente.bairroCliente = registro[8].ToString();
                    cliente.numeroCliente = Convert.ToInt32(registro[9]);
                    cliente.cidadeCliente = registro[10].ToString();
                    cliente.estadoCliente = registro[11].ToString();
                    cliente.cepCliente = registro[12].ToString();
                    cliente.telefoneCliente = registro[13].ToString();
                    cliente.celularCliente = registro[14].ToString();
                    cliente.emailCliente = registro[16].ToString();

                    return cliente;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar o cliente pelo código. [Negócios]. Motivo: " + ex.Message);
            }
        }

        public Cliente BuscarClientePorCpf(string cpfBuscar)
        {
            try
            {
                DataTable tabelaResultado;

                this.sqlserver.LimparParametros();
                this.sqlserver.AdicionarParametro(new SqlParameter("@cpf", cpfBuscar));

                string comando = "exec uspBuscarClientePorCpf @cpf";

                tabelaResultado = this.sqlserver.ExecutarConsulta(comando, CommandType.Text);

                if (tabelaResultado.Rows.Count > 0)
                {
                    Cliente cliente = new Cliente();
                    DataRow registro = tabelaResultado.Rows[0];

                    cliente.codigoCliente = Convert.ToInt32(registro[0]);
                    cliente.nomeCliente = registro[1].ToString();
                    cliente.sobrenomeCliente = registro[2].ToString();
                    cliente.dataNascimentoCliente = Convert.ToDateTime(registro[3]);
                    cliente.sexoCliente = registro[4].ToString();
                    cliente.rgCliente = registro[5].ToString();
                    cliente.cpfCliente = registro[6].ToString();
                    cliente.enderecoCliente = registro[7].ToString();
                    cliente.bairroCliente = registro[8].ToString();
                    cliente.numeroCliente = Convert.ToInt32(registro[9]);
                    cliente.cidadeCliente = registro[10].ToString();
                    cliente.estadoCliente = registro[11].ToString();
                    cliente.cepCliente = registro[12].ToString();
                    cliente.telefoneCliente = registro[13].ToString();
                    cliente.celularCliente = registro[14].ToString();
                    cliente.emailCliente = registro[16].ToString();

                    return cliente;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar o cliente pelo cpf. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //realiza a validação se ja a o produto cadastrado de acordo com a referencia
        public Cliente ValidarNovoCadastroCpf(String Cpf)
        {
            try
            {
                DataTable tabelaRetorno;
                Cliente cliente;

                this.sqlserver.LimparParametros();
                this.sqlserver.AdicionarParametro(new SqlParameter("@Cpf", Cpf));

                string comando = "exec uspValidaCadastroCliente @Cpf";

                tabelaRetorno = this.sqlserver.ExecutarConsulta(comando, CommandType.Text);
                if (tabelaRetorno.Rows.Count > 0)
                {
                    DataRow registro = tabelaRetorno.Rows[0];//Consulta só retorna uma objeto

                    cliente = new Cliente();

                    cliente.codigoCliente = Convert.ToInt32(registro[0]);
                    cliente.nomeCliente = (registro[1].ToString());
                    cliente.sobrenomeCliente = (registro[2].ToString());
                    cliente.cpfCliente = (registro[3].ToString());

                    return cliente;
                }else
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível validar o cliente. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //realiza a validação se ja a o produto cadastrado de acordo com a referencia
        public Cliente ValidarNovoCadastroRG(String Rg)
        {
            try
            {
                DataTable tabelaRetorno;
                Cliente cliente;

                this.sqlserver.LimparParametros();
                this.sqlserver.AdicionarParametro(new SqlParameter("@Rg", Rg));

                string comando = "exec uspValidaCadastroClienteRg @Rg";

                tabelaRetorno = this.sqlserver.ExecutarConsulta(comando, CommandType.Text);
                if (tabelaRetorno.Rows.Count > 0)
                {
                    DataRow registro = tabelaRetorno.Rows[0];//Consulta só retorna uma objeto

                    cliente = new Cliente();

                    cliente.codigoCliente = Convert.ToInt32(registro[0]);
                    cliente.nomeCliente = (registro[1].ToString());
                    cliente.sobrenomeCliente = (registro[2].ToString());
                    cliente.rgCliente = (registro[3].ToString());

                    return cliente;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível validar o cliente. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //--------------------------Cancelamento

        //Buscando Funcioanario por nomefazem parte de venda
        public ClienteLista BuscarCancelamentoClientePorNome(string AVista, string Crediario, string CrediarioPago, string nomeCliente,
            string nomeFuncionario, string formaPagamento, DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                DataTable tabelaResultado;
                Cliente cliente;
                ClienteLista clientes = new ClienteLista();

                this.sqlserver.LimparParametros();
                this.sqlserver.AdicionarParametro(new SqlParameter("@AVista", AVista));
                this.sqlserver.AdicionarParametro(new SqlParameter("@Crediario", Crediario));
                this.sqlserver.AdicionarParametro(new SqlParameter("@CrediarioPago", CrediarioPago));
                this.sqlserver.AdicionarParametro(new SqlParameter("@nomeCliente", nomeCliente));
                this.sqlserver.AdicionarParametro(new SqlParameter("@nomeFuncionario", nomeFuncionario));
                this.sqlserver.AdicionarParametro(new SqlParameter("@formaPagamento", formaPagamento));
                this.sqlserver.AdicionarParametro(new SqlParameter("@dataInicial", dataInicial));
                this.sqlserver.AdicionarParametro(new SqlParameter("@dataFinal", dataFinal));

                string comando = "exec uspBuscarClienteCancelamento @AVista, @Crediario, @CrediarioPago, @nomeCliente, @nomeFuncionario, @formaPagamento, @dataInicial, @dataFinal";

                tabelaResultado = this.sqlserver.ExecutarConsulta(comando, CommandType.Text);

                foreach (DataRow registro in tabelaResultado.Rows)
                {
                    cliente = new Cliente();

                    cliente.codigoCliente = Convert.ToInt32(registro[0]);
                    cliente.nomeCliente = registro[1].ToString();
                    cliente.sobrenomeCliente = registro[2].ToString();
                    cliente.cpfCliente = registro[3].ToString();
                    cliente.celularCliente = registro[4].ToString();

                    clientes.Add(cliente);
                }

                return clientes;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar o cliente pelo nome. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Buscando Funcioanario por codigo fazem parte de vendas
        public Cliente BuscarCancelamentoClientePorCodigo(string AVista, string Crediario, string CrediarioPago, int codigoCliente,
            string nomeFuncionario, string formaPagamento, DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                DataTable tabelaResultado;

                this.sqlserver.LimparParametros();
                this.sqlserver.AdicionarParametro(new SqlParameter("@AVista", AVista));
                this.sqlserver.AdicionarParametro(new SqlParameter("@Crediario", Crediario));
                this.sqlserver.AdicionarParametro(new SqlParameter("@CrediarioPago", CrediarioPago));
                this.sqlserver.AdicionarParametro(new SqlParameter("@codigoCliente", codigoCliente));
                this.sqlserver.AdicionarParametro(new SqlParameter("@nomeFuncionario", nomeFuncionario));
                this.sqlserver.AdicionarParametro(new SqlParameter("@formaPagamento", formaPagamento));
                this.sqlserver.AdicionarParametro(new SqlParameter("@dataInicial", dataInicial));
                this.sqlserver.AdicionarParametro(new SqlParameter("@dataFinal", dataFinal));

                string comando = "exec uspBuscarClienteCancelamentoPorCodigo @AVista, @Crediario, @CrediarioPago, @codigoCliente, @nomeFuncionario, @formaPagamento, @dataInicial, @dataFinal";

     
                tabelaResultado = this.sqlserver.ExecutarConsulta(comando, CommandType.Text);

                if (tabelaResultado.Rows.Count > 0)
                {
                    Cliente cliente = new Cliente();
                    DataRow registro = tabelaResultado.Rows[0];

                    cliente.codigoCliente = Convert.ToInt32(registro[0]);
                    cliente.nomeCliente = registro[1].ToString();
                    cliente.sobrenomeCliente = registro[2].ToString();
                    cliente.cpfCliente = registro[3].ToString();
                    cliente.celularCliente = registro[4].ToString();

                    return cliente;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar o cliente pelo codigo. [Negócios]. Motivo: " + ex.Message);
            }
        }

    }       
}
