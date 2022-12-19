using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoTransferencia
{
   //Valores Caixa
   public class Caixa
    {
       public string tipoVenda { get; set; }
       public double recebidoCaixa { get; set; }
       public double valorCaixa { get; set; }
       public double jurosCaixa { get; set; }
       public double descontoCaixa { get; set; }
       public FormaPagamento formaPagamento { get; set; }
       public DateTime dataCaixa { get; set; }
       public string estatusCaixa { get; set; }
   }
   public class CaixaLista : List<Caixa> { }
  
}
