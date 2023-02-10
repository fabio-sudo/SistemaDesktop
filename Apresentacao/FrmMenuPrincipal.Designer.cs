namespace Apresentacao
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btSair = new System.Windows.Forms.Button();
            this.btBackup = new System.Windows.Forms.Button();
            this.btRelatorio = new System.Windows.Forms.Button();
            this.btUsuarioSenha = new System.Windows.Forms.Button();
            this.btCrediario = new System.Windows.Forms.Button();
            this.btVenda = new System.Windows.Forms.Button();
            this.btEstoque = new System.Windows.Forms.Button();
            this.btProduto = new System.Windows.Forms.Button();
            this.btFornecedor = new System.Windows.Forms.Button();
            this.btFuncionario = new System.Windows.Forms.Button();
            this.btCliente = new System.Windows.Forms.Button();
            this.panelMenuLogo = new System.Windows.Forms.Panel();
            this.btHome = new System.Windows.Forms.Button();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btLogin = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.mstMenus = new System.Windows.Forms.MenuStrip();
            this.inserirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelMenuLogo.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.mstMenus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btSair);
            this.panelMenu.Controls.Add(this.btBackup);
            this.panelMenu.Controls.Add(this.btRelatorio);
            this.panelMenu.Controls.Add(this.btUsuarioSenha);
            this.panelMenu.Controls.Add(this.btCrediario);
            this.panelMenu.Controls.Add(this.btVenda);
            this.panelMenu.Controls.Add(this.btEstoque);
            this.panelMenu.Controls.Add(this.btProduto);
            this.panelMenu.Controls.Add(this.btFornecedor);
            this.panelMenu.Controls.Add(this.btFuncionario);
            this.panelMenu.Controls.Add(this.btCliente);
            this.panelMenu.Controls.Add(this.panelMenuLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(165, 603);
            this.panelMenu.TabIndex = 0;
            // 
            // btSair
            // 
            this.btSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.ForeColor = System.Drawing.Color.Gainsboro;
            this.btSair.Image = global::Apresentacao.Properties.Resources.Sair;
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.Location = new System.Drawing.Point(0, 554);
            this.btSair.Margin = new System.Windows.Forms.Padding(2);
            this.btSair.Name = "btSair";
            this.btSair.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btSair.Size = new System.Drawing.Size(165, 49);
            this.btSair.TabIndex = 11;
            this.btSair.Text = " Sair";
            this.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btBackup
            // 
            this.btBackup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btBackup.FlatAppearance.BorderSize = 0;
            this.btBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBackup.ForeColor = System.Drawing.Color.Gainsboro;
            this.btBackup.Image = global::Apresentacao.Properties.Resources.Backup;
            this.btBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBackup.Location = new System.Drawing.Point(0, 506);
            this.btBackup.Margin = new System.Windows.Forms.Padding(2);
            this.btBackup.Name = "btBackup";
            this.btBackup.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btBackup.Size = new System.Drawing.Size(165, 49);
            this.btBackup.TabIndex = 10;
            this.btBackup.Text = " Backup";
            this.btBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btBackup.UseVisualStyleBackColor = true;
            this.btBackup.Click += new System.EventHandler(this.btBackup_Click);
            // 
            // btRelatorio
            // 
            this.btRelatorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btRelatorio.FlatAppearance.BorderSize = 0;
            this.btRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRelatorio.ForeColor = System.Drawing.Color.Gainsboro;
            this.btRelatorio.Image = global::Apresentacao.Properties.Resources.Relatorios;
            this.btRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRelatorio.Location = new System.Drawing.Point(0, 457);
            this.btRelatorio.Margin = new System.Windows.Forms.Padding(2);
            this.btRelatorio.Name = "btRelatorio";
            this.btRelatorio.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btRelatorio.Size = new System.Drawing.Size(165, 49);
            this.btRelatorio.TabIndex = 9;
            this.btRelatorio.Text = " Relatórios";
            this.btRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btRelatorio.UseVisualStyleBackColor = true;
            this.btRelatorio.Click += new System.EventHandler(this.btRelatorio_Click);
            // 
            // btUsuarioSenha
            // 
            this.btUsuarioSenha.Dock = System.Windows.Forms.DockStyle.Top;
            this.btUsuarioSenha.FlatAppearance.BorderSize = 0;
            this.btUsuarioSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUsuarioSenha.ForeColor = System.Drawing.Color.Gainsboro;
            this.btUsuarioSenha.Image = global::Apresentacao.Properties.Resources.KeyLogo;
            this.btUsuarioSenha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btUsuarioSenha.Location = new System.Drawing.Point(0, 408);
            this.btUsuarioSenha.Margin = new System.Windows.Forms.Padding(2);
            this.btUsuarioSenha.Name = "btUsuarioSenha";
            this.btUsuarioSenha.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btUsuarioSenha.Size = new System.Drawing.Size(165, 49);
            this.btUsuarioSenha.TabIndex = 8;
            this.btUsuarioSenha.Text = " Usuario e Senha";
            this.btUsuarioSenha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btUsuarioSenha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btUsuarioSenha.UseVisualStyleBackColor = true;
            this.btUsuarioSenha.Click += new System.EventHandler(this.btUsuarioSenha_Click);
            // 
            // btCrediario
            // 
            this.btCrediario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCrediario.FlatAppearance.BorderSize = 0;
            this.btCrediario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCrediario.ForeColor = System.Drawing.Color.Gainsboro;
            this.btCrediario.Image = global::Apresentacao.Properties.Resources.Crediario;
            this.btCrediario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCrediario.Location = new System.Drawing.Point(0, 359);
            this.btCrediario.Margin = new System.Windows.Forms.Padding(2);
            this.btCrediario.Name = "btCrediario";
            this.btCrediario.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btCrediario.Size = new System.Drawing.Size(165, 49);
            this.btCrediario.TabIndex = 7;
            this.btCrediario.Text = " Crediario";
            this.btCrediario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCrediario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCrediario.UseVisualStyleBackColor = true;
            this.btCrediario.Click += new System.EventHandler(this.btCrediario_Click);
            // 
            // btVenda
            // 
            this.btVenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btVenda.FlatAppearance.BorderSize = 0;
            this.btVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVenda.ForeColor = System.Drawing.Color.Gainsboro;
            this.btVenda.Image = global::Apresentacao.Properties.Resources.Venda;
            this.btVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btVenda.Location = new System.Drawing.Point(0, 310);
            this.btVenda.Margin = new System.Windows.Forms.Padding(2);
            this.btVenda.Name = "btVenda";
            this.btVenda.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btVenda.Size = new System.Drawing.Size(165, 49);
            this.btVenda.TabIndex = 6;
            this.btVenda.Text = " Venda";
            this.btVenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btVenda.UseVisualStyleBackColor = true;
            this.btVenda.Click += new System.EventHandler(this.btVenda_Click);
            // 
            // btEstoque
            // 
            this.btEstoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.btEstoque.FlatAppearance.BorderSize = 0;
            this.btEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEstoque.ForeColor = System.Drawing.Color.Gainsboro;
            this.btEstoque.Image = global::Apresentacao.Properties.Resources.Estoque;
            this.btEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEstoque.Location = new System.Drawing.Point(0, 261);
            this.btEstoque.Margin = new System.Windows.Forms.Padding(2);
            this.btEstoque.Name = "btEstoque";
            this.btEstoque.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btEstoque.Size = new System.Drawing.Size(165, 49);
            this.btEstoque.TabIndex = 5;
            this.btEstoque.Text = "Estoque";
            this.btEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btEstoque.UseVisualStyleBackColor = true;
            this.btEstoque.Click += new System.EventHandler(this.btEstoque_Click);
            // 
            // btProduto
            // 
            this.btProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btProduto.FlatAppearance.BorderSize = 0;
            this.btProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProduto.ForeColor = System.Drawing.Color.Gainsboro;
            this.btProduto.Image = global::Apresentacao.Properties.Resources.Produto;
            this.btProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btProduto.Location = new System.Drawing.Point(0, 212);
            this.btProduto.Margin = new System.Windows.Forms.Padding(2);
            this.btProduto.Name = "btProduto";
            this.btProduto.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btProduto.Size = new System.Drawing.Size(165, 49);
            this.btProduto.TabIndex = 4;
            this.btProduto.Text = " Produto";
            this.btProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btProduto.UseVisualStyleBackColor = true;
            this.btProduto.Click += new System.EventHandler(this.btProduto_Click);
            // 
            // btFornecedor
            // 
            this.btFornecedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btFornecedor.FlatAppearance.BorderSize = 0;
            this.btFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFornecedor.ForeColor = System.Drawing.Color.Gainsboro;
            this.btFornecedor.Image = global::Apresentacao.Properties.Resources.Fornecedor;
            this.btFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFornecedor.Location = new System.Drawing.Point(0, 163);
            this.btFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.btFornecedor.Name = "btFornecedor";
            this.btFornecedor.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btFornecedor.Size = new System.Drawing.Size(165, 49);
            this.btFornecedor.TabIndex = 3;
            this.btFornecedor.Text = " Fornecedor";
            this.btFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFornecedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btFornecedor.UseVisualStyleBackColor = true;
            this.btFornecedor.Click += new System.EventHandler(this.btFornecedor_Click);
            // 
            // btFuncionario
            // 
            this.btFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btFuncionario.FlatAppearance.BorderSize = 0;
            this.btFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFuncionario.ForeColor = System.Drawing.Color.Gainsboro;
            this.btFuncionario.Image = global::Apresentacao.Properties.Resources.Funcionario;
            this.btFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFuncionario.Location = new System.Drawing.Point(0, 114);
            this.btFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.btFuncionario.Name = "btFuncionario";
            this.btFuncionario.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btFuncionario.Size = new System.Drawing.Size(165, 49);
            this.btFuncionario.TabIndex = 2;
            this.btFuncionario.Text = " Funcionario";
            this.btFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btFuncionario.UseVisualStyleBackColor = true;
            this.btFuncionario.Click += new System.EventHandler(this.btFuncionario_Click);
            // 
            // btCliente
            // 
            this.btCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCliente.FlatAppearance.BorderSize = 0;
            this.btCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.btCliente.Image = global::Apresentacao.Properties.Resources.Cliente;
            this.btCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCliente.Location = new System.Drawing.Point(0, 65);
            this.btCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btCliente.Name = "btCliente";
            this.btCliente.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btCliente.Size = new System.Drawing.Size(165, 49);
            this.btCliente.TabIndex = 1;
            this.btCliente.Text = " Cliente";
            this.btCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCliente.UseVisualStyleBackColor = true;
            this.btCliente.Click += new System.EventHandler(this.btCliente_Click);
            // 
            // panelMenuLogo
            // 
            this.panelMenuLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelMenuLogo.Controls.Add(this.btHome);
            this.panelMenuLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuLogo.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenuLogo.Name = "panelMenuLogo";
            this.panelMenuLogo.Size = new System.Drawing.Size(165, 65);
            this.panelMenuLogo.TabIndex = 0;
            // 
            // btHome
            // 
            this.btHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btHome.FlatAppearance.BorderSize = 0;
            this.btHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.btHome.Image = global::Apresentacao.Properties.Resources.logoPng;
            this.btHome.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btHome.Location = new System.Drawing.Point(0, 0);
            this.btHome.Margin = new System.Windows.Forms.Padding(2);
            this.btHome.Name = "btHome";
            this.btHome.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btHome.Size = new System.Drawing.Size(165, 65);
            this.btHome.TabIndex = 0;
            this.btHome.Text = "Trevezane Software";
            this.btHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btHome.UseVisualStyleBackColor = false;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelDesktop.Controls.Add(this.panelTitulo);
            this.panelDesktop.Controls.Add(this.mstMenus);
            this.panelDesktop.Controls.Add(this.pictureLogo);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(165, 0);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(724, 603);
            this.panelDesktop.TabIndex = 1;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelTitulo.Controls.Add(this.btLogin);
            this.panelTitulo.Controls.Add(this.btFechar);
            this.panelTitulo.Controls.Add(this.lbTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 25);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(724, 65);
            this.panelTitulo.TabIndex = 7;
            // 
            // btLogin
            // 
            this.btLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btLogin.FlatAppearance.BorderSize = 0;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLogin.Image = global::Apresentacao.Properties.Resources.Cliente;
            this.btLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogin.Location = new System.Drawing.Point(634, 0);
            this.btLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(90, 65);
            this.btLogin.TabIndex = 2;
            this.btLogin.Text = "Usuário";
            this.btLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btFechar
            // 
            this.btFechar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btFechar.FlatAppearance.BorderSize = 0;
            this.btFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFechar.Image = global::Apresentacao.Properties.Resources.Fechar;
            this.btFechar.Location = new System.Drawing.Point(0, 0);
            this.btFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(68, 65);
            this.btFechar.TabIndex = 0;
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Visible = false;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTitulo.Location = new System.Drawing.Point(327, 18);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(0, 27);
            this.lbTitulo.TabIndex = 0;
            // 
            // mstMenus
            // 
            this.mstMenus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.mstMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.vendaToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.relatóriosToolStripMenuItem1});
            this.mstMenus.Location = new System.Drawing.Point(0, 0);
            this.mstMenus.Name = "mstMenus";
            this.mstMenus.Size = new System.Drawing.Size(724, 25);
            this.mstMenus.TabIndex = 6;
            this.mstMenus.Text = "Menu";
            // 
            // inserirToolStripMenuItem
            // 
            this.inserirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.funcionárioToolStripMenuItem,
            this.fornecedorToolStripMenuItem,
            this.produtoToolStripMenuItem});
            this.inserirToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.inserirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.inserirToolStripMenuItem.Name = "inserirToolStripMenuItem";
            this.inserirToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.inserirToolStripMenuItem.Text = "Inserir";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.clienteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // funcionárioToolStripMenuItem
            // 
            this.funcionárioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.funcionárioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.funcionárioToolStripMenuItem.Text = "Funcionário";
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.fornecedorToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fornecedorToolStripMenuItem.Text = "Fornecedor";
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.produtoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.produtoToolStripMenuItem.Text = "Produto";
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.estoqueToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.vendaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(54, 21);
            this.vendaToolStripMenuItem.Text = "Venda";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.relatóriosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.relatóriosToolStripMenuItem.Text = "Crediario";
            // 
            // relatóriosToolStripMenuItem1
            // 
            this.relatóriosToolStripMenuItem1.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.relatóriosToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.relatóriosToolStripMenuItem1.Name = "relatóriosToolStripMenuItem1";
            this.relatóriosToolStripMenuItem1.Size = new System.Drawing.Size(74, 21);
            this.relatóriosToolStripMenuItem1.Text = "Relatórios";
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pictureLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureLogo.Image = global::Apresentacao.Properties.Resources.PlanoDeFundoLogo;
            this.pictureLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(724, 603);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(889, 603);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMenuPrincipal_KeyDown);
            this.panelMenu.ResumeLayout(false);
            this.panelMenuLogo.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.mstMenus.ResumeLayout(false);
            this.mstMenus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btCliente;
        private System.Windows.Forms.Panel panelMenuLogo;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btRelatorio;
        private System.Windows.Forms.Button btEstoque;
        private System.Windows.Forms.Button btProduto;
        private System.Windows.Forms.Button btFornecedor;
        private System.Windows.Forms.Button btFuncionario;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Button btBackup;
        private System.Windows.Forms.Button btUsuarioSenha;
        private System.Windows.Forms.Button btCrediario;
        private System.Windows.Forms.Button btVenda;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.MenuStrip mstMenus;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem1;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Label lbTitulo;

    }
}

