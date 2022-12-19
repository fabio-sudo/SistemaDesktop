using Negocio;
using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmVendaPendente : Form
    {
        Venda objVenda = new Venda();
        VendaLista vendaLista = new VendaLista();
        NegVenda nVenda = new NegVenda();

        public FrmVendaPendente()
        {
            InitializeComponent();
        }

        //-------------Métodos
        private void AtualizarDataGrid()
        {
            this.dgvVendaPendente.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.vendaLista.Count > 0)
            {
                this.dgvVendaPendente.Rows.Add(this.vendaLista.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (Venda venda in this.vendaLista)
            {
                this.dgvVendaPendente[0, indice].Value = venda.codigoVenda;
                this.dgvVendaPendente[1, indice].Value = venda.quantidadeVenda;
                this.dgvVendaPendente[2, indice].Value = venda.totalVenda;
                this.dgvVendaPendente[3, indice].Value = venda.dataVenda;

                indice++;
            }

            dgvVendaPendente.Update();

        }

        //-------------Botões
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            int codigoVenda = 0;// nVenda.BuscarItemVendaTempUltimoRegistro();//Busca ultimo Registro
           // codigoVenda = codigoVenda + 1;


            FrmVenda frmVenda = new FrmVenda(codigoVenda);
            resposta = frmVenda.ShowDialog();

            if (resposta == DialogResult.Yes)
            {

                btBuscar.PerformClick();
            }
        }

        private void pbFiltrar_Click(object sender, EventArgs e)
        {
            vendaLista = nVenda.BuscarItemVendaTempPendentePorData(dtpDataInicial.Value,dtpDataFinal.Value);
            AtualizarDataGrid();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            vendaLista = nVenda.BuscarItemVendaTempPendente();
            AtualizarDataGrid();
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            if (dgvVendaPendente.RowCount > 0)
            {
                DialogResult resposta;
                int codigoVenda = Convert.ToInt32(dgvVendaPendente.CurrentRow.Cells[0].Value);
                FrmVenda frmVenda = new FrmVenda(codigoVenda);
                resposta = frmVenda.ShowDialog();

                if (resposta == DialogResult.Yes)
                {

                    btBuscar.PerformClick();
                }
            }

        }

        //-------------Formulário
        private void FrmVendaPendente_Load(object sender, EventArgs e)
        {
           vendaLista = nVenda.BuscarItemVendaTempPendente();
           AtualizarDataGrid();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair da Seleção de Vendas ?",
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

        private void dgvVendaPendente_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btSelecionar.PerformClick();
        }

        private void FrmVendaPendente_KeyDown(object sender, KeyEventArgs e)
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
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {
                btSair.PerformClick();
            }
        }



    }
}
