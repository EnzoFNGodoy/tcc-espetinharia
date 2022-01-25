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
    public partial class frmPesqFPedidosForn : Form
    {
        DAO.FornecedorDAO FornDao = new DAO.FornecedorDAO();
        public int idFornecedor;

        public frmPesqFPedidosForn()
        {
            InitializeComponent();
        }

        private void frmPesqFPedidosForn_Load(object sender, EventArgs e)
        {
            gvExibirFornecedores.DataSource = FornDao.listarFornsGV();
            atualizarGV();
        }

        private void atualizarGV()
        {
            try
            {
                gvExibirFornecedores.Columns[0].HeaderText = "Código";
                gvExibirFornecedores.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirFornecedores.Columns[1].HeaderText = "Fornecedor";
                gvExibirFornecedores.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirFornecedores.Columns[2].HeaderText = "CPF";
                gvExibirFornecedores.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirFornecedores.Columns[3].HeaderText = "CNPJ";
                gvExibirFornecedores.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirFornecedores.Columns[4].HeaderText = "Email";
                gvExibirFornecedores.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                for (int i = 0; i < gvExibirFornecedores.Rows.Count; i++)
                {
                    gvExibirFornecedores.Rows[i].Height = 80;
                }
            }
            catch { }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gvExibirFornecedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idFornecedor = Convert.ToInt32(gvExibirFornecedores.Rows[gvExibirFornecedores.CurrentCell.RowIndex].Cells[0].Value.ToString());
            Close();
        }
    }
}
