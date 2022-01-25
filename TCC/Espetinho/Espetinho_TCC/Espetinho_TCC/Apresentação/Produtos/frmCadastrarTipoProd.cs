using Espetinho_TCC.DAO;
using Espetinho_TCC.Model;
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
    public partial class frmCadastrarTipoProd : Form
    {
        #region Instâncias
        TipoProdutoDAO tipoProdDAO = new TipoProdutoDAO();
        TipoProduto tipoProd = new TipoProduto();
        #endregion

        #region Inicializar Form
        public frmCadastrarTipoProd(string nomeUsu)
        {
            InitializeComponent();
            lblNomeUsuAtivo.Text = nomeUsu;
            lblNomeUsuAtivo.ForeColor = Color.LawnGreen;
        }
        #endregion

        #region Cadastro
        private void btnCadastrarProd_Click(object sender, EventArgs e)
        {
            if (txtTipoProd.Text == String.Empty)
            {
                txtTipoProd.BackColor = Color.Tomato;

                MessageBox.Show("Favor preencher todos os campos!", "CAMPOS VAZIOS!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    tipoProd.Tipo_produto = txtTipoProd.Text;

                    tipoProdDAO.inserirTipoProd(tipoProd);

                    MessageBox.Show("Categoria de produto cadastrada com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                }
                catch { }
            }
        }
        #endregion

        #region Fechar Tela
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
