namespace Apresentacao
{
    partial class FrmCancelamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCancelamento));
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.pbSelecionarCliente = new System.Windows.Forms.PictureBox();
            this.tbSobrenome = new System.Windows.Forms.TextBox();
            this.pbOk = new System.Windows.Forms.PictureBox();
            this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.tgBloqueio = new CustomControls.RJControls.TouglleControl();
            this.lbEstatus = new System.Windows.Forms.Label();
            this.lbCelular = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbSobrenome = new System.Windows.Forms.Label();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAvisoCancelamento = new System.Windows.Forms.Label();
            this.pbCancelamento = new System.Windows.Forms.PictureBox();
            this.pbFuncionario = new System.Windows.Forms.PictureBox();
            this.panelFuncionario = new System.Windows.Forms.Panel();
            this.btFuncionario = new System.Windows.Forms.Button();
            this.tbFuncionario = new System.Windows.Forms.TextBox();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.panelBuscarCliente = new System.Windows.Forms.Panel();
            this.btCliente = new System.Windows.Forms.Button();
            this.tbBuscarCliente = new System.Windows.Forms.TextBox();
            this.cbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.lbFormaPagamento = new System.Windows.Forms.Label();
            this.pbLimpar = new System.Windows.Forms.PictureBox();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.lbDataInicial = new System.Windows.Forms.Label();
            this.lbDataFinal = new System.Windows.Forms.Label();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.cbCrediarioPago = new System.Windows.Forms.CheckBox();
            this.cbVenda = new System.Windows.Forms.CheckBox();
            this.cbCrediarioPendente = new System.Windows.Forms.CheckBox();
            this.panelEstornoLiquido = new System.Windows.Forms.Panel();
            this.lbTituloEstornoLiquido = new System.Windows.Forms.Label();
            this.lbEstornoLiquido = new System.Windows.Forms.Label();
            this.panelTotalLiquido = new System.Windows.Forms.Panel();
            this.lbTituloTotalLiquido = new System.Windows.Forms.Label();
            this.lbValorLiquido = new System.Windows.Forms.Label();
            this.panelTotalBruto = new System.Windows.Forms.Panel();
            this.lbTituloTotalBruto = new System.Windows.Forms.Label();
            this.lbTotalBruto = new System.Windows.Forms.Label();
            this.painelTaxa = new System.Windows.Forms.Panel();
            this.lbTituloTaxa = new System.Windows.Forms.Label();
            this.lbTaxa = new System.Windows.Forms.Label();
            this.painelDesconto = new System.Windows.Forms.Panel();
            this.lbTituloDesconto = new System.Windows.Forms.Label();
            this.lbDesconto = new System.Windows.Forms.Label();
            this.painelEstorno = new System.Windows.Forms.Panel();
            this.lbTituloEstorno = new System.Windows.Forms.Label();
            this.lbEstorno = new System.Windows.Forms.Label();
            this.panelBuscarProduto = new System.Windows.Forms.Panel();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.painelTotalCrediario = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbValorLiquidoCalculo = new System.Windows.Forms.Label();
            this.panelCalculoVenda = new System.Windows.Forms.Panel();
            this.lbDescontoCalculo = new System.Windows.Forms.Label();
            this.lbJurosCalculo = new System.Windows.Forms.Label();
            this.lbTotalVenda = new System.Windows.Forms.Label();
            this.lbValorBrutoCalculo = new System.Windows.Forms.Label();
            this.dgvVendaCancela = new System.Windows.Forms.DataGridView();
            this.codigoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoFormaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalBrutoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descontoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jurosVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobrenomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobrenomeFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.toolTipItemCancelamento = new System.Windows.Forms.ToolTip(this.components);
            this.btLimpar = new System.Windows.Forms.Button();
            this.gbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelecionarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLimpar)).BeginInit();
            this.panelEstornoLiquido.SuspendLayout();
            this.panelTotalLiquido.SuspendLayout();
            this.panelTotalBruto.SuspendLayout();
            this.painelTaxa.SuspendLayout();
            this.painelDesconto.SuspendLayout();
            this.painelEstorno.SuspendLayout();
            this.gbFiltros.SuspendLayout();
            this.painelTotalCrediario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendaCancela)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.pbSelecionarCliente);
            this.gbCliente.Controls.Add(this.tbSobrenome);
            this.gbCliente.Controls.Add(this.pbOk);
            this.gbCliente.Controls.Add(this.mtbCelular);
            this.gbCliente.Controls.Add(this.tgBloqueio);
            this.gbCliente.Controls.Add(this.lbEstatus);
            this.gbCliente.Controls.Add(this.lbCelular);
            this.gbCliente.Controls.Add(this.tbNome);
            this.gbCliente.Controls.Add(this.lbNome);
            this.gbCliente.Controls.Add(this.lbSobrenome);
            this.gbCliente.Controls.Add(this.mtbCpf);
            this.gbCliente.Controls.Add(this.label1);
            this.gbCliente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.gbCliente.Location = new System.Drawing.Point(9, 99);
            this.gbCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbCliente.Size = new System.Drawing.Size(863, 64);
            this.gbCliente.TabIndex = 160;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // pbSelecionarCliente
            // 
            this.pbSelecionarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSelecionarCliente.Image = global::Apresentacao.Properties.Resources.Selecionar;
            this.pbSelecionarCliente.Location = new System.Drawing.Point(185, 34);
            this.pbSelecionarCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbSelecionarCliente.Name = "pbSelecionarCliente";
            this.pbSelecionarCliente.Size = new System.Drawing.Size(21, 22);
            this.pbSelecionarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSelecionarCliente.TabIndex = 188;
            this.pbSelecionarCliente.TabStop = false;
            this.toolTipItemCancelamento.SetToolTip(this.pbSelecionarCliente, "Selecionar Dados Cliente!");
            this.pbSelecionarCliente.Click += new System.EventHandler(this.pbSelecionarCliente_Click);
            // 
            // tbSobrenome
            // 
            this.tbSobrenome.Enabled = false;
            this.tbSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSobrenome.Location = new System.Drawing.Point(218, 34);
            this.tbSobrenome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSobrenome.Name = "tbSobrenome";
            this.tbSobrenome.Size = new System.Drawing.Size(222, 23);
            this.tbSobrenome.TabIndex = 126;
            // 
            // pbOk
            // 
            this.pbOk.Image = global::Apresentacao.Properties.Resources.DialogErro;
            this.pbOk.Location = new System.Drawing.Point(835, 37);
            this.pbOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbOk.Name = "pbOk";
            this.pbOk.Size = new System.Drawing.Size(17, 19);
            this.pbOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOk.TabIndex = 181;
            this.pbOk.TabStop = false;
            // 
            // mtbCelular
            // 
            this.mtbCelular.Enabled = false;
            this.mtbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCelular.Location = new System.Drawing.Point(598, 34);
            this.mtbCelular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtbCelular.Mask = "(99) 00000-0000";
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.Size = new System.Drawing.Size(137, 23);
            this.mtbCelular.TabIndex = 130;
            this.mtbCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tgBloqueio
            // 
            this.tgBloqueio.AutoSize = true;
            this.tgBloqueio.Enabled = false;
            this.tgBloqueio.Location = new System.Drawing.Point(776, 38);
            this.tgBloqueio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tgBloqueio.MinimumSize = new System.Drawing.Size(34, 18);
            this.tgBloqueio.Name = "tgBloqueio";
            this.tgBloqueio.OffBackColor = System.Drawing.Color.Gray;
            this.tgBloqueio.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tgBloqueio.OnBackColor = System.Drawing.Color.DeepPink;
            this.tgBloqueio.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tgBloqueio.Size = new System.Drawing.Size(34, 18);
            this.tgBloqueio.TabIndex = 159;
            this.tgBloqueio.UseVisualStyleBackColor = true;
            // 
            // lbEstatus
            // 
            this.lbEstatus.AutoSize = true;
            this.lbEstatus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbEstatus.Location = new System.Drawing.Point(773, 15);
            this.lbEstatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEstatus.Name = "lbEstatus";
            this.lbEstatus.Size = new System.Drawing.Size(80, 15);
            this.lbEstatus.TabIndex = 158;
            this.lbEstatus.Text = "BLOQUEADO";
            // 
            // lbCelular
            // 
            this.lbCelular.AutoSize = true;
            this.lbCelular.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbCelular.Location = new System.Drawing.Point(596, 17);
            this.lbCelular.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCelular.Name = "lbCelular";
            this.lbCelular.Size = new System.Drawing.Size(47, 15);
            this.lbCelular.TabIndex = 129;
            this.lbCelular.Text = "Celular";
            // 
            // tbNome
            // 
            this.tbNome.Enabled = false;
            this.tbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(7, 34);
            this.tbNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(200, 23);
            this.tbNome.TabIndex = 124;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbNome.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbNome.Location = new System.Drawing.Point(4, 17);
            this.lbNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(40, 15);
            this.lbNome.TabIndex = 123;
            this.lbNome.Text = "Nome";
            // 
            // lbSobrenome
            // 
            this.lbSobrenome.AutoSize = true;
            this.lbSobrenome.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbSobrenome.Location = new System.Drawing.Point(215, 17);
            this.lbSobrenome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSobrenome.Name = "lbSobrenome";
            this.lbSobrenome.Size = new System.Drawing.Size(73, 15);
            this.lbSobrenome.TabIndex = 125;
            this.lbSobrenome.Text = "Sobrenome";
            // 
            // mtbCpf
            // 
            this.mtbCpf.Enabled = false;
            this.mtbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCpf.Location = new System.Drawing.Point(450, 34);
            this.mtbCpf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtbCpf.Mask = "999,999,999-99";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(137, 23);
            this.mtbCpf.TabIndex = 128;
            this.mtbCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(448, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 127;
            this.label1.Text = "CPF";
            // 
            // lbAvisoCancelamento
            // 
            this.lbAvisoCancelamento.AutoSize = true;
            this.lbAvisoCancelamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbAvisoCancelamento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbAvisoCancelamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lbAvisoCancelamento.Location = new System.Drawing.Point(42, 24);
            this.lbAvisoCancelamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAvisoCancelamento.Name = "lbAvisoCancelamento";
            this.lbAvisoCancelamento.Size = new System.Drawing.Size(89, 15);
            this.lbAvisoCancelamento.TabIndex = 163;
            this.lbAvisoCancelamento.Text = "Cancelamento";
            // 
            // pbCancelamento
            // 
            this.pbCancelamento.Image = global::Apresentacao.Properties.Resources.DialogExcluir;
            this.pbCancelamento.Location = new System.Drawing.Point(9, 11);
            this.pbCancelamento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbCancelamento.Name = "pbCancelamento";
            this.pbCancelamento.Size = new System.Drawing.Size(28, 28);
            this.pbCancelamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCancelamento.TabIndex = 162;
            this.pbCancelamento.TabStop = false;
            // 
            // pbFuncionario
            // 
            this.pbFuncionario.Image = global::Apresentacao.Properties.Resources.FuncionarioAzul;
            this.pbFuncionario.Location = new System.Drawing.Point(339, 54);
            this.pbFuncionario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbFuncionario.Name = "pbFuncionario";
            this.pbFuncionario.Size = new System.Drawing.Size(26, 28);
            this.pbFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFuncionario.TabIndex = 171;
            this.pbFuncionario.TabStop = false;
            // 
            // panelFuncionario
            // 
            this.panelFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelFuncionario.Location = new System.Drawing.Point(339, 84);
            this.panelFuncionario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFuncionario.Name = "panelFuncionario";
            this.panelFuncionario.Size = new System.Drawing.Size(258, 2);
            this.panelFuncionario.TabIndex = 169;
            // 
            // btFuncionario
            // 
            this.btFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btFuncionario.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFuncionario.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            this.btFuncionario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btFuncionario.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btFuncionario.ImageKey = "Cliente.png";
            this.btFuncionario.Location = new System.Drawing.Point(600, 52);
            this.btFuncionario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btFuncionario.Name = "btFuncionario";
            this.btFuncionario.Size = new System.Drawing.Size(55, 34);
            this.btFuncionario.TabIndex = 167;
            this.btFuncionario.Text = "Buscar";
            this.toolTipItemCancelamento.SetToolTip(this.btFuncionario, "Buscar Funcionário");
            this.btFuncionario.UseVisualStyleBackColor = false;
            this.btFuncionario.Click += new System.EventHandler(this.btFuncionario_Click);
            // 
            // tbFuncionario
            // 
            this.tbFuncionario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFuncionario.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbFuncionario.Location = new System.Drawing.Point(369, 64);
            this.tbFuncionario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFuncionario.Name = "tbFuncionario";
            this.tbFuncionario.Size = new System.Drawing.Size(226, 16);
            this.tbFuncionario.TabIndex = 166;
            this.tbFuncionario.Text = "Digite o nome do funcionário ...";
            this.tbFuncionario.Enter += new System.EventHandler(this.tbFuncionario_Enter);
            this.tbFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFuncionario_KeyPress);
            this.tbFuncionario.Leave += new System.EventHandler(this.tbFuncionario_Leave);
            // 
            // pbUsuario
            // 
            this.pbUsuario.Image = global::Apresentacao.Properties.Resources.ClienteAzul;
            this.pbUsuario.Location = new System.Drawing.Point(9, 51);
            this.pbUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(26, 29);
            this.pbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsuario.TabIndex = 170;
            this.pbUsuario.TabStop = false;
            // 
            // panelBuscarCliente
            // 
            this.panelBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelBuscarCliente.Location = new System.Drawing.Point(9, 82);
            this.panelBuscarCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBuscarCliente.Name = "panelBuscarCliente";
            this.panelBuscarCliente.Size = new System.Drawing.Size(258, 2);
            this.panelBuscarCliente.TabIndex = 168;
            // 
            // btCliente
            // 
            this.btCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btCliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCliente.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            this.btCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCliente.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btCliente.ImageKey = "Cliente.png";
            this.btCliente.Location = new System.Drawing.Point(270, 50);
            this.btCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCliente.Name = "btCliente";
            this.btCliente.Size = new System.Drawing.Size(55, 34);
            this.btCliente.TabIndex = 165;
            this.btCliente.Text = "Buscar";
            this.toolTipItemCancelamento.SetToolTip(this.btCliente, "Buscar Cliente");
            this.btCliente.UseVisualStyleBackColor = false;
            this.btCliente.Click += new System.EventHandler(this.btCliente_Click);
            // 
            // tbBuscarCliente
            // 
            this.tbBuscarCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBuscarCliente.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbBuscarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.tbBuscarCliente.Location = new System.Drawing.Point(39, 63);
            this.tbBuscarCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbBuscarCliente.Name = "tbBuscarCliente";
            this.tbBuscarCliente.Size = new System.Drawing.Size(226, 16);
            this.tbBuscarCliente.TabIndex = 164;
            this.tbBuscarCliente.Text = "Digite o nome do cliente ...";
            this.tbBuscarCliente.Enter += new System.EventHandler(this.tbBuscarCliente_Enter);
            this.tbBuscarCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscarCliente_KeyPress);
            this.tbBuscarCliente.Leave += new System.EventHandler(this.tbBuscarCliente_Leave);
            // 
            // cbFormaPagamento
            // 
            this.cbFormaPagamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFormaPagamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFormaPagamento.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaPagamento.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.cbFormaPagamento.FormattingEnabled = true;
            this.cbFormaPagamento.Location = new System.Drawing.Point(148, 54);
            this.cbFormaPagamento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbFormaPagamento.Name = "cbFormaPagamento";
            this.cbFormaPagamento.Size = new System.Drawing.Size(107, 25);
            this.cbFormaPagamento.TabIndex = 156;
            this.cbFormaPagamento.DropDown += new System.EventHandler(this.cbFormaPagamento_DropDown);
            this.cbFormaPagamento.SelectedValueChanged += new System.EventHandler(this.cbFormaPagamento_SelectedValueChanged);
            // 
            // lbFormaPagamento
            // 
            this.lbFormaPagamento.AutoSize = true;
            this.lbFormaPagamento.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.lbFormaPagamento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbFormaPagamento.Location = new System.Drawing.Point(146, 29);
            this.lbFormaPagamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFormaPagamento.Name = "lbFormaPagamento";
            this.lbFormaPagamento.Size = new System.Drawing.Size(107, 14);
            this.lbFormaPagamento.TabIndex = 155;
            this.lbFormaPagamento.Text = "Forma Pagamento";
            // 
            // pbLimpar
            // 
            this.pbLimpar.Image = global::Apresentacao.Properties.Resources.Clear;
            this.pbLimpar.Location = new System.Drawing.Point(200, 127);
            this.pbLimpar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbLimpar.Name = "pbLimpar";
            this.pbLimpar.Size = new System.Drawing.Size(20, 22);
            this.pbLimpar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLimpar.TabIndex = 154;
            this.pbLimpar.TabStop = false;
            this.pbLimpar.Click += new System.EventHandler(this.pbLimpar_Click);
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(4, 127);
            this.dtpDataInicial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(94, 23);
            this.dtpDataInicial.TabIndex = 150;
            // 
            // lbDataInicial
            // 
            this.lbDataInicial.AutoSize = true;
            this.lbDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDataInicial.Location = new System.Drawing.Point(2, 107);
            this.lbDataInicial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDataInicial.Name = "lbDataInicial";
            this.lbDataInicial.Size = new System.Drawing.Size(77, 17);
            this.lbDataInicial.TabIndex = 149;
            this.lbDataInicial.Text = "Data Inicial";
            // 
            // lbDataFinal
            // 
            this.lbDataFinal.AutoSize = true;
            this.lbDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDataFinal.Location = new System.Drawing.Point(99, 107);
            this.lbDataFinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDataFinal.Name = "lbDataFinal";
            this.lbDataFinal.Size = new System.Drawing.Size(72, 17);
            this.lbDataFinal.TabIndex = 151;
            this.lbDataFinal.Text = "Data Final";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(102, 127);
            this.dtpDataFinal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(94, 23);
            this.dtpDataFinal.TabIndex = 152;
            // 
            // cbCrediarioPago
            // 
            this.cbCrediarioPago.AutoSize = true;
            this.cbCrediarioPago.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.cbCrediarioPago.Location = new System.Drawing.Point(4, 41);
            this.cbCrediarioPago.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCrediarioPago.Name = "cbCrediarioPago";
            this.cbCrediarioPago.Size = new System.Drawing.Size(107, 18);
            this.cbCrediarioPago.TabIndex = 159;
            this.cbCrediarioPago.Text = "Crediario Pago";
            this.cbCrediarioPago.UseVisualStyleBackColor = true;
            // 
            // cbVenda
            // 
            this.cbVenda.AutoSize = true;
            this.cbVenda.Checked = true;
            this.cbVenda.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVenda.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.cbVenda.Location = new System.Drawing.Point(4, 20);
            this.cbVenda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbVenda.Name = "cbVenda";
            this.cbVenda.Size = new System.Drawing.Size(60, 18);
            this.cbVenda.TabIndex = 158;
            this.cbVenda.Text = "Venda";
            this.cbVenda.UseVisualStyleBackColor = true;
            // 
            // cbCrediarioPendente
            // 
            this.cbCrediarioPendente.AutoSize = true;
            this.cbCrediarioPendente.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.cbCrediarioPendente.Location = new System.Drawing.Point(4, 62);
            this.cbCrediarioPendente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCrediarioPendente.Name = "cbCrediarioPendente";
            this.cbCrediarioPendente.Size = new System.Drawing.Size(133, 18);
            this.cbCrediarioPendente.TabIndex = 160;
            this.cbCrediarioPendente.Text = "Crediario Pendente";
            this.cbCrediarioPendente.UseVisualStyleBackColor = true;
            // 
            // panelEstornoLiquido
            // 
            this.panelEstornoLiquido.AutoScroll = true;
            this.panelEstornoLiquido.BackColor = System.Drawing.Color.Turquoise;
            this.panelEstornoLiquido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEstornoLiquido.Controls.Add(this.lbTituloEstornoLiquido);
            this.panelEstornoLiquido.Controls.Add(this.lbEstornoLiquido);
            this.panelEstornoLiquido.Location = new System.Drawing.Point(149, 553);
            this.panelEstornoLiquido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelEstornoLiquido.Name = "panelEstornoLiquido";
            this.panelEstornoLiquido.Size = new System.Drawing.Size(136, 60);
            this.panelEstornoLiquido.TabIndex = 174;
            // 
            // lbTituloEstornoLiquido
            // 
            this.lbTituloEstornoLiquido.AutoSize = true;
            this.lbTituloEstornoLiquido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTituloEstornoLiquido.ForeColor = System.Drawing.Color.White;
            this.lbTituloEstornoLiquido.Location = new System.Drawing.Point(2, 6);
            this.lbTituloEstornoLiquido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTituloEstornoLiquido.Name = "lbTituloEstornoLiquido";
            this.lbTituloEstornoLiquido.Size = new System.Drawing.Size(132, 19);
            this.lbTituloEstornoLiquido.TabIndex = 85;
            this.lbTituloEstornoLiquido.Text = "Estorno Líquido";
            this.lbTituloEstornoLiquido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbEstornoLiquido
            // 
            this.lbEstornoLiquido.AutoSize = true;
            this.lbEstornoLiquido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbEstornoLiquido.ForeColor = System.Drawing.Color.White;
            this.lbEstornoLiquido.Location = new System.Drawing.Point(27, 32);
            this.lbEstornoLiquido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEstornoLiquido.Name = "lbEstornoLiquido";
            this.lbEstornoLiquido.Size = new System.Drawing.Size(65, 19);
            this.lbEstornoLiquido.TabIndex = 84;
            this.lbEstornoLiquido.Text = "R$ 0,00";
            this.lbEstornoLiquido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTotalLiquido
            // 
            this.panelTotalLiquido.AutoScroll = true;
            this.panelTotalLiquido.BackColor = System.Drawing.Color.Yellow;
            this.panelTotalLiquido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotalLiquido.Controls.Add(this.lbTituloTotalLiquido);
            this.panelTotalLiquido.Controls.Add(this.lbValorLiquido);
            this.panelTotalLiquido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelTotalLiquido.Location = new System.Drawing.Point(710, 553);
            this.panelTotalLiquido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTotalLiquido.Name = "panelTotalLiquido";
            this.panelTotalLiquido.Size = new System.Drawing.Size(136, 60);
            this.panelTotalLiquido.TabIndex = 178;
            // 
            // lbTituloTotalLiquido
            // 
            this.lbTituloTotalLiquido.AutoSize = true;
            this.lbTituloTotalLiquido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTituloTotalLiquido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTituloTotalLiquido.Location = new System.Drawing.Point(2, 6);
            this.lbTituloTotalLiquido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTituloTotalLiquido.Name = "lbTituloTotalLiquido";
            this.lbTituloTotalLiquido.Size = new System.Drawing.Size(127, 19);
            this.lbTituloTotalLiquido.TabIndex = 0;
            this.lbTituloTotalLiquido.Text = "Total A Receber";
            this.lbTituloTotalLiquido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbValorLiquido
            // 
            this.lbValorLiquido.AutoSize = true;
            this.lbValorLiquido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbValorLiquido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbValorLiquido.Location = new System.Drawing.Point(27, 32);
            this.lbValorLiquido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbValorLiquido.Name = "lbValorLiquido";
            this.lbValorLiquido.Size = new System.Drawing.Size(65, 19);
            this.lbValorLiquido.TabIndex = 1;
            this.lbValorLiquido.Text = "R$ 0,00";
            this.lbValorLiquido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTotalBruto
            // 
            this.panelTotalBruto.AutoScroll = true;
            this.panelTotalBruto.BackColor = System.Drawing.Color.White;
            this.panelTotalBruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotalBruto.Controls.Add(this.lbTituloTotalBruto);
            this.panelTotalBruto.Controls.Add(this.lbTotalBruto);
            this.panelTotalBruto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelTotalBruto.Location = new System.Drawing.Point(570, 553);
            this.panelTotalBruto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTotalBruto.Name = "panelTotalBruto";
            this.panelTotalBruto.Size = new System.Drawing.Size(136, 60);
            this.panelTotalBruto.TabIndex = 177;
            // 
            // lbTituloTotalBruto
            // 
            this.lbTituloTotalBruto.AutoSize = true;
            this.lbTituloTotalBruto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTituloTotalBruto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTituloTotalBruto.Location = new System.Drawing.Point(2, 6);
            this.lbTituloTotalBruto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTituloTotalBruto.Name = "lbTituloTotalBruto";
            this.lbTituloTotalBruto.Size = new System.Drawing.Size(127, 19);
            this.lbTituloTotalBruto.TabIndex = 0;
            this.lbTituloTotalBruto.Text = "Total Recebido ";
            this.lbTituloTotalBruto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotalBruto
            // 
            this.lbTotalBruto.AutoSize = true;
            this.lbTotalBruto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTotalBruto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTotalBruto.Location = new System.Drawing.Point(27, 32);
            this.lbTotalBruto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalBruto.Name = "lbTotalBruto";
            this.lbTotalBruto.Size = new System.Drawing.Size(65, 19);
            this.lbTotalBruto.TabIndex = 1;
            this.lbTotalBruto.Text = "R$ 0,00";
            this.lbTotalBruto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // painelTaxa
            // 
            this.painelTaxa.AutoScroll = true;
            this.painelTaxa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.painelTaxa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelTaxa.Controls.Add(this.lbTituloTaxa);
            this.painelTaxa.Controls.Add(this.lbTaxa);
            this.painelTaxa.Location = new System.Drawing.Point(430, 553);
            this.painelTaxa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.painelTaxa.Name = "painelTaxa";
            this.painelTaxa.Size = new System.Drawing.Size(136, 60);
            this.painelTaxa.TabIndex = 176;
            // 
            // lbTituloTaxa
            // 
            this.lbTituloTaxa.AutoSize = true;
            this.lbTituloTaxa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTituloTaxa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTituloTaxa.Location = new System.Drawing.Point(2, 6);
            this.lbTituloTaxa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTituloTaxa.Name = "lbTituloTaxa";
            this.lbTituloTaxa.Size = new System.Drawing.Size(65, 19);
            this.lbTituloTaxa.TabIndex = 87;
            this.lbTituloTaxa.Text = "Taxa% ";
            this.lbTituloTaxa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTaxa
            // 
            this.lbTaxa.AutoSize = true;
            this.lbTaxa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTaxa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTaxa.Location = new System.Drawing.Point(21, 32);
            this.lbTaxa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTaxa.Name = "lbTaxa";
            this.lbTaxa.Size = new System.Drawing.Size(65, 19);
            this.lbTaxa.TabIndex = 84;
            this.lbTaxa.Text = "R$ 0,00";
            this.lbTaxa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // painelDesconto
            // 
            this.painelDesconto.AutoScroll = true;
            this.painelDesconto.BackColor = System.Drawing.Color.DeepPink;
            this.painelDesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelDesconto.Controls.Add(this.lbTituloDesconto);
            this.painelDesconto.Controls.Add(this.lbDesconto);
            this.painelDesconto.Location = new System.Drawing.Point(290, 553);
            this.painelDesconto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.painelDesconto.Name = "painelDesconto";
            this.painelDesconto.Size = new System.Drawing.Size(136, 60);
            this.painelDesconto.TabIndex = 175;
            // 
            // lbTituloDesconto
            // 
            this.lbTituloDesconto.AutoSize = true;
            this.lbTituloDesconto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTituloDesconto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTituloDesconto.Location = new System.Drawing.Point(2, 6);
            this.lbTituloDesconto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTituloDesconto.Name = "lbTituloDesconto";
            this.lbTituloDesconto.Size = new System.Drawing.Size(92, 19);
            this.lbTituloDesconto.TabIndex = 87;
            this.lbTituloDesconto.Text = "Desconto -";
            this.lbTituloDesconto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDesconto
            // 
            this.lbDesconto.AutoSize = true;
            this.lbDesconto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbDesconto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDesconto.Location = new System.Drawing.Point(21, 32);
            this.lbDesconto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDesconto.Name = "lbDesconto";
            this.lbDesconto.Size = new System.Drawing.Size(65, 19);
            this.lbDesconto.TabIndex = 84;
            this.lbDesconto.Text = "R$ 0,00";
            this.lbDesconto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // painelEstorno
            // 
            this.painelEstorno.AutoScroll = true;
            this.painelEstorno.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.painelEstorno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelEstorno.Controls.Add(this.lbTituloEstorno);
            this.painelEstorno.Controls.Add(this.lbEstorno);
            this.painelEstorno.Location = new System.Drawing.Point(9, 553);
            this.painelEstorno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.painelEstorno.Name = "painelEstorno";
            this.painelEstorno.Size = new System.Drawing.Size(136, 60);
            this.painelEstorno.TabIndex = 173;
            // 
            // lbTituloEstorno
            // 
            this.lbTituloEstorno.AutoSize = true;
            this.lbTituloEstorno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTituloEstorno.ForeColor = System.Drawing.Color.White;
            this.lbTituloEstorno.Location = new System.Drawing.Point(2, 6);
            this.lbTituloEstorno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTituloEstorno.Name = "lbTituloEstorno";
            this.lbTituloEstorno.Size = new System.Drawing.Size(95, 19);
            this.lbTituloEstorno.TabIndex = 85;
            this.lbTituloEstorno.Text = "Estorno R$";
            this.lbTituloEstorno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbEstorno
            // 
            this.lbEstorno.AutoSize = true;
            this.lbEstorno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbEstorno.ForeColor = System.Drawing.Color.White;
            this.lbEstorno.Location = new System.Drawing.Point(27, 32);
            this.lbEstorno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEstorno.Name = "lbEstorno";
            this.lbEstorno.Size = new System.Drawing.Size(65, 19);
            this.lbEstorno.TabIndex = 84;
            this.lbEstorno.Text = "R$ 0,00";
            this.lbEstorno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBuscarProduto
            // 
            this.panelBuscarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelBuscarProduto.Location = new System.Drawing.Point(9, 91);
            this.panelBuscarProduto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBuscarProduto.Name = "panelBuscarProduto";
            this.panelBuscarProduto.Size = new System.Drawing.Size(863, 2);
            this.panelBuscarProduto.TabIndex = 179;
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.panelFiltros);
            this.gbFiltros.Controls.Add(this.cbCrediarioPendente);
            this.gbFiltros.Controls.Add(this.cbCrediarioPago);
            this.gbFiltros.Controls.Add(this.dtpDataInicial);
            this.gbFiltros.Controls.Add(this.cbVenda);
            this.gbFiltros.Controls.Add(this.dtpDataFinal);
            this.gbFiltros.Controls.Add(this.lbDataFinal);
            this.gbFiltros.Controls.Add(this.lbDataInicial);
            this.gbFiltros.Controls.Add(this.cbFormaPagamento);
            this.gbFiltros.Controls.Add(this.pbLimpar);
            this.gbFiltros.Controls.Add(this.lbFormaPagamento);
            this.gbFiltros.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.gbFiltros.Location = new System.Drawing.Point(880, 5);
            this.gbFiltros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbFiltros.Size = new System.Drawing.Size(262, 158);
            this.gbFiltros.TabIndex = 180;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros:";
            // 
            // panelFiltros
            // 
            this.panelFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelFiltros.Location = new System.Drawing.Point(2, 94);
            this.panelFiltros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(258, 2);
            this.panelFiltros.TabIndex = 170;
            // 
            // painelTotalCrediario
            // 
            this.painelTotalCrediario.AutoScroll = true;
            this.painelTotalCrediario.BackColor = System.Drawing.Color.White;
            this.painelTotalCrediario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelTotalCrediario.Controls.Add(this.pictureBox2);
            this.painelTotalCrediario.Controls.Add(this.lbValorLiquidoCalculo);
            this.painelTotalCrediario.Controls.Add(this.panelCalculoVenda);
            this.painelTotalCrediario.Controls.Add(this.lbDescontoCalculo);
            this.painelTotalCrediario.Controls.Add(this.lbJurosCalculo);
            this.painelTotalCrediario.Controls.Add(this.lbTotalVenda);
            this.painelTotalCrediario.Controls.Add(this.lbValorBrutoCalculo);
            this.painelTotalCrediario.Location = new System.Drawing.Point(671, 5);
            this.painelTotalCrediario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.painelTotalCrediario.Name = "painelTotalCrediario";
            this.painelTotalCrediario.Size = new System.Drawing.Size(202, 82);
            this.painelTotalCrediario.TabIndex = 182;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Apresentacao.Properties.Resources.Calculator;
            this.pictureBox2.Location = new System.Drawing.Point(34, 32);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 142;
            this.pictureBox2.TabStop = false;
            // 
            // lbValorLiquidoCalculo
            // 
            this.lbValorLiquidoCalculo.AutoSize = true;
            this.lbValorLiquidoCalculo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbValorLiquidoCalculo.ForeColor = System.Drawing.Color.Black;
            this.lbValorLiquidoCalculo.Location = new System.Drawing.Point(102, 63);
            this.lbValorLiquidoCalculo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbValorLiquidoCalculo.Name = "lbValorLiquidoCalculo";
            this.lbValorLiquidoCalculo.Size = new System.Drawing.Size(58, 15);
            this.lbValorLiquidoCalculo.TabIndex = 137;
            this.lbValorLiquidoCalculo.Text = "   R$ 0,00";
            this.lbValorLiquidoCalculo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCalculoVenda
            // 
            this.panelCalculoVenda.BackColor = System.Drawing.Color.Black;
            this.panelCalculoVenda.Location = new System.Drawing.Point(104, 58);
            this.panelCalculoVenda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelCalculoVenda.Name = "panelCalculoVenda";
            this.panelCalculoVenda.Size = new System.Drawing.Size(86, 2);
            this.panelCalculoVenda.TabIndex = 136;
            // 
            // lbDescontoCalculo
            // 
            this.lbDescontoCalculo.AutoSize = true;
            this.lbDescontoCalculo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbDescontoCalculo.ForeColor = System.Drawing.Color.Black;
            this.lbDescontoCalculo.Location = new System.Drawing.Point(102, 42);
            this.lbDescontoCalculo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDescontoCalculo.Name = "lbDescontoCalculo";
            this.lbDescontoCalculo.Size = new System.Drawing.Size(59, 15);
            this.lbDescontoCalculo.TabIndex = 87;
            this.lbDescontoCalculo.Text = " - R$ 0,00";
            this.lbDescontoCalculo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbJurosCalculo
            // 
            this.lbJurosCalculo.AutoSize = true;
            this.lbJurosCalculo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbJurosCalculo.ForeColor = System.Drawing.Color.Black;
            this.lbJurosCalculo.Location = new System.Drawing.Point(102, 24);
            this.lbJurosCalculo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbJurosCalculo.Name = "lbJurosCalculo";
            this.lbJurosCalculo.Size = new System.Drawing.Size(58, 15);
            this.lbJurosCalculo.TabIndex = 86;
            this.lbJurosCalculo.Text = "%R$ 0,00";
            this.lbJurosCalculo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotalVenda
            // 
            this.lbTotalVenda.AutoSize = true;
            this.lbTotalVenda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbTotalVenda.ForeColor = System.Drawing.Color.Black;
            this.lbTotalVenda.Location = new System.Drawing.Point(2, 6);
            this.lbTotalVenda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalVenda.Name = "lbTotalVenda";
            this.lbTotalVenda.Size = new System.Drawing.Size(98, 19);
            this.lbTotalVenda.TabIndex = 85;
            this.lbTotalVenda.Text = "Total Venda";
            this.lbTotalVenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbValorBrutoCalculo
            // 
            this.lbValorBrutoCalculo.AutoSize = true;
            this.lbValorBrutoCalculo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbValorBrutoCalculo.ForeColor = System.Drawing.Color.Black;
            this.lbValorBrutoCalculo.Location = new System.Drawing.Point(102, 6);
            this.lbValorBrutoCalculo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbValorBrutoCalculo.Name = "lbValorBrutoCalculo";
            this.lbValorBrutoCalculo.Size = new System.Drawing.Size(59, 15);
            this.lbValorBrutoCalculo.TabIndex = 84;
            this.lbValorBrutoCalculo.Text = "+ R$ 0,00";
            this.lbValorBrutoCalculo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvVendaCancela
            // 
            this.dgvVendaCancela.AllowUserToAddRows = false;
            this.dgvVendaCancela.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dgvVendaCancela.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVendaCancela.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVendaCancela.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVendaCancela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendaCancela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoVenda,
            this.codigoFormaPagamento,
            this.formaPagamento,
            this.tipoVenda,
            this.quantidadeVenda,
            this.totalBrutoVenda,
            this.totalVenda,
            this.descontoVenda,
            this.jurosVenda,
            this.codigoCliente,
            this.nomeCliente,
            this.sobrenomeCliente,
            this.cpfCliente,
            this.codigoFuncionario,
            this.nomeFuncionario,
            this.sobrenomeFuncionario,
            this.dataVenda,
            this.estatusVenda});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVendaCancela.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvVendaCancela.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvVendaCancela.Location = new System.Drawing.Point(9, 168);
            this.dgvVendaCancela.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvVendaCancela.Name = "dgvVendaCancela";
            this.dgvVendaCancela.ReadOnly = true;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.dgvVendaCancela.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvVendaCancela.RowTemplate.Height = 24;
            this.dgvVendaCancela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendaCancela.Size = new System.Drawing.Size(1133, 380);
            this.dgvVendaCancela.TabIndex = 183;
            this.dgvVendaCancela.DoubleClick += new System.EventHandler(this.dgvVendaCancela_DoubleClick);
            // 
            // codigoVenda
            // 
            this.codigoVenda.HeaderText = "Cód";
            this.codigoVenda.Name = "codigoVenda";
            this.codigoVenda.ReadOnly = true;
            this.codigoVenda.ToolTipText = "Código da Venda";
            this.codigoVenda.Width = 60;
            // 
            // codigoFormaPagamento
            // 
            this.codigoFormaPagamento.HeaderText = "codigoFormaPagamento";
            this.codigoFormaPagamento.Name = "codigoFormaPagamento";
            this.codigoFormaPagamento.ReadOnly = true;
            this.codigoFormaPagamento.Visible = false;
            // 
            // formaPagamento
            // 
            this.formaPagamento.HeaderText = "Pagamento";
            this.formaPagamento.Name = "formaPagamento";
            this.formaPagamento.ReadOnly = true;
            this.formaPagamento.ToolTipText = "Forma de Pagamento";
            this.formaPagamento.Width = 130;
            // 
            // tipoVenda
            // 
            this.tipoVenda.HeaderText = "Tipo Venda";
            this.tipoVenda.Name = "tipoVenda";
            this.tipoVenda.ReadOnly = true;
            this.tipoVenda.ToolTipText = "Tipo de Venda";
            this.tipoVenda.Width = 130;
            // 
            // quantidadeVenda
            // 
            this.quantidadeVenda.HeaderText = "Quant";
            this.quantidadeVenda.Name = "quantidadeVenda";
            this.quantidadeVenda.ReadOnly = true;
            this.quantidadeVenda.ToolTipText = "Quantidade da Venda";
            this.quantidadeVenda.Width = 60;
            // 
            // totalBrutoVenda
            // 
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.totalBrutoVenda.DefaultCellStyle = dataGridViewCellStyle3;
            this.totalBrutoVenda.HeaderText = "Recebido";
            this.totalBrutoVenda.Name = "totalBrutoVenda";
            this.totalBrutoVenda.ReadOnly = true;
            this.totalBrutoVenda.ToolTipText = "Total Bruto da Venda";
            this.totalBrutoVenda.Width = 90;
            // 
            // totalVenda
            // 
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.totalVenda.DefaultCellStyle = dataGridViewCellStyle4;
            this.totalVenda.HeaderText = "Líquido";
            this.totalVenda.Name = "totalVenda";
            this.totalVenda.ReadOnly = true;
            this.totalVenda.ToolTipText = "Total Liquido Venda";
            this.totalVenda.Width = 90;
            // 
            // descontoVenda
            // 
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.descontoVenda.DefaultCellStyle = dataGridViewCellStyle5;
            this.descontoVenda.HeaderText = "Desconto";
            this.descontoVenda.Name = "descontoVenda";
            this.descontoVenda.ReadOnly = true;
            this.descontoVenda.ToolTipText = "Desconto da Venda";
            this.descontoVenda.Width = 90;
            // 
            // jurosVenda
            // 
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.jurosVenda.DefaultCellStyle = dataGridViewCellStyle6;
            this.jurosVenda.HeaderText = "Juros";
            this.jurosVenda.Name = "jurosVenda";
            this.jurosVenda.ReadOnly = true;
            this.jurosVenda.ToolTipText = "Juros da Venda";
            this.jurosVenda.Width = 90;
            // 
            // codigoCliente
            // 
            this.codigoCliente.HeaderText = "Cliente";
            this.codigoCliente.Name = "codigoCliente";
            this.codigoCliente.ReadOnly = true;
            this.codigoCliente.ToolTipText = "Código do Cliente";
            this.codigoCliente.Width = 70;
            // 
            // nomeCliente
            // 
            this.nomeCliente.HeaderText = "Nome";
            this.nomeCliente.Name = "nomeCliente";
            this.nomeCliente.ReadOnly = true;
            this.nomeCliente.ToolTipText = "Nome do Cliente";
            this.nomeCliente.Width = 150;
            // 
            // sobrenomeCliente
            // 
            this.sobrenomeCliente.HeaderText = "Sobrenome";
            this.sobrenomeCliente.Name = "sobrenomeCliente";
            this.sobrenomeCliente.ReadOnly = true;
            this.sobrenomeCliente.ToolTipText = "Sobrenome do Cliente";
            this.sobrenomeCliente.Width = 130;
            // 
            // cpfCliente
            // 
            this.cpfCliente.HeaderText = "CPF";
            this.cpfCliente.Name = "cpfCliente";
            this.cpfCliente.ReadOnly = true;
            this.cpfCliente.ToolTipText = "CPF do Cliente";
            this.cpfCliente.Width = 90;
            // 
            // codigoFuncionario
            // 
            this.codigoFuncionario.HeaderText = "Funcionário";
            this.codigoFuncionario.Name = "codigoFuncionario";
            this.codigoFuncionario.ReadOnly = true;
            this.codigoFuncionario.ToolTipText = "Código do Funcionário";
            this.codigoFuncionario.Width = 90;
            // 
            // nomeFuncionario
            // 
            this.nomeFuncionario.HeaderText = "Nome";
            this.nomeFuncionario.Name = "nomeFuncionario";
            this.nomeFuncionario.ReadOnly = true;
            this.nomeFuncionario.ToolTipText = "Nome do Funcionário";
            this.nomeFuncionario.Width = 150;
            // 
            // sobrenomeFuncionario
            // 
            this.sobrenomeFuncionario.HeaderText = "Sobrenome";
            this.sobrenomeFuncionario.Name = "sobrenomeFuncionario";
            this.sobrenomeFuncionario.ReadOnly = true;
            this.sobrenomeFuncionario.ToolTipText = "Sobrenome do Funcionário";
            this.sobrenomeFuncionario.Width = 130;
            // 
            // dataVenda
            // 
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            this.dataVenda.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataVenda.HeaderText = "Data";
            this.dataVenda.Name = "dataVenda";
            this.dataVenda.ReadOnly = true;
            this.dataVenda.ToolTipText = "Data da Venda";
            this.dataVenda.Width = 80;
            // 
            // estatusVenda
            // 
            this.estatusVenda.HeaderText = "Estatus";
            this.estatusVenda.Name = "estatusVenda";
            this.estatusVenda.ReadOnly = true;
            this.estatusVenda.ToolTipText = "Estatus da Venda ";
            this.estatusVenda.Visible = false;
            this.estatusVenda.Width = 90;
            // 
            // btBuscar
            // 
            this.btBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btBuscar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBuscar.Location = new System.Drawing.Point(9, 643);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(98, 34);
            this.btBuscar.TabIndex = 185;
            this.btBuscar.Text = "F5 Gerar";
            this.toolTipItemCancelamento.SetToolTip(this.btBuscar, "Busca vendas");
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCancelar.ImageKey = "Cliente.png";
            this.btCancelar.Location = new System.Drawing.Point(111, 643);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(98, 34);
            this.btCancelar.TabIndex = 184;
            this.btCancelar.Text = "F6 Cancelar";
            this.toolTipItemCancelamento.SetToolTip(this.btCancelar, "Cancela a Venda");
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSair
            // 
            this.btSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSair.BackColor = System.Drawing.Color.Red;
            this.btSair.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSair.Location = new System.Drawing.Point(1045, 643);
            this.btSair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(98, 34);
            this.btSair.TabIndex = 186;
            this.btSair.Text = "Esc Sair";
            this.toolTipItemCancelamento.SetToolTip(this.btSair, "Sair do Formulário");
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btLimpar.BackColor = System.Drawing.Color.DeepPink;
            this.btLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btLimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLimpar.ImageKey = "Cliente.png";
            this.btLimpar.Location = new System.Drawing.Point(213, 643);
            this.btLimpar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(98, 34);
            this.btLimpar.TabIndex = 187;
            this.btLimpar.Text = "F2 Limpar";
            this.toolTipItemCancelamento.SetToolTip(this.btLimpar, "Cancela a Venda");
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // FrmCancelamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1151, 687);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.dgvVendaCancela);
            this.Controls.Add(this.painelTotalCrediario);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.panelBuscarProduto);
            this.Controls.Add(this.panelEstornoLiquido);
            this.Controls.Add(this.panelTotalLiquido);
            this.Controls.Add(this.panelTotalBruto);
            this.Controls.Add(this.painelTaxa);
            this.Controls.Add(this.painelDesconto);
            this.Controls.Add(this.painelEstorno);
            this.Controls.Add(this.pbFuncionario);
            this.Controls.Add(this.panelFuncionario);
            this.Controls.Add(this.btFuncionario);
            this.Controls.Add(this.tbFuncionario);
            this.Controls.Add(this.pbUsuario);
            this.Controls.Add(this.panelBuscarCliente);
            this.Controls.Add(this.btCliente);
            this.Controls.Add(this.tbBuscarCliente);
            this.Controls.Add(this.lbAvisoCancelamento);
            this.Controls.Add(this.pbCancelamento);
            this.Controls.Add(this.gbCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmCancelamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelamento";
            this.Load += new System.EventHandler(this.FrmCancelamento_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCancelamento_KeyDown);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelecionarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLimpar)).EndInit();
            this.panelEstornoLiquido.ResumeLayout(false);
            this.panelEstornoLiquido.PerformLayout();
            this.panelTotalLiquido.ResumeLayout(false);
            this.panelTotalLiquido.PerformLayout();
            this.panelTotalBruto.ResumeLayout(false);
            this.panelTotalBruto.PerformLayout();
            this.painelTaxa.ResumeLayout(false);
            this.painelTaxa.PerformLayout();
            this.painelDesconto.ResumeLayout(false);
            this.painelDesconto.PerformLayout();
            this.painelEstorno.ResumeLayout(false);
            this.painelEstorno.PerformLayout();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.painelTotalCrediario.ResumeLayout(false);
            this.painelTotalCrediario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendaCancela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.TextBox tbSobrenome;
        private System.Windows.Forms.MaskedTextBox mtbCelular;
        private System.Windows.Forms.Label lbCelular;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbSobrenome;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAvisoCancelamento;
        private System.Windows.Forms.PictureBox pbCancelamento;
        private System.Windows.Forms.PictureBox pbFuncionario;
        private System.Windows.Forms.Panel panelFuncionario;
        private System.Windows.Forms.Button btFuncionario;
        private System.Windows.Forms.TextBox tbFuncionario;
        private System.Windows.Forms.PictureBox pbUsuario;
        private System.Windows.Forms.Panel panelBuscarCliente;
        private System.Windows.Forms.Button btCliente;
        private System.Windows.Forms.TextBox tbBuscarCliente;
        private System.Windows.Forms.ComboBox cbFormaPagamento;
        private System.Windows.Forms.Label lbFormaPagamento;
        private System.Windows.Forms.PictureBox pbLimpar;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.Label lbDataInicial;
        private System.Windows.Forms.Label lbDataFinal;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.CheckBox cbCrediarioPago;
        private System.Windows.Forms.CheckBox cbVenda;
        private System.Windows.Forms.CheckBox cbCrediarioPendente;
        private System.Windows.Forms.Panel panelEstornoLiquido;
        private System.Windows.Forms.Label lbTituloEstornoLiquido;
        private System.Windows.Forms.Label lbEstornoLiquido;
        private System.Windows.Forms.Panel panelTotalLiquido;
        private System.Windows.Forms.Label lbTituloTotalLiquido;
        private System.Windows.Forms.Label lbValorLiquido;
        private System.Windows.Forms.Panel panelTotalBruto;
        private System.Windows.Forms.Label lbTituloTotalBruto;
        private System.Windows.Forms.Label lbTotalBruto;
        private System.Windows.Forms.Panel painelTaxa;
        private System.Windows.Forms.Label lbTituloTaxa;
        private System.Windows.Forms.Label lbTaxa;
        private System.Windows.Forms.Panel painelDesconto;
        private System.Windows.Forms.Label lbTituloDesconto;
        private System.Windows.Forms.Label lbDesconto;
        private System.Windows.Forms.Panel painelEstorno;
        private System.Windows.Forms.Label lbTituloEstorno;
        private System.Windows.Forms.Label lbEstorno;
        private System.Windows.Forms.Panel panelBuscarProduto;
        private System.Windows.Forms.GroupBox gbFiltros;
        private CustomControls.RJControls.TouglleControl tgBloqueio;
        private System.Windows.Forms.Label lbEstatus;
        private System.Windows.Forms.PictureBox pbOk;
        private System.Windows.Forms.Panel painelTotalCrediario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbValorLiquidoCalculo;
        private System.Windows.Forms.Panel panelCalculoVenda;
        private System.Windows.Forms.Label lbDescontoCalculo;
        private System.Windows.Forms.Label lbJurosCalculo;
        private System.Windows.Forms.Label lbTotalVenda;
        private System.Windows.Forms.Label lbValorBrutoCalculo;
        private System.Windows.Forms.DataGridView dgvVendaCancela;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.ToolTip toolTipItemCancelamento;
        private System.Windows.Forms.PictureBox pbSelecionarCliente;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoFormaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalBrutoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn descontoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn jurosVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobrenomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobrenomeFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusVenda;
    }
}