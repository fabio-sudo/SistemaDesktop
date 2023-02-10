namespace Apresentacao
{
    partial class FrmAterarExcluirDespesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAterarExcluirDespesa));
            this.lbDataDespesa = new System.Windows.Forms.Label();
            this.dtpDataDespesa = new System.Windows.Forms.DateTimePicker();
            this.cbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.lbFormaPagamento = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.mtbValorDespesa = new System.Windows.Forms.MaskedTextBox();
            this.lbValorDespesa = new System.Windows.Forms.Label();
            this.btSair = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.pbDespesa = new System.Windows.Forms.PictureBox();
            this.btExcluir = new System.Windows.Forms.Button();
            this.lbCodigoDespesa = new System.Windows.Forms.Label();
            this.tbTrocoCaixa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDespesa)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDataDespesa
            // 
            this.lbDataDespesa.AutoSize = true;
            this.lbDataDespesa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbDataDespesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lbDataDespesa.Location = new System.Drawing.Point(266, 12);
            this.lbDataDespesa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDataDespesa.Name = "lbDataDespesa";
            this.lbDataDespesa.Size = new System.Drawing.Size(33, 15);
            this.lbDataDespesa.TabIndex = 273;
            this.lbDataDespesa.Text = "Data";
            // 
            // dtpDataDespesa
            // 
            this.dtpDataDespesa.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dtpDataDespesa.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.dtpDataDespesa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDespesa.Location = new System.Drawing.Point(269, 31);
            this.dtpDataDespesa.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataDespesa.Name = "dtpDataDespesa";
            this.dtpDataDespesa.Size = new System.Drawing.Size(94, 23);
            this.dtpDataDespesa.TabIndex = 272;
            // 
            // cbFormaPagamento
            // 
            this.cbFormaPagamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFormaPagamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFormaPagamento.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaPagamento.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.cbFormaPagamento.FormattingEnabled = true;
            this.cbFormaPagamento.Location = new System.Drawing.Point(15, 82);
            this.cbFormaPagamento.Margin = new System.Windows.Forms.Padding(2);
            this.cbFormaPagamento.Name = "cbFormaPagamento";
            this.cbFormaPagamento.Size = new System.Drawing.Size(138, 25);
            this.cbFormaPagamento.TabIndex = 271;
            // 
            // lbFormaPagamento
            // 
            this.lbFormaPagamento.AutoSize = true;
            this.lbFormaPagamento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbFormaPagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lbFormaPagamento.Location = new System.Drawing.Point(12, 65);
            this.lbFormaPagamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFormaPagamento.Name = "lbFormaPagamento";
            this.lbFormaPagamento.Size = new System.Drawing.Size(111, 15);
            this.lbFormaPagamento.TabIndex = 270;
            this.lbFormaPagamento.Text = "Forma Pagamento";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbDescricao.Location = new System.Drawing.Point(15, 133);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(348, 165);
            this.tbDescricao.TabIndex = 268;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lbDescricao.Location = new System.Drawing.Point(12, 115);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(65, 15);
            this.lbDescricao.TabIndex = 267;
            this.lbDescricao.Text = "Descrição";
            // 
            // mtbValorDespesa
            // 
            this.mtbValorDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.mtbValorDespesa.Location = new System.Drawing.Point(141, 31);
            this.mtbValorDespesa.Name = "mtbValorDespesa";
            this.mtbValorDespesa.Size = new System.Drawing.Size(123, 23);
            this.mtbValorDespesa.TabIndex = 266;
            // 
            // lbValorDespesa
            // 
            this.lbValorDespesa.AutoSize = true;
            this.lbValorDespesa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbValorDespesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lbValorDespesa.Location = new System.Drawing.Point(141, 12);
            this.lbValorDespesa.Name = "lbValorDespesa";
            this.lbValorDespesa.Size = new System.Drawing.Size(54, 15);
            this.lbValorDespesa.TabIndex = 265;
            this.lbValorDespesa.Text = "Valor R$";
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Red;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSair.ForeColor = System.Drawing.Color.White;
            this.btSair.Location = new System.Drawing.Point(265, 323);
            this.btSair.Margin = new System.Windows.Forms.Padding(2);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(98, 34);
            this.btSair.TabIndex = 264;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = false;
            // 
            // btAlterar
            // 
            this.btAlterar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btAlterar.FlatAppearance.BorderSize = 0;
            this.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlterar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btAlterar.ForeColor = System.Drawing.Color.White;
            this.btAlterar.Location = new System.Drawing.Point(11, 323);
            this.btAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(98, 34);
            this.btAlterar.TabIndex = 263;
            this.btAlterar.Text = "F10 Alterar";
            this.btAlterar.UseVisualStyleBackColor = false;
            // 
            // pbDespesa
            // 
            this.pbDespesa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbDespesa.Image = global::Apresentacao.Properties.Resources.wallet;
            this.pbDespesa.Location = new System.Drawing.Point(12, 12);
            this.pbDespesa.Name = "pbDespesa";
            this.pbDespesa.Size = new System.Drawing.Size(39, 42);
            this.pbDespesa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDespesa.TabIndex = 269;
            this.pbDespesa.TabStop = false;
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.DeepPink;
            this.btExcluir.FlatAppearance.BorderSize = 0;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btExcluir.ForeColor = System.Drawing.Color.White;
            this.btExcluir.Location = new System.Drawing.Point(113, 323);
            this.btExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(98, 34);
            this.btExcluir.TabIndex = 274;
            this.btExcluir.Text = "F2 Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            // 
            // lbCodigoDespesa
            // 
            this.lbCodigoDespesa.AutoSize = true;
            this.lbCodigoDespesa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbCodigoDespesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lbCodigoDespesa.Location = new System.Drawing.Point(56, 13);
            this.lbCodigoDespesa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCodigoDespesa.Name = "lbCodigoDespesa";
            this.lbCodigoDespesa.Size = new System.Drawing.Size(46, 15);
            this.lbCodigoDespesa.TabIndex = 276;
            this.lbCodigoDespesa.Text = "Código";
            // 
            // tbTrocoCaixa
            // 
            this.tbTrocoCaixa.Enabled = false;
            this.tbTrocoCaixa.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.tbTrocoCaixa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbTrocoCaixa.Location = new System.Drawing.Point(59, 31);
            this.tbTrocoCaixa.Name = "tbTrocoCaixa";
            this.tbTrocoCaixa.Size = new System.Drawing.Size(76, 23);
            this.tbTrocoCaixa.TabIndex = 275;
            // 
            // FrmAterarExcluirDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(381, 380);
            this.Controls.Add(this.lbCodigoDespesa);
            this.Controls.Add(this.tbTrocoCaixa);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.lbDataDespesa);
            this.Controls.Add(this.dtpDataDespesa);
            this.Controls.Add(this.cbFormaPagamento);
            this.Controls.Add(this.lbFormaPagamento);
            this.Controls.Add(this.pbDespesa);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.lbDescricao);
            this.Controls.Add(this.mtbValorDespesa);
            this.Controls.Add(this.lbValorDespesa);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btAlterar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmAterarExcluirDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar & Excluir Despesa";
            ((System.ComponentModel.ISupportInitialize)(this.pbDespesa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDataDespesa;
        private System.Windows.Forms.DateTimePicker dtpDataDespesa;
        private System.Windows.Forms.ComboBox cbFormaPagamento;
        private System.Windows.Forms.Label lbFormaPagamento;
        private System.Windows.Forms.PictureBox pbDespesa;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.MaskedTextBox mtbValorDespesa;
        private System.Windows.Forms.Label lbValorDespesa;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Label lbCodigoDespesa;
        private System.Windows.Forms.TextBox tbTrocoCaixa;
    }
}