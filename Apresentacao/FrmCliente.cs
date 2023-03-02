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
using System.Text.RegularExpressions;

namespace Apresentacao
{
    public partial class FrmCliente : Form
    {
        NegCliente ncliente = new NegCliente();
        ClienteLista clienteLista;
        public Cliente clienteSelecionado;


        public FrmCliente()
        {
            InitializeComponent();

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
                this.dgvCliente[3, indice].Value = clie.sexoCliente;
                this.dgvCliente[4, indice].Value = clie.rgCliente;
                this.dgvCliente[5, indice].Value = clie.cpfCliente;
                this.dgvCliente[6, indice].Value = clie.dataNascimentoCliente;
                this.dgvCliente[7, indice].Value = clie.enderecoCliente;
                this.dgvCliente[8, indice].Value = clie.bairroCliente;
                this.dgvCliente[9, indice].Value = clie.numeroCliente;
                this.dgvCliente[10, indice].Value = clie.cepCliente;
                this.dgvCliente[11, indice].Value = clie.cidadeCliente;
                this.dgvCliente[12, indice].Value = clie.estadoCliente;
                this.dgvCliente[13, indice].Value = clie.telefoneCliente;
                this.dgvCliente[14, indice].Value = clie.celularCliente;
                this.dgvCliente[15, indice].Value = clie.emailCliente;

                indice++;
            }

            dgvCliente.Update();

        }

        //Foco na Caixa de Texto Cliente
        private void tbBuscarCliente_Enter(object sender, EventArgs e)
        {
            tbBuscarCliente.Clear();
            pbUsuario.Image = Properties.Resources.ClienteRosa;
            panelBuscarCliente.BackColor = Color.DeepPink;
            //tbBuscarCliente.ForeColor = Color.DeepPink;

        }

        //Caixa de Texto Cliente perde o Foco
        private void tbBuscarCliente_Leave(object sender, EventArgs e)
        {
            if (tbBuscarCliente.Text == "")
            {
                tbBuscarCliente.Text = "Digite o nome do cliente ...";
                pbUsuario.Image = Properties.Resources.ClienteAzul;
                panelBuscarCliente.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                tbBuscarCliente.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

            }
        }

        //Botão Buscar Clientes
        private void btBuscar_Click(object sender, EventArgs e)
        {
            string cliente;
            cliente = tbBuscarCliente.Text;

            if (tbBuscarCliente.Text.Equals("Digite o nome do cliente ...") || tbBuscarCliente.Text == string.Empty)
            {
                cliente = "";
            }

                this.clienteLista = ncliente.BuscarClientePorNome(cliente);
                AtualizarDataGrid();

        }

        //Cadastrar Cliente
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;

            FrmCadastroCliente frmCliente = new FrmCadastroCliente();
            resultado = frmCliente.ShowDialog();

            if (resultado == DialogResult.OK) {

                btBuscar.PerformClick();
            }

        }

        //Teclas de atalho
        private void FrmCliente_KeyDown(object sender, KeyEventArgs e)
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

        //Pressionada tecla Enter no menu principal
        private void tbBuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btBuscar.PerformClick();
                e.Handled = true;
            }
        }

        //Começa o formulário com foco na caixa de texto para buscar o cliente
        private void FrmCliente_Load(object sender, EventArgs e)
        {
            tbBuscarCliente.Focus();
        }

        //Botão para selecionar o cliente para realizar alteração ou exclusão
        private void btSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvCliente.RowCount > 0){
                int indiceRegistroSelecionado = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);
                foreach (Cliente clie in clienteLista)
                {
                    if (clie.codigoCliente == indiceRegistroSelecionado)
                    {

                        clienteSelecionado = clie;
                        break;

                    }


                }

                //Cliente ClienteSelecionado = cliente[indiceRegistroSelecionado];

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

                //Volata o focu para caixa de texto de busca de cliente
                tbBuscarCliente.Focus();
            }
        }

        //Atalho do Selecionar atraves duplo clique na celular
        private void dgvCliente_DoubleClick(object sender, EventArgs e)
        {
            btSelecionar.PerformClick();
        }

    }
}
