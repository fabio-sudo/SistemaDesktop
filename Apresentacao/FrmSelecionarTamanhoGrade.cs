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
    public partial class FrmSelecionarTamanhoGrade : Form
    {

        NegTamanho nTamanho = new NegTamanho();
        public TamanhoLista tamanhoLista;
        public Tamanho tamanhoSelecionado;

        public int intGrade;
        public string strTamanho;

        public FrmSelecionarTamanhoGrade(int codigoGrade,[Optional] string nomeTamanho)
        {
            InitializeComponent();

            intGrade = codigoGrade;

            if (nomeTamanho != String.Empty)
            {
                strTamanho = nomeTamanho;
            }
        }

        //atualiza os valores no Data Grid
        private void AtualizarDataGrid()
        {
            this.dgvTamanho.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.tamanhoLista.Count > 0)
            {
                this.dgvTamanho.Rows.Add(this.tamanhoLista.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (Tamanho tam in this.tamanhoLista)
            {
                this.dgvTamanho[0, indice].Value = tam.codigoTamanho;
                this.dgvTamanho[1, indice].Value = tam.nometamanho;

                indice++;
            }

            dgvTamanho.Update();

        }

        //----------------Botões
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;

            FrmCadastroTamanho frmTamanho = new FrmCadastroTamanho();
            resultado = frmTamanho.ShowDialog();

            if (resultado == DialogResult.OK)
            {

                btBuscar.PerformClick();
            }
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            if (this.dgvTamanho.Rows.Count > 0)
            {
                int indiceRegistroSelecionado = Convert.ToInt32(dgvTamanho.CurrentRow.Cells[0].Value);
                foreach (Tamanho tamanho in tamanhoLista)
                {
                    if (tamanho.codigoTamanho == indiceRegistroSelecionado)
                    {
                        tamanhoSelecionado = tamanho;
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
            " Deseja realmente sair da Seleção de Tamanho ?",
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

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string tamanho;
            tamanho = tbBuscarTamanho.Text;

            if (tbBuscarTamanho.Text.Equals("Digite o tamanho do produto ...") || tbBuscarTamanho.Text == string.Empty)
            {
                tamanho = "";
            }

            this.tamanhoLista = nTamanho.BuscarTamanhoPorNomeNaGrade(intGrade,tamanho);
            AtualizarDataGrid();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTamanho.RowCount > 0)
                {
                    int indiceRegistroSelecionado = Convert.ToInt32(dgvTamanho.CurrentRow.Cells[0].Value);
                    foreach (Tamanho tam in tamanhoLista)
                    {
                        if (tam.codigoTamanho == indiceRegistroSelecionado)
                        {

                            tamanhoSelecionado = tam;
                            break;

                        }


                    }

                    FrmAlterarExcluirTamanho frmAlterarExcluirTamanho = new FrmAlterarExcluirTamanho(tamanhoSelecionado);

                    DialogResult resposta;

                    resposta = frmAlterarExcluirTamanho.ShowDialog();

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
                "Erro ao selecionar o Tamanho!",
                Properties.Resources.DialogErro,
                Color.White,
                Color.Black,
                "Ok", "",
                false);
                frmCaixa.ShowDialog();

                //Volata o focu para caixa de texto de busca de Funcionario
                tbBuscarTamanho.Focus();
            }
        }

        //------------------Caixa de Texto
        private void tbBuscarTamanho_Leave(object sender, EventArgs e)
        {
            if (tbBuscarTamanho.Text == "")
            {
                tbBuscarTamanho.Text = "Digite o tamanho do produto ...";
                pbTamanho.Image = Properties.Resources.TamanhoAzul;
                panelBuscarTamanho.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                panelBuscarTamanho.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

            }
        }

        private void tbBuscarTamanho_Enter(object sender, EventArgs e)
        {
            tbBuscarTamanho.Clear();
            pbTamanho.Image = Properties.Resources.TamanhoRosa;
            panelBuscarTamanho.BackColor = Color.DeepPink;

            if (strTamanho != String.Empty)
            {
                tbBuscarTamanho.Text = strTamanho;

            }
        }

        private void tbBuscarTamanho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btBuscar.PerformClick();
                e.Handled = true;
            }
        }

        private void dgvTamanho_DoubleClick(object sender, EventArgs e)
        {
            btSelecionar.PerformClick();
        }

        private void FrmSelecionarTamanhoGrade_KeyDown(object sender, KeyEventArgs e)
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

        private void FrmSelecionarTamanhoGrade_Load(object sender, EventArgs e)
        {
            if (strTamanho != null)
            {
                tbBuscarTamanho.Text = strTamanho;
                btBuscar.PerformClick();
            }
        }


    }
}
