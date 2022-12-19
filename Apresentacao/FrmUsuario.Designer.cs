namespace Apresentacao
{
    partial class FrmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            this.tbUsuarioSenha = new System.Windows.Forms.TextBox();
            this.panelBuscarUsuarioSenha = new System.Windows.Forms.Panel();
            this.btBuscar = new System.Windows.Forms.Button();
            this.dgvUsuarioSenha = new System.Windows.Forms.DataGridView();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btSelecionar = new System.Windows.Forms.Button();
            this.codigoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobrenomeFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbUsuarioSenha = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarioSenha)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUsuarioSenha
            // 
            this.tbUsuarioSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsuarioSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tbUsuarioSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbUsuarioSenha.Location = new System.Drawing.Point(52, 47);
            this.tbUsuarioSenha.Name = "tbUsuarioSenha";
            this.tbUsuarioSenha.Size = new System.Drawing.Size(343, 23);
            this.tbUsuarioSenha.TabIndex = 0;
            this.tbUsuarioSenha.Text = "Digite o nome do usuário ...";
            this.tbUsuarioSenha.Enter += new System.EventHandler(this.tbUsuarioSenha_Enter);
            this.tbUsuarioSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUsuarioSenha_KeyPress);
            this.tbUsuarioSenha.Leave += new System.EventHandler(this.tbUsuarioSenha_Leave);
            // 
            // panelBuscarUsuarioSenha
            // 
            this.panelBuscarUsuarioSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelBuscarUsuarioSenha.Location = new System.Drawing.Point(12, 70);
            this.panelBuscarUsuarioSenha.Name = "panelBuscarUsuarioSenha";
            this.panelBuscarUsuarioSenha.Size = new System.Drawing.Size(383, 2);
            this.panelBuscarUsuarioSenha.TabIndex = 2;
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
            // dgvUsuarioSenha
            // 
            this.dgvUsuarioSenha.AllowUserToAddRows = false;
            this.dgvUsuarioSenha.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dgvUsuarioSenha.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarioSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuarioSenha.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarioSenha.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarioSenha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarioSenha.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoUsuario,
            this.Usuario,
            this.Senha,
            this.codigoFuncionario,
            this.nomeFuncionario,
            this.sobrenomeFuncionario,
            this.cpfFuncionario});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarioSenha.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsuarioSenha.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvUsuarioSenha.Location = new System.Drawing.Point(12, 80);
            this.dgvUsuarioSenha.Name = "dgvUsuarioSenha";
            this.dgvUsuarioSenha.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.dgvUsuarioSenha.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsuarioSenha.RowTemplate.Height = 24;
            this.dgvUsuarioSenha.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarioSenha.Size = new System.Drawing.Size(1080, 563);
            this.dgvUsuarioSenha.TabIndex = 3;
            this.dgvUsuarioSenha.DoubleClick += new System.EventHandler(this.dgvUsuarioSenha_DoubleClick);
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
            this.btCadastrar.TabIndex = 4;
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
            this.btSelecionar.TabIndex = 5;
            this.btSelecionar.Text = "F2 Selecionar";
            this.btSelecionar.UseVisualStyleBackColor = false;
            this.btSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            // 
            // codigoUsuario
            // 
            this.codigoUsuario.HeaderText = "Cód";
            this.codigoUsuario.Name = "codigoUsuario";
            this.codigoUsuario.ReadOnly = true;
            this.codigoUsuario.ToolTipText = "Código Usuário";
            this.codigoUsuario.Width = 50;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuário";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.ToolTipText = "Login Usuário";
            this.Usuario.Width = 150;
            // 
            // Senha
            // 
            this.Senha.HeaderText = "Senha";
            this.Senha.Name = "Senha";
            this.Senha.ReadOnly = true;
            this.Senha.ToolTipText = "Senha Usuário";
            this.Senha.Width = 150;
            // 
            // codigoFuncionario
            // 
            this.codigoFuncionario.HeaderText = "Cód";
            this.codigoFuncionario.Name = "codigoFuncionario";
            this.codigoFuncionario.ReadOnly = true;
            this.codigoFuncionario.ToolTipText = "Código Funcionário";
            this.codigoFuncionario.Width = 50;
            // 
            // nomeFuncionario
            // 
            this.nomeFuncionario.HeaderText = "Nome";
            this.nomeFuncionario.Name = "nomeFuncionario";
            this.nomeFuncionario.ReadOnly = true;
            this.nomeFuncionario.ToolTipText = "Nome do Funcionário";
            this.nomeFuncionario.Width = 200;
            // 
            // sobrenomeFuncionario
            // 
            this.sobrenomeFuncionario.HeaderText = "Sobrenome";
            this.sobrenomeFuncionario.Name = "sobrenomeFuncionario";
            this.sobrenomeFuncionario.ReadOnly = true;
            this.sobrenomeFuncionario.ToolTipText = "Sobrenome do Funcinário";
            this.sobrenomeFuncionario.Width = 200;
            // 
            // cpfFuncionario
            // 
            this.cpfFuncionario.HeaderText = "CPF";
            this.cpfFuncionario.Name = "cpfFuncionario";
            this.cpfFuncionario.ReadOnly = true;
            this.cpfFuncionario.ToolTipText = "CPF do Funcionário";
            // 
            // pbUsuarioSenha
            // 
            this.pbUsuarioSenha.Image = global::Apresentacao.Properties.Resources.UsuarioAzul;
            this.pbUsuarioSenha.Location = new System.Drawing.Point(12, 32);
            this.pbUsuarioSenha.Name = "pbUsuarioSenha";
            this.pbUsuarioSenha.Size = new System.Drawing.Size(34, 36);
            this.pbUsuarioSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsuarioSenha.TabIndex = 0;
            this.pbUsuarioSenha.TabStop = false;
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1105, 710);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.dgvUsuarioSenha);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.panelBuscarUsuarioSenha);
            this.Controls.Add(this.tbUsuarioSenha);
            this.Controls.Add(this.pbUsuarioSenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuário e Senha";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmUsuario_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarioSenha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbUsuarioSenha;
        private System.Windows.Forms.TextBox tbUsuarioSenha;
        private System.Windows.Forms.Panel panelBuscarUsuarioSenha;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.DataGridView dgvUsuarioSenha;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btSelecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobrenomeFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfFuncionario;
    }
}