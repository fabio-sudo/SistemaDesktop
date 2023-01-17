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
    public partial class FrmCaixaPendente : Form
    {
        Caixa caixaSelecionado = new Caixa();
        CaixaLista listaCaixa = new CaixaLista();
        NegCaixa nCaixa = new NegCaixa();

        public FrmCaixaPendente(Caixa caixa)
        {
            InitializeComponent();

            caixaSelecionado = caixa;
        }

        private void metodoAtualizaGrid() {

            this.dgvCaixa.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.listaCaixa.Count > 0)
            {
                this.dgvCaixa.Rows.Add(this.listaCaixa.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (Caixa caixa in this.listaCaixa)
            {
                this.dgvCaixa[1, indice].Value = caixa.formaPagamento.formaPagamento;
                this.dgvCaixa[2, indice].Value = caixa.totalCaixa;
                this.dgvCaixa[3, indice].Value = caixa.recebidoCaixa;
                this.dgvCaixa[4, indice].Value = caixa.descontoCaixa;
                this.dgvCaixa[5, indice].Value = caixa.jurosCaixa;
 
                indice++;
            }

            dgvCaixa.Update();
        
        }

        private void metodoConstrutor() {

            tbEstatusCaixa.Text = caixaSelecionado.estatusCaixa;
            dtpDataCaixa.Value = caixaSelecionado.dataCaixa;
            tbTrocoCaixa.Text = String.Format("{0:C2}", caixaSelecionado.trocoCaixa);
            tbEstorno.Text = String.Format("{0:C2}", caixaSelecionado.estornoCaixa);

            listaCaixa = nCaixa.BuscarCaixaPendente(caixaSelecionado.dataCaixa);
            if (listaCaixa.Count > 0)
            {
                metodoAtualizaGrid();

            }
            else
            { this.Close(); }
                  
        }

        private void FrmCaixaPendente_Load(object sender, EventArgs e)
        {
            metodoConstrutor();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            FrmBackup bkp = new FrmBackup();
            bkp.Show();
        }
    }
}
