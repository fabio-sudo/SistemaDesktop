namespace Apresentacao
{
    partial class FrmSelecionarGenero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelecionarGenero));
            this.tbBuscarGenero = new System.Windows.Forms.TextBox();
            this.panelBuscarGenero = new System.Windows.Forms.Panel();
            this.btBuscar = new System.Windows.Forms.Button();
            this.dgvGenero = new System.Windows.Forms.DataGridView();
            this.codigoGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btSelecionar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.pbGenero = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGenero)).BeginInit();
            this.SuspendLayout();
            // 
            // tbBuscarGenero
            // 
            this.tbBuscarGenero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBuscarGenero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tbBuscarGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbBuscarGenero.Location = new System.Drawing.Point(52, 47);
            this.tbBuscarGenero.Name = "tbBuscarGenero";
            this.tbBuscarGenero.Size = new System.Drawing.Size(343, 23);
            this.tbBuscarGenero.TabIndex = 1;
            this.tbBuscarGenero.Text = "Digite o gênero do produto ...";
            this.tbBuscarGenero.Enter += new System.EventHandler(this.tbBuscarGenero_Enter);
            this.tbBuscarGenero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscarGenero_KeyPress);
            this.tbBuscarGenero.Leave += new System.EventHandler(this.tbBuscarGenero_Leave);
            // 
            // panelBuscarGenero
            // 
            this.panelBuscarGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelBuscarGenero.Location = new System.Drawing.Point(12, 70);
            this.panelBuscarGenero.Name = "panelBuscarGenero";
            this.panelBuscarGenero.Size = new System.Drawing.Size(383, 2);
            this.panelBuscarGenero.TabIndex = 6;
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btBuscar.FlatAppearance.BorderSize = 0;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBuscar.Location = new System.Drawing.Point(401, 30);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(130, 42);
            this.btBuscar.TabIndex = 7;
            this.btBuscar.Text = "F5 Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // dgvGenero
            // 
            this.dgvGenero.AllowUserToAddRows = false;
            this.dgvGenero.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dgvGenero.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGenero.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGenero.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenero.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoGenero,
            this.nomeGenero});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGenero.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGenero.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvGenero.Location = new System.Drawing.Point(12, 78);
            this.dgvGenero.Name = "dgvGenero";
            this.dgvGenero.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.dgvGenero.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGenero.RowTemplate.Height = 24;
            this.dgvGenero.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGenero.Size = new System.Drawing.Size(538, 427);
            this.dgvGenero.TabIndex = 8;
            this.dgvGenero.DoubleClick += new System.EventHandler(this.dgvGenero_DoubleClick);
            // 
            // codigoGenero
            // 
            this.codigoGenero.HeaderText = "Cód";
            this.codigoGenero.Name = "codigoGenero";
            this.codigoGenero.ReadOnly = true;
            this.codigoGenero.ToolTipText = "Código Gênero";
            // 
            // nomeGenero
            // 
            this.nomeGenero.HeaderText = "Genero";
            this.nomeGenero.Name = "nomeGenero";
            this.nomeGenero.ReadOnly = true;
            this.nomeGenero.ToolTipText = "Nome Gênero";
            this.nomeGenero.Width = 240;
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.Turquoise;
            this.btCadastrar.FlatAppearance.BorderSize = 0;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCadastrar.Location = new System.Drawing.Point(148, 511);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(130, 42);
            this.btCadastrar.TabIndex = 9;
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
            this.btSelecionar.Location = new System.Drawing.Point(12, 511);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(130, 42);
            this.btSelecionar.TabIndex = 10;
            this.btSelecionar.Text = "F2 Selecionar";
            this.btSelecionar.UseVisualStyleBackColor = false;
            this.btSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.BackColor = System.Drawing.Color.DeepPink;
            this.btAlterar.FlatAppearance.BorderSize = 0;
            this.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlterar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btAlterar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAlterar.Location = new System.Drawing.Point(284, 511);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(130, 42);
            this.btAlterar.TabIndex = 11;
            this.btAlterar.Text = "F4 Alterar";
            this.btAlterar.UseVisualStyleBackColor = false;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Red;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSair.Location = new System.Drawing.Point(420, 511);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(130, 42);
            this.btSair.TabIndex = 12;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // pbGenero
            // 
            this.pbGenero.Image = global::Apresentacao.Properties.Resources.GeneroAzul;
            this.pbGenero.Location = new System.Drawing.Point(12, 43);
            this.pbGenero.Name = "pbGenero";
            this.pbGenero.Size = new System.Drawing.Size(34, 26);
            this.pbGenero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGenero.TabIndex = 0;
            this.pbGenero.TabStop = false;
            // 
            // FrmSelecionarGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(560, 573);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.dgvGenero);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.panelBuscarGenero);
            this.Controls.Add(this.tbBuscarGenero);
            this.Controls.Add(this.pbGenero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmSelecionarGenero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gênero Produto";
            this.Load += new System.EventHandler(this.FrmSelecionarGenero_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSelecionarGenero_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGenero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGenero;
        private System.Windows.Forms.TextBox tbBuscarGenero;
        private System.Windows.Forms.Panel panelBuscarGenero;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.DataGridView dgvGenero;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btSelecionar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeGenero;
    }
}