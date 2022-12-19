using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoTransferencia
{
 public class ItemCrediario
    {
        public int codigoItemCrediario { get; set; }
        public Crediario Crediario { get; set; }
        public Venda Venda { get; set; }
        public FormaPagamento formaPagamento { get; set; }
        public ProdutoCor ProdutoCor { get; set; }
        public Tamanho Tamanho { get; set; }//Tamanho de acorodo com grade do produto cadastrado
        public int quantidadeItemCrediario { get; set; }
        public double valorItemCrediario { get; set; }
        public double parcialItemCrediario { get; set; }
        public double recebidoItemCrediario { get; set; }
        public double descontoItemCrediario { get; set; }//Pagamentos em Cartão -> Taxa
        public double jurosItemCrediario { get; set; }
        public string estatusItem { get; set; }
        public DateTime dataItemCrediario { get; set; }
        public DateTime dataVencimentoItemCrediario { get; set; }
        public string codigoBarrasItem { get; set; }//Fica alocada temporariamente para colocar na tabel Estoque
       
    }

 public class ItemCrediarioLista : List<ItemCrediario> { }
}
