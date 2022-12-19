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
    public partial class FrmSelecionarCorProduto : Form
    {
        NegCor nCor = new NegCor();
        public CorLista corLista;
        public Cor corSelecionado;

        public int intProduto;
        public string strCor;

        public FrmSelecionarCorProduto(int codigoProduto, [Optional] string nomeCor)
        {
            InitializeComponent();

            intProduto = codigoProduto;

            if (nomeCor != String.Empty)
            {
                strCor = nomeCor;
            }
        }

        //atualiza os valores no Data Grid
        private void AtualizarDataGrid()
        {
            this.dgvCor.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.corLista.Count > 0)
            {
                this.dgvCor.Rows.Add(this.corLista.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (Cor cor in this.corLista)
            {
                this.dgvCor[0, indice].Value = cor.codigoCor;
                this.dgvCor[1, indice].Value = cor.nomeCor;

                indice++;
            }

            dgvCor.Update();

        }

        //-----------Botões
        private void btBuscar_Click(object sender, EventArgs e)
        {
            string strCor;
            strCor = tbBuscarCor.Text;

            if (tbBuscarCor.Text.Equals("Digite a Cor do Produto ...") || tbBuscarCor.Text == string.Empty)
            {
                strCor = "";
            }

            this.corLista = nCor.BuscarCorProdutoPorNome(intProduto,strCor);
            AtualizarDataGrid();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;

            FrmCadastroCor frmCor = new FrmCadastroCor();
            resultado = frmCor.ShowDialog();

            if (resultado == DialogResult.OK)
            {

                btBuscar.PerformClick();
            }
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            if (this.dgvCor.Rows.Count > 0)
            {
                int indiceRegistroSelecionado = Convert.ToInt32(dgvCor.CurrentRow.Cells[0].Value);
                foreach (Cor cor in corLista)
                {
                    if (cor.codigoCor == indiceRegistroSelecionado)
                    {
                        corSelecionado = cor;
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
                if (dgvCor.RowCount > 0)
                {
                    int indiceRegistroSelecionado = Convert.ToInt32(dgvCor.CurrentRow.Cells[0].Value);
                    foreach (Cor cor in corLista)
                    {
                        if (cor.codigoCor == indiceRegistroSelecionado)
                        {

                            corSelecionado = cor;
                            break;

                        }


                    }

                    FrmAlterarExcluirCor frmAlterarExcluirCor = new FrmAlterarExcluirCor(corSelecionado);

                    DialogResult resposta;

                    resposta = frmAlterarExcluirCor.ShowDialog();

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
                "Erro ao selecionar o Cor!",
                Properties.Resources.DialogErro,
                Color.White,
                Color.Black,
                "Ok", "",
                false);
                frmCaixa.ShowDialog();

                //Volata o focu para caixa de texto de busca de Funcionario
                tbBuscarCor.Focus();
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair da Seleção de Cor ?",
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

        //-------------Caixa de Texto
        private void tbBuscarCor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btBuscar.PerformClick();
                e.Handled = true;
            }
        }

        private void tbBuscarCor_Leave(object sender, EventArgs e)
        {
            if (tbBuscarCor.Text == "")
            {
                tbBuscarCor.Text = "Digite a Cor do Produto ...";
                pbCor.Image = Properties.Resources.CorAzul;
                panelBuscarCor.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                panelBuscarCor.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

            }
        }

        private void tbBuscarCor_Enter(object sender, EventArgs e)
        {
            tbBuscarCor.Clear();
            pbCor.Image = Properties.Resources.CorRosa;
            panelBuscarCor.BackColor = Color.DeepPink;

            if (strCor != String.Empty)
            {
                tbBuscarCor.Text = strCor;

            }
        }

        private void FrmSelecionarCorProduto_KeyDown(object sender, KeyEventArgs e)
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

        private void dgvCor_DoubleClick(object sender, EventArgs e)
        {
            btSelecionar.PerformClick();
        }

        private void FrmSelecionarCorProduto_Load(object sender, EventArgs e)
        {
            if (strCor != null)
            {
                tbBuscarCor.Text = strCor;
                btBuscar.PerformClick();
            }
        }
    }
}
