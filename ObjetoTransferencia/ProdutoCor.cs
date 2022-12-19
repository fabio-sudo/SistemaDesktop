using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoTransferencia
{
  public class ProdutoCor
    {
      public int codigoProdutoCor { get; set; }
      public Cor Cor { get; set; }
      public Produto Produto { get; set; }
      public String ImagemProduto { get; set; }
      //dataCadastro é realizada no banco automaticamente
    }

  public class ProdutoCorLista : List<ProdutoCor> { }

}
