using Espetinho_TCC.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Espetinho_TCC.Apresentação.Funcionario;

namespace Espetinho_TCC.Apresentação.Caixa
{
    public partial class frmValidarCompra : Form
    {
        #region Instâncias
        ClientesDAO cliDAO = new ClientesDAO();
        FuncionarioDAO funcDAO = new FuncionarioDAO();
        #endregion

        #region Variáveis
        public Boolean validou = false;
        public int idCli;
        public int idFunc = 0;
        #endregion

        #region Carregar Tela
        public frmValidarCompra(int id)
        {
            InitializeComponent();
            idFunc = id;
        }

        private void frmValidarCompra_Load(object sender, EventArgs e)
        {
            txtFuncionario.Text = funcDAO.funcPorID(idFunc).Nome_func.ToString();
        }
        #endregion

        #region Validar ou Invalidar Comanda
        private void btnSim_Click(object sender, EventArgs e)
        {
            if (txtFuncionario.Text == String.Empty)
            {
                txtFuncionario.BackColor = Color.Tomato;

                MessageBox.Show("Preencher todos os campos!", "ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                validou = true;
                Close();
            }
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            validou = false;
            Close();
        }
        #endregion

        #region Descolorir Campos
        private void txtFuncionario_TextChanged(object sender, EventArgs e)
        {
            txtFuncionario.BackColor = Color.Empty;
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            txtCliente.BackColor = Color.LawnGreen;
        }
        #endregion

        #region Selecionar Cliente
        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            frmSelecionarCliente telaSelecCli = new frmSelecionarCliente();
            telaSelecCli.ShowDialog();
            if (telaSelecCli.gvExibirClientes.Rows[telaSelecCli.gvExibirClientes.CurrentCell.RowIndex].DefaultCellStyle.SelectionBackColor == Color.GreenYellow)
            {
                idCli = Convert.ToInt32(telaSelecCli.gvExibirClientes.Rows[telaSelecCli.gvExibirClientes.CurrentCell.RowIndex].Cells[0].Value.ToString());
                txtCliente.Text = telaSelecCli.gvExibirClientes.Rows[telaSelecCli.gvExibirClientes.CurrentCell.RowIndex].Cells[1].Value.ToString();
            }
            else
            {
                MessageBox.Show("Você não escolheu nenhum cliente", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        #endregion

        #region Redirecionar para Tela de Gerenciar Funcionários
        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            frmGerenciarFuncionario telaGerFunc = new frmGerenciarFuncionario();
            telaGerFunc.ShowDialog();
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
