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
    public partial class FrmAlterarExcluirProduto : Form
    {
        Produto produtoCorrente = new Produto();
        //-----------Inicia no formulário pegando a localização do projeto
        String LocalSolution;
        public String nomeProdutoSelecionado = "";


        public Produto objProduto = new Produto();
        public ProdutoCor objProdutoCor = new ProdutoCor();
        public ProdutoCorLista listaProdutoCor = new ProdutoCorLista();

        public NegProduto nProduto = new NegProduto();
        public NegProdutoCor nProdutoCor = new NegProdutoCor();

        //-------------Camada de negocios
        public NegGenero nGenero = new NegGenero();
        public NegGrade nGrade = new NegGrade();
        public NegFornecedor nFornecedor = new NegFornecedor();
        //Classe metodos de Validção 
        Formulas.Metodos metodos = new Formulas.Metodos();

        //----------Lista de imagens e Seus respectivos caminhos
        List<Image> ListaImagens = new List<Image>();

        //-----------Cores
        NegCor nCor = new NegCor();
        public CorLista corLista;
        public Cor corSelecionado;

        //public CorLista corListaTemp;
        public Cor corSelecionadoTemp;

        public FrmAlterarExcluirProduto(Produto produto)
        {
            InitializeComponent();
            this.produtoCorrente = produto;
        }

        //--------------Metodos de Validação
        public void metodoIniciaFormulario()
        {
            //Buscal Local que a Solution Está sendo Executada no Computador
            LocalSolution = Environment.CurrentDirectory;
            // This will get the current PROJECT directory
            LocalSolution = Directory.GetParent(LocalSolution).Parent.Parent.FullName;

            tbCodigo.Text = produtoCorrente.codigoProduto.ToString();
            tbDescricao.Text = produtoCorrente.descricaoProduto;
            tbReferencia.Text = produtoCorrente.referenciaProduto;
            cbSexo.SelectedItem = produtoCorrente.sexoProduto;
            mtbCusto.Text = (produtoCorrente.precoCustoProduto * 100).ToString();
            mtbVenda.Text = (produtoCorrente.precoVendaProduto * 100).ToString();
            //-------------Objetos
            tbGenero.Text = produtoCorrente.Genero.nomeGenero;
            tbGrade.Text = produtoCorrente.Grade.nomeGrade;
            tbFornecedor.Text = produtoCorrente.Fornecedor.nomeFantasiaFornecedor;

            //instancia objeto produto 
            objProduto = produtoCorrente;
            metodoAtualizaGrideTemp();
        }

        //Metodo para validar campos
        public Boolean metodoValidaCampos()
        {
            if (tbDescricao.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe a Descrição do Produto!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbDescricao.Clear();
                tbDescricao.Focus();

                return false;
            }
            else if (tbReferencia.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe a Referência do Produto!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbReferencia.Clear();
                tbReferencia.Focus();

                return false;
            }
            else if (cbSexo.SelectedItem == null)
            {
                MessageBox.Show("Informe o Sexo que é destinado o Produto!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbSexo.SelectedItem = null;
                cbSexo.Focus();

                return false;
            }
            else if (tbGenero.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o Gênero do Produto!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbGenero.Clear();
                tbGenero.Focus();

                return false;
            }
            else if (tbGrade.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe a Grade do Produto!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbGrade.Clear();
                tbGrade.Focus();

                return false;
            }
            else if (tbFornecedor.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o Fornecedor do Produto!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbFornecedor.Clear();
                tbFornecedor.Focus();

                return false;
            }
            else if (mtbCusto.Text.Trim() == String.Empty || mtbCusto.Text == "0,00")
            {
                MessageBox.Show("Informe o Preço de custo do produto!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbCusto.Clear();
                mtbCusto.Focus();

                return false;
            }
            else if (mtbVenda.Text == String.Empty || mtbVenda.Text == "0,00")
            {
                MessageBox.Show("Informe o preço de venda do produto!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbVenda.Clear();
                mtbVenda.Focus();
                return false;
            }
            else if (dgvCorProduto.RowCount == 0)
            {
                MessageBox.Show("Informe as Cores do Produto!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbCor.Focus();

                return false;
            }
            else
                return true;


        }

        //--------------Metodos para  manupular as imagens
        //metodo exibe imagem do produto selecionada
        public void metodoExibirImagem() {

            if (dgvCorProduto.RowCount > 0)
            {
                btSelecionar.Enabled = true;
                int posicaoImagem = Convert.ToInt32(dgvCorProduto.CurrentRow.Cells[3].Value);

                lbContadorImagens.Text = posicaoImagem.ToString();
                lbNomeCorImagem.Text = tbReferencia.Text + (dgvCorProduto.CurrentRow.Cells[1].Value).ToString();

                //-------------------Exibe imagem selecionada de acordo com a posicao
                if (ListaImagens.Count > 0 && posicaoImagem < ListaImagens.Count && ListaImagens[posicaoImagem] != null)
                {

                    pbImagemProduto.Image = ListaImagens[posicaoImagem];
                }
                else
                {

                    pbImagemProduto.Image = global::Apresentacao.Properties.Resources.imgDefaut;
                }
            }          
        
        }

        //Volta os Valores padrões do remover
        public void metodoDefautExcluir()
        {

            if (dgvCorProduto.RowCount > 0)
            {
                //dgvCorProduto.Rows[0].Selected = true;
                string codigoCorSelecionadoTemp = Convert.ToInt32(dgvCorProduto.CurrentRow.Cells[0].Value).ToString();
                string nomeCorSelecionadoTemp = tbReferencia.Text + (dgvCorProduto.CurrentRow.Cells[1].Value).ToString();
                int posicaoImagem = Convert.ToInt32(dgvCorProduto.CurrentRow.Cells[3].Value);

                btSelecionar.Enabled = true;
                lbNomeCorImagem.Text = nomeCorSelecionadoTemp;//"Cor Imagem";
                lbContadorImagens.Text = codigoCorSelecionadoTemp;//"0";
                if (ListaImagens.Count == 0)
                {
                    pbImagemProduto.Image = global::Apresentacao.Properties.Resources.imgDefaut;
                }
                else
                {
                    if (ListaImagens[posicaoImagem] != null)
                    {
                        pbImagemProduto.Image = ListaImagens[posicaoImagem];
                    }
                    else
                        pbImagemProduto.Image = global::Apresentacao.Properties.Resources.imgDefaut;
                }
            }
            //Caso gride esteja 0 itens ele limpa todos os valores
            else if (dgvCorProduto.RowCount == 0)
            {
                metodoDefaut();
            }

        }

        //Salvar nova imagem pb.save assim que e selecionada e salva(e vinculada com o produto)
        public Boolean metodoSalvarImagem(string nomeImagem)
        {
            try
            {
                //Verifica se pasta imagens existe
                bool existeDiretorio = Directory.Exists(LocalSolution + "\\Imagens");

                //Se a imagem foi selecionada e diretorio existe cria a imagem 
                if ((existeDiretorio == true))
                {
                    //Pega po valor do contador do gride para salvar a imagem 
                    string caminhoImagem = LocalSolution + "\\Imagens\\" + nomeImagem + ".jpeg";
                    pbImagemProduto.Image.Save(caminhoImagem);
                    return true;
                }

                else if (existeDiretorio == false)
                {

                    MessageBox.Show("Não foi Possivel salvar imagem Imóvel", "Imagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
        }

        //Metodo altera nome das imagens dos produtos
        public Boolean metodoAlterarNomeImagem()
        {
            try
            {
                foreach (DataGridViewRow row in dgvCorProduto.Rows)
                {
                    int codigoProduto = Convert.ToInt32(tbCodigo.Text);
                    int codigoCor = Convert.ToInt32(row.Cells[0].Value);
                    string imgProduto = tbReferencia.Text + row.Cells[1].Value;

                    //Alterar nome da imagem no Banco de dados
                    if (nProdutoCor.AtualizarImagemProdutoCor(codigoProduto,codigoCor,imgProduto) == true)
                    {
                        //-----Pega nome da imagem antiga a ser alterada
                        string imgAlt = LocalSolution + "\\Imagens\\" + row.Cells[2].Value + ".jpeg";
                        //-----Pega nome da Cor e nova referencia
                        string imgAltNova = LocalSolution + "\\Imagens\\" + tbReferencia.Text + row.Cells[1].Value + ".jpeg";

                        //Verifica se a imagem existe cellula 3 esta nome da imagem
                        if (System.IO.File.Exists(imgAlt) == true)
                        {
                            //Realiza a alteração do nome da imagem 
                            File.Move(imgAlt, imgAltNova);
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //------------------Metodos de Exclusão
        //Exclui a imagem referente ao produto do próprio diretório de Imagens
        public Boolean metodoExcluirImagemDiretorio(string localImgem)
        {
            try
            {

                System.IO.File.Delete((localImgem));
                return true;

            }catch (Exception ex){

                MessageBox.Show(ex.Message, "Erro",
                MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return false;
            }
        }

        //---------------Gride Cores
        //atualiza os valores no Data Grid Cor
        private void AtualizarDataGridCor()
        {
            this.dgvCor.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.corLista.Count > 0)
            {
                this.dgvCor.Rows.Add(this.corLista.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (Cor cor in this.corLista)
            {

                        this.dgvCor[0, indice].Value = cor.codigoCor;
                        this.dgvCor[1, indice].Value = cor.nomeCor;

                        indice++;     
            }

            dgvCor.Update();

        }

        //atualiza Gride 
        public void metodoAtualizaGride()
        {
            this.corLista = nProdutoCor.BuscarCorProdutoPorNome(tbCor.Text, produtoCorrente.codigoProduto);
            AtualizarDataGridCor();
        }

        //----------------Gride Temporário
        private void AtualizarDataGridCorTemp()
        {
            this.dgvCorProduto.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.listaProdutoCor.Count > 0)
            {
                this.dgvCorProduto.Rows.Add(this.listaProdutoCor.Count);
            }
            else
            {
                return;
            }

            //Buscal Local que a Solution Está sendo Executada no Computador
            string LocalSolution = Environment.CurrentDirectory;
            // This will get the current PROJECT directory
            LocalSolution = Directory.GetParent(LocalSolution).Parent.Parent.FullName;
            ListaImagens = new List<Image>();

            int indice = 0;
            foreach (ProdutoCor produtocor in this.listaProdutoCor)
            {
                //this.dgvCorProduto[0, indice].Value = produtocor.Produto.codigoProduto;
                this.dgvCorProduto[0, indice].Value = produtocor.Cor.codigoCor;
                this.dgvCorProduto[1, indice].Value = produtocor.Cor.nomeCor;
                this.dgvCorProduto[2, indice].Value = produtocor.ImagemProduto;
                this.dgvCorProduto[3, indice].Value = indice;

                //Verifica se a imagem existe
                if (System.IO.File.Exists(LocalSolution + "\\Imagens\\" + produtocor.ImagemProduto + ".jpeg") == true)
                {             
                    Image img;
                    Bitmap img2;
                    img = (System.Drawing.Image.FromFile(LocalSolution + "\\Imagens\\" + produtocor.ImagemProduto + ".jpeg"));
                    img2 = new Bitmap(img);
                    img.Dispose();

                    ListaImagens.Add(img2);
           
                }
                    //se ela não existir define a a posicao dela na lista como nulla
                else {
                    ListaImagens.Add(null);
                }

                indice++;
            }
            dgvCorProduto.Update();

        }

        //atualiza Gride Temporário
        public void metodoAtualizaGrideTemp()
        {
            this.listaProdutoCor = nProdutoCor.BuscarCorProdutoPorCodigo(produtoCorrente.codigoProduto);
            AtualizarDataGridCorTemp();
        }

        //----------------Movimentação do Gride
        //metodo avanca item do dataGride
        public void metodoAvancar(int contador)
        {

            contador = contador + 1;
            if (dgvCorProduto.RowCount > contador)
            {
                dgvCorProduto.CurrentCell = dgvCorProduto.Rows[contador].Cells[0];
            }
            else
            {
                contador = 0;
                dgvCorProduto.CurrentCell = dgvCorProduto.Rows[contador].Cells[0];
            }

            //----Exibe Imagem Posicao
            if (dgvCorProduto.RowCount > 0)
            {

                btSelecionar.Enabled = true;
                int posicaoImagem = Convert.ToInt32(dgvCorProduto.CurrentRow.Cells[3].Value);

                lbContadorImagens.Text = posicaoImagem.ToString();
                lbNomeCorImagem.Text = tbReferencia.Text + (dgvCorProduto.CurrentRow.Cells[1].Value).ToString();

                //-------------------Exibe imagem selecionada de acordo com a posicao
                if (ListaImagens.Count > 0 && posicaoImagem < ListaImagens.Count && ListaImagens[posicaoImagem] != null)
                {

                    pbImagemProduto.Image = ListaImagens[posicaoImagem];
                }
                else
                {

                    pbImagemProduto.Image = global::Apresentacao.Properties.Resources.imgDefaut;
                }
            }

        }

        //metodo volta item do dataGride
        public void metodoVoltar(int contador)
        {
            if (contador > 0)
            {
                contador = contador - 1;
                dgvCorProduto.CurrentCell = dgvCorProduto.Rows[contador].Cells[0];
            }
            else
            {

                dgvCorProduto.CurrentCell = dgvCorProduto.Rows[dgvCorProduto.RowCount - 1].Cells[0];
                contador = dgvCorProduto.RowCount - 1;
            }

            //----Exibe Imagem Posicao
            if (dgvCorProduto.RowCount > 0)
            {

                btSelecionar.Enabled = true;
                int posicaoImagem = Convert.ToInt32(dgvCorProduto.CurrentRow.Cells[3].Value);

                lbContadorImagens.Text = posicaoImagem.ToString();
                lbNomeCorImagem.Text = tbReferencia.Text + (dgvCorProduto.CurrentRow.Cells[1].Value).ToString();

                //-------------------Exibe imagem selecionada de acordo com a posicao
                if (ListaImagens.Count > 0 && posicaoImagem < ListaImagens.Count && ListaImagens[posicaoImagem] != null)
                {

                    pbImagemProduto.Image = ListaImagens[posicaoImagem];
                }
                else
                {

                    pbImagemProduto.Image = global::Apresentacao.Properties.Resources.imgDefaut;
                }
            }


        }

        //Volta Todos os valores padrão
        public void metodoDefaut()
        {
            btSelecionar.Enabled = false;
            lbNomeCorImagem.Text = "Cor Imagem";
            lbContadorImagens.Text = "0";
            ListaImagens.Clear();
            pbImagemProduto.Image = global::Apresentacao.Properties.Resources.imgDefaut;
        }

        //----------Inicia formulário preenchido
        private void FrmAlterarExcluirProduto_Load(object sender, EventArgs e)
        {
            metodoIniciaFormulario();
            metodoExibirImagem();

        }

        //----------Campos  Moeda Custo e Venda
        private void mtbCusto_TextChanged(object sender, EventArgs e)
        {
            metodos.metodoMoedaMTB(ref mtbCusto);
        }

        private void mtbVenda_TextChanged(object sender, EventArgs e)
        {
            metodos.metodoMoedaMTB(ref mtbVenda);
        }

        //--------------------Validações
        private void tbDescricao_Leave(object sender, EventArgs e)
        {
            //Verifica se o campo for preenchido
            if (tbDescricao.Text == String.Empty)
            {
                epProduto.SetError(tbDescricao, "Campo obrigatório!");
                return;
            }
            else
                epProduto.Clear();
        }

        private void tbReferencia_Leave(object sender, EventArgs e)
        {
            try
            {
                Produto prod = new Produto();

                if (tbReferencia.Text == String.Empty)
                {
                    epProduto.SetError(tbReferencia, "Campo obrigatório!");
                    return;
                }
                else
                    epProduto.Clear();

                //Verifica se o valor digitado não é o mesmo que esta no objto
                if (tbReferencia.Text != produtoCorrente.referenciaProduto)
                {
                    prod = nProduto.ValidarCadastroProdutoPorReferencia(tbReferencia.Text);
                    if (prod != null)
                    {
                        //Criando Caixa de dialogo
                        FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Cor já Existe",
                        " Cód: " + prod.codigoProduto +
                        " Descrição: " + prod.descricaoProduto,
                        Properties.Resources.DialogWarning,
                        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                        Color.White,
                        "Ok", "",
                        false);
                        frmCaixa.ShowDialog();
                        //Volta parametro para caixa de texto
                        tbReferencia.Clear();
                        tbReferencia.Focus();
                    }
                }

            }
            catch (Exception ex)
            {
                //Criando Caixa de dialogo
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro",
                ex.Message,
                Properties.Resources.DialogErro,
                Color.White,
                Color.Black,
                "Ok", "",
                false);
                frmCaixa.ShowDialog();
            }
        }

        private void cbSexo_Leave(object sender, EventArgs e)
        {
            //Verifica se o campo for preenchido
            if (cbSexo.SelectedItem == null)
            {
                epProduto.SetError(cbSexo, "Campo obrigatório!");
                return;
            }
            else
                epProduto.Clear();
        }

        private void tbGenero_Leave(object sender, EventArgs e)
        {
            //Verifica se o campo for preenchido
            if (tbGenero.Text == String.Empty || objProduto.Genero == null)
            {
                epProduto.SetError(tbGenero, "Campo obrigatório!");
                return;
            }
            else
                epProduto.Clear();
        }

        private void tbGrade_Leave(object sender, EventArgs e)
        {
            //Verifica se o campo for preenchido
            if (tbGrade.Text == String.Empty || objProduto.Grade == null)
            {
                epProduto.SetError(tbGrade, "Campo obrigatório!");
                return;
            }
            else
                epProduto.Clear();
        }

        private void tbFornecedor_Leave(object sender, EventArgs e)
        {
            //Verifica se o campo for preenchido
            if (tbFornecedor.Text == String.Empty || objProduto.Fornecedor == null)
            {
                epProduto.SetError(tbFornecedor, "Campo obrigatório!");
                return;
            }
            else
                epProduto.Clear();
        }

        private void mtbCusto_Leave(object sender, EventArgs e)
        {
            //Verifica se o campo for preenchido
            if (mtbCusto.Text == String.Empty)
            {
                epProduto.SetError(mtbCusto, "Campo obrigatório!");
                return;
            }
            else
                epProduto.Clear();
        }

        private void mtbVenda_Leave(object sender, EventArgs e)
        {
            //Verifica se o campo for preenchido
            if (mtbVenda.Text == String.Empty)
            {
                epProduto.SetError(mtbVenda, "Campo obrigatório!");
                return;
            }
            else
                epProduto.Clear();
        }

        //--------------------------Botões
        private void pbDesfazer_Click(object sender, EventArgs e)
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
                metodoIniciaFormulario();
                epProduto.Clear();

            }
        }

        private void pbGenero_Click(object sender, EventArgs e)
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

        private void pbGrade_Click(object sender, EventArgs e)
        {
            int n;
            bool ehUmNumero = int.TryParse(tbGrade.Text, out n);
            if (ehUmNumero == true)
            {
                objProduto.Grade = nGrade.BuscarGradePorCodigo(n);
                if (objProduto.Grade != null)
                {
                    this.tbGrade.Text = objProduto.Grade.nomeGrade;
                    tbFornecedor.Focus();
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
                    tbFornecedor.Focus();
                }

            }    
        }

        private void pbFornecedor_Click(object sender, EventArgs e)
        {
            int n;
            bool ehUmNumero = int.TryParse(tbFornecedor.Text, out n);
            if (ehUmNumero == true)
            {
                objProduto.Fornecedor = nFornecedor.BuscarFornecedorPorCodigo(n);
                if (objProduto.Fornecedor != null)
                {
                    this.tbFornecedor.Text = objProduto.Fornecedor.nomeFantasiaFornecedor;
                    mtbCusto.Focus();
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
                    mtbCusto.Focus();
                }

            }    
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
          try{  //Valida Preenchimento chamando função
                tbDescricao_Leave(null, null);

                //Validas se os campos estão preenchidos
                if (metodoValidaCampos() == true)
                {

                    DialogResult resposta;
                    //Criando Caixa de dialogo
                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Alteração",
                    " Deseja realmente Alterar os dados do Produto ?",
                    Properties.Resources.Alterar,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Confirmar", "Cancelar",
                    false);

                    //Verifica se o usuário realmente quer alterar os dados do cliente.
                    resposta = frmCaixa.ShowDialog();
                    if (resposta == DialogResult.Yes)
                    {
                        Produto produtoAlterado = new Produto();
                        produtoAlterado.Genero = new Genero();
                        produtoAlterado.Grade = new Grade();
                        produtoAlterado.Fornecedor = new Fornecedor();

                        produtoAlterado.codigoProduto = int.Parse(tbCodigo.Text);
                        produtoAlterado.descricaoProduto = tbDescricao.Text;
                        produtoAlterado.referenciaProduto = tbReferencia.Text;
                        produtoAlterado.sexoProduto = cbSexo.SelectedItem.ToString();
                        produtoAlterado.Genero = objProduto.Genero;
                        produtoAlterado.Grade = objProduto.Grade;
                        produtoAlterado.Fornecedor = objProduto.Fornecedor;
                        produtoAlterado.precoCustoProduto = Convert.ToDouble(mtbCusto.Text);
                        produtoAlterado.precoVendaProduto = Convert.ToDouble(mtbVenda.Text);

                        //Realizando a Alteração caso alteração for concluida com sucesso realiza a alteração dos nomes da imagens dos produtos
                        if (nProduto.AtualizarProduto(produtoAlterado) == true)
                        {

                            //------------Verifica se a referênia foi alterada para realizar a alteração das imagens do produto
                            if (tbReferencia.Text != produtoCorrente.referenciaProduto)
                            {
                                metodoAlterarNomeImagem();
                            }

                            //Criando Caixa de dialogo
                            frmCaixa = new FrmCaixaDialogo("Alteração",
                            "Produto Alterada com sucesso !\r\n" +
                            "Alterações Finalizadas ?",
                            Properties.Resources.DialogOK,
                            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                            Color.White,
                            "Sim", "Não",
                            false);
                            resposta = frmCaixa.ShowDialog();

                            if (resposta == DialogResult.Yes)
                            {
                                //Retornando que exclusão foi realizada com sucesso
                                this.DialogResult = DialogResult.Yes;
                                this.Close();
                            }
                            else
                            metodoAtualizaGride();
                            metodoAtualizaGrideTemp();

                            lbNomeCorImagem.Text = tbReferencia.Text + dgvCorProduto.SelectedRows[0].Cells[1].Value.ToString();
                            lbContadorImagens.Text = dgvCorProduto.SelectedRows[0].Cells[3].Value.ToString();

                            nomeProdutoSelecionado = tbDescricao.Text;
                            return;

                        }
                        else {

                            MessageBox.Show("Não foi possível atualizar os dados da Produto. Erro Banco de Dados!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível atualizar os dados da Produto. Motivo: " + ex.Message);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                //Caso o produto esteja vinculado com cores realiza a exclusão de todas as cores
                if (dgvCorProduto.RowCount > 0)
                {
                    DialogResult resposta;
                    //Criando Caixa de dialogo
                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Exclusão",
                    " O Produto possui Cores deseja realmente Excluir o Produto ?",
                    Properties.Resources.Excluir,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Confirmar", "Cancelar",
                    false);

                    resposta = frmCaixa.ShowDialog();
                    if (resposta == DialogResult.Yes)
                    {
                        //Exclui lista de cores do Produto e Imagens do produto
                        if (nProdutoCor.ExcluirListaCorProduto(listaProdutoCor, LocalSolution + "\\Imagens\\") == true)
                        {
                            ListaImagens.Clear();
                            if (nProduto.ExcluirProduto(produtoCorrente) == true)
                            {
                                //Criando Caixa de dialogo
                                frmCaixa = new FrmCaixaDialogo("Exclusão",
                               " Exclusão realizada com sucesso !",
                               Properties.Resources.DialogOK,
                               System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                               Color.White,
                               "Ok", "",
                               false);
                                frmCaixa.ShowDialog();
                                //Retornando que exclusão foi realizada com sucesso
                                this.DialogResult = DialogResult.Yes;
                                this.Close();
                            }
                            else
                            {//Produto está viculado com Entrada de Estoque e Vendas
                                //Criando Caixa de dialogo
                                frmCaixa = new FrmCaixaDialogo("Exclusão",
                                "Não foi possível realizar a exclusão do Produto ! \r\n" +
                                "Produto possui Estoque e Histórico de Vendas!",
                                Properties.Resources.DialogWarning,
                                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                Color.White,
                                "Ok", "",
                                false);
                                frmCaixa.ShowDialog();
                                //Fecha o formulário
                                this.DialogResult = DialogResult.Cancel;
                                this.Close();
                            }
                        }
                        else
                        {
                            //Produto está viculado com Entrada de Estoque e Vendas
                            //Criando Caixa de dialogo
                            frmCaixa = new FrmCaixaDialogo("Exclusão",
                            "Não foi possível realizar a exclusão das Cores do Produto ! \r\n" +
                            "Produto possui Estoque e Histórico de Vendas!",
                            Properties.Resources.DialogWarning,
                            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                            Color.White,
                            "Ok", "",
                            false);
                            frmCaixa.ShowDialog();
                            //Fecha o formulário
                            this.DialogResult = DialogResult.Cancel;
                            this.Close();
                        }
                    }
                }
                //Se produto não tiver cores realiza a exclusão do Produto
                //Caso não haja itens no gride ele realiza a exclusão do produto automaticamente
                else
                {
                    if (nProduto.ExcluirProduto(produtoCorrente) == true)
                    {
                        //Criando Caixa de dialogo
                        FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Exclusão",
                        " Exclusão realizada com sucesso !",
                        Properties.Resources.DialogOK,
                        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                        Color.White,
                        "Ok", "",
                        false);
                        frmCaixa.ShowDialog();
                        //Retornando que exclusão foi realizada com sucesso
                        this.DialogResult = DialogResult.Yes;
                        this.Close();
                    }
                    else
                    {//Produto está viculado com Entrada de Estoque e Vendas
                        //Criando Caixa de dialogo
                        FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Exclusão",
                        "Não foi possível realizar a exclusão do Produto ! \r\n" +
                        "Produto possui Estoque e Histórico de Vendas!",
                        Properties.Resources.DialogWarning,
                        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                        Color.White,
                        "Ok", "",
                        false);
                        frmCaixa.ShowDialog();
                        //Fecha o formulário
                        this.DialogResult = DialogResult.Cancel;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message,
                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

        //-----------------------Buscar Cores
        private void pbBuscarCor_Click(object sender, EventArgs e)
        {
            this.corLista = nProdutoCor.BuscarCorProdutoPorNome(tbCor.Text, produtoCorrente.codigoProduto);
            AtualizarDataGridCor();
        }

        private void pbCor_Click(object sender, EventArgs e)
        {
            DialogResult resultado;

            FrmSelecionarCor frmCor = new FrmSelecionarCor();
            resultado = frmCor.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                this.tbCor.Text = frmCor.corSelecionado.nomeCor;
                pbBuscarCor_Click(null, null);
            }
        }

        private void tbCor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbBuscarCor_Click(null, null);
                e.Handled = true;
            }
        }

        //----------------Data Gride Adicionar - Remover - Limpar e Exibir Imagens
        private void btAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCor.RowCount > 0)
                {
                    int codigoCorSelecionado = Convert.ToInt32(dgvCor.CurrentRow.Cells[0].Value);
                    string nomeCorSelecionado = (dgvCor.CurrentRow.Cells[1].Value).ToString();

                    corSelecionado = new Cor();
                    corSelecionado.codigoCor = codigoCorSelecionado;
                    corSelecionado.nomeCor = nomeCorSelecionado;

                    ProdutoCor produtoCorAdd = new ProdutoCor();
                    produtoCorAdd.Cor = corSelecionado;
                    produtoCorAdd.Produto = produtoCorrente;
                    produtoCorAdd.ImagemProduto = produtoCorrente.referenciaProduto+corSelecionado.nomeCor;

                    nProdutoCor.CadastrarProdutoCor(produtoCorAdd);


                    metodoAtualizaGride();
                    metodoAtualizaGrideTemp();

                    //-----------------Seleciona o ultimo item adiconado no DataGride 
                    dgvCorProduto.CurrentCell = dgvCorProduto.Rows[dgvCorProduto.Rows.Count - 1].Cells[0];
                    lbNomeCorImagem.Text = tbReferencia.Text + dgvCorProduto.SelectedRows[0].Cells[1].Value.ToString();
                    lbContadorImagens.Text = dgvCorProduto.SelectedRows[0].Cells[3].Value.ToString();
                    int posicaoImagem = Convert.ToInt32(dgvCorProduto.SelectedRows[0].Cells[3].Value);
                    btSelecionar.Enabled = true;

                    //-------------------Exibe imagem selecionada de acordo com a posicao
                    if (ListaImagens.Count > 0 && posicaoImagem < ListaImagens.Count && ListaImagens[posicaoImagem] != null)
                    {
                        pbImagemProduto.Image = ListaImagens[posicaoImagem];
                    }
                    else
                    {

                        pbImagemProduto.Image = global::Apresentacao.Properties.Resources.imgDefaut;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro ao Adicionar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbCor.Focus();
                return;
            }
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            try
            {
                //Se for o ultimo item do data gride realiza a exclusão do produto
                if (dgvCorProduto.RowCount == 1)
                {
                    btExcluir.PerformClick();

                }
                else
                {
                    //Pega as informações do Produto que será Excluido
                    ProdutoCor produtoCorRem = new  ProdutoCor();
                    produtoCorRem.Cor = new Cor();
                    produtoCorRem.Produto = new Produto();

                    produtoCorRem.Produto = produtoCorrente;
                    produtoCorRem.Cor.codigoCor = Convert.ToInt32(dgvCorProduto.CurrentRow.Cells[0].Value);
                    produtoCorRem.Cor.nomeCor = (dgvCorProduto.CurrentRow.Cells[1].Value).ToString();
                    produtoCorRem.ImagemProduto = (dgvCorProduto.CurrentRow.Cells[2].Value).ToString();
                    int posicaoImagem = Convert.ToInt32(dgvCorProduto.CurrentRow.Cells[3].Value);

                    //----------Se não for possivel excluir exibe a mensagem de erro -> ProdutoCor relacionado com Estoque e Venda
                    if (nProdutoCor.ExcluirCorProduto(produtoCorRem) == false)
                    {
                        MessageBox.Show("Não foi possivel remover a Cor?", "Erro",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    }
                    else
                    {

                        //----------------Remove Imagens Vinculadas as cores caso a exclusão for OK
                        if (ListaImagens.Count > 0 && posicaoImagem < ListaImagens.Count)
                        {   
                            //Verifica se a imagem existe
                            if (System.IO.File.Exists(LocalSolution + "\\Imagens\\" + produtoCorRem.ImagemProduto + ".jpeg") == true)
                            {
                                //Deleta a imagem referente a cor do produto
                                if (metodoExcluirImagemDiretorio(LocalSolution + "\\Imagens\\" + produtoCorRem.ImagemProduto + ".jpeg") == true)
                                {
                                    ListaImagens.RemoveAt(posicaoImagem);

                                }
                                  else
                                   {
                                    MessageBox.Show("Não foi possivel remover a Imagem do Produto?", "Erro",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                                    }
                                }

                            //-----------------------------Exibe Imagem restantes do Produtos que ainda continuão no Gride
                            if (ListaImagens.Count == 0)
                            {

                                pbImagemProduto.Image = global::Apresentacao.Properties.Resources.imgDefaut;
                            }
                        }
                        //----------Atualiza valores do Gride
                        metodoAtualizaGrideTemp();
                        metodoAtualizaGride();

                        if (dgvCorProduto.RowCount > 0 && posicaoImagem != 0)
                        {
                            //Coloca a seleção no ultimo item adicionado no DATAGRIDE
                            dgvCorProduto.CurrentCell = dgvCorProduto.Rows[posicaoImagem - 1].Cells[0];
                        }
                        //---------Retorna valores padrão até selecionar novo item
                        metodoDefautExcluir();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro ao Remover", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbCor.Focus();
                return;
            }
        }

        private void dgvCorProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvCorProduto.RowCount > 0){
             
             btSelecionar.Enabled = true;
             int posicaoImagem = Convert.ToInt32(dgvCorProduto.CurrentRow.Cells[3].Value);

             lbContadorImagens.Text = posicaoImagem.ToString();
             lbNomeCorImagem.Text = tbReferencia.Text+(dgvCorProduto.CurrentRow.Cells[1].Value).ToString();
             
             //-------------------Exibe imagem selecionada de acordo com a posicao
             if (ListaImagens.Count > 0 && posicaoImagem < ListaImagens.Count && ListaImagens[posicaoImagem] != null)
             {
                     
                 pbImagemProduto.Image = ListaImagens[posicaoImagem];
             }
             else { 
             
             pbImagemProduto.Image = global::Apresentacao.Properties.Resources.imgDefaut;
              }
            }          
        }

        //-----------------Navegação Para adicionar e selecionar Imagens para os Produtos
        private void btVoltar_Click(object sender, EventArgs e)
        {
            if (dgvCorProduto.RowCount > 1)
            {
                int contador = dgvCorProduto.SelectedRows[0].Index;
                metodoVoltar(contador);
            }
        }

        private void btAvancar_Click(object sender, EventArgs e)
        {
            if (dgvCorProduto.RowCount > 1)
            {
                int contador = dgvCorProduto.SelectedRows[0].Index;

                metodoAvancar(contador);

            }
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            //Define o Local do Desktop da Maquina
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = desktop;
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            open.RestoreDirectory = true;
            DialogResult result = open.ShowDialog();
            if (result == DialogResult.OK)
            {
                pbImagemProduto.Image = System.Drawing.Image.FromFile(open.FileName);

           //------------------Slava a imagem -> quando o gride e carregado ele atualiza a lista
           //Deleta a imagem referente a cor do produto
                if (metodoSalvarImagem(lbNomeCorImagem.Text) == true)
                {
                    int posicaoImagem = Convert.ToInt32(dgvCorProduto.CurrentRow.Cells[3].Value);
                    ListaImagens[posicaoImagem] = pbImagemProduto.Image;
                }
                else {
                    MessageBox.Show("Não foi possivel remover a Imagem do Produto?", "Erro",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }

            }
        }

        private void btRemoverImagem_Click(object sender, EventArgs e)
        {
            int posicaoImagem = Convert.ToInt32(dgvCorProduto.CurrentRow.Cells[3].Value);

            if (ListaImagens.Count > 0 && posicaoImagem < ListaImagens.Count)
            {
                String imgProduto = (dgvCorProduto.CurrentRow.Cells[2].Value).ToString();

                //Verifica se a imagem existe
                if (System.IO.File.Exists(LocalSolution + "\\Imagens\\" + imgProduto + ".jpeg") == true)
                {
                    //Deleta a imagem referente a cor do produto
                    if (metodoExcluirImagemDiretorio(LocalSolution + "\\Imagens\\" + imgProduto + ".jpeg") == true)
                    {
                        ListaImagens[posicaoImagem]= null;
                        pbImagemProduto.Image = global::Apresentacao.Properties.Resources.imgDefaut;

                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel remover a Imagem do Produto?", "Erro",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    }
                }
            }

            //-----------------------------Exibe Imagem restantes do Produtos que ainda continuão no Gride
            if (ListaImagens.Count == 0)
            {

                pbImagemProduto.Image = global::Apresentacao.Properties.Resources.imgDefaut;
            }
        }
     
       //------------------------ Atalhos 
        private void tbGenero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbGenero_Click(null, null);
                e.Handled = true;
            }
        }

        private void tbGrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbGrade_Click(null, null);
                e.Handled = true;
            }
        }

        private void tbFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbFornecedor_Click(null, null);
                e.Handled = true;
            }
        }

        private void FrmAlterarExcluirProduto_KeyDown(object sender, KeyEventArgs e)
        {
            //atalho da tecla de atalho ESC
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {
                btSair.PerformClick();
            }
            //atalho para o botão cadastrar
            else if (e.KeyCode.Equals(Keys.F10) == true)
            {
                btAlterar.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.F6) == true)
            {
                btRemover.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.F12) == true)
            {
                btAdicionar.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.F5) == true)
            {
                pbBuscarCor_Click(null, null);
            }
            else if (e.KeyCode.Equals(Keys.F2) == true)
            {
                btExcluir.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.F4) == true)
            {
                btSelecionar.PerformClick();
            }
            //atalho da tecla de atalho ESC
            else if (e.KeyCode.Equals(Keys.Right) == true)
            {
                btAvancar.PerformClick();
            }
            //atalho da tecla de atalho ESC
            else if (e.KeyCode.Equals(Keys.Left) == true)
            {
                btVoltar.PerformClick();
            }
        }

        //----------------------Zomm Imagem
        private void pbImagemProduto_MouseEnter(object sender, EventArgs e)
        {
            pbImagemProdutoZoom.Image = pbImagemProduto.Image;
            pbImagemProdutoZoom.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pbImagemProduto_MouseLeave(object sender, EventArgs e)
        {
            pbImagemProdutoZoom.Image = Properties.Resources.imgDefaut;
            pbImagemProdutoZoom.BorderStyle = BorderStyle.None;
        }

        private void FrmAlterarExcluirProduto_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void dgvCor_DoubleClick(object sender, EventArgs e)
        {
            btAdicionar.PerformClick();
        }

        private void dgvCorProduto_DoubleClick(object sender, EventArgs e)
        {
            btRemover.PerformClick();
        }

    }
}
