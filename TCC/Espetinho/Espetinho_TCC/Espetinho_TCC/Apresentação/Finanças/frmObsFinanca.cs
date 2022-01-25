using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Espetinho_TCC.Apresentação.Finanças
{
    public partial class frmObsFinanca : Form
    {
        string obs;

        public frmObsFinanca(string obsFinanca)
        {
            InitializeComponent();
            obs = obsFinanca;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmObsFinanca_Load(object sender, EventArgs e)
        {
            txtObs.Text = obs;
        }
    }
}
