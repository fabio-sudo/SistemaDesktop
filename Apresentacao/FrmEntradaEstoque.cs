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
    public partial class FrmEntradaEstoque : Form
    {
        NegEntradaEstoque nEntradaEstoque = new NegEntradaEstoque();
        EntradaEstoqueLista entradaEstoqueLista;
        public EntradaEstoque entradaSelecionado;
        
        Fornecedor objFornecedor = new Fornecedor();
        NegFornecedor nFornecedor = new NegFornecedor();

        public FrmEntradaEstoque()
        {
            InitializeComponent();
        }

        //atualiza os valores no Data Grid
        private void AtualizarDataGrid()
        {
            this.dgvEntradaEstoque.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.entradaEstoqueLista.Count > 0)
            {
                this.dgvEntradaEstoque.Rows.Add(this.entradaEstoqueLista.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (EntradaEstoque entr in this.entradaEstoqueLista)
            {
                if (entr.estatusEntrada == "Pendente")
                {
                    //Caso item tenha parcial ele fica de cor diferente dos outros itens no gride
                    dgvEntradaEstoque.Rows[indice].DefaultCellStyle.BackColor = Color.DeepSkyBlue;
                }
                
                this.dgvEntradaEstoque[0, indice].Value = entr.codigoEntradaEstoque;
                this.dgvEntradaEstoque[1, indice].Value = entr.notaFiscal;
                this.dgvEntradaEstoque[2, indice].Value = entr.Fornecedor.nomeFantasiaFornecedor;
                this.dgvEntradaEstoque[3, indice].Value = entr.quantidadeProdutosNota;
                this.dgvEntradaEstoque[4, indice].Value = entr.valorTotalNota;
                this.dgvEntradaEstoque[5, indice].Value = entr.dataEntrada;
                this.dgvEntradaEstoque[6, indice].Value = entr.estatusEntrada;

                indice++;
            }

            dgvEntradaEstoque.Update();

        }

        //--------------------Buscar Fornecedor
        private void pbBuscarFornecedor_Click(object sender, EventArgs e)
        {
            int n;
            bool ehUmNumero = int.TryParse(tbFornecedor.Text, out n);
            if (ehUmNumero == true)
            {
                objFornecedor = nFornecedor.BuscarFornecedorPorCodigo(n);
                if (objFornecedor != null)
                {
                    this.tbFornecedor.Text = objFornecedor.nomeFantasiaFornecedor;
                    btBuscar.Focus();
                    btBuscar.PerformClick();
                }
                else
                    tbFornecedor.Clear();
            }
            else
            {
                FrmSelecionarFornecedor frmSelecionarFornecedor = new FrmSelecionarFornecedor(tbFornecedor.Text);
                DialogResult resultado = frmSelecionarFornecedor.ShowDialog();

                if (resultado == DialogResult.OK)
                {

                    this.objFornecedor = frmSelecionarFornecedor.FornecedorSelecionado;
                    this.tbFornecedor.Text = objFornecedor.nomeFantasiaFornecedor;
                    btBuscar.Focus();
                    btBuscar.PerformClick();
                }

            }    
        }

        private void tbFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbBuscarFornecedor_Click(null, null);
                e.Handled = true;
            }
        }

        private void tbNotaFiscal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btBuscar.PerformClick();
                tbFornecedor.Focus();
            }
        }

        //-------------------Buscar Entrada de Estoque
        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (tbNotaFiscal.Text != string.Empty && tbFornecedor.Text == string.Empty)
            {
                this.entradaEstoqueLista = nEntradaEstoque.BuscarEntradaEstoquePorNotaFiscal(tbNotaFiscal.Text);
            }
            else if (tbNotaFiscal.Text == string.Empty && tbFornecedor.Text != string.Empty)
            {
                this.entradaEstoqueLista = nEntradaEstoque.BuscarEntradaEstoquePorFornecedor(objFornecedor.codigoFornecedor);
            }
            else if (tbNotaFiscal.Text != string.Empty && tbFornecedor.Text != string.Empty)
            {
                this.entradaEstoqueLista = nEntradaEstoque.BuscarEntradaEstoquePorNotaFiscalEFornecedor(tbNotaFiscal.Text, objFornecedor.codigoFornecedor);
            }
            else {
                this.entradaEstoqueLista = nEntradaEstoque.BuscarEntradaEstoqueTodas();
            
            }

            AtualizarDataGrid();

        }

        private void pbFiltrar_Click(object sender, EventArgs e)
        {
            tbFornecedor.Clear();
            tbNotaFiscal.Clear();
            dgvEntradaEstoque.Rows.Clear();

            if (dtpDataInicial.Value <= dtpDataFinal.Value)
            {
                this.entradaEstoqueLista = nEntradaEstoque.BuscarEntradaEstoquePorData(dtpDataInicial.Value, dtpDataFinal.Value);
                AtualizarDataGrid();

                if (dgvEntradaEstoque.Rows.Count == 0)
                {
                    MessageBox.Show("Não a lançamento nesse periodo!",
                  "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
                MessageBox.Show("Período Inicial não pode ser maior doque Período Final!",
               "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
         

        }

        //------------------Botões
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            FrmCadastroEntradaEstoque frmCadastroEstoque = new FrmCadastroEntradaEstoque(null);
            resultado = frmCadastroEstoque.ShowDialog();

            if (resultado == DialogResult.Yes)
            {
                btBuscar.PerformClick();
            }
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEntradaEstoque.RowCount > 0)
                {
                    int indiceRegistroSelecionado = Convert.ToInt32(dgvEntradaEstoque.CurrentRow.Cells[0].Value);
                    foreach (EntradaEstoque ent in entradaEstoqueLista)
                    {
                        if (ent.codigoEntradaEstoque == indiceRegistroSelecionado)
                        {

                            entradaSelecionado = ent;
                            break;

                        }


                    }


                    if (entradaSelecionado.estatusEntrada == "Concluido")
                    {
                        FrmAlterarExcluirEntradaEstoque frmAlterarExcluirEntrada = new FrmAlterarExcluirEntradaEstoque(entradaSelecionado);
                        DialogResult resposta;

                        resposta = frmAlterarExcluirEntrada.ShowDialog();

                        if (resposta == DialogResult.Yes)
                        {
                            btBuscar.PerformClick();
                        }
                    }
                    else//Pendente ou Vazio
                    {
                        FrmCadastroEntradaEstoque frmCadastrarEntrada = new FrmCadastroEntradaEstoque(entradaSelecionado);
                        DialogResult resposta;

                        resposta = frmCadastrarEntrada.ShowDialog();

                        if (resposta == DialogResult.Yes)
                        {
                            btBuscar.PerformClick();
                        }               
                    }


                }

            }
            catch
            {
                //Criando Caixa de dialogo
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro",
                "Erro ao selecionar o Entrada de Estoque!",
                Properties.Resources.DialogErro,
                Color.White,
                Color.Black,
                "Ok", "",
                false);
                frmCaixa.ShowDialog();

                //Volata o focu para caixa de texto de busca de cliente
                tbNotaFiscal.Focus();
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {

            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair da Entrada de Estoque ?",
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

        //------------------------Formulário
        private void dgvEntradaEstoque_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btSelecionar.PerformClick();
        }

        private void FrmEntradaEstoque_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void FrmEntradaEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F5) == true)
            {
                btBuscar.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F2) == true)
            {
                btSelecionar.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F10) == true)
            {
                btCadastrar.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {
                btSair.PerformClick();

            }
        }


    }
}
