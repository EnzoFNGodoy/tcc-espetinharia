using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Espetinho_TCC.Apresentação.Controle_de_Estoque
{
    public partial class frmObsSaidaEstoque : Form
    {
        string obs;

        public frmObsSaidaEstoque(string Observacao)
        {
            InitializeComponent();
            obs = Observacao;
        }

        private void frmObsSaidaEstoque_Load(object sender, EventArgs e)
        {
            txtObs.Text = obs;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
