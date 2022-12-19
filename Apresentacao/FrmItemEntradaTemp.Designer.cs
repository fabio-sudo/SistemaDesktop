namespace Apresentacao
{
    partial class FrmItemEntradaTemp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItemEntradaTemp));
            this.btZerar = new System.Windows.Forms.Button();
            this.gpPreco = new System.Windows.Forms.GroupBox();
            this.pbPrecos = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbCusto = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbVenda = new System.Windows.Forms.MaskedTextBox();
            this.btDesfazer = new System.Windows.Forms.Button();
            this.tbProduto = new System.Windows.Forms.TextBox();
            this.btSelecionar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.dgvTamnhoItem = new System.Windows.Forms.DataGridView();
            this.codigoEntradaEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoTamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanhoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagemProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBuscarProduto = new System.Windows.Forms.Panel();
            this.pbImagemProduto = new System.Windows.Forms.PictureBox();
            this.gpPreco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrecos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTamnhoItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // btZerar
            // 
            this.btZerar.BackColor = System.Drawing.Color.DeepPink;
            this.btZerar.FlatAppearance.BorderSize = 0;
            this.btZerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btZerar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btZerar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btZerar.Location = new System.Drawing.Point(148, 645);
            this.btZerar.Name = "btZerar";
            this.btZerar.Size = new System.Drawing.Size(130, 42);
            this.btZerar.TabIndex = 5;
            this.btZerar.Text = "&F2 Limpar";
            this.btZerar.UseVisualStyleBackColor = false;
            this.btZerar.Click += new System.EventHandler(this.btZerar_Click);
            // 
            // gpPreco
            // 
            this.gpPreco.Controls.Add(this.pbPrecos);
            this.gpPreco.Controls.Add(this.label1);
            this.gpPreco.Controls.Add(this.mtbCusto);
            this.gpPreco.Controls.Add(this.label2);
            this.gpPreco.Controls.Add(this.mtbVenda);
            this.gpPreco.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            this.gpPreco.Location = new System.Drawing.Point(706, 118);
            this.gpPreco.Name = "gpPreco";
            this.gpPreco.Size = new System.Drawing.Size(324, 123);
            this.gpPreco.TabIndex = 1;
            this.gpPreco.TabStop = false;
            this.gpPreco.Text = "Preço do Produto";
            // 
            // pbPrecos
            // 
            this.pbPrecos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPrecos.Image = global::Apresentacao.Properties.Resources.Relogio2;
            this.pbPrecos.Location = new System.Drawing.Point(282, 76);
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
            this.label1.Location = new System.Drawing.Point(3, 55);
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
            this.label2.Location = new System.Drawing.Point(142, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Venda R$";
            // 
            // mtbVenda
            // 
            this.mtbVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.mtbVenda.Location = new System.Drawing.Point(145, 76);
            this.mtbVenda.Name = "mtbVenda";
            this.mtbVenda.Size = new System.Drawing.Size(120, 27);
            this.mtbVenda.TabIndex = 3;
            this.mtbVenda.TextChanged += new System.EventHandler(this.mtbVenda_TextChanged);
            this.mtbVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbVenda_KeyPress);
            // 
            // btDesfazer
            // 
            this.btDesfazer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btDesfazer.FlatAppearance.BorderSize = 0;
            this.btDesfazer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDesfazer.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btDesfazer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDesfazer.Location = new System.Drawing.Point(284, 645);
            this.btDesfazer.Name = "btDesfazer";
            this.btDesfazer.Size = new System.Drawing.Size(130, 42);
            this.btDesfazer.TabIndex = 6;
            this.btDesfazer.Text = "&F5 Desfazer";
            this.btDesfazer.UseVisualStyleBackColor = false;
            this.btDesfazer.Click += new System.EventHandler(this.btDesfazer_Click);
            // 
            // tbProduto
            // 
            this.tbProduto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbProduto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tbProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbProduto.Location = new System.Drawing.Point(238, 209);
            this.tbProduto.Name = "tbProduto";
            this.tbProduto.ReadOnly = true;
            this.tbProduto.Size = new System.Drawing.Size(565, 23);
            this.tbProduto.TabIndex = 0;
            this.tbProduto.Text = "Cód+Descrição do Produto+Cor";
            // 
            // btSelecionar
            // 
            this.btSelecionar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btSelecionar.FlatAppearance.BorderSize = 0;
            this.btSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSelecionar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSelecionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSelecionar.Location = new System.Drawing.Point(12, 645);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(130, 42);
            this.btSelecionar.TabIndex = 4;
            this.btSelecionar.Text = "&F10 Lançar";
            this.btSelecionar.UseVisualStyleBackColor = false;
            this.btSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Red;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSair.Location = new System.Drawing.Point(900, 645);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(130, 42);
            this.btSair.TabIndex = 7;
            this.btSair.Text = "&Esc Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // dgvTamnhoItem
            // 
            this.dgvTamnhoItem.AllowUserToAddRows = false;
            this.dgvTamnhoItem.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dgvTamnhoItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTamnhoItem.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTamnhoItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTamnhoItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTamnhoItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoEntradaEstoque,
            this.nomeCor,
            this.codigoTamanho,
            this.tamanhoProduto,
            this.quantidadeItem,
            this.quantidadeEstoque,
            this.precoCusto,
            this.precoVenda,
            this.codigoBarras,
            this.imagemProduto,
            this.contador});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTamnhoItem.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTamnhoItem.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTamnhoItem.Location = new System.Drawing.Point(12, 247);
            this.dgvTamnhoItem.Name = "dgvTamnhoItem";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.dgvTamnhoItem.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTamnhoItem.RowTemplate.Height = 24;
            this.dgvTamnhoItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTamnhoItem.Size = new System.Drawing.Size(1018, 392);
            this.dgvTamnhoItem.TabIndex = 3;
            this.dgvTamnhoItem.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvTamnhoItem_CellValidating);
            this.dgvTamnhoItem.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvTamnhoItem_EditingControlShowing);
            // 
            // codigoEntradaEstoque
            // 
            this.codigoEntradaEstoque.HeaderText = "CódigoEntradaEstoque";
            this.codigoEntradaEstoque.Name = "codigoEntradaEstoque";
            this.codigoEntradaEstoque.ToolTipText = "Código do Item Selecionado";
            this.codigoEntradaEstoque.Visible = false;
            // 
            // nomeCor
            // 
            this.nomeCor.HeaderText = "Cor";
            this.nomeCor.Name = "nomeCor";
            this.nomeCor.Visible = false;
            // 
            // codigoTamanho
            // 
            this.codigoTamanho.HeaderText = "Cód";
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
            // quantidadeItem
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.quantidadeItem.DefaultCellStyle = dataGridViewCellStyle3;
            this.quantidadeItem.HeaderText = "Quantidade";
            this.quantidadeItem.Name = "quantidadeItem";
            this.quantidadeItem.ToolTipText = "Quantidade de Produtos";
            // 
            // quantidadeEstoque
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.quantidadeEstoque.DefaultCellStyle = dataGridViewCellStyle4;
            this.quantidadeEstoque.HeaderText = "Estoque";
            this.quantidadeEstoque.Name = "quantidadeEstoque";
            this.quantidadeEstoque.ReadOnly = true;
            this.quantidadeEstoque.ToolTipText = "Quantidade do produto em Estoque";
            this.quantidadeEstoque.Width = 90;
            // 
            // precoCusto
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.precoCusto.DefaultCellStyle = dataGridViewCellStyle5;
            this.precoCusto.HeaderText = "Custo R$";
            this.precoCusto.Name = "precoCusto";
            this.precoCusto.ToolTipText = "Preço de Custo do Produto";
            // 
            // precoVenda
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.precoVenda.DefaultCellStyle = dataGridViewCellStyle6;
            this.precoVenda.HeaderText = "Venda R$";
            this.precoVenda.Name = "precoVenda";
            this.precoVenda.ToolTipText = "Preço de venda do Produto";
            // 
            // codigoBarras
            // 
            this.codigoBarras.HeaderText = "Barras";
            this.codigoBarras.Name = "codigoBarras";
            this.codigoBarras.ToolTipText = "Código de Barras do Produto";
            this.codigoBarras.Width = 200;
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
            // panelBuscarProduto
            // 
            this.panelBuscarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelBuscarProduto.Location = new System.Drawing.Point(12, 238);
            this.panelBuscarProduto.Name = "panelBuscarProduto";
            this.panelBuscarProduto.Size = new System.Drawing.Size(690, 3);
            this.panelBuscarProduto.TabIndex = 2;
            // 
            // pbImagemProduto
            // 
            this.pbImagemProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagemProduto.Image = global::Apresentacao.Properties.Resources.imgDefaut;
            this.pbImagemProduto.Location = new System.Drawing.Point(12, 12);
            this.pbImagemProduto.Name = "pbImagemProduto";
            this.pbImagemProduto.Size = new System.Drawing.Size(220, 220);
            this.pbImagemProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagemProduto.TabIndex = 46;
            this.pbImagemProduto.TabStop = false;
            // 
            // FrmItemEntradaTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1042, 699);
            this.Controls.Add(this.btZerar);
            this.Controls.Add(this.gpPreco);
            this.Controls.Add(this.btDesfazer);
            this.Controls.Add(this.tbProduto);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.dgvTamnhoItem);
            this.Controls.Add(this.panelBuscarProduto);
            this.Controls.Add(this.pbImagemProduto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmItemEntradaTemp";
            this.Text = "Item Entrada Estoque Pendente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmItemEntradaTemp_FormClosed);
            this.Load += new System.EventHandler(this.FrmItemEntradaTemp_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmItemEntradaTemp_KeyDown);
            this.gpPreco.ResumeLayout(false);
            this.gpPreco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrecos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTamnhoItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btZerar;
        private System.Windows.Forms.GroupBox gpPreco;
        private System.Windows.Forms.PictureBox pbPrecos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbCusto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbVenda;
        private System.Windows.Forms.Button btDesfazer;
        private System.Windows.Forms.TextBox tbProduto;
        private System.Windows.Forms.Button btSelecionar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.DataGridView dgvTamnhoItem;
        private System.Windows.Forms.Panel panelBuscarProduto;
        private System.Windows.Forms.PictureBox pbImagemProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEntradaEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCor;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanhoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoCusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagemProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn contador;
    }
}