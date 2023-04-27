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
    public partial class FrmCancelamentoDespesa : Form
    {
       ListaDespesas listaDespesaSelecionada = new ListaDespesas();
       SangriaLista  listaSangriaSelecionada = new SangriaLista();
       CaixaLista  listaCaixaSelecionado = new CaixaLista();
       DespesaCaixa objDespesa = new DespesaCaixa();

        //Listas Alteração e Exclusão
       ListaDespesas listaDespesaAlterar = new ListaDespesas();
       ListaDespesas listaDespesaExcluir = new ListaDespesas();

       ParcialVendaLista  listaParcialSelecionado = new ParcialVendaLista();
       ItemVendaLista  listaItemVendaSelecionado = new ItemVendaLista();
       ItemCrediarioLista listaItemCrediarioPagoSelecionado = new ItemCrediarioLista();
       ItemCrediarioParcialLista listaItemCrediarioParcialSelecionado = new ItemCrediarioParcialLista();

       NegDespesa nDespesa = new NegDespesa();
       NegSangria nSangria = new NegSangria();
       NegCaixa nCaixa = new NegCaixa();
       NegFuncionario nFuncionario = new NegFuncionario();

       //Objetos Gride
       TextBox caixaTextoGride;
       Metodos metodos = new Metodos();

       public FrmCancelamentoDespesa([Optional] ParcialVendaLista listaParcialVenda, [Optional]  ItemVendaLista itemVenda, [Optional] ItemCrediarioLista itemCrediario, [Optional]  ItemCrediarioParcialLista itemCrediarioParcial)
        {
            InitializeComponent();

            //Objetos a serem cancelados
            if (listaParcialVenda != null)
            {
                listaParcialSelecionado = listaParcialVenda;
            }
            if (itemVenda != null)
            {
                listaItemVendaSelecionado = itemVenda;
            }
            if (itemCrediario != null)
            {
                listaItemCrediarioPagoSelecionado = itemCrediario;
            }
            if (itemCrediarioParcial != null)
            {
                listaItemCrediarioParcialSelecionado = itemCrediarioParcial;
            }
        }

        //Adiciona as listas todos os elementos por data
       private void metodoConstrutorListas() {

           //---------------------------------------------------------------------------------Adicinando todos os itens Por data para realizar cancelamento
           var dataCancelamento = listaItemVendaSelecionado.GroupBy(p => p.dataItemVenda).Select(d => new { data = d.Key });

           //Adiciona todas as Despesas - Sangrias - Caixa -> De acordo com a lista de cancelamento
           foreach (var item in dataCancelamento)
           {

               listaDespesaSelecionada.AddRange((nDespesa.BuscarDespesaPorData(item.data, item.data)));
               listaSangriaSelecionada.AddRange((nSangria.BuscarSangriaParaCancelamento(item.data)));
               listaCaixaSelecionado.AddRange(nCaixa.BuscarCaixaValores(item.data));
           }

           //---------------------------------------------------------------------------------
       }

       //Preenche grid Movimento Caixa
       private void metodoConstrutor() {

           dgvCancelamento.Rows.Clear();

           #region itemVenda - Cancelamento
           if (listaItemVendaSelecionado.Count > 0)
           {

               dgvCancelamento.Rows.Add(listaItemVendaSelecionado.GroupBy(p => new { p.Venda.formaPagamento, p.dataItemVenda }).Count());//Adiciona Rows de acordo com as forma de pagamentos dos itens cancelados

               var listaAgrupada = listaItemVendaSelecionado
                   .GroupBy(p => new { p.Venda.formaPagamento, p.dataItemVenda })
                   .Select(g => new
                   {
                       formaPagamento = g.Key.formaPagamento,
                       dataCancelamento = g.Key.dataItemVenda,
                       cancelamento = g.Sum(p => ((p.precoVenda * p.quantidadeVenda) + p.JurosItem - p.Venda.descontoVenda)),
                       sangria = listaSangriaSelecionada
                           .Where(s => s.pagamentoSangria.codigoFormaPagamento == g.Key.formaPagamento.codigoFormaPagamento && s.dataSangria == g.Key.dataItemVenda)
                           .Select(p => p.valorSangria).Sum(),
                       caixa = listaCaixaSelecionado
                           .Where(c => c.formaPagamento.codigoFormaPagamento == g.Key.formaPagamento.codigoFormaPagamento && c.dataCaixa == g.Key.dataItemVenda)
                           .Select(p => p.valorCaixa).Sum(),
                       despesa = listaDespesaSelecionada
                           .Where(d => d.formaPagamento.codigoFormaPagamento == g.Key.formaPagamento.codigoFormaPagamento && d.dataDespesa == g.Key.dataItemVenda)
                           .Select(p => p.valorDespesa).Sum(),
                       data = g.Key.dataItemVenda
                   });


               listaAgrupada.Count();


               int indice = 0;

               foreach (var item in listaAgrupada)
               {
                   this.dgvCancelamento[0, indice].Value = item.formaPagamento.codigoFormaPagamento;
                   this.dgvCancelamento[1, indice].Value = item.formaPagamento.formaPagamento;
                   this.dgvCancelamento[2, indice].Value = item.caixa;
                   this.dgvCancelamento[3, indice].Value = - item.cancelamento;
                   this.dgvCancelamento[4, indice].Value = - item.sangria;//Sangria -> não tem nessecidade os cancelamentos estão separados
                   this.dgvCancelamento[5, indice].Value = - item.despesa;
                   this.dgvCancelamento[6, indice].Value = item.caixa - (item.cancelamento + item.sangria + item.despesa);
                   this.dgvCancelamento[7, indice].Value = item.data;
                   this.dgvCancelamento[8, indice].Value = 0;//Estorno

                   indice++;

               }
           }
           #endregion

           //ItemCrediarioPago

           //ItemCrediarioParcial

           //ParcialVenda

       }

       //Preenchimento despesas a cancelar
       private void metodoConstrutorDespesa(List<DespesaPagamento> lista)
       {
           this.dgvDespesa.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

           if (listaDespesaSelecionada.Count > 0)
           {
               dgvDespesa.Rows.Add(listaDespesaSelecionada.Count);

               int indice = 0;
               foreach (DespesaCaixa despesa in listaDespesaSelecionada)
               {

                   dgvDespesa[1, indice].Style.ForeColor = Color.Black;
                   dgvDespesa[1, indice].ErrorText = "";

                   dgvDespesa[0, indice].Value = despesa.codigoDespesa;
                   dgvDespesa[1, indice].Value = despesa.valorDespesa;
                   dgvDespesa[2, indice].Value = despesa.funcionario.codigoFuncionario;
                   dgvDespesa[3, indice].Value = despesa.funcionario.nomeFuncionario;
                   dgvDespesa[4, indice].Value = despesa.formaPagamento.codigoFormaPagamento;
                   dgvDespesa[5, indice].Value = despesa.formaPagamento.formaPagamento;
                   dgvDespesa[6, indice].Value = despesa.statusDespesa;
                   dgvDespesa[7, indice].Value = despesa.dataDespesa;
                   dgvDespesa[8, indice].Value = despesa.valorDespesa;//Valor fixo para os calculos
                   dgvDespesa[9, indice].Value = despesa.caixaDespesa.codigoCaixa;

                   if (lista != null)
                   {
                       foreach (DespesaPagamento itemLista in lista)//Lista de valores que ultrapassaram resto do caixa
                       {

                           if (itemLista.Data == despesa.dataDespesa && itemLista.FormaPagamento == despesa.formaPagamento.codigoFormaPagamento)
                           {
                               dgvDespesa[1, indice].Style.ForeColor = Color.Red;
                               dgvDespesa[1, indice].ErrorText = "Valor a Resto Caixa! " + itemLista.valorDespesaResto.ToString();
                           }
                       }
                   }


                   indice++;
               }

               dgvDespesa.Update();
           }
       }

       //Valida atualização ou exclusão
       private void metodoAtualizaPreenchimento() {

           double valorDespesaAtual = 0;
           double restoCaixa = 0;
           int pagamento = Convert.ToInt32(dgvDespesa.CurrentRow.Cells[4].Value);
           DateTime data = Convert.ToDateTime(dgvDespesa.CurrentRow.Cells[7].Value);

           //GridDespesa
           if (dgvDespesa.CurrentRow.Cells[1].Value != dgvDespesa.CurrentRow.Cells[8].Value)
           {

               foreach (DataGridViewRow rowDespesa in dgvDespesa.Rows) {

               if(pagamento == Convert.ToInt32(rowDespesa.Cells[4].Value) && data == Convert.ToDateTime(rowDespesa.Cells[7].Value)){
               valorDespesaAtual = valorDespesaAtual + Convert.ToDouble(rowDespesa.Cells[1].Value.ToString().Replace("R$", ""));
               
                  }
               }
               //-----------------------------------------------------------------------------------------------------------------

               //GridCancelamento
               foreach (DataGridViewRow row in dgvCancelamento.Rows) {

                   if (pagamento == Convert.ToInt32(row.Cells[0].Value) && data == Convert.ToDateTime(row.Cells[7].Value))
                   {
                      row.Cells[5].Value = -valorDespesaAtual;
                      row.Cells[6].Value = Convert.ToDouble(row.Cells[2].Value) + (Convert.ToDouble(row.Cells[4].Value) + Convert.ToDouble(row.Cells[3].Value) - valorDespesaAtual);
                      restoCaixa = Convert.ToDouble(row.Cells[6].Value);

                      if (restoCaixa > valorDespesaAtual || valorDespesaAtual == 0)
                      {
                          row.Cells[6].Style.ForeColor = Color.Turquoise;
                          pbOk.Image = Properties.Resources.DialogOK;

                          foreach (DataGridViewRow rowDespesa in dgvDespesa.Rows)
                          {
                              if (pagamento == Convert.ToInt32(rowDespesa.Cells[4].Value) && data == Convert.ToDateTime(rowDespesa.Cells[7].Value))
                              {
                                  rowDespesa.Cells[1].Style.ForeColor = Color.Turquoise;
                                  rowDespesa.Cells[1].ErrorText = "";
                              }
                          }
                      }
                      else
                      {
                          row.Cells[6].Style.ForeColor = Color.Red;
                          pbOk.Image = Properties.Resources.DialogErro;

                          foreach (DataGridViewRow rowDespesa in dgvDespesa.Rows)
                          {
                              if (pagamento == Convert.ToInt32(rowDespesa.Cells[4].Value) && data == Convert.ToDateTime(rowDespesa.Cells[7].Value))
                              {
                                  rowDespesa.Cells[1].Style.ForeColor = Color.Red;
                                  rowDespesa.Cells[1].ErrorText = "Valor a Resto Caixa! " + row.Cells[6].Value.ToString(); 
                              }
                          }
                      }

                      break;
                   }              
                }
               //----------------------------------------------------------------------------------------------------------------

             }
         }

      //Valida todos os valores a serem Excluidos ou alterados para atender Caixa
       private Boolean metodoValidaExclusaoAlteracao() {

           List<DespesaPagamento> lista = new List<DespesaPagamento>();

           foreach (DataGridViewRow rowDespesa in dgvDespesa.Rows)
           {
               DespesaPagamento despesa = new DespesaPagamento(
                   Convert.ToDateTime(rowDespesa.Cells[7].Value),
                   Convert.ToInt32(rowDespesa.Cells[4].Value),
                   Convert.ToDouble(rowDespesa.Cells[1].Value.ToString().Replace("R$", ""))                                 
           );

               lista.Add(despesa);
           }

           //Lista Agrupa valores iguais
           var listaDespesaValida = lista.GroupBy(p => new { p.Data, p.FormaPagamento})
               .Select(d => new
               {
                   data = d.Key.Data,
                   pagamento = d.Key.FormaPagamento,
                   despesa = d.Sum(v => v.valorDespesaResto)
               });

           //GridCancelamento - Validação
           foreach (DataGridViewRow row in dgvCancelamento.Rows)
           {

               foreach(var item in listaDespesaValida){

               if(Convert.ToInt32(row.Cells[0].Value) ==  item.pagamento  &&
                  Convert.ToDateTime(row.Cells[7].Value) == item.data){

                      if (item.despesa == 0) {

                          break;
                      }
                      else if (item.despesa >= Convert.ToDouble(row.Cells[6].Value)) {

                          return false;
                      
                      }      
                  }   
               }
           }
           //-------------------------Tudo Ok retorna True
             
             
           return true;      
       }

       //Se ok Add - Lista para Alteração ou ListaExclusão valor for 0,00 
       private void metodoAddItemLista() {

           listaDespesaAlterar = new ListaDespesas();
           listaDespesaExcluir = new ListaDespesas();
           DespesaCaixa despesaAdd = new DespesaCaixa();

           foreach (DataGridViewRow row in dgvDespesa.Rows) {

              despesaAdd = new DespesaCaixa();
              despesaAdd.caixaDespesa = new Caixa();         
              despesaAdd.funcionario = new Funcionario();         
              despesaAdd.formaPagamento = new FormaPagamento();         


               despesaAdd.codigoDespesa = Convert.ToInt32(row.Cells[0].Value);
               despesaAdd.caixaDespesa.codigoCaixa = Convert.ToInt32(row.Cells[9].Value);
               despesaAdd.funcionario.codigoFuncionario =  Convert.ToInt32(row.Cells[2].Value);
               despesaAdd.formaPagamento.codigoFormaPagamento =Convert.ToInt32(row.Cells[4].Value);
               despesaAdd.descricaoDespesa = "";
               despesaAdd.valorDespesa = Convert.ToDouble(row.Cells[1].Value.ToString().Replace("R$", ""));
               despesaAdd.dataDespesa = Convert.ToDateTime(row.Cells[7].Value);
               despesaAdd.statusDespesa = row.Cells[6].Value.ToString();

               if (despesaAdd.valorDespesa == 0)
               {

                   listaDespesaExcluir.Add(despesaAdd);
               }
               else {

                   listaDespesaAlterar.Add(despesaAdd);        
               }
                      
           }

       
       }

       //Exibe itens que estão com valor incorreto
       private void metodoExibeValoresUsuario() {

           //Lista de valores Despesa - FormaPagamento e Data
           var lista = listaDespesaSelecionada.GroupBy(p => new { p.dataDespesa, p.formaPagamento.codigoFormaPagamento })
               .Select(d => new { 
                   data = d.Key.dataDespesa ,
                   pagamento =  d.Key.codigoFormaPagamento,
                   despesa = d.Sum(v => v.valorDespesa)
               });

           List<DespesaPagamento> listaCancelada = new List<DespesaPagamento>();

           double despesaCancelada = 0;
           foreach (DataGridViewRow rowCancelamento in dgvCancelamento.Rows)
           {

            despesaCancelada =  lista.Where(p => p.data == Convert.ToDateTime(rowCancelamento.Cells[7].Value) &&
                   p.pagamento == Convert.ToInt32(rowCancelamento.Cells[0].Value)).Select(d => d.despesa).FirstOrDefault();

            if (despesaCancelada > Convert.ToDouble(rowCancelamento.Cells[6].Value)) {

                rowCancelamento.Cells[6].Style.ForeColor = Color.Red;
                
                DespesaPagamento despesa = new DespesaPagamento(
                      Convert.ToDateTime(rowCancelamento.Cells[7].Value),
                      Convert.ToInt32(rowCancelamento.Cells[0].Value),
                      Convert.ToDouble(rowCancelamento.Cells[6].Value)
                      );

                listaCancelada.Add(despesa);
              }
          }

           //Preenche o Grid marcando os itens que devem ser cancelados
           metodoConstrutorDespesa(listaCancelada);
       }

        //Calcula totais do caixa para facilitar para o usuário
       private void metodoCalculaTotais() {

           string pagamento =(dgvDespesa.CurrentRow.Cells[5].Value).ToString();
           DateTime data = Convert.ToDateTime(dgvDespesa.CurrentRow.Cells[7].Value);


           //Caixa
           double totalSangria = 0;
           double totalDespesa = 0;
           double totalCancelado = 0;
           double totalCaixa = 0;
           double totalRestanteCaixa = 0;


           foreach (DataGridViewRow row in dgvCancelamento.Rows) {

               if(Convert.ToInt32(dgvDespesa.CurrentRow.Cells[4].Value) == Convert.ToInt32(row.Cells[0].Value) &&
                   Convert.ToDateTime(dgvDespesa.CurrentRow.Cells[7].Value) == Convert.ToDateTime(row.Cells[7].Value)){

               totalCaixa = totalCaixa +  Convert.ToDouble(row.Cells[2].Value);
               totalCancelado = totalCancelado + Convert.ToDouble(row.Cells[3].Value);
               totalSangria = totalSangria + Convert.ToDouble(row.Cells[4].Value);
               totalDespesa = totalDespesa + Convert.ToDouble(row.Cells[5].Value);
               totalRestanteCaixa = totalRestanteCaixa + Convert.ToDouble(row.Cells[6].Value);  
               }
           
           }

           lbCaixaTotal.Text = String.Format("{0:C2}", totalCaixa);
           lbDataTotalCaixa.Text = pagamento +" "+data.ToShortDateString();

           lbTotalCancelado.Text = String.Format("{0:C2}", totalCancelado);
           lbDespesaTotal.Text = String.Format("{0:C2}", totalDespesa);
           lbTotalSangria.Text = String.Format("{0:C2}", totalSangria);
           lbCaixaRestante.Text = String.Format("{0:C2}", totalRestanteCaixa);
       
       }

        //---------------------Controles
       private void FrmCancelamentoDespesa_Load(object sender, EventArgs e)
       {
           metodoConstrutorListas();//Busca Referencias dos lançamentos dos itens cancelados  Sangria - Caixa - Despesa
           metodoConstrutor();//Preenche Grid Movimento Caixa
           metodoExibeValoresUsuario();//Preenche Grid Despesa
           metodoCalculaTotais();//Calcula totais a serem cancelados 


           dgvCancelamento.ClearSelection();
       }

       private void btSair_Click(object sender, EventArgs e)
       {

           DialogResult resposta;
           //Criando Caixa de dialogo
           FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
           " Deseja realmente sair da Atualização de Despesas?",
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

       private void btSugestao_Click(object sender, EventArgs e)
       {
           if (btSugestao.Text != "Desfazer")
           {
               var despesaSugestaoLista = listaDespesaSelecionada
                  .GroupBy(p => new { p.formaPagamento.codigoFormaPagamento, p.dataDespesa })
                  .Select(g => new
                  {
                      formaPagamento = g.Key.codigoFormaPagamento,
                      dataCancelamento = g.Key.dataDespesa,
                      cancelamentoDespesa = g.Sum(p => (p.valorDespesa)),
                      quantidadeDespesa = g.Count()
                  });

               //Percorrer Gride Cancelamento
               foreach (DataGridViewRow row in dgvCancelamento.Rows)
               {

                   foreach (var item in despesaSugestaoLista)
                   {

                       //Total a Cancela == Despesas -> FormaPagamento  e Data
                       if ((Convert.ToInt32(row.Cells[0].Value) == (item.formaPagamento) &&
                           (Convert.ToDateTime(row.Cells[7].Value) == item.dataCancelamento)))
                       {

                           if (Convert.ToDouble(row.Cells[6].Value) <= 0)
                           {
                               //Percorre Grid Despesa zerando os valores para cancelamento
                               int contador = 0;
                               foreach (DataGridViewRow rowDespesa in dgvDespesa.Rows)
                               {

                                   if ((Convert.ToInt32(rowDespesa.Cells[4].Value) == (item.formaPagamento) &&
                                       (Convert.ToDateTime(rowDespesa.Cells[7].Value) == item.dataCancelamento)))
                                   {

                                       rowDespesa.Cells[1].Value = 0;
                                       row.Cells[6].Style.ForeColor = Color.Turquoise;
                                       rowDespesa.Cells[1].Style.ForeColor = Color.Turquoise;
                                       rowDespesa.Cells[1].ErrorText = "";
                                       pbOk.Image = Properties.Resources.DialogOK;

                                       contador++;
                                   }

                                   if (contador == item.quantidadeDespesa) { break; }
                               }

                           }
                           //Caso haja caixa é realizada a divisão do total pelo numero de despesas
                           else
                           {
                               //Percorre Grid Despesa dividindo os valores pela quantidade de parcelas de despesa
                               int contador = 0;
                               foreach (DataGridViewRow rowDespesa in dgvDespesa.Rows)
                               {
                                   if ((Convert.ToInt32(rowDespesa.Cells[4].Value) == (item.formaPagamento) &&
                                       (Convert.ToDateTime(rowDespesa.Cells[7].Value) == item.dataCancelamento)))
                                   {

                                       rowDespesa.Cells[1].Value = Convert.ToDouble(row.Cells[6].Value) / item.quantidadeDespesa;
                                       contador++;
                                       row.Cells[6].Style.ForeColor = Color.Turquoise;
                                       rowDespesa.Cells[1].Style.ForeColor = Color.Turquoise;
                                       rowDespesa.Cells[1].ErrorText = "";
                                       pbOk.Image = Properties.Resources.DialogOK;
                                   }

                                   if (contador == item.quantidadeDespesa) { break; }
                               }
                           }
                       }
                   }

               }

               btSugestao.Text = "Desfazer";
               btSugestao.BackColor = Color.White;
               btSugestao.ForeColor = Color.Black;
               btSugestao.FlatAppearance.BorderColor = Color.Black;
               btSugestao.FlatAppearance.BorderSize = 1;

           }
           else
           {

               metodoExibeValoresUsuario();
               btSugestao.Text = "Preencher";
               btSugestao.BackColor = Color.FromArgb(51, 51, 76);
               btSugestao.ForeColor = Color.White;
               btSugestao.FlatAppearance.BorderColor = Color.Black;
               btSugestao.FlatAppearance.BorderSize = 0;



           }

       }

        //---------------------Funcionario
       private void btBuscar_Click(object sender, EventArgs e)
       {
           int n;
           bool ehUmNumero = int.TryParse(tbBuscarFuncionario.Text, out n);
           if (ehUmNumero == true)
           {
               objDespesa.funcionario = nFuncionario.BuscarFuncionarioPorCodigo(n);
               if (objDespesa.funcionario != null)
               {
                   this.tbBuscarFuncionario.Text = objDespesa.funcionario.nomeFuncionario; ;
                   dgvDespesa.Focus();
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

                   this.objDespesa.funcionario = frmSelecionarFuncionario.FuncionarioSelecionado;
                   this.tbBuscarFuncionario.Text = objDespesa.funcionario.nomeFuncionario;
                   dgvDespesa.Focus();
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

        //------------------------Grid
       private void dgvDespesa_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
       {
           try
           {
               //-----------Adiciona o formato apenas na caixa de texto 
               if (dgvDespesa.CurrentCell.ColumnIndex == 1)
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

       private void dgvDespesa_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
       {
           //Valor da Parcial
           if (dgvDespesa.Columns[e.ColumnIndex].Name == "valorParcialVenda")
           {
               dgvDespesa.Rows[e.RowIndex].ErrorText = "";
               double newDouble;

               if (dgvDespesa.Rows[e.RowIndex].IsNewRow) { return; }
               if (!double.TryParse(e.FormattedValue.ToString(),
                   out newDouble) || newDouble < 0)
               {
                   dgvDespesa.Rows[e.RowIndex].ErrorText = "Informe o valor da Despesa";
               }

           }
       }

       private void caixaTextoGride_TextChanged(object sender, EventArgs e)
       {
           metodos.metodoMoedaGridTB(ref caixaTextoGride);
       }

       private void caixaTextoGride_Leave(object sender, EventArgs e)
       {

           metodoAtualizaPreenchimento();
           metodoCalculaTotais();

       }

       private void dgvDespesa_CellClick(object sender, DataGridViewCellEventArgs e)
       {
           metodoCalculaTotais();
       }

        //---------------------Alterar & Excluir
       private void btAlterar_Click(object sender, EventArgs e)
       {
           try
           {
               bool valida = true;

               FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Alterações",
               " Deseja realmente realizar as alterações das Despesas?",
               Properties.Resources.Alterar,
               System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
               Color.White,
               "Sim", "Não",
               false);

               DialogResult resposta =
               frmCaixa.ShowDialog();

               if (resposta == DialogResult.Yes)
               {

                   if (objDespesa.funcionario == null)
                   {
                       frmCaixa = new FrmCaixaDialogo("Erro Funcionário",
                       " Selecione o funcionário responsável pelas atualizações!",
                       Properties.Resources.DialogErro,
                       System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                       Color.White,
                       "OK", "",
                       false);

                       frmCaixa.ShowDialog();

                   }
                   else
                   {
                       if (metodoValidaExclusaoAlteracao() == false)
                       {

                           //Criando Caixa de dialogo
                           frmCaixa = new FrmCaixaDialogo("Erro Valores Despesa",
                           " Verifique os valores a atualizar da Despesa!",
                           Properties.Resources.DialogErro,
                           System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                           Color.White,
                           "OK", "",
                           false);

                           frmCaixa.ShowDialog();
                       }
                       else//Alterações e Exclusões
                       {

                           metodoAddItemLista();

                           //--------------Alteraçõa
                           if (listaDespesaAlterar.Count() > 0) {

                               if (nDespesa.AtualizarDespesaCancelamento(listaDespesaAlterar) == false)
                               { 
                                   //Criando Caixa de dialogo
                                   frmCaixa = new FrmCaixaDialogo("Erro Alterar Despesa",
                                   " Verifique os dados da Alteração!",
                                   Properties.Resources.DialogErro,
                                   System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                   Color.White,
                                   "OK", "",
                                   false);

                                   frmCaixa.ShowDialog();
                                   valida = false;
                               }
                           
                           }
                           //--------------Exclusão
                           if (listaDespesaExcluir.Count() > 0) {

                               if (nDespesa.ExcluirDespesaCancelamento(listaDespesaExcluir) == false)
                               { 
                                   //Criando Caixa de dialogo
                                   frmCaixa = new FrmCaixaDialogo("Erro Excluir Despesa Zerada",
                                   " Verifique os dados da Alteração!",
                                   Properties.Resources.DialogErro,
                                   System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                                   Color.White,
                                   "OK", "",
                                   false);

                                   frmCaixa.ShowDialog();
                                   valida = false;
                               }
                                                                       
                           }

                           //Caso os dados forem atualizados com sucesso
                           if (valida != false)
                           {
                               //Exibindo atualizações concluidas com Sucesso
                               frmCaixa = new FrmCaixaDialogo("Atualizações",
                               " Dados Atualizados com sucesso!",
                               Properties.Resources.DialogOK,
                               System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                               Color.White,
                               "OK", "",
                               false);

                               frmCaixa.ShowDialog();

                               this.DialogResult = DialogResult.Yes;
                           }


                       }//Alterações
                   }
               }//Pergunta se deseja realizar as alterações
           }
           catch (Exception ex) { MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
       }

       private void btExcluir_Click(object sender, EventArgs e)
       {
         try
           {
           FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Exclusão",
               " Deseja realmente realizar a exclusão das Despesas?",
               Properties.Resources.Excluir,
               System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
               Color.White,
               "Sim", "Não",
               false);

               DialogResult resposta =
               frmCaixa.ShowDialog();

               if (resposta == DialogResult.Yes)
               {

                   if (nDespesa.ExcluirDespesaCancelamento(listaDespesaSelecionada) == false)
                   {
                       //Criando Caixa de dialogo
                       frmCaixa = new FrmCaixaDialogo("Erro Excluir Despesas",
                       " Verifique os dados da Exclusão!",
                       Properties.Resources.DialogErro,
                       System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                       Color.White,
                       "OK", "",
                       false);

                       frmCaixa.ShowDialog();
                   }
                   else {


                       //Exibindo atualizações concluidas com Sucesso
                       frmCaixa = new FrmCaixaDialogo("Exclusão",
                       " Despesas Excluidos com sucesso!",
                       Properties.Resources.DialogOK,
                       System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
                       Color.White,
                       "OK", "",
                       false);

                       frmCaixa.ShowDialog();

                       this.DialogResult = DialogResult.Yes;
                   
                   
                   }
               
               }

          }
                      
           catch (Exception ex) { MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

       private void FrmCancelamentoDespesa_KeyDown(object sender, KeyEventArgs e)
       {
           //atalho da tecla de atalho ESC
           if (e.KeyCode.Equals(Keys.Escape) == true)
           {
               btSair.PerformClick();
           }
           //atalho para o botão cadastrar
           else if (e.KeyCode.Equals(Keys.F5) == true)
           {
               btSugestao.PerformClick();
           }
           else if (e.KeyCode.Equals(Keys.F10) == true)
           {
               btAlterar.PerformClick();
           }
           else if (e.KeyCode.Equals(Keys.F2) == true)
           {
               btExcluir.PerformClick();
           }
       }




    }
}
