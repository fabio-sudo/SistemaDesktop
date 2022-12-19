namespace Apresentacao
{
    partial class FrmCaixaDialogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCaixaDialogo));
            this.btConfirmar = new System.Windows.Forms.Button();
            this.tbTexto = new System.Windows.Forms.TextBox();
            this.pbFormulario = new System.Windows.Forms.PictureBox();
            this.btCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormulario)).BeginInit();
            this.SuspendLayout();
            // 
            // btConfirmar
            // 
            this.btConfirmar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btConfirmar.FlatAppearance.BorderSize = 0;
            this.btConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirmar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btConfirmar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btConfirmar.Location = new System.Drawing.Point(95, 164);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(130, 42);
            this.btConfirmar.TabIndex = 0;
            this.btConfirmar.Text = "Confirmar";
            this.btConfirmar.UseVisualStyleBackColor = false;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // tbTexto
            // 
            this.tbTexto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbTexto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbTexto.ForeColor = System.Drawing.Color.Black;
            this.tbTexto.Location = new System.Drawing.Point(12, 108);
            this.tbTexto.Multiline = true;
            this.tbTexto.Name = "tbTexto";
            this.tbTexto.ReadOnly = true;
            this.tbTexto.Size = new System.Drawing.Size(435, 50);
            this.tbTexto.TabIndex = 4;
            this.tbTexto.Text = "...";
            this.tbTexto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbFormulario
            // 
            this.pbFormulario.Image = global::Apresentacao.Properties.Resources.logoPng;
            this.pbFormulario.Location = new System.Drawing.Point(197, 28);
            this.pbFormulario.Name = "pbFormulario";
            this.pbFormulario.Size = new System.Drawing.Size(64, 64);
            this.pbFormulario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFormulario.TabIndex = 3;
            this.pbFormulario.TabStop = false;
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.Red;
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCancelar.Location = new System.Drawing.Point(235, 164);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(130, 42);
            this.btCancelar.TabIndex = 1;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // FrmCaixaDialogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(459, 229);
            this.Controls.Add(this.tbTexto);
            this.Controls.Add(this.pbFormulario);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btConfirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCaixaDialogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...";
            ((System.ComponentModel.ISupportInitialize)(this.pbFormulario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.PictureBox pbFormulario;
        private System.Windows.Forms.TextBox tbTexto;
        private System.Windows.Forms.Button btCancelar;
    }
}