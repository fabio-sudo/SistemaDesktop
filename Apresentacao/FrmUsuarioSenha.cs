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
    public partial class FrmUsuarioSenha : Form
    {
       //Passar Parametros Para formulario anterior
       public UsuarioSenha usuarioMenu { get; set;}

        public FrmUsuarioSenha()
        {
            InitializeComponent();
        }

        //Retorna as configurações do campo 
        private void metodoSenhaReset(){

            tbSenha.UseSystemPasswordChar = false;
            tbSenha.Text = "Senha";
            pbSenha.Image = Properties.Resources.Senha;
            panelSenha.BackColor = Color.White;
            tbSenha.ForeColor = Color.White;   
        
        }

        private void metodoUsuarioReset() {

            tbUsuario.Text = "Usuario";
            pbUsuario.Image = Properties.Resources.Cliente;
            panelUsuario.BackColor = Color.White;
            tbUsuario.ForeColor = Color.White;
        
        }

        //------------tbUsuario
        //Ganha o foco
        private void tbUsuario_Enter(object sender, EventArgs e)
        {
            tbUsuario.Clear();
            pbUsuario.Image = Properties.Resources.ClienteRosa;
            panelUsuario.BackColor = Color.DeepPink;
            tbUsuario.ForeColor = Color.DeepPink;
        }
        //Perde o foco
        private void tbUsuario_Leave(object sender, EventArgs e)
        {
            if (tbUsuario.Text == string.Empty)
            {
                metodoUsuarioReset();
            }
        }

        //-------------tbSenha
        //Ganha o foco
        private void tbSenha_Enter(object sender, EventArgs e)
        {
            tbSenha.Clear();
            pbSenha.Image = Properties.Resources.SenhaRosa;
            panelSenha.BackColor = Color.DeepPink;
            tbSenha.ForeColor = Color.DeepPink;
            tbSenha.UseSystemPasswordChar = true;
        }
        //Perde o foco
        private void tbSenha_Leave(object sender, EventArgs e)
        {
            if (tbSenha.Text == string.Empty)
            {
                metodoSenhaReset();

            }

        }


        //metodo para validar campos estao vazios
        public Boolean metodoValidaPreenchimento()
        {
            if (tbUsuario.Text == String.Empty || tbUsuario.Text == "Usuario")
            {
                MessageBox.Show("Por favor preencha o nome do Usuario corretamente !",
                 "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbUsuario.Focus();
                return false;
            }
            else if (tbSenha.Text == String.Empty || tbSenha.Text == "Senha")
            {
                MessageBox.Show("Por favor preencha a senha corretamente !",
                 "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSenha.Focus();
                return false;

            }
            else

                return true;


        }

        //Encerra software
        private void btCancelar_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        //Teclas de atalho
        private void FrmUsuarioSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {

                btCancelar.PerformClick();

            }
            //atalho da tecla de atalho F10
            else if (e.KeyCode.Equals(Keys.F10) == true)
            {

                btEntrar.PerformClick();

            }     
        }

        //Logar
        private void btEntrar_Click(object sender, EventArgs e)
        {
            if (metodoValidaPreenchimento() == true) { 
            
             NegUsuarioSenha negusuariosenha = new NegUsuarioSenha();
             UsuarioSenha usuariosenha = new UsuarioSenha();
             UsuarioSenha userValidado = new UsuarioSenha();
             usuariosenha.Funcionario = new Funcionario();

                usuariosenha.usuario = this.tbUsuario.Text;
                usuariosenha.senha = this.tbSenha.Text;

                //Faz a validação do Login 
                userValidado = negusuariosenha.ValidarSenha(usuariosenha);
                //Se o objeto for diferente de null
                if (userValidado != null)
                {
                    //---------Passa o parametro pro formulario
                    this.DialogResult = DialogResult.OK;
                    usuarioMenu = userValidado;
                    this.Close();
                }
                else
                {
                    //Criando Caixa de dialogo
                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro",
                    "Verifique o Usuário e Senha !",
                    Properties.Resources.DialogErro,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Ok", "",
                    false);
                    frmCaixa.ShowDialog();
                    metodoSenhaReset();
                    metodoUsuarioReset();
                }
            
            }
          
        }
        
    }
}
