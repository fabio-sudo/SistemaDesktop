using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoTransferencia
{
    public class Cor
    {
        public int codigoCor { get; set; }
        public string nomeCor { get; set; }
        public int ordemCor { get; set; }
    }

    public class CorLista : List<Cor> { }
}
