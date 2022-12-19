using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoTransferencia
{
  public class Genero
    {
        public int codigoGenero { set; get; }
        public string nomeGenero { get; set; }
    }

  public class GeneroLista : List<Genero> { }
}
