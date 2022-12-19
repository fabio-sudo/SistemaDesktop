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
    public partial class FrmAlterarExcluirUsuarioSenha : Form
    {

        UsuarioSenha usuarioCorrente;
        UsuarioSenha objUsuario = new UsuarioSenha();
        NegUsuarioSenha nUsuario = new NegUsuarioSenha();
        NegFuncionario nFuncionario = new NegFuncionario();


        public FrmAlterarExcluirUsuarioSenha(UsuarioSenha usuariosenha)
        {
            InitializeComponent();

            usuarioCorrente = usuariosenha;
        }


        //metodo para iniciar os campos do formulario
        public void metodoIniciaFormulario()
        {
            tbCodigo.Enabled = false;
            this.tbCodigo.Text = usuarioCorrente.codigoUsuarioSenha.ToString();
            this.tbUsuario.Text = usuarioCorrente.usuario.ToString();
            this.tbSenha.Text = usuarioCorrente.senha.ToString();
            this.tbConfirmaSenha.Text = usuarioCorrente.senha.ToString();
            this.tbFuncionario.Text = usuarioCorrente.Funcionario.nomeFuncionario.ToString();

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
            else if (usuarioCorrente.Funcionario == null)
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

        //-----------------------Validações
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

                if (usuarioCorrente.usuario != tbUsuario.Text)
                {
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

        private void tbFuncionario_Leave(object sender, EventArgs e)
        {
            //Verifica se o campo for preenchido
            if (tbFuncionario.Text == String.Empty)
            {
                epUsuarioSenha.SetError(pbSelecionarFuncionario, "Campo obrigatório!");
                return;
            }
            else if (usuarioCorrente.Funcionario == null)
            {

                epUsuarioSenha.SetError(pbSelecionarFuncionario, "Selecione Funcionário!");
                return;
            }
            else
                epUsuarioSenha.Clear();
        }

        //------------------------Botões
        private void pbMostrarSenha_Click(object sender, EventArgs e)
        {
            if (tbSenha.UseSystemPasswordChar == true)
            {
                tbSenha.UseSystemPasswordChar = false;
            }
            else
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
                    objUsuario.Funcionario = nFuncionario.BuscarFuncionarioPorCodigo(n);
                    if (objUsuario.Funcionario != null)
                    {
                        this.tbFuncionario.Text = objUsuario.Funcionario.nomeFuncionario;
                        btAlterar.Focus();
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

                    this.objUsuario.Funcionario = frmSelecionarFuncionario.FuncionarioSelecionado;
                    this.tbFuncionario.Text = objUsuario.Funcionario.nomeFuncionario;

                   }
                }

                if (objUsuario.Funcionario != null)
                {
                    //--------------------Validação se usuário já está vinculado com funcionario
                    usuario = nUsuario.uspValidaCadastroUsuarioFuncionario(objUsuario.Funcionario);

                    //-------------------------Defininindo mascara para o campo CPF
                    if (usuario != null && objUsuario.Funcionario.cpfFuncionario != usuarioCorrente.Funcionario.cpfFuncionario)
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
                        objUsuario.Funcionario = null;
                        tbFuncionario.Clear();
                        tbFuncionario.Focus();
                    }
                    else
                    { btAlterar.Focus(); }
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
                epUsuarioSenha.Clear();

            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                //Valida Preenchimento chamando função
                tbUsuario_Leave(null, null);
                
                //Validas se os campos estão preenchidos
                if (ValidaCadastroUsuarioSenha() == true)
                {

                    DialogResult resposta;
                    //Criando Caixa de dialogo
                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Alteração",
                    " Deseja realmente Alterar os dados do Usuário ?",
                    Properties.Resources.Alterar,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Confirmar", "Cancelar",
                    false);

                    //Verifica se o usuário realmente quer alterar os dados do cliente.
                    resposta = frmCaixa.ShowDialog();
                    if (resposta == DialogResult.Yes)
                    {
                        UsuarioSenha usuarioAlterado = new UsuarioSenha();

                        usuarioAlterado.codigoUsuarioSenha = int.Parse(tbCodigo.Text);
                        usuarioAlterado.usuario = tbUsuario.Text;
                        usuarioAlterado.senha = tbSenha.Text;
                        //Caso não haja alterações no usuário ele usa o mesmo da memória
                        if (objUsuario.Funcionario != null)
                        {
                            usuarioAlterado.Funcionario = objUsuario.Funcionario;
                        }
                        else
                            usuarioAlterado.Funcionario = usuarioCorrente.Funcionario;

                        //Realizando o Cadastro
                        if (nUsuario.AtualizarUsuarioSenha(usuarioAlterado) == true)
                        {

                            //Criando Caixa de dialogo
                            frmCaixa = new FrmCaixaDialogo("Alteração",
                            "Usuário Alterado com sucesso !\r\n" +
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
                            MessageBox.Show("Não foi possível atualizar os dados do Usuário. Erro no banco de Dados!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível atualizar os dados do Usuário. Motivo: " + ex.Message);
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair da Alteração & Exclusão de Usuário?",
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

        private void btExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Exclusão",
            " Deseja realmente Excluir o Usuário ?",
            Properties.Resources.Excluir,
            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
            Color.White,
            "Confirmar", "Cancelar",
            false);

            resposta = frmCaixa.ShowDialog();
            if (resposta == DialogResult.Yes)
            {
                if (nUsuario.ExcluirUsuarioSenha(usuarioCorrente) == true)
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
                    "Não foi possível realizar a exclusão do Usuário ! \r\n" +
                    "Usuário está vinculado a Histórico!",
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

        private void tbFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbSelecionarFuncionario_Click(null, null);
                e.Handled = true;
            }
        }

        //-----------------------------Teclas de Atalho
        private void FrmAlterarExcluirUsuarioSenha_KeyDown(object sender, KeyEventArgs e)
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
            if (e.KeyCode.Equals(Keys.F4) == true)
            {
                pbSelecionarFuncionario_Click(null, null);
            } 
            if (e.KeyCode.Equals(Keys.F5) == true)
            {
                pbDesfazer_Click(null, null);
            }
        }

        private void FrmAlterarExcluirUsuarioSenha_Load(object sender, EventArgs e)
        {
            metodoIniciaFormulario();
        }




    }
}
