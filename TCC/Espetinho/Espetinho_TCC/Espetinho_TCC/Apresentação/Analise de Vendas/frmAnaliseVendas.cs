using Espetinho_TCC.Apresentação.Analise_de_Vendas;
using Espetinho_TCC.DAO;
using Espetinho_TCC.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Espetinho_TCC.Apresentação
{
    public partial class frmAnaliseVendas : Form
    {
        #region INSTANCIAS
        ComandaDAO comDAO = new ComandaDAO();
        #endregion

        public frmAnaliseVendas(String nomeUsu)
        {
            InitializeComponent();
            lblNomeUsuAtivo.Text = nomeUsu;
            lblNomeUsuAtivo.ForeColor = Color.LawnGreen;
        }

        private void frmAnaliseVendas_Load(object sender, EventArgs e)
        {

        }

        #region Metodo para abrir form no Panel
        public void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form tela;
            tela = pnlConteudo.Controls.OfType<Forms>().FirstOrDefault();

            if (tela == null)
            {
                tela = new Forms();
                tela.TopLevel = false;
                tela.FormBorderStyle = FormBorderStyle.None;
                pnlConteudo.Controls.Add(tela);
                tela.Dock = DockStyle.Fill;
                pnlConteudo.Tag = tela;
                tela.Show();
                tela.BringToFront();
            }
            else
            {
                if (tela.WindowState == FormWindowState.Minimized)
                    tela.WindowState = FormWindowState.Normal;
                tela.BringToFront();
            }
        }
        #endregion

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void vendasGeraisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<frmVendasGerais>();
        }

        private void vendasPorProdutosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<frmVendasProdutos>();
        }
    }
}
