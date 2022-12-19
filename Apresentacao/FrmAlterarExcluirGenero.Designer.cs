namespace Apresentacao
{
    partial class FrmAlterarExcluirGenero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlterarExcluirGenero));
            this.btSair = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.lbGenero = new System.Windows.Forms.Label();
            this.tbNomeGenero = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btExcluir = new System.Windows.Forms.Button();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.pbDesfazer = new System.Windows.Forms.PictureBox();
            this.epGenero = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDesfazer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGenero)).BeginInit();
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Red;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSair.Location = new System.Drawing.Point(298, 195);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(130, 42);
            this.btSair.TabIndex = 9;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btAlterar.FlatAppearance.BorderSize = 0;
            this.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlterar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btAlterar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAlterar.Location = new System.Drawing.Point(27, 195);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(130, 42);
            this.btAlterar.TabIndex = 8;
            this.btAlterar.Text = "F10 Alterar";
            this.btAlterar.UseVisualStyleBackColor = false;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbGenero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbGenero.Location = new System.Drawing.Point(23, 134);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(64, 20);
            this.lbGenero.TabIndex = 7;
            this.lbGenero.Text = "Gênero";
            // 
            // tbNomeGenero
            // 
            this.tbNomeGenero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNomeGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbNomeGenero.Location = new System.Drawing.Point(103, 127);
            this.tbNomeGenero.Name = "tbNomeGenero";
            this.tbNomeGenero.Size = new System.Drawing.Size(240, 27);
            this.tbNomeGenero.TabIndex = 6;
            this.tbNomeGenero.Leave += new System.EventHandler(this.tbNomeGenero_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Apresentacao.Properties.Resources.GeneroLogo;
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.DeepPink;
            this.btExcluir.FlatAppearance.BorderSize = 0;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btExcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btExcluir.Location = new System.Drawing.Point(163, 195);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(130, 42);
            this.btExcluir.TabIndex = 10;
            this.btExcluir.Text = "F2 Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCodigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbCodigo.Location = new System.Drawing.Point(23, 99);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(61, 20);
            this.lbCodigo.TabIndex = 12;
            this.lbCodigo.Text = "Código";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Enabled = false;
            this.tbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbCodigo.Location = new System.Drawing.Point(103, 92);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(66, 27);
            this.tbCodigo.TabIndex = 11;
            // 
            // pbDesfazer
            // 
            this.pbDesfazer.Image = global::Apresentacao.Properties.Resources.Desfazer;
            this.pbDesfazer.Location = new System.Drawing.Point(175, 92);
            this.pbDesfazer.Name = "pbDesfazer";
            this.pbDesfazer.Size = new System.Drawing.Size(27, 27);
            this.pbDesfazer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDesfazer.TabIndex = 19;
            this.pbDesfazer.TabStop = false;
            this.pbDesfazer.Click += new System.EventHandler(this.pbDesfazer_Click);
            // 
            // epGenero
            // 
            this.epGenero.ContainerControl = this;
            // 
            // FrmAlterarExcluirGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(456, 249);
            this.Controls.Add(this.pbDesfazer);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.lbGenero);
            this.Controls.Add(this.tbNomeGenero);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmAlterarExcluirGenero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar & Excluir - Gênero";
            this.Load += new System.EventHandler(this.FrmAlterarExcluirGenero_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAlterarExcluirGenero_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDesfazer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGenero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Label lbGenero;
        private System.Windows.Forms.TextBox tbNomeGenero;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.PictureBox pbDesfazer;
        private System.Windows.Forms.ErrorProvider epGenero;
    }
}