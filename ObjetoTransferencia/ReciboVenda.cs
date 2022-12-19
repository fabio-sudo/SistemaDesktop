using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoTransferencia
{
  public class ReciboVenda
    {
       
        //Dados Item
        public ItemVenda ItemVendaTemp { get; set; }//Descrição,Cor,Gernero,Tamanho,Sexo,Preço,Quantidade,Parcial
        //Valores da Compra
        public float valorItem { get; set; }//Valor produto Parcial
        public float trocoCliente { get; set; }
        public float valorPago { get; set; }
        //Rodapé com dados Crediario
        public Venda Venda { get; set; }//CodigoVenda,FormaPagamento,Desconto
        public Cliente Cliente { get; set; }//Id,Nome,Sobrenome,Cpf

        //view [ReciboVenda]+view [ReciboItemVenda] ou view [ReciboItemVendaTemp]
    }

  public class ReciboVendaLista : List<ReciboVenda> { }
}
