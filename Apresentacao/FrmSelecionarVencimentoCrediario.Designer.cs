namespace Apresentacao
{
    partial class FrmSelecionarVencimentoCrediario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelecionarVencimentoCrediario));
            this.pbVencimento = new System.Windows.Forms.PictureBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btRegistrar = new System.Windows.Forms.Button();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.lbDataInicial = new System.Windows.Forms.Label();
            this.lbDataFinal = new System.Windows.Forms.Label();
            this.nudDias = new System.Windows.Forms.NumericUpDown();
            this.lbDias = new System.Windows.Forms.Label();
            this.lbAviso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbVencimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDias)).BeginInit();
            this.SuspendLayout();
            // 
            // pbVencimento
            // 
            this.pbVencimento.Image = global::Apresentacao.Properties.Resources.DataLogo;
            this.pbVencimento.Location = new System.Drawing.Point(197, 12);
            this.pbVencimento.Name = "pbVencimento";
            this.pbVencimento.Size = new System.Drawing.Size(64, 64);
            this.pbVencimento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVencimento.TabIndex = 7;
            this.pbVencimento.TabStop = false;
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.Red;
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCancelar.Location = new System.Drawing.Point(235, 212);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(130, 42);
            this.btCancelar.TabIndex = 6;
            this.btCancelar.Text = "Esc Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btRegistrar
            // 
            this.btRegistrar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btRegistrar.FlatAppearance.BorderSize = 0;
            this.btRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegistrar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btRegistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btRegistrar.Location = new System.Drawing.Point(95, 212);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(130, 42);
            this.btRegistrar.TabIndex = 5;
            this.btRegistrar.Text = "F10 Registrar";
            this.btRegistrar.UseVisualStyleBackColor = false;
            this.btRegistrar.Click += new System.EventHandler(this.btRegistrar_Click);
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Enabled = false;
            this.dtpDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(12, 161);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(130, 27);
            this.dtpDataInicial.TabIndex = 17;
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(317, 161);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(130, 27);
            this.dtpDataFinal.TabIndex = 19;
            this.dtpDataFinal.ValueChanged += new System.EventHandler(this.dtpDataFinal_ValueChanged);
            // 
            // lbDataInicial
            // 
            this.lbDataInicial.AutoSize = true;
            this.lbDataInicial.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbDataInicial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDataInicial.Location = new System.Drawing.Point(12, 137);
            this.lbDataInicial.Name = "lbDataInicial";
            this.lbDataInicial.Size = new System.Drawing.Size(94, 18);
            this.lbDataInicial.TabIndex = 16;
            this.lbDataInicial.Text = "Lançamento";
            // 
            // lbDataFinal
            // 
            this.lbDataFinal.AutoSize = true;
            this.lbDataFinal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbDataFinal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDataFinal.Location = new System.Drawing.Point(357, 137);
            this.lbDataFinal.Name = "lbDataFinal";
            this.lbDataFinal.Size = new System.Drawing.Size(90, 18);
            this.lbDataFinal.TabIndex = 18;
            this.lbDataFinal.Text = "Vencimento";
            // 
            // nudDias
            // 
            this.nudDias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudDias.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.nudDias.Location = new System.Drawing.Point(183, 161);
            this.nudDias.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nudDias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDias.Name = "nudDias";
            this.nudDias.Size = new System.Drawing.Size(90, 30);
            this.nudDias.TabIndex = 95;
            this.nudDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDias.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudDias.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudDias.ValueChanged += new System.EventHandler(this.nudDias_ValueChanged);
            this.nudDias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudDias_KeyPress);
            // 
            // lbDias
            // 
            this.lbDias.AutoSize = true;
            this.lbDias.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbDias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDias.Location = new System.Drawing.Point(210, 134);
            this.lbDias.Name = "lbDias";
            this.lbDias.Size = new System.Drawing.Size(39, 18);
            this.lbDias.TabIndex = 96;
            this.lbDias.Text = "Dias";
            // 
            // lbAviso
            // 
            this.lbAviso.AutoSize = true;
            this.lbAviso.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lbAviso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAviso.Location = new System.Drawing.Point(42, 96);
            this.lbAviso.Name = "lbAviso";
            this.lbAviso.Size = new System.Drawing.Size(381, 22);
            this.lbAviso.TabIndex = 97;
            this.lbAviso.Text = "Informe o Vencimento do Item Crediario.";
            // 
            // FrmSelecionarVencimentoCrediario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(459, 275);
            this.Controls.Add(this.lbAviso);
            this.Controls.Add(this.lbDias);
            this.Controls.Add(this.nudDias);
            this.Controls.Add(this.dtpDataInicial);
            this.Controls.Add(this.dtpDataFinal);
            this.Controls.Add(this.lbDataInicial);
            this.Controls.Add(this.lbDataFinal);
            this.Controls.Add(this.pbVencimento);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btRegistrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmSelecionarVencimentoCrediario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Vencimento";
            this.Load += new System.EventHandler(this.FrmSelecionarVencimentoCrediario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSelecionarVencimentoCrediario_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbVencimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbVencimento;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btRegistrar;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.Label lbDataInicial;
        private System.Windows.Forms.Label lbDataFinal;
        private System.Windows.Forms.NumericUpDown nudDias;
        private System.Windows.Forms.Label lbDias;
        private System.Windows.Forms.Label lbAviso;
    }
}