using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ObjetoTransferencia
{
    public class Cliente
    {

        public int codigoCliente { get; set; }
        public string nomeCliente { get; set; }
        public string sobrenomeCliente { get; set; }
        public DateTime dataNascimentoCliente { get; set; }
        public string sexoCliente { get; set; }
        public string rgCliente { get; set; }
        public string cpfCliente { get; set; }
        public string enderecoCliente { get; set; }
        public string bairroCliente { get; set; }
        public int  numeroCliente { get; set; }
        public string cidadeCliente { get; set; }
        public string estadoCliente { get; set; }
        public string cepCliente { get; set; }
        public string telefoneCliente { get; set; }
        public string celularCliente { get; set; }
        public string emailCliente { get; set; }

    }

    public class ClienteLista : List<Cliente> { }
}
