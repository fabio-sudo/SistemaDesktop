namespace Apresentacao
{
    partial class FrmAlterarExcluirCor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlterarExcluirCor));
            this.btSair = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.tbNomeCor = new System.Windows.Forms.TextBox();
            this.lbCor = new System.Windows.Forms.Label();
            this.tbCodigoCor = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.btExcluir = new System.Windows.Forms.Button();
            this.pbCor = new System.Windows.Forms.PictureBox();
            this.pbDesfazer = new System.Windows.Forms.PictureBox();
            this.epCor = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbCor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDesfazer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCor)).BeginInit();
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Red;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSair.Location = new System.Drawing.Point(293, 195);
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
            this.btAlterar.Location = new System.Drawing.Point(21, 195);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(130, 42);
            this.btAlterar.TabIndex = 8;
            this.btAlterar.Text = "F10 Alterar";
            this.btAlterar.UseVisualStyleBackColor = false;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // tbNomeCor
            // 
            this.tbNomeCor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNomeCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbNomeCor.Location = new System.Drawing.Point(96, 127);
            this.tbNomeCor.Name = "tbNomeCor";
            this.tbNomeCor.Size = new System.Drawing.Size(240, 27);
            this.tbNomeCor.TabIndex = 7;
            this.tbNomeCor.Leave += new System.EventHandler(this.tbNomeCor_Leave);
            // 
            // lbCor
            // 
            this.lbCor.AutoSize = true;
            this.lbCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCor.Location = new System.Drawing.Point(23, 134);
            this.lbCor.Name = "lbCor";
            this.lbCor.Size = new System.Drawing.Size(36, 20);
            this.lbCor.TabIndex = 6;
            this.lbCor.Text = "Cor";
            // 
            // tbCodigoCor
            // 
            this.tbCodigoCor.Enabled = false;
            this.tbCodigoCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbCodigoCor.Location = new System.Drawing.Point(96, 92);
            this.tbCodigoCor.Name = "tbCodigoCor";
            this.tbCodigoCor.Size = new System.Drawing.Size(66, 27);
            this.tbCodigoCor.TabIndex = 11;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCodigo.Location = new System.Drawing.Point(23, 99);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(61, 20);
            this.lbCodigo.TabIndex = 10;
            this.lbCodigo.Text = "Código";
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.DeepPink;
            this.btExcluir.FlatAppearance.BorderSize = 0;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btExcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btExcluir.Location = new System.Drawing.Point(157, 195);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(130, 42);
            this.btExcluir.TabIndex = 12;
            this.btExcluir.Text = "F2 Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // pbCor
            // 
            this.pbCor.Image = global::Apresentacao.Properties.Resources.CorLogo;
            this.pbCor.Location = new System.Drawing.Point(27, 12);
            this.pbCor.Name = "pbCor";
            this.pbCor.Size = new System.Drawing.Size(52, 52);
            this.pbCor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCor.TabIndex = 5;
            this.pbCor.TabStop = false;
            // 
            // pbDesfazer
            // 
            this.pbDesfazer.Image = global::Apresentacao.Properties.Resources.Desfazer;
            this.pbDesfazer.Location = new System.Drawing.Point(168, 92);
            this.pbDesfazer.Name = "pbDesfazer";
            this.pbDesfazer.Size = new System.Drawing.Size(27, 27);
            this.pbDesfazer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDesfazer.TabIndex = 13;
            this.pbDesfazer.TabStop = false;
            this.pbDesfazer.Click += new System.EventHandler(this.pbDesfazer_Click);
            // 
            // epCor
            // 
            this.epCor.ContainerControl = this;
            // 
            // FrmAlterarExcluirCor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(444, 250);
            this.Controls.Add(this.pbDesfazer);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.tbCodigoCor);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.tbNomeCor);
            this.Controls.Add(this.lbCor);
            this.Controls.Add(this.pbCor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmAlterarExcluirCor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar & Ecluir - Cor";
            this.Load += new System.EventHandler(this.FrmAlterarExcluirCor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAlterarExcluirCor_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbCor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDesfazer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.TextBox tbNomeCor;
        private System.Windows.Forms.Label lbCor;
        private System.Windows.Forms.PictureBox pbCor;
        private System.Windows.Forms.TextBox tbCodigoCor;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.PictureBox pbDesfazer;
        private System.Windows.Forms.ErrorProvider epCor;
    }
}