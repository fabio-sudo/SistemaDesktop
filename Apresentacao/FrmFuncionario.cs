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
    public partial class FrmFuncionario : Form
    {
        NegFuncionario nFuncionario = new NegFuncionario();
        FuncionarioLista FuncionarioLista;
        public Funcionario FuncionarioSelecionado;

        public FrmFuncionario()
        {
            InitializeComponent();
        }

        //atualiza os valores no Data Grid
        private void AtualizarDataGrid()
        {
            this.dgvFuncionario.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            if (this.FuncionarioLista.Count > 0)
            {
                this.dgvFuncionario.Rows.Add(this.FuncionarioLista.Count);
            }
            else
            {
                return;
            }

            int indice = 0;
            foreach (Funcionario func in this.FuncionarioLista)
            {
                this.dgvFuncionario[0, indice].Value = func.codigoFuncionario;
                this.dgvFuncionario[1, indice].Value = func.nomeFuncionario;
                this.dgvFuncionario[2, indice].Value = func.sobrenomeFuncionario;
                this.dgvFuncionario[3, indice].Value = func.sexoFuncionario;
                this.dgvFuncionario[4, indice].Value = func.rgFuncionario;
                this.dgvFuncionario[5, indice].Value = func.cpfFuncionario;
                this.dgvFuncionario[6, indice].Value = func.ctpsFuncionario;
                this.dgvFuncionario[7, indice].Value = func.dataNascimentoFuncionario;
                this.dgvFuncionario[8, indice].Value = func.enderecoFuncionario;
                this.dgvFuncionario[9, indice].Value = func.bairroFuncionario;
                this.dgvFuncionario[10, indice].Value = func.numeroFuncionario;
                this.dgvFuncionario[11, indice].Value = func.cepFuncionario;
                this.dgvFuncionario[12, indice].Value = func.cidadeFuncionario;
                this.dgvFuncionario[13, indice].Value = func.estadoFuncionario;
                this.dgvFuncionario[14, indice].Value = func.telefoneFuncionario;
                this.dgvFuncionario[15, indice].Value = func.celularFuncionario;
                this.dgvFuncionario[16, indice].Value = func.salarioFuncionario;

                indice++;
            }

            dgvFuncionario.Update();

        }

        //Realiza busca quando e clicado enter dentro da caixa de testo busca funcionario
        private void tbBuscarFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
               btBuscar.PerformClick();
               e.Handled = true;
            }
        }

        //Volta as configurações padrões quando caixa de pesquisa de funcionario perde o foco
        private void tbBuscarFuncionario_Leave(object sender, EventArgs e)
        {
            if (tbBuscarFuncionario.Text == "")
            {
                tbBuscarFuncionario.Text = "Digite o nome do funcionário ...";
                pbFuncionario.Image = Properties.Resources.FuncionarioAzul;
                panelBuscarFuncionario.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
                tbBuscarFuncionario.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));

            }
        }

        //Destaca o foco quando caixa de texto pesquisa de funcionario e selecionada
        private void tbBuscarFuncionario_Enter(object sender, EventArgs e)
        {
            tbBuscarFuncionario.Clear();
            pbFuncionario.Image = Properties.Resources.FuncionarioRosa;
            panelBuscarFuncionario.BackColor = Color.DeepPink;
            //tbBuscarFuncionario.ForeColor = Color.DeepPink;
        }

        //Botão buscar realiza a busca do funcionario por nome
        private void btBuscar_Click(object sender, EventArgs e)
        {
            string funcionario;
            funcionario = tbBuscarFuncionario.Text;

            if (tbBuscarFuncionario.Text.Equals("Digite o nome do funcionário ...") || tbBuscarFuncionario.Text == string.Empty)
            {
                funcionario = "";
            }

            this.FuncionarioLista = nFuncionario.BuscarFuncionarioPorNome(funcionario);
            AtualizarDataGrid();
        }

        //teclas de atalho
        private void FrmFuncionario_KeyDown(object sender, KeyEventArgs e)
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
            //ESC é no menu principal
        }

        //começa focu na caixa de pesquisa do funcionario
        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            tbBuscarFuncionario.Focus();
        }


        //Botao chama formulário cadastrar
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;

            FrmCadastroFuncionario frmFuncionario = new FrmCadastroFuncionario();
            resultado = frmFuncionario.ShowDialog();

            if (resultado == DialogResult.OK)
            {

                btBuscar.PerformClick();
            }


        }

        //Botão seleciona funcionario para alterar ou excluir dados
        private void btSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvFuncionario.RowCount > 0)
                {
                    int indiceRegistroSelecionado = Convert.ToInt32(dgvFuncionario.CurrentRow.Cells[0].Value);
                    foreach (Funcionario func in FuncionarioLista)
                    {
                        if (func.codigoFuncionario == indiceRegistroSelecionado)
                        {

                            FuncionarioSelecionado = func;
                            break;

                        }


                    }

                    //Funcionario FuncionarioSelecionado = Funcionario[indiceRegistroSelecionado];

                    FrmAlterarExcluirFuncionario frmAlterarExcluirFuncionario = new FrmAlterarExcluirFuncionario(FuncionarioSelecionado);

                    DialogResult resposta;

                    resposta = frmAlterarExcluirFuncionario.ShowDialog();

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
                "Erro ao selecionar o Funcionário!",
                Properties.Resources.DialogErro,
                Color.White,
                Color.Black,
                "Ok", "",
                false);
                frmCaixa.ShowDialog();

                //Volata o focu para caixa de texto de busca de Funcionario
                tbBuscarFuncionario.Focus();
            }
        }

        //Seleciona o funcioário com duplo click sobre funcionario
        private void dgvFuncionario_DoubleClick(object sender, EventArgs e)
        {
            btSelecionar.PerformClick();
        }


    }
}
