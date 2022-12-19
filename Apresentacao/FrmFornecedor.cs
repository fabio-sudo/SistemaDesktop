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
    public partial class FrmFornecedor : Form
    {
        NegFornecedor nfornecedor = new NegFornecedor();
        FornecedorLista fornecedorLista;
        public Fornecedor fornecedorSelecionado;

        public FrmFornecedor()
        {
            InitializeComponent();
        }

        //atualiza os valores no Data Grid
        private void AtualizarDataGrid()
        {
            this.dgvFornecedor.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.fornecedorLista.Count > 0)
            {
                this.dgvFornecedor.Rows.Add(this.fornecedorLista.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (Fornecedor forn in this.fornecedorLista)
            {
                this.dgvFornecedor[0, indice].Value = forn.codigoFornecedor;
                this.dgvFornecedor[1, indice].Value = forn.razaoSocialFornecedor;
                this.dgvFornecedor[2, indice].Value = forn.nomeFantasiaFornecedor;
                this.dgvFornecedor[3, indice].Value = forn.cnpjFornecedor;
                this.dgvFornecedor[4, indice].Value = forn.inscricaoEstadualFornecedor;
                this.dgvFornecedor[5, indice].Value = forn.enderecoFornecedor;
                this.dgvFornecedor[6, indice].Value = forn.bairroFornecedor;
                this.dgvFornecedor[7, indice].Value = forn.numeroFornecedor;
                this.dgvFornecedor[8, indice].Value = forn.cidadeFornecedor;
                this.dgvFornecedor[9, indice].Value = forn.estadoFornecedor;
                this.dgvFornecedor[10, indice].Value = forn.cepFornecedor;
                this.dgvFornecedor[11, indice].Value = forn.telefoneFornecedor;
                this.dgvFornecedor[12, indice].Value = forn.celularFornecedor;
                this.dgvFornecedor[13, indice].Value = forn.emailFornecedor;

                indice++;
            }

            dgvFornecedor.Update();

        }

        //Inicia o formulário com a caixa de pesquisa 
        private void FrmFornecedor_Load(object sender, EventArgs e)
        {
            tbBuscarFornecedor.Focus();
        }

        //Retorna Padrão quando txt perde o foco
        private void tbBuscarFornecedor_Leave(object sender, EventArgs e)
        {
            if (tbBuscarFornecedor.Text == "")
            {
                tbBuscarFornecedor.Text = "Digite o nome do fornecedor ...";
                pbFornecedor.Image = Properties.Resources.FornecedorAzul;
                panelBuscarFornecedor.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                tbBuscarFornecedor.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

            }
        }

        //--------------------------------Botões
        private void btBuscar_Click(object sender, EventArgs e)
        {
            string fornecedor;
            fornecedor = tbBuscarFornecedor.Text;

            if (tbBuscarFornecedor.Text.Equals("Digite o nome do fornecedor ...") || tbBuscarFornecedor.Text == string.Empty)
            {
                fornecedor = "";
            }

            this.fornecedorLista = nfornecedor.BuscarFornecedorPorNome(fornecedor);
            AtualizarDataGrid();
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

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvFornecedor.RowCount > 0)
                {
                    int indiceRegistroSelecionado = Convert.ToInt32(dgvFornecedor.CurrentRow.Cells[0].Value);
                    foreach (Fornecedor forn in fornecedorLista)
                    {
                        if (forn.codigoFornecedor == indiceRegistroSelecionado)
                        {

                            fornecedorSelecionado = forn;
                            break;

                        }


                    }

                    //Fornecedor Fornecedor Seolecionado = fornecedo[indiceRegistroSelecionado];

                    FrmAlterarExcluirFornecedor frmAlterarExcluirFornecedor = new FrmAlterarExcluirFornecedor(fornecedorSelecionado);

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

                //Volata o focu para caixa de texto de busca de cliente
                tbBuscarFornecedor.Focus();
            }
        }

        //------------------------------Teclas de Atalho
        private void FrmFornecedor_KeyDown(object sender, KeyEventArgs e)
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

        private void tbBuscarFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btBuscar.PerformClick();
                e.Handled = true;
            }
        }

        //Selecionar fornecedor
        private void dgvFornecedor_DoubleClick(object sender, EventArgs e)
        {
            btSelecionar.PerformClick();
        }

        private void tbBuscarFornecedor_Enter(object sender, EventArgs e)
        {
            tbBuscarFornecedor.Clear();
            pbFornecedor.Image = Properties.Resources.FornecedorRosa;
            panelBuscarFornecedor.BackColor = Color.DeepPink;
            //tbBuscarfornnte.ForeColor = Color.DeepPink;
        }

    }
}