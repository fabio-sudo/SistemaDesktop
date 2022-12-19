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
    public partial class FrmSelecionarProdutoEntradaEstoque : Form
    {
        NegEntradaEstoque nEntradaEstoque = new NegEntradaEstoque();
        EntradaEstoqueLista entradaEstoqueLista;

        public EntradaEstoque entradaSelecionado;

        //Código do Produto para realizar a busca 
        ProdutoCor objProduto;
        Tamanho objTamanho;

        public FrmSelecionarProdutoEntradaEstoque(ProdutoCor produto,Tamanho tamanho)
        {
            InitializeComponent();

            //Passando paramentro pro objeto ProdutoCor
            objProduto = produto;
            objTamanho = tamanho;
        }

        //atualiza os valores no Data Grid
        private void AtualizarDataGrid()
        {
            this.dgvEntradaEstoque.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.entradaEstoqueLista.Count > 0)
            {
                this.dgvEntradaEstoque.Rows.Add(this.entradaEstoqueLista.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (EntradaEstoque entr in this.entradaEstoqueLista)
            {
                if (entr.estatusEntrada == "Pendente")
                {
                    //Caso item tenha parcial ele fica de cor diferente dos outros itens no gride
                    dgvEntradaEstoque.Rows[indice].DefaultCellStyle.BackColor = Color.DeepSkyBlue;
                }

                this.dgvEntradaEstoque[0, indice].Value = entr.codigoEntradaEstoque;
                this.dgvEntradaEstoque[1, indice].Value = entr.notaFiscal;
                this.dgvEntradaEstoque[2, indice].Value = entr.Fornecedor.nomeFantasiaFornecedor;
                this.dgvEntradaEstoque[3, indice].Value = entr.quantidadeProdutosNota;
                this.dgvEntradaEstoque[4, indice].Value = entr.valorTotalNota;
                this.dgvEntradaEstoque[5, indice].Value = entr.dataEntrada;
                this.dgvEntradaEstoque[6, indice].Value = entr.estatusEntrada;

                indice++;
            }

            dgvEntradaEstoque.Update();

        }

        //Preenche os campos e povoa o DataGride
        public void metodoPreencheCampos(){

            tbCodigoProduto.Text = objProduto.Produto.codigoProduto.ToString();
            tbDescricaoProduto.Text = objProduto.Produto.descricaoProduto;
            tbReferencia.Text = objProduto.Produto.referenciaProduto;
            tbCor.Text = objProduto.Cor.nomeCor;
            tbGrade.Text = objProduto.Produto.Grade.nomeGrade;
            tbGenero.Text = objProduto.Produto.Genero.nomeGenero;
            tbTamanho.Text = objTamanho.nometamanho;
            metodoExibeImagemProduto();

            entradaEstoqueLista = nEntradaEstoque.BuscarEntradaEstoquePorProduto(objProduto.codigoProdutoCor, objTamanho.codigoTamanho);
            AtualizarDataGrid();
        }

        //Exibe imagem do produto salva no bano de Dados
        public void metodoExibeImagemProduto()
        {
               //Buscal Local que a Solution Está sendo Executada no Computador
                String LocalSolution = Environment.CurrentDirectory;
                // This will get the current PROJECT directory
                LocalSolution = Directory.GetParent(LocalSolution).Parent.Parent.FullName;
                String imgProduto = objProduto.ImagemProduto;
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

        //----------------Botões
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            FrmCadastroEntradaEstoque frmCadastroEstoque = new FrmCadastroEntradaEstoque(null);
            resultado = frmCadastroEstoque.ShowDialog();

            if (resultado == DialogResult.Yes)
            {
                metodoPreencheCampos();
            }
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEntradaEstoque.RowCount > 0)
                {
                    int indiceRegistroSelecionado = Convert.ToInt32(dgvEntradaEstoque.CurrentRow.Cells[0].Value);
                    foreach (EntradaEstoque ent in entradaEstoqueLista)
                    {
                        if (ent.codigoEntradaEstoque == indiceRegistroSelecionado)
                        {

                            entradaSelecionado = ent;
                            break;

                        }


                    }


                    if (entradaSelecionado.estatusEntrada == "Concluido")
                    {
                        FrmAlterarExcluirEntradaEstoque frmAlterarExcluirEntrada = new FrmAlterarExcluirEntradaEstoque(entradaSelecionado);
                        DialogResult resposta;

                        resposta = frmAlterarExcluirEntrada.ShowDialog();

                        if (resposta == DialogResult.Yes)
                        {
                            metodoPreencheCampos();
                        }
                    }
                    else//Pendente ou Vazio
                    {
                        FrmCadastroEntradaEstoque frmCadastrarEntrada = new FrmCadastroEntradaEstoque(entradaSelecionado);
                        DialogResult resposta;

                        resposta = frmCadastrarEntrada.ShowDialog();

                        if (resposta == DialogResult.Yes)
                        {
                            metodoPreencheCampos();
                        }
                    }


                }

                if (dgvEntradaEstoque.RowCount == 0) {
                    this.Close();
                
                }

            }
            catch
            {
                //Criando Caixa de dialogo
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro",
                "Erro ao selecionar o Entrada de Estoque!",
                Properties.Resources.DialogErro,
                Color.White,
                Color.Black,
                "Ok", "",
                false);
                frmCaixa.ShowDialog();

                //Volata o focu para caixa de texto de busca de cliente
                tbCodigoProduto.Focus();
            }

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair da Seleção de Produtos da Entrada de Estoque?",
            Properties.Resources.DialogQuestion,
            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
            Color.White,
            "Sim", "Não",
            false);

            resposta = frmCaixa.ShowDialog();
            if (resposta == DialogResult.Yes)
            {
               this.DialogResult = DialogResult.Yes;
               this.Close();

            }
        }

        //----------------Formulário
        private void FrmSelecionarProdutoEntradaEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F2) == true)
            {
                btSelecionar.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.F10) == true)
            {
                btCadastrar.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {
                btSair.PerformClick();
            }
        }

        private void FrmSelecionarProdutoEntradaEstoque_Load(object sender, EventArgs e)
        {
            metodoPreencheCampos();

        }

        private void dgvEntradaEstoque_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btSelecionar.PerformClick();
        }

        private void FrmSelecionarProdutoEntradaEstoque_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

    }
}
