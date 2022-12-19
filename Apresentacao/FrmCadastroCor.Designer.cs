namespace Apresentacao
{
    partial class FrmCadastroCor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroCor));
            this.lbCor = new System.Windows.Forms.Label();
            this.tbNomeCor = new System.Windows.Forms.TextBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.epCor = new System.Windows.Forms.ErrorProvider(this.components);
            this.pbCor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.epCor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCor)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCor
            // 
            this.lbCor.AutoSize = true;
            this.lbCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCor.Location = new System.Drawing.Point(23, 99);
            this.lbCor.Name = "lbCor";
            this.lbCor.Size = new System.Drawing.Size(36, 20);
            this.lbCor.TabIndex = 0;
            this.lbCor.Text = "Cor";
            // 
            // tbNomeCor
            // 
            this.tbNomeCor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNomeCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbNomeCor.Location = new System.Drawing.Point(65, 92);
            this.tbNomeCor.Name = "tbNomeCor";
            this.tbNomeCor.Size = new System.Drawing.Size(240, 27);
            this.tbNomeCor.TabIndex = 1;
            this.tbNomeCor.Leave += new System.EventHandler(this.tbNomeCor_Leave);
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.Turquoise;
            this.btCadastrar.FlatAppearance.BorderSize = 0;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCadastrar.Location = new System.Drawing.Point(27, 148);
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
            this.btSair.Location = new System.Drawing.Point(175, 148);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(130, 42);
            this.btSair.TabIndex = 3;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // epCor
            // 
            this.epCor.ContainerControl = this;
            // 
            // pbCor
            // 
            this.pbCor.Image = global::Apresentacao.Properties.Resources.CorLogo;
            this.pbCor.Location = new System.Drawing.Point(27, 12);
            this.pbCor.Name = "pbCor";
            this.pbCor.Size = new System.Drawing.Size(52, 52);
            this.pbCor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCor.TabIndex = 0;
            this.pbCor.TabStop = false;
            // 
            // FrmCadastroCor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(324, 211);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.tbNomeCor);
            this.Controls.Add(this.lbCor);
            this.Controls.Add(this.pbCor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmCadastroCor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Cor";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadastroCor_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.epCor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCor;
        private System.Windows.Forms.Label lbCor;
        private System.Windows.Forms.TextBox tbNomeCor;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.ErrorProvider epCor;
    }
}