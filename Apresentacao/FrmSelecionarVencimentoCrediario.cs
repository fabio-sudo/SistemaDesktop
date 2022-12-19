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
    public partial class FrmSelecionarVencimentoCrediario : Form
    {
        decimal valorDias;
        Boolean valida = false;
        Boolean atualizaDataCrediario = false;
        public DateTime dataVencimento;
        DateTime dataVencimentoAtual;
        DateTime dataItemAtual;

        public FrmSelecionarVencimentoCrediario(DateTime DataItem,DateTime VencimentoAtual)
        {
            InitializeComponent();

         dataVencimentoAtual = VencimentoAtual;
         dataItemAtual = DataItem;
        }

     private void metodoCalculaData(){
         try
         {
             valida = true;

             DateTime startTime = dtpDataInicial.Value;
             DateTime endTime = dtpDataFinal.Value;
             TimeSpan span = endTime.Subtract(startTime);

             if (atualizaDataCrediario == false)
             {
                 if (span.Days > 90 || span.Days < 1)
                 {

                     dtpDataFinal.Value = DateTime.Now.AddDays(30);
                     nudDias.Value = 30;
                 }
                 else
                 {
                     nudDias.Value = Convert.ToDecimal(span.Days);
                 }
             }
             else {

                 nudDias.Value = Convert.ToDecimal(span.Days);
             }
             

             valida = false;
         }
         catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

     private void FrmSelecionarVencimentoCrediario_Load(object sender, EventArgs e)
        {
            //Recebe a data Inicial do Item
            dtpDataInicial.Value = dataItemAtual;

            if (dataVencimentoAtual.ToShortDateString() != DateTime.Now.ToShortDateString()) {
                nudDias.Minimum = -90;
                atualizaDataCrediario = true;
                dtpDataFinal.Value = dataVencimentoAtual;
                valorDias = nudDias.Value;

            
            
            }
            else
            {
                nudDias.Minimum = 1;
                dtpDataFinal.Value = dtpDataInicial.Value.AddDays(30);
                valorDias = nudDias.Value;
            }
        }

     private void btRegistrar_Click(object sender, EventArgs e)
     {
         metodoCalculaData();

         DialogResult resposta;
        //Criando Caixa de dialogo
         FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Data de Vencimento",
         " Data de Vencimento Selecionada: \n" +dtpDataFinal.Value.ToShortDateString(),
          Properties.Resources.DataLogo,
          System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
          Color.White,
          "Sim", "Não",
          false);
         resposta = frmCaixa.ShowDialog();

         if (resposta == DialogResult.Yes)
         {
             dataVencimento = dtpDataFinal.Value;
             this.DialogResult = DialogResult.Yes;
         }

     }

     private void nudDias_ValueChanged(object sender, EventArgs e)
     {
         if (valida == false)
         {
             //-----Aumenta os dias
             if (nudDias.Value != valorDias)
             {
                 double DiasAdd = Convert.ToDouble(nudDias.Value - valorDias);
                 dtpDataFinal.Value = dtpDataFinal.Value.AddDays(DiasAdd);
                 valorDias = nudDias.Value;
             }
         }

     }

     private void dtpDataFinal_ValueChanged(object sender, EventArgs e)
     {
         metodoCalculaData();
     }

     private void btCancelar_Click(object sender, EventArgs e)
     {
         DialogResult resposta;
         //Criando Caixa de dialogo
         FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
         " Deseja realmente Cancelar?",
         Properties.Resources.DialogQuestion,
         System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76))))),
         Color.White,
         "Sim", "Não",
         false);

         resposta = frmCaixa.ShowDialog();
         if (resposta == DialogResult.Yes)
         {
             this.Close();
             this.DialogResult = DialogResult.Cancel;

         }
     }

     private void FrmSelecionarVencimentoCrediario_KeyDown(object sender, KeyEventArgs e)
     {
         if (e.KeyCode.Equals(Keys.F10) == true)
         {
             btRegistrar.PerformClick();
         }
         if (e.KeyCode.Equals(Keys.Escape) == true)
         {
             btCancelar.PerformClick();
         }
     }

     private void nudDias_KeyPress(object sender, KeyPressEventArgs e)
     {
         if (e.KeyChar == 13)
         {
             btRegistrar.PerformClick();
             e.Handled = true;
         }
     }


    }
}
