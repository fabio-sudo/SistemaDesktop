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
    public partial class FrmAlterarExcluirTamanho : Form
    {
        Tamanho objTamanho = new Tamanho();
        Tamanho tamanhoCorrente;
        NegTamanho nTamanho = new NegTamanho();

        public FrmAlterarExcluirTamanho(Tamanho tamanho)
        {
            InitializeComponent();
            this.tamanhoCorrente = tamanho;
        }

        //--------------Metodos
        public void metodoIniciaFormulario()
        {

            tbCodigo.Text = tamanhoCorrente.codigoTamanho.ToString();
            tbTamanho.Text = tamanhoCorrente.nometamanho;

        }

        //Metodo para validar campos
        public Boolean metodoValidaCampos()
        {

            if (tbTamanho.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o Tamanho do Produto!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbTamanho.Clear();
                tbTamanho.Focus();

                return false;
            }
            else
                return true;


        }


        //------------------Botões
        private void btAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                //Valida Preenchimento chamando função
                tbTamanho_Leave(null, null);

                //Validas se os campos estão preenchidos
                if (metodoValidaCampos() == true)
                {

                    DialogResult resposta;
                    //Criando Caixa de dialogo
                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Alteração",
                    " Deseja realmente Alterar os dados do Tamanho ?",
                    Properties.Resources.Alterar,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Confirmar", "Cancelar",
                    false);

                    //Verifica se o usuário realmente quer alterar os dados do cliente.
                    resposta = frmCaixa.ShowDialog();
                    if (resposta == DialogResult.Yes)
                    {
                        Tamanho tamanhoAlterado = new Tamanho();

                        tamanhoAlterado.codigoTamanho = int.Parse(tbCodigo.Text);
                        tamanhoAlterado.nometamanho = tbTamanho.Text;

                        //Realizando o Cadastro
                        if (nTamanho.AtualizarTamanho(tamanhoAlterado) == true)
                        {

                            //Criando Caixa de dialogo
                            frmCaixa = new FrmCaixaDialogo("Alteração",
                            "Tamanho Alterado com sucesso !\r\n" +
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
                            MessageBox.Show("Não foi possível atualizar os dados do Tamanho. Erro no banco de Dados!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível atualizar os dados do Tamanho. Motivo: " + ex.Message);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Exclusão",
            " Deseja realmente Excluir o Tamanho ?",
            Properties.Resources.Excluir,
            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
            Color.White,
            "Confirmar", "Cancelar",
            false);

            resposta = frmCaixa.ShowDialog();
            if (resposta == DialogResult.Yes)
            {
                if (nTamanho.ExcluirTamanho(tamanhoCorrente) == true)
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
                    "Não foi possível realizar a exclusão do Tamanho! \r\n" +
                    "Tamanho está vinculado com Grade do Produto!",
                    Properties.Resources.DialogWarning,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Ok", "",
                    true);
                    frmCaixa.ShowDialog();
                    //Fecha o formulário
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair do Alteração & Exclusão de Tamanho ?",
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
                metodoIniciaFormulario();
                epTamanho.Clear();

            }
        }

        private void tbTamanho_Leave(object sender, EventArgs e)
        {
            try
            {
                    if (tbTamanho.Text == String.Empty)
                    {
                        epTamanho.SetError(tbTamanho, "Campo obrigatório!");
                        return;
                    }
                    else
                        epTamanho.Clear();

                    if (tbTamanho.Text != tamanhoCorrente.nometamanho)
                    {
                        objTamanho = nTamanho.ValidarCadastroTamanho(tbTamanho.Text);
                        if (objTamanho != null)
                        {
                            //Criando Caixa de dialogo
                            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Tamanho já Existe",
                            " Cód: " + objTamanho.codigoTamanho +
                            " Tamanho: " + objTamanho.nometamanho,
                            Properties.Resources.DialogWarning,
                            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                            Color.White,
                            "Ok", "",
                            false);
                            frmCaixa.ShowDialog();
                            //Volta parametro para caixa de texto
                            tbTamanho.Clear();
                            tbTamanho.Focus();
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

        private void FrmAlterarExcluirTamanho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {
                btSair.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F2) == true)
            {
                btExcluir.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F10) == true)
            {
                btAlterar.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F5) == true)
            {
                pbDesfazer_Click(null, null);
            }
        }

        private void FrmAlterarExcluirTamanho_Load(object sender, EventArgs e)
        {
            metodoIniciaFormulario();
        }
        

    }
}
