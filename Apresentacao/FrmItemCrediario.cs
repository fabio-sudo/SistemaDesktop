using Apresentacao.Formulas;
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
    public partial class FrmItemCrediario : Form
    {
        ItemCrediario objItem = new ItemCrediario();
        ItemCrediario itemSelecionado = new ItemCrediario();
        ItemCrediarioLista itemLista = new ItemCrediarioLista();
        ItemCrediarioLista listaItemCrediarioCad = new ItemCrediarioLista();
        ItemCrediario itemParcialSelecionado = new ItemCrediario();//Para selecionar o item da parcial
        NegItemCrediario nItem = new NegItemCrediario();


        Crediario objCrediario = new Crediario();
        NegCrediario nCrediario = new NegCrediario();

        //Parcial
        ItemCrediarioParcialLista ListaParcial = new ItemCrediarioParcialLista();

        //--------------Forma Pagamento
        FormaPagamento objFormaPagamento = new FormaPagamento();
        ListaFormaPagamento listaFormaPagamento = new ListaFormaPagamento();
        NegFormaPagamento nFormaPagamento = new NegFormaPagamento();
        //--------Variaveis
        int codigoItemSelecionado = 0;
        Boolean clkSelecao = false;
        String LocalSolution;
        Metodos metodos = new Metodos();
        //--------Validações
        Boolean cadParcialValida = false;
        Boolean cadItemCrediarioValida = false;
        //--------------Valores

        int quantidadeTotal = 0;
        double valorBrutoCrediario = 0;
        double valorAReceber = 0;
        double valorJuros = 0;
        double valorDesconto = 0;
        double Porcentagemdesconto = 0;

        public FrmItemCrediario(Crediario crediario)
        {
            InitializeComponent();

            objCrediario = crediario;
        }

        //-------------Metodos
        private void AtualizarDataGrid()
        {
            try
            {
                this.dgvItemCrediario.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

                if (this.itemLista.Count > 0)
                {
                    this.dgvItemCrediario.Rows.Add(this.itemLista.Count);
                }
                else
                {
                    return;
                }

                int indice = 0;
                foreach (ItemCrediario item in this.itemLista)
                {
                    this.dgvItemCrediario[1, indice].Value = item.Venda.codigoVenda;
                    this.dgvItemCrediario[2, indice].Value = item.codigoItemCrediario;
                    this.dgvItemCrediario[3, indice].Value = item.ProdutoCor.codigoProdutoCor;
                    this.dgvItemCrediario[4, indice].Value = item.ProdutoCor.Produto.codigoProduto;
                    this.dgvItemCrediario[5, indice].Value = item.ProdutoCor.Produto.descricaoProduto;
                    this.dgvItemCrediario[6, indice].Value = item.ProdutoCor.Produto.referenciaProduto;
                    this.dgvItemCrediario[7, indice].Value = item.ProdutoCor.Produto.sexoProduto;
                    this.dgvItemCrediario[8, indice].Value = item.ProdutoCor.Cor.nomeCor;
                    this.dgvItemCrediario[9, indice].Value = item.ProdutoCor.Produto.Genero.nomeGenero;
                    this.dgvItemCrediario[10, indice].Value = item.Tamanho.codigoTamanho;
                    this.dgvItemCrediario[11, indice].Value = item.Tamanho.nometamanho;
                    this.dgvItemCrediario[12, indice].Value = item.quantidadeItemCrediario;
                    this.dgvItemCrediario[13, indice].Value = item.valorItemCrediario;
                    this.dgvItemCrediario[14, indice].Value = item.valorItemCrediario * item.quantidadeItemCrediario;//Total 
                    this.dgvItemCrediario[15, indice].Value = item.parcialItemCrediario;
                    this.dgvItemCrediario[16, indice].Value = item.codigoBarrasItem;
                    this.dgvItemCrediario[17, indice].Value = item.ProdutoCor.ImagemProduto;
                    this.dgvItemCrediario[18, indice].Value = item.dataItemCrediario;
                    this.dgvItemCrediario[19, indice].Value = item.dataVencimentoItemCrediario;

                    //DataInicialCompra -- Passar da DataVencimento -> Começar a calcular o atraso
                    TimeSpan span = item.dataVencimentoItemCrediario.Subtract(item.dataItemCrediario);
                    if (span.Days < 0)
                    {
                        dgvItemCrediario.Rows[indice].ErrorText = "Parcela com Atraso: " + span.Days.ToString() + " dias";
                    }

                    indice++;
                }

                dgvItemCrediario.Update();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void metodoIniciaFormulario() {

            //Preenche Camopos
            tbCodigo.Text = objCrediario.codigoCrediario.ToString();
            tbNome.Text = objCrediario.Cliente.nomeCliente;
            tbSobrenome.Text = objCrediario.Cliente.sobrenomeCliente;
            mtbCpf.Text = objCrediario.Cliente.cpfCliente;
            mtbCelular.Text = objCrediario.Cliente.celularCliente;

            //-----Total da Conta do Cliente
            lbCrediarioBruto.Text = String.Format("{0:C2}", objCrediario.contaCrediario);

            //-----Preencher o Gride com os dados do ItemCrediaro
            metodoBuscaItemCrediario(objCrediario);
            metodoExibeImagemProduto();
        
        }

        private void metodoBuscaItemCrediario(Crediario crediario)
        {
            itemLista = nItem.BuscarItemCrediarioPorCrediario(crediario.codigoCrediario);
            AtualizarDataGrid();
        }

        private void metodoExibeImagemProduto()
        {
            if (dgvItemCrediario.Rows.Count > 0)
            {
                //Buscal Local que a Solution Está sendo Executada no Computador
                LocalSolution = Environment.CurrentDirectory;
                // This will get the current PROJECT directory
                LocalSolution = Directory.GetParent(LocalSolution).Parent.Parent.FullName;

                String imgProduto = (dgvItemCrediario.CurrentRow.Cells[17].Value).ToString();
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

        private void metodoCalculaTotais()
        {
            try
            {
                valorBrutoCrediario = 0;
                quantidadeTotal = 0;
                valorAReceber = 0;
                valorJuros = 0;
                valorDesconto = 0;
                Porcentagemdesconto = 0;

                if (dgvItemCrediario.RowCount > 0)
                {

                    //faz a soma dos totais dos valores do gride
                    foreach (DataGridViewRow col in dgvItemCrediario.Rows)
                    {
                        quantidadeTotal = quantidadeTotal + Convert.ToInt32(col.Cells[12].Value);
                        valorBrutoCrediario = valorBrutoCrediario + Convert.ToDouble(col.Cells[15].Value);

                        if ((bool)col.Cells[0].FormattedValue == true)
                        {

                            valorAReceber = valorAReceber + Convert.ToDouble(col.Cells[15].Value);
                        }
                    }
                }

                lbCrediarioBruto.Text = "+ " + String.Format("{0:C2}", valorBrutoCrediario);
                lbValorTotalCrediario.Text = "+ " + String.Format("{0:C2}", valorAReceber);

                //-------Juros Cartão
                if (cbFormaPagamento.Text != "" && cbJuros.Checked == true)
                {
                    valorJuros = Convert.ToDouble(lbTaxaJuros.Text) / 100;
                    valorJuros = valorAReceber * valorJuros;
                    lbTaxa.Text = "- " + String.Format("{0:C2}", valorJuros);
                    lbJurosCrediario.Text = "%" + String.Format("{0:C2}", valorJuros);
                }

                //-------Desconto
                Porcentagemdesconto = (Convert.ToDouble(nudDesconto.Value) / 100);
                valorDesconto = Porcentagemdesconto * valorAReceber;
                lbDesconto.Text = "- " + String.Format("{0:C2}", valorDesconto);
                lbDescontoCrediario.Text = " - " + String.Format("{0:C2}", valorDesconto);

                //-------A Receber
                if (cbFormaPagamento.Text != "" && cbJuros.Checked == false)
                {
                    valorAReceber = valorAReceber - valorDesconto;
                }
                else
                {
                    valorAReceber = valorAReceber + valorJuros - valorDesconto;
                }

                lbDinheiro.Text = "+ " + String.Format("{0:C2}", valorAReceber);
                lbCrediarioLiquido.Text = "+ " + String.Format("{0:C2}", valorAReceber);
                
                //------Troco
                metodoCalculaTroco();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void metodoCalculaTroco()
        {
            try
            {
                double valorTroco = 0;
                //------Troco
                valorTroco = Convert.ToDouble(tbValorPago.Text) - valorAReceber;
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

        //Métodos para adicionar Valores do Gride na Lista
        public void metodoAddItemLista()
        {
            try
            {
                if (dgvItemCrediario.RowCount > 0)
                {
                    //Percorre o gride para adicionar itens
                    listaItemCrediarioCad = new ItemCrediarioLista();
                    //Lista de Parciais
                    ListaParcial = new ItemCrediarioParcialLista();

                    foreach (DataGridViewRow row in dgvItemCrediario.Rows)
                    {
                        //Só adiciona os itens marcados no caso seleciondados
                        if ((bool)row.Cells[0].FormattedValue == true)
                        {
                            ItemCrediario itemCrediario = new ItemCrediario();
                            itemCrediario.Venda = new Venda();
                            itemCrediario.Crediario = new Crediario();
                            itemCrediario.ProdutoCor = new ProdutoCor();
                            itemCrediario.Tamanho = new Tamanho();

                            //Chaves FK e UK
                            itemCrediario.codigoItemCrediario = Convert.ToInt32(row.Cells[2].Value);
                            itemCrediario.ProdutoCor.codigoProdutoCor = Convert.ToInt32(row.Cells[3].Value);
                            itemCrediario.Venda.codigoVenda = Convert.ToInt32(row.Cells[1].Value);
                            itemCrediario.Crediario = objCrediario;
                            itemCrediario.Tamanho.codigoTamanho = Convert.ToInt32(row.Cells[10].Value);
                            itemCrediario.formaPagamento = objFormaPagamento;
                            //Valores
                            itemCrediario.quantidadeItemCrediario = Convert.ToInt32(row.Cells[12].Value);
                            itemCrediario.valorItemCrediario = Convert.ToDouble(row.Cells[13].Value);
                            itemCrediario.parcialItemCrediario = Convert.ToDouble(row.Cells[15].Value);
                            //Encargos Juros e Desconto Total * Porcentagem
                            itemCrediario.jurosItemCrediario = Math.Round((itemCrediario.parcialItemCrediario) * (objFormaPagamento.taxaFormaPagamento / 100), 4);
                            itemCrediario.descontoItemCrediario = Math.Round((itemCrediario.parcialItemCrediario) * (Porcentagemdesconto), 4);
                            itemCrediario.dataItemCrediario = Convert.ToDateTime(row.Cells[18].Value);

                            if (cbJuros.Checked == true)
                            {
                                //----------Parcial do ItemCrediarioPago é valor recebido + Acréscimo dos Juros - Desconto
                                itemCrediario.Venda.jurosVenda = itemCrediario.jurosItemCrediario;
                                itemCrediario.Venda.descontoVenda = itemCrediario.descontoItemCrediario;
                                itemCrediario.parcialItemCrediario = (itemCrediario.parcialItemCrediario + itemCrediario.jurosItemCrediario) - (itemCrediario.descontoItemCrediario);
                            }
                            else
                            {
                                //----------Parcial do ItemCrediarioPago é valor recebido - o Desconto
                                itemCrediario.Venda.jurosVenda = itemCrediario.jurosItemCrediario * -1;
                                itemCrediario.Venda.descontoVenda = itemCrediario.descontoItemCrediario;
                                itemCrediario.parcialItemCrediario = (itemCrediario.parcialItemCrediario - itemCrediario.jurosItemCrediario) - (itemCrediario.descontoItemCrediario);
                                itemCrediario.jurosItemCrediario = itemCrediario.jurosItemCrediario * -1;//Juros é cadastrado como negativo
                            }

                            //Se tiver Parcial
                            if (Convert.ToDouble(row.Cells[15].Value) != Convert.ToDouble(row.Cells[14].Value))
                            {
                                ItemCrediarioParcial itemParcial = new ItemCrediarioParcial();

                                //Carregando Item
                                itemParcial.FormaPagamento = objFormaPagamento;
                                itemParcial.ItemCrediario = itemCrediario;
                                itemParcial.Cliente = objCrediario.Cliente;
                                itemParcial.ProdutoCor = itemCrediario.ProdutoCor;
                                itemParcial.Tamanho = itemCrediario.Tamanho;

                                //Valores
                                itemParcial.descontoParcial = Math.Round(itemCrediario.descontoItemCrediario, 2);
                                itemParcial.jurosParcial = Math.Round(itemCrediario.jurosItemCrediario, 2);
                                itemParcial.valorParcialBruto = Math.Round(itemCrediario.parcialItemCrediario, 2);//Valor Realmente Recebido Com juros desconto SIM/NAO
                                itemParcial.valorPagoParcial = Convert.ToDouble(row.Cells[15].Value);//Valor da Parcial                               

                                if (cbJuros.Checked == true)
                                {
                                    //----------Juros e Desconto ADD na Venda
                                    itemParcial.ItemCrediario.Venda.jurosVenda = itemCrediario.jurosItemCrediario;
                                    itemParcial.ItemCrediario.Venda.descontoVenda = itemCrediario.descontoItemCrediario;
                                }
                                else
                                {
                                    //----------Juros e Desconto ADD na Venda
                                    itemParcial.ItemCrediario.Venda.jurosVenda = itemCrediario.jurosItemCrediario;
                                    itemParcial.ItemCrediario.Venda.descontoVenda = itemCrediario.descontoItemCrediario;
                            }

                                ListaParcial.Add(itemParcial);
                            }
                            //Se não tiver Parcial For item crediario Pago
                            else
                            {

                                listaItemCrediarioCad.Add(itemCrediario);
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

        public void metodoAddItemListaCancelamento(ItemCrediarioParcialLista listaItemCancelar)
        {
            try
            {
                foreach (ItemCrediarioParcial itemCancelar in listaItemCancelar)
                    {
                        listaItemCrediarioCad.Add(itemCancelar.ItemCrediario);

                     }
                 }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void metodoAddItemListaVencimento(DateTime dataVencimento)
        {
            try
            {
                if (dgvItemCrediario.RowCount > 0)
                {
                    //Percorre o gride para adicionar itens
                    listaItemCrediarioCad = new ItemCrediarioLista();

                    foreach (DataGridViewRow row in dgvItemCrediario.Rows)
                    {
                        if ((bool)row.Cells[0].FormattedValue == true)
                        {
                            ItemCrediario itemCrediario = new ItemCrediario();
                            itemCrediario.Venda = new Venda();
                            itemCrediario.Crediario = new Crediario();
                            itemCrediario.ProdutoCor = new ProdutoCor();
                            itemCrediario.Tamanho = new Tamanho();

                            //Chaves FK e UK
                            itemCrediario.codigoItemCrediario = Convert.ToInt32(row.Cells[2].Value);
                            itemCrediario.ProdutoCor.codigoProdutoCor = Convert.ToInt32(row.Cells[4].Value);
                            itemCrediario.Venda.codigoVenda = Convert.ToInt32(row.Cells[1].Value);
                            itemCrediario.Crediario = objCrediario;
                            itemCrediario.Tamanho.codigoTamanho = Convert.ToInt32(row.Cells[10].Value);
                            //Valores
                            itemCrediario.quantidadeItemCrediario = Convert.ToInt32(row.Cells[12].Value);
                            itemCrediario.valorItemCrediario = Convert.ToDouble(row.Cells[13].Value);
                            itemCrediario.parcialItemCrediario = Convert.ToDouble(row.Cells[15].Value);
                            //Encargos Juros e Desconto Total * Porcentagem
                            itemCrediario.jurosItemCrediario = Math.Round((itemCrediario.parcialItemCrediario) * (objFormaPagamento.taxaFormaPagamento / 100), 4);
                            itemCrediario.descontoItemCrediario = Math.Round((itemCrediario.parcialItemCrediario) * (Porcentagemdesconto), 4);


                            if (cbJuros.Checked == true)
                            {
                                //----------Parcial do ItemCrediarioPago é valor recebido + Acréscimo dos Juros - Desconto
                                itemCrediario.parcialItemCrediario = (itemCrediario.parcialItemCrediario + itemCrediario.jurosItemCrediario) - (itemCrediario.descontoItemCrediario);
                            }
                            else
                            {
                                //----------Parcial do ItemCrediarioPago é valor recebido - o Desconto
                                itemCrediario.parcialItemCrediario = (itemCrediario.parcialItemCrediario) - (itemCrediario.descontoItemCrediario);
                            }

                            itemCrediario.dataVencimentoItemCrediario = dataVencimento;

                            listaItemCrediarioCad.Add(itemCrediario);
                        }
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private Boolean metodoValidaFormaPagamento()
        {
           if (cbFormaPagamento.SelectedItem == null)
            {
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro Forma Pagamento",
                "Informe a Forma de Pagamento para realizar o Recebimento",
                Properties.Resources.FormaPagamentoIcone,
                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                Color.White,
                "Ok", "",
                false);
                frmCaixa.ShowDialog();

                return false;
            }
            else
            {
                return true;
            }
        }

        private Boolean metodoValidaSelecao() {
           
            Boolean validaSelecao = false;

            if (dgvItemCrediario.RowCount > 0)
            {
                //percorre todas as linhas do gride
                foreach (DataGridViewRow check in dgvItemCrediario.Rows)
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


        //---------------------------------------Métodos para cancelamento da Sangria
        #region Cancelamento Sangria

        //Verifica se há a necessidade de cancelamento ou atualização da sangria
        private Boolean metodoValidaCancelamentoSangria()
        {
            try
            {
                Sangria sangria = new Sangria();
                NegSangria nSangria = new NegSangria();
                ItemCrediarioParcialLista listaParcialValida = new ItemCrediarioParcialLista();

                if (ListaParcial.Count > 0)
                {
                    //Busca Parciais referente ao item para verificar se há a necessidade de realizar o cancelamento das mesmas
                    foreach (ItemCrediarioParcial item in ListaParcial)
                    {

                        listaParcialValida.AddRange(nItem.BuscarItemCrediarioParcialPorItemCrediario(item.ItemCrediario.codigoItemCrediario));
                    }

                    //Verifica se há parciais vinculadas com sangria
                    foreach (ItemCrediarioParcial item in listaParcialValida)
                    {
                        if (nSangria.BuscarCancelamentoSangriaPorData(item.dataParcial) == true)
                        {
                            //Erro ao Cancelar Parcial
                            FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Cancelamento Parciais do item",
                            "Realize o cancelamento das parciais!",
                            Properties.Resources.DialogQuestion,
                            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                            Color.White,
                            "Ok", "",
                            false);

                            frmCaixaCad.ShowDialog();
                            //Chama Formulario de cancelamento da Parcial enviando lista dos itens
                            DialogResult resultadoParcial;
                            FrmSelecionarParcialCrediario FrmParcialCrediario = new FrmSelecionarParcialCrediario(null, ListaParcial);
                            resultadoParcial = FrmParcialCrediario.ShowDialog();
                            if (resultadoParcial == DialogResult.Yes)
                            {
                                //Carrega os dados do crediario
                                return true;
                            }
                            else
                            {
                                //Erro ao Cancelar Parcial
                                FrmCaixaDialogo frmCaixaerro = new FrmCaixaDialogo("Erro ao Cancelar Parcial",
                                "Não foi possível cancelar as Parciais!",
                                Properties.Resources.DialogErro,
                                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                Color.White,
                                "Ok", "",
                                false);
                                frmCaixaerro.ShowDialog();

                                return false;
                            }

                        }
                    }
                }
                 return true; 

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return false; }
        }

        //Busca Valores dos Caixas referente as datas dos itens que serão cancelados
        private CaixaLista metodoBuscaCaixaCancelamento(ItemCrediarioLista lista)
        {
            NegCaixa nCaixa = new NegCaixa();
            CaixaLista caixaLista = new CaixaLista();
            int contador = 0;
            foreach (ItemCrediario item in lista)
            {
                if (caixaLista.Count == 0)
                {

                    caixaLista = nCaixa.BuscarCaixaValores(item.dataItemCrediario);
                }
                else if (item.dataItemCrediario != caixaLista[contador].dataCaixa)
                {
                    //Toda vez que a data for diferente busca os itens do caixa 
                    //E os adiciona na lista antiga
                    CaixaLista caixaListaNova = new CaixaLista();
                    caixaListaNova = nCaixa.BuscarCaixaValores(item.dataItemCrediario);
                    foreach (Caixa caixaAdd in caixaListaNova)
                    {

                        caixaLista.Add(caixaAdd);

                    }

                }

            }

            return caixaLista;
        }

        //Buscar valores da Sangria referente ao cancelamento
        private SangriaLista metodoBuscaSangriaCancelamento(ItemCrediarioLista lista)
        {

            SangriaLista sangriaLista = new SangriaLista();
            NegSangria nSangria = new NegSangria();
            int contador = 0;
            foreach (ItemCrediario item in lista)
            {
                if (sangriaLista.Count == 0)
                {

                    sangriaLista = nSangria.BuscarSangriaParaCancelamento(item.dataItemCrediario);
                }
                else if (item.dataItemCrediario != sangriaLista[contador].dataSangria)
                {
                    //Toda vez que a data for diferente busca os itens do caixa 
                    //E os adiciona na lista antiga
                    SangriaLista sangriaListaNova = new SangriaLista();
                    sangriaListaNova = nSangria.BuscarSangriaParaCancelamento(item.dataItemCrediario);
                    foreach (Sangria sangriaAdd in sangriaListaNova)
                    {

                        sangriaLista.Add(sangriaAdd);

                    }

                }

            }

            return sangriaLista;

        }

        #endregion

        //-------------------Formulário
        private void FrmItemCrediario_Load(object sender, EventArgs e)
        {
            metodoIniciaFormulario();
            if (objCrediario.estatusCrediario == "BLOQUEADO")
            {

                pbOk.Visible = true;
                pbOk.Image = Properties.Resources.DialogErro;
                tgBloqueio.Checked = true;
                lbEstatus.Text = "BLOQUEADO";

            }
            else {


                pbOk.Visible = true;
                pbOk.Image = Properties.Resources.DialogOK;
                tgBloqueio.Checked = false;
                lbEstatus.Text = "ATIVO";
            
            }

        }

        private void dgvItemCrediario_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvItemCrediario.Columns[e.ColumnIndex].Name == "marcarItem")
            {

                if (clkSelecao == false)
                {
                    clkSelecao = true;
                    foreach (DataGridViewRow dtr in dgvItemCrediario.Rows)
                    {
                        ((DataGridViewCheckBoxCell)dtr.Cells[0]).Value = true;
                    }
                }
                else
                {
                    clkSelecao = false;
                    foreach (DataGridViewRow dtr in dgvItemCrediario.Rows)
                    {
                        ((DataGridViewCheckBoxCell)dtr.Cells[0]).Value = false;
                    }

                }

                btReceber.Focus();
            }
        }

        private void dgvItemCrediario_DoubleClick(object sender, EventArgs e)
        {
            btSelecionarParcial.PerformClick();
        }

        private void dgvItemCrediario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            metodoExibeImagemProduto();
        }

        private void dgvItemCrediario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvItemCrediario.Columns[e.ColumnIndex].Name == "marcarItem")
                {
                    dgvItemCrediario.EndEdit();
                    //percorre todas as linhas do gride
                    foreach (DataGridViewRow check in dgvItemCrediario.Rows)
                    {
                        //pega valores cheked no gride
                        if ((bool)check.Cells[0].FormattedValue)
                        {
                            metodoCalculaTotais();
                        }
                        else {

                            metodoCalculaTotais();
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

        private void FrmItemCrediario_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        //-------------------Combobox
        private void cbFormaPagamento_SelectedValueChanged(object sender, EventArgs e)
        {
            //-----------Sempre que clicar sera uma nova forma de pagamento escolhida
            objFormaPagamento = new FormaPagamento();

            if (listaFormaPagamento.Count > 0)
            {
                //Forma de Pagamento Selecionada na lista Referencia o objeto para uso na venda
                objFormaPagamento = listaFormaPagamento[cbFormaPagamento.SelectedIndex];
                //Exibe forma de pagamento selecionada
                lbTaxaJuros.Text = listaFormaPagamento[cbFormaPagamento.SelectedIndex].taxaFormaPagamento.ToString("F");
            }

            metodoCalculaTotais();
        }

        private void cbFormaPagamento_DropDown(object sender, EventArgs e)
        {
            try
            {

                cbFormaPagamento.Items.Clear();
                this.listaFormaPagamento = nFormaPagamento.BuscarFormaPagamentoCombobox();

                foreach (FormaPagamento pag in this.listaFormaPagamento)
                {
                    if (pag.formaPagamento != "CREDIARIO" && pag.formaPagamento != "PARCIAL")
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
                    if (cbFormaPagamento.Text == "")
                    {
                        lbTaxaJuros.Text = "0,00";
                        lbTaxa.Text = "R$ 0,00";
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void cbJuros_CheckedChanged(object sender, EventArgs e)
        {
            if (cbJuros.Checked == false)
            {
                pbFormaPagamento.Image = Properties.Resources.TaxaRosa;
                metodoCalculaTotais();
            }
            if (cbJuros.Checked == true)
            {
                pbFormaPagamento.Image = Properties.Resources.TaxaIAzul;

                if (cbFormaPagamento.Text != "")
                {
                    lbTaxaJuros.Text = listaFormaPagamento[cbFormaPagamento.SelectedIndex].taxaFormaPagamento.ToString("F");
                }
                metodoCalculaTotais();
            }
        }

        //-------------------Botões
        private void btParcial_Click(object sender, EventArgs e)
        {
            try
            {
                //Valida itens selecionados
                if (metodoValidaSelecao() == true)
                {
                    DialogResult resposta;
                    //Criando Caixa de dialogo
                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Parcial Crediario",
                    " Deseja realmente realizar a Parcial do Item?",
                    Properties.Resources.DialogParcial,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Confirmar", "Cancelar",
                    false);

                    //Verifica se o usuário realmente quer alterar os dados do cliente.
                    resposta = frmCaixa.ShowDialog();
                    if (resposta == DialogResult.Yes)
                    {
                        //Busca primeiro item que foi Seleciondao no DataGrid
                        foreach (DataGridViewRow check in dgvItemCrediario.Rows)
                        {
                            //pega valores cheked no gride
                            if ((bool)check.Cells[0].FormattedValue == true)
                            {
                                //Código item Entrada 
                                codigoItemSelecionado = int.Parse(check.Cells[2].Value.ToString());
                                break;
                            }
                        }
                        //Busca item selecionado na Lista de Items
                        foreach (ItemCrediario itemCred in itemLista)
                        {
                            if (itemCred.codigoItemCrediario == codigoItemSelecionado)
                            {
                                itemSelecionado = itemCred;
                                break;
                            }
                        }

                        //---------Chama Formulário Parcial
                        itemSelecionado.Crediario = objCrediario;

                        FrmParcialCrediario frmParcial = new FrmParcialCrediario(itemSelecionado);
                        DialogResult respostaParcial;
                        respostaParcial = frmParcial.ShowDialog();

                        if (resposta == DialogResult.Yes)
                        {
                            //atualizar o gride quando o formulario voltar ao foco
                            metodoIniciaFormulario();
                            metodoCalculaTotais();
                        }

                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btDesconto_Click(object sender, EventArgs e)
        {
            metodoCalculaTotais();
        }

        private void pbCalculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\system32\\calc.exe");
        }

        private void pbFormaPagamento_Click(object sender, EventArgs e)
        {
            FrmSelecionarFormaPagamento frmSelecionarPagamento = new FrmSelecionarFormaPagamento("");
            frmSelecionarPagamento.ShowDialog();
        }

        private void btReceber_Click(object sender, EventArgs e)
        {
            try
            {
                //Inicializa Variaveis
                cadParcialValida = false;
                cadItemCrediarioValida = false;

                  //Valida a forma de pagamento------------------------------------------------------------------------------------------------
                    #region Confirmações
                if (metodoValidaFormaPagamento() == true)
                {
                    //Valida itens selecionados
                    if (metodoValidaSelecao() == true)
                    {
                         DialogResult resposta;
                            //Criando Caixa de dialogo
                            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Recebimento Crediario",
                            " Deseja realmente realizar o Recebimento ?",
                            Properties.Resources.DialogVenda,
                            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                            Color.White,
                            "Confirmar", "Cancelar",
                            false);

                       //Verifica se o usuário realmente quer realizar recebimento
                       resposta = frmCaixa.ShowDialog();
                      if (resposta == DialogResult.Yes)
                       {
                        //Cria nova lista para receber itens do DataGride Item
                        listaItemCrediarioCad = new ItemCrediarioLista();
                        //Cria nova lista para receber itens do DataGride Parciais
                        ListaParcial = new ItemCrediarioParcialLista();
                        //Adiciona itens a Lista do Crediario
                        metodoAddItemLista();
                #endregion
                  //---------------------------------------Parcial Items Confirmação de recebimento Parcial
                    #region Realiza Cadastro de Parcial
                        if (ListaParcial.Count > 0)
                        {
                            DialogResult respostaParcial;
                            //Criando Caixa de dialogo
                            FrmCaixaDialogo frmCaixaDialogo = new FrmCaixaDialogo("Recebimento Parciais",
                            " Deseja realmente realizar o Recebimento das Parciais ?",
                            Properties.Resources.DialogParcial,
                            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                            Color.White,
                            "Confirmar", "Cancelar",
                            false);

                            //Verifica se o usuário realmente quer alterar os dados do cliente.
                            respostaParcial = frmCaixaDialogo.ShowDialog();
                            if (respostaParcial == DialogResult.Yes)
                            {
                                if (nItem.CadastrarItemCrediarioParcialLista(ListaParcial) == false)
                                {
                                    //Se não for possivel realizar o cadastro
                                    frmCaixa = new FrmCaixaDialogo("Erro Parcial",
                                    "Erro ao Criar Item Crediario Parcial!",
                                     Properties.Resources.DialogErro,
                                     System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                     Color.White,
                                     "Ok", "",
                                     false);
                                    frmCaixa.ShowDialog();
                                }
                                else{cadParcialValida = true;}  //Cadastro da Parcial realizado com sucesso                                
                                }
                        }//************************Parcial END
                        #endregion

                  //-------------------------------------Lista de Items Crediario Pago Confirmação de recebimento de Item Crediario Pago
                    #region Crediario Pago
                        if (listaItemCrediarioCad.Count > 0)
                        {
                           //------------------Cadastra Item Crediario Pago
                            if (nItem.CadastrarItemCrediarioPagoLista(listaItemCrediarioCad) == true)
                            {
                                //---------------Exclui os itens Crediarios cadastrados na nova tabel ItemCrediarioPago
                                if (nItem.ExcluirItemCrediario(listaItemCrediarioCad) == false)
                                {
                                    //---------Erro ao Excluir ItensPendentes
                                    //Se não for possivel realizar o cadastro
                                    frmCaixa = new FrmCaixaDialogo("Erro Exclusão",
                                    "Erro ao Excluir Item Crediario Pendente!",
                                     Properties.Resources.DialogErro,
                                     System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                     Color.White,
                                     "Ok", "",
                                     false);
                                    frmCaixa.ShowDialog();
                                }
                                else { cadItemCrediarioValida = true; } //ItemCrediarioRealizado com sucesso                        
                            }
                            else {
                                //Se não for possivel realizar o cadastro
                                frmCaixa = new FrmCaixaDialogo("Erro Cadastrar",
                                "Erro ao Cadastrar Crediario Pago!",
                                 Properties.Resources.DialogErro,
                                 System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                 Color.White,
                                 "Ok", "",
                                 false);
                                frmCaixa.ShowDialog();                     
                           }
                        }//**********************************CrediarioPago End
                        #endregion

                       }//-------------Valida Itens Foram Selecionados
                    }//---------------Valida se usuário quer realmente realizar recebimento
                    //-----------------------------------Verifica se os Itens ForamSelecionados
                    #region Seleciona Todos os Itens
                    else
                    {
                        DialogResult resposta;
                        //Criando Caixa de dialogo
                        FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Seleção - Pagamento",
                        "Deseja selecionar todos os itens do Crediario? \r\n",
                        Properties.Resources.DialogVenda,
                        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                        Color.White,
                        "Sim", "Não",
                        false);

                        //Se usuário desejar realizar exclusão da entrada de estoque
                        resposta = frmCaixa.ShowDialog();
                        if (resposta == DialogResult.Yes)
                        {
                            //-----Marca todos os itens
                            foreach (DataGridViewRow dtr in dgvItemCrediario.Rows)
                            {
                                ((DataGridViewCheckBoxCell)dtr.Cells[0]).Value = true;
                            }
                            metodoCalculaTotais();
                        }
                    }//Marcação dos Itens
                   
                    if(cadItemCrediarioValida == true || cadParcialValida == true){
                     DialogResult resposta;
                     //Criando Caixa de dialogo
                     FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Lançamento Realizado!",
                    "Crediario recebido com sucesso !\r\n" +
                    "Deseja Realizar Impressão do Comprovante?",
                     Properties.Resources.DialogOK,
                     System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                     Color.White,
                     "Sim", "Não",
                     false);
                    resposta = frmCaixa.ShowDialog();
                    #endregion

                    //----------------------------------ImprimiComprovanteVenda
                    #region Imprimi comprovante

                    if (resposta == DialogResult.Yes)
                    {
                        //Retornando que exclusão foi realizada com sucesso
                        //ListaParcial.Count > 0 > Adicionar Parciais caso forem Pagas
                        metodoIniciaFormulario();//Imprimir Parciais Pagas e Item Crediario Pago
                        metodoCalculaTotais();
                        //this.DialogResult = DialogResult.Yes;
                        //ImprimiComprovante() -> Adicionar Parciais caso forem Pagas
                        //metodoLimpaCampos()
                    }                  
                  }
                }//Valida  a Forma de Pagamento                
            }//Captura de Exceção
                    #endregion

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

        private void tgBloqueio_Click(object sender, EventArgs e)
        {
            if (tgBloqueio.Checked == true)
            {
                DialogResult resposta;
                //Criando Caixa de dialogo
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Bloquear Cliente",
                " Deseja realmente Bloquear o Cliente?\r\n " +
                " " + objCrediario.codigoCrediario +
                " " + objCrediario.Cliente.nomeCliente +
                " " + objCrediario.Cliente.sobrenomeCliente,
                Properties.Resources.DialogErro,
                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                Color.White,
                "Confirmar", "Cancelar",
                 false);

                //Verifica se o usuário realmente quer alterar os dados do cliente.
                resposta = frmCaixa.ShowDialog();
                if (resposta == DialogResult.Yes)
                {
                    if (nCrediario.BloqueioCrediario(objCrediario.codigoCrediario, "BLOQUEADO") == true)
                    {
                        pbOk.Visible = true;
                        pbOk.Image = Properties.Resources.DialogErro;
                        lbEstatus.Text = "BLOQUEADO";
                    }
                    else
                    {
                        MessageBox.Show("Erro ao Bloquear Cliente!",
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else { tgBloqueio.Checked = false; }

            }
            else
            {
                DialogResult resposta;
                //Criando Caixa de dialogo
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Desbloquear Cliente",
                " Deseja realmente Desbloquear o Cliente?\r\n " +
                " " + objCrediario.codigoCrediario +
                " " + objCrediario.Cliente.nomeCliente +
                " " + objCrediario.Cliente.sobrenomeCliente,
                Properties.Resources.DialogOK,
                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                Color.White,
                "Confirmar", "Cancelar",
                false);

                //Verifica se o usuário realmente quer alterar os dados do cliente.
                resposta = frmCaixa.ShowDialog();
                if (resposta == DialogResult.Yes)
                {
                    if (nCrediario.BloqueioCrediario(objCrediario.codigoCrediario, "ATIVO") == true)
                    {
                        pbOk.Visible = true;
                        pbOk.Image = Properties.Resources.DialogOK;
                        lbEstatus.Text = "ATIVO";
                    }
                    else
                    {
                        MessageBox.Show("Erro ao Bloquear Cliente!",
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else { tgBloqueio.Checked = true; }

            }
        }

        private void btAlterarVencimento_Click(object sender, EventArgs e)
        {
            if (metodoValidaSelecao() == true)
            {
                DialogResult resposta;
                //Criando Caixa de dialogo
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Vencimento - Alterar",
                "Deseja realmente alterar o Vencimento do Item? \r\n",
                Properties.Resources.DataLogo,
                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                Color.White,
                "Sim", "Não",
                false);

                //Se usuário desejar realizar Alteração do vencimento
                resposta = frmCaixa.ShowDialog();
                if (resposta == DialogResult.Yes)
                {

                    DateTime dataVencimento = DateTime.Now;
                    DateTime dataItem = DateTime.Now;

                    foreach (DataGridViewRow row in dgvItemCrediario.Rows)
                    {
                        if ((bool)row.Cells[0].FormattedValue == true)
                        {
                            dataItem = Convert.ToDateTime(row.Cells[18].Value);
                            dataVencimento = Convert.ToDateTime(row.Cells[19].Value);
                            break;
                        }
                    }

                    //------------ Informa o vencimento 
                    DialogResult opcaoVencimento;
                    FrmSelecionarVencimentoCrediario frmVencimento = new FrmSelecionarVencimentoCrediario(dataItem, dataVencimento);
                    opcaoVencimento = frmVencimento.ShowDialog();
                    //Se sim formulario retorna o vencimento 
                    if (opcaoVencimento == DialogResult.Yes)
                    {

                        //Adiciona Vencimentos a lista
                        metodoAddItemListaVencimento(frmVencimento.dataVencimento);
                        if (nItem.AlterarVencimentoItemCrediario(listaItemCrediarioCad) == true)
                        {

                            metodoIniciaFormulario();

                        }
                        else
                        {
                            FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Erro - Vencimento Item",
                           "Não existem itens selecionados!",
                            Properties.Resources.DialogErro,
                            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                            Color.White,
                            "Ok", "",
                            false);
                            frmCaixaCad.ShowDialog();

                        }

                    }
                }
            }
            else
            {
                FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Erro - Vencimento Item",
                "Não existem itens selecionados!",
                Properties.Resources.DialogErro,
                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                Color.White,
                "Ok", "",
                false);
                frmCaixaCad.ShowDialog();
            }
        }

        private void btSelecionarParcial_Click(object sender, EventArgs e)
        {
            Boolean itemEncontrado = false;//variável para parar loop quando item for encontrado
            itemParcialSelecionado = new ItemCrediario();

             //percorre todas as linhas do gride
            foreach (DataGridViewRow check in dgvItemCrediario.Rows)
            {
                //pega valores cheked no gride
                if ((bool)check.Cells[0].FormattedValue == true)
                {
                    //Código item Entrada 
                    int codigoItem = int.Parse(check.Cells[2].Value.ToString());
                    foreach (ItemCrediario item in itemLista)
                    {

                        if (codigoItem == item.codigoItemCrediario)
                        {

                            itemParcialSelecionado = item;
                            itemEncontrado = true;
                            break; 
                        }
                    }

                    if (itemEncontrado == true) { break; }

                  } 
                }

            itemParcialSelecionado.Crediario = objCrediario;
            FrmSelecionarParcialCrediario frmParcial = new FrmSelecionarParcialCrediario(itemParcialSelecionado, null);
            frmParcial.ShowDialog();
            metodoIniciaFormulario();

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            try
            {

                //Inicializa Variaveis
                cadParcialValida = false;
                cadItemCrediarioValida = false;

                //Realiza o cancelamento do ItemCrediario
                if (metodoValidaSelecao() == true)
                {
                    DialogResult resposta;
                    //Criando Caixa de dialogo
                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Cancelamento - Excluir",
                    "Deseja realmente cancelar o Item? \r\n",
                    Properties.Resources.DialogExcluir,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Sim", "Não",
                    false);

                    //Se usuário desejar realizar Alteração do vencimento
                    resposta = frmCaixa.ShowDialog();
                    if (resposta == DialogResult.Yes)
                    {
                        //----------Lista de Itens Selecionados
                        //Cria nova lista para receber itens do DataGride Item
                        listaItemCrediarioCad = new ItemCrediarioLista();
                        //Cria nova lista para receber itens do DataGride Parciais
                        ListaParcial = new ItemCrediarioParcialLista();
                        //Adiciona itens a Lista do Crediario
                        metodoAddItemLista();

                        //Verifica se há sangria no caso de parciais do item
                        if (metodoValidaCancelamentoSangria() == true)
                        {

                            //---------------------------------------Parcial Items Confirmação de recebimento Parcial
                            if (ListaParcial.Count > 0)
                            {
                                DialogResult respostaParcial;
                                //Criando Caixa de dialogo
                                FrmCaixaDialogoOpcoes frmCaixaDialogo = new FrmCaixaDialogoOpcoes("Cancelar Parciais",
                                "Item possui parciais, deseja realizar cancelamento das Parciais ?",
                                Properties.Resources.DialogParcial,
                                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                Color.White,
                                "Selecionar", "Excluir", "Cancelar",
                                false);

                                //----------------------Exclusão da Parciais dos itens Selecionados
                                respostaParcial = frmCaixaDialogo.ShowDialog();
                                if (respostaParcial == DialogResult.OK)
                                {
                                    if (nItem.ExcluirItemCrediarioParcialPorItemCrediario(ListaParcial) == true)
                                    {
                                        DialogResult respostaParcialItem;
                                        FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Cancelamento - Parcias",
                                        "Parcias canceladas com Sucesso!" +
                                        "\r\n Deseja Continuar o Cancelamento!",
                                         Properties.Resources.Excluir,
                                         System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                         Color.White,
                                         "Excluir", "Cancelar",
                                         false);

                                        cadParcialValida = true;//Para imprimir comprovante
                                        respostaParcialItem = frmCaixaCad.ShowDialog();

                                        //Se usuário desejar Excluir item -> Items que tiveram as parciais Excluidas
                                        if (respostaParcialItem == DialogResult.Yes)
                                        {
                                            //Adiciona Itens a nova Lista pra realizar o cancelamento 
                                            metodoAddItemListaCancelamento(ListaParcial);

                                        }
                                    }
                                    else
                                    {

                                        MessageBox.Show("Erro não foi possível excluir Parciais!",
                                        "Erro Parcial", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                //---------------------------Formulário de Parcias para realizar Consulta ou Cancelamento
                                else if (respostaParcial == DialogResult.Yes)
                                {
                                    ItemCrediario item = new ItemCrediario();
                                    item.Crediario = objCrediario;
                                    FrmSelecionarParcialCrediario frmParcial = new FrmSelecionarParcialCrediario(item, null);
                                    frmParcial.ShowDialog();
                                    metodoIniciaFormulario();
                                }

                            }
                            //------------------------------------------ItemCrediarioCancelamento
                            if (listaItemCrediarioCad.Count > 0)
                            {
                                //---------------Cancela Item Crediario
                                if (nItem.ExcluirItemCrediarioCancela(listaItemCrediarioCad) == false)
                                {
                                    //---------Erro ao Excluir ItensPendentes
                                    //Se não for possivel realizar o cadastro
                                    frmCaixa = new FrmCaixaDialogo("Erro Exclusão",
                                    "Erro ao Excluir Item Crediario Pendente!",
                                     Properties.Resources.DialogErro,
                                     System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                     Color.White,
                                     "Ok", "",
                                     false);
                                    frmCaixa.ShowDialog();
                                }
                                else { cadItemCrediarioValida = true; } //ItemCrediarioRealizado com sucesso                        
                            }

                            //-------------------Realiza Impressão Comprovante
                            if (cadItemCrediarioValida == true || cadParcialValida == true)
                            {
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
                                    //Imprimir Parciais canceladas como Estorno -> Devem ser exibidas separadamente
                                    //Imprimir Itens Cancelados -> 
                                    //Retornando que exclusão foi realizada com sucesso
                                    //ListaParcial.Count > 0 > Adicionar Parciais caso forem Pagas
                                    metodoIniciaFormulario();//Imprimir Parciais Pagas e Item Crediario Pago
                                    //this.DialogResult = DialogResult.Yes;
                                    //ImprimiComprovante() -> Adicionar Parciais caso forem Pagas
                                    //metodoLimpaCampos()
                                }
                                else { metodoIniciaFormulario(); }
                            }
                        }//Valida Sangria
                        else {
                            MessageBox.Show("Atualize os dados da sangria para realizar cancelamento!",
                                       "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    //Seleção
                    else
                    {
                        MessageBox.Show("Não existem itens Selecionados!",
                            "Seleção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message,
                    "Erro Cancelamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //-------------------Caixa de Texto
        private void tbValorPago_TextChanged(object sender, EventArgs e)
        {
            metodos.metodoMoedaTB(ref tbValorPago);
            metodoCalculaTroco();
        }

        private void nudDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btDesconto.PerformClick();
                e.Handled = true;
            }
        }

        private void FrmItemCrediario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F10) == true)
            {
                btReceber.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F12) == true)
            {
                btParcial.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F4) == true)
            {
                btAlterarVencimento.PerformClick();
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

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair do Item Crediario?",
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


    }
}
