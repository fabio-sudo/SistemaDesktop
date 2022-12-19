namespace Apresentacao
{
    partial class FrmEstoque
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstoque));
            this.lbEstoque = new System.Windows.Forms.Label();
            this.tbBuscarProduto = new System.Windows.Forms.TextBox();
            this.panelBuscarProduto = new System.Windows.Forms.Panel();
            this.btLancamento = new System.Windows.Forms.Button();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.codigoEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoProdutoCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenciaProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoTamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeTamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoCustoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoVendaProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoBarrasProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagemProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbFornecedor = new System.Windows.Forms.TextBox();
            this.tbGrade = new System.Windows.Forms.TextBox();
            this.tbGenero = new System.Windows.Forms.TextBox();
            this.lbFornecedor = new System.Windows.Forms.Label();
            this.lbGrade = new System.Windows.Forms.Label();
            this.lbGenero = new System.Windows.Forms.Label();
            this.lbCor = new System.Windows.Forms.Label();
            this.tbCor = new System.Windows.Forms.TextBox();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.lbDataInicial = new System.Windows.Forms.Label();
            this.lbDataFinal = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.lbSexo = new System.Windows.Forms.Label();
            this.tbTamanho = new System.Windows.Forms.TextBox();
            this.lbTamanho = new System.Windows.Forms.Label();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.pbTamanho = new System.Windows.Forms.PictureBox();
            this.pbBuscarGenero = new System.Windows.Forms.PictureBox();
            this.pbBuscarGrade = new System.Windows.Forms.PictureBox();
            this.pbBuscarFornecedor = new System.Windows.Forms.PictureBox();
            this.pbFiltrar = new System.Windows.Forms.PictureBox();
            this.pbCor = new System.Windows.Forms.PictureBox();
            this.btEntradaEstoque = new System.Windows.Forms.Button();
            this.pbLimpar = new System.Windows.Forms.PictureBox();
            this.pbImagemProduto = new System.Windows.Forms.PictureBox();
            this.pbBuscarEstoque = new System.Windows.Forms.PictureBox();
            this.pbProduto = new System.Windows.Forms.PictureBox();
            this.pbEstoque = new System.Windows.Forms.PictureBox();
            this.painelCusto = new System.Windows.Forms.Panel();
            this.lbTituloTotalEstoque = new System.Windows.Forms.Label();
            this.lbTotalEstoque = new System.Windows.Forms.Label();
            this.painelQuantidade = new System.Windows.Forms.Panel();
            this.lbTituloQuantidade = new System.Windows.Forms.Label();
            this.lbQuantidadeEstoque = new System.Windows.Forms.Label();
            this.painelVenda = new System.Windows.Forms.Panel();
            this.lbTituloTotalVenda = new System.Windows.Forms.Label();
            this.lbVenda = new System.Windows.Forms.Label();
            this.painelFiltros = new System.Windows.Forms.Panel();
            this.btCodigoBarras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            this.gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTamanho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarGenero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiltrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLimpar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstoque)).BeginInit();
            this.painelCusto.SuspendLayout();
            this.painelQuantidade.SuspendLayout();
            this.painelVenda.SuspendLayout();
            this.painelFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbEstoque
            // 
            this.lbEstoque.AutoSize = true;
            this.lbEstoque.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbEstoque.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbEstoque.Location = new System.Drawing.Point(70, 45);
            this.lbEstoque.Name = "lbEstoque";
            this.lbEstoque.Size = new System.Drawing.Size(176, 19);
            this.lbEstoque.TabIndex = 0;
            this.lbEstoque.Text = "Estoque de Produtos";
            // 
            // tbBuscarProduto
            // 
            this.tbBuscarProduto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbBuscarProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBuscarProduto.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbBuscarProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbBuscarProduto.Location = new System.Drawing.Point(13, 104);
            this.tbBuscarProduto.Name = "tbBuscarProduto";
            this.tbBuscarProduto.Size = new System.Drawing.Size(343, 20);
            this.tbBuscarProduto.TabIndex = 1;
            this.tbBuscarProduto.Text = "Digite a descrição do produto ...";
            this.tbBuscarProduto.Enter += new System.EventHandler(this.tbBuscarProduto_Enter);
            this.tbBuscarProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscarProduto_KeyPress);
            this.tbBuscarProduto.Leave += new System.EventHandler(this.tbBuscarProduto_Leave);
            // 
            // panelBuscarProduto
            // 
            this.panelBuscarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelBuscarProduto.Location = new System.Drawing.Point(12, 126);
            this.panelBuscarProduto.Name = "panelBuscarProduto";
            this.panelBuscarProduto.Size = new System.Drawing.Size(343, 2);
            this.panelBuscarProduto.TabIndex = 3;
            // 
            // btLancamento
            // 
            this.btLancamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btLancamento.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btLancamento.FlatAppearance.BorderSize = 0;
            this.btLancamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLancamento.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btLancamento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLancamento.Location = new System.Drawing.Point(12, 668);
            this.btLancamento.Name = "btLancamento";
            this.btLancamento.Size = new System.Drawing.Size(140, 42);
            this.btLancamento.TabIndex = 5;
            this.btLancamento.Text = "F10 Lançamento";
            this.btLancamento.UseVisualStyleBackColor = false;
            this.btLancamento.Click += new System.EventHandler(this.btLancamento_Click);
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.AllowUserToAddRows = false;
            this.dgvEstoque.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dgvEstoque.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEstoque.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoEstoque,
            this.codigoProduto,
            this.codigoProdutoCor,
            this.descricaoProduto,
            this.referenciaProduto,
            this.sexoProduto,
            this.corProduto,
            this.generoProduto,
            this.gradeProduto,
            this.codigoTamanho,
            this.nomeTamanho,
            this.fornecedorProduto,
            this.quantidadeEstoque,
            this.precoCustoProduto,
            this.precoVendaProduto,
            this.codigoBarrasProduto,
            this.imagemProduto,
            this.custoTotal,
            this.dataEstoque,
            this.totalVenda});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEstoque.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEstoque.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvEstoque.Location = new System.Drawing.Point(12, 134);
            this.dgvEstoque.Name = "dgvEstoque";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.dgvEstoque.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvEstoque.RowTemplate.Height = 24;
            this.dgvEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstoque.Size = new System.Drawing.Size(1081, 495);
            this.dgvEstoque.TabIndex = 4;
            this.dgvEstoque.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstoque_CellClick);
            this.dgvEstoque.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstoque_CellDoubleClick);
            this.dgvEstoque.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvEstoque_CellValidating);
            // 
            // codigoEstoque
            // 
            this.codigoEstoque.HeaderText = "CodEstoque";
            this.codigoEstoque.Name = "codigoEstoque";
            this.codigoEstoque.ReadOnly = true;
            this.codigoEstoque.ToolTipText = "Código do Estoque";
            this.codigoEstoque.Visible = false;
            this.codigoEstoque.Width = 40;
            // 
            // codigoProduto
            // 
            this.codigoProduto.HeaderText = "Cód";
            this.codigoProduto.Name = "codigoProduto";
            this.codigoProduto.ReadOnly = true;
            this.codigoProduto.ToolTipText = "Código do Produto";
            this.codigoProduto.Width = 50;
            // 
            // codigoProdutoCor
            // 
            this.codigoProdutoCor.HeaderText = "Cód.ProdutoCor";
            this.codigoProdutoCor.Name = "codigoProdutoCor";
            this.codigoProdutoCor.ReadOnly = true;
            this.codigoProdutoCor.ToolTipText = "Código do Produto Cor";
            this.codigoProdutoCor.Visible = false;
            // 
            // descricaoProduto
            // 
            this.descricaoProduto.HeaderText = "Descrição";
            this.descricaoProduto.Name = "descricaoProduto";
            this.descricaoProduto.ReadOnly = true;
            this.descricaoProduto.ToolTipText = "Descrição do Produto";
            this.descricaoProduto.Width = 220;
            // 
            // referenciaProduto
            // 
            this.referenciaProduto.HeaderText = "Referência";
            this.referenciaProduto.Name = "referenciaProduto";
            this.referenciaProduto.ReadOnly = true;
            this.referenciaProduto.ToolTipText = "Referência do Produto";
            this.referenciaProduto.Width = 80;
            // 
            // sexoProduto
            // 
            this.sexoProduto.HeaderText = "Sexo";
            this.sexoProduto.Name = "sexoProduto";
            this.sexoProduto.ReadOnly = true;
            this.sexoProduto.ToolTipText = "Sexo do Produto";
            this.sexoProduto.Width = 80;
            // 
            // corProduto
            // 
            this.corProduto.HeaderText = "Cor";
            this.corProduto.Name = "corProduto";
            this.corProduto.ReadOnly = true;
            this.corProduto.ToolTipText = "Cor do Produto";
            this.corProduto.Width = 80;
            // 
            // generoProduto
            // 
            this.generoProduto.HeaderText = "Genero";
            this.generoProduto.Name = "generoProduto";
            this.generoProduto.ReadOnly = true;
            this.generoProduto.ToolTipText = "Genero do Produto";
            this.generoProduto.Width = 115;
            // 
            // gradeProduto
            // 
            this.gradeProduto.HeaderText = "Grade";
            this.gradeProduto.Name = "gradeProduto";
            this.gradeProduto.ToolTipText = "Grade do Produto";
            // 
            // codigoTamanho
            // 
            this.codigoTamanho.HeaderText = "Cód.Tamanho";
            this.codigoTamanho.Name = "codigoTamanho";
            this.codigoTamanho.ReadOnly = true;
            this.codigoTamanho.ToolTipText = "Código do Tamanho do Produto";
            this.codigoTamanho.Visible = false;
            // 
            // nomeTamanho
            // 
            this.nomeTamanho.HeaderText = "Tamanho";
            this.nomeTamanho.Name = "nomeTamanho";
            this.nomeTamanho.ReadOnly = true;
            this.nomeTamanho.ToolTipText = "Nome do Tamanho do Produto";
            this.nomeTamanho.Width = 80;
            // 
            // fornecedorProduto
            // 
            this.fornecedorProduto.HeaderText = "Fornecedor";
            this.fornecedorProduto.Name = "fornecedorProduto";
            this.fornecedorProduto.ToolTipText = "Fornecedor do Produto";
            this.fornecedorProduto.Width = 200;
            // 
            // quantidadeEstoque
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.quantidadeEstoque.DefaultCellStyle = dataGridViewCellStyle3;
            this.quantidadeEstoque.HeaderText = "Estoque";
            this.quantidadeEstoque.Name = "quantidadeEstoque";
            this.quantidadeEstoque.ReadOnly = true;
            this.quantidadeEstoque.ToolTipText = "Quantidade do estoque do Produto";
            this.quantidadeEstoque.Width = 70;
            // 
            // precoCustoProduto
            // 
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.precoCustoProduto.DefaultCellStyle = dataGridViewCellStyle4;
            this.precoCustoProduto.HeaderText = "Custo R$";
            this.precoCustoProduto.Name = "precoCustoProduto";
            this.precoCustoProduto.ReadOnly = true;
            this.precoCustoProduto.Width = 90;
            // 
            // precoVendaProduto
            // 
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.precoVendaProduto.DefaultCellStyle = dataGridViewCellStyle5;
            this.precoVendaProduto.HeaderText = "Venda R$";
            this.precoVendaProduto.Name = "precoVendaProduto";
            this.precoVendaProduto.ReadOnly = true;
            this.precoVendaProduto.Width = 90;
            // 
            // codigoBarrasProduto
            // 
            this.codigoBarrasProduto.HeaderText = "Barras";
            this.codigoBarrasProduto.Name = "codigoBarrasProduto";
            this.codigoBarrasProduto.ToolTipText = "Código de Barras do Produto";
            this.codigoBarrasProduto.Width = 140;
            // 
            // imagemProduto
            // 
            this.imagemProduto.HeaderText = "Imagem";
            this.imagemProduto.Name = "imagemProduto";
            this.imagemProduto.ReadOnly = true;
            this.imagemProduto.ToolTipText = "Imagem do Produto";
            this.imagemProduto.Visible = false;
            // 
            // custoTotal
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.custoTotal.DefaultCellStyle = dataGridViewCellStyle6;
            this.custoTotal.HeaderText = "Total R$";
            this.custoTotal.Name = "custoTotal";
            this.custoTotal.ToolTipText = "Custo Total Produto";
            this.custoTotal.Width = 90;
            // 
            // dataEstoque
            // 
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            this.dataEstoque.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataEstoque.HeaderText = "Data";
            this.dataEstoque.Name = "dataEstoque";
            this.dataEstoque.ReadOnly = true;
            this.dataEstoque.ToolTipText = "Data Lançamento";
            this.dataEstoque.Width = 80;
            // 
            // totalVenda
            // 
            this.totalVenda.HeaderText = "TotalVenda";
            this.totalVenda.Name = "totalVenda";
            this.totalVenda.Visible = false;
            // 
            // tbFornecedor
            // 
            this.tbFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbFornecedor.Location = new System.Drawing.Point(670, 81);
            this.tbFornecedor.Name = "tbFornecedor";
            this.tbFornecedor.Size = new System.Drawing.Size(147, 27);
            this.tbFornecedor.TabIndex = 11;
            this.tbFornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFornecedor_KeyPress);
            // 
            // tbGrade
            // 
            this.tbGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbGrade.Location = new System.Drawing.Point(341, 80);
            this.tbGrade.Name = "tbGrade";
            this.tbGrade.Size = new System.Drawing.Size(147, 27);
            this.tbGrade.TabIndex = 7;
            this.tbGrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGrade_KeyPress);
            // 
            // tbGenero
            // 
            this.tbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbGenero.Location = new System.Drawing.Point(341, 47);
            this.tbGenero.Name = "tbGenero";
            this.tbGenero.Size = new System.Drawing.Size(147, 27);
            this.tbGenero.TabIndex = 6;
            this.tbGenero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGenero_KeyPress);
            // 
            // lbFornecedor
            // 
            this.lbFornecedor.AutoSize = true;
            this.lbFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbFornecedor.Location = new System.Drawing.Point(560, 88);
            this.lbFornecedor.Name = "lbFornecedor";
            this.lbFornecedor.Size = new System.Drawing.Size(94, 20);
            this.lbFornecedor.TabIndex = 9;
            this.lbFornecedor.Text = "Fornecedor";
            // 
            // lbGrade
            // 
            this.lbGrade.AutoSize = true;
            this.lbGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbGrade.Location = new System.Drawing.Point(265, 87);
            this.lbGrade.Name = "lbGrade";
            this.lbGrade.Size = new System.Drawing.Size(55, 20);
            this.lbGrade.TabIndex = 5;
            this.lbGrade.Text = "Grade";
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbGenero.Location = new System.Drawing.Point(265, 55);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(64, 20);
            this.lbGenero.TabIndex = 4;
            this.lbGenero.Text = "Genero";
            // 
            // lbCor
            // 
            this.lbCor.AutoSize = true;
            this.lbCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCor.Location = new System.Drawing.Point(4, 88);
            this.lbCor.Name = "lbCor";
            this.lbCor.Size = new System.Drawing.Size(36, 20);
            this.lbCor.TabIndex = 1;
            this.lbCor.Text = "Cor";
            // 
            // tbCor
            // 
            this.tbCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbCor.Location = new System.Drawing.Point(61, 82);
            this.tbCor.Name = "tbCor";
            this.tbCor.Size = new System.Drawing.Size(147, 27);
            this.tbCor.TabIndex = 3;
            this.tbCor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCor_KeyPress);
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(865, 81);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(124, 27);
            this.dtpDataInicial.TabIndex = 13;
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(995, 81);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(124, 27);
            this.dtpDataFinal.TabIndex = 15;
            // 
            // lbDataInicial
            // 
            this.lbDataInicial.AutoSize = true;
            this.lbDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDataInicial.Location = new System.Drawing.Point(861, 57);
            this.lbDataInicial.Name = "lbDataInicial";
            this.lbDataInicial.Size = new System.Drawing.Size(93, 20);
            this.lbDataInicial.TabIndex = 12;
            this.lbDataInicial.Text = "Data Inicial";
            // 
            // lbDataFinal
            // 
            this.lbDataFinal.AutoSize = true;
            this.lbDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDataFinal.Location = new System.Drawing.Point(991, 57);
            this.lbDataFinal.Name = "lbDataFinal";
            this.lbDataFinal.Size = new System.Drawing.Size(86, 20);
            this.lbDataFinal.TabIndex = 14;
            this.lbDataFinal.Text = "Data Final";
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino\t",
            "Unisex"});
            this.cbSexo.Location = new System.Drawing.Point(61, 48);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(147, 28);
            this.cbSexo.TabIndex = 2;
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbSexo.Location = new System.Drawing.Point(4, 57);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(46, 20);
            this.lbSexo.TabIndex = 0;
            this.lbSexo.Text = "Sexo";
            // 
            // tbTamanho
            // 
            this.tbTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbTamanho.Location = new System.Drawing.Point(670, 48);
            this.tbTamanho.Name = "tbTamanho";
            this.tbTamanho.Size = new System.Drawing.Size(147, 27);
            this.tbTamanho.TabIndex = 10;
            this.tbTamanho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTamanho_KeyPress);
            // 
            // lbTamanho
            // 
            this.lbTamanho.AutoSize = true;
            this.lbTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTamanho.Location = new System.Drawing.Point(560, 55);
            this.lbTamanho.Name = "lbTamanho";
            this.lbTamanho.Size = new System.Drawing.Size(78, 20);
            this.lbTamanho.TabIndex = 8;
            this.lbTamanho.Text = "Tamanho";
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.tbFornecedor);
            this.gbFiltros.Controls.Add(this.lbGenero);
            this.gbFiltros.Controls.Add(this.pbTamanho);
            this.gbFiltros.Controls.Add(this.lbGrade);
            this.gbFiltros.Controls.Add(this.tbTamanho);
            this.gbFiltros.Controls.Add(this.lbFornecedor);
            this.gbFiltros.Controls.Add(this.lbTamanho);
            this.gbFiltros.Controls.Add(this.tbGenero);
            this.gbFiltros.Controls.Add(this.cbSexo);
            this.gbFiltros.Controls.Add(this.tbGrade);
            this.gbFiltros.Controls.Add(this.lbSexo);
            this.gbFiltros.Controls.Add(this.pbBuscarGenero);
            this.gbFiltros.Controls.Add(this.dtpDataInicial);
            this.gbFiltros.Controls.Add(this.pbBuscarGrade);
            this.gbFiltros.Controls.Add(this.dtpDataFinal);
            this.gbFiltros.Controls.Add(this.pbBuscarFornecedor);
            this.gbFiltros.Controls.Add(this.pbFiltrar);
            this.gbFiltros.Controls.Add(this.tbCor);
            this.gbFiltros.Controls.Add(this.lbDataInicial);
            this.gbFiltros.Controls.Add(this.lbCor);
            this.gbFiltros.Controls.Add(this.lbDataFinal);
            this.gbFiltros.Controls.Add(this.pbCor);
            this.gbFiltros.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.gbFiltros.Location = new System.Drawing.Point(3, 3);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(1159, 116);
            this.gbFiltros.TabIndex = 0;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros:";
            // 
            // pbTamanho
            // 
            this.pbTamanho.Image = global::Apresentacao.Properties.Resources.TamanhoLogoBotao;
            this.pbTamanho.Location = new System.Drawing.Point(823, 48);
            this.pbTamanho.Name = "pbTamanho";
            this.pbTamanho.Size = new System.Drawing.Size(27, 27);
            this.pbTamanho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTamanho.TabIndex = 115;
            this.pbTamanho.TabStop = false;
            this.pbTamanho.Click += new System.EventHandler(this.pbTamanho_Click);
            // 
            // pbBuscarGenero
            // 
            this.pbBuscarGenero.Image = global::Apresentacao.Properties.Resources.GeneroLogoBotao;
            this.pbBuscarGenero.Location = new System.Drawing.Point(494, 47);
            this.pbBuscarGenero.Name = "pbBuscarGenero";
            this.pbBuscarGenero.Size = new System.Drawing.Size(27, 27);
            this.pbBuscarGenero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscarGenero.TabIndex = 99;
            this.pbBuscarGenero.TabStop = false;
            this.pbBuscarGenero.Click += new System.EventHandler(this.pbBuscarGenero_Click);
            // 
            // pbBuscarGrade
            // 
            this.pbBuscarGrade.Image = global::Apresentacao.Properties.Resources.GradeLogoBotao;
            this.pbBuscarGrade.Location = new System.Drawing.Point(494, 80);
            this.pbBuscarGrade.Name = "pbBuscarGrade";
            this.pbBuscarGrade.Size = new System.Drawing.Size(27, 27);
            this.pbBuscarGrade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscarGrade.TabIndex = 100;
            this.pbBuscarGrade.TabStop = false;
            this.pbBuscarGrade.Click += new System.EventHandler(this.pbBuscarGrade_Click);
            // 
            // pbBuscarFornecedor
            // 
            this.pbBuscarFornecedor.Image = global::Apresentacao.Properties.Resources.FornecedorLogoBotao;
            this.pbBuscarFornecedor.Location = new System.Drawing.Point(823, 81);
            this.pbBuscarFornecedor.Name = "pbBuscarFornecedor";
            this.pbBuscarFornecedor.Size = new System.Drawing.Size(27, 27);
            this.pbBuscarFornecedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscarFornecedor.TabIndex = 101;
            this.pbBuscarFornecedor.TabStop = false;
            this.pbBuscarFornecedor.Click += new System.EventHandler(this.pbBuscarFornecedor_Click);
            // 
            // pbFiltrar
            // 
            this.pbFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFiltrar.Image = global::Apresentacao.Properties.Resources.FiltroImg;
            this.pbFiltrar.Location = new System.Drawing.Point(1125, 80);
            this.pbFiltrar.Name = "pbFiltrar";
            this.pbFiltrar.Size = new System.Drawing.Size(27, 27);
            this.pbFiltrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFiltrar.TabIndex = 110;
            this.pbFiltrar.TabStop = false;
            this.pbFiltrar.Click += new System.EventHandler(this.pbFiltrar_Click);
            // 
            // pbCor
            // 
            this.pbCor.Image = global::Apresentacao.Properties.Resources.CorLogoBotao;
            this.pbCor.Location = new System.Drawing.Point(214, 83);
            this.pbCor.Name = "pbCor";
            this.pbCor.Size = new System.Drawing.Size(27, 27);
            this.pbCor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCor.TabIndex = 104;
            this.pbCor.TabStop = false;
            this.pbCor.Click += new System.EventHandler(this.pbCor_Click);
            // 
            // btEntradaEstoque
            // 
            this.btEntradaEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btEntradaEstoque.BackColor = System.Drawing.Color.DeepPink;
            this.btEntradaEstoque.FlatAppearance.BorderSize = 0;
            this.btEntradaEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEntradaEstoque.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btEntradaEstoque.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEntradaEstoque.Location = new System.Drawing.Point(158, 668);
            this.btEntradaEstoque.Name = "btEntradaEstoque";
            this.btEntradaEstoque.Size = new System.Drawing.Size(162, 42);
            this.btEntradaEstoque.TabIndex = 6;
            this.btEntradaEstoque.Text = "F2 Entrada Estoque";
            this.btEntradaEstoque.UseVisualStyleBackColor = false;
            this.btEntradaEstoque.Click += new System.EventHandler(this.btEntradaEstoque_Click);
            // 
            // pbLimpar
            // 
            this.pbLimpar.Image = global::Apresentacao.Properties.Resources.Clear;
            this.pbLimpar.Location = new System.Drawing.Point(427, 101);
            this.pbLimpar.Name = "pbLimpar";
            this.pbLimpar.Size = new System.Drawing.Size(27, 27);
            this.pbLimpar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLimpar.TabIndex = 119;
            this.pbLimpar.TabStop = false;
            this.pbLimpar.Click += new System.EventHandler(this.pbLimpar_Click);
            // 
            // pbImagemProduto
            // 
            this.pbImagemProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImagemProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagemProduto.Image = global::Apresentacao.Properties.Resources.imgDefaut;
            this.pbImagemProduto.Location = new System.Drawing.Point(878, 10);
            this.pbImagemProduto.Name = "pbImagemProduto";
            this.pbImagemProduto.Size = new System.Drawing.Size(215, 118);
            this.pbImagemProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagemProduto.TabIndex = 116;
            this.pbImagemProduto.TabStop = false;
            // 
            // pbBuscarEstoque
            // 
            this.pbBuscarEstoque.Image = global::Apresentacao.Properties.Resources.Selecionar;
            this.pbBuscarEstoque.Location = new System.Drawing.Point(394, 101);
            this.pbBuscarEstoque.Name = "pbBuscarEstoque";
            this.pbBuscarEstoque.Size = new System.Drawing.Size(27, 27);
            this.pbBuscarEstoque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscarEstoque.TabIndex = 91;
            this.pbBuscarEstoque.TabStop = false;
            this.pbBuscarEstoque.Click += new System.EventHandler(this.pbBuscarEstoque_Click);
            // 
            // pbProduto
            // 
            this.pbProduto.Image = global::Apresentacao.Properties.Resources.ProdutoAzul;
            this.pbProduto.Location = new System.Drawing.Point(361, 101);
            this.pbProduto.Name = "pbProduto";
            this.pbProduto.Size = new System.Drawing.Size(27, 27);
            this.pbProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProduto.TabIndex = 89;
            this.pbProduto.TabStop = false;
            this.pbProduto.Click += new System.EventHandler(this.pbProduto_Click);
            // 
            // pbEstoque
            // 
            this.pbEstoque.Image = global::Apresentacao.Properties.Resources.estoqueLogo;
            this.pbEstoque.Location = new System.Drawing.Point(12, 12);
            this.pbEstoque.Name = "pbEstoque";
            this.pbEstoque.Size = new System.Drawing.Size(52, 52);
            this.pbEstoque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEstoque.TabIndex = 0;
            this.pbEstoque.TabStop = false;
            // 
            // painelCusto
            // 
            this.painelCusto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.painelCusto.AutoScroll = true;
            this.painelCusto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.painelCusto.Controls.Add(this.lbTituloTotalEstoque);
            this.painelCusto.Controls.Add(this.lbTotalEstoque);
            this.painelCusto.Location = new System.Drawing.Point(725, 636);
            this.painelCusto.Name = "painelCusto";
            this.painelCusto.Size = new System.Drawing.Size(181, 74);
            this.painelCusto.TabIndex = 121;
            // 
            // lbTituloTotalEstoque
            // 
            this.lbTituloTotalEstoque.AutoSize = true;
            this.lbTituloTotalEstoque.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTituloTotalEstoque.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTituloTotalEstoque.Location = new System.Drawing.Point(3, 7);
            this.lbTituloTotalEstoque.Name = "lbTituloTotalEstoque";
            this.lbTituloTotalEstoque.Size = new System.Drawing.Size(119, 24);
            this.lbTituloTotalEstoque.TabIndex = 87;
            this.lbTituloTotalEstoque.Text = "Total Custo";
            this.lbTituloTotalEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotalEstoque
            // 
            this.lbTotalEstoque.AutoSize = true;
            this.lbTotalEstoque.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTotalEstoque.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTotalEstoque.Location = new System.Drawing.Point(3, 39);
            this.lbTotalEstoque.Name = "lbTotalEstoque";
            this.lbTotalEstoque.Size = new System.Drawing.Size(80, 24);
            this.lbTotalEstoque.TabIndex = 84;
            this.lbTotalEstoque.Text = "R$ 0,00";
            this.lbTotalEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // painelQuantidade
            // 
            this.painelQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.painelQuantidade.AutoScroll = true;
            this.painelQuantidade.BackColor = System.Drawing.Color.DeepPink;
            this.painelQuantidade.Controls.Add(this.lbTituloQuantidade);
            this.painelQuantidade.Controls.Add(this.lbQuantidadeEstoque);
            this.painelQuantidade.Location = new System.Drawing.Point(538, 636);
            this.painelQuantidade.Name = "painelQuantidade";
            this.painelQuantidade.Size = new System.Drawing.Size(181, 74);
            this.painelQuantidade.TabIndex = 120;
            // 
            // lbTituloQuantidade
            // 
            this.lbTituloQuantidade.AutoSize = true;
            this.lbTituloQuantidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTituloQuantidade.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTituloQuantidade.Location = new System.Drawing.Point(3, 7);
            this.lbTituloQuantidade.Name = "lbTituloQuantidade";
            this.lbTituloQuantidade.Size = new System.Drawing.Size(119, 24);
            this.lbTituloQuantidade.TabIndex = 87;
            this.lbTituloQuantidade.Text = "Quantidade";
            this.lbTituloQuantidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbQuantidadeEstoque
            // 
            this.lbQuantidadeEstoque.AutoSize = true;
            this.lbQuantidadeEstoque.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbQuantidadeEstoque.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbQuantidadeEstoque.Location = new System.Drawing.Point(3, 39);
            this.lbQuantidadeEstoque.Name = "lbQuantidadeEstoque";
            this.lbQuantidadeEstoque.Size = new System.Drawing.Size(21, 24);
            this.lbQuantidadeEstoque.TabIndex = 84;
            this.lbQuantidadeEstoque.Text = "0";
            this.lbQuantidadeEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // painelVenda
            // 
            this.painelVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.painelVenda.AutoScroll = true;
            this.painelVenda.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.painelVenda.Controls.Add(this.lbTituloTotalVenda);
            this.painelVenda.Controls.Add(this.lbVenda);
            this.painelVenda.Location = new System.Drawing.Point(912, 636);
            this.painelVenda.Name = "painelVenda";
            this.painelVenda.Size = new System.Drawing.Size(181, 74);
            this.painelVenda.TabIndex = 122;
            // 
            // lbTituloTotalVenda
            // 
            this.lbTituloTotalVenda.AutoSize = true;
            this.lbTituloTotalVenda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTituloTotalVenda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTituloTotalVenda.Location = new System.Drawing.Point(3, 7);
            this.lbTituloTotalVenda.Name = "lbTituloTotalVenda";
            this.lbTituloTotalVenda.Size = new System.Drawing.Size(121, 24);
            this.lbTituloTotalVenda.TabIndex = 86;
            this.lbTituloTotalVenda.Text = "Total Venda";
            this.lbTituloTotalVenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbVenda
            // 
            this.lbVenda.AutoSize = true;
            this.lbVenda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbVenda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbVenda.Location = new System.Drawing.Point(3, 39);
            this.lbVenda.Name = "lbVenda";
            this.lbVenda.Size = new System.Drawing.Size(80, 24);
            this.lbVenda.TabIndex = 84;
            this.lbVenda.Text = "R$ 0,00";
            this.lbVenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // painelFiltros
            // 
            this.painelFiltros.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.painelFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.painelFiltros.AutoScroll = true;
            this.painelFiltros.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.painelFiltros.Controls.Add(this.gbFiltros);
            this.painelFiltros.Location = new System.Drawing.Point(460, 10);
            this.painelFiltros.Name = "painelFiltros";
            this.painelFiltros.Size = new System.Drawing.Size(412, 118);
            this.painelFiltros.TabIndex = 2;
            // 
            // btCodigoBarras
            // 
            this.btCodigoBarras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCodigoBarras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btCodigoBarras.FlatAppearance.BorderSize = 0;
            this.btCodigoBarras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCodigoBarras.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCodigoBarras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCodigoBarras.Location = new System.Drawing.Point(326, 667);
            this.btCodigoBarras.Name = "btCodigoBarras";
            this.btCodigoBarras.Size = new System.Drawing.Size(140, 42);
            this.btCodigoBarras.TabIndex = 123;
            this.btCodigoBarras.Text = "Código Barras";
            this.btCodigoBarras.UseVisualStyleBackColor = false;
            this.btCodigoBarras.Click += new System.EventHandler(this.btCodigoBarras_Click);
            // 
            // FrmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1105, 722);
            this.Controls.Add(this.btCodigoBarras);
            this.Controls.Add(this.painelVenda);
            this.Controls.Add(this.painelCusto);
            this.Controls.Add(this.painelQuantidade);
            this.Controls.Add(this.painelFiltros);
            this.Controls.Add(this.pbLimpar);
            this.Controls.Add(this.btEntradaEstoque);
            this.Controls.Add(this.pbImagemProduto);
            this.Controls.Add(this.dgvEstoque);
            this.Controls.Add(this.pbBuscarEstoque);
            this.Controls.Add(this.pbProduto);
            this.Controls.Add(this.btLancamento);
            this.Controls.Add(this.panelBuscarProduto);
            this.Controls.Add(this.tbBuscarProduto);
            this.Controls.Add(this.lbEstoque);
            this.Controls.Add(this.pbEstoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.FrmEstoque_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmEstoque_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTamanho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarGenero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiltrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLimpar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstoque)).EndInit();
            this.painelCusto.ResumeLayout(false);
            this.painelCusto.PerformLayout();
            this.painelQuantidade.ResumeLayout(false);
            this.painelQuantidade.PerformLayout();
            this.painelVenda.ResumeLayout(false);
            this.painelVenda.PerformLayout();
            this.painelFiltros.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbEstoque;
        private System.Windows.Forms.Label lbEstoque;
        private System.Windows.Forms.TextBox tbBuscarProduto;
        private System.Windows.Forms.Panel panelBuscarProduto;
        private System.Windows.Forms.Button btLancamento;
        private System.Windows.Forms.PictureBox pbProduto;
        private System.Windows.Forms.PictureBox pbBuscarEstoque;
        private System.Windows.Forms.DataGridView dgvEstoque;
        private System.Windows.Forms.PictureBox pbBuscarFornecedor;
        private System.Windows.Forms.PictureBox pbBuscarGrade;
        private System.Windows.Forms.PictureBox pbBuscarGenero;
        private System.Windows.Forms.TextBox tbFornecedor;
        private System.Windows.Forms.TextBox tbGrade;
        private System.Windows.Forms.TextBox tbGenero;
        private System.Windows.Forms.Label lbFornecedor;
        private System.Windows.Forms.Label lbGrade;
        private System.Windows.Forms.Label lbGenero;
        private System.Windows.Forms.PictureBox pbCor;
        private System.Windows.Forms.Label lbCor;
        private System.Windows.Forms.TextBox tbCor;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.PictureBox pbFiltrar;
        private System.Windows.Forms.Label lbDataInicial;
        private System.Windows.Forms.Label lbDataFinal;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.PictureBox pbTamanho;
        private System.Windows.Forms.TextBox tbTamanho;
        private System.Windows.Forms.Label lbTamanho;
        private System.Windows.Forms.PictureBox pbImagemProduto;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Button btEntradaEstoque;
        private System.Windows.Forms.PictureBox pbLimpar;
        private System.Windows.Forms.Panel painelCusto;
        private System.Windows.Forms.Label lbTituloTotalEstoque;
        private System.Windows.Forms.Label lbTotalEstoque;
        private System.Windows.Forms.Panel painelQuantidade;
        private System.Windows.Forms.Label lbTituloQuantidade;
        private System.Windows.Forms.Label lbQuantidadeEstoque;
        private System.Windows.Forms.Panel painelVenda;
        private System.Windows.Forms.Label lbTituloTotalVenda;
        private System.Windows.Forms.Label lbVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProdutoCor;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenciaProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn corProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeTamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedorProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoCustoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoVendaProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBarrasProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagemProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn custoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalVenda;
        private System.Windows.Forms.Panel painelFiltros;
        private System.Windows.Forms.Button btCodigoBarras;
    }
}