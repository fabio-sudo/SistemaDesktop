namespace Apresentacao
{
    partial class FrmCadastroProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroProduto));
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btSelecionar = new System.Windows.Forms.Button();
            this.tbReferencia = new System.Windows.Forms.TextBox();
            this.lbReferencia = new System.Windows.Forms.Label();
            this.lbContadorImagens = new System.Windows.Forms.Label();
            this.dgvCor = new System.Windows.Forms.DataGridView();
            this.codigoCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.lbNomeCorImagem = new System.Windows.Forms.Label();
            this.dgvCorProduto = new System.Windows.Forms.DataGridView();
            this.tbCor = new System.Windows.Forms.TextBox();
            this.lbCor = new System.Windows.Forms.Label();
            this.btRemoverImagem = new System.Windows.Forms.Button();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.lbSexo = new System.Windows.Forms.Label();
            this.lbGenero = new System.Windows.Forms.Label();
            this.lbGrade = new System.Windows.Forms.Label();
            this.lbFornecedor = new System.Windows.Forms.Label();
            this.lbPrecoCusto = new System.Windows.Forms.Label();
            this.lbPrecoVenda = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.tbGenero = new System.Windows.Forms.TextBox();
            this.tbGrade = new System.Windows.Forms.TextBox();
            this.tbFornecedor = new System.Windows.Forms.TextBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.mtbCusto = new System.Windows.Forms.MaskedTextBox();
            this.mtbVenda = new System.Windows.Forms.MaskedTextBox();
            this.panelDivisor = new System.Windows.Forms.Panel();
            this.panelDivisorImagem = new System.Windows.Forms.Panel();
            this.gpPreco = new System.Windows.Forms.GroupBox();
            this.epProduto = new System.Windows.Forms.ErrorProvider(this.components);
            this.pbImagemProdutoZoom = new System.Windows.Forms.PictureBox();
            this.pbBuscarFornecedor = new System.Windows.Forms.PictureBox();
            this.pbBuscarGrade = new System.Windows.Forms.PictureBox();
            this.pbBuscarGenero = new System.Windows.Forms.PictureBox();
            this.pbProduto = new System.Windows.Forms.PictureBox();
            this.pbCor = new System.Windows.Forms.PictureBox();
            this.pbBuscarCor = new System.Windows.Forms.PictureBox();
            this.btVoltar = new System.Windows.Forms.Button();
            this.btAvancar = new System.Windows.Forms.Button();
            this.pbImagemProduto = new System.Windows.Forms.PictureBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contadorCores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordemCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorProduto)).BeginInit();
            this.gpPreco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemProdutoZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarGenero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarCor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.Turquoise;
            this.btCadastrar.FlatAppearance.BorderSize = 0;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCadastrar.ForeColor = System.Drawing.Color.White;
            this.btCadastrar.Location = new System.Drawing.Point(873, 642);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(130, 42);
            this.btCadastrar.TabIndex = 28;
            this.btCadastrar.Text = "F10 Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btSelecionar
            // 
            this.btSelecionar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btSelecionar.FlatAppearance.BorderSize = 0;
            this.btSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSelecionar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSelecionar.ForeColor = System.Drawing.Color.White;
            this.btSelecionar.Location = new System.Drawing.Point(808, 255);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(130, 42);
            this.btSelecionar.TabIndex = 25;
            this.btSelecionar.Text = "F4 Selecionar";
            this.btSelecionar.UseVisualStyleBackColor = false;
            this.btSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            // 
            // tbReferencia
            // 
            this.tbReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbReferencia.Location = new System.Drawing.Point(131, 127);
            this.tbReferencia.Name = "tbReferencia";
            this.tbReferencia.Size = new System.Drawing.Size(144, 27);
            this.tbReferencia.TabIndex = 3;
            this.tbReferencia.Leave += new System.EventHandler(this.tbReferencia_Leave);
            // 
            // lbReferencia
            // 
            this.lbReferencia.AutoSize = true;
            this.lbReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbReferencia.Location = new System.Drawing.Point(23, 134);
            this.lbReferencia.Name = "lbReferencia";
            this.lbReferencia.Size = new System.Drawing.Size(90, 20);
            this.lbReferencia.TabIndex = 2;
            this.lbReferencia.Text = "Referência";
            // 
            // lbContadorImagens
            // 
            this.lbContadorImagens.AutoSize = true;
            this.lbContadorImagens.Enabled = false;
            this.lbContadorImagens.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold);
            this.lbContadorImagens.Location = new System.Drawing.Point(1044, 221);
            this.lbContadorImagens.Name = "lbContadorImagens";
            this.lbContadorImagens.Size = new System.Drawing.Size(14, 17);
            this.lbContadorImagens.TabIndex = 23;
            this.lbContadorImagens.Text = "0";
            // 
            // dgvCor
            // 
            this.dgvCor.AllowUserToAddRows = false;
            this.dgvCor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dgvCor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCor.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoCor,
            this.nomeCor});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCor.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCor.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCor.Location = new System.Drawing.Point(19, 354);
            this.dgvCor.Name = "dgvCor";
            this.dgvCor.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.dgvCor.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCor.RowTemplate.Height = 24;
            this.dgvCor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCor.Size = new System.Drawing.Size(325, 330);
            this.dgvCor.TabIndex = 16;
            this.dgvCor.DoubleClick += new System.EventHandler(this.dgvCor_DoubleClick);
            // 
            // codigoCor
            // 
            this.codigoCor.DataPropertyName = "codigoCor";
            this.codigoCor.HeaderText = "Cód";
            this.codigoCor.Name = "codigoCor";
            this.codigoCor.ReadOnly = true;
            this.codigoCor.ToolTipText = "Código da Cor";
            this.codigoCor.Width = 50;
            // 
            // nomeCor
            // 
            this.nomeCor.DataPropertyName = "nomeCor";
            this.nomeCor.HeaderText = "Cor";
            this.nomeCor.Name = "nomeCor";
            this.nomeCor.ReadOnly = true;
            this.nomeCor.ToolTipText = "Nome da Cor";
            this.nomeCor.Width = 130;
            // 
            // btAdicionar
            // 
            this.btAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btAdicionar.FlatAppearance.BorderSize = 0;
            this.btAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdicionar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btAdicionar.ForeColor = System.Drawing.Color.White;
            this.btAdicionar.Location = new System.Drawing.Point(350, 450);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(97, 42);
            this.btAdicionar.TabIndex = 17;
            this.btAdicionar.Text = "F12 ADD";
            this.btAdicionar.UseVisualStyleBackColor = false;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // btRemover
            // 
            this.btRemover.BackColor = System.Drawing.Color.HotPink;
            this.btRemover.FlatAppearance.BorderSize = 0;
            this.btRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemover.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btRemover.ForeColor = System.Drawing.Color.White;
            this.btRemover.Location = new System.Drawing.Point(350, 498);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(97, 42);
            this.btRemover.TabIndex = 18;
            this.btRemover.Text = "F6 REM";
            this.btRemover.UseVisualStyleBackColor = false;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.White;
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btLimpar.ForeColor = System.Drawing.Color.Black;
            this.btLimpar.Location = new System.Drawing.Point(350, 546);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(97, 42);
            this.btLimpar.TabIndex = 19;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Red;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSair.ForeColor = System.Drawing.Color.White;
            this.btSair.Location = new System.Drawing.Point(1009, 642);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(130, 42);
            this.btSair.TabIndex = 29;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // lbNomeCorImagem
            // 
            this.lbNomeCorImagem.AutoSize = true;
            this.lbNomeCorImagem.Enabled = false;
            this.lbNomeCorImagem.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold);
            this.lbNomeCorImagem.Location = new System.Drawing.Point(889, 221);
            this.lbNomeCorImagem.Name = "lbNomeCorImagem";
            this.lbNomeCorImagem.Size = new System.Drawing.Size(71, 17);
            this.lbNomeCorImagem.TabIndex = 22;
            this.lbNomeCorImagem.Text = "Cor Imagem";
            // 
            // dgvCorProduto
            // 
            this.dgvCorProduto.AllowUserToAddRows = false;
            this.dgvCorProduto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dgvCorProduto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCorProduto.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCorProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCorProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCorProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.contadorCores,
            this.ordemCor});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCorProduto.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCorProduto.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCorProduto.Location = new System.Drawing.Point(453, 354);
            this.dgvCorProduto.Name = "dgvCorProduto";
            this.dgvCorProduto.ReadOnly = true;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.dgvCorProduto.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCorProduto.RowTemplate.Height = 24;
            this.dgvCorProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCorProduto.Size = new System.Drawing.Size(325, 330);
            this.dgvCorProduto.TabIndex = 20;
            this.dgvCorProduto.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCorProduto_CellMouseClick);
            this.dgvCorProduto.DoubleClick += new System.EventHandler(this.dgvCorProduto_DoubleClick);
            // 
            // tbCor
            // 
            this.tbCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbCor.Location = new System.Drawing.Point(61, 321);
            this.tbCor.Name = "tbCor";
            this.tbCor.Size = new System.Drawing.Size(132, 27);
            this.tbCor.TabIndex = 15;
            this.tbCor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCor_KeyPress);
            // 
            // lbCor
            // 
            this.lbCor.AutoSize = true;
            this.lbCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCor.Location = new System.Drawing.Point(19, 328);
            this.lbCor.Name = "lbCor";
            this.lbCor.Size = new System.Drawing.Size(36, 20);
            this.lbCor.TabIndex = 14;
            this.lbCor.Text = "Cor";
            // 
            // btRemoverImagem
            // 
            this.btRemoverImagem.BackColor = System.Drawing.Color.DeepPink;
            this.btRemoverImagem.FlatAppearance.BorderSize = 0;
            this.btRemoverImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemoverImagem.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btRemoverImagem.ForeColor = System.Drawing.Color.White;
            this.btRemoverImagem.Location = new System.Drawing.Point(1009, 255);
            this.btRemoverImagem.Name = "btRemoverImagem";
            this.btRemoverImagem.Size = new System.Drawing.Size(130, 42);
            this.btRemoverImagem.TabIndex = 26;
            this.btRemoverImagem.Text = "Remover";
            this.btRemoverImagem.UseVisualStyleBackColor = false;
            this.btRemoverImagem.Click += new System.EventHandler(this.btRemoverImagem_Click);
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDescricao.Location = new System.Drawing.Point(23, 99);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(86, 20);
            this.lbDescricao.TabIndex = 0;
            this.lbDescricao.Text = "Descrição";
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbSexo.Location = new System.Drawing.Point(23, 170);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(46, 20);
            this.lbSexo.TabIndex = 4;
            this.lbSexo.Text = "Sexo";
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbGenero.Location = new System.Drawing.Point(23, 204);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(64, 20);
            this.lbGenero.TabIndex = 6;
            this.lbGenero.Text = "Genero";
            // 
            // lbGrade
            // 
            this.lbGrade.AutoSize = true;
            this.lbGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbGrade.Location = new System.Drawing.Point(23, 239);
            this.lbGrade.Name = "lbGrade";
            this.lbGrade.Size = new System.Drawing.Size(55, 20);
            this.lbGrade.TabIndex = 8;
            this.lbGrade.Text = "Grade";
            // 
            // lbFornecedor
            // 
            this.lbFornecedor.AutoSize = true;
            this.lbFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbFornecedor.Location = new System.Drawing.Point(23, 274);
            this.lbFornecedor.Name = "lbFornecedor";
            this.lbFornecedor.Size = new System.Drawing.Size(94, 20);
            this.lbFornecedor.TabIndex = 10;
            this.lbFornecedor.Text = "Fornecedor";
            // 
            // lbPrecoCusto
            // 
            this.lbPrecoCusto.AutoSize = true;
            this.lbPrecoCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbPrecoCusto.Location = new System.Drawing.Point(15, 48);
            this.lbPrecoCusto.Name = "lbPrecoCusto";
            this.lbPrecoCusto.Size = new System.Drawing.Size(79, 20);
            this.lbPrecoCusto.TabIndex = 0;
            this.lbPrecoCusto.Text = "Custo R$";
            // 
            // lbPrecoVenda
            // 
            this.lbPrecoVenda.AutoSize = true;
            this.lbPrecoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbPrecoVenda.Location = new System.Drawing.Point(183, 48);
            this.lbPrecoVenda.Name = "lbPrecoVenda";
            this.lbPrecoVenda.Size = new System.Drawing.Size(82, 20);
            this.lbPrecoVenda.TabIndex = 2;
            this.lbPrecoVenda.Text = "Venda R$";
            // 
            // tbDescricao
            // 
            this.tbDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbDescricao.Location = new System.Drawing.Point(131, 92);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(288, 27);
            this.tbDescricao.TabIndex = 1;
            this.tbDescricao.Leave += new System.EventHandler(this.tbDescricao_Leave);
            // 
            // tbGenero
            // 
            this.tbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbGenero.Location = new System.Drawing.Point(131, 197);
            this.tbGenero.Name = "tbGenero";
            this.tbGenero.Size = new System.Drawing.Size(255, 27);
            this.tbGenero.TabIndex = 7;
            this.tbGenero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGenero_KeyPress);
            this.tbGenero.Leave += new System.EventHandler(this.tbGenero_Leave);
            // 
            // tbGrade
            // 
            this.tbGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbGrade.Location = new System.Drawing.Point(131, 232);
            this.tbGrade.Name = "tbGrade";
            this.tbGrade.Size = new System.Drawing.Size(255, 27);
            this.tbGrade.TabIndex = 9;
            this.tbGrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGrade_KeyPress);
            this.tbGrade.Leave += new System.EventHandler(this.tbGrade_Leave);
            // 
            // tbFornecedor
            // 
            this.tbFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbFornecedor.Location = new System.Drawing.Point(131, 267);
            this.tbFornecedor.Name = "tbFornecedor";
            this.tbFornecedor.Size = new System.Drawing.Size(255, 27);
            this.tbFornecedor.TabIndex = 11;
            this.tbFornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFornecedor_KeyPress);
            this.tbFornecedor.Leave += new System.EventHandler(this.tbFornecedor_Leave);
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
            this.cbSexo.Location = new System.Drawing.Point(131, 162);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(144, 28);
            this.cbSexo.TabIndex = 5;
            this.cbSexo.SelectedValueChanged += new System.EventHandler(this.cbSexo_SelectedValueChanged);
            this.cbSexo.Leave += new System.EventHandler(this.cbSexo_Leave);
            // 
            // mtbCusto
            // 
            this.mtbCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.mtbCusto.Location = new System.Drawing.Point(19, 76);
            this.mtbCusto.Name = "mtbCusto";
            this.mtbCusto.Size = new System.Drawing.Size(120, 27);
            this.mtbCusto.TabIndex = 1;
            this.mtbCusto.TextChanged += new System.EventHandler(this.mtbCusto_TextChanged);
            this.mtbCusto.Leave += new System.EventHandler(this.mtbCusto_Leave);
            // 
            // mtbVenda
            // 
            this.mtbVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.mtbVenda.Location = new System.Drawing.Point(187, 76);
            this.mtbVenda.Name = "mtbVenda";
            this.mtbVenda.Size = new System.Drawing.Size(120, 27);
            this.mtbVenda.TabIndex = 3;
            this.mtbVenda.TextChanged += new System.EventHandler(this.mtbVenda_TextChanged);
            this.mtbVenda.Leave += new System.EventHandler(this.mtbVenda_Leave);
            // 
            // panelDivisor
            // 
            this.panelDivisor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelDivisor.Location = new System.Drawing.Point(19, 303);
            this.panelDivisor.Name = "panelDivisor";
            this.panelDivisor.Size = new System.Drawing.Size(759, 5);
            this.panelDivisor.TabIndex = 13;
            // 
            // panelDivisorImagem
            // 
            this.panelDivisorImagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelDivisorImagem.Location = new System.Drawing.Point(808, 303);
            this.panelDivisorImagem.Name = "panelDivisorImagem";
            this.panelDivisorImagem.Size = new System.Drawing.Size(331, 5);
            this.panelDivisorImagem.TabIndex = 27;
            // 
            // gpPreco
            // 
            this.gpPreco.Controls.Add(this.lbPrecoCusto);
            this.gpPreco.Controls.Add(this.mtbCusto);
            this.gpPreco.Controls.Add(this.lbPrecoVenda);
            this.gpPreco.Controls.Add(this.mtbVenda);
            this.gpPreco.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            this.gpPreco.Location = new System.Drawing.Point(447, 171);
            this.gpPreco.Name = "gpPreco";
            this.gpPreco.Size = new System.Drawing.Size(331, 123);
            this.gpPreco.TabIndex = 12;
            this.gpPreco.TabStop = false;
            this.gpPreco.Text = "Preço do Produto";
            // 
            // epProduto
            // 
            this.epProduto.ContainerControl = this;
            // 
            // pbImagemProdutoZoom
            // 
            this.pbImagemProdutoZoom.Image = global::Apresentacao.Properties.Resources.imgDefaut;
            this.pbImagemProdutoZoom.Location = new System.Drawing.Point(808, 321);
            this.pbImagemProdutoZoom.Name = "pbImagemProdutoZoom";
            this.pbImagemProdutoZoom.Size = new System.Drawing.Size(331, 301);
            this.pbImagemProdutoZoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagemProdutoZoom.TabIndex = 42;
            this.pbImagemProdutoZoom.TabStop = false;
            // 
            // pbBuscarFornecedor
            // 
            this.pbBuscarFornecedor.Image = global::Apresentacao.Properties.Resources.FornecedorLogoBotao;
            this.pbBuscarFornecedor.Location = new System.Drawing.Point(392, 267);
            this.pbBuscarFornecedor.Name = "pbBuscarFornecedor";
            this.pbBuscarFornecedor.Size = new System.Drawing.Size(27, 27);
            this.pbBuscarFornecedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscarFornecedor.TabIndex = 41;
            this.pbBuscarFornecedor.TabStop = false;
            this.pbBuscarFornecedor.Click += new System.EventHandler(this.pbBuscarFornecedor_Click);
            // 
            // pbBuscarGrade
            // 
            this.pbBuscarGrade.Image = global::Apresentacao.Properties.Resources.GradeLogoBotao;
            this.pbBuscarGrade.Location = new System.Drawing.Point(392, 232);
            this.pbBuscarGrade.Name = "pbBuscarGrade";
            this.pbBuscarGrade.Size = new System.Drawing.Size(27, 27);
            this.pbBuscarGrade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscarGrade.TabIndex = 39;
            this.pbBuscarGrade.TabStop = false;
            this.pbBuscarGrade.Click += new System.EventHandler(this.pbBuscarGrade_Click);
            // 
            // pbBuscarGenero
            // 
            this.pbBuscarGenero.Image = global::Apresentacao.Properties.Resources.GeneroLogoBotao;
            this.pbBuscarGenero.Location = new System.Drawing.Point(392, 197);
            this.pbBuscarGenero.Name = "pbBuscarGenero";
            this.pbBuscarGenero.Size = new System.Drawing.Size(27, 27);
            this.pbBuscarGenero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscarGenero.TabIndex = 37;
            this.pbBuscarGenero.TabStop = false;
            this.pbBuscarGenero.Click += new System.EventHandler(this.pbBuscarGenero_Click);
            // 
            // pbProduto
            // 
            this.pbProduto.Image = global::Apresentacao.Properties.Resources.ProdutoLogo;
            this.pbProduto.Location = new System.Drawing.Point(23, 12);
            this.pbProduto.Name = "pbProduto";
            this.pbProduto.Size = new System.Drawing.Size(52, 52);
            this.pbProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProduto.TabIndex = 29;
            this.pbProduto.TabStop = false;
            // 
            // pbCor
            // 
            this.pbCor.Image = global::Apresentacao.Properties.Resources.CorLogoBotao;
            this.pbCor.Location = new System.Drawing.Point(232, 321);
            this.pbCor.Name = "pbCor";
            this.pbCor.Size = new System.Drawing.Size(27, 27);
            this.pbCor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCor.TabIndex = 19;
            this.pbCor.TabStop = false;
            this.pbCor.Click += new System.EventHandler(this.pbCor_Click);
            // 
            // pbBuscarCor
            // 
            this.pbBuscarCor.Image = global::Apresentacao.Properties.Resources.Selecionar;
            this.pbBuscarCor.Location = new System.Drawing.Point(199, 321);
            this.pbBuscarCor.Name = "pbBuscarCor";
            this.pbBuscarCor.Size = new System.Drawing.Size(27, 27);
            this.pbBuscarCor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscarCor.TabIndex = 18;
            this.pbBuscarCor.TabStop = false;
            this.pbBuscarCor.Click += new System.EventHandler(this.pbBuscarCor_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltar.Image = global::Apresentacao.Properties.Resources.Voltar;
            this.btVoltar.Location = new System.Drawing.Point(808, 211);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(75, 38);
            this.btVoltar.TabIndex = 21;
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // btAvancar
            // 
            this.btAvancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAvancar.Image = global::Apresentacao.Properties.Resources.Avancar;
            this.btAvancar.Location = new System.Drawing.Point(1064, 211);
            this.btAvancar.Name = "btAvancar";
            this.btAvancar.Size = new System.Drawing.Size(75, 38);
            this.btAvancar.TabIndex = 24;
            this.btAvancar.UseVisualStyleBackColor = true;
            this.btAvancar.Click += new System.EventHandler(this.btAvancar_Click);
            // 
            // pbImagemProduto
            // 
            this.pbImagemProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagemProduto.Image = global::Apresentacao.Properties.Resources.imgDefaut;
            this.pbImagemProduto.Location = new System.Drawing.Point(808, 12);
            this.pbImagemProduto.Name = "pbImagemProduto";
            this.pbImagemProduto.Size = new System.Drawing.Size(331, 193);
            this.pbImagemProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagemProduto.TabIndex = 0;
            this.pbImagemProduto.TabStop = false;
            this.pbImagemProduto.MouseEnter += new System.EventHandler(this.pbImagemProduto_MouseEnter);
            this.pbImagemProduto.MouseLeave += new System.EventHandler(this.pbImagemProduto_MouseLeave);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codigoCorTemp";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cód";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.ToolTipText = "Código da Cor";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomeCorTemp";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.ToolTipText = "Nome da Cor";
            this.dataGridViewTextBoxColumn2.Width = 130;
            // 
            // contadorCores
            // 
            this.contadorCores.HeaderText = "contador";
            this.contadorCores.Name = "contadorCores";
            this.contadorCores.ReadOnly = true;
            this.contadorCores.Visible = false;
            // 
            // ordemCor
            // 
            this.ordemCor.HeaderText = "Ordem";
            this.ordemCor.Name = "ordemCor";
            this.ordemCor.ReadOnly = true;
            this.ordemCor.Visible = false;
            // 
            // FrmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1169, 701);
            this.Controls.Add(this.pbImagemProdutoZoom);
            this.Controls.Add(this.gpPreco);
            this.Controls.Add(this.panelDivisorImagem);
            this.Controls.Add(this.panelDivisor);
            this.Controls.Add(this.pbBuscarFornecedor);
            this.Controls.Add(this.pbBuscarGrade);
            this.Controls.Add(this.pbBuscarGenero);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.tbFornecedor);
            this.Controls.Add(this.tbGrade);
            this.Controls.Add(this.tbGenero);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.pbProduto);
            this.Controls.Add(this.lbFornecedor);
            this.Controls.Add(this.lbGrade);
            this.Controls.Add(this.lbGenero);
            this.Controls.Add(this.lbSexo);
            this.Controls.Add(this.lbDescricao);
            this.Controls.Add(this.btRemoverImagem);
            this.Controls.Add(this.pbCor);
            this.Controls.Add(this.pbBuscarCor);
            this.Controls.Add(this.lbCor);
            this.Controls.Add(this.tbCor);
            this.Controls.Add(this.dgvCorProduto);
            this.Controls.Add(this.lbNomeCorImagem);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.dgvCor);
            this.Controls.Add(this.lbContadorImagens);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btAvancar);
            this.Controls.Add(this.lbReferencia);
            this.Controls.Add(this.tbReferencia);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.pbImagemProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Cadastro Produto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCadastroProduto_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadastroProduto_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorProduto)).EndInit();
            this.gpPreco.ResumeLayout(false);
            this.gpPreco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemProdutoZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarGenero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarCor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagemProduto;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btSelecionar;
        private System.Windows.Forms.TextBox tbReferencia;
        private System.Windows.Forms.Label lbReferencia;
        private System.Windows.Forms.Button btAvancar;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Label lbContadorImagens;
        private System.Windows.Forms.DataGridView dgvCor;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label lbNomeCorImagem;
        private System.Windows.Forms.TextBox tbCor;
        private System.Windows.Forms.Label lbCor;
        private System.Windows.Forms.PictureBox pbBuscarCor;
        private System.Windows.Forms.PictureBox pbCor;
        private System.Windows.Forms.Button btRemoverImagem;
        private System.Windows.Forms.DataGridView dgvCorProduto;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.Label lbGenero;
        private System.Windows.Forms.Label lbGrade;
        private System.Windows.Forms.Label lbFornecedor;
        private System.Windows.Forms.Label lbPrecoCusto;
        private System.Windows.Forms.Label lbPrecoVenda;
        private System.Windows.Forms.PictureBox pbProduto;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.TextBox tbGenero;
        private System.Windows.Forms.TextBox tbGrade;
        private System.Windows.Forms.TextBox tbFornecedor;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.MaskedTextBox mtbCusto;
        private System.Windows.Forms.MaskedTextBox mtbVenda;
        private System.Windows.Forms.PictureBox pbBuscarGenero;
        private System.Windows.Forms.PictureBox pbBuscarGrade;
        private System.Windows.Forms.PictureBox pbBuscarFornecedor;
        private System.Windows.Forms.Panel panelDivisor;
        private System.Windows.Forms.Panel panelDivisorImagem;
        private System.Windows.Forms.GroupBox gpPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoCor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCor;
        private System.Windows.Forms.PictureBox pbImagemProdutoZoom;
        private System.Windows.Forms.ErrorProvider epProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn contadorCores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordemCor;
    }
}