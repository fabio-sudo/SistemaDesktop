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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.epDespesa = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvCaixa = new System.Windows.Forms.DataGridView();
            this.lbTituloTotalVenda = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Caixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorRealCaixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SangriaCaixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagamentoCaixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estornoCaixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbDespesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDespesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.btSair.TabIndex = 9;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
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
            this.btCadastrar.TabIndex = 8;
            this.btCadastrar.Text = "F10 Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // mtbValorDespesa
            // 
            this.mtbValorDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.mtbValorDespesa.Location = new System.Drawing.Point(12, 80);
            this.mtbValorDespesa.Name = "mtbValorDespesa";
            this.mtbValorDespesa.Size = new System.Drawing.Size(123, 23);
            this.mtbValorDespesa.TabIndex = 1;
            this.mtbValorDespesa.TextChanged += new System.EventHandler(this.mtbValorDespesa_TextChanged);
            this.mtbValorDespesa.Leave += new System.EventHandler(this.mtbValorDespesa_Leave);
            // 
            // lbValorDespesa
            // 
            this.lbValorDespesa.AutoSize = true;
            this.lbValorDespesa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbValorDespesa.Location = new System.Drawing.Point(12, 61);
            this.lbValorDespesa.Name = "lbValorDespesa";
            this.lbValorDespesa.Size = new System.Drawing.Size(54, 15);
            this.lbValorDespesa.TabIndex = 0;
            this.lbValorDespesa.Text = "Valor R$";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbDescricao.Location = new System.Drawing.Point(15, 133);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(364, 165);
            this.tbDescricao.TabIndex = 7;
            this.tbDescricao.Leave += new System.EventHandler(this.tbDescricao_Leave);
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbDescricao.Location = new System.Drawing.Point(12, 115);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(65, 15);
            this.lbDescricao.TabIndex = 6;
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
            this.cbFormaPagamento.TabIndex = 3;
            this.cbFormaPagamento.DropDown += new System.EventHandler(this.cbFormaPagamento_DropDown);
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
            this.lbFormaPagamento.TabIndex = 2;
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
            this.dtpDataDespesa.TabIndex = 5;
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
            this.lbDataDespesa.TabIndex = 4;
            this.lbDataDespesa.Text = "Data";
            // 
            // epDespesa
            // 
            this.epDespesa.ContainerControl = this;
            // 
            // dgvCaixa
            // 
            this.dgvCaixa.AllowUserToAddRows = false;
            this.dgvCaixa.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dgvCaixa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCaixa.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCaixa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaixa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Caixa,
            this.valorRealCaixa,
            this.SangriaCaixa,
            this.formaPagamentoCaixa,
            this.estornoCaixa});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCaixa.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCaixa.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCaixa.Location = new System.Drawing.Point(384, 78);
            this.dgvCaixa.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCaixa.Name = "dgvCaixa";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.dgvCaixa.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCaixa.RowTemplate.Height = 24;
            this.dgvCaixa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCaixa.Size = new System.Drawing.Size(550, 220);
            this.dgvCaixa.TabIndex = 231;
            // 
            // lbTituloTotalVenda
            // 
            this.lbTituloTotalVenda.AutoSize = true;
            this.lbTituloTotalVenda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTituloTotalVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lbTituloTotalVenda.Location = new System.Drawing.Point(420, 55);
            this.lbTituloTotalVenda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTituloTotalVenda.Name = "lbTituloTotalVenda";
            this.lbTituloTotalVenda.Size = new System.Drawing.Size(167, 19);
            this.lbTituloTotalVenda.TabIndex = 232;
            this.lbTituloTotalVenda.Text = "Movimentação Caixa";
            this.lbTituloTotalVenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Apresentacao.Properties.Resources.DialogVenda;
            this.pictureBox1.Location = new System.Drawing.Point(384, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 248;
            this.pictureBox1.TabStop = false;
            // 
            // Caixa
            // 
            this.Caixa.DataPropertyName = "caixaUsuario";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Caixa.DefaultCellStyle = dataGridViewCellStyle3;
            this.Caixa.HeaderText = "Caixa";
            this.Caixa.Name = "Caixa";
            this.Caixa.ReadOnly = true;
            this.Caixa.ToolTipText = "Total do Caixa";
            // 
            // valorRealCaixa
            // 
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.valorRealCaixa.DefaultCellStyle = dataGridViewCellStyle4;
            this.valorRealCaixa.HeaderText = "Recebimento";
            this.valorRealCaixa.Name = "valorRealCaixa";
            // 
            // SangriaCaixa
            // 
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.SangriaCaixa.DefaultCellStyle = dataGridViewCellStyle5;
            this.SangriaCaixa.HeaderText = "Sangria";
            this.SangriaCaixa.Name = "SangriaCaixa";
            this.SangriaCaixa.ReadOnly = true;
            // 
            // formaPagamentoCaixa
            // 
            this.formaPagamentoCaixa.HeaderText = "Pagamento";
            this.formaPagamentoCaixa.Name = "formaPagamentoCaixa";
            this.formaPagamentoCaixa.ReadOnly = true;
            this.formaPagamentoCaixa.ToolTipText = "Forma de Pagamento";
            // 
            // estornoCaixa
            // 
            this.estornoCaixa.HeaderText = "Estorno";
            this.estornoCaixa.Name = "estornoCaixa";
            // 
            // FrmCadastrarDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(945, 369);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbTituloTotalVenda);
            this.Controls.Add(this.dgvCaixa);
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
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadastrarDespesa_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbDespesa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDespesa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ErrorProvider epDespesa;
        private System.Windows.Forms.DataGridView dgvCaixa;
        private System.Windows.Forms.Label lbTituloTotalVenda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorRealCaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn SangriaCaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaPagamentoCaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn estornoCaixa;
    }
}