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
    public partial class FrmCadastroUsuarioSenha : Form
    {
        UsuarioSenha objUsuarioSenha = new UsuarioSenha();
        NegUsuarioSenha nUsuario = new NegUsuarioSenha();
        NegFuncionario nFuncionario = new NegFuncionario();

        public FrmCadastroUsuarioSenha()
        {
            InitializeComponent();
        }

        //Metodo para validar campos
        public Boolean ValidaCadastroUsuarioSenha()
        {

            if (tbUsuario.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o Usuário!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbUsuario.Clear();
                tbUsuario.Focus();

                return false;
            }
            else if (tbSenha.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe a Senha!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSenha.Clear();
                tbSenha.Focus();

                return false;
            }
            else if (tbConfirmaSenha.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Confirme a Senha!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbConfirmaSenha.Clear();
                tbConfirmaSenha.Focus();

                return false;
            }
            else if (tbConfirmaSenha.Text.Trim() != tbSenha.Text.Trim())
            {
                MessageBox.Show("Senhas estão diferentes !",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbConfirmaSenha.Clear();
                tbConfirmaSenha.Focus();

                return false;
            }
            else if (tbFuncionario.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o Funcionário!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbFuncionario.Clear();
                tbFuncionario.Focus();

                return false;
            }
            else if (objUsuarioSenha.Funcionario == null)
            {
                MessageBox.Show("Informe um Funcionário Válido!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbFuncionario.Clear();
                tbFuncionario.Focus();

                return false;
            }
            else
                return true;

        }

        //Metodo para limpar os campos
        public void LimpaCampos()
        {
            epUsuarioSenha.Clear();
            tbUsuario.Clear();
            tbSenha.Clear();
            tbConfirmaSenha.Clear();
            tbFuncionario.Clear();
            objUsuarioSenha.Funcionario = null;
     
        }

        //----------------Exibir ou oucultar Senha
        private void pbMostrarSenha_Click(object sender, EventArgs e)
        {
            if (tbSenha.UseSystemPasswordChar == true)
            {
                tbSenha.UseSystemPasswordChar = false;
            }else
                tbSenha.UseSystemPasswordChar = true;
        }

        private void pbMostrarConfirmaSenha_Click(object sender, EventArgs e)
        {
            if (tbConfirmaSenha.UseSystemPasswordChar == true)
            {
                tbConfirmaSenha.UseSystemPasswordChar = false;
            }
            else
                tbConfirmaSenha.UseSystemPasswordChar = true;
        }

        //-----------------Seleciona Funcionario
        private void pbSelecionarFuncionario_Click(object sender, EventArgs e)
        {
            try
            {

            //Verifica se já existe Funcionario já está vinculado com usuário
             UsuarioSenha usuario = new UsuarioSenha();

                int n;
                bool ehUmNumero = int.TryParse(tbFuncionario.Text, out n);
                if (ehUmNumero == true)
                {
                    objUsuarioSenha.Funcionario = nFuncionario.BuscarFuncionarioPorCodigo(n);
                    if (objUsuarioSenha.Funcionario != null)
                    {
                        this.tbFuncionario.Text = objUsuarioSenha.Funcionario.nomeFuncionario;
                        btCadastrar.Focus();
                    }
                    else
                    { tbFuncionario.Clear(); }
                }
                else
                {
               
                FrmSelecionarFuncionario frmSelecionarFuncionario = new FrmSelecionarFuncionario(tbFuncionario.Text);
                DialogResult resultado = frmSelecionarFuncionario.ShowDialog();
                             
                if (resultado == DialogResult.OK)
                {

                    this.objUsuarioSenha.Funcionario = frmSelecionarFuncionario.FuncionarioSelecionado;
                    this.tbFuncionario.Text = objUsuarioSenha.Funcionario.nomeFuncionario;

                   }
                }

                if (objUsuarioSenha.Funcionario != null)
                {
                    //--------------------Validação se usuário já está vinculado com funcionario
                    usuario = nUsuario.uspValidaCadastroUsuarioFuncionario(objUsuarioSenha.Funcionario);

                    if (usuario != null)
                    {
                        //Criando Caixa de dialogo
                        FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Funcionário já está vinculado",
                        " User: " + usuario.usuario +
                        " Nome: " + usuario.Funcionario.nomeFuncionario + " " + usuario.Funcionario.sobrenomeFuncionario +
                        " CPF: " + usuario.Funcionario.cpfFuncionario,
                        Properties.Resources.DialogWarning,
                        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                        Color.White,
                        "Ok", "",
                        true);
                        frmCaixa.ShowDialog();
                        //Volta parametro para caixa de texto
                        objUsuarioSenha.Funcionario = null;
                        tbFuncionario.Clear();
                        tbFuncionario.Focus();
                    }
                    else
                    { btCadastrar.Focus(); }
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

        //-------------------Botões
        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair do Cadastro de Usuário?",
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
            tbUsuario_Leave(null, null);

            if (ValidaCadastroUsuarioSenha() == true)
            {
                try
                {
                    NegUsuarioSenha negusuariosenha = new NegUsuarioSenha();
                    UsuarioSenha usuariosenha = new UsuarioSenha();

                    usuariosenha.usuario = this.tbUsuario.Text;
                    usuariosenha.senha = this.tbSenha.Text;
                    usuariosenha.Funcionario = objUsuarioSenha.Funcionario;

                    if (negusuariosenha.CadastrarUsuarioSenha(usuariosenha) == true)
                    {
                        DialogResult resposta;
                        //Criando Caixa de dialogo
                        FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
                        " Cadastro Realizado com Sucesso! \r\n" +
                        "Deseja Continuar No Cadastro De Usuário?",
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
                        LimpaCampos();
                        tbUsuario.Focus();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao realizar o Cadastro !", "Erro Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbUsuario.Focus();
                        return;
                    }

                }

                catch (Exception ex)
                {
                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro",
                    "Erro ao cadastrar Usuário \r\n" + ex.Message,
                    Properties.Resources.DialogErro,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Ok", "",
                    false);

                    frmCaixa.ShowDialog();
                }
            }
        }

        //---------------------Teclas de Atalho
        private void FrmCadastroUsuarioSenha_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode.Equals(Keys.Escape) == true)
            {
                btSair.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F10) == true)
            {
                btCadastrar.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F4) == true)
            {
                pbSelecionarFuncionario_Click(null, null);
            }

        }

        //---------------------------Validações
        private void tbUsuario_Leave(object sender, EventArgs e)
        {
            try
            {
                //Verifica se o campo for preenchido
                if (tbUsuario.Text == String.Empty)
                {
                    epUsuarioSenha.SetError(tbUsuario, "Campo obrigatório!");
                    return;
                }
                else
                    epUsuarioSenha.Clear();

                //Verifica se já existe CPF cadastrado
                UsuarioSenha usuario = new UsuarioSenha();
                usuario = nUsuario.ValidaCadastroUsuarioSenha(tbUsuario.Text);
                if (usuario != null)
                {
                    //Criando Caixa de dialogo
                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Usuário já Existe",
                    " User: " + usuario.usuario +
                    " Nome: " + usuario.Funcionario.nomeFuncionario + " " + usuario.Funcionario.sobrenomeFuncionario +
                    " CPF: " + usuario.Funcionario.cpfFuncionario,
                    Properties.Resources.DialogWarning,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Ok", "",
                    true);
                    frmCaixa.ShowDialog();
                    //Volta parametro para caixa de texto
                    tbUsuario.Clear();
                    tbUsuario.Focus();
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

        private void tbFuncionario_Leave(object sender, EventArgs e)
        {
                //Verifica se o campo for preenchido
                if (tbFuncionario.Text == String.Empty)
                {
                    epUsuarioSenha.SetError(pbSelecionarFuncionario, "Campo obrigatório!");
                    return;
                }else if(objUsuarioSenha.Funcionario == null){

                    epUsuarioSenha.SetError(pbSelecionarFuncionario, "Selecione Funcionário!");
                    return;
                }
                else
                    epUsuarioSenha.Clear();

        }

        private void tbSenha_Leave(object sender, EventArgs e)
        {
            //verifica campo senha 
            if (tbSenha.Text == String.Empty)
            {
                epUsuarioSenha.SetError(pbMostrarSenha, "Campo obrigatório!");
            }
            else
                epUsuarioSenha.Clear();
        }

        private void tbConfirmaSenha_Leave(object sender, EventArgs e)
        {
            //verifica e valida se as senhas forão digitadas coretamente
            if (tbConfirmaSenha.Text == String.Empty)
            {
                epUsuarioSenha.SetError(pbMostrarConfirmaSenha, "Campo Obrigatório!");

            }            //verifica e valida se as senhas forão digitadas coretamente
            else if (tbConfirmaSenha.Text != tbSenha.Text)
            {
                epUsuarioSenha.SetError(pbMostrarConfirmaSenha, "Senha foi digitada incorretamente!");
            }
            else
                epUsuarioSenha.Clear();
        }

        private void tbFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbSelecionarFuncionario_Click(null, null);
                e.Handled = true;
            }
        }

    }
}
