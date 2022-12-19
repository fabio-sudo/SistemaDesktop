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
    public partial class FrmCadastroGrade : Form
    {
        NegGrade nGrade = new NegGrade();
        Grade objGrade = new Grade();
        
        NegTamanho nTamanho = new NegTamanho();
        public TamanhoLista tamanhoLista;
        public TamanhoLista tamanhoListaAdd;
        public Tamanho tamanhoSelecionado;
        public Tamanho tamanhoTempSelecionado;
        //ORDEM PARA ACessos Simultaneos
        int ordemBuscar = 0;

        public FrmCadastroGrade()
        {
            InitializeComponent();
        }

        //Metodo para validar campos
        public Boolean metodoValidaCampos()
        {

            if (tbGrade.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe a Grade do Produto!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbGrade.Clear();
                tbGrade.Focus();

                return false;
            }
            if (dgvTamanhoGrade.RowCount == 0)
            {
                MessageBox.Show("Informe os Tamanhos da Grade!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbTamanho.Focus();

                return false;
            }
            else
                return true;


        }

        //Metodo para limpar os campos
        public void metodoLimpaCampos()
        {
            epGrade.Clear();
            tbGrade.Clear();
            btLimpar.PerformClick();
            dgvTamanho.Rows.Clear();

        }


        //atualiza os valores no Data Grid
        private void AtualizarDataGrid()
        {
            this.dgvTamanho.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.tamanhoLista.Count > 0)
            {
                this.dgvTamanho.Rows.Add(this.tamanhoLista.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (Tamanho tam in this.tamanhoLista)
            {
                this.dgvTamanho[0, indice].Value = tam.codigoTamanho;
                this.dgvTamanho[1, indice].Value = tam.nometamanho;

                indice++;
            }

            dgvTamanho.Update();

        }

        //atualiza os valores no Data Grid
        private void AtualizarDataGridTemp()
        {
            this.dgvTamanhoGrade.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.tamanhoListaAdd.Count > 0)
            {
                this.dgvTamanhoGrade.Rows.Add(this.tamanhoListaAdd.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (Tamanho tam in this.tamanhoListaAdd)
            {
                this.dgvTamanhoGrade[0, indice].Value = tam.codigoTamanho;
                this.dgvTamanhoGrade[1, indice].Value = tam.nometamanho;
                this.dgvTamanhoGrade[2, indice].Value = tam.ordemtamanho;
                indice++;
            }

            dgvTamanhoGrade.Update();

        }

        //atualiza Gride Temporário
        public void metodoAtualizaGrideTemp()
        {

            this.tamanhoListaAdd = nTamanho.BuscarTamanhoTemp(ordemBuscar);
            AtualizarDataGridTemp();
        }

        //atualiza Gride 
        public void metodoAtualizaGride()
        {

            this.tamanhoLista = nTamanho.BuscarTamanhoTempPorNome(tbTamanho.Text, ordemBuscar);
            AtualizarDataGrid();
        }

        //Busca Tamanhos para adicionar na grade
        private void pbBuscar_Click(object sender, EventArgs e)
        {
            if (dgvTamanhoGrade.Rows.Count > 0)
            {
                ordemBuscar = Convert.ToInt32(dgvTamanhoGrade.CurrentRow.Cells[2].Value);
            }
            else {
                ordemBuscar = nTamanho.BuscarUltimoRegistroTamanho() + 1;
            }
            this.tamanhoLista = nTamanho.BuscarTamanhoTempPorNome(tbTamanho.Text, ordemBuscar);
            AtualizarDataGrid();
        }

        private void tbTamanho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbBuscar_Click(null,null);
                e.Handled = true;
            }
        }

        private void pbTamanho_Click(object sender, EventArgs e)
        {
            DialogResult resultado;

            FrmSelecionarTamanho frmTamanho = new FrmSelecionarTamanho();
            resultado = frmTamanho.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                this.tbTamanho.Text = frmTamanho.tamanhoSelecionado.nometamanho;
                pbBuscar_Click(null, null);
            }
        }

        //------------------------Botões
        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair do Cadastro de Grade ?",
            Properties.Resources.DialogQuestion,
            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
            Color.White,
            "Sim", "Não",
            false);

            resposta = frmCaixa.ShowDialog();
            if (resposta == DialogResult.Yes)
            {
                btLimpar.PerformClick();
                this.Close();

            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            tbGrade_Leave(null, null);

            //Valida se todos os campos foram preenchidos
            if (metodoValidaCampos() == true)
            {
                try
                {
                    Grade grade = new Grade();
                    grade.codigoGrade = nGrade.BuscarUltimoRegistroGrade() + 1;
                    grade.nomeGrade = tbGrade.Text;

                    if (nGrade.CadastrarGrade(grade) == true)
                    {

                        if (nGrade.CadastrarGradeTamanhoLista(grade, tamanhoListaAdd) == true) {

                            DialogResult resposta;
                            //Criando Caixa de dialogo
                            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
                            " Cadastro Realizado com Sucesso! \r\n" +
                            "Deseja Continuar No Cadastro De Grade?",
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
                            tbGrade.Focus();
                            return;
                        
                        }               

                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar Grade do Produto!", "Erro Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbGrade.Focus();
                        return;
                    }    
                        
                     }

                catch (Exception ex)
                {
                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro",
                    "Erro ao cadastrar Grade \r\n" + ex.Message,
                    Properties.Resources.DialogErro,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Ok", "",
                    false);

                    frmCaixa.ShowDialog();
                }   
                        
                        
            }
        }            
                                          
        private void btAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTamanho.RowCount > 0)
                {
                    int codigoTamanhoSelecionado = Convert.ToInt32(dgvTamanho.CurrentRow.Cells[0].Value);
                    string nomeTamanhoSelecionado = dgvTamanho.CurrentRow.Cells[1].Value.ToString();
                    int ordemTamanhoSelecionado = ordemBuscar;
                    
                    tamanhoSelecionado = new Tamanho();
                    tamanhoSelecionado.codigoTamanho = codigoTamanhoSelecionado;
                    tamanhoSelecionado.nometamanho = nomeTamanhoSelecionado;
                    tamanhoSelecionado.ordemtamanho = ordemTamanhoSelecionado;

                    nTamanho.CadastrarTamanhoTemp(tamanhoSelecionado);
                 
                }

                metodoAtualizaGrideTemp();
                metodoAtualizaGride();
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message, "Erro ao Adicionar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbTamanho.Focus();
                return;
            }
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTamanhoGrade.RowCount == 0)
                {
                    MessageBox.Show("Não é possivel remover, não há itens do gride!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    int codigoTamanhoSelecionadoTemp = Convert.ToInt32(dgvTamanhoGrade.CurrentRow.Cells[0].Value);
                    string nomeTamanhoSelecionadoTemp = dgvTamanhoGrade.CurrentRow.Cells[1].Value.ToString();

                    tamanhoTempSelecionado = new Tamanho();
                    tamanhoTempSelecionado.codigoTamanho = codigoTamanhoSelecionadoTemp;
                    tamanhoTempSelecionado.nometamanho = nomeTamanhoSelecionadoTemp;             

                    if (nTamanho.ExcluirTamanhoTemp(tamanhoTempSelecionado) == false)
                    {
                        MessageBox.Show("Não foi possivel remover o Tamanho?", "Erro",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    }
                    else
                    {

                        metodoAtualizaGrideTemp();
                        metodoAtualizaGride();

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro ao Remover", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbTamanho.Focus();
                return;
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTamanhoGrade.Rows.Count > 0)
                {
                    ordemBuscar = Convert.ToInt32(dgvTamanhoGrade.CurrentRow.Cells[2].Value);
                }
                else
                {
                    ordemBuscar = nTamanho.BuscarUltimoRegistroTamanho() + 1;
                }


                if (dgvTamanhoGrade.RowCount > 0)
                {
                    nTamanho.ExcluirDadosTabelaTemporaria(ordemBuscar);
                    metodoAtualizaGrideTemp();
                    metodoAtualizaGride();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro ao Limpar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbTamanho.Focus();
                return;
            }
        }

        //Reliza metodo adicionar
        private void dgvTamanho_DoubleClick(object sender, EventArgs e)
        {
            btAdicionar.PerformClick();
        }

        //Realiza o metodo remover
        private void dgvTamanhoGrade_DoubleClick(object sender, EventArgs e)
        {
            btRemover.PerformClick();
        }

        //Valida Grade já existe
        private void tbGrade_Leave(object sender, EventArgs e)
        {
            try
            {

                if (tbGrade.Text == String.Empty)
                {
                    epGrade.SetError(tbGrade, "Campo obrigatório!");
                    return;
                }
                else
                    epGrade.Clear();

                objGrade = nGrade.ValidarCadastroGrade(tbGrade.Text);
                if (objGrade != null)
                {
                    //Criando Caixa de dialogo
                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Grade já Existe",
                    " Cód: " + objGrade.codigoGrade +
                    " Grade: " + objGrade.nomeGrade,
                    Properties.Resources.DialogWarning,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Ok", "",
                    false);
                    frmCaixa.ShowDialog();
                    //Volta parametro para caixa de texto
                    tbGrade.Clear();
                    tbGrade.Focus();
                }

            }
            catch (Exception ex)
            {
                //Criando Caixa de dialogo
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro",
                ex.Message,
                Properties.Resources.DialogErro,
                Color.White,
                Color.Black,
                "Ok", "",
                false);
                frmCaixa.ShowDialog();
            }
        }

        //Teclas de Atalho
        private void FrmCadastroGrade_KeyDown(object sender, KeyEventArgs e)
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
            else if (e.KeyCode.Equals(Keys.F6) == true)
            {
                btRemover.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.F12) == true)
            {
                btAdicionar.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.F5) == true)
            {
                pbBuscar_Click(null,null);
            }
        }

        //Limpa Tabela temporária quando formulário e fechado
        private void FrmCadastroGrade_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dgvTamanhoGrade.RowCount > 0)
            {
                btLimpar.PerformClick();
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

    }
}
