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
    public partial class FrmSelecionarGenero : Form
    {
        NegGenero nGenero = new NegGenero();
        public GeneroLista generoLista;
        public Genero generoSelecionado;
        public string strGenero;

        public FrmSelecionarGenero([Optional] string nomeGenero)
        {
            InitializeComponent();

            if (nomeGenero != String.Empty)
            {
                strGenero = nomeGenero;
            }
        }

        //atualiza os valores no Data Grid
        private void AtualizarDataGrid()
        {
            this.dgvGenero.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.generoLista.Count > 0)
            {
                this.dgvGenero.Rows.Add(this.generoLista.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (Genero gen in this.generoLista)
            {
                this.dgvGenero[0, indice].Value = gen.codigoGenero;
                this.dgvGenero[1, indice].Value = gen.nomeGenero;
                indice++;
            }

            dgvGenero.Update();

        }

        //--------------------Caixa de Texto
        private void tbBuscarGenero_Enter(object sender, EventArgs e)
        {
            tbBuscarGenero.Clear();
            pbGenero.Image = Properties.Resources.GeneroRosa;
            panelBuscarGenero.BackColor = Color.DeepPink;

            if (strGenero != String.Empty)
            {
                tbBuscarGenero.Text = strGenero;

            }
        }

        private void tbBuscarGenero_Leave(object sender, EventArgs e)
        {
            if (tbBuscarGenero.Text == "")
            {
                tbBuscarGenero.Text = "Digite o gênero do produto ...";
                pbGenero.Image = Properties.Resources.GeneroAzul;
                panelBuscarGenero.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                tbBuscarGenero.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

            }
        }

        private void tbBuscarGenero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btBuscar.PerformClick();
                e.Handled = true;
            }
        }

        //---------------------Botões
        private void btBuscar_Click(object sender, EventArgs e)
        {
            string genero;
            genero = tbBuscarGenero.Text;

            if (tbBuscarGenero.Text.Equals("Digite o gênero do produto ...") || tbBuscarGenero .Text == string.Empty)
            {
                genero = "";
            }

            this.generoLista = nGenero.BuscarGeneroPorNome(genero);
            AtualizarDataGrid();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;

            FrmCadastroGenero frmGenero = new FrmCadastroGenero();
            resultado = frmGenero.ShowDialog();

            if (resultado == DialogResult.OK)
            {

                btBuscar.PerformClick();
            }
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            if (this.dgvGenero.Rows.Count > 0)
            {
                int indiceRegistroSelecionado = Convert.ToInt32(dgvGenero.CurrentRow.Cells[0].Value);
                foreach (Genero gen in generoLista)
                {
                    if (gen.codigoGenero == indiceRegistroSelecionado)
                    {
                        generoSelecionado = gen;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        break;

                    }
                }

            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvGenero.RowCount > 0)
                {
                    int indiceRegistroSelecionado = Convert.ToInt32(dgvGenero.CurrentRow.Cells[0].Value);
                    foreach (Genero gen in generoLista)
                    {
                        if (gen.codigoGenero == indiceRegistroSelecionado)
                        {

                            generoSelecionado = gen;

                        }


                    }

                    FrmAlterarExcluirGenero frmAlterarExcluirGenero = new FrmAlterarExcluirGenero(generoSelecionado);

                    DialogResult resposta;

                    resposta = frmAlterarExcluirGenero.ShowDialog();

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
                "Erro ao selecionar o Gênero!",
                Properties.Resources.DialogErro,
                Color.White,
                Color.Black,
                "Ok", "",
                false);
                frmCaixa.ShowDialog();

                //Volata o focu para caixa de texto de busca de Funcionario
                tbBuscarGenero.Focus();
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair da Seleção de Gênero ?",
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

        //---------------------------Teclas de Atalho
        private void FrmSelecionarGenero_KeyDown(object sender, KeyEventArgs e)
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

        private void dgvGenero_DoubleClick(object sender, EventArgs e)
        {
            btSelecionar.PerformClick();
        }

        private void FrmSelecionarGenero_Load(object sender, EventArgs e)
        {
            if (strGenero != null)
            {
                tbBuscarGenero.Text = strGenero;
                btBuscar.PerformClick();
            }
        }

    }
}
