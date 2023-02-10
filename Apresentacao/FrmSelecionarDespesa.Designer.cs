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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelecionarDespesa));
            this.btSair = new System.Windows.Forms.Button();
            this.btSelecionar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.panelBuscarGenero = new System.Windows.Forms.Panel();
            this.tbBuscarDespesa = new System.Windows.Forms.TextBox();
            this.dgvDespesas = new System.Windows.Forms.DataGridView();
            this.descricaoDespesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDespesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagamentoDespesa = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.contador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoFormaPagamentoSelecionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDespesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.lbDataInicial = new System.Windows.Forms.Label();
            this.lbDataFinal = new System.Windows.Forms.Label();
            this.pbFiltrar = new System.Windows.Forms.PictureBox();
            this.pbDespesa = new System.Windows.Forms.PictureBox();
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
            this.btSair.Location = new System.Drawing.Point(556, 413);
            this.btSair.Margin = new System.Windows.Forms.Padding(2);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(98, 34);
            this.btSair.TabIndex = 21;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = false;
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
            this.btSelecionar.TabIndex = 19;
            this.btSelecionar.Text = "F2 Selecionar";
            this.btSelecionar.UseVisualStyleBackColor = false;
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
            this.btCadastrar.TabIndex = 18;
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
            this.btBuscar.TabIndex = 16;
            this.btBuscar.Text = "F5 Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            // 
            // panelBuscarGenero
            // 
            this.panelBuscarGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelBuscarGenero.Location = new System.Drawing.Point(11, 55);
            this.panelBuscarGenero.Margin = new System.Windows.Forms.Padding(2);
            this.panelBuscarGenero.Name = "panelBuscarGenero";
            this.panelBuscarGenero.Size = new System.Drawing.Size(287, 2);
            this.panelBuscarGenero.TabIndex = 15;
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
            this.tbBuscarDespesa.TabIndex = 14;
            this.tbBuscarDespesa.Text = "Digite o nome da despesa ...";
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
            this.descricaoDespesa,
            this.valorDespesa,
            this.formaPagamentoDespesa,
            this.contador,
            this.codigoFormaPagamentoSelecionado,
            this.dataDespesa});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDespesas.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDespesas.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDespesas.Location = new System.Drawing.Point(11, 61);
            this.dgvDespesas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDespesas.Name = "dgvDespesas";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.dgvDespesas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDespesas.RowTemplate.Height = 24;
            this.dgvDespesas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDespesas.Size = new System.Drawing.Size(643, 348);
            this.dgvDespesas.TabIndex = 256;
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
            this.valorDespesa.HeaderText = "Valor R$";
            this.valorDespesa.Name = "valorDespesa";
            this.valorDespesa.ToolTipText = "valor da despesa";
            // 
            // formaPagamentoDespesa
            // 
            this.formaPagamentoDespesa.HeaderText = "Pagamento";
            this.formaPagamentoDespesa.Name = "formaPagamentoDespesa";
            this.formaPagamentoDespesa.ToolTipText = "Forma de Pagamento da Despesa";
            this.formaPagamentoDespesa.Width = 140;
            // 
            // contador
            // 
            this.contador.HeaderText = "contador";
            this.contador.Name = "contador";
            this.contador.Visible = false;
            // 
            // codigoFormaPagamentoSelecionado
            // 
            this.codigoFormaPagamentoSelecionado.HeaderText = "codigoFormaPagamento";
            this.codigoFormaPagamentoSelecionado.Name = "codigoFormaPagamentoSelecionado";
            this.codigoFormaPagamentoSelecionado.Visible = false;
            // 
            // dataDespesa
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.dataDespesa.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataDespesa.HeaderText = "Data";
            this.dataDespesa.Name = "dataDespesa";
            this.dataDespesa.Width = 80;
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dtpDataInicial.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(438, 33);
            this.dtpDataInicial.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(94, 23);
            this.dtpDataInicial.TabIndex = 258;
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dtpDataFinal.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(535, 33);
            this.dtpDataFinal.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(94, 23);
            this.dtpDataFinal.TabIndex = 260;
            // 
            // lbDataInicial
            // 
            this.lbDataInicial.AutoSize = true;
            this.lbDataInicial.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lbDataInicial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lbDataInicial.Location = new System.Drawing.Point(434, 11);
            this.lbDataInicial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDataInicial.Name = "lbDataInicial";
            this.lbDataInicial.Size = new System.Drawing.Size(78, 20);
            this.lbDataInicial.TabIndex = 257;
            this.lbDataInicial.Text = "Data Inicial";
            // 
            // lbDataFinal
            // 
            this.lbDataFinal.AutoSize = true;
            this.lbDataFinal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lbDataFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lbDataFinal.Location = new System.Drawing.Point(531, 11);
            this.lbDataFinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDataFinal.Name = "lbDataFinal";
            this.lbDataFinal.Size = new System.Drawing.Size(71, 20);
            this.lbDataFinal.TabIndex = 259;
            this.lbDataFinal.Text = "Data Final";
            // 
            // pbFiltrar
            // 
            this.pbFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFiltrar.Image = global::Apresentacao.Properties.Resources.FiltroImg;
            this.pbFiltrar.Location = new System.Drawing.Point(633, 34);
            this.pbFiltrar.Margin = new System.Windows.Forms.Padding(2);
            this.pbFiltrar.Name = "pbFiltrar";
            this.pbFiltrar.Size = new System.Drawing.Size(21, 22);
            this.pbFiltrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFiltrar.TabIndex = 261;
            this.pbFiltrar.TabStop = false;
            // 
            // pbDespesa
            // 
            this.pbDespesa.Image = global::Apresentacao.Properties.Resources.DespesasPequena;
            this.pbDespesa.Location = new System.Drawing.Point(11, 33);
            this.pbDespesa.Margin = new System.Windows.Forms.Padding(2);
            this.pbDespesa.Name = "pbDespesa";
            this.pbDespesa.Size = new System.Drawing.Size(26, 21);
            this.pbDespesa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDespesa.TabIndex = 13;
            this.pbDespesa.TabStop = false;
            // 
            // FrmSelecionarDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(668, 459);
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
            this.Controls.Add(this.panelBuscarGenero);
            this.Controls.Add(this.tbBuscarDespesa);
            this.Controls.Add(this.pbDespesa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmSelecionarDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Despesas";
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
        private System.Windows.Forms.Panel panelBuscarGenero;
        private System.Windows.Forms.TextBox tbBuscarDespesa;
        private System.Windows.Forms.PictureBox pbDespesa;
        private System.Windows.Forms.DataGridView dgvDespesas;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDespesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDespesa;
        private System.Windows.Forms.DataGridViewComboBoxColumn formaPagamentoDespesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn contador;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoFormaPagamentoSelecionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDespesa;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.PictureBox pbFiltrar;
        private System.Windows.Forms.Label lbDataInicial;
        private System.Windows.Forms.Label lbDataFinal;
    }
}