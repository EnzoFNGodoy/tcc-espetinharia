using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Espetinho_TCC.Apresentação;
using Espetinho_TCC.Apresentação.Controle_de_Estoque;
using Espetinho_TCC.DAO;

namespace Espetinho_TCC.Apresentação
{
    public partial class frmControleEstoque : Form
    {
        ProdutoDAO prodDAO = new ProdutoDAO();
        DataGridViewImageColumn imgCol = new DataGridViewImageColumn();

        string comando = "";

        public frmControleEstoque(string nomeUsu)
        {
            InitializeComponent();
            lblNomeUsuAtivo.Text = nomeUsu;
            lblNomeUsuAtivo.ForeColor = Color.LawnGreen;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmControleEstoque_Load(object sender, EventArgs e)
        {
            gvExibirProdutos.DataSource = prodDAO.listarProduto();
            atualizarGV();
            atualizarColunaFoto();
        }

        private void atualizarGV()
        {
            try
            {
                gvExibirProdutos.Columns[0].HeaderText = "Código";
                gvExibirProdutos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirProdutos.Columns[1].HeaderText = "Produto";
                gvExibirProdutos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirProdutos.Columns[2].Visible = false;
                gvExibirProdutos.Columns[3].HeaderText = "Custo";
                gvExibirProdutos.Columns[3].DefaultCellStyle.Format = "c";
                gvExibirProdutos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirProdutos.Columns[4].HeaderText = "Preço";
                gvExibirProdutos.Columns[4].DefaultCellStyle.Format = "c";
                gvExibirProdutos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirProdutos.Columns[5].HeaderText = "Quantidade";
                gvExibirProdutos.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

        private void atualizarColunaFoto()
        {
            for (int i = 0; i < gvExibirProdutos.Rows.Count; i++)
            {
                Image imgProd = Image.FromFile(gvExibirProdutos.Rows[i].Cells[8].Value.ToString());
                gvExibirProdutos.Rows[i].Cells[9].Value = imgProd;
                gvExibirProdutos.Rows[i].Height = 100;
            }
        }

        private void btnPesquisarPorNome_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNomeProd.Text != String.Empty)
                {
                    gvExibirProdutos.Columns.Clear();
                    gvExibirProdutos.DataSource = prodDAO.PesquisarProdNomeGV(txtNomeProd.Text);
                    atualizarGV();
                    atualizarColunaFoto();
                }
            }
            catch { }
        }

        private void btnPesquisarPorID_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text != String.Empty)
                {
                    gvExibirProdutos.Columns.Clear();
                    gvExibirProdutos.DataSource = prodDAO.produtoPorIDGV(Convert.ToInt32(txtID.Text));
                    atualizarGV();
                    atualizarColunaFoto();
                }
            }
            catch { }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            gvExibirProdutos.Columns.Clear();
            gvExibirProdutos.DataSource = prodDAO.listarProduto();
            txtID.Clear();
            txtNomeProd.Clear();
            cmbPesqPorEstoque.Text = "";
            cmbPesqPorEstoque.SelectedItem = null;
            atualizarGV();
            atualizarColunaFoto();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtNomeProd.Clear();
            cmbPesqPorEstoque.SelectedItem = null;
            for (int i = 0; i < gvExibirProdutos.RowCount; i++)
            {
                gvExibirProdutos.Rows[i].DataGridView.Columns.Clear();
            }
        }

        private void cmbPesqPorEstoque_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtID.Clear();
            txtNomeProd.Clear();
            if (cmbPesqPorEstoque.SelectedIndex == 0)
            {
                comando = "p.qtdest_prod <= 10";
            } // MENOS DE 10
            if (cmbPesqPorEstoque.SelectedIndex == 1)
            {
                comando = "p.qtdest_prod >= 10 and p.qtdest_prod < 50";
            } // ENTRE 10 E 50
            if (cmbPesqPorEstoque.SelectedIndex == 2)
            {
                comando = "p.qtdest_prod >= 50 and p.qtdest_prod < 100";
            } // ENTRE 50 E 100
            if (cmbPesqPorEstoque.SelectedIndex == 3)
            {
                comando = "p.qtdest_prod >= 100";
            } // MAIS DE 100
        }

        private void btnPesqEstoque_Click(object sender, EventArgs e)
        {
            if (cmbPesqPorEstoque.SelectedItem != null)
            {
                gvExibirProdutos.Columns.Clear();
                gvExibirProdutos.DataSource = prodDAO.produtoPorEstoque(comando);
                atualizarGV();
                atualizarColunaFoto();
            }
        }

        private void gvExibirProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String nomeProd, imgProd, nomeForn, tipoProd;
            int idProd, qtdEstProd;
            double custoProd, precoProd;

            nomeProd = gvExibirProdutos.Rows[gvExibirProdutos.CurrentCell.RowIndex].Cells[1].Value.ToString();
            imgProd = gvExibirProdutos.Rows[gvExibirProdutos.CurrentCell.RowIndex].Cells[8].Value.ToString();
            nomeForn = gvExibirProdutos.Rows[gvExibirProdutos.CurrentCell.RowIndex].Cells[7].Value.ToString();
            tipoProd = gvExibirProdutos.Rows[gvExibirProdutos.CurrentCell.RowIndex].Cells[6].Value.ToString();
            idProd = Convert.ToInt32(gvExibirProdutos.Rows[gvExibirProdutos.CurrentCell.RowIndex].Cells[0].Value.ToString());
            qtdEstProd = Convert.ToInt32(gvExibirProdutos.Rows[gvExibirProdutos.CurrentCell.RowIndex].Cells[5].Value.ToString());
            custoProd = Convert.ToDouble(gvExibirProdutos.Rows[gvExibirProdutos.CurrentCell.RowIndex].Cells[3].Value.ToString());
            precoProd = Convert.ToDouble(gvExibirProdutos.Rows[gvExibirProdutos.CurrentCell.RowIndex].Cells[4].Value.ToString());

            frmGerenciarProduto telaGerenciarProd = new frmGerenciarProduto(lblNomeUsuAtivo.Text, idProd, qtdEstProd, nomeProd, custoProd, precoProd, nomeForn, tipoProd, imgProd);
            telaGerenciarProd.ShowDialog();

            atualizarGV();
            atualizarColunaFoto();
        }

        private void btnEntradas_Click(object sender, EventArgs e)
        {
            frmEntradaEstoque telaRegEntradaEstoque = new frmEntradaEstoque(lblNomeUsuAtivo.Text);
            telaRegEntradaEstoque.ShowDialog();
        }

        private void btnSaidas_Click(object sender, EventArgs e)
        {
            frmSaidaEstoque telaSaidaEst = new frmSaidaEstoque(lblNomeUsuAtivo.Text);
            telaSaidaEst.ShowDialog();
        }

        private void gvExibirProdutos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            atualizarGV();
            atualizarColunaFoto();
        }

        private void txtNomeProd_TextChanged(object sender, EventArgs e)
        {
            txtID.Clear();
            cmbPesqPorEstoque.Text = "";
            cmbPesqPorEstoque.SelectedItem = null;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            txtNomeProd.Clear();
            cmbPesqPorEstoque.Text = "";
            cmbPesqPorEstoque.SelectedItem = null;
        }
    }
}
