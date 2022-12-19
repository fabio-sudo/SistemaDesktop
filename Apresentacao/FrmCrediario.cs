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
    public partial class FrmCrediario : Form
    {
        Crediario objCrediario = new Crediario();
        Crediario crediarioSelecionado = new Crediario();
        CrediarioLista listaCrediario = new CrediarioLista();
        NegCrediario nCrediario = new NegCrediario();

        //Cliente
        NegCliente nCliente = new NegCliente();

        public FrmCrediario()
        {
            InitializeComponent();
        }

        //atualiza os valores no Data Grid
        private void AtualizarDataGrid()
        {
            this.dgvCrediario.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.listaCrediario.Count > 0)
            {
                this.dgvCrediario.Rows.Add(this.listaCrediario.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (Crediario cred in this.listaCrediario)
            {
                this.dgvCrediario[0, indice].Value = cred.codigoCrediario;
                this.dgvCrediario[1, indice].Value = cred.Cliente.nomeCliente;
                this.dgvCrediario[2, indice].Value = cred.Cliente.sobrenomeCliente;
                this.dgvCrediario[3, indice].Value = cred.Cliente.cpfCliente;
                this.dgvCrediario[4, indice].Value = cred.Cliente.celularCliente;
                this.dgvCrediario[5, indice].Value = cred.Cliente.enderecoCliente;
                this.dgvCrediario[6, indice].Value = cred.Cliente.bairroCliente;
                this.dgvCrediario[7, indice].Value = cred.Cliente.numeroCliente;
                this.dgvCrediario[8, indice].Value = cred.Cliente.cepCliente;
                this.dgvCrediario[9, indice].Value = cred.Cliente.cidadeCliente;
                this.dgvCrediario[10, indice].Value = cred.quantidadeCrediario;
                this.dgvCrediario[11, indice].Value = cred.contaCrediario;
                this.dgvCrediario[12, indice].Value = cred.dataCrediario;
                this.dgvCrediario[13, indice].Value = cred.estatusCrediario;

                //Exibe que o cliente está bloqueado
                if (cred.estatusCrediario == "BLOQUEADO") {

                    dgvCrediario.Rows[indice].ErrorText = "CONTA BLOQUEADA!";
                    //Caso item tenha parcial ele fica de cor diferente dos outros itens no gride
                    dgvCrediario.Rows[indice].DefaultCellStyle.ForeColor = Color.White;
                    dgvCrediario.Rows[indice].DefaultCellStyle.BackColor = Color.Red;
                }
                //Verifica se parcelas atrasadas no crediario
                else if (nCrediario.BuscarCrediarioVencimento(cred.codigoCrediario) == true && cred.estatusCrediario != "BLOQUEADO")
                {

                    dgvCrediario.Rows[indice].ErrorText = "Parcelas Atrasadas!";
                }

                indice++;
            }

            dgvCrediario.Update();

        }

        public void metodoCalculaTotais()
        {

            int varQuantidadeTotal = 0;
            double varCrediarioTotal = 0;

            if (dgvCrediario.RowCount > 0)
            {

                //faz a soma dos totais dos valores do gride
                foreach (DataGridViewRow col in dgvCrediario.Rows)
                {
                    varQuantidadeTotal = varQuantidadeTotal + Convert.ToInt32(col.Cells[10].Value);
                    varCrediarioTotal = varCrediarioTotal + Convert.ToDouble(col.Cells[11].Value);
                }
            }
            //preencher as quantidade totais
            lbQuantidadeCrediario.Text = varQuantidadeTotal.ToString();
            lbCrediarioTotal.Text = String.Format("{0:C2}", varCrediarioTotal);
        }

        public void metodoBuscaCrediario() { 
        
         string EstatusCrediario = "";
         string nomeClienteCrediario = "";

         //Estatus
         if (cbEstatus.Checked == true && cbPendente.Checked == true || cbEstatus.Checked == true && cbPagos.Checked == true) {

             EstatusCrediario = "";//Traz todos
         
         }
         else if(cbEstatus.Checked == true){
         
             EstatusCrediario = "BLOQUEADO";//BLOQUEADO 

         }
         else
         {

             EstatusCrediario = "ATIVO";
         }
        //Cliente
         if (tbBuscarClienteCrediario.Text == "Digite o nome do cliente ..." || tbBuscarClienteCrediario.Text.Equals(String.Empty))
         {

             nomeClienteCrediario = "";

         }
         else
         {

             nomeClienteCrediario = tbBuscarClienteCrediario.Text;
         }

         if (cbPagos.Checked == true)
         {
             listaCrediario = nCrediario.BuscarCrediarioPagoPorNome(nomeClienteCrediario, mtbCpf.Text, EstatusCrediario);
         }
         else
         {
             listaCrediario = nCrediario.BuscarCrediarioPorNome(nomeClienteCrediario, mtbCpf.Text, EstatusCrediario);
         } 
         AtualizarDataGrid();
         metodoCalculaTotais();
         metodoExibeCliente();
         
        
        }

        private void metodoExibeCliente() {

            if (dgvCrediario.RowCount > 0)
            {
                lbTotalCliente.Text = String.Format("{0:C2}", Convert.ToDouble(dgvCrediario.CurrentRow.Cells[11].Value));
                if (dgvCrediario.CurrentRow.Cells[13].Value.ToString() == "BLOQUEADO")
                {
                    pbOk.Visible = true;
                    pbOk.Image = Properties.Resources.DialogErro;
                    lbTituloTotalCliente.Text = dgvCrediario.CurrentRow.Cells[1].Value.ToString();
                }
                else {
                    pbOk.Visible = true;
                    pbOk.Image = Properties.Resources.DialogOK;
                    lbTituloTotalCliente.Text = dgvCrediario.CurrentRow.Cells[1].Value.ToString();
                }
            }
        }
        //----------------Botões
        private void pbBuscarCrediario_Click(object sender, EventArgs e)
        {
            metodoBuscaCrediario();
        }

        private void pbCliente_Click(object sender, EventArgs e)
        {
            int n;
            bool ehUmNumero = int.TryParse(tbBuscarClienteCrediario.Text, out n);
            if (ehUmNumero == true)
            {
                objCrediario.Cliente = nCliente.BuscarClientePorCodigo(n);
                if (objCrediario.Cliente != null)
                {
                    this.tbBuscarClienteCrediario.Text = objCrediario.Cliente.nomeCliente;

                    pbBuscarCrediario_Click(null, null);

                }
            }
                else
                {
                    FrmSelecionarCliente frmSelecionarCliente = new FrmSelecionarCliente(tbBuscarClienteCrediario.Text);
                    DialogResult resultado = frmSelecionarCliente.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        this.objCrediario.Cliente = frmSelecionarCliente.clienteSelecionado;
                        this.tbBuscarClienteCrediario.Text = objCrediario.Cliente.nomeCliente;

                        pbBuscarCrediario_Click(null, null);
                    }

                }
            }

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair do Crediario?",
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

        private void pbLimpar_Click(object sender, EventArgs e)
        {
            pbOk.Visible = false;
            tbBuscarClienteCrediario.Text = "Digite o nome do cliente ...";
            mtbCpf.Clear();
            dgvCrediario.Rows.Clear();
            lbTituloTotalCliente.Text = "Conta Cliente";
            lbQuantidadeCrediario.Text = "0";
            lbCrediarioTotal.Text = "0,00";
            lbTotalCliente.Text = "0,00";

        }

        private void pbFiltrar_Click(object sender, EventArgs e)
        {
            if (cbPagos.Checked == true)
            {
                listaCrediario = nCrediario.BuscarCrediarioPagoPorData(dtpDataInicial.Value, dtpDataFinal.Value);
            }
            else {

                listaCrediario = nCrediario.BuscarCrediarioPorData(dtpDataInicial.Value, dtpDataFinal.Value);
            }
           AtualizarDataGrid();
           metodoCalculaTotais();
        }

        private void btReceber_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCrediario.RowCount > 0)
                {
                    int indiceRegistroSelecionado = Convert.ToInt32(dgvCrediario.CurrentRow.Cells[0].Value);
                    foreach (Crediario cre in listaCrediario)
                    {
                        if (cre.codigoCrediario == indiceRegistroSelecionado)
                        {

                            crediarioSelecionado = cre;
                            break;

                        }

                    }

                    if (cbPagos.Checked == true) {

                        FrmItemCrediarioPago frmItemCrediarioPago = new FrmItemCrediarioPago(crediarioSelecionado);

                        DialogResult resposta;

                        resposta = frmItemCrediarioPago.ShowDialog();

                        if (resposta == DialogResult.Yes)
                        {
                            //atualizar o gride quando o formulario voltar ao foco
                            pbBuscarCrediario_Click(null, null);
                        }
                    }
                    else
                    {

                        FrmItemCrediario frmItemCrediario = new FrmItemCrediario(crediarioSelecionado);
                        DialogResult resposta;

                        resposta = frmItemCrediario.ShowDialog();

                        if (resposta == DialogResult.Yes)
                        {
                            //atualizar o gride quando o formulario voltar ao foco
                            pbBuscarCrediario_Click(null, null);
                        }
                    }
                }
            }
            catch
            {
                //Criando Caixa de dialogo
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro",
                "Erro ao selecionar o Crediario!",
                Properties.Resources.DialogErro,
                Color.White,
                Color.Black,
                "Ok", "",
                false);
                frmCaixa.ShowDialog();

                //Volata o focu para caixa de texto de busca de cliente
                tbBuscarClienteCrediario.Focus();
            }
        }

        private void btParcial_Click(object sender, EventArgs e)
        {
            FrmSelecionarParcialCrediario frmParcialCrediario = new FrmSelecionarParcialCrediario(null,null);
            frmParcialCrediario.ShowDialog();
            pbBuscarCrediario_Click(null, null);
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            metodoBuscaCrediario();
        }

        //-----------------Caixa de Texto
        private void tbBuscarClienteCrediario_Enter(object sender, EventArgs e)
        {
            tbBuscarClienteCrediario.Clear();
            pbCliente.Image = Properties.Resources.ClienteRosa;
            panelBuscarCliente.BackColor = Color.DeepPink;
        }

        private void tbBuscarClienteCrediario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbCliente_Click(null,null);
                e.Handled = true;
            }
        }

        private void tbBuscarClienteCrediario_Leave(object sender, EventArgs e)
        {
            if (tbBuscarClienteCrediario.Text == "")
            {
                tbBuscarClienteCrediario.Text = "Digite o nome do cliente ...";
                pbCliente.Image = Properties.Resources.ClienteAzul;
                panelBuscarCliente.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                tbBuscarClienteCrediario.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

            }
        }

        private void mtbCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbBuscarCrediario_Click(null, null);
                e.Handled = true;
            }
        }

        //-------------------DataGride
        private void dgvCrediario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            metodoExibeCliente();
        }

        private void FrmCrediario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F5) == true)
            {
               pbBuscarCrediario_Click(null,null);
            }
            if (e.KeyCode.Equals(Keys.F10) == true)
            {
                btReceber.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F2) == true)
            {
                btCancelar.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {
                btSair.PerformClick();
            }
        }

        private void dgvCrediario_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btReceber.PerformClick();
        }

        //------------------Filtros
        private void cbPagos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPagos.Checked == true)
            {
                btReceber.Text = "F10 Selecionar";
                btReceber.BackColor = Color.Yellow;
                btReceber.ForeColor = Color.Black;

                pbCrediarioAviso.Visible = true;
                pbCrediarioAviso.Image = Properties.Resources.CrediarioPagoAviso;
                lbAvisoCrediario.Visible = true;
                lbAvisoCrediario.Text = "Crediario Recebido";

                cbPendente.Checked = false;
                pbLimpar_Click(null, null);
            }
            else {

                btReceber.Text = "F10 Receber";
                btReceber.BackColor = Color.DeepSkyBlue;
                btReceber.ForeColor = Color.White;

                pbCrediarioAviso.Visible = true;
                pbCrediarioAviso.Image = Properties.Resources.CrediarioPendenteAviso;
                lbAvisoCrediario.Visible = true;
                lbAvisoCrediario.Text = "Crediario Pendente";
            
            }
        }

        private void cbPendente_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPendente.Checked == true)
            {
                cbPagos.Checked = false;
                pbLimpar_Click(null, null);
            }
        }

        private void cbEstatus_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEstatus.Checked == true)
            {
                pbLimpar_Click(null, null);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (cbPendente.Checked == true)
            {
                FrmCancelamento frmCancelamento = new FrmCancelamento("Crediario");
                frmCancelamento.ShowDialog();
            }
            else {

                FrmCancelamento frmCancelamento = new FrmCancelamento("CrediarioPago");
                frmCancelamento.ShowDialog();
            
            }
        }


    }
}
