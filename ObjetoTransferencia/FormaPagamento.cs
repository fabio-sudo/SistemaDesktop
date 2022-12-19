using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
   public class FormaPagamento
    {
       public int codigoFormaPagamento { get; set; }
       public string formaPagamento { get; set; }
       public double taxaFormaPagamento { get; set; }

    }

   public class ListaFormaPagamento : List<FormaPagamento> { }

}
