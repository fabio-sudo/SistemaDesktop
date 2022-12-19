using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
   public class Estoque
    {
        public int codigoEstoque { get; set; }
        public ProdutoCor ProdutoCor { get; set; }
        public Tamanho tamanhoProduto { get; set; }
        public string codigoBarrasProduto { get; set; }//Código de Barras vem do item entrada e é atualizado
        public int quantidadeEstoque { get; set; }
        public double precoCustoEstoque { get; set; }
        public double precoVendaEstoque { get; set; }
        public DateTime dataEstoque { get; set; } 
        

    }

   public class EstoqueLista : List<Estoque> { }
}
