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
    public partial class FrmSelecionarProdutoItemVenda : Form
    {
        Venda objVenda = new Venda();

        ProdutoCor produtoCor = new ProdutoCor();
        ProdutoCorLista listaProdutoCor = new ProdutoCorLista();
        NegProdutoCor nProdutoCor = new NegProdutoCor();

        public ProdutoCor produtoCorSelecionado;

        String LocalSolution;
        String objProdutoDescriacao;


        public FrmSelecionarProdutoItemVenda(Venda venda, string descricaoProduto)
        {
            InitializeComponent();

            this.objVenda = venda;
            this.objProdutoDescriacao = descricaoProduto;
        }

        //atualiza os valores no Data Grid
        private void AtualizarDataGrid()
        {
            this.dgvProduto.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.listaProdutoCor.Count > 0)
            {
                this.dgvProduto.Rows.Add(this.listaProdutoCor.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (ProdutoCor prod in this.listaProdutoCor)
            {
                this.dgvProduto[0, indice].Value = prod.Produto.codigoProduto;
                this.dgvProduto[1, indice].Value = prod.Produto.descricaoProduto;
                this.dgvProduto[2, indice].Value = prod.Produto.referenciaProduto;
                this.dgvProduto[3, indice].Value = prod.Produto.sexoProduto;
                this.dgvProduto[4, indice].Value = prod.Produto.Genero.nomeGenero;
                this.dgvProduto[5, indice].Value = prod.Produto.Grade.nomeGrade;
                this.dgvProduto[6, indice].Value = prod.Produto.Fornecedor.nomeFantasiaFornecedor;
                this.dgvProduto[7, indice].Value = prod.Produto.quantidadeProduto;
                this.dgvProduto[8, indice].Value = prod.Produto.precoCustoProduto;
                this.dgvProduto[9, indice].Value = prod.Produto.precoVendaProduto;
                this.dgvProduto[10, indice].Value = prod.Produto.dataProduto;
                this.dgvProduto[11, indice].Value = prod.ImagemProduto;

                indice++;
            }

            dgvProduto.Update();

        }

        private void metodoExibeImagemProduto()
        {
            if (dgvProduto.Rows.Count > 0)
            {
                //Buscal Local que a Solution Está sendo Executada no Computador
                LocalSolution = Environment.CurrentDirectory;
                // This will get the current PROJECT directory
                LocalSolution = Directory.GetParent(LocalSolution).Parent.Parent.FullName;

                String imgProduto = (dgvProduto.CurrentRow.Cells[11].Value).ToString();
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
                    pbImagemZoom.Image = img2;
                }
                else
                {
                    pbImagemProduto.Image = global::Apresentacao.Properties.Resources.imgDefaut;
                    pbImagemZoom.Image = global::Apresentacao.Properties.Resources.imgDefaut;
                }
            }

        }

        //-------------Caixa de Texto
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

            if (objProdutoDescriacao != null)
            {
                tbBuscarProduto.Text = objProdutoDescriacao;
                btBuscar.PerformClick();
            }
            if (objProdutoDescriacao == "Digite a descrição do produto ...")
            {

                tbBuscarProduto.Text = "";
                btBuscar.PerformClick();
                tbBuscarProduto.Focus();
            }

        }

        //--------------Botões
        private void btBuscar_Click(object sender, EventArgs e)
        {
            string Strproduto;
            Strproduto = tbBuscarProduto.Text;

            if (tbBuscarProduto.Text.Equals("Digite a descrição do produto ...") || tbBuscarProduto.Text == string.Empty)
            {
                Strproduto = "";
            }

            this.listaProdutoCor = nProdutoCor.BuscarProdutoItemVenda(Strproduto, objVenda.codigoVenda);
            AtualizarDataGrid();
            metodoExibeImagemProduto();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair da Seleção de Produtos ?",
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

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            if (this.dgvProduto.Rows.Count > 0)
            {
                int indiceRegistroSelecionado = Convert.ToInt32(dgvProduto.CurrentRow.Cells[0].Value);
                foreach (ProdutoCor prod in listaProdutoCor)
                {
                    if (prod.Produto.codigoProduto == indiceRegistroSelecionado)
                    {
                        produtoCorSelecionado = prod;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        break;

                    }
                }

            }
        }

        //--------------Imagem
        private void pbImagemProduto_MouseEnter(object sender, EventArgs e)
        {
            pbImagemZoom.Visible = true;
        }

        private void pbImagemProduto_MouseLeave(object sender, EventArgs e)
        {
            pbImagemZoom.Visible = false;
        }

        //-------------DataGride
        private void dgvProduto_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            metodoExibeImagemProduto();
        }

        private void FrmSelecionarProdutoItemVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F5) == true)
            {
                btBuscar.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {
                btSair.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F2) == true)
            {
                btSelecionar.PerformClick();
            }
        }

        private void dgvProduto_DoubleClick(object sender, EventArgs e)
        {
            btSelecionar.PerformClick();
        }



    }
}
