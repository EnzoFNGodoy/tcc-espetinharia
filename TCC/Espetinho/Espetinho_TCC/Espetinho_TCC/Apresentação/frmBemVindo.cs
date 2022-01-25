using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Espetinho_TCC.Utils;
using Espetinho_TCC.Apresentação;
using Resolucao;

namespace Espetinho_TCC
{
    public partial class frmBemVindo : Form
    {

        private int Altura = 0, Largura = 0;
        private int ArrumarAltura = 0, ArrumarLargura = 0;
        private int cont = 6;

        public frmBemVindo()
        {
            InitializeComponent();
        }

        private void tmrCarregar_Tick(object sender, EventArgs e)
        {
            if (pgbCarregar.Value < 100)
            {
                pgbCarregar.Value = pgbCarregar.Value + 2;
            }
            else
            {
                tmrCarregar.Enabled = false;
                this.Hide();
                frmPrincipal telaPrincipal = new frmPrincipal();
                telaPrincipal.ShowDialog();
            }
        }

        private void frmBemVindo_Load(object sender, EventArgs e)
        {
            tmrCarregar.Enabled = true;
            tmrContagem.Enabled = true;

            lblConexao.Text = (Conexao.criar_Conexao());

            Screen Srn = Screen.PrimaryScreen;
            Altura = Srn.Bounds.Height;
            Largura = Srn.Bounds.Width;

            ArrumarLargura = 1680;
            ArrumarAltura = 1050;

            if (Altura != 1050 && Largura != 1680)
            {
                Resolucao.CResolution MudarResolucao = new Resolucao.CResolution(ArrumarLargura, ArrumarAltura);
            }
        }

        private void tmrContagem_Tick(object sender, EventArgs e)
        {
            if (pgbCarregar.Value < 100)
            {
                cont--;
                lblContagemRegressiva.Text = "Iniciando em " + cont.ToString() + "...";
            }
            else
            {
                tmrContagem.Enabled = false;
            }
        }

        private void frmBemVindo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:

                    Application.Exit();

                    break;
            }
        }
    }
}
