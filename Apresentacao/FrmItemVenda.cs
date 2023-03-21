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
    public partial class FrmItemVenda : Form
    {


        Venda objVenda = new Venda();
        NegVenda nVenda = new NegVenda();

        NegItemVenda nItem = new NegItemVenda();
        ItemVendaLista listaItemVenda = new ItemVendaLista();
        ItemVendaLista listaItemVendaExclusao = new ItemVendaLista();

        NegParcialVenda nParcial = new NegParcialVenda();

        ProdutoCor produtoCor = new ProdutoCor();
        NegProdutoCor nProdutoCor = new NegProdutoCor();

        ListaFormaPagamento listaFormaPagamento = new ListaFormaPagamento();
        NegFormaPagamento nFormaPagamento = new NegFormaPagamento();

        //----Variaveis
        String LocalSolution;
        Boolean clkSelecao = false;

        //Validacao Exclusão
        NegSangria nSangria = new NegSangria();
        Sangria sangria = new Sangria();
        NegCaixa nCaixa = new NegCaixa();
        NegDespesa nDespesa = new NegDespesa();


        //Verifica se os itens ja foram excluidos
        Boolean cancelamentoJaRealizado = false;

        public FrmItemVenda(Venda venda)
        {
            InitializeComponent();

            objVenda = venda;
        }

        //-------------Metodos
        private void AtualizarDataGrid()
        {
            try
            {
                this.dgvItemVenda.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

                if (this.listaItemVenda.Count > 0)
                {
                    this.dgvItemVenda.Rows.Add(this.listaItemVenda.Count);
                }
                else
                {
                    return;
                }

                int indice = 0;
                foreach (ItemVenda item in this.listaItemVenda)
                {
                    this.dgvItemVenda[1, indice].Value = item.codigoItemVenda;
                    this.dgvItemVenda[2, indice].Value = item.Venda.codigoVenda;
                    this.dgvItemVenda[3, indice].Value = item.ProdutoCor.Produto.codigoProduto;
                    this.dgvItemVenda[4, indice].Value = item.ProdutoCor.codigoProdutoCor;

                    this.dgvItemVenda[5, indice].Value = item.ProdutoCor.Produto.descricaoProduto;
                    this.dgvItemVenda[6, indice].Value = item.ProdutoCor.Produto.referenciaProduto;
                    this.dgvItemVenda[7, indice].Value = item.ProdutoCor.Produto.sexoProduto;
                    this.dgvItemVenda[8, indice].Value = item.ProdutoCor.Cor.nomeCor;
                    this.dgvItemVenda[9, indice].Value = item.ProdutoCor.Produto.Genero.nomeGenero;
                    this.dgvItemVenda[10, indice].Value = item.Tamanho.codigoTamanho;
                    this.dgvItemVenda[11, indice].Value = item.Tamanho.nometamanho;

                    this.dgvItemVenda[12, indice].Value = item.quantidadeVenda;
                    this.dgvItemVenda[13, indice].Value = item.precoCusto;
                    this.dgvItemVenda[14, indice].Value = item.precoVenda;
                    this.dgvItemVenda[15, indice].Value = (item.quantidadeVenda*item.precoVenda);//Total


                    //Calculo valor real recebido
                    this.dgvItemVenda[16, indice].Value = (((item.quantidadeVenda * item.precoVenda) - item.descontoItem) + item.JurosItem);//Valor Recebido


                    this.dgvItemVenda[17, indice].Value = item.Venda.formaPagamento.formaPagamento;
                    this.dgvItemVenda[18, indice].Value = item.descontoItem;
                    this.dgvItemVenda[19, indice].Value = item.JurosItem;

                    this.dgvItemVenda[20, indice].Value = item.codigoBarrasItem;
                    this.dgvItemVenda[21, indice].Value = item.ProdutoCor.ImagemProduto;
                    this.dgvItemVenda[22, indice].Value = item.estatusItem;
                    this.dgvItemVenda[23, indice].Value = item.dataItemVenda;


                    indice++;
                }

                dgvItemVenda.Update();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
       
        private void metodoCalculaTotal()
        {

            if (dgvItemVenda.RowCount > 0)
            {
                double valoTotal = 0;
                double estornoLiquido = 0;
                double valoTotalLiquido = 0;

                double extornoTotal = 0;
                double descontoTotal = 0;
                double jurosTotal = 0;

                //faz a soma dos totais dos valores do gride
                foreach (DataGridViewRow col in dgvItemVenda.Rows)
                {
                    valoTotal = valoTotal + Convert.ToDouble(col.Cells[15].Value);
                    valoTotalLiquido = valoTotalLiquido + Convert.ToDouble(col.Cells[16].Value);

                    if ((bool)col.Cells[0].FormattedValue == true)
                    {
                        extornoTotal = extornoTotal + Convert.ToDouble(col.Cells[15].Value);
                        estornoLiquido = estornoLiquido + Convert.ToDouble(col.Cells[16].Value);
                        descontoTotal = descontoTotal + Convert.ToDouble(col.Cells[18].Value);
                        jurosTotal = jurosTotal + Convert.ToDouble(col.Cells[19].Value);
                    }
                }

                //-----Total da Conta do Cliente
                lbVendaBruto.Text = String.Format("{0:C2}", estornoLiquido);//Valor Total Recebido
                lbValorLiquido.Text = String.Format("{0:C2}", valoTotalLiquido);//Valor Total Recebido
                lbDinheiro.Text = String.Format("{0:C2}", extornoTotal);//Valor Recebido Selecionado

                lbEstorno.Text = String.Format("{0:C2}", estornoLiquido);//Valor Recebido Selecionado
                lbDesconto.Text = String.Format("{0:C2}", descontoTotal);//Quantidade Total de Itens
                lbTaxa.Text = String.Format("{0:C2}", jurosTotal);//Quantidade Total de Itens
                
                //-----------Menu Calculos
                lbValorTotalVenda.Text = String.Format("{0:C2}", extornoTotal);//Valor Total Recebido
                lbJurosVenda.Text = String.Format("{0:C2}", jurosTotal);//Valor juros
                lbDescontoVenda.Text = String.Format("{0:C2}", descontoTotal);//Valor desconto
                lbVendaLiquido.Text = String.Format("{0:C2}", estornoLiquido);//Valor liquido
            }
        }

        private void metodoInicializaFormulario() {
           
            //Preenche Camopos
            tbCodigo.Text = objVenda.Cliente.codigoCliente.ToString();
            tbNome.Text = objVenda.Cliente.nomeCliente;
            tbSobrenome.Text = objVenda.Cliente.sobrenomeCliente;
            mtbCpf.Text = objVenda.Cliente.cpfCliente;
            mtbCelular.Text = objVenda.Cliente.celularCliente;

            //-----Preencher o Gride com os dados do ITemVenda
            listaItemVenda = nItem.BuscarItemVendaPorVenda(objVenda.codigoVenda);//Busca itens da venda

            //Atualiza Gride
            AtualizarDataGrid();

            //Exibe Imagem Produto
            metodoExibeImagemProduto();

            //Calcula
            metodoCalculaTotal();  
        }

        private void metodoExibeImagemProduto()
        {
            if (dgvItemVenda.Rows.Count > 0)
            {
                //Buscal Local que a Solution Está sendo Executada no Computador
                LocalSolution = Environment.CurrentDirectory;
                // This will get the current PROJECT directory
                LocalSolution = Directory.GetParent(LocalSolution).Parent.Parent.FullName;

                String imgProduto = (dgvItemVenda.CurrentRow.Cells[21].Value).ToString();
                //Verifica se a imagem existe
                if (System.IO.File.Exists(LocalSolution + "\\Imagens\\" + imgProduto + ".jpeg") == true)
                {
                    //----------------Cria imagem para exibir 
                    Image img;
                    Bitmap img2;
                    img = (System.Drawing.Image.FromFile(LocalSolution + "\\Imagens\\" + imgProduto + ".jpeg"));
                    img2 = new Bitmap(img);
                    img.Dispose();
                    pbImagemProduto.Image = img2;
                }
                else
                {
                    pbImagemProduto.Image = global::Apresentacao.Properties.Resources.imgDefaut;
                }
            }

        }

        //Métodos para adicionar Valores do Gride na Lista
        public void metodoAddItemLista()
        {
            try
            {
                if (dgvItemVenda.RowCount > 0)
                {

                    //Percorre o gride para adicionar itens
                    listaItemVendaExclusao = new ItemVendaLista();
                    
                    foreach (DataGridViewRow row in dgvItemVenda.Rows)
                    {
                        //Só adiciona os itens marcados no caso seleciondados
                        if ((bool)row.Cells[0].FormattedValue == true)
                        {
                            foreach (ItemVenda item in listaItemVenda)
                            {

                                if (item.codigoItemVenda == Convert.ToInt32(row.Cells[1].Value)) {

                                    listaItemVendaExclusao.Add(item);

                                    break;
                                }
                            
                            }                                                      
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //MEtodo Lambida Menor Data de uma lista
        private DateTime metodoDataVenda(){
            try
            {
                DateTime min = listaItemVenda.Min(c => c.dataItemVenda);
                return min;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message);
            return DateTime.Now;
            }
        }

        //Valida Sangria
        #region Metodo valida cancelamento vinculo sangria

        private Boolean metodoValidaCancelamentoSangria() {

            //Verifica se há sangria para realizar cancelamento
            foreach (ItemVenda item in listaItemVendaExclusao)
            {
                //-----------------------------------------------------------------------------PARCIAL
                if (item.Venda.formaPagamento.formaPagamento == "PARCIAL") {

                    //Verifica se há sangria no dia da parcial
                    if (nSangria.BuscarCancelamentoSangriaPorData(item.dataItemVenda) == true)
                    {

                        //Chama Formulario de cancelamento da Parcial
                        DialogResult resultadoParcial;
                        FrmAlterarExcluirParcialVenda FrmParcialVenda = new FrmAlterarExcluirParcialVenda(objVenda, listaItemVendaExclusao);

                        resultadoParcial = FrmParcialVenda.ShowDialog();

                        if (resultadoParcial == DialogResult.Yes)
                        {
                            //Se o retorno for Sim atualiza os dados da venda buscando venda por codigo
                            objVenda = nVenda.BuscarVendaPorCodigo(objVenda.codigoVenda);

                            //Caso parcial e itens da venda forem excluidos retorna confimando cancelamento
                            if (objVenda == null) {

                                FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Itens Cancelados",
                               "Itens cancelados com sucesso!",
                               Properties.Resources.DialogOK,
                               System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                               Color.White,
                               "Ok", "",
                               false);

                               frmCaixaCad.ShowDialog();

                               cancelamentoJaRealizado = true;
                               this.DialogResult = DialogResult.Yes;
                               this.Close();
                               break;
                            }

                            metodoInicializaFormulario();
                            break;
                        }
                        else
                        {
                            //Erro ao Cancelar Parcial
                            FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Erro ao Cancelar Parcial",
                            "Não foi possível cancelar as Parciais!",
                            Properties.Resources.DialogErro,
                            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                            Color.White,
                            "Ok", "",
                            false);
                            frmCaixaCad.ShowDialog();

                            return false;
                        }
                    }
                }

                //Item não tiver parcial cancelamento normal
                sangria = nSangria.BuscarCancelamentoSangria(item.dataItemVenda, item.Venda.formaPagamento.codigoFormaPagamento);

                if (sangria != null)
                {
                    sangria.dataSangria = item.dataItemVenda;
                    double valorTotalItem = (from x in listaItemVendaExclusao where (x.Venda.formaPagamento.codigoFormaPagamento == sangria.pagamentoSangria.codigoFormaPagamento) select ((x.quantidadeVenda * x.precoVenda)+x.JurosItem-x.descontoItem)).Sum();

                    SangriaLista sangriaLista = new SangriaLista();
                    sangriaLista = nSangria.BuscarSangriaParaCancelamento(sangria.dataSangria);
                    double valorSangria = (from s in sangriaLista where (s.pagamentoSangria.codigoFormaPagamento == item.Venda.formaPagamento.codigoFormaPagamento) select (s.valorSangria)).Sum();

                    CaixaLista caixaLista = new CaixaLista();
                    caixaLista = nCaixa.BuscarCaixaValores(sangria.dataSangria);
                    double valorCaixa = (from c in caixaLista where (c.formaPagamento.codigoFormaPagamento == item.Venda.formaPagamento.codigoFormaPagamento) select (c.valorCaixa)).Sum();

                    //Valor restante do Caixa For igual o da Sangria não é necessário o cancelmento
                    if ((valorSangria) >= valorCaixa - valorTotalItem)
                    {//Verifica se há necessidade da atualização da sangria

                        DialogResult resultadoAtualizacaoSangria;
                        FrmCancelamentoSangria frmSangria = new FrmCancelamentoSangria(sangria, caixaLista, null, listaItemVendaExclusao, null, null);
                        resultadoAtualizacaoSangria = frmSangria.ShowDialog();

                        if (resultadoAtualizacaoSangria == DialogResult.Yes)
                        {

                            return true;

                        }
                        else {

                            return false;
                        
                        }
                    }
                }

            }//Foreach

            return  true;
        }


        private Boolean metodoValidaCancelamentoDespesa() { 
        
          //Verifica se há sangria para realizar cancelamento
            foreach (ItemVenda item in listaItemVendaExclusao)
            {
                #region Parcial Cancela
                //---------------------------------------------------------------------------Parcial - Despesa -> Cancelamento
                if (item.Venda.formaPagamento.formaPagamento == "PARCIAL")
                {
                     //Verifica se há despesa no dia da parcial
                    if (nDespesa.BuscarCancelamentoDespesaPorData(item.dataItemVenda) == true)
                    {
                        //Chama Formulario de cancelamento da Parcial
                        DialogResult resultadoParcial;
                        FrmAlterarExcluirParcialVenda FrmParcialVenda = new FrmAlterarExcluirParcialVenda(objVenda, listaItemVendaExclusao);

                        resultadoParcial = FrmParcialVenda.ShowDialog();

                        if (resultadoParcial == DialogResult.Yes)
                        {
                            //Se o retorno for Sim atualiza os dados da venda buscando venda por codigo
                            objVenda = nVenda.BuscarVendaPorCodigo(objVenda.codigoVenda);

                            //Caso parcial e itens da venda forem excluidos retorna confimando cancelamento
                            if (objVenda == null) {

                                FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Itens Cancelados",
                               "Itens cancelados com sucesso!",
                               Properties.Resources.DialogOK,
                               System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                               Color.White,
                               "Ok", "",
                               false);
                               frmCaixaCad.ShowDialog();

                               cancelamentoJaRealizado = true;
                               this.DialogResult = DialogResult.Yes;
                               this.Close();
                               break;
                            }

                            metodoInicializaFormulario();
                            break;
                        }
                        else
                        {
                            //Erro ao Cancelar Parcial
                            FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Erro ao Cancelar Parcial - Despesa",
                            "Não foi possível cancelar as Parciais!",
                            Properties.Resources.DialogErro,
                            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                            Color.White,
                            "Ok", "",
                            false);
                            frmCaixaCad.ShowDialog();

                            return false;
                        }
                   
                    }//Verifica se existe sangria no dia da Parcial

                }//Verifica se existe Parcial no item
                #endregion
                //--------------------------------------------------------------Cancelamento da Parcial - Despesa
                DespesaCaixa despesaValida = null;
                //Item não tiver parcial cancelamento normal -> Despesa Recebe o valor restante do caixa
                despesaValida = nDespesa.BuscarCancelamentoDespesa(item.dataItemVenda, item.Venda.formaPagamento.codigoFormaPagamento);
                
                if (despesaValida != null)
                {

                    //TotalExcluir
                    despesaValida.dataDespesa = item.dataItemVenda; 
                    double valorTotalItem = (from x in listaItemVendaExclusao where (x.Venda.formaPagamento.codigoFormaPagamento == despesaValida.formaPagamento.codigoFormaPagamento) select ((x.quantidadeVenda * x.precoVenda) + x.JurosItem - x.descontoItem)).Sum();

                    //DESPESA
                    ListaDespesas despesaLista = new ListaDespesas();
                    despesaLista = nDespesa.BuscarDespesaPorData(despesaValida.dataDespesa, despesaValida.dataDespesa);
                    double valorDespesa = (from d in despesaLista where (d.formaPagamento.codigoFormaPagamento == item.Venda.formaPagamento.codigoFormaPagamento) select (d.valorDespesa)).Sum();                 

                    //SANGRIA
                    SangriaLista sangriaLista = new SangriaLista();
                    sangriaLista = nSangria.BuscarSangriaParaCancelamento(despesaValida.dataDespesa);
                    double valorSangria = (from s in sangriaLista where (s.pagamentoSangria.codigoFormaPagamento == item.Venda.formaPagamento.codigoFormaPagamento) select (s.valorSangria)).Sum();

                    //CAIXA
                    CaixaLista caixaLista = new CaixaLista();
                    caixaLista = nCaixa.BuscarCaixaValores(despesaValida.dataDespesa);
                    double valorCaixa = (from c in caixaLista where (c.formaPagamento.codigoFormaPagamento == item.Venda.formaPagamento.codigoFormaPagamento) select (c.valorCaixa)).Sum();


                    //Despesa for maior que o resto que sobrou no caixa não necessita cancelamento
                    if ((valorDespesa) >= (valorCaixa - valorTotalItem - valorSangria))
                    {
                        FrmCancelamentoDespesa frmDespesa
                            = new FrmCancelamentoDespesa(null, listaItemVendaExclusao, null, null);

                        DialogResult resultadoAtualizacaoSangria = frmDespesa.ShowDialog();

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


        #endregion
        //----------------Formulário
        private void FrmItemVenda_Load(object sender, EventArgs e)
        {
  
            metodoInicializaFormulario();
            dtpDataInicial.Value = objVenda.dataVenda;


        }

        //------------------Botões
        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair do Item Venda?",
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

        private void pbCalculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\system32\\calc.exe");
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            try{
            //Adicicona itens do gride para realizar cancelamento.  
            metodoAddItemLista();

                //Realiza cancelamento dos itens
                if (listaItemVendaExclusao.Count > 0)
                {
                    DialogResult resposta;
                    //Criando Caixa de dialogo
                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Cancelamento",
                    " Deseja realmente realizar o Cancelamento?",
                    Properties.Resources.DialogQuestion,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Confirmar", "Cancelar",
                    false);
                    resposta = frmCaixa.ShowDialog();

                    if (resposta == DialogResult.Yes)
                    {

                    //método verifica se há sangria vinculada com venda para realizar atualização
                  if ( metodoValidaCancelamentoDespesa() == true)
                      //metodoValidaCancelamentoSangria() == true &&
                    {
                        if (cancelamentoJaRealizado == false)
                        {
                          //Se não haver mais sangria pergunta se quer cancelar tudo
                            if (nSangria.BuscarCancelamentoSangriaPorData(objVenda.dataVenda) == false || nSangria.ValidaSangriaFormaPagamento(objVenda.dataVenda, objVenda.formaPagamento.codigoFormaPagamento) == false)
                            {

                                #region Cancela Todos os Itens
                                //----------------------------------------------Cancela Todos os Itens e Parciais da Venda 
                                if (listaItemVendaExclusao.Count == dgvItemVenda.RowCount)
                                {

                                    DialogResult respostaAtualiza;
                                    //Criando Caixa de dialogo
                                    FrmCaixaDialogo frmCaixaAtualiza = new FrmCaixaDialogo("Cancelamento Itens!",
                                    "Deseja excluir todos os itens e parciais?",
                                    Properties.Resources.DialogExcluir,
                                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                    Color.White,
                                    "Sim", "Não",
                                    false);
                                    respostaAtualiza = frmCaixaAtualiza.ShowDialog();

                                    if (respostaAtualiza == DialogResult.Yes)
                                    {

                                        if (nParcial.ExcluirParcialPorVenda(objVenda) == true)//Exclui Todas as Parciais da Venda
                                        {
                                            if (nItem.ExcluirItemVenda(listaItemVendaExclusao) == true)
                                            {
                                                //----------------------------Realiza Impressão
                                                DialogResult respostaImpressao;
                                                //Criando Caixa de dialogo
                                                FrmCaixaDialogo frmCaixaImpressao = new FrmCaixaDialogo("Exclusão Realizada!",
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
                                                    this.DialogResult = DialogResult.Yes; //Após a impressão fecha o formulário
                                                    //ImprimiComprovante()
                                                    //Tem que Ter CodigoParcial
                                                    //Valor Venda
                                                    //Itens
                                                    //Imprimir Total Venda 
                                                    //Com Acréscimos e sem acréscimos
                                                    //Venda antes e Depois dos Acréscimos
                                                }

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
                                    }
                                }
                                #endregion

                                #region  Cancela Parciais
                                //------------------------------------------------Cancelar Parcial Venda
                                else if (objVenda.formaPagamento.formaPagamento == "PARCIAL")
                                {
                                    //Chama Formulario de cancelamento da Parcial
                                    DialogResult resultadoParcial;
                                    FrmAlterarExcluirParcialVenda FrmParcialVenda = new FrmAlterarExcluirParcialVenda(objVenda, listaItemVendaExclusao);
                                    resultadoParcial = FrmParcialVenda.ShowDialog();


                                    if (resultadoParcial == DialogResult.Yes)
                                    {

                                        //Se o retorno for Sim atualiza os dados da venda buscando venda por codigo
                                        objVenda = nVenda.BuscarVendaPorCodigo(objVenda.codigoVenda);
                                    }
                                    else
                                    {
                                        //Erro ao Cancelar Parcial
                                        FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Erro ao Cancelar Parcial",
                                        "Não foi possível cancelar as Parciais!",
                                        Properties.Resources.DialogErro,
                                        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                        Color.White,
                                        "Ok", "",
                                        false);
                                        frmCaixaCad.ShowDialog();
                                    }
                                }
                                #endregion

                                #region Cancela Item Venda
                                //--------------------------------------Cancelar Item da Venda
                                else
                                {
                                    if (nItem.ExcluirItemVenda(listaItemVendaExclusao) == true)
                                    {
                                        //----------------------------Realiza Impressão
                                        DialogResult respostaImpressao;
                                        //Criando Caixa de dialogo
                                        FrmCaixaDialogo frmCaixaImpressao = new FrmCaixaDialogo("Exclusão Realizada!",
                                        "Cancelamento realizado com sucesso !\r\n" +
                                        "Deseja Realizar Impressão do Comprovante?",
                                        Properties.Resources.DialogOK,
                                        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                        Color.White,
                                        "Sim", "Não",
                                        false);
                                        respostaImpressao = frmCaixaImpressao.ShowDialog();
                                        //----------------------------------ImprimiComprovanteVenda
                                        if (resposta == DialogResult.Yes)
                                        {
                                            //Retornando que exclusão foi realizada com sucesso
                                            // this.DialogResult = DialogResult.Yes;
                                            //ImprimiComprovante()
                                            //Tem que Ter CodigoParcial
                                            //Valor Venda
                                            //Itens
                                            //Imprimir Total Venda 
                                            //Com Acréscimos e sem acréscimos
                                            //Venda antes e Depois dos Acréscimos
                                        }

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
                                #endregion
                            }
                        }
                        else { 
                            this.DialogResult = DialogResult.Yes; 
                            this.Dispose(); }//Finaliza pois itens ja foram excluidos
                    }
                    else
                    {
                        MessageBox.Show("Atualize os dados da sangria para realizar cancelamento!",
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                      if (cancelamentoJaRealizado == false)
                      {
                        metodoInicializaFormulario();//Atualiza dados do formulário
                      }
                  }
            }//Não há itens selecionado

        }
            catch(Exception ex){

               MessageBox.Show(ex.Message,
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
        }

        private void btBuscarTodos_Click(object sender, EventArgs e)
        {
            metodoInicializaFormulario();
        }

        //----Filtro Caixa de Texto
        private void tbBuscarProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbProduto_Click(null, null);
                e.Handled = true;
            }
        }

        private void tbBuscarProduto_Enter(object sender, EventArgs e)
        {
            cbFormaPagamento.Items.Clear();
            produtoCor = new ProdutoCor();

            tbBuscarProduto.Clear();
            pbProduto.Image = Properties.Resources.ProdutoRosa;
            panelBuscarProduto.BackColor = Color.DeepPink;
        }

        private void tbBuscarProduto_Leave(object sender, EventArgs e)
        {
            if (tbBuscarProduto.Text == "")
            {
                tbBuscarProduto.Text = "Digite a descrição do produto ...";
                pbProduto.Image = Properties.Resources.ProdutoAzul;
                panelBuscarProduto.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                tbBuscarProduto.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

            }
        }

        private void pbProduto_Click(object sender, EventArgs e)
        {
            //Erro quando informado um valor que não existe na tabela
            cbFormaPagamento.Items.Clear();

            int n;
            bool ehUmNumero = int.TryParse(tbBuscarProduto.Text, out n);
            if (ehUmNumero == true)
            {
                produtoCor = nProdutoCor.BuscarProdutoItemVendaPorCodigo(n, objVenda.codigoVenda);
                if (produtoCor != null)
                {
                    this.tbBuscarProduto.Text = produtoCor.Produto.descricaoProduto;
                    cbFormaPagamento.Focus();
                }
                else
                {
                    FrmSelecionarProdutoItemVenda frmProdutoCrediarioPago = new FrmSelecionarProdutoItemVenda(objVenda, tbBuscarProduto.Text);
                    DialogResult resultado = frmProdutoCrediarioPago.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {

                        this.produtoCor = frmProdutoCrediarioPago.produtoCorSelecionado;
                        this.tbBuscarProduto.Text = produtoCor.Produto.descricaoProduto;
                        cbFormaPagamento.Focus();

                    }

                }
            }
            else
            {
                FrmSelecionarProdutoItemVenda frmProdutoCrediarioPago = new FrmSelecionarProdutoItemVenda(objVenda, tbBuscarProduto.Text);
                DialogResult resultado = frmProdutoCrediarioPago.ShowDialog();

                if (resultado == DialogResult.OK)
                {

                    this.produtoCor = frmProdutoCrediarioPago.produtoCorSelecionado;
                    this.tbBuscarProduto.Text = produtoCor.Produto.descricaoProduto;
                    cbFormaPagamento.Focus();
                }

            }

        }

        private void cbFormaPagamento_DropDown(object sender, EventArgs e)
        {
            try
            {
                string produtoPago = "";

                if (produtoCor.Produto != null)
                {

                    produtoPago = produtoCor.Produto.descricaoProduto;
                }

                cbFormaPagamento.Items.Clear();
                this.listaFormaPagamento = nFormaPagamento.BuscarFormaPagamentoItemVenda(produtoPago, objVenda.codigoVenda);

                foreach (FormaPagamento pag in this.listaFormaPagamento)
                {
                    if (pag.taxaFormaPagamento == 0)
                    {

                        this.cbFormaPagamento.Items.IndexOf(pag.codigoFormaPagamento);
                        this.cbFormaPagamento.Items.Add(pag.formaPagamento);

                    }
                    else
                    {
                        this.cbFormaPagamento.Items.IndexOf(pag.codigoFormaPagamento);
                        this.cbFormaPagamento.Items.Add(pag.formaPagamento + " - " + pag.taxaFormaPagamento.ToString("F"));
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void pbFiltrar_Click(object sender, EventArgs e)
        {
            //Gerar Filtros do Gride
            listaItemVenda = new ItemVendaLista();


            string descricaoProdutoBuscar = "";

            if (tbBuscarProduto.Text != "Digite a descrição do produto ...")
            {

                descricaoProdutoBuscar = tbBuscarProduto.Text;
            }

            listaItemVenda = nItem.BuscarItemVendaPorFiltros(objVenda.codigoVenda, descricaoProdutoBuscar, cbFormaPagamento.Text, dtpDataInicial.Value, dtpDataFinal.Value);
            AtualizarDataGrid();

            //Data
            dtpDataInicial.Value = objVenda.dataVenda;
            metodoCalculaTotal();
        }

        private void pbLimpar_Click(object sender, EventArgs e)
        {
            dtpDataInicial.Value = objVenda.dataVenda;
            cbFormaPagamento.Items.Clear();
            dtpDataFinal.Value = DateTime.Now;
            tbBuscarProduto.Text = "Digite a descrição do produto ...";
            metodoInicializaFormulario();

        }

        //--------------------DataGride
        private void dgvItemVenda_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvItemVenda.Columns[e.ColumnIndex].Name == "marcarItem")
            {

                if (clkSelecao == false)
                {
                    clkSelecao = true;
                    foreach (DataGridViewRow dtr in dgvItemVenda.Rows)
                    {
                        ((DataGridViewCheckBoxCell)dtr.Cells[0]).Value = true;
                    }
                }
                else
                {
                    clkSelecao = false;
                    foreach (DataGridViewRow dtr in dgvItemVenda.Rows)
                    {
                        ((DataGridViewCheckBoxCell)dtr.Cells[0]).Value = false;
                    }

                }

                btCancelar.Focus();
                metodoCalculaTotal();
            }
        }

        private void dgvItemVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvItemVenda.Columns[e.ColumnIndex].Name == "marcarItem")
                {
                    dgvItemVenda.EndEdit();
                    //percorre todas as linhas do gride
                    foreach (DataGridViewRow check in dgvItemVenda.Rows)
                    {
                        //pega valores cheked no gride
                        if ((bool)check.Cells[0].FormattedValue)
                        {
                            metodoCalculaTotal();
                        }
                        else
                        {

                            metodoCalculaTotal();
                        }

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

        private void dgvItemVenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            metodoExibeImagemProduto();
        }

        private void FrmItemVenda_KeyDown(object sender, KeyEventArgs e)
        {
            //atalho da tecla de atalho ESC
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {
                btSair.PerformClick();
            }
            //atalho para o botão cadastrar
            else if (e.KeyCode.Equals(Keys.F5) == true)
            {
                btBuscarTodos.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.F2) == true)
            {
                btCancelar.PerformClick();
            }
        }



    }
}
