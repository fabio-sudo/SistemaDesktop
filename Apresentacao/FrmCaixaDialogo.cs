﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmCaixaDialogo : Form
    {
        //Criação do Formulário
        public FrmCaixaDialogo(string NomeFormulario,string Texto,Image logoForm, Color corFundo, Color corTexto, string bt1, string bt2,[Optional] Boolean Scrol)
        {
            InitializeComponent();

            this.Text = NomeFormulario;
            tbTexto.Text = Texto;
            pbFormulario.Image = logoForm;
            this.BackColor = corFundo;
            tbTexto.BackColor = corFundo;
            tbTexto.ForeColor = corTexto;
            btConfirmar.Text = bt1;

            if (Scrol == true)
            {
                tbTexto.ScrollBars = ScrollBars.Vertical;
            }
                if (bt2 == "")
            {
                btCancelar.Visible = false;
                this.btConfirmar.Location = new Point(122,135);
            }
            else
            {
                btCancelar.Visible = true;
                btCancelar.Text = bt2;
            }


        }

        //Cancelar
        private void btCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        //Confirmar Sair do formulario
        private void btConfirmar_Click(object sender, EventArgs e)
        {
            
            DialogResult = DialogResult.Yes;

        }

    }
}
