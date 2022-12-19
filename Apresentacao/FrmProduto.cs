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
    public partial class FrmProduto : Form
    {
        NegProduto nProduto = new NegProduto();
        ProdutoLista ProdutoLista;
        public Produto ProdutoSelecionado;

        //iniciada no inicio do formulário
        Image imgPrincipal;
        ImagemProdutoLista listaImagens;
        int contadorImagem = 0;


        public FrmProduto()
        {
            InitializeComponent();

        }


        //atualiza os valores no Data Grid
        private void AtualizarDataGrid()
        {
            this.dgvProduto.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.ProdutoLista.Count > 0)
            {
                this.dgvProduto.Rows.Add(this.ProdutoLista.Count);
            }
            else
            {
                return ;
            }

            int indice = 0;
            foreach (Produto prod in this.ProdutoLista)
            {
                this.dgvProduto[0, indice].Value = prod.codigoProduto;
                this.dgvProduto[1, indice].Value = prod.descricaoProduto;
                this.dgvProduto[2, indice].Value = prod.referenciaProduto;
                this.dgvProduto[3, indice].Value = prod.sexoProduto;
                this.dgvProduto[4, indice].Value = prod.Genero.nomeGenero;
                this.dgvProduto[5, indice].Value = prod.Grade.nomeGrade;
                this.dgvProduto[6, indice].Value = prod.Fornecedor.nomeFantasiaFornecedor;
                this.dgvProduto[7, indice].Value = prod.quantidadeProduto;
                this.dgvProduto[8, indice].Value = prod.precoCustoProduto;
                this.dgvProduto[9, indice].Value = prod.precoVendaProduto;
                this.dgvProduto[10, indice].Value = prod.dataProduto;

                indice++;
            }

            dgvProduto.Update();

        }

        //Criar imagem de acordo com ela salva no banco de dados
        public void metodoExibeImagemProduto()
        {       
            contadorImagem = 0;
            listaImagens = new ImagemProdutoLista();

            if (this.dgvProduto.Rows.Count > 0)
            {
                int indiceSelecionado = Convert.ToInt32(dgvProduto.CurrentRow.Cells[0].Value);
                listaImagens = nProduto.BuscarImagensProduto(indiceSelecionado);
                metodoCriaImagemProduto();
            }
                
                }

        //método cria imagem
        public void metodoCriaImagemProduto()
        {
            try
            {
                //----------------- Se não existir mais imagens na lista Ele bloqueia o avançar e voltar
                if (listaImagens.Count - 1 == 0 || listaImagens.Count == 0)
                {
                    btAvancar.Enabled = false;
                    btVoltar.Enabled = false;
                }
                else {

                    btAvancar.Enabled = true;
                    btVoltar.Enabled = true;
                
                }
                //Buscal Local que a Solution Está sendo Executada no Computador
                string LocalSolution = Environment.CurrentDirectory;
                // This will get the current PROJECT directory
                LocalSolution = Directory.GetParent(LocalSolution).Parent.Parent.FullName;

                //----------------- Cria a Imagem utilizando a lista de imagens e contador 
                //Verifica se Existe a imagem dentro da pasta
                if (listaImagens.Count > 0)
                {
                    if (System.IO.File.Exists(LocalSolution + "\\Imagens\\" + listaImagens[contadorImagem] + ".jpeg"))
                    {
                        Image img;
                        Bitmap img2;
                        img = Image.FromFile(LocalSolution + "\\Imagens\\" + listaImagens[contadorImagem] + ".jpeg");
                        img2 = new Bitmap(img);
                        img.Dispose();
                        pbImagemProduto.Image = img2;
                        pbImagemZoom.Image = img2;
                    }
                    else
                    {

                        pbImagemProduto.Image = imgPrincipal;
                        pbImagemZoom.Image = imgPrincipal;
                    }
                }
                else {
                    pbImagemProduto.Image = imgPrincipal;
                    pbImagemZoom.Image = imgPrincipal;
                
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Imagem não cadastrada: " + ex.Message, "ERRO",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                pbImagemProduto.Image = imgPrincipal;
                pbImagemZoom.Image = imgPrincipal;
            }

        }

        //------------------Botões
        private void btBuscar_Click(object sender, EventArgs e)
        {
            //-----------Defaut Imagem
            pbImagemProduto.Image = imgPrincipal;
            pbImagemZoom.Image = imgPrincipal;
            btAvancar.Enabled = false;
            btVoltar.Enabled = false;

            string Strproduto;
            Strproduto = tbBuscarProduto.Text;

            if (tbBuscarProduto.Text.Equals("Digite a descrição do produto ...") || tbBuscarProduto.Text == string.Empty)
            {
                Strproduto = "";
            }

            this.ProdutoLista = nProduto.BuscarProdutoPorNome(Strproduto);
            AtualizarDataGrid();
            //---------------Mostra as imagens do primeiro item do Gride
            this.dgvProduto.CurrentRow.Selected = true;
            metodoExibeImagemProduto();
        }
        
        private void btCadastrar_Click(object sender, EventArgs e)
        {            
            DialogResult resultado;

            FrmCadastroProduto frmProduto = new FrmCadastroProduto();
            resultado = frmProduto.ShowDialog();

            if (resultado == DialogResult.OK)
            {

                btBuscar.PerformClick();
            }
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProduto.RowCount > 0)
                {
                    int indiceRegistroSelecionado = Convert.ToInt32(dgvProduto.CurrentRow.Cells[0].Value);
                    foreach (Produto prod in ProdutoLista)
                    {
                        if (prod.codigoProduto == indiceRegistroSelecionado)
                        {

                            ProdutoSelecionado = prod;
                            break;

                        }


                    }
                    
                    FrmAlterarExcluirProduto frmAlterarExcluirProduto = new FrmAlterarExcluirProduto(ProdutoSelecionado);
                    DialogResult resposta;


                    resposta = frmAlterarExcluirProduto.ShowDialog();

                    if (resposta == DialogResult.Yes)
                    {
                        tbBuscarProduto.Text = frmAlterarExcluirProduto.nomeProdutoSelecionado;
                        //atualizar o gride quando o formulario voltar ao foco
                        btBuscar.PerformClick();
                        this.dgvProduto.CurrentRow.Selected = true;
                        metodoExibeImagemProduto();
                    }
                }
               
            }
            catch
            {
                //Criando Caixa de dialogo
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro",
                "Erro ao selecionar o Produto!",
                Properties.Resources.DialogErro,
                Color.White,
                Color.Black,
                "Ok", "",
                false);
                frmCaixa.ShowDialog();

                //Volata o focu para caixa de texto de busca de cliente
                tbBuscarProduto.Focus();
            }
        }

        //----------------Caixa de Texto
        private void tbBuscarProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btBuscar.PerformClick();
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

        //-------------------- Da zoom Na imagem 
        private void pbImagemProduto_MouseEnter(object sender, EventArgs e)
        {
            pbImagemZoom.Visible = true;
        }

        private void pbImagemProduto_MouseLeave(object sender, EventArgs e)
        {
            pbImagemZoom.Visible = false;
        }

        private void dgvProduto_DoubleClick(object sender, EventArgs e)
        {
            btSelecionar.PerformClick();
        }

        //--------------------Teclas de Atalho
        private void FrmProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F5) == true)
            {
                btBuscar.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F10) == true)
            {
                btCadastrar.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F2) == true)
            {
                btSelecionar.PerformClick();
            }
            //atalho da tecla de atalho ESC
            if (e.KeyCode.Equals(Keys.Right) == true)
            {
                btAvancar.PerformClick();
            }
            //atalho da tecla de atalho ESC
            if (e.KeyCode.Equals(Keys.Left) == true)
            {
                btVoltar.PerformClick();
            }
            //ESC é no menu principal
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            tbBuscarProduto.Focus();
            //Buscal Local que a Solution Está sendo Executada no Computador
            string LocalSolution = Environment.CurrentDirectory;
            // This will get the current PROJECT directory
            LocalSolution = Directory.GetParent(LocalSolution).Parent.Parent.FullName;
            //Pegar Local Automaticante
            imgPrincipal = Image.FromFile(LocalSolution + "\\Imagens\\\\imgDefaut.png");
        }

        private void dgvProduto_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            metodoExibeImagemProduto();
        }

        //-------------------------Avançar e Voltar
        private void btAvancar_Click(object sender, EventArgs e)
        {
            int imgCont = listaImagens.Count() - 1;

            if (imgCont > contadorImagem)
            {
                contadorImagem++;
                metodoCriaImagemProduto();
            }
            else
            {
                contadorImagem = 0;
                metodoCriaImagemProduto();
            }
            }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            int imgCont = listaImagens.Count() - 1;

            if (contadorImagem > 0)
            {
                contadorImagem--;
                metodoCriaImagemProduto();
            }
            else
            {
                contadorImagem = imgCont;
                metodoCriaImagemProduto();
            }
            }

        private void btCodigoBarras_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            FrmCodigoBarras frmCodigoBarras = new FrmCodigoBarras();
            resposta = frmCodigoBarras.ShowDialog();

            if (resposta == DialogResult.Yes)
            {
                btBuscar.PerformClick();

            }
        }

    }
}
