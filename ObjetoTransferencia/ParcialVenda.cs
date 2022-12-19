using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
   public  class ParcialVenda

    {
        public int CodigoParcial { get; set; }
        public Venda Venda { get; set; }
        public FormaPagamento formaPagamentoVenda { get; set; }
        public double valorParcialVenda { get; set; }
        public double descontoParcialVenda { get; set; }
        public double jurosParcialVenda { get; set; }
        public double acrescimoTaxa { get; set; }
        public double acrescimoDesconto { get; set; }
    }

   public class ParcialVendaLista : List<ParcialVenda> { }

   public class ParcialVendaListaSangria : List<ParcialVenda> { }
}
