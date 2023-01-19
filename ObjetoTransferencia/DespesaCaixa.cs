using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
   public class DespesaCaixa
    {
       int codigoDespesa { get; set; }
       Caixa caixaDespesa { get; set; }
       string descricaoDespesa { get; set; }
       double valorDespesa { get; set; }
   }

    public class ListaDespesas:List<Caixa>{}
}
