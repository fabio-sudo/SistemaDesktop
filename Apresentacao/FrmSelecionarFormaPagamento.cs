using Apresentacao.Formulas;
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
    public partial class FrmSelecionarFormaPagamento : Form
    {
        Metodos metodos = new Metodos();
        NegFormaPagamento nPagamento = new NegFormaPagamento();
        public ListaFormaPagamento pagamentoLista = new ListaFormaPagamento();
        public ListaFormaPagamento pagamentoListaCadastro = new ListaFormaPagamento();
        public ListaFormaPagamento pagamentoListaAtualizar = new ListaFormaPagamento();


        Boolean validaADD = false;
        int indice = 0;

        public FormaPagamento pagamentoSelecionado;
        
        string strFormaPagamento;

        public FrmSelecionarFormaPagamento([Optional] string nomePagamento)
        {
            InitializeComponent();

            if (nomePagamento != String.Empty)
            {
                strFormaPagamento = nomePagamento;
            }
        }

        //--------------Métodos
        //atualiza os valores no Data Grid
        private void AtualizarDataGrid()
        {
            this.dgvFormaPagamento.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.pagamentoLista.Count > 0)
            {
                this.dgvFormaPagamento.Rows.Add(this.pagamentoLista.Count);
            }
            else
            {
                return;
            }

            indice = 0;
            foreach (FormaPagamento pag in this.pagamentoLista)
            {
                this.dgvFormaPagamento[0, indice].Value = pag.codigoFormaPagamento;
                this.dgvFormaPagamento[1, indice].Value = pag.formaPagamento;
                this.dgvFormaPagamento[2, indice].Value = pag.taxaFormaPagamento;
                this.dgvFormaPagamento[3, indice].Value = indice;

                indice++;
            }

            dgvFormaPagamento.Update();

        }

        //---------------Botões
        private void btBuscar_Click(object sender, EventArgs e)
        {
            string strPagamento;
            strPagamento = tbBuscarFormaPagamento.Text;

            if (tbBuscarFormaPagamento.Text.Equals("Digite a Forma de Pagamento ...") || tbBuscarFormaPagamento.Text == string.Empty)
            {
                strPagamento = "";
            }

            this.pagamentoLista = nPagamento.BuscarFormaPagamentoPorNome(strPagamento);
            AtualizarDataGrid();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair da Seleção de Forma de Pagamento ?",
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
          //percorre todas as linhas do gride
            foreach (DataGridViewRow rowGride in dgvFormaPagamento.Rows)
            {
                //Itens a Cadastrar
                if (Convert.ToInt32(rowGride.Cells[0].Value) == 0)
                {
                    FormaPagamento pagamentoCad = new FormaPagamento();

                    if (rowGride.Cells[1].Value != null && rowGride.Cells[2].Value != null)
                    {
                        pagamentoCad.formaPagamento = (rowGride.Cells[1].Value.ToString());
                        pagamentoCad.taxaFormaPagamento = Convert.ToDouble(rowGride.Cells[2].Value.ToString());


                        pagamentoListaCadastro.Add(pagamentoCad);
                    }
                }
                //Itens a Atualizar
                if (Convert.ToInt32(rowGride.Cells[0].Value) != 0)
                {
                    FormaPagamento pagamentoAlt = new FormaPagamento();

                    if (rowGride.Cells[1].Value != null && rowGride.Cells[2].Value != null)
                    {
                        //----Verifica se houve realmente alteração
                        if ((rowGride.Cells[1].Value.ToString() != pagamentoLista[Convert.ToInt32(rowGride.Cells[3].Value)].formaPagamento)||
                        rowGride.Cells[2].Value.ToString() != pagamentoLista[Convert.ToInt32(rowGride.Cells[3].Value)].taxaFormaPagamento.ToString())
                        {

                            pagamentoAlt.codigoFormaPagamento = Convert.ToInt32(rowGride.Cells[0].Value);
                            pagamentoAlt.formaPagamento = (rowGride.Cells[1].Value.ToString());
                            pagamentoAlt.taxaFormaPagamento = Convert.ToDouble(rowGride.Cells[2].Value.ToString());

                            pagamentoListaAtualizar.Add(pagamentoAlt);
                        }
                    }    
                }
            }
            
            //Cadastra
            if (pagamentoListaCadastro.Count > 0) {
                if (nPagamento.CadastrarFormaPagamento(pagamentoListaCadastro) == true)
                {

                    btBuscar.PerformClick();
                }
                else {

                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro - Cadastro",
                    "Não foi possível realizar o cadastro da Forma de Pagamento",
                    Properties.Resources.DialogErro,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Ok", "",
                    false);

                    //Se usuário desejar realizar exclusão da entrada de estoque
                    frmCaixa.ShowDialog();
                
                }
            
            }

            //Atualiza
            if (pagamentoListaAtualizar.Count > 0)
            {
                if (nPagamento.AtualizarFormaPagamento(pagamentoListaAtualizar) == true)
                {

                    btBuscar.PerformClick();
                }
                else
                {

                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro - Atualização",
                    "Não foi possível realizar a atualização da Forma de Pagamento",
                    Properties.Resources.DialogErro,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Ok", "",
                    false);

                    //Se usuário desejar realizar exclusão da entrada de estoque
                    frmCaixa.ShowDialog();

                }

            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (dgvFormaPagamento.RowCount > 0 && dgvFormaPagamento.CurrentRow.Cells[0].Value == null)
            {
                dgvFormaPagamento.Rows.RemoveAt(dgvFormaPagamento.CurrentRow.Index);
            }
            else{
            
            if (this.dgvFormaPagamento.Rows.Count > 0 && pagamentoLista.Count != 0)
            {
              int indiceRegistroSelecionado = Convert.ToInt32(dgvFormaPagamento.CurrentRow.Cells[0].Value);
             
                if (indiceRegistroSelecionado != 0)
                   {
                    foreach (FormaPagamento pag in pagamentoLista)
                    {
                        if (pag.codigoFormaPagamento == indiceRegistroSelecionado)
                        {
                            pagamentoSelecionado = pag;
                            break;
                        }
                    }

                    if (nPagamento.ExcluirFormaPagamento(pagamentoSelecionado) == false)
                    {
                        FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro - Exclusão",
                        "Não foi possível excluir a Forma de Pagamento",
                        Properties.Resources.DialogErro,
                        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                        Color.White,
                        "Ok", "",
                        false);

                        //Se usuário desejar realizar exclusão da entrada de estoque
                        frmCaixa.ShowDialog();
                    }
                    else {
                        btBuscar.PerformClick();
                    
                    }
                }
            }
          }
            //---Atualiza o gride--\\
            btBuscar.PerformClick();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            if (dgvFormaPagamento.RowCount == 0)
            {
                this.dgvFormaPagamento.Rows.Add(1);
                this.dgvFormaPagamento.CurrentRow.Cells[2].Value = "0,00";
                dgvFormaPagamento.CurrentCell = dgvFormaPagamento.Rows[0].Cells[1];
            }

            //percorre todas as linhas do gride
            foreach (DataGridViewRow rowChek in dgvFormaPagamento.Rows)
            {
                if (rowChek.Cells[1].Value != null && rowChek.Cells[2].Value != null)
                {
                    validaADD = true;
                }
                else
                {

                    validaADD = false;
                    break;
                }
            }

            if (validaADD == true)
            {
                dgvFormaPagamento.Rows.Add(1);
                indice = indice + 1;
                dgvFormaPagamento.CurrentCell = dgvFormaPagamento.Rows[indice-1].Cells[1];
                this.dgvFormaPagamento.CurrentRow.Cells[2].Value = "0,00";
            }
        }

        //-------------------Caixa de Texto
        private void tbBuscarFormaPagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btBuscar.PerformClick();
                e.Handled = true;
            }
        }

        private void tbBuscarFormaPagamento_Leave(object sender, EventArgs e)
        {
            if (tbBuscarFormaPagamento.Text == "")
            {
                tbBuscarFormaPagamento.Text = "Digite a Forma de Pagamento ...";
                pbFormaPagamento.Image = Properties.Resources.TaxaIAzul;
                panelBuscarFormaPagamento.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                panelBuscarFormaPagamento.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

            }
        }

        private void tbBuscarFormaPagamento_Enter(object sender, EventArgs e)
        {
            tbBuscarFormaPagamento.Clear();
            pbFormaPagamento.Image = Properties.Resources.TaxaRosa;
            panelBuscarFormaPagamento.BackColor = Color.DeepPink;

            if (strFormaPagamento != String.Empty)
            {
                tbBuscarFormaPagamento.Text = strFormaPagamento;

            }
        }

        //-----------------Formulário
        private void FrmSelecionarFormaPagamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F5) == true)
            {
                btBuscar.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {
                btSair.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F10) == true)
            {
                btCadastrar.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F2) == true)
            {
                btExcluir.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Enter) == true)
            {
                btNovo.PerformClick();
            }
        }

        private void FrmSelecionarFormaPagamento_Load(object sender, EventArgs e)
        {
            if (strFormaPagamento != null)
            {
                tbBuscarFormaPagamento.Text = strFormaPagamento;
            }
            btBuscar.PerformClick();
        }

        private void dgvFormaPagamento_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                //FormaPagamento
                if (dgvFormaPagamento.Columns[e.ColumnIndex].Name == "nomeFormaPagamento")
                {
                    dgvFormaPagamento.Rows[e.RowIndex].ErrorText = "";

                    if (dgvFormaPagamento.Rows[e.RowIndex].IsNewRow) { return; }
                    if (e.FormattedValue.ToString() == "")
                    {
                        dgvFormaPagamento.Rows[e.RowIndex].ErrorText = "Informe a Forma de Pagamento Corretamente";
                    }


                    if (dgvFormaPagamento.CurrentRow.Cells[0].Value == null)
                    {
                        if (nPagamento.ValidarCadastroFormaPagamento(e.FormattedValue.ToString()) != null)
                        {
                            dgvFormaPagamento.Rows[e.RowIndex].ErrorText = "Pagamento já Cadastrado!";
                            dgvFormaPagamento.CurrentRow.Cells[1].Value = null;
                        }
                    }
                
                }
                //Taxa
                if (dgvFormaPagamento.Columns[e.ColumnIndex].Name == "porcentagemTaxa")
                {
                    dgvFormaPagamento.Rows[e.RowIndex].ErrorText = "";
                    double newDouble;

                    if (dgvFormaPagamento.Rows[e.RowIndex].IsNewRow) { return; }
                    if (!double.TryParse(e.FormattedValue.ToString(),
                        out newDouble) || newDouble < 0)
                    {
                        dgvFormaPagamento.Rows[e.RowIndex].ErrorText = "Informe o valor da Taxa Corretamente";
                    }

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

    }
}
