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
    public partial class FrmCadastroFornecedor : Form
    {
        //Classe metodos de Validção 
        Formulas.Metodos metodos = new Formulas.Metodos();

        //Instaciando
        NegFornecedor nFornecedor = new NegFornecedor();
        Fornecedor objFornecedor = new Fornecedor();


        public FrmCadastroFornecedor()
        {
            InitializeComponent();
        }

        //-------------------Botões
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            mtbCnpj_Leave(null, null);
            
            //Valida se todos os campos foram preenchidos
            if (metodoValidaCampos() == true)
            {
                try
                {
                    NegFornecedor nFornecedor = new NegFornecedor();
                    Fornecedor Fornecedor = new Fornecedor();

                    Fornecedor.razaoSocialFornecedor = tbRazaoSocial.Text;
                    Fornecedor.nomeFantasiaFornecedor = tbNomeFantasia.Text;
                    Fornecedor.cnpjFornecedor = mtbCnpj.Text;
                    Fornecedor.inscricaoEstadualFornecedor = mtbInscricaoEstadual.Text;
                    Fornecedor.enderecoFornecedor = tbEndereco.Text;
                    Fornecedor.bairroFornecedor = tbBairro.Text;
                    Fornecedor.numeroFornecedor = int.Parse(tbNumero.Text);
                    Fornecedor.cidadeFornecedor = tbCidade.Text;
                    Fornecedor.estadoFornecedor = cbEstado.SelectedItem.ToString();
                    Fornecedor.cepFornecedor = mtbCep.Text;
                    Fornecedor.telefoneFornecedor = mtbTelefone.Text;
                    Fornecedor.celularFornecedor = mtbCelular.Text;
                    Fornecedor.emailFornecedor = tbEmail.Text;

                    if (nFornecedor.CadastrarFornecedor(Fornecedor) == true)
                    {
                        DialogResult resposta;
                        //Criando Caixa de dialogo
                        FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
                        " Cadastro Realizado com Sucesso! \r\n" +
                        "Deseja Continuar No Cadastro De Fornecedor?",
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
                        tbRazaoSocial.Focus();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("O Fornecedor já cadastrado. Razão Social: " + Fornecedor.razaoSocialFornecedor + " CNPJ: " + Fornecedor.cnpjFornecedor + " Iscrição Estadual: " + Fornecedor.inscricaoEstadualFornecedor, "Erro Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbRazaoSocial.Focus();
                        return;
                    }

                }

                catch (Exception ex)
                {
                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro",
                    "Erro ao cadastrar Fornecedor \r\n" + ex.Message,
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
            " Deseja realmente sair do Cadastro de Fornecedor ?",
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

        //--------------------Eventos
        //Metodo para validar campos
        public Boolean metodoValidaCampos()
        {

            if (tbRazaoSocial.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe a Razão Social do Fornecedor!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbRazaoSocial.Clear();
                tbRazaoSocial.Focus();

                return false;
            }
            else if (tbNomeFantasia.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o Nome Fantasia do Fornecedor!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNomeFantasia.Clear();
                tbNomeFantasia.Focus();

                return false;
            }
            else if (mtbCnpj.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o CNPJ do Fornecedor!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbCnpj.Clear();
                mtbCnpj.Focus();

                return false;
            }
            else if (mtbInscricaoEstadual.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o Inscrição Estadual do Fornecedor!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbInscricaoEstadual.Clear();
                mtbInscricaoEstadual.Focus();

                return false;
            }
            else if (tbEndereco.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o endereço do Fornecedor!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbEndereco.Clear();
                tbEndereco.Focus();

                return false;
            }
            else if (tbBairro.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o bairro do Fornecedor!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbBairro.Clear();
                tbBairro.Focus();

                return false;
            }
            else if (tbNumero.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o número do Fornecedor!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNumero.Clear();
                tbNumero.Focus();

                return false;
            }
            else if (tbCidade.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o cidade do Fornecedor!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbCidade.Clear();
                tbCidade.Focus();

                return false;
            }
            else if (mtbCep.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o CEP do Fornecedor!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbCep.Clear();
                mtbCep.Focus();

                return false;
            }
            else if (cbEstado.SelectedItem == null)
            {
                MessageBox.Show("Informe o estado do Fornecedor!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbEstado.SelectedItem = null;
                cbEstado.Focus();

                return false;
            }
            else if (mtbTelefone.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o telefone do Fornecedor!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbTelefone.Clear();
                mtbTelefone.Focus();

                return false;
            }
            else if (mtbCelular.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o celular do Fornecedor!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbCelular.Clear();
                mtbCelular.Focus();

                return false;
            }
            else if (tbEmail.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o email do Fornecedor!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbEmail.Clear();
                tbEmail.Focus();

                return false;
            }
            else
                return true;


        }

        //Metodo para limpar os campos
        public void metodoLimpaCampos()
        {
            epFornecedor.Clear();
            tbRazaoSocial.Clear();
            tbNomeFantasia.Clear();
            mtbCnpj.Clear();
            mtbInscricaoEstadual.Clear();
            mtbCep.Clear();
            tbEndereco.Clear();
            tbNumero.Clear();
            tbBairro.Clear();
            tbCidade.Clear();
            cbEstado.SelectedItem = null;
            mtbTelefone.Clear();
            mtbCelular.Clear();
            tbEmail.Clear();
        }

        //Permite somente numeros
        private void tbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.metodoAllowNumber(e);
        }

        //Teclas de atalho
        private void FrmCadastroFornecedor_KeyDown(object sender, KeyEventArgs e)
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
        }

        //------------------Validação
        private void tbRazaoSocial_Leave(object sender, EventArgs e)
        {
            if (tbRazaoSocial.Text == String.Empty)
            {
                epFornecedor.SetError(tbRazaoSocial, "Campo obrigatório!");
            }
            else
                epFornecedor.Clear();

        }

        private void tbNomeFantasia_Leave(object sender, EventArgs e)
        {
            if (tbNomeFantasia.Text == String.Empty)
            {
                epFornecedor.SetError(tbNomeFantasia, "Campo obrigatório!");
            }
            else
                epFornecedor.Clear();
        }

        //Valida Cadastro Duplicidade CNPJ
        private void mtbCnpj_Leave(object sender, EventArgs e)
        {
            try
            {
                //Verifica se o campo for preenchido
                if (mtbCnpj.Text == String.Empty)
                {
                    epFornecedor.SetError(mtbCnpj, "Campo obrigatório!");
                    return;
                }
                else
                    epFornecedor.Clear();

                //Verifica se já existe CPF cadastrado
                Fornecedor fornecedor = new Fornecedor();
                fornecedor = nFornecedor.ValidarNovoCadastroCnpj(mtbCnpj.Text);
                if (fornecedor != null)
                {
                    //Criando Caixa de dialogo
                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("CNPJ já Existe",
                    " Cód: " + fornecedor.codigoFornecedor +
                    " Nome: " + fornecedor.nomeFantasiaFornecedor +
                    " CPF: " + fornecedor.cnpjFornecedor,
                    Properties.Resources.DialogWarning,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Ok", "",
                    false);
                    frmCaixa.ShowDialog();
                    //Volta parametro para caixa de texto
                    mtbCnpj.Clear();
                    mtbCnpj.Focus();
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

        private void mtbInscricaoEstadual_Leave(object sender, EventArgs e)
        {
            if (mtbInscricaoEstadual.Text == String.Empty)
            {
                epFornecedor.SetError(mtbInscricaoEstadual, "Campo obrigatório!");
            }
            else
                epFornecedor.Clear();
        }

        private void tbEndereco_Leave(object sender, EventArgs e)
        {
            if (tbEndereco.Text == String.Empty)
            {
                epFornecedor.SetError(tbEndereco, "Campo obrigatório!");
            }
            else
                epFornecedor.Clear();
        }

        private void tbBairro_Leave(object sender, EventArgs e)
        {
            if (tbBairro.Text == String.Empty)
            {
                epFornecedor.SetError(tbBairro, "Campo obrigatório!");
            }
            else
                epFornecedor.Clear();
        }

        private void tbNumero_Leave(object sender, EventArgs e)
        {
            if (tbNumero.Text == String.Empty)
            {
                epFornecedor.SetError(tbNumero, "Campo obrigatório!");
            }
            else
                epFornecedor.Clear();
        }

        private void tbCidade_Leave(object sender, EventArgs e)
        {
            if (tbCidade.Text == String.Empty)
            {
                epFornecedor.SetError(tbCidade, "Campo obrigatório!");
            }
            else
                epFornecedor.Clear();
        }

        private void mtbCep_Leave(object sender, EventArgs e)
        {
            if (mtbCep.Text == String.Empty)
            {
                epFornecedor.SetError(mtbCep, "Campo obrigatório!");
            }
            else
                epFornecedor.Clear();
        }

        private void tbEstado_Leave(object sender, EventArgs e)
        {
            if (cbEstado.Text == String.Empty)
            {
                epFornecedor.SetError(cbEstado, "Campo obrigatório!");
            }
            else
                epFornecedor.Clear();
        }

        private void mtbTelefone_Leave(object sender, EventArgs e)
        {
            if (mtbTelefone.Text == String.Empty)
            {
                epFornecedor.SetError(mtbTelefone, "Campo obrigatório!");
            }
            else
                epFornecedor.Clear();
        }

        private void mtbCelular_Leave(object sender, EventArgs e)
        {
            if (mtbCelular.Text == String.Empty)
            {
                epFornecedor.SetError(mtbCelular, "Campo obrigatório!");
            }
            else
                epFornecedor.Clear();
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (tbEmail.Text == String.Empty)
            {
                epFornecedor.SetError(tbEmail, "Campo obrigatório!");
            }
            else
                epFornecedor.Clear();
        }

    }
}
