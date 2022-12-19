namespace Apresentacao
{
    partial class FrmSangria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSangria));
            this.dgvSangria = new System.Windows.Forms.DataGridView();
            this.ordemSangria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSangria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionarioSangria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusSangria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.painelSangria = new System.Windows.Forms.Panel();
            this.lbTituloSangria = new System.Windows.Forms.Label();
            this.lbSangria = new System.Windows.Forms.Label();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.lbDataInicial = new System.Windows.Forms.Label();
            this.lbDataFinal = new System.Windows.Forms.Label();
            this.pbFiltrar = new System.Windows.Forms.PictureBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.panelBuscarFuncionario = new System.Windows.Forms.Panel();
            this.tbBuscarFuncionario = new System.Windows.Forms.TextBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btSelecionar = new System.Windows.Forms.Button();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.pbFuncionario = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pbBuscarFuncionario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSangria)).BeginInit();
            this.painelSangria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiltrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSangria
            // 
            this.dgvSangria.AllowUserToAddRows = false;
            this.dgvSangria.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dgvSangria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSangria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvSangria.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSangria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSangria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSangria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ordemSangria,
            this.dataSangria,
            this.codigoFuncionario,
            this.funcionarioSangria,
            this.estatusSangria});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSangria.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSangria.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvSangria.Location = new System.Drawing.Point(9, 65);
            this.dgvSangria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvSangria.Name = "dgvSangria";
            this.dgvSangria.ReadOnly = true;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.dgvSangria.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSangria.RowTemplate.Height = 24;
            this.dgvSangria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSangria.Size = new System.Drawing.Size(796, 344);
            this.dgvSangria.TabIndex = 0;
            this.dgvSangria.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSangria_CellDoubleClick);
            // 
            // ordemSangria
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ordemSangria.DefaultCellStyle = dataGridViewCellStyle3;
            this.ordemSangria.HeaderText = "Ordem";
            this.ordemSangria.Name = "ordemSangria";
            this.ordemSangria.ReadOnly = true;
            this.ordemSangria.ToolTipText = "Ordenação das sangrias";
            this.ordemSangria.Width = 60;
            // 
            // dataSangria
            // 
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.dataSangria.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataSangria.HeaderText = "Data";
            this.dataSangria.Name = "dataSangria";
            this.dataSangria.ReadOnly = true;
            this.dataSangria.ToolTipText = "Data da Sangria";
            this.dataSangria.Width = 70;
            // 
            // codigoFuncionario
            // 
            this.codigoFuncionario.HeaderText = "Cod.Func";
            this.codigoFuncionario.Name = "codigoFuncionario";
            this.codigoFuncionario.ReadOnly = true;
            this.codigoFuncionario.ToolTipText = "Código do funcionario";
            this.codigoFuncionario.Visible = false;
            // 
            // funcionarioSangria
            // 
            this.funcionarioSangria.HeaderText = "Funcionario";
            this.funcionarioSangria.Name = "funcionarioSangria";
            this.funcionarioSangria.ReadOnly = true;
            this.funcionarioSangria.ToolTipText = "Nome do Funcionário";
            this.funcionarioSangria.Width = 220;
            // 
            // estatusSangria
            // 
            this.estatusSangria.HeaderText = "Estatus";
            this.estatusSangria.Name = "estatusSangria";
            this.estatusSangria.ReadOnly = true;
            this.estatusSangria.ToolTipText = "Estatus do recebimento da Sangria";
            // 
            // painelSangria
            // 
            this.painelSangria.AutoScroll = true;
            this.painelSangria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.painelSangria.Controls.Add(this.lbTituloSangria);
            this.painelSangria.Controls.Add(this.lbSangria);
            this.painelSangria.Location = new System.Drawing.Point(656, 414);
            this.painelSangria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.painelSangria.Name = "painelSangria";
            this.painelSangria.Size = new System.Drawing.Size(149, 60);
            this.painelSangria.TabIndex = 14;
            // 
            // lbTituloSangria
            // 
            this.lbTituloSangria.AutoSize = true;
            this.lbTituloSangria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTituloSangria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTituloSangria.Location = new System.Drawing.Point(2, 6);
            this.lbTituloSangria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTituloSangria.Name = "lbTituloSangria";
            this.lbTituloSangria.Size = new System.Drawing.Size(122, 19);
            this.lbTituloSangria.TabIndex = 0;
            this.lbTituloSangria.Text = "Total Sangria +";
            this.lbTituloSangria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSangria
            // 
            this.lbSangria.AutoSize = true;
            this.lbSangria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbSangria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSangria.Location = new System.Drawing.Point(21, 32);
            this.lbSangria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSangria.Name = "lbSangria";
            this.lbSangria.Size = new System.Drawing.Size(65, 19);
            this.lbSangria.TabIndex = 1;
            this.lbSangria.Text = "R$ 0,00";
            this.lbSangria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpDataInicial.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dtpDataInicial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(502, 34);
            this.dtpDataInicial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(138, 26);
            this.dtpDataInicial.TabIndex = 155;
            // 
            // lbDataInicial
            // 
            this.lbDataInicial.AutoSize = true;
            this.lbDataInicial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbDataInicial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lbDataInicial.Location = new System.Drawing.Point(499, 12);
            this.lbDataInicial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDataInicial.Name = "lbDataInicial";
            this.lbDataInicial.Size = new System.Drawing.Size(92, 19);
            this.lbDataInicial.TabIndex = 154;
            this.lbDataInicial.Text = "Data Inicial";
            // 
            // lbDataFinal
            // 
            this.lbDataFinal.AutoSize = true;
            this.lbDataFinal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbDataFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lbDataFinal.Location = new System.Drawing.Point(640, 12);
            this.lbDataFinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDataFinal.Name = "lbDataFinal";
            this.lbDataFinal.Size = new System.Drawing.Size(85, 19);
            this.lbDataFinal.TabIndex = 156;
            this.lbDataFinal.Text = "Data Final";
            // 
            // pbFiltrar
            // 
            this.pbFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFiltrar.Image = global::Apresentacao.Properties.Resources.FiltroImg;
            this.pbFiltrar.Location = new System.Drawing.Point(785, 34);
            this.pbFiltrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbFiltrar.Name = "pbFiltrar";
            this.pbFiltrar.Size = new System.Drawing.Size(21, 25);
            this.pbFiltrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFiltrar.TabIndex = 158;
            this.pbFiltrar.TabStop = false;
            this.toolTip.SetToolTip(this.pbFiltrar, "Clique para buscar sangrias por Data");
            this.pbFiltrar.Click += new System.EventHandler(this.pbFiltrar_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btBuscar.FlatAppearance.BorderSize = 0;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBuscar.Location = new System.Drawing.Point(326, 26);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(98, 34);
            this.btBuscar.TabIndex = 160;
            this.btBuscar.Text = "F5 Buscar";
            this.toolTip.SetToolTip(this.btBuscar, "Clique para buscar sangrias");
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // panelBuscarFuncionario
            // 
            this.panelBuscarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelBuscarFuncionario.Location = new System.Drawing.Point(9, 58);
            this.panelBuscarFuncionario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBuscarFuncionario.Name = "panelBuscarFuncionario";
            this.panelBuscarFuncionario.Size = new System.Drawing.Size(287, 2);
            this.panelBuscarFuncionario.TabIndex = 162;
            // 
            // tbBuscarFuncionario
            // 
            this.tbBuscarFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBuscarFuncionario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.tbBuscarFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbBuscarFuncionario.Location = new System.Drawing.Point(39, 40);
            this.tbBuscarFuncionario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbBuscarFuncionario.Name = "tbBuscarFuncionario";
            this.tbBuscarFuncionario.Size = new System.Drawing.Size(257, 19);
            this.tbBuscarFuncionario.TabIndex = 159;
            this.tbBuscarFuncionario.Text = "Digite o nome do funcionário ...";
            this.tbBuscarFuncionario.Enter += new System.EventHandler(this.tbBuscarFuncionario_Enter);
            this.tbBuscarFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscarFuncionario_KeyPress);
            this.tbBuscarFuncionario.Leave += new System.EventHandler(this.tbBuscarFuncionario_Leave);
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.Turquoise;
            this.btCadastrar.FlatAppearance.BorderSize = 0;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCadastrar.Location = new System.Drawing.Point(9, 440);
            this.btCadastrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(98, 34);
            this.btCadastrar.TabIndex = 164;
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
            this.btSair.Location = new System.Drawing.Point(213, 440);
            this.btSair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(98, 34);
            this.btSair.TabIndex = 166;
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
            this.btSelecionar.Location = new System.Drawing.Point(111, 440);
            this.btSelecionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(98, 34);
            this.btSelecionar.TabIndex = 167;
            this.btSelecionar.Text = "F2 Selecionar";
            this.btSelecionar.UseVisualStyleBackColor = false;
            this.btSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpDataFinal.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dtpDataFinal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(644, 34);
            this.dtpDataFinal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(138, 26);
            this.dtpDataFinal.TabIndex = 157;
            // 
            // pbFuncionario
            // 
            this.pbFuncionario.Image = global::Apresentacao.Properties.Resources.FuncionarioAzul;
            this.pbFuncionario.Location = new System.Drawing.Point(9, 28);
            this.pbFuncionario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbFuncionario.Name = "pbFuncionario";
            this.pbFuncionario.Size = new System.Drawing.Size(26, 29);
            this.pbFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFuncionario.TabIndex = 163;
            this.pbFuncionario.TabStop = false;
            this.pbFuncionario.Tag = "";
            this.toolTip.SetToolTip(this.pbFuncionario, "Clique para buscar funcionario");
            this.pbFuncionario.Click += new System.EventHandler(this.pbFuncionario_Click);
            // 
            // pbBuscarFuncionario
            // 
            this.pbBuscarFuncionario.Image = global::Apresentacao.Properties.Resources.Selecionar;
            this.pbBuscarFuncionario.Location = new System.Drawing.Point(301, 38);
            this.pbBuscarFuncionario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbBuscarFuncionario.Name = "pbBuscarFuncionario";
            this.pbBuscarFuncionario.Size = new System.Drawing.Size(20, 22);
            this.pbBuscarFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscarFuncionario.TabIndex = 168;
            this.pbBuscarFuncionario.TabStop = false;
            this.pbBuscarFuncionario.Click += new System.EventHandler(this.pbBuscarFuncionario_Click);
            // 
            // FrmSangria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(818, 483);
            this.Controls.Add(this.pbBuscarFuncionario);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.panelBuscarFuncionario);
            this.Controls.Add(this.tbBuscarFuncionario);
            this.Controls.Add(this.pbFuncionario);
            this.Controls.Add(this.dtpDataInicial);
            this.Controls.Add(this.lbDataInicial);
            this.Controls.Add(this.lbDataFinal);
            this.Controls.Add(this.dtpDataFinal);
            this.Controls.Add(this.pbFiltrar);
            this.Controls.Add(this.painelSangria);
            this.Controls.Add(this.dgvSangria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmSangria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sangria";
            this.Load += new System.EventHandler(this.FrmSangria_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSangria_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSangria)).EndInit();
            this.painelSangria.ResumeLayout(false);
            this.painelSangria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiltrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSangria;
        private System.Windows.Forms.Panel painelSangria;
        private System.Windows.Forms.Label lbTituloSangria;
        private System.Windows.Forms.Label lbSangria;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.Label lbDataInicial;
        private System.Windows.Forms.Label lbDataFinal;
        private System.Windows.Forms.PictureBox pbFiltrar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Panel panelBuscarFuncionario;
        private System.Windows.Forms.TextBox tbBuscarFuncionario;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btSelecionar;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.PictureBox pbFuncionario;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordemSangria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSangria;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcionarioSangria;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusSangria;
        private System.Windows.Forms.PictureBox pbBuscarFuncionario;
    }
}