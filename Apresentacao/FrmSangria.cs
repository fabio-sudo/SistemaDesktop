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
    public partial class FrmSangria : Form
    {
        Sangria objSangria = new Sangria();
        Sangria objSangriaSelecionada = new Sangria();
        SangriaLista listaSangria = new SangriaLista();
        string nomeFuncionario = "";

        List<string> formaPagamentoLista = new List<string>();
        SangriaLista listaPagamento = new SangriaLista();

        NegFuncionario nFuncionario = new NegFuncionario();
        NegSangria nSangria = new NegSangria();

        public FrmSangria()
        {
            InitializeComponent();
        }

        private void metodoLimpaGride() {

            //Metodo Zera Data Gride
            while (dgvSangria.ColumnCount > 5)
            {

                dgvSangria.Columns.RemoveAt(dgvSangria.ColumnCount - 1); //Index da coluna 'ArquivoExcelId'

            }

            //Limpa Data Gride
            this.dgvSangria.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.
            lbSangria.Text = String.Format("{0:C2}", 0);
        
        }

        private void metodoCalcula() {

            lbSangria.Text = String.Format("{0:C2}", listaPagamento.Sum(t => t.valorSangria));
        
        
        }

        private void metodoIniciaFormulario() { 
        
        }

        private void metodoAddColunasGride() {
       
            listaPagamento = nSangria.BuscarPagamentoSangriaPorData(dtpDataInicial.Value, dtpDataFinal.Value, nomeFuncionario);

            //------------------------------Preenche Gride novas colunas Forma de Pagamento
            //Metodo Zera Data Gride
            while (dgvSangria.ColumnCount > 5)
            {

                dgvSangria.Columns.RemoveAt(dgvSangria.ColumnCount - 1); //Index da coluna 'ArquivoExcelId'

            }

            //Limpa Data Gride
            this.dgvSangria.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.


            //Conta as Formas de Pagamento
            formaPagamentoLista = new List<string>();

            foreach (Sangria sang in listaPagamento)
            {

                formaPagamentoLista.Add(sang.pagamentoSangria.formaPagamento);

            }

            //Adiciona novas colunas ao data gride
            foreach (string formaPagamento in formaPagamentoLista.Distinct())
            {
                // Initialize the button column.
                DataGridViewTextBoxColumn novaColuna =
                new DataGridViewTextBoxColumn();
                novaColuna.Name = formaPagamento;
                novaColuna.HeaderText = formaPagamento;
                dgvSangria.Columns.Insert(5, novaColuna);
                dgvSangria.Columns[formaPagamento].DefaultCellStyle.Format = "C2";
                dgvSangria.Columns[formaPagamento].ReadOnly = false;
      
            }

            //-------------------------------------------------------------------------------
        
        
        }

        //atualiza os valores no Data Grid
        private void AtualizarDataGrid()
        {
            try
            {
                if (listaSangria != null)
                {
                    metodoAddColunasGride();//Adiciona colunas de pagamentos no DataGride filtrando as formas de pagamento
                    metodoCalcula();//Calcula totais

                    //Conta o númeo de colunas
                    int numeroDeColunas = formaPagamentoLista.Distinct().Count() + 4;//Novas Colunas Mais colunas existentes
                    int indicePagamento = 5;//Pegar coluna referente ao pagamento

                    this.dgvSangria.Rows.Add(1);//Adiciona coluna para preencher os dados 

                    int indice = 0;
                    foreach (Sangria sang in this.listaSangria)
                    {
                        this.dgvSangria[0, indice].Value = sang.ordemSangra;
                        this.dgvSangria[1, indice].Value = sang.dataSangria;
                        this.dgvSangria[2, indice].Value = sang.funcionarioSangria.codigoFuncionario;
                        this.dgvSangria[3, indice].Value = sang.funcionarioSangria.nomeFuncionario;
                        this.dgvSangria[4, indice].Value = sang.estatusSangria;

                        //--------------------------------------------------------Percorre DataGride Preenchendo as formas de pagamento
                        int indicePagamentoSangria = 5;

                        while (indicePagamentoSangria < dgvSangria.Columns.Count)
                        {
                            if (listaPagamento.Count == 0) { break; }

                            int indiceNaoTem = 0;
                            List<Sangria> sangriaLista = new SangriaLista();

                            sangriaLista = listaPagamento.Where(x => x.dataSangria == sang.dataSangria).Where(f => f.pagamentoSangria.formaPagamento == dgvSangria.Columns[indicePagamentoSangria].HeaderText).OrderBy(t => t.pagamentoSangria.formaPagamento).ToList();

                                foreach (Sangria pagamento in sangriaLista)
                                {
                                    if (pagamento.ordemSangra == sang.ordemSangra && pagamento.funcionarioSangria.codigoFuncionario == sang.funcionarioSangria.codigoFuncionario &&
                                        pagamento.pagamentoSangria.formaPagamento == dgvSangria.Columns[indicePagamentoSangria].HeaderText && pagamento.dataSangria == sang.dataSangria)
                                    {
                                        this.dgvSangria[indicePagamentoSangria, indice].Value = pagamento.valorSangria;
                                        listaPagamento.Remove(pagamento);
                                        indicePagamentoSangria++;
                                        break;
                                    }
                                    else
                                    {

                                        this.dgvSangria[indicePagamentoSangria, indice].Value = 0.00;
                                        indiceNaoTem++;
                                    }

                                    if (indiceNaoTem >= sangriaLista.Count) { indicePagamentoSangria++; }//Se todos os valores da lista forem comparados pula coluna
                                }

                                if (sangriaLista.Count == 0) { indicePagamentoSangria++; }
                            }                      
                        //-----------------------------------------------------------------


                        if (indicePagamento > numeroDeColunas) { indicePagamento = 5; }//Restaura o contador para não exceder o idice             


                        indicePagamento++;
                        indice++;

                        if (dgvSangria.Rows.Count < listaSangria.Count)
                        {
                            this.dgvSangria.Rows.Add(1);
                        }
                    }

                    dgvSangria.Update();
                }
                else { metodoLimpaGride(); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message);}
        }

        //-----------------------Caixa de Texto
        private void tbBuscarFuncionario_Enter(object sender, EventArgs e)
        {
            tbBuscarFuncionario.Clear();
            pbFuncionario.Image = Properties.Resources.FuncionarioRosa;
            panelBuscarFuncionario.BackColor = Color.DeepPink;
        }

        private void tbBuscarFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbFuncionario_Click(null, null);
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

        //-------------------------Formulário
        private void FrmSangria_Load(object sender, EventArgs e)
        {

        }

        //-------------------------Botões
        private void pbFuncionario_Click(object sender, EventArgs e)
        {
            int n;
            bool ehUmNumero = int.TryParse(tbBuscarFuncionario.Text, out n);
            if (ehUmNumero == true)
            {
                objSangria.funcionarioSangria = nFuncionario.BuscarFuncionarioPorCodigo(n);
                if (objSangria.funcionarioSangria != null)
                {
                    this.tbBuscarFuncionario.Text = objSangria.funcionarioSangria.nomeFuncionario; ;
                    dgvSangria.Focus();
                }
                else
                    tbBuscarFuncionario.Clear();
            }
            else
            {
                FrmSelecionarFuncionario frmSelecionarFuncionario = new FrmSelecionarFuncionario(tbBuscarFuncionario.Text);
                DialogResult resultado = frmSelecionarFuncionario.ShowDialog();

                if (resultado == DialogResult.OK)
                {

                    this.objSangria.funcionarioSangria = frmSelecionarFuncionario.FuncionarioSelecionado;
                    this.tbBuscarFuncionario.Text = objSangria.funcionarioSangria.nomeFuncionario;
                    dgvSangria.Focus();
                }

            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastroSangria cadSangria = new FrmCadastroSangria();
            DialogResult result = cadSangria.ShowDialog();

            if (result == DialogResult.Yes) {

                metodoIniciaFormulario();
            
            }
            
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            try{
            if (this.dgvSangria.Rows.Count > 0)
            {
                int indiceRegistroSelecionado = Convert.ToInt32(dgvSangria.CurrentRow.Cells[0].Value);
                int indiceFuncionarioSelecionado = Convert.ToInt32(dgvSangria.CurrentRow.Cells[2].Value);
                DateTime dataSangriaSelecionada = Convert.ToDateTime(dgvSangria.CurrentRow.Cells[1].Value);

                foreach (Sangria sang in listaSangria)
                {
                    if (sang.ordemSangra == indiceRegistroSelecionado && sang.funcionarioSangria.codigoFuncionario == indiceFuncionarioSelecionado && sang.dataSangria == dataSangriaSelecionada)
                    {
                        objSangriaSelecionada = sang;
                        break;

                    }
                }

                   FrmAlterarExcluirSangria frmAlterarExcluirSangria = new FrmAlterarExcluirSangria(objSangriaSelecionada);                  
                    DialogResult resposta;


                    resposta = frmAlterarExcluirSangria.ShowDialog();

                    btBuscar.PerformClick();
                }
               
            }
            catch
            {
                //Criando Caixa de dialogo
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro",
                "Erro ao selecionar o Sangria!",
                Properties.Resources.DialogErro,
                Color.White,
                Color.Black,
                "Ok", "",
                false);
                frmCaixa.ShowDialog();

                //Volata o focu para caixa de texto de busca de cliente
                tbBuscarFuncionario.Focus();
            }
         }

        private void btSair_Click(object sender, EventArgs e)
        {

            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação Sair",
            " Deseja realmente sair da Sangria ?",
            Properties.Resources.DialogQuestion,
            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
            Color.White,
            "Sim", "Não",
            false);

            resposta = frmCaixa.ShowDialog();
            if (resposta == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Yes;
                this.Close();

            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {

            if (tbBuscarFuncionario.Text == string.Empty || tbBuscarFuncionario.Text == "Digite o nome do funcionário ...")
            {

                nomeFuncionario = "";
            }
            else { nomeFuncionario = tbBuscarFuncionario.Text; }

            listaSangria = new SangriaLista();
            listaPagamento = new SangriaLista();

            listaSangria = nSangria.BuscarSangriaPorData(dtpDataInicial.Value, dtpDataFinal.Value, nomeFuncionario);
            
            AtualizarDataGrid();
        }

        private void pbFiltrar_Click(object sender, EventArgs e)
        {

            listaSangria = nSangria.BuscarSangriaPorData(dtpDataInicial.Value, dtpDataFinal.Value, "");
            AtualizarDataGrid();
        }

        private void pbBuscarFuncionario_Click(object sender, EventArgs e)
        {
            int n;
            bool ehUmNumero = int.TryParse(tbBuscarFuncionario.Text, out n);
            if (ehUmNumero == true)
            {
                objSangria.funcionarioSangria = nFuncionario.BuscarFuncionarioPorCodigo(n);
                if (objSangria.funcionarioSangria != null)
                {
                    this.tbBuscarFuncionario.Text = objSangria.funcionarioSangria.nomeFuncionario; ;
                    dgvSangria.Focus();
                }
                else
                    tbBuscarFuncionario.Clear();
            }
            else
            {
                FrmSelecionarFuncionario frmSelecionarFuncionario = new FrmSelecionarFuncionario(tbBuscarFuncionario.Text);
                DialogResult resultado = frmSelecionarFuncionario.ShowDialog();

                if (resultado == DialogResult.OK)
                {

                    this.objSangria.funcionarioSangria = frmSelecionarFuncionario.FuncionarioSelecionado;
                    this.tbBuscarFuncionario.Text = objSangria.funcionarioSangria.nomeFuncionario;
                    dgvSangria.Focus();
                }

            }
        }

        private void dgvSangria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btSelecionar.PerformClick();
        }

        private void FrmSangria_KeyDown(object sender, KeyEventArgs e)
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
        }




    }
}
