namespace Apresentacao
{
    partial class FrmAlterarExcluirSangria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlterarExcluirSangria));
            this.btAlterar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.dtpDataSangria = new System.Windows.Forms.DateTimePicker();
            this.btBuscar = new System.Windows.Forms.Button();
            this.panelBuscarFuncionario = new System.Windows.Forms.Panel();
            this.tbBuscarFuncionario = new System.Windows.Forms.TextBox();
            this.panelEstorno = new System.Windows.Forms.Panel();
            this.lbTituloEstorno = new System.Windows.Forms.Label();
            this.lbTotalEstorno = new System.Windows.Forms.Label();
            this.panelCaixaRestante = new System.Windows.Forms.Panel();
            this.lbRestoCaixa = new System.Windows.Forms.Label();
            this.lbCaixaRestante = new System.Windows.Forms.Label();
            this.painelSangria = new System.Windows.Forms.Panel();
            this.lbTituloSangria = new System.Windows.Forms.Label();
            this.lbSangriaTotal = new System.Windows.Forms.Label();
            this.painelDesconto = new System.Windows.Forms.Panel();
            this.lbTituloDesconto = new System.Windows.Forms.Label();
            this.lbDesconto = new System.Windows.Forms.Label();
            this.painelTaxa = new System.Windows.Forms.Panel();
            this.lbTituloTaxa = new System.Windows.Forms.Label();
            this.lbTaxa = new System.Windows.Forms.Label();
            this.painelCaixa = new System.Windows.Forms.Panel();
            this.lbTituloCaixa = new System.Windows.Forms.Label();
            this.lbCaixaTotal = new System.Windows.Forms.Label();
            this.dgvSangria = new System.Windows.Forms.DataGridView();
            this.valorParcialVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sangriaCaixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoFormaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagamentoParcial = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.descontoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentagemTaxa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estornoCaixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btSangriaTotal = new System.Windows.Forms.Button();
            this.pbFuncionario = new System.Windows.Forms.PictureBox();
            this.pbTitulo = new System.Windows.Forms.PictureBox();
            this.panelEstorno.SuspendLayout();
            this.panelCaixaRestante.SuspendLayout();
            this.painelSangria.SuspendLayout();
            this.painelDesconto.SuspendLayout();
            this.painelTaxa.SuspendLayout();
            this.painelCaixa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSangria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitulo)).BeginInit();
            this.SuspendLayout();
            // 
            // btAlterar
            // 
            this.btAlterar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btAlterar.FlatAppearance.BorderSize = 0;
            this.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlterar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btAlterar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAlterar.Location = new System.Drawing.Point(12, 550);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(130, 42);
            this.btAlterar.TabIndex = 11;
            this.btAlterar.Text = "F10 Alterar";
            this.btAlterar.UseVisualStyleBackColor = false;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Red;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSair.Location = new System.Drawing.Point(1036, 550);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(130, 42);
            this.btSair.TabIndex = 14;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // dtpDataSangria
            // 
            this.dtpDataSangria.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dtpDataSangria.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dtpDataSangria.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dtpDataSangria.CustomFormat = "dddd MM yyyy";
            this.dtpDataSangria.Enabled = false;
            this.dtpDataSangria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.dtpDataSangria.Location = new System.Drawing.Point(697, 12);
            this.dtpDataSangria.Name = "dtpDataSangria";
            this.dtpDataSangria.Size = new System.Drawing.Size(469, 30);
            this.dtpDataSangria.TabIndex = 2;
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btBuscar.FlatAppearance.BorderSize = 0;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBuscar.Location = new System.Drawing.Point(459, 24);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(130, 42);
            this.btBuscar.TabIndex = 1;
            this.btBuscar.Text = "F5 Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // panelBuscarFuncionario
            // 
            this.panelBuscarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelBuscarFuncionario.Location = new System.Drawing.Point(70, 62);
            this.panelBuscarFuncionario.Name = "panelBuscarFuncionario";
            this.panelBuscarFuncionario.Size = new System.Drawing.Size(383, 2);
            this.panelBuscarFuncionario.TabIndex = 3;
            // 
            // tbBuscarFuncionario
            // 
            this.tbBuscarFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBuscarFuncionario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tbBuscarFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbBuscarFuncionario.Location = new System.Drawing.Point(110, 39);
            this.tbBuscarFuncionario.Name = "tbBuscarFuncionario";
            this.tbBuscarFuncionario.Size = new System.Drawing.Size(343, 23);
            this.tbBuscarFuncionario.TabIndex = 0;
            this.tbBuscarFuncionario.Text = "Digite o nome do funcionário ...";
            this.tbBuscarFuncionario.Enter += new System.EventHandler(this.tbBuscarFuncionario_Enter);
            this.tbBuscarFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscarFuncionario_KeyPress);
            this.tbBuscarFuncionario.Leave += new System.EventHandler(this.tbBuscarFuncionario_Leave);
            // 
            // panelEstorno
            // 
            this.panelEstorno.AutoScroll = true;
            this.panelEstorno.BackColor = System.Drawing.Color.Red;
            this.panelEstorno.Controls.Add(this.lbTituloEstorno);
            this.panelEstorno.Controls.Add(this.lbTotalEstorno);
            this.panelEstorno.Location = new System.Drawing.Point(967, 230);
            this.panelEstorno.Name = "panelEstorno";
            this.panelEstorno.Size = new System.Drawing.Size(199, 74);
            this.panelEstorno.TabIndex = 7;
            // 
            // lbTituloEstorno
            // 
            this.lbTituloEstorno.AutoSize = true;
            this.lbTituloEstorno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTituloEstorno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTituloEstorno.Location = new System.Drawing.Point(3, 7);
            this.lbTituloEstorno.Name = "lbTituloEstorno";
            this.lbTituloEstorno.Size = new System.Drawing.Size(98, 24);
            this.lbTituloEstorno.TabIndex = 0;
            this.lbTituloEstorno.Text = "Estorno -";
            this.lbTituloEstorno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotalEstorno
            // 
            this.lbTotalEstorno.AutoSize = true;
            this.lbTotalEstorno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTotalEstorno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTotalEstorno.Location = new System.Drawing.Point(28, 39);
            this.lbTotalEstorno.Name = "lbTotalEstorno";
            this.lbTotalEstorno.Size = new System.Drawing.Size(80, 24);
            this.lbTotalEstorno.TabIndex = 1;
            this.lbTotalEstorno.Text = "R$ 0,00";
            this.lbTotalEstorno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCaixaRestante
            // 
            this.panelCaixaRestante.AutoScroll = true;
            this.panelCaixaRestante.BackColor = System.Drawing.Color.White;
            this.panelCaixaRestante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCaixaRestante.Controls.Add(this.lbRestoCaixa);
            this.panelCaixaRestante.Controls.Add(this.lbCaixaRestante);
            this.panelCaixaRestante.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelCaixaRestante.Location = new System.Drawing.Point(967, 470);
            this.panelCaixaRestante.Name = "panelCaixaRestante";
            this.panelCaixaRestante.Size = new System.Drawing.Size(199, 74);
            this.panelCaixaRestante.TabIndex = 10;
            // 
            // lbRestoCaixa
            // 
            this.lbRestoCaixa.AutoSize = true;
            this.lbRestoCaixa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbRestoCaixa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbRestoCaixa.Location = new System.Drawing.Point(3, 7);
            this.lbRestoCaixa.Name = "lbRestoCaixa";
            this.lbRestoCaixa.Size = new System.Drawing.Size(141, 24);
            this.lbRestoCaixa.TabIndex = 0;
            this.lbRestoCaixa.Text = "Resto Caixa +";
            this.lbRestoCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCaixaRestante
            // 
            this.lbCaixaRestante.AutoSize = true;
            this.lbCaixaRestante.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbCaixaRestante.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbCaixaRestante.Location = new System.Drawing.Point(36, 39);
            this.lbCaixaRestante.Name = "lbCaixaRestante";
            this.lbCaixaRestante.Size = new System.Drawing.Size(80, 24);
            this.lbCaixaRestante.TabIndex = 1;
            this.lbCaixaRestante.Text = "R$ 0,00";
            this.lbCaixaRestante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // painelSangria
            // 
            this.painelSangria.AutoScroll = true;
            this.painelSangria.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.painelSangria.Controls.Add(this.lbTituloSangria);
            this.painelSangria.Controls.Add(this.lbSangriaTotal);
            this.painelSangria.Location = new System.Drawing.Point(967, 150);
            this.painelSangria.Name = "painelSangria";
            this.painelSangria.Size = new System.Drawing.Size(199, 74);
            this.painelSangria.TabIndex = 6;
            // 
            // lbTituloSangria
            // 
            this.lbTituloSangria.AutoSize = true;
            this.lbTituloSangria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTituloSangria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTituloSangria.Location = new System.Drawing.Point(6, 7);
            this.lbTituloSangria.Name = "lbTituloSangria";
            this.lbTituloSangria.Size = new System.Drawing.Size(95, 24);
            this.lbTituloSangria.TabIndex = 0;
            this.lbTituloSangria.Text = "Sangria -";
            this.lbTituloSangria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSangriaTotal
            // 
            this.lbSangriaTotal.AutoSize = true;
            this.lbSangriaTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbSangriaTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSangriaTotal.Location = new System.Drawing.Point(28, 39);
            this.lbSangriaTotal.Name = "lbSangriaTotal";
            this.lbSangriaTotal.Size = new System.Drawing.Size(80, 24);
            this.lbSangriaTotal.TabIndex = 1;
            this.lbSangriaTotal.Text = "R$ 0,00";
            this.lbSangriaTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // painelDesconto
            // 
            this.painelDesconto.AutoScroll = true;
            this.painelDesconto.BackColor = System.Drawing.Color.DeepPink;
            this.painelDesconto.Controls.Add(this.lbTituloDesconto);
            this.painelDesconto.Controls.Add(this.lbDesconto);
            this.painelDesconto.Location = new System.Drawing.Point(967, 390);
            this.painelDesconto.Name = "painelDesconto";
            this.painelDesconto.Size = new System.Drawing.Size(199, 74);
            this.painelDesconto.TabIndex = 9;
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
            // painelTaxa
            // 
            this.painelTaxa.AutoScroll = true;
            this.painelTaxa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.painelTaxa.Controls.Add(this.lbTituloTaxa);
            this.painelTaxa.Controls.Add(this.lbTaxa);
            this.painelTaxa.Location = new System.Drawing.Point(967, 310);
            this.painelTaxa.Name = "painelTaxa";
            this.painelTaxa.Size = new System.Drawing.Size(199, 74);
            this.painelTaxa.TabIndex = 8;
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
            // painelCaixa
            // 
            this.painelCaixa.AutoScroll = true;
            this.painelCaixa.BackColor = System.Drawing.Color.Turquoise;
            this.painelCaixa.Controls.Add(this.lbTituloCaixa);
            this.painelCaixa.Controls.Add(this.lbCaixaTotal);
            this.painelCaixa.Location = new System.Drawing.Point(967, 70);
            this.painelCaixa.Name = "painelCaixa";
            this.painelCaixa.Size = new System.Drawing.Size(199, 74);
            this.painelCaixa.TabIndex = 5;
            // 
            // lbTituloCaixa
            // 
            this.lbTituloCaixa.AutoSize = true;
            this.lbTituloCaixa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTituloCaixa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTituloCaixa.Location = new System.Drawing.Point(3, 7);
            this.lbTituloCaixa.Name = "lbTituloCaixa";
            this.lbTituloCaixa.Size = new System.Drawing.Size(80, 24);
            this.lbTituloCaixa.TabIndex = 0;
            this.lbTituloCaixa.Text = "Caixa +";
            this.lbTituloCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCaixaTotal
            // 
            this.lbCaixaTotal.AutoSize = true;
            this.lbCaixaTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbCaixaTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCaixaTotal.Location = new System.Drawing.Point(36, 39);
            this.lbCaixaTotal.Name = "lbCaixaTotal";
            this.lbCaixaTotal.Size = new System.Drawing.Size(80, 24);
            this.lbCaixaTotal.TabIndex = 1;
            this.lbCaixaTotal.Text = "R$ 0,00";
            this.lbCaixaTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvSangria
            // 
            this.dgvSangria.AllowUserToAddRows = false;
            this.dgvSangria.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dgvSangria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSangria.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSangria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSangria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSangria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSangria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.valorParcialVenda,
            this.sangriaCaixa,
            this.Venda,
            this.codigoFormaPagamento,
            this.formaPagamentoParcial,
            this.descontoVenda,
            this.porcentagemTaxa,
            this.estornoCaixa,
            this.contador});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSangria.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSangria.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvSangria.Location = new System.Drawing.Point(12, 70);
            this.dgvSangria.Name = "dgvSangria";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.dgvSangria.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSangria.RowTemplate.Height = 24;
            this.dgvSangria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSangria.Size = new System.Drawing.Size(949, 474);
            this.dgvSangria.TabIndex = 4;
            this.dgvSangria.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvSangria_CellValidating);
            this.dgvSangria.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvSangria_EditingControlShowing);
            // 
            // valorParcialVenda
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.valorParcialVenda.DefaultCellStyle = dataGridViewCellStyle3;
            this.valorParcialVenda.HeaderText = "Sangria";
            this.valorParcialVenda.Name = "valorParcialVenda";
            this.valorParcialVenda.ToolTipText = "Valor Retirado do Caixa";
            this.valorParcialVenda.Width = 90;
            // 
            // sangriaCaixa
            // 
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.sangriaCaixa.DefaultCellStyle = dataGridViewCellStyle4;
            this.sangriaCaixa.HeaderText = "Retirada";
            this.sangriaCaixa.Name = "sangriaCaixa";
            this.sangriaCaixa.ReadOnly = true;
            this.sangriaCaixa.ToolTipText = "Sangria ja realizada no caixa";
            // 
            // Venda
            // 
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.Venda.DefaultCellStyle = dataGridViewCellStyle5;
            this.Venda.HeaderText = "Caixa R$";
            this.Venda.Name = "Venda";
            this.Venda.ToolTipText = "Dinheiro Caixa";
            // 
            // codigoFormaPagamento
            // 
            this.codigoFormaPagamento.HeaderText = "codFormaPagamento";
            this.codigoFormaPagamento.Name = "codigoFormaPagamento";
            this.codigoFormaPagamento.Visible = false;
            // 
            // formaPagamentoParcial
            // 
            this.formaPagamentoParcial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.formaPagamentoParcial.HeaderText = "Pagamento";
            this.formaPagamentoParcial.Name = "formaPagamentoParcial";
            this.formaPagamentoParcial.ReadOnly = true;
            this.formaPagamentoParcial.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.formaPagamentoParcial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.formaPagamentoParcial.ToolTipText = "Forma de Pagamento";
            this.formaPagamentoParcial.Width = 180;
            // 
            // descontoVenda
            // 
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.descontoVenda.DefaultCellStyle = dataGridViewCellStyle6;
            this.descontoVenda.HeaderText = "Desconto";
            this.descontoVenda.Name = "descontoVenda";
            this.descontoVenda.ReadOnly = true;
            this.descontoVenda.ToolTipText = "Desconto da Venda";
            this.descontoVenda.Width = 95;
            // 
            // porcentagemTaxa
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.porcentagemTaxa.DefaultCellStyle = dataGridViewCellStyle7;
            this.porcentagemTaxa.HeaderText = "Juros";
            this.porcentagemTaxa.Name = "porcentagemTaxa";
            this.porcentagemTaxa.ReadOnly = true;
            this.porcentagemTaxa.ToolTipText = "Valor da Forma de Pagamento";
            this.porcentagemTaxa.Width = 95;
            // 
            // estornoCaixa
            // 
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.estornoCaixa.DefaultCellStyle = dataGridViewCellStyle8;
            this.estornoCaixa.HeaderText = "Estorno";
            this.estornoCaixa.Name = "estornoCaixa";
            this.estornoCaixa.ReadOnly = true;
            this.estornoCaixa.Visible = false;
            // 
            // contador
            // 
            this.contador.HeaderText = "contador";
            this.contador.Name = "contador";
            this.contador.Visible = false;
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.DeepPink;
            this.btExcluir.FlatAppearance.BorderSize = 0;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btExcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btExcluir.Location = new System.Drawing.Point(148, 550);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(130, 42);
            this.btExcluir.TabIndex = 12;
            this.btExcluir.Text = "F2 Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btSangriaTotal
            // 
            this.btSangriaTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btSangriaTotal.FlatAppearance.BorderSize = 0;
            this.btSangriaTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSangriaTotal.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSangriaTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSangriaTotal.Location = new System.Drawing.Point(284, 550);
            this.btSangriaTotal.Name = "btSangriaTotal";
            this.btSangriaTotal.Size = new System.Drawing.Size(130, 42);
            this.btSangriaTotal.TabIndex = 13;
            this.btSangriaTotal.Text = "Preencher";
            this.btSangriaTotal.UseVisualStyleBackColor = false;
            this.btSangriaTotal.Click += new System.EventHandler(this.btSangriaTotal_Click);
            // 
            // pbFuncionario
            // 
            this.pbFuncionario.Image = global::Apresentacao.Properties.Resources.FuncionarioAzul;
            this.pbFuncionario.Location = new System.Drawing.Point(70, 24);
            this.pbFuncionario.Name = "pbFuncionario";
            this.pbFuncionario.Size = new System.Drawing.Size(34, 36);
            this.pbFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFuncionario.TabIndex = 32;
            this.pbFuncionario.TabStop = false;
            // 
            // pbTitulo
            // 
            this.pbTitulo.Image = global::Apresentacao.Properties.Resources.wallet;
            this.pbTitulo.Location = new System.Drawing.Point(12, 12);
            this.pbTitulo.Name = "pbTitulo";
            this.pbTitulo.Size = new System.Drawing.Size(52, 52);
            this.pbTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTitulo.TabIndex = 19;
            this.pbTitulo.TabStop = false;
            // 
            // FrmAlterarExcluirSangria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1188, 611);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btSangriaTotal);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.dtpDataSangria);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.panelBuscarFuncionario);
            this.Controls.Add(this.tbBuscarFuncionario);
            this.Controls.Add(this.pbFuncionario);
            this.Controls.Add(this.panelEstorno);
            this.Controls.Add(this.panelCaixaRestante);
            this.Controls.Add(this.painelSangria);
            this.Controls.Add(this.painelDesconto);
            this.Controls.Add(this.painelTaxa);
            this.Controls.Add(this.painelCaixa);
            this.Controls.Add(this.dgvSangria);
            this.Controls.Add(this.pbTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmAlterarExcluirSangria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar & Excluir Sangria";
            this.Load += new System.EventHandler(this.FrmAlterarExcluirSangria_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAlterarExcluirSangria_KeyDown);
            this.panelEstorno.ResumeLayout(false);
            this.panelEstorno.PerformLayout();
            this.panelCaixaRestante.ResumeLayout(false);
            this.panelCaixaRestante.PerformLayout();
            this.painelSangria.ResumeLayout(false);
            this.painelSangria.PerformLayout();
            this.painelDesconto.ResumeLayout(false);
            this.painelDesconto.PerformLayout();
            this.painelTaxa.ResumeLayout(false);
            this.painelTaxa.PerformLayout();
            this.painelCaixa.ResumeLayout(false);
            this.painelCaixa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSangria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.DateTimePicker dtpDataSangria;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Panel panelBuscarFuncionario;
        private System.Windows.Forms.TextBox tbBuscarFuncionario;
        private System.Windows.Forms.PictureBox pbFuncionario;
        private System.Windows.Forms.Panel panelEstorno;
        private System.Windows.Forms.Label lbTituloEstorno;
        private System.Windows.Forms.Label lbTotalEstorno;
        private System.Windows.Forms.Panel panelCaixaRestante;
        private System.Windows.Forms.Label lbRestoCaixa;
        private System.Windows.Forms.Label lbCaixaRestante;
        private System.Windows.Forms.Panel painelSangria;
        private System.Windows.Forms.Label lbTituloSangria;
        private System.Windows.Forms.Label lbSangriaTotal;
        private System.Windows.Forms.Panel painelDesconto;
        private System.Windows.Forms.Label lbTituloDesconto;
        private System.Windows.Forms.Label lbDesconto;
        private System.Windows.Forms.Panel painelTaxa;
        private System.Windows.Forms.Label lbTituloTaxa;
        private System.Windows.Forms.Label lbTaxa;
        private System.Windows.Forms.Panel painelCaixa;
        private System.Windows.Forms.Label lbTituloCaixa;
        private System.Windows.Forms.Label lbCaixaTotal;
        private System.Windows.Forms.DataGridView dgvSangria;
        private System.Windows.Forms.PictureBox pbTitulo;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btSangriaTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorParcialVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn sangriaCaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoFormaPagamento;
        private System.Windows.Forms.DataGridViewComboBoxColumn formaPagamentoParcial;
        private System.Windows.Forms.DataGridViewTextBoxColumn descontoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentagemTaxa;
        private System.Windows.Forms.DataGridViewTextBoxColumn estornoCaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn contador;
    }
}