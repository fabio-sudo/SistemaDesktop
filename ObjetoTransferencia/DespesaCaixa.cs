using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
   public class DespesaCaixa
    {
      public int codigoDespesa { get; set; }
      public Caixa caixaDespesa { get; set; }
      public Funcionario funcionario { get; set; }
      public FormaPagamento formaPagamento { get; set; }
      public string descricaoDespesa { get; set; }
      public double valorDespesa { get; set; }
      public DateTime dataDespesa { get; set; }
      public string statusDespesa { get; set; }
   }

   public class ListaDespesas : List<DespesaCaixa> { }

   //Lista Genética
   public class DespesaPagamento
   {
       public DateTime Data { get; set; }
       public int FormaPagamento { get; set; }
       public double valorDespesaResto { get; set; }

       public DespesaPagamento(DateTime data, int formaPagamento, double valor)
       {
           Data = data;
           FormaPagamento = formaPagamento;
           valorDespesaResto = valor;
       }
   }


}
