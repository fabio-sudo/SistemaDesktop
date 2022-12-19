namespace Apresentacao
{
    partial class FrmParcialVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParcialVenda));
            this.dgvFormaParcial = new System.Windows.Forms.DataGridView();
            this.codigoParcialVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorParcialVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagamentoParcial = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.codigoFormaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descontoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentagemTaxa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxaJuros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.painelTaxa = new System.Windows.Forms.Panel();
            this.lbTituloTaxa = new System.Windows.Forms.Label();
            this.lbTaxa = new System.Windows.Forms.Label();
            this.painelDesconto = new System.Windows.Forms.Panel();
            this.lbTituloDesconto = new System.Windows.Forms.Label();
            this.lbDesconto = new System.Windows.Forms.Label();
            this.painelDinheiro = new System.Windows.Forms.Panel();
            this.lbTituloTotal = new System.Windows.Forms.Label();
            this.lbDinheiro = new System.Windows.Forms.Label();
            this.painelTroco = new System.Windows.Forms.Panel();
            this.lbTituloTroco = new System.Windows.Forms.Label();
            this.lbTroco = new System.Windows.Forms.Label();
            this.gbPagamento = new System.Windows.Forms.GroupBox();
            this.tbValorPago = new System.Windows.Forms.TextBox();
            this.lbValorParcial = new System.Windows.Forms.Label();
            this.btDesconto = new System.Windows.Forms.Button();
            this.nudDesconto = new System.Windows.Forms.NumericUpDown();
            this.lbDescontoNum = new System.Windows.Forms.Label();
            this.painelTotalVenda = new System.Windows.Forms.Panel();
            this.cbJuros = new System.Windows.Forms.CheckBox();
            this.lbTotalParcialVenda = new System.Windows.Forms.Label();
            this.lbTotalBrutoVenda = new System.Windows.Forms.Label();
            this.lbVendaLiquido = new System.Windows.Forms.Label();
            this.panelCalculoVenda = new System.Windows.Forms.Panel();
            this.lbDescontoVenda = new System.Windows.Forms.Label();
            this.lbJurosVenda = new System.Windows.Forms.Label();
            this.lbTituloTotalVenda = new System.Windows.Forms.Label();
            this.lbValorTotalVenda = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.panelTotalParcial = new System.Windows.Forms.Panel();
            this.lbTituloParcial = new System.Windows.Forms.Label();
            this.lbTotalParcial = new System.Windows.Forms.Label();
            this.panelParcialLiquido = new System.Windows.Forms.Panel();
            this.lbTituloParcialLiquido = new System.Windows.Forms.Label();
            this.lbParcialLiquido = new System.Windows.Forms.Label();
            this.pbOk = new System.Windows.Forms.PictureBox();
            this.pbCalculadora = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormaParcial)).BeginInit();
            this.painelTaxa.SuspendLayout();
            this.painelDesconto.SuspendLayout();
            this.painelDinheiro.SuspendLayout();
            this.painelTroco.SuspendLayout();
            this.gbPagamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesconto)).BeginInit();
            this.painelTotalVenda.SuspendLayout();
            this.panelTotalParcial.SuspendLayout();
            this.panelParcialLiquido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCalculadora)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFormaParcial
            // 
            this.dgvFormaParcial.AllowUserToAddRows = false;
            this.dgvFormaParcial.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dgvFormaParcial.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFormaParcial.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvFormaParcial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFormaParcial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFormaParcial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormaParcial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoParcialVenda,
            this.codigoVenda,
            this.valorParcialVenda,
            this.formaPagamentoParcial,
            this.codigoFormaPagamento,
            this.descontoVenda,
            this.porcentagemTaxa,
            this.taxaJuros,
            this.contador});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFormaParcial.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFormaParcial.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvFormaParcial.Location = new System.Drawing.Point(12, 127);
            this.dgvFormaParcial.Name = "dgvFormaParcial";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.dgvFormaParcial.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvFormaParcial.RowTemplate.Height = 24;
            this.dgvFormaParcial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFormaParcial.Size = new System.Drawing.Size(671, 474);
            this.dgvFormaParcial.TabIndex = 0;
            this.dgvFormaParcial.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFormaParcial_CellMouseClick);
            this.dgvFormaParcial.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvFormaParcial_CellValidating);
            this.dgvFormaParcial.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvFormaParcial_EditingControlShowing);
            // 
            // codigoParcialVenda
            // 
            dataGridViewCellStyle3.NullValue = null;
            this.codigoParcialVenda.DefaultCellStyle = dataGridViewCellStyle3;
            this.codigoParcialVenda.HeaderText = "CódParcial";
            this.codigoParcialVenda.Name = "codigoParcialVenda";
            this.codigoParcialVenda.ToolTipText = "Código da Parcial";
            this.codigoParcialVenda.Visible = false;
            this.codigoParcialVenda.Width = 50;
            // 
            // codigoVenda
            // 
            this.codigoVenda.HeaderText = "Cód";
            this.codigoVenda.Name = "codigoVenda";
            this.codigoVenda.ToolTipText = "Código da Venda";
            this.codigoVenda.Visible = false;
            this.codigoVenda.Width = 60;
            // 
            // valorParcialVenda
            // 
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.valorParcialVenda.DefaultCellStyle = dataGridViewCellStyle4;
            this.valorParcialVenda.HeaderText = "Parcial";
            this.valorParcialVenda.Name = "valorParcialVenda";
            this.valorParcialVenda.ToolTipText = "Valor pago parcialmente";
            this.valorParcialVenda.Width = 90;
            // 
            // formaPagamentoParcial
            // 
            this.formaPagamentoParcial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.formaPagamentoParcial.HeaderText = "Pagamento";
            this.formaPagamentoParcial.Name = "formaPagamentoParcial";
            this.formaPagamentoParcial.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.formaPagamentoParcial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.formaPagamentoParcial.ToolTipText = "Forma de Pagamento";
            this.formaPagamentoParcial.Width = 180;
            // 
            // codigoFormaPagamento
            // 
            this.codigoFormaPagamento.HeaderText = "codFormaPagamento";
            this.codigoFormaPagamento.Name = "codigoFormaPagamento";
            this.codigoFormaPagamento.Visible = false;
            // 
            // descontoVenda
            // 
            this.descontoVenda.HeaderText = "Desconto";
            this.descontoVenda.Name = "descontoVenda";
            this.descontoVenda.ReadOnly = true;
            this.descontoVenda.ToolTipText = "Desconto da Venda";
            this.descontoVenda.Width = 95;
            // 
            // porcentagemTaxa
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.porcentagemTaxa.DefaultCellStyle = dataGridViewCellStyle5;
            this.porcentagemTaxa.HeaderText = "Juros";
            this.porcentagemTaxa.Name = "porcentagemTaxa";
            this.porcentagemTaxa.ToolTipText = "Valor da Forma de Pagamento";
            this.porcentagemTaxa.Width = 95;
            // 
            // taxaJuros
            // 
            this.taxaJuros.HeaderText = "Taxa";
            this.taxaJuros.Name = "taxaJuros";
            this.taxaJuros.Visible = false;
            // 
            // contador
            // 
            this.contador.HeaderText = "contador";
            this.contador.Name = "contador";
            this.contador.Visible = false;
            // 
            // painelTaxa
            // 
            this.painelTaxa.AutoScroll = true;
            this.painelTaxa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.painelTaxa.Controls.Add(this.lbTituloTaxa);
            this.painelTaxa.Controls.Add(this.lbTaxa);
            this.painelTaxa.Location = new System.Drawing.Point(689, 447);
            this.painelTaxa.Name = "painelTaxa";
            this.painelTaxa.Size = new System.Drawing.Size(199, 74);
            this.painelTaxa.TabIndex = 10;
            // 
            // lbTituloTaxa
            // 
            this.lbTituloTaxa.AutoSize = true;
            this.lbTituloTaxa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTituloTaxa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTituloTaxa.Location = new System.Drawing.Point(3, 7);
            this.lbTituloTaxa.Name = "lbTituloTaxa";
            this.lbTituloTaxa.Size = new System.Drawing.Size(137, 24);
            this.lbTituloTaxa.TabIndex = 0;
            this.lbTituloTaxa.Text = "Total Taxa % ";
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
            this.painelDesconto.Location = new System.Drawing.Point(689, 527);
            this.painelDesconto.Name = "painelDesconto";
            this.painelDesconto.Size = new System.Drawing.Size(199, 74);
            this.painelDesconto.TabIndex = 11;
            // 
            // lbTituloDesconto
            // 
            this.lbTituloDesconto.AutoSize = true;
            this.lbTituloDesconto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTituloDesconto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTituloDesconto.Location = new System.Drawing.Point(3, 7);
            this.lbTituloDesconto.Name = "lbTituloDesconto";
            this.lbTituloDesconto.Size = new System.Drawing.Size(166, 24);
            this.lbTituloDesconto.TabIndex = 0;
            this.lbTituloDesconto.Text = "Total Desconto -";
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
            // painelDinheiro
            // 
            this.painelDinheiro.AutoScroll = true;
            this.painelDinheiro.BackColor = System.Drawing.Color.Turquoise;
            this.painelDinheiro.Controls.Add(this.lbTituloTotal);
            this.painelDinheiro.Controls.Add(this.lbDinheiro);
            this.painelDinheiro.Location = new System.Drawing.Point(689, 127);
            this.painelDinheiro.Name = "painelDinheiro";
            this.painelDinheiro.Size = new System.Drawing.Size(199, 74);
            this.painelDinheiro.TabIndex = 6;
            // 
            // lbTituloTotal
            // 
            this.lbTituloTotal.AutoSize = true;
            this.lbTituloTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTituloTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTituloTotal.Location = new System.Drawing.Point(3, 7);
            this.lbTituloTotal.Name = "lbTituloTotal";
            this.lbTituloTotal.Size = new System.Drawing.Size(106, 24);
            this.lbTituloTotal.TabIndex = 0;
            this.lbTituloTotal.Text = "Receber +";
            this.lbTituloTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // painelTroco
            // 
            this.painelTroco.AutoScroll = true;
            this.painelTroco.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.painelTroco.Controls.Add(this.lbTituloTroco);
            this.painelTroco.Controls.Add(this.lbTroco);
            this.painelTroco.Location = new System.Drawing.Point(689, 207);
            this.painelTroco.Name = "painelTroco";
            this.painelTroco.Size = new System.Drawing.Size(199, 74);
            this.painelTroco.TabIndex = 7;
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
            // gbPagamento
            // 
            this.gbPagamento.Controls.Add(this.tbValorPago);
            this.gbPagamento.Controls.Add(this.lbValorParcial);
            this.gbPagamento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.gbPagamento.Location = new System.Drawing.Point(471, 6);
            this.gbPagamento.Name = "gbPagamento";
            this.gbPagamento.Size = new System.Drawing.Size(281, 115);
            this.gbPagamento.TabIndex = 2;
            this.gbPagamento.TabStop = false;
            this.gbPagamento.Text = "Pagamento";
            // 
            // tbValorPago
            // 
            this.tbValorPago.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold);
            this.tbValorPago.Location = new System.Drawing.Point(6, 59);
            this.tbValorPago.Name = "tbValorPago";
            this.tbValorPago.Size = new System.Drawing.Size(260, 50);
            this.tbValorPago.TabIndex = 1;
            this.tbValorPago.Text = "0,00";
            this.tbValorPago.TextChanged += new System.EventHandler(this.tbValorPago_TextChanged);
            // 
            // lbValorParcial
            // 
            this.lbValorParcial.AutoSize = true;
            this.lbValorParcial.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbValorParcial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbValorParcial.Location = new System.Drawing.Point(6, 37);
            this.lbValorParcial.Name = "lbValorParcial";
            this.lbValorParcial.Size = new System.Drawing.Size(120, 19);
            this.lbValorParcial.TabIndex = 0;
            this.lbValorParcial.Text = "Valor Pago R$";
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
            this.btDesconto.Location = new System.Drawing.Point(758, 79);
            this.btDesconto.Name = "btDesconto";
            this.btDesconto.Size = new System.Drawing.Size(130, 42);
            this.btDesconto.TabIndex = 5;
            this.btDesconto.Text = "F5 Desconto %";
            this.btDesconto.UseVisualStyleBackColor = false;
            this.btDesconto.Click += new System.EventHandler(this.btDesconto_Click);
            // 
            // nudDesconto
            // 
            this.nudDesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudDesconto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.nudDesconto.Location = new System.Drawing.Point(758, 43);
            this.nudDesconto.Name = "nudDesconto";
            this.nudDesconto.Size = new System.Drawing.Size(130, 30);
            this.nudDesconto.TabIndex = 4;
            this.nudDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudDesconto_KeyPress);
            // 
            // lbDescontoNum
            // 
            this.lbDescontoNum.AutoSize = true;
            this.lbDescontoNum.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbDescontoNum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDescontoNum.Location = new System.Drawing.Point(758, 22);
            this.lbDescontoNum.Name = "lbDescontoNum";
            this.lbDescontoNum.Size = new System.Drawing.Size(93, 18);
            this.lbDescontoNum.TabIndex = 3;
            this.lbDescontoNum.Text = "Desconto %";
            // 
            // painelTotalVenda
            // 
            this.painelTotalVenda.AutoScroll = true;
            this.painelTotalVenda.BackColor = System.Drawing.Color.White;
            this.painelTotalVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelTotalVenda.Controls.Add(this.pbOk);
            this.painelTotalVenda.Controls.Add(this.cbJuros);
            this.painelTotalVenda.Controls.Add(this.lbTotalParcialVenda);
            this.painelTotalVenda.Controls.Add(this.lbTotalBrutoVenda);
            this.painelTotalVenda.Controls.Add(this.pbCalculadora);
            this.painelTotalVenda.Controls.Add(this.lbVendaLiquido);
            this.painelTotalVenda.Controls.Add(this.panelCalculoVenda);
            this.painelTotalVenda.Controls.Add(this.lbDescontoVenda);
            this.painelTotalVenda.Controls.Add(this.lbJurosVenda);
            this.painelTotalVenda.Controls.Add(this.lbTituloTotalVenda);
            this.painelTotalVenda.Controls.Add(this.lbValorTotalVenda);
            this.painelTotalVenda.Location = new System.Drawing.Point(12, 16);
            this.painelTotalVenda.Name = "painelTotalVenda";
            this.painelTotalVenda.Size = new System.Drawing.Size(453, 105);
            this.painelTotalVenda.TabIndex = 1;
            // 
            // cbJuros
            // 
            this.cbJuros.AutoSize = true;
            this.cbJuros.Checked = true;
            this.cbJuros.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbJuros.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.cbJuros.Location = new System.Drawing.Point(333, 78);
            this.cbJuros.Name = "cbJuros";
            this.cbJuros.Size = new System.Drawing.Size(102, 20);
            this.cbJuros.TabIndex = 7;
            this.cbJuros.Text = "Add Taxa%";
            this.cbJuros.UseVisualStyleBackColor = true;
            this.cbJuros.CheckedChanged += new System.EventHandler(this.cbJuros_CheckedChanged);
            // 
            // lbTotalParcialVenda
            // 
            this.lbTotalParcialVenda.AutoSize = true;
            this.lbTotalParcialVenda.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalParcialVenda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTotalParcialVenda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTotalParcialVenda.Location = new System.Drawing.Point(200, 7);
            this.lbTotalParcialVenda.Name = "lbTotalParcialVenda";
            this.lbTotalParcialVenda.Size = new System.Drawing.Size(206, 24);
            this.lbTotalParcialVenda.TabIndex = 5;
            this.lbTotalParcialVenda.Text = "Valor Total Venda R$";
            this.lbTotalParcialVenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotalBrutoVenda
            // 
            this.lbTotalBrutoVenda.AutoSize = true;
            this.lbTotalBrutoVenda.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalBrutoVenda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTotalBrutoVenda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTotalBrutoVenda.Location = new System.Drawing.Point(260, 40);
            this.lbTotalBrutoVenda.Name = "lbTotalBrutoVenda";
            this.lbTotalBrutoVenda.Size = new System.Drawing.Size(80, 24);
            this.lbTotalBrutoVenda.TabIndex = 6;
            this.lbTotalBrutoVenda.Text = "R$ 0,00";
            this.lbTotalBrutoVenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbVendaLiquido
            // 
            this.lbVendaLiquido.AutoSize = true;
            this.lbVendaLiquido.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbVendaLiquido.ForeColor = System.Drawing.Color.Black;
            this.lbVendaLiquido.Location = new System.Drawing.Point(84, 78);
            this.lbVendaLiquido.Name = "lbVendaLiquido";
            this.lbVendaLiquido.Size = new System.Drawing.Size(71, 18);
            this.lbVendaLiquido.TabIndex = 4;
            this.lbVendaLiquido.Text = "   R$ 0,00";
            this.lbVendaLiquido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCalculoVenda
            // 
            this.panelCalculoVenda.BackColor = System.Drawing.Color.Black;
            this.panelCalculoVenda.Location = new System.Drawing.Point(84, 73);
            this.panelCalculoVenda.Name = "panelCalculoVenda";
            this.panelCalculoVenda.Size = new System.Drawing.Size(115, 2);
            this.panelCalculoVenda.TabIndex = 136;
            // 
            // lbDescontoVenda
            // 
            this.lbDescontoVenda.AutoSize = true;
            this.lbDescontoVenda.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbDescontoVenda.ForeColor = System.Drawing.Color.Black;
            this.lbDescontoVenda.Location = new System.Drawing.Point(84, 52);
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
            this.lbJurosVenda.Location = new System.Drawing.Point(84, 29);
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
            this.lbTituloTotalVenda.Size = new System.Drawing.Size(74, 24);
            this.lbTituloTotalVenda.TabIndex = 0;
            this.lbTituloTotalVenda.Text = "Parcial";
            this.lbTituloTotalVenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbValorTotalVenda
            // 
            this.lbValorTotalVenda.AutoSize = true;
            this.lbValorTotalVenda.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbValorTotalVenda.ForeColor = System.Drawing.Color.Black;
            this.lbValorTotalVenda.Location = new System.Drawing.Point(84, 7);
            this.lbValorTotalVenda.Name = "lbValorTotalVenda";
            this.lbValorTotalVenda.Size = new System.Drawing.Size(72, 18);
            this.lbValorTotalVenda.TabIndex = 1;
            this.lbValorTotalVenda.Text = "+ R$ 0,00";
            this.lbValorTotalVenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btCadastrar.FlatAppearance.BorderSize = 0;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCadastrar.Location = new System.Drawing.Point(12, 620);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(130, 42);
            this.btCadastrar.TabIndex = 12;
            this.btCadastrar.Text = "F10 Lançar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.DeepPink;
            this.btExcluir.FlatAppearance.BorderSize = 0;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btExcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btExcluir.Location = new System.Drawing.Point(284, 620);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(130, 42);
            this.btExcluir.TabIndex = 14;
            this.btExcluir.Text = "F2 Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Red;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSair.Location = new System.Drawing.Point(758, 620);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(130, 42);
            this.btSair.TabIndex = 15;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btAdicionar
            // 
            this.btAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btAdicionar.FlatAppearance.BorderSize = 0;
            this.btAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdicionar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btAdicionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAdicionar.Location = new System.Drawing.Point(148, 620);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(130, 42);
            this.btAdicionar.TabIndex = 13;
            this.btAdicionar.Text = "Ent Add";
            this.btAdicionar.UseVisualStyleBackColor = false;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // panelTotalParcial
            // 
            this.panelTotalParcial.AutoScroll = true;
            this.panelTotalParcial.BackColor = System.Drawing.Color.Black;
            this.panelTotalParcial.Controls.Add(this.lbTituloParcial);
            this.panelTotalParcial.Controls.Add(this.lbTotalParcial);
            this.panelTotalParcial.Location = new System.Drawing.Point(689, 367);
            this.panelTotalParcial.Name = "panelTotalParcial";
            this.panelTotalParcial.Size = new System.Drawing.Size(199, 74);
            this.panelTotalParcial.TabIndex = 9;
            // 
            // lbTituloParcial
            // 
            this.lbTituloParcial.AutoSize = true;
            this.lbTituloParcial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTituloParcial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTituloParcial.Location = new System.Drawing.Point(3, 7);
            this.lbTituloParcial.Name = "lbTituloParcial";
            this.lbTituloParcial.Size = new System.Drawing.Size(150, 24);
            this.lbTituloParcial.TabIndex = 0;
            this.lbTituloParcial.Text = "Parcial Líquida";
            this.lbTituloParcial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotalParcial
            // 
            this.lbTotalParcial.AutoSize = true;
            this.lbTotalParcial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTotalParcial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTotalParcial.Location = new System.Drawing.Point(36, 39);
            this.lbTotalParcial.Name = "lbTotalParcial";
            this.lbTotalParcial.Size = new System.Drawing.Size(80, 24);
            this.lbTotalParcial.TabIndex = 1;
            this.lbTotalParcial.Text = "R$ 0,00";
            this.lbTotalParcial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelParcialLiquido
            // 
            this.panelParcialLiquido.AutoScroll = true;
            this.panelParcialLiquido.BackColor = System.Drawing.Color.White;
            this.panelParcialLiquido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelParcialLiquido.Controls.Add(this.lbTituloParcialLiquido);
            this.panelParcialLiquido.Controls.Add(this.lbParcialLiquido);
            this.panelParcialLiquido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelParcialLiquido.Location = new System.Drawing.Point(689, 287);
            this.panelParcialLiquido.Name = "panelParcialLiquido";
            this.panelParcialLiquido.Size = new System.Drawing.Size(199, 74);
            this.panelParcialLiquido.TabIndex = 8;
            // 
            // lbTituloParcialLiquido
            // 
            this.lbTituloParcialLiquido.AutoSize = true;
            this.lbTituloParcialLiquido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTituloParcialLiquido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTituloParcialLiquido.Location = new System.Drawing.Point(3, 7);
            this.lbTituloParcialLiquido.Name = "lbTituloParcialLiquido";
            this.lbTituloParcialLiquido.Size = new System.Drawing.Size(139, 24);
            this.lbTituloParcialLiquido.TabIndex = 0;
            this.lbTituloParcialLiquido.Text = "Parcial Bruto ";
            this.lbTituloParcialLiquido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbParcialLiquido
            // 
            this.lbParcialLiquido.AutoSize = true;
            this.lbParcialLiquido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbParcialLiquido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbParcialLiquido.Location = new System.Drawing.Point(36, 39);
            this.lbParcialLiquido.Name = "lbParcialLiquido";
            this.lbParcialLiquido.Size = new System.Drawing.Size(80, 24);
            this.lbParcialLiquido.TabIndex = 1;
            this.lbParcialLiquido.Text = "R$ 0,00";
            this.lbParcialLiquido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbOk
            // 
            this.pbOk.Image = global::Apresentacao.Properties.Resources.DialogErro;
            this.pbOk.Location = new System.Drawing.Point(425, 8);
            this.pbOk.Name = "pbOk";
            this.pbOk.Size = new System.Drawing.Size(23, 23);
            this.pbOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOk.TabIndex = 146;
            this.pbOk.TabStop = false;
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
            // FrmParcialVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(900, 678);
            this.Controls.Add(this.panelParcialLiquido);
            this.Controls.Add(this.panelTotalParcial);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.btDesconto);
            this.Controls.Add(this.nudDesconto);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.lbDescontoNum);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.gbPagamento);
            this.Controls.Add(this.painelTotalVenda);
            this.Controls.Add(this.painelTroco);
            this.Controls.Add(this.painelDinheiro);
            this.Controls.Add(this.painelDesconto);
            this.Controls.Add(this.painelTaxa);
            this.Controls.Add(this.dgvFormaParcial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmParcialVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parcial Venda";
            this.Load += new System.EventHandler(this.FrmParcialVenda_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmParcialVenda_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormaParcial)).EndInit();
            this.painelTaxa.ResumeLayout(false);
            this.painelTaxa.PerformLayout();
            this.painelDesconto.ResumeLayout(false);
            this.painelDesconto.PerformLayout();
            this.painelDinheiro.ResumeLayout(false);
            this.painelDinheiro.PerformLayout();
            this.painelTroco.ResumeLayout(false);
            this.painelTroco.PerformLayout();
            this.gbPagamento.ResumeLayout(false);
            this.gbPagamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesconto)).EndInit();
            this.painelTotalVenda.ResumeLayout(false);
            this.painelTotalVenda.PerformLayout();
            this.panelTotalParcial.ResumeLayout(false);
            this.panelTotalParcial.PerformLayout();
            this.panelParcialLiquido.ResumeLayout(false);
            this.panelParcialLiquido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCalculadora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFormaParcial;
        private System.Windows.Forms.Panel painelTaxa;
        private System.Windows.Forms.Label lbTituloTaxa;
        private System.Windows.Forms.Label lbTaxa;
        private System.Windows.Forms.Panel painelDesconto;
        private System.Windows.Forms.Label lbTituloDesconto;
        private System.Windows.Forms.Label lbDesconto;
        private System.Windows.Forms.Panel painelDinheiro;
        private System.Windows.Forms.Label lbTituloTotal;
        private System.Windows.Forms.Label lbDinheiro;
        private System.Windows.Forms.Panel painelTroco;
        private System.Windows.Forms.Label lbTituloTroco;
        private System.Windows.Forms.Label lbTroco;
        private System.Windows.Forms.GroupBox gbPagamento;
        private System.Windows.Forms.TextBox tbValorPago;
        private System.Windows.Forms.Label lbValorParcial;
        private System.Windows.Forms.NumericUpDown nudDesconto;
        private System.Windows.Forms.Label lbDescontoNum;
        private System.Windows.Forms.Panel painelTotalVenda;
        private System.Windows.Forms.PictureBox pbCalculadora;
        private System.Windows.Forms.Label lbVendaLiquido;
        private System.Windows.Forms.Panel panelCalculoVenda;
        private System.Windows.Forms.Label lbDescontoVenda;
        private System.Windows.Forms.Label lbJurosVenda;
        private System.Windows.Forms.Label lbTituloTotalVenda;
        private System.Windows.Forms.Label lbValorTotalVenda;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btDesconto;
        private System.Windows.Forms.Label lbTotalParcialVenda;
        private System.Windows.Forms.Label lbTotalBrutoVenda;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Panel panelTotalParcial;
        private System.Windows.Forms.Label lbTituloParcial;
        private System.Windows.Forms.Label lbTotalParcial;
        private System.Windows.Forms.CheckBox cbJuros;
        private System.Windows.Forms.Panel panelParcialLiquido;
        private System.Windows.Forms.Label lbTituloParcialLiquido;
        private System.Windows.Forms.Label lbParcialLiquido;
        private System.Windows.Forms.PictureBox pbOk;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoParcialVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorParcialVenda;
        private System.Windows.Forms.DataGridViewComboBoxColumn formaPagamentoParcial;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoFormaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn descontoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentagemTaxa;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxaJuros;
        private System.Windows.Forms.DataGridViewTextBoxColumn contador;
    }
}