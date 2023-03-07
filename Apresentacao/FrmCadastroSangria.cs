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
    public partial class FrmCadastroSangria : Form
    {
        Sangria objSangria = new Sangria();
        SangriaLista sangriaLista = new SangriaLista();//Lista para preencher o gride
        SangriaLista sangriaListaCad = new SangriaLista();//Lista para cadastrar
        NegSangria nSangria = new NegSangria();

        ListaFormaPagamento listaFormaPagamento = new ListaFormaPagamento();
        NegFormaPagamento nFormaPagamento = new NegFormaPagamento();

        NegFuncionario nFuncionario = new NegFuncionario();
        //-----------------Metodos
        Metodos metodos = new Metodos();

        //Objetos Gride
        TextBox caixaTextoGride;


        public FrmCadastroSangria()
        {
            InitializeComponent();
        }


        private void metodoPreencheDespesa() {

            ListaDespesas listaDespesas = new ListaDespesas();
            NegDespesa nDespesa = new NegDespesa();

            listaDespesas = nDespesa.BuscarDespesaPorData(dtpDataSangria.Value, dtpDataSangria.Value);

            if (listaDespesas.Count > 0)
            {
                //Adiciona valor da Despesas ja cadastradas na sangria
                foreach (DespesaCaixa despesa in listaDespesas)
                {

                    foreach (Sangria sangria in sangriaLista)
                    {

                        if (despesa.formaPagamento.formaPagamento == sangria.pagamentoSangria.formaPagamento)
                        {

                            sangria.despesaSangria = - despesa.valorDespesa;
                            break;
                        }
                    }
                }

            }
        
        
        
        }

        //atualiza os valores no Data Grid
        private void AtualizarDataGrid()
        {
            this.dgvSangria.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.sangriaLista.Count > 0)
            {
                this.dgvSangria.Rows.Add(this.sangriaLista.Count);
                metodoPreencheDespesa();
            }
            else
            {
                return;
            }
   

            int indice = 0;
            foreach (Sangria sang in this.sangriaLista)
            {
                this.dgvSangria[0, indice].Value = 0;//Valor será lançado
                if (sang.retiradaSangria <= 0) { sang.retiradaSangria = 0; }
                this.dgvSangria[1, indice].Value = sang.retiradaSangria;//Valor de lançamento ja realizados no dia 
                this.dgvSangria[2, indice].Value = sang.valorSangria - sang.retiradaSangria + sang.despesaSangria - sang.estornoSangria;//Valor do Caixa
                this.dgvSangria[3, indice].Value = sang.pagamentoSangria.codigoFormaPagamento;               
                this.dgvSangria[4, indice].Value = sang.pagamentoSangria.formaPagamento;
                this.dgvSangria[5, indice].Value = sang.descontoItem;
                this.dgvSangria[6, indice].Value = sang.JurosItem;
                this.dgvSangria[7, indice].Value = 0;//Caso haja estorno no caixa
                this.dgvSangria[9, indice].Value = sang.despesaSangria;//DespesaCaixa
                this.dgvSangria[8, indice].Value = sang.ordemSangra;//Contador

                indice++;
            }
            dgvSangria.Update();

        }

        private void metodoZerarForm() {
            lbCaixaTotal.Text = "+ " + String.Format("{0:C2}", (0));
            lbSangriaTotal.Text = "-" + String.Format("{0:C2}", 0);
            lbTotalEstorno.Text = "- " + String.Format("{0:C2}", 0);
            lbTaxa.Text = "% " + String.Format("{0:C2}", 0);
            lbDesconto.Text = "- " + String.Format("{0:C2}", 0);
            lbCaixaRestante.Text = "+ " + String.Format("{0:C2}", 0);      
        
        }

        //Adiciona valores da retirada na sangria
        private SangriaLista PreencheValoresRetiradaSangria(SangriaLista lista) {

            SangriaLista sangriaListaRetiradaNew = nSangria.BuscarSangriaRetirada(dtpDataSangria.Value);
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
        private void metodoIniciaFormulario() {

           
            sangriaLista = PreencheValoresRetiradaSangria(nSangria.BuscarSangriaValores(dtpDataSangria.Value));                
            metodoPreencheCombobox();
            AtualizarDataGrid();
            metodoCalculaTotais();
            tbBuscarFuncionario.Focus();
        }

        //Calcula Totais
        private void metodoCalculaTotais() { 
            
            //Caixa
            double jurosSangria = 0;
            double descontoSangria = 0;
            double valorCaixaSangria = 0;
            double valorSangria = 0;
            double valorCaixaSangriaAnterior = 0;
            double valorEstornoCaixa = 0;
            double despesaCaixa = 0;
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
                despesaCaixa = despesaCaixa + Convert.ToDouble(col.Cells[9].Value)+0;
            }
                //-----------Venda
            lbCaixaTotal.Text = "+ " + String.Format("{0:C2}", (valorCaixaSangria + valorCaixaSangriaAnterior));
            lbSangriaTotal.Text = "-" + String.Format("{0:C2}", valorSangria);
            lbTotalEstorno.Text = "- " + String.Format("{0:C2}", valorEstornoCaixa);
            lbTotalDespesas.Text = " " + String.Format("{0:C2}", (despesaCaixa));
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

            sangriaListaCad = new SangriaLista();

            foreach (DataGridViewRow col in dgvSangria.Rows)
            {
                Sangria newSangria = new Sangria();
                newSangria.pagamentoSangria = new FormaPagamento();
                newSangria.funcionarioSangria = new Funcionario();

                newSangria.valorSangria = Convert.ToDouble(col.Cells[0].Value);
                newSangria.pagamentoSangria.codigoFormaPagamento = Convert.ToInt32(col.Cells[3].Value);
                newSangria.pagamentoSangria.formaPagamento = (col.Cells[4].Value).ToString();
                newSangria.funcionarioSangria = objSangria.funcionarioSangria;
                newSangria.descontoItem = Convert.ToDouble(col.Cells[5].Value);
                newSangria.JurosItem = Convert.ToDouble(col.Cells[6].Value);
                newSangria.dataSangria = DateTime.Now;
                newSangria.ordemSangra = Convert.ToInt32(col.Cells[8].Value);

                if (newSangria.valorSangria > 0)//Só adiciona valores lançados
                {
                    sangriaListaCad.Add(newSangria);
                }
            }
        }

        //Preeche sangria com total do caixa
        private void metodoPreencheAuto(string preencher) {

            if (preencher == "total") { 
            foreach (DataGridViewRow col in dgvSangria.Rows)
            {
            
            col.Cells[0].Value = col.Cells[2].Value;
            }            
               }else if(preencher == "zerar"){      
                  foreach (DataGridViewRow col in dgvSangria.Rows)
                      {
            
                          col.Cells[0].Value = 0;
                        }
              }    
        }

        
        //-----------------------Botões
        private void btCadastrar_Click(object sender, EventArgs e)
        {
          try
            {
                if (objSangria.funcionarioSangria == null)
                {

                    MessageBox.Show("Selecione o Funcionário que vai gerar a Sangria!", "Aviso Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                            if (sangriaListaCad.Count > 0)
                            {
                                if (nSangria.CadastrarSangria(sangriaListaCad) == true)
                                {
                                    DialogResult resposta;
                                    //Criando Caixa de dialogo
                                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
                                    " Cadastro Realizado com Sucesso! \r\n" +
                                    "Deseja Continuar No Cadastro De Cor?",
                                    Properties.Resources.DialogOK,
                                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                    Color.White,
                                    "Sim", "Não",
                                    false);

                                    resposta = frmCaixa.ShowDialog();
                                    if (resposta != DialogResult.Yes)
                                    {
                                        metodoIniciaFormulario();
                                        this.DialogResult = DialogResult.OK;
                                        this.Close();

                                    }
                                    else
                                        metodoIniciaFormulario();
                                        metodoZerarForm();
                                    return;
                                }
                                else//Cadastro Erro
                                {
                                    MessageBox.Show("Erro ao cadastrar Sangria!", "Erro Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        }


                    }//Gride Vazio
                }//Funcionário Selecionado com Sucesso
         }//Captura de EXceção

                catch (Exception ex)
                {
                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro",
                    "Erro ao cadastrar a Sangria \r\n" + ex.Message,
                    Properties.Resources.DialogErro,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Ok", "",
                    false);

                    frmCaixa.ShowDialog();
                }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            int n;
            bool ehUmNumero = int.TryParse(tbBuscarFuncionario.Text, out n);
            if (ehUmNumero == true)
            {
                objSangria.funcionarioSangria = nFuncionario.BuscarFuncionarioPorCodigo(n);
                if (objSangria.funcionarioSangria != null)
                {
                    this.tbBuscarFuncionario.Text = objSangria.funcionarioSangria.nomeFuncionario; ;
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

                    this.objSangria.funcionarioSangria = frmSelecionarFuncionario.FuncionarioSelecionado;
                    this.tbBuscarFuncionario.Text = objSangria.funcionarioSangria.nomeFuncionario;
                    dgvSangria.Focus();
                }

            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {

            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação Sair",
            " Deseja realmente sair do Lançamento de Sangria ?",
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
            if(dgvSangria.RowCount > 0){

                if (btSangriaTotal.Text == "F2 Preencher")
                {
                    metodoPreencheAuto("total");
                    btSangriaTotal.Text = "F2 Zerar";
                    btSangriaTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                }
                else if (btSangriaTotal.Text == "F2 Zerar") {
                    
                    metodoPreencheAuto("zerar");
                    btSangriaTotal.Text = "F2 Preencher";
                    btSangriaTotal.BackColor = Color.DeepPink;
                
                }

                metodoCalculaTotais();
            }
        }

        //-----------------------Data Gride
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

        //---------------------Caixa de Texto Funcionario
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

        //-----------------------Formulario
        private void FrmCadastrarSangria_Load(object sender, EventArgs e)
        {
            //Pega no formulario da venda o UsuarioLogado
            if (FrmMenuPrincipal.userLogado != null)
            {
                objSangria.funcionarioSangria = FrmMenuPrincipal.userLogado;
                tbBuscarFuncionario.Text = objSangria.funcionarioSangria.nomeFuncionario;
            }

            metodoIniciaFormulario();
            metodoCalculaTotais();
        }

        private void FrmCadastroSangria_KeyDown(object sender, KeyEventArgs e)
        {
            //atalho da tecla de atalho ESC
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {
                btSair.PerformClick();
            }
            //atalho para o botão cadastrar
            else if (e.KeyCode.Equals(Keys.F10) == true)
            {
                btCadastrar.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.F2) == true)
            {
                btSangriaTotal.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.F5) == true)
            {
                btBuscar.PerformClick();
            }

        }



    }
}
