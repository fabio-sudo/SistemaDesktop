using AcessoDados;
using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmMenuPrincipal : Form
    {
        //Usuariologado
        public static Funcionario userLogado;
        //Fields
        private Button currentButton;
        public Form activeForm;

        //Construtor
        public FrmMenuPrincipal()
        {
            InitializeComponent();

        }

        public void chamaFormularioEstoque(object obj) {
            
            OpenChildForm(new FrmEstoque(), obj);
        }

        //methods para escolher cor do menu
        private Color SelectThemeColor()
        {
            string color = "#ff1493";
            return ColorTranslator.FromHtml(color);
        }

        //Muda Cor Menus
        private void ActivateButton(object btnSender)
        {

            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    //Botão fechar começa formulario come fechado
                    btFechar.Visible = true;
                    EsconderMenu();
                }
            }
        }

        //Default color menu
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
                if (previousBtn.GetType() == typeof(Button))
                {

                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
        }

        //Abrir formulario no painel
        public void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {

                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbTitulo.Text = childForm.Text;
            childForm.Focus();
        }

        //Voltar ao formulario principal
        private void Reset()
        {
            DisableButton();
            lbTitulo.Text = "";
            currentButton = null;
            btFechar.Visible = false;
            MostrarMenu();
        }

        //Esconder e mostrar menus
        private void EsconderMenu() {
            if (btHome.Text != (""))
            {
                this.panelMenu.Size = new System.Drawing.Size(72, 742);
                //Remove o Texto
                btHome.Text = "";
                btCliente.Text = "";
                btFuncionario.Text = "";
                btFornecedor.Text = "";
                btProduto.Text = "";
                btEstoque.Text = "";
                btVenda.Text = "";
                btCrediario.Text = "";
                btUsuarioSenha.Text = "";
                btRelatorio.Text = "";
                btBackup.Text = "";
                btSair.Text = "";
                //Alinha Icones
                btHome.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            }
        }

        private void MostrarMenu()
        {
            this.panelMenu.Size = new System.Drawing.Size(167, 742);
            //Remove o Texto
            btHome.Text = " Trevezane Software";
            btCliente.Text = " Cliente";
            btFuncionario.Text = " Funcionario";
            btFornecedor.Text = " Fornecedor";
            btProduto.Text = " Produto";
            btEstoque.Text = " Estoque";
            btVenda.Text = " Venda";
            btCrediario.Text = " Crediario";
            btUsuarioSenha.Text = " Usuario E Senha";
            btRelatorio.Text = " Relatorio";
            btBackup.Text = " Backup";
            btSair.Text = " Sair";
            //Alinha Icones
            btHome.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
        }

        //Metodo Fechar formulario Painel
        public void metodoFechar() {

            if (activeForm != null)
                activeForm.Close();
            Reset();
        
        }

        public void metodoMudaTextoLabel(string strTitulo) {

            this.lbTitulo.Text = strTitulo;
        }
    
        //-------------------------------Menus

        //Metodo Clicar Botão Cliente
        private void btCliente_Click(object sender, EventArgs e)
        {

           OpenChildForm(new FrmCliente(), sender);

        }

        //Metodo Clicar Botão Funcionario
        private void btFuncionario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmFuncionario(), sender);
        }

        //Metodo Clicar Botão Fornecedor
        private void btFornecedor_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmFornecedor(), sender);
        }

        //Metodo Clicar Botão Produto
        public void btProduto_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmProduto(), sender);
        }

        //Metodo Clicar Botão Estoque
        private void btEstoque_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmEstoque(), sender);
        }

        //Metodo Clicar Botão Venda
        private void btVenda_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmCaixa(), sender);
        }

        //Metodo Clicar Botão Crediario
        private void btCrediario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmCrediario(), sender);
        }

        //Metodo Clicar Botão Usuario e Senha
        private void btUsuarioSenha_Click(object sender, EventArgs e)
        {
            //Passa o usuário que está logado no sistema
            OpenChildForm(new FrmUsuario(), sender);
        }

        //Metodo Clicar Botão Relatórios
        private void btRelatorio_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmCancelamento(""), sender);
        }

        //Metodo Clicar Botão Backup
        private void btBackup_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {

                activeForm.Close();
            }
            ActivateButton(sender);
            lbTitulo.Text = "Backup";
            FrmBackup frmBackup = new FrmBackup();
            frmBackup.ShowDialog();

            Reset();

        }

        //Metodo Clicar Botão Sair -> Perguntar se deseja fazer logoof
        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair do Menu Principal ?",
            Properties.Resources.logoPng, 
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

        //Botão Fechar
        private void btFechar_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
                Reset();

        }

        //Botão Home
        private void btHome_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
                Reset();

        }


        //Atalho para Fechar Form Aberto
        private void FrmMenuPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            //atalho da tecla de atalho ESC
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {
                if (activeForm != null)
                {
                    btFechar.PerformClick();
                    activeForm = null;
                }
                else
                {
                    //Chamar botão sair com formulario criado
                    btSair.PerformClick();
                }
                }


        }

        //------------------------Login
        private void metodoIniciaMenu()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            panelMenu.Visible = true;
            panelMenuLogo.Visible = true;
            panelMenu.Visible = true;
            btLogin.Visible = true;
            pictureLogo.Visible = true;
        }

        private void metodoResetaMenu()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            panelMenu.Visible = false;
            panelMenuLogo.Visible = false;
            panelMenu.Visible = false;
            btLogin.Visible = false;
            pictureLogo.Visible = false;
            panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
        }
        
        //Inicaia Software Login
        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            metodoResetaMenu();
            DialogResult resultado;
            FrmUsuarioSenha frmLogin = new FrmUsuarioSenha();
            resultado = frmLogin.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                metodoIniciaMenu();
                btLogin.Text = frmLogin.usuarioMenu.usuario;
                btLogin.Visible = true;

                //Passa valor do usuario logado para varivel para ser usada na venda
                userLogado = frmLogin.usuarioMenu.Funcionario;

            }
            else
                this.Close();
        }

        //Logout
        private void btLogin_Click(object sender, EventArgs e)
        {

            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Logout",
            " Deseja realmente sair do usuário "+btLogin.Text+" ?",
            Properties.Resources.UsuarioLogoBranco,
            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
            Color.White,
            "Sim", "Não",
            false);

            resposta = frmCaixa.ShowDialog();
            if (resposta == DialogResult.Yes)
            {

                if (activeForm != null)
                {

                    activeForm.Close();
                }

                btFechar.PerformClick();
                metodoResetaMenu();

                DialogResult resultado;
                FrmUsuarioSenha frmLogin = new FrmUsuarioSenha();
                resultado = frmLogin.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    metodoIniciaMenu();
                    btLogin.Text = frmLogin.usuarioMenu.usuario;
                    btLogin.Visible = true;

                }
                else
                    this.Close();
            }
        }

    }
}
