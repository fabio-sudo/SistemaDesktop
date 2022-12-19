namespace Apresentacao
{
    partial class FrmCadastroGenero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroGenero));
            this.pbGenero = new System.Windows.Forms.PictureBox();
            this.tbNomeGenero = new System.Windows.Forms.TextBox();
            this.lbGenero = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.epGenero = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbGenero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGenero)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGenero
            // 
            this.pbGenero.Image = global::Apresentacao.Properties.Resources.GeneroLogo;
            this.pbGenero.Location = new System.Drawing.Point(27, 12);
            this.pbGenero.Name = "pbGenero";
            this.pbGenero.Size = new System.Drawing.Size(64, 45);
            this.pbGenero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGenero.TabIndex = 0;
            this.pbGenero.TabStop = false;
            // 
            // tbNomeGenero
            // 
            this.tbNomeGenero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNomeGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbNomeGenero.Location = new System.Drawing.Point(102, 92);
            this.tbNomeGenero.Name = "tbNomeGenero";
            this.tbNomeGenero.Size = new System.Drawing.Size(240, 27);
            this.tbNomeGenero.TabIndex = 1;
            this.tbNomeGenero.Leave += new System.EventHandler(this.tbNomeGenero_Leave);
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbGenero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbGenero.Location = new System.Drawing.Point(23, 99);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(64, 20);
            this.lbGenero.TabIndex = 0;
            this.lbGenero.Text = "Gênero";
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.Turquoise;
            this.btCadastrar.FlatAppearance.BorderSize = 0;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCadastrar.Location = new System.Drawing.Point(76, 152);
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
            this.btSair.Location = new System.Drawing.Point(212, 152);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(130, 42);
            this.btSair.TabIndex = 3;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // epGenero
            // 
            this.epGenero.ContainerControl = this;
            // 
            // FrmCadastroGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(371, 206);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.lbGenero);
            this.Controls.Add(this.tbNomeGenero);
            this.Controls.Add(this.pbGenero);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmCadastroGenero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Cadastro Gênero";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadastrarGenero_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbGenero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGenero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGenero;
        private System.Windows.Forms.TextBox tbNomeGenero;
        private System.Windows.Forms.Label lbGenero;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.ErrorProvider epGenero;
    }
}