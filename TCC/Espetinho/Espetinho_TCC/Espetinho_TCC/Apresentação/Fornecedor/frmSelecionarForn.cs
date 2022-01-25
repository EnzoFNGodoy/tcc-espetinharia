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

namespace Espetinho_TCC.Apresentação.Controle_de_Estoque
{
    public partial class frmSelecionarForn : Form
    {
        FornecedorDAO fornDAO = new FornecedorDAO();

        public int idForn;

        public frmSelecionarForn()
        {
            InitializeComponent();
        }

        private void frmPesqFornEstoque_Load(object sender, EventArgs e)
        {
            gvExibirFornecedores.DataSource = fornDAO.listarFornecedor();
            atualizarGV();
        }

        private void atualizarGV()
        {
            try
            {
                gvExibirFornecedores.Columns[0].HeaderText = "Código";
                gvExibirFornecedores.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirFornecedores.Columns[1].HeaderText = "Razão Social";
                gvExibirFornecedores.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirFornecedores.Columns[2].HeaderText = "CPF";
                gvExibirFornecedores.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirFornecedores.Columns[3].HeaderText = "CNPJ";
                gvExibirFornecedores.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirFornecedores.Columns[4].HeaderText = "Email";
                gvExibirFornecedores.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                for (int i = 0; i < gvExibirFornecedores.Rows.Count; i++)
                {
                    gvExibirFornecedores.Rows[i].Height = 100;
                }
            }
            catch { }
        }

        private void gvExibirFornecedores_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            atualizarGV();
        }

        private void gvExibirFornecedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idForn = Convert.ToInt32(gvExibirFornecedores.Rows[gvExibirFornecedores.CurrentCell.RowIndex].Cells[0].Value.ToString());
            Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
