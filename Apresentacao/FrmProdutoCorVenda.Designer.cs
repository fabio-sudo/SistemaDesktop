namespace Apresentacao
{
    partial class FrmProdutoCorVenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdutoCorVenda));
            this.btSelecionar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.btAvancar = new System.Windows.Forms.Button();
            this.tbProduto = new System.Windows.Forms.TextBox();
            this.dgvProdutoCor = new System.Windows.Forms.DataGridView();
            this.codigoProdutoCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagemProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBuscarProduto = new System.Windows.Forms.Panel();
            this.pbImagemProduto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutoCor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // btSelecionar
            // 
            this.btSelecionar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btSelecionar.FlatAppearance.BorderSize = 0;
            this.btSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSelecionar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSelecionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSelecionar.Location = new System.Drawing.Point(17, 672);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(130, 42);
            this.btSelecionar.TabIndex = 5;
            this.btSelecionar.Text = "&Ent Selecionar";
            this.btSelecionar.UseVisualStyleBackColor = false;
            this.btSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.DeepPink;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSair.Location = new System.Drawing.Point(285, 672);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(130, 42);
            this.btSair.TabIndex = 6;
            this.btSair.Text = "&Esc Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btVoltar.FlatAppearance.BorderSize = 0;
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltar.Image = global::Apresentacao.Properties.Resources.Voltar;
            this.btVoltar.Location = new System.Drawing.Point(25, 88);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(75, 69);
            this.btVoltar.TabIndex = 3;
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // btAvancar
            // 
            this.btAvancar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAvancar.FlatAppearance.BorderSize = 0;
            this.btAvancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAvancar.Image = global::Apresentacao.Properties.Resources.Avancar;
            this.btAvancar.Location = new System.Drawing.Point(332, 88);
            this.btAvancar.Name = "btAvancar";
            this.btAvancar.Size = new System.Drawing.Size(75, 69);
            this.btAvancar.TabIndex = 4;
            this.btAvancar.UseVisualStyleBackColor = true;
            this.btAvancar.Click += new System.EventHandler(this.btAvancar_Click);
            // 
            // tbProduto
            // 
            this.tbProduto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbProduto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tbProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbProduto.Location = new System.Drawing.Point(16, 238);
            this.tbProduto.Name = "tbProduto";
            this.tbProduto.ReadOnly = true;
            this.tbProduto.Size = new System.Drawing.Size(399, 23);
            this.tbProduto.TabIndex = 2;
            this.tbProduto.Text = "Descrição do Produto";
            this.tbProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvProdutoCor
            // 
            this.dgvProdutoCor.AllowUserToAddRows = false;
            this.dgvProdutoCor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dgvProdutoCor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdutoCor.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutoCor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProdutoCor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutoCor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoProdutoCor,
            this.codigoCor,
            this.corProduto,
            this.imagemProduto});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdutoCor.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProdutoCor.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvProdutoCor.Location = new System.Drawing.Point(16, 274);
            this.dgvProdutoCor.Name = "dgvProdutoCor";
            this.dgvProdutoCor.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.dgvProdutoCor.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProdutoCor.RowTemplate.Height = 24;
            this.dgvProdutoCor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutoCor.Size = new System.Drawing.Size(399, 392);
            this.dgvProdutoCor.TabIndex = 0;
            this.dgvProdutoCor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutoCor_CellClick);
            this.dgvProdutoCor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutoCor_CellDoubleClick);
            // 
            // codigoProdutoCor
            // 
            this.codigoProdutoCor.HeaderText = "Cód";
            this.codigoProdutoCor.Name = "codigoProdutoCor";
            this.codigoProdutoCor.ReadOnly = true;
            this.codigoProdutoCor.ToolTipText = "Código do Item Selecionado";
            this.codigoProdutoCor.Visible = false;
            // 
            // codigoCor
            // 
            this.codigoCor.HeaderText = "Cód";
            this.codigoCor.Name = "codigoCor";
            this.codigoCor.ReadOnly = true;
            this.codigoCor.ToolTipText = "Código da Cor ";
            // 
            // corProduto
            // 
            this.corProduto.HeaderText = "Cor";
            this.corProduto.Name = "corProduto";
            this.corProduto.ReadOnly = true;
            this.corProduto.ToolTipText = "Cor do Produto";
            this.corProduto.Width = 150;
            // 
            // imagemProduto
            // 
            this.imagemProduto.HeaderText = "Imagem";
            this.imagemProduto.Name = "imagemProduto";
            this.imagemProduto.ReadOnly = true;
            this.imagemProduto.Visible = false;
            // 
            // panelBuscarProduto
            // 
            this.panelBuscarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelBuscarProduto.Location = new System.Drawing.Point(17, 265);
            this.panelBuscarProduto.Name = "panelBuscarProduto";
            this.panelBuscarProduto.Size = new System.Drawing.Size(400, 3);
            this.panelBuscarProduto.TabIndex = 1;
            // 
            // pbImagemProduto
            // 
            this.pbImagemProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagemProduto.Image = global::Apresentacao.Properties.Resources.imgDefaut;
            this.pbImagemProduto.Location = new System.Drawing.Point(106, 12);
            this.pbImagemProduto.Name = "pbImagemProduto";
            this.pbImagemProduto.Size = new System.Drawing.Size(220, 220);
            this.pbImagemProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagemProduto.TabIndex = 37;
            this.pbImagemProduto.TabStop = false;
            // 
            // FrmProdutoCorVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(436, 732);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btAvancar);
            this.Controls.Add(this.tbProduto);
            this.Controls.Add(this.dgvProdutoCor);
            this.Controls.Add(this.panelBuscarProduto);
            this.Controls.Add(this.pbImagemProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmProdutoCorVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Código+Referência";
            this.Load += new System.EventHandler(this.FrmProdutoCorVenda_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmProdutoCorVenda_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutoCor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSelecionar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button btAvancar;
        private System.Windows.Forms.TextBox tbProduto;
        private System.Windows.Forms.DataGridView dgvProdutoCor;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProdutoCor;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoCor;
        private System.Windows.Forms.DataGridViewTextBoxColumn corProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagemProduto;
        private System.Windows.Forms.Panel panelBuscarProduto;
        private System.Windows.Forms.PictureBox pbImagemProduto;
    }
}