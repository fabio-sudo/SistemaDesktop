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
    public partial class FrmCadastroTamanho : Form
    {
        //Instaciando
        NegTamanho nTamanho = new NegTamanho();
        Tamanho objTamanho = new Tamanho();

        public FrmCadastroTamanho()
        {
            InitializeComponent();
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

        //Metodo para limpar os campos
        public void metodoLimpaCampos()
        {
            epTamanho.Clear();
            tbTamanho.Clear();

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair do Cadastro de Tamanho ?",
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

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            tbTamanho_Leave(null,null);
            
            //Valida se todos os campos foram preenchidos
            if (metodoValidaCampos() == true)
            {
                try
                {


                    Tamanho tamanho = new Tamanho();

                    tamanho.nometamanho = tbTamanho.Text;


                    if (nTamanho.CadastrarTamanho(tamanho) == true)
                    {
                        DialogResult resposta;
                        //Criando Caixa de dialogo
                        FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
                        " Cadastro Realizado com Sucesso! \r\n" +
                        "Deseja Continuar No Cadastro De Tamanho?",
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
                        tbTamanho.Focus();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar Tamanho do Produto!", "Erro Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbTamanho.Focus();
                        return;
                    }

                }

                catch (Exception ex)
                {
                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro",
                    "Erro ao cadastrar Gênero \r\n" + ex.Message,
                    Properties.Resources.DialogErro,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Ok", "",
                    false);

                    frmCaixa.ShowDialog();
                }
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

        private void FrmCadastroTamanho_KeyDown(object sender, KeyEventArgs e)
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
        }


    }
}
