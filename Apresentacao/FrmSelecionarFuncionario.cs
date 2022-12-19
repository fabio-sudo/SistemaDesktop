using Negocio;
using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmSelecionarFuncionario : Form
    {
        NegFuncionario nFuncionario = new NegFuncionario();
        public FuncionarioLista FuncionarioLista;
        public Funcionario FuncionarioSelecionado;
        string strFuncionario;

        public FrmSelecionarFuncionario([Optional]string nomeFuncionario)
        {
            InitializeComponent();
            if (nomeFuncionario != String.Empty)
            {
                strFuncionario = nomeFuncionario;
            }
        }

        //atualiza os valores no Data Grid
        private void AtualizarDataGrid()
        {
            this.dgvFuncionario.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.FuncionarioLista.Count > 0)
            {
                this.dgvFuncionario.Rows.Add(this.FuncionarioLista.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (Funcionario func in this.FuncionarioLista)
            {
                this.dgvFuncionario[0, indice].Value = func.codigoFuncionario;
                this.dgvFuncionario[1, indice].Value = func.nomeFuncionario;
                this.dgvFuncionario[2, indice].Value = func.sobrenomeFuncionario;
                this.dgvFuncionario[3, indice].Value = Convert.ToUInt64(func.cpfFuncionario).ToString(@"000\.000\.000\-00");
                indice++;
            }

            dgvFuncionario.Update();

        }

        //------------------Caixa de Texto
        private void tbBuscarFuncionario_Enter(object sender, EventArgs e)
        {
            tbBuscarFuncionario.Clear();
            pbFuncionario.Image = Properties.Resources.FuncionarioRosa;
            panelBuscarFuncionario.BackColor = Color.DeepPink;
            if (strFuncionario != String.Empty)
            {
                tbBuscarFuncionario.Text = strFuncionario;
            
            }
        }

        private void tbBuscarFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btBuscar.PerformClick();
                e.Handled = true;
            }
        }

        private void tbBuscarFuncionario_Leave(object sender, EventArgs e)
        {
            if (tbBuscarFuncionario.Text == "")
            {
                tbBuscarFuncionario.Text = "Digite o nome do funcionário ...";
                pbFuncionario.Image = Properties.Resources.FuncionarioAzul;
                panelBuscarFuncionario.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                tbBuscarFuncionario.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

            }
        }

        //-------------------Botões
        private void btBuscar_Click(object sender, EventArgs e)
        {
            string funcionario;
            funcionario = tbBuscarFuncionario.Text;

            if (tbBuscarFuncionario.Text.Equals("Digite o nome do funcionário ...") || tbBuscarFuncionario.Text == string.Empty)
            {
                funcionario = "";
            }

            this.FuncionarioLista = nFuncionario.BuscarFuncionarioPorNome(funcionario);
            AtualizarDataGrid();
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            if (this.dgvFuncionario.Rows.Count > 0)
            {
              int indiceRegistroSelecionado = Convert.ToInt32(dgvFuncionario.CurrentRow.Cells[0].Value);
              foreach (Funcionario func in FuncionarioLista)
              {
              if (func.codigoFuncionario == indiceRegistroSelecionado)
                {
               FuncionarioSelecionado = func;
               this.DialogResult = DialogResult.OK;
               this.Close();
               break;

                }
              }

            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair da Seleção de Funcionário ?",
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
            DialogResult resultado;

            FrmCadastroFuncionario frmFuncionario = new FrmCadastroFuncionario();
            resultado = frmFuncionario.ShowDialog();

            if (resultado == DialogResult.OK)
            {

                btBuscar.PerformClick();
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvFuncionario.RowCount > 0)
                {
                    int indiceRegistroSelecionado = Convert.ToInt32(dgvFuncionario.CurrentRow.Cells[0].Value);
                    foreach (Funcionario func in FuncionarioLista)
                    {
                        if (func.codigoFuncionario == indiceRegistroSelecionado)
                        {

                            FuncionarioSelecionado = func;
                            break;
                        }


                    }

                    FrmAlterarExcluirFuncionario frmAlterarExcluirFuncionario = new FrmAlterarExcluirFuncionario(FuncionarioSelecionado);

                    DialogResult resposta;

                    resposta = frmAlterarExcluirFuncionario.ShowDialog();

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
                "Erro ao selecionar o Funcionário!",
                Properties.Resources.DialogErro,
                Color.White,
                Color.Black,
                "Ok", "",
                false);
                frmCaixa.ShowDialog();

                //Volata o focu para caixa de texto de busca de Funcionario
                tbBuscarFuncionario.Focus();
            }
        }

        //--------------------------Atalhos
        private void FrmSelecionarFuncionario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F5) == true)
            {
                btBuscar.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {
                btSair.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F2) == true)
            {
                btSelecionar.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F10) == true)
            {
                btCadastrar.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F4) == true)
            {
                btAlterar.PerformClick();
            }
        }

        private void dgvFuncionario_DoubleClick(object sender, EventArgs e)
        {
            btSelecionar.PerformClick();
        }

        //Verifica se foi preenchido nome do funcionário caso sim ja realiza a busca
        private void FrmSelecionarFuncionario_Load(object sender, EventArgs e)
        {
            if (strFuncionario != String.Empty)
            {
                tbBuscarFuncionario.Text = strFuncionario;
                btBuscar.PerformClick();
            }
        }


    }
}
