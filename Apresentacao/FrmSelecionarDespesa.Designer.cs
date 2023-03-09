namespace Apresentacao
{
    partial class FrmSelecionarDespesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelecionarDespesa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btSair = new System.Windows.Forms.Button();
            this.btSelecionar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.panelBuscarDespesa = new System.Windows.Forms.Panel();
            this.tbBuscarDespesa = new System.Windows.Forms.TextBox();
            this.dgvDespesas = new System.Windows.Forms.DataGridView();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.lbDataInicial = new System.Windows.Forms.Label();
            this.lbDataFinal = new System.Windows.Forms.Label();
            this.pbFiltrar = new System.Windows.Forms.PictureBox();
            this.pbDespesa = new System.Windows.Forms.PictureBox();
            this.codigoDespesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDespesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDespesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionarioDespesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagamentoDespesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoFormaPagamentoSelecionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDespesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiltrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDespesa)).BeginInit();
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Red;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSair.Location = new System.Drawing.Point(721, 414);
            this.btSair.Margin = new System.Windows.Forms.Padding(2);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(98, 34);
            this.btSair.TabIndex = 9;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btSelecionar
            // 
            this.btSelecionar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btSelecionar.FlatAppearance.BorderSize = 0;
            this.btSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSelecionar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSelecionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSelecionar.Location = new System.Drawing.Point(11, 413);
            this.btSelecionar.Margin = new System.Windows.Forms.Padding(2);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(98, 34);
            this.btSelecionar.TabIndex = 7;
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
            this.btCadastrar.Location = new System.Drawing.Point(113, 413);
            this.btCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(98, 34);
            this.btCadastrar.TabIndex = 8;
            this.btCadastrar.Text = "F10 Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btBuscar.FlatAppearance.BorderSize = 0;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBuscar.Location = new System.Drawing.Point(303, 22);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(98, 34);
            this.btBuscar.TabIndex = 1;
            this.btBuscar.Text = "F5 Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // panelBuscarDespesa
            // 
            this.panelBuscarDespesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelBuscarDespesa.Location = new System.Drawing.Point(11, 55);
            this.panelBuscarDespesa.Margin = new System.Windows.Forms.Padding(2);
            this.panelBuscarDespesa.Name = "panelBuscarDespesa";
            this.panelBuscarDespesa.Size = new System.Drawing.Size(287, 2);
            this.panelBuscarDespesa.TabIndex = 15;
            // 
            // tbBuscarDespesa
            // 
            this.tbBuscarDespesa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBuscarDespesa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tbBuscarDespesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbBuscarDespesa.Location = new System.Drawing.Point(41, 36);
            this.tbBuscarDespesa.Margin = new System.Windows.Forms.Padding(2);
            this.tbBuscarDespesa.Name = "tbBuscarDespesa";
            this.tbBuscarDespesa.Size = new System.Drawing.Size(257, 19);
            this.tbBuscarDespesa.TabIndex = 0;
            this.tbBuscarDespesa.Text = "Digite a descrição da Despesa ...";
            this.tbBuscarDespesa.Enter += new System.EventHandler(this.tbBuscarDespesa_Enter);
            this.tbBuscarDespesa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscarDespesa_KeyPress);
            this.tbBuscarDespesa.Leave += new System.EventHandler(this.tbBuscarDespesa_Leave);
            // 
            // dgvDespesas
            // 
            this.dgvDespesas.AllowUserToAddRows = false;
            this.dgvDespesas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dgvDespesas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDespesas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDespesas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDespesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDespesas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDespesa,
            this.descricaoDespesa,
            this.valorDespesa,
            this.funcionarioDespesa,
            this.formaPagamentoDespesa,
            this.codigoFormaPagamentoSelecionado,
            this.dataDespesa});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDespesas.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDespesas.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDespesas.Location = new System.Drawing.Point(11, 61);
            this.dgvDespesas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDespesas.Name = "dgvDespesas";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.dgvDespesas.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDespesas.RowTemplate.Height = 24;
            this.dgvDespesas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDespesas.Size = new System.Drawing.Size(808, 348);
            this.dgvDespesas.TabIndex = 6;
            this.dgvDespesas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDespesas_CellDoubleClick);
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dtpDataInicial.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(603, 33);
            this.dtpDataInicial.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(94, 23);
            this.dtpDataInicial.TabIndex = 4;
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dtpDataFinal.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(700, 33);
            this.dtpDataFinal.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(94, 23);
            this.dtpDataFinal.TabIndex = 5;
            // 
            // lbDataInicial
            // 
            this.lbDataInicial.AutoSize = true;
            this.lbDataInicial.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lbDataInicial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lbDataInicial.Location = new System.Drawing.Point(599, 11);
            this.lbDataInicial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDataInicial.Name = "lbDataInicial";
            this.lbDataInicial.Size = new System.Drawing.Size(78, 20);
            this.lbDataInicial.TabIndex = 2;
            this.lbDataInicial.Text = "Data Inicial";
            // 
            // lbDataFinal
            // 
            this.lbDataFinal.AutoSize = true;
            this.lbDataFinal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lbDataFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lbDataFinal.Location = new System.Drawing.Point(696, 11);
            this.lbDataFinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDataFinal.Name = "lbDataFinal";
            this.lbDataFinal.Size = new System.Drawing.Size(71, 20);
            this.lbDataFinal.TabIndex = 3;
            this.lbDataFinal.Text = "Data Final";
            // 
            // pbFiltrar
            // 
            this.pbFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("pbFiltrar.Image")));
            this.pbFiltrar.Location = new System.Drawing.Point(798, 34);
            this.pbFiltrar.Margin = new System.Windows.Forms.Padding(2);
            this.pbFiltrar.Name = "pbFiltrar";
            this.pbFiltrar.Size = new System.Drawing.Size(21, 22);
            this.pbFiltrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFiltrar.TabIndex = 261;
            this.pbFiltrar.TabStop = false;
            this.pbFiltrar.Click += new System.EventHandler(this.pbFiltrar_Click);
            // 
            // pbDespesa
            // 
            this.pbDespesa.Image = ((System.Drawing.Image)(resources.GetObject("pbDespesa.Image")));
            this.pbDespesa.Location = new System.Drawing.Point(11, 33);
            this.pbDespesa.Margin = new System.Windows.Forms.Padding(2);
            this.pbDespesa.Name = "pbDespesa";
            this.pbDespesa.Size = new System.Drawing.Size(26, 21);
            this.pbDespesa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDespesa.TabIndex = 13;
            this.pbDespesa.TabStop = false;
            // 
            // codigoDespesa
            // 
            this.codigoDespesa.HeaderText = "Cód";
            this.codigoDespesa.Name = "codigoDespesa";
            this.codigoDespesa.Width = 50;
            // 
            // descricaoDespesa
            // 
            this.descricaoDespesa.HeaderText = "Descrição";
            this.descricaoDespesa.Name = "descricaoDespesa";
            this.descricaoDespesa.ToolTipText = "Descrição da despesa";
            this.descricaoDespesa.Width = 240;
            // 
            // valorDespesa
            // 
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.valorDespesa.DefaultCellStyle = dataGridViewCellStyle3;
            this.valorDespesa.HeaderText = "Valor R$";
            this.valorDespesa.Name = "valorDespesa";
            this.valorDespesa.ToolTipText = "valor da despesa";
            // 
            // funcionarioDespesa
            // 
            this.funcionarioDespesa.HeaderText = "Funcionário";
            this.funcionarioDespesa.Name = "funcionarioDespesa";
            this.funcionarioDespesa.ToolTipText = "Funcionário realizou pagamento da despesa";
            this.funcionarioDespesa.Width = 140;
            // 
            // formaPagamentoDespesa
            // 
            this.formaPagamentoDespesa.HeaderText = "Pagamento";
            this.formaPagamentoDespesa.Name = "formaPagamentoDespesa";
            this.formaPagamentoDespesa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.formaPagamentoDespesa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.formaPagamentoDespesa.ToolTipText = "Forma de Pagamento da Despesa";
            this.formaPagamentoDespesa.Width = 140;
            // 
            // codigoFormaPagamentoSelecionado
            // 
            this.codigoFormaPagamentoSelecionado.HeaderText = "codigoFormaPagamento";
            this.codigoFormaPagamentoSelecionado.Name = "codigoFormaPagamentoSelecionado";
            this.codigoFormaPagamentoSelecionado.Visible = false;
            // 
            // dataDespesa
            // 
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.dataDespesa.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataDespesa.HeaderText = "Data";
            this.dataDespesa.Name = "dataDespesa";
            this.dataDespesa.Width = 80;
            // 
            // FrmSelecionarDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(832, 459);
            this.Controls.Add(this.dtpDataInicial);
            this.Controls.Add(this.dtpDataFinal);
            this.Controls.Add(this.pbFiltrar);
            this.Controls.Add(this.lbDataInicial);
            this.Controls.Add(this.lbDataFinal);
            this.Controls.Add(this.dgvDespesas);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.panelBuscarDespesa);
            this.Controls.Add(this.tbBuscarDespesa);
            this.Controls.Add(this.pbDespesa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmSelecionarDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Despesas";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSelecionarDespesa_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiltrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDespesa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btSelecionar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Panel panelBuscarDespesa;
        private System.Windows.Forms.TextBox tbBuscarDespesa;
        private System.Windows.Forms.PictureBox pbDespesa;
        private System.Windows.Forms.DataGridView dgvDespesas;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.PictureBox pbFiltrar;
        private System.Windows.Forms.Label lbDataInicial;
        private System.Windows.Forms.Label lbDataFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDespesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDespesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDespesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcionarioDespesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaPagamentoDespesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoFormaPagamentoSelecionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDespesa;
    }
}