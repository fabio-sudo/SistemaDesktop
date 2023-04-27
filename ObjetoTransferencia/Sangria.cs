using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoTransferencia
{
   public class Sangria
    {
        public int codigoSangria { set; get; }
        public double valorSangria { set; get; }
        public Caixa caixaSangria { get; set; }
        public Funcionario funcionarioSangria { set; get; }
        public FormaPagamento pagamentoSangria { set; get; }
        public DateTime dataSangria  { set; get; }
        public string estatusSangria { set; get; }//Para fechamento de caixa
        public int ordemSangra { set; get; }

       //------------------Olhar se tem necessidade
        public double retiradaSangria { set; get; }
        public double cancelamentoSangra { set; get; }
        public double descontoItem { get; set; }
        public double JurosItem { get; set; }
        public double despesaSangria { get; set; }
        public double estornoSangria { get; set; }
    }

   //Lista Genética
   public class SangriaPagamento
   {
       public DateTime Data { get; set; }
       public int FormaPagamento { get; set; }
       public double valorSangriaResto { get; set; }

       public SangriaPagamento(DateTime data, int formaPagamento, double valor)
       {
           Data = data;
           FormaPagamento = formaPagamento;
           valorSangriaResto = valor;
       }
   }




   public class SangriaLista : List<Sangria> { }

   public class SangriaListaCancelamento : List<Sangria> { }

   public class SangriaListaAlterada : List<Sangria> { }
}
