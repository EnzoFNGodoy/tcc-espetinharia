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

namespace Espetinho_TCC.Apresentação.Usuarios
{
    public partial class frmCadastrarTipoUsuario : Form
    {
        #region Instâncias
        TipoUsuarioDAO tipoUsuDAO = new TipoUsuarioDAO();
        TipoUsuario tipoUsu = new TipoUsuario();
        #endregion

        #region Inicializar Form
        public frmCadastrarTipoUsuario(string nomeUsu)
        {
            InitializeComponent();
            lblNomeUsuAtivo.Text = nomeUsu;
            lblNomeUsuAtivo.ForeColor = Color.LawnGreen;
        }
        #endregion

        #region Cadastro
        private void btnCadastrarTipoUsu_Click(object sender, EventArgs e)
        {
            if (txtTipoUsuario.Text == String.Empty)
            {
                txtTipoUsuario.BackColor = Color.Tomato;

                MessageBox.Show("Favor preencher todos os campos!", "CAMPOS VAZIOS!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    tipoUsu.Tipo_usu = txtTipoUsuario.Text;

                    tipoUsuDAO.inserirTipoUsuario(tipoUsu);

                    MessageBox.Show("Tipo de usuário cadastrado com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                }
                catch
                { 
                    MessageBox.Show("Algum erro ocorreu. Verifique o campo digitado!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void txtTipoUsuario_TextChanged(object sender, EventArgs e)
        {
            txtTipoUsuario.BackColor = Color.Empty;
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
