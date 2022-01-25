using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Espetinho_TCC.DAO;

namespace Espetinho_TCC.Apresentação.Principal
{
    public partial class frmBuscarFunc : Form
    {
        FuncionarioDAO funcDAO = new FuncionarioDAO();
        public frmBuscarFunc()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmBuscarFunc_Load(object sender, EventArgs e)
        {
            gvExibirFuncionarios.DataSource = funcDAO.listarFuncGerenciarPedido();
            atualizarGV();
        }

        public void atualizarGV()
        {
            try
            {
                gvExibirFuncionarios.Columns[0].HeaderText = "Código";
                gvExibirFuncionarios.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirFuncionarios.Columns[1].HeaderText = "Cargo";
                gvExibirFuncionarios.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                for (int i = 0; i < gvExibirFuncionarios.Rows.Count; i++)
                {
                    gvExibirFuncionarios.Rows[i].Height = 60;
                }
            }
            catch { }
        }
    }
}
