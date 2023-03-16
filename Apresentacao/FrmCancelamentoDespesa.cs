using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmCancelamentoDespesa : Form
    {
       DespesaCaixa despesaSelecionada = new DespesaCaixa();
       SangriaLista  listaSangriaSelecionada = new SangriaLista();
       CaixaLista  listaCaixaSelecionado = new CaixaLista();
       ParcialVendaLista  listaParcialSelecionado = new ParcialVendaLista();
       ItemVendaLista  listaItemVendaSelecionado = new ItemVendaLista();
       ItemCrediarioLista listaItemCrediarioPagoSelecionado = new ItemCrediarioLista();
       ItemCrediarioParcialLista listaItemCrediarioParcialSelecionado = new ItemCrediarioParcialLista();

       public FrmCancelamentoDespesa(DespesaCaixa despesa, CaixaLista caixa, [Optional] SangriaLista sangria, [Optional] ParcialVendaLista listaParcialVenda, [Optional]  ItemVendaLista itemVenda, [Optional] ItemCrediarioLista itemCrediario, [Optional]  ItemCrediarioParcialLista itemCrediarioParcial)
        {
            InitializeComponent();

            despesaSelecionada = despesa;

            if (sangria != null)
            {
                listaSangriaSelecionada = sangria;
            }
            if (caixa != null)
            {
                listaCaixaSelecionado = caixa;
            }
            //Objetos a serem cancelados
            if (listaParcialVenda != null)
            {
                listaParcialSelecionado = listaParcialVenda;
            }
            if (itemVenda != null)
            {
                listaItemVendaSelecionado = itemVenda;
            }
            if (itemCrediario != null)
            {
                listaItemCrediarioPagoSelecionado = itemCrediario;
            }
            if (itemCrediarioParcial != null)
            {
                listaItemCrediarioParcialSelecionado = itemCrediarioParcial;
            }
        }







    }
}
