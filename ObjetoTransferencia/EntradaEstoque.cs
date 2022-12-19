using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoTransferencia
{
  public class EntradaEstoque
    {
        public int codigoEntradaEstoque { get; set; }
        public string notaFiscal { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public DateTime dataEntrada { get; set; }
        public string estatusEntrada { get; set; }
        //Valores para preenchimento
        public int quantidadeProdutosNota { get; set; }
        public double valorTotalNota { get; set; }
    }

  public class EntradaEstoqueLista : List<EntradaEstoque> { }
}
