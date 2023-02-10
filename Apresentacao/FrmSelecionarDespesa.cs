using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmSelecionarDespesa : Form
    {
        public FrmSelecionarDespesa()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastrarDespesa frmCadastroDespesa = new FrmCadastrarDespesa();
            frmCadastroDespesa.ShowDialog();
        }
    }
}
