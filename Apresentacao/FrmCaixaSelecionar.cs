using Negocio;
using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmCaixaSelecionar : Form
    {
        NegCaixa nCaixa = new NegCaixa();
        Caixa objCaixa = new Caixa();
        CaixaLista listaCaixa = new CaixaLista();



        public FrmCaixaSelecionar()
        {
            InitializeComponent();
        }

        //Controles
        private void btFiltrar_Click(object sender, EventArgs e)
        {
            listaCaixa = nCaixa.BuscarMovimentacaoCaixa("", dtpDataInicial.Value, dtpDataFinal.Value);
            listaCaixa.Count();
        }
    }
}
