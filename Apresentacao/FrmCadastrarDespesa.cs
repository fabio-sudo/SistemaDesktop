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
    public partial class FrmCadastrarDespesa : Form
    {
        //Classe metodos de Validção 
        Formulas.Metodos metodos = new Formulas.Metodos();
        ListaFormaPagamento listaPagamento = new ListaFormaPagamento();
        NegFormaPagamento nPagamento = new NegFormaPagamento();

        Funcionario objFuncionario = new Funcionario();
        NegFuncionario nFuncionario = new NegFuncionario();

        ListaDespesas listaDespesas = new ListaDespesas();
        NegDespesa nDespesa = new NegDespesa();



        CaixaLista listaCaixa = new CaixaLista();
        NegCaixa nCaixa = new NegCaixa();

        public FrmCadastrarDespesa()
        {
            InitializeComponent();
        }

        //-------------MEtodos
        private void metodoCalculaTotais() {

            //Caixa
            double caixa = 0;
            double sangria = 0;
            double estorno = 0;
            double despesa = 0;

            //-----------------------------------------Calcula Totais do Datagride
            //faz a soma dos totais dos valores do gride

            foreach (DataGridViewRow col in dgvCaixa.Rows)
            {
                //Valor da Parcial
                caixa = caixa + Convert.ToDouble(col.Cells[1].Value);
                sangria = sangria + Convert.ToDouble(col.Cells[3].Value);
                estorno = estorno + Convert.ToDouble(col.Cells[4].Value);
                despesa = despesa + Convert.ToDouble(col.Cells[5].Value);
            }
            //-----------Venda
            lbCaixaTotal.Text =  String.Format("{0:C2}", caixa);
            lbSangriaTotal.Text = String.Format("{0:C2}", sangria);
            lbTotalEstorno.Text = String.Format("{0:C2}", estorno);
            lbTotalDespesas.Text = String.Format("{0:C2}", despesa);
        }

        //-------------metodo valida preenchimento da despesa
        private Boolean metodoValidaCadastro() {


            foreach(Caixa caixa in listaCaixa){

                if (cbFormaPagamento.SelectedItem.ToString() == caixa.formaPagamento.formaPagamento) {

                    if (Convert.ToDouble(mtbValorDespesa.Text) > (caixa.valorCaixa - caixa.despesaCaixa - caixa.sangriaCaixa - caixa.estornoCaixa)) {

                        MessageBox.Show("Valor da despesa maior que o valor do Caixa!", "Erro Valor Despesa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbDescricao.Focus();
                        return false;
                    
                    }
                
                }         
            }
            return true;
        
        
        }

        private void metodoConstrutor() {

            listaDespesas = nDespesa.BuscarDespesaPorData(dtpDataDespesa.Value, dtpDataDespesa.Value);
            listaCaixa = nCaixa.BuscarCaixaPendente(dtpDataDespesa.Value);

            SangriaLista listaSangria = new SangriaLista();
            listaSangria = nCaixa.BuscarSangriaFechamentoCaixa(dtpDataDespesa.Value);

            //------------------------------------Sangria
            if (listaSangria.Count > 0)
            {
                //Adiciona valor da Sangria ao Caixa
                foreach (Sangria sangria in listaSangria)
                {

                    foreach (Caixa caixa in listaCaixa)
                    {

                        if (sangria.pagamentoSangria.formaPagamento == caixa.formaPagamento.formaPagamento)
                        {

                            caixa.sangriaCaixa = -sangria.valorSangria;
                            break;
                        }
                    }
                }
            }

            //------------------------------------Despesa
            if (listaDespesas.Count > 0)
            {
                //Adiciona valor da Despesas ja cadastradas na sangria
                foreach (DespesaCaixa despesa in listaDespesas)
                {

                    foreach (Caixa caixa in listaCaixa)
                    {

                        if (despesa.formaPagamento.formaPagamento == caixa.formaPagamento.formaPagamento)
                        {

                            caixa.despesaCaixa = -despesa.valorDespesa;
                            break;
                        }
                    }
                }

            }


            //Preenche o gird
            if (listaCaixa.Count > 0)
            {
                metodoAtualizaGrid();
                metodoCalculaTotais();
            }
            else
            { this.Close(); }
                  
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
                this.dgvCaixa[0, indice].Value = caixa.formaPagamento.formaPagamento;
                this.dgvCaixa[1, indice].Value = caixa.totalCaixa + (caixa.sangriaCaixa - caixa.estornoCaixa - caixa.estornoCaixa + caixa.despesaCaixa);
                this.dgvCaixa[2, indice].Value = caixa.recebidoCaixa;
                this.dgvCaixa[3, indice].Value = caixa.sangriaCaixa;
                this.dgvCaixa[4, indice].Value = caixa.estornoCaixa;
                this.dgvCaixa[5, indice].Value = caixa.despesaCaixa;
 
                indice++;
            }

            dgvCaixa.Update();
        }

        //Metodo para validar campos
        public Boolean metodoValidaCampos()
        {

            if (tbDescricao.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe a Descrição do Produto!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbDescricao.Clear();
                tbDescricao.Focus();

                return false;
            }
            else if (cbFormaPagamento.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe a Forma de Pagamento!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbFormaPagamento.Focus();

                return false;
            }
            else if (mtbValorDespesa.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o valor da Despesa!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbValorDespesa.Clear();
                mtbValorDespesa.Focus();


                return false;
            }

            else if (objFuncionario.nomeFuncionario == null)
            {
                MessageBox.Show("Informe o Funcinário que está lançando a Despesa!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbFuncionario.Clear();
                tbFuncionario.Focus();


                return false;
            }

            else
                return true;


        }

        //Metodo para limpar os campos
        public void metodoLimpaCampos()
        {
            epDespesa.Clear();
            tbDescricao.Clear();
            cbFormaPagamento.SelectedItem = null;
            mtbValorDespesa.Clear();

        }

        //Aviso campo obrigatório
        private void tbDescricao_Leave(object sender, EventArgs e)
        {
            //Verifica se o campo for preenchido
            if (tbDescricao.Text == String.Empty)
            {
                epDespesa.SetError(tbDescricao, "Campo obrigatório!");
                return;
            }
            else
                epDespesa.Clear();
        }

        private void mtbValorDespesa_Leave(object sender, EventArgs e)
        {
            //Verifica se o campo for preenchido
            if (mtbValorDespesa.Text == String.Empty)
            {
                epDespesa.SetError(mtbValorDespesa, "Campo obrigatório!");
                return;
            }
            else
                epDespesa.Clear();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair do Cadastro de Despesas ?",
            Properties.Resources.DialogQuestion,
            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
            Color.White,
            "Sim", "Não",
            false);

            resposta = frmCaixa.ShowDialog();
            if (resposta == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void mtbValorDespesa_TextChanged(object sender, EventArgs e)
        {
            metodos.metodoMoedaMTB(ref mtbValorDespesa);
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            //Valida se todos os campos foram preenchidos
            if (metodoValidaCampos() == true)
            {
                try
                {
                    if (metodoValidaCadastro() == true)
                    {


                        NegDespesa nDespesa = new NegDespesa();
                        DespesaCaixa despesa = new DespesaCaixa();

                        despesa.descricaoDespesa = tbDescricao.Text;
                        despesa.valorDespesa = Convert.ToDouble(mtbValorDespesa.Text);
                        despesa.dataDespesa = dtpDataDespesa.Value;
                        despesa.funcionario = objFuncionario;
                        despesa.formaPagamento = listaPagamento.Where(p => p.formaPagamento == cbFormaPagamento.SelectedItem.ToString()).First();


                        if (nDespesa.CadastrarDespesaTemp(despesa) == true)
                        {
                            DialogResult resposta;
                            //Criando Caixa de dialogo
                            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
                            " Cadastro Realizado com Sucesso! \r\n" +
                            "Deseja Continuar No Cadastro De Despesas?",
                            Properties.Resources.DialogOK,
                            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                            Color.White,
                            "Sim", "Não",
                            false);

                            resposta = frmCaixa.ShowDialog();
                            if (resposta != DialogResult.Yes)
                            {
                                this.DialogResult = DialogResult.OK;
                                this.Close();

                            }
                            else
                                metodoLimpaCampos();
                            tbDescricao.Focus();
                            metodoConstrutor();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível realizar o cadastro da Despesa!", "Erro Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tbDescricao.Focus();
                            return;
                        }
                    }

                }

                catch (Exception ex)
                {
                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro",
                    "Erro ao cadastrar Despesa \r\n" + ex.Message,
                    Properties.Resources.DialogErro,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Ok", "",
                    false);

                    frmCaixa.ShowDialog();
                }
            }
        }

        private void cbFormaPagamento_DropDown(object sender, EventArgs e)
        {
            try
            {
                cbFormaPagamento.Items.Clear();
                this.listaPagamento = nPagamento.BuscarFormaPagamentoComboboxPorData(dtpDataDespesa.Value);

                foreach (FormaPagamento pag in this.listaPagamento)
                {
                   
                        this.cbFormaPagamento.Items.Add(pag.formaPagamento);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void FrmCadastrarDespesa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {
                btSair.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F10) == true)
            {
                btCadastrar.PerformClick();
            }
        }

        private void FrmCadastrarDespesa_Load(object sender, EventArgs e)
        {

            //Pega no formulario da venda o UsuarioLogado
            if (FrmMenuPrincipal.userLogado != null)
            {
                objFuncionario = FrmMenuPrincipal.userLogado;
                tbFuncionario.Text = objFuncionario.nomeFuncionario;
            }

            metodoConstrutor();
        }

        private void btFuncionario_Click(object sender, EventArgs e)
        {
            int n;
            bool ehUmNumero = int.TryParse(tbFuncionario.Text, out n);
            if (ehUmNumero == true)
            {
                objFuncionario = nFuncionario.BuscarFuncionarioPorCodigo(n);
                if (objFuncionario != null)
                {
                    this.tbFuncionario.Text = objFuncionario.nomeFuncionario;
                    mtbValorDespesa.Focus();
                }
                else
                    tbFuncionario.Clear();
            }
            else
            {
                FrmSelecionarFuncionario frmSelecionarFuncionario = new FrmSelecionarFuncionario(tbFuncionario.Text);
                DialogResult resultado = frmSelecionarFuncionario.ShowDialog();

                if (resultado == DialogResult.OK)
                {

                    this.objFuncionario = frmSelecionarFuncionario.FuncionarioSelecionado;
                    this.tbFuncionario.Text = objFuncionario.nomeFuncionario;
                    mtbValorDespesa.Focus();
                }

            }
        }

        private void tbFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btFuncionario.PerformClick();
                e.Handled = true;
            }
        }

        private void tbFuncionario_Leave(object sender, EventArgs e)
        {
            if (tbFuncionario.Text == "")
            {
                tbFuncionario.Text = "Digite o nome do funcionário ...";
                pbFuncionario.Image = Properties.Resources.FuncionarioAzul;
                panelFuncionario.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                tbFuncionario.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

            }
        }

        private void tbFuncionario_Enter(object sender, EventArgs e)
        {
            tbFuncionario.Clear();
            pbFuncionario.Image = Properties.Resources.FuncionarioRosa;
            panelFuncionario.BackColor = Color.DeepPink;
        }


    }
}
