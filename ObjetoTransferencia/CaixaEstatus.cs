using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoTransferencia
{
   public class CaixaEstatus
    {

            public double totalCaixa { get; set; }
            public double descontoCaixa { get; set; }
            public string estatusCaixa { get; set; }
            public DateTime dataCaixa { get; set; }

        }
        public class ListCaixaEstatus : List<CaixaEstatus> { }
    }
