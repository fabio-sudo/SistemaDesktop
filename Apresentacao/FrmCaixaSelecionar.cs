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

        //método preenche dataGrid
        private void metodoAtualizaDataGrid()
        {

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

            foreach (Caixa item in this.listaCaixa)
            {
                this.dgvCaixa[0, indice].Value = item.recebidoCaixa;
                this.dgvCaixa[1, indice].Value = item.totalCaixa;
                this.dgvCaixa[2, indice].Value = item.trocoCaixa;
                this.dgvCaixa[3, indice].Value = item.estornoCaixa;
                this.dgvCaixa[4, indice].Value = item.descontoCaixa;
                this.dgvCaixa[5, indice].Value = item.jurosCaixa;
                this.dgvCaixa[6, indice].Value = item.dataCaixa;
                this.dgvCaixa[7, indice].Value = item.estatusCaixa;

                indice++;
            }

            dgvCaixa.Update();

        }

        //método calcula totais
        private void metodoCalculaTotais() {
            if (dgvCaixa.Rows.Count > 0) {


                double recebido = 0;
                double liquido = 0;
                double troco = 0;
                double estorno = 0;
                double juros = 0;
                double desconto = 0;


                foreach (DataGridViewRow row in dgvCaixa.Rows) {

                    recebido = recebido + Convert.ToDouble(row.Cells[0].Value);
                    liquido = liquido + Convert.ToDouble(row.Cells[1].Value);
                    troco = troco + Convert.ToDouble(row.Cells[2].Value);
                    estorno = estorno + Convert.ToDouble(row.Cells[3].Value);
                    desconto = desconto + Convert.ToDouble(row.Cells[4].Value);
                    juros = juros + Convert.ToDouble(row.Cells[5].Value);

                }

                lbDinheiro.Text = String.Format("{0:C2}", recebido);
                lbValorTotalVenda.Text = String.Format("{0:C2}", liquido);
                lbJuros.Text = String.Format("{0:C2}", juros);
                lbDesconto.Text = String.Format("{0:C2}", desconto);
                lbTotalEstorno.Text = String.Format("{0:C2}", estorno);
                lbTotalTrocoCaixa.Text = String.Format("{0:C2}", troco);

            
            }
        }

        //Controles
        private void btFiltrar_Click(object sender, EventArgs e)
        {
            listaCaixa = nCaixa.BuscarMovimentacaoCaixa("", dtpDataInicial.Value, dtpDataFinal.Value);
            metodoAtualizaDataGrid();
            metodoCalculaTotais();
        }

        private void cbFinalizado_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFinalizado.Checked == true) { cbPendente.Checked = false; }
        }

        private void cbPendente_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPendente.Checked == true) { cbFinalizado.Checked = false; }
        }
    }
}
