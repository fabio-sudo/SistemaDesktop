using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoTransferencia
{
   public class Venda
    {
        public int codigoVenda { get; set; }
        public Cliente Cliente { get; set; }
        public Funcionario Funcionario { get; set; }
        public FormaPagamento formaPagamento { get; set; }//Avista,Crediario,Cartão 2x,Cartão 3x
        public string tipoPagamento { get; set; } //Crediario CrediarioPago  Parcial  ItemVenda(AVista)
        public int quantidadeVenda { get; set; }
        public double descontoVenda { get; set; }
        public double jurosVenda { get; set; }
        public double totalVenda { get; set; }
        public double liquidoVenda { get; set; }
        public DateTime dataVenda { get; set; }//Pego no Próprio banco de dados
        public string estatusVenda { get; set; }
    }

   public class VendaLista : List<Venda> { }
}
