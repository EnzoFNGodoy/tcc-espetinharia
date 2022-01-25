using Espetinho_TCC.Apresentação.Controle_de_Estoque.Entrada_de_Estoque;
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

namespace Espetinho_TCC.Apresentação.Controle_de_Estoque
{
    public partial class frmEntradaEstoque : Form
    {
        #region Instâncias
        EntradaEstoqueDAO entEstDAO = new EntradaEstoqueDAO();
        #endregion

        #region Variáveis
        String comando;

        DataGridViewButtonColumn colunaBotaoOBS = new DataGridViewButtonColumn();
        DataGridViewButtonColumn colunaBotaoProdutos = new DataGridViewButtonColumn();
        #endregion

        #region Carregar Tela
        public frmEntradaEstoque(string nomeUsu)
        {
            InitializeComponent();
            lblNomeUsuAtivo.Text = nomeUsu;
            lblNomeUsuAtivo.ForeColor = Color.LawnGreen;
        }
        private void frmEntradaEstoque_Load(object sender, EventArgs e)
        {
            gvExibirEntradasEstoque.DataSource = entEstDAO.listarEntradas();
            atualizarGV();
            atualizarColunaBotaoOBS();
            atualizarColunaBotaoProdutos();
        }
        #endregion

        #region Atualizar GridView
        private void atualizarGV()
        {
            try
            {
                gvExibirEntradasEstoque.Columns[0].HeaderText = "Código";
                gvExibirEntradasEstoque.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirEntradasEstoque.Columns[1].HeaderText = "Data";
                gvExibirEntradasEstoque.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirEntradasEstoque.Columns[2].HeaderText = "Hora";
                gvExibirEntradasEstoque.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirEntradasEstoque.Columns[3].HeaderText = "Valor";
                gvExibirEntradasEstoque.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirEntradasEstoque.Columns.Add(colunaBotaoOBS);
                colunaBotaoOBS.HeaderText = "Observações";
                colunaBotaoOBS.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirEntradasEstoque.Columns.Add(colunaBotaoProdutos);
                colunaBotaoProdutos.HeaderText = "Ver Produtos";
                colunaBotaoProdutos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch { }
        }

        private void atualizarColunaBotaoOBS()
        {
            for (int i = 0; i < gvExibirEntradasEstoque.Rows.Count; i++)
            {
                gvExibirEntradasEstoque.Rows[i].Cells[4].Value = "Observações ...";
                gvExibirEntradasEstoque.Rows[i].Height = 60;
            }
        }

        private void atualizarColunaBotaoProdutos()
        {
            for (int i = 0; i < gvExibirEntradasEstoque.Rows.Count; i++)
            {
                gvExibirEntradasEstoque.Rows[i].Cells[5].Value = "Produtos ...";
                gvExibirEntradasEstoque.Rows[i].Height = 60;
            }
        }
        #endregion

        #region Interações com GridView
        private void gvExibirEntradasEstoque_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            double valor;
            DateTime data, hora;
            data = Convert.ToDateTime(gvExibirEntradasEstoque.Rows[gvExibirEntradasEstoque.CurrentCell.RowIndex].Cells[1].Value.ToString());
            hora = Convert.ToDateTime(gvExibirEntradasEstoque.Rows[gvExibirEntradasEstoque.CurrentCell.RowIndex].Cells[2].Value.ToString());
            valor = Convert.ToDouble(gvExibirEntradasEstoque.Rows[gvExibirEntradasEstoque.CurrentCell.RowIndex].Cells[3].Value.ToString().TrimStart("R$ ".ToCharArray()));
            frmGerenciarEntradaEstoque telaEntradaEst = new frmGerenciarEntradaEstoque
                (lblNomeUsuAtivo.Text,
                Convert.ToInt32(
                    gvExibirEntradasEstoque.Rows[gvExibirEntradasEstoque.CurrentCell.RowIndex].Cells[0].Value.ToString()),
                data, hora, valor);
            telaEntradaEst.ShowDialog();
        }

        private void gvExibirEntradasEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                frmObsEntradaEstoque telaOBS = new frmObsEntradaEstoque(entEstDAO.entradaPorID(Convert.ToInt32(gvExibirEntradasEstoque.Rows[gvExibirEntradasEstoque.CurrentCell.RowIndex].Cells[0].Value)).Obs_entEst.ToString());
                telaOBS.ShowDialog();
            }
            if (e.ColumnIndex == 5)
            {
                frmVerProdutosEntradaEstoque telaVerProd = new frmVerProdutosEntradaEstoque(gvExibirEntradasEstoque.Rows[gvExibirEntradasEstoque.CurrentCell.RowIndex].Cells[0].Value.ToString());
                telaVerProd.ShowDialog();
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            gvExibirEntradasEstoque.Columns.Clear();
            gvExibirEntradasEstoque.DataSource = entEstDAO.listarEntradas();
            txtID.Clear();
            dtpDataInicio.Text = String.Empty;
            dtpDataInicio.Value = DateTime.Now;
            dtpDataTermino.Text = String.Empty;
            dtpDataTermino.Value = DateTime.Now;
            cmbPesqPorValor.Text = String.Empty;
            cmbPesqPorValor.SelectedItem = null;
            atualizarGV();
            atualizarColunaBotaoOBS();
            atualizarColunaBotaoProdutos();
        }
        #endregion

        #region Limpar Tudo
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            dtpDataInicio.Text = String.Empty;
            dtpDataInicio.Value = DateTime.Now;
            dtpDataTermino.Text = String.Empty;
            dtpDataTermino.Value = DateTime.Now;
            cmbPesqPorValor.Text = String.Empty;
            cmbPesqPorValor.SelectedItem = null;
            for (int i = 0; i < gvExibirEntradasEstoque.RowCount; i++)
            {
                gvExibirEntradasEstoque.Rows[i].DataGridView.Columns.Clear();
            }
        }
        #endregion

        #region Pesquisar Entradas de Estoque
        private void btnPesqID_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text != String.Empty)
                {
                    gvExibirEntradasEstoque.Columns.Clear();
                    gvExibirEntradasEstoque.DataSource = entEstDAO.pesquisarPorIDGV(Convert.ToInt32(txtID.Text));
                    atualizarGV();
                    atualizarColunaBotaoOBS();
                    atualizarColunaBotaoProdutos();
                }
            }
            catch { }
        }

        private void btnPesqData_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpDataInicio.Text != String.Empty && dtpDataInicio.Value != null ||
                    dtpDataTermino.Text != String.Empty && dtpDataTermino.Value != null)
                {
                    gvExibirEntradasEstoque.Columns.Clear();
                    gvExibirEntradasEstoque.DataSource = entEstDAO.pesquisarPorData(Convert.ToDateTime(dtpDataInicio.Value).ToString("yyyy/MM/dd"), Convert.ToDateTime(dtpDataTermino.Value).ToString("yyyy/MM/dd"));
                    atualizarGV();
                    atualizarColunaBotaoOBS();
                    atualizarColunaBotaoProdutos();
                }
            }
            catch { }
        }

        private void btnPesqValor_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPesqPorValor.Text != String.Empty && cmbPesqPorValor.SelectedItem != null)
                {
                    gvExibirEntradasEstoque.Columns.Clear();
                    gvExibirEntradasEstoque.DataSource = entEstDAO.pesquisarPorValor(comando);
                    atualizarGV();
                    atualizarColunaBotaoOBS();
                    atualizarColunaBotaoProdutos();
                }
            }
            catch { }
        }

        private void cmbPesqPorValor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtID.Clear();
            dtpDataInicio.Text = String.Empty;
            dtpDataInicio.Value = DateTime.Now;
            dtpDataTermino.Text = String.Empty;
            dtpDataTermino.Value = DateTime.Now;
            if (cmbPesqPorValor.SelectedIndex == 0)
            {
                comando = "e.valor_entEst <= 25";
            } // MENOS DE 10
            if (cmbPesqPorValor.SelectedIndex == 1)
            {
                comando = "e.valor_entEst >= 25 and e.valor_entEst <= 50";
            } // ENTRE 10 E 50
            if (cmbPesqPorValor.SelectedIndex == 2)
            {
                comando = "e.valor_entEst >= 50 and e.valor_entEst <= 100";
            } // ENTRE 50 E 100
            if (cmbPesqPorValor.SelectedIndex == 3)
            {
                comando = "e.valor_entEst >= 100";
            } // MAIS DE 100
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            dtpDataInicio.Text = String.Empty;
            dtpDataInicio.Value = DateTime.Now;
            dtpDataTermino.Text = String.Empty;
            dtpDataTermino.Value = DateTime.Now;
            cmbPesqPorValor.Text = String.Empty;
            cmbPesqPorValor.SelectedItem = null;
        }

        private void dtpDataInicio_Enter(object sender, EventArgs e)
        {
            txtID.Clear();
            cmbPesqPorValor.Text = String.Empty;
            cmbPesqPorValor.SelectedItem = null;
        }

        private void dtpDataTermino_Enter(object sender, EventArgs e)
        {
            txtID.Clear();
            cmbPesqPorValor.Text = String.Empty;
            cmbPesqPorValor.SelectedItem = null;
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
