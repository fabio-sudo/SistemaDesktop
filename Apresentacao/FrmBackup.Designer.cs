namespace Apresentacao
{
    partial class FrmBackup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBackup));
            this.pbBackup = new System.Windows.Forms.PictureBox();
            this.tbLocalBackup = new System.Windows.Forms.TextBox();
            this.btSelecionar = new System.Windows.Forms.Button();
            this.btGerar = new System.Windows.Forms.Button();
            this.pbBarraProgressoBackup = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.dtpDataBackup = new System.Windows.Forms.DateTimePicker();
            this.lbProgressBar = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.btSair = new System.Windows.Forms.Button();
            this.lbDataBackup = new System.Windows.Forms.Label();
            this.lbLocalBackup = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackup)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBackup
            // 
            this.pbBackup.Image = global::Apresentacao.Properties.Resources.Backup;
            this.pbBackup.Location = new System.Drawing.Point(12, 12);
            this.pbBackup.Name = "pbBackup";
            this.pbBackup.Size = new System.Drawing.Size(52, 56);
            this.pbBackup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbBackup.TabIndex = 0;
            this.pbBackup.TabStop = false;
            // 
            // tbLocalBackup
            // 
            this.tbLocalBackup.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbLocalBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tbLocalBackup.Location = new System.Drawing.Point(126, 45);
            this.tbLocalBackup.Name = "tbLocalBackup";
            this.tbLocalBackup.ReadOnly = true;
            this.tbLocalBackup.Size = new System.Drawing.Size(394, 23);
            this.tbLocalBackup.TabIndex = 3;
            // 
            // btSelecionar
            // 
            this.btSelecionar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btSelecionar.FlatAppearance.BorderSize = 0;
            this.btSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSelecionar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSelecionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSelecionar.Location = new System.Drawing.Point(12, 184);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(130, 42);
            this.btSelecionar.TabIndex = 0;
            this.btSelecionar.Text = "F2 Selecionar";
            this.btSelecionar.UseVisualStyleBackColor = false;
            this.btSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            // 
            // btGerar
            // 
            this.btGerar.BackColor = System.Drawing.Color.Turquoise;
            this.btGerar.FlatAppearance.BorderSize = 0;
            this.btGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGerar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btGerar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btGerar.Location = new System.Drawing.Point(148, 184);
            this.btGerar.Name = "btGerar";
            this.btGerar.Size = new System.Drawing.Size(130, 42);
            this.btGerar.TabIndex = 1;
            this.btGerar.Text = "F10 Gerar";
            this.btGerar.UseVisualStyleBackColor = false;
            this.btGerar.Click += new System.EventHandler(this.btGerar_Click);
            // 
            // pbBarraProgressoBackup
            // 
            this.pbBarraProgressoBackup.Location = new System.Drawing.Point(87, 100);
            this.pbBarraProgressoBackup.Name = "pbBarraProgressoBackup";
            this.pbBarraProgressoBackup.Size = new System.Drawing.Size(358, 23);
            this.pbBarraProgressoBackup.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbBarraProgressoBackup.TabIndex = 4;
            this.pbBarraProgressoBackup.Visible = false;
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Selecione o Local Para salvar o Backup";
            // 
            // dtpDataBackup
            // 
            this.dtpDataBackup.Enabled = false;
            this.dtpDataBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtpDataBackup.Location = new System.Drawing.Point(126, 12);
            this.dtpDataBackup.Name = "dtpDataBackup";
            this.dtpDataBackup.Size = new System.Drawing.Size(394, 27);
            this.dtpDataBackup.TabIndex = 2;
            // 
            // lbProgressBar
            // 
            this.lbProgressBar.AutoSize = true;
            this.lbProgressBar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbProgressBar.Location = new System.Drawing.Point(201, 126);
            this.lbProgressBar.Name = "lbProgressBar";
            this.lbProgressBar.Size = new System.Drawing.Size(131, 17);
            this.lbProgressBar.TabIndex = 5;
            this.lbProgressBar.Text = "Gerando Backup ...";
            this.lbProgressBar.Visible = false;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Red;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSair.ForeColor = System.Drawing.Color.Transparent;
            this.btSair.Location = new System.Drawing.Point(390, 184);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(130, 42);
            this.btSair.TabIndex = 6;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // lbDataBackup
            // 
            this.lbDataBackup.AutoSize = true;
            this.lbDataBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbDataBackup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDataBackup.Location = new System.Drawing.Point(70, 19);
            this.lbDataBackup.Name = "lbDataBackup";
            this.lbDataBackup.Size = new System.Drawing.Size(45, 20);
            this.lbDataBackup.TabIndex = 7;
            this.lbDataBackup.Text = "Data";
            // 
            // lbLocalBackup
            // 
            this.lbLocalBackup.AutoSize = true;
            this.lbLocalBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbLocalBackup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbLocalBackup.Location = new System.Drawing.Point(70, 48);
            this.lbLocalBackup.Name = "lbLocalBackup";
            this.lbLocalBackup.Size = new System.Drawing.Size(50, 20);
            this.lbLocalBackup.TabIndex = 8;
            this.lbLocalBackup.Text = "Local";
            // 
            // FrmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(532, 249);
            this.Controls.Add(this.lbLocalBackup);
            this.Controls.Add(this.lbDataBackup);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.lbProgressBar);
            this.Controls.Add(this.pbBarraProgressoBackup);
            this.Controls.Add(this.btGerar);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.tbLocalBackup);
            this.Controls.Add(this.dtpDataBackup);
            this.Controls.Add(this.pbBackup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup";
            this.Load += new System.EventHandler(this.FrmBackup_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmBackup_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBackup;
        private System.Windows.Forms.TextBox tbLocalBackup;
        private System.Windows.Forms.Button btSelecionar;
        private System.Windows.Forms.Button btGerar;
        private System.Windows.Forms.ProgressBar pbBarraProgressoBackup;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.DateTimePicker dtpDataBackup;
        private System.Windows.Forms.Label lbProgressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label lbDataBackup;
        private System.Windows.Forms.Label lbLocalBackup;
    }
}