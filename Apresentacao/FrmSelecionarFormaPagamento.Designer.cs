namespace Apresentacao
{
    partial class FrmSelecionarFormaPagamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelecionarFormaPagamento));
            this.btExcluir = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.dgvFormaPagamento = new System.Windows.Forms.DataGridView();
            this.codigoFormaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFormaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentagemTaxa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btBuscar = new System.Windows.Forms.Button();
            this.panelBuscarFormaPagamento = new System.Windows.Forms.Panel();
            this.tbBuscarFormaPagamento = new System.Windows.Forms.TextBox();
            this.pbFormaPagamento = new System.Windows.Forms.PictureBox();
            this.btNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormaPagamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormaPagamento)).BeginInit();
            this.SuspendLayout();
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.DeepPink;
            this.btExcluir.FlatAppearance.BorderSize = 0;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btExcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btExcluir.Location = new System.Drawing.Point(284, 488);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(130, 42);
            this.btExcluir.TabIndex = 6;
            this.btExcluir.Text = "F2 Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Red;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSair.Location = new System.Drawing.Point(420, 488);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(130, 42);
            this.btSair.TabIndex = 7;
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
            this.btCadastrar.Location = new System.Drawing.Point(148, 488);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(130, 42);
            this.btCadastrar.TabIndex = 5;
            this.btCadastrar.Text = "F10 Salvar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // dgvFormaPagamento
            // 
            this.dgvFormaPagamento.AllowUserToAddRows = false;
            this.dgvFormaPagamento.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dgvFormaPagamento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFormaPagamento.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFormaPagamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFormaPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormaPagamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoFormaPagamento,
            this.nomeFormaPagamento,
            this.porcentagemTaxa,
            this.contador});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFormaPagamento.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFormaPagamento.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvFormaPagamento.Location = new System.Drawing.Point(12, 55);
            this.dgvFormaPagamento.Name = "dgvFormaPagamento";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.dgvFormaPagamento.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFormaPagamento.RowTemplate.Height = 24;
            this.dgvFormaPagamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFormaPagamento.Size = new System.Drawing.Size(538, 427);
            this.dgvFormaPagamento.TabIndex = 3;
            this.dgvFormaPagamento.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvFormaPagamento_CellValidating);
            // 
            // codigoFormaPagamento
            // 
            dataGridViewCellStyle3.NullValue = null;
            this.codigoFormaPagamento.DefaultCellStyle = dataGridViewCellStyle3;
            this.codigoFormaPagamento.HeaderText = "Cód";
            this.codigoFormaPagamento.Name = "codigoFormaPagamento";
            this.codigoFormaPagamento.ReadOnly = true;
            this.codigoFormaPagamento.ToolTipText = "Código da Forma de Pagamento";
            this.codigoFormaPagamento.Visible = false;
            this.codigoFormaPagamento.Width = 50;
            // 
            // nomeFormaPagamento
            // 
            this.nomeFormaPagamento.HeaderText = "Pagamento";
            this.nomeFormaPagamento.Name = "nomeFormaPagamento";
            this.nomeFormaPagamento.ToolTipText = "Forma de Pagamento";
            this.nomeFormaPagamento.Width = 220;
            // 
            // porcentagemTaxa
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.porcentagemTaxa.DefaultCellStyle = dataGridViewCellStyle4;
            this.porcentagemTaxa.HeaderText = "Taxa %";
            this.porcentagemTaxa.Name = "porcentagemTaxa";
            this.porcentagemTaxa.ToolTipText = "Valor da Taxa";
            this.porcentagemTaxa.Width = 110;
            // 
            // contador
            // 
            this.contador.HeaderText = "contador";
            this.contador.Name = "contador";
            this.contador.Visible = false;
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btBuscar.FlatAppearance.BorderSize = 0;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBuscar.Location = new System.Drawing.Point(401, 7);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(130, 42);
            this.btBuscar.TabIndex = 1;
            this.btBuscar.Text = "F5 Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // panelBuscarFormaPagamento
            // 
            this.panelBuscarFormaPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelBuscarFormaPagamento.Location = new System.Drawing.Point(12, 47);
            this.panelBuscarFormaPagamento.Name = "panelBuscarFormaPagamento";
            this.panelBuscarFormaPagamento.Size = new System.Drawing.Size(383, 2);
            this.panelBuscarFormaPagamento.TabIndex = 2;
            // 
            // tbBuscarFormaPagamento
            // 
            this.tbBuscarFormaPagamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBuscarFormaPagamento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tbBuscarFormaPagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbBuscarFormaPagamento.Location = new System.Drawing.Point(52, 24);
            this.tbBuscarFormaPagamento.Name = "tbBuscarFormaPagamento";
            this.tbBuscarFormaPagamento.Size = new System.Drawing.Size(343, 23);
            this.tbBuscarFormaPagamento.TabIndex = 0;
            this.tbBuscarFormaPagamento.Text = "Digite a Forma de Pagamento ...";
            this.tbBuscarFormaPagamento.Enter += new System.EventHandler(this.tbBuscarFormaPagamento_Enter);
            this.tbBuscarFormaPagamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscarFormaPagamento_KeyPress);
            this.tbBuscarFormaPagamento.Leave += new System.EventHandler(this.tbBuscarFormaPagamento_Leave);
            // 
            // pbFormaPagamento
            // 
            this.pbFormaPagamento.Image = global::Apresentacao.Properties.Resources.TaxaIAzul;
            this.pbFormaPagamento.Location = new System.Drawing.Point(12, 9);
            this.pbFormaPagamento.Name = "pbFormaPagamento";
            this.pbFormaPagamento.Size = new System.Drawing.Size(34, 36);
            this.pbFormaPagamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFormaPagamento.TabIndex = 9;
            this.pbFormaPagamento.TabStop = false;
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btNovo.FlatAppearance.BorderSize = 0;
            this.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNovo.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btNovo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btNovo.Location = new System.Drawing.Point(12, 488);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(130, 42);
            this.btNovo.TabIndex = 4;
            this.btNovo.Text = "Ent Novo";
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // FrmSelecionarFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(568, 542);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.dgvFormaPagamento);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.panelBuscarFormaPagamento);
            this.Controls.Add(this.tbBuscarFormaPagamento);
            this.Controls.Add(this.pbFormaPagamento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmSelecionarFormaPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forma de Pagamento";
            this.Load += new System.EventHandler(this.FrmSelecionarFormaPagamento_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSelecionarFormaPagamento_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormaPagamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormaPagamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.DataGridView dgvFormaPagamento;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Panel panelBuscarFormaPagamento;
        private System.Windows.Forms.TextBox tbBuscarFormaPagamento;
        private System.Windows.Forms.PictureBox pbFormaPagamento;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoFormaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFormaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentagemTaxa;
        private System.Windows.Forms.DataGridViewTextBoxColumn contador;
    }
}