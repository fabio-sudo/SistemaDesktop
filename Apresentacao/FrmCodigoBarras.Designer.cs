namespace Apresentacao
{
    partial class FrmCodigoBarras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCodigoBarras));
            this.gpPreco = new System.Windows.Forms.GroupBox();
            this.pbPrecos = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbCusto = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbVenda = new System.Windows.Forms.MaskedTextBox();
            this.dgvProdutoCor = new System.Windows.Forms.DataGridView();
            this.codigoEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProdutoCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoTamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanhoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagemProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbBuscarProduto = new System.Windows.Forms.TextBox();
            this.panelBuscarProduto = new System.Windows.Forms.Panel();
            this.pbImagemProduto = new System.Windows.Forms.PictureBox();
            this.pbProduto = new System.Windows.Forms.PictureBox();
            this.pbBarras = new System.Windows.Forms.PictureBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.gpPreco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrecos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutoCor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarras)).BeginInit();
            this.SuspendLayout();
            // 
            // gpPreco
            // 
            this.gpPreco.Controls.Add(this.pbPrecos);
            this.gpPreco.Controls.Add(this.label1);
            this.gpPreco.Controls.Add(this.mtbCusto);
            this.gpPreco.Controls.Add(this.label2);
            this.gpPreco.Controls.Add(this.mtbVenda);
            this.gpPreco.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            this.gpPreco.Location = new System.Drawing.Point(677, 41);
            this.gpPreco.Name = "gpPreco";
            this.gpPreco.Size = new System.Drawing.Size(300, 118);
            this.gpPreco.TabIndex = 2;
            this.gpPreco.TabStop = false;
            this.gpPreco.Text = "Preço do Produto";
            // 
            // pbPrecos
            // 
            this.pbPrecos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPrecos.Image = global::Apresentacao.Properties.Resources.Relogio2;
            this.pbPrecos.Location = new System.Drawing.Point(265, 76);
            this.pbPrecos.Name = "pbPrecos";
            this.pbPrecos.Size = new System.Drawing.Size(27, 27);
            this.pbPrecos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPrecos.TabIndex = 4;
            this.pbPrecos.TabStop = false;
            this.pbPrecos.Click += new System.EventHandler(this.pbPrecos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(2, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Custo R$";
            // 
            // mtbCusto
            // 
            this.mtbCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.mtbCusto.Location = new System.Drawing.Point(6, 76);
            this.mtbCusto.Name = "mtbCusto";
            this.mtbCusto.Size = new System.Drawing.Size(120, 27);
            this.mtbCusto.TabIndex = 1;
            this.mtbCusto.TextChanged += new System.EventHandler(this.mtbCusto_TextChanged);
            this.mtbCusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbCusto_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(133, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Venda R$";
            // 
            // mtbVenda
            // 
            this.mtbVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.mtbVenda.Location = new System.Drawing.Point(137, 76);
            this.mtbVenda.Name = "mtbVenda";
            this.mtbVenda.Size = new System.Drawing.Size(120, 27);
            this.mtbVenda.TabIndex = 3;
            this.mtbVenda.TextChanged += new System.EventHandler(this.mtbVenda_TextChanged);
            this.mtbVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbVenda_KeyPress);
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
            this.codigoEstoque,
            this.codigoProduto,
            this.CodigoProdutoCor,
            this.codigoCor,
            this.corProduto,
            this.codigoTamanho,
            this.tamanhoProduto,
            this.quantidadeEstoque,
            this.precoCusto,
            this.precoVenda,
            this.codigoBarras,
            this.imagemProduto,
            this.contador});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdutoCor.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProdutoCor.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvProdutoCor.Location = new System.Drawing.Point(11, 165);
            this.dgvProdutoCor.Name = "dgvProdutoCor";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.dgvProdutoCor.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProdutoCor.RowTemplate.Height = 24;
            this.dgvProdutoCor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutoCor.Size = new System.Drawing.Size(966, 510);
            this.dgvProdutoCor.TabIndex = 3;
            this.dgvProdutoCor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutoCor_CellClick);
            this.dgvProdutoCor.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvProdutoCor_CellValidating);
            // 
            // codigoEstoque
            // 
            this.codigoEstoque.HeaderText = "Cód";
            this.codigoEstoque.Name = "codigoEstoque";
            this.codigoEstoque.ToolTipText = "Codigo Produto no Estoque";
            this.codigoEstoque.Width = 50;
            // 
            // codigoProduto
            // 
            this.codigoProduto.HeaderText = "CodigoProduto";
            this.codigoProduto.Name = "codigoProduto";
            this.codigoProduto.Visible = false;
            // 
            // CodigoProdutoCor
            // 
            this.CodigoProdutoCor.HeaderText = "codigoProdutoCor";
            this.CodigoProdutoCor.Name = "CodigoProdutoCor";
            this.CodigoProdutoCor.Visible = false;
            // 
            // codigoCor
            // 
            this.codigoCor.HeaderText = "CodigoCor";
            this.codigoCor.Name = "codigoCor";
            this.codigoCor.Visible = false;
            // 
            // corProduto
            // 
            this.corProduto.HeaderText = "Cor";
            this.corProduto.Name = "corProduto";
            this.corProduto.ReadOnly = true;
            this.corProduto.ToolTipText = "Cor do Produto";
            // 
            // codigoTamanho
            // 
            this.codigoTamanho.HeaderText = "CodigoTamanho";
            this.codigoTamanho.Name = "codigoTamanho";
            this.codigoTamanho.ToolTipText = "Código do Tamanho";
            this.codigoTamanho.Visible = false;
            this.codigoTamanho.Width = 50;
            // 
            // tamanhoProduto
            // 
            this.tamanhoProduto.HeaderText = "Tamanho";
            this.tamanhoProduto.Name = "tamanhoProduto";
            this.tamanhoProduto.ReadOnly = true;
            this.tamanhoProduto.ToolTipText = "Tamanho do Produto";
            this.tamanhoProduto.Width = 120;
            // 
            // quantidadeEstoque
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.quantidadeEstoque.DefaultCellStyle = dataGridViewCellStyle3;
            this.quantidadeEstoque.HeaderText = "Estoque";
            this.quantidadeEstoque.Name = "quantidadeEstoque";
            this.quantidadeEstoque.ReadOnly = true;
            this.quantidadeEstoque.ToolTipText = "Quantidade do produto em Estoque";
            this.quantidadeEstoque.Width = 90;
            // 
            // precoCusto
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.precoCusto.DefaultCellStyle = dataGridViewCellStyle4;
            this.precoCusto.HeaderText = "Custo R$";
            this.precoCusto.Name = "precoCusto";
            this.precoCusto.ToolTipText = "Preço de Custo do Produto";
            // 
            // precoVenda
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.precoVenda.DefaultCellStyle = dataGridViewCellStyle5;
            this.precoVenda.HeaderText = "Venda R$";
            this.precoVenda.Name = "precoVenda";
            this.precoVenda.ToolTipText = "Preço de venda do Produto";
            // 
            // codigoBarras
            // 
            this.codigoBarras.HeaderText = "Barras";
            this.codigoBarras.Name = "codigoBarras";
            this.codigoBarras.ToolTipText = "Código de Barras do Produto";
            this.codigoBarras.Width = 170;
            // 
            // imagemProduto
            // 
            this.imagemProduto.HeaderText = "Imagem";
            this.imagemProduto.Name = "imagemProduto";
            this.imagemProduto.Visible = false;
            // 
            // contador
            // 
            this.contador.HeaderText = "Contador";
            this.contador.Name = "contador";
            this.contador.Visible = false;
            // 
            // tbBuscarProduto
            // 
            this.tbBuscarProduto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbBuscarProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBuscarProduto.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbBuscarProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbBuscarProduto.Location = new System.Drawing.Point(295, 135);
            this.tbBuscarProduto.Name = "tbBuscarProduto";
            this.tbBuscarProduto.Size = new System.Drawing.Size(343, 20);
            this.tbBuscarProduto.TabIndex = 0;
            this.tbBuscarProduto.Text = "Digite a descrição do produto ...";
            this.tbBuscarProduto.Enter += new System.EventHandler(this.tbBuscarProduto_Enter);
            this.tbBuscarProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscarProduto_KeyPress);
            this.tbBuscarProduto.Leave += new System.EventHandler(this.tbBuscarProduto_Leave);
            // 
            // panelBuscarProduto
            // 
            this.panelBuscarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelBuscarProduto.Location = new System.Drawing.Point(295, 157);
            this.panelBuscarProduto.Name = "panelBuscarProduto";
            this.panelBuscarProduto.Size = new System.Drawing.Size(343, 2);
            this.panelBuscarProduto.TabIndex = 1;
            // 
            // pbImagemProduto
            // 
            this.pbImagemProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagemProduto.Image = global::Apresentacao.Properties.Resources.imgDefaut;
            this.pbImagemProduto.Location = new System.Drawing.Point(11, 4);
            this.pbImagemProduto.Name = "pbImagemProduto";
            this.pbImagemProduto.Size = new System.Drawing.Size(221, 155);
            this.pbImagemProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagemProduto.TabIndex = 128;
            this.pbImagemProduto.TabStop = false;
            // 
            // pbProduto
            // 
            this.pbProduto.Image = global::Apresentacao.Properties.Resources.ProdutoAzul;
            this.pbProduto.Location = new System.Drawing.Point(644, 132);
            this.pbProduto.Name = "pbProduto";
            this.pbProduto.Size = new System.Drawing.Size(27, 27);
            this.pbProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProduto.TabIndex = 126;
            this.pbProduto.TabStop = false;
            this.pbProduto.Click += new System.EventHandler(this.pbProduto_Click);
            // 
            // pbBarras
            // 
            this.pbBarras.Image = global::Apresentacao.Properties.Resources.BarrasIcone;
            this.pbBarras.Location = new System.Drawing.Point(238, 107);
            this.pbBarras.Name = "pbBarras";
            this.pbBarras.Size = new System.Drawing.Size(52, 52);
            this.pbBarras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBarras.TabIndex = 121;
            this.pbBarras.TabStop = false;
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btBuscar.FlatAppearance.BorderSize = 0;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBuscar.Location = new System.Drawing.Point(147, 681);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(130, 42);
            this.btBuscar.TabIndex = 5;
            this.btBuscar.Text = "&F5 Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btSalvar.FlatAppearance.BorderSize = 0;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSalvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSalvar.Location = new System.Drawing.Point(11, 681);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(130, 42);
            this.btSalvar.TabIndex = 4;
            this.btSalvar.Text = "&F10 Salvar";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Red;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSair.Location = new System.Drawing.Point(847, 681);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(130, 42);
            this.btSair.TabIndex = 6;
            this.btSair.Text = "&Esc Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // FrmCodigoBarras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(991, 736);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.gpPreco);
            this.Controls.Add(this.dgvProdutoCor);
            this.Controls.Add(this.pbImagemProduto);
            this.Controls.Add(this.pbProduto);
            this.Controls.Add(this.panelBuscarProduto);
            this.Controls.Add(this.tbBuscarProduto);
            this.Controls.Add(this.pbBarras);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmCodigoBarras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar Dados Produto";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCodigoBarras_KeyDown);
            this.gpPreco.ResumeLayout(false);
            this.gpPreco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrecos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutoCor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagemProduto;
        private System.Windows.Forms.GroupBox gpPreco;
        private System.Windows.Forms.PictureBox pbPrecos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbCusto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbVenda;
        private System.Windows.Forms.DataGridView dgvProdutoCor;
        private System.Windows.Forms.PictureBox pbBarras;
        private System.Windows.Forms.TextBox tbBuscarProduto;
        private System.Windows.Forms.Panel panelBuscarProduto;
        private System.Windows.Forms.PictureBox pbProduto;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProdutoCor;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoCor;
        private System.Windows.Forms.DataGridViewTextBoxColumn corProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanhoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoCusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagemProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn contador;
    }
}