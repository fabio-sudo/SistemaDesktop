using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmBackup : Form
    {
        BackgroundWorker worker;
        Boolean backup = false;//se for true backup ja realizado

        public FrmBackup()
        {
            InitializeComponent();
        }
        //Botão Sair
        private void btSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            //Criando Caixa de dialogo
            FrmCaixaDialogo frmCaixa = new FrmCaixaDialogo("Confirmação",
            " Deseja realmente sair do Backup ?",
            Properties.Resources.Backup,
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

        //Botão Gerar
        private void btGerar_Click(object sender, EventArgs e)
        {

            if (tbLocalBackup.Text.Trim() == string.Empty)
            {
                DialogResult result;
                result = MessageBox.Show("Informe o local do Backup?", "ERRO",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                backup = false;
                pbBarraProgressoBackup.Value = 0;
                pbBarraProgressoBackup.Visible = true;
                lbProgressBar.Visible = true;

                worker = new BackgroundWorker();
                worker.WorkerReportsProgress = true;
                worker.DoWork += (obj, ea) => longTask(10);
                worker.ProgressChanged += new ProgressChangedEventHandler(progressReport);
                worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(workedCompleted);
                worker.RunWorkerAsync();//Exibe Barra de Progresso

                backgroundWorker.RunWorkerAsync();//Realiza Backup

            }
        }

        //Botão Selecionar
        private void btSelecionar_Click(object sender, EventArgs e)
        {
            String localbackup;
            String dataBackup;
            String Backup;

            DialogResult resut = folderBrowserDialog.ShowDialog();
            if (resut == DialogResult.OK)
            {

                localbackup = folderBrowserDialog.SelectedPath;

                //data do backup
                dataBackup = dtpDataBackup.Value.ToShortDateString().Replace("/", "-");
                Backup = localbackup + "\\" + dataBackup + "-BancoDeDadosSqlServer.BAK";
                tbLocalBackup.Text = Backup;
            }
            else
                return;
        }

        //Informativos do Backup
        void progressReport(object sender, ProgressChangedEventArgs e)
        {

            pbBarraProgressoBackup.Value = e.ProgressPercentage;

        }

        void workedCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pbBarraProgressoBackup.Visible = false;
            lbProgressBar.Visible = false;
        }

        private void longTask(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Thread.Sleep(100);
                worker.ReportProgress(i * (100 / times));
                if (backup == true)
                {
                    //Finaliza a operação
                    break;
                }
            }

        }

        private void FrmBackup_Load(object sender, EventArgs e)
        {
            pbBarraProgressoBackup.Visible = false;
            lbProgressBar.Visible = false;
        }

        //Executa Backup
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            NegBackupBancoDeDados nBackup = new NegBackupBancoDeDados();
            if (nBackup.Backup(tbLocalBackup.Text) == true)
            {

                DialogResult result;
                result = MessageBox.Show("Backup foi Realizado com sucesso!", "Confirmação",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    backup = true;

                }
            }
            else
            {
                DialogResult result;
                result = MessageBox.Show("Não foi possivel realizar o Backup", "ERRO",
                           MessageBoxButtons.OK, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    return;
                }
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pbBarraProgressoBackup.Visible = false;
            lbProgressBar.Visible = false;
            this.Close();
        }

        private void FrmBackup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Escape) == true)
            {

                btSair.PerformClick();

            }
            //atalho da tecla de atalho F10
            else if (e.KeyCode.Equals(Keys.F10) == true)
            {

                btGerar.PerformClick();

            }            //atalho da tecla de atalho F10
            else if (e.KeyCode.Equals(Keys.F2) == true)
            {

                btSelecionar.PerformClick();

            }
        }



    }
}
