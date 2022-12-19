namespace Apresentacao
{
    partial class FrmAlterarExcluirFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlterarExcluirFornecedor));
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbRazaoSocial = new System.Windows.Forms.Label();
            this.lbNomeFantasia = new System.Windows.Forms.Label();
            this.lbCnpj = new System.Windows.Forms.Label();
            this.lbInscricaoEstadual = new System.Windows.Forms.Label();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.lbBairro = new System.Windows.Forms.Label();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbCidade = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.lbCep = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbCelular = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbRazaoSocial = new System.Windows.Forms.TextBox();
            this.tbNomeFantasia = new System.Windows.Forms.TextBox();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.mtbCnpj = new System.Windows.Forms.MaskedTextBox();
            this.mtbInscricaoEstadual = new System.Windows.Forms.MaskedTextBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.mtbCep = new System.Windows.Forms.MaskedTextBox();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btDesfazer = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.pbFornecedor = new System.Windows.Forms.PictureBox();
            this.epFornecedor = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCodigo.Location = new System.Drawing.Point(23, 99);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(61, 20);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "Código";
            // 
            // lbRazaoSocial
            // 
            this.lbRazaoSocial.AutoSize = true;
            this.lbRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbRazaoSocial.Location = new System.Drawing.Point(23, 134);
            this.lbRazaoSocial.Name = "lbRazaoSocial";
            this.lbRazaoSocial.Size = new System.Drawing.Size(108, 20);
            this.lbRazaoSocial.TabIndex = 2;
            this.lbRazaoSocial.Text = "Razão Social";
            // 
            // lbNomeFantasia
            // 
            this.lbNomeFantasia.AutoSize = true;
            this.lbNomeFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbNomeFantasia.Location = new System.Drawing.Point(23, 169);
            this.lbNomeFantasia.Name = "lbNomeFantasia";
            this.lbNomeFantasia.Size = new System.Drawing.Size(122, 20);
            this.lbNomeFantasia.TabIndex = 4;
            this.lbNomeFantasia.Text = "Nome Fantasia";
            // 
            // lbCnpj
            // 
            this.lbCnpj.AutoSize = true;
            this.lbCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCnpj.Location = new System.Drawing.Point(23, 204);
            this.lbCnpj.Name = "lbCnpj";
            this.lbCnpj.Size = new System.Drawing.Size(53, 20);
            this.lbCnpj.TabIndex = 6;
            this.lbCnpj.Text = "CNPJ";
            // 
            // lbInscricaoEstadual
            // 
            this.lbInscricaoEstadual.AutoSize = true;
            this.lbInscricaoEstadual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbInscricaoEstadual.Location = new System.Drawing.Point(23, 239);
            this.lbInscricaoEstadual.Name = "lbInscricaoEstadual";
            this.lbInscricaoEstadual.Size = new System.Drawing.Size(147, 20);
            this.lbInscricaoEstadual.TabIndex = 8;
            this.lbInscricaoEstadual.Text = "Inscrição Estadual";
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbEndereco.Location = new System.Drawing.Point(23, 274);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(80, 20);
            this.lbEndereco.TabIndex = 10;
            this.lbEndereco.Text = "Endereço";
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbBairro.Location = new System.Drawing.Point(23, 309);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(55, 20);
            this.lbBairro.TabIndex = 12;
            this.lbBairro.Text = "Bairro";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lbNumero.Location = new System.Drawing.Point(375, 312);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(24, 17);
            this.lbNumero.TabIndex = 14;
            this.lbNumero.Text = "N°";
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCidade.Location = new System.Drawing.Point(540, 134);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(61, 20);
            this.lbCidade.TabIndex = 16;
            this.lbCidade.Text = "Cidade";
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbEstado.Location = new System.Drawing.Point(540, 205);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(61, 20);
            this.lbEstado.TabIndex = 20;
            this.lbEstado.Text = "Estado";
            // 
            // lbCep
            // 
            this.lbCep.AutoSize = true;
            this.lbCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCep.Location = new System.Drawing.Point(540, 169);
            this.lbCep.Name = "lbCep";
            this.lbCep.Size = new System.Drawing.Size(43, 20);
            this.lbCep.TabIndex = 18;
            this.lbCep.Text = "CEP";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTelefone.Location = new System.Drawing.Point(540, 239);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(73, 20);
            this.lbTelefone.TabIndex = 22;
            this.lbTelefone.Text = "Telefone";
            // 
            // lbCelular
            // 
            this.lbCelular.AutoSize = true;
            this.lbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCelular.Location = new System.Drawing.Point(540, 274);
            this.lbCelular.Name = "lbCelular";
            this.lbCelular.Size = new System.Drawing.Size(62, 20);
            this.lbCelular.TabIndex = 24;
            this.lbCelular.Text = "Celular";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbEmail.Location = new System.Drawing.Point(540, 309);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(51, 20);
            this.lbEmail.TabIndex = 26;
            this.lbEmail.Text = "Email";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Enabled = false;
            this.tbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbCodigo.Location = new System.Drawing.Point(186, 92);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(66, 27);
            this.tbCodigo.TabIndex = 1;
            // 
            // tbRazaoSocial
            // 
            this.tbRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbRazaoSocial.Location = new System.Drawing.Point(187, 127);
            this.tbRazaoSocial.Name = "tbRazaoSocial";
            this.tbRazaoSocial.Size = new System.Drawing.Size(288, 27);
            this.tbRazaoSocial.TabIndex = 3;
            this.tbRazaoSocial.Leave += new System.EventHandler(this.tbRazaoSocial_Leave);
            // 
            // tbNomeFantasia
            // 
            this.tbNomeFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbNomeFantasia.Location = new System.Drawing.Point(187, 162);
            this.tbNomeFantasia.Name = "tbNomeFantasia";
            this.tbNomeFantasia.Size = new System.Drawing.Size(288, 27);
            this.tbNomeFantasia.TabIndex = 5;
            this.tbNomeFantasia.Leave += new System.EventHandler(this.tbNomeFantasia_Leave);
            // 
            // tbEndereco
            // 
            this.tbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbEndereco.Location = new System.Drawing.Point(187, 267);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(288, 27);
            this.tbEndereco.TabIndex = 11;
            this.tbEndereco.Leave += new System.EventHandler(this.tbEndereco_Leave);
            // 
            // tbBairro
            // 
            this.tbBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbBairro.Location = new System.Drawing.Point(187, 302);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(182, 27);
            this.tbBairro.TabIndex = 13;
            this.tbBairro.Leave += new System.EventHandler(this.tbBairro_Leave);
            // 
            // tbCidade
            // 
            this.tbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbCidade.Location = new System.Drawing.Point(626, 127);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(237, 27);
            this.tbCidade.TabIndex = 17;
            this.tbCidade.Leave += new System.EventHandler(this.tbCidade_Leave);
            // 
            // mtbCnpj
            // 
            this.mtbCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.mtbCnpj.Location = new System.Drawing.Point(187, 197);
            this.mtbCnpj.Mask = "##,###,###/####-##";
            this.mtbCnpj.Name = "mtbCnpj";
            this.mtbCnpj.Size = new System.Drawing.Size(201, 27);
            this.mtbCnpj.TabIndex = 7;
            this.mtbCnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbCnpj.Leave += new System.EventHandler(this.mtbCnpj_Leave);
            // 
            // mtbInscricaoEstadual
            // 
            this.mtbInscricaoEstadual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.mtbInscricaoEstadual.Location = new System.Drawing.Point(187, 232);
            this.mtbInscricaoEstadual.Mask = "###,###,###,###";
            this.mtbInscricaoEstadual.Name = "mtbInscricaoEstadual";
            this.mtbInscricaoEstadual.Size = new System.Drawing.Size(201, 27);
            this.mtbInscricaoEstadual.TabIndex = 9;
            this.mtbInscricaoEstadual.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbInscricaoEstadual.Leave += new System.EventHandler(this.mtbInscricaoEstadual_Leave);
            // 
            // tbNumero
            // 
            this.tbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbNumero.Location = new System.Drawing.Point(405, 302);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(70, 27);
            this.tbNumero.TabIndex = 15;
            this.tbNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumero_KeyPress);
            this.tbNumero.Leave += new System.EventHandler(this.tbNumero_Leave);
            // 
            // mtbCep
            // 
            this.mtbCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.mtbCep.Location = new System.Drawing.Point(626, 162);
            this.mtbCep.Mask = "99999-999";
            this.mtbCep.Name = "mtbCep";
            this.mtbCep.Size = new System.Drawing.Size(237, 27);
            this.mtbCep.TabIndex = 19;
            this.mtbCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbCep.Leave += new System.EventHandler(this.mtbCep_Leave);
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.mtbTelefone.Location = new System.Drawing.Point(626, 232);
            this.mtbTelefone.Mask = "(99) 0000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(237, 27);
            this.mtbTelefone.TabIndex = 23;
            this.mtbTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbTelefone.Leave += new System.EventHandler(this.mtbTelefone_Leave);
            // 
            // mtbCelular
            // 
            this.mtbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.mtbCelular.Location = new System.Drawing.Point(626, 267);
            this.mtbCelular.Mask = "(99) 00000-0000";
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.Size = new System.Drawing.Size(237, 27);
            this.mtbCelular.TabIndex = 25;
            this.mtbCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbCelular.Leave += new System.EventHandler(this.mtbCelular_Leave);
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbEmail.Location = new System.Drawing.Point(626, 302);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(237, 27);
            this.tbEmail.TabIndex = 27;
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piaui",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.cbEstado.Location = new System.Drawing.Point(626, 197);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(237, 28);
            this.cbEstado.TabIndex = 21;
            this.cbEstado.Leave += new System.EventHandler(this.tbEstado_Leave);
            // 
            // btAlterar
            // 
            this.btAlterar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btAlterar.FlatAppearance.BorderSize = 0;
            this.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlterar.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btAlterar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAlterar.Location = new System.Drawing.Point(27, 423);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(130, 42);
            this.btAlterar.TabIndex = 28;
            this.btAlterar.Text = "F10 Alterar";
            this.btAlterar.UseVisualStyleBackColor = false;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.DeepPink;
            this.btExcluir.FlatAppearance.BorderSize = 0;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btExcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btExcluir.Location = new System.Drawing.Point(163, 423);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(130, 42);
            this.btExcluir.TabIndex = 29;
            this.btExcluir.Text = "F2 Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btDesfazer
            // 
            this.btDesfazer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDesfazer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDesfazer.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btDesfazer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btDesfazer.Location = new System.Drawing.Point(299, 423);
            this.btDesfazer.Name = "btDesfazer";
            this.btDesfazer.Size = new System.Drawing.Size(130, 42);
            this.btDesfazer.TabIndex = 30;
            this.btDesfazer.Text = "F5 Desfazer";
            this.btDesfazer.UseVisualStyleBackColor = false;
            this.btDesfazer.Click += new System.EventHandler(this.btDesfazer_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Red;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSair.Location = new System.Drawing.Point(730, 423);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(130, 42);
            this.btSair.TabIndex = 31;
            this.btSair.Text = "Esc Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // pbFornecedor
            // 
            this.pbFornecedor.Image = global::Apresentacao.Properties.Resources.FornecedorLogo;
            this.pbFornecedor.Location = new System.Drawing.Point(27, 12);
            this.pbFornecedor.Name = "pbFornecedor";
            this.pbFornecedor.Size = new System.Drawing.Size(52, 52);
            this.pbFornecedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFornecedor.TabIndex = 32;
            this.pbFornecedor.TabStop = false;
            // 
            // epFornecedor
            // 
            this.epFornecedor.ContainerControl = this;
            // 
            // FrmAlterarExcluirFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(905, 499);
            this.Controls.Add(this.pbFornecedor);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btDesfazer);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.mtbCelular);
            this.Controls.Add(this.mtbTelefone);
            this.Controls.Add(this.mtbCep);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.mtbInscricaoEstadual);
            this.Controls.Add(this.mtbCnpj);
            this.Controls.Add(this.tbCidade);
            this.Controls.Add(this.tbBairro);
            this.Controls.Add(this.tbEndereco);
            this.Controls.Add(this.tbNomeFantasia);
            this.Controls.Add(this.tbRazaoSocial);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbCelular);
            this.Controls.Add(this.lbTelefone);
            this.Controls.Add(this.lbCep);
            this.Controls.Add(this.lbEstado);
            this.Controls.Add(this.lbCidade);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.lbBairro);
            this.Controls.Add(this.lbEndereco);
            this.Controls.Add(this.lbInscricaoEstadual);
            this.Controls.Add(this.lbCnpj);
            this.Controls.Add(this.lbNomeFantasia);
            this.Controls.Add(this.lbRazaoSocial);
            this.Controls.Add(this.lbCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmAlterarExcluirFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar & Excluir - Fornecedor";
            this.Load += new System.EventHandler(this.FrmAlterarExcluirFornecedor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAlterarExcluirFornecedor_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbRazaoSocial;
        private System.Windows.Forms.Label lbNomeFantasia;
        private System.Windows.Forms.Label lbCnpj;
        private System.Windows.Forms.Label lbInscricaoEstadual;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Label lbCep;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbCelular;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbRazaoSocial;
        private System.Windows.Forms.TextBox tbNomeFantasia;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.MaskedTextBox mtbCnpj;
        private System.Windows.Forms.MaskedTextBox mtbInscricaoEstadual;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.MaskedTextBox mtbCep;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.MaskedTextBox mtbCelular;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btDesfazer;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.PictureBox pbFornecedor;
        private System.Windows.Forms.ErrorProvider epFornecedor;
    }
}