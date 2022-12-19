namespace Apresentacao
{
    partial class FrmSelecionarGrade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelecionarGrade));
            this.tbBuscarGrade = new System.Windows.Forms.TextBox();
            this.panelBuscarGrade = new System.Windows.Forms.Panel();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btSelecionar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.dgvGrade = new System.Windows.Forms.DataGridView();
            this.codigoGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbGrade = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // tbBuscarGrade
            // 
            this.tbBuscarGrade.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbBuscarGrade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBuscarGrade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tbBuscarGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbBuscarGrade.Location = new System.Drawing.Point(52, 47);
            this.tbBuscarGrade.Name = "tbBuscarGrade";
            this.tbBuscarGrade.Size = new System.Drawing.Size(343, 23);
            this.tbBuscarGrade.TabIndex = 0;
            this.tbBuscarGrade.Text = "Digite a grade do produto ...";
            this.tbBuscarGrade.Enter += new System.EventHandler(this.tbBuscarGrade_Enter);
            this.tbBuscarGrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscarGrade_KeyPress);
            this.tbBuscarGrade.Leave += new System.EventHandler(this.tbBuscarGrade_Leave);
            // 
            // panelBuscarGrade
            // 
            this.panelBuscarGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelBuscarGrade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelBuscarGrade.Location = new System.Drawing.Point(12, 70);
            this.panelBuscarGrade.Name = "panelBuscarGrade";
            this.panelBuscarGrade.Size = new System.Drawing.Size(383, 2);
            this.panelBuscarGrade.TabIndex = 6;
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btBuscar.FlatAppearance.BorderSize = 0;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBuscar.Location = new System.Drawing.Point(401, 32);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(130, 42);
            this.btBuscar.TabIndex = 1;
            this.btBuscar.Text = "F5 Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
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
            this.btSelecionar.TabIndex = 3;
            this.btSelecionar.Text = "F2 Selecionar";
            this.btSelecionar.UseVisualStyleBackColor = false;
            this.btSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
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
            this.btCadastrar.TabIndex = 4;
            this.btCadastrar.Text = "F10 Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
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
            this.btAlterar.TabIndex = 5;
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
            this.btSair.TabIndex = 6;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // dgvGrade
            // 
            this.dgvGrade.AllowUserToAddRows = false;
            this.dgvGrade.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dgvGrade.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGrade.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGrade.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoGrade,
            this.nomeGrade});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGrade.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGrade.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvGrade.Location = new System.Drawing.Point(12, 78);
            this.dgvGrade.Name = "dgvGrade";
            this.dgvGrade.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.dgvGrade.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGrade.RowTemplate.Height = 24;
            this.dgvGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrade.Size = new System.Drawing.Size(538, 427);
            this.dgvGrade.TabIndex = 2;
            this.dgvGrade.DoubleClick += new System.EventHandler(this.dgvGrade_DoubleClick);
            // 
            // codigoGrade
            // 
            this.codigoGrade.HeaderText = "Cód";
            this.codigoGrade.Name = "codigoGrade";
            this.codigoGrade.ReadOnly = true;
            // 
            // nomeGrade
            // 
            this.nomeGrade.HeaderText = "Grade";
            this.nomeGrade.Name = "nomeGrade";
            this.nomeGrade.ReadOnly = true;
            this.nomeGrade.Width = 240;
            // 
            // pbGrade
            // 
            this.pbGrade.Image = global::Apresentacao.Properties.Resources.GradeAzul;
            this.pbGrade.Location = new System.Drawing.Point(12, 32);
            this.pbGrade.Name = "pbGrade";
            this.pbGrade.Size = new System.Drawing.Size(34, 36);
            this.pbGrade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGrade.TabIndex = 0;
            this.pbGrade.TabStop = false;
            // 
            // FrmSelecionarGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(560, 573);
            this.Controls.Add(this.dgvGrade);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.panelBuscarGrade);
            this.Controls.Add(this.tbBuscarGrade);
            this.Controls.Add(this.pbGrade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmSelecionarGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grade";
            this.Load += new System.EventHandler(this.FrmSelecionarGrade_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSelecionarGrade_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGrade;
        private System.Windows.Forms.TextBox tbBuscarGrade;
        private System.Windows.Forms.Panel panelBuscarGrade;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btSelecionar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.DataGridView dgvGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeGrade;
    }
}