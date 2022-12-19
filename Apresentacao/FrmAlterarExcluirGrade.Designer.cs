namespace Apresentacao
{
    partial class FrmAlterarExcluirGrade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlterarExcluirGrade));
            this.dgvTamanho = new System.Windows.Forms.DataGridView();
            this.codigoTamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeTamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbGrade = new System.Windows.Forms.Label();
            this.lbTamanho = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.pbTamanho = new System.Windows.Forms.PictureBox();
            this.tbGrade = new System.Windows.Forms.TextBox();
            this.tbTamanho = new System.Windows.Forms.TextBox();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.dgvTamanhoGrade = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epGrade = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbCodigo = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.pbDesfazer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTamanho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTamanho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTamanhoGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDesfazer)).BeginInit();
            this.SuspendLayout();
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
            this.dgvTamanho.Location = new System.Drawing.Point(27, 172);
            this.dgvTamanho.Name = "dgvTamanho";
            this.dgvTamanho.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.dgvTamanho.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTamanho.RowTemplate.Height = 24;
            this.dgvTamanho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTamanho.Size = new System.Drawing.Size(307, 282);
            this.dgvTamanho.TabIndex = 6;
            this.dgvTamanho.DoubleClick += new System.EventHandler(this.dgvTamanho_DoubleClick);
            // 
            // codigoTamanho
            // 
            this.codigoTamanho.HeaderText = "Cód";
            this.codigoTamanho.Name = "codigoTamanho";
            this.codigoTamanho.ReadOnly = true;
            this.codigoTamanho.ToolTipText = "Código do Tamanho";
            this.codigoTamanho.Width = 50;
            // 
            // nomeTamanho
            // 
            this.nomeTamanho.HeaderText = "Tamanho";
            this.nomeTamanho.Name = "nomeTamanho";
            this.nomeTamanho.ReadOnly = true;
            this.nomeTamanho.ToolTipText = "Nome do Tamanho";
            // 
            // lbGrade
            // 
            this.lbGrade.AutoSize = true;
            this.lbGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbGrade.Location = new System.Drawing.Point(23, 113);
            this.lbGrade.Name = "lbGrade";
            this.lbGrade.Size = new System.Drawing.Size(55, 20);
            this.lbGrade.TabIndex = 2;
            this.lbGrade.Text = "Grade";
            // 
            // lbTamanho
            // 
            this.lbTamanho.AutoSize = true;
            this.lbTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTamanho.Location = new System.Drawing.Point(23, 146);
            this.lbTamanho.Name = "lbTamanho";
            this.lbTamanho.Size = new System.Drawing.Size(78, 20);
            this.lbTamanho.TabIndex = 4;
            this.lbTamanho.Text = "Tamanho";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Apresentacao.Properties.Resources.GradeLogo;
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pbBuscar
            // 
            this.pbBuscar.Image = global::Apresentacao.Properties.Resources.Selecionar;
            this.pbBuscar.Location = new System.Drawing.Point(274, 139);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(27, 27);
            this.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscar.TabIndex = 6;
            this.pbBuscar.TabStop = false;
            this.pbBuscar.Click += new System.EventHandler(this.pbBuscar_Click);
            // 
            // pbTamanho
            // 
            this.pbTamanho.Image = global::Apresentacao.Properties.Resources.TamanhoLogoBotao;
            this.pbTamanho.Location = new System.Drawing.Point(307, 139);
            this.pbTamanho.Name = "pbTamanho";
            this.pbTamanho.Size = new System.Drawing.Size(27, 27);
            this.pbTamanho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTamanho.TabIndex = 7;
            this.pbTamanho.TabStop = false;
            this.pbTamanho.Click += new System.EventHandler(this.pbTamanho_Click);
            // 
            // tbGrade
            // 
            this.tbGrade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbGrade.Location = new System.Drawing.Point(118, 106);
            this.tbGrade.Name = "tbGrade";
            this.tbGrade.Size = new System.Drawing.Size(216, 27);
            this.tbGrade.TabIndex = 3;
            this.tbGrade.Leave += new System.EventHandler(this.tbGrade_Leave);
            // 
            // tbTamanho
            // 
            this.tbTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbTamanho.Location = new System.Drawing.Point(118, 139);
            this.tbTamanho.Name = "tbTamanho";
            this.tbTamanho.Size = new System.Drawing.Size(150, 27);
            this.tbTamanho.TabIndex = 5;
            // 
            // btAlterar
            // 
            this.btAlterar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btAlterar.FlatAppearance.BorderSize = 0;
            this.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlterar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btAlterar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAlterar.Location = new System.Drawing.Point(27, 476);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(130, 42);
            this.btAlterar.TabIndex = 10;
            this.btAlterar.Text = "F10 Alterar";
            this.btAlterar.UseVisualStyleBackColor = false;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.DeepPink;
            this.btExcluir.FlatAppearance.BorderSize = 0;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btExcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btExcluir.Location = new System.Drawing.Point(163, 476);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(130, 42);
            this.btExcluir.TabIndex = 11;
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
            this.btSair.Location = new System.Drawing.Point(620, 476);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(130, 42);
            this.btSair.TabIndex = 12;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btAdicionar
            // 
            this.btAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdicionar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btAdicionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAdicionar.Location = new System.Drawing.Point(340, 244);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(97, 42);
            this.btAdicionar.TabIndex = 7;
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
            this.btRemover.Location = new System.Drawing.Point(340, 292);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(97, 42);
            this.btRemover.TabIndex = 8;
            this.btRemover.Text = "F6 REM";
            this.btRemover.UseVisualStyleBackColor = false;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
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
            this.codigo,
            this.tamanho});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTamanhoGrade.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTamanhoGrade.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTamanhoGrade.Location = new System.Drawing.Point(443, 172);
            this.dgvTamanhoGrade.Name = "dgvTamanhoGrade";
            this.dgvTamanhoGrade.ReadOnly = true;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.dgvTamanhoGrade.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTamanhoGrade.RowTemplate.Height = 24;
            this.dgvTamanhoGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTamanhoGrade.Size = new System.Drawing.Size(307, 282);
            this.dgvTamanhoGrade.TabIndex = 9;
            this.dgvTamanhoGrade.DoubleClick += new System.EventHandler(this.dgvTamanhoGrade_DoubleClick);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Cód";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.ToolTipText = "Código do Tamanho";
            this.codigo.Width = 50;
            // 
            // tamanho
            // 
            this.tamanho.HeaderText = "Tamanho";
            this.tamanho.Name = "tamanho";
            this.tamanho.ReadOnly = true;
            this.tamanho.ToolTipText = "Nome do Tamanho";
            // 
            // epGrade
            // 
            this.epGrade.ContainerControl = this;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCodigo.Location = new System.Drawing.Point(23, 81);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(61, 20);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "Código";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Enabled = false;
            this.tbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbCodigo.Location = new System.Drawing.Point(118, 74);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(66, 27);
            this.tbCodigo.TabIndex = 1;
            // 
            // pbDesfazer
            // 
            this.pbDesfazer.Image = global::Apresentacao.Properties.Resources.Desfazer;
            this.pbDesfazer.Location = new System.Drawing.Point(190, 74);
            this.pbDesfazer.Name = "pbDesfazer";
            this.pbDesfazer.Size = new System.Drawing.Size(27, 27);
            this.pbDesfazer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDesfazer.TabIndex = 20;
            this.pbDesfazer.TabStop = false;
            this.pbDesfazer.Click += new System.EventHandler(this.pbDesfazer_Click);
            // 
            // FrmAlterarExcluirGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(773, 537);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.pbDesfazer);
            this.Controls.Add(this.dgvTamanhoGrade);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.tbTamanho);
            this.Controls.Add(this.tbGrade);
            this.Controls.Add(this.pbTamanho);
            this.Controls.Add(this.pbBuscar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbTamanho);
            this.Controls.Add(this.lbGrade);
            this.Controls.Add(this.dgvTamanho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmAlterarExcluirGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar & Excluir - Grade";
            this.Load += new System.EventHandler(this.FrmAlterarExcluirGrade_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAlterarExcluirGrade_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTamanho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTamanho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTamanhoGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDesfazer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTamanho;
        private System.Windows.Forms.Label lbGrade;
        private System.Windows.Forms.Label lbTamanho;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbBuscar;
        private System.Windows.Forms.PictureBox pbTamanho;
        private System.Windows.Forms.TextBox tbGrade;
        private System.Windows.Forms.TextBox tbTamanho;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeTamanho;
        private System.Windows.Forms.DataGridView dgvTamanhoGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanho;
        private System.Windows.Forms.ErrorProvider epGrade;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.PictureBox pbDesfazer;
    }
}