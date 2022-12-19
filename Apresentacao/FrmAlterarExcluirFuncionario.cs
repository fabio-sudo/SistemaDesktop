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
    public partial class FrmAlterarExcluirFuncionario : Form
    {
        Funcionario FuncionarioCorrente;
        NegFuncionario nFuncionario = new NegFuncionario();
        Formulas.Metodos metodos = new Formulas.Metodos();

        public FrmAlterarExcluirFuncionario(Funcionario funcionario)
        {
            InitializeComponent();

            this.FuncionarioCorrente = funcionario;
        }

        //-----------------------------------Métodos
        //metodo para iniciar os campos do formulario
        public void metodoIniciaFormulario()
        {
            tbCodigo.Enabled = false;

            this.tbCodigo.Text = FuncionarioCorrente.codigoFuncionario.ToString();
            this.tbNome.Text = FuncionarioCorrente.nomeFuncionario;
            this.tbSobrenome.Text = FuncionarioCorrente.sobrenomeFuncionario;
            this.mtbRg.Text = FuncionarioCorrente.rgFuncionario;
            this.mtbCpf.Text = FuncionarioCorrente.cpfFuncionario;
            this.mtbCtps.Text = FuncionarioCorrente.ctpsFuncionario;
            this.tbEndereco.Text = FuncionarioCorrente.enderecoFuncionario;
            this.tbBairro.Text = FuncionarioCorrente.bairroFuncionario;
            this.tbNumero.Text = FuncionarioCorrente.numeroFuncionario.ToString();
            this.tbCidade.Text = FuncionarioCorrente.cidadeFuncionario;
            this.cbEstado.Text = FuncionarioCorrente.estadoFuncionario;
            this.mtbCep.Text = FuncionarioCorrente.cepFuncionario;
            this.mtbTelefone.Text = FuncionarioCorrente.telefoneFuncionario;
            this.mtbCelular.Text = FuncionarioCorrente.celularFuncionario;
            this.dtpNascimento.Value = FuncionarioCorrente.dataNascimentoFuncionario;
            this.mtbSalario.Text = (FuncionarioCorrente.salarioFuncionario/100).ToString();
            //verificação para realizar escolha do sexo
            if (FuncionarioCorrente.sexoFuncionario == "MASCULINO")
            {
                rbFeminino.Checked = false;
                rbMasculino.Checked = true;
            }
            else
            {
                rbMasculino.Checked = false;
                rbFeminino.Checked = true;
            }

        }

        //Evento Preencher o formulário ao iniciar
        private void FrmAlterarExcluirFuncionario_Load(object sender, EventArgs e)
        {
            metodoIniciaFormulario();
        }

        //Define valor dinheiro para o campo salario
        private void mtbSalario_TextChanged(object sender, EventArgs e)
        {
            metodos.metodoMoedaMTB(ref mtbSalario);
        }
        
        //Permite só numeros
        private void tbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.metodoAllowNumber(e);
        }

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

        //Ativa Erro Provider
        public void metodoEpFuncionario(TextBox txt, MaskedTextBox mtb)
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

        //Teclas de Atalho
        private void FrmAlterarExcluirFuncionario_KeyDown(object sender, KeyEventArgs e)
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


        //-------------------------Validações
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

                //Verifica se o valor digitado não é o mesmo que esta no objto
                if (mtbRg.Text != FuncionarioCorrente.rgFuncionario)
                {

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

                //Verifica se o valor digitado não é o mesmo que esta no objto
                if (mtbCpf.Text != FuncionarioCorrente.cpfFuncionario)
                {
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
            metodoEpFuncionario(null, mtbCtps);
        }

        //Valida Endereco
        private void tbEndereco_Leave(object sender, EventArgs e)
        {
            metodoEpFuncionario(tbEndereco, null);
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

        //----------------------------------Botões
        private void btAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                //Valida Preenchimento chamando função
                mtbRg_Leave(null, null);
                mtbCpf_Leave(null, null);

                //Validas se os campos estão preenchidos
                if (metodoValidaCampos() == true)
                {

                    DialogResult resposta;
                    //Criando Caixa de dialogo
                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Alteração",
                    " Deseja realmente Alterar os dados do Funcionário ?",
                    Properties.Resources.Alterar,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Confirmar", "Cancelar",
                     false);

                    //Verifica se o usuário realmente quer alterar os dados do Funcionario.
                    resposta = frmCaixa.ShowDialog();
                    if (resposta == DialogResult.Yes)
                    {
                        NegFuncionario nFuncionario = new NegFuncionario();
                        Funcionario funcionarioAlterado = new Funcionario();

                        funcionarioAlterado.codigoFuncionario = int.Parse(tbCodigo.Text);
                        funcionarioAlterado.nomeFuncionario = tbNome.Text;
                        funcionarioAlterado.sobrenomeFuncionario = tbSobrenome.Text;
                        funcionarioAlterado.rgFuncionario = mtbRg.Text;
                        funcionarioAlterado.cpfFuncionario = mtbCpf.Text;
                        funcionarioAlterado.ctpsFuncionario = mtbCtps.Text;
                        funcionarioAlterado.enderecoFuncionario = tbEndereco.Text;
                        funcionarioAlterado.bairroFuncionario = tbBairro.Text;
                        funcionarioAlterado.numeroFuncionario = int.Parse(tbNumero.Text);
                        funcionarioAlterado.cidadeFuncionario = tbCidade.Text;
                        funcionarioAlterado.estadoFuncionario = cbEstado.Text;
                        funcionarioAlterado.cepFuncionario = mtbCep.Text;
                        funcionarioAlterado.telefoneFuncionario = mtbTelefone.Text;
                        funcionarioAlterado.celularFuncionario = mtbCelular.Text;
                        funcionarioAlterado.salarioFuncionario = decimal.Parse(mtbSalario.Text);
                        funcionarioAlterado.dataNascimentoFuncionario = dtpNascimento.Value;
                        if (rbMasculino.Checked == true)
                        {
                            funcionarioAlterado.sexoFuncionario = rbMasculino.Text;
                        }
                        else
                            funcionarioAlterado.sexoFuncionario = rbFeminino.Text;

                        //Realizando o Cadastro
                        if (nFuncionario.AtualizarFuncionario(funcionarioAlterado) == true)
                        {

                            //Criando Caixa de dialogo
                            frmCaixa = new FrmCaixaDialogo("Alteração",
                            "Funcionário Alterado com sucesso !\r\n" +
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
                            MessageBox.Show("Não foi possível atualizar os dados do Funcionário. Erro no Banco de Dados!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível atualizar os dados do Funcionário. Motivo: " + ex.Message);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Exclusão",
            " Deseja realmente Excluir o Funcionário ?",
            Properties.Resources.Excluir,
            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
            Color.White,
            "Confirmar", "Cancelar",
            false);

            resposta = frmCaixa.ShowDialog();
            if (resposta == DialogResult.Yes)
            {
                if (nFuncionario.ExcluirFuncionario(FuncionarioCorrente) == true)
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
                    "Não foi possível realizar a exclusão do Funcionário ! \r\n" +
                    "Funcionario está vinculado com Usuario e Senha e Vendas!",
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

        //Botão Desfazer
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
                epFuncionario.Clear();

            }
        }

        //Botão Sair
        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair da Alteração & Exclusão de Funcionário ?",
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
