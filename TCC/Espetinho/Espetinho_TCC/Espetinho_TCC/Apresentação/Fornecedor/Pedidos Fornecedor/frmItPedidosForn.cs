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

namespace Espetinho_TCC.Apresentação.Fornecedor
{
    public partial class frmItPedidosForn : Form
    {
        PedidosFornDAO pedfornDAO = new PedidosFornDAO();
        ItensPedidoFornDAO ItPedDAO = new ItensPedidoFornDAO();
        DataGridViewImageColumn imgCol = new DataGridViewImageColumn();

        int idPed;
        public frmItPedidosForn(string id)
        {
            InitializeComponent();
            idPed = Convert.ToInt32(id);
        }

        private void frmItPedidosForn_Load(object sender, EventArgs e)
        {
            gvExibirProdutos.DataSource = ItPedDAO.ListarItensPedido(idPed);
            atualizarGV();
            atualizarColunaFoto();
            txtIdPedido.Text = idPed.ToString();
        }

        private void atualizarGV()
        {
            try
            {
                gvExibirProdutos.Columns[0].HeaderText = "Código";
                gvExibirProdutos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                gvExibirProdutos.Columns[1].HeaderText = "Produtos";
                gvExibirProdutos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                gvExibirProdutos.Columns[2].HeaderText = "Quantidade";
                gvExibirProdutos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                gvExibirProdutos.Columns[3].Visible = false;

                gvExibirProdutos.Columns.Add(imgCol);
                imgCol.HeaderText = "Foto";
                imgCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                imgCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            catch { }
        }

        private void atualizarColunaFoto()
        {
            for (int i = 0; i < gvExibirProdutos.Rows.Count; i++)
            {
                Image imgProd = Image.FromFile(gvExibirProdutos.Rows[i].Cells[3].Value.ToString());
                gvExibirProdutos.Rows[i].Cells[4].Value = imgProd;
                gvExibirProdutos.Rows[i].Height = 100;
            }
        }

        private void gvExibirProdutos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            atualizarGV();
            atualizarColunaFoto();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
