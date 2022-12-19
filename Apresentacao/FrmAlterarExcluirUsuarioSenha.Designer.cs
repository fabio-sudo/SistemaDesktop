namespace Apresentacao
{
    partial class FrmAlterarExcluirUsuarioSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlterarExcluirUsuarioSenha));
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.lbConfirmaSenha = new System.Windows.Forms.Label();
            this.lbFuncionario = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.tbConfirmaSenha = new System.Windows.Forms.TextBox();
            this.tbFuncionario = new System.Windows.Forms.TextBox();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.pbSelecionarFuncionario = new System.Windows.Forms.PictureBox();
            this.pbMostrarConfirmaSenha = new System.Windows.Forms.PictureBox();
            this.pbMostrarSenha = new System.Windows.Forms.PictureBox();
            this.pbUsuarioSenha = new System.Windows.Forms.PictureBox();
            this.pbDesfazer = new System.Windows.Forms.PictureBox();
            this.epUsuarioSenha = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbSelecionarFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarConfirmaSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarioSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDesfazer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUsuarioSenha)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCodigo.Location = new System.Drawing.Point(27, 84);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(61, 20);
            this.lbCodigo.TabIndex = 1;
            this.lbCodigo.Text = "Código";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbUsuario.Location = new System.Drawing.Point(27, 119);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(67, 20);
            this.lbUsuario.TabIndex = 2;
            this.lbUsuario.Text = "Usuário";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbSenha.Location = new System.Drawing.Point(27, 154);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(56, 20);
            this.lbSenha.TabIndex = 3;
            this.lbSenha.Text = "Senha";
            // 
            // lbConfirmaSenha
            // 
            this.lbConfirmaSenha.AutoSize = true;
            this.lbConfirmaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbConfirmaSenha.Location = new System.Drawing.Point(27, 189);
            this.lbConfirmaSenha.Name = "lbConfirmaSenha";
            this.lbConfirmaSenha.Size = new System.Drawing.Size(62, 20);
            this.lbConfirmaSenha.TabIndex = 4;
            this.lbConfirmaSenha.Text = "Senha*";
            // 
            // lbFuncionario
            // 
            this.lbFuncionario.AutoSize = true;
            this.lbFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbFuncionario.Location = new System.Drawing.Point(27, 224);
            this.lbFuncionario.Name = "lbFuncionario";
            this.lbFuncionario.Size = new System.Drawing.Size(96, 20);
            this.lbFuncionario.TabIndex = 5;
            this.lbFuncionario.Text = "Funcionário";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Enabled = false;
            this.tbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbCodigo.Location = new System.Drawing.Point(136, 77);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(66, 27);
            this.tbCodigo.TabIndex = 6;
            // 
            // tbUsuario
            // 
            this.tbUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbUsuario.Location = new System.Drawing.Point(136, 112);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(240, 27);
            this.tbUsuario.TabIndex = 7;
            this.tbUsuario.Leave += new System.EventHandler(this.tbUsuario_Leave);
            // 
            // tbSenha
            // 
            this.tbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbSenha.Location = new System.Drawing.Point(136, 147);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(207, 27);
            this.tbSenha.TabIndex = 8;
            this.tbSenha.UseSystemPasswordChar = true;
            this.tbSenha.Leave += new System.EventHandler(this.tbSenha_Leave);
            // 
            // tbConfirmaSenha
            // 
            this.tbConfirmaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbConfirmaSenha.Location = new System.Drawing.Point(136, 182);
            this.tbConfirmaSenha.Name = "tbConfirmaSenha";
            this.tbConfirmaSenha.Size = new System.Drawing.Size(207, 27);
            this.tbConfirmaSenha.TabIndex = 9;
            this.tbConfirmaSenha.UseSystemPasswordChar = true;
            this.tbConfirmaSenha.Leave += new System.EventHandler(this.tbConfirmaSenha_Leave);
            // 
            // tbFuncionario
            // 
            this.tbFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbFuncionario.Location = new System.Drawing.Point(136, 217);
            this.tbFuncionario.Name = "tbFuncionario";
            this.tbFuncionario.Size = new System.Drawing.Size(207, 27);
            this.tbFuncionario.TabIndex = 10;
            this.tbFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFuncionario_KeyPress);
            this.tbFuncionario.Leave += new System.EventHandler(this.tbFuncionario_Leave);
            // 
            // btAlterar
            // 
            this.btAlterar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btAlterar.FlatAppearance.BorderSize = 0;
            this.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlterar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btAlterar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAlterar.Location = new System.Drawing.Point(12, 270);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(130, 42);
            this.btAlterar.TabIndex = 14;
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
            this.btExcluir.Location = new System.Drawing.Point(148, 270);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(130, 42);
            this.btExcluir.TabIndex = 15;
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
            this.btSair.Location = new System.Drawing.Point(284, 270);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(130, 42);
            this.btSair.TabIndex = 17;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // pbSelecionarFuncionario
            // 
            this.pbSelecionarFuncionario.Image = global::Apresentacao.Properties.Resources.Selecionar;
            this.pbSelecionarFuncionario.Location = new System.Drawing.Point(349, 215);
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
            this.pbMostrarConfirmaSenha.Location = new System.Drawing.Point(349, 182);
            this.pbMostrarConfirmaSenha.Name = "pbMostrarConfirmaSenha";
            this.pbMostrarConfirmaSenha.Size = new System.Drawing.Size(27, 27);
            this.pbMostrarConfirmaSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMostrarConfirmaSenha.TabIndex = 12;
            this.pbMostrarConfirmaSenha.TabStop = false;
            this.pbMostrarConfirmaSenha.Click += new System.EventHandler(this.pbMostrarConfirmaSenha_Click);
            // 
            // pbMostrarSenha
            // 
            this.pbMostrarSenha.Image = global::Apresentacao.Properties.Resources.MostrarSenha;
            this.pbMostrarSenha.Location = new System.Drawing.Point(349, 147);
            this.pbMostrarSenha.Name = "pbMostrarSenha";
            this.pbMostrarSenha.Size = new System.Drawing.Size(27, 27);
            this.pbMostrarSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMostrarSenha.TabIndex = 11;
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
            this.pbUsuarioSenha.TabIndex = 0;
            this.pbUsuarioSenha.TabStop = false;
            // 
            // pbDesfazer
            // 
            this.pbDesfazer.Image = global::Apresentacao.Properties.Resources.Desfazer;
            this.pbDesfazer.Location = new System.Drawing.Point(208, 77);
            this.pbDesfazer.Name = "pbDesfazer";
            this.pbDesfazer.Size = new System.Drawing.Size(27, 27);
            this.pbDesfazer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDesfazer.TabIndex = 18;
            this.pbDesfazer.TabStop = false;
            this.pbDesfazer.Click += new System.EventHandler(this.pbDesfazer_Click);
            // 
            // epUsuarioSenha
            // 
            this.epUsuarioSenha.ContainerControl = this;
            // 
            // FrmAlterarExcluirUsuarioSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(428, 338);
            this.Controls.Add(this.pbDesfazer);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.pbSelecionarFuncionario);
            this.Controls.Add(this.pbMostrarConfirmaSenha);
            this.Controls.Add(this.pbMostrarSenha);
            this.Controls.Add(this.tbFuncionario);
            this.Controls.Add(this.tbConfirmaSenha);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.lbFuncionario);
            this.Controls.Add(this.lbConfirmaSenha);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.pbUsuarioSenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmAlterarExcluirUsuarioSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar & Excluir Usuário ";
            this.Load += new System.EventHandler(this.FrmAlterarExcluirUsuarioSenha_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAlterarExcluirUsuarioSenha_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbSelecionarFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarConfirmaSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarioSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDesfazer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUsuarioSenha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbUsuarioSenha;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Label lbConfirmaSenha;
        private System.Windows.Forms.Label lbFuncionario;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.TextBox tbConfirmaSenha;
        private System.Windows.Forms.TextBox tbFuncionario;
        private System.Windows.Forms.PictureBox pbMostrarSenha;
        private System.Windows.Forms.PictureBox pbMostrarConfirmaSenha;
        private System.Windows.Forms.PictureBox pbSelecionarFuncionario;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.PictureBox pbDesfazer;
        private System.Windows.Forms.ErrorProvider epUsuarioSenha;
    }
}