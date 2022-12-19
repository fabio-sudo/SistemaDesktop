using Negocio;
using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmSelecionarGrade : Form
    {
        NegGrade nGrade = new NegGrade();
        public GradeLista gradeLista;
        public Grade gradeSelecionado;
        public string strGrade;

        public FrmSelecionarGrade([Optional]string nomeGrade)
        {
            InitializeComponent();

            if(nomeGrade != String.Empty){
               
                strGrade = nomeGrade;
            
            }

        }

        //atualiza os valores no Data Grid
        private void AtualizarDataGrid()
        {
            this.dgvGrade.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.gradeLista.Count > 0)
            {
                this.dgvGrade.Rows.Add(this.gradeLista.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (Grade gra in this.gradeLista)
            {
                this.dgvGrade[0, indice].Value = gra.codigoGrade;
                this.dgvGrade[1, indice].Value = gra.nomeGrade;

                indice++;
            }

            dgvGrade.Update();

        }

        //----------------------Caixa de Texto
        private void tbBuscarGrade_Leave(object sender, EventArgs e)
        {
            if (tbBuscarGrade.Text == "")
            {
                tbBuscarGrade.Text = "Digite a grade do produto ...";
                pbGrade.Image = Properties.Resources.GradeAzul;
                panelBuscarGrade.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                panelBuscarGrade.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

            }
        }

        private void tbBuscarGrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btBuscar.PerformClick();
                e.Handled = true;
            }
        }

        private void tbBuscarGrade_Enter(object sender, EventArgs e)
        {
            tbBuscarGrade.Clear();
            pbGrade.Image = Properties.Resources.GradeRosa;
            panelBuscarGrade.BackColor = Color.DeepPink;

            if (strGrade != String.Empty)
            {
                tbBuscarGrade.Text = strGrade;

            }
        }


        //-----------------------Botões
        private void btBuscar_Click(object sender, EventArgs e)
        {
            string grade;
            grade = tbBuscarGrade.Text;

            if (tbBuscarGrade.Text.Equals("Digite a grade do produto ...") || tbBuscarGrade.Text == string.Empty)
            {
                grade = "";
            }

            this.gradeLista = nGrade.BuscarGradePorNome(grade);
            AtualizarDataGrid();
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            if (this.dgvGrade.Rows.Count > 0)
            {
                int indiceRegistroSelecionado = Convert.ToInt32(dgvGrade.CurrentRow.Cells[0].Value);
                foreach (Grade gra in gradeLista)
                {
                    if (gra.codigoGrade == indiceRegistroSelecionado)
                    {
                        gradeSelecionado = gra;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        break;

                    }
                }

            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;

            FrmCadastroGrade frmGrade = new FrmCadastroGrade();
            resultado = frmGrade.ShowDialog();

            if (resultado == DialogResult.OK)
            {

                btBuscar.PerformClick();
            }

        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvGrade.RowCount > 0)
                {
                    int indiceRegistroSelecionado = Convert.ToInt32(dgvGrade.CurrentRow.Cells[0].Value);
                    foreach (Grade gra in gradeLista)
                    {
                        if (gra.codigoGrade == indiceRegistroSelecionado)
                        {

                            gradeSelecionado = gra;

                        }


                    }

                    FrmAlterarExcluirGrade frmAlterarExcluirGrade = new FrmAlterarExcluirGrade(gradeSelecionado);

                    DialogResult resposta;

                    resposta = frmAlterarExcluirGrade.ShowDialog();

                    if (resposta == DialogResult.Yes)
                    {
                        //atualizar o gride quando o formulario voltar ao foco
                        btBuscar.PerformClick();
                    }
                }
            }
            catch
            {
                //Criando Caixa de dialogo
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro",
                "Erro ao selecionar o Grade!",
                Properties.Resources.DialogErro,
                Color.White,
                Color.Black,
                "Ok", "",
                false);
                frmCaixa.ShowDialog();

                //Volata o focu para caixa de texto de busca de Funcionario
                tbBuscarGrade.Focus();
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair da Seleção de Grade ?",
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

        //----------------------Teclas de Atalho
        private void FrmSelecionarGrade_KeyDown(object sender, KeyEventArgs e)
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
            if (e.KeyCode.Equals(Keys.F4) == true)
            {
                btAlterar.PerformClick();
            }
        }

        private void dgvGrade_DoubleClick(object sender, EventArgs e)
        {
            btSelecionar.PerformClick();
        }

        private void FrmSelecionarGrade_Load(object sender, EventArgs e)
        {
            if (strGrade != null)
            {
                tbBuscarGrade.Text = strGrade;
                btBuscar.PerformClick();
            }
        }


    }
}
