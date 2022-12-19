namespace Apresentacao
{
    partial class FrmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduto));
            this.tbBuscarProduto = new System.Windows.Forms.TextBox();
            this.panelBuscarProduto = new System.Windows.Forms.Panel();
            this.btBuscar = new System.Windows.Forms.Button();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.codigoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenciaProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoCustoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoVendaProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btSelecionar = new System.Windows.Forms.Button();
            this.pbImagemZoom = new System.Windows.Forms.PictureBox();
            this.pbImagemProduto = new System.Windows.Forms.PictureBox();
            this.btVoltar = new System.Windows.Forms.Button();
            this.btAvancar = new System.Windows.Forms.Button();
            this.pbProduto = new System.Windows.Forms.PictureBox();
            this.btCodigoBarras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // tbBuscarProduto
            // 
            this.tbBuscarProduto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbBuscarProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBuscarProduto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tbBuscarProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbBuscarProduto.Location = new System.Drawing.Point(51, 47);
            this.tbBuscarProduto.Name = "tbBuscarProduto";
            this.tbBuscarProduto.Size = new System.Drawing.Size(343, 23);
            this.tbBuscarProduto.TabIndex = 0;
            this.tbBuscarProduto.Text = "Digite a descrição do produto ...";
            this.tbBuscarProduto.Enter += new System.EventHandler(this.tbBuscarProduto_Enter);
            this.tbBuscarProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscarProduto_KeyPress);
            this.tbBuscarProduto.Leave += new System.EventHandler(this.tbBuscarProduto_Leave);
            // 
            // panelBuscarProduto
            // 
            this.panelBuscarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelBuscarProduto.Location = new System.Drawing.Point(11, 70);
            this.panelBuscarProduto.Name = "panelBuscarProduto";
            this.panelBuscarProduto.Size = new System.Drawing.Size(383, 2);
            this.panelBuscarProduto.TabIndex = 2;
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btBuscar.FlatAppearance.BorderSize = 0;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBuscar.Location = new System.Drawing.Point(400, 32);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(130, 42);
            this.btBuscar.TabIndex = 1;
            this.btBuscar.Text = "F5 Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dgvProduto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduto.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoProduto,
            this.descricaoProduto,
            this.referenciaProduto,
            this.sexoProduto,
            this.generoProduto,
            this.gradeProduto,
            this.fornecedorProduto,
            this.quantidadeProduto,
            this.precoCustoProduto,
            this.precoVendaProduto,
            this.dataProduto});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduto.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProduto.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvProduto.Location = new System.Drawing.Point(12, 80);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.dgvProduto.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProduto.RowTemplate.Height = 24;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(1080, 563);
            this.dgvProduto.TabIndex = 3;
            this.dgvProduto.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProduto_CellMouseClick);
            this.dgvProduto.DoubleClick += new System.EventHandler(this.dgvProduto_DoubleClick);
            // 
            // codigoProduto
            // 
            this.codigoProduto.HeaderText = "Cód";
            this.codigoProduto.Name = "codigoProduto";
            this.codigoProduto.ReadOnly = true;
            this.codigoProduto.ToolTipText = "Código do Produto";
            this.codigoProduto.Width = 50;
            // 
            // descricaoProduto
            // 
            this.descricaoProduto.HeaderText = "Descrição";
            this.descricaoProduto.Name = "descricaoProduto";
            this.descricaoProduto.ReadOnly = true;
            this.descricaoProduto.ToolTipText = "Descrição do Produto";
            this.descricaoProduto.Width = 300;
            // 
            // referenciaProduto
            // 
            this.referenciaProduto.HeaderText = "Referência";
            this.referenciaProduto.Name = "referenciaProduto";
            this.referenciaProduto.ReadOnly = true;
            this.referenciaProduto.ToolTipText = "Referência do Produto";
            this.referenciaProduto.Width = 130;
            // 
            // sexoProduto
            // 
            this.sexoProduto.HeaderText = "Sexo";
            this.sexoProduto.Name = "sexoProduto";
            this.sexoProduto.ReadOnly = true;
            this.sexoProduto.ToolTipText = "Sexo do Produto";
            this.sexoProduto.Width = 110;
            // 
            // generoProduto
            // 
            this.generoProduto.HeaderText = "Gênero";
            this.generoProduto.Name = "generoProduto";
            this.generoProduto.ReadOnly = true;
            this.generoProduto.ToolTipText = "Gênero do Produto";
            this.generoProduto.Width = 120;
            // 
            // gradeProduto
            // 
            this.gradeProduto.HeaderText = "Grade";
            this.gradeProduto.Name = "gradeProduto";
            this.gradeProduto.ReadOnly = true;
            this.gradeProduto.ToolTipText = "Grade do Produto";
            // 
            // fornecedorProduto
            // 
            this.fornecedorProduto.HeaderText = "Fornecedor";
            this.fornecedorProduto.Name = "fornecedorProduto";
            this.fornecedorProduto.ReadOnly = true;
            this.fornecedorProduto.ToolTipText = "Nome Fantasia do Fornecedor";
            this.fornecedorProduto.Width = 180;
            // 
            // quantidadeProduto
            // 
            this.quantidadeProduto.HeaderText = "Quantidade";
            this.quantidadeProduto.Name = "quantidadeProduto";
            this.quantidadeProduto.ReadOnly = true;
            this.quantidadeProduto.ToolTipText = "Quantidade do Produto";
            // 
            // precoCustoProduto
            // 
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.precoCustoProduto.DefaultCellStyle = dataGridViewCellStyle3;
            this.precoCustoProduto.HeaderText = "Custo";
            this.precoCustoProduto.Name = "precoCustoProduto";
            this.precoCustoProduto.ReadOnly = true;
            this.precoCustoProduto.ToolTipText = "Preço de Custo do Produto";
            // 
            // precoVendaProduto
            // 
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.precoVendaProduto.DefaultCellStyle = dataGridViewCellStyle4;
            this.precoVendaProduto.HeaderText = "Venda";
            this.precoVendaProduto.Name = "precoVendaProduto";
            this.precoVendaProduto.ReadOnly = true;
            this.precoVendaProduto.ToolTipText = "Preço de Venda do Produto";
            // 
            // dataProduto
            // 
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.dataProduto.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataProduto.HeaderText = "Data";
            this.dataProduto.Name = "dataProduto";
            this.dataProduto.ReadOnly = true;
            this.dataProduto.ToolTipText = "Data do Cadastro do Produto";
            // 
            // btCadastrar
            // 
            this.btCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCadastrar.BackColor = System.Drawing.Color.Turquoise;
            this.btCadastrar.FlatAppearance.BorderSize = 0;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCadastrar.Location = new System.Drawing.Point(12, 649);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(130, 42);
            this.btCadastrar.TabIndex = 4;
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
            this.btSelecionar.Location = new System.Drawing.Point(148, 649);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(130, 42);
            this.btSelecionar.TabIndex = 5;
            this.btSelecionar.Text = "F2 Selecionar";
            this.btSelecionar.UseVisualStyleBackColor = false;
            this.btSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            // 
            // pbImagemZoom
            // 
            this.pbImagemZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImagemZoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagemZoom.Image = global::Apresentacao.Properties.Resources.imgDefaut;
            this.pbImagemZoom.Location = new System.Drawing.Point(715, 80);
            this.pbImagemZoom.Name = "pbImagemZoom";
            this.pbImagemZoom.Size = new System.Drawing.Size(377, 254);
            this.pbImagemZoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagemZoom.TabIndex = 10;
            this.pbImagemZoom.TabStop = false;
            this.pbImagemZoom.Visible = false;
            // 
            // pbImagemProduto
            // 
            this.pbImagemProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImagemProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagemProduto.Image = global::Apresentacao.Properties.Resources.imgDefaut;
            this.pbImagemProduto.Location = new System.Drawing.Point(878, 5);
            this.pbImagemProduto.Name = "pbImagemProduto";
            this.pbImagemProduto.Size = new System.Drawing.Size(132, 69);
            this.pbImagemProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagemProduto.TabIndex = 9;
            this.pbImagemProduto.TabStop = false;
            this.pbImagemProduto.MouseEnter += new System.EventHandler(this.pbImagemProduto_MouseEnter);
            this.pbImagemProduto.MouseLeave += new System.EventHandler(this.pbImagemProduto_MouseLeave);
            // 
            // btVoltar
            // 
            this.btVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btVoltar.Enabled = false;
            this.btVoltar.FlatAppearance.BorderSize = 0;
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltar.Image = global::Apresentacao.Properties.Resources.Voltar;
            this.btVoltar.Location = new System.Drawing.Point(797, 5);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(75, 69);
            this.btVoltar.TabIndex = 6;
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // btAvancar
            // 
            this.btAvancar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAvancar.Enabled = false;
            this.btAvancar.FlatAppearance.BorderSize = 0;
            this.btAvancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAvancar.Image = global::Apresentacao.Properties.Resources.Avancar;
            this.btAvancar.Location = new System.Drawing.Point(1016, 5);
            this.btAvancar.Name = "btAvancar";
            this.btAvancar.Size = new System.Drawing.Size(75, 69);
            this.btAvancar.TabIndex = 7;
            this.btAvancar.UseVisualStyleBackColor = true;
            this.btAvancar.Click += new System.EventHandler(this.btAvancar_Click);
            // 
            // pbProduto
            // 
            this.pbProduto.Image = global::Apresentacao.Properties.Resources.ProdutoAzul;
            this.pbProduto.Location = new System.Drawing.Point(11, 32);
            this.pbProduto.Name = "pbProduto";
            this.pbProduto.Size = new System.Drawing.Size(34, 36);
            this.pbProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProduto.TabIndex = 0;
            this.pbProduto.TabStop = false;
            // 
            // btCodigoBarras
            // 
            this.btCodigoBarras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCodigoBarras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btCodigoBarras.FlatAppearance.BorderSize = 0;
            this.btCodigoBarras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCodigoBarras.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCodigoBarras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCodigoBarras.Location = new System.Drawing.Point(284, 649);
            this.btCodigoBarras.Name = "btCodigoBarras";
            this.btCodigoBarras.Size = new System.Drawing.Size(140, 42);
            this.btCodigoBarras.TabIndex = 124;
            this.btCodigoBarras.Text = "Código Barras";
            this.btCodigoBarras.UseVisualStyleBackColor = false;
            this.btCodigoBarras.Click += new System.EventHandler(this.btCodigoBarras_Click);
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1105, 710);
            this.Controls.Add(this.btCodigoBarras);
            this.Controls.Add(this.pbImagemZoom);
            this.Controls.Add(this.pbImagemProduto);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btAvancar);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.dgvProduto);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.panelBuscarProduto);
            this.Controls.Add(this.tbBuscarProduto);
            this.Controls.Add(this.pbProduto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmProduto_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbProduto;
        private System.Windows.Forms.TextBox tbBuscarProduto;
        private System.Windows.Forms.Panel panelBuscarProduto;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btSelecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenciaProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedorProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoCustoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoVendaProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataProduto;
        private System.Windows.Forms.Button btAvancar;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.PictureBox pbImagemProduto;
        private System.Windows.Forms.PictureBox pbImagemZoom;
        private System.Windows.Forms.Button btCodigoBarras;
    }
}