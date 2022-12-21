using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoTransferencia
{
   public class ItemCaixa
    {
     public int codigoItem { get; set; }
     public Venda Venda { get; set; }
     public string tipoVenda { get; set; }
     public FormaPagamento formaPagamento { get; set; }
     public ProdutoCor ProdutoCor { get; set; }
     public Tamanho tamanho { get; set; }
     public int quantidadeItem {get;set;}
     public double custoItem { get; set; }
     public double vendaItem { get; set; }
     public double totalItem { get; set; }
     public double recebidoItem { get; set; }
     public double descontoItem { get; set; }
     public double jurosItem { get; set; }
     public Cliente cliente { get; set; }
     public Funcionario funcionario { get; set; }
     public Fornecedor fornecedor { get; set; }
     public DateTime dataItem { get; set; }
     public string estatusItem { get; set; }
   }
       public class ItemCaixaLista : List<ItemCaixa> { }

}
