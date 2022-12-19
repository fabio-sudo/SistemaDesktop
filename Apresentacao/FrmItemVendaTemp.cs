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
    public partial class FrmItemVendaTemp : Form
    {
        TextBox caixaTextoGride;

        int codVenda;//Codigo Entrada de Estoque
        ItemVendaLista itemLista = new ItemVendaLista();
        ProdutoCor produtoCorCorrente = new ProdutoCor();

        NegItemVenda nItem = new NegItemVenda();
        NegVenda nVenda = new NegVenda();
        Formulas.Metodos metodos = new Formulas.Metodos();

        //Essa variavel passa por todas a telas Para realizar incremento do ITEMVENDATEMP
        public Boolean varValidaPrimeiraVenda = false;


        public FrmItemVendaTemp(ProdutoCor produtoCor, int codigoVenda)
        {
            InitializeComponent();

            produtoCorCorrente = produtoCor;
            codVenda = codigoVenda;
        }

        //------------------------------------Métodos
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
            foreach (ItemVenda item in this.itemLista)
            {
                this.dgvTamnhoItem[0, indice].Value = item.codigoItemVenda;
                this.dgvTamnhoItem[1, indice].Value = item.ProdutoCor.Cor.nomeCor;
                this.dgvTamnhoItem[2, indice].Value = item.Tamanho.codigoTamanho;
                this.dgvTamnhoItem[3, indice].Value = item.Tamanho.nometamanho;
                this.dgvTamnhoItem[4, indice].Value = item.quantidadeVenda;
                //Estoque + Quantidade que foi retirada do mesmo Para os valores possam ser atualizados
                this.dgvTamnhoItem[5, indice].Value = item.ProdutoCor.Produto.quantidadeProduto + item.quantidadeVenda;
                this.dgvTamnhoItem[6, indice].Value = item.precoCusto;
                this.dgvTamnhoItem[7, indice].Value = item.precoVenda;
                this.dgvTamnhoItem[8, indice].Value = item.codigoBarrasItem;
                this.dgvTamnhoItem[9, indice].Value = item.ProdutoCor.ImagemProduto;
                this.dgvTamnhoItem[10, indice].Value = indice;

                indice++;
            }

            dgvTamnhoItem.Update();

        }

        //Junta os dados da lista 
       public void metodoBuscaDados()
        {
            ItemVendaLista itemListaNova = new ItemVendaLista();
            ItemVendaLista itemListaTemp = new ItemVendaLista();
            itemLista = new ItemVendaLista();

            //Busca itemEntradaTemp de acordo com os tamanhos salvos
            itemListaNova = nItem.BuscarTamanhoItemVendaTemp(produtoCorCorrente.codigoProdutoCor, codVenda);
            itemListaTemp = nItem.BuscarItemVendaTempPorProduto(produtoCorCorrente.codigoProdutoCor);
            //Busca quantidade de items Com estoque e caracteristica para realizar lançamento

            if (itemListaNova.Count > 0)
            {
                int contador = 0;
                foreach (ItemVenda itemnovo in itemListaTemp)
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

        //Inicia os dados do formulário
        public void metodoIniciaFormulario()
        {
            tbProduto.Text = " " + produtoCorCorrente.Produto.codigoProduto.ToString() +
            " " + produtoCorCorrente.Produto.descricaoProduto +
            " " + produtoCorCorrente.Cor.nomeCor;

            mtbCusto.Text = (produtoCorCorrente.Produto.precoCustoProduto * 100).ToString();
            mtbVenda.Text = (produtoCorCorrente.Produto.precoVendaProduto * 100).ToString();

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

        //Valida se gride foi preenchido com as quantidades
        public Boolean metodoValida(ItemVendaLista lista)
        {

            if (lista.Count > 0)
            {

                int quantidade = 0;
                foreach (ItemVenda item in lista)
                {

                    quantidade = item.quantidadeVenda + quantidade;

                }
                if (quantidade != 0)
                {

                    return true;
                }
                else return false;

            }
            else
                return false;
        }

        //-------------------------DataGride
        private void FrmItemVendaTemp_Load(object sender, EventArgs e)
        {

            metodoIniciaFormulario();
        }

        private void dgvTamnhoItem_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                //Quantidade -> Não pode  ser maior que a quantidade de Estoque
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
                  //Pegando valores no gride e na lista 
                  int quantidadeNova = Convert.ToInt32(e.FormattedValue.ToString());//Quantidade inserida
                  //int quantidadeMemoria = itemLista[Convert.ToInt32(dgvTamnhoItem.CurrentRow.Cells[10].Value)].quantidadeVenda;//Quantidade que já estava inserida
                  int quantidadeEstoque = Convert.ToInt32(dgvTamnhoItem.CurrentRow.Cells[5].Value);//Estoque
                  //Quantidade nova for mairo que quantidade no estoque
                  if ((quantidadeNova > quantidadeEstoque))
                  {
                      //Quantidade antiga será acrescentada ao Estoque AtualizaDataGrid(quantidadeMemoria+Estoque)
                      e.Cancel = true;
                      dgvTamnhoItem.Rows[e.RowIndex].ErrorText = "Quantidade insuficiente. Estoque mínimo: " + (quantidadeEstoque).ToString();
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

            }
            catch (Exception ex)
            {
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

        //----------------------Botões
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

        private void btLimpar_Click(object sender, EventArgs e)
        {
            int contador = 0;
            foreach (DataGridViewRow row in dgvTamnhoItem.Rows)
            {
                dgvTamnhoItem.Rows[contador].Cells[4].Value = 0;
                contador++;
            }
        }

        private void btLancar_Click(object sender, EventArgs e)
        {
            try
            {
                //Se o código da venda for 0 o mesmo é atualizado para realização do cadastro
                //Só executa na primeira venda
                
                if (codVenda == 0) {

                    codVenda = nVenda.BuscarItemVendaTempUltimoRegistro() + 1;
                    //Variavel para atualizar VendaTemp codigo = 0
                    varValidaPrimeiraVenda = true;

                }

                //Percorre o gride para adicionar itens
                ItemVendaLista itemLista = new ItemVendaLista();
                //---------Liberar o lançamento do Formulário caso o mesmo tinha itens antriormente e os mesmos foram 0zerados
                Boolean validaLancamento = false;

                foreach (DataGridViewRow row in dgvTamnhoItem.Rows)
                {
                    ItemVenda item = new ItemVenda();
                    item.Venda = new Venda();
                    item.ProdutoCor = new ProdutoCor();
                    item.Tamanho = new Tamanho();

                    item.Venda.codigoVenda = codVenda;
                    item.ProdutoCor = produtoCorCorrente;
                    item.Tamanho.codigoTamanho = Convert.ToInt32(row.Cells[2].Value);
                    item.quantidadeVenda = Convert.ToInt32(row.Cells[4].Value);
                    item.precoCusto = Convert.ToDouble(row.Cells[6].Value);
                    item.precoVenda = Convert.ToDouble(row.Cells[7].Value);
                    //-----------Adiciona itens com quantidades na lista para o cadastro ou alteração
                    if (item.quantidadeVenda > 0)
                    {
                        itemLista.Add(item);
                    }
                    //------------Exclui itens ja cadastrados quando suas quantidades são zeradas 
                    else if (Convert.ToInt32(row.Cells[0].Value) != 0 && item.quantidadeVenda == 0)
                    {
                        //-----------Exclui item entrada para não ocupar espaço no banco de dados
                        if (nItem.ExcluirItemVendaTemp(Convert.ToInt32(row.Cells[0].Value)) != true)
                        {
                            MessageBox.Show("Erro ao Zerar Produto!", "Erro Exclusão",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dgvTamnhoItem.Focus();
                            return;
                        }
                        //-----------Formulário Já tinha itens
                        else { validaLancamento = true; }
                    }
                }
                //------------------Valida se Gride Está preenchido
                if (metodoValida(itemLista) == true || validaLancamento == true)
                {
                    if (nItem.CadastrarItemVendaListaTemp(itemLista) == true)
                    {
                        DialogResult resposta;
                        //Criando Caixa de dialogo
                        FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
                        "Lançamento Realizado com Sucesso! \r\n",
                        Properties.Resources.DialogOK,
                        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                        Color.White,
                        "Sim", "",
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
                else
                {

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

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair do Lançamento de Produto ?",
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

        //---------------------Caixa de Texto
        private void mtbVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbPrecos_Click(null, null);
                e.Handled = true;
                dgvTamnhoItem.Focus();
            }
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

        private void mtbCusto_TextChanged(object sender, EventArgs e)
        {
            metodos.metodoMoedaMTB(ref mtbCusto);
        }

        private void mtbVenda_TextChanged(object sender, EventArgs e)
        {
            metodos.metodoMoedaMTB(ref mtbVenda);
        }

        //----------------------Formulário
        private void FrmItemVendaTemp_KeyDown(object sender, KeyEventArgs e)
        {
            //atalho da tecla de atalho ESC
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {
                btSair.PerformClick();
            }
            //atalho para o botão cadastrar
            else if (e.KeyCode.Equals(Keys.F10) == true)
            {
                btLancar.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.F5) == true)
            {
                btDesfazer.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.F2) == true)
            {
                btLimpar.PerformClick();
            }
        }

        private void FrmItemVendaTemp_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void dgvTamnhoItem_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //-----------Adiciona o formato apenas na caixa de texto 
            if (dgvTamnhoItem.CurrentCell.ColumnIndex == 4)
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
