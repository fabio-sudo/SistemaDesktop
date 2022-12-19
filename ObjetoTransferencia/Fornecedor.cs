using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoTransferencia
{
   public class Fornecedor
    {
        public int codigoFornecedor { get; set; }
        public string razaoSocialFornecedor { get; set; }
        public string nomeFantasiaFornecedor { get; set; }
        public string cnpjFornecedor { get; set; }
        public string inscricaoEstadualFornecedor { get; set; }
        public string enderecoFornecedor { get; set; }
        public string bairroFornecedor { get; set; }
        public int numeroFornecedor { get; set; }
        public string cidadeFornecedor { get; set; }
        public string estadoFornecedor { get; set; }
        public string cepFornecedor { get; set; }
        public string telefoneFornecedor { get; set; }
        public string celularFornecedor { get; set; }
        public string emailFornecedor { get; set; }
    }

   public class FornecedorLista : List<Fornecedor> { }
}
