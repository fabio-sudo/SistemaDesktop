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
    public partial class FrmCadastroProduto : Form
    {
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

        //ORDEM PARA ACessos Simultaneos
        int ordemBuscar = 0;

        //----------Lista de imagens e Seus respectivos caminhos
        List<Image>ListaImagens = new List<Image>();

        //-----------Cores
        NegCor nCor = new NegCor();
        public CorLista corLista;
        public Cor corSelecionado;

        public CorLista corListaTemp;
        public Cor corSelecionadoTemp;

        public FrmCadastroProduto()
        {
            InitializeComponent();
        }

        //--------------------------------------------------Métodos

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

        //Metodo para limpar os campos
        public void metodoLimpaCampos()
        {
            epProduto.Clear();
            tbDescricao.Clear();
            tbReferencia.Clear();
            cbSexo.SelectedItem = null;
            tbGenero.Clear();
            tbGrade.Clear();
            tbFornecedor.Clear();
            mtbCusto.Clear();
            mtbVenda.Clear();
            tbCor.Clear();

            btLimpar.PerformClick();
            dgvCor.Rows.Clear();

        }

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
                int posicaoImagem = Convert.ToInt32(dgvCorProduto.CurrentRow.Cells[2].Value);

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
                int posicaoImagem = Convert.ToInt32(dgvCorProduto.CurrentRow.Cells[2].Value);

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
        public void metodoDefaut() {
            btSelecionar.Enabled = false;
            lbNomeCorImagem.Text = "Cor Imagem";
            lbContadorImagens.Text = "0";
            ListaImagens.Clear();
            pbImagemProduto.Image = global::Apresentacao.Properties.Resources.imgDefaut;
        }

        //Volta os Valores padrões do remover
        public void metodoDefautExcluir() {

            if (dgvCorProduto.RowCount > 0)
            {
                //dgvCorProduto.Rows[0].Selected = true;
                string codigoCorSelecionadoTemp = Convert.ToInt32(dgvCorProduto.CurrentRow.Cells[0].Value).ToString();
                string nomeCorSelecionadoTemp = tbReferencia.Text + (dgvCorProduto.CurrentRow.Cells[1].Value).ToString();
                int posicaoImagem = Convert.ToInt32(dgvCorProduto.CurrentRow.Cells[2].Value);

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
                    }else
                        pbImagemProduto.Image = global::Apresentacao.Properties.Resources.imgDefaut;
                }
            }
            //Caso gride esteja 0 itens ele limpa todos os valores
            else if (dgvCorProduto.RowCount == 0)
            {
                metodoDefaut();
            }

        }

        //Salvar lista de imagens imagens tem que ficar vinculadas com COR e Referencia
        public Boolean metodoSalvarImagem()
        {
            //Metodo pega lista de imagens[0] e pega contador do [Gride] valida posicao  correta salva imagem com referencia e nome da cor
            try
            {
                //Buscal Local que a Solution Está sendo Executada no Computador
                string LocalSolution = Environment.CurrentDirectory;
                // This will get the current PROJECT directory
                LocalSolution = Directory.GetParent(LocalSolution).Parent.Parent.FullName;

                //Verifica se pasta imagens existe
                bool existeDiretorio = Directory.Exists(LocalSolution + "\\Imagens");

                int contador = 0;
                //Se a imagem foi selecionada e diretorio existe cria a imagem 
                if ((existeDiretorio == true))
                {
                  foreach (Image img in ListaImagens)
                    {              
                        //Salva as imagens existentes na lista
                        if(img != null){
                         //Procuara no data gride a ordem correta salvar as imagens
                            foreach (DataGridViewRow row in dgvCorProduto.Rows)
                            {
                                if (row.Cells[2].Value != null)
                                {
                                    if (Convert.ToInt32(row.Cells[2].Value) == (contador))
                                    {
                                        //Pega po valor do contador do gride para salvar a imagem 
                                        string nomeCor = row.Cells[1].Value.ToString();
                                        string caminhoImagem = LocalSolution + "\\Imagens\\" + tbReferencia.Text + nomeCor + ".jpeg";
                                        img.Save(caminhoImagem);
                                        break;
                                    }
                                }
                            }
                    }
                        contador++;
                    }
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

        //atualiza os valores no Data Grid Cor Temporário
        private void AtualizarDataGridCorTemp()
        {
            this.dgvCorProduto.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.corListaTemp.Count > 0)
            {
                this.dgvCorProduto.Rows.Add(this.corListaTemp.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (Cor cor in this.corListaTemp)
            {
                this.dgvCorProduto[0, indice].Value = cor.codigoCor;
                this.dgvCorProduto[1, indice].Value = cor.nomeCor;
                this.dgvCorProduto[2, indice].Value = indice;
                this.dgvCorProduto[3, indice].Value = cor.ordemCor;

                indice++;
            }

            dgvCorProduto.Update();

        }

        //atualiza Gride Temporário
        public void metodoAtualizaGrideTemp()
        {
            this.corListaTemp = nCor.BuscarCorTemp(ordemBuscar);
            AtualizarDataGridCorTemp();
        }

        //atualiza Gride 
        public void metodoAtualizaGride()
        {
            this.corLista = nCor.BuscarCorTempPorNome(tbCor.Text, ordemBuscar);
            AtualizarDataGridCor();
        }

        //Metodo adicionar listaDeProdutosCor
        public Boolean metodoAdicionarCorProduto(Produto prod){

            
            objProdutoCor.Produto = new Produto();
            listaProdutoCor = new ProdutoCorLista();

            //Enquanto tiver cores no gride vai cadastrando ProdutoCor
            foreach (Cor cor in this.corListaTemp)
            {
                objProdutoCor = new ProdutoCor();
                objProdutoCor.Cor = new Cor();

                objProdutoCor.Produto = prod;
                objProdutoCor.Cor = cor;
                objProdutoCor.ImagemProduto = prod.referenciaProduto + cor.nomeCor;

                listaProdutoCor.Add(objProdutoCor);

            }

            //-----------------------Realiza o cadastro da lista de ProdutoCor
            if(nProdutoCor.CadastrarProdutoCorLista(listaProdutoCor) == true)
            {

            return true;
            
            }
            else{
            
                return false;
            }

        }

        //-----------------------Botões
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
                //tbCaminhoImagem.Text = open.FileName;

                //------------------Adiciona imagem selecionada em lista
                if (dgvCorProduto.RowCount > 0)
                {
                    int posicaoImagem = Convert.ToInt32(dgvCorProduto.CurrentRow.Cells[2].Value);

                    if (ListaImagens.Count <= posicaoImagem)
                    {

                        while (ListaImagens.Count < posicaoImagem)
                        {

                            ListaImagens.Add(null);

                        }

                        ListaImagens.Insert(posicaoImagem, pbImagemProduto.Image);
                    }

                    else if (ListaImagens.Count > posicaoImagem)
                    {
                        ListaImagens[posicaoImagem] = pbImagemProduto.Image;
                    }

                    ListaImagens.Count();
                }
                else {
                    //Caso o usuário selecione a imagem antes de selecionar a cor
                    int posicaoImagem = 0;

                    if (ListaImagens.Count <= posicaoImagem)
                    {

                        while (ListaImagens.Count < posicaoImagem)
                        {

                            ListaImagens.Add(null);

                        }

                        ListaImagens.Insert(posicaoImagem, pbImagemProduto.Image);
                    }

                    else if (ListaImagens.Count > posicaoImagem)
                    {
                        ListaImagens[posicaoImagem] = pbImagemProduto.Image;
                    }

                    ListaImagens.Count();
                            
                }

            }
            else

                return;
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            //Valida se todos os campos foram preenchidos
            if (metodoValidaCampos() == true)
            {
                try
                {
                    //--------------Produto
                    Produto produto = new Produto();
                    produto.Genero = new Genero();
                    produto.Grade = new Grade();
                    produto.Fornecedor = new Fornecedor();

                    //------------Busca o Valor do codigo do produto no banco de dados
                    produto.codigoProduto = nProduto.BuscarUltimoRegistroProduto()+1;

                    //---------Preenche os dados do produto com as informações do formulário
                    produto.descricaoProduto = tbDescricao.Text.Trim();//remove os espaços
                    produto.referenciaProduto = tbReferencia.Text.Trim();
                    produto.sexoProduto = cbSexo.Text;
                    produto.quantidadeProduto = 1;
                    produto.Genero = objProduto.Genero;
                    produto.Grade = objProduto.Grade;
                    produto.Fornecedor = objProduto.Fornecedor;
                    produto.precoCustoProduto = double.Parse(mtbCusto.Text);
                    produto.precoVendaProduto = double.Parse(mtbVenda.Text);
                    produto.dataProduto = DateTime.Now;

                    //-----------Cadastra o Produto
                    if (nProduto.CadastrarProduto(produto) == true)
                    { 
                          //------------Salva as imagens selecionadas
                          if(metodoSalvarImagem() == true){
                        
                    
                            //----------------------------ProdutoCor
                            if(metodoAdicionarCorProduto(produto) == true){

                              DialogResult resposta;
                              //Criando Caixa de dialogo
                              FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
                              " Cadastro Realizado com Sucesso! \r\n" +
                              "Deseja Continuar No Cadastro De Produto?",
                              Properties.Resources.DialogOK,
                              System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                              Color.White,
                              "Sim", "Não",
                              false);

                            resposta = frmCaixa.ShowDialog();
                            if (resposta != DialogResult.Yes)
                            {
                                this.DialogResult = DialogResult.OK;
                                this.Close();

                            }
                            else
                            metodoLimpaCampos();
                            tbDescricao.Focus();
                            epProduto.Clear();
                            return;                 
                        
                        }//-----------------Erro ao cadastrar PRODUTOCOR
                          else{
                              MessageBox.Show("Erro ao cadastrar cores do Produto!", "Erro Cores do Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                              tbDescricao.Focus();
                              return;
                             }         
                        }//------------------Erro ao cadastrar IMAGENS
                        else{
                        MessageBox.Show("Erro ao salvar imagens do Produto!", "Erro Imagem do Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbDescricao.Focus();
                        return;
                        }
                      }//---------------------Erro em Cadastrar o Produto
                    else{
                        MessageBox.Show("Erro ao cadastrar o Produto!", "Erro Cadastro Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbDescricao.Focus();
                        return;
                    }
                }
                catch (Exception ex)
                {
                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro",
                    "Erro ao cadastrar Produto: \r\n" + ex.Message,
                    Properties.Resources.DialogErro,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Ok", "",
                    false);
                    frmCaixa.ShowDialog();
                }
            }
        }
       
        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair do Cadastro de Produto ?",
            Properties.Resources.DialogQuestion,
            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
            Color.White,
            "Sim", "Não",
            false);

            resposta = frmCaixa.ShowDialog();
            if (resposta == DialogResult.Yes)
            {
                btLimpar.PerformClick();
                this.Close();

            }
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCor.RowCount > 0)
                {
                    int codigoCorSelecionado = Convert.ToInt32(dgvCor.CurrentRow.Cells[0].Value);
                    string nomeCorSelecionado = (dgvCor.CurrentRow.Cells[1].Value).ToString();
                    int ordemTamanhoSelecionado = ordemBuscar;

                    corSelecionado = new Cor();
                    corSelecionado.codigoCor = codigoCorSelecionado;
                    corSelecionado.nomeCor = nomeCorSelecionado;
                    corSelecionado.ordemCor = ordemTamanhoSelecionado;

                    nCor.CadastrarCorTemp(corSelecionado);


                    metodoAtualizaGride();
                    metodoAtualizaGrideTemp();

                    //-----------------Seleciona o ultimo item adiconado no DataGride 
                    dgvCorProduto.CurrentCell = dgvCorProduto.Rows[dgvCorProduto.Rows.Count - 1].Cells[0];
                    lbNomeCorImagem.Text = tbReferencia.Text + dgvCorProduto.SelectedRows[0].Cells[1].Value.ToString();
                    lbContadorImagens.Text = dgvCorProduto.SelectedRows[0].Cells[2].Value.ToString();
                    int posicaoImagem = Convert.ToInt32(dgvCorProduto.SelectedRows[0].Cells[2].Value);
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
                if (dgvCorProduto.RowCount == 0)
                {
                    MessageBox.Show("Não é possivel remover, não há itens do gride!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    //-------------------Pega os parâmetros dos valores do gride para inserir na tabela temporária
                    int codigoCorSelecionadoTemp = Convert.ToInt32(dgvCorProduto.CurrentRow.Cells[0].Value);
                    string nomeCorSelecionadoTemp = (dgvCorProduto.CurrentRow.Cells[1].Value).ToString();
                    int posicaoImagem = Convert.ToInt32(dgvCorProduto.CurrentRow.Cells[2].Value);

                    corSelecionadoTemp = new Cor();
                    corSelecionadoTemp.codigoCor = codigoCorSelecionadoTemp;
                    corSelecionadoTemp.nomeCor = nomeCorSelecionadoTemp;

                    if (nCor.ExcluirCorTemp(corSelecionadoTemp) == false)
                    {
                        MessageBox.Show("Não foi possivel remover a Cor?", "Erro",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    }
                    else
                    {
                    
                        //----------------Remove Imagens Vinculadas as cores
                        if (ListaImagens.Count > 0 && posicaoImagem < ListaImagens.Count)
                        {
                            ListaImagens.RemoveAt(posicaoImagem);

                            if (ListaImagens.Count == 0) {

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

        private void btLimpar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCorProduto.Rows.Count > 0)
                {
                    ordemBuscar = Convert.ToInt32(dgvCorProduto.CurrentRow.Cells[3].Value);
                }
                else
                {
                    ordemBuscar = nCor.BuscarUltimoRegistroCor() + 1;
                }
                              
                
                if (dgvCorProduto.RowCount > 0)
                {
                    nCor.ExcluirDadosTabelaTemporaria(ordemBuscar);
                    metodoAtualizaGrideTemp();
                    metodoAtualizaGride();
                    lbContadorImagens.Text = dgvCorProduto.RowCount.ToString();
                    //Limapa todos os valores para Defaut
                    metodoDefaut();
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro ao Limpar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbCor.Focus();
                return;
            }
        }

        private void pbBuscarCor_Click(object sender, EventArgs e)
        {
            if (dgvCorProduto.Rows.Count > 0)
            {
                ordemBuscar = Convert.ToInt32(dgvCorProduto.CurrentRow.Cells[3].Value);
            }
            else
            {
                ordemBuscar = nCor.BuscarUltimoRegistroCor() + 1;
            }
            
            this.corLista = nCor.BuscarCorTempPorNome(tbCor.Text, ordemBuscar);
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

        private void btRemoverImagem_Click(object sender, EventArgs e)
        {

            if (dgvCorProduto.RowCount > 0)
            {
                int posicaoImagem = Convert.ToInt32(dgvCorProduto.CurrentRow.Cells[2].Value);

                if (ListaImagens.Count > 0)
                {
                    if (ListaImagens[posicaoImagem] != null)
                    {
                        ListaImagens[posicaoImagem] = null;
                        pbImagemProduto.Image = global::Apresentacao.Properties.Resources.imgDefaut;
                    }
                }
            }
            else
            pbImagemProduto.Image = global::Apresentacao.Properties.Resources.imgDefaut;

        }

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

        //----------------------Eventos Gride
        private void dgvCorProduto_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dgvCorProduto.RowCount > 0){
             
             btSelecionar.Enabled = true;
             int posicaoImagem = Convert.ToInt32(dgvCorProduto.CurrentRow.Cells[2].Value);

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

        private void dgvCor_DoubleClick(object sender, EventArgs e)
        {
            btAdicionar.PerformClick();
        }

        private void dgvCorProduto_DoubleClick(object sender, EventArgs e)
        {
            btRemover.PerformClick();
        }

        //---------------------Eventos Formulário
        private void FrmCadastroProduto_KeyDown(object sender, KeyEventArgs e)
        {
            //atalho da tecla de atalho ESC
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {
                btSair.PerformClick();
            }
            //atalho para o botão cadastrar
            else if (e.KeyCode.Equals(Keys.F10) == true)
            {
                btCadastrar.PerformClick();
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

        private void FrmCadastroProduto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dgvCorProduto.RowCount > 0)
            {
                btLimpar.PerformClick();
                DialogResult = DialogResult.OK;
                this.Close();
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

        //-----------------------Preenchendo objeto Genero
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

        private void tbGenero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbBuscarGenero_Click(null, null);
                e.Handled = true;
            }
        }

        //-----------------------Preenchendo objeto Grade
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

        private void tbGrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbBuscarGrade_Click(null, null);
                e.Handled = true;
            }
        }

        //-----------------------Preenchendo objeto Fornecedor
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

        private void tbFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbBuscarFornecedor_Click(null, null);
                e.Handled = true;
            }
        }

        //-----------------------CoboBox trocar caixa depois da seleção
        private void cbSexo_SelectedValueChanged(object sender, EventArgs e)
        {
            tbGenero.Focus();
        }

        //-----------------------Definir os campos como Moeda
        private void mtbCusto_TextChanged(object sender, EventArgs e)
        {
            metodos.metodoMoedaMTB(ref mtbCusto);
        }

        private void mtbVenda_TextChanged(object sender, EventArgs e)
        {
            metodos.metodoMoedaMTB(ref mtbVenda);
        }
      
        //-----------------------Zoom da imagem
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

        //-----------------------Validações
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
 

    }
}
