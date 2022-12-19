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
    public partial class FrmEstoque : Form
    {
        EstoqueLista listaEstoque = new EstoqueLista();
        Estoque objEstoque = new Estoque();
        Produto objProduto = new Produto();
        Tamanho objTamanho = new Tamanho();
        Cor objCor = new Cor();

        //Negócios
        NegEstoque nEstoque = new NegEstoque();
        NegProduto nProduto = new NegProduto();
        NegGenero nGenero = new NegGenero();
        NegGrade nGrade = new NegGrade();
        NegFornecedor nFornecedor = new NegFornecedor();
        NegProdutoCor nProdutoCor = new NegProdutoCor();
        NegCor nCor = new NegCor();
        NegTamanho nTamanho = new NegTamanho();
        NegItemEntrada nItem = new NegItemEntrada();

        public FrmEstoque()
        {
            InitializeComponent();
        }

        //---------Limpa Filtros
        public void metodoCalculaTotais() {

            int varQuantidadeTotal= 0;
            double varCustoTotal= 0;
            double varVendaTotal = 0;

            if (dgvEstoque.RowCount > 0) {

                //faz a soma dos totais dos valores do gride
                foreach (DataGridViewRow col in dgvEstoque.Rows)
                {
                    varQuantidadeTotal = varQuantidadeTotal + Convert.ToInt32(col.Cells[12].Value);
                    varCustoTotal = varCustoTotal + Convert.ToDouble(col.Cells[17].Value);
                    varVendaTotal = varVendaTotal + Convert.ToInt16(col.Cells[19].Value);
                }
            }
                //preencher as quantidade totais
                lbQuantidadeEstoque.Text = varQuantidadeTotal.ToString();
                lbTotalEstoque.Text = String.Format("{0:C2}", varCustoTotal);
                lbVenda.Text = String.Format("{0:C2}", varVendaTotal);            
        
        }

        public void metodoLimpaFiltros() {
            this.cbSexo.SelectedItem = null;
            this.tbGenero.Clear();
            this.tbGrade.Clear();
            this.tbFornecedor.Clear();
            this.dtpDataInicial.Value = DateTime.Now;
            this.dtpDataFinal.Value = DateTime.Now;
            this.tbCor.Clear();
            this.tbTamanho.Clear();

            dgvEstoque.Rows.Clear();
        }
        
        //Atualiza dados do DataGride
        private void AtualizarDataGrid()
        {
            this.dgvEstoque.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.listaEstoque.Count > 0)
            {
                this.dgvEstoque.Rows.Add(this.listaEstoque.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (Estoque item in this.listaEstoque)
            {
                this.dgvEstoque[0, indice].Value = item.codigoEstoque;
                this.dgvEstoque[1, indice].Value = item.ProdutoCor.Produto.codigoProduto;
                this.dgvEstoque[2, indice].Value = item.ProdutoCor.codigoProdutoCor;
                this.dgvEstoque[3, indice].Value = item.ProdutoCor.Produto.descricaoProduto;
                this.dgvEstoque[4, indice].Value = item.ProdutoCor.Produto.referenciaProduto;
                this.dgvEstoque[5, indice].Value = item.ProdutoCor.Produto.sexoProduto;
                this.dgvEstoque[6, indice].Value = item.ProdutoCor.Cor.nomeCor;
                this.dgvEstoque[7, indice].Value = item.ProdutoCor.Produto.Genero.nomeGenero;
                this.dgvEstoque[8, indice].Value = item.ProdutoCor.Produto.Grade.nomeGrade;
                this.dgvEstoque[9, indice].Value = item.tamanhoProduto.codigoTamanho;
                this.dgvEstoque[10, indice].Value = item.tamanhoProduto.nometamanho;
                this.dgvEstoque[11, indice].Value = item.ProdutoCor.Produto.Fornecedor.nomeFantasiaFornecedor;
                this.dgvEstoque[12, indice].Value = item.quantidadeEstoque;
                this.dgvEstoque[13, indice].Value = item.precoCustoEstoque;
                this.dgvEstoque[14, indice].Value = item.precoVendaEstoque;
                this.dgvEstoque[15, indice].Value = item.codigoBarrasProduto;
                this.dgvEstoque[16, indice].Value = item.ProdutoCor.ImagemProduto;
                this.dgvEstoque[17, indice].Value = item.quantidadeEstoque * item.precoCustoEstoque;
                this.dgvEstoque[18, indice].Value = item.dataEstoque;
                this.dgvEstoque[19, indice].Value = item.quantidadeEstoque * item.precoVendaEstoque;
                indice++;
            }

            dgvEstoque.Update();

        }

        private void metodoPreecheFiltros() {

            objEstoque = new Estoque();
            objEstoque.ProdutoCor = new ProdutoCor();
            objEstoque.ProdutoCor.Produto = new Produto();
            objEstoque.ProdutoCor.Produto.Genero = new Genero();
            objEstoque.ProdutoCor.Produto.Grade = new Grade();
            objEstoque.ProdutoCor.Produto.Fornecedor = new Fornecedor();
            objEstoque.ProdutoCor.Cor = new Cor();
            objEstoque.tamanhoProduto = new Tamanho();

            string strTextoABuscar;
            if (tbBuscarProduto.Text == "Digite a descrição do produto ...")
            {
                strTextoABuscar = "";
            }
            else {
                strTextoABuscar = tbBuscarProduto.Text;
            }

            objEstoque.ProdutoCor.Produto.descricaoProduto = strTextoABuscar;
            objEstoque.ProdutoCor.Produto.sexoProduto = cbSexo.Text;
            objEstoque.ProdutoCor.Cor.nomeCor = tbCor.Text;
            objEstoque.ProdutoCor.Produto.Genero.nomeGenero = tbGenero.Text;
            objEstoque.ProdutoCor.Produto.Grade.nomeGrade = tbGrade.Text;
            objEstoque.tamanhoProduto.nometamanho = tbTamanho.Text;
            objEstoque.ProdutoCor.Produto.Fornecedor.nomeFantasiaFornecedor = tbFornecedor.Text;
        
        }

        //Exibe imagem do produto salva no bano de Dados
        public void metodoExibeImagemProduto()
        {
            if (dgvEstoque.Rows.Count > 0)
            {
                //Buscal Local que a Solution Está sendo Executada no Computador
                String LocalSolution = Environment.CurrentDirectory;
                // This will get the current PROJECT directory
                LocalSolution = Directory.GetParent(LocalSolution).Parent.Parent.FullName;

                String imgProduto = (dgvEstoque.CurrentRow.Cells[16].Value).ToString();
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

        //-------------------Botões

        private void pbCor_Click(object sender, EventArgs e)
        {
            if (objProduto != null && tbBuscarProduto.Text != String.Empty && tbBuscarProduto.Text != "Digite a descrição do produto ...")
                {
                    FrmSelecionarCorProduto frmSelecionarCorProduto = new FrmSelecionarCorProduto(objProduto.codigoProduto, tbCor.Text);
                    DialogResult resultado = frmSelecionarCorProduto.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        this.objCor = frmSelecionarCorProduto.corSelecionado;
                        this.tbCor.Text = objCor.nomeCor;
                        tbGenero.Focus();
                    }

                }
                else
                {
                    int n;
                    bool ehUmNumero = int.TryParse(tbCor.Text, out n);
                    if (ehUmNumero == true)
                    {
                        objCor = nCor.BuscarCorPorCodigo(n);
                        //Erro Codigo Tamanho é == a 10
                        if (objCor != null)
                        {
                            this.tbCor.Text = objCor.nomeCor;
                            tbGenero.Focus();
                        }
                        else
                            tbCor.Clear();
                    }
                    else
                    {
                        FrmSelecionarCor frmSelecionarCor = new FrmSelecionarCor(tbCor.Text);
                        DialogResult resultado = frmSelecionarCor.ShowDialog();

                        if (resultado == DialogResult.OK)
                        {
                            this.objCor = frmSelecionarCor.corSelecionado;
                            this.tbCor.Text = objCor.nomeCor;
                            tbGenero.Focus();
                        }

                    }
                }
            }   

        private void pbBuscarGenero_Click(object sender, EventArgs e)
        {
            int n;
            bool ehUmNumero = int.TryParse(tbGenero.Text, out n);
            if (ehUmNumero == true)
            {
                objProduto.Genero = nGenero.BuscarGeneroPorCodigo(n);
                if (objProduto.Genero != null)
                {
                    this.tbGenero.Text = objProduto.Genero.nomeGenero;
                    tbGrade.Focus();
                }
                else
                    tbGenero.Clear();
            }
            else
            {
                FrmSelecionarGenero frmSelecionarGenero = new FrmSelecionarGenero(tbGenero.Text);
                DialogResult resultado = frmSelecionarGenero.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    this.objProduto.Genero = frmSelecionarGenero.generoSelecionado;
                    this.tbGenero.Text = objProduto.Genero.nomeGenero;
                    tbGrade.Focus();
                }

            }   
        }

        private void pbBuscarGrade_Click(object sender, EventArgs e)
        {
            int n;
            bool ehUmNumero = int.TryParse(tbGrade.Text, out n);
            if (ehUmNumero == true)
            {
                objProduto.Grade = nGrade.BuscarGradePorCodigo(n);
                if (objProduto.Grade != null)
                {
                    this.tbGrade.Text = objProduto.Grade.nomeGrade;
                    tbTamanho.Clear();
                    tbTamanho.Focus();
                }
                else
                    tbGrade.Clear();
            }
            else
            {
                FrmSelecionarGrade frmSelecionarGrade = new FrmSelecionarGrade(tbGrade.Text);
                DialogResult resultado = frmSelecionarGrade.ShowDialog();

                if (resultado == DialogResult.OK)
                {

                    this.objProduto.Grade = frmSelecionarGrade.gradeSelecionado;
                    this.tbGrade.Text = objProduto.Grade.nomeGrade;
                    tbTamanho.Clear();
                    tbTamanho.Focus();
                }

            }    
        }

        private void pbBuscarFornecedor_Click(object sender, EventArgs e)
        {
            int n;
            bool ehUmNumero = int.TryParse(tbFornecedor.Text, out n);
            if (ehUmNumero == true)
            {
                objProduto.Fornecedor = nFornecedor.BuscarFornecedorPorCodigo(n);
                if (objProduto.Fornecedor != null)
                {
                    this.tbFornecedor.Text = objProduto.Fornecedor.nomeFantasiaFornecedor;
                }
                else
                    tbFornecedor.Clear();
            }
            else
            {
                FrmSelecionarFornecedor frmSelecionarFornecedor = new FrmSelecionarFornecedor(tbFornecedor.Text);
                DialogResult resultado = frmSelecionarFornecedor.ShowDialog();

                if (resultado == DialogResult.OK)
                {

                    this.objProduto.Fornecedor = frmSelecionarFornecedor.FornecedorSelecionado;
                    this.tbFornecedor.Text = objProduto.Fornecedor.nomeFantasiaFornecedor;
                }

            }    
        }

        private void pbTamanho_Click(object sender, EventArgs e)
        {
            if (objProduto.Grade != null && tbGrade.Text != String.Empty)
            {
              
                    FrmSelecionarTamanhoGrade frmSelecionarTamanhoGrade = new FrmSelecionarTamanhoGrade(objProduto.Grade.codigoGrade,tbTamanho.Text);
                    DialogResult resultado = frmSelecionarTamanhoGrade.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        this.objTamanho = frmSelecionarTamanhoGrade.tamanhoSelecionado;
                        this.tbTamanho.Text = objTamanho.nometamanho;
                        tbFornecedor.Focus();
                    }

            }
            else
            {
                int n;
                bool ehUmNumero = int.TryParse(tbTamanho.Text, out n);
                if (ehUmNumero == true)
                {
                    objTamanho = nTamanho.BuscarTamanhoPorCodigo(n);
                    //Erro Codigo Tamanho é == a 10
                    if (objTamanho != null)
                    {
                        this.tbTamanho.Text = objTamanho.nometamanho;
                        tbFornecedor.Focus();
                    }
                    else
                        tbTamanho.Clear();
                }
                else
                {
                    FrmSelecionarTamanho frmSelecionarTamanho = new FrmSelecionarTamanho(tbTamanho.Text);
                    DialogResult resultado = frmSelecionarTamanho.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        this.objTamanho = frmSelecionarTamanho.tamanhoSelecionado;
                        this.tbTamanho.Text = objTamanho.nometamanho;
                        tbFornecedor.Focus();
                    }

                }
            }
        }

        private void pbProduto_Click(object sender, EventArgs e)
        {

            int n;
            bool ehUmNumero = int.TryParse(tbBuscarProduto.Text, out n);
            if (ehUmNumero == true)
            {
                objProduto = nProduto.BuscarProdutoPorCodigo(n);
                if (objProduto.descricaoProduto != null)
                {
                    this.tbBuscarProduto.Text = objProduto.descricaoProduto;
                    this.cbSexo.SelectedItem = objProduto.sexoProduto;
                    this.tbGenero.Text = objProduto.Genero.nomeGenero;
                    this.tbGrade.Text = objProduto.Grade.nomeGrade;
                    this.tbFornecedor.Text = objProduto.Fornecedor.nomeFantasiaFornecedor;
                    this.dtpDataInicial.Value = objProduto.dataProduto;
                    this.dtpDataFinal.Value = objProduto.dataProduto;
                    this.tbCor.Clear();
                    this.tbTamanho.Clear();

                    tbCor.Focus();
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
                    this.objProduto  = frmSelecionarProduto.ProdutoSelecionado;
                    this.tbBuscarProduto.Text = objProduto.descricaoProduto;

                    this.tbBuscarProduto.Text = objProduto.descricaoProduto;
                    this.cbSexo.SelectedItem = objProduto.sexoProduto;
                    this.tbGenero.Text = objProduto.Genero.nomeGenero;
                    this.tbGrade.Text = objProduto.Grade.nomeGrade;
                    this.tbFornecedor.Text = objProduto.Fornecedor.nomeFantasiaFornecedor;
                    this.dtpDataInicial.Value = objProduto.dataProduto;
                    this.dtpDataFinal.Value = objProduto.dataProduto;
                    this.tbCor.Clear();
                    this.tbTamanho.Clear();

                    tbCor.Focus();
                }

            }

            pbBuscarEstoque_Click(null, null);
        }

        //------------------Caixas de Texto
        private void tbBuscarProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbProduto_Click(null, null);
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

        private void tbBuscarProduto_Enter(object sender, EventArgs e)
        {
            tbBuscarProduto.Clear();
            pbProduto.Image = Properties.Resources.ProdutoRosa;
            panelBuscarProduto.BackColor = Color.DeepPink;

        }

        private void tbCor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbCor_Click(null, null);
                e.Handled = true;
            }
        }

        private void tbGenero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbBuscarGenero_Click(null, null);
                e.Handled = true;
            }
        }

        private void tbGrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbBuscarGrade_Click(null, null);
                e.Handled = true;
            }
        }

        private void tbTamanho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbTamanho_Click(null, null);
                e.Handled = true;
            }
        }

        private void tbFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbBuscarFornecedor_Click(null, null);
                e.Handled = true;
            }
        }

        //------------------------Botões
        private void btEntradaEstoque_Click(object sender, EventArgs e)
        {
            DialogResult resposta;

            FrmEntradaEstoque frmEntradaEstoque = new FrmEntradaEstoque();
            resposta = frmEntradaEstoque.ShowDialog();

            if (resposta == DialogResult.Yes) {

                pbLimpar_Click(null, null);
            }
        }

        private void btLancamento_Click(object sender, EventArgs e)
        {

            //Busca Produto para realizar consulta de produtos existentes nos Lançamentos
            if (this.dgvEstoque.Rows.Count > 0)
            {
                Tamanho tamanhoSelecionado = new Tamanho();

                int indiceRegistroSelecionado = Convert.ToInt32(dgvEstoque.CurrentRow.Cells[2].Value);
                tamanhoSelecionado.codigoTamanho = Convert.ToInt32(dgvEstoque.CurrentRow.Cells[9].Value);
                tamanhoSelecionado.nometamanho = dgvEstoque.CurrentRow.Cells[10].Value.ToString();

                ProdutoCor prod = nProdutoCor.BuscarProdutoCorPorCodigo(indiceRegistroSelecionado);

                if (prod != null)
                {

                    DialogResult resposta;
                    FrmSelecionarProdutoEntradaEstoque frmEntradaEstoque = new FrmSelecionarProdutoEntradaEstoque(prod, tamanhoSelecionado);
                    resposta = frmEntradaEstoque.ShowDialog();

                    if (resposta == DialogResult.Yes)
                    {
                        pbBuscarEstoque_Click(null, null);
                    }

                }

            }
            
        }

        private void pbLimpar_Click(object sender, EventArgs e)
        {
            metodoLimpaFiltros();
            tbBuscarProduto.Focus();
            metodoCalculaTotais();
        }

        private void pbBuscarEstoque_Click(object sender, EventArgs e)
        {
            metodoPreecheFiltros();
            listaEstoque = nEstoque.BuscarEstoqueFiltros(objEstoque);
            AtualizarDataGrid();
            metodoExibeImagemProduto();
            metodoCalculaTotais();
        }

        private void pbFiltrar_Click(object sender, EventArgs e)
        {
            listaEstoque = nEstoque.BuscarEstoquePorData(dtpDataInicial.Value, dtpDataFinal.Value);
            AtualizarDataGrid();
            metodoExibeImagemProduto();
        }

        //-------------------------Formulário
        private void FrmEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F5) == true)
            {
                pbBuscarEstoque_Click(null,null);
            }
            if (e.KeyCode.Equals(Keys.F10) == true)
            {
                btLancamento.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F2) == true)
            {
                btEntradaEstoque.PerformClick();
            }
            //ESC é no menu principal
        }

        private void dgvEstoque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            metodoExibeImagemProduto();
        }

        private void dgvEstoque_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                //Código Barras
                if (dgvEstoque.Columns[e.ColumnIndex].Name == "codigoBarrasProduto")
                {
                    dgvEstoque.Rows[e.RowIndex].ErrorText = "";
                    //Correção do Erro
                    if (dgvEstoque.CurrentRow.Cells[15].Value == null)
                    {
                        dgvEstoque.CurrentRow.Cells[15].Value = "";
                    }
                        //Verifica Se o item oferecido e diferente do valor digitado
                        if (e.FormattedValue.ToString() != "" && e.FormattedValue.ToString() != dgvEstoque.CurrentRow.Cells[15].Value.ToString())
                        {

                            ProdutoCor produtoCorValida = new ProdutoCor();
                            produtoCorValida = nItem.ValidarCodigoBarras(e.FormattedValue.ToString());

                            if (produtoCorValida != null)
                            {
                                e.Cancel = true;
                                dgvEstoque.Rows[e.RowIndex].ErrorText =
                                    "Barras já existe"
                                    + " Cód:" + produtoCorValida.Produto.codigoProduto.ToString()
                                    + " Ref:" + produtoCorValida.Produto.descricaoProduto
                                    + " Cor:" + produtoCorValida.Cor.nomeCor;

                                DialogResult resposta;
                                //Criando Caixa de dialogo
                                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Código de Barras Existente",
                                " Deseja realmente alterar o Código de Barras"
                                + "\r\n Cód:" + produtoCorValida.Produto.codigoProduto.ToString()
                                + "\r\n Ref:" + produtoCorValida.Produto.descricaoProduto
                                + "\r\n Cor:" + produtoCorValida.Cor.nomeCor,
                                Properties.Resources.DialogQuestion,
                                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                Color.White,
                                "Sim", "Não",
                                true);

                                resposta = frmCaixa.ShowDialog();
                                if (resposta == DialogResult.Yes)
                                {
                                    if (nItem.AtualizarCodigoBarrasItem(produtoCorValida.codigoProdutoCor, produtoCorValida.Cor.codigoCor, "") == true)//codigo da cor e codigo do tamanho
                                    {

                                        if (nItem.AtualizarCodigoBarrasItem(objEstoque.ProdutoCor.codigoProdutoCor, Convert.ToInt32(dgvEstoque.CurrentRow.Cells[9].Value), e.FormattedValue.ToString()) == true)
                                        {
                                            foreach (DataGridViewRow row in dgvEstoque.Rows)
                                            {

                                                if (e.FormattedValue.ToString() == row.Cells[15].Value.ToString() && e.FormattedValue.ToString() != dgvEstoque.CurrentRow.Cells[15].Value.ToString())
                                                {

                                                    dgvEstoque.Rows[row.Index].Cells[15].Value = "";
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
                            //Se o Código de Barras For novo Realiza o cadastro                  
                            else {
                                    //Cadastrar Código de Barras Novo
                                if (nItem.AtualizarCodigoBarrasItem(Convert.ToInt32(dgvEstoque.CurrentRow.Cells[2].Value), Convert.ToInt32(dgvEstoque.CurrentRow.Cells[9].Value), e.FormattedValue.ToString()) != true) {

                                    MessageBox.Show("Erro ao cadastrar CódigoBarras!",
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);                               
                                }                                    
                            }
                    } 
                        else if(e.FormattedValue.ToString() == "" && e.FormattedValue.ToString() != dgvEstoque.CurrentRow.Cells[15].Value.ToString()){
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
                                        nItem.AtualizarCodigoBarrasItem(Convert.ToInt32(dgvEstoque.CurrentRow.Cells[2].Value), Convert.ToInt32(dgvEstoque.CurrentRow.Cells[9].Value), "");

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

        private void dgvEstoque_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btLancamento.PerformClick();
        }

        private void FrmEstoque_Load(object sender, EventArgs e)
        {
            tbBuscarProduto.Focus();
        }

        private void btCodigoBarras_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            FrmCodigoBarras frmCodigoBarras = new FrmCodigoBarras();
            resposta = frmCodigoBarras.ShowDialog();

            if (resposta == DialogResult.Yes)
            {
                pbBuscarEstoque_Click(null, null);
            }

        }

    }
}
