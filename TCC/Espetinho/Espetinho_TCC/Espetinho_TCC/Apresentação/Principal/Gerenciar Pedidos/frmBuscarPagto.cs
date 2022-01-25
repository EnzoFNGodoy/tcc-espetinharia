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
    public partial class frmBuscarPagto : Form
    {
        PagamentoDAO pagDAO = new PagamentoDAO();
        public frmBuscarPagto()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmBuscarPagto_Load(object sender, EventArgs e)
        {
            gvExibirPagamentos.DataSource = pagDAO.listarPagamento();
            atualizarGV();
        }

        public void atualizarGV()
        {
            try
            {
                gvExibirPagamentos.Columns[0].HeaderText = "Código";
                gvExibirPagamentos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirPagamentos.Columns[1].HeaderText = "Tipo Pagamento";
                gvExibirPagamentos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                for (int i = 0; i < gvExibirPagamentos.Rows.Count; i++)
                {
                    gvExibirPagamentos.Rows[i].Height = 60;
                }
            }
            catch { }
        }
    }
}
