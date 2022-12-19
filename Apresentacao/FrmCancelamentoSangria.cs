using Apresentacao.Formulas;
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
    public partial class FrmCancelamentoSangria : Form
    {
        Sangria objSangriaAlterada = new Sangria();
        Sangria sangriaSelecionada = new Sangria();
        SangriaLista sangriaLista = new SangriaLista();//Lista para preencher o gride
        SangriaLista sangriaListaAlt = new SangriaLista();//Lista para cadastrar
        SangriaLista listaSangriaExcluir = new SangriaLista();
        NegSangria nSangria = new NegSangria();

        ListaFormaPagamento listaFormaPagamento = new ListaFormaPagamento();
        NegFormaPagamento nFormaPagamento = new NegFormaPagamento();

        NegFuncionario nFuncionario = new NegFuncionario();

        //-----------------Metodos
        Metodos metodos = new Metodos();
        int quantidadeItem = 0;
        double totalCancelar = 0;
        string FormularioCancelado = "";
        //Objetos Gride
        TextBox caixaTextoGride;

        //Objetos para o cancelamento
        SangriaListaCancelamento listaSangriaCancelada = new SangriaListaCancelamento();
        ItemVendaLista itemVendaSelecionado = new ItemVendaLista();
        ParcialVendaListaSangria parcialVendaSelecionado = new ParcialVendaListaSangria();
        ItemCrediarioLista itemCrediarioPagoSelecionado = new ItemCrediarioLista();
        ItemCrediarioParcialLista itemCrediarioParcialSelecionado = new ItemCrediarioParcialLista();
        CaixaLista caixaSelecionado = new CaixaLista();

        public FrmCancelamentoSangria(Sangria sangria, CaixaLista caixa, [Optional] ParcialVendaListaSangria parcialVenda, [Optional]  ItemVendaLista itemVenda, [Optional] ItemCrediarioLista itemCrediario, [Optional]  ItemCrediarioParcialLista itemCrediarioParcial)
        {
            InitializeComponent();

            sangriaSelecionada = sangria;

            if (caixa != null)
            {
                caixaSelecionado = caixa;
            }
            //Objetos a serem cancelados
            if (parcialVenda != null)
            {
                parcialVendaSelecionado = parcialVenda;
            }
            if (itemVenda != null)
            {
                itemVendaSelecionado = itemVenda;
            }
            if (itemCrediario != null)
            {
                itemCrediarioPagoSelecionado = itemCrediario;
            }
            if (itemCrediarioParcial != null)
            {
                itemCrediarioParcialSelecionado = itemCrediarioParcial;
            }

        }

        //----------------------------------------Metodos

        //Inicia o formulario
        private void metodoIniciaFormulario()
        {


            metodoPreencheCombobox();
            //ParcialVenda
            if (parcialVendaSelecionado.Count > 0)
            {
                FormularioCancelado = "ParcialVenda";
                dtpDataSangria.Value = sangriaSelecionada.dataSangria;
                sangriaLista = nSangria.BuscarSangriaParaCancelamento(sangriaSelecionada.dataSangria);
                AtualizarDataGridCancelamentoVendaParcial();
            }
            //ItemVenda
            else if (itemVendaSelecionado.Count > 0)
            {
                FormularioCancelado = "ItemVenda";
                dtpDataSangria.Value = sangriaSelecionada.dataSangria;
                sangriaLista = nSangria.BuscarSangriaParaCancelamento(sangriaSelecionada.dataSangria);
                AtualizarDataGridCancelamentoItemVenda();
            }
            //ItemCrediarioPago
            else if (itemCrediarioPagoSelecionado.Count > 0)
            {

                FormularioCancelado = "ItemCrediarioPago";
                sangriaLista = metodoSangriaCrediario(itemCrediarioPagoSelecionado);
                AtualizarDataGridCancelamentoItemCrediarioPago();
            }
            //ItemCrediarioParcial
            else if (itemCrediarioParcialSelecionado.Count > 0)
            {
                FormularioCancelado = "ItemCrediarioParcial";
                sangriaLista = metodoSangriaCrediarioParcial(itemCrediarioParcialSelecionado);
                AtualizarDataGridCancelamentoItemCrediarioParcial();
            }
            else
            {

                FrmCaixaDialogo frmCaixaCad = new FrmCaixaDialogo("Sangria não existe",
                "Não exitem dados na Sangria!",
                Properties.Resources.DialogErro,
                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                Color.White,
                "Ok", "",
                false);
                frmCaixaCad.ShowDialog();
                DialogResult = DialogResult.Cancel;
            }


            //Atualiza o gride
            AtualizarDataGrid();
            //Calcula totais
            metodoCalculaTotais();
            //Percorre o gride verificando os valores
            metodoValidaCalculaGrideAtualizacoes();
            //Passa o Focu pro DataGrideSangria
            dgvSangria.Focus();
        }

        //Atualiza dados do dataGrid
        private void AtualizarDataGrid()
        {
            this.dgvSangria.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

            int indice = 0;

            foreach (Sangria sangCancelado in listaSangriaCancelada)
            {

                foreach (Sangria sang in this.sangriaLista)
                {
                    if (sangCancelado.pagamentoSangria.codigoFormaPagamento == sang.pagamentoSangria.codigoFormaPagamento &&
                        sangCancelado.dataSangria == sang.dataSangria)
                    {

                        this.dgvSangria.Rows.Add(1);

                        //----------------------------Exibindo valor a ser cancelado
                        if (sangCancelado.valorSangria > 0)
                        {
                            dgvSangria.Rows[indice].Cells["valorParcialVenda"].Style.ForeColor = Color.Red;
                        }
                        //Quantidade itens sangria 3                        
                        quantidadeItem = sangriaLista.Where(t => t.pagamentoSangria.codigoFormaPagamento == sang.pagamentoSangria.codigoFormaPagamento && t.dataSangria == sang.dataSangria).Count();

                        //Valor total cancelado de itens R$60
                        totalCancelar = sangriaLista.Where(t => t.pagamentoSangria.codigoFormaPagamento == sang.pagamentoSangria.codigoFormaPagamento && t.dataSangria == sang.dataSangria).Select(s => s.valorSangria).Sum();

                        this.dgvSangria[0, indice].Value = sang.ordemSangra;
                        this.dgvSangria[1, indice].Value = sang.valorSangria;//Valor da sangria para atualização e liberação cancelamento
                        //------------------------------------------------
                        this.dgvSangria[2, indice].Value = sang.valorSangria;//Valor atual da sangria FIXO
                        this.dgvSangria[3, indice].Value = sang.funcionarioSangria.codigoFuncionario;
                        this.dgvSangria[4, indice].Value = sang.funcionarioSangria.nomeFuncionario + " " + sang.funcionarioSangria.sobrenomeFuncionario;
                        this.dgvSangria[5, indice].Value = sang.pagamentoSangria.codigoFormaPagamento;
                        this.dgvSangria[6, indice].Value = sang.pagamentoSangria.formaPagamento;
                        this.dgvSangria[7, indice].Value = 0;
                        this.dgvSangria[8, indice].Value = sang.estatusSangria;
                        this.dgvSangria[9, indice].Value = sang.dataSangria;
                        indice++;
                    }
                }
            }

            dgvSangria.Update();
            this.dgvSangria.ClearSelection();
        }

        //Preencher ComboBox
        public void metodoPreencheCombobox()
        {

            this.formaPagamentoParcial.Items.Clear();
            this.formaPagamentoCancelado.Items.Clear();

            this.listaFormaPagamento = nFormaPagamento.BuscarFormaPagamentoPorNome("");

            foreach (FormaPagamento pag in this.listaFormaPagamento)
            {
                if (pag.formaPagamento != "CREDIARIO")
                {
                    {
                        this.formaPagamentoParcial.Items.IndexOf(pag.codigoFormaPagamento);
                        this.formaPagamentoParcial.Items.Add(pag.formaPagamento);

                        this.formaPagamentoCancelado.Items.IndexOf(pag.codigoFormaPagamento);
                        this.formaPagamentoCancelado.Items.Add(pag.formaPagamento);
                    }
                }
            }
        }

        //Calcula Totais
        private void metodoCalculaTotais()
        {
            //Caixa
            double valorSangria = 0;
            double valorSangriaNova = 0;
            double valorCancelado = 0;//VAlor do caixa
            double valorRetirada = 0;
            //-----------------------------------------Calcula Totais do Datagride
            //faz a soma dos totais dos valores do gride
            #region dgvSanngria
            foreach (DataGridViewRow col in dgvSangria.Rows)
            {
                //Valor da Parcial
                valorSangriaNova = valorSangriaNova + Convert.ToDouble(col.Cells[1].Value);
                valorSangria = valorSangria + Convert.ToDouble(col.Cells[3].Value);//Valor fixo da sangria
            }
            #endregion

            #region dgvCancelamento
            foreach (DataGridViewRow col in dgvCancelamento.Rows)
            {
                //Valor da Parcial
                valorCancelado = valorCancelado + Convert.ToDouble(col.Cells[2].Value);
                valorRetirada = valorRetirada + Convert.ToDouble(col.Cells[3].Value);

                col.DefaultCellStyle.ForeColor = Color.SkyBlue;
                col.ErrorText = "";

            }
            #endregion


            //-----------Venda
            if (FormularioCancelado == "ParcialVenda")
            {
                lbCaixaTotal.Text = "+ " + String.Format("{0:C2}", (listaSangriaCancelada.Sum(p => p.valorSangria)) + sangriaLista.Sum(p => p.valorSangria * quantidadeItem));//TotalCaixa
            }
            else
            {
                lbCaixaTotal.Text = "+ " + String.Format("{0:C2}", (listaSangriaCancelada.Sum(p => p.valorSangria)) + valorCancelado);//TotalCaixa          
            }
            lbSangriaTotal.Text = "+" + String.Format("{0:C2}", valorSangriaNova);//TotalNovaSangria
            lbTotalCancelado.Text = "- " + String.Format("{0:C2}", itemVendaSelecionado.Sum(i => i.quantidadeVenda * i.precoVenda));//Soma dos Itens Cancelados
            lbCaixaRestante.Text = "+ " + String.Format("{0:C2}", (valorCancelado));//ValorRestanteCaixa           

        }

        //Retorna Lista de Parcias Atualizadas
        private void metodoAddSangriaLista()
        {

            sangriaListaAlt = new SangriaLista();

            foreach (DataGridViewRow col in dgvSangria.Rows)
            {
                Sangria newSangria = new Sangria();
                newSangria.pagamentoSangria = new FormaPagamento();
                newSangria.funcionarioSangria = new Funcionario();

                newSangria.codigoSangria = objSangriaAlterada.codigoSangria;
                newSangria.valorSangria = Convert.ToDouble(col.Cells[0].Value);
                newSangria.pagamentoSangria.codigoFormaPagamento = Convert.ToInt32(col.Cells[3].Value);
                newSangria.pagamentoSangria.formaPagamento = (col.Cells[4].Value).ToString();
                newSangria.funcionarioSangria = objSangriaAlterada.funcionarioSangria;
                newSangria.descontoItem = Convert.ToDouble(col.Cells[5].Value);
                newSangria.JurosItem = Convert.ToDouble(col.Cells[6].Value);
                newSangria.dataSangria = objSangriaAlterada.dataSangria;
                newSangria.ordemSangra = objSangriaAlterada.ordemSangra;

                if (newSangria.valorSangria > 0)//Só adiciona valores lançados
                {
                    sangriaListaAlt.Add(newSangria);
                }
            }
        }

        #region Venda ItemVenda e ParcialVenda
        //VENDAPARCIAL
        private void AtualizarDataGridCancelamentoVendaParcial()
        {
            try
            {
                this.dgvCancelamento.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

                //Adiciona Valores e forma de pagamentos a serem cancelados
                Sangria sangriaCancelada = new Sangria();
                listaSangriaCancelada = new SangriaListaCancelamento();

                #region ADD PARCIALVENDA
                int contador = 0;
                foreach (ParcialVenda item in parcialVendaSelecionado)
                {
                    if (item.valorParcialVenda < 0)
                    {

                        item.valorParcialVenda = 0;
                    }



                    if (listaSangriaCancelada.Count() > 0)
                    {

                        if (listaSangriaCancelada[contador].pagamentoSangria.codigoFormaPagamento == item.formaPagamentoVenda.codigoFormaPagamento)
                        {

                            listaSangriaCancelada[contador].valorSangria = listaSangriaCancelada[contador].valorSangria + (item.valorParcialVenda);
                            listaSangriaCancelada[contador].retiradaSangria = listaSangriaCancelada[contador].retiradaSangria + (item.valorParcialVenda);
                        }
                        else
                        {

                            sangriaCancelada = new Sangria();
                            sangriaCancelada.pagamentoSangria = new FormaPagamento();

                            sangriaCancelada.valorSangria = item.valorParcialVenda;
                            sangriaCancelada.retiradaSangria = item.valorParcialVenda;
                            sangriaCancelada.pagamentoSangria.codigoFormaPagamento = item.formaPagamentoVenda.codigoFormaPagamento;
                            sangriaCancelada.pagamentoSangria.formaPagamento = item.formaPagamentoVenda.formaPagamento;
                            sangriaCancelada.dataSangria = sangriaSelecionada.dataSangria;
                            listaSangriaCancelada.Add(sangriaCancelada);

                            contador++;
                        }
                    }
                    else
                    {

                        sangriaCancelada = new Sangria();
                        sangriaCancelada.pagamentoSangria = new FormaPagamento();

                        sangriaCancelada.valorSangria = item.valorParcialVenda;
                        sangriaCancelada.pagamentoSangria.codigoFormaPagamento = item.formaPagamentoVenda.codigoFormaPagamento;
                        sangriaCancelada.pagamentoSangria.formaPagamento = item.formaPagamentoVenda.formaPagamento;
                        sangriaCancelada.retiradaSangria = item.valorParcialVenda;
                        sangriaCancelada.dataSangria = sangriaSelecionada.dataSangria;
                        listaSangriaCancelada.Add(sangriaCancelada);
                    }

                }
                #endregion

                if (this.listaSangriaCancelada.Count > 0)
                {
                    this.dgvCancelamento.Rows.Add(this.listaSangriaCancelada.Count);
                }
                else
                {
                    return;
                }

                int indice = 0;
                foreach (Sangria sang in this.listaSangriaCancelada)
                {
                    this.dgvCancelamento[0, indice].Value = sang.pagamentoSangria.codigoFormaPagamento;
                    this.dgvCancelamento[1, indice].Value = sang.pagamentoSangria.formaPagamento;//forma de pagamentoo
                    this.dgvCancelamento[2, indice].Value = sang.valorSangria;//Valor a ser cancelado      
                    this.dgvCancelamento[3, indice].Value = sang.retiradaSangria;
                    this.dgvCancelamento[4, indice].Value = sang.dataSangria;
                    indice++;
                }
                dgvCancelamento.Update();

                this.dgvCancelamento.ClearSelection();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        //ITEMVENDA 
        private void AtualizarDataGridCancelamentoItemVenda()
        {
            try
            {

                this.dgvCancelamento.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

                //Adiciona Valores e forma de pagamentos a serem cancelados
                Sangria sangriaCancelada = new Sangria();
                listaSangriaCancelada = new SangriaListaCancelamento();
                int contador = 0;

                foreach (ItemVenda item in itemVendaSelecionado)
                {

                    if (listaSangriaCancelada.Count() > 0)
                    {

                        if (listaSangriaCancelada[contador].pagamentoSangria.codigoFormaPagamento == item.Venda.formaPagamento.codigoFormaPagamento)
                        {

                            listaSangriaCancelada[contador].valorSangria = listaSangriaCancelada[contador].valorSangria + (item.quantidadeVenda * item.precoVenda);
                            listaSangriaCancelada[contador].retiradaSangria = listaSangriaCancelada[contador].retiradaSangria + (item.quantidadeVenda * item.precoVenda);
                            listaSangriaCancelada[contador].JurosItem = listaSangriaCancelada[contador].JurosItem + (item.quantidadeVenda * item.precoVenda) + item.JurosItem;
                            listaSangriaCancelada[contador].descontoItem = listaSangriaCancelada[contador].descontoItem + (item.quantidadeVenda * item.precoVenda) + item.descontoItem;
                        }
                        else
                        {

                            sangriaCancelada = new Sangria();
                            sangriaCancelada.pagamentoSangria = new FormaPagamento();

                            sangriaCancelada.valorSangria = item.quantidadeVenda * item.precoVenda;
                            sangriaCancelada.retiradaSangria = item.quantidadeVenda * item.precoVenda;
                            sangriaCancelada.pagamentoSangria.codigoFormaPagamento = item.Venda.formaPagamento.codigoFormaPagamento;
                            sangriaCancelada.pagamentoSangria.formaPagamento = item.Venda.formaPagamento.formaPagamento;
                            sangriaCancelada.dataSangria = item.dataItemVenda;
                            sangriaCancelada.JurosItem = item.JurosItem;
                            sangriaCancelada.descontoItem = item.descontoItem;

                            listaSangriaCancelada.Add(sangriaCancelada);

                            contador++;
                        }
                    }
                    else
                    {

                        sangriaCancelada = new Sangria();
                        sangriaCancelada.pagamentoSangria = new FormaPagamento();

                        sangriaCancelada.valorSangria = item.quantidadeVenda * item.precoVenda;
                        sangriaCancelada.pagamentoSangria.codigoFormaPagamento = item.Venda.formaPagamento.codigoFormaPagamento;
                        sangriaCancelada.pagamentoSangria.formaPagamento = item.Venda.formaPagamento.formaPagamento;
                        sangriaCancelada.retiradaSangria = item.quantidadeVenda * item.precoVenda;
                        sangriaCancelada.dataSangria = item.dataItemVenda;
                        sangriaCancelada.JurosItem = item.JurosItem;
                        sangriaCancelada.descontoItem = item.descontoItem;

                        listaSangriaCancelada.Add(sangriaCancelada);
                    }

                }

                if (this.listaSangriaCancelada.Count > 0)
                {
                    this.dgvCancelamento.Rows.Add(this.listaSangriaCancelada.Count);
                }
                else
                {
                    return;
                }

                int indice = 0;
                foreach (Sangria sang in this.listaSangriaCancelada)
                {
                    this.dgvCancelamento[0, indice].Value = sang.pagamentoSangria.codigoFormaPagamento;
                    this.dgvCancelamento[1, indice].Value = sang.pagamentoSangria.formaPagamento;//forma de pagamento
                    this.dgvCancelamento[2, indice].Value = caixaSelecionado.Where(c => c.formaPagamento.codigoFormaPagamento == sang.pagamentoSangria.codigoFormaPagamento).Select(s => s.valorCaixa).Sum() - sang.valorSangria - sang.JurosItem + sang.descontoItem;//Valor a ser cancelado
                    this.dgvCancelamento[3, indice].Value = sang.retiradaSangria;
                    this.dgvCancelamento[4, indice].Value = sang.dataSangria;
                    indice++;
                }
                dgvCancelamento.Update();

                this.dgvCancelamento.ClearSelection();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        #endregion

        #region Crediario ItemCrediarioPago e ParcialCrediario

        //ItemCrediarioPago
        private void AtualizarDataGridCancelamentoItemCrediarioPago()
        {
            try
            {

                this.dgvCancelamento.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

                //Adiciona Valores e forma de pagamentos a serem cancelados
                Sangria sangriaCancelada = new Sangria();
                listaSangriaCancelada = new SangriaListaCancelamento();
                sangriaLista.Count();

                ItemCrediarioLista novaListaCrediarioPago = new ItemCrediarioLista();

                //Remover Items que não existem na Sangria
                foreach (ItemCrediario pago in itemCrediarioPagoSelecionado)
                {
                    foreach (Sangria sangria in sangriaLista)
                    {

                        if (sangria.pagamentoSangria.codigoFormaPagamento == pago.formaPagamento.codigoFormaPagamento &&
                            sangria.dataSangria == pago.dataItemCrediario)
                        {

                            novaListaCrediarioPago.Add(pago);
                            break;
                        }
                    }
                }
                //Lista com apenas valore a serm cancelados de acordo com a sangria
                itemCrediarioPagoSelecionado = novaListaCrediarioPago;

                //Adiciona os valores restantes do caixa
                int contador = 0;
                foreach (ItemCrediario item in itemCrediarioPagoSelecionado)
                {
                    if (listaSangriaCancelada.Count() > 0)
                    {

                        if (listaSangriaCancelada[contador].pagamentoSangria.codigoFormaPagamento == item.formaPagamento.codigoFormaPagamento &&
                            listaSangriaCancelada[contador].dataSangria == item.dataItemCrediario)
                        {

                            listaSangriaCancelada[contador].valorSangria = listaSangriaCancelada[contador].valorSangria + (item.quantidadeItemCrediario * item.valorItemCrediario);
                            listaSangriaCancelada[contador].retiradaSangria = listaSangriaCancelada[contador].retiradaSangria + (item.quantidadeItemCrediario * item.valorItemCrediario);
                            listaSangriaCancelada[contador].JurosItem = listaSangriaCancelada[contador].JurosItem + item.jurosItemCrediario;
                            listaSangriaCancelada[contador].descontoItem = listaSangriaCancelada[contador].descontoItem + item.descontoItemCrediario;

                        }
                        else
                        {

                            sangriaCancelada = new Sangria();
                            sangriaCancelada.pagamentoSangria = new FormaPagamento();

                            sangriaCancelada.valorSangria = item.quantidadeItemCrediario * item.valorItemCrediario;
                            sangriaCancelada.retiradaSangria = item.quantidadeItemCrediario * item.valorItemCrediario;
                            sangriaCancelada.pagamentoSangria.codigoFormaPagamento = item.formaPagamento.codigoFormaPagamento;
                            sangriaCancelada.pagamentoSangria.formaPagamento = item.formaPagamento.formaPagamento;
                            sangriaCancelada.dataSangria = item.dataItemCrediario;
                            sangriaCancelada.JurosItem = item.jurosItemCrediario;
                            sangriaCancelada.descontoItem = item.descontoItemCrediario;
                            listaSangriaCancelada.Add(sangriaCancelada);

                            contador++;
                        }
                    }
                    else
                    {

                        sangriaCancelada = new Sangria();
                        sangriaCancelada.pagamentoSangria = new FormaPagamento();

                        sangriaCancelada.valorSangria = item.quantidadeItemCrediario * item.valorItemCrediario;
                        sangriaCancelada.pagamentoSangria.codigoFormaPagamento = item.formaPagamento.codigoFormaPagamento;
                        sangriaCancelada.pagamentoSangria.formaPagamento = item.formaPagamento.formaPagamento;
                        sangriaCancelada.retiradaSangria = item.quantidadeItemCrediario * item.valorItemCrediario;
                        sangriaCancelada.dataSangria = item.dataItemCrediario;
                        sangriaCancelada.JurosItem = item.jurosItemCrediario;
                        sangriaCancelada.descontoItem = item.descontoItemCrediario;
                        listaSangriaCancelada.Add(sangriaCancelada);
                    }
                }//Foreach

                //Adiciona colunas ao gride
                if (this.listaSangriaCancelada.Count > 0)
                {
                    this.dgvCancelamento.Rows.Add(this.listaSangriaCancelada.Count);
                }
                else
                {
                    return;
                }

                int indice = 0;
                foreach (Sangria sang in this.listaSangriaCancelada)
                {
                    this.dgvCancelamento[0, indice].Value = sang.pagamentoSangria.codigoFormaPagamento;
                    this.dgvCancelamento[1, indice].Value = sang.pagamentoSangria.formaPagamento;//forma de pagamento
                    this.dgvCancelamento[2, indice].Value = caixaSelecionado.Where(c => c.formaPagamento.codigoFormaPagamento == sang.pagamentoSangria.codigoFormaPagamento && c.dataCaixa == sang.dataSangria).Select(s => s.valorCaixa).Sum() - sang.valorSangria - sang.JurosItem + sang.descontoItem;//Valor a ser cancelado
                    this.dgvCancelamento[3, indice].Value = sang.retiradaSangria;
                    this.dgvCancelamento[4, indice].Value = sang.dataSangria;
                    indice++;
                }
                dgvCancelamento.Update();

                this.dgvCancelamento.ClearSelection();

            }//Try
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        //Adiciona itens na sangria de acordo com data do item cancelado e da sangria equivalente
        public SangriaLista metodoSangriaCrediario(ItemCrediarioLista lista)
        {
            try
            {
                sangriaLista = new SangriaLista();
                ItemCrediarioLista ItensRemovidos = new ItemCrediarioLista();

                int contador = 0;
                foreach (ItemCrediario item in lista)
                {
                    if (sangriaLista.Count == 0)
                    {

                        sangriaLista = nSangria.BuscarSangriaParaCancelamento(item.dataItemCrediario);
                    }
                    else if (item.dataItemCrediario != sangriaLista[contador].dataSangria)
                    {
                        //Toda vez que a data for diferente busca os itens do caixa 
                        //E os adiciona na lista antiga
                        SangriaLista sangriaListaNova = new SangriaLista();
                        sangriaListaNova = nSangria.BuscarSangriaParaCancelamento(item.dataItemCrediario);
                        //Se não houver sangria o item não é adicionado
                        if (sangriaListaNova.Count > 0)
                        {
                            foreach (Sangria sangAdd in sangriaListaNova)
                            {

                                sangriaLista.Add(sangAdd);

                            }
                        }
                        //Remove o item da lista Pois não sangria referente ao item
                        else
                        {

                            foreach (ItemCrediario itemRemove in itemCrediarioPagoSelecionado)
                            {
                                //Verifica se os itens são iguais e remove os mesmo da lista a atualizar
                                if (item == itemRemove)
                                {

                                    ItensRemovidos.Add(itemRemove);
                                    break;
                                }

                            }
                        }

                    }

                }

                //Remove itens da lista que não tem Sangria 
                if (ItensRemovidos.Count > 0)
                {

                    foreach (ItemCrediario itemRemove in ItensRemovidos)
                    {
                        itemCrediarioPagoSelecionado.Remove(itemRemove);
                    }
                }

                return sangriaLista;

            }

            catch (Exception ex) { MessageBox.Show(ex.Message); return null; }
        }

        //ItemCrediarioParcial
        private void AtualizarDataGridCancelamentoItemCrediarioParcial()
        {
            try
            {

                this.dgvCancelamento.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

                //Adiciona Valores e forma de pagamentos a serem cancelados
                Sangria sangriaCancelada = new Sangria();
                listaSangriaCancelada = new SangriaListaCancelamento();

                ItemCrediarioParcialLista novaListaParcial = new ItemCrediarioParcialLista();

                //Remover Items que não existem na Sangria
                foreach (ItemCrediarioParcial parcial in itemCrediarioParcialSelecionado)
                {
                    foreach (Sangria sangria in sangriaLista)
                    {

                        if (sangria.pagamentoSangria.codigoFormaPagamento == parcial.FormaPagamento.codigoFormaPagamento &&
                            sangria.dataSangria == parcial.dataParcial)
                        {

                            novaListaParcial.Add(parcial);
                            break;
                        }
                    }
                }
                //Lista com apenas valore a serm cancelados de acordo com a sangria
                itemCrediarioParcialSelecionado = novaListaParcial;


                int contador = 0;
                foreach (ItemCrediarioParcial item in itemCrediarioParcialSelecionado)
                {
                    if (listaSangriaCancelada.Count() > 0)
                    {

                        if (listaSangriaCancelada[contador].pagamentoSangria.codigoFormaPagamento == item.FormaPagamento.codigoFormaPagamento &&
                            listaSangriaCancelada[contador].dataSangria == item.dataParcial)
                        {

                            listaSangriaCancelada[contador].valorSangria = listaSangriaCancelada[contador].valorSangria + item.valorPagoParcial;
                            listaSangriaCancelada[contador].retiradaSangria = listaSangriaCancelada[contador].retiradaSangria + item.valorPagoParcial;
                            listaSangriaCancelada[contador].JurosItem = listaSangriaCancelada[contador].JurosItem + item.jurosParcial;
                            listaSangriaCancelada[contador].descontoItem = listaSangriaCancelada[contador].descontoItem + item.descontoParcial;

                        }
                        else
                        {

                            sangriaCancelada = new Sangria();
                            sangriaCancelada.pagamentoSangria = new FormaPagamento();

                            sangriaCancelada.valorSangria = item.valorPagoParcial;
                            sangriaCancelada.retiradaSangria = item.valorPagoParcial;
                            sangriaCancelada.pagamentoSangria.codigoFormaPagamento = item.FormaPagamento.codigoFormaPagamento;
                            sangriaCancelada.pagamentoSangria.formaPagamento = item.FormaPagamento.formaPagamento;
                            sangriaCancelada.dataSangria = item.dataParcial;
                            sangriaCancelada.JurosItem = item.jurosParcial;
                            sangriaCancelada.descontoItem = item.descontoParcial;
                            listaSangriaCancelada.Add(sangriaCancelada);

                            contador++;
                        }
                    }
                    else
                    {

                        sangriaCancelada = new Sangria();
                        sangriaCancelada.pagamentoSangria = new FormaPagamento();

                        sangriaCancelada.valorSangria = item.valorPagoParcial;
                        sangriaCancelada.retiradaSangria = item.valorPagoParcial;
                        sangriaCancelada.pagamentoSangria.codigoFormaPagamento = item.FormaPagamento.codigoFormaPagamento;
                        sangriaCancelada.pagamentoSangria.formaPagamento = item.FormaPagamento.formaPagamento;
                        sangriaCancelada.dataSangria = item.dataParcial;
                        sangriaCancelada.JurosItem = item.jurosParcial;
                        sangriaCancelada.descontoItem = item.descontoParcial;
                        listaSangriaCancelada.Add(sangriaCancelada);

                    }
                }//Foreach

                //Adiciona colunas ao gride
                if (this.listaSangriaCancelada.Count > 0)
                {
                    this.dgvCancelamento.Rows.Add(this.listaSangriaCancelada.Count);
                }
                else
                {
                    return;
                }

                int indice = 0;
                foreach (Sangria sang in this.listaSangriaCancelada)
                {
                    this.dgvCancelamento[0, indice].Value = sang.pagamentoSangria.codigoFormaPagamento;
                    this.dgvCancelamento[1, indice].Value = sang.pagamentoSangria.formaPagamento;//forma de pagamento
                    this.dgvCancelamento[2, indice].Value = caixaSelecionado.Where(c => c.formaPagamento.codigoFormaPagamento == sang.pagamentoSangria.codigoFormaPagamento && c.dataCaixa == sang.dataSangria).Select(s => s.valorCaixa).Sum() - sang.valorSangria - sang.JurosItem + sang.descontoItem;//Valor a ser cancelado
                    this.dgvCancelamento[3, indice].Value = sang.retiradaSangria;
                    this.dgvCancelamento[4, indice].Value = sang.dataSangria;
                    indice++;
                }
                dgvCancelamento.Update();

                this.dgvCancelamento.ClearSelection();

            }//Try
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }//Criar esse método

        //Adiciona itens na sangria de acordo com data do item cancelado e da sangria equivalente
        public SangriaLista metodoSangriaCrediarioParcial(ItemCrediarioParcialLista lista)
        {
            try
            {
                sangriaLista = new SangriaLista();
                ItemCrediarioParcialLista ItensRemovidos = new ItemCrediarioParcialLista();

                int contador = 0;
                foreach (ItemCrediarioParcial item in lista)
                {
                    if (sangriaLista.Count == 0)
                    {

                        sangriaLista = nSangria.BuscarSangriaParaCancelamento(item.dataParcial);
                    }
                    else if (item.dataParcial != sangriaLista[contador].dataSangria)
                    {
                        //Toda vez que a data for diferente busca os itens do caixa 
                        //E os adiciona na lista antiga
                        SangriaLista sangriaListaNova = new SangriaLista();
                        sangriaListaNova = nSangria.BuscarSangriaParaCancelamento(item.dataParcial);
                        //Se não houver sangria o item não é adicionado
                        if (sangriaListaNova.Count > 0)
                        {
                            foreach (Sangria sangAdd in sangriaListaNova)
                            {

                                sangriaLista.Add(sangAdd);

                            }
                        }
                        //Remove o item da lista Pois não sangria referente ao item
                        else
                        {

                            foreach (ItemCrediarioParcial itemRemove in itemCrediarioParcialSelecionado)
                            {
                                //Verifica se os itens são iguais e remove os mesmo da lista a atualizar
                                if (item == itemRemove)
                                {

                                    ItensRemovidos.Add(itemRemove);
                                    break;
                                }

                            }
                        }

                    }

                }

                //Remove itens da lista que não tem Sangria 
                if (ItensRemovidos.Count > 0)
                {

                    foreach (ItemCrediarioParcial itemRemove in ItensRemovidos)
                    {
                        itemCrediarioParcialSelecionado.Remove(itemRemove);
                    }
                }

                return sangriaLista;

            }

            catch (Exception ex) { MessageBox.Show(ex.Message); return null; }
        }//Atualizar Ess Método

        #endregion


        //Metodo atualiza valores validação CurrentRows Valor Tempo Real
        private void metodoAtualizaCancelamentoGrid()
        {

            double valorCanceladoAtualizar = 0;
            double totalCancelarAtualiza = 0;
            double totalCancelarCaixa = 0;


            if (FormularioCancelado == "ItemVenda")
            {
                totalCancelarAtualiza = totalCancelarAtualiza = listaSangriaCancelada.Where(t => t.pagamentoSangria.codigoFormaPagamento == Convert.ToInt32(dgvSangria.CurrentRow.Cells[5].Value)).Select(s => s.valorSangria + s.JurosItem - s.descontoItem).Sum();
                totalCancelarAtualiza = (caixaSelecionado.Where(c => c.formaPagamento.codigoFormaPagamento == Convert.ToInt32(dgvSangria.CurrentRow.Cells[5].Value)).Select(s => s.valorCaixa).Sum() - totalCancelarAtualiza);

            }
            else if (FormularioCancelado == "ItemCrediarioPago")
            {

                totalCancelarAtualiza = totalCancelarAtualiza = listaSangriaCancelada.Where(t => t.pagamentoSangria.codigoFormaPagamento == Convert.ToInt32(dgvSangria.CurrentRow.Cells[5].Value) && t.dataSangria == Convert.ToDateTime(dgvSangria.CurrentRow.Cells[9].Value)).Select(s => s.valorSangria + s.JurosItem - s.descontoItem).Sum();
                totalCancelarCaixa = (caixaSelecionado.Where(c => c.formaPagamento.codigoFormaPagamento == Convert.ToInt32(dgvSangria.CurrentRow.Cells[5].Value) && c.dataCaixa == Convert.ToDateTime(dgvSangria.CurrentRow.Cells[9].Value)).Select(s => s.valorCaixa).Sum());
                totalCancelarAtualiza = totalCancelarCaixa - totalCancelarAtualiza;

            }
            else if (FormularioCancelado == "ItemCrediarioParcial")
            {

                totalCancelarAtualiza = totalCancelarAtualiza = listaSangriaCancelada.Where(t => t.pagamentoSangria.codigoFormaPagamento == Convert.ToInt32(dgvSangria.CurrentRow.Cells[5].Value) && t.dataSangria == Convert.ToDateTime(dgvSangria.CurrentRow.Cells[9].Value)).Select(s => s.valorSangria + s.JurosItem - s.descontoItem).Sum();
                totalCancelarCaixa = (caixaSelecionado.Where(c => c.formaPagamento.codigoFormaPagamento == Convert.ToInt32(dgvSangria.CurrentRow.Cells[5].Value) && c.dataCaixa == Convert.ToDateTime(dgvSangria.CurrentRow.Cells[9].Value)).Select(s => s.valorCaixa).Sum());
                totalCancelarAtualiza = totalCancelarAtualiza - totalCancelarCaixa;

            }
            else//ParcialVenda 
            {

                totalCancelarAtualiza = totalCancelarAtualiza = listaSangriaCancelada.Where(t => t.pagamentoSangria.codigoFormaPagamento == Convert.ToInt32(dgvSangria.CurrentRow.Cells[6].Value)).Select(s => s.valorSangria).Sum();

            }



            foreach (DataGridViewRow col in dgvSangria.Rows)
            {
                if (col.Cells[5].Value.ToString() == dgvSangria.CurrentRow.Cells[5].Value.ToString() &&
                    Convert.ToDateTime(col.Cells[9].Value) == Convert.ToDateTime(dgvSangria.CurrentRow.Cells[9].Value))
                {

                    valorCanceladoAtualizar = valorCanceladoAtualizar + Convert.ToDouble(col.Cells[1].Value);

                }
            }
            foreach (DataGridViewRow col in dgvSangria.Rows)
            {
                if (valorCanceladoAtualizar <= totalCancelarAtualiza)
                {
                    if (col.Cells[5].Value.ToString() == dgvSangria.CurrentRow.Cells[5].Value.ToString() &&
                    Convert.ToDateTime(col.Cells[9].Value) == Convert.ToDateTime(dgvSangria.CurrentRow.Cells[9].Value))
                    {
                        col.Cells["valorParcialVenda"].Style.ForeColor = Color.SkyBlue;
                    }
                }
                else
                {

                    if (col.Cells[5].Value.ToString() == dgvSangria.CurrentRow.Cells[5].Value.ToString() &&
                    Convert.ToDateTime(col.Cells[9].Value) == Convert.ToDateTime(dgvSangria.CurrentRow.Cells[9].Value))
                    {
                        col.Cells["valorParcialVenda"].Style.ForeColor = Color.Red;
                    }
                }

            }

            this.dgvSangria.ClearSelection();
        }

        //Percorre os grides para validar os valores que devem ser atualizados na sangria
        private void metodoValidaCalculaGrideAtualizacoes()
        {

            double valorCanceladoAtualizar = 0;
            double totalCancelarAtualiza = 0;

            //Percorre as formas de pagamenta do caixa para verificar valores a serem cancelados 
            foreach (DataGridViewRow colCaixa in dgvCancelamento.Rows)
            {
                valorCanceladoAtualizar = 0;

                if (FormularioCancelado == "ItemVenda")
                {
                    totalCancelarAtualiza = listaSangriaCancelada.Where(t => t.pagamentoSangria.codigoFormaPagamento == Convert.ToInt32(colCaixa.Cells[0].Value)).Select(s => s.valorSangria).Sum();
                    totalCancelarAtualiza = (caixaSelecionado.Where(c => c.formaPagamento.codigoFormaPagamento == Convert.ToInt32(colCaixa.Cells[0].Value)).Select(s => s.valorCaixa).Sum() - totalCancelarAtualiza);
                }
                else if (FormularioCancelado == "ParcialVenda")
                {

                    totalCancelarAtualiza = listaSangriaCancelada.Where(t => t.pagamentoSangria.codigoFormaPagamento == Convert.ToInt32(colCaixa.Cells[0].Value)).Select(s => s.valorSangria).Sum();
                }
                else if ((FormularioCancelado == "ItemCrediarioPago"))
                {
                    totalCancelarAtualiza = listaSangriaCancelada.Where(t => t.pagamentoSangria.codigoFormaPagamento == Convert.ToInt32(colCaixa.Cells[0].Value) && t.dataSangria == Convert.ToDateTime(colCaixa.Cells[4].Value)).Select(s => s.valorSangria).Sum();
                    totalCancelarAtualiza = (caixaSelecionado.Where(c => c.formaPagamento.codigoFormaPagamento == Convert.ToInt32(colCaixa.Cells[0].Value) && c.dataCaixa == Convert.ToDateTime(colCaixa.Cells[4].Value)).Select(s => s.valorCaixa).Sum() - totalCancelarAtualiza);

                }

                //Soma total dos itens cancelados de acordo com a forma de pagamente 
                foreach (DataGridViewRow colSangria in dgvSangria.Rows)
                {
                    if (colCaixa.Cells[0].Value.ToString() == colSangria.Cells[5].Value.ToString() &&
                    Convert.ToDateTime(colCaixa.Cells[4].Value) == Convert.ToDateTime(colSangria.Cells[9].Value))
                    {
                        valorCanceladoAtualizar = valorCanceladoAtualizar + Convert.ToDouble(colSangria.Cells[1].Value);
                    }
                }

                //Caso o Valor a ser cancelado for <= ao valor restante do caixa muda a cor dos valores para Azul SENÃO Vermelho
                if (valorCanceladoAtualizar <= totalCancelarAtualiza)
                {
                    foreach (DataGridViewRow colValores in dgvSangria.Rows)
                    {
                        if (colValores.Cells[5].Value.ToString() == colCaixa.Cells[0].Value.ToString())
                        {
                            colValores.Cells["valorParcialVenda"].Style.ForeColor = Color.SkyBlue;
                            colCaixa.ErrorText = "";
                        }
                    }

                }
                //Soma dos itens forem maior doque valor restante do caixa cor fica vermelha
                else
                {

                    foreach (DataGridViewRow colValores in dgvSangria.Rows)
                    {
                        if (colValores.Cells[5].Value.ToString() == colCaixa.Cells[0].Value.ToString())
                        {
                            colValores.Cells["valorParcialVenda"].Style.ForeColor = Color.Red;
                            colCaixa.ErrorText = "Valor a Resto Caixa! " + colCaixa.Cells[1].Value.ToString();
                        }
                    }

                }
            }


            this.dgvSangria.ClearSelection();
        }

        //Valida se os valores atualizados não são maiores que valores que existe no caixa
        private Boolean metodoValidaAlteracaoSangria() {

           double valorValida = 0;
            
            //Percorre Data Grid com valores referente ao caixa 
            foreach (DataGridViewRow rowCancela in dgvCancelamento.Rows) {

                //Zera o valor a ser validado para a nova comparação
                valorValida = 0;

                //Percorre valores a serem atualizados
                foreach (DataGridViewRow rowSangria in dgvSangria.Rows) {
                
               //Verifica itens iguais
               if (Convert.ToInt32(rowCancela.Cells[0].Value) == Convert.ToInt32(rowSangria.Cells[5].Value) &&
                    Convert.ToDateTime(rowCancela.Cells[4].Value) == Convert.ToDateTime(rowSangria.Cells[9].Value)){
               
                   //soma itens iguais para validação
                   valorValida = valorValida + Convert.ToDouble(rowSangria.Cells[1].Value);
                     
                    }
                }//Foreach
                //Caso valor a ser atualizado for maior que o valor que existe no caixa retorna falso
                if (Math.Round(valorValida, 2) > Math.Round(Convert.ToDouble(rowCancela.Cells[2].Value),2))
                {

                    return false;
                }     
            }

            return true;
        }

        //Cria Preenche listas para realizar a exclusão do item ou alteração
        private void metodoAddSangriaAltExc() { 

            sangriaListaAlt = new SangriaLista();
            listaSangriaExcluir = new SangriaLista();

                //Percorre valores a serem atualizados
            foreach (DataGridViewRow rowSangria in dgvSangria.Rows)
            {

                //Adiciona sangrias com valor igaul a 0 para realizar a exclusão
                if (Math.Round(Convert.ToDouble(rowSangria.Cells[1].Value), 2) == 0)
                {

                    Sangria sangExcluida = new Sangria();

                    sangExcluida.funcionarioSangria = new Funcionario();
                    sangExcluida.pagamentoSangria = new FormaPagamento();

                    sangExcluida.ordemSangra = Convert.ToInt32(rowSangria.Cells[0].Value);
                    sangExcluida.funcionarioSangria.codigoFuncionario = Convert.ToInt32(rowSangria.Cells[3].Value);
                    sangExcluida.pagamentoSangria.codigoFormaPagamento = Convert.ToInt32(rowSangria.Cells[5].Value);
                    sangExcluida.dataSangria = Convert.ToDateTime(rowSangria.Cells[9].Value);

                    listaSangriaExcluir.Add(sangExcluida);
                }
                else
                {


                    Sangria sangAterar = new Sangria();

                    sangAterar.funcionarioSangria = new Funcionario();
                    sangAterar.pagamentoSangria = new FormaPagamento();

                    sangAterar.ordemSangra = Convert.ToInt32(rowSangria.Cells[0].Value);
                    sangAterar.valorSangria = Convert.ToInt32(rowSangria.Cells[1].Value);
                    sangAterar.funcionarioSangria.codigoFuncionario = Convert.ToInt32(rowSangria.Cells[3].Value);
                    sangAterar.pagamentoSangria.codigoFormaPagamento = Convert.ToInt32(rowSangria.Cells[5].Value);
                    sangAterar.dataSangria = Convert.ToDateTime(rowSangria.Cells[9].Value);

                    sangriaListaAlt.Add(sangAterar);
                }
            }
        }

        //-------------------------------------------------------Formulário
        //-------------------------Buscar Funcionário da Sangria
        private void btBuscar_Click(object sender, EventArgs e)
        {
            int n;
            bool ehUmNumero = int.TryParse(tbBuscarFuncionario.Text, out n);
            if (ehUmNumero == true)
            {
                objSangriaAlterada.funcionarioSangria = nFuncionario.BuscarFuncionarioPorCodigo(n);
                if (objSangriaAlterada.funcionarioSangria != null)
                {
                    this.tbBuscarFuncionario.Text = objSangriaAlterada.funcionarioSangria.nomeFuncionario; ;
                    dgvSangria.Focus();
                }
                else
                    tbBuscarFuncionario.Clear();
            }
            else
            {
                FrmSelecionarFuncionario frmSelecionarFuncionario = new FrmSelecionarFuncionario(tbBuscarFuncionario.Text);
                DialogResult resultado = frmSelecionarFuncionario.ShowDialog();

                if (resultado == DialogResult.OK)
                {

                    this.objSangriaAlterada.funcionarioSangria = frmSelecionarFuncionario.FuncionarioSelecionado;
                    this.tbBuscarFuncionario.Text = objSangriaAlterada.funcionarioSangria.nomeFuncionario;
                    dgvSangria.Focus();
                }

            }
        }

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

        private void tbBuscarFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btBuscar.PerformClick();
                e.Handled = true;
            }
        }

        private void tbBuscarFuncionario_Enter(object sender, EventArgs e)
        {
            tbBuscarFuncionario.Clear();
            pbFuncionario.Image = Properties.Resources.FuncionarioRosa;
            panelBuscarFuncionario.BackColor = Color.DeepPink;
        }

        //--------------------------Formulário
        private void FrmCancelamentoSangria_Load(object sender, EventArgs e)
        {
            //Pega no formulario da venda o UsuarioLogado
            if (FrmMenuPrincipal.userLogado != null)
            {
                objSangriaAlterada.funcionarioSangria = FrmMenuPrincipal.userLogado;
                tbBuscarFuncionario.Text = objSangriaAlterada.funcionarioSangria.nomeFuncionario;
            }

            metodoIniciaFormulario();
        }

        private void dgvSangria_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                //-----------Adiciona o formato apenas na caixa de texto 
                if (dgvSangria.CurrentCell.ColumnIndex == 1)
                {
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

        private void dgvSangria_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //Valor da Parcial
            if (dgvSangria.Columns[e.ColumnIndex].Name == "valorParcialVenda")
            {
                dgvSangria.Rows[e.RowIndex].ErrorText = "";
                double newDouble;

                if (dgvSangria.Rows[e.RowIndex].IsNewRow) { return; }
                if (!double.TryParse(e.FormattedValue.ToString(),
                    out newDouble) || newDouble < 0)
                {
                    dgvSangria.Rows[e.RowIndex].ErrorText = "Informe o valor da Sangria";
                }

            }
        }

        //-----------------------------Data Gride Caixa de Texto
        //Evento TextoChanged do Gride
        private void caixaTextoGride_TextChanged(object sender, EventArgs e)
        {
            metodos.metodoMoedaTB(ref caixaTextoGride);
        }

        private void caixaTextoGride_Leave(object sender, EventArgs e)
        {
            metodoAtualizaCancelamentoGrid();
            metodoCalculaTotais();
        }

        private void FrmCancelamentoSangria_KeyDown(object sender, KeyEventArgs e)
        {
            //atalho da tecla de atalho ESC
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {
                btSair.PerformClick();
            }
            //atalho para o botão cadastrar
            else if (e.KeyCode.Equals(Keys.F10) == true)
            {
                btAlterar.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.F2) == true)
            {
                btExcluir.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.F5) == true)
            {
                btBuscar.PerformClick();
            }
        }

        //----------------------------Botões
        private void btExcluir_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult resposta;
                //Criando Caixa de dialogo
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Exclusão",
                "Deseja excluir a sangria?",
                 Properties.Resources.DialogExcluir,
                 System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                 Color.White,
                 "Sim", "Não",
                 false);
                resposta = frmCaixa.ShowDialog();
                if (resposta == DialogResult.Yes)
                {

                    //Adiciona sangria a serem excluidas 
                    listaSangriaExcluir = new SangriaLista();
                    Sangria sangExcluida = new Sangria();

                    foreach (DataGridViewRow row in dgvSangria.Rows)
                    {

                        sangExcluida = new Sangria();
                        sangExcluida.funcionarioSangria = new Funcionario();
                        sangExcluida.pagamentoSangria = new FormaPagamento();

                        sangExcluida.ordemSangra = Convert.ToInt32(row.Cells[0].Value);
                        sangExcluida.funcionarioSangria.codigoFuncionario = Convert.ToInt32(row.Cells[3].Value);
                        sangExcluida.pagamentoSangria.codigoFormaPagamento = Convert.ToInt32(row.Cells[5].Value);
                        sangExcluida.dataSangria = Convert.ToDateTime(row.Cells[9].Value);

                        listaSangriaExcluir.Add(sangExcluida);
                    }


                    if (nSangria.ExcluirSangriaCancelamento(listaSangriaExcluir) == true)
                    {

                        resposta = new DialogResult();
                        //Criando Caixa de dialogo
                        frmCaixa = new FrmCaixaDialogo("Confirmação",
                        "Exclusão Realizada com Sucesso! \r\n" +
                        "Deseja realizar impressão comprovante?",
                        Properties.Resources.DialogOK,
                        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                        Color.White,
                        "Sim", "Não",
                        false);

                        resposta = frmCaixa.ShowDialog();
                        if (resposta == DialogResult.Yes)
                        {

                            //Imprimi o comprovante
                            this.DialogResult = DialogResult.Yes;
                        }
                        else
                        {

                            this.DialogResult = DialogResult.Yes;

                        }

                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir Sangria!", "Erro Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.DialogResult = DialogResult.No;//Erro finaliza a operação por não conseguir excluir os itens
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir Sangria!: " + ex.Message, "Erro Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            Boolean validaAlteracao = true;

            try
            {

                DialogResult resposta;
                //Criando Caixa de dialogo
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Alteração",
                "Deseja alterar os dados da sangria?",
                 Properties.Resources.Alterar,
                 System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                 Color.White,
                 "Sim", "Não",
                 false);

                resposta = frmCaixa.ShowDialog();

                if (resposta == DialogResult.Yes)
                {

                    //-----Validação sangria está dentro do valor do caixa
                    if (metodoValidaAlteracaoSangria() == true)
                    {

                        //---------------------------Adiciona itens a serem atualizados
                        metodoAddSangriaAltExc();

                        //-----------------------------Altera os dados da sangria
                        #region Alterar
                        if (sangriaListaAlt.Count() > 0)
                        {

                            if (nSangria.AlterarSangria(sangriaListaAlt) != true)
                            {

                                //Criando Caixa de dialogo
                                frmCaixa = new FrmCaixaDialogo("Erro ao Alterar",
                                "Não foi possível alterar a sangria!",
                                Properties.Resources.DialogErro,
                                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                Color.White,
                                "OK", "",
                                false);

                                validaAlteracao = false;
                            }

                        }
                        #endregion

                        //-----------------------Exclui Valores 0,00 da sangria
                        #region Excluir
                        if (listaSangriaExcluir.Count() > 0)
                        {

                            //Criando Caixa de dialogo
                            frmCaixa = new FrmCaixaDialogo("Sangria zerada",
                           "Sangrias com valor R$0,00 serão excluidas!",
                            Properties.Resources.DialogExcluir,
                            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                            Color.White,
                            "OK", "",
                            false);

                            frmCaixa.ShowDialog();

                            if (nSangria.ExcluirSangriaCancelamento(listaSangriaExcluir) != true)
                            {

                                //Criando Caixa de dialogo
                                frmCaixa = new FrmCaixaDialogo("Erro ao Excluir",
                                "Não foi possível excluir a sangria!",
                                Properties.Resources.DialogErro,
                                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                Color.White,
                                "OK", "",
                                false);

                                validaAlteracao = false;
                            }
                        }
                        #endregion

                        //-----------------------------------------Impressão do comprovante
                        if (validaAlteracao == true) {

                            resposta = new DialogResult();
                            //Criando Caixa de dialogo
                            frmCaixa = new FrmCaixaDialogo("Confirmação",
                            "Alteração Realizada com Sucesso! \r\n" +
                            "Deseja realizar impressão comprovante?",
                            Properties.Resources.DialogOK,
                            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                            Color.White,
                            "Sim", "Não",
                            false);

                            resposta = frmCaixa.ShowDialog();
                            if (resposta == DialogResult.Yes)
                            {

                                //Imprimi o comprovante
                                this.DialogResult = DialogResult.Yes;
                            }
                            else
                            {

                                this.DialogResult = DialogResult.Yes;

                            }                  
                        }

                    }//Validação da alteração
                        else
                        {
                            //Criando Caixa de dialogo
                            frmCaixa = new FrmCaixaDialogo("Sangria maior que o Caixa",
                           "Erro - Valores da sangria maiores que o lançamento no Caixa!",
                            Properties.Resources.DialogErro,
                            System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                            Color.White,
                            "OK", "",
                            false);

                        
                    }
                }
            }
            catch (Exception ex)
            {
                FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Erro",
                "Erro ao alterar a Sangria \r\n" + ex.Message,
                Properties.Resources.DialogErro,
                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                Color.White,
                "Ok", "",
                false);

                frmCaixa.ShowDialog();
            }
        }

        private void btSugestao_Click(object sender, EventArgs e)
        {

            if (btSugestao.Text != "Desfazer")
            {
                foreach (DataGridViewRow rowGridSangriaCancelamento in dgvCancelamento.Rows)
                {

                    int contador = 0;

                    //Conta quantas vezes foram realizadas as sangia
                    foreach (DataGridViewRow rowGridSangriaConta in dgvSangria.Rows)
                    {
                        //Quantas formas de pagamento iguais existem no item
                        if ((Convert.ToInt32(rowGridSangriaCancelamento.Cells[0].Value) == (Convert.ToInt32(rowGridSangriaConta.Cells[5].Value)) &&
                          (Convert.ToDateTime(rowGridSangriaCancelamento.Cells[4].Value) == Convert.ToDateTime(rowGridSangriaConta.Cells[9].Value))))
                        {
                            //Erro está aqui
                            contador++;
                        }
                    }

                    //Atualiza o valor da sangria com a sugestão
                    foreach (DataGridViewRow rowGridSangria in dgvSangria.Rows)
                    {

                        if ((Convert.ToInt32(rowGridSangriaCancelamento.Cells[0].Value) == (Convert.ToInt32(rowGridSangria.Cells[5].Value)) &&
                         (Convert.ToDateTime(rowGridSangriaCancelamento.Cells[4].Value) == Convert.ToDateTime(rowGridSangria.Cells[9].Value))))
                        {
                            rowGridSangria.Cells[1].Value = (Convert.ToDouble(rowGridSangriaCancelamento.Cells[2].Value) / contador);
                        }
                    }

                }


                btSugestao.Text = "Desfazer";
                btSugestao.BackColor = Color.White;
                btSugestao.ForeColor = Color.Black;
                btSugestao.FlatAppearance.BorderColor = Color.Black;
                btSugestao.FlatAppearance.BorderSize = 1;

            }
            //--------------------------------Retorna valores originais da sangria
            else {

                foreach (DataGridViewRow row in dgvSangria.Rows) {

                    row.Cells[1].Value = row.Cells[2].Value;
                
                }

                btSugestao.Text = "Preencher";
                btSugestao.BackColor = Color.FromArgb(51,51,76);
                btSugestao.ForeColor = Color.White;
                btSugestao.FlatAppearance.BorderColor = Color.Black;
                btSugestao.FlatAppearance.BorderSize = 0;

            }

            metodoValidaCalculaGrideAtualizacoes();
            metodoCalculaTotais();

        }


    }
}
