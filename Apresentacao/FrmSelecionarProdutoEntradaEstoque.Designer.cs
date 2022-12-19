namespace Apresentacao
{
    partial class FrmSelecionarProdutoEntradaEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelecionarProdutoEntradaEstoque));
            this.btSair = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btSelecionar = new System.Windows.Forms.Button();
            this.tbDescricaoProduto = new System.Windows.Forms.TextBox();
            this.tbCodigoProduto = new System.Windows.Forms.TextBox();
            this.lbCodigoProduto = new System.Windows.Forms.Label();
            this.lbDescricaoProduto = new System.Windows.Forms.Label();
            this.pbEntradaEstoque = new System.Windows.Forms.PictureBox();
            this.dgvEntradaEstoque = new System.Windows.Forms.DataGridView();
            this.codigoEntradaEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaFiscalEntradaEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorEntradaEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeEntradaEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalEntradaEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEntradaEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbImagemProduto = new System.Windows.Forms.PictureBox();
            this.lbReferencia = new System.Windows.Forms.Label();
            this.lbCor = new System.Windows.Forms.Label();
            this.tbReferencia = new System.Windows.Forms.TextBox();
            this.tbCor = new System.Windows.Forms.TextBox();
            this.tbGrade = new System.Windows.Forms.TextBox();
            this.lbGrade = new System.Windows.Forms.Label();
            this.tbGenero = new System.Windows.Forms.TextBox();
            this.lbGenero = new System.Windows.Forms.Label();
            this.tbTamanho = new System.Windows.Forms.TextBox();
            this.lbTamanho = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbEntradaEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradaEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSair.BackColor = System.Drawing.Color.Red;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSair.Location = new System.Drawing.Point(1106, 653);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(130, 42);
            this.btSair.TabIndex = 11;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCadastrar.BackColor = System.Drawing.Color.Turquoise;
            this.btCadastrar.FlatAppearance.BorderSize = 0;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCadastrar.Location = new System.Drawing.Point(152, 653);
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
            this.btSelecionar.Location = new System.Drawing.Point(16, 653);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(130, 42);
            this.btSelecionar.TabIndex = 9;
            this.btSelecionar.Text = "F2 Selecionar";
            this.btSelecionar.UseVisualStyleBackColor = false;
            this.btSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            // 
            // tbDescricaoProduto
            // 
            this.tbDescricaoProduto.Enabled = false;
            this.tbDescricaoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbDescricaoProduto.Location = new System.Drawing.Point(170, 54);
            this.tbDescricaoProduto.Name = "tbDescricaoProduto";
            this.tbDescricaoProduto.Size = new System.Drawing.Size(288, 27);
            this.tbDescricaoProduto.TabIndex = 3;
            // 
            // tbCodigoProduto
            // 
            this.tbCodigoProduto.Enabled = false;
            this.tbCodigoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbCodigoProduto.Location = new System.Drawing.Point(93, 54);
            this.tbCodigoProduto.Name = "tbCodigoProduto";
            this.tbCodigoProduto.Size = new System.Drawing.Size(71, 27);
            this.tbCodigoProduto.TabIndex = 1;
            // 
            // lbCodigoProduto
            // 
            this.lbCodigoProduto.AutoSize = true;
            this.lbCodigoProduto.Font = new System.Drawing.Font("Segoe Marker", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbCodigoProduto.Location = new System.Drawing.Point(93, 29);
            this.lbCodigoProduto.Name = "lbCodigoProduto";
            this.lbCodigoProduto.Size = new System.Drawing.Size(59, 20);
            this.lbCodigoProduto.TabIndex = 0;
            this.lbCodigoProduto.Text = "Código";
            // 
            // lbDescricaoProduto
            // 
            this.lbDescricaoProduto.AutoSize = true;
            this.lbDescricaoProduto.Font = new System.Drawing.Font("Segoe Marker", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbDescricaoProduto.Location = new System.Drawing.Point(166, 29);
            this.lbDescricaoProduto.Name = "lbDescricaoProduto";
            this.lbDescricaoProduto.Size = new System.Drawing.Size(77, 20);
            this.lbDescricaoProduto.TabIndex = 2;
            this.lbDescricaoProduto.Text = "Descrição";
            // 
            // pbEntradaEstoque
            // 
            this.pbEntradaEstoque.Image = global::Apresentacao.Properties.Resources.EntradaEstoqueIco;
            this.pbEntradaEstoque.Location = new System.Drawing.Point(16, 15);
            this.pbEntradaEstoque.Name = "pbEntradaEstoque";
            this.pbEntradaEstoque.Size = new System.Drawing.Size(71, 64);
            this.pbEntradaEstoque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEntradaEstoque.TabIndex = 15;
            this.pbEntradaEstoque.TabStop = false;
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
            this.dgvEntradaEstoque.Location = new System.Drawing.Point(16, 87);
            this.dgvEntradaEstoque.Name = "dgvEntradaEstoque";
            this.dgvEntradaEstoque.ReadOnly = true;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.dgvEntradaEstoque.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvEntradaEstoque.RowTemplate.Height = 24;
            this.dgvEntradaEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntradaEstoque.Size = new System.Drawing.Size(1220, 560);
            this.dgvEntradaEstoque.TabIndex = 8;
            this.dgvEntradaEstoque.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntradaEstoque_CellDoubleClick);
            // 
            // codigoEntradaEstoque
            // 
            this.codigoEntradaEstoque.HeaderText = "Cód";
            this.codigoEntradaEstoque.Name = "codigoEntradaEstoque";
            this.codigoEntradaEstoque.ReadOnly = true;
            this.codigoEntradaEstoque.Width = 50;
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
            // pbImagemProduto
            // 
            this.pbImagemProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImagemProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagemProduto.Image = global::Apresentacao.Properties.Resources.imgDefaut;
            this.pbImagemProduto.Location = new System.Drawing.Point(1087, -1);
            this.pbImagemProduto.Name = "pbImagemProduto";
            this.pbImagemProduto.Size = new System.Drawing.Size(149, 82);
            this.pbImagemProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagemProduto.TabIndex = 88;
            this.pbImagemProduto.TabStop = false;
            // 
            // lbReferencia
            // 
            this.lbReferencia.AutoSize = true;
            this.lbReferencia.Font = new System.Drawing.Font("Segoe Marker", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbReferencia.Location = new System.Drawing.Point(460, 29);
            this.lbReferencia.Name = "lbReferencia";
            this.lbReferencia.Size = new System.Drawing.Size(83, 20);
            this.lbReferencia.TabIndex = 4;
            this.lbReferencia.Text = "Referência";
            // 
            // lbCor
            // 
            this.lbCor.AutoSize = true;
            this.lbCor.Font = new System.Drawing.Font("Segoe Marker", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbCor.Location = new System.Drawing.Point(937, 29);
            this.lbCor.Name = "lbCor";
            this.lbCor.Size = new System.Drawing.Size(33, 20);
            this.lbCor.TabIndex = 6;
            this.lbCor.Text = "Cor";
            // 
            // tbReferencia
            // 
            this.tbReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbReferencia.Enabled = false;
            this.tbReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbReferencia.Location = new System.Drawing.Point(464, 54);
            this.tbReferencia.Name = "tbReferencia";
            this.tbReferencia.Size = new System.Drawing.Size(85, 27);
            this.tbReferencia.TabIndex = 5;
            // 
            // tbCor
            // 
            this.tbCor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCor.Enabled = false;
            this.tbCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbCor.Location = new System.Drawing.Point(941, 54);
            this.tbCor.Name = "tbCor";
            this.tbCor.Size = new System.Drawing.Size(115, 27);
            this.tbCor.TabIndex = 7;
            // 
            // tbGrade
            // 
            this.tbGrade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbGrade.Enabled = false;
            this.tbGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbGrade.Location = new System.Drawing.Point(671, 54);
            this.tbGrade.Name = "tbGrade";
            this.tbGrade.Size = new System.Drawing.Size(142, 27);
            this.tbGrade.TabIndex = 90;
            // 
            // lbGrade
            // 
            this.lbGrade.AutoSize = true;
            this.lbGrade.Font = new System.Drawing.Font("Segoe Marker", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbGrade.Location = new System.Drawing.Point(667, 29);
            this.lbGrade.Name = "lbGrade";
            this.lbGrade.Size = new System.Drawing.Size(50, 20);
            this.lbGrade.TabIndex = 89;
            this.lbGrade.Text = "Grade";
            // 
            // tbGenero
            // 
            this.tbGenero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbGenero.Enabled = false;
            this.tbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbGenero.Location = new System.Drawing.Point(555, 54);
            this.tbGenero.Name = "tbGenero";
            this.tbGenero.Size = new System.Drawing.Size(110, 27);
            this.tbGenero.TabIndex = 91;
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.Font = new System.Drawing.Font("Segoe Marker", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbGenero.Location = new System.Drawing.Point(551, 29);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(59, 20);
            this.lbGenero.TabIndex = 92;
            this.lbGenero.Text = "Gênero";
            // 
            // tbTamanho
            // 
            this.tbTamanho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbTamanho.Enabled = false;
            this.tbTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbTamanho.Location = new System.Drawing.Point(819, 54);
            this.tbTamanho.Name = "tbTamanho";
            this.tbTamanho.Size = new System.Drawing.Size(115, 27);
            this.tbTamanho.TabIndex = 94;
            // 
            // lbTamanho
            // 
            this.lbTamanho.AutoSize = true;
            this.lbTamanho.Font = new System.Drawing.Font("Segoe Marker", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbTamanho.Location = new System.Drawing.Point(815, 29);
            this.lbTamanho.Name = "lbTamanho";
            this.lbTamanho.Size = new System.Drawing.Size(73, 20);
            this.lbTamanho.TabIndex = 93;
            this.lbTamanho.Text = "Tamanho";
            // 
            // FrmSelecionarProdutoEntradaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1252, 710);
            this.Controls.Add(this.tbTamanho);
            this.Controls.Add(this.lbTamanho);
            this.Controls.Add(this.lbGenero);
            this.Controls.Add(this.tbGenero);
            this.Controls.Add(this.tbGrade);
            this.Controls.Add(this.lbGrade);
            this.Controls.Add(this.tbCor);
            this.Controls.Add(this.tbReferencia);
            this.Controls.Add(this.lbCor);
            this.Controls.Add(this.lbReferencia);
            this.Controls.Add(this.pbImagemProduto);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.tbDescricaoProduto);
            this.Controls.Add(this.tbCodigoProduto);
            this.Controls.Add(this.lbCodigoProduto);
            this.Controls.Add(this.lbDescricaoProduto);
            this.Controls.Add(this.pbEntradaEstoque);
            this.Controls.Add(this.dgvEntradaEstoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmSelecionarProdutoEntradaEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Produto Entrada Estoque";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSelecionarProdutoEntradaEstoque_FormClosed);
            this.Load += new System.EventHandler(this.FrmSelecionarProdutoEntradaEstoque_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSelecionarProdutoEntradaEstoque_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbEntradaEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradaEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btSelecionar;
        private System.Windows.Forms.TextBox tbDescricaoProduto;
        private System.Windows.Forms.TextBox tbCodigoProduto;
        private System.Windows.Forms.Label lbCodigoProduto;
        private System.Windows.Forms.Label lbDescricaoProduto;
        private System.Windows.Forms.PictureBox pbEntradaEstoque;
        private System.Windows.Forms.DataGridView dgvEntradaEstoque;
        private System.Windows.Forms.PictureBox pbImagemProduto;
        private System.Windows.Forms.Label lbReferencia;
        private System.Windows.Forms.Label lbCor;
        private System.Windows.Forms.TextBox tbReferencia;
        private System.Windows.Forms.TextBox tbCor;
        private System.Windows.Forms.TextBox tbGrade;
        private System.Windows.Forms.Label lbGrade;
        private System.Windows.Forms.TextBox tbGenero;
        private System.Windows.Forms.Label lbGenero;
        private System.Windows.Forms.TextBox tbTamanho;
        private System.Windows.Forms.Label lbTamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEntradaEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaFiscalEntradaEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedorEntradaEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeEntradaEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalEntradaEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEntradaEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusEntrada;
    }
}