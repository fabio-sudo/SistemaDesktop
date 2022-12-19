using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ObjetoTransferencia
{
   public class Tamanho
    {
        public int codigoTamanho { get; set; }
        public string nometamanho { get; set; }
        public int ordemtamanho { get; set; }
    }

   public class TamanhoLista : List<Tamanho> { }
}
