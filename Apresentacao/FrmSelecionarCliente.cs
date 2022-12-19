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
    public partial class FrmSelecionarCliente : Form
    {
        NegCliente nCliente = new NegCliente();
        NegCrediario nCrediario = new NegCrediario();
        public ClienteLista clienteLista;
        public Cliente clienteSelecionado;
        string strCliente;


        public FrmSelecionarCliente([Optional]string nomeCliente)
        {
            InitializeComponent();

            if (nomeCliente != String.Empty)
            {
                strCliente = nomeCliente;
            }
        }

        //atualiza os valores no Data Grid
        private void AtualizarDataGrid()
        {
            this.dgvCliente.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.clienteLista.Count > 0)
            {
                this.dgvCliente.Rows.Add(this.clienteLista.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (Cliente clie in this.clienteLista)
            {
                this.dgvCliente[0, indice].Value = clie.codigoCliente;
                this.dgvCliente[1, indice].Value = clie.nomeCliente;
                this.dgvCliente[2, indice].Value = clie.sobrenomeCliente;
                this.dgvCliente[3, indice].Value = Convert.ToUInt64(clie.cpfCliente).ToString(@"000\.000\.000\-00");

                //Verifica se o Cliente está bloqueado
                if (nCrediario.BuscarCrediarioBloqueado(clie.codigoCliente) == true)
                {
                    dgvCliente.Rows[indice].ErrorText = "Cliente Bloqueado!";
                    dgvCliente.Rows[indice].DefaultCellStyle.ForeColor = Color.White;
                    dgvCliente.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                }
                //Verifica se o cliente tem parcelas atrasadas
                else if (nCrediario.BuscarCrediarioVencimento(clie.codigoCliente) == true)
                {
                    dgvCliente.Rows[indice].ErrorText = "Parcelas Atrasadas!";
                }
                
                indice++;
            }

            dgvCliente.Update();

        }

        private void tbBuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btBuscar.PerformClick();
                e.Handled = true;
            }
        }

        private void tbBuscarCliente_Leave(object sender, EventArgs e)
        {
            if (tbBuscarCliente.Text == "")
            {
                tbBuscarCliente.Text = "Digite o nome do cliente ...";
                pbCliente.Image = Properties.Resources.ClienteAzul;
                panelBuscarCliente.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                tbBuscarCliente.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

            }
        }

        private void tbBuscarCliente_Enter(object sender, EventArgs e)
        {
            tbBuscarCliente.Clear();
            pbCliente.Image = Properties.Resources.ClienteRosa;
            panelBuscarCliente.BackColor = Color.DeepPink; 
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string clienteStr;
            clienteStr = tbBuscarCliente.Text;

            if (tbBuscarCliente.Text.Equals("Digite o nome do cliente ...") || tbBuscarCliente.Text == string.Empty)
            {
                clienteStr = "";
            }

            this.clienteLista = nCliente.BuscarClientePorNome(clienteStr);
            AtualizarDataGrid();
        }

        //-----------------Botões
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;

            FrmCadastroCliente frmCliente = new FrmCadastroCliente();
            resultado = frmCliente.ShowDialog();

            if (resultado == DialogResult.OK)
            {

                btBuscar.PerformClick();
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCliente.RowCount > 0)
                {
                    int indiceRegistroSelecionado = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);
                    foreach (Cliente clie in clienteLista)
                    {
                        if (clie.codigoCliente == indiceRegistroSelecionado)
                        {

                            clienteSelecionado = clie;
                            break;
                        }

                    }

                    FrmAlterarExcluirCliente frmAlterarExcluirCliente = new FrmAlterarExcluirCliente(clienteSelecionado);

                    DialogResult resposta;

                    resposta = frmAlterarExcluirCliente.ShowDialog();

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
                "Erro ao selecionar o Cliente!",
                Properties.Resources.DialogErro,
                Color.White,
                Color.Black,
                "Ok", "",
                false);
                frmCaixa.ShowDialog();

                //Volata o focu para caixa de texto de busca de Funcionario
                tbBuscarCliente.Focus();
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair da Seleção de Clientes?",
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

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            if (this.dgvCliente.Rows.Count > 0)
            {
                int indiceRegistroSelecionado = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);
                foreach (Cliente clie in clienteLista)
                {
                    if (clie.codigoCliente == indiceRegistroSelecionado)
                    {
                        clienteSelecionado = clie;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        break;

                    }
                }

            }
        }

        //-------------------Formulário
        private void FrmSelecionarCliente_KeyDown(object sender, KeyEventArgs e)
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

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btSelecionar.PerformClick();
        }

        private void FrmSelecionarCliente_Load(object sender, EventArgs e)
        {
            if (strCliente != String.Empty)
            {
                tbBuscarCliente.Text = strCliente;
                btBuscar.PerformClick();
            }
        }

    }
}
