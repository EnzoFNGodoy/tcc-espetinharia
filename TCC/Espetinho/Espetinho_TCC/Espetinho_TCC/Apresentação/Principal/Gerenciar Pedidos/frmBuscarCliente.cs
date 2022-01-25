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
    public partial class frmBuscarCliente : Form
    {
        ClientesDAO cliDAO = new ClientesDAO();

        public frmBuscarCliente()
        {
            InitializeComponent();
        }

        private void frmBuscarCliente_Load(object sender, EventArgs e)
        {
            gvExibirClientes.DataSource = cliDAO.listarClientes();
            atualizarGV();
        }

        public void atualizarGV()
        {
            try
            {
                gvExibirClientes.Columns[0].HeaderText = "Código";
                gvExibirClientes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirClientes.Columns[1].HeaderText = "Cliente";
                gvExibirClientes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirClientes.Columns[2].HeaderText = "CPF";
                gvExibirClientes.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirClientes.Columns[3].HeaderText = "CNPJ";
                gvExibirClientes.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirClientes.Columns[4].HeaderText = "Email";
                gvExibirClientes.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                for (int i = 0; i < gvExibirClientes.Rows.Count; i++)
                {
                    gvExibirClientes.Rows[i].Height = 60;
                }
            }
            catch { }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gvExibirClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            gvExibirClientes.Rows[gvExibirClientes.CurrentCell.RowIndex].DefaultCellStyle.SelectionBackColor = Color.GreenYellow;
            Close();
        }
    }
}
