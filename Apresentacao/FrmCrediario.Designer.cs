namespace Apresentacao
{
    partial class FrmCrediario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrediario));
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.cbPendente = new System.Windows.Forms.CheckBox();
            this.cbPagos = new System.Windows.Forms.CheckBox();
            this.pbLimpar = new System.Windows.Forms.PictureBox();
            this.cbEstatus = new System.Windows.Forms.CheckBox();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.lbCpf = new System.Windows.Forms.Label();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.lbDataInicial = new System.Windows.Forms.Label();
            this.lbDataFinal = new System.Windows.Forms.Label();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.pbFiltrar = new System.Windows.Forms.PictureBox();
            this.panelBuscarCliente = new System.Windows.Forms.Panel();
            this.tbBuscarClienteCrediario = new System.Windows.Forms.TextBox();
            this.painelCrediarioTotal = new System.Windows.Forms.Panel();
            this.lbTituloTotalCrediario = new System.Windows.Forms.Label();
            this.lbCrediarioTotal = new System.Windows.Forms.Label();
            this.painelTotalCliente = new System.Windows.Forms.Panel();
            this.pbOk = new System.Windows.Forms.PictureBox();
            this.lbTituloTotalCliente = new System.Windows.Forms.Label();
            this.lbTotalCliente = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btReceber = new System.Windows.Forms.Button();
            this.painelQuantidade = new System.Windows.Forms.Panel();
            this.lbTituloQuantidade = new System.Windows.Forms.Label();
            this.lbQuantidadeCrediario = new System.Windows.Forms.Label();
            this.dgvCrediario = new System.Windows.Forms.DataGridView();
            this.codigoCrediario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobrenomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeCrediario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contaCrediario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCrediario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusCrediario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btSair = new System.Windows.Forms.Button();
            this.btParcial = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.pbBuscarCrediario = new System.Windows.Forms.PictureBox();
            this.pbCliente = new System.Windows.Forms.PictureBox();
            this.pbCrediario = new System.Windows.Forms.PictureBox();
            this.pbCrediarioAviso = new System.Windows.Forms.PictureBox();
            this.lbAvisoCrediario = new System.Windows.Forms.Label();
            this.gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLimpar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiltrar)).BeginInit();
            this.painelCrediarioTotal.SuspendLayout();
            this.painelTotalCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOk)).BeginInit();
            this.painelQuantidade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrediario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarCrediario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrediario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrediarioAviso)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.cbPendente);
            this.gbFiltros.Controls.Add(this.cbPagos);
            this.gbFiltros.Controls.Add(this.pbLimpar);
            this.gbFiltros.Controls.Add(this.cbEstatus);
            this.gbFiltros.Controls.Add(this.mtbCpf);
            this.gbFiltros.Controls.Add(this.lbCpf);
            this.gbFiltros.Controls.Add(this.dtpDataInicial);
            this.gbFiltros.Controls.Add(this.lbDataInicial);
            this.gbFiltros.Controls.Add(this.lbDataFinal);
            this.gbFiltros.Controls.Add(this.dtpDataFinal);
            this.gbFiltros.Controls.Add(this.pbFiltrar);
            this.gbFiltros.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.gbFiltros.Location = new System.Drawing.Point(486, 4);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(693, 98);
            this.gbFiltros.TabIndex = 1;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros:";
            // 
            // cbPendente
            // 
            this.cbPendente.AutoSize = true;
            this.cbPendente.Checked = true;
            this.cbPendente.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPendente.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.cbPendente.Location = new System.Drawing.Point(6, 48);
            this.cbPendente.Name = "cbPendente";
            this.cbPendente.Size = new System.Drawing.Size(98, 20);
            this.cbPendente.TabIndex = 1;
            this.cbPendente.Text = "Pendente";
            this.cbPendente.UseVisualStyleBackColor = true;
            this.cbPendente.CheckedChanged += new System.EventHandler(this.cbPendente_CheckedChanged);
            // 
            // cbPagos
            // 
            this.cbPagos.AutoSize = true;
            this.cbPagos.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.cbPagos.Location = new System.Drawing.Point(6, 22);
            this.cbPagos.Name = "cbPagos";
            this.cbPagos.Size = new System.Drawing.Size(73, 20);
            this.cbPagos.TabIndex = 0;
            this.cbPagos.Text = "Pagos";
            this.cbPagos.UseVisualStyleBackColor = true;
            this.cbPagos.CheckedChanged += new System.EventHandler(this.cbPagos_CheckedChanged);
            // 
            // pbLimpar
            // 
            this.pbLimpar.Image = global::Apresentacao.Properties.Resources.Clear;
            this.pbLimpar.Location = new System.Drawing.Point(660, 63);
            this.pbLimpar.Name = "pbLimpar";
            this.pbLimpar.Size = new System.Drawing.Size(27, 27);
            this.pbLimpar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLimpar.TabIndex = 148;
            this.pbLimpar.TabStop = false;
            this.pbLimpar.Click += new System.EventHandler(this.pbLimpar_Click);
            // 
            // cbEstatus
            // 
            this.cbEstatus.AutoSize = true;
            this.cbEstatus.Checked = true;
            this.cbEstatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEstatus.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.cbEstatus.Location = new System.Drawing.Point(6, 74);
            this.cbEstatus.Name = "cbEstatus";
            this.cbEstatus.Size = new System.Drawing.Size(114, 20);
            this.cbEstatus.TabIndex = 2;
            this.cbEstatus.Text = "Bloqueados";
            this.cbEstatus.UseVisualStyleBackColor = true;
            this.cbEstatus.CheckedChanged += new System.EventHandler(this.cbEstatus_CheckedChanged);
            // 
            // mtbCpf
            // 
            this.mtbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCpf.Location = new System.Drawing.Point(203, 64);
            this.mtbCpf.Mask = "999,999,999-99";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(158, 27);
            this.mtbCpf.TabIndex = 4;
            this.mtbCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbCpf_KeyPress);
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpf.Location = new System.Drawing.Point(155, 71);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(42, 20);
            this.lbCpf.TabIndex = 3;
            this.lbCpf.Text = "CPF";
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(367, 64);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(124, 27);
            this.dtpDataInicial.TabIndex = 6;
            // 
            // lbDataInicial
            // 
            this.lbDataInicial.AutoSize = true;
            this.lbDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDataInicial.Location = new System.Drawing.Point(363, 40);
            this.lbDataInicial.Name = "lbDataInicial";
            this.lbDataInicial.Size = new System.Drawing.Size(93, 20);
            this.lbDataInicial.TabIndex = 5;
            this.lbDataInicial.Text = "Data Inicial";
            // 
            // lbDataFinal
            // 
            this.lbDataFinal.AutoSize = true;
            this.lbDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDataFinal.Location = new System.Drawing.Point(493, 40);
            this.lbDataFinal.Name = "lbDataFinal";
            this.lbDataFinal.Size = new System.Drawing.Size(86, 20);
            this.lbDataFinal.TabIndex = 7;
            this.lbDataFinal.Text = "Data Final";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(497, 64);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(124, 27);
            this.dtpDataFinal.TabIndex = 8;
            // 
            // pbFiltrar
            // 
            this.pbFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFiltrar.Image = global::Apresentacao.Properties.Resources.FiltroImg;
            this.pbFiltrar.Location = new System.Drawing.Point(627, 64);
            this.pbFiltrar.Name = "pbFiltrar";
            this.pbFiltrar.Size = new System.Drawing.Size(27, 27);
            this.pbFiltrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFiltrar.TabIndex = 110;
            this.pbFiltrar.TabStop = false;
            this.pbFiltrar.Click += new System.EventHandler(this.pbFiltrar_Click);
            // 
            // panelBuscarCliente
            // 
            this.panelBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelBuscarCliente.Location = new System.Drawing.Point(70, 99);
            this.panelBuscarCliente.Name = "panelBuscarCliente";
            this.panelBuscarCliente.Size = new System.Drawing.Size(343, 2);
            this.panelBuscarCliente.TabIndex = 5;
            // 
            // tbBuscarClienteCrediario
            // 
            this.tbBuscarClienteCrediario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbBuscarClienteCrediario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBuscarClienteCrediario.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbBuscarClienteCrediario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbBuscarClienteCrediario.Location = new System.Drawing.Point(71, 77);
            this.tbBuscarClienteCrediario.Name = "tbBuscarClienteCrediario";
            this.tbBuscarClienteCrediario.Size = new System.Drawing.Size(343, 20);
            this.tbBuscarClienteCrediario.TabIndex = 0;
            this.tbBuscarClienteCrediario.Text = "Digite o nome do cliente ...";
            this.tbBuscarClienteCrediario.Enter += new System.EventHandler(this.tbBuscarClienteCrediario_Enter);
            this.tbBuscarClienteCrediario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscarClienteCrediario_KeyPress);
            this.tbBuscarClienteCrediario.Leave += new System.EventHandler(this.tbBuscarClienteCrediario_Leave);
            // 
            // painelCrediarioTotal
            // 
            this.painelCrediarioTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.painelCrediarioTotal.AutoScroll = true;
            this.painelCrediarioTotal.BackColor = System.Drawing.Color.Yellow;
            this.painelCrediarioTotal.Controls.Add(this.lbTituloTotalCrediario);
            this.painelCrediarioTotal.Controls.Add(this.lbCrediarioTotal);
            this.painelCrediarioTotal.Location = new System.Drawing.Point(1643, 28);
            this.painelCrediarioTotal.Name = "painelCrediarioTotal";
            this.painelCrediarioTotal.Size = new System.Drawing.Size(181, 74);
            this.painelCrediarioTotal.TabIndex = 4;
            // 
            // lbTituloTotalCrediario
            // 
            this.lbTituloTotalCrediario.AutoSize = true;
            this.lbTituloTotalCrediario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTituloTotalCrediario.ForeColor = System.Drawing.Color.Black;
            this.lbTituloTotalCrediario.Location = new System.Drawing.Point(3, 7);
            this.lbTituloTotalCrediario.Name = "lbTituloTotalCrediario";
            this.lbTituloTotalCrediario.Size = new System.Drawing.Size(149, 24);
            this.lbTituloTotalCrediario.TabIndex = 86;
            this.lbTituloTotalCrediario.Text = "Total Crediario";
            this.lbTituloTotalCrediario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCrediarioTotal
            // 
            this.lbCrediarioTotal.AutoSize = true;
            this.lbCrediarioTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbCrediarioTotal.ForeColor = System.Drawing.Color.Black;
            this.lbCrediarioTotal.Location = new System.Drawing.Point(3, 39);
            this.lbCrediarioTotal.Name = "lbCrediarioTotal";
            this.lbCrediarioTotal.Size = new System.Drawing.Size(80, 24);
            this.lbCrediarioTotal.TabIndex = 84;
            this.lbCrediarioTotal.Text = "R$ 0,00";
            this.lbCrediarioTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // painelTotalCliente
            // 
            this.painelTotalCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.painelTotalCliente.AutoScroll = true;
            this.painelTotalCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.painelTotalCliente.Controls.Add(this.pbOk);
            this.painelTotalCliente.Controls.Add(this.lbTituloTotalCliente);
            this.painelTotalCliente.Controls.Add(this.lbTotalCliente);
            this.painelTotalCliente.Location = new System.Drawing.Point(1185, 28);
            this.painelTotalCliente.Name = "painelTotalCliente";
            this.painelTotalCliente.Size = new System.Drawing.Size(265, 74);
            this.painelTotalCliente.TabIndex = 2;
            // 
            // pbOk
            // 
            this.pbOk.Image = global::Apresentacao.Properties.Resources.DialogErro;
            this.pbOk.Location = new System.Drawing.Point(239, 3);
            this.pbOk.Name = "pbOk";
            this.pbOk.Size = new System.Drawing.Size(23, 23);
            this.pbOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOk.TabIndex = 147;
            this.pbOk.TabStop = false;
            this.pbOk.Visible = false;
            // 
            // lbTituloTotalCliente
            // 
            this.lbTituloTotalCliente.AutoSize = true;
            this.lbTituloTotalCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTituloTotalCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTituloTotalCliente.Location = new System.Drawing.Point(3, 7);
            this.lbTituloTotalCliente.Name = "lbTituloTotalCliente";
            this.lbTituloTotalCliente.Size = new System.Drawing.Size(137, 24);
            this.lbTituloTotalCliente.TabIndex = 87;
            this.lbTituloTotalCliente.Text = "Conta Cliente";
            this.lbTituloTotalCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotalCliente
            // 
            this.lbTotalCliente.AutoSize = true;
            this.lbTotalCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTotalCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTotalCliente.Location = new System.Drawing.Point(3, 39);
            this.lbTotalCliente.Name = "lbTotalCliente";
            this.lbTotalCliente.Size = new System.Drawing.Size(80, 24);
            this.lbTotalCliente.TabIndex = 84;
            this.lbTotalCliente.Text = "R$ 0,00";
            this.lbTotalCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCancelar.Location = new System.Drawing.Point(284, 584);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(130, 42);
            this.btCancelar.TabIndex = 9;
            this.btCancelar.Text = "F2 Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btReceber
            // 
            this.btReceber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btReceber.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btReceber.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btReceber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReceber.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btReceber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btReceber.Location = new System.Drawing.Point(148, 584);
            this.btReceber.Name = "btReceber";
            this.btReceber.Size = new System.Drawing.Size(130, 42);
            this.btReceber.TabIndex = 8;
            this.btReceber.Text = "F10 Receber";
            this.btReceber.UseVisualStyleBackColor = false;
            this.btReceber.Click += new System.EventHandler(this.btReceber_Click);
            // 
            // painelQuantidade
            // 
            this.painelQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.painelQuantidade.AutoScroll = true;
            this.painelQuantidade.BackColor = System.Drawing.Color.DeepPink;
            this.painelQuantidade.Controls.Add(this.lbTituloQuantidade);
            this.painelQuantidade.Controls.Add(this.lbQuantidadeCrediario);
            this.painelQuantidade.Location = new System.Drawing.Point(1456, 27);
            this.painelQuantidade.Name = "painelQuantidade";
            this.painelQuantidade.Size = new System.Drawing.Size(181, 74);
            this.painelQuantidade.TabIndex = 3;
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
            // lbQuantidadeCrediario
            // 
            this.lbQuantidadeCrediario.AutoSize = true;
            this.lbQuantidadeCrediario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbQuantidadeCrediario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbQuantidadeCrediario.Location = new System.Drawing.Point(3, 39);
            this.lbQuantidadeCrediario.Name = "lbQuantidadeCrediario";
            this.lbQuantidadeCrediario.Size = new System.Drawing.Size(21, 24);
            this.lbQuantidadeCrediario.TabIndex = 84;
            this.lbQuantidadeCrediario.Text = "0";
            this.lbQuantidadeCrediario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvCrediario
            // 
            this.dgvCrediario.AllowUserToAddRows = false;
            this.dgvCrediario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dgvCrediario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCrediario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCrediario.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCrediario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCrediario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCrediario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoCrediario,
            this.nomeCliente,
            this.sobrenomeCliente,
            this.cpfCliente,
            this.celularCliente,
            this.enderecoCliente,
            this.bairroCliente,
            this.numeroCliente,
            this.cepCliente,
            this.cidadeCliente,
            this.quantidadeCrediario,
            this.contaCrediario,
            this.dataCrediario,
            this.estatusCrediario});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCrediario.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCrediario.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCrediario.Location = new System.Drawing.Point(12, 108);
            this.dgvCrediario.Name = "dgvCrediario";
            this.dgvCrediario.ReadOnly = true;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.dgvCrediario.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCrediario.RowTemplate.Height = 24;
            this.dgvCrediario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCrediario.Size = new System.Drawing.Size(1812, 470);
            this.dgvCrediario.TabIndex = 6;
            this.dgvCrediario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCrediario_CellClick);
            this.dgvCrediario.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCrediario_CellMouseDoubleClick);
            // 
            // codigoCrediario
            // 
            this.codigoCrediario.HeaderText = "Cód";
            this.codigoCrediario.Name = "codigoCrediario";
            this.codigoCrediario.ReadOnly = true;
            this.codigoCrediario.ToolTipText = "Código";
            this.codigoCrediario.Width = 50;
            // 
            // nomeCliente
            // 
            this.nomeCliente.HeaderText = "Nome";
            this.nomeCliente.Name = "nomeCliente";
            this.nomeCliente.ReadOnly = true;
            this.nomeCliente.ToolTipText = "Nome ";
            this.nomeCliente.Width = 150;
            // 
            // sobrenomeCliente
            // 
            this.sobrenomeCliente.HeaderText = "Sobrenome";
            this.sobrenomeCliente.Name = "sobrenomeCliente";
            this.sobrenomeCliente.ReadOnly = true;
            this.sobrenomeCliente.ToolTipText = "Sobrenome";
            this.sobrenomeCliente.Width = 130;
            // 
            // cpfCliente
            // 
            this.cpfCliente.HeaderText = "CPF";
            this.cpfCliente.Name = "cpfCliente";
            this.cpfCliente.ReadOnly = true;
            this.cpfCliente.ToolTipText = "CPF";
            this.cpfCliente.Width = 80;
            // 
            // celularCliente
            // 
            this.celularCliente.HeaderText = "Celular";
            this.celularCliente.Name = "celularCliente";
            this.celularCliente.ReadOnly = true;
            this.celularCliente.ToolTipText = "Celular";
            this.celularCliente.Width = 90;
            // 
            // enderecoCliente
            // 
            this.enderecoCliente.HeaderText = "Endereço";
            this.enderecoCliente.Name = "enderecoCliente";
            this.enderecoCliente.ReadOnly = true;
            this.enderecoCliente.ToolTipText = "Endereço";
            this.enderecoCliente.Width = 200;
            // 
            // bairroCliente
            // 
            this.bairroCliente.HeaderText = "Bairro";
            this.bairroCliente.Name = "bairroCliente";
            this.bairroCliente.ReadOnly = true;
            this.bairroCliente.ToolTipText = "Bairro";
            this.bairroCliente.Width = 90;
            // 
            // numeroCliente
            // 
            this.numeroCliente.HeaderText = "Número";
            this.numeroCliente.Name = "numeroCliente";
            this.numeroCliente.ReadOnly = true;
            this.numeroCliente.ToolTipText = "Número";
            this.numeroCliente.Width = 70;
            // 
            // cepCliente
            // 
            this.cepCliente.HeaderText = "CEP";
            this.cepCliente.Name = "cepCliente";
            this.cepCliente.ReadOnly = true;
            this.cepCliente.ToolTipText = "CEP";
            this.cepCliente.Width = 80;
            // 
            // cidadeCliente
            // 
            this.cidadeCliente.HeaderText = "Cidade";
            this.cidadeCliente.Name = "cidadeCliente";
            this.cidadeCliente.ReadOnly = true;
            this.cidadeCliente.ToolTipText = "Cidade";
            // 
            // quantidadeCrediario
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.quantidadeCrediario.DefaultCellStyle = dataGridViewCellStyle3;
            this.quantidadeCrediario.HeaderText = "Quantidade";
            this.quantidadeCrediario.Name = "quantidadeCrediario";
            this.quantidadeCrediario.ReadOnly = true;
            this.quantidadeCrediario.ToolTipText = "Quantidade de Itens no Crediario";
            // 
            // contaCrediario
            // 
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.contaCrediario.DefaultCellStyle = dataGridViewCellStyle4;
            this.contaCrediario.HeaderText = "Conta";
            this.contaCrediario.Name = "contaCrediario";
            this.contaCrediario.ReadOnly = true;
            // 
            // dataCrediario
            // 
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.dataCrediario.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataCrediario.HeaderText = "Data";
            this.dataCrediario.Name = "dataCrediario";
            this.dataCrediario.ReadOnly = true;
            // 
            // estatusCrediario
            // 
            this.estatusCrediario.HeaderText = "Estatus";
            this.estatusCrediario.Name = "estatusCrediario";
            this.estatusCrediario.ReadOnly = true;
            this.estatusCrediario.ToolTipText = "Estatus do Crediario";
            // 
            // btSair
            // 
            this.btSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSair.BackColor = System.Drawing.Color.Red;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSair.Location = new System.Drawing.Point(1694, 587);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(130, 42);
            this.btSair.TabIndex = 11;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btParcial
            // 
            this.btParcial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btParcial.BackColor = System.Drawing.Color.DeepPink;
            this.btParcial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btParcial.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btParcial.ForeColor = System.Drawing.Color.White;
            this.btParcial.Location = new System.Drawing.Point(420, 584);
            this.btParcial.Name = "btParcial";
            this.btParcial.Size = new System.Drawing.Size(130, 42);
            this.btParcial.TabIndex = 10;
            this.btParcial.Text = "Buscar Parcial";
            this.btParcial.UseVisualStyleBackColor = false;
            this.btParcial.Click += new System.EventHandler(this.btParcial_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btBuscar.BackColor = System.Drawing.Color.Turquoise;
            this.btBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBuscar.Location = new System.Drawing.Point(12, 584);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(130, 42);
            this.btBuscar.TabIndex = 7;
            this.btBuscar.Text = "F5 Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // pbBuscarCrediario
            // 
            this.pbBuscarCrediario.Image = global::Apresentacao.Properties.Resources.Selecionar;
            this.pbBuscarCrediario.Location = new System.Drawing.Point(453, 75);
            this.pbBuscarCrediario.Name = "pbBuscarCrediario";
            this.pbBuscarCrediario.Size = new System.Drawing.Size(27, 27);
            this.pbBuscarCrediario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscarCrediario.TabIndex = 126;
            this.pbBuscarCrediario.TabStop = false;
            this.pbBuscarCrediario.Click += new System.EventHandler(this.pbBuscarCrediario_Click);
            // 
            // pbCliente
            // 
            this.pbCliente.Image = global::Apresentacao.Properties.Resources.ClienteAzul;
            this.pbCliente.Location = new System.Drawing.Point(420, 74);
            this.pbCliente.Name = "pbCliente";
            this.pbCliente.Size = new System.Drawing.Size(27, 27);
            this.pbCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCliente.TabIndex = 125;
            this.pbCliente.TabStop = false;
            this.pbCliente.Click += new System.EventHandler(this.pbCliente_Click);
            // 
            // pbCrediario
            // 
            this.pbCrediario.Image = global::Apresentacao.Properties.Resources.CrediarioIcone;
            this.pbCrediario.Location = new System.Drawing.Point(12, 50);
            this.pbCrediario.Name = "pbCrediario";
            this.pbCrediario.Size = new System.Drawing.Size(52, 52);
            this.pbCrediario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCrediario.TabIndex = 121;
            this.pbCrediario.TabStop = false;
            // 
            // pbCrediarioAviso
            // 
            this.pbCrediarioAviso.Image = global::Apresentacao.Properties.Resources.CrediarioPendenteAviso;
            this.pbCrediarioAviso.Location = new System.Drawing.Point(12, 4);
            this.pbCrediarioAviso.Name = "pbCrediarioAviso";
            this.pbCrediarioAviso.Size = new System.Drawing.Size(38, 34);
            this.pbCrediarioAviso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCrediarioAviso.TabIndex = 129;
            this.pbCrediarioAviso.TabStop = false;
            // 
            // lbAvisoCrediario
            // 
            this.lbAvisoCrediario.AutoSize = true;
            this.lbAvisoCrediario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbAvisoCrediario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbAvisoCrediario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lbAvisoCrediario.Location = new System.Drawing.Point(56, 12);
            this.lbAvisoCrediario.Name = "lbAvisoCrediario";
            this.lbAvisoCrediario.Size = new System.Drawing.Size(147, 18);
            this.lbAvisoCrediario.TabIndex = 130;
            this.lbAvisoCrediario.Text = "Crediario Pendente";
            // 
            // FrmCrediario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1836, 641);
            this.Controls.Add(this.lbAvisoCrediario);
            this.Controls.Add(this.pbCrediarioAviso);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btParcial);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.dgvCrediario);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.painelQuantidade);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btReceber);
            this.Controls.Add(this.painelCrediarioTotal);
            this.Controls.Add(this.painelTotalCliente);
            this.Controls.Add(this.pbBuscarCrediario);
            this.Controls.Add(this.pbCliente);
            this.Controls.Add(this.panelBuscarCliente);
            this.Controls.Add(this.tbBuscarClienteCrediario);
            this.Controls.Add(this.pbCrediario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmCrediario";
            this.Text = "Crediario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCrediario_KeyDown);
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLimpar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiltrar)).EndInit();
            this.painelCrediarioTotal.ResumeLayout(false);
            this.painelCrediarioTotal.PerformLayout();
            this.painelTotalCliente.ResumeLayout(false);
            this.painelTotalCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOk)).EndInit();
            this.painelQuantidade.ResumeLayout(false);
            this.painelQuantidade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrediario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarCrediario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrediario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrediarioAviso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.PictureBox pbFiltrar;
        private System.Windows.Forms.Label lbDataInicial;
        private System.Windows.Forms.Label lbDataFinal;
        private System.Windows.Forms.PictureBox pbBuscarCrediario;
        private System.Windows.Forms.PictureBox pbCliente;
        private System.Windows.Forms.Panel panelBuscarCliente;
        private System.Windows.Forms.TextBox tbBuscarClienteCrediario;
        private System.Windows.Forms.PictureBox pbCrediario;
        private System.Windows.Forms.Panel painelCrediarioTotal;
        private System.Windows.Forms.Label lbTituloTotalCrediario;
        private System.Windows.Forms.Label lbCrediarioTotal;
        private System.Windows.Forms.Panel painelTotalCliente;
        private System.Windows.Forms.Label lbTituloTotalCliente;
        private System.Windows.Forms.Label lbTotalCliente;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btReceber;
        private System.Windows.Forms.Panel painelQuantidade;
        private System.Windows.Forms.Label lbTituloQuantidade;
        private System.Windows.Forms.Label lbQuantidadeCrediario;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.CheckBox cbEstatus;
        private System.Windows.Forms.DataGridView dgvCrediario;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.PictureBox pbOk;
        private System.Windows.Forms.PictureBox pbLimpar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoCrediario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobrenomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeCrediario;
        private System.Windows.Forms.DataGridViewTextBoxColumn contaCrediario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCrediario;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusCrediario;
        private System.Windows.Forms.CheckBox cbPendente;
        private System.Windows.Forms.Button btParcial;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.CheckBox cbPagos;
        private System.Windows.Forms.PictureBox pbCrediarioAviso;
        private System.Windows.Forms.Label lbAvisoCrediario;

    }
}