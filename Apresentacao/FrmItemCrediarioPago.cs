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
    public partial class FrmItemCrediarioPago : Form
    {

        ItemCrediario objItem = new ItemCrediario();
        ItemCrediario itemSelecionado = new ItemCrediario();
        ItemCrediarioLista itemLista = new ItemCrediarioLista();
        ItemCrediarioLista listaItemCrediarioCad = new ItemCrediarioLista();
        ItemCrediario itemParcialSelecionado = new ItemCrediario();//Para selecionar o item da parcial
        NegItemCrediario nItem = new NegItemCrediario();

        //Crediario
        Crediario objCrediario = new Crediario();
        NegCrediario nCrediario = new NegCrediario();
        //Produto Cor
        NegProdutoCor nProdutoCor = new NegProdutoCor();
        ProdutoCor produtoCor = new ProdutoCor();

        //Parcial
        ItemCrediarioParcialLista ListaParcial = new ItemCrediarioParcialLista();
       
        //--------Validações
        Boolean cadParcialValida = false;
        Boolean cadItemCrediarioValida = false;
        Boolean cancelamentoParcialFinalizado = false;
        
        //--------------Forma Pagamento
        FormaPagamento objFormaPagamento = new FormaPagamento();
        ListaFormaPagamento listaFormaPagamento = new ListaFormaPagamento();
        NegFormaPagamento nFormaPagamento = new NegFormaPagamento();
        
        //--------Variaveis
        //int codigoItemSelecionado = 0;
        Boolean clkSelecao = false;
        String LocalSolution;
        Metodos metodos = new Metodos();
        //--------------Valores
        DateTime dataInicial = DateTime.Now;


        public FrmItemCrediarioPago(Crediario crediario)
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
                    this.dgvItemCrediario[1, indice].Value = item.codigoItemCrediario;
                    this.dgvItemCrediario[2, indice].Value = item.Venda.codigoVenda;
                    this.dgvItemCrediario[3, indice].Value = item.ProdutoCor.Produto.codigoProduto;
                    this.dgvItemCrediario[4, indice].Value = item.ProdutoCor.codigoProdutoCor;
                    
                    this.dgvItemCrediario[5, indice].Value = item.ProdutoCor.Produto.descricaoProduto;
                    this.dgvItemCrediario[6, indice].Value = item.ProdutoCor.Produto.referenciaProduto;
                    this.dgvItemCrediario[7, indice].Value = item.ProdutoCor.Produto.sexoProduto;
                    this.dgvItemCrediario[8, indice].Value = item.ProdutoCor.Cor.nomeCor;
                    this.dgvItemCrediario[9, indice].Value = item.ProdutoCor.Produto.Genero.nomeGenero;
                    this.dgvItemCrediario[10, indice].Value = item.Tamanho.codigoTamanho;
                    this.dgvItemCrediario[11, indice].Value = item.Tamanho.nometamanho;

                    this.dgvItemCrediario[12, indice].Value = item.quantidadeItemCrediario;
                    this.dgvItemCrediario[13, indice].Value = item.valorItemCrediario;
                    this.dgvItemCrediario[14, indice].Value = item.recebidoItemCrediario;
                    this.dgvItemCrediario[15, indice].Value = item.parcialItemCrediario;

                    this.dgvItemCrediario[16, indice].Value = item.formaPagamento.formaPagamento;
                    this.dgvItemCrediario[17, indice].Value = item.descontoItemCrediario;
                    this.dgvItemCrediario[18, indice].Value = item.jurosItemCrediario;

                    this.dgvItemCrediario[19, indice].Value = item.codigoBarrasItem;
                    this.dgvItemCrediario[20, indice].Value = item.ProdutoCor.ImagemProduto;
                    this.dgvItemCrediario[21, indice].Value = item.estatusItem;
                    this.dgvItemCrediario[22, indice].Value = item.dataItemCrediario;
                    this.dgvItemCrediario[23, indice].Value = item.formaPagamento.codigoFormaPagamento;

                    if (item.parcialItemCrediario != (item.valorItemCrediario * item.quantidadeItemCrediario))
                    {
                        dgvItemCrediario.Rows[indice].ErrorText = "Possui parcial pendente!";
                    }

                    //Parametro das datas
                    if (dataInicial > item.dataItemCrediario) {

                        dataInicial = item.dataItemCrediario;                
                    }

                    indice++;
                }

                dgvItemCrediario.Update();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void metodoCalculaTotal() {

            if (dgvItemCrediario.RowCount > 0)
            {
                double valoTotal = 0;
                double estornoLiquido = 0;
                double valoTotalLiquido = 0;
                double quantidadeTotal = 0;
                double extornoTotal = 0;
                double descontoTotal = 0;
                double jurosTotal = 0;

                //faz a soma dos totais dos valores do gride
                foreach (DataGridViewRow col in dgvItemCrediario.Rows)
                {
                    quantidadeTotal = quantidadeTotal + Convert.ToInt32(col.Cells[12].Value);
                    valoTotal = valoTotal + Convert.ToDouble(col.Cells[14].Value);
                    valoTotalLiquido = valoTotalLiquido + Convert.ToDouble(col.Cells[15].Value);

                    if ((bool)col.Cells[0].FormattedValue == true)
                    {
                        extornoTotal = extornoTotal + Convert.ToDouble(col.Cells[14].Value);
                        estornoLiquido = estornoLiquido + Convert.ToDouble(col.Cells[15].Value);
                        descontoTotal = descontoTotal + Convert.ToDouble(col.Cells[17].Value);
                        jurosTotal = jurosTotal + Convert.ToDouble(col.Cells[18].Value);
                    }
                }

            //-----Total da Conta do Cliente
            lbCrediarioBruto.Text = String.Format("{0:C2}", valoTotal);//Valor Total Recebido
            lbValorLiquido.Text = String.Format("{0:C2}", valoTotalLiquido);//Valor Total Recebido
            lbDinheiro.Text = String.Format("{0:C2}", extornoTotal);//Valor Recebido Selecionado
            lbEstorno.Text = String.Format("{0:C2}", estornoLiquido);//Valor Recebido Selecionado
            lbDesconto.Text = String.Format("{0:C2}", descontoTotal);//Quantidade Total de Itens
            lbTaxa.Text = String.Format("{0:C2}", jurosTotal);//Quantidade Total de Itens
            //-----------Menu Calculos
            lbValorTotalCrediario.Text = String.Format("{0:C2}", estornoLiquido);//Valor Total Recebido
            lbJurosCrediario.Text = String.Format("{0:C2}", jurosTotal);//Valor juros
            lbDescontoCrediario.Text = String.Format("{0:C2}", descontoTotal);//Valor desconto
            lbCrediarioLiquido.Text = String.Format("{0:C2}", extornoTotal);//Valor liquido
            }
        }

        private void metodoIniciaFormulario()
        {

            //Preenche Camopos
            tbCodigo.Text = objCrediario.codigoCrediario.ToString();
            tbNome.Text = objCrediario.Cliente.nomeCliente;
            tbSobrenome.Text = objCrediario.Cliente.sobrenomeCliente;
            mtbCpf.Text = objCrediario.Cliente.cpfCliente;
            mtbCelular.Text = objCrediario.Cliente.celularCliente;

            //-----Preencher o Gride com os dados do ItemCrediaro
            metodoBuscaItemCrediarioPago(objCrediario);
            metodoExibeImagemProduto();

            //Calcula
            metodoCalculaTotal();


        }

        private void metodoBuscaItemCrediarioPago(Crediario crediario)
        {
            itemLista = nItem.BuscarItemCrediarioPagoPorCrediario(crediario.codigoCrediario);
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

                String imgProduto = (dgvItemCrediario.CurrentRow.Cells[20].Value).ToString();
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
                            itemCrediario.formaPagamento = new FormaPagamento();

                            //Chaves FK e UK
                            itemCrediario.codigoItemCrediario = Convert.ToInt32(row.Cells[1].Value);
                            itemCrediario.ProdutoCor.codigoProdutoCor = Convert.ToInt32(row.Cells[4].Value);
                            itemCrediario.Venda.codigoVenda = Convert.ToInt32(row.Cells[2].Value);
                            itemCrediario.Crediario = objCrediario;
                            itemCrediario.Tamanho.codigoTamanho = Convert.ToInt32(row.Cells[10].Value);
                            itemCrediario.formaPagamento.codigoFormaPagamento = Convert.ToInt32(row.Cells[23].Value); //Testar se está dando certo
                            itemCrediario.formaPagamento.formaPagamento = row.Cells[16].Value.ToString();
                            //Valores
                            itemCrediario.quantidadeItemCrediario = Convert.ToInt32(row.Cells[12].Value);
                            itemCrediario.valorItemCrediario = Convert.ToDouble(row.Cells[13].Value);
                            itemCrediario.parcialItemCrediario = Convert.ToDouble(row.Cells[14].Value);
                            //Encargos Juros e Desconto Total * Porcentagem
                            itemCrediario.jurosItemCrediario = Convert.ToDouble(row.Cells[18].Value);
                            itemCrediario.descontoItemCrediario = Convert.ToDouble(row.Cells[17].Value);
                            itemCrediario.dataItemCrediario = Convert.ToDateTime(row.Cells[22].Value);
                            //Se tiver Parcial
                            if (row.Cells[16].Value.ToString() == "PARCIAL")
                            {
                                ItemCrediarioParcial itemParcial = new ItemCrediarioParcial();

                                //Carregando Item
                                itemParcial.FormaPagamento = objFormaPagamento;
                                itemParcial.ItemCrediario = itemCrediario;
                                itemParcial.Cliente = objCrediario.Cliente;
                                itemParcial.ProdutoCor = itemCrediario.ProdutoCor;
                                itemParcial.Tamanho = itemCrediario.Tamanho;

                                //Valores
                                itemParcial.descontoParcial = Convert.ToDouble(row.Cells[17].Value);
                                itemParcial.jurosParcial = Convert.ToDouble(row.Cells[18].Value);
                                itemParcial.valorParcialBruto = Convert.ToDouble(row.Cells[14].Value); ;//Valor Realmente Recebido Com juros e desconto 
                                itemParcial.valorPagoParcial = Convert.ToDouble(row.Cells[15].Value);//Valor da Parcial
                                itemParcial.dataParcial = Convert.ToDateTime(row.Cells[22].Value);
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

        private Boolean metodoValidaSelecao()
        {

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

        //Retorna menor data
        private DateTime metodoDataCrediario()
        {
            try
            {
                DateTime min = itemLista.Min(c => c.dataItemCrediario);
                return min;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return DateTime.Now;
            }
        }

        //---------------------------------------Métodos para cancelamento da Sangria
        #region Cancelamento Sangria
     
        //Verifica se há a necessidade de cancelamento ou atualização da sangria
        private Boolean metodoValidaCancelamentoSangria() {
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

                    //Faz a validação se há parciais na sangria
                    foreach (ItemCrediarioParcial item in listaParcialValida)
                    {

                        if (nSangria.BuscarCancelamentoSangriaPorData(item.dataParcial) == true)
                        {
                            //Cancelar Parcial
                            FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Cancelamento Parciais do item",
                            "Realize o cancelamento das parciais!",
                            Properties.Resources.DialogQuestion,
                            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                            Color.White,
                            "Ok", "",
                            false);

                            //Chama Formulario de cancelamento da Parcial enviando lista dos itens
                            DialogResult resultadoParcial;
                            FrmSelecionarParcialCrediario FrmParcialCrediario = new FrmSelecionarParcialCrediario(null, ListaParcial);
                            resultadoParcial = FrmParcialCrediario.ShowDialog();
                          
                            if (resultadoParcial == DialogResult.Yes)
                            {
                                listaItemCrediarioCad.Clear();
                                cancelamentoParcialFinalizado = true;
                                return true;
                            }
                            else
                            {
                                //Erro ao Cancelar Parcial
                                FrmCaixaDialogo frmCaixaErro = new FrmCaixaDialogo("Erro ao Cancelar Parcial",
                                "Não foi possível cancelar as Parciais!",
                                Properties.Resources.DialogErro,
                                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                Color.White,
                                "Ok", "",
                                false);
                                frmCaixaCad.ShowDialog();

                                return false;//erro ao atualizar pariciais
                            }
                            
                        }
                    }
                }

                //-------------------------Item Crediario tem items para cancelamento
                if (listaItemCrediarioCad.Count > 0)
                {

                    //Nova  Lista Separando intens por forma de Pagamento
                    ItemCrediarioLista lista = new ItemCrediarioLista();

                    //Adiciona itens por data e forma de pagamento na lista
                    int contador = 0;

                    foreach (ItemCrediario itemLista in listaItemCrediarioCad)
                    {

                        if (contador == 0)
                        {
                            lista.Add(itemLista);

                        }
                            //DATA e PAGAMENTO forem iguais realizado a atualização do item
                        else if (lista[contador].formaPagamento.codigoFormaPagamento == itemLista.formaPagamento.codigoFormaPagamento &&
                            lista[contador].dataItemCrediario == itemLista.dataItemCrediario)
                        {

                            lista[contador].valorItemCrediario = lista[contador].valorItemCrediario + itemLista.valorItemCrediario;
                            lista[contador].quantidadeItemCrediario = lista[contador].quantidadeItemCrediario + itemLista.quantidadeItemCrediario;
                        }
                        else
                        {
                            lista.Add(itemLista);
                            contador++;
                        }

                    }

                    //Validar itens de acordo com sua forma de pagamento e data
                    contador = 0;
                    while (lista.Count > contador)
                    {
                        //Resto Caixa
                        sangria = nSangria.BuscarCancelamentoSangria(lista[contador].dataItemCrediario, lista[contador].formaPagamento.codigoFormaPagamento);
                        if (sangria != null)
                        {
                            sangria.dataSangria = lista[contador].dataItemCrediario;
                            double valorTotalItem = (from x in lista where (x.formaPagamento.codigoFormaPagamento == sangria.pagamentoSangria.codigoFormaPagamento && x.dataItemCrediario == sangria.dataSangria) select ((x.quantidadeItemCrediario * x.valorItemCrediario) + x.jurosItemCrediario - x.descontoItemCrediario)).Sum();

                            //Lista de valores da sangria referente a data de cancelamento do item
                            SangriaLista sangriaLista = new SangriaLista();
                            sangriaLista = metodoBuscaSangriaCancelamento(lista);
                            double valorSangria = (from s in sangriaLista where (s.pagamentoSangria.codigoFormaPagamento == lista[contador].formaPagamento.codigoFormaPagamento) select (s.valorSangria)).Sum();

                            //Busca Valores do caixa de acordo com as datas que tem no item
                            CaixaLista caixaLista = new CaixaLista();
                            caixaLista = metodoBuscaCaixaCancelamento(lista);
                            double valorCaixa = (from c in caixaLista where (c.formaPagamento.codigoFormaPagamento == lista[contador].formaPagamento.codigoFormaPagamento && c.dataCaixa == lista[contador].dataItemCrediario) select (c.valorCaixa)).Sum();


                            //Resto do caixa >= Valor do Caixa - Valor Item Cancelado
                            if ((valorSangria) >= valorCaixa - valorTotalItem)
                            {
                                DialogResult resultadoAtualizacaoSangria;
                                FrmCancelamentoSangria frmSangria = new FrmCancelamentoSangria(sangria, caixaLista, null, null, lista, null);
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
                            else { contador++; }

                        }
                        else { contador++; }
                        //Validação sangria vazia 
                    }//While End
                }//ListaItemCrediario > 0

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
                else if (item.dataItemCrediario != caixaLista[contador].dataCaixa) {
                    //Toda vez que a data for diferente busca os itens do caixa 
                    //E os adiciona na lista antiga
                    CaixaLista caixaListaNova = new CaixaLista();
                    caixaListaNova = nCaixa.BuscarCaixaValores(item.dataItemCrediario);
                    foreach (Caixa caixaAdd in caixaListaNova) {

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

        //--------------------Formulário
        private void FrmItemCrediarioPago_Load(object sender, EventArgs e)
        {
            metodoIniciaFormulario();
            //Data  Inicial Filtros
            dtpDataInicial.Value = dataInicial;

            if (objCrediario.estatusCrediario == "BLOQUEADO")
            {
                pbOk.Visible = true;
                pbOk.Image = Properties.Resources.DialogErro;
                tgBloqueio.Checked = true;
                lbEstatus.Text = "BLOQUEADO";
            }
            else
            {
                pbOk.Visible = true;
                pbOk.Image = Properties.Resources.DialogOK;
                tgBloqueio.Checked = false;
                lbEstatus.Text = "ATIVO";
            }
        }
       
        private void FrmItemCrediarioPago_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F5) == true)
            {
                btBuscarTodos.PerformClick();
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

        private void FrmItemCrediarioPago_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        //----------------------DataGide
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

        private void dgvItemCrediario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            metodoExibeImagemProduto();
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

                btCancelar.Focus();
            }
        }

        private void dgvItemCrediario_DoubleClick(object sender, EventArgs e)
        {
            btSelecionarParcial.PerformClick();
        }

        //-------------------Botões
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

        private void pbCalculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\system32\\calc.exe");
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
         try
            {
                //Inicializa Variaveis
                cadParcialValida = false;
                cadItemCrediarioValida = false;

                //----------Lista de Itens Selecionados
                //Cria nova lista para receber itens do DataGride Item
                listaItemCrediarioCad = new ItemCrediarioLista();
                //Cria nova lista para receber itens do DataGride Parciais
                ListaParcial = new ItemCrediarioParcialLista();
                //Adiciona itens a Lista do Crediario
                metodoAddItemLista();
               
                //Cancelamento Sangria caso haja vinculo com parcial
                if (metodoValidaCancelamentoSangria() == true)
                {
                    //Caso as parciais forem excluidas atualiza o formulario e finaliza evento botao
                    if (cancelamentoParcialFinalizado == true) {
                        cancelamentoParcialFinalizado = false;
                        metodoIniciaFormulario();
                        return;
                    }

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

                        //Se usuário desejar realizar cancelar o item
                        resposta = frmCaixa.ShowDialog();
                        if (resposta == DialogResult.Yes)
                        {

                            //---------------------------------------Parcial Items Confirmação de recebimento Parcial
                            #region Cancelamento das Parciais
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
                                    }
                                    else
                                    {

                                        MessageBox.Show("Erro não foi possível excluir Parciais!",
                                        "Erro Parcial", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            #endregion

                            //---------------------------Formulário de Parcias para realizar Consulta ou Cancelamento
                            #region Chama Formulário Parcial
                                else if (respostaParcial == DialogResult.Yes)
                                {
                                    ItemCrediario item = new ItemCrediario();
                                    item.Crediario = objCrediario;
                                    FrmSelecionarParcialCrediario frmParcial = new FrmSelecionarParcialCrediario(item, null);
                                    frmParcial.ShowDialog();
                                    metodoIniciaFormulario();
                                }

                            }
                                #endregion

                            //------------------------------------------ItemCrediarioCancelamento
                            #region Cancelamento ItemCrediarioPago Vontando para ItemCrediario
                            if (listaItemCrediarioCad.Count > 0)
                            {
                                DialogResult respostaParcial;
                                //Criando Caixa de dialogo
                                FrmCaixaDialogoOpcoes frmCaixaDialogo = new FrmCaixaDialogoOpcoes("Cancelar Item",
                                "Cancelamento item volta para o Crediario?\r\n" +
                                "Exclusão item volta para o Estoque?",
                                Properties.Resources.DialogExcluir,
                                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                Color.White,
                                "Cancelar", "Excluir", "Sair",
                                false);

                                //----------------------Exclusão dos itens Selecionados
                                respostaParcial = frmCaixaDialogo.ShowDialog();

                                //--------------CANCELAMENTO
                                if (respostaParcial == DialogResult.Yes)
                                {
                                    if (nItem.ExcluirItemCrediarioPagoCancela(listaItemCrediarioCad) == true)
                                    {
                                        //Cancelamento realizado sucesso
                                        frmCaixa = new FrmCaixaDialogo("Cancelamento - Item",
                                        "Cancelamento realizado com sucesso, item voltou para Crediario!",
                                         Properties.Resources.DialogProcessando,
                                         System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                         Color.White,
                                         "Ok", "",
                                         false);
                                        frmCaixa.ShowDialog();

                                        cadItemCrediarioValida = true;//Para imprimir comprovante
                                    }
                                    else
                                    {

                                        MessageBox.Show("Erro não foi possível cancelar Item !",
                                        "Erro Parcial", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            #endregion

                            //----------EXCLUSÃO
                            #region Cancelamento Item Crediario Pago
                                else if (respostaParcial == DialogResult.OK)
                                {

                                    if (nItem.ExcluirItemCrediarioPago(listaItemCrediarioCad) == true)
                                    {
                                        //Cancelamento realizado sucesso
                                        frmCaixa = new FrmCaixaDialogo("Exclusão - Item",
                                        "Exclusão realizado com sucesso, item voltou para Estoque!",
                                         Properties.Resources.DialogExcluir,
                                         System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                         Color.White,
                                         "Ok", "",
                                         false);
                                        frmCaixa.ShowDialog();

                                        cadItemCrediarioValida = true;//Para imprimir comprovante
                                    }
                                    else
                                    {

                                        MessageBox.Show("Erro não foi possível excluir Item !",
                                        "Erro Parcial", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                                #endregion

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
                        }
                    }
                    //Seleção
                    else
                    {
                        MessageBox.Show("Não existem itens Selecionados!",
                            "Seleção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }//Validação Sangria
                else
                {
                    MessageBox.Show("Atualize os dados da sangria para realizar cancelamento!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message,
                    "Erro Cancelamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            FrmSelecionarParcialCrediario frmParcial = new FrmSelecionarParcialCrediario(itemParcialSelecionado,null);
            frmParcial.ShowDialog();
            metodoIniciaFormulario();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair do Item Crediario Pago?",
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

        private void btBuscarTodos_Click(object sender, EventArgs e)
        {
            pbLimpar_Click(null, null);
        }

        private void pbLimpar_Click(object sender, EventArgs e)
        {
            dataInicial = DateTime.Now;
            cbFormaPagamento.Items.Clear();
            tbBuscarProduto.Text = "Digite a descrição do produto ...";
            metodoIniciaFormulario();
            dtpDataInicial.Value = dataInicial;
        }

        //-----------------Filtros
        private void pbFiltrar_Click(object sender, EventArgs e)
        {
            //Gerar Filtros do Gride
            itemLista = new ItemCrediarioLista();
            dataInicial = metodoDataCrediario();


            string descricaoProdutoBuscar = "";
            
            if (tbBuscarProduto.Text != "Digite a descrição do produto ...") {

             descricaoProdutoBuscar =  tbBuscarProduto.Text;
            }

            itemLista = nItem.BuscarItemCrediarioPagoPorFiltros(objCrediario.codigoCrediario, descricaoProdutoBuscar, cbFormaPagamento.Text, dtpDataInicial.Value, dtpDataFinal.Value);
            AtualizarDataGrid();

            //Data
            dtpDataInicial.Value = dataInicial;
        }

        private void pbProduto_Click(object sender, EventArgs e)
        {
            //Erro quando informado um valor que não existe na tabela
            cbFormaPagamento.Items.Clear();

            int n;
            bool ehUmNumero = int.TryParse(tbBuscarProduto.Text, out n);
            if (ehUmNumero == true)
            {
                produtoCor = nProdutoCor.uspBuscarProdutoItemCrediarioPagoPorCodigo(n, objCrediario.codigoCrediario);
                if (produtoCor != null)
                {
                    this.tbBuscarProduto.Text = produtoCor.Produto.descricaoProduto;
                    cbFormaPagamento.Focus();
                }
                else {
                    FrmSelecionarProdutoCrediarioPago frmProdutoCrediarioPago = new FrmSelecionarProdutoCrediarioPago(objCrediario, tbBuscarProduto.Text);
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
                FrmSelecionarProdutoCrediarioPago frmProdutoCrediarioPago = new FrmSelecionarProdutoCrediarioPago(objCrediario,tbBuscarProduto.Text);
                DialogResult resultado = frmProdutoCrediarioPago.ShowDialog();

                if (resultado == DialogResult.OK)
                {

                    this.produtoCor = frmProdutoCrediarioPago.produtoCorSelecionado;
                    this.tbBuscarProduto.Text = produtoCor.Produto.descricaoProduto;
                    cbFormaPagamento.Focus();
                }

            }


        }

        //Caixa de Texto Produto
        private void tbBuscarProduto_Enter(object sender, EventArgs e)
        {
            cbFormaPagamento.Items.Clear();
            produtoCor = new ProdutoCor();

            tbBuscarProduto.Clear();
            pbProduto.Image = Properties.Resources.ProdutoRosa;
            panelBuscarProduto.BackColor = Color.DeepPink;
        }

        private void tbBuscarProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbProduto_Click(null,null);
                e.Handled = true;
            }
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

        private void cbFormaPagamento_DropDown(object sender, EventArgs e)
        {
            try
            {
                string produtoPago = "";

                if (produtoCor.Produto != null) {

                    produtoPago = produtoCor.Produto.descricaoProduto;
                }

                cbFormaPagamento.Items.Clear();
                this.listaFormaPagamento = nFormaPagamento.BuscarFormaPagamentoCrediarioPago(produtoPago, objCrediario.codigoCrediario);

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

        //------------------Data
        private void dtpDataInicial_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDataInicial.Value < dataInicial)
            {

                dtpDataInicial.Value = dataInicial;
            
            }
        }

        private void dtpDataFinal_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDataFinal.Value < dtpDataInicial.Value) {

                dtpDataFinal.Value = DateTime.Now;
            
            }
        }


    }
}
