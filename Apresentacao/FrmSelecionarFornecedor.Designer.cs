namespace Apresentacao
{
    partial class FrmSelecionarFornecedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelecionarFornecedor));
            this.pbFornecedor = new System.Windows.Forms.PictureBox();
            this.panelFornecedor = new System.Windows.Forms.Panel();
            this.tbFornecedor = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btSelecionar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.dgvFornecedor = new System.Windows.Forms.DataGridView();
            this.codigoFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaoSocialFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFantasiaFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpjFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFornecedor
            // 
            this.pbFornecedor.Image = global::Apresentacao.Properties.Resources.FornecedorLogo;
            this.pbFornecedor.Location = new System.Drawing.Point(12, 32);
            this.pbFornecedor.Name = "pbFornecedor";
            this.pbFornecedor.Size = new System.Drawing.Size(34, 36);
            this.pbFornecedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFornecedor.TabIndex = 0;
            this.pbFornecedor.TabStop = false;
            // 
            // panelFornecedor
            // 
            this.panelFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelFornecedor.Location = new System.Drawing.Point(12, 70);
            this.panelFornecedor.Name = "panelFornecedor";
            this.panelFornecedor.Size = new System.Drawing.Size(383, 2);
            this.panelFornecedor.TabIndex = 2;
            // 
            // tbFornecedor
            // 
            this.tbFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFornecedor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tbFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbFornecedor.Location = new System.Drawing.Point(52, 47);
            this.tbFornecedor.Name = "tbFornecedor";
            this.tbFornecedor.Size = new System.Drawing.Size(343, 23);
            this.tbFornecedor.TabIndex = 0;
            this.tbFornecedor.Text = "Digite o nome do fornecedor ...";
            this.tbFornecedor.Enter += new System.EventHandler(this.tbFornecedor_Enter);
            this.tbFornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFornecedor_KeyPress);
            this.tbFornecedor.Leave += new System.EventHandler(this.tbFornecedor_Leave);
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btBuscar.FlatAppearance.BorderSize = 0;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBuscar.Location = new System.Drawing.Point(401, 32);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(130, 42);
            this.btBuscar.TabIndex = 1;
            this.btBuscar.Text = "F5 Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btSelecionar
            // 
            this.btSelecionar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btSelecionar.FlatAppearance.BorderSize = 0;
            this.btSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSelecionar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSelecionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSelecionar.Location = new System.Drawing.Point(12, 368);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(130, 42);
            this.btSelecionar.TabIndex = 4;
            this.btSelecionar.Text = "F2 Selecionar";
            this.btSelecionar.UseVisualStyleBackColor = false;
            this.btSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.BackColor = System.Drawing.Color.DeepPink;
            this.btAlterar.FlatAppearance.BorderSize = 0;
            this.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlterar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btAlterar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAlterar.Location = new System.Drawing.Point(561, 368);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(130, 42);
            this.btAlterar.TabIndex = 6;
            this.btAlterar.Text = "F4 Alterar";
            this.btAlterar.UseVisualStyleBackColor = false;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.Turquoise;
            this.btCadastrar.FlatAppearance.BorderSize = 0;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCadastrar.Location = new System.Drawing.Point(425, 368);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(130, 42);
            this.btCadastrar.TabIndex = 5;
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
            this.btSair.Location = new System.Drawing.Point(697, 368);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(130, 42);
            this.btSair.TabIndex = 7;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // dgvFornecedor
            // 
            this.dgvFornecedor.AllowUserToAddRows = false;
            this.dgvFornecedor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dgvFornecedor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFornecedor.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFornecedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoFornecedor,
            this.razaoSocialFornecedor,
            this.nomeFantasiaFornecedor,
            this.cnpjFornecedor});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFornecedor.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFornecedor.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvFornecedor.Location = new System.Drawing.Point(12, 80);
            this.dgvFornecedor.Name = "dgvFornecedor";
            this.dgvFornecedor.ReadOnly = true;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.dgvFornecedor.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFornecedor.RowTemplate.Height = 24;
            this.dgvFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFornecedor.Size = new System.Drawing.Size(815, 282);
            this.dgvFornecedor.TabIndex = 3;
            this.dgvFornecedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFornecedor_CellDoubleClick);
            // 
            // codigoFornecedor
            // 
            this.codigoFornecedor.HeaderText = "Cód";
            this.codigoFornecedor.Name = "codigoFornecedor";
            this.codigoFornecedor.ReadOnly = true;
            this.codigoFornecedor.Width = 50;
            // 
            // razaoSocialFornecedor
            // 
            this.razaoSocialFornecedor.HeaderText = "Razão Social";
            this.razaoSocialFornecedor.Name = "razaoSocialFornecedor";
            this.razaoSocialFornecedor.ReadOnly = true;
            this.razaoSocialFornecedor.ToolTipText = "Razão Social do Fornecedor";
            this.razaoSocialFornecedor.Width = 220;
            // 
            // nomeFantasiaFornecedor
            // 
            this.nomeFantasiaFornecedor.HeaderText = "Fornecedor";
            this.nomeFantasiaFornecedor.Name = "nomeFantasiaFornecedor";
            this.nomeFantasiaFornecedor.ReadOnly = true;
            this.nomeFantasiaFornecedor.ToolTipText = "Nome Fantasia do Fornecedor";
            this.nomeFantasiaFornecedor.Width = 180;
            // 
            // cnpjFornecedor
            // 
            dataGridViewCellStyle3.NullValue = null;
            this.cnpjFornecedor.DefaultCellStyle = dataGridViewCellStyle3;
            this.cnpjFornecedor.HeaderText = "CNPJ";
            this.cnpjFornecedor.Name = "cnpjFornecedor";
            this.cnpjFornecedor.ReadOnly = true;
            this.cnpjFornecedor.ToolTipText = "Cnpj do Fornecedor";
            this.cnpjFornecedor.Width = 110;
            // 
            // FrmSelecionarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(839, 433);
            this.Controls.Add(this.dgvFornecedor);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.tbFornecedor);
            this.Controls.Add(this.panelFornecedor);
            this.Controls.Add(this.pbFornecedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmSelecionarFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Fornecedor";
            this.Load += new System.EventHandler(this.FrmSelecionarFornecedor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSelecionarFornecedor_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFornecedor;
        private System.Windows.Forms.Panel panelFornecedor;
        private System.Windows.Forms.TextBox tbFornecedor;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btSelecionar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.DataGridView dgvFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaoSocialFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFantasiaFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpjFornecedor;
    }
}