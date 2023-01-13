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
    public partial class FrmCaixaPendente : Form
    {
        Caixa caixaSelecionado = new Caixa();

        public FrmCaixaPendente(Caixa caixa)
        {
            InitializeComponent();

            caixaSelecionado = caixa;
        }

        private void metodoConstrutor() {

            tbEstatusCaixa.Text = caixaSelecionado.estatusCaixa;
            dtpDataCaixa.Value = caixaSelecionado.dataCaixa;
            tbTrocoCaixa.Text = String.Format("{0:C2}", caixaSelecionado.trocoCaixa);
            //Criar Tabela Despesas
            //Buscar Pagamentos do Caixa//Buscar Despesas do Caixa


        
        }

        private void FrmCaixaPendente_Load(object sender, EventArgs e)
        {
            metodoConstrutor();
        }
    }
}
