namespace Apresentacao
{
    partial class FrmCaixaDialogoOpcoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCaixaDialogoOpcoes));
            this.tbTexto = new System.Windows.Forms.TextBox();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.pbFormulario = new System.Windows.Forms.PictureBox();
            this.btSelecionar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormulario)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTexto
            // 
            this.tbTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbTexto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbTexto.ForeColor = System.Drawing.Color.White;
            this.tbTexto.Location = new System.Drawing.Point(11, 92);
            this.tbTexto.Multiline = true;
            this.tbTexto.Name = "tbTexto";
            this.tbTexto.ReadOnly = true;
            this.tbTexto.Size = new System.Drawing.Size(435, 50);
            this.tbTexto.TabIndex = 3;
            this.tbTexto.Text = "...";
            this.tbTexto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btConfirmar
            // 
            this.btConfirmar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirmar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btConfirmar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btConfirmar.Location = new System.Drawing.Point(12, 148);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(130, 42);
            this.btConfirmar.TabIndex = 0;
            this.btConfirmar.Text = "Selecionar";
            this.btConfirmar.UseVisualStyleBackColor = false;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // pbFormulario
            // 
            this.pbFormulario.Image = global::Apresentacao.Properties.Resources.logoPng;
            this.pbFormulario.Location = new System.Drawing.Point(196, 12);
            this.pbFormulario.Name = "pbFormulario";
            this.pbFormulario.Size = new System.Drawing.Size(64, 64);
            this.pbFormulario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFormulario.TabIndex = 7;
            this.pbFormulario.TabStop = false;
            // 
            // btSelecionar
            // 
            this.btSelecionar.BackColor = System.Drawing.Color.DeepPink;
            this.btSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSelecionar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSelecionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSelecionar.Location = new System.Drawing.Point(166, 148);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(130, 42);
            this.btSelecionar.TabIndex = 1;
            this.btSelecionar.Text = "Excluir";
            this.btSelecionar.UseVisualStyleBackColor = false;
            this.btSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.Red;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCancelar.Location = new System.Drawing.Point(317, 148);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(130, 42);
            this.btCancelar.TabIndex = 2;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // FrmCaixaDialogoOpcoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(459, 229);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.tbTexto);
            this.Controls.Add(this.pbFormulario);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btConfirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCaixaDialogoOpcoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...";
            ((System.ComponentModel.ISupportInitialize)(this.pbFormulario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTexto;
        private System.Windows.Forms.PictureBox pbFormulario;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.Button btSelecionar;
        private System.Windows.Forms.Button btCancelar;
    }
}