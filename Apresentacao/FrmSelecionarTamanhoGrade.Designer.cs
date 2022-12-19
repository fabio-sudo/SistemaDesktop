namespace Apresentacao
{
    partial class FrmSelecionarTamanhoGrade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelecionarTamanhoGrade));
            this.btAlterar = new System.Windows.Forms.Button();
            this.dgvTamanho = new System.Windows.Forms.DataGridView();
            this.codigoTamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeTamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btSair = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btSelecionar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.panelBuscarTamanho = new System.Windows.Forms.Panel();
            this.tbBuscarTamanho = new System.Windows.Forms.TextBox();
            this.pbTamanho = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTamanho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTamanho)).BeginInit();
            this.SuspendLayout();
            // 
            // btAlterar
            // 
            this.btAlterar.BackColor = System.Drawing.Color.DeepPink;
            this.btAlterar.FlatAppearance.BorderSize = 0;
            this.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlterar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btAlterar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAlterar.Location = new System.Drawing.Point(283, 506);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(130, 42);
            this.btAlterar.TabIndex = 5;
            this.btAlterar.Text = "F4 Alterar";
            this.btAlterar.UseVisualStyleBackColor = false;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // dgvTamanho
            // 
            this.dgvTamanho.AllowUserToAddRows = false;
            this.dgvTamanho.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dgvTamanho.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTamanho.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTamanho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTamanho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTamanho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoTamanho,
            this.nomeTamanho});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTamanho.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTamanho.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTamanho.Location = new System.Drawing.Point(11, 73);
            this.dgvTamanho.Name = "dgvTamanho";
            this.dgvTamanho.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.dgvTamanho.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTamanho.RowTemplate.Height = 24;
            this.dgvTamanho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTamanho.Size = new System.Drawing.Size(538, 427);
            this.dgvTamanho.TabIndex = 2;
            this.dgvTamanho.DoubleClick += new System.EventHandler(this.dgvTamanho_DoubleClick);
            // 
            // codigoTamanho
            // 
            this.codigoTamanho.HeaderText = "Cód";
            this.codigoTamanho.Name = "codigoTamanho";
            this.codigoTamanho.ReadOnly = true;
            this.codigoTamanho.ToolTipText = "Código do Tamano";
            this.codigoTamanho.Width = 50;
            // 
            // nomeTamanho
            // 
            this.nomeTamanho.HeaderText = "Tamanho";
            this.nomeTamanho.Name = "nomeTamanho";
            this.nomeTamanho.ReadOnly = true;
            this.nomeTamanho.Width = 240;
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Red;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSair.Location = new System.Drawing.Point(419, 506);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(130, 42);
            this.btSair.TabIndex = 6;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.Turquoise;
            this.btCadastrar.FlatAppearance.BorderSize = 0;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCadastrar.Location = new System.Drawing.Point(147, 506);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(130, 42);
            this.btCadastrar.TabIndex = 4;
            this.btCadastrar.Text = "F10 Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btSelecionar
            // 
            this.btSelecionar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btSelecionar.FlatAppearance.BorderSize = 0;
            this.btSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSelecionar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSelecionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSelecionar.Location = new System.Drawing.Point(11, 506);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(130, 42);
            this.btSelecionar.TabIndex = 3;
            this.btSelecionar.Text = "F2 Selecionar";
            this.btSelecionar.UseVisualStyleBackColor = false;
            this.btSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btBuscar.FlatAppearance.BorderSize = 0;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBuscar.Location = new System.Drawing.Point(400, 25);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(130, 42);
            this.btBuscar.TabIndex = 1;
            this.btBuscar.Text = "F5 Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // panelBuscarTamanho
            // 
            this.panelBuscarTamanho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelBuscarTamanho.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelBuscarTamanho.Location = new System.Drawing.Point(11, 65);
            this.panelBuscarTamanho.Name = "panelBuscarTamanho";
            this.panelBuscarTamanho.Size = new System.Drawing.Size(383, 2);
            this.panelBuscarTamanho.TabIndex = 11;
            // 
            // tbBuscarTamanho
            // 
            this.tbBuscarTamanho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBuscarTamanho.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tbBuscarTamanho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbBuscarTamanho.Location = new System.Drawing.Point(51, 42);
            this.tbBuscarTamanho.Name = "tbBuscarTamanho";
            this.tbBuscarTamanho.Size = new System.Drawing.Size(343, 23);
            this.tbBuscarTamanho.TabIndex = 0;
            this.tbBuscarTamanho.Text = "Digite o tamanho do produto ...";
            this.tbBuscarTamanho.Enter += new System.EventHandler(this.tbBuscarTamanho_Enter);
            this.tbBuscarTamanho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscarTamanho_KeyPress);
            this.tbBuscarTamanho.Leave += new System.EventHandler(this.tbBuscarTamanho_Leave);
            // 
            // pbTamanho
            // 
            this.pbTamanho.Image = global::Apresentacao.Properties.Resources.TamanhoAzul;
            this.pbTamanho.Location = new System.Drawing.Point(11, 27);
            this.pbTamanho.Name = "pbTamanho";
            this.pbTamanho.Size = new System.Drawing.Size(34, 36);
            this.pbTamanho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTamanho.TabIndex = 9;
            this.pbTamanho.TabStop = false;
            // 
            // FrmSelecionarTamanhoGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(560, 573);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.dgvTamanho);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.panelBuscarTamanho);
            this.Controls.Add(this.tbBuscarTamanho);
            this.Controls.Add(this.pbTamanho);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmSelecionarTamanhoGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Tamanho da Grade";
            this.Load += new System.EventHandler(this.FrmSelecionarTamanhoGrade_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSelecionarTamanhoGrade_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTamanho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTamanho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.DataGridView dgvTamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeTamanho;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btSelecionar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Panel panelBuscarTamanho;
        private System.Windows.Forms.TextBox tbBuscarTamanho;
        private System.Windows.Forms.PictureBox pbTamanho;
    }
}