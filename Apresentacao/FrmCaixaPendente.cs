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

        ListaDespesas listaDespesas = new ListaDespesas();
        NegDespesa nDespesa = new NegDespesa();

        ListaFormaPagamento listaFormaPagamento = new ListaFormaPagamento();
        NegFormaPagamento nFormaPagamento = new NegFormaPagamento();

        Metodos metodos = new Metodos();
        TextBox caixaTextoGride;
        TextBox caixaTextoGrideDespesa;


        //---Variaveis
        double valorRecebidoCaixa = 0;
        double valorRecebidoUsuario = 0;
        double valorLiquidoCaixa = 0;
        double descontoCaixa = 0;
        double jurosCaixa = 0;
        double valorDespesaCaixa = 0;
        double valorSangria = 0;
        double faltaCaixa = 0;

        public FrmCaixaPendente(Caixa caixa)
        {
            InitializeComponent();

            caixaSelecionado = caixa;
        }

        //atualiza do dados da GRid
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
                this.dgvCaixa[0, indice].Value = "0,00";
                this.dgvCaixa[1, indice].Value = caixa.sangriaCaixa;
                this.dgvCaixa[2, indice].Value = caixa.formaPagamento.formaPagamento;
                this.dgvCaixa[3, indice].Value = caixa.totalCaixa;
                this.dgvCaixa[4, indice].Value = caixa.recebidoCaixa;
                this.dgvCaixa[5, indice].Value = caixa.descontoCaixa;
                this.dgvCaixa[6, indice].Value = caixa.jurosCaixa;
                
 
                indice++;
            }

            dgvCaixa.Update();
        
        }

        //realiza criação do formulário preenhcido
        private void metodoConstrutor() {




            if (caixaSelecionado.estatusCaixa != "Pendente") { tgEstatus.Checked = true; } else { tgEstatus.Checked = false; }
            lbEstatusCaixa.Text = caixaSelecionado.estatusCaixa;

            dtpDataCaixa.Value = caixaSelecionado.dataCaixa;


            lbTotalTrocoCaixa.Text = String.Format("{0:C2}", caixaSelecionado.trocoCaixa);
            lbTotalEstorno.Text = String.Format("{0:C2}", caixaSelecionado.estornoCaixa);
            //Combo Despesas

            listaCaixa = nCaixa.BuscarCaixaPendente(caixaSelecionado.dataCaixa);

            SangriaLista listaSangria = new SangriaLista();
            listaSangria = nCaixa.BuscarSangriaFechamentoCaixa(caixaSelecionado.dataCaixa);

            //Adiciona valor da Sangria ao Caixa
            foreach (Sangria sangria in listaSangria) {

                foreach (Caixa caixa in listaCaixa) {

                    if (sangria.pagamentoSangria.formaPagamento == caixa.formaPagamento.formaPagamento) {

                        caixa.sangriaCaixa = - sangria.valorSangria;
                        break;
                    }     
                }                 
            }




            if (listaCaixa.Count > 0)
            {
                metodoAtualizaGrid();
                metodoCalculaTotais();
            }
            else
            { this.Close(); }
                  
        }

        //Preeche caixa com os tatis armazenados no sistema
        private void metodoPreencheAuto(string preencher)
        {

            if (preencher == "F5 Preencher")
            {
                foreach (DataGridViewRow col in dgvCaixa.Rows)
                {

                    col.Cells[0].Value = Convert.ToDouble(col.Cells[3].Value) + Convert.ToDouble(col.Cells[1].Value);
                    metodoCalculaTotais();
                }
            }
            else if (preencher == "F5 Zerar")
            {
                foreach (DataGridViewRow col in dgvCaixa.Rows)
                {

                    col.Cells[0].Value = 0;
                    metodoCalculaTotais();
                }
            }
        }

        //Calcula os totais do caixa
        private void metodoCalculaTotais() {


             valorRecebidoCaixa = 0;
             valorRecebidoUsuario = 0;
             valorLiquidoCaixa = 0;
             descontoCaixa = 0;
             jurosCaixa = 0;
             valorDespesaCaixa = 0;
             valorSangria = 0;
             faltaCaixa = 0;




            foreach (DataGridViewRow row in dgvCaixa.Rows) {

                valorRecebidoUsuario = valorRecebidoUsuario + Convert.ToDouble(row.Cells[0].Value);
                valorSangria = valorSangria + Convert.ToDouble(row.Cells[1].Value);
                valorRecebidoCaixa = valorRecebidoCaixa + Convert.ToDouble(row.Cells[3].Value);
                valorLiquidoCaixa = valorLiquidoCaixa + Convert.ToDouble(row.Cells[4].Value);
                descontoCaixa = descontoCaixa + Convert.ToDouble(row.Cells[5].Value);
                jurosCaixa = jurosCaixa + Convert.ToDouble(row.Cells[6].Value);

                if ((valorRecebidoCaixa - valorSangria) < 1) { row.DefaultCellStyle.ForeColor = Color.Green; }
            }
           

            //Comparação dos caixas
            lbTotalCaixaReal.Text = String.Format("{0:C2}", valorRecebidoUsuario + valorDespesaCaixa - valorSangria);
            lbTotalCaixaSistema.Text = String.Format("{0:C2}", valorRecebidoCaixa);

            if (Math.Round(valorRecebidoCaixa) == Math.Round(valorRecebidoUsuario + valorDespesaCaixa - valorSangria))
            {
                lbTituloCaixaReal.BackColor = Color.Turquoise;
                pbOk.Image = Properties.Resources.DialogOK;
            }
            else {
                lbTituloCaixaReal.BackColor = Color.Red;
                pbOk.Image = Properties.Resources.DialogErro;
            
            }

            //Fechamento Usuário Falta Caixa
            faltaCaixa = (valorRecebidoUsuario + valorDespesaCaixa - valorSangria) - valorRecebidoCaixa;


            if (faltaCaixa > 0) { 

            lbTituloMovimentacaoCaixa.BackColor =   Color.Turquoise;
            lbFaltouSobrou.Text = "Sobrou +";
            }
            else if (faltaCaixa < 0)
            {


                lbTituloMovimentacaoCaixa.BackColor = Color.Red;
                lbFaltouSobrou.Text = "Faltou - +";
            }
            else {
                lbTituloMovimentacaoCaixa.BackColor = Color.FromArgb(51, 51, 76);
                lbFaltouSobrou.Text = "Valor Confirmado";        
            }

            //Caixa
            lbTotalMovimentacaoCaixa.Text = String.Format("{0:C2}",  faltaCaixa);       
           
            //Liquido
            lbTotalLiquidoCaixa.Text = "+" + String.Format("{0:C2}", valorLiquidoCaixa);
            //Sangria
            lbTotalSangria.Text = "+" + String.Format("{0:C2}", -valorSangria);

            //Juros
            lbTotalJurosCaixa.Text = "%"+String.Format("{0:C2}", jurosCaixa);
            
            //Desconto
            lbTotalDescontoCaixa.Text ="- "+ String.Format("{0:C2}", descontoCaixa);

            //Despesas
            lbTotalDespesas.Text = "- " + String.Format("{0:C2}", valorDespesaCaixa);

        }

        //----------------------------------Controles
        private void FrmCaixaPendente_Load(object sender, EventArgs e)
        {
            metodoConstrutor();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            metodoCalculaTotais();
            
            
            FrmBackup bkp = new FrmBackup();
            bkp.Show();
        }

        //------------------Gride Caixa
        private void caixaTextoGride_TextChanged(object sender, EventArgs e)
        {
            metodos.metodoMoedaTB(ref caixaTextoGride);
        }

        private void caixaTextoGride_Leave(object sender, EventArgs e)
        {

            //Pega valor da caixa de testo para atualizar juros
            if (caixaTextoGride.Text != "0,00")
            {
                string valorRecebidoStr = String.Format("{0:C2}", Convert.ToDouble(dgvCaixa.CurrentRow.Cells[3].Value)).Replace("R$", "");
                double valorCaixaTexto = Convert.ToDouble(caixaTextoGride.Text);
                double valor1 = Math.Truncate(Convert.ToDouble(dgvCaixa.CurrentRow.Cells[3].Value));
                double valor2 = Math.Truncate(Convert.ToDouble(dgvCaixa.CurrentRow.Cells[1].Value));

                double valida = valor1 + valor2 - Math.Truncate(valorCaixaTexto);

                if (valida != 0)
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

            metodoCalculaTotais();
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

        private void btPreencher_Click(object sender, EventArgs e)
        {
            metodoPreencheAuto(btPreencher.Text);
            if (btPreencher.Text == "F5 Preencher")
            {
                btPreencher.Text = "F5 Zerar";
            }
            else { btPreencher.Text = "F5 Preencher"; }
        }
        
         //---------------Evento Caixa de Texto
        private void caixaTextoGrideDespesa_TextChanged(object sender, EventArgs e)
        {
            metodos.metodoMoedaTB(ref caixaTextoGrideDespesa);
        }

        private void caixaTextoGrideDespesa_Leave(object sender, EventArgs e)
        {
            metodoCalculaTotais();
        }
        
        //--------------Troco
        private void tbTrocoDeixado_TextChanged(object sender, EventArgs e)
        {
            metodos.metodoMoedaTB(ref tbTrocoDeixado);
        }

        //----------------------------------Botões
        private void btFinalizar_Click(object sender, EventArgs e)
        {
            //Metodo valida fechamento do caixa
            Caixa caixaCadastro = new Caixa();
          


        }

        private void btDespesas_Click(object sender, EventArgs e)
        {
            FrmSelecionarDespesa frmDespesa = new FrmSelecionarDespesa();
            frmDespesa.ShowDialog();

            metodoConstrutor();
        
        }
    }
}
