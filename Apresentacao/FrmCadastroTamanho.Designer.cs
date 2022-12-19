namespace Apresentacao
{
    partial class FrmCadastroTamanho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroTamanho));
            this.pbTamanho = new System.Windows.Forms.PictureBox();
            this.lbTamanho = new System.Windows.Forms.Label();
            this.tbTamanho = new System.Windows.Forms.TextBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.epTamanho = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbTamanho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTamanho)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTamanho
            // 
            this.pbTamanho.Image = global::Apresentacao.Properties.Resources.Tamanho;
            this.pbTamanho.Location = new System.Drawing.Point(27, 12);
            this.pbTamanho.Name = "pbTamanho";
            this.pbTamanho.Size = new System.Drawing.Size(52, 52);
            this.pbTamanho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTamanho.TabIndex = 0;
            this.pbTamanho.TabStop = false;
            // 
            // lbTamanho
            // 
            this.lbTamanho.AutoSize = true;
            this.lbTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTamanho.Location = new System.Drawing.Point(23, 99);
            this.lbTamanho.Name = "lbTamanho";
            this.lbTamanho.Size = new System.Drawing.Size(78, 20);
            this.lbTamanho.TabIndex = 0;
            this.lbTamanho.Text = "Tamanho";
            // 
            // tbTamanho
            // 
            this.tbTamanho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbTamanho.Location = new System.Drawing.Point(112, 92);
            this.tbTamanho.Name = "tbTamanho";
            this.tbTamanho.Size = new System.Drawing.Size(240, 27);
            this.tbTamanho.TabIndex = 1;
            this.tbTamanho.Leave += new System.EventHandler(this.tbTamanho_Leave);
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.Turquoise;
            this.btCadastrar.FlatAppearance.BorderSize = 0;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCadastrar.Location = new System.Drawing.Point(86, 152);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(130, 42);
            this.btCadastrar.TabIndex = 2;
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
            this.btSair.Location = new System.Drawing.Point(222, 152);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(130, 42);
            this.btSair.TabIndex = 3;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // epTamanho
            // 
            this.epTamanho.ContainerControl = this;
            // 
            // FrmCadastroTamanho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(376, 211);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.tbTamanho);
            this.Controls.Add(this.lbTamanho);
            this.Controls.Add(this.pbTamanho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmCadastroTamanho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Tamanho";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadastroTamanho_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbTamanho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTamanho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTamanho;
        private System.Windows.Forms.Label lbTamanho;
        private System.Windows.Forms.TextBox tbTamanho;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.ErrorProvider epTamanho;
    }
}