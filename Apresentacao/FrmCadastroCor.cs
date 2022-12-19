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
    public partial class FrmCadastroCor : Form
    {
        //Instaciando
        NegCor nCor = new NegCor();
        Cor objCor = new Cor();

        public FrmCadastroCor()
        {
            InitializeComponent();
        }

        //Metodo para validar campos
        public Boolean metodoValidaCampos()
        {

            if (tbNomeCor.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe a Cor do Produto!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNomeCor.Clear();
                tbNomeCor.Focus();

                return false;
            }
            else
                return true;


        }

        //Metodo para limpar os campos
        public void metodoLimpaCampos()
        {
            epCor.Clear();
            tbNomeCor.Clear();

        }

        //Botão Sair
        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair do Cadastro de Cor ?",
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

        //Botão Cadastrar
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            tbNomeCor_Leave(null, null);

            //Valida se todos os campos foram preenchidos
            if (metodoValidaCampos() == true)
            {
                try
                {
                    Cor cor = new Cor();

                    cor.nomeCor = tbNomeCor.Text;


                    if (nCor.CadastrarCor(cor) == true)
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
                            this.DialogResult = DialogResult.OK;
                            this.Close();

                        }
                        else
                        metodoLimpaCampos();
                        tbNomeCor.Focus();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar a Cor do Produto!", "Erro Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbNomeCor.Focus();
                        return;
                    }

                }

                catch (Exception ex)
                {
                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro",
                    "Erro ao cadastrar a Cor \r\n" + ex.Message,
                    Properties.Resources.DialogErro,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Ok", "",
                    false);

                    frmCaixa.ShowDialog();
                }
            }
        }

        //Verifica se o campo ja foi preenchido ou já existe dados iguais do produto
        private void tbNomeCor_Leave(object sender, EventArgs e)
        {
            try
            {

                if (tbNomeCor.Text == String.Empty)
                {
                    epCor.SetError(tbNomeCor, "Campo obrigatório!");
                    return;
                }
                else
                    epCor.Clear();

                objCor = nCor.ValidarCadastroCor(tbNomeCor.Text);
                if (objCor != null)
                {
                    //Criando Caixa de dialogo
                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Cor já Existe",
                    " Cód: " + objCor.codigoCor +
                    " Gênero: " + objCor.nomeCor,
                    Properties.Resources.DialogWarning,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Ok", "",
                    false);
                    frmCaixa.ShowDialog();
                    //Volta parametro para caixa de texto
                    tbNomeCor.Clear();
                    tbNomeCor.Focus();
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

        //--------------------------Atalhos
        private void FrmCadastroCor_KeyDown(object sender, KeyEventArgs e)
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
