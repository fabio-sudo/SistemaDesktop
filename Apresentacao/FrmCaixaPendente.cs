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
        ListaFormaPagamento listaFormaPagamento = new ListaFormaPagamento();

        NegFormaPagamento nFormaPagamento = new NegFormaPagamento();

        Metodos metodos = new Metodos();
        TextBox caixaTextoGride;
        TextBox caixaTextoGrideDespesa;
        ComboBox comboDataGride;
        int indiceGride = 0;

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
                this.dgvCaixa[5, indice].Value = caixa.jurosCaixa;
                this.dgvCaixa[6, indice].Value = caixa.descontoCaixa;
                
 
                indice++;
            }

            dgvCaixa.Update();
        
        }

        //realiza criação do formulário preenhcido
        private void metodoConstrutor() {

            tbEstatusCaixa.Text = caixaSelecionado.estatusCaixa;
            dtpDataCaixa.Value = caixaSelecionado.dataCaixa;
            tbTrocoCaixa.Text = String.Format("{0:C2}", caixaSelecionado.trocoCaixa);
            tbEstorno.Text = String.Format("{0:C2}", caixaSelecionado.estornoCaixa);


            lbTotalTrocoCaixa.Text = String.Format("{0:C2}", caixaSelecionado.trocoCaixa);
            lbTrocoSistema.Text = String.Format("{0:C2}", caixaSelecionado.trocoCaixa);
            lbTotalEstorno.Text = String.Format("{0:C2}", caixaSelecionado.estornoCaixa);
            //Combo Despesas
            metodoPreencheCombobox();

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

                    col.Cells[0].Value = col.Cells[2].Value;
                }
            }
            else if (preencher == "F5 Zerar")
            {
                foreach (DataGridViewRow col in dgvCaixa.Rows)
                {

                    col.Cells[0].Value = 0;
                }
            }
        }

        //Preenche Combobox das Despesas
        private void metodoPreencheCombobox()
        {

            this.formaPagamentoDespesa.Items.Clear();
            this.listaFormaPagamento = nFormaPagamento.BuscarFormaPagamentoCombobox();
            


            foreach (FormaPagamento pag in this.listaFormaPagamento)
            {
                if (pag.formaPagamento != "CREDIARIO" || pag.formaPagamento != "PARCIAL")
                {
                    {
                        this.formaPagamentoDespesa.Items.IndexOf(pag.codigoFormaPagamento);
                        //this.formaPagamentoParcial.Items.Add(pag.formaPagamento + " - " + pag.taxaFormaPagamento.ToString("F"));
                        this.formaPagamentoDespesa.Items.Add(pag.formaPagamento);
                    }
                }
            }
        }

        //Calcula os totais do caixa
        private void metodoCalculaTotais() {

            //---Variaveis
            double valorRecebidoCaixa = 0;
            double valorRecebidoUsuario = 0;
            double valorLiquidoCaixa = 0;
            double descontoCaixa = 0;
            double jurosCaixa = 0;
            double valorDespesaCaixa = 0;
            double valorSangria = 0;

            foreach (DataGridViewRow row in dgvCaixa.Rows) {

                valorRecebidoUsuario = valorRecebidoUsuario + Convert.ToDouble(row.Cells[0].Value);
                valorSangria = valorSangria + Convert.ToDouble(row.Cells[1].Value);
                valorRecebidoCaixa = valorRecebidoCaixa + Convert.ToDouble(row.Cells[3].Value);
                valorLiquidoCaixa = valorLiquidoCaixa + Convert.ToDouble(row.Cells[4].Value);
                descontoCaixa = descontoCaixa + Convert.ToDouble(row.Cells[5].Value);
                jurosCaixa = jurosCaixa + Convert.ToDouble(row.Cells[6].Value);

                if ((valorRecebidoCaixa - valorSangria) < 1) { row.DefaultCellStyle.ForeColor = Color.Green; }
            }
            //Caso houver despesas
            if (dgvDespesas.Rows.Count > 0) {
                foreach (DataGridViewRow row in dgvDespesas.Rows)
                {
                    valorDespesaCaixa = valorDespesaCaixa + Convert.ToDouble(row.Cells[1].Value);
                }
            }


            //Comparação dos caixas
            lbTotalCaixaReal.Text = String.Format("{0:C2}", valorRecebidoUsuario + valorDespesaCaixa);
            lbTotalCaixaSistema.Text = String.Format("{0:C2}", valorRecebidoCaixa);

            if (valorRecebidoCaixa == (valorRecebidoUsuario + valorDespesaCaixa))
            {
                lbTituloCaixaReal.BackColor = Color.Turquoise;
                lbCaixaCliente.ForeColor = Color.Turquoise;
                panelCalculoVenda.BackColor = Color.Turquoise;
                pbOk.Image = Properties.Resources.DialogOK;
            }
            else {
                lbTituloCaixaReal.BackColor = Color.Red;
                lbCaixaCliente.ForeColor = Color.Red;
                panelCalculoVenda.BackColor = Color.Red;
                pbOk.Image = Properties.Resources.DialogErro;
            
            }

            //Fechamento Usuário
            lbTotalRecebidoCaixa.Text = String.Format("{0:C2}", valorRecebidoUsuario + valorDespesaCaixa);
            lbCaixaCliente.Text = String.Format("{0:C2}", valorRecebidoUsuario + valorDespesaCaixa);
            
            //Caixa Sistema
            lbTotalMovimentacaoCaixa.Text = "+" + String.Format("{0:C2}", valorRecebidoCaixa);
            lbRecebidoSistema.Text = "+" + String.Format("{0:C2}", valorRecebidoCaixa);
            //Liquido
            lbTotalLiquidoCaixa.Text = String.Format("{0:C2}", valorLiquidoCaixa);
            lbVendaLiquido.Text = String.Format("{0:C2}", valorLiquidoCaixa);
            //Juros
            lbTotalJurosCaixa.Text = "%" + String.Format("{0:C2}", jurosCaixa);
            lbJurosSistema.Text = "%"+String.Format("{0:C2}", jurosCaixa);
            //Desconto
            lbTotalDescontoCaixa.Text ="- "+ String.Format("{0:C2}", descontoCaixa);
            lbDescontoSistema.Text = "- "+ String.Format("{0:C2}", descontoCaixa);

            //Despesas
            lbTotalDespesas.Text = "§" + String.Format("{0:C2}", valorDespesaCaixa);
            lbDespesasSistema.Text = "§" + String.Format("{0:C2}", valorDespesaCaixa);

        }

        //Valida preenchimento do dataGrid
        private Boolean metodoValidaDespesa() {

            if (dgvDespesas.Rows.Count == 0) { return true; }

            foreach (DataGridViewRow row in dgvDespesas.Rows) {

                if (row.Cells[0].Value.ToString() == "") { return false; }
                if (row.Cells[1].Value.ToString() == "0,00") { return false; }
                if (row.Cells[2].Value == null) { return false; }         
            }

            return true;
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

        //--------------------Gride Despesas
        private void btAdicionar_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgvDespesas.RowCount == 0)
                {
                    this.dgvDespesas.Rows.Add(1);
                    dgvDespesas.CurrentRow.Cells[3].Value = indiceGride;
                    DataGridViewRow row = dgvDespesas.Rows[0];
                    row.Height = 30;

                    dgvDespesas.CurrentRow.Cells[0].Value = "";
                    dgvDespesas.CurrentRow.Cells[1].Value = "0,00";

                }
                else if(dgvDespesas.CurrentRow.Cells[0].Value.ToString() == "" ||
                        dgvDespesas.CurrentRow.Cells[1].Value.ToString() == "0,00" || 
                        dgvDespesas.CurrentRow.Cells[1].Value.ToString() == "" || dgvDespesas.CurrentRow.Cells[2].Value.ToString() == "")
                {
                    FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Informe a Despesa",
                    "Despesa não foi informada corretamente.",
                    Properties.Resources.DialogErro,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Ok", "",
                    false);
                    frmCaixaCad.ShowDialog();
              


                }else{
                    //metodoCalculaTotais
                    dgvDespesas.Rows.Add(1);
                    indiceGride = dgvDespesas.RowCount - 1;
                    dgvDespesas.CurrentCell = dgvDespesas.Rows[indiceGride].Cells[0];
                    DataGridViewRow row = dgvDespesas.Rows[indiceGride];
                    row.Height = 30;
                    dgvDespesas.CurrentRow.Cells[0].Value = "";
                    dgvDespesas.CurrentRow.Cells[1].Value = "0,00";
                }
            }

            catch (Exception ex) { MessageBox.Show(null, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if(dgvDespesas.Rows.Count > 0){
            var indice = dgvDespesas.CurrentRow.Index;

            if (indice >= 0)
            {

                dgvDespesas.Rows.RemoveAt(indice);
            }
            }
            //metodoCalculaTotais();
        }

        private void dgvDespesas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                btAdicionar.PerformClick();
            }
            if (e.KeyChar == 46)
            {

                btExcluir.PerformClick();
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

        private void dgvDespesas_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                comboDataGride = e.Control as ComboBox;
                if (comboDataGride != null)
                {
                    comboDataGride.DropDown -= new EventHandler(comboDataGride__DropDown);
                    comboDataGride.DropDown += comboDataGride__DropDown;
                    comboDataGride.SelectedIndexChanged += comboDataGride_SelectedIndexChanged;
                }

                //--------------------Caixa de Texto
                    if (dgvDespesas.CurrentCell.ColumnIndex == 1)
                    {
                        {
                            caixaTextoGrideDespesa = e.Control as TextBox;
                            caixaTextoGrideDespesa.TextChanged -= new EventHandler(caixaTextoGrideDespesa_TextChanged);
                            caixaTextoGrideDespesa.TextChanged += caixaTextoGrideDespesa_TextChanged;
                        }
                    }
                    else
                    {

                        caixaTextoGrideDespesa = new TextBox();

                    }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
           }
        
         //---------------Evento Caixa de Texto
        private void caixaTextoGrideDespesa_TextChanged(object sender, EventArgs e)
        {
            metodos.metodoMoedaTB(ref caixaTextoGrideDespesa);
        }

        //---------------Evento DroDown Combo
        private void comboDataGride__DropDown(object sender, EventArgs e)
        {
            metodoPreencheCombobox();
        }

         //Pega o valor utilizado no data gride
        private void comboDataGride_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Pegando valor do index do combobox
            int indiceLista = (sender as ComboBox).SelectedIndex;

            if (indiceLista >= 0)
            {
                //Instanciando objeto forma de pagamento
                FormaPagamento formaPagamento = new FormaPagamento();
                formaPagamento = listaFormaPagamento[indiceLista];

                dgvDespesas.CurrentRow.Cells[4].Value = formaPagamento.codigoFormaPagamento;
            }
        }

        private void dgvDespesas_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //Valor da Parcial
            if (dgvDespesas.Columns[e.ColumnIndex].Name == "valorDespesa")
            {
                dgvDespesas.Rows[e.RowIndex].ErrorText = "";
                double newDouble;

                if (dgvDespesas.Rows[e.RowIndex].IsNewRow) { return; }
                if (!double.TryParse(e.FormattedValue.ToString(),
                    out newDouble) || newDouble <= 0)
                {
                    dgvDespesas.Rows[e.RowIndex].ErrorText = "Informe o valor da Despesa";
                }
            }
            //FormaPagamento
            if (dgvDespesas.Columns[e.ColumnIndex].Name == "formaPagamentoDespesa")
            {

                dgvDespesas.Rows[e.RowIndex].ErrorText = "";

                if (dgvDespesas.Rows[e.RowIndex].IsNewRow) { return; }
                if (e.FormattedValue.ToString() == "")
                {
                    dgvDespesas.Rows[e.RowIndex].ErrorText = "Informe a Forma de Pagamento Corretamente";
                }

            }

        }
        
        //--------------Troco
        private void tbTrocoDeixado_TextChanged(object sender, EventArgs e)
        {
            metodos.metodoMoedaTB(ref tbTrocoDeixado);
        }

        //Toco tem que ser removido do valor total de feichameto do Caixa -Remove fica pro próximo caixa
        //Troco anterior tem que ser somado ao Valor atual do caixa -Adiciona no caixa atual

        //----------------------------------Botões
        private void btFinalizar_Click(object sender, EventArgs e)
        {
            //Metodo valida fechamento do caixa
            Caixa caixaCadastro = new Caixa();

            //Valida despesas preenchidas corretamente
            #region Despesas - Validação - Criação de Lista
            if (dgvDespesas.Rows.Count > 0)
            {
                if (metodoValidaDespesa() == true)
                {
                    listaDespesas = new ListaDespesas();

                    foreach (DataGridViewRow row in dgvDespesas.Rows)
                    {
                        DespesaCaixa despesaAdd = new DespesaCaixa();
                        despesaAdd.formaPagamento = new FormaPagamento();

                        despesaAdd.descricaoDespesa = row.Cells[0].Value.ToString();
                        despesaAdd.valorDespesa = Convert.ToDouble(row.Cells[1].Value);
                        despesaAdd.formaPagamento.codigoFormaPagamento = Convert.ToInt32(row.Cells[4].Value);
                    }
                }
                else { 
                
                  FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro Grid Despesas",
                  " Preencha as despesas corretamente !",
                  Properties.Resources.DialogErro,
                  System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                  Color.White,
                  "OK", "",
                  false);

                  frmCaixa.ShowDialog();
                }
            }
            #endregion



        }
    }
}
