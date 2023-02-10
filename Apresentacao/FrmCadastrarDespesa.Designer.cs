namespace Apresentacao
{
    partial class FrmCadastrarDespesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarDespesa));
            this.btSair = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.mtbValorDespesa = new System.Windows.Forms.MaskedTextBox();
            this.lbValorDespesa = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.pbDespesa = new System.Windows.Forms.PictureBox();
            this.cbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.lbFormaPagamento = new System.Windows.Forms.Label();
            this.dtpDataDespesa = new System.Windows.Forms.DateTimePicker();
            this.lbDataDespesa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbDespesa)).BeginInit();
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Red;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSair.ForeColor = System.Drawing.Color.White;
            this.btSair.Location = new System.Drawing.Point(278, 323);
            this.btSair.Margin = new System.Windows.Forms.Padding(2);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(98, 34);
            this.btSair.TabIndex = 16;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = false;
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.Turquoise;
            this.btCadastrar.FlatAppearance.BorderSize = 0;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCadastrar.ForeColor = System.Drawing.Color.White;
            this.btCadastrar.Location = new System.Drawing.Point(11, 323);
            this.btCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(98, 34);
            this.btCadastrar.TabIndex = 15;
            this.btCadastrar.Text = "F10 Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            // 
            // mtbValorDespesa
            // 
            this.mtbValorDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.mtbValorDespesa.Location = new System.Drawing.Point(12, 80);
            this.mtbValorDespesa.Name = "mtbValorDespesa";
            this.mtbValorDespesa.Size = new System.Drawing.Size(123, 23);
            this.mtbValorDespesa.TabIndex = 34;
            // 
            // lbValorDespesa
            // 
            this.lbValorDespesa.AutoSize = true;
            this.lbValorDespesa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbValorDespesa.Location = new System.Drawing.Point(12, 61);
            this.lbValorDespesa.Name = "lbValorDespesa";
            this.lbValorDespesa.Size = new System.Drawing.Size(54, 15);
            this.lbValorDespesa.TabIndex = 33;
            this.lbValorDespesa.Text = "Valor R$";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbDescricao.Location = new System.Drawing.Point(15, 133);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(364, 165);
            this.tbDescricao.TabIndex = 36;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbDescricao.Location = new System.Drawing.Point(12, 115);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(65, 15);
            this.lbDescricao.TabIndex = 35;
            this.lbDescricao.Text = "Descrição";
            // 
            // pbDespesa
            // 
            this.pbDespesa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbDespesa.Image = global::Apresentacao.Properties.Resources.wallet;
            this.pbDespesa.Location = new System.Drawing.Point(12, 12);
            this.pbDespesa.Name = "pbDespesa";
            this.pbDespesa.Size = new System.Drawing.Size(39, 42);
            this.pbDespesa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDespesa.TabIndex = 91;
            this.pbDespesa.TabStop = false;
            // 
            // cbFormaPagamento
            // 
            this.cbFormaPagamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFormaPagamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFormaPagamento.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaPagamento.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.cbFormaPagamento.FormattingEnabled = true;
            this.cbFormaPagamento.Location = new System.Drawing.Point(140, 78);
            this.cbFormaPagamento.Margin = new System.Windows.Forms.Padding(2);
            this.cbFormaPagamento.Name = "cbFormaPagamento";
            this.cbFormaPagamento.Size = new System.Drawing.Size(138, 25);
            this.cbFormaPagamento.TabIndex = 93;
            // 
            // lbFormaPagamento
            // 
            this.lbFormaPagamento.AutoSize = true;
            this.lbFormaPagamento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbFormaPagamento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbFormaPagamento.Location = new System.Drawing.Point(137, 61);
            this.lbFormaPagamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFormaPagamento.Name = "lbFormaPagamento";
            this.lbFormaPagamento.Size = new System.Drawing.Size(111, 15);
            this.lbFormaPagamento.TabIndex = 92;
            this.lbFormaPagamento.Text = "Forma Pagamento";
            // 
            // dtpDataDespesa
            // 
            this.dtpDataDespesa.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dtpDataDespesa.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.dtpDataDespesa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDespesa.Location = new System.Drawing.Point(282, 80);
            this.dtpDataDespesa.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataDespesa.Name = "dtpDataDespesa";
            this.dtpDataDespesa.Size = new System.Drawing.Size(94, 23);
            this.dtpDataDespesa.TabIndex = 261;
            // 
            // lbDataDespesa
            // 
            this.lbDataDespesa.AutoSize = true;
            this.lbDataDespesa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbDataDespesa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDataDespesa.Location = new System.Drawing.Point(279, 61);
            this.lbDataDespesa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDataDespesa.Name = "lbDataDespesa";
            this.lbDataDespesa.Size = new System.Drawing.Size(33, 15);
            this.lbDataDespesa.TabIndex = 262;
            this.lbDataDespesa.Text = "Data";
            // 
            // FrmCadastrarDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(391, 369);
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
            this.Controls.Add(this.btCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmCadastrarDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Despesas";
            ((System.ComponentModel.ISupportInitialize)(this.pbDespesa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.MaskedTextBox mtbValorDespesa;
        private System.Windows.Forms.Label lbValorDespesa;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.PictureBox pbDespesa;
        private System.Windows.Forms.ComboBox cbFormaPagamento;
        private System.Windows.Forms.Label lbFormaPagamento;
        private System.Windows.Forms.DateTimePicker dtpDataDespesa;
        private System.Windows.Forms.Label lbDataDespesa;
    }
}