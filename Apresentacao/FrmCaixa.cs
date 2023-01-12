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
using System.Windows.Forms.DataVisualization.Charting;

namespace Apresentacao
{
    public partial class FrmCaixa : Form
    {
        NegCaixa nCaixa = new NegCaixa();
        ItemCaixa objItemCaixa = new ItemCaixa();
        ItemCaixaLista listaItemCaixa = new ItemCaixaLista();

        Caixa objCaixa = new Caixa();
        CaixaLista listaCaixa = new CaixaLista();

        //Variaveis
        String LocalSolution;

        double totalVendaCaixa = 0;//Total c
        double totalCrediario = 0;
        double totalCrediarioPago = 0;

        public FrmCaixa()
        {
            InitializeComponent();
        }

        //método calcula totais
        private void metodoCalculaTotais() {

            totalVendaCaixa = 0;
            totalCrediario = 0;
            totalCrediarioPago = 0;

            double totalRecebido = 0;
            double totalJuros = 0;
            double totalDesconto = 0;

            int totalQuantidade = 0;

            //Estorno Buscar banco de dados na tabela estorno
            double totalEstorno = 0;//Total de cancelamentos valores estornados

            #region Calcula total Detalhado
                foreach (DataGridViewRow row in dgvCaixa.Rows)
                {

                    if (row.Cells[1].Value.ToString() == "AVISTA")
                    {
                        totalVendaCaixa = totalVendaCaixa + Convert.ToDouble(row.Cells[17].Value);
                        totalJuros = totalJuros + Convert.ToDouble(row.Cells[21].Value);
                        totalDesconto = totalDesconto + Convert.ToDouble(row.Cells[20].Value);
                        totalQuantidade = totalQuantidade + Convert.ToInt32(row.Cells[14].Value);
                        totalRecebido = totalRecebido + Convert.ToDouble(row.Cells[18].Value);
                    }
                    if (row.Cells[1].Value.ToString() == "PARCIAL AVISTA")
                    {
                        totalVendaCaixa = totalVendaCaixa + Convert.ToDouble(row.Cells[17].Value);
                        totalJuros = totalJuros + Convert.ToDouble(row.Cells[21].Value);
                        totalDesconto = totalDesconto + Convert.ToDouble(row.Cells[20].Value);
                        totalQuantidade = totalQuantidade + Convert.ToInt32(row.Cells[14].Value);
                        totalRecebido = totalRecebido + Convert.ToDouble(row.Cells[18].Value);
                    }

                    if (row.Cells[1].Value.ToString() == "CREDIARIO")
                    {

                        totalCrediario = totalCrediario + Convert.ToDouble(row.Cells[17].Value);
                        totalJuros = totalJuros + Convert.ToDouble(row.Cells[21].Value);
                        totalDesconto = totalDesconto + Convert.ToDouble(row.Cells[20].Value);
                        totalQuantidade = totalQuantidade + Convert.ToInt32(row.Cells[14].Value);
                        totalRecebido = totalRecebido + Convert.ToDouble(row.Cells[18].Value);
                    }
                    if (row.Cells[1].Value.ToString() == "CREDIARIO PAGO")
                    {

                        totalCrediarioPago = totalCrediarioPago + Convert.ToDouble(row.Cells[17].Value);
                        totalJuros = totalJuros + Convert.ToDouble(row.Cells[21].Value);
                        totalDesconto = totalDesconto + Convert.ToDouble(row.Cells[20].Value);
                        totalQuantidade = totalQuantidade + Convert.ToInt32(row.Cells[14].Value);
                        totalRecebido = totalRecebido + Convert.ToDouble(row.Cells[18].Value);
                    }

                    if (row.Cells[1].Value.ToString() == "CREDIARIO PARCIAL")
                    {

                        totalCrediarioPago = totalCrediarioPago + Convert.ToDouble(row.Cells[18].Value) - Convert.ToDouble(row.Cells[21].Value) + Convert.ToDouble(row.Cells[20].Value);
                        totalJuros = totalJuros + Convert.ToDouble(row.Cells[21].Value);
                        totalDesconto = totalDesconto + Convert.ToDouble(row.Cells[20].Value);
                        totalQuantidade = totalQuantidade + Convert.ToInt32(row.Cells[14].Value);
                        totalRecebido = totalRecebido + Convert.ToDouble(row.Cells[18].Value);
                    }
                }
                #endregion

            lbDinheiro.Text = String.Format("{0:C2}", totalRecebido);//RECEBIDO
            lbJuros.Text = String.Format("{0:C2}", totalJuros);
            lbDesconto.Text = String.Format("{0:C2}", totalDesconto);
            lbQuantidade.Text = (totalQuantidade).ToString();

            lbValorTotalVenda.Text = String.Format("{0:C2}", totalVendaCaixa);
            lbTotalCrediarioPago.Text = String.Format("{0:C2}", totalCrediarioPago);
            lbCrediario.Text = String.Format("{0:C2}", totalCrediario);
            lbTotalEstorno.Text = String.Format("{0:C2}", totalEstorno);

        }

        //método preenche dataGridDetalhado
        private void metodoAtualizaDataGridDetalhado() { 
        
            this.dgvCaixa.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.listaItemCaixa.Count > 0)
            {
                this.dgvCaixa.Rows.Add(this.listaItemCaixa.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (ItemCaixa item in this.listaItemCaixa)
            {
                this.dgvCaixa[0, indice].Value = item.Venda.codigoVenda;
                this.dgvCaixa[1, indice].Value = item.tipoVenda;
                this.dgvCaixa[2, indice].Value = item.formaPagamento.codigoFormaPagamento;
                this.dgvCaixa[3, indice].Value = item.formaPagamento.formaPagamento;
                this.dgvCaixa[4, indice].Value = item.ProdutoCor.Produto.codigoProduto;
                this.dgvCaixa[5, indice].Value = item.ProdutoCor.codigoProdutoCor;
                this.dgvCaixa[6, indice].Value = item.ProdutoCor.Produto.descricaoProduto;
                this.dgvCaixa[7, indice].Value = item.ProdutoCor.Produto.referenciaProduto;
                this.dgvCaixa[8, indice].Value = item.ProdutoCor.Produto.sexoProduto;
                this.dgvCaixa[9, indice].Value = item.ProdutoCor.Cor.nomeCor;
                this.dgvCaixa[10, indice].Value = item.ProdutoCor.Produto.Genero.nomeGenero;
                this.dgvCaixa[11, indice].Value = item.ProdutoCor.Produto.Grade.nomeGrade;
                this.dgvCaixa[12, indice].Value = item.tamanho.codigoTamanho;
                this.dgvCaixa[13, indice].Value = item.tamanho.nometamanho;
                this.dgvCaixa[14, indice].Value = item.quantidadeItem;
                this.dgvCaixa[15, indice].Value = item.custoItem;
                this.dgvCaixa[16, indice].Value = item.vendaItem;
                this.dgvCaixa[17, indice].Value = item.totalItem;
                this.dgvCaixa[18, indice].Value = item.recebidoItem;
                this.dgvCaixa[19, indice].Value = item.ProdutoCor.ImagemProduto;
                this.dgvCaixa[20, indice].Value = item.descontoItem;
                this.dgvCaixa[21, indice].Value = item.jurosItem;
                this.dgvCaixa[22, indice].Value = item.cliente.nomeCliente;
                this.dgvCaixa[23, indice].Value = item.funcionario.nomeFuncionario;
                this.dgvCaixa[24, indice].Value = item.fornecedor.nomeFantasiaFornecedor;
                this.dgvCaixa[25, indice].Value = item.dataItem;
                this.dgvCaixa[26, indice].Value = item.estatusItem;

                indice++;
            }

            dgvCaixa.Update();
        
        }

        //método preenche dataGrid
        private void metodoAtualizaDataGrid()
        {

            this.dgvCaixa.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.listaCaixa.Count > 0)
            {
                this.dgvCaixa.Rows.Add(this.listaCaixa.Count);
            }
            else
            {
                return;
            }

            int indice = 0;

            foreach (Caixa item in this.listaCaixa)
            {
                this.dgvCaixa[1, indice].Value = item.tipoVenda;
                this.dgvCaixa[3, indice].Value = item.formaPagamento.formaPagamento;
                this.dgvCaixa[17, indice].Value = item.valorCaixa;
                this.dgvCaixa[18, indice].Value = item.recebidoCaixa;
                this.dgvCaixa[20, indice].Value = item.descontoCaixa;
                this.dgvCaixa[21, indice].Value = item.jurosCaixa;
                this.dgvCaixa[25, indice].Value = item.dataCaixa;
                this.dgvCaixa[26, indice].Value = item.estatusCaixa;

                indice++;
            }

            dgvCaixa.Update();

        }

        private void metodoExibeImagemProduto()
        {
            if (dgvCaixa.Rows.Count > 0)
            {
                if (dgvCaixa.CurrentRow.Cells[19].Value != null)
                {
                    //Buscal Local que a Solution Está sendo Executada no Computador
                    LocalSolution = Environment.CurrentDirectory;
                    // This will get the current PROJECT directory
                    LocalSolution = Directory.GetParent(LocalSolution).Parent.Parent.FullName;

                    String imgProduto = (dgvCaixa.CurrentRow.Cells[19].Value).ToString();
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

        }

        //Método preenche lista de acordo com os filtros
        private void metodoBuscarCaixaDetalhado()
        {

            listaItemCaixa = new ItemCaixaLista();

            string Avista;
            string CrediarioPendente;
            string CrediarioPago;

            string nomeCliente;
            string nomeFuncionario;
            string strDinheiro;
            string strPix;
            string strCredito;
            string strDebito;
            string strCheque;
            string strParcial;
            DateTime dataInicio;
            DateTime dataFim;

            //Tipos Venda
            if (cbVenda.Checked == true) { Avista = "ok"; } else { Avista = ""; }
            if (cbCrediarioPago.Checked == true) { CrediarioPago = "ok"; } else { CrediarioPago = ""; }
            if (cbCrediarioPendente.Checked == true) { CrediarioPendente = "ok"; } else { CrediarioPendente = ""; }

            //Formas de Pagamento
            if (cbCredito.Checked == true)
            {
                strCredito = "CRÉDITO";
                if (cbFormaPagamento.Text != string.Empty)
                {

                    strCredito = cbFormaPagamento.Text;
                }
            }
            else
            {
                strCredito = "null";
            }
            if (cbDinheiro.Checked == true) { strDinheiro = "DINHEIRO"; } else { strDinheiro = ""; }
            if (cbPix.Checked == true) { strPix = "PIX"; } else { strPix = ""; }
            if (cbDebito.Checked == true) { strDebito = "DÉBITO"; } else { strDebito = ""; }
            if (cbCheque.Checked == true) { strCheque = "CHEQUE"; } else { strCheque = ""; }
            if (cbParcial.Checked == true) { strParcial = "PARCIAL"; } else { strParcial = ""; }
            //CLIENTE E FUNCIONÁRIO
            if (tbBuscarCliente.Text != string.Empty && tbBuscarCliente.Text != "Digite o nome do cliente ...")
            { nomeCliente = tbBuscarCliente.Text; }
            else { nomeCliente = ""; }

            if (tbFuncionario.Text != string.Empty && tbFuncionario.Text != "Digite o nome do funcionário ...")
            { nomeFuncionario = tbFuncionario.Text; }
            else { nomeFuncionario = ""; }


            //DATA INICIO E DATA FIM VENDAS
            dataInicio = dtpDataInicial.Value;
            dataFim = dtpDataFinal.Value;

            if (cbParcialDetalhada.Checked == false)
            {

                listaItemCaixa = nCaixa.BuscarCaixaDetalhado(Avista, CrediarioPendente, CrediarioPago, nomeCliente, nomeFuncionario, strDinheiro, strPix, strCredito, strDebito, strCheque, strParcial, dataInicio, dataFim);

            }
            else
            {
                listaItemCaixa = nCaixa.BuscarCaixaDetalhadoParciais(Avista, CrediarioPendente, CrediarioPago, nomeCliente, nomeFuncionario, strDinheiro, strPix, strCredito, strDebito, strCheque, strParcial, dataInicio, dataFim);
                //atualizar valores das parciais na lista
                metodoBuscarCaixaDetalhadoParcial();

            }
        }

        //Exibe totais detalhados de compras parciais
        private void metodoBuscarCaixaDetalhadoParcial()
        {
            ItemCaixaLista listaNova = new ItemCaixaLista();
            int contador = 0;
            int contadorFormaPagamento;
         
            foreach (ItemCaixa item in listaItemCaixa) {

                if (item.tipoVenda == "PARCIAL AVISTA")
                {
                    contador = (listaItemCaixa.Where(u => u.codigoItem == item.codigoItem && u.Venda.codigoVenda == item.Venda.codigoVenda).Count());
                    contadorFormaPagamento = (listaItemCaixa.Where(u => u.formaPagamento.formaPagamento == item.formaPagamento.formaPagamento && u.Venda.codigoVenda == item.Venda.codigoVenda).Count());
            
                    item.totalItem = (item.totalItem / contador);
                    item.jurosItem = item.jurosItem / contadorFormaPagamento;
                    item.descontoItem = item.descontoItem / contadorFormaPagamento;
                    item.recebidoItem = item.totalItem + item.jurosItem - item.descontoItem;
                    item.quantidadeItem = 0;
                }


                    listaNova.Add(item);
                
            }

        }

        //Método preenche lista de acordo com os filtros
        private void metodoBuscarCaixa()
        {

            listaCaixa = new CaixaLista();

            string Avista;
            string CrediarioPendente;
            string CrediarioPago;

            string nomeCliente;
            string nomeFuncionario;
            string strDinheiro;
            string strPix;
            string strCredito;
            string strDebito;
            string strCheque;
            string strParcial;
            DateTime dataInicio;
            DateTime dataFim;

            //Tipos Venda
            if (cbVenda.Checked == true) { Avista = "ok"; } else { Avista = ""; }
            if (cbCrediarioPago.Checked == true) { CrediarioPago = "ok"; } else { CrediarioPago = ""; }
            if (cbCrediarioPendente.Checked == true) { CrediarioPendente = "ok"; } else { CrediarioPendente = ""; }

            //Formas de Pagamento
            if (cbCredito.Checked == true)
            {
                strCredito = "CRÉDITO";
                if (cbFormaPagamento.Text != string.Empty)
                {

                    strCredito = cbFormaPagamento.Text;
                }
            }
            else
            {
                strCredito = "null";
            }
            if (cbDinheiro.Checked == true) { strDinheiro = "DINHEIRO"; } else { strDinheiro = ""; }
            if (cbPix.Checked == true) { strPix = "PIX"; } else { strPix = ""; }
            if (cbDebito.Checked == true) { strDebito = "DÉBITO"; } else { strDebito = ""; }
            if (cbCheque.Checked == true) { strCheque = "CHEQUE"; } else { strCheque = ""; }
            if (cbParcial.Checked == true) { strParcial = "PARCIAL"; } else { strParcial = ""; }
            //CLIENTE E FUNCIONÁRIO
            if (tbBuscarCliente.Text != string.Empty && tbBuscarCliente.Text != "Digite o nome do cliente ...")
            { nomeCliente = tbBuscarCliente.Text; }
            else { nomeCliente = ""; }

            if (tbFuncionario.Text != string.Empty && tbFuncionario.Text != "Digite o nome do funcionário ...")
            { nomeFuncionario = tbFuncionario.Text; }
            else { nomeFuncionario = ""; }


            //DATA INICIO E DATA FIM VENDAS
            dataInicio = dtpDataInicial.Value;
            dataFim = dtpDataFinal.Value;

            listaCaixa = nCaixa.BuscarCaixa(Avista, CrediarioPendente, CrediarioPago, strDinheiro, strPix, strCredito, strDebito, strCheque, strParcial, dataInicio, dataFim);
        }

        //Valida data filtro
        private Boolean metodoValidaData() {

            if (dtpDataInicial.Value > dtpDataFinal.Value) {


                //Criando Caixa de dialogo
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro filtro Data",
                " Data inicial está maior que Data final!",
                Properties.Resources.DialogErro,
                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                Color.White,
                "OK", "",
                false);

                frmCaixa.ShowDialog();

                return false;

            }

            return true;
        }

        //Gráficos
        private void metodoChartAnaliseVenda() {

            chartAnaliseVenda.Series.Clear();
            chartAnaliseVenda.Titles.Clear();
            chartAnaliseVenda.Legends.Clear();
            chartAnaliseVenda.ChartAreas.Clear();



            //Título do Gráfico
            Title titulo = new Title();
            titulo.Font = new Font("Arial Narrow", 12 ,FontStyle.Bold);
            titulo.Text = "Análise de Vendas";
            chartAnaliseVenda.Titles.Add(titulo);

            //Legenda do Gráfico
            Legend legenda = new Legend();
            chartAnaliseVenda.Legends.Add(legenda);
            chartAnaliseVenda.Legends[0].Title = "Legenda";

            //Áreas
            ChartArea chart = new ChartArea();
            chart.Name = "ChartArea1";
            chartAnaliseVenda.ChartAreas.Add(chart);


            //chartAnaliseVenda.ChartAreas["ChartArea1"].AxisX.Title = "Movimentação Caixa";
            //chartAnaliseVenda.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Arial Narrow", 12, FontStyle.Bold);

            chartAnaliseVenda.ChartAreas["ChartArea1"].AxisY.Title = "Valores R$";
            chartAnaliseVenda.ChartAreas["ChartArea1"].AxisY.TitleFont  = new Font("Arial Narrow", 12 ,FontStyle.Bold);
            chartAnaliseVenda.ChartAreas["ChartArea1"].AxisY.LabelStyle.Format = "{0:C2}";


            chartAnaliseVenda.ChartAreas["ChartArea1"].AxisX.Interval = 1 ;  // a cada 1 coluna 1 label

            //Remove linhas
            chartAnaliseVenda.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chartAnaliseVenda.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;



                chartAnaliseVenda.Series.Add("Venda");
                chartAnaliseVenda.Series["Venda"].Color = System.Drawing.Color.FromArgb(51, 51, 76);

                chartAnaliseVenda.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                //chartAnaliseVenda.Series[0].LegendText = "Venda R$";
                chartAnaliseVenda.Series[0].BorderWidth = 4;
                //adiciona valores ao eixo X e eixo Y
                chartAnaliseVenda.Series[0].IsValueShownAsLabel = true;
                chartAnaliseVenda.Series[0].Points.AddXY("Venda", String.Format("{0:C2}", totalVendaCaixa));
                chartAnaliseVenda.Series[0].Points[0].AxisLabel = "Venda";
                chartAnaliseVenda.Series[0].Points[0].Color = System.Drawing.Color.FromArgb(51, 51, 76);
                chartAnaliseVenda.Series[0].Points[0].LabelFormat = "{0:C2}";


                //----------------Crediario
                chartAnaliseVenda.Series.Add("Crediario");
                chartAnaliseVenda.Series["Crediario"].Color = System.Drawing.Color.Yellow;

                chartAnaliseVenda.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                //chartAnaliseVenda.Series[1].LegendText = "Crediario R$";
                chartAnaliseVenda.Series[0].BorderWidth = 4;
                //adiciona valores ao eixo X e eixo Y
                chartAnaliseVenda.Series[0].IsValueShownAsLabel = true;
                chartAnaliseVenda.Series[0].Points.AddXY("Crediario", totalCrediario);
                chartAnaliseVenda.Series[0].Points[1].AxisLabel = "Crediario";
                chartAnaliseVenda.Series[0].Points[1].Color = System.Drawing.Color.Yellow;
                chartAnaliseVenda.Series[0].Points[1].LabelFormat = "{0:C2}";


                //-----------------Crediario Pago
                chartAnaliseVenda.Series.Add("CrediarioPago");
                chartAnaliseVenda.Series["CrediarioPago"].Color = System.Drawing.Color.MediumSeaGreen;

                chartAnaliseVenda.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                //chartAnaliseVenda.Series[2].LegendText = "Crediario Pago R$";
                chartAnaliseVenda.Series[0].BorderWidth = 4;
                //adiciona valores ao eixo X e eixo Y
                chartAnaliseVenda.Series[0].IsValueShownAsLabel = true;
                chartAnaliseVenda.Series[0].Points.AddXY("", totalCrediarioPago);
                chartAnaliseVenda.Series[0].Points[2].AxisLabel = "Crediario Pago";
                chartAnaliseVenda.Series[0].Points[2].Color = System.Drawing.Color.MediumSeaGreen;
                chartAnaliseVenda.Series[0].Points[2].LabelFormat = "{0:C2}";
        
        }

        private void metodoChartAnalisePizzaVenda()
        {
            try
            {

                chartPieAnalizeVenda.Series.Clear();
                chartPieAnalizeVenda.Titles.Clear();
                chartPieAnalizeVenda.Legends.Clear();
                chartPieAnalizeVenda.ChartAreas.Clear();



                //Título do Gráfico
                Title titulo = new Title();
                titulo.Font = new Font("Arial Narrow", 12, FontStyle.Bold);
                titulo.Text = "Análise de Vendas";
                chartPieAnalizeVenda.Titles.Add(titulo);

                //Legenda do Gráfico
                Legend legenda = new Legend();
                chartPieAnalizeVenda.Legends.Add(legenda);
                chartPieAnalizeVenda.Legends[0].Title = "Legenda";

                //Add Área
                ChartArea chart = new ChartArea();
                chart.Name = "ChartArea1";
                chartPieAnalizeVenda.ChartAreas.Add(chart);

                //Área
                chartPieAnalizeVenda.ChartAreas["ChartArea1"].AxisY.Title = "Valores R$";
                chartPieAnalizeVenda.ChartAreas["ChartArea1"].AxisY.TitleFont = new Font("Arial Narrow", 12, FontStyle.Bold);
                chartPieAnalizeVenda.ChartAreas["ChartArea1"].AxisY.LabelStyle.Format = "{0:C2}";

                if (totalVendaCaixa > 0)
                {
                    chartPieAnalizeVenda.Series.Add("Venda").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                    chartPieAnalizeVenda.Series["Venda"].Color = System.Drawing.Color.FromArgb(51, 51, 76);
                    chartPieAnalizeVenda.Series[0].Points.AddXY("Venda" + " #PERCENT", totalVendaCaixa);
                    chartPieAnalizeVenda.Series[0].Points[0].Color = System.Drawing.Color.FromArgb(51, 51, 76);
                }
                if (totalCrediario > 0)
                {

                    chartPieAnalizeVenda.Series.Add("Crediario").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                    chartPieAnalizeVenda.Series["Crediario"].Color = System.Drawing.Color.Yellow;
                    chartPieAnalizeVenda.Series[0].Points.AddXY("Crediario" + " #PERCENT", totalCrediario);
                    chartPieAnalizeVenda.Series[0].Points[0].Color = System.Drawing.Color.Yellow;
                }
                if (totalCrediarioPago > 0)
                {
                    chartPieAnalizeVenda.Series.Add("Crediario Pago").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                    chartPieAnalizeVenda.Series["Crediario Pago"].Color = System.Drawing.Color.MediumSeaGreen;
                    chartPieAnalizeVenda.Series[0].Points.AddXY("Crediario Pago" + " #PERCENT", totalCrediarioPago);
                    chartPieAnalizeVenda.Series[0].Points[0].Color = System.Drawing.Color.MediumSeaGreen;
                }
                

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void metodoChartAnaliseVendaDetalhada()
        {

            chartAnaliseVenda.Series.Clear();
            chartAnaliseVenda.Titles.Clear();
            chartAnaliseVenda.Legends.Clear();
            chartAnaliseVenda.ChartAreas.Clear();

            //Título do Gráfico
            Title titulo = new Title();
            titulo.Font = new Font("Arial Narrow", 12, FontStyle.Bold);
            titulo.Text = "Análise de Pagamentos";
            chartAnaliseVenda.Titles.Add(titulo);

            //Legenda do Gráfico
            Legend legenda = new Legend();
            chartAnaliseVenda.Legends.Add(legenda);
            chartAnaliseVenda.Legends[0].Title = "Legenda";

            //Áreas
            ChartArea chart = new ChartArea();
            chart.Name = "ChartArea1";
            chartAnaliseVenda.ChartAreas.Add(chart);

            chartAnaliseVenda.ChartAreas["ChartArea1"].AxisY.Title = "Valores R$";
            chartAnaliseVenda.ChartAreas["ChartArea1"].AxisY.TitleFont = new Font("Arial Narrow", 12, FontStyle.Bold);
            chartAnaliseVenda.ChartAreas["ChartArea1"].AxisY.LabelStyle.Format = "{0:C2}";


            chartAnaliseVenda.ChartAreas["ChartArea1"].AxisX.Interval = 1;  // a cada 1 coluna 1 label

            //Remove linhas
            chartAnaliseVenda.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chartAnaliseVenda.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

            //Método Agrupa e soma Valore por forma de pagamento
            var ListaPagamentos = listaItemCaixa.GroupBy(c => c.formaPagamento.formaPagamento)
                        .Select(gp => new
                        {
                            ID = gp.Key,
                            Recebido = gp.Sum(r => r.recebidoItem),
                            AReceber = gp.Sum(r => r.totalItem)
                        });


            //Criar cores aleatórias para o datagride
            Random random = new Random();
        
            int contador = 0;
            foreach(var item in ListaPagamentos){

                if (item.ID.ToString() == "CREDIARIO")
                {
                    int corRed = random.Next(255);
                    int corGreen = random.Next(255);
                    int corBlue = random.Next(255);

                    chartAnaliseVenda.Series.Add(item.ID.ToString());
                    chartAnaliseVenda.Series[item.ID.ToString()].Color = System.Drawing.Color.FromArgb(corRed, corGreen, corBlue);

                    chartAnaliseVenda.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    //chartAnaliseVenda.Series[0].LegendText = "Venda R$";
                    chartAnaliseVenda.Series[0].BorderWidth = 4;
                    //adiciona valores ao eixo X e eixo Y
                    chartAnaliseVenda.Series[0].IsValueShownAsLabel = true;
                    chartAnaliseVenda.Series[0].Points.AddXY(item.ID.ToString(), String.Format("{0:C2}", Convert.ToDouble(item.AReceber)));
                    chartAnaliseVenda.Series[0].Points[contador].AxisLabel = item.ID.ToString();
                    chartAnaliseVenda.Series[0].Points[contador].Color = System.Drawing.Color.FromArgb(corRed, corGreen, corBlue);
                    chartAnaliseVenda.Series[0].Points[contador].LabelFormat = "{0:C2}";
                }
                else
                {
                    int corRed = random.Next(255);
                    int corGreen = random.Next(255);
                    int corBlue = random.Next(255);

                    chartAnaliseVenda.Series.Add(item.ID.ToString());
                    chartAnaliseVenda.Series[item.ID.ToString()].Color = System.Drawing.Color.FromArgb(corRed, corGreen, corBlue);

                    chartAnaliseVenda.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    //chartAnaliseVenda.Series[0].LegendText = "Venda R$";
                    chartAnaliseVenda.Series[0].BorderWidth = 4;
                    //adiciona valores ao eixo X e eixo Y
                    chartAnaliseVenda.Series[0].IsValueShownAsLabel = true;
                    chartAnaliseVenda.Series[0].Points.AddXY(item.ID.ToString(), String.Format("{0:C2}", Convert.ToDouble(item.Recebido)));
                    chartAnaliseVenda.Series[0].Points[contador].AxisLabel = item.ID.ToString();
                    chartAnaliseVenda.Series[0].Points[contador].Color = System.Drawing.Color.FromArgb(corRed, corGreen, corBlue);
                    chartAnaliseVenda.Series[0].Points[contador].LabelFormat = "{0:C2}";
                }
                contador++;
            
            }


        }

        private void metodoCaixaConstrutor() {

            if (tgTipoCaixa.Checked == true)
            {

                lbCaixa.Text = "Caixa Detalhado";
                dgvCaixa.Rows.Clear();

                tbBuscarCliente.Enabled = true;
                tbFuncionario.Enabled = true;
                btCliente.Enabled = true;
                btFuncionario.Enabled = true;

                this.dgvCaixa.Columns["codigoItemVenda"].Visible = true;
                this.dgvCaixa.Columns["codigoProduto"].Visible = true;
                this.dgvCaixa.Columns["codigoProdutoCor"].Visible = false;
                this.dgvCaixa.Columns["descricaoProduto"].Visible = true;
                this.dgvCaixa.Columns["referenciaProduto"].Visible = true;
                this.dgvCaixa.Columns["sexoProduto"].Visible = true;
                this.dgvCaixa.Columns["corProduto"].Visible = true;
                this.dgvCaixa.Columns["generoProduto"].Visible = true;
                this.dgvCaixa.Columns["gradeProduto"].Visible = true;
                this.dgvCaixa.Columns["codigoTamanho"].Visible = true;
                this.dgvCaixa.Columns["nomeTamanho"].Visible = true;
                this.dgvCaixa.Columns["quantidadeProduto"].Visible = true;
                this.dgvCaixa.Columns["precoCustoProduto"].Visible = true;
                this.dgvCaixa.Columns["precoVendaProduto"].Visible = true;
                this.dgvCaixa.Columns["imagemProduto"].Visible = true;
                this.dgvCaixa.Columns["funcionarioVenda"].Visible = true;
                this.dgvCaixa.Columns["nomeCliente"].Visible = true;
                this.dgvCaixa.Columns["fornecedorProduto"].Visible = true;

                pbImagemProduto.Visible = true;
               // dgvCaixa.Size = new System.Drawing.Size(larguraGride, 385);
                dgvCaixa.Size = new System.Drawing.Size(this.Width - 15, 385);
                chartPieAnalizeVenda.Visible = false;
            }

            else
            {

                lbCaixa.Text = "Caixa";
                dgvCaixa.Rows.Clear();


                tbBuscarCliente.Enabled = false;
                tbFuncionario.Enabled = false;
                btCliente.Enabled = false;
                btFuncionario.Enabled = false;

                this.dgvCaixa.Columns["codigoItemVenda"].Visible = false;
                this.dgvCaixa.Columns["codigoProduto"].Visible = false;
                this.dgvCaixa.Columns["codigoProdutoCor"].Visible = false;
                this.dgvCaixa.Columns["descricaoProduto"].Visible = false;
                this.dgvCaixa.Columns["referenciaProduto"].Visible = false;
                this.dgvCaixa.Columns["sexoProduto"].Visible = false;
                this.dgvCaixa.Columns["corProduto"].Visible = false;
                this.dgvCaixa.Columns["generoProduto"].Visible = false;
                this.dgvCaixa.Columns["gradeProduto"].Visible = false;
                this.dgvCaixa.Columns["codigoTamanho"].Visible = false;
                this.dgvCaixa.Columns["nomeTamanho"].Visible = false;
                this.dgvCaixa.Columns["quantidadeProduto"].Visible = false;
                this.dgvCaixa.Columns["precoCustoProduto"].Visible = false;
                this.dgvCaixa.Columns["precoVendaProduto"].Visible = false;
                this.dgvCaixa.Columns["imagemProduto"].Visible = false;
                this.dgvCaixa.Columns["funcionarioVenda"].Visible = false;
                this.dgvCaixa.Columns["nomeCliente"].Visible = false;
                this.dgvCaixa.Columns["fornecedorProduto"].Visible = false;


                dgvCaixa.Size = new System.Drawing.Size(920, 385);
                chartPieAnalizeVenda.Visible = true;

            }
        
        }

        //-----------------------------------Formulário
        private void FrmCaixa_Load(object sender, EventArgs e)
        {
            //Largura antiga
            //larguraGride = dgvCaixa.Width;
            metodoCaixaConstrutor();
            btFiltrar.PerformClick();
            metodoCalculaTotais();

        }

        //Botões
        private void btVenda_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmVendaPendente frmVendaPendente = new FrmVendaPendente();
            frmVendaPendente.ShowDialog();
            this.Visible = true;
        }

        private void btFiltrar_Click(object sender, EventArgs e)
        {
            if (metodoValidaData() == true)
            {
                if (tgTipoCaixa.Checked == true)
                {
                    if (cbParcialDetalhada.Checked == false)
                    {
                        metodoBuscarCaixaDetalhado();
                        metodoAtualizaDataGridDetalhado();
                        metodoExibeImagemProduto();
                    }
                    else {
                        //Parcial detalhado
                        metodoBuscarCaixaDetalhado();
                        metodoAtualizaDataGridDetalhado();
                        metodoExibeImagemProduto();
                    
                    }

                }
                else {

                    metodoBuscarCaixa();
                    metodoAtualizaDataGrid();
                
                }

                metodoCalculaTotais();
                if (cbParcialDetalhada.Checked == false)
                {
                    metodoChartAnaliseVenda();
                    metodoChartAnalisePizzaVenda();
                }
                else {

                    metodoChartAnaliseVendaDetalhada();
                
                }
            }
        }

        private void btCancelaVenda_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmCancelamento frmCancelamento = new FrmCancelamento("");
            frmCancelamento.ShowDialog();
            this.Visible = true;
        }

        private void btCrediario_Click(object sender, EventArgs e)
        {
            this.Visible = false;
           // FrmCrediario frmCrediario = new FrmCrediario();
            //frmCrediario.WindowState = FormWindowState.Normal;
           // frmCrediario.ShowDialog();
            this.Visible = true;
        }

        private void btSangria_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmSangria frmSangria = new FrmSangria();
            frmSangria.ShowDialog();
            this.Visible = true;
        }

        private void btParcial_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmSelecionarParcialVenda frmParcial = new FrmSelecionarParcialVenda();
            frmParcial.ShowDialog();
            this.Visible = true;
        }

        //DataGrid
        private void dgvCaixa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            metodoExibeImagemProduto();
        }

        private void tgTipoCaixa_CheckedChanged(object sender, EventArgs e)
        {
            metodoCaixaConstrutor();
            btFiltrar.PerformClick();
        }

        //CAIXA DE TEXTO
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

        private void tbFuncionario_Enter(object sender, EventArgs e)
        {
            objItemCaixa.funcionario = new Funcionario();

            tbFuncionario.Clear();
            pbFuncionario.Image = Properties.Resources.FuncionarioRosa;
            panelFuncionario.BackColor = Color.DeepPink;
        }

        private void tbBuscarCliente_Leave(object sender, EventArgs e)
        {
            if (tbBuscarCliente.Text == "")
            {
                tbBuscarCliente.Text = "Digite o nome do cliente ...";
                pbUsuario.Image = Properties.Resources.ClienteAzul;
                panelBuscarCliente.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                tbBuscarCliente.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            }
        }

        private void tbBuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btCliente.PerformClick();
                e.Handled = true;
            }
        }

        private void tbBuscarCliente_Enter(object sender, EventArgs e)
        {
            objItemCaixa.cliente = new Cliente();

            tbBuscarCliente.Clear();
            pbUsuario.Image = Properties.Resources.ClienteRosa;
            panelBuscarCliente.BackColor = Color.DeepPink;
        }

        private void btCliente_Click(object sender, EventArgs e)
        {
            Cliente objCliente = new Cliente();
            NegCliente nCliente = new NegCliente();
            NegCrediario nCrediario = new NegCrediario();

            int n;
            bool ehUmNumero = int.TryParse(tbBuscarCliente.Text, out n);
            if (ehUmNumero == true)
            {
                objCliente = nCliente.BuscarClientePorCodigo(n);

                if (objCliente != null)
                {
                    this.tbBuscarCliente.Text = objCliente.nomeCliente;

                    if (nCrediario.BuscarCrediarioBloqueado(n) == true)
                    {
                        FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Aviso - Cliente Bloqueado",
                        "Cliente está Bloqueado!",
                        Properties.Resources.DialogErro,
                        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                        Color.White,
                        "Ok", "",
                        false);
                        frmCaixaCad.ShowDialog();
                    }
                    else if (nCrediario.BuscarCrediarioVencimento(n) == true)
                    {
                        FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Aviso - Parcelas Atrasadas",
                        "Cliente está com Parcelas Atrasadas!",
                        Properties.Resources.DialogErro,
                        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                        Color.White,
                        "Ok", "",
                        false);
                        frmCaixaCad.ShowDialog();
                    }
                    //----------Voltar o foco para funcionario
                    if (tbFuncionario.Text == "" || tbFuncionario.Text == "Digite o nome do funcionário ...")
                    {
                        tbFuncionario.Focus();
                    }
                }
                else
                    tbBuscarCliente.Clear();
            }
            else
            {
                FrmSelecionarCliente frmSelecionarCliente = new FrmSelecionarCliente(tbBuscarCliente.Text);
                DialogResult resultado = frmSelecionarCliente.ShowDialog();

                if (resultado == DialogResult.OK)
                {

                    objCliente = frmSelecionarCliente.clienteSelecionado;
                    this.tbBuscarCliente.Text = objCliente.nomeCliente;
                    //----------Voltar o foco para funcionario
                    if (tbFuncionario.Text == "" || tbFuncionario.Text == "Digite o nome do funcionário ...")
                    {
                        tbFuncionario.Focus();
                    }
                }

            }
        }

        private void btFuncionario_Click(object sender, EventArgs e)
        {
            Funcionario objFuncionario = new Funcionario();
            NegFuncionario nFuncionario = new NegFuncionario();

            int n;
            bool ehUmNumero = int.TryParse(tbFuncionario.Text, out n);
            if (ehUmNumero == true)
            {
                objFuncionario = nFuncionario.BuscarFuncionarioPorCodigo(n);
                if (objFuncionario != null)
                {
                    this.tbFuncionario.Text = objFuncionario.nomeFuncionario;
                    cbFormaPagamento.Focus();
                }
                else
                    tbFuncionario.Clear();
            }
            else
            {
                FrmSelecionarFuncionario frmSelecionarFuncionario = new FrmSelecionarFuncionario(tbFuncionario.Text);
                DialogResult resultado = frmSelecionarFuncionario.ShowDialog();

                if (resultado == DialogResult.OK)
                {

                    objFuncionario = frmSelecionarFuncionario.FuncionarioSelecionado;
                    this.tbFuncionario.Text = objFuncionario.nomeFuncionario;
                    cbFormaPagamento.Focus();
                }

            }
        }

        //FORMA DE PAGAMENTO
        private void cbFormaPagamento_DropDown(object sender, EventArgs e)
        {
            try
            {
                    ListaFormaPagamento listaPagamento = new ListaFormaPagamento();
                    NegFormaPagamento nPagamento = new NegFormaPagamento();

                    cbFormaPagamento.Items.Clear();
                    listaPagamento = nPagamento.BuscarFormaPagamentoPorNome("CRÉDITO");

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

        private void cbCredito_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCredito.Checked == true) { cbFormaPagamento.Enabled = true; } else { cbFormaPagamento.Enabled = false; cbFormaPagamento.Items.Clear(); }
        }

        private void FrmCaixa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F5) == true)
            {
                btFiltrar.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F10) == true)
            {
                btVenda.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F2) == true)
            {
                btCancelaVenda.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F12) == true)
            {
                btCrediario.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F4) == true)
            {
                btCrediario.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F6) == true)
            {
                btSangria.PerformClick();
            }
        }


    }
}
