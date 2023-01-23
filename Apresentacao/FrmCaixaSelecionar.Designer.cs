namespace Apresentacao
{
    partial class FrmCaixaSelecionar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCaixaSelecionar));
            this.dgvCaixa = new System.Windows.Forms.DataGridView();
            this.totalVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalRecebido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trocoCaixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estornoCaixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.despesaCaixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descontoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jurosVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.painelEstorno = new System.Windows.Forms.Panel();
            this.lbTituloEstorno = new System.Windows.Forms.Label();
            this.lbTotalEstorno = new System.Windows.Forms.Label();
            this.painelDinheiro = new System.Windows.Forms.Panel();
            this.lbTituloTotal = new System.Windows.Forms.Label();
            this.lbDinheiro = new System.Windows.Forms.Label();
            this.painelTotalVenda = new System.Windows.Forms.Panel();
            this.lbTituloTotalVenda = new System.Windows.Forms.Label();
            this.lbValorTotalVenda = new System.Windows.Forms.Label();
            this.painelDesconto = new System.Windows.Forms.Panel();
            this.lbTituloDesconto = new System.Windows.Forms.Label();
            this.lbDesconto = new System.Windows.Forms.Label();
            this.painelJuros = new System.Windows.Forms.Panel();
            this.lbTituloJuros = new System.Windows.Forms.Label();
            this.lbJuros = new System.Windows.Forms.Label();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.lbDataInicial = new System.Windows.Forms.Label();
            this.lbDataFinal = new System.Windows.Forms.Label();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.btFiltrar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btSelecionar = new System.Windows.Forms.Button();
            this.pbCaixa = new System.Windows.Forms.PictureBox();
            this.cbPendente = new System.Windows.Forms.CheckBox();
            this.cbFinalizado = new System.Windows.Forms.CheckBox();
            this.gbDataVenda = new System.Windows.Forms.GroupBox();
            this.lbPagamentosCaixa = new System.Windows.Forms.Label();
            this.painelTrocoCaixa = new System.Windows.Forms.Panel();
            this.lbTituloTrocoCaixa = new System.Windows.Forms.Label();
            this.lbTotalTrocoCaixa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).BeginInit();
            this.painelEstorno.SuspendLayout();
            this.painelDinheiro.SuspendLayout();
            this.painelTotalVenda.SuspendLayout();
            this.painelDesconto.SuspendLayout();
            this.painelJuros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaixa)).BeginInit();
            this.gbDataVenda.SuspendLayout();
            this.painelTrocoCaixa.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCaixa
            // 
            this.dgvCaixa.AllowUserToAddRows = false;
            this.dgvCaixa.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dgvCaixa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.totalVenda,
            this.totalRecebido,
            this.trocoCaixa,
            this.estornoCaixa,
            this.despesaCaixa,
            this.descontoVenda,
            this.jurosVenda,
            this.dataVenda,
            this.estatusItem});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCaixa.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCaixa.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCaixa.Location = new System.Drawing.Point(11, 60);
            this.dgvCaixa.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCaixa.Name = "dgvCaixa";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.dgvCaixa.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCaixa.RowTemplate.Height = 24;
            this.dgvCaixa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCaixa.Size = new System.Drawing.Size(837, 284);
            this.dgvCaixa.TabIndex = 6;
            this.dgvCaixa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCaixa_CellDoubleClick);
            // 
            // totalVenda
            // 
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.totalVenda.DefaultCellStyle = dataGridViewCellStyle3;
            this.totalVenda.HeaderText = "Recebido";
            this.totalVenda.Name = "totalVenda";
            this.totalVenda.ReadOnly = true;
            this.totalVenda.ToolTipText = "Total do Item Venda";
            // 
            // totalRecebido
            // 
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.totalRecebido.DefaultCellStyle = dataGridViewCellStyle4;
            this.totalRecebido.HeaderText = "Líquido";
            this.totalRecebido.Name = "totalRecebido";
            this.totalRecebido.ReadOnly = true;
            this.totalRecebido.ToolTipText = "Total Recebido";
            // 
            // trocoCaixa
            // 
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.trocoCaixa.DefaultCellStyle = dataGridViewCellStyle5;
            this.trocoCaixa.HeaderText = "Troco";
            this.trocoCaixa.Name = "trocoCaixa";
            this.trocoCaixa.ToolTipText = "Troco do caixa";
            // 
            // estornoCaixa
            // 
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.estornoCaixa.DefaultCellStyle = dataGridViewCellStyle6;
            this.estornoCaixa.HeaderText = "Estorno";
            this.estornoCaixa.Name = "estornoCaixa";
            this.estornoCaixa.ToolTipText = "Estorno dos cancelamentos do caixa";
            // 
            // despesaCaixa
            // 
            this.despesaCaixa.HeaderText = "Despesas";
            this.despesaCaixa.Name = "despesaCaixa";
            this.despesaCaixa.ReadOnly = true;
            this.despesaCaixa.ToolTipText = "Despesas do Caixa";
            // 
            // descontoVenda
            // 
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.descontoVenda.DefaultCellStyle = dataGridViewCellStyle7;
            this.descontoVenda.HeaderText = "Desconto";
            this.descontoVenda.Name = "descontoVenda";
            this.descontoVenda.ToolTipText = "total descontos do caixa";
            this.descontoVenda.Width = 90;
            // 
            // jurosVenda
            // 
            dataGridViewCellStyle8.NullValue = null;
            this.jurosVenda.DefaultCellStyle = dataGridViewCellStyle8;
            this.jurosVenda.HeaderText = "Juros";
            this.jurosVenda.Name = "jurosVenda";
            this.jurosVenda.ToolTipText = "total de juros do caixa";
            this.jurosVenda.Width = 90;
            // 
            // dataVenda
            // 
            dataGridViewCellStyle9.Format = "d";
            dataGridViewCellStyle9.NullValue = null;
            this.dataVenda.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataVenda.HeaderText = "Data";
            this.dataVenda.Name = "dataVenda";
            this.dataVenda.ToolTipText = "Data movimentação do caixa";
            // 
            // estatusItem
            // 
            this.estatusItem.HeaderText = "Estatus";
            this.estatusItem.Name = "estatusItem";
            this.estatusItem.ToolTipText = "Estatus fechamento do caixa";
            this.estatusItem.Width = 90;
            // 
            // painelEstorno
            // 
            this.painelEstorno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.painelEstorno.AutoScroll = true;
            this.painelEstorno.BackColor = System.Drawing.Color.Red;
            this.painelEstorno.Controls.Add(this.lbTituloEstorno);
            this.painelEstorno.Controls.Add(this.lbTotalEstorno);
            this.painelEstorno.Location = new System.Drawing.Point(571, 348);
            this.painelEstorno.Margin = new System.Windows.Forms.Padding(2);
            this.painelEstorno.Name = "painelEstorno";
            this.painelEstorno.Size = new System.Drawing.Size(136, 60);
            this.painelEstorno.TabIndex = 11;
            // 
            // lbTituloEstorno
            // 
            this.lbTituloEstorno.AutoSize = true;
            this.lbTituloEstorno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTituloEstorno.ForeColor = System.Drawing.Color.White;
            this.lbTituloEstorno.Location = new System.Drawing.Point(2, 6);
            this.lbTituloEstorno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTituloEstorno.Name = "lbTituloEstorno";
            this.lbTituloEstorno.Size = new System.Drawing.Size(79, 19);
            this.lbTituloEstorno.TabIndex = 87;
            this.lbTituloEstorno.Text = "Estorno -";
            this.lbTituloEstorno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotalEstorno
            // 
            this.lbTotalEstorno.AutoSize = true;
            this.lbTotalEstorno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTotalEstorno.ForeColor = System.Drawing.Color.White;
            this.lbTotalEstorno.Location = new System.Drawing.Point(21, 32);
            this.lbTotalEstorno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalEstorno.Name = "lbTotalEstorno";
            this.lbTotalEstorno.Size = new System.Drawing.Size(92, 19);
            this.lbTotalEstorno.TabIndex = 84;
            this.lbTotalEstorno.Text = "R$ 1200,00";
            this.lbTotalEstorno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // painelDinheiro
            // 
            this.painelDinheiro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.painelDinheiro.AutoScroll = true;
            this.painelDinheiro.BackColor = System.Drawing.Color.Turquoise;
            this.painelDinheiro.Controls.Add(this.lbTituloTotal);
            this.painelDinheiro.Controls.Add(this.lbDinheiro);
            this.painelDinheiro.Location = new System.Drawing.Point(11, 348);
            this.painelDinheiro.Margin = new System.Windows.Forms.Padding(2);
            this.painelDinheiro.Name = "painelDinheiro";
            this.painelDinheiro.Size = new System.Drawing.Size(136, 60);
            this.painelDinheiro.TabIndex = 7;
            // 
            // lbTituloTotal
            // 
            this.lbTituloTotal.AutoSize = true;
            this.lbTituloTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTituloTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTituloTotal.Location = new System.Drawing.Point(2, 6);
            this.lbTituloTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTituloTotal.Name = "lbTituloTotal";
            this.lbTituloTotal.Size = new System.Drawing.Size(107, 19);
            this.lbTituloTotal.TabIndex = 0;
            this.lbTituloTotal.Text = "Recebido R$";
            this.lbTituloTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDinheiro
            // 
            this.lbDinheiro.AutoSize = true;
            this.lbDinheiro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbDinheiro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDinheiro.Location = new System.Drawing.Point(27, 32);
            this.lbDinheiro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDinheiro.Name = "lbDinheiro";
            this.lbDinheiro.Size = new System.Drawing.Size(105, 19);
            this.lbDinheiro.TabIndex = 84;
            this.lbDinheiro.Text = "R$ 99.000,00";
            this.lbDinheiro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // painelTotalVenda
            // 
            this.painelTotalVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.painelTotalVenda.AutoScroll = true;
            this.painelTotalVenda.BackColor = System.Drawing.Color.White;
            this.painelTotalVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelTotalVenda.Controls.Add(this.lbTituloTotalVenda);
            this.painelTotalVenda.Controls.Add(this.lbValorTotalVenda);
            this.painelTotalVenda.Location = new System.Drawing.Point(151, 348);
            this.painelTotalVenda.Margin = new System.Windows.Forms.Padding(2);
            this.painelTotalVenda.Name = "painelTotalVenda";
            this.painelTotalVenda.Size = new System.Drawing.Size(136, 60);
            this.painelTotalVenda.TabIndex = 8;
            // 
            // lbTituloTotalVenda
            // 
            this.lbTituloTotalVenda.AutoSize = true;
            this.lbTituloTotalVenda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTituloTotalVenda.ForeColor = System.Drawing.Color.Black;
            this.lbTituloTotalVenda.Location = new System.Drawing.Point(2, 6);
            this.lbTituloTotalVenda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTituloTotalVenda.Name = "lbTituloTotalVenda";
            this.lbTituloTotalVenda.Size = new System.Drawing.Size(92, 19);
            this.lbTituloTotalVenda.TabIndex = 85;
            this.lbTituloTotalVenda.Text = "Líquido R$";
            this.lbTituloTotalVenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbValorTotalVenda
            // 
            this.lbValorTotalVenda.AutoSize = true;
            this.lbValorTotalVenda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbValorTotalVenda.ForeColor = System.Drawing.Color.Black;
            this.lbValorTotalVenda.Location = new System.Drawing.Point(27, 32);
            this.lbValorTotalVenda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbValorTotalVenda.Name = "lbValorTotalVenda";
            this.lbValorTotalVenda.Size = new System.Drawing.Size(105, 19);
            this.lbValorTotalVenda.TabIndex = 84;
            this.lbValorTotalVenda.Text = "R$ 99.000,00";
            this.lbValorTotalVenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // painelDesconto
            // 
            this.painelDesconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.painelDesconto.AutoScroll = true;
            this.painelDesconto.BackColor = System.Drawing.Color.DeepPink;
            this.painelDesconto.Controls.Add(this.lbTituloDesconto);
            this.painelDesconto.Controls.Add(this.lbDesconto);
            this.painelDesconto.Location = new System.Drawing.Point(431, 348);
            this.painelDesconto.Margin = new System.Windows.Forms.Padding(2);
            this.painelDesconto.Name = "painelDesconto";
            this.painelDesconto.Size = new System.Drawing.Size(136, 60);
            this.painelDesconto.TabIndex = 10;
            // 
            // lbTituloDesconto
            // 
            this.lbTituloDesconto.AutoSize = true;
            this.lbTituloDesconto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTituloDesconto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTituloDesconto.Location = new System.Drawing.Point(2, 6);
            this.lbTituloDesconto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTituloDesconto.Name = "lbTituloDesconto";
            this.lbTituloDesconto.Size = new System.Drawing.Size(92, 19);
            this.lbTituloDesconto.TabIndex = 87;
            this.lbTituloDesconto.Text = "Desconto -";
            this.lbTituloDesconto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDesconto
            // 
            this.lbDesconto.AutoSize = true;
            this.lbDesconto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbDesconto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDesconto.Location = new System.Drawing.Point(21, 32);
            this.lbDesconto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDesconto.Name = "lbDesconto";
            this.lbDesconto.Size = new System.Drawing.Size(92, 19);
            this.lbDesconto.TabIndex = 84;
            this.lbDesconto.Text = "R$ 1200,00";
            this.lbDesconto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // painelJuros
            // 
            this.painelJuros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.painelJuros.AutoScroll = true;
            this.painelJuros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.painelJuros.Controls.Add(this.lbTituloJuros);
            this.painelJuros.Controls.Add(this.lbJuros);
            this.painelJuros.Location = new System.Drawing.Point(291, 348);
            this.painelJuros.Margin = new System.Windows.Forms.Padding(2);
            this.painelJuros.Name = "painelJuros";
            this.painelJuros.Size = new System.Drawing.Size(136, 60);
            this.painelJuros.TabIndex = 9;
            // 
            // lbTituloJuros
            // 
            this.lbTituloJuros.AutoSize = true;
            this.lbTituloJuros.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTituloJuros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTituloJuros.Location = new System.Drawing.Point(2, 6);
            this.lbTituloJuros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTituloJuros.Name = "lbTituloJuros";
            this.lbTituloJuros.Size = new System.Drawing.Size(69, 19);
            this.lbTituloJuros.TabIndex = 87;
            this.lbTituloJuros.Text = "Juros%";
            this.lbTituloJuros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbJuros
            // 
            this.lbJuros.AutoSize = true;
            this.lbJuros.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbJuros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbJuros.Location = new System.Drawing.Point(21, 32);
            this.lbJuros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbJuros.Name = "lbJuros";
            this.lbJuros.Size = new System.Drawing.Size(92, 19);
            this.lbJuros.TabIndex = 84;
            this.lbJuros.Text = "R$ 1200,00";
            this.lbJuros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpDataFinal.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dtpDataFinal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(709, 30);
            this.dtpDataFinal.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(138, 26);
            this.dtpDataFinal.TabIndex = 5;
            // 
            // lbDataInicial
            // 
            this.lbDataInicial.AutoSize = true;
            this.lbDataInicial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbDataInicial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lbDataInicial.Location = new System.Drawing.Point(563, 8);
            this.lbDataInicial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDataInicial.Name = "lbDataInicial";
            this.lbDataInicial.Size = new System.Drawing.Size(92, 19);
            this.lbDataInicial.TabIndex = 2;
            this.lbDataInicial.Text = "Data Inicial";
            // 
            // lbDataFinal
            // 
            this.lbDataFinal.AutoSize = true;
            this.lbDataFinal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbDataFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lbDataFinal.Location = new System.Drawing.Point(705, 8);
            this.lbDataFinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDataFinal.Name = "lbDataFinal";
            this.lbDataFinal.Size = new System.Drawing.Size(85, 19);
            this.lbDataFinal.TabIndex = 3;
            this.lbDataFinal.Text = "Data Final";
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dtpDataInicial.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpDataInicial.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dtpDataInicial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(567, 30);
            this.dtpDataInicial.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(138, 26);
            this.dtpDataInicial.TabIndex = 4;
            this.dtpDataInicial.Value = new System.DateTime(2023, 1, 16, 6, 59, 0, 0);
            // 
            // btFiltrar
            // 
            this.btFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btFiltrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFiltrar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btFiltrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btFiltrar.Location = new System.Drawing.Point(113, 438);
            this.btFiltrar.Margin = new System.Windows.Forms.Padding(2);
            this.btFiltrar.Name = "btFiltrar";
            this.btFiltrar.Size = new System.Drawing.Size(98, 34);
            this.btFiltrar.TabIndex = 14;
            this.btFiltrar.Text = "F5 Gerar";
            this.btFiltrar.UseVisualStyleBackColor = false;
            this.btFiltrar.Click += new System.EventHandler(this.btFiltrar_Click);
            // 
            // btSair
            // 
            this.btSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSair.BackColor = System.Drawing.Color.Red;
            this.btSair.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSair.Location = new System.Drawing.Point(749, 438);
            this.btSair.Margin = new System.Windows.Forms.Padding(2);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(98, 34);
            this.btSair.TabIndex = 15;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btSelecionar
            // 
            this.btSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSelecionar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btSelecionar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSelecionar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSelecionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSelecionar.ImageKey = "Cliente.png";
            this.btSelecionar.Location = new System.Drawing.Point(11, 438);
            this.btSelecionar.Margin = new System.Windows.Forms.Padding(2);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(98, 34);
            this.btSelecionar.TabIndex = 13;
            this.btSelecionar.Text = "F10 Selecionar";
            this.btSelecionar.UseVisualStyleBackColor = false;
            this.btSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            // 
            // pbCaixa
            // 
            this.pbCaixa.Image = global::Apresentacao.Properties.Resources.CaixaForm;
            this.pbCaixa.Location = new System.Drawing.Point(11, 14);
            this.pbCaixa.Margin = new System.Windows.Forms.Padding(2);
            this.pbCaixa.Name = "pbCaixa";
            this.pbCaixa.Size = new System.Drawing.Size(39, 42);
            this.pbCaixa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCaixa.TabIndex = 199;
            this.pbCaixa.TabStop = false;
            // 
            // cbPendente
            // 
            this.cbPendente.AutoSize = true;
            this.cbPendente.Checked = true;
            this.cbPendente.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPendente.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.cbPendente.Location = new System.Drawing.Point(4, 25);
            this.cbPendente.Margin = new System.Windows.Forms.Padding(2);
            this.cbPendente.Name = "cbPendente";
            this.cbPendente.Size = new System.Drawing.Size(79, 18);
            this.cbPendente.TabIndex = 0;
            this.cbPendente.Text = "Pendente";
            this.cbPendente.UseVisualStyleBackColor = true;
            this.cbPendente.CheckedChanged += new System.EventHandler(this.cbPendente_CheckedChanged);
            // 
            // cbFinalizado
            // 
            this.cbFinalizado.AutoSize = true;
            this.cbFinalizado.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.cbFinalizado.Location = new System.Drawing.Point(87, 25);
            this.cbFinalizado.Margin = new System.Windows.Forms.Padding(2);
            this.cbFinalizado.Name = "cbFinalizado";
            this.cbFinalizado.Size = new System.Drawing.Size(80, 18);
            this.cbFinalizado.TabIndex = 1;
            this.cbFinalizado.Text = "Finalizado";
            this.cbFinalizado.UseVisualStyleBackColor = true;
            this.cbFinalizado.CheckedChanged += new System.EventHandler(this.cbFinalizado_CheckedChanged);
            // 
            // gbDataVenda
            // 
            this.gbDataVenda.Controls.Add(this.cbPendente);
            this.gbDataVenda.Controls.Add(this.cbFinalizado);
            this.gbDataVenda.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.gbDataVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.gbDataVenda.Location = new System.Drawing.Point(389, 8);
            this.gbDataVenda.Margin = new System.Windows.Forms.Padding(2);
            this.gbDataVenda.Name = "gbDataVenda";
            this.gbDataVenda.Padding = new System.Windows.Forms.Padding(2);
            this.gbDataVenda.Size = new System.Drawing.Size(170, 50);
            this.gbDataVenda.TabIndex = 1;
            this.gbDataVenda.TabStop = false;
            this.gbDataVenda.Text = "Estatus Do Caixa";
            // 
            // lbPagamentosCaixa
            // 
            this.lbPagamentosCaixa.AutoSize = true;
            this.lbPagamentosCaixa.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lbPagamentosCaixa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lbPagamentosCaixa.Location = new System.Drawing.Point(54, 35);
            this.lbPagamentosCaixa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPagamentosCaixa.Name = "lbPagamentosCaixa";
            this.lbPagamentosCaixa.Size = new System.Drawing.Size(156, 20);
            this.lbPagamentosCaixa.TabIndex = 0;
            this.lbPagamentosCaixa.Text = "Movimentação do Caixa";
            // 
            // painelTrocoCaixa
            // 
            this.painelTrocoCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.painelTrocoCaixa.AutoScroll = true;
            this.painelTrocoCaixa.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.painelTrocoCaixa.Controls.Add(this.lbTituloTrocoCaixa);
            this.painelTrocoCaixa.Controls.Add(this.lbTotalTrocoCaixa);
            this.painelTrocoCaixa.Location = new System.Drawing.Point(711, 348);
            this.painelTrocoCaixa.Margin = new System.Windows.Forms.Padding(2);
            this.painelTrocoCaixa.Name = "painelTrocoCaixa";
            this.painelTrocoCaixa.Size = new System.Drawing.Size(136, 60);
            this.painelTrocoCaixa.TabIndex = 12;
            // 
            // lbTituloTrocoCaixa
            // 
            this.lbTituloTrocoCaixa.AutoSize = true;
            this.lbTituloTrocoCaixa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTituloTrocoCaixa.ForeColor = System.Drawing.Color.White;
            this.lbTituloTrocoCaixa.Location = new System.Drawing.Point(2, 6);
            this.lbTituloTrocoCaixa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTituloTrocoCaixa.Name = "lbTituloTrocoCaixa";
            this.lbTituloTrocoCaixa.Size = new System.Drawing.Size(78, 19);
            this.lbTituloTrocoCaixa.TabIndex = 87;
            this.lbTituloTrocoCaixa.Text = "Troco R$";
            this.lbTituloTrocoCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotalTrocoCaixa
            // 
            this.lbTotalTrocoCaixa.AutoSize = true;
            this.lbTotalTrocoCaixa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTotalTrocoCaixa.ForeColor = System.Drawing.Color.White;
            this.lbTotalTrocoCaixa.Location = new System.Drawing.Point(21, 32);
            this.lbTotalTrocoCaixa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalTrocoCaixa.Name = "lbTotalTrocoCaixa";
            this.lbTotalTrocoCaixa.Size = new System.Drawing.Size(92, 19);
            this.lbTotalTrocoCaixa.TabIndex = 84;
            this.lbTotalTrocoCaixa.Text = "R$ 1200,00";
            this.lbTotalTrocoCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmCaixaSelecionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(859, 483);
            this.Controls.Add(this.painelTrocoCaixa);
            this.Controls.Add(this.lbPagamentosCaixa);
            this.Controls.Add(this.gbDataVenda);
            this.Controls.Add(this.pbCaixa);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btFiltrar);
            this.Controls.Add(this.dtpDataFinal);
            this.Controls.Add(this.lbDataInicial);
            this.Controls.Add(this.lbDataFinal);
            this.Controls.Add(this.dtpDataInicial);
            this.Controls.Add(this.painelEstorno);
            this.Controls.Add(this.painelDinheiro);
            this.Controls.Add(this.painelTotalVenda);
            this.Controls.Add(this.painelDesconto);
            this.Controls.Add(this.painelJuros);
            this.Controls.Add(this.dgvCaixa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCaixaSelecionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fechamento Caixa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).EndInit();
            this.painelEstorno.ResumeLayout(false);
            this.painelEstorno.PerformLayout();
            this.painelDinheiro.ResumeLayout(false);
            this.painelDinheiro.PerformLayout();
            this.painelTotalVenda.ResumeLayout(false);
            this.painelTotalVenda.PerformLayout();
            this.painelDesconto.ResumeLayout(false);
            this.painelDesconto.PerformLayout();
            this.painelJuros.ResumeLayout(false);
            this.painelJuros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaixa)).EndInit();
            this.gbDataVenda.ResumeLayout(false);
            this.gbDataVenda.PerformLayout();
            this.painelTrocoCaixa.ResumeLayout(false);
            this.painelTrocoCaixa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCaixa;
        private System.Windows.Forms.Panel painelEstorno;
        private System.Windows.Forms.Label lbTituloEstorno;
        private System.Windows.Forms.Label lbTotalEstorno;
        private System.Windows.Forms.Panel painelDinheiro;
        private System.Windows.Forms.Label lbTituloTotal;
        private System.Windows.Forms.Label lbDinheiro;
        private System.Windows.Forms.Panel painelTotalVenda;
        private System.Windows.Forms.Label lbTituloTotalVenda;
        private System.Windows.Forms.Label lbValorTotalVenda;
        private System.Windows.Forms.Panel painelDesconto;
        private System.Windows.Forms.Label lbTituloDesconto;
        private System.Windows.Forms.Label lbDesconto;
        private System.Windows.Forms.Panel painelJuros;
        private System.Windows.Forms.Label lbTituloJuros;
        private System.Windows.Forms.Label lbJuros;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.Label lbDataInicial;
        private System.Windows.Forms.Label lbDataFinal;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.Button btFiltrar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btSelecionar;
        private System.Windows.Forms.PictureBox pbCaixa;
        private System.Windows.Forms.CheckBox cbPendente;
        private System.Windows.Forms.CheckBox cbFinalizado;
        private System.Windows.Forms.GroupBox gbDataVenda;
        private System.Windows.Forms.Label lbPagamentosCaixa;
        private System.Windows.Forms.Panel painelTrocoCaixa;
        private System.Windows.Forms.Label lbTituloTrocoCaixa;
        private System.Windows.Forms.Label lbTotalTrocoCaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalRecebido;
        private System.Windows.Forms.DataGridViewTextBoxColumn trocoCaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn estornoCaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn despesaCaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn descontoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn jurosVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusItem;
    }
}