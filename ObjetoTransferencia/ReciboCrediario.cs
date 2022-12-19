using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ObjetoTransferencia
{
    //Recibio de pagamento para Cliente Crediairo ou Venda
    public class ReciboCrediario
    {
        //Dados Cliente
        public Cliente Cliente { get; set; }//Id,Nome,Sobrenome,Cpf
        //Dados Item
        public ItemCrediario ItemCrediario { get; set; }//Descrição,Cor,Gernero,Tamanho,Sexo,Preço,Quantidade,Parcial,FORMAPAGAMENTO
        //Valores da Compra
        public float valorItem { get; set; }//Valor produto Parcial
        public float trocoCliente { get; set; }
        public float valorPago { get; set; }
        //Rodapé com dados Crediario
        public Crediario Crediario { get; set; }//Codigo,ContaClienteCrediario,Data

        //view [ReciboCrediario]+[ReciboItemCrediario]ou[ReciboItemCrediarioPago]
    }

    public class ReciboCrediarioLista : List<ReciboCrediario> { }
}
