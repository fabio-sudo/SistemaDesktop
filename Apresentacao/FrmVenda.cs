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
    public partial class FrmVenda : Form
    {
        //--------------Venda
        Venda objVenda = new Venda();

        //----------------Instanciando camada de negocios
        NegItemVenda nItem = new NegItemVenda();
        NegItemCrediario nItemCrediario = new NegItemCrediario();
        NegProdutoCor nProdutoCor = new NegProdutoCor();
        NegProduto nProduto = new NegProduto();
        NegFuncionario nFuncionario = new NegFuncionario();
        NegCliente nCliente = new NegCliente();
        NegCrediario nCrediario= new NegCrediario();
        NegVenda nVenda = new NegVenda();
        NegFormaPagamento nFormaPagamento = new NegFormaPagamento();//Prencher formas de pagamento

        //--------------Item da Venda
        ItemVenda item = new ItemVenda();
        ItemVenda itemCodigoBarras = new ItemVenda();
        ItemVendaLista listaItems = new ItemVendaLista();
        ItemVendaLista listaItemVendaCad = new ItemVendaLista();//Lista nova para cadastro de Items
        //---------------ItemCrediario
        ItemCrediario itemCrediario = new ItemCrediario();
        ItemCrediarioLista listaItemCrediario = new ItemCrediarioLista();

        //---------------Forma de Pagamento
        FormaPagamento objFormaPagamento = new FormaPagamento();
        ListaFormaPagamento listaFormaPagamento = new ListaFormaPagamento();//Usado no combobox

        //--------------------Metodos e Variaveis
        Metodos metodos = new Metodos();
        String LocalSolution;

        //----------------Variaveis de Armazenamento Temp
        int codVenda;
        int codigoVendaCad;

        //--------------Valores
        double valorBrutoVenda = 0;
        int quantidadeTotal = 0;
        double valorAReceber = 0;
        double valorJuros = 0;
        double valorDesconto = 0;
        double Porcentagemdesconto = 0;

        //Variavel Booleana para idicar selecionado ou não selecionado  
        Boolean clkSelecao = false;
        Boolean validaCad = false;

        //Essa variavel passa por todas a telas Para realizar incremento do ITEMVENDATEMP
        Boolean varValidaPrimeiraVenda = false;

        public FrmVenda(int codigoVenda)
        {
            InitializeComponent();

            //Código Venda Temporário
            codVenda = codigoVenda;
        }

        //---------------------------Metodos
        private void AtualizarDataGrid()
        {
            this.dgvItemVenda.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.listaItems.Count > 0)
            {
                this.dgvItemVenda.Rows.Add(this.listaItems.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (ItemVenda item in this.listaItems)
            {
                this.dgvItemVenda[1, indice].Value = item.codigoItemVenda;
                this.dgvItemVenda[2, indice].Value = item.ProdutoCor.Produto.codigoProduto;
                this.dgvItemVenda[3, indice].Value = item.ProdutoCor.codigoProdutoCor;
                this.dgvItemVenda[4, indice].Value = item.ProdutoCor.Produto.descricaoProduto;
                this.dgvItemVenda[5, indice].Value = item.ProdutoCor.Produto.referenciaProduto;
                this.dgvItemVenda[6, indice].Value = item.ProdutoCor.Produto.sexoProduto;
                this.dgvItemVenda[7, indice].Value = item.ProdutoCor.Cor.nomeCor;
                this.dgvItemVenda[8, indice].Value = item.ProdutoCor.Produto.Genero.nomeGenero;
                this.dgvItemVenda[9, indice].Value = item.Tamanho.codigoTamanho;
                this.dgvItemVenda[10, indice].Value = item.Tamanho.nometamanho;
                this.dgvItemVenda[11, indice].Value = item.quantidadeVenda;
                this.dgvItemVenda[12, indice].Value = item.precoCusto;
                this.dgvItemVenda[13, indice].Value = item.precoVenda;
                this.dgvItemVenda[14, indice].Value = item.precoVenda * item.quantidadeVenda;//Total 
                this.dgvItemVenda[15, indice].Value = item.codigoBarrasItem;
                this.dgvItemVenda[16, indice].Value = item.ProdutoCor.ImagemProduto;

                indice++;
            }

            dgvItemVenda.Update();

        }

        private void metodoIniciaFormulario()
        {
            //Buscal Local que a Solution Está sendo Executada no Computador
            LocalSolution = Environment.CurrentDirectory;
            // This will get the current PROJECT directory
            LocalSolution = Directory.GetParent(LocalSolution).Parent.Parent.FullName;

            metodoBuscaVendaTempValida();

            listaItems = nItem.BuscarItemVendaTempPorVenda(codVenda);//CodigoEntradaEstoque          
            AtualizarDataGrid();

            if (listaItems.Count > 0)
            {
                metodoCalculaTotais();
                metodoExibeImagemProduto();
            }
            else
            {

                pbImagemProduto.Image = global::Apresentacao.Properties.Resources.imgDefaut;
            }

        }

        //Busca a venda que vai ser utilizada no cadastro temporátio Sempre após o primeiro cadastro
        private void metodoBuscaVendaTempValida()
        {
            //Vai passar aqui apenas quando houver o Primeiro cadastro
            if (varValidaPrimeiraVenda == true && validaCad == false && codVenda == 0)
            {
                codVenda = nVenda.BuscarItemVendaTempUltimoRegistro();
                validaCad = true;
            }
        }

        private Boolean metodoValidaVenda()
        {

            if (objVenda.Cliente == null || tbBuscarCliente.Text == "Digite o nome do cliente ...")
            {
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro Cliente",
                "Informe o Cliente para realizar a Venda",
                Properties.Resources.Cliente,
                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                Color.White,
                "Ok", "",
                false);
                frmCaixa.ShowDialog();

                return false;
            }
            else if (objVenda.Funcionario == null || tbFuncionario.Text == "Digite o nome do funcionário ...")
            {
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro Funcionário",
                "Informe o Funcionário para realizar a Venda",
                Properties.Resources.Funcionario,
                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                Color.White,
                "Ok", "",
                false);
                frmCaixa.ShowDialog();

                return false;
            }
            else if (cbFormaPagamento.SelectedItem == null)
            {
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro Forma Pagamento",
                "Informe a Forma de Pagamento para realizar a Venda",
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

        private Boolean metodoValidaParcial()
        {

            if (objVenda.Cliente == null || tbBuscarCliente.Text == "Digite o nome do cliente ...")
            {
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro Cliente",
                "Informe o Cliente para realizar a Venda",
                Properties.Resources.Cliente,
                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                Color.White,
                "Ok", "",
                false);
                frmCaixa.ShowDialog();

                return false;
            }
            else if (objVenda.Funcionario == null || tbFuncionario.Text == "Digite o nome do funcionário ...")
            {
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro Funcionário",
                "Informe o Funcionário para realizar a Venda",
                Properties.Resources.Funcionario,
                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                Color.White,
                "Ok", "",
                false);
                frmCaixa.ShowDialog();

                return false;
            }
            else { return true; }

        }

        private void metodoAtivaCamposVenda()
        {

            //Caixa de Texto Venda
            tbBuscarCliente.Enabled = true;
            btCliente.Enabled = true;
            tbFuncionario.Enabled = true;
            btFuncionario.Enabled = true;

            //Items da Venda
            tbBuscarCliente.Focus();

        }

        private void metodoDesativaCamposVenda()
        {
            //Caixa de Texto Venda
            tbBuscarCliente.Enabled = false;
            btCliente.Enabled = false;
            tbBuscarCliente.Text = "Digite o nome do cliente ...";
            pbUsuario.Image = Properties.Resources.ClienteAzul;
            panelBuscarCliente.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            tbBuscarCliente.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

            tbFuncionario.Enabled = false;
            btFuncionario.Enabled = false;
            tbFuncionario.Text = "Digite o nome do funcionário ...";
            pbFuncionario.Image = Properties.Resources.FuncionarioAzul;
            panelFuncionario.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            tbFuncionario.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

            //Items da Venda
            tbBuscarProduto.Focus();
        }

        private void metodoExibeImagemProduto()
        {
            if (dgvItemVenda.Rows.Count > 0)
            {
                String imgProduto = (dgvItemVenda.CurrentRow.Cells[16].Value).ToString();
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

        //Metodos Barras
        private void metodoBarrasAtivado()
        {
            itemCodigoBarras = new ItemVenda();
            tbCodigoBarras.Enabled = true;
            tbQuantidadeBarras.Enabled = true;
            mtbPrecoVendaBarras.Enabled = true;
            tbCodigoBarras.Focus();
            pbLancar.Enabled = true;
            pbBuscarBarras.Enabled = true;

            tbCodigoBarras.Focus();
            tbCodigoBarras.Clear();
            tbBuscarProduto.Clear();
            tbQuantidadeBarras.Minimum = 0;
            tbQuantidadeBarras.Value = 0;
            mtbPrecoVendaBarras.Clear();

            tbBuscarProduto.Enabled = false;
            pbProduto.Enabled = false;
        }

        private void metodoBarrasDesativado()
        {
            tbCodigoBarras.Enabled = false;
            tbQuantidadeBarras.Enabled = false;
            mtbPrecoVendaBarras.Enabled = false;
            pbLancar.Enabled = false;
            pbBuscarBarras.Enabled = false;

            tbCodigoBarras.Clear();
            tbQuantidadeBarras.Minimum = 0;
            tbQuantidadeBarras.Value = 0;
            mtbPrecoVendaBarras.Clear();
            tbBuscarProduto.Clear();

            tbBuscarProduto.Enabled = true;
            pbProduto.Enabled = true;
            tbBuscarProduto.Focus();
        }
        //--MetodosTotais
        private void metodoCalculaTotais()
        {
            try
            {

                quantidadeTotal = 0;
                valorBrutoVenda = 0;
                valorAReceber = 0;
                valorJuros = 0;
                valorDesconto = 0;
                Porcentagemdesconto = 0;

                if (dgvItemVenda.RowCount > 0)
                {

                    //faz a soma dos totais dos valores do gride
                    foreach (DataGridViewRow col in dgvItemVenda.Rows)
                    {
                        quantidadeTotal = quantidadeTotal + Convert.ToInt32(col.Cells[11].Value);
                        valorAReceber = valorAReceber + Convert.ToDouble(col.Cells[14].Value);
                    }
                }
                valorBrutoVenda = valorAReceber;
                lbValorTotalVenda.Text = "+ " + String.Format("{0:C2}", valorAReceber);
                //-------Juros Cartão
                if (cbFormaPagamento.Text != "")
                {
                    valorJuros = Convert.ToDouble(lbTaxaJuros.Text) / 100;
                    valorJuros = valorAReceber * valorJuros;
                    lbTaxa.Text = "- " + String.Format("{0:C2}", valorJuros);
                    lbJurosVenda.Text = "%" + String.Format("{0:C2}", valorJuros);
                }

                //-------Desconto
                Porcentagemdesconto = (Convert.ToDouble(nudDesconto.Value) / 100);
                valorDesconto = Porcentagemdesconto * valorAReceber;
                lbDesconto.Text = "- " + String.Format("{0:C2}", valorDesconto);
                lbDescontoVenda.Text = " - " + String.Format("{0:C2}", valorDesconto);
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
                lbVendaLiquido.Text = "+ " + String.Format("{0:C2}", valorAReceber);
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
        public void metodoAddItemLista(int codigoVenda)
        {
            try
            {
                if (dgvItemVenda.RowCount > 0)
                {
                    //Percorre o gride para adicionar itens
                    listaItemVendaCad = new ItemVendaLista();

                    foreach (DataGridViewRow row in dgvItemVenda.Rows)
                    {
                        ItemVenda itemVenda = new ItemVenda();
                        itemVenda.Venda = new Venda();
                        itemVenda.ProdutoCor = new ProdutoCor();
                        itemVenda.Tamanho = new Tamanho();

                        //Chaves FK e UK
                        itemVenda.ProdutoCor.codigoProdutoCor = Convert.ToInt32(row.Cells[3].Value);
                        itemVenda.Venda.codigoVenda = codigoVenda;
                        itemVenda.Tamanho.codigoTamanho = Convert.ToInt32(row.Cells[9].Value);
                        //Valores
                        itemVenda.quantidadeVenda = Convert.ToInt32(row.Cells[11].Value);
                        itemVenda.precoCusto = Convert.ToDouble(row.Cells[12].Value);
                        itemVenda.precoVenda = Convert.ToDouble(row.Cells[13].Value);
                        //Encargos Juros e Desconto Total * Porcentagem
                        itemVenda.JurosItem = Math.Round((itemVenda.precoVenda * itemVenda.quantidadeVenda) * (objFormaPagamento.taxaFormaPagamento / 100), 4);
                        itemVenda.descontoItem = Math.Round((itemVenda.precoVenda * itemVenda.quantidadeVenda) * (Porcentagemdesconto), 4);
                       
                        if (cbJuros.Checked == false) { itemVenda.JurosItem = itemVenda.JurosItem * -1; }//Juros Negativos é quando juros não é acrescentado no total da venda


                        listaItemVendaCad.Add(itemVenda);

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //Métodos para adicionar Valores do Gride na Lista
        public void metodoAddItemListaCrediario(Venda objVendaCrediario, DateTime dataVencimento)
        {
            try
            {
                if (dgvItemVenda.RowCount > 0)
                {
                    //Percorre o gride para adicionar itens
                    listaItemCrediario = new ItemCrediarioLista();

                    foreach (DataGridViewRow row in dgvItemVenda.Rows)
                    {
                        ItemCrediario itemCred = new ItemCrediario();
                        itemCred.Venda = new Venda();
                        itemCred.Crediario = new Crediario();
                        itemCred.formaPagamento = new FormaPagamento();
                        itemCred.ProdutoCor = new ProdutoCor();
                        itemCred.Tamanho = new Tamanho();

                        //Chaves FK e UK
                        itemCred.Venda.codigoVenda = objVendaCrediario.codigoVenda;
                        itemCred.Crediario.codigoCrediario = objVendaCrediario.Cliente.codigoCliente;
                        itemCred.formaPagamento = objVendaCrediario.formaPagamento;
                        itemCred.ProdutoCor.codigoProdutoCor = Convert.ToInt32(row.Cells[3].Value);
                        itemCred.Tamanho.codigoTamanho = Convert.ToInt32(row.Cells[9].Value);
                        //Valores
                        itemCred.quantidadeItemCrediario = Convert.ToInt32(row.Cells[11].Value);
                        itemCred.valorItemCrediario = Convert.ToDouble(row.Cells[13].Value);
                        itemCred.parcialItemCrediario = (itemCred.valorItemCrediario * itemCred.quantidadeItemCrediario);
                        //Encargos Juros e Desconto Total * Porcentagem
                        itemCred.descontoItemCrediario = Math.Round((itemCred.parcialItemCrediario) * (Porcentagemdesconto), 4);
                        itemCred.jurosItemCrediario = Math.Round((itemCred.parcialItemCrediario) * (objFormaPagamento.taxaFormaPagamento / 100), 4);
                        //---------------Data Venciemtno
                        itemCred.dataVencimentoItemCrediario = dataVencimento;

                        listaItemCrediario.Add(itemCred);

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //------------------Botões Item Venda
        private void pbProduto_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Código Venda Serve Para realizar mais de uma venda ao mesmo tempo
            FrmSelecionarProdutoVenda frmSelecionarProdutoVenda = new FrmSelecionarProdutoVenda(codVenda, tbBuscarProduto.Text, "Cadastrar");
            resposta = frmSelecionarProdutoVenda.ShowDialog();
            if (resposta == DialogResult.Yes)
            {

                //Variavel para atualizar VendaTemp codigo = 0
                varValidaPrimeiraVenda = frmSelecionarProdutoVenda.varValidaPrimeiraVenda;

                metodoIniciaFormulario();
            }

        }

        private void pbCalculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\system32\\calc.exe");
        }

        //------------------Formulário
        private void FrmVenda_Load(object sender, EventArgs e)
        {
            metodoIniciaFormulario();

            //Pega no formulario da venda o UsuarioLogado
            if (FrmMenuPrincipal.userLogado != null)
            {
                objVenda.Funcionario = FrmMenuPrincipal.userLogado;
                tbFuncionario.Text = objVenda.Funcionario.nomeFuncionario;
            }

            if (dgvItemVenda.RowCount > 0)
            {

                metodoExibeImagemProduto();
            }
        }

        private void dgvItemVenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            metodoExibeImagemProduto();
        }

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

                btExcluir.Focus();
            }
        }

        private void dgvItemVenda_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(dgvItemVenda.CurrentRow.Cells[3].Value);
                item.ProdutoCor = nProdutoCor.BuscarProdutoCorPorCodigo(n);
                if (item.ProdutoCor != null)
                {
                    FrmItemVendaTemp frmItemVenda = new FrmItemVendaTemp(item.ProdutoCor, codVenda);
                    DialogResult resposta;

                    resposta = frmItemVenda.ShowDialog();

                    if (resposta == DialogResult.Yes)
                    {
                        metodoIniciaFormulario();
                    }
                }
            }
            catch (Exception ex)
            {
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro",
                "Erro ao selecionar Produto \r\n" + ex.Message,
                Properties.Resources.DialogErro,
                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                Color.White,
                "Ok", "",
                false);
                frmCaixa.ShowDialog();
            }
        }

        //-----------------Caixa de Texto
        private void tbBuscarProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    int n;
                    bool ehUmNumero = int.TryParse(tbBuscarProduto.Text, out n);
                    if (ehUmNumero == true)
                    {
                        item.ProdutoCor = new ProdutoCor();
                        item.ProdutoCor.Produto = nProduto.BuscarProdutoVendaPorCodigo(n, codVenda);
                        if (item.ProdutoCor.Produto != null)
                        {
                            FrmProdutoCorVenda frmProdutoCor = new FrmProdutoCorVenda(item.ProdutoCor.Produto, codVenda, "Cadastrar");
                            DialogResult resposta;


                            resposta = frmProdutoCor.ShowDialog();

                            if (resposta == DialogResult.Yes)
                            {
                                //Variavel para atualizar VendaTemp codigo = 0
                                varValidaPrimeiraVenda = frmProdutoCor.varValidaPrimeiraVenda;
                                tbBuscarProduto.Clear();
                                metodoIniciaFormulario();
                            }
                            e.Handled = true;
                        }
                        else
                        {
                            pbProduto_Click(null, null);
                            e.Handled = true;
                        }
                    }
                    else
                    {
                        item.ProdutoCor = new ProdutoCor();
                        item.ProdutoCor.Produto = nProduto.BuscarProdutoVendaPorReferencia(tbBuscarProduto.Text, codVenda);
                        if (item.ProdutoCor.Produto != null)
                        {
                            FrmProdutoCorVenda frmProdutoCor = new FrmProdutoCorVenda(item.ProdutoCor.Produto, codVenda, "Cadastrar");
                            DialogResult resposta;


                            resposta = frmProdutoCor.ShowDialog();

                            if (resposta == DialogResult.Yes)
                            {

                                //Variavel para atualizar VendaTemp codigo = 0
                                varValidaPrimeiraVenda = frmProdutoCor.varValidaPrimeiraVenda;
                                tbBuscarProduto.Clear();
                                metodoIniciaFormulario();
                            }
                            e.Handled = true;
                        }
                        else
                        {
                            pbProduto_Click(null, null);
                            e.Handled = true;
                        }
                    }

                    if (dgvItemVenda.RowCount > 0)
                    {
                        this.dgvItemVenda.CurrentRow.Selected = true;
                    }
                    metodoExibeImagemProduto();
                }
            }
            catch (Exception ex)
            {
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro",
                "Erro ao selecionar Produto \r\n" + ex.Message,
                Properties.Resources.DialogErro,
                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                Color.White,
                "Ok", "",
                false);
                frmCaixa.ShowDialog();
            }
        }

        private void tbBuscarProduto_Enter(object sender, EventArgs e)
        {
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

        //-----------------CódigoBarras
        private void cbAtivarBarras_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAtivarBarras.Checked == true)
            {
                metodoBarrasAtivado();
            }
            else
            {
                metodoBarrasDesativado();
            }
        }

        private void pbLancar_Click(object sender, EventArgs e)
        {
            if (codVenda == 0)
            {

                codVenda = nVenda.BuscarItemVendaTempUltimoRegistro() + 1;
                //Variavel para atualizar VendaTemp codigo = 0
                varValidaPrimeiraVenda = true;

            }




            if (tbCodigoBarras.Text == String.Empty || tbQuantidadeBarras.Text == String.Empty || itemCodigoBarras.ProdutoCor == null)
            {
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro Código de Barras",
                "Informe o código de Barras do Produto",
                Properties.Resources.DialogErro,
                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                Color.White,
                "Ok", "",
                false);
                frmCaixa.ShowDialog();
            }
            else
            {
                itemCodigoBarras.Venda = new Venda();
                itemCodigoBarras.Venda.codigoVenda = codVenda;
                itemCodigoBarras.quantidadeVenda = Convert.ToInt32(tbQuantidadeBarras.Text);
                itemCodigoBarras.precoVenda = Convert.ToDouble(mtbPrecoVendaBarras.Text);
                if (itemCodigoBarras.quantidadeVenda <= 0)
                {
                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro Código de Barras",
                    "Informe a quantidade a Adicionar!",
                    Properties.Resources.DialogErro,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Ok", "",
                    false);
                    frmCaixa.ShowDialog();
                }

                if (nItem.CadastrarItemVendaTempBarras(itemCodigoBarras) == true)
                {
                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação Código de Barras",
                    "Produto Adicionado com sucesso!",
                    Properties.Resources.DialogOK,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Ok", "",
                    false);
                    frmCaixa.ShowDialog();

                    metodoBarrasAtivado();
                    metodoIniciaFormulario();
                }
                else
                {
                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro Código de Barras",
                    "Erro ao Adicionar o produto!",
                     Properties.Resources.DialogErro,
                     System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                     Color.White,
                     "Ok", "",
                     false);
                    frmCaixa.ShowDialog();
                }
            }
        }

        private void pbBuscarBarras_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbCodigoBarras.Text == String.Empty)
                {
                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro Código de Barras",
                    "Informe o código de Barras do Produto",
                    Properties.Resources.DialogErro,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Ok", "",
                    false);
                    frmCaixa.ShowDialog();
                }
                else
                {
                    itemCodigoBarras = new ItemVenda();
                    itemCodigoBarras = nItem.BuscarItemVendaTempPorBarras(tbCodigoBarras.Text, codVenda);
                    if (itemCodigoBarras != null)
                    {
                        tbBuscarProduto.Text = itemCodigoBarras.ProdutoCor.Produto.descricaoProduto;
                        mtbPrecoVendaBarras.Text = (itemCodigoBarras.precoVenda * 100).ToString();
                        tbQuantidadeBarras.Minimum = 1;
                        tbQuantidadeBarras.Value = 1;
                        tbQuantidadeBarras.Maximum = itemCodigoBarras.ProdutoCor.Produto.quantidadeProduto;//Quantidade máxima estoque

                    }
                    else
                    {
                        FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro Código de Barras",
                        "Código de Barras não existe!",
                         Properties.Resources.DialogErro,
                         System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                         Color.White,
                         "Ok", "",
                        false);
                        frmCaixa.ShowDialog();

                    }

                }
            }
            catch (Exception)
            {
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro Código de Barras",
               "Código de Barras não existe!",
               Properties.Resources.DialogErro,
               System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
               Color.White,
               "Ok", "",
               false);
                frmCaixa.ShowDialog();

            }
        }

        private void mtbPrecoVendaBarras_TextChanged(object sender, EventArgs e)
        {
            metodos.metodoMoedaMTB(ref mtbPrecoVendaBarras);
        }

        private void tbCodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (itemCodigoBarras.ProdutoCor == null)
                {
                    pbBuscarBarras_Click(null, null);
                    e.Handled = true;
                }
                else
                {
                    pbLancar_Click(null, null);
                    e.Handled = true;
                }
            }
            else if (e.KeyChar == 27)
            {

                metodoBarrasDesativado();
                cbAtivarBarras.Checked = false;
                e.Handled = true;
            }
        }

        //----------------Venda
        private void btCliente_Click(object sender, EventArgs e)
        {
            int n;
            bool ehUmNumero = int.TryParse(tbBuscarCliente.Text, out n);
            if (ehUmNumero == true)
            {
                objVenda.Cliente = nCliente.BuscarClientePorCodigo(n);
                if (objVenda.Cliente != null)
                {
                    this.tbBuscarCliente.Text = objVenda.Cliente.nomeCliente;

                   if(nCrediario.BuscarCrediarioBloqueado(n) == true){
                   FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Aviso - Cliente Bloqueado",
                   "Cliente está Bloqueado!",
                   Properties.Resources.DialogErro,
                   System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                   Color.White,
                   "Ok", "",
                   false);
                   frmCaixaCad.ShowDialog();
                   }
                   else if (nCrediario.BuscarCrediarioVencimento(n) == true) {
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

                    this.objVenda.Cliente = frmSelecionarCliente.clienteSelecionado;
                    this.tbBuscarCliente.Text = objVenda.Cliente.nomeCliente;
                    //----------Voltar o foco para funcionario
                    if (tbFuncionario.Text == "" || tbFuncionario.Text == "Digite o nome do funcionário ...")
                    {
                        tbFuncionario.Focus();
                    }
                }

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
            tbBuscarCliente.Clear();
            pbUsuario.Image = Properties.Resources.ClienteRosa;
            panelBuscarCliente.BackColor = Color.DeepPink;
        }

        private void btFuncionario_Click(object sender, EventArgs e)
        {
            int n;
            bool ehUmNumero = int.TryParse(tbFuncionario.Text, out n);
            if (ehUmNumero == true)
            {
                objVenda.Funcionario = nFuncionario.BuscarFuncionarioPorCodigo(n);
                if (objVenda.Funcionario != null)
                {
                    this.tbFuncionario.Text = objVenda.Funcionario.nomeFuncionario;
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

                    this.objVenda.Funcionario = frmSelecionarFuncionario.FuncionarioSelecionado;
                    this.tbFuncionario.Text = objVenda.Funcionario.nomeFuncionario;
                    cbFormaPagamento.Focus();
                }

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

        private void tbFuncionario_Enter(object sender, EventArgs e)
        {
            tbFuncionario.Clear();
            pbFuncionario.Image = Properties.Resources.FuncionarioRosa;
            panelFuncionario.BackColor = Color.DeepPink;
        }

        //---------------------Botões
        private void btFinalizar_Click(object sender, EventArgs e)
        {   
            try
            {
                if (dgvItemVenda.RowCount > 0)
                {

                    if (metodoValidaVenda() == true)
                    {
                        //ChamaParcial
                        if (objFormaPagamento.formaPagamento == "PARCIAL") { btParcial.PerformClick(); }
                        //ChamaCrediario
                        else if (objFormaPagamento.formaPagamento == "CREDIARIO") { btCrediario.PerformClick(); }
                        //RealizaVenda
                        else
                        {
                            DialogResult resposta;
                            //Criando Caixa de dialogo
                            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Lançamento Venda",
                            " Deseja realmente realizar a Venda ?",
                            Properties.Resources.DialogVenda,
                            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                            Color.White,
                            "Confirmar", "Cancelar",
                            false);

                            //Verifica se o usuário realmente quer alterar os dados do cliente.
                            resposta = frmCaixa.ShowDialog();
                            if (resposta == DialogResult.Yes)
                            {
                                //--------------Criar objVenda
                                Venda objVendaCad = new Venda();
                                objVendaCad.Cliente = objVenda.Cliente;
                                objVendaCad.Funcionario = objVenda.Funcionario;
                                objVendaCad.formaPagamento = objFormaPagamento;
                                objVendaCad.quantidadeVenda = quantidadeTotal;
                                objVendaCad.descontoVenda = Math.Round(valorDesconto, 2);
                                if (cbJuros.Checked == true)
                                {
                                    objVendaCad.jurosVenda = Math.Round(valorJuros, 2);
                                }
                                else { objVendaCad.jurosVenda = Math.Round(-valorJuros, 2); }//Caso haja taxa e a mesma não for adicionada ela computada negativamente
                                objVendaCad.totalVenda = Math.Round(valorBrutoVenda, 2);

                                //--------------Cadastrar Venda
                                if (nVenda.CadastrarVenda(objVendaCad) == true)
                                {
                                    //Busca codigo da Venda Cadastrado
                                    codigoVendaCad = nVenda.BuscarUltimoRegistroVenda();
                                    //Adiciona itens a lista para realizar o cadstro
                                    metodoAddItemLista(codigoVendaCad);
                                    //------------------------------------Cadastra ItemVenda
                                    if (nItem.CadastrarItemVendaLista(listaItemVendaCad) == true)
                                    {
                                        //------------------------------------Exclui dados da tabela ItemVendaTemp
                                        if (nItem.ExcluirItemVendaTempPorVenda(codVenda) == true)
                                        {

                                            //Criando Caixa de dialogo
                                            frmCaixa = new FrmCaixaDialogo("Lançamento Realizado!",
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
                                                //ImprimiComprovante()
                                                //metodoLimpaCampos()
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
                                    FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Erro Cadastrar Venda",
                                    "Erro ao cadastrar Venda!",
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
                }
                //--------------------Captura de Execessão
            }
            catch (Exception ex)
            {
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro",
               "Erro no Venda motivo: \r\n" + ex.Message,
               Properties.Resources.DialogErro,
               System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
               Color.White,
               "Ok", "",
               false);

                frmCaixa.ShowDialog();
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            Boolean validaSelecao = false;//Verifica se o gride tem algum item selecionado para realizar exclusão

            //percorre todas as linhas do gride
            foreach (DataGridViewRow check in dgvItemVenda.Rows)
            {
                //pega valores cheked no gride
                if ((bool)check.Cells[0].FormattedValue)
                {
                    //Código item Entrada 
                    int codigoItem = int.Parse(check.Cells[1].Value.ToString());
                    validaSelecao = true;

                    if (nItem.ExcluirItemVendaTempPorCodigo(codigoItem) == false)
                    {
                        FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro - Exclusão",
                        "Descrição :" + check.Cells[2].Value.ToString() + " " + check.Cells[4].Value.ToString()
                        + "\r\n Referência :" + check.Cells[5].Value.ToString()
                        + "\r\n Não foi possível excluir!",
                        Properties.Resources.DialogErro,
                        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                        Color.White,
                        "Ok", "",
                        true);

                        //Se usuário desejar realizar exclusão da entrada de estoque
                        frmCaixa.ShowDialog();
                    }
                }
            }

            //---Atualiza o gride--\\
            metodoIniciaFormulario();

            //Se a tabela não triver itens pergunta para o usuário se ele deseja excluir a entrada de estoque
            if (dgvItemVenda.Rows.Count > 0 && validaSelecao == false)
            {
                DialogResult resposta;
                //Criando Caixa de dialogo
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação - Exclusão",
                "Deseja realizar a exclusão dos Itens da Venda? \r\n",
                Properties.Resources.DialogExcluir,
                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                Color.White,
                "Sim", "Não",
                false);

                //Se usuário desejar realizar exclusão da entrada de estoque
                resposta = frmCaixa.ShowDialog();
                if (resposta == DialogResult.Yes)
                {
                    foreach (DataGridViewRow dtr in dgvItemVenda.Rows)
                    {
                        ((DataGridViewCheckBoxCell)dtr.Cells[0]).Value = true;
                    }

                    btExcluir.PerformClick();

                }
            }
            if (dgvItemVenda.Rows.Count == 0)
            {
                metodoCalculaTotais();
                pbImagemProduto.Image = global::Apresentacao.Properties.Resources.imgDefaut;
            }

            metodoCalculaTotais();
        }

        private void btParcial_Click(object sender, EventArgs e)
        {
            try
            {
                if (metodoValidaParcial() == true)
                {

                    if (dgvItemVenda.RowCount > 0)
                    {
                        DialogResult resposta;
                        //Criando Caixa de dialogo
                        FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Parcial",
                        " Deseja realizar pagamento Parcial?",
                        Properties.Resources.DialogParcial,
                        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                        Color.White,
                        "Sim", "Não",
                        false);

                        resposta = frmCaixa.ShowDialog();
                        if (resposta == DialogResult.Yes)
                        {
                            objVenda.formaPagamento = nFormaPagamento.BuscarFormaPagamentoPorTipo("Parcial");

                            if (objVenda.formaPagamento == null)
                            {

                                frmCaixa = new FrmCaixaDialogo("Erro ao selecionar parcial!",
                                " Forma de pagamento parcial não existe deseja realizar o cadastro?",
                                Properties.Resources.dialogGerarValores,
                                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                Color.White,
                                "Sim", "Não",
                                false);
                                resposta = frmCaixa.ShowDialog();

                                if (resposta == DialogResult.Yes)
                                {
                                    FrmSelecionarFormaPagamento frmPagamento = new FrmSelecionarFormaPagamento("Parcial");
                                    frmPagamento.ShowDialog();

                                }

                            }
                            else
                            {
                                objVenda.codigoVenda = codVenda;
                                objVenda.quantidadeVenda = listaItems.Sum(x => x.quantidadeVenda);
                                objVenda.totalVenda = valorBrutoVenda;

                                FrmParcialVenda frmParcialVenda = new FrmParcialVenda(objVenda, listaItems);
                                DialogResult retornoParcial = frmParcialVenda.ShowDialog();
                                if (retornoParcial == DialogResult.Yes)
                                {

                                    metodoIniciaFormulario();
                                    DialogResult = DialogResult.Yes;
                                }
                            }
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

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair da Venda?",
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

        private void btCrediario_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvItemVenda.RowCount > 0)
                {

                    if (metodoValidaParcial() == true)
                    {
                        DialogResult resposta;
                        //Criando Caixa de dialogo
                        FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Lançamento Crediario",
                        "Deseja realizar lançamento no Crediario?",
                        Properties.Resources.Crediario,
                        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                        Color.White,
                        "Confirmar", "Cancelar",
                        false);

                        //Verifica se o usuário realmente quer alterar os dados do cliente.
                        resposta = frmCaixa.ShowDialog();
                        
                        if (resposta == DialogResult.Yes)
                        {
                            //--------------Criar Forma de Pagamento
                            objVenda.formaPagamento = nFormaPagamento.BuscarFormaPagamentoPorTipo("Crediario");

                            if (objVenda.formaPagamento == null)
                            {

                                frmCaixa = new FrmCaixaDialogo("Erro ao selecionar crediario!",
                                " Forma de pagamento Crediario não existe deseja realizar o cadastro?",
                                Properties.Resources.dialogGerarValores,
                                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                Color.White,
                                "Sim", "Não",
                                false);
                                resposta = frmCaixa.ShowDialog();

                                if (resposta == DialogResult.Yes)
                                {
                                    FrmSelecionarFormaPagamento frmPagamento = new FrmSelecionarFormaPagamento("Crediario");
                                    frmPagamento.ShowDialog();

                                }

                            }
                            else
                            {
                                //------------ Informa o vencimento 
                                DialogResult opcaoVencimento;
                                FrmSelecionarVencimentoCrediario frmVencimento = new FrmSelecionarVencimentoCrediario(DateTime.Now, DateTime.Now);
                                opcaoVencimento = frmVencimento.ShowDialog();
                                //Se sim formulario retorna o vencimento 
                                if (opcaoVencimento == DialogResult.Yes)
                                {

                                    //-----------------Cria objeto Venda
                                    Venda objVendaCad = new Venda();

                                    objVendaCad.Cliente = objVenda.Cliente;
                                    objVendaCad.Funcionario = objVenda.Funcionario;
                                    objVendaCad.formaPagamento = objVenda.formaPagamento;
                                    objVendaCad.quantidadeVenda = quantidadeTotal;
                                    objVendaCad.descontoVenda = Math.Round(valorDesconto, 2);
                                    objVendaCad.jurosVenda = Math.Round(valorJuros, 2);
                                    objVendaCad.totalVenda = Math.Round(valorBrutoVenda, 2);

                                    //--------------Cadastrar Venda
                                    if (nVenda.CadastrarVenda(objVendaCad) == true)
                                    {
                                        //Busca codigo da Venda Cadastrado
                                        objVendaCad.codigoVenda = nVenda.BuscarUltimoRegistroVenda();

                                        //Adiciona itens a lista para realizar o cadstro
                                        metodoAddItemListaCrediario(objVendaCad, frmVencimento.dataVencimento);
                                        //------------------------------------Cadastra ItemVenda
                                        if (nItemCrediario.CadastrarItemCrediarioLista(listaItemCrediario) == true)
                                        {
                                            //------------------------------------Exclui dados da tabela ItemVendaTemp
                                            if (nItem.ExcluirItemVendaTempPorVenda(codVenda) == true)
                                            {

                                                //Criando Caixa de dialogo
                                                frmCaixa = new FrmCaixaDialogo("Lançamento Realizado!",
                                                "Crediario lançado com sucesso !\r\n" +
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
                                                    //ImprimiComprovante()
                                                    //metodoLimpaCampos()
                                                }
                                                else
                                                {
                                                    //metodoLimpaCampos()
                                                    this.DialogResult = DialogResult.Yes;
                                                }
                                            }
                                            else
                                            {
                                                FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Erro Excluir Item Crediario",
                                                "Erro ao excluir tabela Item Venda/Crediario Temp!",
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
                                            FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Erro Cadastrar Item Crediario",
                                            "Erro ao cadastrar Item Crediario!",
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
                                        FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Erro Cadastrar Venda",
                                        "Erro ao cadastrar Venda Crediario!",
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
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        //---------------------Menus
        private void pbCrediario_Click(object sender, EventArgs e)
        {
            FrmCrediario frmCrediario = new FrmCrediario();
            frmCrediario.ShowDialog();
        }

        private void pbParcial_Click(object sender, EventArgs e)
        {
            FrmSelecionarParcialVenda frmparcial = new FrmSelecionarParcialVenda();
            frmparcial.ShowDialog();
        }

        private void pbEstoque_Click(object sender, EventArgs e)
        {
            FrmEstoque frmEstoque = new FrmEstoque();
            frmEstoque.ShowDialog();
        }

        //--------------------Valores da Venda
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

        private void FrmVenda_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        //----------------------Forma Pagamento
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

        private void pbFormaPagamento_Click(object sender, EventArgs e)
        {
            FrmSelecionarFormaPagamento frmSelecionarPagamento = new FrmSelecionarFormaPagamento("");
            frmSelecionarPagamento.ShowDialog();
        }

        private void cbFormaPagamento_DropDown(object sender, EventArgs e)
        {
            try
            {

                cbFormaPagamento.Items.Clear();
                this.listaFormaPagamento = nFormaPagamento.BuscarFormaPagamentoPorNome("");

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
                if (cbFormaPagamento.Text == "")
                {
                    lbTaxaJuros.Text = "0,00";
                    lbTaxa.Text = "R$ 0,00";
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void cbJuros_CheckedChanged(object sender, EventArgs e)
        {
            if (cbJuros.Checked == false)
            {
                //lbTaxaJuros.Text = "0,00";
                //lbTaxa.Text = "R$ 0,00";
                //lbJurosVenda.Text = "%R$ 0,00";
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

        //----------------------Formuário
        private void FrmVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F5) == true)
            {
                metodoIniciaFormulario();
            }
            if (e.KeyCode.Equals(Keys.F10) == true)
            {
                btFinalizar.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F2) == true)
            {
                btExcluir.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F12) == true)
            {
                btParcial.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F4) == true)
            {
                btCrediario.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {
                btSair.PerformClick();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            FrmCancelamento frmCancelamento = new FrmCancelamento("ItemVenda");
            frmCancelamento.ShowDialog();

        }

 }

}