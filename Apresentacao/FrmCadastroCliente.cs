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
    public partial class FrmCadastroCliente : Form
    {
        //Classe metodos de Validção 
        Formulas.Metodos metodos = new Formulas.Metodos();

        //Instaciando
        NegCliente nCliente = new NegCliente();
        Cliente objCliente = new Cliente();

        public FrmCadastroCliente()
        {
            InitializeComponent();
        }

        //Metodo para validar campos
        public Boolean metodoValidaCampos()
        {

            if (tbNome.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o nome do Cliente!",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNome.Clear();
                tbNome.Focus();

                return false;
            }
            else if (tbSobrenome.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o sobrenome do Cliente!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSobrenome.Clear();
                tbSobrenome.Focus();

                return false;
            }
            else if (mtbRg.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o RG do Cliente!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbRg.Clear();
                mtbRg.Focus();

                return false;
            }
            else if (mtbCpf.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o CPF do Cliente!",
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

            else if (tbEndereco.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o endereço do Cliente!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbEndereco.Clear();
                tbEndereco.Focus();

                return false;
            }
            else if (tbBairro.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o bairro do Cliente!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbBairro.Clear();
                tbBairro.Focus();

                return false;
            }
            else if (tbNumero.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o número do Cliente!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNumero.Clear();
                tbNumero.Focus();

                return false;
            }
            else if (tbEmail.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o email do Cliente!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbEmail.Clear();
                tbEmail.Focus();

                return false;
            }
            else if (tbCidade.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o cidade do Cliente!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbCidade.Clear();
                tbCidade.Focus();

                return false;
            }
            else if (mtbCep.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o CEP do Cliente!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbCep.Clear();
                mtbCep.Focus();

                return false;
            }
            else if (cbEstado.SelectedItem == null)
            {
                MessageBox.Show("Informe o estado do Cliente!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbEstado.SelectedItem = null;
                cbEstado.Focus();

                return false;
            }
            else if (mtbTelefone.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o telefone do Cliente!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbTelefone.Clear();
                mtbTelefone.Focus();

                return false;
            }
            else if (mtbCelular.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe o celular do Cliente!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbCelular.Clear();
                mtbCelular.Focus();

                return false;
            }
            else if (dtpNascimento.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Informe a data de nascimento do Cliente!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpNascimento.ResetText();
                dtpNascimento.Focus();

                return false;
            }
            else if (rbMasculino.Checked == false && rbFeminino.Checked == false)
            {
                MessageBox.Show("Informe o sexo do Cliente!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rbMasculino.Focus();
                rbMasculino.Checked = false;
                rbFeminino.Checked = false;

                return false;
            }
            else
                return true;


        }

        //Metodo para limpar os campos
        public void metodoLimpaCampos()
        {
            epCliente.Clear();
            tbNome.Clear();
            tbEndereco.Clear();
            tbSobrenome.Clear();
            tbCidade.Clear();
            mtbCelular.Clear();
            mtbCep.Clear();
            mtbCpf.Clear();
            mtbRg.Clear();
            mtbTelefone.Clear();
            dtpNascimento.ResetText();
            tbNumero.Clear();
            tbBairro.Clear();
            cbEstado.SelectedItem = null;
            rbMasculino.Checked = false;
            rbFeminino.Checked = false;
            tbEmail.Clear();
        }

        //Só permite números no campo Número
        private void tbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.metodoAllowNumber(e);
        }

        //Teclas de atalho do formuláro
        private void FrmCadastroCliente_KeyDown(object sender, KeyEventArgs e)
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


        //-----------------Validações

        //Mostra que o campo nome deve ser preenchido
        private void tbNome_Leave(object sender, EventArgs e)
        {  
           //Verifica se o campo for preenchido
            if (tbNome.Text == String.Empty)
            {
                epCliente.SetError(tbNome, "Campo obrigatório!");
                return;
            }
            else
                epCliente.Clear();

        }

        //Mostra que o capo sobrenome deve ser preenchidpo
        private void tbSobrenome_Leave(object sender, EventArgs e)
        {
            //Verifica se o campo for preenchido
            if (tbSobrenome.Text == String.Empty)
            {
                epCliente.SetError(tbSobrenome, "Campo obrigatório!");
                return;
            }
            else
                epCliente.Clear();
        }

        //Mostra que o campo rg é obrigatório
        private void mtbRg_Leave(object sender, EventArgs e)
        {
            try
            {
                //Verifica se o campo for preenchido
                if (mtbRg.Text == String.Empty)
                {
                    epCliente.SetError(mtbRg, "Campo obrigatório!");
                    return;
                }
                else
                    epCliente.Clear();

                //Verifica se já existe CPF cadastrado
                Cliente cliente = new Cliente();
                cliente = nCliente.ValidarNovoCadastroRG(mtbRg.Text);
                if (cliente != null)
                {
                    //Criando Caixa de dialogo
                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("RG já Existe",
                    " Cód: " + cliente.codigoCliente +
                    " Nome: " + cliente.nomeCliente + " " + cliente.sobrenomeCliente +
                    " RG: " + cliente.rgCliente,
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

        //Valida Cliente já está cadastrado
        private void mtbCpf_Leave(object sender, EventArgs e)
        {
            try
            {
                //Verifica se o campo for preenchido
                if (mtbCpf.Text == String.Empty)
                {
                    epCliente.SetError(mtbCpf, "Campo obrigatório!");
                    return;
                }
                else
                    epCliente.Clear();

                //Verifica se já existe CPF cadastrado
                Cliente cliente = new Cliente();
                cliente = nCliente.ValidarNovoCadastroCpf(mtbCpf.Text);
                if (cliente != null)
                {
                    //Criando Caixa de dialogo
                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("CPF já Existe",
                    " Cód: " + cliente.codigoCliente +
                    " Nome: " + cliente.nomeCliente + " " + cliente.sobrenomeCliente +
                    " CPF: " + cliente.cpfCliente,
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

        //Mostra campo endereço deve ser preenchido
        private void tbEndereco_Leave(object sender, EventArgs e)
        {
            //Verifica se o campo for preenchido
            if (tbEndereco.Text == String.Empty)
            {
                epCliente.SetError(tbEndereco, "Campo obrigatório!");
                return;
            }
            else
                epCliente.Clear();
        }

        //Mostra campo bairro deve ser preenchido
        private void tbBairro_Leave(object sender, EventArgs e)
        {
            //Verifica se o campo for preenchido
            if (tbBairro.Text == String.Empty)
            {
                epCliente.SetError(tbBairro, "Campo obrigatório!");
                return;
            }
            else
                epCliente.Clear();
        }

        //Mostra campo número deve ser preenchido
        private void tbNumero_Leave(object sender, EventArgs e)
        {
            //Verifica se o campo for preenchido
            if (tbNumero.Text == String.Empty)
            {
                epCliente.SetError(tbNumero, "Campo obrigatório!");
                return;
            }
            else
                epCliente.Clear();
        }

        //Mostra campo email deve ser preenchido
        private void tbEmail_Leave(object sender, EventArgs e)
        {
            //Verifica se o campo for preenchido
            if (tbEmail.Text == String.Empty)
            {
                epCliente.SetError(tbEmail, "Campo obrigatório!");
                return;
            }
            else
                epCliente.Clear();
        }

        //Mostra campo cidade deve ser preenchido
        private void tbCidade_Leave(object sender, EventArgs e)
        {
            //Verifica se o campo for preenchido
            if (tbCidade.Text == String.Empty)
            {
                epCliente.SetError(tbCidade, "Campo obrigatório!");
                return;
            }
            else
                epCliente.Clear();
        }

        //Mostra campo cep deve ser preenchido
        private void mtbCep_Leave(object sender, EventArgs e)
        {
            //Verifica se o campo for preenchido
            if (mtbCep.Text == String.Empty)
            {
                epCliente.SetError(mtbCep, "Campo obrigatório!");
                return;
            }
            else
                epCliente.Clear();
        }

        //Mostra campo estado deve ser preenchido
        private void cbEstado_Leave(object sender, EventArgs e)
        {
            if (cbEstado.Text == String.Empty)
            {
                epCliente.SetError(cbEstado, "Campo obrigatório!");
            }
            else
                epCliente.Clear();
        }

        //Mostra campo telefone deve ser preenchido
        private void mtbTelefone_Leave(object sender, EventArgs e)
        {
            if (mtbTelefone.Text == String.Empty)
            {
                epCliente.SetError(mtbTelefone, "Campo obrigatório!");
            }
            else
                epCliente.Clear();

        }

        //Mostra campo celular deve ser preenchido
        private void mtbCelular_Leave(object sender, EventArgs e)
        {
            if (mtbCelular.Text == String.Empty)
            {
                epCliente.SetError(mtbCelular, "Campo obrigatório!");
            }
            else
                epCliente.Clear();
        }


        //----------------------------Botões

        //Botão Cadastrar Cliente
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            //Chama função realiza validação 
            mtbRg_Leave(null ,null);
            mtbCpf_Leave(null,null);

            //Valida se todos os campos foram preenchidos
            if (metodoValidaCampos() == true)
            {
                try
                {
                    NegCliente nCliente = new NegCliente();
                    Cliente cliente = new Cliente();

                    cliente.nomeCliente = tbNome.Text;
                    cliente.sobrenomeCliente = tbSobrenome.Text;
                    cliente.rgCliente = mtbRg.Text;
                    cliente.cpfCliente = mtbCpf.Text;
                    cliente.enderecoCliente = tbEndereco.Text;
                    cliente.bairroCliente = tbBairro.Text;
                    cliente.numeroCliente = int.Parse(tbNumero.Text);
                    cliente.cidadeCliente = tbCidade.Text;
                    cliente.estadoCliente = cbEstado.SelectedItem.ToString();
                    cliente.cepCliente = mtbCep.Text;
                    cliente.telefoneCliente = mtbTelefone.Text;
                    cliente.celularCliente = mtbCelular.Text;
                    cliente.emailCliente = tbEmail.Text;
                    cliente.dataNascimentoCliente = dtpNascimento.Value;

                    if (rbMasculino.Checked == true)
                    {
                        cliente.sexoCliente = rbMasculino.Text;
                    }
                    else if (rbFeminino.Checked == true)
                    {
                        cliente.sexoCliente = rbFeminino.Text;
                    }

                    if (nCliente.CadastrarCliente(cliente) == true)
                    {
                        DialogResult resposta;
                        //Criando Caixa de dialogo
                        FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
                        " Cadastro Realizado com Sucesso! \r\n" +
                        "Deseja Continuar No Cadastro De Cliente?",
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
                        MessageBox.Show("O Cliente já cadastrado. Nome: " + cliente.nomeCliente + " RG: " + cliente.rgCliente + " CPF: " + cliente.cpfCliente, "Erro Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbNome.Focus();
                        return;
                    }

                }

                catch (Exception ex)
                {
                        FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro",
                        "Erro ao cadastrar Cliente \r\n"+ex.Message,
                        Properties.Resources.DialogErro,
                        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                        Color.White,
                        "Ok", "",
                        false);

                        frmCaixa.ShowDialog();
                }
            }
        }

        //Sair do Formulário
        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair do Cadastro de Cliente ?",
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

    }
}
