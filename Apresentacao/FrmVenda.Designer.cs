namespace Apresentacao
{
    partial class FrmVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenda));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imgListaVenda = new System.Windows.Forms.ImageList(this.components);
            this.dgvItemVenda = new System.Windows.Forms.DataGridView();
            this.marcarItem = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.codigoItemVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoProdutoCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenciaProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoTamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeTamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoCustoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoVendaProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoBarrasProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagemProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbPrecoVenda = new System.Windows.Forms.Label();
            this.mtbPrecoVendaBarras = new System.Windows.Forms.MaskedTextBox();
            this.lbQuantidadeBarras = new System.Windows.Forms.Label();
            this.cbAtivarBarras = new System.Windows.Forms.CheckBox();
            this.tbCodigoBarras = new System.Windows.Forms.TextBox();
            this.cbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.lbFormaPagamento = new System.Windows.Forms.Label();
            this.painelTroco = new System.Windows.Forms.Panel();
            this.lbTituloTroco = new System.Windows.Forms.Label();
            this.lbTroco = new System.Windows.Forms.Label();
            this.painelTaxa = new System.Windows.Forms.Panel();
            this.lbTaxaJuros = new System.Windows.Forms.Label();
            this.lbTituloTaxa = new System.Windows.Forms.Label();
            this.lbTaxa = new System.Windows.Forms.Label();
            this.painelDesconto = new System.Windows.Forms.Panel();
            this.lbTituloDesconto = new System.Windows.Forms.Label();
            this.lbDesconto = new System.Windows.Forms.Label();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.btCrediario = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btParcial = new System.Windows.Forms.Button();
            this.gbVenda = new System.Windows.Forms.GroupBox();
            this.cbJuros = new System.Windows.Forms.CheckBox();
            this.pbFormaPagamento = new System.Windows.Forms.PictureBox();
            this.painelTotalVenda = new System.Windows.Forms.Panel();
            this.pbCalculadora = new System.Windows.Forms.PictureBox();
            this.lbVendaLiquido = new System.Windows.Forms.Label();
            this.panelCalculoVenda = new System.Windows.Forms.Panel();
            this.lbDescontoVenda = new System.Windows.Forms.Label();
            this.lbJurosVenda = new System.Windows.Forms.Label();
            this.lbTituloTotalVenda = new System.Windows.Forms.Label();
            this.lbValorTotalVenda = new System.Windows.Forms.Label();
            this.panelBuscarProduto = new System.Windows.Forms.Panel();
            this.tbBuscarProduto = new System.Windows.Forms.TextBox();
            this.dtpVenda = new System.Windows.Forms.DateTimePicker();
            this.panelFuncionario = new System.Windows.Forms.Panel();
            this.btFuncionario = new System.Windows.Forms.Button();
            this.tbFuncionario = new System.Windows.Forms.TextBox();
            this.panelBuscarCliente = new System.Windows.Forms.Panel();
            this.btCliente = new System.Windows.Forms.Button();
            this.tbBuscarCliente = new System.Windows.Forms.TextBox();
            this.gbPagamento = new System.Windows.Forms.GroupBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.tbValorPago = new System.Windows.Forms.TextBox();
            this.lbValorPago = new System.Windows.Forms.Label();
            this.btDesconto = new System.Windows.Forms.Button();
            this.nudDesconto = new System.Windows.Forms.NumericUpDown();
            this.lbDescontoNum = new System.Windows.Forms.Label();
            this.tbQuantidadeBarras = new System.Windows.Forms.NumericUpDown();
            this.lbDinheiro = new System.Windows.Forms.Label();
            this.lbTituloTotal = new System.Windows.Forms.Label();
            this.painelDinheiro = new System.Windows.Forms.Panel();
            this.pbCrediario = new System.Windows.Forms.PictureBox();
            this.pbParcial = new System.Windows.Forms.PictureBox();
            this.pbEstoque = new System.Windows.Forms.PictureBox();
            this.pbFuncionario = new System.Windows.Forms.PictureBox();
            this.pbImagemProduto = new System.Windows.Forms.PictureBox();
            this.pbProduto = new System.Windows.Forms.PictureBox();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.pbBuscarBarras = new System.Windows.Forms.PictureBox();
            this.pbLancar = new System.Windows.Forms.PictureBox();
            this.toolTipVenda = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemVenda)).BeginInit();
            this.painelTroco.SuspendLayout();
            this.painelTaxa.SuspendLayout();
            this.painelDesconto.SuspendLayout();
            this.gbVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormaPagamento)).BeginInit();
            this.painelTotalVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCalculadora)).BeginInit();
            this.gbPagamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesconto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuantidadeBarras)).BeginInit();
            this.painelDinheiro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrediario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbParcial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarBarras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLancar)).BeginInit();
            this.SuspendLayout();
            // 
            // imgListaVenda
            // 
            this.imgListaVenda.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListaVenda.ImageStream")));
            this.imgListaVenda.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListaVenda.Images.SetKeyName(0, "Cliente.png");
            this.imgListaVenda.Images.SetKeyName(1, "Crediario.png");
            this.imgListaVenda.Images.SetKeyName(2, "Estoque.png");
            this.imgListaVenda.Images.SetKeyName(3, "Funcionario.png");
            this.imgListaVenda.Images.SetKeyName(4, "Produto.png");
            this.imgListaVenda.Images.SetKeyName(5, "Venda.png");
            this.imgListaVenda.Images.SetKeyName(6, "RegistrarVenda.png");
            this.imgListaVenda.Images.SetKeyName(7, "iconeProdutoBranco.png");
            this.imgListaVenda.Images.SetKeyName(8, "Desconto.png");
            // 
            // dgvItemVenda
            // 
            this.dgvItemVenda.AllowUserToAddRows = false;
            this.dgvItemVenda.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dgvItemVenda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItemVenda.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemVenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItemVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.marcarItem,
            this.codigoItemVenda,
            this.codigoProduto,
            this.codigoProdutoCor,
            this.descricaoProduto,
            this.referenciaProduto,
            this.sexoProduto,
            this.corProduto,
            this.generoProduto,
            this.codigoTamanho,
            this.nomeTamanho,
            this.quantidadeProduto,
            this.precoCustoProduto,
            this.precoVendaProduto,
            this.totalVenda,
            this.codigoBarrasProduto,
            this.imagemProduto});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItemVenda.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvItemVenda.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvItemVenda.Location = new System.Drawing.Point(12, 166);
            this.dgvItemVenda.Name = "dgvItemVenda";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.dgvItemVenda.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvItemVenda.RowTemplate.Height = 24;
            this.dgvItemVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemVenda.Size = new System.Drawing.Size(1514, 460);
            this.dgvItemVenda.TabIndex = 8;
            this.dgvItemVenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemVenda_CellClick);
            this.dgvItemVenda.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvItemVenda_CellMouseDoubleClick);
            this.dgvItemVenda.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvItemVenda_ColumnHeaderMouseClick);
            // 
            // marcarItem
            // 
            this.marcarItem.HeaderText = "...";
            this.marcarItem.Name = "marcarItem";
            this.marcarItem.Width = 30;
            // 
            // codigoItemVenda
            // 
            this.codigoItemVenda.HeaderText = "CodItemVenda";
            this.codigoItemVenda.Name = "codigoItemVenda";
            this.codigoItemVenda.ReadOnly = true;
            this.codigoItemVenda.ToolTipText = "Código da Item Venda";
            this.codigoItemVenda.Visible = false;
            this.codigoItemVenda.Width = 40;
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
            // quantidadeProduto
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.quantidadeProduto.DefaultCellStyle = dataGridViewCellStyle3;
            this.quantidadeProduto.HeaderText = "Quant";
            this.quantidadeProduto.Name = "quantidadeProduto";
            this.quantidadeProduto.ReadOnly = true;
            this.quantidadeProduto.ToolTipText = "Quantidade do Produto";
            this.quantidadeProduto.Width = 60;
            // 
            // precoCustoProduto
            // 
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.precoCustoProduto.DefaultCellStyle = dataGridViewCellStyle4;
            this.precoCustoProduto.HeaderText = "Custo R$";
            this.precoCustoProduto.Name = "precoCustoProduto";
            this.precoCustoProduto.ReadOnly = true;
            this.precoCustoProduto.Visible = false;
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
            // totalVenda
            // 
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.totalVenda.DefaultCellStyle = dataGridViewCellStyle6;
            this.totalVenda.HeaderText = "Total R$";
            this.totalVenda.Name = "totalVenda";
            this.totalVenda.ReadOnly = true;
            this.totalVenda.ToolTipText = "Total do Item Venda";
            this.totalVenda.Width = 90;
            // 
            // codigoBarrasProduto
            // 
            this.codigoBarrasProduto.HeaderText = "Barras";
            this.codigoBarrasProduto.Name = "codigoBarrasProduto";
            this.codigoBarrasProduto.ReadOnly = true;
            this.codigoBarrasProduto.ToolTipText = "Código de Barras do Produto";
            this.codigoBarrasProduto.Width = 110;
            // 
            // imagemProduto
            // 
            this.imagemProduto.HeaderText = "imagem";
            this.imagemProduto.Name = "imagemProduto";
            this.imagemProduto.ToolTipText = "Imagem do Produto";
            this.imagemProduto.Visible = false;
            // 
            // lbPrecoVenda
            // 
            this.lbPrecoVenda.AutoSize = true;
            this.lbPrecoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbPrecoVenda.Location = new System.Drawing.Point(624, 108);
            this.lbPrecoVenda.Name = "lbPrecoVenda";
            this.lbPrecoVenda.Size = new System.Drawing.Size(82, 20);
            this.lbPrecoVenda.TabIndex = 5;
            this.lbPrecoVenda.Text = "Venda R$";
            // 
            // mtbPrecoVendaBarras
            // 
            this.mtbPrecoVendaBarras.Enabled = false;
            this.mtbPrecoVendaBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.mtbPrecoVendaBarras.Location = new System.Drawing.Point(628, 133);
            this.mtbPrecoVendaBarras.Name = "mtbPrecoVendaBarras";
            this.mtbPrecoVendaBarras.Size = new System.Drawing.Size(95, 27);
            this.mtbPrecoVendaBarras.TabIndex = 6;
            this.mtbPrecoVendaBarras.TextChanged += new System.EventHandler(this.mtbPrecoVendaBarras_TextChanged);
            // 
            // lbQuantidadeBarras
            // 
            this.lbQuantidadeBarras.AutoSize = true;
            this.lbQuantidadeBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbQuantidadeBarras.Location = new System.Drawing.Point(546, 108);
            this.lbQuantidadeBarras.Name = "lbQuantidadeBarras";
            this.lbQuantidadeBarras.Size = new System.Drawing.Size(65, 20);
            this.lbQuantidadeBarras.TabIndex = 3;
            this.lbQuantidadeBarras.Text = "Volume";
            // 
            // cbAtivarBarras
            // 
            this.cbAtivarBarras.AutoSize = true;
            this.cbAtivarBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAtivarBarras.Location = new System.Drawing.Point(353, 107);
            this.cbAtivarBarras.Name = "cbAtivarBarras";
            this.cbAtivarBarras.Size = new System.Drawing.Size(167, 21);
            this.cbAtivarBarras.TabIndex = 1;
            this.cbAtivarBarras.Text = "Código Barras  &Ent";
            this.cbAtivarBarras.UseVisualStyleBackColor = true;
            this.cbAtivarBarras.CheckedChanged += new System.EventHandler(this.cbAtivarBarras_CheckedChanged);
            // 
            // tbCodigoBarras
            // 
            this.tbCodigoBarras.Enabled = false;
            this.tbCodigoBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbCodigoBarras.Location = new System.Drawing.Point(353, 133);
            this.tbCodigoBarras.Name = "tbCodigoBarras";
            this.tbCodigoBarras.Size = new System.Drawing.Size(191, 27);
            this.tbCodigoBarras.TabIndex = 2;
            this.tbCodigoBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodigoBarras_KeyPress);
            // 
            // cbFormaPagamento
            // 
            this.cbFormaPagamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFormaPagamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFormaPagamento.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaPagamento.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.cbFormaPagamento.FormattingEnabled = true;
            this.cbFormaPagamento.Location = new System.Drawing.Point(4, 39);
            this.cbFormaPagamento.Name = "cbFormaPagamento";
            this.cbFormaPagamento.Size = new System.Drawing.Size(163, 30);
            this.cbFormaPagamento.TabIndex = 2;
            this.cbFormaPagamento.DropDown += new System.EventHandler(this.cbFormaPagamento_DropDown);
            this.cbFormaPagamento.SelectedValueChanged += new System.EventHandler(this.cbFormaPagamento_SelectedValueChanged);
            // 
            // lbFormaPagamento
            // 
            this.lbFormaPagamento.AutoSize = true;
            this.lbFormaPagamento.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.lbFormaPagamento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbFormaPagamento.Location = new System.Drawing.Point(1, 20);
            this.lbFormaPagamento.Name = "lbFormaPagamento";
            this.lbFormaPagamento.Size = new System.Drawing.Size(134, 16);
            this.lbFormaPagamento.TabIndex = 0;
            this.lbFormaPagamento.Text = "Forma Pagamento";
            // 
            // painelTroco
            // 
            this.painelTroco.AutoScroll = true;
            this.painelTroco.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.painelTroco.Controls.Add(this.lbTituloTroco);
            this.painelTroco.Controls.Add(this.lbTroco);
            this.painelTroco.Location = new System.Drawing.Point(199, 632);
            this.painelTroco.Name = "painelTroco";
            this.painelTroco.Size = new System.Drawing.Size(181, 74);
            this.painelTroco.TabIndex = 20;
            // 
            // lbTituloTroco
            // 
            this.lbTituloTroco.AutoSize = true;
            this.lbTituloTroco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTituloTroco.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTituloTroco.Location = new System.Drawing.Point(6, 7);
            this.lbTituloTroco.Name = "lbTituloTroco";
            this.lbTituloTroco.Size = new System.Drawing.Size(83, 24);
            this.lbTituloTroco.TabIndex = 0;
            this.lbTituloTroco.Text = "Troco +";
            this.lbTituloTroco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTroco
            // 
            this.lbTroco.AutoSize = true;
            this.lbTroco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTroco.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTroco.Location = new System.Drawing.Point(28, 39);
            this.lbTroco.Name = "lbTroco";
            this.lbTroco.Size = new System.Drawing.Size(80, 24);
            this.lbTroco.TabIndex = 1;
            this.lbTroco.Text = "R$ 0,00";
            this.lbTroco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // painelTaxa
            // 
            this.painelTaxa.AutoScroll = true;
            this.painelTaxa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.painelTaxa.Controls.Add(this.lbTaxaJuros);
            this.painelTaxa.Controls.Add(this.lbTituloTaxa);
            this.painelTaxa.Controls.Add(this.lbTaxa);
            this.painelTaxa.Location = new System.Drawing.Point(170, 24);
            this.painelTaxa.Name = "painelTaxa";
            this.painelTaxa.Size = new System.Drawing.Size(181, 74);
            this.painelTaxa.TabIndex = 1;
            // 
            // lbTaxaJuros
            // 
            this.lbTaxaJuros.AutoSize = true;
            this.lbTaxaJuros.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTaxaJuros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTaxaJuros.Location = new System.Drawing.Point(94, 7);
            this.lbTaxaJuros.Name = "lbTaxaJuros";
            this.lbTaxaJuros.Size = new System.Drawing.Size(49, 24);
            this.lbTaxaJuros.TabIndex = 2;
            this.lbTaxaJuros.Text = "0,00";
            this.lbTaxaJuros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTituloTaxa
            // 
            this.lbTituloTaxa.AutoSize = true;
            this.lbTituloTaxa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTituloTaxa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTituloTaxa.Location = new System.Drawing.Point(3, 7);
            this.lbTituloTaxa.Name = "lbTituloTaxa";
            this.lbTituloTaxa.Size = new System.Drawing.Size(85, 24);
            this.lbTituloTaxa.TabIndex = 0;
            this.lbTituloTaxa.Text = "Taxa% -";
            this.lbTituloTaxa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTaxa
            // 
            this.lbTaxa.AutoSize = true;
            this.lbTaxa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTaxa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTaxa.Location = new System.Drawing.Point(28, 39);
            this.lbTaxa.Name = "lbTaxa";
            this.lbTaxa.Size = new System.Drawing.Size(80, 24);
            this.lbTaxa.TabIndex = 1;
            this.lbTaxa.Text = "R$ 0,00";
            this.lbTaxa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // painelDesconto
            // 
            this.painelDesconto.AutoScroll = true;
            this.painelDesconto.BackColor = System.Drawing.Color.DeepPink;
            this.painelDesconto.Controls.Add(this.lbTituloDesconto);
            this.painelDesconto.Controls.Add(this.lbDesconto);
            this.painelDesconto.Location = new System.Drawing.Point(386, 632);
            this.painelDesconto.Name = "painelDesconto";
            this.painelDesconto.Size = new System.Drawing.Size(181, 74);
            this.painelDesconto.TabIndex = 21;
            // 
            // lbTituloDesconto
            // 
            this.lbTituloDesconto.AutoSize = true;
            this.lbTituloDesconto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTituloDesconto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTituloDesconto.Location = new System.Drawing.Point(3, 7);
            this.lbTituloDesconto.Name = "lbTituloDesconto";
            this.lbTituloDesconto.Size = new System.Drawing.Size(113, 24);
            this.lbTituloDesconto.TabIndex = 0;
            this.lbTituloDesconto.Text = "Desconto -";
            this.lbTituloDesconto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDesconto
            // 
            this.lbDesconto.AutoSize = true;
            this.lbDesconto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbDesconto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDesconto.Location = new System.Drawing.Point(28, 39);
            this.lbDesconto.Name = "lbDesconto";
            this.lbDesconto.Size = new System.Drawing.Size(80, 24);
            this.lbDesconto.TabIndex = 1;
            this.lbDesconto.Text = "R$ 0,00";
            this.lbDesconto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btExcluir
            // 
            this.btExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btExcluir.BackColor = System.Drawing.Color.DeepPink;
            this.btExcluir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btExcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btExcluir.Location = new System.Drawing.Point(148, 715);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(130, 42);
            this.btExcluir.TabIndex = 17;
            this.btExcluir.Text = "F2 Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btFinalizar
            // 
            this.btFinalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btFinalizar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btFinalizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFinalizar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btFinalizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btFinalizar.ImageKey = "Cliente.png";
            this.btFinalizar.Location = new System.Drawing.Point(12, 715);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(130, 42);
            this.btFinalizar.TabIndex = 16;
            this.btFinalizar.Text = "F10 Finalizar";
            this.btFinalizar.UseVisualStyleBackColor = false;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // btCrediario
            // 
            this.btCrediario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCrediario.BackColor = System.Drawing.Color.Yellow;
            this.btCrediario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCrediario.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCrediario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btCrediario.Location = new System.Drawing.Point(545, 76);
            this.btCrediario.Name = "btCrediario";
            this.btCrediario.Size = new System.Drawing.Size(130, 42);
            this.btCrediario.TabIndex = 6;
            this.btCrediario.Text = "F4 Crediario";
            this.btCrediario.UseVisualStyleBackColor = false;
            this.btCrediario.Click += new System.EventHandler(this.btCrediario_Click);
            // 
            // btSair
            // 
            this.btSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSair.BackColor = System.Drawing.Color.Red;
            this.btSair.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSair.Location = new System.Drawing.Point(817, 76);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(130, 42);
            this.btSair.TabIndex = 8;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btParcial
            // 
            this.btParcial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btParcial.BackColor = System.Drawing.Color.Turquoise;
            this.btParcial.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btParcial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btParcial.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btParcial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btParcial.Location = new System.Drawing.Point(409, 76);
            this.btParcial.Name = "btParcial";
            this.btParcial.Size = new System.Drawing.Size(130, 42);
            this.btParcial.TabIndex = 5;
            this.btParcial.Text = "F12 Parcial";
            this.btParcial.UseVisualStyleBackColor = false;
            this.btParcial.Click += new System.EventHandler(this.btParcial_Click);
            // 
            // gbVenda
            // 
            this.gbVenda.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbVenda.Controls.Add(this.cbJuros);
            this.gbVenda.Controls.Add(this.pbFormaPagamento);
            this.gbVenda.Controls.Add(this.cbFormaPagamento);
            this.gbVenda.Controls.Add(this.lbFormaPagamento);
            this.gbVenda.Controls.Add(this.painelTaxa);
            this.gbVenda.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.gbVenda.Location = new System.Drawing.Point(971, 48);
            this.gbVenda.Name = "gbVenda";
            this.gbVenda.Size = new System.Drawing.Size(357, 112);
            this.gbVenda.TabIndex = 8;
            this.gbVenda.TabStop = false;
            this.gbVenda.Text = "Venda";
            // 
            // cbJuros
            // 
            this.cbJuros.AutoSize = true;
            this.cbJuros.Checked = true;
            this.cbJuros.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbJuros.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.cbJuros.Location = new System.Drawing.Point(37, 82);
            this.cbJuros.Name = "cbJuros";
            this.cbJuros.Size = new System.Drawing.Size(102, 20);
            this.cbJuros.TabIndex = 3;
            this.cbJuros.Text = "Add Taxa%";
            this.cbJuros.UseVisualStyleBackColor = true;
            this.cbJuros.CheckedChanged += new System.EventHandler(this.cbJuros_CheckedChanged);
            // 
            // pbFormaPagamento
            // 
            this.pbFormaPagamento.Image = global::Apresentacao.Properties.Resources.TaxaIAzul;
            this.pbFormaPagamento.Location = new System.Drawing.Point(4, 75);
            this.pbFormaPagamento.Name = "pbFormaPagamento";
            this.pbFormaPagamento.Size = new System.Drawing.Size(27, 27);
            this.pbFormaPagamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFormaPagamento.TabIndex = 143;
            this.pbFormaPagamento.TabStop = false;
            this.toolTipVenda.SetToolTip(this.pbFormaPagamento, "Formlário Forma Pagamento");
            this.pbFormaPagamento.Click += new System.EventHandler(this.pbFormaPagamento_Click);
            // 
            // painelTotalVenda
            // 
            this.painelTotalVenda.AutoScroll = true;
            this.painelTotalVenda.BackColor = System.Drawing.Color.White;
            this.painelTotalVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelTotalVenda.Controls.Add(this.pbCalculadora);
            this.painelTotalVenda.Controls.Add(this.lbVendaLiquido);
            this.painelTotalVenda.Controls.Add(this.panelCalculoVenda);
            this.painelTotalVenda.Controls.Add(this.lbDescontoVenda);
            this.painelTotalVenda.Controls.Add(this.lbJurosVenda);
            this.painelTotalVenda.Controls.Add(this.lbTituloTotalVenda);
            this.painelTotalVenda.Controls.Add(this.lbValorTotalVenda);
            this.painelTotalVenda.Location = new System.Drawing.Point(762, 58);
            this.painelTotalVenda.Name = "painelTotalVenda";
            this.painelTotalVenda.Size = new System.Drawing.Size(203, 102);
            this.painelTotalVenda.TabIndex = 7;
            // 
            // pbCalculadora
            // 
            this.pbCalculadora.Image = global::Apresentacao.Properties.Resources.Calculator;
            this.pbCalculadora.Location = new System.Drawing.Point(24, 48);
            this.pbCalculadora.Name = "pbCalculadora";
            this.pbCalculadora.Size = new System.Drawing.Size(34, 34);
            this.pbCalculadora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCalculadora.TabIndex = 142;
            this.pbCalculadora.TabStop = false;
            this.pbCalculadora.Click += new System.EventHandler(this.pbCalculadora_Click);
            // 
            // lbVendaLiquido
            // 
            this.lbVendaLiquido.AutoSize = true;
            this.lbVendaLiquido.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbVendaLiquido.ForeColor = System.Drawing.Color.Black;
            this.lbVendaLiquido.Location = new System.Drawing.Point(77, 78);
            this.lbVendaLiquido.Name = "lbVendaLiquido";
            this.lbVendaLiquido.Size = new System.Drawing.Size(71, 18);
            this.lbVendaLiquido.TabIndex = 4;
            this.lbVendaLiquido.Text = "   R$ 0,00";
            this.lbVendaLiquido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCalculoVenda
            // 
            this.panelCalculoVenda.BackColor = System.Drawing.Color.Black;
            this.panelCalculoVenda.Location = new System.Drawing.Point(77, 73);
            this.panelCalculoVenda.Name = "panelCalculoVenda";
            this.panelCalculoVenda.Size = new System.Drawing.Size(115, 2);
            this.panelCalculoVenda.TabIndex = 5;
            // 
            // lbDescontoVenda
            // 
            this.lbDescontoVenda.AutoSize = true;
            this.lbDescontoVenda.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbDescontoVenda.ForeColor = System.Drawing.Color.Black;
            this.lbDescontoVenda.Location = new System.Drawing.Point(77, 52);
            this.lbDescontoVenda.Name = "lbDescontoVenda";
            this.lbDescontoVenda.Size = new System.Drawing.Size(72, 18);
            this.lbDescontoVenda.TabIndex = 3;
            this.lbDescontoVenda.Text = " - R$ 0,00";
            this.lbDescontoVenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbJurosVenda
            // 
            this.lbJurosVenda.AutoSize = true;
            this.lbJurosVenda.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbJurosVenda.ForeColor = System.Drawing.Color.Black;
            this.lbJurosVenda.Location = new System.Drawing.Point(77, 29);
            this.lbJurosVenda.Name = "lbJurosVenda";
            this.lbJurosVenda.Size = new System.Drawing.Size(72, 18);
            this.lbJurosVenda.TabIndex = 2;
            this.lbJurosVenda.Text = "%R$ 0,00";
            this.lbJurosVenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTituloTotalVenda
            // 
            this.lbTituloTotalVenda.AutoSize = true;
            this.lbTituloTotalVenda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTituloTotalVenda.ForeColor = System.Drawing.Color.Black;
            this.lbTituloTotalVenda.Location = new System.Drawing.Point(3, 7);
            this.lbTituloTotalVenda.Name = "lbTituloTotalVenda";
            this.lbTituloTotalVenda.Size = new System.Drawing.Size(68, 24);
            this.lbTituloTotalVenda.TabIndex = 0;
            this.lbTituloTotalVenda.Text = "Venda";
            this.lbTituloTotalVenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbValorTotalVenda
            // 
            this.lbValorTotalVenda.AutoSize = true;
            this.lbValorTotalVenda.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbValorTotalVenda.ForeColor = System.Drawing.Color.Black;
            this.lbValorTotalVenda.Location = new System.Drawing.Point(77, 7);
            this.lbValorTotalVenda.Name = "lbValorTotalVenda";
            this.lbValorTotalVenda.Size = new System.Drawing.Size(72, 18);
            this.lbValorTotalVenda.TabIndex = 1;
            this.lbValorTotalVenda.Text = "+ R$ 0,00";
            this.lbValorTotalVenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBuscarProduto
            // 
            this.panelBuscarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelBuscarProduto.Location = new System.Drawing.Point(12, 158);
            this.panelBuscarProduto.Name = "panelBuscarProduto";
            this.panelBuscarProduto.Size = new System.Drawing.Size(304, 2);
            this.panelBuscarProduto.TabIndex = 7;
            // 
            // tbBuscarProduto
            // 
            this.tbBuscarProduto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbBuscarProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBuscarProduto.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbBuscarProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbBuscarProduto.Location = new System.Drawing.Point(12, 135);
            this.tbBuscarProduto.Name = "tbBuscarProduto";
            this.tbBuscarProduto.Size = new System.Drawing.Size(302, 20);
            this.tbBuscarProduto.TabIndex = 0;
            this.tbBuscarProduto.Text = "Digite a descrição do produto ...";
            this.tbBuscarProduto.Enter += new System.EventHandler(this.tbBuscarProduto_Enter);
            this.tbBuscarProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscarProduto_KeyPress);
            this.tbBuscarProduto.Leave += new System.EventHandler(this.tbBuscarProduto_Leave);
            // 
            // dtpVenda
            // 
            this.dtpVenda.Enabled = false;
            this.dtpVenda.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.dtpVenda.Location = new System.Drawing.Point(866, 12);
            this.dtpVenda.Name = "dtpVenda";
            this.dtpVenda.Size = new System.Drawing.Size(357, 27);
            this.dtpVenda.TabIndex = 15;
            // 
            // panelFuncionario
            // 
            this.panelFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelFuncionario.Location = new System.Drawing.Point(439, 50);
            this.panelFuncionario.Name = "panelFuncionario";
            this.panelFuncionario.Size = new System.Drawing.Size(344, 2);
            this.panelFuncionario.TabIndex = 14;
            // 
            // btFuncionario
            // 
            this.btFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btFuncionario.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFuncionario.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            this.btFuncionario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btFuncionario.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btFuncionario.ImageKey = "Cliente.png";
            this.btFuncionario.Location = new System.Drawing.Point(787, 11);
            this.btFuncionario.Name = "btFuncionario";
            this.btFuncionario.Size = new System.Drawing.Size(73, 42);
            this.btFuncionario.TabIndex = 12;
            this.btFuncionario.Text = "Buscar";
            this.btFuncionario.UseVisualStyleBackColor = false;
            this.btFuncionario.Click += new System.EventHandler(this.btFuncionario_Click);
            // 
            // tbFuncionario
            // 
            this.tbFuncionario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFuncionario.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbFuncionario.Location = new System.Drawing.Point(479, 26);
            this.tbFuncionario.Name = "tbFuncionario";
            this.tbFuncionario.Size = new System.Drawing.Size(302, 20);
            this.tbFuncionario.TabIndex = 11;
            this.tbFuncionario.Text = "Digite o nome do funcionário ...";
            this.tbFuncionario.Enter += new System.EventHandler(this.tbFuncionario_Enter);
            this.tbFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFuncionario_KeyPress);
            this.tbFuncionario.Leave += new System.EventHandler(this.tbFuncionario_Leave);
            // 
            // panelBuscarCliente
            // 
            this.panelBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelBuscarCliente.Location = new System.Drawing.Point(12, 50);
            this.panelBuscarCliente.Name = "panelBuscarCliente";
            this.panelBuscarCliente.Size = new System.Drawing.Size(344, 2);
            this.panelBuscarCliente.TabIndex = 13;
            // 
            // btCliente
            // 
            this.btCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btCliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCliente.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            this.btCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCliente.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btCliente.ImageKey = "Cliente.png";
            this.btCliente.Location = new System.Drawing.Point(360, 10);
            this.btCliente.Name = "btCliente";
            this.btCliente.Size = new System.Drawing.Size(73, 42);
            this.btCliente.TabIndex = 10;
            this.btCliente.Text = "Buscar";
            this.btCliente.UseVisualStyleBackColor = false;
            this.btCliente.Click += new System.EventHandler(this.btCliente_Click);
            // 
            // tbBuscarCliente
            // 
            this.tbBuscarCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBuscarCliente.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbBuscarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbBuscarCliente.Location = new System.Drawing.Point(52, 27);
            this.tbBuscarCliente.Name = "tbBuscarCliente";
            this.tbBuscarCliente.Size = new System.Drawing.Size(302, 20);
            this.tbBuscarCliente.TabIndex = 9;
            this.tbBuscarCliente.Text = "Digite o nome do cliente ...";
            this.tbBuscarCliente.Enter += new System.EventHandler(this.tbBuscarCliente_Enter);
            this.tbBuscarCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscarCliente_KeyPress);
            this.tbBuscarCliente.Leave += new System.EventHandler(this.tbBuscarCliente_Leave);
            // 
            // gbPagamento
            // 
            this.gbPagamento.Controls.Add(this.btCancelar);
            this.gbPagamento.Controls.Add(this.btCrediario);
            this.gbPagamento.Controls.Add(this.btSair);
            this.gbPagamento.Controls.Add(this.btParcial);
            this.gbPagamento.Controls.Add(this.tbValorPago);
            this.gbPagamento.Controls.Add(this.lbValorPago);
            this.gbPagamento.Controls.Add(this.btDesconto);
            this.gbPagamento.Controls.Add(this.nudDesconto);
            this.gbPagamento.Controls.Add(this.lbDescontoNum);
            this.gbPagamento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.gbPagamento.Location = new System.Drawing.Point(573, 632);
            this.gbPagamento.Name = "gbPagamento";
            this.gbPagamento.Size = new System.Drawing.Size(953, 125);
            this.gbPagamento.TabIndex = 18;
            this.gbPagamento.TabStop = false;
            this.gbPagamento.Text = "Pagamento";
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCancelar.Location = new System.Drawing.Point(681, 76);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(130, 42);
            this.btCancelar.TabIndex = 7;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // tbValorPago
            // 
            this.tbValorPago.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold);
            this.tbValorPago.Location = new System.Drawing.Point(9, 68);
            this.tbValorPago.Name = "tbValorPago";
            this.tbValorPago.Size = new System.Drawing.Size(245, 50);
            this.tbValorPago.TabIndex = 1;
            this.tbValorPago.Text = "0,00";
            this.tbValorPago.TextChanged += new System.EventHandler(this.tbValorPago_TextChanged);
            // 
            // lbValorPago
            // 
            this.lbValorPago.AutoSize = true;
            this.lbValorPago.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbValorPago.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbValorPago.Location = new System.Drawing.Point(5, 44);
            this.lbValorPago.Name = "lbValorPago";
            this.lbValorPago.Size = new System.Drawing.Size(120, 19);
            this.lbValorPago.TabIndex = 0;
            this.lbValorPago.Text = "Valor Pago R$";
            // 
            // btDesconto
            // 
            this.btDesconto.BackColor = System.Drawing.Color.DeepPink;
            this.btDesconto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btDesconto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDesconto.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btDesconto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDesconto.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btDesconto.ImageKey = "Desconto.png";
            this.btDesconto.ImageList = this.imgListaVenda;
            this.btDesconto.Location = new System.Drawing.Point(260, 76);
            this.btDesconto.Name = "btDesconto";
            this.btDesconto.Size = new System.Drawing.Size(130, 42);
            this.btDesconto.TabIndex = 4;
            this.btDesconto.Text = "Desconto %";
            this.btDesconto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDesconto.UseVisualStyleBackColor = false;
            this.btDesconto.Click += new System.EventHandler(this.btDesconto_Click);
            // 
            // nudDesconto
            // 
            this.nudDesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudDesconto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.nudDesconto.Location = new System.Drawing.Point(300, 40);
            this.nudDesconto.Name = "nudDesconto";
            this.nudDesconto.Size = new System.Drawing.Size(90, 30);
            this.nudDesconto.TabIndex = 3;
            this.nudDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudDesconto_KeyPress);
            // 
            // lbDescontoNum
            // 
            this.lbDescontoNum.AutoSize = true;
            this.lbDescontoNum.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbDescontoNum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDescontoNum.Location = new System.Drawing.Point(297, 19);
            this.lbDescontoNum.Name = "lbDescontoNum";
            this.lbDescontoNum.Size = new System.Drawing.Size(93, 18);
            this.lbDescontoNum.TabIndex = 2;
            this.lbDescontoNum.Text = "Desconto %";
            // 
            // tbQuantidadeBarras
            // 
            this.tbQuantidadeBarras.Enabled = false;
            this.tbQuantidadeBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbQuantidadeBarras.Location = new System.Drawing.Point(550, 133);
            this.tbQuantidadeBarras.Name = "tbQuantidadeBarras";
            this.tbQuantidadeBarras.Size = new System.Drawing.Size(72, 27);
            this.tbQuantidadeBarras.TabIndex = 4;
            this.tbQuantidadeBarras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbDinheiro
            // 
            this.lbDinheiro.AutoSize = true;
            this.lbDinheiro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbDinheiro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDinheiro.Location = new System.Drawing.Point(36, 39);
            this.lbDinheiro.Name = "lbDinheiro";
            this.lbDinheiro.Size = new System.Drawing.Size(80, 24);
            this.lbDinheiro.TabIndex = 1;
            this.lbDinheiro.Text = "R$ 0,00";
            this.lbDinheiro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTituloTotal
            // 
            this.lbTituloTotal.AutoSize = true;
            this.lbTituloTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTituloTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTituloTotal.Location = new System.Drawing.Point(3, 7);
            this.lbTituloTotal.Name = "lbTituloTotal";
            this.lbTituloTotal.Size = new System.Drawing.Size(119, 24);
            this.lbTituloTotal.TabIndex = 0;
            this.lbTituloTotal.Text = "Receber R$";
            this.lbTituloTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // painelDinheiro
            // 
            this.painelDinheiro.AutoScroll = true;
            this.painelDinheiro.BackColor = System.Drawing.Color.Turquoise;
            this.painelDinheiro.Controls.Add(this.lbTituloTotal);
            this.painelDinheiro.Controls.Add(this.lbDinheiro);
            this.painelDinheiro.Location = new System.Drawing.Point(12, 632);
            this.painelDinheiro.Name = "painelDinheiro";
            this.painelDinheiro.Size = new System.Drawing.Size(181, 74);
            this.painelDinheiro.TabIndex = 19;
            // 
            // pbCrediario
            // 
            this.pbCrediario.Image = global::Apresentacao.Properties.Resources.imgCrediarioBotao;
            this.pbCrediario.Location = new System.Drawing.Point(1235, 12);
            this.pbCrediario.Name = "pbCrediario";
            this.pbCrediario.Size = new System.Drawing.Size(27, 27);
            this.pbCrediario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCrediario.TabIndex = 144;
            this.pbCrediario.TabStop = false;
            this.toolTipVenda.SetToolTip(this.pbCrediario, "Formulário Crediário");
            this.pbCrediario.Click += new System.EventHandler(this.pbCrediario_Click);
            // 
            // pbParcial
            // 
            this.pbParcial.Image = global::Apresentacao.Properties.Resources.imgParcialBotao;
            this.pbParcial.Location = new System.Drawing.Point(1268, 12);
            this.pbParcial.Name = "pbParcial";
            this.pbParcial.Size = new System.Drawing.Size(27, 27);
            this.pbParcial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbParcial.TabIndex = 146;
            this.pbParcial.TabStop = false;
            this.toolTipVenda.SetToolTip(this.pbParcial, "Formulário Parcial");
            this.pbParcial.Click += new System.EventHandler(this.pbParcial_Click);
            // 
            // pbEstoque
            // 
            this.pbEstoque.Image = global::Apresentacao.Properties.Resources.imgEstoqueBotao;
            this.pbEstoque.Location = new System.Drawing.Point(1301, 12);
            this.pbEstoque.Name = "pbEstoque";
            this.pbEstoque.Size = new System.Drawing.Size(27, 27);
            this.pbEstoque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEstoque.TabIndex = 145;
            this.pbEstoque.TabStop = false;
            this.toolTipVenda.SetToolTip(this.pbEstoque, "Formulário Estoque");
            this.pbEstoque.Click += new System.EventHandler(this.pbEstoque_Click);
            // 
            // pbFuncionario
            // 
            this.pbFuncionario.Image = global::Apresentacao.Properties.Resources.FuncionarioAzul;
            this.pbFuncionario.Location = new System.Drawing.Point(439, 13);
            this.pbFuncionario.Name = "pbFuncionario";
            this.pbFuncionario.Size = new System.Drawing.Size(34, 34);
            this.pbFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFuncionario.TabIndex = 140;
            this.pbFuncionario.TabStop = false;
            // 
            // pbImagemProduto
            // 
            this.pbImagemProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagemProduto.Image = global::Apresentacao.Properties.Resources.imgDefaut;
            this.pbImagemProduto.Location = new System.Drawing.Point(1334, 12);
            this.pbImagemProduto.Name = "pbImagemProduto";
            this.pbImagemProduto.Size = new System.Drawing.Size(192, 148);
            this.pbImagemProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagemProduto.TabIndex = 100;
            this.pbImagemProduto.TabStop = false;
            // 
            // pbProduto
            // 
            this.pbProduto.Image = global::Apresentacao.Properties.Resources.ProdutoAzul;
            this.pbProduto.Location = new System.Drawing.Point(320, 133);
            this.pbProduto.Name = "pbProduto";
            this.pbProduto.Size = new System.Drawing.Size(27, 27);
            this.pbProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProduto.TabIndex = 99;
            this.pbProduto.TabStop = false;
            this.toolTipVenda.SetToolTip(this.pbProduto, "Formulário Produto");
            this.pbProduto.Click += new System.EventHandler(this.pbProduto_Click);
            // 
            // pbUsuario
            // 
            this.pbUsuario.Image = global::Apresentacao.Properties.Resources.ClienteAzul;
            this.pbUsuario.Location = new System.Drawing.Point(12, 12);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(34, 36);
            this.pbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsuario.TabIndex = 136;
            this.pbUsuario.TabStop = false;
            // 
            // pbBuscarBarras
            // 
            this.pbBuscarBarras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBuscarBarras.Enabled = false;
            this.pbBuscarBarras.Image = global::Apresentacao.Properties.Resources.Selecionar;
            this.pbBuscarBarras.Location = new System.Drawing.Point(517, 133);
            this.pbBuscarBarras.Name = "pbBuscarBarras";
            this.pbBuscarBarras.Size = new System.Drawing.Size(27, 27);
            this.pbBuscarBarras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscarBarras.TabIndex = 76;
            this.pbBuscarBarras.TabStop = false;
            this.pbBuscarBarras.Click += new System.EventHandler(this.pbBuscarBarras_Click);
            // 
            // pbLancar
            // 
            this.pbLancar.Enabled = false;
            this.pbLancar.Image = global::Apresentacao.Properties.Resources.LancarBotao;
            this.pbLancar.Location = new System.Drawing.Point(729, 133);
            this.pbLancar.Name = "pbLancar";
            this.pbLancar.Size = new System.Drawing.Size(27, 27);
            this.pbLancar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLancar.TabIndex = 75;
            this.pbLancar.TabStop = false;
            this.pbLancar.Click += new System.EventHandler(this.pbLancar_Click);
            // 
            // FrmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1540, 769);
            this.Controls.Add(this.pbCrediario);
            this.Controls.Add(this.tbQuantidadeBarras);
            this.Controls.Add(this.gbPagamento);
            this.Controls.Add(this.pbParcial);
            this.Controls.Add(this.pbFuncionario);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.panelFuncionario);
            this.Controls.Add(this.btFinalizar);
            this.Controls.Add(this.btFuncionario);
            this.Controls.Add(this.pbEstoque);
            this.Controls.Add(this.dtpVenda);
            this.Controls.Add(this.painelTotalVenda);
            this.Controls.Add(this.pbImagemProduto);
            this.Controls.Add(this.tbFuncionario);
            this.Controls.Add(this.pbProduto);
            this.Controls.Add(this.pbUsuario);
            this.Controls.Add(this.panelBuscarCliente);
            this.Controls.Add(this.painelTroco);
            this.Controls.Add(this.btCliente);
            this.Controls.Add(this.gbVenda);
            this.Controls.Add(this.tbBuscarCliente);
            this.Controls.Add(this.panelBuscarProduto);
            this.Controls.Add(this.tbBuscarProduto);
            this.Controls.Add(this.painelDesconto);
            this.Controls.Add(this.painelDinheiro);
            this.Controls.Add(this.lbPrecoVenda);
            this.Controls.Add(this.mtbPrecoVendaBarras);
            this.Controls.Add(this.pbBuscarBarras);
            this.Controls.Add(this.pbLancar);
            this.Controls.Add(this.lbQuantidadeBarras);
            this.Controls.Add(this.cbAtivarBarras);
            this.Controls.Add(this.tbCodigoBarras);
            this.Controls.Add(this.dgvItemVenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmVenda_FormClosed);
            this.Load += new System.EventHandler(this.FrmVenda_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmVenda_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemVenda)).EndInit();
            this.painelTroco.ResumeLayout(false);
            this.painelTroco.PerformLayout();
            this.painelTaxa.ResumeLayout(false);
            this.painelTaxa.PerformLayout();
            this.painelDesconto.ResumeLayout(false);
            this.painelDesconto.PerformLayout();
            this.gbVenda.ResumeLayout(false);
            this.gbVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormaPagamento)).EndInit();
            this.painelTotalVenda.ResumeLayout(false);
            this.painelTotalVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCalculadora)).EndInit();
            this.gbPagamento.ResumeLayout(false);
            this.gbPagamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesconto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuantidadeBarras)).EndInit();
            this.painelDinheiro.ResumeLayout(false);
            this.painelDinheiro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrediario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbParcial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarBarras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLancar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imgListaVenda;
        private System.Windows.Forms.DataGridView dgvItemVenda;
        private System.Windows.Forms.Label lbPrecoVenda;
        private System.Windows.Forms.MaskedTextBox mtbPrecoVendaBarras;
        private System.Windows.Forms.PictureBox pbBuscarBarras;
        private System.Windows.Forms.PictureBox pbLancar;
        private System.Windows.Forms.Label lbQuantidadeBarras;
        private System.Windows.Forms.CheckBox cbAtivarBarras;
        private System.Windows.Forms.TextBox tbCodigoBarras;
        private System.Windows.Forms.ComboBox cbFormaPagamento;
        private System.Windows.Forms.Label lbFormaPagamento;
        private System.Windows.Forms.Panel painelTroco;
        private System.Windows.Forms.Label lbTituloTroco;
        private System.Windows.Forms.Label lbTroco;
        private System.Windows.Forms.Panel painelTaxa;
        private System.Windows.Forms.Label lbTituloTaxa;
        private System.Windows.Forms.Label lbTaxa;
        private System.Windows.Forms.Panel painelDesconto;
        private System.Windows.Forms.Label lbTituloDesconto;
        private System.Windows.Forms.Label lbDesconto;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btFinalizar;
        private System.Windows.Forms.GroupBox gbVenda;
        private System.Windows.Forms.PictureBox pbProduto;
        private System.Windows.Forms.Panel panelBuscarProduto;
        private System.Windows.Forms.TextBox tbBuscarProduto;
        private System.Windows.Forms.PictureBox pbImagemProduto;
        private System.Windows.Forms.Panel painelTotalVenda;
        private System.Windows.Forms.Label lbTituloTotalVenda;
        private System.Windows.Forms.Label lbValorTotalVenda;
        private System.Windows.Forms.DateTimePicker dtpVenda;
        private System.Windows.Forms.DataGridViewCheckBoxColumn marcarItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoItemVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProdutoCor;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenciaProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn corProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeTamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoCustoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoVendaProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBarrasProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagemProduto;
        private System.Windows.Forms.Button btParcial;
        private System.Windows.Forms.PictureBox pbFuncionario;
        private System.Windows.Forms.Panel panelFuncionario;
        private System.Windows.Forms.Button btFuncionario;
        private System.Windows.Forms.TextBox tbFuncionario;
        private System.Windows.Forms.PictureBox pbUsuario;
        private System.Windows.Forms.Panel panelBuscarCliente;
        private System.Windows.Forms.Button btCliente;
        private System.Windows.Forms.TextBox tbBuscarCliente;
        private System.Windows.Forms.GroupBox gbPagamento;
        private System.Windows.Forms.TextBox tbValorPago;
        private System.Windows.Forms.Label lbValorPago;
        private System.Windows.Forms.Button btDesconto;
        private System.Windows.Forms.NumericUpDown nudDesconto;
        private System.Windows.Forms.Label lbDescontoNum;
        private System.Windows.Forms.Label lbDescontoVenda;
        private System.Windows.Forms.Label lbJurosVenda;
        private System.Windows.Forms.Label lbVendaLiquido;
        private System.Windows.Forms.Panel panelCalculoVenda;
        private System.Windows.Forms.PictureBox pbCalculadora;
        private System.Windows.Forms.NumericUpDown tbQuantidadeBarras;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.PictureBox pbFormaPagamento;
        private System.Windows.Forms.Label lbTaxaJuros;
        private System.Windows.Forms.CheckBox cbJuros;
        private System.Windows.Forms.Button btCrediario;
        private System.Windows.Forms.Label lbDinheiro;
        private System.Windows.Forms.Label lbTituloTotal;
        private System.Windows.Forms.Panel painelDinheiro;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.PictureBox pbEstoque;
        private System.Windows.Forms.PictureBox pbCrediario;
        private System.Windows.Forms.PictureBox pbParcial;
        private System.Windows.Forms.ToolTip toolTipVenda;

    }
}