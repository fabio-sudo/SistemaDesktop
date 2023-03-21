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
    public partial class FrmSelecionarDespesa : Form
    {

        ListaDespesas listaDespesa = new ListaDespesas();
        NegDespesa nDespesa = new NegDespesa();

        public FrmSelecionarDespesa()
        {
            InitializeComponent();
        }

        //Atualiza Gride
        private void metodoAtualizaGrid() { 
        
            this.dgvDespesas.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.listaDespesa.Count > 0)
            {
                this.dgvDespesas.Rows.Add(this.listaDespesa.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (DespesaCaixa despesa in this.listaDespesa)
            {
                this.dgvDespesas[0, indice].Value = despesa.codigoDespesa;
                this.dgvDespesas[1, indice].Value = despesa.descricaoDespesa;
                this.dgvDespesas[2, indice].Value = despesa.valorDespesa;
                this.dgvDespesas[3, indice].Value = despesa.funcionario.nomeFuncionario;
                this.dgvDespesas[5, indice].Value = despesa.formaPagamento.codigoFormaPagamento;
                this.dgvDespesas[4, indice].Value = despesa.formaPagamento.formaPagamento;
                this.dgvDespesas[6, indice].Value = despesa.dataDespesa;
                this.dgvDespesas[7, indice].Value = despesa.statusDespesa;


                indice++;
            }

            dgvDespesas.Update();      
        
        }

        //---------------------Controles
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastrarDespesa frmCadastroDespesa = new FrmCadastrarDespesa();
            frmCadastroDespesa.ShowDialog();
        }

        private void pbFiltrar_Click(object sender, EventArgs e)
        {
            listaDespesa = nDespesa.BuscarDespesaPorData(dtpDataInicial.Value, dtpDataFinal.Value);
            metodoAtualizaGrid();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string strDespesa;
            strDespesa = tbBuscarDespesa.Text;

            if (tbBuscarDespesa.Text.Equals("Digite a descrição da Despesa ...") || tbBuscarDespesa.Text == string.Empty)
            {
                strDespesa = "";
            }

            listaDespesa = nDespesa.BuscarDespesaPorDescricao(strDespesa);
            metodoAtualizaGrid();
        }

        private void tbBuscarDespesa_Leave(object sender, EventArgs e)
        {
            if (tbBuscarDespesa.Text == "")
            {
                tbBuscarDespesa.Text = "Digite a descrição da Despesa ...";
                panelBuscarDespesa.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                panelBuscarDespesa.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

            }
        }

        private void tbBuscarDespesa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btBuscar.PerformClick();
                e.Handled = true;
            }
        }

        private void tbBuscarDespesa_Enter(object sender, EventArgs e)
        {
            tbBuscarDespesa.Clear();
            panelBuscarDespesa.BackColor = Color.DeepPink;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair da Seleção de Despesas ?",
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
            if (this.dgvDespesas.Rows.Count > 0)
            {
                int indiceRegistroSelecionado = Convert.ToInt32(dgvDespesas.CurrentRow.Cells[0].Value);
                foreach (DespesaCaixa despesa in listaDespesa)
                {
                    if (despesa.codigoDespesa == indiceRegistroSelecionado)
                    {

                        FrmAterarExcluirDespesa frmDespesa = new FrmAterarExcluirDespesa(despesa);
                        frmDespesa.ShowDialog();
                        btBuscar.PerformClick();


                    }
                }

            }
        }

        private void FrmSelecionarDespesa_KeyDown(object sender, KeyEventArgs e)
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
            if (e.KeyCode.Equals(Keys.F10) == true)
            {
                btCadastrar.PerformClick();
            }
        }

        private void dgvDespesas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btSelecionar.PerformClick();
        }


    }
}
