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
    public partial class FrmAlterarExcluirFornecedor : Form
    {
        //Classe metodos de Validção 
        Formulas.Metodos metodos = new Formulas.Metodos();

        //Instaciando
        NegFornecedor nFornecedor = new NegFornecedor();
        Fornecedor fornecedorCorrente = new Fornecedor();


        public FrmAlterarExcluirFornecedor(Fornecedor fornecedor)
        {
            InitializeComponent();
            this.fornecedorCorrente = fornecedor;
        }

        //Inicia o Formulário
        public void metodoIniciaFormulario()
        {
            tbCodigo.Enabled = false;
            this.tbCodigo.Text = fornecedorCorrente.codigoFornecedor.ToString();
            this.tbRazaoSocial.Text = fornecedorCorrente.razaoSocialFornecedor;
            this.tbNomeFantasia.Text = fornecedorCorrente.nomeFantasiaFornecedor;
            this.mtbCnpj.Text = fornecedorCorrente.cnpjFornecedor;
            this.mtbInscricaoEstadual.Text = fornecedorCorrente.inscricaoEstadualFornecedor;
            this.tbEndereco.Text = fornecedorCorrente.enderecoFornecedor;
            this.tbBairro.Text = fornecedorCorrente.bairroFornecedor;
            this.tbNumero.Text = fornecedorCorrente.numeroFornecedor.ToString();
            this.tbCidade.Text = fornecedorCorrente.cidadeFornecedor;
            this.cbEstado.Text = fornecedorCorrente.estadoFornecedor;
            this.mtbCep.Text = fornecedorCorrente.cepFornecedor;
            this.mtbTelefone.Text = fornecedorCorrente.telefoneFornecedor;
            this.mtbCelular.Text = fornecedorCorrente.celularFornecedor;
            this.tbEmail.Text = fornecedorCorrente.emailFornecedor;
        }

        private void FrmAlterarExcluirFornecedor_Load(object sender, EventArgs e)
        {
            metodoIniciaFormulario();
        }

        //Botões
        private void btAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                //Valida Preenchimento chamando função
                mtbCnpj_Leave(null, null);

                //Validas se os campos estão preenchidos
                if (metodoValidaCampos() == true)
                {

                    DialogResult resposta;
                    //Criando Caixa de dialogo
                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Alteração",
                    " Deseja realmente Alterar os dados do Fornecedor ?",
                    Properties.Resources.Alterar,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Confirmar", "Cancelar",
                    false);

                    //Verifica se o usuário realmente quer alterar os dados do Fornecedor.
                    resposta = frmCaixa.ShowDialog();
                    if (resposta == DialogResult.Yes)
                    {
                        NegFornecedor nFornecedor = new NegFornecedor();
                        Fornecedor fornecedorAlterado = new Fornecedor();

                        fornecedorAlterado.codigoFornecedor = int.Parse(tbCodigo.Text);
                        fornecedorAlterado.razaoSocialFornecedor = tbRazaoSocial.Text;
                        fornecedorAlterado.nomeFantasiaFornecedor = tbNomeFantasia.Text;
                        fornecedorAlterado.cnpjFornecedor = mtbCnpj.Text;
                        fornecedorAlterado.inscricaoEstadualFornecedor = mtbInscricaoEstadual.Text;
                        fornecedorAlterado.enderecoFornecedor = tbEndereco.Text;
                        fornecedorAlterado.bairroFornecedor = tbBairro.Text;
                        fornecedorAlterado.numeroFornecedor = int.Parse(tbNumero.Text);
                        fornecedorAlterado.cidadeFornecedor = tbCidade.Text;
                        fornecedorAlterado.estadoFornecedor = cbEstado.Text;
                        fornecedorAlterado.cepFornecedor = mtbCep.Text;
                        fornecedorAlterado.telefoneFornecedor = mtbTelefone.Text;
                        fornecedorAlterado.celularFornecedor = mtbCelular.Text;
                        fornecedorAlterado.emailFornecedor = tbEmail.Text;

                        //Realizando o Cadastro
                        if (nFornecedor.AtualizarFornecedor(fornecedorAlterado) == true)
                        {

                            //Criando Caixa de dialogo
                            frmCaixa = new FrmCaixaDialogo("Alteração",
                            "Fornecedor Alterado com sucesso !\r\n" +
                            "Alterações Finalizadas ?",
                            Properties.Resources.DialogOK,
                            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                            Color.White,
                            "Sim", "Não",
                            false);
                            resposta = frmCaixa.ShowDialog();

                            if (resposta == DialogResult.Yes)
                            {
                                //Retornando que exclusão foi realizada com sucesso
                                this.DialogResult = DialogResult.Yes;
                                this.Close();
                            }
                            else
                                return;

                        }
                        else
                        {
                            MessageBox.Show("Não foi possível atualizar os dados do Fornecedor. Erro no Banco de Dados!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível atualizar os dados do Fornecedor. Motivo: " + ex.Message);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Exclusão",
            " Deseja realmente Excluir o Fornecedor ?",
            Properties.Resources.Excluir,
            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
            Color.White,
            "Confirmar", "Cancelar",
            false);

            resposta = frmCaixa.ShowDialog();
            if (resposta == DialogResult.Yes)
            {
                if (nFornecedor.ExcluirFornecedor(fornecedorCorrente) == true)
                {
                    //Criando Caixa de dialogo
                    frmCaixa = new FrmCaixaDialogo("Exclusão",
                    " Exclusão realizada com sucesso !",
                    Properties.Resources.DialogOK,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                   "Ok", "",
                    false);
                    frmCaixa.ShowDialog();
                    //Retornando que exclusão foi realizada com sucesso
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                }
                else
                {

                    //Criando Caixa de dialogo
                    frmCaixa = new FrmCaixaDialogo("Exclusão",
                    "Não foi possível realizar a exclusão do Fornecedor ! \r\n" +
                    "Fornecedor está vinculado com Produto e Entrada de Estoque!",
                    Properties.Resources.DialogWarning,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Ok", "",
                    true);
                    frmCaixa.ShowDialog();
                    //Fecha o formulário
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }
        }

        private void btDesfazer_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Desfazer",
            " Deseja realmente desfazer alterações ?",
            Properties.Resources.DialogProcessando,
            Color.White,
            Color.Black,
            "Confirmar", "Cancelar",
            false);

            resposta = frmCaixa.ShowDialog();
            if (resposta == DialogResult.Yes)
            {
                metodoIniciaFormulario();
                epFornecedor.Clear();

            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair da Alteração & Exclusão de Fornecedor ?",
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

        //Validação
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

                 //Verifica se o valor digitado não é o mesmo que esta na memoria
                if (mtbCnpj.Text != fornecedorCorrente.cnpjFornecedor)
                {
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

        //Metodos
        private void FrmAlterarExcluirFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            //atalho da tecla de atalho ESC
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {

                btSair.PerformClick();

            }
            //F5 defazer
            else if (e.KeyCode.Equals(Keys.F5) == true)
            {

                btDesfazer.PerformClick();

            }
            //F2 Excluir
            else if (e.KeyCode.Equals(Keys.F2) == true)
            {

                btExcluir.PerformClick();

            }
            //F10 Alterar
            else if (e.KeyCode.Equals(Keys.F10) == true)
            {

                btAlterar.PerformClick();

            }
        }

        private void tbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.metodoAllowNumber(e);
        }

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



    }
}
