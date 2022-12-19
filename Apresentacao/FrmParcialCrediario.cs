using Apresentacao.Formulas;
using Negocio;
using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmParcialCrediario : Form
    {
        NegItemCrediario nParcial = new NegItemCrediario();
        ItemCrediarioParcial objItemCrediarioParcial = new ItemCrediarioParcial();
        //Tras Crediario e Cliente Carregados no objeto
        ItemCrediario objItemCrediario = new ItemCrediario();

        //---------------Forma de Pagamento
        FormaPagamento objFormaPagamento = new FormaPagamento();
        ListaFormaPagamento listaFormaPagamento = new ListaFormaPagamento();//Usado no combobox
        NegFormaPagamento nFormaPagamento = new NegFormaPagamento();//Prencher formas de pagamento
        //--------------Funções
        Metodos metodos = new Metodos();

        //-----Variaveis pora calculos
        double valorJuros = 0;
        double valorDesconto = 0;
        double valorAReceberIndividual = 0;
        double CalculaJuros = 0;
        double valorPagoBruto = 0;
        double valorLiquidoParcial = 0;

        public FrmParcialCrediario(ItemCrediario itemCrediario)
        {
            InitializeComponent();

            objItemCrediario = itemCrediario; 
        }

        public void metodoIniciaFormulario() {

            //------------Valores
            lbTotalBrutoParcial.Text = String.Format("{0:C2}", objItemCrediario.parcialItemCrediario);
            lbParcialBruto.Text = String.Format("{0:C2}", objItemCrediario.parcialItemCrediario);

            //-----------Descrição do Produto
            tbProduto.Text = "Produto: "+objItemCrediario.ProdutoCor.Produto.codigoProduto.ToString() +
            " " + objItemCrediario.ProdutoCor.Produto.descricaoProduto +
            " " + objItemCrediario.ProdutoCor.Cor.nomeCor; ;

            //-------Caixa de Texto
            tbCodigo.Text = objItemCrediario.Crediario.codigoCrediario.ToString();
            tbItemCrediario.Text = objItemCrediario.codigoItemCrediario.ToString();
            tbCodigoVenda.Text = objItemCrediario.Venda.codigoVenda.ToString();
            tbCliente.Text = objItemCrediario.Crediario.Cliente.nomeCliente + " " + objItemCrediario.Crediario.Cliente.sobrenomeCliente;

            //---------------Imagem
            //Buscal Local que a Solution Está sendo Executada no Computador
            string LocalSolution = Environment.CurrentDirectory;
            // This will get the current PROJECT directory
            LocalSolution = Directory.GetParent(LocalSolution).Parent.Parent.FullName;

            String imgProduto = objItemCrediario.ProdutoCor.ImagemProduto;
            //Verifica se a imagem existe
            if (System.IO.File.Exists(LocalSolution + "\\Imagens\\" + imgProduto + ".jpeg") == true)
            {
                //----------------Cria imagem para exibir 
                Image img;
                Bitmap img2;
                img = (System.Drawing.Image.FromFile(LocalSolution + "\\Imagens\\" + imgProduto + ".jpeg"));
                img2 = new Bitmap(img);
                img.Dispose();
                pbImagemProduto.Image = img2;
            }
            else
            {
                pbImagemProduto.Image = global::Apresentacao.Properties.Resources.imgDefaut;
            }
        
        
        
        }

        private Boolean metodoValidaParcial() { 
        
          if (cbFormaPagamento.SelectedItem == null)
            {
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro Forma Pagamento",
                "Informe a Forma de Pagamento para realizar a Venda",
                Properties.Resources.FormaPagamentoIcone,
                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                Color.White,
                "Ok", "",
                false);
                frmCaixa.ShowDialog();

                return false;
            }
          else if (Convert.ToDouble(tbValorPago.Text) == 0)
          {
              FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro Forma Pagamento",
              "Informe a valor da Parcial",
              Properties.Resources.FormaPagamentoIcone,
              System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
              Color.White,
              "Ok", "",
              false);
              frmCaixa.ShowDialog();

              return false;

          }
          else {
              return true;
          
          }
        
        }

        //----------Metodos Calculos
        private void metodoCalculaJuros()
        {

            CalculaJuros = 0;

            //-------Juros Cartão
            if (cbFormaPagamento.SelectedItem != null)
            {
                double valorPagoJuros = Convert.ToDouble(tbValorPago.Text);

                //Caso valor digitado no pagamento for maior que a Parcial a o valor é igualado com parcial para o calculo do desconto
                if (valorPagoJuros > objItemCrediario.parcialItemCrediario)
                {

                    valorPagoJuros = objItemCrediario.parcialItemCrediario;

                }
                CalculaJuros = Convert.ToDouble(lbTaxaJuros.Text) / 100;

                valorJuros = valorPagoJuros * CalculaJuros;
            }

            //Parcial Juros
            lbTaxa.Text = "% " + String.Format("{0:C2}", valorJuros);
            lbJurosParcial.Text = "% " + String.Format("{0:C2}", valorJuros);

        }

        //Calcuala Desconto individual
        private void metodoCalculaDesconto()
        {
            double valorPagoDesc = Convert.ToDouble(tbValorPago.Text);

            double Porcentagemdesconto = (Convert.ToDouble(nudDesconto.Value) / 100);

            //Caso valor digitado no pagamento for maior que a Parcial a o valor é igualado com parcial para o calculo do desconto
            if(valorPagoDesc > objItemCrediario.parcialItemCrediario){
            
            valorPagoDesc = objItemCrediario.parcialItemCrediario;
            
            }

            valorDesconto = (Porcentagemdesconto * valorPagoDesc);

            //Parcial Desconto
            lbDesconto.Text = "-  " + String.Format("{0:C2}", valorDesconto);
            lbDescontoParcial.Text = "-  " + String.Format("{0:C2}", valorDesconto);
        }

        //Calcuala Troco individual
        private void metodoCalculaTroco()
        {
            try
            {
                double valorTroco = 0;
                //------Troco
                valorTroco = Convert.ToDouble(tbRecebimento.Text) - valorAReceberIndividual;
                if (valorTroco < 0)
                {
                    valorTroco = 0;
                }
                lbTroco.Text = "- " + String.Format("{0:C2}", valorTroco);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //Calcula Valor Recebimento individual
        private void metodoCaculaRecebimento()
        {

            try
            {
               double valorPagoRecebimento = Convert.ToDouble(tbValorPago.Text);
               double valorParcialRestante = Convert.ToDouble(tbValorPago.Text);
               
                if(valorPagoRecebimento > objItemCrediario.parcialItemCrediario){             
                    
                    valorAReceberIndividual = objItemCrediario.parcialItemCrediario;          
                }

                if (cbTaxa.Checked == false)
                {
                    valorAReceberIndividual = (valorPagoRecebimento - valorDesconto);
                }
                else
                {

                    valorAReceberIndividual = ((valorPagoRecebimento - valorDesconto) + valorJuros);
                }

                valorParcialRestante = (valorParcialRestante - objItemCrediario.parcialItemCrediario);
                lbParcialRestante.Text = "+ " + String.Format("{0:C2}", valorParcialRestante);


                //Mostra se o item foi pago por Itenteiro na parcia
                if (valorParcialRestante != 0)
                {
                    pbOk.Visible = true;
                    pbOk.Image = Properties.Resources.DialogErro;
                }
                else
                {
                    pbOk.Visible = true;
                    pbOk.Image = Properties.Resources.DialogOK;
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        //Calcula Valor Recebimento individual
        private void metodoCaculaTotalBruto()
        {

            try
            {
                valorLiquidoParcial = 0;
                valorLiquidoParcial = Convert.ToDouble(tbValorPago.Text);
                
                if (cbTaxa.Checked == true) { valorLiquidoParcial = ((valorLiquidoParcial - valorDesconto) + valorJuros); }
                else
                {
                    valorLiquidoParcial = ((valorLiquidoParcial - valorDesconto) - valorJuros);
                }

                valorPagoBruto = 0;
                valorPagoBruto = Convert.ToDouble(tbValorPago.Text);
                valorPagoBruto = ((valorPagoBruto - valorDesconto) + valorJuros);


                lbParcialBruto.Text = "+ " + String.Format("{0:C2}", valorPagoBruto);
                lbValorParcialLiquido.Text = "+ " + String.Format("{0:C2}", valorLiquidoParcial);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        //Calcula Totais Gerais
        private void metodoCalculaTotais()
        {
            try
            {
                valorJuros = 0;
                valorDesconto = 0;
                valorAReceberIndividual = 0;

                metodoCalculaDesconto();//Calcula Desconto
                metodoCalculaJuros();//Calcula Juros
                metodoCaculaRecebimento();//Calcula Valor Pagamento
                metodoCaculaTotalBruto();

                //ParcialBruto
                lbValorTotalParcial.Text = "+ " + String.Format("{0:C2}", Convert.ToDouble(tbValorPago.Text));
               

                lbDinheiro.Text = "+ " + String.Format("{0:C2}", valorAReceberIndividual);
                lbTotalLiquidoParcial.Text = "+ " + String.Format("{0:C2}", valorAReceberIndividual);


                if (Convert.ToDouble(tbValorPago.Text) > objItemCrediario.parcialItemCrediario)
                {

                    valorAReceberIndividual = objItemCrediario.parcialItemCrediario;
                    tbValorPago.Text = (objItemCrediario.parcialItemCrediario * 100).ToString();
                }

                if (Convert.ToDouble(tbValorPago.Text) != 0)
                {

                    tbRecebimento.Enabled = true;
                }
                else { tbRecebimento.Enabled = false; tbRecebimento.Text = "0,00"; }


                metodoCalculaTroco();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //--------------------Forma de Pagamento
        private void cbFormaPagamento_DropDown(object sender, EventArgs e)
        {
            try
            {

                cbFormaPagamento.Items.Clear();
                this.listaFormaPagamento = nFormaPagamento.BuscarFormaPagamentoPorNome("");

                foreach (FormaPagamento pag in this.listaFormaPagamento)
                {
                    if (pag.formaPagamento != "CREDIARIO" && pag.formaPagamento != "PARCIAL")
                    {

                        if (pag.taxaFormaPagamento == 0)
                        {

                            this.cbFormaPagamento.Items.IndexOf(pag.codigoFormaPagamento);
                            this.cbFormaPagamento.Items.Add(pag.formaPagamento);

                        }
                        else
                        {
                            this.cbFormaPagamento.Items.IndexOf(pag.codigoFormaPagamento);
                            this.cbFormaPagamento.Items.Add(pag.formaPagamento + " - " + pag.taxaFormaPagamento.ToString("F"));
                        }
                    }
                }
                if (cbFormaPagamento.Text == "")
                {
                    lbTaxaJuros.Text = "0,00";
                    lbTaxa.Text = "R$ 0,00";
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void pbFormaPagamento_Click(object sender, EventArgs e)
        {
            FrmSelecionarFormaPagamento frmSelecionarPagamento = new FrmSelecionarFormaPagamento("");
            frmSelecionarPagamento.ShowDialog();
        }

        private void cbFormaPagamento_SelectedValueChanged(object sender, EventArgs e)
        {
            //-----------Sempre que clicar sera uma nova forma de pagamento escolhida
            objFormaPagamento = new FormaPagamento();

            if (listaFormaPagamento.Count > 0)
            {
                //Forma de Pagamento Selecionada na lista Referencia o objeto para uso na venda
                objFormaPagamento = listaFormaPagamento[cbFormaPagamento.SelectedIndex];
                //Exibe forma de pagamento selecionada
                lbTaxaJuros.Text = listaFormaPagamento[cbFormaPagamento.SelectedIndex].taxaFormaPagamento.ToString("F");
            }

            metodoCalculaTotais();
        }

        private void cbTaxa_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTaxa.Checked == false)
            {
                pbFormaPagamento.Image = Properties.Resources.TaxaRosa;
                metodoCalculaTotais();
            }
            if (cbTaxa.Checked == true)
            {
                pbFormaPagamento.Image = Properties.Resources.TaxaIAzul;

                if (cbFormaPagamento.Text != "")
                {
                    lbTaxaJuros.Text = listaFormaPagamento[cbFormaPagamento.SelectedIndex].taxaFormaPagamento.ToString("F");
                }
                metodoCalculaTotais();
            }
        }

        //------------------Pagamento
        private void tbValorPago_TextChanged(object sender, EventArgs e)
        {
            metodos.metodoMoedaTB(ref tbValorPago);
            metodoCalculaTotais();
        }

        private void btDesconto_Click(object sender, EventArgs e)
        {
            metodoCalculaTotais();
        }

        private void nudDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btDesconto.PerformClick();
                e.Handled = true;
            }
        }
        
        //Valor Recebido para calcular troco
        private void tbRecebimento_TextChanged(object sender, EventArgs e)
        {
            metodos.metodoMoedaTB(ref tbRecebimento);
            metodoCalculaTotais();
        }

        //----------------------Botões
        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair do Crediario Parcial?",
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

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            try{
                if (metodoValidaParcial() == true)
                {
                    DialogResult resposta;
                    //Criando Caixa de dialogo
                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Lançamento Parcial",
                    " Deseja realmente realizar a Parcial ?",
                    Properties.Resources.DialogVenda,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Confirmar", "Cancelar",
                    false);
                    //Verifica se o usuário realmente quer alterar os dados do cliente.
                    resposta = frmCaixa.ShowDialog();
                    if (resposta == DialogResult.Yes)
                    {
                        #region Montando Parcial
                        //Carregando Item
                        objItemCrediarioParcial = new ItemCrediarioParcial();
                        objItemCrediarioParcial.FormaPagamento = objFormaPagamento;
                        objItemCrediarioParcial.ItemCrediario = objItemCrediario;
                        objItemCrediarioParcial.Cliente = objItemCrediario.Crediario.Cliente;
                        objItemCrediarioParcial.ProdutoCor = objItemCrediario.ProdutoCor;
                        objItemCrediarioParcial.Tamanho = objItemCrediario.Tamanho;

                        //Valores
                        objItemCrediarioParcial.descontoParcial = Math.Round(valorDesconto, 2);
                        objItemCrediarioParcial.jurosParcial = Math.Round(valorJuros, 2);
                        objItemCrediarioParcial.valorParcialBruto = Math.Round(valorLiquidoParcial, 2);//Valor Realmente Recebido
                        objItemCrediarioParcial.valorPagoParcial = Convert.ToDouble(tbValorPago.Text);
                        
                        //Taxas para atualizar na venda 
                        if (cbTaxa.Checked == true)
                        {
                            objItemCrediarioParcial.ItemCrediario.Venda.descontoVenda = Math.Round(valorDesconto, 2);
                            objItemCrediarioParcial.ItemCrediario.Venda.jurosVenda = Math.Round(valorJuros, 2);
                            objItemCrediarioParcial.jurosParcial = Math.Round(valorJuros, 2);    
                       
                        }
                        else
                        {
                            objItemCrediarioParcial.ItemCrediario.Venda.descontoVenda = Math.Round(valorDesconto, 2);
                            objItemCrediarioParcial.ItemCrediario.Venda.jurosVenda = Math.Round(valorJuros, 2)*-1;
                            objItemCrediarioParcial.jurosParcial = Math.Round(valorJuros, 2)*-1;       
                       
                        }

                        objItemCrediarioParcial.valorParcialBruto.ToString();
                        

                       #endregion

                        #region Evento para realizar o cadastro da parcial
                        if (nParcial.CadastrarItemCrediarioParcial(objItemCrediarioParcial) == true)
                        {

                            //Criando Caixa de dialogo
                            frmCaixa = new FrmCaixaDialogo("Lançamento Realizado!",
                            "Parcial realizada com sucesso !\r\n" +
                            "Deseja Realizar Impressão do Comprovante?",
                            Properties.Resources.DialogOK,
                            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                            Color.White,
                            "Sim", "Não",
                            false);
                            resposta = frmCaixa.ShowDialog();
                        #endregion

                        #region Comprovante
                            //----------------------------------ImprimiComprovanteVenda
                            if (resposta == DialogResult.Yes)
                            {
                                //ImprimiComprovante()
                                this.DialogResult = DialogResult.Yes;
                                this.Close();
                            }
                            else
                            {
                                this.DialogResult = DialogResult.Yes;
                                this.Close();
                            }
                            #endregion
                        }
                        else
                        {
                            FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Erro Excluir Item Venda",
                            "Erro ao excluir tabela Item Venda Temp!",
                             Properties.Resources.DialogErro,
                             System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                             Color.White,
                             "Ok", "",
                             false);
                            frmCaixaCad.ShowDialog();
                        }

                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void FrmParcialCrediario_Load(object sender, EventArgs e)
        {
            metodoIniciaFormulario();
            metodoCalculaTotais();
        }

        private void pbCalculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\system32\\calc.exe");
        }

        private void FrmParcialCrediario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F10) == true)
            {
                btCadastrar.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {
                btSair.PerformClick();
            }
        }


    }
}
