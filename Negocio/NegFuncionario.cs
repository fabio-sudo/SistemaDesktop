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
 public class NegFuncionario
    {
        ConexaoSqlServer sqlserver = new ConexaoSqlServer();

        //Metodo para Cadastrar Funcionario
        public Boolean CadastrarFuncionario(Funcionario funcionario)
        {
            try
            {
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@nome", funcionario.nomeFuncionario));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@sobrenome", funcionario.sobrenomeFuncionario));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@dataNascimento", funcionario.dataNascimentoFuncionario));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@sexo", funcionario.sexoFuncionario));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@rg", funcionario.rgFuncionario));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@cpf", funcionario.cpfFuncionario));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@ctps", funcionario.ctpsFuncionario));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@endereco", funcionario.enderecoFuncionario));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@bairro", funcionario.bairroFuncionario));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@numero", funcionario.numeroFuncionario));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@cidade", funcionario.cidadeFuncionario));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@estado", funcionario.estadoFuncionario));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@cep", funcionario.cepFuncionario));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@telefone", funcionario.telefoneFuncionario));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@celular", funcionario.celularFuncionario));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@salario", funcionario.salarioFuncionario));



                string comando = " exec uspCadastrarFuncionario " +
                    "@nome, @sobrenome, @dataNascimento, @sexo, @rg, @cpf, @ctps, @endereco, @bairro, @numero, @cidade, @estado, " +
                    "@cep, @telefone, @celular, @salario";

                object Resposta = sqlserver.ExecutarScalar(comando, System.Data.CommandType.Text);
                if (Convert.ToInt16(Resposta) == 1)
                {
                    return false;//Já existe funcionario cadastrado com CPF e RG compativeis
                }
                else
                    return true;

            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Erro na camada de negócios - Cadastro. " + ex.Message);
            }
        }

        //Metodo para Atualizar funcionario
        public Boolean AtualizarFuncionario(Funcionario funcionario)
        {
            try
            {

                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigo", funcionario.codigoFuncionario));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@nome", funcionario.nomeFuncionario));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@sobrenome", funcionario.sobrenomeFuncionario));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@dataNascimento", funcionario.dataNascimentoFuncionario));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@sexo", funcionario.sexoFuncionario));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@rg", funcionario.rgFuncionario));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@cpf", funcionario.cpfFuncionario));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@ctps", funcionario.ctpsFuncionario));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@endereco", funcionario.enderecoFuncionario));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@bairro", funcionario.bairroFuncionario));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@numero", funcionario.numeroFuncionario));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@cidade", funcionario.cidadeFuncionario));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@estado", funcionario.estadoFuncionario));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@cep", funcionario.cepFuncionario));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@telefone", funcionario.telefoneFuncionario));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@celular", funcionario.celularFuncionario));
                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@salario", funcionario.salarioFuncionario));



                string comando = "exec uspAlterarFuncionario @codigo, @nome, @sobrenome, @dataNascimento, @sexo, @rg, @cpf, @ctps, @endereco, @bairro, @numero, @cidade, " +
                    "@estado, @cep, @telefone, @celular, @salario";

                sqlserver.ExecutarScalar(comando, System.Data.CommandType.Text);

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível atualizar os dados do funcionario. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Metodo Excluir Funcionario
        public Boolean ExcluirFuncionario(Funcionario funcionario)
        {
            try
            {

                sqlserver.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigo", funcionario.codigoFuncionario));

                string comando = "exec uspExcluirFuncionario @codigo";

                object Resposta = sqlserver.ExecutarScalar(comando, System.Data.CommandType.Text);

                if (Convert.ToInt16(Resposta) == 1)
                {
                    return false;//Caso estiver vinculado a alguma venda
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

        //Buscando Funcioanario por nome
        public FuncionarioLista BuscarFuncionarioPorNome(string nomeABuscar)
        {
            try
            {
                DataTable tabelaResultado;
                Funcionario funcionario;
                FuncionarioLista funcionarios = new FuncionarioLista();

                this.sqlserver.LimparParametros();
                this.sqlserver.AdicionarParametro(new SqlParameter("@nome", nomeABuscar));

                string comando = "exec uspBuscarFuncionarioPorNome @nome";

                tabelaResultado = this.sqlserver.ExecutarConsulta(comando, CommandType.Text);

                foreach (DataRow registro in tabelaResultado.Rows)
                {
                    funcionario = new Funcionario();

                    funcionario.codigoFuncionario = Convert.ToInt32(registro[0]);
                    funcionario.nomeFuncionario = registro[1].ToString();
                    funcionario.sobrenomeFuncionario = registro[2].ToString();
                    funcionario.dataNascimentoFuncionario = Convert.ToDateTime(registro[3]);
                    funcionario.sexoFuncionario = registro[4].ToString();
                    funcionario.rgFuncionario = registro[5].ToString();
                    funcionario.cpfFuncionario = registro[6].ToString();
                    funcionario.ctpsFuncionario = registro[7].ToString();
                    funcionario.enderecoFuncionario = registro[8].ToString();
                    funcionario.bairroFuncionario = registro[9].ToString();
                    funcionario.numeroFuncionario = Convert.ToInt32(registro[10]);
                    funcionario.cidadeFuncionario = registro[11].ToString();
                    funcionario.estadoFuncionario = registro[12].ToString();
                    funcionario.cepFuncionario = registro[13].ToString();
                    funcionario.telefoneFuncionario = registro[14].ToString();
                    funcionario.celularFuncionario = registro[15].ToString();
                    funcionario.salarioFuncionario = Convert.ToDecimal(registro[16]);

                    funcionarios.Add(funcionario);
                }

                return funcionarios;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar o funcionario pelo nome. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Buscando Funcioanario por codigo
        public Funcionario BuscarFuncionarioPorCodigo(int codigoABuscar)
        {
            try
            {
                DataTable tabelaResultado;

                this.sqlserver.LimparParametros();
                this.sqlserver.AdicionarParametro(new SqlParameter("@codigo", codigoABuscar));

                string comando = "exec uspBuscarFuncionarioPorCodigo @codigo";

                tabelaResultado = this.sqlserver.ExecutarConsulta(comando, CommandType.Text);

                if (tabelaResultado.Rows.Count > 0)
                {
                    Funcionario funcionario = new Funcionario();
                    DataRow registro = tabelaResultado.Rows[0];

                    funcionario.codigoFuncionario = Convert.ToInt32(registro[0]);
                    funcionario.nomeFuncionario = registro[1].ToString();
                    funcionario.sobrenomeFuncionario = registro[2].ToString();
                    funcionario.dataNascimentoFuncionario = Convert.ToDateTime(registro[3]);
                    funcionario.sexoFuncionario = registro[4].ToString();
                    funcionario.rgFuncionario = registro[5].ToString();
                    funcionario.cpfFuncionario = registro[6].ToString();
                    funcionario.ctpsFuncionario = registro[7].ToString();
                    funcionario.enderecoFuncionario = registro[8].ToString();
                    funcionario.bairroFuncionario = registro[9].ToString();
                    funcionario.numeroFuncionario = Convert.ToInt32(registro[10]);
                    funcionario.cidadeFuncionario = registro[11].ToString();
                    funcionario.estadoFuncionario = registro[12].ToString();
                    funcionario.cepFuncionario = registro[13].ToString();
                    funcionario.telefoneFuncionario = registro[14].ToString();
                    funcionario.celularFuncionario = registro[15].ToString();
                    funcionario.salarioFuncionario = Convert.ToDecimal(registro[16]);

                    return funcionario;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar o funcionario pelo nome. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //realiza a validação se ja a o produto cadastrado de acordo com a referencia
        public Funcionario ValidarNovoCadastroCpf(String Cpf)
        {
            try
            {
                DataTable tabelaRetorno;
                Funcionario funcionario;

                this.sqlserver.LimparParametros();
                this.sqlserver.AdicionarParametro(new SqlParameter("@Cpf", Cpf));

                string comando = "exec uspValidaCadastroFuncionarioCpf @Cpf";

                tabelaRetorno = this.sqlserver.ExecutarConsulta(comando, CommandType.Text);
                if (tabelaRetorno.Rows.Count > 0)
                {
                    DataRow registro = tabelaRetorno.Rows[0];//Consulta só retorna uma objeto

                    funcionario = new Funcionario();

                    funcionario.codigoFuncionario = Convert.ToInt32(registro[0]);
                    funcionario.nomeFuncionario = (registro[1].ToString());
                    funcionario.sobrenomeFuncionario = (registro[2].ToString());
                    funcionario.cpfFuncionario = (registro[3].ToString());

                    return funcionario;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível validar o funcionario. [Negócios]. Motivo: " + ex.Message);
            }
        }


        //realiza a validação se ja a o produto cadastrado de acordo com a referencia
        public Funcionario ValidarNovoCadastroRG(String Rg)
        {
            try
            {
                DataTable tabelaRetorno;
                Funcionario funcionario;

                this.sqlserver.LimparParametros();
                this.sqlserver.AdicionarParametro(new SqlParameter("@Rg", Rg));

                string comando = "exec uspValidaCadastroFuncionarioRg @Rg";

                tabelaRetorno = this.sqlserver.ExecutarConsulta(comando, CommandType.Text);
                if (tabelaRetorno.Rows.Count > 0)
                {
                    DataRow registro = tabelaRetorno.Rows[0];//Consulta só retorna uma objeto

                    funcionario = new Funcionario();

                    funcionario.codigoFuncionario = Convert.ToInt32(registro[0]);
                    funcionario.nomeFuncionario = (registro[1].ToString());
                    funcionario.sobrenomeFuncionario = (registro[2].ToString());
                    funcionario.rgFuncionario = (registro[3].ToString());

                    return funcionario;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível validar o funcionário. [Negócios]. Motivo: " + ex.Message);
            }
        }

     //--------------------------Cancelamento

        //Buscando Funcioanario por nomefazem parte de venda
        public FuncionarioLista BuscarCancelamentoFuncionarioPorNome(string AVista, string Crediario, string CrediarioPago,
            string nomeCliente, string sobrenomeClinete,string nomeFuncionario, string formaPagamento, DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                DataTable tabelaResultado;
                Funcionario funcionario;
                FuncionarioLista funcionarios = new FuncionarioLista();

                this.sqlserver.LimparParametros();
                this.sqlserver.AdicionarParametro(new SqlParameter("@AVista", AVista));
                this.sqlserver.AdicionarParametro(new SqlParameter("@Crediario", Crediario));
                this.sqlserver.AdicionarParametro(new SqlParameter("@CrediarioPago", CrediarioPago));
                this.sqlserver.AdicionarParametro(new SqlParameter("@nomeCliente", nomeCliente));
                this.sqlserver.AdicionarParametro(new SqlParameter("@sobrenomeCliente", sobrenomeClinete));
                this.sqlserver.AdicionarParametro(new SqlParameter("@nomeFuncionario", nomeFuncionario));
                this.sqlserver.AdicionarParametro(new SqlParameter("@formaPagamento", formaPagamento));
                this.sqlserver.AdicionarParametro(new SqlParameter("@dataInicial", dataInicial));
                this.sqlserver.AdicionarParametro(new SqlParameter("@dataFinal", dataFinal));

                string comando = "exec uspBuscarFuncionarioCancelamento @AVista, @Crediario, @CrediarioPago, @nomeCliente, @sobrenomeCliente, @nomeFuncionario, @formaPagamento, @dataInicial, @dataFinal";

                tabelaResultado = this.sqlserver.ExecutarConsulta(comando, CommandType.Text);

                foreach (DataRow registro in tabelaResultado.Rows)
                {
                    funcionario = new Funcionario();

                    funcionario.codigoFuncionario = Convert.ToInt32(registro[0]);
                    funcionario.nomeFuncionario = registro[1].ToString();
                    funcionario.sobrenomeFuncionario = registro[2].ToString();
                    funcionario.cpfFuncionario = registro[3].ToString();


                    funcionarios.Add(funcionario);
                }

                return funcionarios;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar o funcionario pelo nome. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Buscando Funcioanario por codigo fazem parte de vendas
        public Funcionario BuscarCancelamentoFuncionarioPorCodigo(string AVista, string Crediario, string CrediarioPago,
            string nomeCliente, string sobrenomeClinete, int codigoFuncionario, string formaPagamento, DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                DataTable tabelaResultado;

                this.sqlserver.LimparParametros();
                this.sqlserver.AdicionarParametro(new SqlParameter("@AVista", AVista));
                this.sqlserver.AdicionarParametro(new SqlParameter("@Crediario", Crediario));
                this.sqlserver.AdicionarParametro(new SqlParameter("@CrediarioPago", CrediarioPago));
                this.sqlserver.AdicionarParametro(new SqlParameter("@nomeCliente", nomeCliente));
                this.sqlserver.AdicionarParametro(new SqlParameter("@sobrenomeCliente", sobrenomeClinete));
                this.sqlserver.AdicionarParametro(new SqlParameter("@codigoFuncionario", codigoFuncionario));
                this.sqlserver.AdicionarParametro(new SqlParameter("@formaPagamento", formaPagamento));
                this.sqlserver.AdicionarParametro(new SqlParameter("@dataInicial", dataInicial));
                this.sqlserver.AdicionarParametro(new SqlParameter("@dataFinal", dataFinal));

                string comando = "exec uspBuscarFuncionarioCancelamentoPorCodigo @AVista, @Crediario, @CrediarioPago, @nomeCliente, @sobrenomeCliente, @codigoFuncionario, @formaPagamento, @dataInicial, @dataFinal";

                tabelaResultado = this.sqlserver.ExecutarConsulta(comando, CommandType.Text);

                if (tabelaResultado.Rows.Count > 0)
                {
                    Funcionario funcionario = new Funcionario();
                    DataRow registro = tabelaResultado.Rows[0];

                    funcionario.codigoFuncionario = Convert.ToInt32(registro[0]);
                    funcionario.nomeFuncionario = registro[1].ToString();
                    funcionario.sobrenomeFuncionario = registro[2].ToString();
                    funcionario.cpfFuncionario = registro[3].ToString();

                    return funcionario;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar o funcionario pelo nome. [Negócios]. Motivo: " + ex.Message);
            }
        }

    }
}
