namespace Apresentacao
{
    partial class FrmFuncionario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuncionario));
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btSelecionar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.tbBuscarFuncionario = new System.Windows.Forms.TextBox();
            this.panelBuscarFuncionario = new System.Windows.Forms.Panel();
            this.pbFuncionario = new System.Windows.Forms.PictureBox();
            this.codigoFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobrenomeFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctpsFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nascimentoFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.AllowUserToAddRows = false;
            this.dgvFuncionario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dgvFuncionario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFuncionario.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFuncionario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoFuncionario,
            this.nomeFuncionario,
            this.sobrenomeFuncionario,
            this.sexoFuncionario,
            this.rgFuncionario,
            this.cpfFuncionario,
            this.ctpsFuncionario,
            this.nascimentoFuncionario,
            this.enderecoFuncionario,
            this.bairroFuncionario,
            this.numeroFuncionario,
            this.cepFuncionario,
            this.cidadeFuncionario,
            this.estadoFuncionario,
            this.telefoneFuncionario,
            this.celularFuncionario,
            this.salarioFuncionario});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFuncionario.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvFuncionario.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvFuncionario.Location = new System.Drawing.Point(12, 80);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.ReadOnly = true;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.dgvFuncionario.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvFuncionario.RowTemplate.Height = 24;
            this.dgvFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionario.Size = new System.Drawing.Size(1080, 563);
            this.dgvFuncionario.TabIndex = 2;
            this.dgvFuncionario.DoubleClick += new System.EventHandler(this.dgvFuncionario_DoubleClick);
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
            // tbBuscarFuncionario
            // 
            this.tbBuscarFuncionario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbBuscarFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBuscarFuncionario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tbBuscarFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbBuscarFuncionario.Location = new System.Drawing.Point(52, 47);
            this.tbBuscarFuncionario.Name = "tbBuscarFuncionario";
            this.tbBuscarFuncionario.Size = new System.Drawing.Size(343, 23);
            this.tbBuscarFuncionario.TabIndex = 0;
            this.tbBuscarFuncionario.Text = "Digite o nome do funcionário ...";
            this.tbBuscarFuncionario.Enter += new System.EventHandler(this.tbBuscarFuncionario_Enter);
            this.tbBuscarFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscarFuncionario_KeyPress);
            this.tbBuscarFuncionario.Leave += new System.EventHandler(this.tbBuscarFuncionario_Leave);
            // 
            // panelBuscarFuncionario
            // 
            this.panelBuscarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelBuscarFuncionario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelBuscarFuncionario.Location = new System.Drawing.Point(12, 70);
            this.panelBuscarFuncionario.Name = "panelBuscarFuncionario";
            this.panelBuscarFuncionario.Size = new System.Drawing.Size(383, 2);
            this.panelBuscarFuncionario.TabIndex = 5;
            // 
            // pbFuncionario
            // 
            this.pbFuncionario.Image = global::Apresentacao.Properties.Resources.FuncionarioAzul;
            this.pbFuncionario.Location = new System.Drawing.Point(12, 32);
            this.pbFuncionario.Name = "pbFuncionario";
            this.pbFuncionario.Size = new System.Drawing.Size(34, 36);
            this.pbFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFuncionario.TabIndex = 6;
            this.pbFuncionario.TabStop = false;
            // 
            // codigoFuncionario
            // 
            this.codigoFuncionario.HeaderText = "Cód";
            this.codigoFuncionario.Name = "codigoFuncionario";
            this.codigoFuncionario.ReadOnly = true;
            this.codigoFuncionario.ToolTipText = "Código";
            this.codigoFuncionario.Width = 55;
            // 
            // nomeFuncionario
            // 
            this.nomeFuncionario.HeaderText = "Nome";
            this.nomeFuncionario.Name = "nomeFuncionario";
            this.nomeFuncionario.ReadOnly = true;
            this.nomeFuncionario.ToolTipText = "Nome";
            this.nomeFuncionario.Width = 150;
            // 
            // sobrenomeFuncionario
            // 
            this.sobrenomeFuncionario.HeaderText = "Sobrenome";
            this.sobrenomeFuncionario.Name = "sobrenomeFuncionario";
            this.sobrenomeFuncionario.ReadOnly = true;
            this.sobrenomeFuncionario.ToolTipText = "Sobrenome";
            this.sobrenomeFuncionario.Width = 130;
            // 
            // sexoFuncionario
            // 
            this.sexoFuncionario.HeaderText = "Sexo";
            this.sexoFuncionario.Name = "sexoFuncionario";
            this.sexoFuncionario.ReadOnly = true;
            this.sexoFuncionario.ToolTipText = "Sexo";
            this.sexoFuncionario.Width = 90;
            // 
            // rgFuncionario
            // 
            dataGridViewCellStyle3.NullValue = null;
            this.rgFuncionario.DefaultCellStyle = dataGridViewCellStyle3;
            this.rgFuncionario.HeaderText = "RG";
            this.rgFuncionario.Name = "rgFuncionario";
            this.rgFuncionario.ReadOnly = true;
            this.rgFuncionario.ToolTipText = "RG";
            this.rgFuncionario.Width = 80;
            // 
            // cpfFuncionario
            // 
            dataGridViewCellStyle4.NullValue = null;
            this.cpfFuncionario.DefaultCellStyle = dataGridViewCellStyle4;
            this.cpfFuncionario.HeaderText = "CPF";
            this.cpfFuncionario.Name = "cpfFuncionario";
            this.cpfFuncionario.ReadOnly = true;
            this.cpfFuncionario.ToolTipText = "CPF";
            this.cpfFuncionario.Width = 80;
            // 
            // ctpsFuncionario
            // 
            this.ctpsFuncionario.HeaderText = "CTPS";
            this.ctpsFuncionario.Name = "ctpsFuncionario";
            this.ctpsFuncionario.ReadOnly = true;
            this.ctpsFuncionario.ToolTipText = "Carteira de Trabalho";
            // 
            // nascimentoFuncionario
            // 
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.nascimentoFuncionario.DefaultCellStyle = dataGridViewCellStyle5;
            this.nascimentoFuncionario.HeaderText = "Nascimento";
            this.nascimentoFuncionario.Name = "nascimentoFuncionario";
            this.nascimentoFuncionario.ReadOnly = true;
            this.nascimentoFuncionario.ToolTipText = "Data de Nascimento";
            this.nascimentoFuncionario.Width = 90;
            // 
            // enderecoFuncionario
            // 
            this.enderecoFuncionario.HeaderText = "Endereço";
            this.enderecoFuncionario.Name = "enderecoFuncionario";
            this.enderecoFuncionario.ReadOnly = true;
            this.enderecoFuncionario.ToolTipText = "Endereço";
            this.enderecoFuncionario.Width = 200;
            // 
            // bairroFuncionario
            // 
            this.bairroFuncionario.HeaderText = "Bairro";
            this.bairroFuncionario.Name = "bairroFuncionario";
            this.bairroFuncionario.ReadOnly = true;
            this.bairroFuncionario.ToolTipText = "Bairro";
            this.bairroFuncionario.Width = 90;
            // 
            // numeroFuncionario
            // 
            this.numeroFuncionario.HeaderText = "Número";
            this.numeroFuncionario.Name = "numeroFuncionario";
            this.numeroFuncionario.ReadOnly = true;
            this.numeroFuncionario.ToolTipText = "Número ";
            this.numeroFuncionario.Width = 70;
            // 
            // cepFuncionario
            // 
            this.cepFuncionario.HeaderText = "CEP";
            this.cepFuncionario.Name = "cepFuncionario";
            this.cepFuncionario.ReadOnly = true;
            this.cepFuncionario.ToolTipText = "CEP";
            this.cepFuncionario.Width = 80;
            // 
            // cidadeFuncionario
            // 
            this.cidadeFuncionario.HeaderText = "Cidade";
            this.cidadeFuncionario.Name = "cidadeFuncionario";
            this.cidadeFuncionario.ReadOnly = true;
            this.cidadeFuncionario.ToolTipText = "Cidade ";
            // 
            // estadoFuncionario
            // 
            this.estadoFuncionario.HeaderText = "Estado";
            this.estadoFuncionario.Name = "estadoFuncionario";
            this.estadoFuncionario.ReadOnly = true;
            this.estadoFuncionario.ToolTipText = "Estado";
            // 
            // telefoneFuncionario
            // 
            this.telefoneFuncionario.HeaderText = "Telefone";
            this.telefoneFuncionario.Name = "telefoneFuncionario";
            this.telefoneFuncionario.ReadOnly = true;
            this.telefoneFuncionario.ToolTipText = "Telefone";
            this.telefoneFuncionario.Width = 90;
            // 
            // celularFuncionario
            // 
            this.celularFuncionario.HeaderText = "Celular";
            this.celularFuncionario.Name = "celularFuncionario";
            this.celularFuncionario.ReadOnly = true;
            this.celularFuncionario.ToolTipText = "Celular ";
            this.celularFuncionario.Width = 90;
            // 
            // salarioFuncionario
            // 
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.salarioFuncionario.DefaultCellStyle = dataGridViewCellStyle6;
            this.salarioFuncionario.HeaderText = "Salário";
            this.salarioFuncionario.Name = "salarioFuncionario";
            this.salarioFuncionario.ReadOnly = true;
            this.salarioFuncionario.ToolTipText = "Salário";
            this.salarioFuncionario.Width = 90;
            // 
            // FrmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1105, 710);
            this.Controls.Add(this.pbFuncionario);
            this.Controls.Add(this.panelBuscarFuncionario);
            this.Controls.Add(this.tbBuscarFuncionario);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.dgvFuncionario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionário";
            this.Load += new System.EventHandler(this.FrmFuncionario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmFuncionario_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btSelecionar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox tbBuscarFuncionario;
        private System.Windows.Forms.Panel panelBuscarFuncionario;
        private System.Windows.Forms.PictureBox pbFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobrenomeFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctpsFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nascimentoFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioFuncionario;
    }
}