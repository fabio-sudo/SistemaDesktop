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
    public partial class FrmSelecionarFornecedor : Form
    {
        NegFornecedor nFornecedor = new NegFornecedor();
        public FornecedorLista FornecedorLista;
        public Fornecedor FornecedorSelecionado;
        string strFornecedor;

        public FrmSelecionarFornecedor([Optional] string nomeFornecedor)
        {
            InitializeComponent();
            if (nomeFornecedor != String.Empty)
            {
                strFornecedor = nomeFornecedor;
            }
        }

        //atualiza os valores no Data Grid
        private void AtualizarDataGrid()
        {
            this.dgvFornecedor.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.FornecedorLista.Count > 0)
            {
                this.dgvFornecedor.Rows.Add(this.FornecedorLista.Count);
            }
            else
            {
                return;
            }

            int indice = 0;


            foreach (Fornecedor forn in this.FornecedorLista)
            {
                this.dgvFornecedor[0, indice].Value = forn.codigoFornecedor;
                this.dgvFornecedor[1, indice].Value = forn.razaoSocialFornecedor;
                this.dgvFornecedor[2, indice].Value = forn.nomeFantasiaFornecedor;
                forn.cnpjFornecedor = Convert.ToUInt64(forn.cnpjFornecedor).ToString(@"00\.000\.000\/0000\-00");
                this.dgvFornecedor[3, indice].Value = forn.cnpjFornecedor;
                indice++;
            }

            dgvFornecedor.Update();

        }

        //----------------Caixa de Texto
        private void tbFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btBuscar.PerformClick();
                e.Handled = true;
            }
        }

        private void tbFornecedor_Leave(object sender, EventArgs e)
        {
            if (tbFornecedor.Text == "")
            {
                tbFornecedor.Text = "Digite o nome do fornecedor ...";
                pbFornecedor.Image = Properties.Resources.FornecedorAzul;
                panelFornecedor.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                tbFornecedor.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

            }
        }

        private void tbFornecedor_Enter(object sender, EventArgs e)
        {
            tbFornecedor.Clear();
            pbFornecedor.Image = Properties.Resources.FornecedorRosa;
            panelFornecedor.BackColor = Color.DeepPink;
            if (strFornecedor != String.Empty)
            {
                tbFornecedor.Text = strFornecedor;

            }
        }

        //--------------Botões
        private void btBuscar_Click(object sender, EventArgs e)
        {
            string fornecedor;
            fornecedor = tbFornecedor.Text;

            if (tbFornecedor.Text.Equals("Digite o nome do fornecedor ...") || tbFornecedor.Text == string.Empty)
            {
                fornecedor = "";
            }

            this.FornecedorLista = nFornecedor.BuscarFornecedorPorNome(fornecedor);
            AtualizarDataGrid();
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            if (this.dgvFornecedor.Rows.Count > 0)
            {
                int indiceRegistroSelecionado = Convert.ToInt32(dgvFornecedor.CurrentRow.Cells[0].Value);
                foreach (Fornecedor forn in FornecedorLista)
                {
                    if (forn.codigoFornecedor == indiceRegistroSelecionado)
                    {
                        FornecedorSelecionado = forn;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        break;

                    }
                }

            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;

            FrmCadastroFornecedor frmFornecedor = new FrmCadastroFornecedor();
            resultado = frmFornecedor.ShowDialog();

            if (resultado == DialogResult.OK)
            {

                btBuscar.PerformClick();
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvFornecedor.RowCount > 0)
                {
                    int indiceRegistroSelecionado = Convert.ToInt32(dgvFornecedor.CurrentRow.Cells[0].Value);
                    foreach (Fornecedor forn in FornecedorLista)
                    {
                        if (forn.codigoFornecedor == indiceRegistroSelecionado)
                        {

                            FornecedorSelecionado = forn;

                        }


                    }

                    FrmAlterarExcluirFornecedor frmAlterarExcluirFornecedor = new FrmAlterarExcluirFornecedor(FornecedorSelecionado);

                    DialogResult resposta;

                    resposta = frmAlterarExcluirFornecedor.ShowDialog();

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
                "Erro ao selecionar o Fornecedor!",
                Properties.Resources.DialogErro,
                Color.White,
                Color.Black,
                "Ok", "",
                false);
                frmCaixa.ShowDialog();

                //Volata o focu para caixa de texto de busca de Fornecedor
                tbFornecedor.Focus();
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair da Seleção de Fornecedor ?",
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

        //--------------------------Atalhos
        private void FrmSelecionarFornecedor_KeyDown(object sender, KeyEventArgs e)
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

        private void dgvFornecedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btSelecionar.PerformClick();
        }

        private void FrmSelecionarFornecedor_Load(object sender, EventArgs e)
        {
            if (strFornecedor != null)
            {
                tbFornecedor.Text = strFornecedor;
                btBuscar.PerformClick();
            }
        }



    }
}
