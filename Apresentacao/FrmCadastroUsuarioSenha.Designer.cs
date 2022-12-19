namespace Apresentacao
{
    partial class FrmCadastroUsuarioSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroUsuarioSenha));
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.lbConfirmaSenha = new System.Windows.Forms.Label();
            this.lbFuncionario = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.tbConfirmaSenha = new System.Windows.Forms.TextBox();
            this.tbFuncionario = new System.Windows.Forms.TextBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.epUsuarioSenha = new System.Windows.Forms.ErrorProvider(this.components);
            this.pbSelecionarFuncionario = new System.Windows.Forms.PictureBox();
            this.pbMostrarConfirmaSenha = new System.Windows.Forms.PictureBox();
            this.pbMostrarSenha = new System.Windows.Forms.PictureBox();
            this.pbUsuarioSenha = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.epUsuarioSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelecionarFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarConfirmaSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarioSenha)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbUsuario.Location = new System.Drawing.Point(27, 84);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(67, 20);
            this.lbUsuario.TabIndex = 0;
            this.lbUsuario.Text = "Usuário";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbSenha.Location = new System.Drawing.Point(27, 119);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(56, 20);
            this.lbSenha.TabIndex = 2;
            this.lbSenha.Text = "Senha";
            // 
            // lbConfirmaSenha
            // 
            this.lbConfirmaSenha.AutoSize = true;
            this.lbConfirmaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbConfirmaSenha.Location = new System.Drawing.Point(27, 154);
            this.lbConfirmaSenha.Name = "lbConfirmaSenha";
            this.lbConfirmaSenha.Size = new System.Drawing.Size(62, 20);
            this.lbConfirmaSenha.TabIndex = 4;
            this.lbConfirmaSenha.Text = "&Senha*";
            // 
            // lbFuncionario
            // 
            this.lbFuncionario.AutoSize = true;
            this.lbFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbFuncionario.Location = new System.Drawing.Point(27, 189);
            this.lbFuncionario.Name = "lbFuncionario";
            this.lbFuncionario.Size = new System.Drawing.Size(96, 20);
            this.lbFuncionario.TabIndex = 6;
            this.lbFuncionario.Text = "Funcionário";
            // 
            // tbUsuario
            // 
            this.tbUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbUsuario.Location = new System.Drawing.Point(136, 77);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(240, 27);
            this.tbUsuario.TabIndex = 1;
            this.tbUsuario.Leave += new System.EventHandler(this.tbUsuario_Leave);
            // 
            // tbSenha
            // 
            this.tbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbSenha.Location = new System.Drawing.Point(136, 112);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(207, 27);
            this.tbSenha.TabIndex = 3;
            this.tbSenha.UseSystemPasswordChar = true;
            this.tbSenha.Leave += new System.EventHandler(this.tbSenha_Leave);
            // 
            // tbConfirmaSenha
            // 
            this.tbConfirmaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbConfirmaSenha.Location = new System.Drawing.Point(136, 147);
            this.tbConfirmaSenha.Name = "tbConfirmaSenha";
            this.tbConfirmaSenha.Size = new System.Drawing.Size(207, 27);
            this.tbConfirmaSenha.TabIndex = 5;
            this.tbConfirmaSenha.UseSystemPasswordChar = true;
            this.tbConfirmaSenha.Leave += new System.EventHandler(this.tbConfirmaSenha_Leave);
            // 
            // tbFuncionario
            // 
            this.tbFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbFuncionario.Location = new System.Drawing.Point(136, 182);
            this.tbFuncionario.Name = "tbFuncionario";
            this.tbFuncionario.Size = new System.Drawing.Size(207, 27);
            this.tbFuncionario.TabIndex = 7;
            this.tbFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFuncionario_KeyPress);
            this.tbFuncionario.Leave += new System.EventHandler(this.tbFuncionario_Leave);
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.Turquoise;
            this.btCadastrar.FlatAppearance.BorderSize = 0;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCadastrar.Location = new System.Drawing.Point(110, 242);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(130, 42);
            this.btCadastrar.TabIndex = 8;
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
            this.btSair.Location = new System.Drawing.Point(246, 242);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(130, 42);
            this.btSair.TabIndex = 9;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // epUsuarioSenha
            // 
            this.epUsuarioSenha.ContainerControl = this;
            // 
            // pbSelecionarFuncionario
            // 
            this.pbSelecionarFuncionario.AccessibleDescription = "";
            this.pbSelecionarFuncionario.Image = global::Apresentacao.Properties.Resources.Selecionar;
            this.pbSelecionarFuncionario.ImageLocation = "";
            this.pbSelecionarFuncionario.Location = new System.Drawing.Point(349, 182);
            this.pbSelecionarFuncionario.Name = "pbSelecionarFuncionario";
            this.pbSelecionarFuncionario.Size = new System.Drawing.Size(27, 27);
            this.pbSelecionarFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSelecionarFuncionario.TabIndex = 13;
            this.pbSelecionarFuncionario.TabStop = false;
            this.pbSelecionarFuncionario.Click += new System.EventHandler(this.pbSelecionarFuncionario_Click);
            // 
            // pbMostrarConfirmaSenha
            // 
            this.pbMostrarConfirmaSenha.Image = global::Apresentacao.Properties.Resources.MostrarSenha;
            this.pbMostrarConfirmaSenha.ImageLocation = "";
            this.pbMostrarConfirmaSenha.Location = new System.Drawing.Point(349, 147);
            this.pbMostrarConfirmaSenha.Name = "pbMostrarConfirmaSenha";
            this.pbMostrarConfirmaSenha.Size = new System.Drawing.Size(27, 27);
            this.pbMostrarConfirmaSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMostrarConfirmaSenha.TabIndex = 11;
            this.pbMostrarConfirmaSenha.TabStop = false;
            this.pbMostrarConfirmaSenha.Click += new System.EventHandler(this.pbMostrarConfirmaSenha_Click);
            // 
            // pbMostrarSenha
            // 
            this.pbMostrarSenha.Image = global::Apresentacao.Properties.Resources.MostrarSenha;
            this.pbMostrarSenha.ImageLocation = "";
            this.pbMostrarSenha.Location = new System.Drawing.Point(349, 112);
            this.pbMostrarSenha.Name = "pbMostrarSenha";
            this.pbMostrarSenha.Size = new System.Drawing.Size(27, 27);
            this.pbMostrarSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMostrarSenha.TabIndex = 10;
            this.pbMostrarSenha.TabStop = false;
            this.pbMostrarSenha.Click += new System.EventHandler(this.pbMostrarSenha_Click);
            // 
            // pbUsuarioSenha
            // 
            this.pbUsuarioSenha.Image = global::Apresentacao.Properties.Resources.UsuarioLogo;
            this.pbUsuarioSenha.Location = new System.Drawing.Point(27, 12);
            this.pbUsuarioSenha.Name = "pbUsuarioSenha";
            this.pbUsuarioSenha.Size = new System.Drawing.Size(52, 52);
            this.pbUsuarioSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsuarioSenha.TabIndex = 4;
            this.pbUsuarioSenha.TabStop = false;
            // 
            // FrmCadastroUsuarioSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(408, 301);
            this.Controls.Add(this.pbSelecionarFuncionario);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.pbMostrarConfirmaSenha);
            this.Controls.Add(this.pbMostrarSenha);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.tbFuncionario);
            this.Controls.Add(this.tbConfirmaSenha);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.pbUsuarioSenha);
            this.Controls.Add(this.lbFuncionario);
            this.Controls.Add(this.lbConfirmaSenha);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmCadastroUsuarioSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Usuário";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadastroUsuarioSenha_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.epUsuarioSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelecionarFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarConfirmaSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarioSenha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Label lbConfirmaSenha;
        private System.Windows.Forms.Label lbFuncionario;
        private System.Windows.Forms.PictureBox pbUsuarioSenha;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.TextBox tbConfirmaSenha;
        private System.Windows.Forms.TextBox tbFuncionario;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.PictureBox pbMostrarSenha;
        private System.Windows.Forms.PictureBox pbMostrarConfirmaSenha;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.ErrorProvider epUsuarioSenha;
        private System.Windows.Forms.PictureBox pbSelecionarFuncionario;
    }
}