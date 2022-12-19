using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoTransferencia
{
   public class ItemCrediarioParcial
    {
        public int CodigoParcial { get; set; }
        public ItemCrediario ItemCrediario { get; set; }
        public Cliente Cliente { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public ProdutoCor ProdutoCor { get; set; }
        public Tamanho Tamanho { get; set; }
        public int parcelaParcial { get; set; }
        public double valorParcialBruto { get; set; }//Valor da Parcial com Taxas e Desconto
        public double valorPagoParcial { get; set; }//Valor que realmente foi pago na Parcial
        public double jurosParcial { get; set; }
        public double descontoParcial { get; set; }
        public string estatusParcial { get; set; }
        public DateTime dataParcial { get; set; }
    }

   public class ItemCrediarioParcialLista : List<ItemCrediarioParcial> { }
}
