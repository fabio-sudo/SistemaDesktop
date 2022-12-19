using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoTransferencia
{
   public class ItemVenda
    {
        public int codigoItemVenda { get; set; }
        public Venda Venda { get; set; }
        public ProdutoCor ProdutoCor { get; set; }
        public Tamanho Tamanho { get; set; }
        public int quantidadeVenda { get; set; }
        public double precoCusto { get; set; }
        public double precoVenda { get; set; }
        public double descontoItem { get; set; }
        public double JurosItem { get; set; }
        public string codigoBarrasItem { get; set; }//Fica alocada temporariamente para colocar na tabel Estoque
        public DateTime dataItemVenda { get; set; }
        public String estatusItem { get; set; }
        //Data e vinculada no Banco

    }
   public class ItemVendaLista : List<ItemVenda> { }
}
