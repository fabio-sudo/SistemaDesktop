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
    public partial class FrmAlterarExcluirGrade : Form
    {
        Grade objGrade = new Grade();
        Grade gradeCorrente;
        NegGrade nGrade = new NegGrade();

        NegTamanho nTamanho = new NegTamanho();
        public TamanhoLista tamanhoLista;//Gride Tamanhos
        public TamanhoLista tamanhoListaAdd;//Gride Tamanhos Grade
        public TamanhoLista tamanhoListaAddTemp;//Guarda os registros na memória

        public Tamanho tamanhoSelecionado;
        public Tamanho tamanhoTempSelecionado;

        public FrmAlterarExcluirGrade(Grade grade)
        {
            InitializeComponent();
            this.gradeCorrente = grade;
        }


        //--------------Metodos
        public void metodoIniciaFormulario()
        {

            tbCodigo.Text = gradeCorrente.codigoGrade.ToString();
            tbGrade.Text = gradeCorrente.nomeGrade;
            metodoAtualizaGrideTemp();
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

        
        //----------------Gride
        
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

                indice++;
            }

            dgvTamanhoGrade.Update();

        }
        
        //-----------------Dados do Gride
        
        //atualiza Gride Temporário
        public void metodoAtualizaGrideTemp()
        {

            this.tamanhoListaAdd = nTamanho.BuscarGradeTamanhoPorCodigo(gradeCorrente.codigoGrade);
            AtualizarDataGridTemp();
        }

        //atualiza Gride Temporário 
        public void metodoAtualizaGride()
        {

            this.tamanhoLista = nTamanho.BuscarGradeTamanhoPorNome(tbTamanho.Text, gradeCorrente.codigoGrade);
            AtualizarDataGrid();
        }

        //------------------------Botões
        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair da Alteração e Exclusão de Grade ?",
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

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            metodoAtualizaGride();
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

        private void pbDesfazer_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Desfazer",
            " Deseja realmente desfazer alterações ?",
            Properties.Resources.DialogProcessando,
            Color.White,
            Color.Black,
            "Confirmar", "Cancelar",
            false);

            resposta = frmCaixa.ShowDialog();
            if (resposta == DialogResult.Yes)
            {
                if (nGrade.ExcluirGradeTamanhoDesfazer(gradeCorrente) == true)
                {

                    if (nGrade.CadastrarGradeTamanhoLista(gradeCorrente, tamanhoListaAddTemp) == true)
                    {
                        metodoAtualizaGride();
                        metodoIniciaFormulario();
                        epGrade.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivél desfazer as alterações !",
        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Não foi possivél limpar a tabela para desfazer as alterações !",
    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                //Valida Preenchimento chamando função
                tbGrade_Leave(null, null);

                //Validas se os campos estão preenchidos
                if (metodoValidaCampos() == true)
                {

                    DialogResult resposta;
                    //Criando Caixa de dialogo
                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Alteração",
                    " Deseja realmente Alterar os dados da Grade ?",
                    Properties.Resources.Alterar,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Confirmar", "Cancelar",
                    false);

                    //Verifica se o usuário realmente quer alterar os dados do cliente.
                    resposta = frmCaixa.ShowDialog();
                    if (resposta == DialogResult.Yes)
                    {
                        Grade gradeAlterado = new Grade();

                        gradeAlterado.codigoGrade = int.Parse(tbCodigo.Text);
                        gradeAlterado.nomeGrade = tbGrade.Text;

                        //Realizando o Cadastro
                        if (nGrade.AtualizarGrade(gradeAlterado) == true)
                        {

                            //Criando Caixa de dialogo
                            frmCaixa = new FrmCaixaDialogo("Alteração",
                            "Grade Alterada com sucesso !\r\n" +
                            "Alterações Finalizadas ?",
                            Properties.Resources.DialogOK,
                            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                            Color.White,
                            "Sim", "Não",
                            false);
                            resposta = frmCaixa.ShowDialog();

                            if (resposta == DialogResult.Yes)
                            {
                                //Retornando que exclusão foi realizada com sucesso
                                this.DialogResult = DialogResult.Yes;
                                this.Close();
                            }
                            else
                                return;

                        }
                        else
                        {
                            MessageBox.Show("Não foi possível atualizar os dados da Grade. Erro no banco de Dados!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível atualizar os dados da Grade. Motivo: " + ex.Message);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (dgvTamanhoGrade.RowCount > 0)//Exclui Tamanhos e Grades
            {
                DialogResult resposta;
                //Criando Caixa de dialogo
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Exclusão",
                " A Grade possui tamanhos deseja realmente Excluir a Grade ?",
                Properties.Resources.Excluir,
                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                Color.White,
                "Confirmar", "Cancelar",
                false);

                resposta = frmCaixa.ShowDialog();
                if (resposta == DialogResult.Yes)
                {
                    //Exclui grade e tamanhos
                    if (nGrade.ExcluirGradeTamanhoTodos(gradeCorrente) == true)
                    {
                        //Criando Caixa de dialogo
                        frmCaixa = new FrmCaixaDialogo("Exclusão",
                        " Exclusão realizada com sucesso !",
                        Properties.Resources.DialogOK,
                        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                        Color.White,
                       "Ok", "",
                        false);
                        frmCaixa.ShowDialog();
                        //Retornando que exclusão foi realizada com sucesso
                        this.DialogResult = DialogResult.Yes;
                        this.Close();
                    }
                    else
                    {

                        //Criando Caixa de dialogo
                        frmCaixa = new FrmCaixaDialogo("Exclusão",
                        "Não foi possível realizar a exclusão da Grade ! \r\n" +
                        "Grade está vinculado com Produto!",
                        Properties.Resources.DialogWarning,
                        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                        Color.White,
                        "Ok", "",
                        false);
                        frmCaixa.ShowDialog();
                        //Fecha o formulário
                        this.DialogResult = DialogResult.Cancel;
                        this.Close();
                    }
                }
            }

            else//Exclui somente a grade
            {
                DialogResult resposta;
                //Criando Caixa de dialogo
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Exclusão",
                " Deseja realmente Excluir a Grade ?",
                Properties.Resources.Excluir,
                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                Color.White,
                "Confirmar", "Cancelar",
                false);

                resposta = frmCaixa.ShowDialog();
                if (resposta == DialogResult.Yes)
                {
                    if (nGrade.ExcluirGrade(gradeCorrente) == true)
                    {
                        //Criando Caixa de dialogo
                        frmCaixa = new FrmCaixaDialogo("Exclusão",
                        " Exclusão realizada com sucesso !",
                        Properties.Resources.DialogOK,
                        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                        Color.White,
                       "Ok", "",
                        false);
                        frmCaixa.ShowDialog();
                        //Retornando que exclusão foi realizada com sucesso
                        this.DialogResult = DialogResult.Yes;
                        this.Close();
                    }
                    else
                    {

                        //Criando Caixa de dialogo
                        frmCaixa = new FrmCaixaDialogo("Exclusão",
                        "Não foi possível realizar a exclusão da Grade ! \r\n" +
                        "Grade está vinculado com Produto!",
                        Properties.Resources.DialogWarning,
                        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                        Color.White,
                        "Ok", "",
                        false);
                        frmCaixa.ShowDialog();
                        //Fecha o formulário
                        this.DialogResult = DialogResult.Cancel;
                        this.Close();
                    }
                }
            }



        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTamanho.RowCount > 0)
                {
                    int indiceRegistroSelecionado = Convert.ToInt32(dgvTamanho.CurrentRow.Cells[0].Value);
                    foreach (Tamanho tam in tamanhoLista)
                    {
                        if (tam.codigoTamanho == indiceRegistroSelecionado)
                        {

                            tamanhoSelecionado = tam;
                            nGrade.CadastrarGradeTamanho(gradeCorrente, tamanhoSelecionado);

                        }
                    }
                }

                metodoAtualizaGrideTemp();
                metodoAtualizaGride();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro ao Adicionar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbTamanho.Focus();
                return;
            }
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTamanhoGrade.RowCount == 1)
                {
                    btExcluir.PerformClick();

                }
                else
                {
                    int indiceRegistroSelecionado = Convert.ToInt32(dgvTamanhoGrade.CurrentRow.Cells[0].Value);
                    foreach (Tamanho tam in tamanhoListaAdd)
                    {
                        if (tam.codigoTamanho == indiceRegistroSelecionado)
                        {

                            tamanhoTempSelecionado = tam;
                            break;

                        }
                    }


                    Produto validaExclusao = new Produto();
                    validaExclusao = nGrade.ValidaExclusaoGrade(gradeCorrente.codigoGrade);
                    if (validaExclusao == null)
                    {
                        if (nGrade.ExcluirGradeTamanho(gradeCorrente, tamanhoTempSelecionado) == true)
                        {

                        }
                        else
                        {

                            FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Erro ao Excluir o tamanho da Grade",
                            "Não foi possível excluir a Grade: \n" + gradeCorrente.nomeGrade,
                            Properties.Resources.DialogErro,
                            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                            Color.White,
                            "Ok", "",
                             false);                          
                        }
                    }else{
                    
                             FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Erro ao Excluir o tamanho da Grade",
                            "Grade Está vinculada ao Produto: \n" + validaExclusao.codigoProduto+"\n"+
                            "Descrição: "+validaExclusao.descricaoProduto,
                            Properties.Resources.DialogErro,
                            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                            Color.White,
                            "Ok", "",
                            false);
                            frmCaixaCad.ShowDialog();                   
                    }

                    metodoAtualizaGrideTemp();
                    metodoAtualizaGride();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro ao Remover", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbTamanho.Focus();
                return;
            }
        }

        //-----------------------Inicia Formulário
        private void FrmAlterarExcluirGrade_Load(object sender, EventArgs e)
        {
            metodoIniciaFormulario();
            tamanhoListaAddTemp = tamanhoListaAdd;
        }

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



                //Verifica se o valor digitado não é o mesmo que esta no objto
                if (tbGrade.Text != gradeCorrente.nomeGrade)
                {
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

        private void FrmAlterarExcluirGrade_KeyDown(object sender, KeyEventArgs e)
        {
            //atalho da tecla de atalho ESC
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {

                btSair.PerformClick();

            }
            else if (e.KeyCode.Equals(Keys.F2) == true)
            {
                btExcluir.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.F10) == true)
            {
                btAlterar.PerformClick();
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
                pbBuscar_Click(null, null);
            }
        }
       
        //---------------------------DataGride

        private void dgvTamanho_DoubleClick(object sender, EventArgs e)
        {
            btAdicionar.PerformClick();
        }

        private void dgvTamanhoGrade_DoubleClick(object sender, EventArgs e)
        {
            btRemover.PerformClick();
        }

    }
}
