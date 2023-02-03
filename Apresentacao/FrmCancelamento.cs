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
    public partial class FrmCancelamento : Form
    {
        Venda objVenda = new Venda();
        VendaLista objVendaLista = new VendaLista();
        NegVenda nVenda = new NegVenda();

        Crediario objCrediario = new Crediario();
        NegCrediario nCrediario = new NegCrediario();
        NegCliente nCliente = new NegCliente();
        NegFuncionario nFuncionario = new NegFuncionario();
        NegFormaPagamento nPagamento = new NegFormaPagamento();
        ListaFormaPagamento listaPagamento = new ListaFormaPagamento();

        //-----------Var Filtros
        string strnomeCliente = "";
        string strsobrenomeCliente = "";
        string strnomeFuncionario = "";
        string strAVista = "";
        string strCrediarioPago = "";
        string strCrediario = "";

        DateTime dataInicial;

        //Formulario deixa selecionado tipo de cancelamento desejado
        string varTipoCancelamento;


        public FrmCancelamento(string tipoCancelamento)
        {
            InitializeComponent();

            //Recebe paramentro dos formularios para saber qual tipo de cancelamento ideal
            varTipoCancelamento = tipoCancelamento;
        }

        //--------------Métodos
        private void AtualizarDataGrid()
        {
            try
            {
                this.dgvVendaCancela.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

                if (this.objVendaLista.Count > 0)
                {
                    this.dgvVendaCancela.Rows.Add(this.objVendaLista.Count);
                }
                else
                {
                    return;
                }

                int indice = 0;
                foreach (Venda item in this.objVendaLista)
                {
                    if (item.tipoPagamento == "Crediario Pendente")
                    {
                        dgvVendaCancela.Rows[indice].DefaultCellStyle.ForeColor = Color.Red;
                    }

                    //Venda
                    this.dgvVendaCancela[0, indice].Value = item.codigoVenda;
                    this.dgvVendaCancela[1, indice].Value = item.formaPagamento.codigoFormaPagamento;
                    this.dgvVendaCancela[2, indice].Value = item.formaPagamento.formaPagamento;
                    this.dgvVendaCancela[3, indice].Value = item.tipoPagamento;
                    //Valores
                    this.dgvVendaCancela[4, indice].Value = item.quantidadeVenda;
                    this.dgvVendaCancela[5, indice].Value = item.totalVenda;
                    this.dgvVendaCancela[6, indice].Value = item.liquidoVenda;
                    this.dgvVendaCancela[8, indice].Value = item.jurosVenda;
                    this.dgvVendaCancela[7, indice].Value = item.descontoVenda;
                    //Cliente
                    this.dgvVendaCancela[9, indice].Value = item.Cliente.codigoCliente;
                    this.dgvVendaCancela[10, indice].Value = item.Cliente.nomeCliente;
                    this.dgvVendaCancela[11, indice].Value = item.Cliente.sobrenomeCliente;
                    this.dgvVendaCancela[12, indice].Value = Convert.ToUInt64(item.Cliente.cpfCliente).ToString(@"000\.000\.000\-00");
                    //Funcionário
                    this.dgvVendaCancela[13, indice].Value = item.Funcionario.codigoFuncionario;
                    this.dgvVendaCancela[14, indice].Value = item.Funcionario.nomeFuncionario;
                    this.dgvVendaCancela[15, indice].Value = item.Funcionario.sobrenomeFuncionario;
                    //Dados Venda
                    this.dgvVendaCancela[16, indice].Value = item.dataVenda;
                    this.dgvVendaCancela[17, indice].Value = item.estatusVenda;

                    indice++;
                }

                dgvVendaCancela.Update();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void metodoPreencheCamposCliente() {

            //verifica dados do cliente
            if (tbBuscarCliente.Text != "" && tbBuscarCliente.Text != "Digite o nome do cliente ..." && objVenda.Cliente != null)
            {
                tbNome.Text = objVenda.Cliente.nomeCliente;
                tbSobrenome.Text = objVenda.Cliente.sobrenomeCliente;
                mtbCpf.Text = objVenda.Cliente.celularCliente;
                mtbCelular.Text = objVenda.Cliente.cpfCliente;

            }
            else {

                tbNome.Clear();
                tbSobrenome.Clear();
                mtbCpf.Clear();
                mtbCelular.Clear();

                pbOk.Visible = true;
                pbOk.Image = Properties.Resources.DialogErro;
                tgBloqueio.Checked = true;
                lbEstatus.Text = "BLOQUEADO";     
            }

            //---------------Verifica se o cliente está bloqueado ou ativo
            if (objVenda.Cliente != null)
            {
                if (nCrediario.BuscarCrediarioBloqueado(objVenda.Cliente.codigoCliente) != true)
                {
                    pbOk.Visible = true;
                    pbOk.Image = Properties.Resources.DialogOK;
                    tgBloqueio.Checked = false;
                    lbEstatus.Text = "ATIVO";
                }
                else {
                    pbOk.Visible = true;
                    pbOk.Image = Properties.Resources.DialogErro;
                    tgBloqueio.Checked = true;
                    lbEstatus.Text = "BLOQUEADO";             
                }
            }     
        }

        private void metodoFiltros() {
            //-----------------------Tipos de Venda
            if (cbVenda.Checked == true) { strAVista = "ok"; }
            else { strAVista = ""; }

            if (cbCrediarioPago.Checked == true) { strCrediarioPago = "ok"; }
            else { strCrediarioPago = ""; }

            if (cbCrediarioPendente.Checked == true) { strCrediario = "ok"; }
            else { strCrediario = ""; }

            //-----------------------Cliente
            if (objVenda.Cliente != null && objVenda.Cliente.nomeCliente != null)
            {
                strnomeCliente = objVenda.Cliente.nomeCliente;
                strsobrenomeCliente = objVenda.Cliente.sobrenomeCliente;
            }
            else { strnomeCliente = ""; strsobrenomeCliente = ""; }

            //-----------------------Funcionario
            if (objVenda.Funcionario != null && objVenda.Funcionario.nomeFuncionario != null)
            {
                strnomeFuncionario = objVenda.Funcionario.nomeFuncionario;
            }
            else { strnomeFuncionario = ""; }

        }

        private void metodoCalculaTotal() {

            int varQuantidadeTotal= 0;
            double varBruto = 0;
            double varLiquido  = 0;
            double varDesconto = 0;
            double varJuros = 0;
            double varCrediario = 0;

            if (dgvVendaCancela.RowCount > 0) {

                //faz a soma dos totais dos valores do gride
                foreach (DataGridViewRow col in dgvVendaCancela.Rows)
                {
                    if (col.Cells[3].Value.ToString() == "Crediario Pendente")
                    {

                        varCrediario = varCrediario + Convert.ToDouble(col.Cells[5].Value);

                    }
                    else {

                        varBruto = varBruto + Convert.ToDouble(col.Cells[5].Value);
                        varLiquido = varLiquido + Convert.ToInt16(col.Cells[6].Value);                    
                    }
                    
                    varQuantidadeTotal = varQuantidadeTotal + Convert.ToInt32(col.Cells[4].Value);

                    varDesconto = varDesconto + Convert.ToInt16(col.Cells[7].Value);
                    varJuros = varJuros + Convert.ToInt16(col.Cells[8].Value);

                }
            }
            //------------------Preenchendo o a tabela de Valores
            lbValorBrutoCalculo.Text = String.Format("{0:C2}", varBruto);
            lbJurosCalculo.Text = "% "+String.Format("{0:C2}", varJuros);
            lbDescontoCalculo.Text ="- "+ String.Format("{0:C2}", varDesconto);
            lbValorLiquidoCalculo.Text = String.Format("{0:C2}", varLiquido); 

            //------------------Mostradores
            lbEstorno.Text = String.Format("{0:C2}", varBruto);
            lbEstornoLiquido.Text = String.Format("{0:C2}", varLiquido);
            lbDesconto.Text = String.Format("{0:C2}", varDesconto);
            lbTaxa.Text = String.Format("{0:C2}", varJuros);
            lbTotalBruto.Text = String.Format("{0:C2}", varLiquido);//Valor Realmente Recebido das Vendas + juros - desconto

            lbValorLiquido.Text = String.Format("{0:C2}", varCrediario);//Valores dos Crediarios

        }

        //--------------Botões
        private void btBuscar_Click(object sender, EventArgs e)
        {
            metodoFiltros();
            
            objVendaLista = nVenda.BuscarCancelamento(strAVista,strCrediario,strCrediarioPago,strnomeCliente,strsobrenomeCliente,strnomeFuncionario, cbFormaPagamento.Text, dtpDataInicial.Value, dtpDataFinal.Value);
            AtualizarDataGrid();
            metodoCalculaTotal();
        }

        private void btCliente_Click(object sender, EventArgs e)
        {
            metodoFiltros();

            int n;
            bool ehUmNumero = int.TryParse(tbBuscarCliente.Text, out n);
            if (ehUmNumero == true)
            {
                objVenda.Cliente = nCliente.BuscarCancelamentoClientePorCodigo(strAVista, strCrediario, strCrediarioPago, n, strnomeFuncionario, cbFormaPagamento.Text, dtpDataInicial.Value, dtpDataFinal.Value);
                if (objVenda.Cliente != null)
                {
                    this.tbBuscarCliente.Text = objVenda.Cliente.nomeCliente;
                    metodoPreencheCamposCliente();
                    
                    strnomeCliente = objVenda.Cliente.nomeCliente;
                    strsobrenomeCliente = objVenda.Cliente.sobrenomeCliente;

                }
                else
                    tbBuscarCliente.Clear();
            }
            else
            {
                FrmSelecionarClienteCancelamento frmSelecionarCliente = new FrmSelecionarClienteCancelamento(tbBuscarCliente.Text, strAVista, strCrediario, strCrediarioPago, strnomeFuncionario, cbFormaPagamento.Text, dtpDataInicial.Value, dtpDataFinal.Value);
                DialogResult resultado = frmSelecionarCliente.ShowDialog();

                if (resultado == DialogResult.OK)
                {

                    this.objVenda.Cliente = frmSelecionarCliente.clienteSelecionado;
                    this.tbBuscarCliente.Text = objVenda.Cliente.nomeCliente;
                    metodoPreencheCamposCliente();
                    
                    strnomeCliente = objVenda.Cliente.nomeCliente;
                    strsobrenomeCliente = objVenda.Cliente.sobrenomeCliente;
                }

            }

            btBuscar.PerformClick();
        }

        private void btFuncionario_Click(object sender, EventArgs e)
        {
            metodoFiltros();

            int n;
            bool ehUmNumero = int.TryParse(tbFuncionario.Text, out n);
            if (ehUmNumero == true)
            {
                //--------------Funcionarios que estão na Venda e de acordo com vendas feitas para cliente selecionado
                objVenda.Funcionario = nFuncionario.BuscarCancelamentoFuncionarioPorCodigo(strAVista, strCrediario, strCrediarioPago, strnomeCliente, strsobrenomeCliente, n, cbFormaPagamento.Text, dtpDataInicial.Value, dtpDataFinal.Value);
                if (objVenda.Funcionario != null)
                {
                    this.tbFuncionario.Text = objVenda.Funcionario.nomeFuncionario;
                    strnomeFuncionario = objVenda.Funcionario.nomeFuncionario;

                    btBuscar.Focus();
                }
                else
                    tbFuncionario.Clear();
            }
            else
            {

                //---------------Passar paramentros para formulario 
                FrmSelecionarFuncionarioCancelamento frmSelecionarFuncionarioCancelamento = new FrmSelecionarFuncionarioCancelamento(tbFuncionario.Text, strAVista, strCrediario, strCrediarioPago, strnomeCliente, strsobrenomeCliente, cbFormaPagamento.Text, dtpDataInicial.Value, dtpDataFinal.Value);
                DialogResult resultado = frmSelecionarFuncionarioCancelamento.ShowDialog();

                if (resultado == DialogResult.OK)
                {

                    this.objVenda.Funcionario = frmSelecionarFuncionarioCancelamento.FuncionarioSelecionado;
                    this.tbFuncionario.Text = objVenda.Funcionario.nomeFuncionario;
                    strnomeFuncionario = objVenda.Funcionario.nomeFuncionario;
                    btBuscar.Focus();
                }

            }

            btBuscar.PerformClick();
        }

        private void cbFormaPagamento_DropDown(object sender, EventArgs e)
        {
            metodoFiltros();

            try
            {
                cbFormaPagamento.Items.Clear();
                this.listaPagamento = nPagamento.BuscarFormaPagamentoCancelamento(strAVista, strCrediario, strCrediarioPago, strnomeCliente, strsobrenomeCliente, strnomeFuncionario, dtpDataInicial.Value, dtpDataFinal.Value);

                if (listaPagamento.Count > 0)
                {
                    foreach (FormaPagamento pag in listaPagamento)
                    {
                        this.cbFormaPagamento.Items.IndexOf(pag.codigoFormaPagamento);
                        this.cbFormaPagamento.Items.Add(pag.formaPagamento);
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        //--------------Caixa de Texto
        private void tbBuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btCliente.PerformClick();
                e.Handled = true;
            }
        }

        private void tbBuscarCliente_Leave(object sender, EventArgs e)
        {
            if (tbBuscarCliente.Text == "")
            {
                tbBuscarCliente.Text = "Digite o nome do cliente ...";
                pbUsuario.Image = Properties.Resources.ClienteAzul;
                panelBuscarCliente.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                tbBuscarCliente.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                metodoPreencheCamposCliente();
            }
        }

        private void tbBuscarCliente_Enter(object sender, EventArgs e)
        {
            objVenda.Cliente = new Cliente();

            tbBuscarCliente.Clear();
            pbUsuario.Image = Properties.Resources.ClienteRosa;
            panelBuscarCliente.BackColor = Color.DeepPink;
            metodoPreencheCamposCliente();
        }

        private void tbFuncionario_Enter(object sender, EventArgs e)
        {
            objVenda.Funcionario = new Funcionario();

            tbFuncionario.Clear();
            pbFuncionario.Image = Properties.Resources.FuncionarioRosa;
            panelFuncionario.BackColor = Color.DeepPink;
        }

        private void tbFuncionario_Leave(object sender, EventArgs e)
        {
            if (tbFuncionario.Text == "")
            {
                tbFuncionario.Text = "Digite o nome do funcionário ...";
                pbFuncionario.Image = Properties.Resources.FuncionarioAzul;
                panelFuncionario.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                tbFuncionario.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

            }
        }

        private void tbFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btFuncionario.PerformClick();
                e.Handled = true;
            }
        }

        //--------------------Formulário
        private void FrmCancelamento_Load(object sender, EventArgs e)
        {

            if (varTipoCancelamento == "ItemVenda") {

                cbCrediarioPago.Checked = false;
                cbCrediarioPendente.Checked = false;
                cbVenda.Checked = true;

            }
            else if (varTipoCancelamento == "Crediario") {
                
                cbCrediarioPago.Checked = false;
                cbCrediarioPendente.Checked = true;
                cbVenda.Checked = false;

            }
            else if (varTipoCancelamento == "CrediarioPago")
            {
                cbCrediarioPago.Checked = true;
                cbCrediarioPendente.Checked = false;
                cbVenda.Checked = false;
            
            }
            else {

                cbCrediarioPago.Checked = true;
                cbCrediarioPendente.Checked = true;
                cbVenda.Checked = true;
          
            }

             dataInicial = nVenda.BuscarDataVendaCancelamento();
             dtpDataInicial.Value = dataInicial;
             dtpDataInicial.MinDate = dataInicial;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair do Cancelamento ?",
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

        private void btLimpar_Click(object sender, EventArgs e)
        {
             strnomeCliente = "";
             strsobrenomeCliente = "";
             strnomeFuncionario = "";
             strAVista = "";
             strCrediarioPago = "";
             strCrediario = "";

             cbFormaPagamento.Items.Clear();

             tbFuncionario.Text = "Digite o nome do funcionário ...";
             pbFuncionario.Image = Properties.Resources.FuncionarioAzul;
             panelFuncionario.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
             tbFuncionario.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

             tbBuscarCliente.Text = "Digite o nome do cliente ...";
             pbUsuario.Image = Properties.Resources.ClienteAzul;
             panelBuscarCliente.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
             tbBuscarCliente.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
             metodoPreencheCamposCliente();

             dgvVendaCancela.Rows.Clear();

             metodoPreencheCamposCliente();
             metodoCalculaTotal();

             dtpDataInicial.Value = dataInicial;
             dtpDataInicial.MinDate = dataInicial;

             objVenda = new Venda();

        }

        private void cbFormaPagamento_SelectedValueChanged(object sender, EventArgs e)
        {
            btBuscar.PerformClick();
        }

        private void pbLimpar_Click(object sender, EventArgs e)
        {
            btLimpar.PerformClick();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
                        
            if (this.dgvVendaCancela.Rows.Count > 0)
            {
                int indiceRegistroSelecionado = Convert.ToInt32(dgvVendaCancela.CurrentRow.Cells[0].Value);
                int codigoCliente = Convert.ToInt32(dgvVendaCancela.CurrentRow.Cells[9].Value);
                Crediario crediarioCancela = new Crediario();

                //ItemVenda
                if (dgvVendaCancela.CurrentRow.Cells[3].Value.ToString() == "AVista")
                {
                    foreach (Venda venda in objVendaLista)
                    {
                        if (venda.codigoVenda == indiceRegistroSelecionado)
                        {
                            FrmItemVenda frmItemVenda = new FrmItemVenda(venda);
                            frmItemVenda.ShowDialog();
                        }
                    }
                }
                //Crediario Pendente
                else if (dgvVendaCancela.CurrentRow.Cells[3].Value.ToString() == "Crediario Pendente")
                {
                   crediarioCancela = nCrediario.BuscarCrediarioPorCodigo(codigoCliente);
                   FrmItemCrediario frmitemCrediario = new FrmItemCrediario(crediarioCancela);
                   frmitemCrediario.ShowDialog();


                }
                //Crediario Pago ou Pago Parcialmente
                else {

                  crediarioCancela =  nCrediario.BuscarCrediarioPagoPorCodigo(codigoCliente);
                  FrmItemCrediarioPago frmitemCrediarioPago = new FrmItemCrediarioPago(crediarioCancela);
                  frmitemCrediarioPago.ShowDialog();
                
                }

                //Atualiza dados do Gride
                btBuscar.PerformClick();

            }

        }

        private void dgvVendaCancela_DoubleClick(object sender, EventArgs e)
        {
            btCancelar.PerformClick();
        }

        //Teclas de atalho
        private void FrmCancelamento_KeyDown(object sender, KeyEventArgs e)
        {
            //atalho da tecla de atalho ESC
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {
                btSair.PerformClick();
            }
            //atalho para o botão cadastrar
            else if (e.KeyCode.Equals(Keys.F5) == true)
            {
                btBuscar.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.F6) == true)
            {
                btCancelar.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.F2) == true)
            {
                btLimpar.PerformClick();
            }
        }

        private void pbSelecionarCliente_Click(object sender, EventArgs e)
        {
            if (dgvVendaCancela.RowCount > 0)
            {
                metodoFiltros();
                objVenda.Cliente = nCliente.BuscarCancelamentoClientePorCodigo(strAVista, strCrediario, strCrediarioPago, Convert.ToInt32(dgvVendaCancela.CurrentRow.Cells[9].Value), strnomeFuncionario, cbFormaPagamento.Text, dtpDataInicial.Value, dtpDataFinal.Value);
                if (objVenda.Cliente != null)
                {
                    this.tbBuscarCliente.Text = objVenda.Cliente.nomeCliente;
                    metodoPreencheCamposCliente();

                    strnomeCliente = objVenda.Cliente.nomeCliente;
                    strsobrenomeCliente = objVenda.Cliente.sobrenomeCliente;
                }
            }
        }





    }
}
