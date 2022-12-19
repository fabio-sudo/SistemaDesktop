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
    public partial class FrmCodigoBarras : Form
    {
        NegEstoque nEstoque = new NegEstoque();
        EstoqueLista listaEstoque = new EstoqueLista();
        EstoqueLista itemEstoqueLista = new EstoqueLista();//Lista Para adicionar produtos que não tem Cadastro 
        EstoqueLista listaEstoqueAtualizar = new EstoqueLista();//Lista de produtos já cadastrados para realizar atualização
        Estoque objEstoque = new Estoque();

        Produto objProduto = new Produto();
        NegProduto nProduto = new NegProduto();
        NegItemEntrada nItem = new NegItemEntrada();

        Metodos metodos = new Metodos();

        public FrmCodigoBarras()
        {
            InitializeComponent();
        }


        //Atualiza dados do DataGride
        private void AtualizarDataGrid()
        {
            this.dgvProdutoCor.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.listaEstoque.Count > 0)
            {
                this.dgvProdutoCor.Rows.Add(this.listaEstoque.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (Estoque item in this.listaEstoque)
            {
                this.dgvProdutoCor[0, indice].Value = item.codigoEstoque;
                this.dgvProdutoCor[1, indice].Value = item.ProdutoCor.Produto.codigoProduto;
                this.dgvProdutoCor[2, indice].Value = item.ProdutoCor.codigoProdutoCor;
                this.dgvProdutoCor[3, indice].Value = item.ProdutoCor.Cor.codigoCor;
                this.dgvProdutoCor[4, indice].Value = item.ProdutoCor.Cor.nomeCor;
                this.dgvProdutoCor[5, indice].Value = item.tamanhoProduto.codigoTamanho;
                this.dgvProdutoCor[6, indice].Value = item.tamanhoProduto.nometamanho;
                this.dgvProdutoCor[7, indice].Value = item.quantidadeEstoque;
                this.dgvProdutoCor[8, indice].Value = item.precoCustoEstoque;
                this.dgvProdutoCor[9, indice].Value = item.precoVendaEstoque;
                this.dgvProdutoCor[10, indice].Value = item.codigoBarrasProduto;
                this.dgvProdutoCor[11, indice].Value = item.ProdutoCor.ImagemProduto;
                this.dgvProdutoCor[12, indice].Value = indice;


                indice++;
            }

            dgvProdutoCor.Update();

        }

        //Exibe imagem do produto salva no bano de Dados
        public void metodoExibeImagemProduto()
        {
            if (dgvProdutoCor.Rows.Count > 0)
            {
                //Buscal Local que a Solution Está sendo Executada no Computador
                String LocalSolution = Environment.CurrentDirectory;
                // This will get the current PROJECT directory
                LocalSolution = Directory.GetParent(LocalSolution).Parent.Parent.FullName;

                String imgProduto = (dgvProdutoCor.CurrentRow.Cells[11].Value).ToString();
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

        //Metodo adiciona itens a lista para realizar alterações
        public void metodoAddItemLista() {
            if (dgvProdutoCor.RowCount > 0)
            {
                //Percorre o gride para adicionar itens
                itemEstoqueLista = new EstoqueLista();
                listaEstoqueAtualizar = new EstoqueLista();

                foreach (DataGridViewRow row in dgvProdutoCor.Rows)
                {
                    Estoque itemEstoque = new Estoque();
                    itemEstoque.ProdutoCor = new ProdutoCor();
                    itemEstoque.ProdutoCor.Produto = new Produto();
                    itemEstoque.ProdutoCor.Cor = new Cor();
                    itemEstoque.tamanhoProduto = new Tamanho();

                    itemEstoque.codigoEstoque = Convert.ToInt32(row.Cells[0].Value);
                    itemEstoque.ProdutoCor.Produto.codigoProduto = Convert.ToInt32(row.Cells[1].Value);
                    itemEstoque.ProdutoCor.codigoProdutoCor = Convert.ToInt32(row.Cells[2].Value);
                    itemEstoque.ProdutoCor.Cor.codigoCor = Convert.ToInt32(row.Cells[3].Value);
                    itemEstoque.tamanhoProduto.codigoTamanho = Convert.ToInt32(row.Cells[5].Value);
                    itemEstoque.quantidadeEstoque = 0;//Para não atualizar quantidades
                    itemEstoque.precoCustoEstoque = Convert.ToDouble(row.Cells[8].Value);
                    itemEstoque.precoVendaEstoque = Convert.ToDouble(row.Cells[9].Value);
                    itemEstoque.codigoBarrasProduto = row.Cells[10].Value.ToString();

                    //-----------Adiciona itens que não tem cadastro e tem código de barras inserido
                    if (itemEstoque.codigoEstoque == 0 && itemEstoque.codigoBarrasProduto != "")
                    {
                        itemEstoqueLista.Add(itemEstoque);
                    }
                    else
                    {

                        listaEstoqueAtualizar.Add(itemEstoque);
                    }

                }
            }
        }

        //------------------Caixa de Texto
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

        private void tbBuscarProduto_Enter(object sender, EventArgs e)
        {
            tbBuscarProduto.Clear();
            pbProduto.Image = Properties.Resources.ProdutoRosa;
            panelBuscarProduto.BackColor = Color.DeepPink;
        }

        private void tbBuscarProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbProduto_Click(null, null);
                e.Handled = true;
            }
        }

        //-------------------Botões
        private void pbProduto_Click(object sender, EventArgs e)
        {
            objProduto = new Produto();

            int n;
            bool ehUmNumero = int.TryParse(tbBuscarProduto.Text, out n);
            if (ehUmNumero == true)
            {
                objProduto = nProduto.BuscarProdutoPorCodigo(n);
                if (objProduto != null)
                {
                    this.tbBuscarProduto.Text = objProduto.descricaoProduto;
                    dgvProdutoCor.Focus();

                }
                else
                    tbBuscarProduto.Clear();
            }
            else
            {
                FrmSelecionarProduto frmSelecionarProduto = new FrmSelecionarProduto(tbBuscarProduto.Text);
                DialogResult resultado = frmSelecionarProduto.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    this.objProduto = frmSelecionarProduto.ProdutoSelecionado;
                    this.tbBuscarProduto.Text = objProduto.descricaoProduto;
                    dgvProdutoCor.Focus();
                }

            }

            if (objProduto.codigoProduto != 0)
            {
                btBuscar.PerformClick();
                metodoExibeImagemProduto();
                mtbCusto.Text = (objProduto.precoCustoProduto * 100).ToString();
                mtbVenda.Text = (objProduto.precoVendaProduto * 100).ToString();
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (objProduto.codigoProduto != 0)
            {
                listaEstoque = nEstoque.BuscarTamanhoProdutoCorPorProduto(objProduto.codigoProduto);
                AtualizarDataGrid();
            }
            if (tbBuscarProduto.Text == "" || tbBuscarProduto.Text == "Digite a descrição do produto ...") {
                dgvProdutoCor.Rows.Clear();
            
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                metodoAddItemLista(); 

                //----------------------------Novos Produtos
                //Realiza o cadstro dos novos produtos que não tem cadatro no caso de lançamento de código de barras
                if (itemEstoqueLista.Count > 0) {

                    if (nEstoque.CadastraEstoqueLista(itemEstoqueLista) == true)
                    {
                        //Criando Caixa de dialogo
                        FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Alteração",
                        "Produto Atualizado com sucesso !\r\n" +
                        "Alterações Finalizadas ?",
                        Properties.Resources.DialogOK,
                        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                        Color.White,
                        "Sim", "Não",
                        false);
                        DialogResult resposta = frmCaixa.ShowDialog();

                        if (resposta == DialogResult.Yes)
                        {
                            //Retornando que exclusão foi realizada com sucesso
                            this.DialogResult = DialogResult.Yes;
                            this.Close();
                        }
                        else {
                            btBuscar.PerformClick();
                        }
                    }
                    else {

                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro",
                    "Erro ao Atualizar Produtos \r\n",
                    Properties.Resources.DialogErro,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Ok", "",
                    false);
                    frmCaixa.ShowDialog();
                    
                    }
                }
            }

            catch (Exception ex)
            {
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro",
                "Erro ao Atualizar Produtos \r\n" + ex.Message,
                Properties.Resources.DialogErro,
                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                Color.White,
                "Ok", "",
                false);
                frmCaixa.ShowDialog();
            }
        }

        private void pbPrecos_Click(object sender, EventArgs e)
        {
            try
            {
                //Atualiza os valores caso o Gride estiver registros
                if (dgvProdutoCor.RowCount > 0)
                {

                    DialogResult resposta;
                    //Criando Caixa de dialogo
                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Alteração",
                    " Deseja realmente Alterar os valores do Produto ?",
                    Properties.Resources.Alterar,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Confirmar", "Cancelar",
                    false);
                    //Verifica se o usuário realmente quer alterar os dados do cliente.
                    resposta = frmCaixa.ShowDialog();
                    if (resposta == DialogResult.Yes)
                    {

                        int contador = 0;
                        foreach (DataGridViewRow row in dgvProdutoCor.Rows)
                        {
                            dgvProdutoCor.Rows[contador].Cells[8].Value = Convert.ToDouble(mtbCusto.Text);
                            dgvProdutoCor.Rows[contador].Cells[9].Value = Convert.ToDouble(mtbVenda.Text);

                            contador++;
                        }
                        //----------------------Atualiza os valores do Produtos 
                        metodoAddItemLista();//Adiciona os valores do gride em uma lista
                        if (listaEstoqueAtualizar.Count > 0)
                        {
                            if (nEstoque.AtualizarPrecoEstoque(listaEstoqueAtualizar) == true)
                            {

                                if (nProduto.AtualizarPrecoProduto(objProduto.codigoProduto, Convert.ToDouble(mtbCusto.Text), Convert.ToDouble(mtbVenda.Text)) == false)
                                {
                                    //Erro quando atualiza valores do Produto
                                    FrmCaixaDialogo frmCaixaPrecos = new FrmCaixaDialogo("Erro",
                                   "Erro ao Atualizar Valores!\r\n",
                                    Properties.Resources.DialogErro,
                                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                    Color.White,
                                    "Ok", "",
                                    false);
                                    frmCaixaPrecos.ShowDialog();
                                }
                                //Finaliza cadastro de Valores com sucesso
                                else
                                {
                                    FrmCaixaDialogo frmCaixaPrecos = new FrmCaixaDialogo("Aviso",
                                       "Valores Atualizados com Sucesso!\r\n",
                                        Properties.Resources.DialogOK,
                                        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                        Color.White,
                                        "Ok", "",
                                        false);
                                    frmCaixaPrecos.ShowDialog();
                                    this.DialogResult = DialogResult.Yes;//Retorna Sim pra atualizar formulario anterior

                                }

                            }
                            //Erro Quanto atualiza valores do Estoque
                            else
                            {
                                FrmCaixaDialogo frmCaixaPrecos = new FrmCaixaDialogo("Erro",
                                "Erro ao Atualizar Valores!\r\n",
                                 Properties.Resources.DialogErro,
                                 System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                 Color.White,
                                 "Ok", "",
                                 false);
                                frmCaixaPrecos.ShowDialog();

                            }
                        }
                    }
                }
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair da Atualização de Produto ?",
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

        //--------------------DataGride
        private void dgvProdutoCor_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try{
            //Custo
                if (dgvProdutoCor.Columns[e.ColumnIndex].Name == "precoCusto")
                {
                    dgvProdutoCor.Rows[e.RowIndex].ErrorText = "";
                    double newDouble;

                    if (dgvProdutoCor.Rows[e.RowIndex].IsNewRow) { return; }
                    if (!double.TryParse(e.FormattedValue.ToString(),
                        out newDouble) || newDouble < 0)
                    {
                        e.Cancel = true;
                        dgvProdutoCor.Rows[e.RowIndex].ErrorText = "Informe o preço de Custo Corretamente";
                    }
                    //Verifica se houve alguma alteração nos preços
                    if (newDouble != Convert.ToDouble(dgvProdutoCor.CurrentRow.Cells[8].Value.ToString()) && dgvProdutoCor.CurrentRow.Cells[0].Value.ToString() != "0")
                    {                   
                        //Atualiza o preco de Custo
                        if (nEstoque.AtualizarPrecoCustoEstoque(Convert.ToInt32(dgvProdutoCor.CurrentRow.Cells[2].Value), newDouble, Convert.ToInt32(dgvProdutoCor.CurrentRow.Cells[5].Value)) != true)
                        {

                            MessageBox.Show("Erro ao Atualizar Preço Custo!",
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                //Venda
                if (dgvProdutoCor.Columns[e.ColumnIndex].Name == "precoVenda")
                {
                    dgvProdutoCor.Rows[e.RowIndex].ErrorText = "";
                    double newDouble;

                    if (dgvProdutoCor.Rows[e.RowIndex].IsNewRow) { return; }
                    if (!double.TryParse(e.FormattedValue.ToString(),
                        out newDouble) || newDouble < 0)
                    {
                        e.Cancel = true;
                        dgvProdutoCor.Rows[e.RowIndex].ErrorText = "Informe o preço de Venda Corretamente";
                    }
                    //Verifica se houve alguma alteração nos preços
                    if (newDouble != Convert.ToDouble(dgvProdutoCor.CurrentRow.Cells[9].Value.ToString()) && dgvProdutoCor.CurrentRow.Cells[0].Value.ToString() != "0")
                    {

                        //Atualiza o preco de Custo
                        if (nEstoque.AtualizarPrecoVendaEstoque(Convert.ToInt32(dgvProdutoCor.CurrentRow.Cells[2].Value), newDouble, Convert.ToInt32(dgvProdutoCor.CurrentRow.Cells[5].Value)) != true)
                        {

                            MessageBox.Show("Erro ao atualizar preco de Venda!",
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                //Código Barras
                if (dgvProdutoCor.Columns[e.ColumnIndex].Name == "codigoBarras")
                {
                    dgvProdutoCor.Rows[e.RowIndex].ErrorText = "";
                    //Correção do Erro
                    if (dgvProdutoCor.CurrentRow.Cells[10].Value == null)
                    {
                        dgvProdutoCor.CurrentRow.Cells[10].Value = "";//passa uma string em vez de null
                    }

                    //Verifica Se o item Já existe na memória
                    if (e.FormattedValue.ToString() != listaEstoque[Convert.ToInt32(dgvProdutoCor.CurrentRow.Cells[12].Value)].codigoBarrasProduto.ToString())
                    {
                        //Verifica Se o item oferecido e diferente do valor digitado
                        if (e.FormattedValue.ToString() != "" && e.FormattedValue.ToString() != dgvProdutoCor.CurrentRow.Cells[10].Value.ToString())
                        {

                            ProdutoCor produtoCorValida = new ProdutoCor();
                            produtoCorValida = nItem.ValidarCodigoBarras(e.FormattedValue.ToString());

                            if (produtoCorValida != null)
                            {
                                e.Cancel = true;
                                dgvProdutoCor.Rows[e.RowIndex].ErrorText =
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
                                    //Caso o item não exista ele deve ser cadastrado no Estoque******
                                    if (nItem.AtualizarCodigoBarrasItem(produtoCorValida.codigoProdutoCor, produtoCorValida.Cor.codigoCor, "") == true)//codigo da cor e codigo do tamanho
                                    {
                                        if (nItem.AtualizarCodigoBarrasItem(Convert.ToInt32(dgvProdutoCor.CurrentRow.Cells[2].Value), Convert.ToInt32(dgvProdutoCor.CurrentRow.Cells[5].Value), e.FormattedValue.ToString()) == true)
                                        {
                                            //Adiciona novo valor ao a lista
                                            listaEstoque[Convert.ToInt32(dgvProdutoCor.CurrentRow.Cells[12].Value)].codigoBarrasProduto = e.FormattedValue.ToString();
                                            //Se o codigo de barras alterado estiver no mesmo produto em tamnho diferente o código antigo é apagado
                                            foreach (DataGridViewRow row in dgvProdutoCor.Rows)
                                            {

                                                if (e.FormattedValue.ToString() == row.Cells[10].Value.ToString() && e.FormattedValue.ToString() != dgvProdutoCor.CurrentRow.Cells[10].Value.ToString())
                                                {

                                                    dgvProdutoCor.Rows[row.Index].Cells[10].Value = "";
                                                    listaEstoque[row.Index].codigoBarrasProduto = "";
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
                                Boolean cadRepetiu = false;

                                foreach (DataGridViewRow row in dgvProdutoCor.Rows)
                                {

                                    if (e.FormattedValue.ToString() == row.Cells[10].Value.ToString() && e.FormattedValue.ToString() != dgvProdutoCor.CurrentRow.Cells[10].Value.ToString())
                                    {

                                        e.Cancel = true;
                                        dgvProdutoCor.Rows[e.RowIndex].ErrorText = "Barras já existe";
                                        cadRepetiu = true;
                                        break;

                                    }
                                }
                                //Se o item não for repetido e ja estiver cadastrado no estoque ele e atualizado
                                if (cadRepetiu == false && Convert.ToInt32(dgvProdutoCor.CurrentRow.Cells[0].Value) != 0)
                                {
                                    //Cadastrar Código de Barras Novo
                                    if (nItem.AtualizarCodigoBarrasItem(Convert.ToInt32(dgvProdutoCor.CurrentRow.Cells[2].Value), Convert.ToInt32(dgvProdutoCor.CurrentRow.Cells[5].Value), e.FormattedValue.ToString()) != true)
                                    {

                                        MessageBox.Show("Erro ao cadastrar CódigoBarras!",
                                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                        //Caso usuário queira deixar código de barras como vazio
                        else if (e.FormattedValue.ToString() == "" && e.FormattedValue.ToString() != dgvProdutoCor.CurrentRow.Cells[12].Value.ToString())
                        {
                            //Se já existir um codigo de barras e ele for mudado para vazio
                            DialogResult respostaCadastro;
                            //Criando Caixa de dialogo
                            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Código de Barras Vazio",
                            " Deseja realmente cadastrar o Código de Barras Vazio",
                            Properties.Resources.DialogQuestion,
                            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                            Color.White,
                            "Sim", "Não",
                            false);

                            respostaCadastro = frmCaixa.ShowDialog();
                            if (respostaCadastro == DialogResult.Yes)
                            {
                                //Se Sim Cadastra Código De Barras Vazio
                                nItem.AtualizarCodigoBarrasItem(Convert.ToInt32(dgvProdutoCor.CurrentRow.Cells[2].Value), Convert.ToInt32(dgvProdutoCor.CurrentRow.Cells[5].Value), "");

                            }
                        }
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

        private void dgvProdutoCor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            metodoExibeImagemProduto();
        }

        private void FrmCodigoBarras_KeyDown(object sender, KeyEventArgs e)
        {
            //atalho da tecla de atalho ESC
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {
                btSair.PerformClick();
            }
            //atalho para o botão cadastrar
            else if (e.KeyCode.Equals(Keys.F10) == true)
            {
                btSalvar.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.F5) == true)
            {
                btBuscar.PerformClick();
            }
        }

        //-------------------Caixa de Texto Preço
        private void mtbCusto_TextChanged(object sender, EventArgs e)
        {
            metodos.metodoMoedaMTB(ref mtbCusto);
        }

        private void mtbVenda_TextChanged(object sender, EventArgs e)
        {
            metodos.metodoMoedaMTB(ref mtbVenda);
        }

        private void mtbVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbPrecos_Click(null, null);
                e.Handled = true;
                dgvProdutoCor.Focus();
            }
        }

        private void mtbCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbPrecos_Click(null, null);
                e.Handled = true;
                dgvProdutoCor.Focus();
            }
        }


    }
}
