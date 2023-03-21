﻿using Negocio;
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

       ParcialVendaLista  listaParcialSelecionado = new ParcialVendaLista();
       ItemVendaLista  listaItemVendaSelecionado = new ItemVendaLista();
       ItemCrediarioLista listaItemCrediarioPagoSelecionado = new ItemCrediarioLista();
       ItemCrediarioParcialLista listaItemCrediarioParcialSelecionado = new ItemCrediarioParcialLista();

       NegDespesa nDespesa = new NegDespesa();
       NegSangria nSangria = new NegSangria();
       NegCaixa nCaixa = new NegCaixa();

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
                   this.dgvCancelamento[3, indice].Value = item.cancelamento;
                   this.dgvCancelamento[4, indice].Value = - item.sangria;//Sangria -> não tem nessecidade os cancelamentos estão separados
                   this.dgvCancelamento[5, indice].Value = - item.despesa;
                   this.dgvCancelamento[6, indice].Value = item.caixa - (item.cancelamento + item.sangria + item.despesa);
                   this.dgvCancelamento[7, indice].Value = item.data;
                   this.dgvCancelamento[8, indice].Value = 0;//Estorno

                   indice++;

               }
           }
           #endregion

       }

       private void metodoValidaPreenchimento() {


           // dgvSangria.Rows[indice].Cells["valorParcialVenda"].Style.ForeColor = Color.Red;
       
       
       
       }


       private void metodoConstrutorDespesa()
       {
           this.dgvDespesa.Rows.Clear(); // Limpa todos os registros atuais no grid de funcionários.

           if (listaDespesaSelecionada.Count > 0)
           {

               dgvDespesa.Rows.Add(listaDespesaSelecionada.Count);

                int indice = 0;
                foreach (DespesaCaixa despesa in listaDespesaSelecionada)
                {
                    dgvDespesa[0, indice].Value = despesa.codigoDespesa;
                    dgvDespesa[1, indice].Value = despesa.valorDespesa;
                    dgvDespesa[2, indice].Value = despesa.funcionario.codigoFuncionario;
                    dgvDespesa[3, indice].Value = despesa.funcionario.nomeFuncionario;
                    dgvDespesa[4, indice].Value = despesa.formaPagamento.codigoFormaPagamento;
                    dgvDespesa[5, indice].Value = despesa.formaPagamento.formaPagamento;
                    dgvDespesa[6, indice].Value = despesa.statusDespesa;
                    dgvDespesa[7, indice].Value = despesa.dataDespesa;

                    indice++;
                }

                dgvDespesa.Update();
             }
       }

       private void FrmCancelamentoDespesa_Load(object sender, EventArgs e)
       {
           metodoConstrutorListas();//Busca Referencias dos lançamentos dos itens cancelados  Sangria - Caixa - Despesa
           metodoConstrutor();//Preenche Grid Movimento Caixa
           metodoConstrutorDespesa();//Preenche Grid Despesa

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




    }
}
