using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
   public class DespesaCaixa
    {
      public int codigoDespesa { get; set; }
      public Caixa caixaDespesa { get; set; }
      public FormaPagamento formaPagamento { get; set; }
      public string descricaoDespesa { get; set; }
      public double valorDespesa { get; set; }
   }

    public class ListaDespesas:List<Caixa>{}
}
