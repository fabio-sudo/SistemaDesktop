using Apresentacao.Formulas;
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
    public partial class FrmParcialVenda : Form
    {
        //Receber formulario Anterior
        //objVenda Cliente - Funcioanrio - Quantidade - Total
        //Lista de Items a Cadastrar

        ParcialVendaLista listaParcialCad = new ParcialVendaLista();
        NegParcialVenda nParcial = new NegParcialVenda();

        ComboBox comboDataGride;
        TextBox caixaTextoGride;

        //---------------Objetos Para realizar os cadastros
        Venda objVenda = new Venda();
        NegVenda nVenda = new NegVenda();
        NegItemVenda nItem = new NegItemVenda();
        ItemVendaLista itemVendaLista = new ItemVendaLista();
        ItemVendaLista itemVendaListaNova = new ItemVendaLista();

        //-----------------Metodos
        Metodos metodos = new Metodos();

        //---------------Forma de Pagamento
        FormaPagamento objFormaPagamento = new FormaPagamento();
        ListaFormaPagamento listaFormaPagamento = new ListaFormaPagamento();//Usado no combobox
        NegFormaPagamento nFormaPagamento = new NegFormaPagamento();//Prencher formas de pagamento

        //-----Variaveis para adicionar novos itens no gride
        Boolean validaADD = false;
        int indice = 0;

        //-----Variaveis pora calculos
        double valorJuros = 0;
        double valorDesconto = 0;
        double valorAReceberIndividual = 0;
        double CalculavalorJuros = 0;
        double valorParcialTotal = 0;
        double valorParcial = 0;
        double valorDescontoTotal = 0;
        double valorJurosTotal = 0;


        public FrmParcialVenda(Venda venda, ItemVendaLista lista)
        {
            InitializeComponent();

            this.objVenda = venda;
            this.itemVendaLista = lista;
        }
        //-------------Metodos
        private void metodoIniciaFormulario() {

            lbTotalBrutoVenda.Text = String.Format("{0:C2}", objVenda.totalVenda);
            //Adiciona um item
            btAdicionar.PerformClick();
            //Focu na parcial
            dgvFormaParcial.CurrentCell = dgvFormaParcial.Rows[0].Cells[2];
          
            dgvFormaParcial.CurrentRow.Cells[2].Value = "0,00";
            dgvFormaParcial.CurrentRow.Cells[5].Value = "0,00";
            dgvFormaParcial.CurrentRow.Cells[6].Value = "0,00";
            dgvFormaParcial.CurrentRow.Cells[3].ReadOnly =true;

            //---------------Preenche combobox
            metodoPreencheCombobox();

        }

        public void metodoPreencheCombobox() {

            formaPagamentoParcial.Items.Clear();
            this.listaFormaPagamento = nFormaPagamento.BuscarFormaPagamentoPorNome("");

            foreach (FormaPagamento pag in this.listaFormaPagamento)
            {
                if (pag.formaPagamento != "CREDIARIO" && pag.formaPagamento != "PARCIAL")
                {
                    if (pag.taxaFormaPagamento == 0)
                    {

                        this.formaPagamentoParcial.Items.IndexOf(pag.codigoFormaPagamento);
                        this.formaPagamentoParcial.Items.Add(pag.formaPagamento);

                    }
                    else
                    {
                        this.formaPagamentoParcial.Items.IndexOf(pag.codigoFormaPagamento);
                        this.formaPagamentoParcial.Items.Add(pag.formaPagamento + " - " + pag.taxaFormaPagamento.ToString("F"));

                    }
                }
            }
        }

        public Boolean metodoValidaParcialVenda() {

            //verifica se campos vazios
            foreach (DataGridViewRow col in dgvFormaParcial.Rows)
            {
                if (col.Cells[3].Value == null) { return false; }
             
            }

            return true;
     
        
        }

        private ParcialVendaLista metodoAddParcialLista(Venda vendaParcial)
        {
            ParcialVendaLista listaParcial = new ParcialVendaLista();

            foreach (DataGridViewRow col in dgvFormaParcial.Rows)
            {
                ParcialVenda objParcial = new ParcialVenda();
                objParcial.Venda = new Venda();
                objParcial.formaPagamentoVenda = new FormaPagamento();

                //Chaves FK e UK
                objParcial.Venda = vendaParcial;
                objParcial.valorParcialVenda = Convert.ToDouble(col.Cells[2].Value);
                objParcial.formaPagamentoVenda.codigoFormaPagamento = Convert.ToInt32(col.Cells[4].Value);
                objParcial.descontoParcialVenda = Convert.ToDouble(col.Cells[5].Value);
                objParcial.jurosParcialVenda = Convert.ToDouble(col.Cells[6].Value);
                objParcial.acrescimoDesconto = 0.00;
                objParcial.acrescimoTaxa = 0.00;

                if (cbJuros.Checked == false) { objParcial.jurosParcialVenda = objParcial.jurosParcialVenda * -1; }//Parcial fica negativa

                listaParcial.Add(objParcial);
            }

            return listaParcial;
        }

        //Valida Comparando os valores da Venda e valores adicionados pelo usuário
        private void metodoValidaParcial(double valorParcialCorrente,double valorParcialValida, double valorTotalValida)
        {
            //PegaValoresTotai + Valor nova Parcial Se > que Total da Venda 
            if ((valorParcialValida) > valorTotalValida)
            {
                double valorRest = (valorTotalValida - valorParcialTotal );
                valorRest = valorParcialCorrente + valorRest;

                FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Total da Venda Atendido!",
                "Valor restante da Venda é: \n" + valorRest.ToString(),
                Properties.Resources.DialogParcial,
                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                Color.White,
                "Ok", "",
                false);
                frmCaixaCad.ShowDialog();

                this.dgvFormaParcial.CurrentRow.Cells[2].Value = valorRest;
                pbOk.Image = Properties.Resources.DialogErro;

            }
            else if (valorParcialTotal == valorTotalValida)
            {

                btAdicionar.Enabled = false;
                pbOk.Image = Properties.Resources.DialogOK;

            }
            else { btAdicionar.Enabled = true;
            pbOk.Image = Properties.Resources.DialogErro;
            
            }
        }

        //----------Metodos Calculos
        private void metodoCalculaJuros() {

        CalculavalorJuros = 0;

        //-------Juros Cartão
            if (dgvFormaParcial.CurrentRow.Cells[3].Value != null)
            {
                CalculavalorJuros = Convert.ToDouble(dgvFormaParcial.CurrentRow.Cells[7].Value) / 100;
                CalculavalorJuros = Convert.ToDouble(dgvFormaParcial.CurrentRow.Cells[2].Value) * CalculavalorJuros;
                dgvFormaParcial.CurrentRow.Cells[6].Value = CalculavalorJuros;
            }
        
        }

        //Calcuala Desconto individual
        private void metodoCalculaDesconto() {
       
            double Porcentagemdesconto = (Convert.ToDouble(nudDesconto.Value) / 100);
            valorDesconto = Porcentagemdesconto * Convert.ToDouble(dgvFormaParcial.CurrentRow.Cells[2].Value);

            //----------Acrescenta Desconto no Gride
            dgvFormaParcial.CurrentRow.Cells[5].Value = valorDesconto;  
        }

        //Calcuala Troco individual
        private void metodoCalculaTroco()
        {
            try
            {
                double valorTroco = 0;
                //------Troco
                valorTroco = Convert.ToDouble(tbValorPago.Text) - valorAReceberIndividual;
                if (valorTroco < 0)
                {
                    valorTroco = 0;
                }
                lbTroco.Text = "- " + String.Format("{0:C2}", valorTroco);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //Calcula Valor Recebimento individual
        private void metodoCaculaRecebimento() { 
        
            try{
                if (dgvFormaParcial.CurrentRow.Cells[3].Value != null && cbJuros.Checked == false)
                {
                    valorAReceberIndividual = (Convert.ToDouble(dgvFormaParcial.CurrentRow.Cells[2].Value)) - Convert.ToDouble(dgvFormaParcial.CurrentRow.Cells[5].Value);
                }
                else {

                    valorAReceberIndividual = (Convert.ToDouble(dgvFormaParcial.CurrentRow.Cells[2].Value) + Convert.ToDouble(dgvFormaParcial.CurrentRow.Cells[6].Value)) - Convert.ToDouble(dgvFormaParcial.CurrentRow.Cells[5].Value);
                }

               lbDinheiro.Text = "+ " + String.Format("{0:C2}", valorAReceberIndividual);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
        }

        //Calcula Totais Gerais
        private void metodoCalculaTotais()
        {
            try
            {
                valorParcialTotal = 0;
                valorJurosTotal = 0;
                valorDescontoTotal = 0;
                valorParcial = 0;

                if (dgvFormaParcial.RowCount > 0)
                {
                    metodoCalculaJuros();
                    metodoCaculaRecebimento();
                    //------Troco
                    metodoCalculaTroco();

                    //faz a soma dos totais dos valores do gride
                    foreach (DataGridViewRow col in dgvFormaParcial.Rows)
                    {
                        //Valor da Parcial
                        valorParcialTotal = valorParcialTotal + Convert.ToDouble(col.Cells[2].Value);
                        valorDescontoTotal = valorDescontoTotal + +Convert.ToDouble(col.Cells[5].Value);
                        valorJurosTotal = valorJurosTotal + +Convert.ToDouble(col.Cells[6].Value);
                    }

                valorParcial = valorParcialTotal;

                //Verifica se valor digitado não excedo valor da venda
                metodoValidaParcial(Convert.ToDouble(dgvFormaParcial.CurrentRow.Cells[2].Value),valorParcial, objVenda.totalVenda);

                //Parcial Liquido
                lbParcialLiquido.Text = "+ " + String.Format("{0:C2}", valorParcialTotal);

                //--------TotalBruto
                lbValorTotalVenda.Text = "+ " + String.Format("{0:C2}", valorParcialTotal);

                //-------Desconto
                lbDesconto.Text = "- " + String.Format("{0:C2}", valorDescontoTotal);
                lbDescontoVenda.Text = " - " + String.Format("{0:C2}", valorDescontoTotal);

                //-------Juros
                lbTaxa.Text = "% " + String.Format("{0:C2}", valorJurosTotal);
                lbJurosVenda.Text = "% " + String.Format("{0:C2}", valorJurosTotal);

                //-------A Receber
                if (dgvFormaParcial.CurrentRow.Cells[3].Value != null && cbJuros.Checked == false)
                {
                    valorParcialTotal = valorParcialTotal - valorDescontoTotal;
                }

                else
                {
                    valorParcialTotal = valorParcialTotal + valorJurosTotal - valorDescontoTotal;
                }

                //-------Receber
                lbVendaLiquido.Text = "+ " + String.Format("{0:C2}",valorParcialTotal);

                //-------Valor Parciais
                lbTotalParcial.Text = "+ " + String.Format("{0:C2}", valorParcialTotal);

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        //Métodos para adicionar Valores do Gride na Lista
        public void metodoAddItemLista(int codigoVenda)
        {
            try
            {

                double PorcentagemDescontoVenda = valorDescontoTotal / objVenda.totalVenda;
                double PorcentagemJurosVenda = valorJurosTotal / objVenda.totalVenda;

                if (itemVendaLista.Count > 0)
                {
                    //Percorre o gride para adicionar itens
                    itemVendaListaNova = new ItemVendaLista();

                    foreach (ItemVenda item  in itemVendaLista)
                    {
                        ItemVenda itemVenda = new ItemVenda();
                        itemVenda.Venda = new Venda();
                        itemVenda.ProdutoCor = new ProdutoCor();
                        itemVenda.Tamanho = new Tamanho();

                        //Chaves FK e UK
                        itemVenda.ProdutoCor = item.ProdutoCor; 
                        itemVenda.Venda.codigoVenda = codigoVenda;
                        itemVenda.Tamanho = item.Tamanho;
                        //Valores
                        itemVenda.quantidadeVenda = item.quantidadeVenda;
                        itemVenda.precoCusto = item.precoCusto;
                        itemVenda.precoVenda = item.precoVenda;
                        //Encargos Juros e Desconto Total * Porcentagem

                        itemVenda.JurosItem = Math.Round((itemVenda.precoVenda * itemVenda.quantidadeVenda) * (PorcentagemJurosVenda), 4);
                        itemVenda.descontoItem = Math.Round((itemVenda.precoVenda * itemVenda.quantidadeVenda) * (PorcentagemDescontoVenda), 4);
                        if (cbJuros.Checked == false) { itemVenda.JurosItem = itemVenda.JurosItem * -1; }//Deixa juros negativos mostrando que o mesmo não foi adicionado a venda

                        itemVendaListaNova.Add(itemVenda);

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        } 

        //-----------Botões
        private void btCadastrar_Click(object sender, EventArgs e)
        {          
            try
            {

                if (dgvFormaParcial.RowCount > 0)
                {
                    if (metodoValidaParcialVenda() == true)
                    {
                        if (valorParcial == objVenda.totalVenda)
                        {
                            //--------------Criar objVenda
                            Venda objVendaCad = new Venda();
                            objVendaCad.Cliente = objVenda.Cliente;
                            objVendaCad.Funcionario = objVenda.Funcionario;
                            objVendaCad.formaPagamento = objVenda.formaPagamento;
                            objVendaCad.quantidadeVenda = objVenda.quantidadeVenda;//Soma quantidade dos itensTemporários
                            objVendaCad.descontoVenda = valorDescontoTotal;
                            
                            //Adiciona Juros Sim/Não
                            if (cbJuros.Checked == true)
                            {
                                objVendaCad.jurosVenda = valorJurosTotal;
                            }
                            else {
                                objVendaCad.jurosVenda = -valorJurosTotal;//Se não adicionar os juros entram como negativos
                            }
                            //TotalBruto e salvo -> Tem que ser o liquido 
                            objVendaCad.totalVenda = (objVenda.totalVenda);

                            //--------------Cadastrar Venda
                            if (nVenda.CadastrarVenda(objVendaCad) == true)
                            {
                                //Busca codigo da Venda Cadastrado
                                int codigoVendaCad = nVenda.BuscarUltimoRegistroVenda();

                                //Monta Lista Com codigo da venda e parciais cadastradas
                                objVendaCad.codigoVenda = codigoVendaCad;
                                listaParcialCad = metodoAddParcialLista(objVendaCad);

                                //-----------------Cadastra Parcial
                                if (nParcial.CadastrarParcialLista(listaParcialCad) == true)
                                {
                                    //Adiciona itens a lista para realizar o cadstro
                                    metodoAddItemLista(codigoVendaCad);
                                    //------------------------Cadastra ItemVenda
                                    if (nItem.CadastrarItemVendaLista(itemVendaListaNova) == true)
                                    {
                                        //------------------------------------Exclui dados da tabela ItemVendaTemp -> código da ItemVendaTemp
                                        if (nItem.ExcluirItemVendaTempPorVenda(objVenda.codigoVenda) == true)
                                        {
                                            DialogResult resposta;
                                            //Criando Caixa de dialogo
                                            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Lançamento Realizado!",
                                            "Venda realizada com sucesso !\r\n" +
                                            "Deseja Realizar Impressão do Comprovante?",
                                            Properties.Resources.DialogOK,
                                            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                            Color.White,
                                            "Sim", "Não",
                                            false);
                                            resposta = frmCaixa.ShowDialog();
                                            //----------------------------------ImprimiComprovanteVenda
                                            if (resposta == DialogResult.Yes)
                                            {
                                                //Retornando que exclusão foi realizada com sucesso
                                                this.DialogResult = DialogResult.Yes;
                                                this.Close();
                                                //ImprimiComprovante()
                                                //Tem que Ter CodigoParcial
                                                //Valor Venda
                                                //Itens
                                            }
                                            else
                                            {
                                                //metodoLimpaCampos()
                                                this.DialogResult = DialogResult.Yes;
                                            }
                                        }
                                        else
                                        {
                                            FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Erro Excluir Item Venda",
                                            "Erro ao excluir tabela Item Venda Temp!",
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
                                        FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Erro Cadastrar Item Venda",
                                        "Erro ao cadastrar Item Venda!",
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
                                    FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Erro Cadastrar Parcial",
                                    "Erro ao cadastrar Parcial da Venda!",
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
                                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro Venda",
                                "Erro ao realiza cadastro da Venda!",
                                Properties.Resources.DialogErro,
                                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                Color.White,
                                "Ok", "",
                                false);
                                frmCaixa.ShowDialog();
                            }
                        }
                        else
                        {
                            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro Totais",
                            "Informe os valores das parciais para realizar a Venda!",
                            Properties.Resources.DialogErro,
                            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                            Color.White,
                            "Ok", "",
                            false);
                            frmCaixa.ShowDialog();
                        }
                    }
                }
                else {
                     FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro Cadastrar Parcial",
                     "Não existem parciais para realizar o Lançamento!",
                     Properties.Resources.DialogErro,
                     System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                     Color.White,
                     "Ok", "",
                     false);
                    frmCaixa.ShowDialog();
                
                }
          //--------------------Captura de Execessão
          }catch(Exception ex){
                 FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro",
                "Erro na Venda motivo: \r\n" + ex.Message,
                Properties.Resources.DialogErro,
                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                Color.White,
                "Ok", "",
                false);

                frmCaixa.ShowDialog();      
          }
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            try
            {


                if (dgvFormaParcial.RowCount == 0)
                {

                    this.dgvFormaParcial.Rows.Add(1);
                    dgvFormaParcial.CurrentRow.Cells[7].Value = indice;
                    DataGridViewRow row = dgvFormaParcial.Rows[0];
                    row.Height = 30;

                    tbValorPago.Text = "0,00";
                    lbTroco.Text = "0,00";
                    lbDinheiro.Text = "0,00";
                    dgvFormaParcial.CurrentRow.Cells[2].Value = "0,00";
                    dgvFormaParcial.CurrentRow.Cells[5].Value = "0,00";
                    dgvFormaParcial.CurrentRow.Cells[6].Value = "0,00";

                }
                else
                {

                    metodoCalculaTotais();
                    if (objVenda.totalVenda >= valorParcial)
                    {
                        //percorre todas as linhas do gride
                        foreach (DataGridViewRow rowChek in dgvFormaParcial.Rows)
                        {
                            if (rowChek.Cells[2].Value != null && rowChek.Cells[3].Value != null)
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
                            dgvFormaParcial.Rows.Add(1);
                            indice = dgvFormaParcial.RowCount - 1;
                            dgvFormaParcial.Rows[indice].Cells[3].ReadOnly = true;
                            dgvFormaParcial.CurrentCell = dgvFormaParcial.Rows[indice].Cells[2];
                            DataGridViewRow row = dgvFormaParcial.Rows[indice];
                            row.Height = 30;
                            nudDesconto.Value = 0;
                            tbValorPago.Text = "0,00";
                            lbTroco.Text = "0,00";
                            lbDinheiro.Text = "0,00";
                            dgvFormaParcial.CurrentRow.Cells[2].Value = "0,00";
                            dgvFormaParcial.CurrentRow.Cells[5].Value = "0,00";
                            dgvFormaParcial.CurrentRow.Cells[6].Value = "0,00";
                        }
                    }
                    else
                    {
                        FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Total da Venda Atendido!",
                        "Valor total da venda totalmente atendido: /n" + lbTotalBrutoVenda.Text,
                        Properties.Resources.DialogParcial,
                        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                        Color.White,
                        "Ok", "",
                        false);
                        frmCaixaCad.ShowDialog();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            var indice = dgvFormaParcial.CurrentRow.Index;
           
            if (indice >= 0)
            {
                dgvFormaParcial.Rows.RemoveAt(indice);
            }

            if (dgvFormaParcial.RowCount <= 0) {

                metodoIniciaFormulario();
            }

            metodoCalculaTotais();
        }

        private void btDesconto_Click(object sender, EventArgs e)
        {
            metodoCalculaDesconto();
            metodoCalculaTotais();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair da Parcial ?",
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

        //----------Formulário
        private void FrmParcialVenda_Load(object sender, EventArgs e)
        {
            metodoIniciaFormulario();
        }

        private void dgvFormaParcial_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //FormaPagamento
            if (dgvFormaParcial.Columns[e.ColumnIndex].Name == "formaPagamentoParcial")
            {

                dgvFormaParcial.Rows[e.RowIndex].ErrorText = "";

                if (dgvFormaParcial.Rows[e.RowIndex].IsNewRow) { return; }
                if (e.FormattedValue.ToString() == "")
                {
                    dgvFormaParcial.Rows[e.RowIndex].ErrorText = "Informe a Forma de Pagamento Corretamente";
                }

            }
            //Valor da Parcial
            if (dgvFormaParcial.Columns[e.ColumnIndex].Name == "valorParcialVenda")
            {
                dgvFormaParcial.Rows[e.RowIndex].ErrorText = "";
                double newDouble;

                if (dgvFormaParcial.Rows[e.RowIndex].IsNewRow) { return; }
                if (!double.TryParse(e.FormattedValue.ToString(),
                    out newDouble) || newDouble <= 0)
                {
                    dgvFormaParcial.Rows[e.RowIndex].ErrorText = "Informe o valor da Parcial";
                    dgvFormaParcial.CurrentRow.Cells[3].ReadOnly = true;
                }
                else {
                    //habilita escolher forma de pagamento
                    dgvFormaParcial.CurrentRow.Cells[3].ReadOnly = false;
                
                }

            }
        }

        //-------------------Combobox
        //Atribui o Combox do datagride Para variavel para ser utilizado
        private void dgvFormaParcial_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                comboDataGride = e.Control as ComboBox;
                if (comboDataGride != null)
                {
                    comboDataGride.DropDown -= new EventHandler(comboDataGride__DropDown);
                    comboDataGride.DropDown += comboDataGride__DropDown;

                    comboDataGride.SelectedIndexChanged -= new EventHandler(comboDataGride_SelectedIndexChanged);
                    comboDataGride.SelectedIndexChanged += comboDataGride_SelectedIndexChanged;
                }

                //-----------Adiciona o formato apenas na caixa de texto 
                if (dgvFormaParcial.CurrentCell.ColumnIndex == 2)
                {
                    //if (caixaTextoGride != null)
                    {
                        caixaTextoGride = e.Control as TextBox;
                        caixaTextoGride.TextChanged -= new EventHandler(caixaTextoGride_TextChanged);
                        caixaTextoGride.TextChanged += caixaTextoGride_TextChanged;

                        caixaTextoGride.Leave -= new EventHandler(caixaTextoGride_Leave);
                        caixaTextoGride.Leave += caixaTextoGride_Leave;
                    }
                }
                else {

                    caixaTextoGride = new TextBox();
                
                }
                     

            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }

        //Evento DroDown Combo
        private void comboDataGride__DropDown(object sender, EventArgs e)
        {
            metodoPreencheCombobox();
        }

        //Pega o valor utilizado no data gride
        private void comboDataGride_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Pegando valor do index do combobox
            int indiceLista = (sender as ComboBox).SelectedIndex;

            if (indiceLista >= 0)
            {
                //Instanciando objeto forma de pagamento
                FormaPagamento formaPagamento = new FormaPagamento();
                formaPagamento = listaFormaPagamento[indiceLista];


                valorJuros = formaPagamento.taxaFormaPagamento;
                dgvFormaParcial.CurrentRow.Cells[4].Value = formaPagamento.codigoFormaPagamento;
                dgvFormaParcial.CurrentRow.Cells[7].Value = formaPagamento.taxaFormaPagamento;
                dgvFormaParcial.CurrentRow.Cells[6].Value = (formaPagamento.taxaFormaPagamento/100) * Convert.ToDouble(dgvFormaParcial.CurrentRow.Cells[2].Value);

            }
            metodoCalculaTotais();
        }

        //Evento TextoChanged do Gride
        private void caixaTextoGride_TextChanged(object sender, EventArgs e)
        {
           metodos.metodoMoedaTB(ref caixaTextoGride);
        }

        private void caixaTextoGride_Leave(object sender, EventArgs e)
        {
            metodoCalculaTotais();
        }

        //----------------------Caixa de Texto
        private void tbValorPago_TextChanged(object sender, EventArgs e)
        {
            metodos.metodoMoedaTB(ref tbValorPago);
            metodoCalculaTroco();
        }

        private void pbCalculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\system32\\calc.exe");
        }

        private void cbJuros_CheckedChanged(object sender, EventArgs e)
        {
            metodoCalculaTotais();
        }

        private void dgvFormaParcial_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            metodoCalculaTotais();
        }

        private void FrmParcialVenda_KeyDown(object sender, KeyEventArgs e)
        {
            //atalho da tecla de atalho ESC
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {
                btSair.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.F10) == true)
            {
                btCadastrar.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.F2) == true)
            {
                btExcluir.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.Enter) == true)
            {
                btAdicionar.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.F5) == true)
            {
                btDesconto.PerformClick();
            }
        }

        private void nudDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {

                btDesconto.PerformClick();
            
            }
        }

    }
}
