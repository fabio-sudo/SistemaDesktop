using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
  public class ReciboCrediarioParcial
    {
        //Dados Cliente
        public Cliente Cliente { get; set; }//Id,Nome,Sobrenome,Cpf
        //Dados Item
        public ItemCrediarioParcial ItemCrediarioParcial { get; set; }//Descrição,Cor,Gernero,Tamanho,Sexo,Preço,Quantidade,Parcial,Parcela do Item
        //Valores da Compra
        public float valorItem { get; set; }//Valor produto Parcial
        public float trocoCliente { get; set; }
        public float valorPago { get; set; }

        //view [ReciboCrediario]+ [ReciboCrediarioParcial]contem todos os valores do item
    }

  public class ReciboCrediarioParcialLista : List<ReciboCrediarioParcial> { }
}
