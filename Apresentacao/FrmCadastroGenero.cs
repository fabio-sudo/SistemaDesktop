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
    public partial class FrmCadastroGenero : Form
    {
        //Instaciando
        NegGenero nGenero = new NegGenero();
        Genero objGenero = new Genero();


        public FrmCadastroGenero()
        {
            InitializeComponent();
        }

        //Metodo para validar campos
        public Boolean metodoValidaCampos()
        {

            if (tbNomeGenero.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o Gênero do Produto!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNomeGenero.Clear();
                tbNomeGenero.Focus();

                return false;
            }
            else
                return true;


        }

        //Metodo para limpar os campos
        public void metodoLimpaCampos()
        {
            epGenero.Clear();
            tbNomeGenero.Clear();

        }

        //-----------------------Botões
        private void btCadastrar_Click(object sender, EventArgs e)
        {

            tbNomeGenero_Leave(null, null);
            
            //Valida se todos os campos foram preenchidos
            if (metodoValidaCampos() == true)
            {
                try
                {
                    Genero genero = new Genero();

                    genero.nomeGenero = tbNomeGenero.Text;


                    if (nGenero.CadastrarGenero(genero) == true)
                    {
                        DialogResult resposta;
                        //Criando Caixa de dialogo
                        FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
                        " Cadastro Realizado com Sucesso! \r\n" +
                        "Deseja Continuar No Cadastro De Gênero?",
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
                        tbNomeGenero.Focus();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar Gênero do Produto!", "Erro Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbNomeGenero.Focus();
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

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair do Cadastro do Gênero ?",
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

        //----------------------Validação
        private void tbNomeGenero_Leave(object sender, EventArgs e)
        {
            try
            {

            if (tbNomeGenero.Text == String.Empty)
            {
                epGenero.SetError(tbNomeGenero, "Campo obrigatório!");
                return;
            }
            else
                epGenero.Clear();

                objGenero = nGenero.ValidarCadastroGenero(tbNomeGenero.Text);
                if (objGenero != null)
                {
                    //Criando Caixa de dialogo
                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Gênero já Existe",
                    " Cód: " + objGenero.codigoGenero +
                    " Gênero: " + objGenero.nomeGenero,
                    Properties.Resources.DialogWarning,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Ok", "",
                    false);
                    frmCaixa.ShowDialog();
                    //Volta parametro para caixa de texto
                    tbNomeGenero.Clear();
                    tbNomeGenero.Focus();
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
        private void FrmCadastrarGenero_KeyDown(object sender, KeyEventArgs e)
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
