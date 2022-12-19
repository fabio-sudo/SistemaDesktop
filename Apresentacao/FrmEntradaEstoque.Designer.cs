namespace Apresentacao
{
    partial class FrmEntradaEstoque
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntradaEstoque));
            this.dgvEntradaEstoque = new System.Windows.Forms.DataGridView();
            this.codigoEntradaEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaFiscalEntradaEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorEntradaEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeEntradaEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalEntradaEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEntradaEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbFornecedor = new System.Windows.Forms.Label();
            this.lbNotaFiscal = new System.Windows.Forms.Label();
            this.tbNotaFiscal = new System.Windows.Forms.TextBox();
            this.tbFornecedor = new System.Windows.Forms.TextBox();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.lbDataInicial = new System.Windows.Forms.Label();
            this.lbDataFinal = new System.Windows.Forms.Label();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btSelecionar = new System.Windows.Forms.Button();
            this.pbFiltrar = new System.Windows.Forms.PictureBox();
            this.pbBuscarFornecedor = new System.Windows.Forms.PictureBox();
            this.pbEntradaEstoque = new System.Windows.Forms.PictureBox();
            this.btSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradaEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiltrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEntradaEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEntradaEstoque
            // 
            this.dgvEntradaEstoque.AllowUserToAddRows = false;
            this.dgvEntradaEstoque.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dgvEntradaEstoque.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEntradaEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEntradaEstoque.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntradaEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEntradaEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntradaEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoEntradaEstoque,
            this.notaFiscalEntradaEstoque,
            this.fornecedorEntradaEstoque,
            this.quantidadeEntradaEstoque,
            this.totalEntradaEstoque,
            this.dataEntradaEstoque,
            this.estatusEntrada});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEntradaEstoque.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEntradaEstoque.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvEntradaEstoque.Location = new System.Drawing.Point(12, 84);
            this.dgvEntradaEstoque.Name = "dgvEntradaEstoque";
            this.dgvEntradaEstoque.ReadOnly = true;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.dgvEntradaEstoque.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvEntradaEstoque.RowTemplate.Height = 24;
            this.dgvEntradaEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntradaEstoque.Size = new System.Drawing.Size(1272, 560);
            this.dgvEntradaEstoque.TabIndex = 8;
            this.dgvEntradaEstoque.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntradaEstoque_CellDoubleClick);
            // 
            // codigoEntradaEstoque
            // 
            this.codigoEntradaEstoque.HeaderText = "Cód";
            this.codigoEntradaEstoque.Name = "codigoEntradaEstoque";
            this.codigoEntradaEstoque.ReadOnly = true;
            // 
            // notaFiscalEntradaEstoque
            // 
            this.notaFiscalEntradaEstoque.HeaderText = "Nota Fiscal";
            this.notaFiscalEntradaEstoque.Name = "notaFiscalEntradaEstoque";
            this.notaFiscalEntradaEstoque.ReadOnly = true;
            this.notaFiscalEntradaEstoque.Width = 150;
            // 
            // fornecedorEntradaEstoque
            // 
            this.fornecedorEntradaEstoque.HeaderText = "Fornecedor";
            this.fornecedorEntradaEstoque.Name = "fornecedorEntradaEstoque";
            this.fornecedorEntradaEstoque.ReadOnly = true;
            this.fornecedorEntradaEstoque.Width = 220;
            // 
            // quantidadeEntradaEstoque
            // 
            this.quantidadeEntradaEstoque.HeaderText = "Volume";
            this.quantidadeEntradaEstoque.Name = "quantidadeEntradaEstoque";
            this.quantidadeEntradaEstoque.ReadOnly = true;
            this.quantidadeEntradaEstoque.Width = 120;
            // 
            // totalEntradaEstoque
            // 
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.totalEntradaEstoque.DefaultCellStyle = dataGridViewCellStyle3;
            this.totalEntradaEstoque.HeaderText = "Total R$";
            this.totalEntradaEstoque.Name = "totalEntradaEstoque";
            this.totalEntradaEstoque.ReadOnly = true;
            this.totalEntradaEstoque.Width = 120;
            // 
            // dataEntradaEstoque
            // 
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.dataEntradaEstoque.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataEntradaEstoque.HeaderText = "Data";
            this.dataEntradaEstoque.Name = "dataEntradaEstoque";
            this.dataEntradaEstoque.ReadOnly = true;
            this.dataEntradaEstoque.Width = 120;
            // 
            // estatusEntrada
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.estatusEntrada.DefaultCellStyle = dataGridViewCellStyle5;
            this.estatusEntrada.HeaderText = "Estatus";
            this.estatusEntrada.Name = "estatusEntrada";
            this.estatusEntrada.ReadOnly = true;
            this.estatusEntrada.ToolTipText = "Estatus Entrada de Estoque";
            // 
            // lbFornecedor
            // 
            this.lbFornecedor.AutoSize = true;
            this.lbFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbFornecedor.Location = new System.Drawing.Point(89, 56);
            this.lbFornecedor.Name = "lbFornecedor";
            this.lbFornecedor.Size = new System.Drawing.Size(94, 20);
            this.lbFornecedor.TabIndex = 2;
            this.lbFornecedor.Text = "Fornecedor";
            // 
            // lbNotaFiscal
            // 
            this.lbNotaFiscal.AutoSize = true;
            this.lbNotaFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbNotaFiscal.Location = new System.Drawing.Point(89, 21);
            this.lbNotaFiscal.Name = "lbNotaFiscal";
            this.lbNotaFiscal.Size = new System.Drawing.Size(94, 20);
            this.lbNotaFiscal.TabIndex = 0;
            this.lbNotaFiscal.Text = "Nota Fiscal";
            // 
            // tbNotaFiscal
            // 
            this.tbNotaFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbNotaFiscal.Location = new System.Drawing.Point(197, 14);
            this.tbNotaFiscal.Name = "tbNotaFiscal";
            this.tbNotaFiscal.Size = new System.Drawing.Size(100, 27);
            this.tbNotaFiscal.TabIndex = 1;
            this.tbNotaFiscal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNotaFiscal_KeyPress);
            // 
            // tbFornecedor
            // 
            this.tbFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbFornecedor.Location = new System.Drawing.Point(197, 49);
            this.tbFornecedor.Name = "tbFornecedor";
            this.tbFornecedor.Size = new System.Drawing.Size(255, 27);
            this.tbFornecedor.TabIndex = 3;
            this.tbFornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFornecedor_KeyPress);
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(844, 51);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(200, 27);
            this.dtpDataInicial.TabIndex = 5;
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(1051, 51);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(200, 27);
            this.dtpDataFinal.TabIndex = 7;
            // 
            // lbDataInicial
            // 
            this.lbDataInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDataInicial.AutoSize = true;
            this.lbDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDataInicial.Location = new System.Drawing.Point(840, 28);
            this.lbDataInicial.Name = "lbDataInicial";
            this.lbDataInicial.Size = new System.Drawing.Size(93, 20);
            this.lbDataInicial.TabIndex = 4;
            this.lbDataInicial.Text = "Data Inicial";
            // 
            // lbDataFinal
            // 
            this.lbDataFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDataFinal.AutoSize = true;
            this.lbDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDataFinal.Location = new System.Drawing.Point(1047, 28);
            this.lbDataFinal.Name = "lbDataFinal";
            this.lbDataFinal.Size = new System.Drawing.Size(86, 20);
            this.lbDataFinal.TabIndex = 6;
            this.lbDataFinal.Text = "Data Final";
            // 
            // btBuscar
            // 
            this.btBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btBuscar.FlatAppearance.BorderSize = 0;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBuscar.Location = new System.Drawing.Point(12, 650);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(130, 42);
            this.btBuscar.TabIndex = 9;
            this.btBuscar.Text = "F5 Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCadastrar.BackColor = System.Drawing.Color.Turquoise;
            this.btCadastrar.FlatAppearance.BorderSize = 0;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCadastrar.Location = new System.Drawing.Point(148, 650);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(130, 42);
            this.btCadastrar.TabIndex = 10;
            this.btCadastrar.Text = "F10 Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btSelecionar
            // 
            this.btSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSelecionar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btSelecionar.FlatAppearance.BorderSize = 0;
            this.btSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSelecionar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSelecionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSelecionar.Location = new System.Drawing.Point(284, 650);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(130, 42);
            this.btSelecionar.TabIndex = 11;
            this.btSelecionar.Text = "F2 Selecionar";
            this.btSelecionar.UseVisualStyleBackColor = false;
            this.btSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            // 
            // pbFiltrar
            // 
            this.pbFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFiltrar.Image = global::Apresentacao.Properties.Resources.FiltroImg;
            this.pbFiltrar.Location = new System.Drawing.Point(1257, 51);
            this.pbFiltrar.Name = "pbFiltrar";
            this.pbFiltrar.Size = new System.Drawing.Size(27, 27);
            this.pbFiltrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFiltrar.TabIndex = 11;
            this.pbFiltrar.TabStop = false;
            this.pbFiltrar.Click += new System.EventHandler(this.pbFiltrar_Click);
            // 
            // pbBuscarFornecedor
            // 
            this.pbBuscarFornecedor.Image = global::Apresentacao.Properties.Resources.FornecedorLogoBotao;
            this.pbBuscarFornecedor.Location = new System.Drawing.Point(458, 49);
            this.pbBuscarFornecedor.Name = "pbBuscarFornecedor";
            this.pbBuscarFornecedor.Size = new System.Drawing.Size(27, 27);
            this.pbBuscarFornecedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscarFornecedor.TabIndex = 10;
            this.pbBuscarFornecedor.TabStop = false;
            this.pbBuscarFornecedor.Click += new System.EventHandler(this.pbBuscarFornecedor_Click);
            // 
            // pbEntradaEstoque
            // 
            this.pbEntradaEstoque.Image = global::Apresentacao.Properties.Resources.EntradaEstoqueIco;
            this.pbEntradaEstoque.Location = new System.Drawing.Point(12, 12);
            this.pbEntradaEstoque.Name = "pbEntradaEstoque";
            this.pbEntradaEstoque.Size = new System.Drawing.Size(71, 64);
            this.pbEntradaEstoque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEntradaEstoque.TabIndex = 1;
            this.pbEntradaEstoque.TabStop = false;
            // 
            // btSair
            // 
            this.btSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSair.BackColor = System.Drawing.Color.Red;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSair.Location = new System.Drawing.Point(1154, 650);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(130, 42);
            this.btSair.TabIndex = 12;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // FrmEntradaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1304, 710);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.dtpDataInicial);
            this.Controls.Add(this.dtpDataFinal);
            this.Controls.Add(this.pbFiltrar);
            this.Controls.Add(this.lbDataInicial);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.lbDataFinal);
            this.Controls.Add(this.pbBuscarFornecedor);
            this.Controls.Add(this.tbFornecedor);
            this.Controls.Add(this.tbNotaFiscal);
            this.Controls.Add(this.lbNotaFiscal);
            this.Controls.Add(this.lbFornecedor);
            this.Controls.Add(this.pbEntradaEstoque);
            this.Controls.Add(this.dgvEntradaEstoque);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmEntradaEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada De Estoque";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmEntradaEstoque_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmEntradaEstoque_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradaEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiltrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEntradaEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEntradaEstoque;
        private System.Windows.Forms.PictureBox pbEntradaEstoque;
        private System.Windows.Forms.Label lbFornecedor;
        private System.Windows.Forms.Label lbNotaFiscal;
        private System.Windows.Forms.TextBox tbNotaFiscal;
        private System.Windows.Forms.TextBox tbFornecedor;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.Label lbDataInicial;
        private System.Windows.Forms.Label lbDataFinal;
        private System.Windows.Forms.PictureBox pbBuscarFornecedor;
        private System.Windows.Forms.PictureBox pbFiltrar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btSelecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEntradaEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaFiscalEntradaEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedorEntradaEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeEntradaEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalEntradaEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEntradaEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusEntrada;
        private System.Windows.Forms.Button btSair;
    }
}