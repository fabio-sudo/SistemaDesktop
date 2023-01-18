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
using Apresentacao.Formulas;

namespace Apresentacao
{
    public partial class FrmCaixaPendente : Form
    {
        Caixa caixaSelecionado = new Caixa();
        CaixaLista listaCaixa = new CaixaLista();
        NegCaixa nCaixa = new NegCaixa();


        Metodos metodos = new Metodos();
        TextBox caixaTextoGride;

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

        //Evento TextoChanged do Gride
        private void caixaTextoGride_TextChanged(object sender, EventArgs e)
        {
            metodos.metodoMoedaTB(ref caixaTextoGride);
        }

        private void caixaTextoGride_Leave(object sender, EventArgs e)
        {
            //Pega valor da caixa de testo para atualizar juros
            if (caixaTextoGride.Text != null)
            {
                string valorRecebidoStr = String.Format("{0:C2}", Convert.ToDouble(dgvCaixa.CurrentRow.Cells[2].Value)).Replace("R$","");
                double valorCaixaTexto = Convert.ToDouble(caixaTextoGride.Text);

                if (Convert.ToDouble(valorRecebidoStr) != valorCaixaTexto)//Erro referencia objeto verificar
                {
                    FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Erro Valores Caixa",
                   "Caixa do sistema está diferente do caixa físico!",
                    Properties.Resources.DialogErro,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Ok", "",
                    false);
                    frmCaixaCad.ShowDialog();
                }
            }
        }

        private void dgvCaixa_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try{
                //-----------Adiciona o formato apenas na caixa de texto 
                if (dgvCaixa.CurrentCell.ColumnIndex == 0)
                {
                    //if (caixaTextoGride != null)
                    {
                        caixaTextoGride = e.Control as TextBox;
                        caixaTextoGride.TextChanged -= new EventHandler(caixaTextoGride_TextChanged);
                        caixaTextoGride.TextChanged += caixaTextoGride_TextChanged;

                        caixaTextoGride.Leave -= new EventHandler(caixaTextoGride_Leave);
                        caixaTextoGride.Leave += caixaTextoGride_Leave;
                    }
                }
                else
                {

                    caixaTextoGride = new TextBox();

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void pbCalculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\system32\\calc.exe");
        }

        private void dgvCaixa_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //Valor da Parcial
            if (dgvCaixa.Columns[e.ColumnIndex].Name == "caixaUsuario")
            {
                dgvCaixa.Rows[e.RowIndex].ErrorText = "";
                double newDouble;

                if (dgvCaixa.Rows[e.RowIndex].IsNewRow) { return; }
                if (!double.TryParse(e.FormattedValue.ToString(),
                    out newDouble) || newDouble <= 0)
                {
                    dgvCaixa.Rows[e.RowIndex].ErrorText = "Informe o valor da Parcial";
                }

            }
        }
    }
}
