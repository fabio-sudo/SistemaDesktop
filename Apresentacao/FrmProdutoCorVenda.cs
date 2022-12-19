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
    public partial class FrmProdutoCorVenda : Form
    {
        //---------------Instâncias
        Produto produtoCorrente = new Produto();
        ProdutoCorLista listaProdutoCor = new ProdutoCorLista();
        NegProdutoCor nProdutoCor = new NegProdutoCor();

        ProdutoCor produtoCorSelecionado = new ProdutoCor();
        //-------------Pegar local da solution
        String LocalSolution;
        int codVenda;

        //Essa variavel passa por todas a telas Para realizar incremento do ITEMVENDATEMP
        public Boolean varValidaPrimeiraVenda = false;

        //----------Tipo de Formulário
        string strFormulario;


        public FrmProdutoCorVenda(Produto produto, int codigoVenda, string strFrm)
        {
            InitializeComponent();

            produtoCorrente = produto;
            codVenda = codigoVenda;
            strFormulario = strFrm;
        }


        //--------------------Metodos
        //atualiza os valores no Data Grid
        private void AtualizarDataGrid()
        {
            this.dgvProdutoCor.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.listaProdutoCor.Count > 0)
            {
                this.dgvProdutoCor.Rows.Add(this.listaProdutoCor.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (ProdutoCor produtocor in this.listaProdutoCor)
            {
                this.dgvProdutoCor[0, indice].Value = produtocor.codigoProdutoCor;
                this.dgvProdutoCor[1, indice].Value = produtocor.Cor.codigoCor;
                this.dgvProdutoCor[2, indice].Value = produtocor.Cor.nomeCor;
                this.dgvProdutoCor[3, indice].Value = produtocor.ImagemProduto;

                indice++;
            }

            dgvProdutoCor.Update();

        }

        public void metodoExibeImagemDown()
        {
            try{

            int contador = dgvProdutoCor.SelectedRows[0].Index + 1;
            if (dgvProdutoCor.RowCount <= contador)
            {
                return;
            }

            String imgProduto = (dgvProdutoCor.Rows[contador].Cells[3].Value).ToString();
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        public void metodoExibeImagemUp()
        {

            int contador = dgvProdutoCor.SelectedRows[0].Index - 1;
            if (contador < 0)
            {
                return;
            }

            String imgProduto = (dgvProdutoCor.Rows[contador].Cells[3].Value).ToString();
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

        public void metodoIniciaFormulario()
        {
            try{

            //Buscal Local que a Solution Está sendo Executada no Computador
            LocalSolution = Environment.CurrentDirectory;
            // This will get the current PROJECT directory
            LocalSolution = Directory.GetParent(LocalSolution).Parent.Parent.FullName;

            //Preenche os dados do formulario
            this.Text = "Cód: " + produtoCorrente.codigoProduto +
            " Referência: " + produtoCorrente.referenciaProduto;
            tbProduto.Text = produtoCorrente.descricaoProduto;

            //-----------------Buscar cores do produto
            listaProdutoCor = nProdutoCor.BuscarCoresProdutoVendaPorCodigo(produtoCorrente.codigoProduto, codVenda);
            AtualizarDataGrid();

            }catch (Exception ex){

                MessageBox.Show(ex.Message);

            }

        }

        public void metodoExibeImagemProduto()
        {
            try
            {
                String imgProduto = (dgvProdutoCor.CurrentRow.Cells[3].Value).ToString();
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
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }

        }

        public void metodoAvancar(int contador)
        {
            try
            {
                contador = contador + 1;
                if (dgvProdutoCor.RowCount > contador)
                {
                    dgvProdutoCor.CurrentCell = dgvProdutoCor.Rows[contador].Cells[1];
                }
                else
                {
                    contador = 0;
                    dgvProdutoCor.CurrentCell = dgvProdutoCor.Rows[contador].Cells[1];
                }

                metodoExibeImagemProduto();

            }catch (Exception ex){

                MessageBox.Show(ex.Message);

            }
        }

        public void metodoVoltar(int contador)
        {
            try{

            if (contador > 0)
            {
                contador = contador - 1;
                dgvProdutoCor.CurrentCell = dgvProdutoCor.Rows[contador].Cells[1];
            }
            else
            {

                dgvProdutoCor.CurrentCell = dgvProdutoCor.Rows[dgvProdutoCor.RowCount - 1].Cells[1];
                contador = dgvProdutoCor.RowCount - 1;
            }

            metodoExibeImagemProduto();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        //----------------------Métodos do Gride
        private void dgvProdutoCor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            metodoExibeImagemProduto();
        }

        private void btAvancar_Click(object sender, EventArgs e)
        {
            
            if (dgvProdutoCor.RowCount > 1)
            {
                int contador = dgvProdutoCor.SelectedRows[0].Index;
                metodoAvancar(contador);

            }
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            if (dgvProdutoCor.RowCount > 1)
            {
                int contador = dgvProdutoCor.SelectedRows[0].Index;
                metodoVoltar(contador);
            }
        }

        //------------------------Botões
        private void btSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProdutoCor.RowCount > 0)
                {
                    int indiceRegistroSelecionado = Convert.ToInt32(dgvProdutoCor.CurrentRow.Cells[0].Value);
                    foreach (ProdutoCor prod in listaProdutoCor)
                    {
                        if (prod.codigoProdutoCor == indiceRegistroSelecionado)
                        {

                            produtoCorSelecionado = prod;
                            produtoCorSelecionado.Produto = produtoCorrente;
                            break;

                        }

                    }

                    //-------------Chama Formulario ItemVenda ou ItemVendaPendente
                    DialogResult resposta;

                    if (strFormulario.Equals("Cadastrar"))
                    {
                        FrmItemVendaTemp frmItemVendaTemp = new FrmItemVendaTemp(produtoCorSelecionado, codVenda);
                        resposta = frmItemVendaTemp.ShowDialog();

                        //Variavel para atualizar VendaTemp codigo = 0
                        varValidaPrimeiraVenda = frmItemVendaTemp.varValidaPrimeiraVenda;
                    }
                    else
                    {
                        FrmItemVenda frmItemVenda = new FrmItemVenda(null);
                        resposta = frmItemVenda.ShowDialog();
                    }

                    if (resposta == DialogResult.Yes)
                    {
                        //atualizar o gride quando o formulario voltar ao foco
                        this.DialogResult = DialogResult.Yes;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                //Criando Caixa de dialogo
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro",
                "Erro ao selecionar o Produto: "+ex.Message,
                Properties.Resources.DialogErro,
                Color.White,
                Color.Black,
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
            " Deseja realmente sair da Seleção de Produto ?",
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

        private void dgvProdutoCor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btSelecionar.PerformClick();
        }

        //-----------------------Formuláro
        private void FrmProdutoCorVenda_Load(object sender, EventArgs e)
        {
            metodoIniciaFormulario();
            this.dgvProdutoCor.CurrentRow.Selected = true;
            metodoExibeImagemProduto();
        }

        private void FrmProdutoCorVenda_KeyDown(object sender, KeyEventArgs e)
        {
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
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {
                btSair.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Enter) == true)
            {
                btSelecionar.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Down) == true)
            {
                metodoExibeImagemDown();

            }
            if (e.KeyCode.Equals(Keys.Up) == true)
            {
                metodoExibeImagemUp();

            }
        }


    }
}
