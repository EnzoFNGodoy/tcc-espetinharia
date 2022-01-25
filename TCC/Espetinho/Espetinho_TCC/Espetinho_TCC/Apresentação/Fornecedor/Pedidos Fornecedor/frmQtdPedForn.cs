using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Espetinho_TCC.Apresentação.Fornecedor
{
    public partial class frmQtdPedForn : Form
    {
        DAO.ProdutoDAO prodDAO = new DAO.ProdutoDAO();
        int idProd;

        public frmQtdPedForn(int id)
        {
            InitializeComponent();
            idProd = id;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            btnContinuar.Enabled = false;
            btnCancelar.Enabled = true;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnContinuar.Enabled = true;
            btnCancelar.Enabled = false;
            Close();
        }

        private void frmQtdPedForn_Load(object sender, EventArgs e)
        {
            btnContinuar.Enabled = true;
            btnCancelar.Enabled = true;
            txtQtdProd.Text = "0";
            txtQtdEstoque.Text = prodDAO.produtoPorID(idProd).QtdEst_prod.ToString();

        }
        #region Aumentar e Diminuir Quantidade
        private void txtQtdProd_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtQtdEstoque.Text = Convert.ToInt32(prodDAO.Prod.QtdEst_prod - Convert.ToInt32(txtQtdProd.Text)).ToString();
                if (Convert.ToInt32(txtQtdProd.Text) > prodDAO.Prod.QtdEst_prod)
                {
                    txtQtdProd.Text = (Convert.ToInt32(txtQtdProd.Text) - 1).ToString();
                    MessageBox.Show("Quantidade Insuficiente!", "Erro!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch { }
            txtQtdProd.BackColor = Color.Empty;
        }

        private void btnAumentarQtd_Click(object sender, EventArgs e)
        {
            try
            {
                txtQtdProd.Text = (Convert.ToInt32(txtQtdProd.Text) + 1).ToString();
                if (txtQtdProd.Text != "0")
                {
                    if (txtQtdProd.Text == "1")
                    {
                        btnDiminuirQtd.Enabled = false;
                    }
                    if (Convert.ToInt32(txtQtdProd.Text) < 0)
                    {
                        txtQtdProd.Text = (Convert.ToInt32(txtQtdProd.Text) + 1).ToString();
                        MessageBox.Show("Quantidade negativa!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        btnDiminuirQtd.Enabled = true;
                    }
                }
            }
            catch { }
        }

        private void btnDiminuirQtd_Click(object sender, EventArgs e)
        {
            try
            {
                txtQtdProd.Text = (Convert.ToInt32(txtQtdProd.Text) - 1).ToString();
                if (txtQtdProd.Text != "0")
                {
                    if (txtQtdProd.Text == "1")
                    {
                        btnDiminuirQtd.Enabled = false;
                    }
                    if (Convert.ToInt32(txtQtdProd.Text) < 0)
                    {
                        txtQtdProd.Text = (Convert.ToInt32(txtQtdProd.Text) + 1).ToString();
                        MessageBox.Show("Quantidade negativa!!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        btnDiminuirQtd.Enabled = true;
                    }
                }
            }
            catch { }
        }
        #endregion

        private void txtQtdEstoque_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
