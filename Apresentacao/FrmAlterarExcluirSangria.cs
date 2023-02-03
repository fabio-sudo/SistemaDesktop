using Apresentacao.Formulas;
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
    public partial class FrmAlterarExcluirSangria : Form
    {
        Sangria objSangriaAlterada = new Sangria();
        Sangria sangriaSelecionada = new Sangria();
        SangriaLista sangriaLista = new SangriaLista();//Lista para preencher o gride
        SangriaLista sangriaListaAlt = new SangriaLista();//Lista para cadastrar
        NegSangria nSangria = new NegSangria();

        ListaFormaPagamento listaFormaPagamento = new ListaFormaPagamento();
        NegFormaPagamento nFormaPagamento = new NegFormaPagamento();

        NegFuncionario nFuncionario = new NegFuncionario();

        //-----------------Metodos
        Metodos metodos = new Metodos();

        //Objetos Gride
        TextBox caixaTextoGride;

        public FrmAlterarExcluirSangria(Sangria sangria)
        {
            InitializeComponent();

            sangriaSelecionada = sangria;
        }

        //----------------------------------------Metodos
        private void metodoPreencheGrid()
        {

            SangriaLista sangriaListaAlterar = new SangriaLista();
            sangriaListaAlterar = nSangria.BuscarSangriaRealizada(sangriaSelecionada.ordemSangra, sangriaSelecionada.dataSangria, sangriaSelecionada.funcionarioSangria.codigoFuncionario);

            if (sangriaListaAlterar.Count > 0)
            {
                foreach (DataGridViewRow row in dgvSangria.Rows)
                {

                    foreach (Sangria valores in sangriaListaAlterar)
                    {

                        if (Convert.ToInt32(row.Cells[3].Value) == valores.pagamentoSangria.codigoFormaPagamento) {
                           
                            row.Cells[0].Value = valores.valorSangria;//Valor
                            row.Cells[1].Value = Convert.ToDouble(row.Cells[1].Value) - valores.valorSangria; //Retirada
                            row.Cells[2].Value = Convert.ToDouble(row.Cells[2].Value) + valores.valorSangria;//Caixa
                        
                        }
                    }

                }


            }
        }

        //Adiciona valores da retirada na sangria
        private SangriaLista PreencheValoresRetiradaSangria(SangriaLista lista)
        {

            SangriaLista sangriaListaRetiradaNew = nSangria.BuscarSangriaRetirada(sangriaSelecionada.dataSangria);
            SangriaLista novaLista = new SangriaLista();


            if (sangriaListaRetiradaNew.Count > 0)
            {
                foreach (Sangria sangriaCaixa in lista)
                {

                    foreach (Sangria retirada in sangriaListaRetiradaNew)
                    {

                        if (retirada.pagamentoSangria.codigoFormaPagamento == sangriaCaixa.pagamentoSangria.codigoFormaPagamento)
                        {

                            sangriaCaixa.retiradaSangria = retirada.valorSangria;
                            sangriaCaixa.ordemSangra = retirada.ordemSangra;

                            break;

                        }

                    }
                    novaLista.Add(sangriaCaixa);
                }
                this.dgvSangria.Columns[1].Visible = true;
                return novaLista;

            }
            else
            {
                this.dgvSangria.Columns[1].Visible = false;
                return lista;
            }
        }

        //atualiza os valores no Data Grid
        private void AtualizarDataGrid()
        {
            this.dgvSangria.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.sangriaLista.Count > 0)
            {
                this.dgvSangria.Rows.Add(this.sangriaLista.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (Sangria sang in this.sangriaLista)
            {
                this.dgvSangria[0, indice].Value = 0;//Valor será lançado
                
                if (sang.retiradaSangria <= 0) {
                    sang.retiradaSangria = 0;
                }
                this.dgvSangria[1, indice].Value = sang.retiradaSangria;//Valor de lançamento ja realizados no dia 
                this.dgvSangria[2, indice].Value = sang.valorSangria - sang.retiradaSangria;//Valor do Caixa
                this.dgvSangria[3, indice].Value = sang.pagamentoSangria.codigoFormaPagamento;
                this.dgvSangria[4, indice].Value = sang.pagamentoSangria.formaPagamento;
                this.dgvSangria[5, indice].Value = sang.descontoItem;
                this.dgvSangria[6, indice].Value = sang.JurosItem;
                this.dgvSangria[7, indice].Value = 0;//Caso haja estorno no caixa
                this.dgvSangria[8, indice].Value = sang.ordemSangra;//Contador

                indice++;
            }
            dgvSangria.Update();

            metodoPreencheGrid();

        }

        private void metodoZerarForm()
        {
            lbCaixaTotal.Text = "+ " + String.Format("{0:C2}", (0));
            lbSangriaTotal.Text = "-" + String.Format("{0:C2}", 0);
            lbTotalEstorno.Text = "- " + String.Format("{0:C2}", 0);
            lbTaxa.Text = "% " + String.Format("{0:C2}", 0);
            lbDesconto.Text = "- " + String.Format("{0:C2}", 0);
            lbCaixaRestante.Text = "+ " + String.Format("{0:C2}", 0);

        }

        //Preencher ComboBox
        public void metodoPreencheCombobox()
        {

            this.formaPagamentoParcial.Items.Clear();
            this.listaFormaPagamento = nFormaPagamento.BuscarFormaPagamentoCombobox();

            foreach (FormaPagamento pag in this.listaFormaPagamento)
            {
                if (pag.formaPagamento != "CREDIARIO" && pag.formaPagamento != "PARCIAL")
                {
                    {
                        this.formaPagamentoParcial.Items.IndexOf(pag.codigoFormaPagamento);
                        this.formaPagamentoParcial.Items.Add(pag.formaPagamento);
                    }
                }
            }
        }

        //Inicia o formulario
        private void metodoIniciaFormulario()
        {
            dtpDataSangria.Value = sangriaSelecionada.dataSangria;
            sangriaLista = PreencheValoresRetiradaSangria(nSangria.BuscarSangriaValores(sangriaSelecionada.dataSangria));
            metodoPreencheCombobox();
            AtualizarDataGrid();
            metodoCalculaTotais();
            objSangriaAlterada = sangriaSelecionada;
            tbBuscarFuncionario.Text = objSangriaAlterada.funcionarioSangria.nomeFuncionario;
            dgvSangria.Focus();
        }

        //Calcula Totais
        private void metodoCalculaTotais()
        {
            //Caixa
            double jurosSangria = 0;
            double descontoSangria = 0;
            double valorCaixaSangria = 0;
            double valorSangria = 0;
            double valorCaixaSangriaAnterior = 0;
            double valorEstornoCaixa = 0;
            //-----------------------------------------Calcula Totais do Datagride
            //faz a soma dos totais dos valores do gride

            foreach (DataGridViewRow col in dgvSangria.Rows)
            {
                //Valor da Parcial
                valorSangria = valorSangria + Convert.ToDouble(col.Cells[0].Value);
                valorCaixaSangriaAnterior = valorCaixaSangriaAnterior + Convert.ToDouble(col.Cells[1].Value);
                valorCaixaSangria = valorCaixaSangria + Convert.ToDouble(col.Cells[2].Value);
                descontoSangria = descontoSangria + Convert.ToDouble(col.Cells[5].Value);
                jurosSangria = jurosSangria + Convert.ToDouble(col.Cells[6].Value);
                valorEstornoCaixa = valorEstornoCaixa + Convert.ToDouble(col.Cells[7].Value);
            }
            //-----------Venda
            lbCaixaTotal.Text = "+ " + String.Format("{0:C2}", (valorCaixaSangria + valorCaixaSangriaAnterior));
            lbSangriaTotal.Text = "-" + String.Format("{0:C2}", valorSangria);
            lbTotalEstorno.Text = "- " + String.Format("{0:C2}", valorEstornoCaixa);
            lbTaxa.Text = "% " + String.Format("{0:C2}", jurosSangria);
            lbDesconto.Text = "- " + String.Format("{0:C2}", descontoSangria);
            lbCaixaRestante.Text = "+ " + String.Format("{0:C2}", valorCaixaSangria - valorSangria);
        }

        //Valida se há algum valor lançado
        public Boolean metodoValidaSangria()
        {
            double ValidaSangria = 0;

            //verifica se campos vazios
            foreach (DataGridViewRow col in dgvSangria.Rows)
            {


                ValidaSangria = ValidaSangria + Convert.ToDouble(col.Cells[0].Value);



            }
            if (ValidaSangria > 0)
            {

                return true;
            }
            else { return false; }

        }

        //Retorna Lista de Parcias Atualizadas
        private void metodoAddSangriaLista()
        {

            sangriaListaAlt = new SangriaLista();

            foreach (DataGridViewRow col in dgvSangria.Rows)
            {
                Sangria newSangria = new Sangria();
                newSangria.pagamentoSangria = new FormaPagamento();
                newSangria.funcionarioSangria = new Funcionario();

                newSangria.codigoSangria = objSangriaAlterada.codigoSangria;
                newSangria.valorSangria = Convert.ToDouble(col.Cells[0].Value);
                newSangria.pagamentoSangria.codigoFormaPagamento = Convert.ToInt32(col.Cells[3].Value);
                newSangria.pagamentoSangria.formaPagamento = (col.Cells[4].Value).ToString();
                newSangria.funcionarioSangria = objSangriaAlterada.funcionarioSangria;
                newSangria.descontoItem = Convert.ToDouble(col.Cells[5].Value);
                newSangria.JurosItem = Convert.ToDouble(col.Cells[6].Value);
                newSangria.dataSangria = objSangriaAlterada.dataSangria;
                newSangria.ordemSangra = objSangriaAlterada.ordemSangra;

                if (newSangria.valorSangria > 0)//Só adiciona valores lançados
                {
                    sangriaListaAlt.Add(newSangria);
                }
            }
        }

        //Preeche sangria com total do caixa
        private void metodoPreencheAuto(string preencher)
        {

            if (preencher == "total")
            {
                foreach (DataGridViewRow col in dgvSangria.Rows)
                {

                    col.Cells[0].Value = col.Cells[2].Value;
                }
            }
            else if (preencher == "zerar")
            {
                foreach (DataGridViewRow col in dgvSangria.Rows)
                {

                    col.Cells[0].Value = 0;
                }
            }
        }

        //-------------------------Formulário
        private void FrmAlterarExcluirSangria_Load(object sender, EventArgs e)
        {
            //Pega no formulario da venda o UsuarioLogado
            if (FrmMenuPrincipal.userLogado != null)
            {
                objSangriaAlterada.funcionarioSangria = FrmMenuPrincipal.userLogado;
                tbBuscarFuncionario.Text = objSangriaAlterada.funcionarioSangria.nomeFuncionario;
            }

            metodoIniciaFormulario();
            metodoCalculaTotais();
        }

        //--------------------------Funcionário
        private void btBuscar_Click(object sender, EventArgs e)
        {
            int n;
            bool ehUmNumero = int.TryParse(tbBuscarFuncionario.Text, out n);
            if (ehUmNumero == true)
            {
                objSangriaAlterada.funcionarioSangria = nFuncionario.BuscarFuncionarioPorCodigo(n);
                if (objSangriaAlterada.funcionarioSangria != null)
                {
                    this.tbBuscarFuncionario.Text = objSangriaAlterada.funcionarioSangria.nomeFuncionario; ;
                    dgvSangria.Focus();
                }
                else
                    tbBuscarFuncionario.Clear();
            }
            else
            {
                FrmSelecionarFuncionario frmSelecionarFuncionario = new FrmSelecionarFuncionario(tbBuscarFuncionario.Text);
                DialogResult resultado = frmSelecionarFuncionario.ShowDialog();

                if (resultado == DialogResult.OK)
                {

                    this.objSangriaAlterada.funcionarioSangria = frmSelecionarFuncionario.FuncionarioSelecionado;
                    this.tbBuscarFuncionario.Text = objSangriaAlterada.funcionarioSangria.nomeFuncionario;
                    dgvSangria.Focus();
                }

            }
        }

        private void tbBuscarFuncionario_Leave(object sender, EventArgs e)
        {
            if (tbBuscarFuncionario.Text == "")
            {
                tbBuscarFuncionario.Text = "Digite o nome do funcionário ...";
                pbFuncionario.Image = Properties.Resources.FuncionarioAzul;
                panelBuscarFuncionario.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                tbBuscarFuncionario.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

            }
        }

        private void tbBuscarFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btBuscar.PerformClick();
                e.Handled = true;
            }
        }

        private void tbBuscarFuncionario_Enter(object sender, EventArgs e)
        {
            tbBuscarFuncionario.Clear();
            pbFuncionario.Image = Properties.Resources.FuncionarioRosa;
            panelBuscarFuncionario.BackColor = Color.DeepPink;
        }

        //---------------------------DataGride
        private void dgvSangria_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                //-----------Adiciona o formato apenas na caixa de texto 
                if (dgvSangria.CurrentCell.ColumnIndex == 0)
                {
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

        private void dgvSangria_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //Valor da Parcial
            if (dgvSangria.Columns[e.ColumnIndex].Name == "valorParcialVenda")
            {
                dgvSangria.Rows[e.RowIndex].ErrorText = "";
                double newDouble;

                if (dgvSangria.Rows[e.RowIndex].IsNewRow) { return; }
                if (!double.TryParse(e.FormattedValue.ToString(),
                    out newDouble) || newDouble <= 0)
                {
                    dgvSangria.Rows[e.RowIndex].ErrorText = "Informe o valor da Sangria";
                }

            }
        }

        //-----------------------------Data Gride Caixa de Texto
        //Evento TextoChanged do Gride
        private void caixaTextoGride_TextChanged(object sender, EventArgs e)
        {
            metodos.metodoMoedaTB(ref caixaTextoGride);
        }

        private void caixaTextoGride_Leave(object sender, EventArgs e)
        {
            //Pega valor da caixa de testo para atualizar juros
            double valorCaixaTexto = Convert.ToDouble(caixaTextoGride.Text);
            double valorCaixa = Convert.ToDouble(dgvSangria.CurrentRow.Cells[2].Value);

            if (valorCaixaTexto > valorCaixa)
            {
                FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Sangria maior que Caixa",
                "Valor restante caixa é: \n" + valorCaixa.ToString(),
                Properties.Resources.DialogParcial,
                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                Color.White,
                "Ok", "",
                false);
                frmCaixaCad.ShowDialog();

                dgvSangria.CurrentRow.Cells[0].Value = valorCaixa;
            }
            metodoCalculaTotais();

        }

        //-------------------------Botões
        private void btAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (objSangriaAlterada.funcionarioSangria == null)
                {

                    MessageBox.Show("Selecione o Funcionário que vai alterar a Sangria!", "Aviso Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    tbBuscarFuncionario.Focus();
                }
                else
                {
                    if (dgvSangria.RowCount > 0)
                    {
                        if (metodoValidaSangria() == true)
                        {
                            metodoAddSangriaLista();//Adiciona itens a lista da sangria
                            //Lista Sangria é maior que zero realiza o cadastro
                            if (sangriaListaAlt.Count > 0)
                            {
                                if (nSangria.AlterarSangria(sangriaListaAlt) == true)
                                {
                                    DialogResult resposta;
                                    //Criando Caixa de dialogo
                                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
                                    "Alteração Realizada com Sucesso! \r\n" +
                                    "Deseja realizar impressão comprovante?",
                                    Properties.Resources.DialogOK,
                                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                    Color.White,
                                    "Sim", "Não",
                                    false);

                                    resposta = frmCaixa.ShowDialog();
                                    if (resposta == DialogResult.Yes) { 
                                    
                                        //Imprimi o comprovante
                                        this.DialogResult = DialogResult.OK;    
                                    }
                                     
                                    this.DialogResult = DialogResult.OK;                                        
                                    this.Close();

                                }
                                else//Cadastro Erro
                                {
                                    MessageBox.Show("Erro ao alterar Sangria!", "Erro Alteração", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }


                            }
                            else//Erro Lista de Sangrias
                            {
                                MessageBox.Show("Não existem items na Sangria!", "Erro Lista", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else//Erro Validação
                        {


                            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Valores Sangria",
                            "Não existem valores para realizar a Sangria!",
                            Properties.Resources.DialogQuestion,
                            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                            Color.White,
                            "Ok", "",
                            false);
                            frmCaixa.ShowDialog();

                            btExcluir.PerformClick();
                        }


                    }//Gride Vazio
                }//Funcionário Selecionado com Sucesso
            }//Captura de EXceção

            catch (Exception ex)
            {
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro",
                "Erro ao alterar a Sangria \r\n" + ex.Message,
                Properties.Resources.DialogErro,
                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                Color.White,
                "Ok", "",
                false);

                frmCaixa.ShowDialog();
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (nSangria.AlterarSangria(sangriaListaAlt) == true)
            {
                try
                {
                    DialogResult resposta;
                    //Criando Caixa de dialogo
                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Exclusão",
                    "Exclusão deseja excluir a sangria?",
                     Properties.Resources.DialogOK,
                     System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                     Color.White,
                     "Sim", "Não",
                     false);
                    resposta = frmCaixa.ShowDialog();
                    if (resposta == DialogResult.Yes)
                    {
                        if (nSangria.ExcluirSangria(sangriaLista, objSangriaAlterada.funcionarioSangria.codigoFuncionario,objSangriaAlterada.ordemSangra) == true)
                        {

                            resposta = new DialogResult();
                            //Criando Caixa de dialogo
                            frmCaixa = new FrmCaixaDialogo("Confirmação",
                            "Alteração Realizada com Sucesso! \r\n" +
                            "Deseja realizar impressão comprovante?",
                            Properties.Resources.DialogOK,
                            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                            Color.White,
                            "Sim", "Não",
                            false);

                            resposta = frmCaixa.ShowDialog();
                            if (resposta == DialogResult.Yes)
                            {

                                //Imprimi o comprovante
                                this.DialogResult = DialogResult.Yes;
                            }
                            else
                            {

                                this.DialogResult = DialogResult.Yes;

                            }

                        }
                        else
                        {
                            MessageBox.Show("Erro ao excluir Sangria!", "Erro Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir Sangria!: "+ex.Message, "Erro Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação Sair",
            " Deseja realmente sair do Alteração de Sangria ?",
            Properties.Resources.DialogQuestion,
            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
            Color.White,
            "Sim", "Não",
            false);

            resposta = frmCaixa.ShowDialog();
            if (resposta == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Yes;
                this.Close();

            }
        }

        private void btSangriaTotal_Click(object sender, EventArgs e)
        {
            if (dgvSangria.RowCount > 0)
            {

                if (btSangriaTotal.Text == "Preencher")
                {
                    metodoPreencheAuto("total");
                    btSangriaTotal.Text = "F2 Zerar";
                    btSangriaTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                }
                else if (btSangriaTotal.Text == "F2 Zerar")
                {

                    metodoPreencheAuto("zerar");
                    btSangriaTotal.Text = "Preencher";
                    btSangriaTotal.BackColor = Color.DeepPink;

                }

                metodoCalculaTotais();
            }
        }

        private void FrmAlterarExcluirSangria_KeyDown(object sender, KeyEventArgs e)
        {
            //atalho da tecla de atalho ESC
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {
                btSair.PerformClick();
            }
            //atalho para o botão cadastrar
            else if (e.KeyCode.Equals(Keys.F10) == true)
            {
                btAlterar.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.F2) == true)
            {
                btExcluir.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.F5) == true)
            {
                btBuscar.PerformClick();
            }
        }
    }
}
