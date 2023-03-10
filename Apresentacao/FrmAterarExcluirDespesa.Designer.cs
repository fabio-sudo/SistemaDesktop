namespace Apresentacao
{
    partial class FrmAterarExcluirDespesa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAterarExcluirDespesa));
            this.lbDataDespesa = new System.Windows.Forms.Label();
            this.dtpDataDespesa = new System.Windows.Forms.DateTimePicker();
            this.cbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.lbFormaPagamento = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.mtbValorDespesa = new System.Windows.Forms.MaskedTextBox();
            this.lbValorDespesa = new System.Windows.Forms.Label();
            this.btSair = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.pbDespesa = new System.Windows.Forms.PictureBox();
            this.btExcluir = new System.Windows.Forms.Button();
            this.lbCodigoDespesa = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.epDespesa = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelDespesas = new System.Windows.Forms.Panel();
            this.lbTituloDespesas = new System.Windows.Forms.Label();
            this.lbTotalDespesas = new System.Windows.Forms.Label();
            this.panelEstorno = new System.Windows.Forms.Panel();
            this.lbTituloEstorno = new System.Windows.Forms.Label();
            this.lbTotalEstorno = new System.Windows.Forms.Label();
            this.painelSangria = new System.Windows.Forms.Panel();
            this.lbTituloSangria = new System.Windows.Forms.Label();
            this.lbSangriaTotal = new System.Windows.Forms.Label();
            this.painelCaixa = new System.Windows.Forms.Panel();
            this.lbTituloCaixa = new System.Windows.Forms.Label();
            this.lbCaixaTotal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTituloTotalVenda = new System.Windows.Forms.Label();
            this.dgvCaixa = new System.Windows.Forms.DataGridView();
            this.formaPagamentoCaixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorRealCaixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SangriaCaixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estornoCaixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.despesaCaixaGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbFuncionario = new System.Windows.Forms.PictureBox();
            this.panelFuncionario = new System.Windows.Forms.Panel();
            this.btFuncionario = new System.Windows.Forms.Button();
            this.tbFuncionario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDespesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDespesa)).BeginInit();
            this.panelDespesas.SuspendLayout();
            this.panelEstorno.SuspendLayout();
            this.painelSangria.SuspendLayout();
            this.painelCaixa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDataDespesa
            // 
            this.lbDataDespesa.AutoSize = true;
            this.lbDataDespesa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbDataDespesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lbDataDespesa.Location = new System.Drawing.Point(247, 12);
            this.lbDataDespesa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDataDespesa.Name = "lbDataDespesa";
            this.lbDataDespesa.Size = new System.Drawing.Size(33, 15);
            this.lbDataDespesa.TabIndex = 273;
            this.lbDataDespesa.Text = "Data";
            // 
            // dtpDataDespesa
            // 
            this.dtpDataDespesa.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dtpDataDespesa.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.dtpDataDespesa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDespesa.Location = new System.Drawing.Point(250, 31);
            this.dtpDataDespesa.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataDespesa.Name = "dtpDataDespesa";
            this.dtpDataDespesa.Size = new System.Drawing.Size(94, 23);
            this.dtpDataDespesa.TabIndex = 272;
            // 
            // cbFormaPagamento
            // 
            this.cbFormaPagamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFormaPagamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFormaPagamento.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaPagamento.Enabled = false;
            this.cbFormaPagamento.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.cbFormaPagamento.FormattingEnabled = true;
            this.cbFormaPagamento.Location = new System.Drawing.Point(11, 120);
            this.cbFormaPagamento.Margin = new System.Windows.Forms.Padding(2);
            this.cbFormaPagamento.Name = "cbFormaPagamento";
            this.cbFormaPagamento.Size = new System.Drawing.Size(138, 25);
            this.cbFormaPagamento.TabIndex = 271;
            // 
            // lbFormaPagamento
            // 
            this.lbFormaPagamento.AutoSize = true;
            this.lbFormaPagamento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbFormaPagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lbFormaPagamento.Location = new System.Drawing.Point(8, 103);
            this.lbFormaPagamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFormaPagamento.Name = "lbFormaPagamento";
            this.lbFormaPagamento.Size = new System.Drawing.Size(111, 15);
            this.lbFormaPagamento.TabIndex = 270;
            this.lbFormaPagamento.Text = "Forma Pagamento";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbDescricao.Location = new System.Drawing.Point(15, 178);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(361, 165);
            this.tbDescricao.TabIndex = 268;
            this.tbDescricao.Leave += new System.EventHandler(this.tbDescricao_Leave);
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lbDescricao.Location = new System.Drawing.Point(12, 160);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(65, 15);
            this.lbDescricao.TabIndex = 267;
            this.lbDescricao.Text = "Descrição";
            // 
            // mtbValorDespesa
            // 
            this.mtbValorDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.mtbValorDespesa.Location = new System.Drawing.Point(122, 31);
            this.mtbValorDespesa.Name = "mtbValorDespesa";
            this.mtbValorDespesa.Size = new System.Drawing.Size(123, 23);
            this.mtbValorDespesa.TabIndex = 266;
            this.mtbValorDespesa.TextChanged += new System.EventHandler(this.mtbValorDespesa_TextChanged);
            this.mtbValorDespesa.Leave += new System.EventHandler(this.mtbValorDespesa_Leave);
            // 
            // lbValorDespesa
            // 
            this.lbValorDespesa.AutoSize = true;
            this.lbValorDespesa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbValorDespesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lbValorDespesa.Location = new System.Drawing.Point(122, 12);
            this.lbValorDespesa.Name = "lbValorDespesa";
            this.lbValorDespesa.Size = new System.Drawing.Size(54, 15);
            this.lbValorDespesa.TabIndex = 265;
            this.lbValorDespesa.Text = "Valor R$";
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Red;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSair.ForeColor = System.Drawing.Color.White;
            this.btSair.Location = new System.Drawing.Point(265, 373);
            this.btSair.Margin = new System.Windows.Forms.Padding(2);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(98, 34);
            this.btSair.TabIndex = 264;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btAlterar.FlatAppearance.BorderSize = 0;
            this.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlterar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btAlterar.ForeColor = System.Drawing.Color.White;
            this.btAlterar.Location = new System.Drawing.Point(11, 373);
            this.btAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(98, 34);
            this.btAlterar.TabIndex = 263;
            this.btAlterar.Text = "F10 Alterar";
            this.btAlterar.UseVisualStyleBackColor = false;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // pbDespesa
            // 
            this.pbDespesa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbDespesa.Image = global::Apresentacao.Properties.Resources.wallet;
            this.pbDespesa.Location = new System.Drawing.Point(12, 12);
            this.pbDespesa.Name = "pbDespesa";
            this.pbDespesa.Size = new System.Drawing.Size(39, 42);
            this.pbDespesa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDespesa.TabIndex = 269;
            this.pbDespesa.TabStop = false;
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.DeepPink;
            this.btExcluir.FlatAppearance.BorderSize = 0;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btExcluir.ForeColor = System.Drawing.Color.White;
            this.btExcluir.Location = new System.Drawing.Point(113, 373);
            this.btExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(98, 34);
            this.btExcluir.TabIndex = 274;
            this.btExcluir.Text = "F2 Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // lbCodigoDespesa
            // 
            this.lbCodigoDespesa.AutoSize = true;
            this.lbCodigoDespesa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbCodigoDespesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lbCodigoDespesa.Location = new System.Drawing.Point(56, 13);
            this.lbCodigoDespesa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCodigoDespesa.Name = "lbCodigoDespesa";
            this.lbCodigoDespesa.Size = new System.Drawing.Size(46, 15);
            this.lbCodigoDespesa.TabIndex = 276;
            this.lbCodigoDespesa.Text = "Código";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Enabled = false;
            this.tbCodigo.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.tbCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbCodigo.Location = new System.Drawing.Point(59, 31);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(57, 23);
            this.tbCodigo.TabIndex = 275;
            // 
            // epDespesa
            // 
            this.epDespesa.ContainerControl = this;
            // 
            // panelDespesas
            // 
            this.panelDespesas.AutoScroll = true;
            this.panelDespesas.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelDespesas.Controls.Add(this.lbTituloDespesas);
            this.panelDespesas.Controls.Add(this.lbTotalDespesas);
            this.panelDespesas.Location = new System.Drawing.Point(381, 347);
            this.panelDespesas.Margin = new System.Windows.Forms.Padding(2);
            this.panelDespesas.Name = "panelDespesas";
            this.panelDespesas.Size = new System.Drawing.Size(149, 60);
            this.panelDespesas.TabIndex = 283;
            // 
            // lbTituloDespesas
            // 
            this.lbTituloDespesas.AutoSize = true;
            this.lbTituloDespesas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTituloDespesas.ForeColor = System.Drawing.Color.White;
            this.lbTituloDespesas.Location = new System.Drawing.Point(2, 6);
            this.lbTituloDespesas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTituloDespesas.Name = "lbTituloDespesas";
            this.lbTituloDespesas.Size = new System.Drawing.Size(89, 19);
            this.lbTituloDespesas.TabIndex = 87;
            this.lbTituloDespesas.Text = "Despesas ";
            this.lbTituloDespesas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotalDespesas
            // 
            this.lbTotalDespesas.AutoSize = true;
            this.lbTotalDespesas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTotalDespesas.ForeColor = System.Drawing.Color.White;
            this.lbTotalDespesas.Location = new System.Drawing.Point(21, 32);
            this.lbTotalDespesas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalDespesas.Name = "lbTotalDespesas";
            this.lbTotalDespesas.Size = new System.Drawing.Size(92, 19);
            this.lbTotalDespesas.TabIndex = 84;
            this.lbTotalDespesas.Text = "R$ 1200,00";
            this.lbTotalDespesas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelEstorno
            // 
            this.panelEstorno.AutoScroll = true;
            this.panelEstorno.BackColor = System.Drawing.Color.Red;
            this.panelEstorno.Controls.Add(this.lbTituloEstorno);
            this.panelEstorno.Controls.Add(this.lbTotalEstorno);
            this.panelEstorno.Location = new System.Drawing.Point(534, 347);
            this.panelEstorno.Margin = new System.Windows.Forms.Padding(2);
            this.panelEstorno.Name = "panelEstorno";
            this.panelEstorno.Size = new System.Drawing.Size(149, 60);
            this.panelEstorno.TabIndex = 282;
            // 
            // lbTituloEstorno
            // 
            this.lbTituloEstorno.AutoSize = true;
            this.lbTituloEstorno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTituloEstorno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTituloEstorno.Location = new System.Drawing.Point(2, 6);
            this.lbTituloEstorno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTituloEstorno.Name = "lbTituloEstorno";
            this.lbTituloEstorno.Size = new System.Drawing.Size(79, 19);
            this.lbTituloEstorno.TabIndex = 0;
            this.lbTituloEstorno.Text = "Estorno -";
            this.lbTituloEstorno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotalEstorno
            // 
            this.lbTotalEstorno.AutoSize = true;
            this.lbTotalEstorno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTotalEstorno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTotalEstorno.Location = new System.Drawing.Point(21, 32);
            this.lbTotalEstorno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalEstorno.Name = "lbTotalEstorno";
            this.lbTotalEstorno.Size = new System.Drawing.Size(65, 19);
            this.lbTotalEstorno.TabIndex = 1;
            this.lbTotalEstorno.Text = "R$ 0,00";
            this.lbTotalEstorno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // painelSangria
            // 
            this.painelSangria.AutoScroll = true;
            this.painelSangria.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.painelSangria.Controls.Add(this.lbTituloSangria);
            this.painelSangria.Controls.Add(this.lbSangriaTotal);
            this.painelSangria.Location = new System.Drawing.Point(687, 347);
            this.painelSangria.Margin = new System.Windows.Forms.Padding(2);
            this.painelSangria.Name = "painelSangria";
            this.painelSangria.Size = new System.Drawing.Size(149, 60);
            this.painelSangria.TabIndex = 281;
            // 
            // lbTituloSangria
            // 
            this.lbTituloSangria.AutoSize = true;
            this.lbTituloSangria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTituloSangria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTituloSangria.Location = new System.Drawing.Point(4, 6);
            this.lbTituloSangria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTituloSangria.Name = "lbTituloSangria";
            this.lbTituloSangria.Size = new System.Drawing.Size(77, 19);
            this.lbTituloSangria.TabIndex = 0;
            this.lbTituloSangria.Text = "Sangria -";
            this.lbTituloSangria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSangriaTotal
            // 
            this.lbSangriaTotal.AutoSize = true;
            this.lbSangriaTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbSangriaTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSangriaTotal.Location = new System.Drawing.Point(21, 32);
            this.lbSangriaTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSangriaTotal.Name = "lbSangriaTotal";
            this.lbSangriaTotal.Size = new System.Drawing.Size(65, 19);
            this.lbSangriaTotal.TabIndex = 1;
            this.lbSangriaTotal.Text = "R$ 0,00";
            this.lbSangriaTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // painelCaixa
            // 
            this.painelCaixa.AutoScroll = true;
            this.painelCaixa.BackColor = System.Drawing.Color.Turquoise;
            this.painelCaixa.Controls.Add(this.lbTituloCaixa);
            this.painelCaixa.Controls.Add(this.lbCaixaTotal);
            this.painelCaixa.Location = new System.Drawing.Point(840, 347);
            this.painelCaixa.Margin = new System.Windows.Forms.Padding(2);
            this.painelCaixa.Name = "painelCaixa";
            this.painelCaixa.Size = new System.Drawing.Size(149, 60);
            this.painelCaixa.TabIndex = 280;
            // 
            // lbTituloCaixa
            // 
            this.lbTituloCaixa.AutoSize = true;
            this.lbTituloCaixa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTituloCaixa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTituloCaixa.Location = new System.Drawing.Point(2, 6);
            this.lbTituloCaixa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTituloCaixa.Name = "lbTituloCaixa";
            this.lbTituloCaixa.Size = new System.Drawing.Size(65, 19);
            this.lbTituloCaixa.TabIndex = 0;
            this.lbTituloCaixa.Text = "Caixa +";
            this.lbTituloCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCaixaTotal
            // 
            this.lbCaixaTotal.AutoSize = true;
            this.lbCaixaTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbCaixaTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCaixaTotal.Location = new System.Drawing.Point(27, 32);
            this.lbCaixaTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCaixaTotal.Name = "lbCaixaTotal";
            this.lbCaixaTotal.Size = new System.Drawing.Size(65, 19);
            this.lbCaixaTotal.TabIndex = 1;
            this.lbCaixaTotal.Text = "R$ 0,00";
            this.lbCaixaTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Apresentacao.Properties.Resources.DialogVenda;
            this.pictureBox1.Location = new System.Drawing.Point(381, 67);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 279;
            this.pictureBox1.TabStop = false;
            // 
            // lbTituloTotalVenda
            // 
            this.lbTituloTotalVenda.AutoSize = true;
            this.lbTituloTotalVenda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTituloTotalVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lbTituloTotalVenda.Location = new System.Drawing.Point(417, 80);
            this.lbTituloTotalVenda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTituloTotalVenda.Name = "lbTituloTotalVenda";
            this.lbTituloTotalVenda.Size = new System.Drawing.Size(167, 19);
            this.lbTituloTotalVenda.TabIndex = 278;
            this.lbTituloTotalVenda.Text = "Movimentação Caixa";
            this.lbTituloTotalVenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvCaixa
            // 
            this.dgvCaixa.AllowUserToAddRows = false;
            this.dgvCaixa.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dgvCaixa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            this.formaPagamentoCaixa,
            this.Caixa,
            this.valorRealCaixa,
            this.SangriaCaixa,
            this.estornoCaixa,
            this.despesaCaixaGrid});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCaixa.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCaixa.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCaixa.Location = new System.Drawing.Point(381, 103);
            this.dgvCaixa.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCaixa.Name = "dgvCaixa";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.dgvCaixa.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCaixa.RowTemplate.Height = 24;
            this.dgvCaixa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCaixa.Size = new System.Drawing.Size(608, 240);
            this.dgvCaixa.TabIndex = 277;
            // 
            // formaPagamentoCaixa
            // 
            this.formaPagamentoCaixa.HeaderText = "Pagamento";
            this.formaPagamentoCaixa.Name = "formaPagamentoCaixa";
            this.formaPagamentoCaixa.ReadOnly = true;
            this.formaPagamentoCaixa.ToolTipText = "Forma de Pagamento";
            // 
            // Caixa
            // 
            this.Caixa.DataPropertyName = "caixaUsuario";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Caixa.DefaultCellStyle = dataGridViewCellStyle3;
            this.Caixa.HeaderText = "Caixa";
            this.Caixa.Name = "Caixa";
            this.Caixa.ReadOnly = true;
            this.Caixa.ToolTipText = "Total do Caixa";
            this.Caixa.Width = 95;
            // 
            // valorRealCaixa
            // 
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.valorRealCaixa.DefaultCellStyle = dataGridViewCellStyle4;
            this.valorRealCaixa.HeaderText = "Líquido";
            this.valorRealCaixa.Name = "valorRealCaixa";
            this.valorRealCaixa.Width = 95;
            // 
            // SangriaCaixa
            // 
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.SangriaCaixa.DefaultCellStyle = dataGridViewCellStyle5;
            this.SangriaCaixa.HeaderText = "Sangria";
            this.SangriaCaixa.Name = "SangriaCaixa";
            this.SangriaCaixa.ReadOnly = true;
            this.SangriaCaixa.Width = 95;
            // 
            // estornoCaixa
            // 
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.estornoCaixa.DefaultCellStyle = dataGridViewCellStyle6;
            this.estornoCaixa.HeaderText = "Estorno";
            this.estornoCaixa.Name = "estornoCaixa";
            this.estornoCaixa.Width = 95;
            // 
            // despesaCaixaGrid
            // 
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.despesaCaixaGrid.DefaultCellStyle = dataGridViewCellStyle7;
            this.despesaCaixaGrid.HeaderText = "Despesa";
            this.despesaCaixaGrid.Name = "despesaCaixaGrid";
            this.despesaCaixaGrid.Width = 95;
            // 
            // pbFuncionario
            // 
            this.pbFuncionario.Image = global::Apresentacao.Properties.Resources.FuncionarioAzul;
            this.pbFuncionario.Location = new System.Drawing.Point(11, 62);
            this.pbFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.pbFuncionario.Name = "pbFuncionario";
            this.pbFuncionario.Size = new System.Drawing.Size(26, 28);
            this.pbFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFuncionario.TabIndex = 287;
            this.pbFuncionario.TabStop = false;
            // 
            // panelFuncionario
            // 
            this.panelFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelFuncionario.Location = new System.Drawing.Point(11, 92);
            this.panelFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.panelFuncionario.Name = "panelFuncionario";
            this.panelFuncionario.Size = new System.Drawing.Size(258, 2);
            this.panelFuncionario.TabIndex = 286;
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
            this.btFuncionario.Location = new System.Drawing.Point(272, 60);
            this.btFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.btFuncionario.Name = "btFuncionario";
            this.btFuncionario.Size = new System.Drawing.Size(72, 34);
            this.btFuncionario.TabIndex = 285;
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
            this.tbFuncionario.Location = new System.Drawing.Point(41, 72);
            this.tbFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.tbFuncionario.Name = "tbFuncionario";
            this.tbFuncionario.Size = new System.Drawing.Size(226, 16);
            this.tbFuncionario.TabIndex = 284;
            this.tbFuncionario.Text = "Digite o nome do funcionário ...";
            this.tbFuncionario.Enter += new System.EventHandler(this.tbFuncionario_Enter);
            this.tbFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFuncionario_KeyPress);
            this.tbFuncionario.Leave += new System.EventHandler(this.tbFuncionario_Leave);
            // 
            // FrmAterarExcluirDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1004, 429);
            this.Controls.Add(this.pbFuncionario);
            this.Controls.Add(this.panelFuncionario);
            this.Controls.Add(this.btFuncionario);
            this.Controls.Add(this.tbFuncionario);
            this.Controls.Add(this.panelDespesas);
            this.Controls.Add(this.panelEstorno);
            this.Controls.Add(this.painelSangria);
            this.Controls.Add(this.painelCaixa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbTituloTotalVenda);
            this.Controls.Add(this.dgvCaixa);
            this.Controls.Add(this.lbCodigoDespesa);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.lbDataDespesa);
            this.Controls.Add(this.dtpDataDespesa);
            this.Controls.Add(this.cbFormaPagamento);
            this.Controls.Add(this.lbFormaPagamento);
            this.Controls.Add(this.pbDespesa);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.lbDescricao);
            this.Controls.Add(this.mtbValorDespesa);
            this.Controls.Add(this.lbValorDespesa);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btAlterar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmAterarExcluirDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar & Excluir Despesa";
            this.Load += new System.EventHandler(this.FrmAterarExcluirDespesa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAterarExcluirDespesa_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbDespesa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDespesa)).EndInit();
            this.panelDespesas.ResumeLayout(false);
            this.panelDespesas.PerformLayout();
            this.panelEstorno.ResumeLayout(false);
            this.panelEstorno.PerformLayout();
            this.painelSangria.ResumeLayout(false);
            this.painelSangria.PerformLayout();
            this.painelCaixa.ResumeLayout(false);
            this.painelCaixa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDataDespesa;
        private System.Windows.Forms.DateTimePicker dtpDataDespesa;
        private System.Windows.Forms.ComboBox cbFormaPagamento;
        private System.Windows.Forms.Label lbFormaPagamento;
        private System.Windows.Forms.PictureBox pbDespesa;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.MaskedTextBox mtbValorDespesa;
        private System.Windows.Forms.Label lbValorDespesa;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Label lbCodigoDespesa;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.ErrorProvider epDespesa;
        private System.Windows.Forms.Panel panelDespesas;
        private System.Windows.Forms.Label lbTituloDespesas;
        private System.Windows.Forms.Label lbTotalDespesas;
        private System.Windows.Forms.Panel panelEstorno;
        private System.Windows.Forms.Label lbTituloEstorno;
        private System.Windows.Forms.Label lbTotalEstorno;
        private System.Windows.Forms.Panel painelSangria;
        private System.Windows.Forms.Label lbTituloSangria;
        private System.Windows.Forms.Label lbSangriaTotal;
        private System.Windows.Forms.Panel painelCaixa;
        private System.Windows.Forms.Label lbTituloCaixa;
        private System.Windows.Forms.Label lbCaixaTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTituloTotalVenda;
        private System.Windows.Forms.DataGridView dgvCaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaPagamentoCaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorRealCaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn SangriaCaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn estornoCaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn despesaCaixaGrid;
        private System.Windows.Forms.PictureBox pbFuncionario;
        private System.Windows.Forms.Panel panelFuncionario;
        private System.Windows.Forms.Button btFuncionario;
        private System.Windows.Forms.TextBox tbFuncionario;
    }
}