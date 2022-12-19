using Negocio;
using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmSelecionarParcialVenda : Form
    {

        NegParcialVenda nParcial = new NegParcialVenda();

        ParcialVenda objParcial = new ParcialVenda();
        ParcialVenda parcialSelecionada = new ParcialVenda();
        ParcialVendaLista listaParcial = new ParcialVendaLista();
        ParcialVendaLista ListaCancelamento = new ParcialVendaLista();
        ParcialVendaListaSangria parcialListaSangria = new ParcialVendaListaSangria();

        ItemVenda objItemVenda = new ItemVenda();
        ItemVendaLista listaItemVendaExclusao = new ItemVendaLista();

        Cliente objCliente = new Cliente();
        NegCliente nCliente = new NegCliente();
        NegItemVenda nItem = new NegItemVenda();

        Formulas.Metodos metodos = new Formulas.Metodos();


        public FrmSelecionarParcialVenda()
        {
            InitializeComponent();
        }

        //----------------Métodos
        private void AtualizarDataGrid()
        {
            try
            {
                this.dgvParcial.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

                if (this.listaParcial.Count > 0)
                {
                    this.dgvParcial.Rows.Add(this.listaParcial.Count);
                }
                else
                {
                    return;
                }

                int indice = 0;
                foreach (ParcialVenda item in this.listaParcial)
                {
                    //------FK e UK
                    this.dgvParcial[1, indice].Value = item.Venda.codigoVenda;
                    this.dgvParcial[2, indice].Value = item.CodigoParcial;
                    //------Cliente
                    this.dgvParcial[3, indice].Value = item.Venda.Cliente.codigoCliente;
                    this.dgvParcial[4, indice].Value = item.Venda.Cliente.nomeCliente;
                    this.dgvParcial[5, indice].Value = item.Venda.Cliente.sobrenomeCliente;
                    this.dgvParcial[6, indice].Value = item.Venda.Cliente.cpfCliente;
                    this.dgvParcial[7, indice].Value = item.Venda.Cliente.celularCliente;
                    //------Forma Pagamento
                    this.dgvParcial[8, indice].Value = item.formaPagamentoVenda.codigoFormaPagamento;
                    this.dgvParcial[9, indice].Value = item.formaPagamentoVenda.formaPagamento;
                    //------Valores
                    this.dgvParcial[10, indice].Value = item.Venda.totalVenda;
                    this.dgvParcial[11, indice].Value = item.valorParcialVenda;
                    this.dgvParcial[12, indice].Value = item.jurosParcialVenda;
                    this.dgvParcial[13, indice].Value = item.descontoParcialVenda;
                    //------Estatus e Data
                    this.dgvParcial[14, indice].Value = item.Venda.dataVenda;
                    this.dgvParcial[15, indice].Value = item.Venda.estatusVenda;


                    indice++;
                }

                dgvParcial.Update();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void metodoCalculaTotais() {

            double varEstorno = 0;
            double varEstonoBruto = 0;
            double varTaxa = 0;
            double varDesconto = 0;

           if (dgvParcial.RowCount > 0)
            {

                //faz a soma dos totais dos valores do gride
                foreach (DataGridViewRow col in dgvParcial.Rows)
                {
                    if ((bool)col.Cells[0].Value == true)
                    {
                        varEstorno = varEstorno + Convert.ToDouble(col.Cells[10].Value);
                        varEstonoBruto = varEstonoBruto + Convert.ToDouble(col.Cells[11].Value);
                        varTaxa = varTaxa + Convert.ToDouble(col.Cells[12].Value);
                        varDesconto = varDesconto + Convert.ToDouble(col.Cells[13].Value);
                    }

                 }
            }



            //preencher as quantidade totais
           lbEstorno.Text = String.Format("{0:C2}", varEstorno);
           lbTaxa.Text = String.Format("{0:C2}", varTaxa);
           lbDesconto.Text = String.Format("{0:C2}", varDesconto);


           lbValorEstornoBruto.Text = String.Format("{0:C2}", varEstonoBruto);
           lbValorJuros.Text = String.Format("{0:C2}", varTaxa);
           lbValorDesconto.Text = String.Format("{0:C2}", varDesconto);
           lbLiquidoEstorno.Text = String.Format("{0:C2}", varEstorno);
           lbTotalEstorno.Text = String.Format("{0:C2}", varEstorno);


        
        }

        private void metodoLimpaCapos() {

            lbValorEstornoBruto.Text = "+ " + String.Format("{0:C2}", 0);
            lbValorJuros.Text = "% " + String.Format("{0:C2}", 0);
            lbValorDesconto.Text = "-  " + String.Format("{0:C2}", 0);
            lbLiquidoEstorno.Text = String.Format("{0:C2}", 0); //Esse e o valor que realmente foi recebido
            lbTotalEstorno.Text = String.Format("{0:C2}", 0);
            //preencher as quantidade totais
            lbEstorno.Text = String.Format("{0:C2}", 0);
            lbTaxa.Text = String.Format("{0:C2}", 0);
            lbDesconto.Text = String.Format("{0:C2}", 0);
        
        }

        private Boolean metodoValidaSelecao() {
           
            Boolean validaSelecao = false;

            if (dgvParcial.RowCount > 0)
            {
                //percorre todas as linhas do gride
                foreach (DataGridViewRow check in dgvParcial.Rows)
                {
                    //pega valores cheked no gride
                    if ((bool)check.Cells[0].FormattedValue)
                    {
                        validaSelecao = true;
                        return validaSelecao;
                    }

                }

            }

            return validaSelecao;
        
        }


        private Boolean metodoValidaCancelamentoSangria() {
            
            NegSangria nSangria = new NegSangria();
            NegCaixa nCaixa = new NegCaixa();
            Sangria sangria = new Sangria();

            if (nSangria.BuscarCancelamentoSangriaPorData(parcialListaSangria[0].Venda.dataVenda) == true)
            {
                foreach (ParcialVenda item in parcialListaSangria)
                {
                    sangria = nSangria.BuscarCancelamentoSangria(item.Venda.dataVenda, item.formaPagamentoVenda.codigoFormaPagamento);

                    if (sangria != null)
                    {
                        sangria.dataSangria = item.Venda.dataVenda;
                        double valorTotalItem = item.valorParcialVenda + item.jurosParcialVenda - item.descontoParcialVenda;

                        SangriaLista sangriaLista = new SangriaLista();
                        sangriaLista = nSangria.BuscarSangriaParaCancelamento(sangria.dataSangria);
                        double valorSangria = (from s in sangriaLista where (s.pagamentoSangria.codigoFormaPagamento == item.formaPagamentoVenda.codigoFormaPagamento) select (s.valorSangria)).Sum();

                        CaixaLista caixaLista = new CaixaLista();
                        caixaLista = nCaixa.BuscarCaixaValores(sangria.dataSangria);
                        double valorCaixa = (from c in caixaLista where (c.formaPagamento.codigoFormaPagamento == item.formaPagamentoVenda.codigoFormaPagamento) select (c.valorCaixa)).Sum();

                        //Valor restante do Caixa For igual o da Sangria não é necessário o cancelmento
                        if ((valorSangria) >= valorCaixa - valorTotalItem)
                        {//Verifica se há necessidade da atualização da sangria

                            //ZerandoValores Parciais para cancelamento
                            int contador = 0;
                            foreach (ParcialVenda parcial in parcialListaSangria)
                            {

                                parcialListaSangria[contador].valorParcialVenda = 0;
                                contador++;
                            }

                            DialogResult resultadoAtualizacaoSangria;
                            FrmCancelamentoSangria frmSangria = new FrmCancelamentoSangria(sangria, caixaLista, parcialListaSangria, null, null, null);
                            resultadoAtualizacaoSangria = frmSangria.ShowDialog();

                            if (resultadoAtualizacaoSangria == DialogResult.Yes)
                            {

                                return true;

                            }
                            else
                            {
                                return false;

                            }
                        }
                    }

                }//Foreach

                return true;
            }
            else { return true; }//Não Existem sangrias na data
        }

        //-----------------Botões
        private void pbCliente_Click(object sender, EventArgs e)
        {
            int n;
            bool ehUmNumero = int.TryParse(tbBuscarCliente.Text, out n);
            if (ehUmNumero == true)
            {
                objCliente = nCliente.BuscarClientePorCodigo(n);
                if (objCliente != null)
                {
                    this.tbBuscarCliente.Text = objCliente.nomeCliente + " " + objCliente.sobrenomeCliente;
                    this.mtbCpf.Text = objCliente.cpfCliente;
                    btBuscarParcial.PerformClick();

                }
            }
            else
            {
                FrmSelecionarCliente frmSelecionarCliente = new FrmSelecionarCliente(tbBuscarCliente.Text);
                DialogResult resultado = frmSelecionarCliente.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    this.objCliente = frmSelecionarCliente.clienteSelecionado;
                    this.tbBuscarCliente.Text = objCliente.nomeCliente + " " + objCliente.sobrenomeCliente;
                    this.mtbCpf.Text = objCliente.cpfCliente;
                    btBuscarParcial.PerformClick();
                }

            }
        }

        private void pbBuscarParcial_Click(object sender, EventArgs e)
        {//Busca o Cliente do Gride Prenchendo os dados e filtrando assim 
            if (dgvParcial.Rows.Count > 0)
            {
                objCliente = nCliente.BuscarClientePorCodigo(Convert.ToInt32(dgvParcial.CurrentRow.Cells[3].Value));

                if (objCliente != null)
                {
                    this.tbBuscarCliente.Text = objCliente.nomeCliente + " " + objCliente.sobrenomeCliente;
                    this.mtbCpf.Text = objCliente.cpfCliente;

                    btBuscarParcial.PerformClick();

                    lbValorEstornoBruto.Text = "+ " + String.Format("{0:C2}", 0);
                    lbValorJuros.Text = "% " + String.Format("{0:C2}", 0);
                    lbValorDesconto.Text = "-  " + String.Format("{0:C2}", 0);
                    lbLiquidoEstorno.Text = String.Format("{0:C2}", 0); //Esse e o valor que realmente foi recebido
                    lbTotalEstorno.Text = String.Format("{0:C2}", 0);

                    //preencher as quantidade totais
                    lbEstorno.Text = String.Format("{0:C2}", 0);
                    lbTaxa.Text = String.Format("{0:C2}", 0);
                    lbDesconto.Text = String.Format("{0:C2}", 0);
                }
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Sair Parcial",
            " Deseja realmente sair da Parcial?",
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

        private void btBuscarParcial_Click(object sender, EventArgs e)
        {
            metodoLimpaCapos();

            string cliente = tbBuscarCliente.Text;
            string cpf = mtbCpf.Text;

            if (mtbCpf.Text == string.Empty)
            {
                cpf = "";
            }

            if (tbBuscarCliente.Text.Equals("Digite o nome do cliente ...") || tbBuscarCliente.Text == string.Empty)
            {
                cliente = "";
            }
            else if (objCliente != null)
            {

                cliente = objCliente.nomeCliente;
                cpf = objCliente.cpfCliente;
            }


            listaParcial = nParcial.BuscarParcialVendaCancelamento(cliente,cpf);
            if (listaParcial.Count == 0)
            {
                FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Não Existem Parciais",
                "Não existem parciais vinculadas com o Cliente!"
                +"\n"+objCliente.nomeCliente+" "+objCliente.sobrenomeCliente,
                 Properties.Resources.DialogQuestion,
                 System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                 Color.White,
                "Ok", "",
                 false);
                frmCaixaCad.ShowDialog();

                mtbCpf.Clear();
                tbBuscarCliente.Focus();
            }
            else
            {
                AtualizarDataGrid();
            }
        }

        private void pbFiltrar_Click(object sender, EventArgs e)
        {//Se cpf estiver preenchido filtrar por cpf se não por data
            if (mtbCpf.Text != string.Empty)
            {
                if (metodos.metodoValidarCPF(mtbCpf.Text) == true)
                {

                    objCliente = nCliente.BuscarClientePorCpf(mtbCpf.Text);

                    if (objCliente.nomeCliente != string.Empty)
                    {

                        tbBuscarCliente.Text = objCliente.nomeCliente + " " + objCliente.sobrenomeCliente;
                        mtbCpf.Text = objCliente.cpfCliente;
                        btBuscarParcial.PerformClick();

                    }
                }
                else {
                    MessageBox.Show("CPF Inválido!",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mtbCpf.Clear();
                    mtbCpf.Focus();
                }
            }
            else {

                listaParcial = nParcial.BuscarParcialVendaCancelamentoPorData(dtpDataInicial.Value, dtpDataFinal.Value);
               
                if (listaParcial.Count == 0)
                {
                    FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Não Existem Parciais",
                    "Não existem parciais entre as Datas! \r\n"
                    +dtpDataInicial.Value.ToShortDateString() + " á " + dtpDataFinal.Value.ToShortDateString(),
                     Properties.Resources.DialogProcessando,
                     System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                     Color.White,
                    "Ok", "",
                     false);
                    frmCaixaCad.ShowDialog();

                }
                else
                {
                    AtualizarDataGrid();
                }
            
            }
        }

        private void pbLimpar_Click(object sender, EventArgs e)
        {
            dtpDataInicial.Value = DateTime.Now;
            dtpDataFinal.Value = DateTime.Now;
            dgvParcial.Rows.Clear();
            tbBuscarCliente.Focus();
            mtbCpf.Clear();

            lbValorEstornoBruto.Text = "+ " + String.Format("{0:C2}", 0);
            lbValorJuros.Text = "% " + String.Format("{0:C2}", 0);
            lbValorDesconto.Text = "-  " + String.Format("{0:C2}", 0);
            lbLiquidoEstorno.Text = String.Format("{0:C2}", 0); //Esse e o valor que realmente foi recebido
            lbTotalEstorno.Text = String.Format("{0:C2}", 0);
            //preencher as quantidade totais
            lbEstorno.Text = String.Format("{0:C2}", 0);
            lbTaxa.Text = String.Format("{0:C2}", 0);
            lbDesconto.Text = String.Format("{0:C2}", 0);
        }

        private void pbCalculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\system32\\calc.exe");
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            dtpDataInicial.Value = DateTime.Now;
            dtpDataFinal.Value = DateTime.Now;
            dgvParcial.Rows.Clear();
            tbBuscarCliente.Focus();
            mtbCpf.Clear();

            lbValorEstornoBruto.Text = "+ " + String.Format("{0:C2}", 0);
            lbValorJuros.Text = "% " + String.Format("{0:C2}", 0);
            lbValorDesconto.Text = "-  " + String.Format("{0:C2}", 0);
            lbLiquidoEstorno.Text = String.Format("{0:C2}", 0); //Esse e o valor que realmente foi recebido
            lbTotalEstorno.Text = String.Format("{0:C2}", 0);
            //preencher as quantidade totais
            lbEstorno.Text = String.Format("{0:C2}", 0);
            lbTaxa.Text = String.Format("{0:C2}", 0);
            lbDesconto.Text = String.Format("{0:C2}", 0);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (metodoValidaSelecao() == true)
                {
                    DialogResult respostaAtualiza;
                    //Criando Caixa de dialogo
                    FrmCaixaDialogo frmCaixaAtualiza = new FrmCaixaDialogo("Cancelamento Parcial & Venda!",
                    "Deseja excluir todos os itens e parciais?",
                    Properties.Resources.DialogExcluir,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Sim", "Não",
                    false);
                    respostaAtualiza = frmCaixaAtualiza.ShowDialog();

                    if (respostaAtualiza == DialogResult.Yes)
                    {

                        //---------------------------------------Seleciona Parcial Para Exclusao
                        #region SelecionaParcial

                        int indiceRegistroSelecionado = 0;

                        foreach (DataGridViewRow row in dgvParcial.Rows)
                        {
                            //Só adiciona os itens marcados no caso seleciondados
                            if ((bool)row.Cells[0].FormattedValue == true)
                            {

                                indiceRegistroSelecionado = Convert.ToInt32(row.Cells[1].Value);
                                break;

                            }
                        }

                        foreach (ParcialVenda parc in listaParcial)
                        {
                            if (parc.Venda.codigoVenda == indiceRegistroSelecionado)
                            {

                                parcialSelecionada = parc;
                                parcialListaSangria.Add(parc);//Lista para validar se houve sangria para atualizar o cancelamento

                            }

                        }
                        #endregion

                        //---------------------------------------Busca Itens Para o Cancelamento                        
                        #region Adicionando Itens a Lista de Cancelamento

                        listaItemVendaExclusao = nItem.BuscarItemVendaPorVenda(parcialSelecionada.Venda.codigoVenda);
                        if (listaItemVendaExclusao.Count <= 0)
                        {
                            //Criando Caixa de dialogo
                            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro Cancelamento",
                            "Lista de Itesn está vazia!",
                             Properties.Resources.DialogErro,
                             System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                             Color.White,
                             "OK", "",
                             false);
                            frmCaixa.ShowDialog();
                        }

                        else//Caso a Lista estaja cheia realiza a exclusão
                        {
                        #endregion
                        
                        //---------------------------------------Cancelamento Parciais e Itens e Venda                        
                        #region Cancela Paricial e Item
                            if (metodoValidaCancelamentoSangria() == true)
                            {
                                if (nParcial.ExcluirParcialPorVenda(parcialSelecionada.Venda) == true)//Exclui Todas as Parciais da Venda
                                {
                                    if (nItem.ExcluirItemVenda(listaItemVendaExclusao) == true)
                                    {
                                        //----------------------------Realiza Impressão
                                        DialogResult respostaImpressao;
                                        //Criando Caixa de dialogo
                                        FrmCaixaDialogo frmCaixaImpressao = new FrmCaixaDialogo("Cancelamento Realizado!",
                                        "Cancelamento realizado com sucesso !\r\n" +
                                        "Deseja Realizar Impressão do Comprovante?",
                                        Properties.Resources.DialogOK,
                                        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                        Color.White,
                                        "Sim", "Não",
                                        false);
                                        respostaImpressao = frmCaixaImpressao.ShowDialog();
                                        //----------------------------------ImprimiComprovanteVenda
                                        if (respostaImpressao == DialogResult.Yes)
                                        {
                                            //Retornando que exclusão foi realizada com sucesso
                                            //this.DialogResult = DialogResult.Yes; //Após a impressão fecha o formulário
                                            btBuscarParcial.PerformClick();//Realiza Atualização
                                            //ImprimiComprovante()
                                            //Tem que Ter CodigoParcial
                                            //Valor Venda
                                            //Itens
                                            //Imprimir Total Venda 
                                            //Com Acréscimos e sem acréscimos
                                            //Venda antes e Depois dos Acréscimos
                                        }
                                        else { btBuscarParcial.PerformClick(); }//Realiza Atualização}

                                    }
                                    else
                                    {
                                        //Erro ao Cancelar Item
                                        FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Erro ao Cancelar Item",
                                        "Não foi possível cancelar os Itens!",
                                        Properties.Resources.DialogErro,
                                        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                        Color.White,
                                        "Ok", "",
                                        false);
                                        frmCaixaCad.ShowDialog();
                                    }
                                }

                                else
                                {
                                    FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Erro Cancelamento Parcial",
                                   "Não foi possível cancelar as Parciais!",
                                   Properties.Resources.DialogErro,
                                   System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                   Color.White,
                                   "Ok", "",
                                   false);
                                    frmCaixaCad.ShowDialog();
                                }
                            #endregion

                            }//--Validacao Lista
                            else
                            {
                                MessageBox.Show("Atualize os dados da sangria para realizar cancelamento!",
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }//--------ConfirmandoExclusão
                    }//-----------------------ValidaSelecao
                    else
                    {
                        MessageBox.Show("Não Existem Parciais Selecionadas!",
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }//Valida se há sangria a ser atualizada no dia da venda
            }
            //--------------------Captura de Execessão
            catch (Exception ex)
            {
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro",
               "Erro no Recebimento motivo: \r\n" + ex.Message,
               Properties.Resources.DialogErro,
               System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
               Color.White,
               "Ok", "",
               false);

                frmCaixa.ShowDialog();
            }
        }

        private void FrmSelecionarParcialVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F5) == true)
            {
                btBuscarParcial.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F2) == true)
            {
                btExcluir.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {
                btSair.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F6) == true)
            {
                btLimpar.PerformClick();
            }
        }

        //-----------------Cliente
        private void tbBuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbCliente_Click(null,null);
                e.Handled = true;
            }
        }

        private void tbBuscarCliente_Leave(object sender, EventArgs e)
        {
            if (tbBuscarCliente.Text == "")
            {
                tbBuscarCliente.Text = "Digite o nome do cliente ...";
                pbCliente.Image = Properties.Resources.ClienteAzul;
                panelBuscarCliente.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                tbBuscarCliente.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

            }
        }

        private void tbBuscarCliente_Enter(object sender, EventArgs e)
        {
            tbBuscarCliente.Clear();
            pbCliente.Image = Properties.Resources.ClienteRosa;
            panelBuscarCliente.BackColor = Color.DeepPink;
            //tbBuscarCliente.ForeColor = Color.DeepPink;
        }

        private void mtbCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbFiltrar_Click(null, null);
                e.Handled = true;
            }
        }

        private void dgvParcial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                    //interrompe a edição
                    dgvParcial.EndEdit();

                    if (e.RowIndex >= 0)
                    {

                        if (dgvParcial.Rows[e.RowIndex].Cells[0].Value != null)
                        {
                            if ((bool)dgvParcial.Rows[e.RowIndex].Cells[0].Value == true)
                            {

                                string varVenda = (dgvParcial.CurrentRow.Cells[1].Value).ToString();


                                //percorre todas as linhas do gride
                                foreach (DataGridViewRow check in dgvParcial.Rows)
                                {
                                    if (check.Cells[1].FormattedValue.ToString() == varVenda)
                                    {

                                        ((DataGridViewCheckBoxCell)check.Cells[0]).Value = true;

                                    }
                                    else
                                    {

                                        ((DataGridViewCheckBoxCell)check.Cells[0]).Value = false;

                                    }

                                }
                            }
                            else if ((bool)dgvParcial.Rows[e.RowIndex].Cells[0].Value == false)
                            {

                                string varVenda = (dgvParcial.CurrentRow.Cells[1].Value).ToString();


                                //percorre todas as linhas do gride
                                foreach (DataGridViewRow check in dgvParcial.Rows)
                                {
                                    if (check.Cells[1].FormattedValue.ToString() == varVenda)
                                    {

                                        ((DataGridViewCheckBoxCell)check.Cells[0]).Value = false;

                                    }

                                }
                            } metodoCalculaTotais();
                        } 
                    }
            }
            catch (Exception ex)
            {
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro Seleção",
                "Erro no DataGride Selecionar: \r\n" + ex.Message,
                Properties.Resources.DialogErro,
                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                Color.White,
                "Ok", "",
                false);
                frmCaixa.ShowDialog();
            }
        }

        private void FrmSelecionarParcialVenda_Load(object sender, EventArgs e)
        {

        }





    }
}
