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
    public partial class FrmItemEntrada : Form
    {
        TextBox caixaTextoGride;

        int codEntradaEstoque;//Codigo Entrada de Estoque
        ItemEntradaLista itemLista = new ItemEntradaLista();
        ProdutoCor produtoCorCorrente = new ProdutoCor();

        NegItemEntrada nItem = new NegItemEntrada();
        Formulas.Metodos metodos = new Formulas.Metodos();

        public FrmItemEntrada(ProdutoCor produtoCor, int codigoEntradaEstoque)
        {
            InitializeComponent();

            produtoCorCorrente = produtoCor;
            codEntradaEstoque = codigoEntradaEstoque;
        }

        //atualiza os valores no Data Grid
        private void AtualizarDataGrid()
        {
            this.dgvTamnhoItem.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.itemLista.Count > 0)
            {
                this.dgvTamnhoItem.Rows.Add(this.itemLista.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (ItemEntrada item in this.itemLista)
            {
                this.dgvTamnhoItem[0, indice].Value = item.codigoItemEntrada;
                this.dgvTamnhoItem[1, indice].Value = item.ProdutoCor.Cor.nomeCor;
                this.dgvTamnhoItem[2, indice].Value = item.Tamanho.codigoTamanho;
                this.dgvTamnhoItem[3, indice].Value = item.Tamanho.nometamanho;
                this.dgvTamnhoItem[4, indice].Value = item.quantidadeItem;
                this.dgvTamnhoItem[5, indice].Value = item.ProdutoCor.Produto.quantidadeProduto;
                this.dgvTamnhoItem[6, indice].Value = item.precoCustoItem;
                this.dgvTamnhoItem[7, indice].Value = item.precoVendaItem;
                this.dgvTamnhoItem[8, indice].Value = item.codigoBarrasItem;
                this.dgvTamnhoItem[9, indice].Value = item.ProdutoCor.ImagemProduto;
                this.dgvTamnhoItem[10, indice].Value = indice;
                indice++;
            }

            dgvTamnhoItem.Update();

        }

        //Junta os dados da lista 
        public void metodoBuscaDados() {
            ItemEntradaLista itemListaNova = new ItemEntradaLista();
            ItemEntradaLista itemListaTemp = new ItemEntradaLista();
            itemLista = new ItemEntradaLista();

            itemListaNova = nItem.BuscarTamanhoItemEntrada(produtoCorCorrente.codigoProdutoCor, codEntradaEstoque);
            itemListaTemp = nItem.BuscarItemEntradaTemp(produtoCorCorrente.codigoProdutoCor);


            if (itemListaNova.Count > 0)
            {
                int contador = 0;
                foreach (ItemEntrada itemnovo in itemListaTemp)
                {

                    if (itemListaNova[contador].Tamanho.codigoTamanho == itemnovo.Tamanho.codigoTamanho)
                    {
                        itemLista.Add(itemListaNova[contador]);
                        if (contador + 1 < itemListaNova.Count)
                        {
                            contador++;
                        }
                    }
                    else
                    {
                        itemLista.Add(itemnovo);
                    }
                }
            }
            else
            {
                itemLista = itemListaTemp;

            }              
        }

        //---------------------------Metodos
        public void metodoIniciaFormulario() {
            tbProduto.Text = " " + produtoCorCorrente.Produto.codigoProduto.ToString()+
            " "+produtoCorCorrente.Produto.descricaoProduto+
            " "+produtoCorCorrente.Cor.nomeCor;

            mtbCusto.Text = (produtoCorCorrente.Produto.precoCustoProduto*100).ToString();
            mtbVenda.Text = (produtoCorCorrente.Produto.precoVendaProduto*100).ToString();

            //Buscal Local que a Solution Está sendo Executada no Computador
           string LocalSolution = Environment.CurrentDirectory;
            // This will get the current PROJECT directory
            LocalSolution = Directory.GetParent(LocalSolution).Parent.Parent.FullName;

            String imgProduto = produtoCorCorrente.ImagemProduto;
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

            metodoBuscaDados();
            AtualizarDataGrid();

        }

        //-----------Valida se gride foi preenchido com as quantidades
        public Boolean metodoValida(ItemEntradaLista lista){
        
        if(lista.Count > 0){
        
        int quantidade = 0;
        foreach (ItemEntrada item in lista) {
        
        quantidade = item.quantidadeItem + quantidade;

        }
            if(quantidade != 0){
            
            return true;

            }else return false;

        }else
            return false;
        }

        private void FrmItemEntrada_Load(object sender, EventArgs e)
        {
            metodoIniciaFormulario();
        }

        //-------------Caixa de Texto
        private void mtbCusto_TextChanged(object sender, EventArgs e)
        {
            metodos.metodoMoedaMTB(ref mtbCusto);
        }

        private void mtbVenda_TextChanged(object sender, EventArgs e)
        {
            metodos.metodoMoedaMTB(ref mtbVenda);
        }

        private void mtbCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbPrecos_Click(null, null);
                e.Handled = true;
                mtbVenda.Focus();
            }

        }

        private void mtbVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbPrecos_Click(null, null);
                e.Handled = true;
                dgvTamnhoItem.Focus();
            }

        }

        //----------------DataGrideValidações
        private void dgvTamnhoItem_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                //Quantidade
                if (dgvTamnhoItem.Columns[e.ColumnIndex].Name == "quantidadeItem")
                {
                    dgvTamnhoItem.Rows[e.RowIndex].ErrorText = "";
                    int newInteger;

                    if (dgvTamnhoItem.Rows[e.RowIndex].IsNewRow) { return; }
                    if (!int.TryParse(e.FormattedValue.ToString(),
                        out newInteger) || newInteger < 0)
                    {
                        e.Cancel = true;
                        dgvTamnhoItem.Rows[e.RowIndex].ErrorText = "Informe a Quantidade Corretamente";
                    }
                    //Quantidade não pode ser menor que quantidade no Estoque 
                    //Pegando valores no gride e na lista 
                    int quantidadeNova = Convert.ToInt32(e.FormattedValue.ToString());
                    int quantidadeMemoria = itemLista[Convert.ToInt32(dgvTamnhoItem.CurrentRow.Cells[10].Value)].quantidadeItem;
                    int quantidadeEstoque = itemLista[Convert.ToInt32(dgvTamnhoItem.CurrentRow.Cells[10].Value)].ProdutoCor.Produto.quantidadeProduto;
                    if (((quantidadeNova - quantidadeMemoria) + quantidadeEstoque) < 0)
                    {

                        e.Cancel = true;
                        dgvTamnhoItem.Rows[e.RowIndex].ErrorText = "Quantidade insuficiente. Estoque mínimo: " + (quantidadeMemoria - quantidadeEstoque).ToString();
                    }

                }
                //Custo
                if (dgvTamnhoItem.Columns[e.ColumnIndex].Name == "precoCusto")
                {
                    dgvTamnhoItem.Rows[e.RowIndex].ErrorText = "";
                    double newDouble;

                    if (dgvTamnhoItem.Rows[e.RowIndex].IsNewRow) { return; }
                    if (!double.TryParse(e.FormattedValue.ToString(),
                        out newDouble) || newDouble < 0)
                    {
                        e.Cancel = true;
                        dgvTamnhoItem.Rows[e.RowIndex].ErrorText = "Informe o preço de Custo Corretamente";
                    }

                }
                //Venda
                if (dgvTamnhoItem.Columns[e.ColumnIndex].Name == "precoVenda")
                {
                    dgvTamnhoItem.Rows[e.RowIndex].ErrorText = "";
                    double newDouble;

                    if (dgvTamnhoItem.Rows[e.RowIndex].IsNewRow) { return; }
                    if (!double.TryParse(e.FormattedValue.ToString(),
                        out newDouble) || newDouble < 0)
                    {
                        e.Cancel = true;
                        dgvTamnhoItem.Rows[e.RowIndex].ErrorText = "Informe o preço de Venda Corretamente";
                    }

                }

                //Código Barras
                if (dgvTamnhoItem.Columns[e.ColumnIndex].Name == "codigoBarras")
                {
                    dgvTamnhoItem.Rows[e.RowIndex].ErrorText = "";
                    //Correção do Erro
                    if (dgvTamnhoItem.CurrentRow.Cells[8].Value == null) {
                        dgvTamnhoItem.CurrentRow.Cells[8].Value = "";
                    }

                    //Verifica Se o item Já existe na memória
                    if (e.FormattedValue.ToString() != itemLista[Convert.ToInt32(dgvTamnhoItem.CurrentRow.Cells[10].Value)].codigoBarrasItem.ToString())
                    {
                    //Verifica Se o item oferecido e diferente do valor digitado
                    if (e.FormattedValue.ToString() != "" && e.FormattedValue.ToString() != dgvTamnhoItem.CurrentRow.Cells[8].Value.ToString())
                    {

                        ProdutoCor produtoCorValida = new ProdutoCor();
                        produtoCorValida = nItem.ValidarCodigoBarras(e.FormattedValue.ToString());

                        if (produtoCorValida != null)
                        {
                            e.Cancel = true;
                            dgvTamnhoItem.Rows[e.RowIndex].ErrorText =
                                "Barras já existe"
                                + " Cód:" + produtoCorValida.Produto.codigoProduto.ToString()
                                + " Ref:" + produtoCorValida.Produto.descricaoProduto
                                + " Cor:" + produtoCorValida.Cor.nomeCor;

                            DialogResult resposta;
                            //Criando Caixa de dialogo
                            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Código de Barras Existente",
                            " Deseja realmente alterar o Código de Barras do Produto ?",
                            Properties.Resources.DialogQuestion,
                            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                            Color.White,
                            "Sim", "Não",
                            false);

                            resposta = frmCaixa.ShowDialog();
                            if (resposta == DialogResult.Yes)
                            {
                                if (nItem.AtualizarCodigoBarrasItem(produtoCorValida.codigoProdutoCor,produtoCorValida.Cor.codigoCor, "") == true)//codigo da cor e codigo do tamanho
                                {
                                    
                                    if (nItem.AtualizarCodigoBarrasItem(produtoCorCorrente.codigoProdutoCor,Convert.ToInt32(dgvTamnhoItem.CurrentRow.Cells[2].Value), e.FormattedValue.ToString()) == true)
                                    {
                                        //Adiciona novo valor ao a lista
                                        itemLista[Convert.ToInt32(dgvTamnhoItem.CurrentRow.Cells[10].Value)].codigoBarrasItem = e.FormattedValue.ToString();                  
                                        //Se o codigo de barras alterado estiver no mesmo produto em tamnho diferente o código antigo é apagado
                                       foreach (DataGridViewRow row in dgvTamnhoItem.Rows)
                                        {

                                            if (e.FormattedValue.ToString() == row.Cells[8].Value.ToString() && e.FormattedValue.ToString() != dgvTamnhoItem.CurrentRow.Cells[8].Value.ToString())
                                            {
                                                
                                                dgvTamnhoItem.Rows[row.Index].Cells[8].Value = "";
                                                itemLista[row.Index].codigoBarrasItem = ""; 
                                            }

                                        }
                                    }
                                    else
                                    {
                                        frmCaixa = new FrmCaixaDialogo("Erro",
                                        "Erro ao Cadastrar novo Código de Barras",
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
                                    frmCaixa = new FrmCaixaDialogo("Erro",
                                    "Erro ao Remover antigo Código de Barras",
                                    Properties.Resources.DialogErro,
                                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                    Color.White,
                                    "Ok", "",
                                    false);
                                    frmCaixa.ShowDialog();                  
                                }
                            }
                        }
                            //Verifica se usuário repetiu o código de barras
                        else
                        {
                            foreach (DataGridViewRow row in dgvTamnhoItem.Rows)
                            {

                                if (e.FormattedValue.ToString() == row.Cells[8].Value.ToString() && e.FormattedValue.ToString() != dgvTamnhoItem.CurrentRow.Cells[8].Value.ToString())
                                {

                                    e.Cancel = true;
                                    dgvTamnhoItem.Rows[e.RowIndex].ErrorText = "Barras já existe";

                                }
                            }
                        }
                    }
                }
              }

            } catch(Exception ex){
                     FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro Validação",
                     "Erro no DataGride Validação: \r\n" + ex.Message,
                     Properties.Resources.DialogErro,
                     System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                     Color.White,
                     "Ok", "",
                     false);
                     frmCaixa.ShowDialog();
            }

        }

        //-------------------Botões
        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair da Alteração & Exclusão do Produto ?",
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

        private void pbPrecos_Click(object sender, EventArgs e)
        {
            int contador = 0;
            foreach (DataGridViewRow row in dgvTamnhoItem.Rows)
            {
                dgvTamnhoItem.Rows[contador].Cells[6].Value = Convert.ToDouble(mtbCusto.Text);
                dgvTamnhoItem.Rows[contador].Cells[7].Value = Convert.ToDouble(mtbVenda.Text);
                contador++;
            }
        }

        private void btDesfazer_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Desfazer",
            " Deseja realmente desfazer alterações ?",
            Properties.Resources.DialogProcessando,
            Color.White,
            Color.Black,
            "Confirmar", "Cancelar",
            false);

            resposta = frmCaixa.ShowDialog();
            if (resposta == DialogResult.Yes)
            {

                AtualizarDataGrid();
            }
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
              try
                {
                  //Percorre o gride para adicionar itens
                  ItemEntradaLista itemListaAlterar = new ItemEntradaLista();
                  ItemEntradaLista itemListaExcluir = new ItemEntradaLista();
                  
                  //---------Liberar o lançamento do Formulário caso o mesmo tinha itens antriormente e os mesmos foram 0zerados
                  Boolean validaLancamento = false;

                    foreach (DataGridViewRow row in dgvTamnhoItem.Rows)
                    {
                        ItemEntrada item = new ItemEntrada();
                        item.EntradaEstoque = new EntradaEstoque();
                        item.ProdutoCor = new ProdutoCor();
                        item.Tamanho = new Tamanho();

                        item.EntradaEstoque.codigoEntradaEstoque = codEntradaEstoque;
                        item.ProdutoCor = produtoCorCorrente;
                        item.Tamanho.codigoTamanho = Convert.ToInt32(row.Cells[2].Value);
                        item.quantidadeItem =Convert.ToInt32(row.Cells[4].Value);
                        item.precoCustoItem = Convert.ToDouble(row.Cells[6].Value);
                        item.precoVendaItem = Convert.ToDouble(row.Cells[7].Value);
                        item.codigoBarrasItem = row.Cells[8].Value.ToString();
                        //-----------Adiciona itens com quantidades na lista para o cadastro ou alteração
                        if (item.quantidadeItem > 0 || itemLista[Convert.ToInt32(row.Cells[10].Value)].quantidadeItem > 0)//EstoqueNovo ou EstoqueAntigo > 0
                        {
                            //---------Itens para ser Alterados
                            itemListaAlterar.Add(item);
                            validaLancamento = true;
                        }
                       //------------Entrada de Estoque existe 
                       if(Convert.ToInt32(row.Cells[0].Value) != 0 && item.quantidadeItem ==  0 ){
                           //--------Adiciona itens para serem excluidos
                           item.codigoItemEntrada = Convert.ToInt32(row.Cells[0].Value);
                           itemListaExcluir.Add(item);
                         }
                      }

                  //------------------Valida se Gride Está preenchido
                  if(metodoValida(itemLista) == true || validaLancamento == true){

                    if (nItem.CadastrarItemEntradaLista(itemListaAlterar) == true)
                    {               
                        //--------------Limpar itens que não tem entrada
                        if (itemListaExcluir.Count > 0)
                        {
                            if (nItem.ExcluirItemEntrada(itemListaExcluir) != true)
                            {
                                MessageBox.Show("Erro ao Zerar Produto!", "Erro Exclusão",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                dgvTamnhoItem.Focus();
                                return;
                            }
                        }                       

                        DialogResult resposta;
                        //Criando Caixa de dialogo
                        FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
                        "Lançamento Realizado com Sucesso! \r\n",
                        Properties.Resources.DialogOK,
                        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                        Color.White,
                        "Sim","",
                        false);

                        resposta = frmCaixa.ShowDialog();
                        if (resposta != DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.Yes;
                            this.Close();

                        }
                        else
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao lançar Produtos!", "Erro Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dgvTamnhoItem.Focus();
                        return;
                    }
                  }
                   else{
                  
                         MessageBox.Show("Não existe Quantidades para realizar o lançamento!"
                             , "Erro Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dgvTamnhoItem.Focus();
                        return;
                  
                  }
                }

                catch (Exception ex)
                {
                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro",
                    "Erro ao lançar Itens \r\n" + ex.Message,
                    Properties.Resources.DialogErro,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Ok", "",
                    false);
                    frmCaixa.ShowDialog();
                }
            }

        private void btZerar_Click(object sender, EventArgs e)
        {
            //Verificar se é possivel zerar ou apenas deixar estoque minímo se for o caso

            int contador = 0;
            foreach (DataGridViewRow row in dgvTamnhoItem.Rows)
            {
                int quantidade = Convert.ToInt32(row.Cells[4].Value);
                int estoque = Convert.ToInt32(row.Cells[5].Value);

                if (quantidade <= estoque)
                {
                    dgvTamnhoItem.Rows[contador].Cells[4].Value = "0";
                }
                else {

                    dgvTamnhoItem.Rows[contador].Cells[4].Value = (quantidade - estoque).ToString();
                }
            contador++;
            }
        }    

        //-------------------------Teclas de Atalho
        private void FrmItemEntrada_KeyDown(object sender, KeyEventArgs e)
        {
            //atalho da tecla de atalho ESC
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {
                btSair.PerformClick();
            }
            //atalho para o botão cadastrar
            else if (e.KeyCode.Equals(Keys.F10) == true)
            {
                btSelecionar.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.F5) == true)
            {
                btDesfazer.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.F2) == true)
            {
                btZerar.PerformClick();
            }
        }

        private void FrmItemEntrada_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void dgvTamnhoItem_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {


            //-----------Adiciona o formato apenas na caixa de texto 
            if (dgvTamnhoItem.CurrentCell.ColumnIndex == 4 || dgvTamnhoItem.CurrentCell.ColumnIndex == 8)
            {
                caixaTextoGride = new TextBox();

            }
            else
            {
                caixaTextoGride = e.Control as TextBox;
                caixaTextoGride.TextChanged -= new EventHandler(caixaTextoGride_TextChanged);
                caixaTextoGride.TextChanged += caixaTextoGride_TextChanged;

            }
        }

        //Evento TextoChanged do Gride
        private void caixaTextoGride_TextChanged(object sender, EventArgs e)
        {
            metodos.metodoMoedaTB(ref caixaTextoGride);
        }

    }
}
