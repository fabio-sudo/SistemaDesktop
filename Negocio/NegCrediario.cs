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
   public class NegCrediario
    {
       ConexaoSqlServer sqlServer = new ConexaoSqlServer();

       //---------------------Crediario 

        //metodo para buscar crediario por nome de cliente
        public CrediarioLista BuscarCrediarioPorNome(string nome, string cpf, string status)
        {
            try
            {

                this.sqlServer.LimparParametros();
                this.sqlServer.AdicionarParametro(new SqlParameter("@nomeCliente", nome));
                this.sqlServer.AdicionarParametro(new SqlParameter("@cpfCliente", cpf));
                this.sqlServer.AdicionarParametro(new SqlParameter("@estatusCliente", status));

                string comandoSql = "exec uspBuscarCrediarioPorNome @nomeCliente, @cpfCliente, @estatusCliente";

                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

                CrediarioLista listaCrediario = new CrediarioLista();
                Crediario crediario;

                foreach (DataRow registro in tabelaRetorno.Rows)
                {       
                    crediario = new Crediario();
                    crediario.Cliente = new Cliente();


                    crediario.codigoCrediario = Convert.ToInt32(registro[0]);//CódigoCrediario = CódigoCliente
                    crediario.Cliente.nomeCliente = registro[1].ToString();
                    crediario.Cliente.sobrenomeCliente = registro[2].ToString();
                    crediario.Cliente.cpfCliente = registro[3].ToString();
                    crediario.Cliente.celularCliente = registro[4].ToString();
                    crediario.Cliente.enderecoCliente = registro[5].ToString();
                    crediario.Cliente.bairroCliente = registro[6].ToString();
                    crediario.Cliente.numeroCliente = Convert.ToInt32(registro[7]);
                    crediario.Cliente.cidadeCliente = registro[8].ToString();
                    crediario.Cliente.cepCliente = registro[9].ToString();
                    crediario.quantidadeCrediario = Convert.ToInt32(registro[10]);
                    crediario.contaCrediario = Convert.ToDouble(registro[11]);
                    crediario.dataCrediario = Convert.ToDateTime(registro[12]);
                    crediario.estatusCrediario = (registro[13].ToString());
                    //Estatus Ativo o Bloqueado

                    listaCrediario.Add(crediario);
                }

                return listaCrediario;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao buscar Crediario por Nome " + ex.Message);
            }
        }

        //metodo para buscar crediario por codigo de cliente
        public Crediario BuscarCrediarioPorCodigo(int codigoCliente)
        {
            try
            {

                this.sqlServer.LimparParametros();
                this.sqlServer.AdicionarParametro(new SqlParameter("@codigoCliente", codigoCliente));


                string comandoSql = "exec uspBuscarCrediarioPorCodigoCliente @codigoCliente";

                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

                Crediario crediario;

                if (tabelaRetorno.Rows.Count > 0)
                {
                    DataRow registro = tabelaRetorno.Rows[0];//Consulta só retorna uma objeto

                    crediario = new Crediario();
                    crediario.Cliente = new Cliente();


                    crediario.codigoCrediario = Convert.ToInt32(registro[0]);//CódigoCrediario = CódigoCliente
                    crediario.Cliente.nomeCliente = registro[1].ToString();
                    crediario.Cliente.sobrenomeCliente = registro[2].ToString();
                    crediario.Cliente.cpfCliente = registro[3].ToString();
                    crediario.Cliente.celularCliente = registro[4].ToString();
                    crediario.Cliente.enderecoCliente = registro[5].ToString();
                    crediario.Cliente.bairroCliente = registro[6].ToString();
                    crediario.Cliente.numeroCliente = Convert.ToInt32(registro[7]);
                    crediario.Cliente.cidadeCliente = registro[8].ToString();
                    crediario.Cliente.cepCliente = registro[9].ToString();
                    crediario.quantidadeCrediario = Convert.ToInt32(registro[10]);
                    crediario.contaCrediario = Convert.ToDouble(registro[11]);
                    crediario.dataCrediario = Convert.ToDateTime(registro[12]);
                    crediario.estatusCrediario = (registro[13].ToString());
                    //Estatus Ativo o Bloqueado

                    return crediario;
                }
                else return null;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao buscar Crediario por Nome " + ex.Message);
            }
        }

        //Realiza busca por Data do creadiario
        public CrediarioLista BuscarCrediarioPorData(DateTime dataInicial, DateTime dataFinal)
        {
            try
            {

                this.sqlServer.LimparParametros();
                this.sqlServer.AdicionarParametro(new SqlParameter("@dataInicial", dataInicial));
                this.sqlServer.AdicionarParametro(new SqlParameter("@dataFinal", dataFinal));

                string comandoSql = "exec uspBuscarCrediarioPorData @dataInicial, @dataFinal";

                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

                CrediarioLista listaCrediario = new CrediarioLista();
                Crediario crediario;

                foreach (DataRow registro in tabelaRetorno.Rows)
                {
                    crediario = new Crediario();
                    crediario.Cliente = new Cliente();


                    crediario.codigoCrediario = Convert.ToInt32(registro[0]);//CódigoCrediario = CódigoCliente
                    crediario.Cliente.nomeCliente = registro[1].ToString();
                    crediario.Cliente.sobrenomeCliente = registro[2].ToString();
                    crediario.Cliente.cpfCliente = registro[3].ToString();
                    crediario.Cliente.celularCliente = registro[4].ToString();
                    crediario.Cliente.enderecoCliente = registro[5].ToString();
                    crediario.Cliente.bairroCliente = registro[6].ToString();
                    crediario.Cliente.numeroCliente = Convert.ToInt32(registro[7]);
                    crediario.Cliente.cidadeCliente = registro[8].ToString();
                    crediario.Cliente.cepCliente = registro[9].ToString();
                    crediario.quantidadeCrediario = Convert.ToInt32(registro[10]);
                    crediario.contaCrediario = Convert.ToDouble(registro[11]);
                    crediario.dataCrediario = Convert.ToDateTime(registro[12]);
                    crediario.estatusCrediario = (registro[13].ToString());
                    //Estatus Ativo o Bloqueado

                    listaCrediario.Add(crediario);
                }

                return listaCrediario;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao buscar Crediario por Data " + ex.Message);
            }
        }

        //Realiza busca por Cpf do Cliente
        public CrediarioLista BuscarCrediarioPorCpf(string cpfCliente)
        {

            try
            {

                this.sqlServer.LimparParametros();
                this.sqlServer.AdicionarParametro(new SqlParameter("@cpf", cpfCliente));
                string comandoSql = "exec uspBuscarCrediarioPorCpf @cpf";

                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

                CrediarioLista listaCrediario = new CrediarioLista();
                Crediario crediario;

                foreach (DataRow registro in tabelaRetorno.Rows)
                {
                    crediario = new Crediario();
                    crediario.Cliente = new Cliente();


                    crediario.codigoCrediario = Convert.ToInt32(registro[0]);//CódigoCrediario = CódigoCliente
                    crediario.Cliente.nomeCliente = registro[1].ToString();
                    crediario.Cliente.sobrenomeCliente = registro[2].ToString();
                    crediario.Cliente.cpfCliente = registro[3].ToString();
                    crediario.Cliente.celularCliente = registro[4].ToString();
                    crediario.Cliente.enderecoCliente = registro[5].ToString();
                    crediario.Cliente.bairroCliente = registro[6].ToString();
                    crediario.Cliente.numeroCliente = Convert.ToInt32(registro[7]);
                    crediario.Cliente.cidadeCliente = registro[8].ToString();
                    crediario.Cliente.cepCliente = registro[9].ToString();
                    crediario.quantidadeCrediario = Convert.ToInt32(registro[10]);
                    crediario.contaCrediario = Convert.ToDouble(registro[11]);
                    crediario.dataCrediario = Convert.ToDateTime(registro[12]);

                    listaCrediario.Add(crediario);
                }

                return listaCrediario;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao buscar Crediario por CPF do Cliente "+ex.Message);
            }

        }

       
       //-------------------CrediarioPago

        //metodo para buscar crediario por nome de cliente
        public CrediarioLista BuscarCrediarioPagoPorNome(string nome, string cpf, string status)
        {
            try
            {

                this.sqlServer.LimparParametros();
                this.sqlServer.AdicionarParametro(new SqlParameter("@nomeCliente", nome));
                this.sqlServer.AdicionarParametro(new SqlParameter("@cpfCliente", cpf));
                this.sqlServer.AdicionarParametro(new SqlParameter("@estatusCliente", status));

                string comandoSql = "exec uspBuscarCrediarioPagoPorNome @nomeCliente, @cpfCliente, @estatusCliente";

                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

                CrediarioLista listaCrediario = new CrediarioLista();
                Crediario crediario;

                foreach (DataRow registro in tabelaRetorno.Rows)
                {
                    crediario = new Crediario();
                    crediario.Cliente = new Cliente();


                    crediario.codigoCrediario = Convert.ToInt32(registro[0]);//CódigoCrediario = CódigoCliente
                    crediario.Cliente.nomeCliente = registro[1].ToString();
                    crediario.Cliente.sobrenomeCliente = registro[2].ToString();
                    crediario.Cliente.cpfCliente = registro[3].ToString();
                    crediario.Cliente.celularCliente = registro[4].ToString();
                    crediario.Cliente.enderecoCliente = registro[5].ToString();
                    crediario.Cliente.bairroCliente = registro[6].ToString();
                    crediario.Cliente.numeroCliente = Convert.ToInt32(registro[7]);
                    crediario.Cliente.cidadeCliente = registro[8].ToString();
                    crediario.Cliente.cepCliente = registro[9].ToString();
                    crediario.quantidadeCrediario = Convert.ToInt32(registro[10]);
                    crediario.contaCrediario = Convert.ToDouble(registro[11]);
                    crediario.dataCrediario = Convert.ToDateTime(registro[12]);
                    crediario.estatusCrediario = (registro[13].ToString());
                    //Estatus Ativo o Bloqueado

                    listaCrediario.Add(crediario);
                }

                return listaCrediario;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao buscar Crediario por Nome " + ex.Message);
            }
        }

        //metodo para buscar crediario por codigo de cliente
        public Crediario BuscarCrediarioPagoPorCodigo(int codigoCliente)
        {
            try
            {

                this.sqlServer.LimparParametros();
                this.sqlServer.AdicionarParametro(new SqlParameter("@codigoCliente", codigoCliente));


                string comandoSql = "exec uspBuscarCrediarioPagoPorCodigoCliente @codigoCliente";

                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

                Crediario crediario;

                if (tabelaRetorno.Rows.Count > 0)
                {
                    DataRow registro = tabelaRetorno.Rows[0];//Consulta só retorna uma objeto

                    crediario = new Crediario();
                    crediario.Cliente = new Cliente();


                    crediario.codigoCrediario = Convert.ToInt32(registro[0]);//CódigoCrediario = CódigoCliente
                    crediario.Cliente.nomeCliente = registro[1].ToString();
                    crediario.Cliente.sobrenomeCliente = registro[2].ToString();
                    crediario.Cliente.cpfCliente = registro[3].ToString();
                    crediario.Cliente.celularCliente = registro[4].ToString();
                    crediario.Cliente.enderecoCliente = registro[5].ToString();
                    crediario.Cliente.bairroCliente = registro[6].ToString();
                    crediario.Cliente.numeroCliente = Convert.ToInt32(registro[7]);
                    crediario.Cliente.cidadeCliente = registro[8].ToString();
                    crediario.Cliente.cepCliente = registro[9].ToString();
                    crediario.quantidadeCrediario = Convert.ToInt32(registro[10]);
                    crediario.contaCrediario = Convert.ToDouble(registro[11]);
                    crediario.dataCrediario = Convert.ToDateTime(registro[12]);
                    crediario.estatusCrediario = (registro[13].ToString());
                    //Estatus Ativo o Bloqueado

                    return crediario;
                }
                else return null;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao buscar Crediario por Nome " + ex.Message);
            }
        }

        //Realiza busca por Data do creadiario
        public CrediarioLista BuscarCrediarioPagoPorData(DateTime dataInicial, DateTime dataFinal)
        {
            try
            {

                this.sqlServer.LimparParametros();
                this.sqlServer.AdicionarParametro(new SqlParameter("@dataInicial", dataInicial));
                this.sqlServer.AdicionarParametro(new SqlParameter("@dataFinal", dataFinal));

                string comandoSql = "exec uspBuscarCrediarioPagoPorData @dataInicial, @dataFinal";

                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

                CrediarioLista listaCrediario = new CrediarioLista();
                Crediario crediario;

                foreach (DataRow registro in tabelaRetorno.Rows)
                {
                    crediario = new Crediario();
                    crediario.Cliente = new Cliente();


                    crediario.codigoCrediario = Convert.ToInt32(registro[0]);//CódigoCrediario = CódigoCliente
                    crediario.Cliente.nomeCliente = registro[1].ToString();
                    crediario.Cliente.sobrenomeCliente = registro[2].ToString();
                    crediario.Cliente.cpfCliente = registro[3].ToString();
                    crediario.Cliente.celularCliente = registro[4].ToString();
                    crediario.Cliente.enderecoCliente = registro[5].ToString();
                    crediario.Cliente.bairroCliente = registro[6].ToString();
                    crediario.Cliente.numeroCliente = Convert.ToInt32(registro[7]);
                    crediario.Cliente.cidadeCliente = registro[8].ToString();
                    crediario.Cliente.cepCliente = registro[9].ToString();
                    crediario.quantidadeCrediario = Convert.ToInt32(registro[10]);
                    crediario.contaCrediario = Convert.ToDouble(registro[11]);
                    crediario.dataCrediario = Convert.ToDateTime(registro[12]);
                    crediario.estatusCrediario = (registro[13].ToString());
                    //Estatus Ativo o Bloqueado

                    listaCrediario.Add(crediario);
                }

                return listaCrediario;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao buscar Crediario por Data " + ex.Message);
            }
        }

        //Realiza busca por Cpf do Cliente
        public CrediarioLista BuscarCrediarioPagoPorCpf(string cpfCliente)
        {

            try
            {

                this.sqlServer.LimparParametros();
                this.sqlServer.AdicionarParametro(new SqlParameter("@cpf", cpfCliente));
                string comandoSql = "exec uspBuscarCrediarioPagoPorCpf @cpf";

                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

                CrediarioLista listaCrediario = new CrediarioLista();
                Crediario crediario;

                foreach (DataRow registro in tabelaRetorno.Rows)
                {
                    crediario = new Crediario();
                    crediario.Cliente = new Cliente();


                    crediario.codigoCrediario = Convert.ToInt32(registro[0]);//CódigoCrediario = CódigoCliente
                    crediario.Cliente.nomeCliente = registro[1].ToString();
                    crediario.Cliente.sobrenomeCliente = registro[2].ToString();
                    crediario.Cliente.cpfCliente = registro[3].ToString();
                    crediario.Cliente.celularCliente = registro[5].ToString();
                    crediario.Cliente.enderecoCliente = registro[5].ToString();
                    crediario.Cliente.bairroCliente = registro[6].ToString();
                    crediario.Cliente.numeroCliente = Convert.ToInt32(registro[7]);
                    crediario.Cliente.cidadeCliente = registro[8].ToString();
                    crediario.Cliente.cepCliente = registro[9].ToString();
                    crediario.quantidadeCrediario = Convert.ToInt32(registro[10]);
                    crediario.contaCrediario = Convert.ToDouble(registro[11]);
                    crediario.valorRecebidoCrediario = Convert.ToDouble(registro[12]);
                    crediario.dataCrediario = Convert.ToDateTime(registro[13]);

                    listaCrediario.Add(crediario);
                }

                return listaCrediario;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao buscar Crediario por CPF do Cliente " + ex.Message);
            }

        }


       //--------------------Médotodos de Bloqueio
      //metodo bloqueio e desbloqueuio "BLOQUEADO" ou "ATIVO"
        public Boolean BloqueioCrediario(int codigoCrediario,string estatusBloqueio)
        {
            try
            {

                sqlServer.LimparParametros();

                sqlServer.AdicionarParametro(new SqlParameter("@codigoCrediario", codigoCrediario));
                sqlServer.AdicionarParametro(new SqlParameter("@estatusCrediario", estatusBloqueio));

                string comandoSql = "exec uspAlterarCrediarioEstatus @codigoCrediario, @estatusCrediario";

                sqlServer.ExecutarScalar(comandoSql, System.Data.CommandType.Text);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível alterar os dados do Crediario. [Negócios]. Motivo: " + ex.Message);
            }
        }

       //Buscar se Crediario tem parcelas atrasadas caso encontre algum informa que a Items com atraso
        public Boolean BuscarCrediarioVencimento(int codigoCrediario)
        {
            try
            {

                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@codigoCrediario", codigoCrediario));

                string comandoSql = "exec uspBuscarVencimentoCrediario @codigoCrediario";
                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

                int Vencimento = 0;
                List<int>ListaVencimento = new List<int>();

                foreach (DataRow registro in tabelaRetorno.Rows)
                {
                    Vencimento = Convert.ToInt32(registro[0]);//CódigoCrediario = CódigoCliente
                    ListaVencimento.Add(Vencimento);
                  
                }

                if (ListaVencimento.Count > 0)
                {

                    return true;
                }
                else { return false; }
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível alterar os dados do Crediario. [Negócios]. Motivo: " + ex.Message);
            }
        }

       //Buscar se Crediario tem parcelas atrasadas caso encontre algum informa Crediarios Bloqueados
        public Boolean BuscarCrediarioBloqueado(int codigoCrediario)
        {
            try
            {

                sqlServer.LimparParametros();
                sqlServer.AdicionarParametro(new SqlParameter("@codigoCrediario", codigoCrediario));

                string comandoSql = "exec uspBuscarClienteBloqueadoCrediario @codigoCrediario";
                DataTable tabelaRetorno = this.sqlServer.ExecutarConsulta(comandoSql, CommandType.Text);

                int CrediarioBloqueado = 0;
                List<int>ListaCrediarioBloqueado = new List<int>();

                foreach (DataRow registro in tabelaRetorno.Rows)
                {
                    CrediarioBloqueado = Convert.ToInt32(registro[0]);//CódigoCrediario = CódigoCliente
                    ListaCrediarioBloqueado.Add(CrediarioBloqueado);
                  
                }

                if (ListaCrediarioBloqueado.Count > 0)
                {

                    return true;
                }
                else { return false; }
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Não foi possível alterar os dados do Crediario. [Negócios]. Motivo: " + ex.Message);
            }
        }
       

    }
}
