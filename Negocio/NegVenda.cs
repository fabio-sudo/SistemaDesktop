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
   public class NegVenda
    {
        private ConexaoSqlServer sqlServer = new ConexaoSqlServer();

        //metodo para realizar o cadastro da venda
        public Boolean CadastrarVenda(Venda Venda)
        {
            try
            {
                sqlServer.LimparParametros();
                
                sqlServer.AdicionarParametro(new SqlParameter("@codigoCliente", Venda.Cliente.codigoCliente));
                sqlServer.AdicionarParametro(new SqlParameter("@codigoFuncionario", Venda.Funcionario.codigoFuncionario));
                sqlServer.AdicionarParametro(new SqlParameter("@formaPagamento", Venda.formaPagamento.codigoFormaPagamento));
                sqlServer.AdicionarParametro(new SqlParameter("@quantidadeVenda", Venda.quantidadeVenda));
                sqlServer.AdicionarParametro(new SqlParameter("@jurosVenda", Venda.jurosVenda));
                sqlServer.AdicionarParametro(new SqlParameter("@descontoVenda", Venda.descontoVenda));
                sqlServer.AdicionarParametro(new SqlParameter("@totalVenda", Venda.totalVenda));

                string comandoSql = "exec uspCadastrarVenda @codigoCliente, @codigoFuncionario, @formaPagamento, @quantidadeVenda, @jurosVenda, @descontoVenda, @totalVenda";

                sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível cadastrar o Venda. [Negócios]. Motivo: " + ex.Message);
            }
        }

        //Excluir Venda 
        public Boolean ExcluirVenda(int codigoVenda)
        {
            try
            {
                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new System.Data.SqlClient.SqlParameter("@codigo", codigoVenda));

                string comando = "exec uspExcluirVenda @codigo";

                object Resposta = sqlServer.ExecutarScalar(comando, System.Data.CommandType.Text);
                if (Convert.ToInt16(Resposta) == 1)
                {
                    return false;//Existem itens na venda ItemCrediario ou ItemVenda
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


        //------------------------------Consulta

        //Buscar e retornar ultimo registro do sqlServer
        public int BuscarUltimoRegistroVenda()
        {
            try
            {
                string comando = " exec uspVendaUltimoRegistro ";

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
       
        //Buscar Vendas por nome de Cliente
        public VendaLista BuscarVendaPorNomeCliente(string nomeCliente) 
        {
            try{

            this.sqlServer.LimparParametros();
            this.sqlServer.AdicionarParametro(new SqlParameter("@nomeCliente", nomeCliente));

            string comandoSql = "exec uspBuscarVendaPorNomeCliente @nomeCliente";

            DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

            VendaLista vendaLista = new VendaLista();

            foreach (DataRow registro in tabelaRetorno.Rows)
            {
                Venda venda = new Venda();
                venda.Cliente = new Cliente();
                venda.Funcionario = new Funcionario();

                //Venda
                venda.codigoVenda = Convert.ToInt32(registro[0]);
                //venda.tipoVenda = (registro[1].ToString());
               // venda.formaPagamento = (registro[2].ToString());
                //Cliente
                venda.Cliente.codigoCliente =Convert.ToInt32(registro[3]);
                venda.Cliente.nomeCliente = registro[4].ToString();
                venda.Cliente.sobrenomeCliente = registro[5].ToString();
                venda.Cliente.cpfCliente = registro[6].ToString();
                venda.Cliente.celularCliente = registro[7].ToString();
                 //Funcionario
                venda.Funcionario.codigoFuncionario = Convert.ToInt32(registro[8]);
                venda.Funcionario.nomeFuncionario = registro[9].ToString();
                venda.Funcionario.sobrenomeFuncionario = registro[10].ToString();
                //Dados Venda
                venda.quantidadeVenda = Convert.ToInt32(registro[11]);
               // venda.totalVenda = Convert.ToDouble(registro[12]);
                venda.descontoVenda = Convert.ToDouble(registro[13]);
                //venda.estatusVenda = (registro[14].ToString());
                venda.dataVenda = Convert.ToDateTime(registro[15]);

                vendaLista.Add(venda);

            }

            return vendaLista;
        }
            catch (Exception ex){
            throw new Exception("Erro ao buscar Vendas por nome do Cliente "+ex.Message);
        }
       }

        //Buscar Vendas por codigo de Cliente
        public VendaLista BuscarVendaPorCodigoCliente(int codigoCliente)
        {
            try
            {

                this.sqlServer.LimparParametros();
                this.sqlServer.AdicionarParametro(new SqlParameter("@codigoCliente", codigoCliente));

                string comandoSql = "exec uspBuscarVendaPorCodigoCliente @codigoCliente";

                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

                VendaLista vendaLista = new VendaLista();

                foreach (DataRow registro in tabelaRetorno.Rows)
                {
                    Venda venda = new Venda();
                    venda.Cliente = new Cliente();
                    venda.Funcionario = new Funcionario();

                    //Venda
                    venda.codigoVenda = Convert.ToInt32(registro[0]);
                    //venda.tipoVenda = (registro[1].ToString());
                    //venda.formaPagamento = (registro[2].ToString());
                    //Cliente
                    venda.Cliente.codigoCliente = Convert.ToInt32(registro[3]);
                    venda.Cliente.nomeCliente = registro[4].ToString();
                    venda.Cliente.sobrenomeCliente = registro[5].ToString();
                    venda.Cliente.cpfCliente = registro[6].ToString();
                    venda.Cliente.celularCliente = registro[7].ToString();
                    //Funcionario
                    venda.Funcionario.codigoFuncionario = Convert.ToInt32(registro[8]);
                    venda.Funcionario.nomeFuncionario = registro[9].ToString();
                    venda.Funcionario.sobrenomeFuncionario = registro[10].ToString();
                    //Dados Venda
                    venda.quantidadeVenda = Convert.ToInt32(registro[11]);
                    //venda.totalVenda = Convert.ToDouble(registro[12]);
                    venda.descontoVenda = Convert.ToDouble(registro[13]);
                    //venda.estatusVenda = (registro[14].ToString());
                    venda.dataVenda = Convert.ToDateTime(registro[15]);

                    vendaLista.Add(venda);

                }

                return vendaLista;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar Vendas por nome do Cliente " + ex.Message);
            }
        }

        //Buscar Vendas por codigo de Cliente
        public Venda BuscarVendaPorCodigo(int codigoVenda)
        {
            try
            {

                this.sqlServer.LimparParametros();
                this.sqlServer.AdicionarParametro(new SqlParameter("@codigoVenda", codigoVenda));

                string comandoSql = "exec uspBuscarVendaPorCodigo @codigoVenda";

                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

                Venda venda = new Venda();
                venda.Cliente = new Cliente();
                venda.Funcionario = new Funcionario();
                venda.formaPagamento = new FormaPagamento();

                if (tabelaRetorno.Rows.Count > 0)
                {

                    DataRow registro = tabelaRetorno.Rows[0];

                    //Venda
                    venda.codigoVenda = Convert.ToInt32(registro[0]);
                    //Forma Pagamento
                    venda.formaPagamento.codigoFormaPagamento = Convert.ToInt32(registro[1]);
                    venda.formaPagamento.formaPagamento = registro[2].ToString();
                    venda.tipoPagamento = registro[3].ToString();
                    //Valore
                    venda.quantidadeVenda = Convert.ToInt32(registro[4]);
                    venda.totalVenda = Convert.ToDouble(registro[5]);//Valor da Venda com soma de todos os custos
                    venda.liquidoVenda = Convert.ToDouble(registro[6]);//Valor realmente recebido da venda
                    venda.jurosVenda = Convert.ToDouble(registro[7]);
                    venda.descontoVenda = Convert.ToDouble(registro[8]);
                    //Cliente
                    venda.Cliente.codigoCliente = Convert.ToInt32(registro[9]);
                    venda.Cliente.nomeCliente = registro[10].ToString();
                    venda.Cliente.sobrenomeCliente = registro[11].ToString();
                    venda.Cliente.cpfCliente = registro[12].ToString();
                    venda.Cliente.celularCliente = registro[13].ToString();
                    //Funcionario
                    venda.Funcionario.codigoFuncionario = Convert.ToInt32(registro[14]);
                    venda.Funcionario.nomeFuncionario = registro[15].ToString();
                    venda.Funcionario.sobrenomeFuncionario = registro[16].ToString();
                    //Dados Venda
                    venda.dataVenda = Convert.ToDateTime(registro[17]);
                    venda.estatusVenda = registro[18].ToString();


                    return venda;
                }
                else
                {

                    return venda = null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar Vendas por codigo da Venda " + ex.Message);
            }
        }

       //-----------------------------ItemVendaTemp Venda Pendente Temporária

        //Buscar Vendas pendentes Form VendaPendente
        public VendaLista BuscarItemVendaTempPendente()
        {
            try
            {
                string comandoSql = "exec uspBuscarItemVendaTempPendente";

                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

                VendaLista vendaLista = new VendaLista();

                foreach (DataRow registro in tabelaRetorno.Rows)
                {
                    Venda venda = new Venda();

                    //Venda
                    venda.codigoVenda = Convert.ToInt32(registro[0]);       
                    venda.quantidadeVenda = Convert.ToInt32(registro[1]);
                    venda.totalVenda = Convert.ToDouble(registro[2]);
                    venda.dataVenda = Convert.ToDateTime(registro[3]);

                    vendaLista.Add(venda);

                }

                return vendaLista;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar Vendas Pendentes " + ex.Message);
            }
        }

        //Buscar Vendas pendentes
        public VendaLista BuscarItemVendaTempPendentePorData(DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                sqlServer.LimparParametros();
                this.sqlServer.AdicionarParametro(new SqlParameter("@DataInicial", dataInicial));
                this.sqlServer.AdicionarParametro(new SqlParameter("@DataFinal", dataFinal));

                string comandoSql = "exec uspBuscarItemVendaTempPendentePorData @dataInicial, @dataFinal";

                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

                VendaLista vendaLista = new VendaLista();

                foreach (DataRow registro in tabelaRetorno.Rows)
                {
                    Venda venda = new Venda();

                    //Venda
                    venda.codigoVenda = Convert.ToInt32(registro[0]);
                    venda.quantidadeVenda = Convert.ToInt32(registro[1]);
                    venda.totalVenda = Convert.ToDouble(registro[2]);
                    venda.dataVenda = Convert.ToDateTime(registro[3]);

                    vendaLista.Add(venda);

                }

                return vendaLista;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar Vendas Pendentes " + ex.Message);
            }
        }

        //Buscar e retornar ultimo registro do sqlServer
        public int BuscarItemVendaTempUltimoRegistro()
        {
            try
            {
                string comando = " exec uspItemVendaTempUltimoRegistro ";

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

       //--------------------------------Cancelamento

        //Buscar Vendas por codigo de Cliente
        public VendaLista BuscarCancelamento(string varAVista, string varCrediario, string varCrediarioPago, string nomeCliente, string sobrenomeCliente,
            string nomeFuncionario, string formaPagamento, DateTime dataInicial, DateTime dataFinal)
        {
            try
            {

                this.sqlServer.LimparParametros();

                this.sqlServer.AdicionarParametro(new SqlParameter("@AVista", varAVista));
                this.sqlServer.AdicionarParametro(new SqlParameter("@Crediario", varCrediario));
                this.sqlServer.AdicionarParametro(new SqlParameter("@CrediarioPago", varCrediarioPago));
                this.sqlServer.AdicionarParametro(new SqlParameter("@nomeCliente", nomeCliente));
                this.sqlServer.AdicionarParametro(new SqlParameter("@sobrenomeCliente", sobrenomeCliente));
                this.sqlServer.AdicionarParametro(new SqlParameter("@nomeFuncionario", nomeFuncionario));
                this.sqlServer.AdicionarParametro(new SqlParameter("@formaPagamento", formaPagamento));
                this.sqlServer.AdicionarParametro(new SqlParameter("@dataInicialVenda", dataInicial));
                this.sqlServer.AdicionarParametro(new SqlParameter("@dataFinalVenda", dataFinal));

                string comandoSql = "exec uspBuscarCancelamento @AVista, @Crediario, @CrediarioPago, @nomeCliente, @sobrenomeCliente, @nomeFuncionario, @formaPagamento, @dataInicialVenda, @dataFinalVenda";

                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

                VendaLista vendaLista = new VendaLista();
                Venda venda;

                foreach (DataRow registro in tabelaRetorno.Rows)
                {
                    venda = new Venda();
                    venda.Cliente = new Cliente();
                    venda.Funcionario = new Funcionario();
                    venda.formaPagamento = new FormaPagamento();

                    //Venda
                    venda.codigoVenda = Convert.ToInt32(registro[0]);
                    //Forma Pagamento
                    venda.formaPagamento.codigoFormaPagamento = Convert.ToInt32(registro[1]);
                    venda.formaPagamento.formaPagamento = registro[2].ToString();
                    venda.tipoPagamento = registro[3].ToString();
                    //Valore
                    venda.quantidadeVenda = Convert.ToInt32(registro[4]);
                    venda.totalVenda = Convert.ToDouble(registro[5]);//Valor da Venda com soma de todos os custos
                    venda.liquidoVenda = Convert.ToDouble(registro[6]);//Valor realmente recebido da venda
                    venda.jurosVenda = Convert.ToDouble(registro[7]);
                    venda.descontoVenda = Convert.ToDouble(registro[8]);
                    //Cliente
                    venda.Cliente.codigoCliente = Convert.ToInt32(registro[9]);
                    venda.Cliente.nomeCliente = registro[10].ToString();
                    venda.Cliente.sobrenomeCliente = registro[11].ToString();
                    venda.Cliente.cpfCliente = registro[12].ToString();
                    venda.Cliente.celularCliente = registro[13].ToString();
                    //Funcionario
                    venda.Funcionario.codigoFuncionario = Convert.ToInt32(registro[14]);
                    venda.Funcionario.nomeFuncionario = registro[15].ToString();
                    venda.Funcionario.sobrenomeFuncionario = registro[16].ToString();
                    //Dados Venda
                    venda.dataVenda = Convert.ToDateTime(registro[17]);
                    venda.estatusVenda = registro[18].ToString();

                    vendaLista.Add(venda);

                }

                return vendaLista;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar Vendas para cancelamento! " + ex.Message);
            }
        }

        //Busca data inicial da Venda para filtrar no cancelamento
        public DateTime BuscarDataVendaCancelamento() { 
          try
            {

                DataTable tabelaResultado;
                DateTime dataInicial;

                string comando = " exec uspBuscarDataCancelamento ";
                tabelaResultado = this.sqlServer.ExecutarConsulta(comando, CommandType.Text);

                if (tabelaResultado.Rows.Count > 0)
                {
                    DataRow registro = tabelaResultado.Rows[0];

                    dataInicial = Convert.ToDateTime(registro[0]);
                    return dataInicial;
                }
                else
                    return DateTime.Now;

            }
          catch (Exception ex)
          {
              //caso não houver nenhum registro retorna 1 para o primeiro cadastro
              return DateTime.Now;
              throw new Exception("Erro na camada de negócios - Retorno. " + ex.Message);

          }

        }

    }
}
