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
    public partial class FrmCadastroFuncionario : Form
    {
        //Classe metodos de Validção 
        Formulas.Metodos metodos = new Formulas.Metodos();

        //Instaciando
        NegFuncionario nFuncionario = new NegFuncionario();
        Funcionario objFuncionario = new Funcionario();

        public FrmCadastroFuncionario()
        {
            InitializeComponent();
        }

        //-------------------------Métodos

        //Metodo para validar campos
        public Boolean metodoValidaCampos()
        {

            if (tbNome.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o nome do Funcionário!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNome.Clear();
                tbNome.Focus();

                return false;
            }
            else if (tbSobrenome.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o sobrenome do Funcionário!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSobrenome.Clear();
                tbSobrenome.Focus();

                return false;
            }
            else if (mtbRg.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o RG do Funcionário!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbRg.Clear();
                mtbRg.Focus();

                return false;
            }
            else if (mtbCpf.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o CPF do Funcionário!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbCpf.Clear();
                mtbCpf.Focus();

                return false;
            }
            else if (metodos.metodoValidarCPF(mtbCpf.Text) == false)
            {
                MessageBox.Show("CPF Inválido!",
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbCpf.Focus();
                return false;
            } 
            else if (mtbCtps.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o CTPS do Funcionário!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbCtps.Clear();
                mtbCtps.Focus();

                return false;
            }
            else if (tbEndereco.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o endereço do Funcionário!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbEndereco.Clear();
                tbEndereco.Focus();

                return false;
            }
            else if (tbBairro.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o bairro do Funcionário!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbBairro.Clear();
                tbBairro.Focus();

                return false;
            }
            else if (tbNumero.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o número do Funcionário!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNumero.Clear();
                tbNumero.Focus();

                return false;
            }
            else if (tbCidade.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o cidade do Funcionário!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbCidade.Clear();
                tbCidade.Focus();

                return false;
            }
            else if (mtbCep.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o CEP do Funcionário!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbCep.Clear();
                mtbCep.Focus();

                return false;
            }
            else if (cbEstado.SelectedItem == null)
            {
                MessageBox.Show("Informe o estado do Funcionário!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbEstado.SelectedItem = null;
                cbEstado.Focus();

                return false;
            }
            else if (mtbTelefone.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o telefone do Funcionário!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbTelefone.Clear();
                mtbTelefone.Focus();

                return false;
            }
            else if (mtbCelular.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o celular do Funcionário!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbCelular.Clear();
                mtbCelular.Focus();

                return false;
            }
            else if (dtpNascimento.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe a data de nascimento do Funcionário!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpNascimento.ResetText();
                dtpNascimento.Focus();

                return false;
            }
            else if (rbMasculino.Checked == false && rbFeminino.Checked == false)
            {
                MessageBox.Show("Informe o sexo do Funcionário!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rbMasculino.Focus();
                rbMasculino.Checked = false;
                rbFeminino.Checked = false;

                return false;
            }
            else if (mtbSalario.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o salário do Funcionário!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbSalario.Clear();
                mtbSalario.Focus();
                return false;
            }
            else
                return true;

        }

        //Metodo para limpar os campos
        public void metodoLimpaCampos()
        {
            epFuncionario.Clear();
            tbNome.Clear();
            tbEndereco.Clear();
            tbSobrenome.Clear();
            tbCidade.Clear();
            mtbCelular.Clear();
            mtbCep.Clear();
            mtbCpf.Clear();
            mtbCtps.Clear();
            mtbRg.Clear();
            mtbTelefone.Clear();
            dtpNascimento.ResetText();
            tbNumero.Clear();
            tbBairro.Clear();
            cbEstado.SelectedItem = null;
            rbMasculino.Checked = false;
            rbFeminino.Checked = false;
            mtbSalario.Clear();
        }

        //Teclas de atalho
        private void FrmCadastroFuncionario_KeyDown(object sender, KeyEventArgs e)
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

        //Permite só números
        private void tbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.metodoAllowNumber(e);
        }
        
        //Valor Dinheiro
        private void mtbSalario_TextChanged(object sender, EventArgs e)
        {
            metodos.metodoMoedaMTB(ref mtbSalario);
        }

        //Ativa Erro Provider
        public void metodoEpFuncionario(TextBox txt , MaskedTextBox mtb)
        {
            if (txt != null)
            {
                //Verifica se o campo for preenchido
                if (txt.Text == String.Empty)
                {
                    epFuncionario.SetError(txt, "Campo obrigatório!");
                    return;
                }
                else
                    epFuncionario.Clear();
            } 
            else if (mtb != null)
            {
                //Verifica se o campo for preenchido
                if (mtb.Text == String.Empty)
                {
                    epFuncionario.SetError(mtb, "Campo obrigatório!");
                    return;
                }
                else
                    epFuncionario.Clear();
            }
        }

        //------------------------Botões
        //Botão Sair
        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair do Cadastro de Funcionário ?",
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

        //Botão Cadastrar
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            mtbCpf_Leave(null, null);
            mtbRg_Leave(null, null);
            
            //Valida se todos os campos foram preenchidos
            if (metodoValidaCampos() == true)
            {
                try
                {
                    NegFuncionario nFuncionario = new NegFuncionario();
                    Funcionario funcionario = new Funcionario();

                    funcionario.nomeFuncionario = tbNome.Text;
                    funcionario.sobrenomeFuncionario = tbSobrenome.Text;
                    funcionario.rgFuncionario = mtbRg.Text;
                    funcionario.cpfFuncionario = mtbCpf.Text;
                    funcionario.ctpsFuncionario = mtbCtps.Text;
                    funcionario.enderecoFuncionario = tbEndereco.Text;
                    funcionario.bairroFuncionario = tbBairro.Text;
                    funcionario.numeroFuncionario = int.Parse(tbNumero.Text);
                    funcionario.cidadeFuncionario = tbCidade.Text;
                    funcionario.estadoFuncionario = cbEstado.SelectedItem.ToString();
                    funcionario.cepFuncionario = mtbCep.Text;
                    funcionario.telefoneFuncionario = mtbTelefone.Text;
                    funcionario.celularFuncionario = mtbCelular.Text;
                    funcionario.dataNascimentoFuncionario = dtpNascimento.Value;
                    funcionario.salarioFuncionario = Decimal.Parse(mtbSalario.Text);

                    if (rbMasculino.Checked == true)
                    {
                        funcionario.sexoFuncionario = rbMasculino.Text;
                    }
                    else if (rbFeminino.Checked == true)
                    {
                        funcionario.sexoFuncionario = rbFeminino.Text;
                    }

                    if (nFuncionario.CadastrarFuncionario(funcionario) == true)
                    {
                        DialogResult resposta;
                        //Criando Caixa de dialogo
                        FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
                        " Cadastro Realizado com Sucesso! \r\n" +
                        "Deseja Continuar No Cadastro De Funcionário?",
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
                        tbNome.Focus();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("O Funcionário já cadastrado. Nome: " + funcionario.nomeFuncionario + " RG: " + funcionario.rgFuncionario + " CPF: " + funcionario.cpfFuncionario, "Erro Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbNome.Focus();
                        return;
                    }

                }

                catch (Exception ex)
                {
                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro",
                    "Erro ao cadastrar Funcionário \r\n" + ex.Message,
                    Properties.Resources.DialogErro,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Ok", "",
                    false);

                    frmCaixa.ShowDialog();
                }
            }
        }

        //------------------------Validação

        //Valida Nome
        private void tbNome_Leave(object sender, EventArgs e)
        {
            metodoEpFuncionario(tbNome, null);
        }

        //Valida Sobrenome
        private void tbSobrenome_Leave(object sender, EventArgs e)
        {
            metodoEpFuncionario(tbSobrenome, null);
        }

        //Validando RG
        private void mtbRg_Leave(object sender, EventArgs e)
        {
            try
            {
                //Verifica se o campo for preenchido
                if (mtbRg.Text == String.Empty)
                {
                    epFuncionario.SetError(mtbRg, "Campo obrigatório!");
                    return;
                }
                else
                    epFuncionario.Clear();

                //Verifica se já existe CPF cadastrado
                Funcionario funcionario = new Funcionario();
                funcionario = nFuncionario.ValidarNovoCadastroRG(mtbRg.Text);
                if (funcionario != null)
                {
                    //Criando Caixa de dialogo
                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("RG já Existe",
                    " Cód: " + funcionario.codigoFuncionario +
                    " Nome: " + funcionario.nomeFuncionario + " " + funcionario.sobrenomeFuncionario +
                    " RG: " + funcionario.rgFuncionario,
                    Properties.Resources.DialogWarning,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Ok", "",
                    false);
                    frmCaixa.ShowDialog();
                    //Volta parametro para caixa de texto
                    mtbRg.Clear();
                    mtbRg.Focus();
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

        //Validando CPf
        private void mtbCpf_Leave(object sender, EventArgs e)
        {
            try
            {
                //Verifica se o campo for preenchido
                if (mtbCpf.Text == String.Empty)
                {
                    epFuncionario.SetError(mtbCpf, "Campo obrigatório!");
                    return;
                }
                else
                    epFuncionario.Clear();

                //Verifica se já existe CPF cadastrado
                Funcionario funcionario = new Funcionario();
                funcionario = nFuncionario.ValidarNovoCadastroCpf(mtbCpf.Text);
                if (funcionario != null)
                {
                    //Criando Caixa de dialogo
                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("CPF já Existe",
                    " Cód: " + funcionario.codigoFuncionario +
                    " Nome: " + funcionario.nomeFuncionario + " " + funcionario.sobrenomeFuncionario +
                    " CPF: " + funcionario.cpfFuncionario,
                    Properties.Resources.DialogWarning,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Ok", "",
                    false);
                    frmCaixa.ShowDialog();
                    //Volta parametro para caixa de texto
                    mtbCpf.Clear();
                    mtbCpf.Focus();
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

        //Valida CTPS
        private void mtbCtps_Leave(object sender, EventArgs e)
        {
            metodoEpFuncionario(null,mtbCtps);
        }

        //Valida Endereco
        private void tbEndereco_Leave(object sender, EventArgs e)
        {
            metodoEpFuncionario(tbEndereco,null);
        }

        //Valida Bairro
        private void tbBairro_Leave(object sender, EventArgs e)
        {
            metodoEpFuncionario(tbBairro, null);
        }

        //Valida Número
        private void tbNumero_Leave(object sender, EventArgs e)
        {
            metodoEpFuncionario(tbNumero, null);
        }

        //Valida Cidade
        private void tbCidade_Leave(object sender, EventArgs e)
        {
            metodoEpFuncionario(tbCidade, null);
        }

        //Valida o Cep
        private void mtbCep_Leave(object sender, EventArgs e)
        {
            metodoEpFuncionario(null, mtbCep);
        }

        //Valida o estado
        private void cbEstado_Leave(object sender, EventArgs e)
        {
            //Verifica se o campo for preenchido
            if (cbEstado.Text == String.Empty)
            {
                epFuncionario.SetError(cbEstado, "Campo obrigatório!");
                return;
            }
            else
                epFuncionario.Clear();
        }

        //Valida o telefone
        private void mtbTelefone_Leave(object sender, EventArgs e)
        {
            metodoEpFuncionario(null, mtbTelefone);
        }

        //Valida o Celular
        private void mtbCelular_Leave(object sender, EventArgs e)
        {
            metodoEpFuncionario(null, mtbCelular);
        }

        //Valida o salário
        private void mtbSalario_Leave(object sender, EventArgs e)
        {
            metodoEpFuncionario(null, mtbSalario);
        }



    }
}
