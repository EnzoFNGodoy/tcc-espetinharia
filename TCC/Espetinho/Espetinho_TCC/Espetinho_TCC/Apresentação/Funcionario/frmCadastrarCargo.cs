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

namespace Espetinho_TCC.Apresentação.Funcionario
{
    public partial class frmCadastrarCargo : Form
    {
        #region Instâncias
        CargoDAO cargoDAO = new CargoDAO();
        Cargo cargo = new Cargo();
        #endregion

        #region Inicializar Form
        public frmCadastrarCargo(string nomeUsu)
        {
            InitializeComponent();
            lblNomeUsuAtivo.Text = nomeUsu;
            lblNomeUsuAtivo.ForeColor = Color.LawnGreen;
        }
        #endregion  

        #region Cadastrar
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtCargo.Text == String.Empty)
            {
                txtCargo.BackColor = Color.Tomato;

                MessageBox.Show("Favor preencher todos os campos!", "CAMPOS VAZIOS!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    cargo.Tipo_cargo = txtCargo.Text;

                    cargoDAO.inserirCargo(cargo);

                    MessageBox.Show("Cargo cadastrado com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
