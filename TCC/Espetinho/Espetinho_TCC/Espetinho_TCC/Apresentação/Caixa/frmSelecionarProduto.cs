using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Espetinho_TCC.Apresentação;
using Espetinho_TCC.Model;
using Espetinho_TCC.DAO;

namespace Espetinho_TCC.Apresentação.Caixa
{
    public partial class frmSelecionarProduto : Form
    {
        #region Instâncias
        ProdutoDAO prodDAO = new ProdutoDAO();
        #endregion

        #region Criação Coluna de Imagem
        DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
        #endregion

        #region Carregar Form
        public frmSelecionarProduto()
        {
            InitializeComponent();
        }

        private void frmSelecionarProduto_Load(object sender, EventArgs e)
        {
            gvExibirProdutos.DataSource = prodDAO.listarProduto();
            try
            {
                atualizarGV();
                atualizarColunaFoto();
            }
            catch { }
        }
        #endregion

        #region Método para AtualizarGridView
        private void atualizarGV()
        {
            try
            {
                gvExibirProdutos.Columns[0].HeaderText = "Código";
                gvExibirProdutos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirProdutos.Columns[1].HeaderText = "Produto";
                gvExibirProdutos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirProdutos.Columns[4].HeaderText = "Preço";
                gvExibirProdutos.Columns[4].DefaultCellStyle.Format = "c";
                gvExibirProdutos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirProdutos.Columns[5].HeaderText = "Estoque";
                gvExibirProdutos.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirProdutos.Columns[2].Visible = false;
                gvExibirProdutos.Columns[3].Visible = false;
                gvExibirProdutos.Columns[6].Visible = false;
                gvExibirProdutos.Columns[7].Visible = false;
                gvExibirProdutos.Columns[8].Visible = false;
                gvExibirProdutos.Columns.Add(imgCol);
                imgCol.HeaderText = "Foto";
                imgCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                imgCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            catch { }
        }
        #endregion

        #region Método para Atualizar Coluna de Imagem
        private void atualizarColunaFoto()
        {
            for (int i = 0; i < gvExibirProdutos.Rows.Count; i++)
            {
                Image imgProd = Image.FromFile(gvExibirProdutos.Rows[i].Cells[8].Value.ToString());
                gvExibirProdutos.Rows[i].Cells[9].Value = imgProd;
                gvExibirProdutos.Rows[i].Height = 100;
            }
        }
        #endregion

        #region Duplo Clique no GridView
        private void gvExibirProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            gvExibirProdutos.Rows[gvExibirProdutos.CurrentCell.RowIndex].DefaultCellStyle.SelectionBackColor = Color.GreenYellow;
            Close();
        }
        #endregion

        #region Atualizar GridView e Coluna de Imagem ao Clicar na Célula de Cabeçalho
        private void gvExibirProdutos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            atualizarGV();
            atualizarColunaFoto();
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
