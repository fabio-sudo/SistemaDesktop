namespace Apresentacao
{
    partial class FrmFornecedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFornecedor));
            this.btSelecionar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.dgvFornecedor = new System.Windows.Forms.DataGridView();
            this.codigoFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaoSocialFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFantasiaFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpjFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incricaoEstadualFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btBuscar = new System.Windows.Forms.Button();
            this.panelBuscarFornecedor = new System.Windows.Forms.Panel();
            this.tbBuscarFornecedor = new System.Windows.Forms.TextBox();
            this.pbFornecedor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btSelecionar
            // 
            this.btSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSelecionar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btSelecionar.FlatAppearance.BorderSize = 0;
            this.btSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSelecionar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSelecionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSelecionar.Location = new System.Drawing.Point(148, 642);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(130, 42);
            this.btSelecionar.TabIndex = 5;
            this.btSelecionar.Text = "F2 Selecionar";
            this.btSelecionar.UseVisualStyleBackColor = false;
            this.btSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCadastrar.BackColor = System.Drawing.Color.Turquoise;
            this.btCadastrar.FlatAppearance.BorderSize = 0;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCadastrar.Location = new System.Drawing.Point(12, 642);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(130, 42);
            this.btCadastrar.TabIndex = 4;
            this.btCadastrar.Text = "F10 Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // dgvFornecedor
            // 
            this.dgvFornecedor.AllowUserToAddRows = false;
            this.dgvFornecedor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dgvFornecedor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.cnpjFornecedor,
            this.incricaoEstadualFornecedor,
            this.enderecoFornecedor,
            this.bairroFornecedor,
            this.numeroFornecedor,
            this.cidadeFornecedor,
            this.estadoFornecedor,
            this.cepFornecedor,
            this.telefoneFornecedor,
            this.celularFornecedor,
            this.emailFornecedor});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFornecedor.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFornecedor.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvFornecedor.Location = new System.Drawing.Point(12, 73);
            this.dgvFornecedor.Name = "dgvFornecedor";
            this.dgvFornecedor.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.dgvFornecedor.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFornecedor.RowTemplate.Height = 24;
            this.dgvFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFornecedor.Size = new System.Drawing.Size(1080, 563);
            this.dgvFornecedor.TabIndex = 3;
            this.dgvFornecedor.DoubleClick += new System.EventHandler(this.dgvFornecedor_DoubleClick);
            // 
            // codigoFornecedor
            // 
            this.codigoFornecedor.HeaderText = "Cód";
            this.codigoFornecedor.Name = "codigoFornecedor";
            this.codigoFornecedor.ReadOnly = true;
            this.codigoFornecedor.ToolTipText = "Código";
            this.codigoFornecedor.Width = 50;
            // 
            // razaoSocialFornecedor
            // 
            this.razaoSocialFornecedor.HeaderText = "Razão Social";
            this.razaoSocialFornecedor.Name = "razaoSocialFornecedor";
            this.razaoSocialFornecedor.ReadOnly = true;
            this.razaoSocialFornecedor.ToolTipText = "Razão Social";
            this.razaoSocialFornecedor.Width = 180;
            // 
            // nomeFantasiaFornecedor
            // 
            this.nomeFantasiaFornecedor.HeaderText = "Nome Fantasia";
            this.nomeFantasiaFornecedor.Name = "nomeFantasiaFornecedor";
            this.nomeFantasiaFornecedor.ReadOnly = true;
            this.nomeFantasiaFornecedor.ToolTipText = "Nome Fantasia";
            this.nomeFantasiaFornecedor.Width = 180;
            // 
            // cnpjFornecedor
            // 
            this.cnpjFornecedor.HeaderText = "CNPJ";
            this.cnpjFornecedor.Name = "cnpjFornecedor";
            this.cnpjFornecedor.ReadOnly = true;
            this.cnpjFornecedor.ToolTipText = "CNPJ";
            this.cnpjFornecedor.Width = 120;
            // 
            // incricaoEstadualFornecedor
            // 
            this.incricaoEstadualFornecedor.HeaderText = "Inscrição";
            this.incricaoEstadualFornecedor.Name = "incricaoEstadualFornecedor";
            this.incricaoEstadualFornecedor.ReadOnly = true;
            this.incricaoEstadualFornecedor.ToolTipText = "Inscrição Estadual";
            // 
            // enderecoFornecedor
            // 
            this.enderecoFornecedor.HeaderText = "Endereço";
            this.enderecoFornecedor.Name = "enderecoFornecedor";
            this.enderecoFornecedor.ReadOnly = true;
            this.enderecoFornecedor.ToolTipText = "Endereço";
            this.enderecoFornecedor.Width = 180;
            // 
            // bairroFornecedor
            // 
            this.bairroFornecedor.HeaderText = "Bairro";
            this.bairroFornecedor.Name = "bairroFornecedor";
            this.bairroFornecedor.ReadOnly = true;
            this.bairroFornecedor.ToolTipText = "Bairro";
            this.bairroFornecedor.Width = 120;
            // 
            // numeroFornecedor
            // 
            this.numeroFornecedor.HeaderText = "Número";
            this.numeroFornecedor.Name = "numeroFornecedor";
            this.numeroFornecedor.ReadOnly = true;
            this.numeroFornecedor.ToolTipText = "Número";
            this.numeroFornecedor.Width = 80;
            // 
            // cidadeFornecedor
            // 
            this.cidadeFornecedor.HeaderText = "Cidade";
            this.cidadeFornecedor.Name = "cidadeFornecedor";
            this.cidadeFornecedor.ReadOnly = true;
            this.cidadeFornecedor.ToolTipText = "Cidade";
            // 
            // estadoFornecedor
            // 
            this.estadoFornecedor.HeaderText = "Estado";
            this.estadoFornecedor.Name = "estadoFornecedor";
            this.estadoFornecedor.ReadOnly = true;
            this.estadoFornecedor.ToolTipText = "Estado";
            // 
            // cepFornecedor
            // 
            this.cepFornecedor.HeaderText = "CEP";
            this.cepFornecedor.Name = "cepFornecedor";
            this.cepFornecedor.ReadOnly = true;
            this.cepFornecedor.ToolTipText = "CEP";
            this.cepFornecedor.Width = 80;
            // 
            // telefoneFornecedor
            // 
            this.telefoneFornecedor.HeaderText = "Telefone";
            this.telefoneFornecedor.Name = "telefoneFornecedor";
            this.telefoneFornecedor.ReadOnly = true;
            this.telefoneFornecedor.ToolTipText = "Telefone";
            this.telefoneFornecedor.Width = 90;
            // 
            // celularFornecedor
            // 
            this.celularFornecedor.HeaderText = "Celular";
            this.celularFornecedor.Name = "celularFornecedor";
            this.celularFornecedor.ReadOnly = true;
            this.celularFornecedor.ToolTipText = "Celular ";
            this.celularFornecedor.Width = 90;
            // 
            // emailFornecedor
            // 
            this.emailFornecedor.HeaderText = "Email";
            this.emailFornecedor.Name = "emailFornecedor";
            this.emailFornecedor.ReadOnly = true;
            this.emailFornecedor.ToolTipText = "Email ";
            this.emailFornecedor.Width = 180;
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btBuscar.FlatAppearance.BorderSize = 0;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBuscar.Location = new System.Drawing.Point(401, 27);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(130, 42);
            this.btBuscar.TabIndex = 1;
            this.btBuscar.Text = "F5 Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // panelBuscarFornecedor
            // 
            this.panelBuscarFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelBuscarFornecedor.Location = new System.Drawing.Point(12, 65);
            this.panelBuscarFornecedor.Name = "panelBuscarFornecedor";
            this.panelBuscarFornecedor.Size = new System.Drawing.Size(383, 2);
            this.panelBuscarFornecedor.TabIndex = 2;
            // 
            // tbBuscarFornecedor
            // 
            this.tbBuscarFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBuscarFornecedor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tbBuscarFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbBuscarFornecedor.Location = new System.Drawing.Point(52, 42);
            this.tbBuscarFornecedor.Name = "tbBuscarFornecedor";
            this.tbBuscarFornecedor.Size = new System.Drawing.Size(343, 23);
            this.tbBuscarFornecedor.TabIndex = 0;
            this.tbBuscarFornecedor.Text = "Digite o nome do fornecedor ...";
            this.tbBuscarFornecedor.Enter += new System.EventHandler(this.tbBuscarFornecedor_Enter);
            this.tbBuscarFornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscarFornecedor_KeyPress);
            this.tbBuscarFornecedor.Leave += new System.EventHandler(this.tbBuscarFornecedor_Leave);
            // 
            // pbFornecedor
            // 
            this.pbFornecedor.Image = global::Apresentacao.Properties.Resources.FornecedorAzul;
            this.pbFornecedor.Location = new System.Drawing.Point(12, 27);
            this.pbFornecedor.Name = "pbFornecedor";
            this.pbFornecedor.Size = new System.Drawing.Size(34, 36);
            this.pbFornecedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFornecedor.TabIndex = 7;
            this.pbFornecedor.TabStop = false;
            // 
            // FrmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1105, 710);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.dgvFornecedor);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.panelBuscarFornecedor);
            this.Controls.Add(this.tbBuscarFornecedor);
            this.Controls.Add(this.pbFornecedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmFornecedor";
            this.Text = "Fornecedor";
            this.Load += new System.EventHandler(this.FrmFornecedor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmFornecedor_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSelecionar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.DataGridView dgvFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaoSocialFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFantasiaFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpjFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn incricaoEstadualFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailFornecedor;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Panel panelBuscarFornecedor;
        private System.Windows.Forms.TextBox tbBuscarFornecedor;
        private System.Windows.Forms.PictureBox pbFornecedor;
    }
}