using Apresentacao.Formulas;
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
    public partial class FrmAlterarExcluirParcialVenda : Form
    {
        //Venda 
        Venda objVenda = new Venda();
        Venda objVendaAtualizada = new Venda();
            
        //Parcial Venda
        ParcialVendaLista listaParcial = new ParcialVendaLista();
        ParcialVendaLista listaParcialExcluir = new ParcialVendaLista();//Itens para ser excluidos
        ParcialVendaLista listaParcialAtualizar = new ParcialVendaLista();//itens para ser atualizados ou cadastrados
        NegParcialVenda nParcial = new NegParcialVenda();

        //---------------Forma de Pagamento
        FormaPagamento objFormaPagamento = new FormaPagamento();
        ListaFormaPagamento listaFormaPagamento = new ListaFormaPagamento();//Usado no combobox
        NegFormaPagamento nFormaPagamento = new NegFormaPagamento();//Prencher formas de pagamento
        ListaFormaPagamento listaFormaPagamentoGride = new ListaFormaPagamento();//Usado no combobox
        
        //Objetos Gride
        ComboBox comboDataGride;
        TextBox caixaTextoGride;

        //-----------------Metodos
        Metodos metodos = new Metodos();

        //-----Variaveis para adicionar novos itens no gride
        Boolean validaADD = false;
        int indiceGride = 0;
        //Lista Parcial Cancelamento Sangria
        ParcialVendaListaSangria listaParcialSangria = new ParcialVendaListaSangria();
       
        //ItemVenda
        ItemVendaLista listaItem = new ItemVendaLista();
        NegItemVenda nItem = new NegItemVenda();

        //Variaveis
        double valorJuros = 0;
        double valorParcial = 0;
        double valorLiquidoEstorno = 0;
        double valorTotalDesconto = 0;
        double valorTotalJuros = 0;
        double totalAtualizadoParcial = 0;
        //Venda Nova
        double jurosNovaVenda = 0;
        double descontoVendaNova = 0;
        double vendaNovaLiquida = 0;
        //Estorno
        double valorItemCancelado = 0;
        double descontoItemCancelado = 0;
        double jurosItemCancelado = 0;
        double descontoEstornoAtualizado = 0;
        double jurosEstornoAtualizado = 0;

        public FrmAlterarExcluirParcialVenda(Venda venda, ItemVendaLista listaItemCancelado)
        {
            InitializeComponent();

            objVenda = venda;
            listaItem = listaItemCancelado;
        }

        //------------------------------------Métodos
        private void AtualizarDataGrid()
        {
            try
            {
                this.dgvFormaParcial.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

                if (this.listaParcial.Count > 0)
                {
                    this.dgvFormaParcial.Rows.Add(this.listaParcial.Count);
                }
                else
                {
                    return;
                }

                int indice = 0;

                foreach (ParcialVenda parcial in this.listaParcial)
                {

                    //this.formaPagamentoParcial.Items.Add(parcial.formaPagamentoVenda.formaPagamento);

                    this.dgvFormaParcial[0, indice].Value = parcial.CodigoParcial;
                    this.dgvFormaParcial[1, indice].Value = parcial.Venda.codigoVenda;

                    this.dgvFormaParcial[2, indice].Value = parcial.valorParcialVenda;

                    this.dgvFormaParcial[3, indice].Value = parcial.formaPagamentoVenda.formaPagamento;// + " - " + parcial.formaPagamentoVenda.taxaFormaPagamento.ToString("F");

                    this.dgvFormaParcial[4, indice].Value = parcial.formaPagamentoVenda.codigoFormaPagamento;

                    this.dgvFormaParcial[5, indice].Value = parcial.descontoParcialVenda;
                    this.dgvFormaParcial[6, indice].Value = parcial.jurosParcialVenda;
                    this.dgvFormaParcial[7, indice].Value = parcial.formaPagamentoVenda.taxaFormaPagamento;
                    this.dgvFormaParcial[8, indice].Value = indice;

                    indiceGride = indice;

                    indice++;
                }

                dgvFormaParcial.Update();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        //Retorna Lista de Parcias Atualizadas
        private void metodoAddParcialLista()
        {

            listaParcialAtualizar = new ParcialVendaLista();

            //Retira das parcias proporcionalmente os valores que restavam de juros ou descontos antigo
            int quantidadeParcelas = 0;

            //Não seleciona valores zerados
            foreach (DataGridViewRow row in dgvFormaParcial.Rows) { 
            
            if(Convert.ToDouble(row.Cells[2].Value) != 0){
            
              quantidadeParcelas ++;
            }
         }
            
            double jurosAntigo = objVenda.jurosVenda - jurosItemCancelado;
            double descontoAntigo = objVenda.descontoVenda - descontoItemCancelado;

            jurosAntigo = jurosAntigo / quantidadeParcelas;
            descontoAntigo = descontoItemCancelado / quantidadeParcelas;
  
            foreach (DataGridViewRow col in dgvFormaParcial.Rows)
            {
                ParcialVenda objParcial = new ParcialVenda();
                objParcial.Venda = new Venda();
                objParcial.formaPagamentoVenda = new FormaPagamento();

                //Chaves FK e UK
                objParcial.CodigoParcial = Convert.ToInt32(col.Cells[0].Value);
                objParcial.Venda.codigoVenda = objVenda.codigoVenda;     
                objParcial.formaPagamentoVenda.formaPagamento = (col.Cells[3].Value).ToString();
                objParcial.formaPagamentoVenda.codigoFormaPagamento = Convert.ToInt32(col.Cells[4].Value);
                objParcial.descontoParcialVenda = Convert.ToDouble(col.Cells[5].Value);
                objParcial.jurosParcialVenda = Convert.ToDouble(col.Cells[6].Value);
                objParcial.acrescimoTaxa = (jurosEstornoAtualizado/quantidadeParcelas);
                objParcial.acrescimoDesconto = (descontoEstornoAtualizado / quantidadeParcelas);

                //Deixa somento valor do item na Parcial
                //Juros Antigo já foi descontado no caso o juro e descontado novamento no caso da geração de uma nova venda
                if (cbTaxaEstorno.Checked == true)
                {
                    objParcial.valorParcialVenda = Math.Round(Convert.ToDouble(col.Cells[2].Value) - jurosAntigo + descontoAntigo, 2);
                }
                else
                {
                    //Deixa somente o valor do item na parcial
                    objParcial.valorParcialVenda = Math.Round(Convert.ToDouble(col.Cells[2].Value) - (objVenda.jurosVenda / quantidadeParcelas), 2);
                    objParcial.jurosParcialVenda = objParcial.jurosParcialVenda * -1;//Taxa e atualiza mais fica com o valor negativo
                }

                listaParcialAtualizar.Add(objParcial);
            }
        }

        //Retorna Venda Atualizada com novos valores
        private void metodoGerarVendaAtualizada()
        {      
            if(listaParcialAtualizar.Count > 0){
            objVendaAtualizada = new Venda();

            objVendaAtualizada.codigoVenda = objVenda.codigoVenda;
            objVendaAtualizada.totalVenda = listaParcialAtualizar.Sum(g => g.valorParcialVenda);
            objVendaAtualizada.descontoVenda = listaParcialAtualizar.Sum(d => d.descontoParcialVenda);
            objVendaAtualizada.jurosVenda = listaParcialAtualizar.Sum(j => j.jurosParcialVenda);
            }
        }

        //Verifica se os campos estão vazios
        public Boolean metodoValidaParcialVenda()
        {

            //verifica se campos vazios
            foreach (DataGridViewRow col in dgvFormaParcial.Rows)
            {
                if (col.Cells[3].Value == null) { return false; }

            }

            return true;


        }

        private Boolean metodoValidaAtualizacao(double valorTotalParciais, double valorTotalEstorno)
        {
            if (valorTotalParciais == valorTotalEstorno)
            {
                return true;
            }
            else
            { return false; }
        
        }

        //Valida Comparando os valores da Venda e valores adicionados pelo usuário
        private void metodoValidaParcial(double valorTotalParciais, double valorTotalEstorno)
        {
            double valorRest = Math.Round(valorTotalParciais - valorTotalEstorno, 2);
            //PegaValoresTotai + Valor nova Parcial Se > que Total da Venda 


            if (valorTotalParciais == valorTotalEstorno || String.Format("{0:C2}", valorTotalParciais) == lbTotalBrutoVenda.Text)
            {

                btAdicionar.Enabled = false;
                pbOk.Image = Properties.Resources.DialogOK;

                lbValorTotalEstorno.ForeColor = Color.Turquoise;
                lbJurosEstorno.ForeColor = Color.Turquoise;
                lbDescontoEstorno.ForeColor = Color.Turquoise;
                lbEstornoLiquido.ForeColor = Color.Turquoise;
                lbTotalBrutoEstorno.ForeColor = Color.Turquoise;
                lbTotalEstorno.ForeColor = Color.Turquoise;
                panelCalculoVenda.BackColor = Color.Turquoise;

                panelEstorno.BackColor = Color.DeepSkyBlue;

                //Acréscimos
                descontoEstornoAtualizado = 0;
                jurosEstornoAtualizado = 0;

                //Valor estorno atualizado
                jurosEstornoAtualizado = Math.Round(valorTotalJuros - objVenda.jurosVenda, 2);//Juros A+ ou A- deve ser adicionado ou removido estorno
                //Valor desconto Atualizado
                descontoEstornoAtualizado = (valorTotalDesconto / objVenda.quantidadeVenda);
                descontoEstornoAtualizado = Math.Round(valorTotalDesconto - objVenda.descontoVenda, 2);//Juros A+ ou A- deve ser adicionado ou removido estorno

                lbValorAcrescimoTaxa.Text = "% " + String.Format("{0:C2}", jurosEstornoAtualizado);
                lbValorAcrescimoDesconto.Text = "- " + String.Format("{0:C2}", descontoEstornoAtualizado);
                lbEstornoAcrescimos.Text = "Taxa Acréscimos: " + String.Format("{0:C2}", jurosEstornoAtualizado);
                lbDescontoAcrescimos.Text = "Desconto Acréscimos: " + String.Format("{0:C2}", descontoEstornoAtualizado);

            }

            else if ((valorTotalParciais) > valorTotalEstorno )
            {
                //Venda Excede o valor total
                btAdicionar.Enabled = true;
                pbOk.Image = Properties.Resources.DialogErro;

                lbValorTotalEstorno.ForeColor = Color.Red;
                lbJurosEstorno.ForeColor = Color.Red;
                lbDescontoEstorno.ForeColor = Color.Red;
                lbEstornoLiquido.ForeColor = Color.Red;
                lbTotalBrutoEstorno.ForeColor = Color.Red;
                lbTotalEstorno.ForeColor = Color.Red;
                panelCalculoVenda.BackColor = Color.Red;
                panelEstorno.BackColor = Color.Red;

                //-------------Acrescimos
                lbValorAcrescimoTaxa.Text = "% " + String.Format("{0:C2}", 0);
                lbValorAcrescimoDesconto.Text = "- " + String.Format("{0:C2}", 0);
                lbEstornoAcrescimos.Text = "Taxa Acréscimos: " + String.Format("{0:C2}", 0);
                lbDescontoAcrescimos.Text = "Desconto Acréscimos: " + String.Format("{0:C2}", 0);
                lbVendaValorFinal.Text = String.Format("{0:C2}", 0);

            }
            else
            {
                btAdicionar.Enabled = true;
                pbOk.Image = Properties.Resources.DialogErro;

                lbValorTotalEstorno.ForeColor = Color.Red;
                lbJurosEstorno.ForeColor = Color.Red;
                lbDescontoEstorno.ForeColor = Color.Red;
                lbEstornoLiquido.ForeColor = Color.Red;
                lbTotalBrutoEstorno.ForeColor = Color.Red;
                lbTotalEstorno.ForeColor = Color.Red;
                panelCalculoVenda.BackColor = Color.Red;

                panelEstorno.BackColor = Color.Red;

                //-------------Acrescimos
                lbValorAcrescimoTaxa.Text = "% " + String.Format("{0:C2}", 0);
                lbValorAcrescimoDesconto.Text = "- " + String.Format("{0:C2}", 0);
                lbEstornoAcrescimos.Text = "Taxa Acréscimos: " + String.Format("{0:C2}", 0);
                lbDescontoAcrescimos.Text = "Desconto Acréscimos: " + String.Format("{0:C2}", 0);
                lbVendaValorFinal.Text = String.Format("{0:C2}", 0);
            }
        }

        //Calcuala Desconto individual
        private void metodoCalculaDesconto()
        {
            double valorDesconto = 0;

            double Porcentagemdesconto = (Convert.ToDouble(nudDesconto.Value) / 100);
            valorDesconto = Porcentagemdesconto * Convert.ToDouble(dgvFormaParcial.CurrentRow.Cells[2].Value);

            //----------Acrescenta Desconto no Gride
            dgvFormaParcial.CurrentRow.Cells[5].Value = valorDesconto;
        }

        private void metodoCalculaTotais() {
            //Estorno
            jurosItemCancelado = 0;
            descontoItemCancelado = 0;
            valorItemCancelado = 0;
            //Totais
            valorParcial = 0;
            valorTotalDesconto = 0;
            valorTotalJuros = 0;
            //-----------------------------------------Calcula Totais do Datagride
            //faz a soma dos totais dos valores do gride

            foreach (DataGridViewRow col in dgvFormaParcial.Rows)
            {
                //Valor da Parcial
                valorParcial = valorParcial + Convert.ToDouble(col.Cells[2].Value);
                valorTotalDesconto = valorTotalDesconto + Convert.ToDouble(col.Cells[5].Value);
                valorTotalJuros = valorTotalJuros + Convert.ToDouble(col.Cells[6].Value);

            }

            //-----------------------------------------ItemCanceladoVenda
            foreach (ItemVenda item in listaItem)
            {
                valorItemCancelado = valorItemCancelado + (item.precoVenda * item.quantidadeVenda);
                descontoItemCancelado = descontoItemCancelado + item.descontoItem;
                jurosItemCancelado = jurosItemCancelado + item.JurosItem;
            }
            if (cbTaxaEstorno.Checked == true)//Adiciona Taxa Cartão
            {
                valorLiquidoEstorno = (valorItemCancelado - descontoItemCancelado) + jurosItemCancelado;
                lbEstornoLiquido.Text = "- " + String.Format("{0:C2}", valorLiquidoEstorno);
                lbEstorno.Text = String.Format("{0:C2}", valorLiquidoEstorno);
            }
            else
            {//Item se taxa adicionada
                valorLiquidoEstorno = (valorItemCancelado - descontoItemCancelado);
                lbEstornoLiquido.Text = "- " + String.Format("{0:C2}", valorLiquidoEstorno);
                lbEstorno.Text = String.Format("{0:C2}", valorLiquidoEstorno);
            }

            lbTotalBrutoEstorno.Text = String.Format("{0:C2}", valorLiquidoEstorno);

            //--------------------------------------------Paineis Estorno
            //-----------Estorno
            lbValorTotalEstorno.Text = "+ " + String.Format("{0:C2}", valorItemCancelado);
            lbJurosEstorno.Text = "%" + String.Format("{0:C2}", jurosItemCancelado);
            lbDescontoEstorno.Text = "- " + String.Format("{0:C2}", descontoItemCancelado);

                //-----------Venda
                lbValorTotalVenda.Text = "+ " + String.Format("{0:C2}", (objVenda.liquidoVenda));
                lbJurosVenda.Text = "%" + String.Format("{0:C2}", objVenda.jurosVenda);
                lbDescontoVenda.Text = "- " + String.Format("{0:C2}", objVenda.descontoVenda);
                lbVendaLiquido.Text = "+ " + String.Format("{0:C2}", objVenda.liquidoVenda + objVenda.jurosVenda - objVenda.descontoVenda);


                totalAtualizadoParcial =  (objVenda.liquidoVenda - valorLiquidoEstorno + objVenda.jurosVenda - objVenda.descontoVenda);
                lbTotalBrutoVenda.Text = String.Format("{0:C2}", objVenda.liquidoVenda - valorLiquidoEstorno + objVenda.jurosVenda - objVenda.descontoVenda);
                lbVenda.Text = String.Format("{0:C2}", objVenda.liquidoVenda - valorLiquidoEstorno + objVenda.jurosVenda - objVenda.descontoVenda);

                //Paineis ParcialAtualBruto, ParcialAtualLiquido,Desconto,Taxa
                lbParcialLiquido.Text = String.Format("{0:C2}", valorParcial);
                lbTotalParcial.Text = String.Format("{0:C2}", (valorParcial - valorTotalDesconto) + valorTotalJuros);
                lbDesconto.Text = String.Format("{0:C2}", valorTotalDesconto);
                lbTaxa.Text = String.Format("{0:C2}", valorTotalJuros);

                //Valida Se o valor Estorno Foi Atualizado
                metodoValidaParcial(valorParcial, Math.Round(objVenda.liquidoVenda - valorLiquidoEstorno + objVenda.jurosVenda - objVenda.descontoVenda, 2));

                //--------Acrescimos
                if (cbTaxaEstorno.Checked == true)//Adiciona Taxa Cartão
                {
                    lbVendaAtualizada.Text = String.Format("{0:C2}", (objVenda.liquidoVenda - valorLiquidoEstorno + objVenda.jurosVenda - objVenda.descontoVenda) + jurosEstornoAtualizado - descontoEstornoAtualizado);
                    lbEstornoAtualizado.Text = String.Format("{0:C2}", valorLiquidoEstorno - jurosEstornoAtualizado + descontoEstornoAtualizado);
                }
                else
                {
                    lbVendaAtualizada.Text = String.Format("{0:C2}", (objVenda.liquidoVenda - valorLiquidoEstorno + objVenda.jurosVenda - objVenda.descontoVenda) - descontoEstornoAtualizado);
                    lbEstornoAtualizado.Text = String.Format("{0:C2}", (valorLiquidoEstorno + descontoEstornoAtualizado));
                }

                //Valores novos da Venda
                metodoCalculaVendaNova();         
  }

        public void metodoPreencheCombobox()
        {

            this.formaPagamentoParcial.Items.Clear();
            this.listaFormaPagamento = nFormaPagamento.BuscarFormaPagamentoPorNome("");

            foreach (FormaPagamento pag in this.listaFormaPagamento)
            {
                if (pag.formaPagamento != "CREDIARIO" && pag.formaPagamento != "PARCIAL")
                {
                    {
                        this.formaPagamentoParcial.Items.IndexOf(pag.codigoFormaPagamento);
                        //this.formaPagamentoParcial.Items.Add(pag.formaPagamento + " - " + pag.taxaFormaPagamento.ToString("F"));
                        this.formaPagamentoParcial.Items.Add(pag.formaPagamento);
                    }
                }
            }
        }

        private void metodoIniciaFormulario() {

            if(objVenda.jurosVenda < 0){objVenda.jurosVenda = objVenda.jurosVenda * -1;}
            metodoPreencheCombobox();
            listaParcial = nParcial.BuscarParcialVendaPorCodigoDaVenda(objVenda.codigoVenda);
            AtualizarDataGrid();
            metodoCalculaTotais();
        }

        private void metodoExcluiParcialZerada() {
            //Valor for zerado Vai direto para cancelar a sangria e itens da venda
            if (totalAtualizadoParcial < 1)//Se total a cancelar for menor que 1
            {

                DialogResult resposta;
                //Criando Caixa de dialogo
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
                " Parcial esta 0,00 deseja excluir a Parcial ?",
                Properties.Resources.DialogExcluir,
                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                Color.White,
                "Sim", "Não",
                false);

                resposta = frmCaixa.ShowDialog();
                if (resposta == DialogResult.Yes)
                {
                    metodoAddParcialLista();

                    //Zera valores do gride para cancelamento
                    foreach (ParcialVenda parcial in listaParcialAtualizar)
                    {

                        parcial.valorParcialVenda = 0;

                    }

                    //Valida se há necessidade de atualizar as sangrias
                    if (metodoValidaCancelamentoSangria() == true)
                    {

                        if (nParcial.ExcluirParcialPorVenda(objVenda) == true)//Exclui Todas as Parciais da Venda
                        {
                            if (nItem.ExcluirItemVenda(listaItem) == true)
                            {
                                //----------------------------Realiza Impressão
                                DialogResult respostaImpressao;
                                //Criando Caixa de dialogo
                                FrmCaixaDialogo frmCaixaImpressao = new FrmCaixaDialogo("Cancelamento Realizado!",
                                "Cancelamento realizado com sucesso !\r\n" +
                                "Deseja Realizar Impressão do Comprovante?",
                                Properties.Resources.DialogOK,
                                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                Color.White,
                                "Sim", "Não",
                                false);
                                respostaImpressao = frmCaixaImpressao.ShowDialog();
                                //----------------------------------ImprimiComprovanteVenda
                                if (respostaImpressao == DialogResult.Yes)
                                {
                                    //Retornando que exclusão foi realizada com sucesso
                                    //this.DialogResult = DialogResult.Yes; //Após a impressão fecha o formulário
                                    //ImprimiComprovante()
                                    //Tem que Ter CodigoParcial
                                    //Valor Venda
                                    //Itens
                                    //Imprimir Total Venda 
                                    //Com Acréscimos e sem acréscimos
                                    //Venda antes e Depois dos Acréscimos
                                    DialogResult = DialogResult.Yes;
                                }
                                else { DialogResult = DialogResult.Yes; }//Realiza Atualização}
                            }//Exclusão ItemVenda
                            else
                            {
                                //Erro ao atualizar valores das parciais
                                FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Aviso Exclusão Itens Parcial",
                                "Erro ao cancelar Itens da Parcial!",
                                Properties.Resources.DialogErro,
                                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                Color.White,
                                "Ok", "",
                                false);
                                frmCaixaCad.ShowDialog();
                                DialogResult = DialogResult.Cancel;
                            }
                        }//Exclusão Parcial Venda
                        else
                        {

                            //Erro ao atualizar valores das parciais
                            FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Aviso Exclusão Parcial",
                            "Erro ao cancelar Parcial da Venda!",
                            Properties.Resources.DialogErro,
                            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                            Color.White,
                            "Ok", "",
                            false);
                            frmCaixaCad.ShowDialog();
                            DialogResult = DialogResult.Cancel;
                        }
                    }//Erro ao atualizar Parcial
                    else
                    {
                        //Erro ao atualizar valores das parciais
                        FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Aviso Parcial Sangria",
                        "Atualize os dados da Sangria vincualda com a parcial!",
                        Properties.Resources.DialogWarning,
                        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                        Color.White,
                        "Ok", "",
                        false);
                        frmCaixaCad.ShowDialog();
                        DialogResult = DialogResult.Cancel;
                    }
                }
                else { DialogResult = DialogResult.Cancel; }
            }
   
        }

        //Valores que ficarão registrados na venda
        private void metodoCalculaVendaNova() {

            //-------------Valor que vai ficar no item e na venda
            jurosNovaVenda = 0;
            descontoVendaNova = 0;
            vendaNovaLiquida = 0;

            foreach (ItemVenda item in listaItem) {

                vendaNovaLiquida = vendaNovaLiquida + (item.precoVenda*item.quantidadeVenda);
            
            }
            //faz a soma dos totais dos valores do gride
            foreach (DataGridViewRow col in dgvFormaParcial.Rows)
            {
                descontoVendaNova = descontoVendaNova +Convert.ToDouble(col.Cells[5].Value);
                jurosNovaVenda = jurosNovaVenda +Convert.ToDouble(col.Cells[6].Value);
            }
            
            vendaNovaLiquida = Math.Round(objVenda.liquidoVenda - vendaNovaLiquida,2);//90


            if(cbTaxaEstorno.Checked == true){
                lbVendaValorFinal.Text = String.Format("{0:C2}", (vendaNovaLiquida - descontoVendaNova + jurosNovaVenda));  
            }
            else{
                jurosNovaVenda = jurosNovaVenda * -1;//Deixa juros da venda negatico no caso dele nao ser computado
                lbVendaValorFinal.Text = String.Format("{0:C2}", (vendaNovaLiquida - descontoVendaNova + jurosNovaVenda));
            }
        }
        
        //Metodo Chama formulario para atualizar Sangria antes do cancelamento
        private Boolean metodoValidaCancelamentoSangria()
        {
            NegSangria nSangria = new NegSangria();
            if (nSangria.BuscarCancelamentoSangriaPorData(objVenda.dataVenda) == true)
            {
                listaParcialSangria = new ParcialVendaListaSangria();
                //Passa os valores da lista para atualizar
                if (listaParcialAtualizar.Count > 0)
                {
                    foreach (ParcialVenda item in listaParcialAtualizar)
                        listaParcialSangria.Add(item);
                }
                //Passa os valores que foram excluidos para a lista 
                if (listaParcialExcluir.Count > 0)
                {

                    foreach (ParcialVenda item in listaParcialExcluir)
                    {
                        //Item Excluido vai tem que ser atualizada a sangria como 0
                        item.valorParcialVenda = 0;
                        listaParcialSangria.Add(item);
                    }
                }

                //Chama o formulário de cancelamento
                if (listaParcialSangria.Count > 0)
                {
                    foreach (ParcialVenda item in listaParcialSangria)
                    {

                        Sangria sangria = new Sangria();
                        sangria = nSangria.BuscarCancelamentoSangria(objVenda.dataVenda, item.formaPagamentoVenda.codigoFormaPagamento);
                        sangria.dataSangria = objVenda.dataVenda;

                        if (sangria != null)
                        {
                            SangriaLista sangriaLista = new SangriaLista();
                            sangriaLista = nSangria.BuscarSangriaParaCancelamento(sangria.dataSangria);//Resto sangria
                            double valorSangria = (from s in sangriaLista where (s.pagamentoSangria.codigoFormaPagamento == item.formaPagamentoVenda.codigoFormaPagamento) select (s.valorSangria)).Sum();

                            //Valor da Sangria for maior que valor da Parcial da venda 
                            if ((valorSangria) >= item.valorParcialVenda)
                            {//Verifica se há necessidade da atualização da sangria

                                DialogResult resultadoAtualizacaoSangria;
                                FrmCancelamentoSangria frmSangria = new FrmCancelamentoSangria(sangria, null, listaParcialSangria, listaItem, null, null);
                                resultadoAtualizacaoSangria = frmSangria.ShowDialog();

                                if (resultadoAtualizacaoSangria == DialogResult.Yes)
                                {

                                    return true;

                                }
                                else
                                {
                                    return false;

                                }
                            }
                        }

                    }//Foreach

                    return true;//Não há necessidade de atualizar a sangria
                }
                else
                {
                    return true;
                }
            }
            else { return true; }//não houver sangria retorna verdadeiro para continuar cancelamento
            }

        private void FrmAlterarExcluirParcialVenda_Load(object sender, EventArgs e)
        {
            if (objVenda.jurosVenda > 0) {

                cbTaxaEstorno.Checked = true;
            }

            metodoIniciaFormulario();

            metodoExcluiParcialZerada();

        }

        private void pbCalculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\system32\\calc.exe");
        }

        //---------------------------Data Grdide Combobox
        //Evento DroDown Combo
        private void comboDataGride__DropDown(object sender, EventArgs e)
        {
           metodoPreencheCombobox();
        }

        //Pega o valor utilizado no data gride
        private void comboDataGride_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Pegando valor do index do combobox
            int indiceLista = (sender as ComboBox).SelectedIndex;

            if (indiceLista >= 0)
            {
                //Instanciando objeto forma de pagamento
                FormaPagamento formaPagamento = new FormaPagamento();
                formaPagamento = listaFormaPagamento[indiceLista];


                valorJuros = formaPagamento.taxaFormaPagamento;
                dgvFormaParcial.CurrentRow.Cells[4].Value = formaPagamento.codigoFormaPagamento;
                dgvFormaParcial.CurrentRow.Cells[7].Value = formaPagamento.taxaFormaPagamento;
                dgvFormaParcial.CurrentRow.Cells[6].Value = (formaPagamento.taxaFormaPagamento / 100) * Convert.ToDouble(dgvFormaParcial.CurrentRow.Cells[2].Value);
          
            }
            metodoCalculaTotais();
        }

        //-----------------------------Data Gride Caixa de Texto
        //Evento TextoChanged do Gride
        private void caixaTextoGride_TextChanged(object sender, EventArgs e)
        {
            metodos.metodoMoedaTB(ref caixaTextoGride);
        }

        private void caixaTextoGride_Leave(object sender, EventArgs e)
        {
            double valorRestante = 0;
            metodoCalculaTotais();
            //Pega valor da caixa de testo para atualizar juros
            double valorCaixaTexto = Convert.ToDouble(caixaTextoGride.Text);
            dgvFormaParcial.CurrentRow.Cells[6].Value = valorCaixaTexto * (Convert.ToDouble(dgvFormaParcial.CurrentRow.Cells[7].Value)/100);//Atualiza Taxa
            dgvFormaParcial.CurrentRow.Cells[5].Value = 0;//ZeraDesconto

            //Parcial igual a 0 e removida
            if (Convert.ToDouble(dgvFormaParcial.CurrentRow.Cells[2].Value) == 0)//Erro referencia objeto verificar
            {
                FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Parcial com valor 0",
               "Parcial será excluido por estar 0,00!",
                Properties.Resources.DialogExcluir,
                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                Color.White,
                "Ok", "",
                false);
                frmCaixaCad.ShowDialog();


            }

                if (Math.Round((objVenda.totalVenda - valorLiquidoEstorno), 2) < Math.Round(valorParcial, 2))
                {
                    valorRestante = Math.Round(valorParcial - (objVenda.totalVenda - valorLiquidoEstorno) - valorCaixaTexto, 2);

                    FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Atualize valor Venda",
                    "Valor restante parcial é: \n" + valorRestante.ToString(),
                    Properties.Resources.DialogParcial,
                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                    Color.White,
                    "Ok", "",
                    false);
                    frmCaixaCad.ShowDialog();

                }

                metodoCalculaTotais();
            
        }

        //-----------------------------Botões
        private void btAdicionar_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvFormaParcial.RowCount == 0)
                {

                    this.dgvFormaParcial.Rows.Add(1);
                    dgvFormaParcial.CurrentRow.Cells[7].Value = indiceGride;
                    DataGridViewRow row = dgvFormaParcial.Rows[0];
                    row.Height = 30;

                    dgvFormaParcial.CurrentRow.Cells[2].Value = "0,00";
                    dgvFormaParcial.CurrentRow.Cells[5].Value = "0,00";
                    dgvFormaParcial.CurrentRow.Cells[6].Value = "0,00";

                }
                else
                {

                    metodoCalculaTotais();

                    //Se o valor for maior possivel add outra parcial
                    if ( Math.Round((objVenda.totalVenda - valorLiquidoEstorno),2) >  Math.Round(valorParcial,2))
                    {
                        //percorre todas as linhas do gride
                        foreach (DataGridViewRow rowChek in dgvFormaParcial.Rows)
                        {
                            if (rowChek.Cells[2].Value != null && rowChek.Cells[3].Value != null)
                            {
                                validaADD = true;
                            }
                            else
                            {

                                validaADD = false;
                                break;
                            }
                        }
                        if (validaADD == true)
                        {
                            dgvFormaParcial.Rows.Add(1);
                            indiceGride = dgvFormaParcial.RowCount - 1;
                            dgvFormaParcial.Rows[indiceGride].Cells[3].ReadOnly = true;
                            dgvFormaParcial.CurrentCell = dgvFormaParcial.Rows[indiceGride].Cells[2];
                            DataGridViewRow row = dgvFormaParcial.Rows[indiceGride];
                            row.Height = 30;
                            nudDesconto.Value = 0;
                            dgvFormaParcial.CurrentRow.Cells[2].Value = "0,00";
                            dgvFormaParcial.CurrentRow.Cells[5].Value = "0,00";
                            dgvFormaParcial.CurrentRow.Cells[6].Value = "0,00";
                        }
                    }
                    else if (Math.Round((objVenda.totalVenda - valorLiquidoEstorno), 2) == Math.Round(valorParcial, 2))
                    {
                        FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Valor Venda Atendido",
                        "Valor total da venda Atendido: \n" + lbTotalBrutoVenda.Text,
                        Properties.Resources.DialogParcial,
                        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                        Color.White,
                        "Ok", "",
                        false);
                        frmCaixaCad.ShowDialog();
                    }
                    else {
                        FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Atualize valor Venda",
                        "Valor Parcial maior que Venda: \n" + Math.Round(valorParcial - (objVenda.totalVenda - valorLiquidoEstorno),2).ToString(),
                        Properties.Resources.DialogParcial,
                        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                        Color.White,
                        "Ok", "",
                        false);
                        frmCaixaCad.ShowDialog();
              
                  
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {             
            var indice = dgvFormaParcial.CurrentRow.Index;

            if (indice >= 0)
            {
                foreach (ParcialVenda parcial in listaParcial) {

                    if (parcial.CodigoParcial == Convert.ToInt32(dgvFormaParcial.Rows[indice].Cells[0].Value)) {

                        listaParcialExcluir.Add(parcial);
                        listaParcial.Remove(parcial);
                        break;
                    }
                
                }

                dgvFormaParcial.Rows.RemoveAt(indice);
            }

            if (dgvFormaParcial.RowCount <= 0)
            {
                listaParcialExcluir.Clear();
                metodoIniciaFormulario();
            }

            metodoCalculaTotais();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            try{
                //Adiciona Parciais do Gride na Lista de Parciais a serem atualizadas
                metodoAddParcialLista();//Parciais atualizadas             

               if (metodoValidaParcialVenda() == true)
               {
                        if (metodoValidaAtualizacao(valorParcial, Math.Round((objVenda.liquidoVenda + objVenda.jurosVenda - objVenda.descontoVenda) - valorLiquidoEstorno, 2)) == true)
                        {
                            DialogResult respostaAtualiza;
                            //Criando Caixa de dialogo
                            FrmCaixaDialogo frmCaixaAtualiza = new FrmCaixaDialogo("Atualizar Parciais!",
                           "Deseja realizar a atualização da parciais ?\r\n" +
                           "Acréscimos Estorno:" + lbEstornoAtualizado.Text + " Venda: " + lbVendaAtualizada.Text,
                            Properties.Resources.DialogParcial,
                            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                            Color.White,
                            "Sim", "Não",
                            false);
                            respostaAtualiza = frmCaixaAtualiza.ShowDialog();

                            if (respostaAtualiza == DialogResult.Yes)
                            {
                                //Valida se há necessidade de atualizar as sangrias
                                if (metodoValidaCancelamentoSangria() == true)
                                {
                                    //--------------------Exclui Parciais deletadas
                                    if (nParcial.ExcluirListaParcial(listaParcialExcluir) == true)
                                    {
                                        //---------------------Exclui Lista de Iems Cancelados
                                        if (nItem.ExcluirItemVendaCancela(listaItem) == true)
                                        {

                                            if (nParcial.AltualizarParcialLista(listaParcialAtualizar) == true)
                                            {
                                                //-----------------------------Atualiza Novos Valores na Venda e Atualiza Taxas e Descontos nos Items da Venda
                                                //Adiciona os valores a serem atualizados
                                                metodoGerarVendaAtualizada();
                                                if (nParcial.AtualizarParcialValoresItemEVenda(vendaNovaLiquida, descontoVendaNova, jurosNovaVenda, objVendaAtualizada) == true)
                                                {//Aqui tem que atualizar a venda se chheked == true valor negativo se não valor positivo
                                                    //----------------------------Realiza Impressão
                                                    DialogResult resposta;
                                                    //Criando Caixa de dialogo
                                                    FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Alteração Realizada!",
                                                    "Alteração realizada com sucesso !\r\n" +
                                                    "Deseja Realizar Impressão do Comprovante?",
                                                    Properties.Resources.DialogOK,
                                                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                                    Color.White,
                                                    "Sim", "Não",
                                                    false);
                                                    resposta = frmCaixa.ShowDialog();
                                                    //----------------------------------ImprimiComprovanteVenda
                                                    if (resposta == DialogResult.Yes)
                                                    {
                                                        //Retornando que exclusão foi realizada com sucesso
                                                        this.DialogResult = DialogResult.Yes;
                                                        this.Close();
                                                        //ImprimiComprovante()
                                                        //Tem que Ter CodigoParcial
                                                        //Valor Venda
                                                        //Itens
                                                        //Imprimir Total Venda 
                                                        //Com Acréscimos e sem acréscimos
                                                        //Venda antes e Depois dos Acréscimos
                                                    }
                                                    else
                                                    {
                                                        //metodoLimpaCampos()
                                                        this.DialogResult = DialogResult.Yes;
                                                        this.Close();
                                                    }
                                                }
                                                else
                                                {
                                                    //Erro Atualizar Valores da Venda e Item
                                                    FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Erro ao Atualizar Venda",
                                                    "Não foi possível atualizar a Venda!",
                                                    Properties.Resources.DialogErro,
                                                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                                    Color.White,
                                                    "Ok", "",
                                                    false);
                                                    frmCaixaCad.ShowDialog();
                                                }
                                            }
                                            else
                                            {
                                                //Erro Excluir
                                                FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Erro ao Atualizar Parcial",
                                                "Não foi possível atualizar as Parcias!",
                                                Properties.Resources.DialogErro,
                                                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                                Color.White,
                                                "Ok", "",
                                                false);
                                                frmCaixaCad.ShowDialog();

                                            }

                                        }
                                        else
                                        {

                                            //Erro Excluir
                                            FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Erro ao Excluir Item",
                                            "Não foi possível realizar exclusão dos items!",
                                            Properties.Resources.DialogErro,
                                            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                            Color.White,
                                            "Ok", "",
                                            false);
                                            frmCaixaCad.ShowDialog();

                                        }

                                    }
                                    else
                                    {
                                        //Erro Excluir
                                        FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Erro ao Excluir Parcial",
                                        "Não foi possível realizar exclusão das parciais!",
                                        Properties.Resources.DialogErro,
                                        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                        Color.White,
                                        "Ok", "",
                                        false);
                                        frmCaixaCad.ShowDialog();
                                    }
                                }//Caso na for feita a atualização das sangria
                                else {
                                    //Erro ao atualizar valores das parciais
                                    FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Aviso Parcial Sangria",
                                    "Atualize os dados da Sangria vincualda com a parcial!",
                                    Properties.Resources.DialogWarning,
                                    System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                    Color.White,
                                    "Ok", "",
                                    false);
                                    frmCaixaCad.ShowDialog();

                                }
                            }
                            else { return; }//Não queire atualizar parcial
                       
                   }//Validação Atualização
                        else
                        {
                            //Erro ao atualizar valores das parciais
                            FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Aviso Parcial Venda",
                            "Valor da parcial da venda deve ser atualizado !",
                            Properties.Resources.DialogWarning,
                            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                            Color.White,
                            "Ok", "",
                            false);
                            frmCaixaCad.ShowDialog();

                        }
                }//Validação foram selecionadas as formas de pagamento
                   else
                    {
                        //Erro ao atualizar valores das parciais
                        FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Preenchimento Parcial Venda",
                        "Informe corretamento as parciais da venda!",
                        Properties.Resources.DialogErro,
                        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                        Color.White,
                        "Ok", "",
                        false);
                        frmCaixaCad.ShowDialog();

                    }
                                                                       
           }catch(Exception ex){

               MessageBox.Show(ex.Message,
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
        }

        private void btDesconto_Click(object sender, EventArgs e)
        {
            metodoCalculaDesconto();
            metodoCalculaTotais();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair da Parcial ?",
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

        //-----------------------------DataGride
        private void dgvFormaParcial_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //FormaPagamento
            if (dgvFormaParcial.Columns[e.ColumnIndex].Name == "formaPagamentoParcial")
            {

                dgvFormaParcial.Rows[e.RowIndex].ErrorText = "";

                if (dgvFormaParcial.Rows[e.RowIndex].IsNewRow) { return; }
                if (e.FormattedValue.ToString() == "")
                {
                    dgvFormaParcial.Rows[e.RowIndex].ErrorText = "Informe a Forma de Pagamento Corretamente";
                }

            }
            //Valor da Parcial
            if (dgvFormaParcial.Columns[e.ColumnIndex].Name == "valorParcialVenda")
            {
                dgvFormaParcial.Rows[e.RowIndex].ErrorText = "";
                double newDouble;

                if (dgvFormaParcial.Rows[e.RowIndex].IsNewRow) { return; }
                if (!double.TryParse(e.FormattedValue.ToString(),
                    out newDouble) || newDouble <= 0)
                {
                    dgvFormaParcial.Rows[e.RowIndex].ErrorText = "Informe o valor da Parcial";
                    dgvFormaParcial.CurrentRow.Cells[3].ReadOnly = true;
                }
                else
                {
                    //habilita escolher forma de pagamento
                    dgvFormaParcial.CurrentRow.Cells[3].ReadOnly = false;

                }

            }
        }

        private void dgvFormaParcial_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                comboDataGride = e.Control as ComboBox;
                if (comboDataGride != null)
                {
                    comboDataGride.DropDown -= new EventHandler(comboDataGride__DropDown);
                    comboDataGride.DropDown += comboDataGride__DropDown;

                    comboDataGride.SelectedIndexChanged -= new EventHandler(comboDataGride_SelectedIndexChanged);
                    comboDataGride.SelectedIndexChanged += comboDataGride_SelectedIndexChanged;
                }

                //-----------Adiciona o formato apenas na caixa de texto 
                if (dgvFormaParcial.CurrentCell.ColumnIndex == 2)
                {
                    //if (caixaTextoGride != null)
                    {
                        caixaTextoGride = e.Control as TextBox;
                        caixaTextoGride.TextChanged -= new EventHandler(caixaTextoGride_TextChanged);
                        caixaTextoGride.TextChanged += caixaTextoGride_TextChanged;

                        caixaTextoGride.Leave -= new EventHandler(caixaTextoGride_Leave);
                        caixaTextoGride.Leave += caixaTextoGride_Leave;
                    }
                }
                else
                {

                    caixaTextoGride = new TextBox();

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //---------------------------Cheked Taxa
        private void btDesfazer_Click(object sender, EventArgs e)
        {
            metodoIniciaFormulario();
        }

        private void cbTaxaEstorno_Click(object sender, EventArgs e)
        {
            //Arrumar Taxa
            metodoCalculaTotais();
        }

        private void FrmAlterarExcluirParcialVenda_KeyDown(object sender, KeyEventArgs e)
        {
            //atalho da tecla de atalho ESC
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {
                btSair.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.F10) == true)
            {
                btAtualizar.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.F2) == true)
            {
                btExcluir.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.Enter) == true)
            {
                btAdicionar.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.F5) == true)
            {
                btDesconto.PerformClick();
            }

        }


    }
}
