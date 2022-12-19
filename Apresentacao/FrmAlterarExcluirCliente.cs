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
    public partial class FrmAlterarExcluirCliente : Form
    {
        Cliente clienteCorrente;
        NegCliente nCliente = new NegCliente();
        Formulas.Metodos metodos = new Formulas.Metodos();


        public FrmAlterarExcluirCliente(Cliente cliente)
        {
            InitializeComponent();

            this.clienteCorrente = cliente;
        }


        //metodo para iniciar os campos do formulario
        public void metodoIniciaFormulario()
        {
            tbCodigo.Enabled = false;

            this.tbCodigo.Text = clienteCorrente.codigoCliente.ToString();
            this.tbNome.Text = clienteCorrente.nomeCliente;
            this.tbSobrenome.Text = clienteCorrente.sobrenomeCliente;
            this.mtbRg.Text = clienteCorrente.rgCliente;
            this.mtbCpf.Text = clienteCorrente.cpfCliente;
            this.tbEndereco.Text = clienteCorrente.enderecoCliente;
            this.tbBairro.Text = clienteCorrente.bairroCliente;
            this.tbNumero.Text = clienteCorrente.numeroCliente.ToString();
            this.tbCidade.Text = clienteCorrente.cidadeCliente;
            this.cbEstado.Text = clienteCorrente.estadoCliente;
            this.mtbCep.Text = clienteCorrente.cepCliente;
            this.mtbTelefone.Text = clienteCorrente.telefoneCliente;
            this.mtbCelular.Text = clienteCorrente.celularCliente;
            this.tbEmail.Text = clienteCorrente.emailCliente;
            this.dtpNascimento.Value = clienteCorrente.dataNascimentoCliente;
            //verificação para realizar escolha do sexo
            if (clienteCorrente.sexoCliente == "MASCULINO")
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
        private void FrmAlterarExcluirCliente_Load(object sender, EventArgs e)
        {
            metodoIniciaFormulario();
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
            else if (cbEstado.SelectedItem == null)
            {
                MessageBox.Show("Informe o estado do Cliente!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbEstado.SelectedItem = null;
                cbEstado.Focus();

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

        //Permite apenas valores numéricos campo  Número
        private void tbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.metodoAllowNumber(e);
        }

        //Teclas de Atalho
        private void FrmAlterarExcluirCliente_KeyDown(object sender, KeyEventArgs e)
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

        //-------------------------Botões

        //Botão as Desfazer
        private void btDesfazer_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Desfazer",
            " Deseja realmente desfazer alterações ?",
            Properties.Resources.DialogProcessando,
            Color.White,
            Color.Black,
            "Confirmar","Cancelar",
            false);

            resposta = frmCaixa.ShowDialog();
            if (resposta == DialogResult.Yes)
            {
                metodoIniciaFormulario();
                epCliente.Clear();

            }

        }
       
        //Botão sair
        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair da Alteração & Exclusão de Cliente ?",
            Properties.Resources.DialogQuestion,
            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
            Color.White,
            "Sim","Não",
            false);

            resposta = frmCaixa.ShowDialog();
            if (resposta == DialogResult.Yes)
            {
                this.Close();

            }
        }

        //Botão Alterar
        private void btAlterar_Click(object sender, EventArgs e)
        {
          try
             {

              //Valida Preenchimento chamando função
              mtbRg_Leave(null,null);
              mtbCpf_Leave(null,null);
              
              //Validas se os campos estão preenchidos
            if (metodoValidaCampos() == true) {

                DialogResult resposta;
                //Criando Caixa de dialogo
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Alteração",
                " Deseja realmente Alterar os dados do Cliente ?",
                Properties.Resources.Alterar,
                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                Color.White,
                "Confirmar", "Cancelar",
                false);

                //Verifica se o usuário realmente quer alterar os dados do cliente.
                resposta = frmCaixa.ShowDialog();
                if (resposta == DialogResult.Yes)
                {
                    NegCliente nCliente = new NegCliente();
                    Cliente clienteAlterado = new Cliente();
                 
                    clienteAlterado.codigoCliente = int.Parse(tbCodigo.Text);
                    clienteAlterado.nomeCliente = tbNome.Text;
                    clienteAlterado.sobrenomeCliente = tbSobrenome.Text;
                    clienteAlterado.rgCliente = mtbRg.Text;
                    clienteAlterado.cpfCliente = mtbCpf.Text;
                    clienteAlterado.enderecoCliente = tbEndereco.Text;
                    clienteAlterado.bairroCliente = tbBairro.Text;
                    clienteAlterado.numeroCliente = int.Parse(tbNumero.Text);
                    clienteAlterado.cidadeCliente = tbCidade.Text;
                    clienteAlterado.estadoCliente = cbEstado.Text;
                    clienteAlterado.cepCliente = mtbCep.Text;
                    clienteAlterado.telefoneCliente = mtbTelefone.Text;
                    clienteAlterado.celularCliente = mtbCelular.Text;
                    clienteAlterado.emailCliente = tbEmail.Text;
                    clienteAlterado.dataNascimentoCliente = dtpNascimento.Value;
                    if (rbMasculino.Checked == true) {
                        clienteAlterado.sexoCliente = rbMasculino.Text;
                    }
                    else
                        clienteAlterado.sexoCliente = rbFeminino.Text;

                    //Realizando o Cadastro
                    if (nCliente.AtualizarCliente(clienteAlterado) == true)
                      {
                         
                          //Criando Caixa de dialogo
                          frmCaixa = new FrmCaixaDialogo("Alteração",
                          "Cliente Alterado com sucesso !\r\n"+
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
                   }       
                }
             }
          catch (Exception ex)
          {
              MessageBox.Show("Não foi possível atualizar os dados do Cliente. Motivo: " + ex.Message);
          }
        }

        //Botão Excluir
        private void btExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Exclusão",
            " Deseja realmente Excluir o Cliente ?",
            Properties.Resources.Excluir,
            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
            Color.White,
            "Confirmar", "Cancelar",
            false);

            resposta = frmCaixa.ShowDialog();
            if (resposta == DialogResult.Yes)
            {
                if (nCliente.ExcluirCliente(clienteCorrente) == true)
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
                else{

                    //Criando Caixa de dialogo
                    frmCaixa = new FrmCaixaDialogo("Exclusão",
                    "Não foi possível realizar a exclusão do Cliente ! \r\n"+
                    "Cliente está vinculado a Vendas!",
                    Properties.Resources.DialogWarning,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Ok", "",
                    false);
                    frmCaixa.ShowDialog();
                    //Fecha o formulário
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }
        }

        //--------------------------Validações

        //Validação campo Nome
        private void tbNome_Leave(object sender, EventArgs e)
        {
            if (tbNome.Text == String.Empty)
            {
                epCliente.SetError(tbNome, "Campo obrigatório!");
            }
            else
                epCliente.Clear();
        }

        //Validação campo Sobrenome
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

        //Validação Campo RG
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


                //Verifica se o valor digitado não é o mesmo que esta no objto
                if (mtbRg.Text != clienteCorrente.rgCliente)
                {
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

        //Validação campo CPF
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


                //Verifica se o valor digitado não é o mesmo que esta na memoria
                if (mtbCpf.Text != clienteCorrente.cpfCliente)
                {

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

        //Valida campo Endereço
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

        //Valida Campo Bairro
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

        //Valida campo número
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

        //Valida campo email
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

        //Valida campo cidade
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

        //Valida campo Cep
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

        //Valida campo Telefone
        private void mtbTelefone_Leave(object sender, EventArgs e)
        {
            if (mtbTelefone.Text == String.Empty)
            {
                epCliente.SetError(mtbTelefone, "Campo obrigatório!");
            }
            else
                epCliente.Clear();
        }

        //Valida campo Celular
        private void mtbCelular_Leave(object sender, EventArgs e)
        {
            if (mtbCelular.Text == String.Empty)
            {
                epCliente.SetError(mtbCelular, "Campo obrigatório!");
            }
            else
                epCliente.Clear();
        }





    }
}
