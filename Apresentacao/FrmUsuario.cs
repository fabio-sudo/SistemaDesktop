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
    public partial class FrmUsuario : Form
    {
        NegUsuarioSenha nUsuario = new NegUsuarioSenha();
        UsuarioSenhaLista usuarioSenhaLista;
        public UsuarioSenha usuarioSelecionado;

        public FrmUsuario()
        {
            InitializeComponent();
        }


        //--------------------------Metodos

        private void AtualizarDataGrid()
        {
            this.dgvUsuarioSenha.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.usuarioSenhaLista.Count > 0)
            {
                this.dgvUsuarioSenha.Rows.Add(this.usuarioSenhaLista.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (UsuarioSenha user in this.usuarioSenhaLista)
            {
                this.dgvUsuarioSenha[0, indice].Value = user.codigoUsuarioSenha;
                this.dgvUsuarioSenha[1, indice].Value = user.usuario;
                this.dgvUsuarioSenha[2, indice].Value = user.senha;
                this.dgvUsuarioSenha[3, indice].Value = user.Funcionario.codigoFuncionario;
                this.dgvUsuarioSenha[4, indice].Value = user.Funcionario.nomeFuncionario;
                this.dgvUsuarioSenha[5, indice].Value = user.Funcionario.sobrenomeFuncionario;
                this.dgvUsuarioSenha[6, indice].Value = user.Funcionario.cpfFuncionario;

                indice++;
            }

            dgvUsuarioSenha.Update();

        }

        //--------------------------Caixa de Texto
        //Evento quando e clicado Enter dentro da caixa de texto realiza a busca
        private void tbUsuarioSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btBuscar.PerformClick();
                e.Handled = true;
            }
        }

        private void tbUsuarioSenha_Enter(object sender, EventArgs e)
        {
            tbUsuarioSenha.Clear();
            pbUsuarioSenha.Image = Properties.Resources.UsuarioRosa;
            panelBuscarUsuarioSenha.BackColor = Color.DeepPink;
            //tbBuscarUsuarioSenha.ForeColor = Color.DeepPink;
        }

        private void tbUsuarioSenha_Leave(object sender, EventArgs e)
        {
            if (tbUsuarioSenha.Text == "")
            {
                tbUsuarioSenha.Text = "Digite o nome do usuário ...";
                pbUsuarioSenha.Image = Properties.Resources.UsuarioAzul;
                panelBuscarUsuarioSenha.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                tbUsuarioSenha.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

            }
        }

        //---------------------------Botões
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;

            FrmCadastroUsuarioSenha frmUsuarioSenha = new FrmCadastroUsuarioSenha();
            resultado = frmUsuarioSenha.ShowDialog();

            if (resultado == DialogResult.OK)
            {

                btBuscar.PerformClick();
            }
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsuarioSenha.RowCount > 0)
                {
                    int indiceRegistroSelecionado = Convert.ToInt32(dgvUsuarioSenha.CurrentRow.Cells[0].Value);
                    foreach (UsuarioSenha user in usuarioSenhaLista)
                    {
                        if (user.codigoUsuarioSenha == indiceRegistroSelecionado)
                        {

                            usuarioSelecionado = user;
                            break;

                        }
                    }
                    //UsuarioSenha UsuarioSenhaSelecionado = UsuarioSenha[indiceRegistroSelecionado];

                    FrmAlterarExcluirUsuarioSenha frmAlterarExcluirUsuario = new FrmAlterarExcluirUsuarioSenha(usuarioSelecionado);

                    DialogResult resposta;

                    resposta = frmAlterarExcluirUsuario.ShowDialog();

                    if (resposta == DialogResult.Yes)
                    {
                        //atualizar o gride quando o formulario voltar ao foco
                        btBuscar.PerformClick();
                    }
                }
            }
            catch
            {
                //Criando Caixa de dialogo
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro",
                "Erro ao selecionar o Usuário!",
                Properties.Resources.DialogErro,
                Color.White,
                Color.Black,
                "Ok", "",
                false);
                frmCaixa.ShowDialog();

                //Volata o focu para caixa de texto de busca de UsuarioSenha
                tbUsuarioSenha.Focus();
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string usuario;
            usuario = tbUsuarioSenha.Text;

            if (tbUsuarioSenha.Text.Equals("Digite o nome do usuário ...") || tbUsuarioSenha.Text == string.Empty)
            {
                usuario = "";
            }

            this.usuarioSenhaLista = nUsuario.BuscarUsuarioSenhaPorNome(usuario);

                AtualizarDataGrid();
        }

        //----------------------------Teclas de Atalho
        private void FrmUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F5) == true)
            {
                btBuscar.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F10) == true)
            {
                btCadastrar.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F2) == true)
            {
                btSelecionar.PerformClick();
            }
            //ESC é no menu principal
        }

        private void dgvUsuarioSenha_DoubleClick(object sender, EventArgs e)
        {
            btSelecionar.PerformClick();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            tbUsuarioSenha.Focus();
        }

    }
}