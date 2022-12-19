namespace Apresentacao
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.codigoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobrenomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.tbBuscarCliente = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.panelBuscarCliente = new System.Windows.Forms.Panel();
            this.btSelecionar = new System.Windows.Forms.Button();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dgvCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCliente.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoCliente,
            this.nomeCliente,
            this.sobrenomeCliente,
            this.sexoCliente,
            this.rgCliente,
            this.cpfCliente,
            this.dataNascimento,
            this.enderecoCliente,
            this.bairroCliente,
            this.numeroCliente,
            this.cepCliente,
            this.cidadeCliente,
            this.estadoCliente,
            this.telefoneCliente,
            this.celularCliente,
            this.emailCliente});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCliente.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCliente.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCliente.Location = new System.Drawing.Point(12, 80);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.dgvCliente.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCliente.RowTemplate.Height = 24;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(1080, 563);
            this.dgvCliente.TabIndex = 2;
            this.dgvCliente.DoubleClick += new System.EventHandler(this.dgvCliente_DoubleClick);
            // 
            // codigoCliente
            // 
            this.codigoCliente.HeaderText = "Cód";
            this.codigoCliente.Name = "codigoCliente";
            this.codigoCliente.ReadOnly = true;
            this.codigoCliente.ToolTipText = "Código";
            this.codigoCliente.Width = 50;
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
            // sexoCliente
            // 
            this.sexoCliente.HeaderText = "Sexo";
            this.sexoCliente.Name = "sexoCliente";
            this.sexoCliente.ReadOnly = true;
            this.sexoCliente.ToolTipText = "Sexo ";
            this.sexoCliente.Width = 90;
            // 
            // rgCliente
            // 
            this.rgCliente.HeaderText = "RG";
            this.rgCliente.Name = "rgCliente";
            this.rgCliente.ReadOnly = true;
            this.rgCliente.ToolTipText = "RG ";
            this.rgCliente.Width = 80;
            // 
            // cpfCliente
            // 
            this.cpfCliente.HeaderText = "CPF";
            this.cpfCliente.Name = "cpfCliente";
            this.cpfCliente.ReadOnly = true;
            this.cpfCliente.ToolTipText = "CPF";
            this.cpfCliente.Width = 80;
            // 
            // dataNascimento
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.dataNascimento.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataNascimento.HeaderText = "Nascimento";
            this.dataNascimento.Name = "dataNascimento";
            this.dataNascimento.ReadOnly = true;
            this.dataNascimento.ToolTipText = "Data de Nascimento";
            this.dataNascimento.Width = 90;
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
            // estadoCliente
            // 
            this.estadoCliente.HeaderText = "Estado";
            this.estadoCliente.Name = "estadoCliente";
            this.estadoCliente.ReadOnly = true;
            this.estadoCliente.ToolTipText = "Estado";
            // 
            // telefoneCliente
            // 
            this.telefoneCliente.HeaderText = "Telefone";
            this.telefoneCliente.Name = "telefoneCliente";
            this.telefoneCliente.ReadOnly = true;
            this.telefoneCliente.ToolTipText = "Telefone ";
            this.telefoneCliente.Width = 90;
            // 
            // celularCliente
            // 
            this.celularCliente.HeaderText = "Celular";
            this.celularCliente.Name = "celularCliente";
            this.celularCliente.ReadOnly = true;
            this.celularCliente.ToolTipText = "Celular";
            this.celularCliente.Width = 90;
            // 
            // emailCliente
            // 
            this.emailCliente.HeaderText = "Email";
            this.emailCliente.Name = "emailCliente";
            this.emailCliente.ReadOnly = true;
            this.emailCliente.ToolTipText = "Email ";
            this.emailCliente.Width = 150;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCadastrar.BackColor = System.Drawing.Color.Turquoise;
            this.btCadastrar.FlatAppearance.BorderSize = 0;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCadastrar.Location = new System.Drawing.Point(12, 649);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(130, 42);
            this.btCadastrar.TabIndex = 3;
            this.btCadastrar.Text = "F10 Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // tbBuscarCliente
            // 
            this.tbBuscarCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBuscarCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tbBuscarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbBuscarCliente.Location = new System.Drawing.Point(52, 47);
            this.tbBuscarCliente.Name = "tbBuscarCliente";
            this.tbBuscarCliente.Size = new System.Drawing.Size(343, 23);
            this.tbBuscarCliente.TabIndex = 0;
            this.tbBuscarCliente.Text = "Digite o nome do cliente ...";
            this.tbBuscarCliente.Enter += new System.EventHandler(this.tbBuscarCliente_Enter);
            this.tbBuscarCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscarCliente_KeyPress);
            this.tbBuscarCliente.Leave += new System.EventHandler(this.tbBuscarCliente_Leave);
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
            // panelBuscarCliente
            // 
            this.panelBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelBuscarCliente.Location = new System.Drawing.Point(12, 70);
            this.panelBuscarCliente.Name = "panelBuscarCliente";
            this.panelBuscarCliente.Size = new System.Drawing.Size(383, 2);
            this.panelBuscarCliente.TabIndex = 5;
            // 
            // btSelecionar
            // 
            this.btSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSelecionar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btSelecionar.FlatAppearance.BorderSize = 0;
            this.btSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSelecionar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSelecionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSelecionar.Location = new System.Drawing.Point(148, 649);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(130, 42);
            this.btSelecionar.TabIndex = 4;
            this.btSelecionar.Text = "F2 Selecionar";
            this.btSelecionar.UseVisualStyleBackColor = false;
            this.btSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            // 
            // pbUsuario
            // 
            this.pbUsuario.Image = global::Apresentacao.Properties.Resources.ClienteAzul;
            this.pbUsuario.Location = new System.Drawing.Point(12, 32);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(34, 36);
            this.pbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbUsuario.TabIndex = 7;
            this.pbUsuario.TabStop = false;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1105, 710);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.pbUsuario);
            this.Controls.Add(this.panelBuscarCliente);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.tbBuscarCliente);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.dgvCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCliente_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.TextBox tbBuscarCliente;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Panel panelBuscarCliente;
        private System.Windows.Forms.PictureBox pbUsuario;
        private System.Windows.Forms.Button btSelecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobrenomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailCliente;
    }
}