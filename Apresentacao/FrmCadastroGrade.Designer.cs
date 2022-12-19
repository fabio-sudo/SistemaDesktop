namespace Apresentacao
{
    partial class FrmCadastroGrade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroGrade));
            this.lbNomeGrade = new System.Windows.Forms.Label();
            this.pbGrade = new System.Windows.Forms.PictureBox();
            this.tbGrade = new System.Windows.Forms.TextBox();
            this.dgvTamanho = new System.Windows.Forms.DataGridView();
            this.codigoTamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeTamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.dgvTamanhoGrade = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordemTamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTamanho = new System.Windows.Forms.Label();
            this.tbTamanho = new System.Windows.Forms.TextBox();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.pbTamanho = new System.Windows.Forms.PictureBox();
            this.epGrade = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTamanho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTamanhoGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTamanho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNomeGrade
            // 
            this.lbNomeGrade.AutoSize = true;
            this.lbNomeGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbNomeGrade.Location = new System.Drawing.Point(17, 67);
            this.lbNomeGrade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNomeGrade.Name = "lbNomeGrade";
            this.lbNomeGrade.Size = new System.Drawing.Size(48, 17);
            this.lbNomeGrade.TabIndex = 0;
            this.lbNomeGrade.Text = "Grade";
            // 
            // pbGrade
            // 
            this.pbGrade.Image = global::Apresentacao.Properties.Resources.GradeLogo;
            this.pbGrade.Location = new System.Drawing.Point(20, 10);
            this.pbGrade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbGrade.Name = "pbGrade";
            this.pbGrade.Size = new System.Drawing.Size(39, 42);
            this.pbGrade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGrade.TabIndex = 2;
            this.pbGrade.TabStop = false;
            // 
            // tbGrade
            // 
            this.tbGrade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbGrade.Location = new System.Drawing.Point(88, 62);
            this.tbGrade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbGrade.Name = "tbGrade";
            this.tbGrade.Size = new System.Drawing.Size(163, 23);
            this.tbGrade.TabIndex = 1;
            this.tbGrade.Leave += new System.EventHandler(this.tbGrade_Leave);
            // 
            // dgvTamanho
            // 
            this.dgvTamanho.AllowUserToAddRows = false;
            this.dgvTamanho.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dgvTamanho.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTamanho.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTamanho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTamanho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTamanho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoTamanho,
            this.nomeTamanho});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTamanho.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTamanho.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTamanho.Location = new System.Drawing.Point(20, 115);
            this.dgvTamanho.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTamanho.Name = "dgvTamanho";
            this.dgvTamanho.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.dgvTamanho.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTamanho.RowTemplate.Height = 24;
            this.dgvTamanho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTamanho.Size = new System.Drawing.Size(230, 229);
            this.dgvTamanho.TabIndex = 4;
            this.dgvTamanho.DoubleClick += new System.EventHandler(this.dgvTamanho_DoubleClick);
            // 
            // codigoTamanho
            // 
            this.codigoTamanho.HeaderText = "Cód";
            this.codigoTamanho.Name = "codigoTamanho";
            this.codigoTamanho.ReadOnly = true;
            this.codigoTamanho.ToolTipText = "Código Tamanho";
            this.codigoTamanho.Width = 50;
            // 
            // nomeTamanho
            // 
            this.nomeTamanho.HeaderText = "Tamanho";
            this.nomeTamanho.Name = "nomeTamanho";
            this.nomeTamanho.ReadOnly = true;
            this.nomeTamanho.ToolTipText = "Tamanho Produto";
            // 
            // btAdicionar
            // 
            this.btAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdicionar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btAdicionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAdicionar.Location = new System.Drawing.Point(255, 174);
            this.btAdicionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(73, 34);
            this.btAdicionar.TabIndex = 5;
            this.btAdicionar.Text = "F12 ADD";
            this.btAdicionar.UseVisualStyleBackColor = false;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // btRemover
            // 
            this.btRemover.BackColor = System.Drawing.Color.HotPink;
            this.btRemover.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemover.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btRemover.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btRemover.Location = new System.Drawing.Point(255, 213);
            this.btRemover.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(73, 34);
            this.btRemover.TabIndex = 6;
            this.btRemover.Text = "F6 REM";
            this.btRemover.UseVisualStyleBackColor = false;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.Turquoise;
            this.btCadastrar.FlatAppearance.BorderSize = 0;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCadastrar.Location = new System.Drawing.Point(363, 364);
            this.btCadastrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(98, 34);
            this.btCadastrar.TabIndex = 9;
            this.btCadastrar.Text = "F10 Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Red;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSair.Location = new System.Drawing.Point(465, 363);
            this.btSair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(98, 34);
            this.btSair.TabIndex = 10;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.White;
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btLimpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btLimpar.Location = new System.Drawing.Point(255, 252);
            this.btLimpar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(73, 34);
            this.btLimpar.TabIndex = 7;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // dgvTamanhoGrade
            // 
            this.dgvTamanhoGrade.AllowUserToAddRows = false;
            this.dgvTamanhoGrade.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dgvTamanhoGrade.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTamanhoGrade.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTamanhoGrade.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTamanhoGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTamanhoGrade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Tamanho,
            this.ordemTamanho});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTamanhoGrade.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTamanhoGrade.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTamanhoGrade.Location = new System.Drawing.Point(332, 115);
            this.dgvTamanhoGrade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTamanhoGrade.Name = "dgvTamanhoGrade";
            this.dgvTamanhoGrade.ReadOnly = true;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.dgvTamanhoGrade.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTamanhoGrade.RowTemplate.Height = 24;
            this.dgvTamanhoGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTamanhoGrade.Size = new System.Drawing.Size(230, 229);
            this.dgvTamanhoGrade.TabIndex = 8;
            this.dgvTamanhoGrade.DoubleClick += new System.EventHandler(this.dgvTamanhoGrade_DoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Cód";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.ToolTipText = "Código do Tamanho";
            this.Codigo.Width = 50;
            // 
            // Tamanho
            // 
            this.Tamanho.HeaderText = "Tamanho";
            this.Tamanho.Name = "Tamanho";
            this.Tamanho.ReadOnly = true;
            this.Tamanho.ToolTipText = "Tamanho do Produto";
            // 
            // ordemTamanho
            // 
            this.ordemTamanho.HeaderText = "Ordem";
            this.ordemTamanho.Name = "ordemTamanho";
            this.ordemTamanho.ReadOnly = true;
            this.ordemTamanho.Visible = false;
            // 
            // lbTamanho
            // 
            this.lbTamanho.AutoSize = true;
            this.lbTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTamanho.Location = new System.Drawing.Point(17, 94);
            this.lbTamanho.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTamanho.Name = "lbTamanho";
            this.lbTamanho.Size = new System.Drawing.Size(68, 17);
            this.lbTamanho.TabIndex = 2;
            this.lbTamanho.Text = "Tamanho";
            // 
            // tbTamanho
            // 
            this.tbTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbTamanho.Location = new System.Drawing.Point(88, 89);
            this.tbTamanho.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTamanho.Name = "tbTamanho";
            this.tbTamanho.Size = new System.Drawing.Size(114, 23);
            this.tbTamanho.TabIndex = 3;
            this.tbTamanho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTamanho_KeyPress);
            // 
            // pbBuscar
            // 
            this.pbBuscar.Image = global::Apresentacao.Properties.Resources.Selecionar;
            this.pbBuscar.Location = new System.Drawing.Point(206, 89);
            this.pbBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(20, 22);
            this.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscar.TabIndex = 14;
            this.pbBuscar.TabStop = false;
            this.pbBuscar.Click += new System.EventHandler(this.pbBuscar_Click);
            // 
            // pbTamanho
            // 
            this.pbTamanho.Image = global::Apresentacao.Properties.Resources.TamanhoLogoBotao;
            this.pbTamanho.Location = new System.Drawing.Point(230, 89);
            this.pbTamanho.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbTamanho.Name = "pbTamanho";
            this.pbTamanho.Size = new System.Drawing.Size(20, 22);
            this.pbTamanho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTamanho.TabIndex = 15;
            this.pbTamanho.TabStop = false;
            this.pbTamanho.Click += new System.EventHandler(this.pbTamanho_Click);
            // 
            // epGrade
            // 
            this.epGrade.ContainerControl = this;
            // 
            // FrmCadastroGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(580, 407);
            this.Controls.Add(this.pbTamanho);
            this.Controls.Add(this.pbBuscar);
            this.Controls.Add(this.dgvTamanhoGrade);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.tbTamanho);
            this.Controls.Add(this.lbTamanho);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.dgvTamanho);
            this.Controls.Add(this.tbGrade);
            this.Controls.Add(this.pbGrade);
            this.Controls.Add(this.lbNomeGrade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmCadastroGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Grade Produto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCadastroGrade_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadastroGrade_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTamanho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTamanhoGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTamanho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNomeGrade;
        private System.Windows.Forms.PictureBox pbGrade;
        private System.Windows.Forms.TextBox tbGrade;
        private System.Windows.Forms.DataGridView dgvTamanho;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.DataGridView dgvTamanhoGrade;
        private System.Windows.Forms.Label lbTamanho;
        private System.Windows.Forms.TextBox tbTamanho;
        private System.Windows.Forms.PictureBox pbBuscar;
        private System.Windows.Forms.PictureBox pbTamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeTamanho;
        private System.Windows.Forms.ErrorProvider epGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordemTamanho;
    }
}