using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoTransferencia
{
   public class Crediario
    {
        public int codigoCrediario { get; set; }
        public Cliente Cliente { get; set; }
        public int quantidadeCrediario { get; set; }
        public double contaCrediario { get; set; }//TotalConta Cliente
        public double valorRecebidoCrediario { get; set; }
        public DateTime dataCrediario { get; set; }
        public string estatusCrediario { get; set; } 
   }

   public class CrediarioLista : List<Crediario> { }
}
