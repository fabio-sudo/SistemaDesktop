namespace Apresentacao
{
    partial class FrmCadastroFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroFornecedor));
            this.btSair = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtbCep = new System.Windows.Forms.MaskedTextBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.mtbInscricaoEstadual = new System.Windows.Forms.MaskedTextBox();
            this.mtbCnpj = new System.Windows.Forms.MaskedTextBox();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.tbNomeFantasia = new System.Windows.Forms.TextBox();
            this.tbRazaoSocial = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbCelular = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbCep = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.lbCidade = new System.Windows.Forms.Label();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbBairro = new System.Windows.Forms.Label();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.lbInscricaoEstadual = new System.Windows.Forms.Label();
            this.lbCnpj = new System.Windows.Forms.Label();
            this.lbNomeFantasia = new System.Windows.Forms.Label();
            this.lbRazaoSocial = new System.Windows.Forms.Label();
            this.pbFornecedor = new System.Windows.Forms.PictureBox();
            this.epFornecedor = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Red;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSair.Location = new System.Drawing.Point(730, 388);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(130, 42);
            this.btSair.TabIndex = 27;
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
            this.btCadastrar.Location = new System.Drawing.Point(594, 388);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(130, 42);
            this.btCadastrar.TabIndex = 26;
            this.btCadastrar.Text = "F10 Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
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
            this.cbEstado.Location = new System.Drawing.Point(626, 162);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(237, 28);
            this.cbEstado.TabIndex = 19;
            this.cbEstado.Leave += new System.EventHandler(this.tbEstado_Leave);
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbEmail.Location = new System.Drawing.Point(626, 267);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(237, 27);
            this.tbEmail.TabIndex = 25;
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // mtbCelular
            // 
            this.mtbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.mtbCelular.Location = new System.Drawing.Point(626, 232);
            this.mtbCelular.Mask = "(99) 00000-0000";
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.Size = new System.Drawing.Size(237, 27);
            this.mtbCelular.TabIndex = 23;
            this.mtbCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbCelular.Leave += new System.EventHandler(this.mtbCelular_Leave);
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.mtbTelefone.Location = new System.Drawing.Point(626, 197);
            this.mtbTelefone.Mask = "(99) 0000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(237, 27);
            this.mtbTelefone.TabIndex = 21;
            this.mtbTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbTelefone.Leave += new System.EventHandler(this.mtbTelefone_Leave);
            // 
            // mtbCep
            // 
            this.mtbCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.mtbCep.Location = new System.Drawing.Point(626, 127);
            this.mtbCep.Mask = "99999-999";
            this.mtbCep.Name = "mtbCep";
            this.mtbCep.Size = new System.Drawing.Size(237, 27);
            this.mtbCep.TabIndex = 17;
            this.mtbCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbCep.Leave += new System.EventHandler(this.mtbCep_Leave);
            // 
            // tbNumero
            // 
            this.tbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbNumero.Location = new System.Drawing.Point(410, 267);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(70, 27);
            this.tbNumero.TabIndex = 13;
            this.tbNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumero_KeyPress);
            this.tbNumero.Leave += new System.EventHandler(this.tbNumero_Leave);
            // 
            // mtbInscricaoEstadual
            // 
            this.mtbInscricaoEstadual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.mtbInscricaoEstadual.Location = new System.Drawing.Point(192, 197);
            this.mtbInscricaoEstadual.Mask = "###,###,###,###";
            this.mtbInscricaoEstadual.Name = "mtbInscricaoEstadual";
            this.mtbInscricaoEstadual.Size = new System.Drawing.Size(201, 27);
            this.mtbInscricaoEstadual.TabIndex = 7;
            this.mtbInscricaoEstadual.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbInscricaoEstadual.Leave += new System.EventHandler(this.mtbInscricaoEstadual_Leave);
            // 
            // mtbCnpj
            // 
            this.mtbCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.mtbCnpj.Location = new System.Drawing.Point(192, 162);
            this.mtbCnpj.Mask = "##,###,###/####-##";
            this.mtbCnpj.Name = "mtbCnpj";
            this.mtbCnpj.Size = new System.Drawing.Size(201, 27);
            this.mtbCnpj.TabIndex = 5;
            this.mtbCnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbCnpj.Leave += new System.EventHandler(this.mtbCnpj_Leave);
            // 
            // tbCidade
            // 
            this.tbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbCidade.Location = new System.Drawing.Point(626, 92);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(237, 27);
            this.tbCidade.TabIndex = 15;
            this.tbCidade.Leave += new System.EventHandler(this.tbCidade_Leave);
            // 
            // tbBairro
            // 
            this.tbBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbBairro.Location = new System.Drawing.Point(192, 267);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(182, 27);
            this.tbBairro.TabIndex = 11;
            this.tbBairro.Leave += new System.EventHandler(this.tbBairro_Leave);
            // 
            // tbEndereco
            // 
            this.tbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbEndereco.Location = new System.Drawing.Point(192, 232);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(288, 27);
            this.tbEndereco.TabIndex = 9;
            this.tbEndereco.Leave += new System.EventHandler(this.tbEndereco_Leave);
            // 
            // tbNomeFantasia
            // 
            this.tbNomeFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbNomeFantasia.Location = new System.Drawing.Point(192, 127);
            this.tbNomeFantasia.Name = "tbNomeFantasia";
            this.tbNomeFantasia.Size = new System.Drawing.Size(288, 27);
            this.tbNomeFantasia.TabIndex = 3;
            this.tbNomeFantasia.Leave += new System.EventHandler(this.tbNomeFantasia_Leave);
            // 
            // tbRazaoSocial
            // 
            this.tbRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.tbRazaoSocial.Location = new System.Drawing.Point(192, 92);
            this.tbRazaoSocial.Name = "tbRazaoSocial";
            this.tbRazaoSocial.Size = new System.Drawing.Size(288, 27);
            this.tbRazaoSocial.TabIndex = 1;
            this.tbRazaoSocial.Leave += new System.EventHandler(this.tbRazaoSocial_Leave);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbEmail.Location = new System.Drawing.Point(544, 274);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(51, 20);
            this.lbEmail.TabIndex = 24;
            this.lbEmail.Text = "Email";
            // 
            // lbCelular
            // 
            this.lbCelular.AutoSize = true;
            this.lbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCelular.Location = new System.Drawing.Point(544, 239);
            this.lbCelular.Name = "lbCelular";
            this.lbCelular.Size = new System.Drawing.Size(62, 20);
            this.lbCelular.TabIndex = 22;
            this.lbCelular.Text = "Celular";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTelefone.Location = new System.Drawing.Point(544, 204);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(73, 20);
            this.lbTelefone.TabIndex = 20;
            this.lbTelefone.Text = "Telefone";
            // 
            // lbCep
            // 
            this.lbCep.AutoSize = true;
            this.lbCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCep.Location = new System.Drawing.Point(544, 134);
            this.lbCep.Name = "lbCep";
            this.lbCep.Size = new System.Drawing.Size(43, 20);
            this.lbCep.TabIndex = 16;
            this.lbCep.Text = "CEP";
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbEstado.Location = new System.Drawing.Point(544, 170);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(61, 20);
            this.lbEstado.TabIndex = 18;
            this.lbEstado.Text = "Estado";
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCidade.Location = new System.Drawing.Point(544, 99);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(61, 20);
            this.lbCidade.TabIndex = 14;
            this.lbCidade.Text = "Cidade";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lbNumero.Location = new System.Drawing.Point(380, 277);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(24, 17);
            this.lbNumero.TabIndex = 12;
            this.lbNumero.Text = "N°";
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbBairro.Location = new System.Drawing.Point(27, 274);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(55, 20);
            this.lbBairro.TabIndex = 10;
            this.lbBairro.Text = "Bairro";
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbEndereco.Location = new System.Drawing.Point(27, 239);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(80, 20);
            this.lbEndereco.TabIndex = 8;
            this.lbEndereco.Text = "Endereço";
            // 
            // lbInscricaoEstadual
            // 
            this.lbInscricaoEstadual.AutoSize = true;
            this.lbInscricaoEstadual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbInscricaoEstadual.Location = new System.Drawing.Point(27, 204);
            this.lbInscricaoEstadual.Name = "lbInscricaoEstadual";
            this.lbInscricaoEstadual.Size = new System.Drawing.Size(147, 20);
            this.lbInscricaoEstadual.TabIndex = 6;
            this.lbInscricaoEstadual.Text = "Inscrição Estadual";
            // 
            // lbCnpj
            // 
            this.lbCnpj.AutoSize = true;
            this.lbCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCnpj.Location = new System.Drawing.Point(27, 169);
            this.lbCnpj.Name = "lbCnpj";
            this.lbCnpj.Size = new System.Drawing.Size(53, 20);
            this.lbCnpj.TabIndex = 4;
            this.lbCnpj.Text = "CNPJ";
            // 
            // lbNomeFantasia
            // 
            this.lbNomeFantasia.AutoSize = true;
            this.lbNomeFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbNomeFantasia.Location = new System.Drawing.Point(27, 134);
            this.lbNomeFantasia.Name = "lbNomeFantasia";
            this.lbNomeFantasia.Size = new System.Drawing.Size(122, 20);
            this.lbNomeFantasia.TabIndex = 2;
            this.lbNomeFantasia.Text = "Nome Fantasia";
            // 
            // lbRazaoSocial
            // 
            this.lbRazaoSocial.AutoSize = true;
            this.lbRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbRazaoSocial.Location = new System.Drawing.Point(27, 99);
            this.lbRazaoSocial.Name = "lbRazaoSocial";
            this.lbRazaoSocial.Size = new System.Drawing.Size(108, 20);
            this.lbRazaoSocial.TabIndex = 0;
            this.lbRazaoSocial.Text = "Razão Social";
            // 
            // pbFornecedor
            // 
            this.pbFornecedor.Image = global::Apresentacao.Properties.Resources.FornecedorLogo;
            this.pbFornecedor.Location = new System.Drawing.Point(27, 12);
            this.pbFornecedor.Name = "pbFornecedor";
            this.pbFornecedor.Size = new System.Drawing.Size(52, 52);
            this.pbFornecedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFornecedor.TabIndex = 65;
            this.pbFornecedor.TabStop = false;
            // 
            // epFornecedor
            // 
            this.epFornecedor.ContainerControl = this;
            // 
            // FrmCadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(905, 451);
            this.Controls.Add(this.pbFornecedor);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btCadastrar);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmCadastroFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Fornecedor";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadastroFornecedor_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFornecedor;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.MaskedTextBox mtbCelular;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.MaskedTextBox mtbCep;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.MaskedTextBox mtbInscricaoEstadual;
        private System.Windows.Forms.MaskedTextBox mtbCnpj;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.TextBox tbNomeFantasia;
        private System.Windows.Forms.TextBox tbRazaoSocial;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbCelular;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbCep;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.Label lbInscricaoEstadual;
        private System.Windows.Forms.Label lbCnpj;
        private System.Windows.Forms.Label lbNomeFantasia;
        private System.Windows.Forms.Label lbRazaoSocial;
        private System.Windows.Forms.ErrorProvider epFornecedor;
    }
}