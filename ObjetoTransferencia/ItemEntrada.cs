using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class ItemEntrada
    {
        public int codigoItemEntrada { get; set; }
        public EntradaEstoque EntradaEstoque { get; set; }
        public ProdutoCor ProdutoCor { get; set; }
        public int quantidadeItem { get; set; }
        public Double precoCustoItem { get; set; }
        public Double precoVendaItem { get; set; }
        public Tamanho Tamanho { get; set; }
        public string codigoBarrasItem { get; set; }//Fica alocada temporariamente para colocar na tabel Estoque
        //Data e vinculada no Banco
    }

    public class ItemEntradaLista : List<ItemEntrada> { }
}
