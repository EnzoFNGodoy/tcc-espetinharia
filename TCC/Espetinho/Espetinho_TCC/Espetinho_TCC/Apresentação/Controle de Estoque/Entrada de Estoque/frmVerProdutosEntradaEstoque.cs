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

namespace Espetinho_TCC.Apresentação.Controle_de_Estoque.Entrada_de_Estoque
{
    public partial class frmVerProdutosEntradaEstoque : Form
    {
        ItensEntradaEstoqueDAO itsEntEstDAO = new ItensEntradaEstoqueDAO();
        DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
        int idEntrada;

        public frmVerProdutosEntradaEstoque(string id)
        {
            InitializeComponent();
            idEntrada = Convert.ToInt32(id);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmVerProdutosEntradaEstoque_Load(object sender, EventArgs e)
        {
            gvExibirProdutos.DataSource = itsEntEstDAO.listarProdutosEntradaEstoqueDataTable(idEntrada);
            atualizarGV();
            atualizarColunaFoto();
            txtIdEntradaEstoque.Text = idEntrada.ToString();
        }

        private void atualizarGV()
        {
            try
            {
                gvExibirProdutos.Columns[0].Visible = false;
                gvExibirProdutos.Columns[1].HeaderText = "Produtos";
                gvExibirProdutos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirProdutos.Columns[2].HeaderText = "Quantidade";
                gvExibirProdutos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirProdutos.Columns[3].HeaderText = "Preço Unit.";
                gvExibirProdutos.Columns[3].DefaultCellStyle.Format = "c";
                gvExibirProdutos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirProdutos.Columns[4].HeaderText = "Preço Total";
                gvExibirProdutos.Columns[4].DefaultCellStyle.Format = "c";
                gvExibirProdutos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirProdutos.Columns[5].Visible = false;
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
                Image imgProd = Image.FromFile(gvExibirProdutos.Rows[i].Cells[5].Value.ToString());
                gvExibirProdutos.Rows[i].Cells[6].Value = imgProd;
                gvExibirProdutos.Rows[i].Height = 100;
            }
        }

        private void gvExibirProdutos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            atualizarGV();
            atualizarColunaFoto();
        }
    }
}
