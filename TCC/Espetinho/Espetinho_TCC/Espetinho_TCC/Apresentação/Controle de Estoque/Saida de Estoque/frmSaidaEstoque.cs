using Espetinho_TCC.Apresentação.Controle_de_Estoque.Saida_de_Estoque;
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
    public partial class frmSaidaEstoque : Form
    {
        #region Instâncias
        SaidaEstoqueDAO saiEstDAO = new SaidaEstoqueDAO();
        #endregion

        #region Variáveis
        String comando;

        DataGridViewButtonColumn colunaBotaoOBS = new DataGridViewButtonColumn();
        DataGridViewButtonColumn colunaBotaoProdutos = new DataGridViewButtonColumn();
        #endregion

        #region Carregar Tela
        public frmSaidaEstoque(string nomeUsu)
        {
            InitializeComponent();
            lblNomeUsuAtivo.Text = nomeUsu;
            lblNomeUsuAtivo.ForeColor = Color.LawnGreen;
        }

        private void frmSaidaEstoque_Load(object sender, EventArgs e)
        {
            gvExibirSaidasEstoque.DataSource = saiEstDAO.listarSaidas();
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
                gvExibirSaidasEstoque.Columns[0].HeaderText = "Código";
                gvExibirSaidasEstoque.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirSaidasEstoque.Columns[1].HeaderText = "Data";
                gvExibirSaidasEstoque.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirSaidasEstoque.Columns[2].HeaderText = "Hora";
                gvExibirSaidasEstoque.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirSaidasEstoque.Columns[3].HeaderText = "Valor";
                gvExibirSaidasEstoque.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirSaidasEstoque.Columns.Add(colunaBotaoOBS);
                colunaBotaoOBS.HeaderText = "Observações";
                colunaBotaoOBS.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirSaidasEstoque.Columns.Add(colunaBotaoProdutos);
                colunaBotaoProdutos.HeaderText = "Ver Produtos";
                colunaBotaoProdutos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch { }
        }

        private void atualizarColunaBotaoOBS()
        {
            for (int i = 0; i < gvExibirSaidasEstoque.Rows.Count; i++)
            {
                gvExibirSaidasEstoque.Rows[i].Cells[4].Value = "Observações ...";
                gvExibirSaidasEstoque.Rows[i].Height = 60;
            }
        }

        private void atualizarColunaBotaoProdutos()
        {
            for (int i = 0; i < gvExibirSaidasEstoque.Rows.Count; i++)
            {
                gvExibirSaidasEstoque.Rows[i].Cells[5].Value = "Produtos ...";
                gvExibirSaidasEstoque.Rows[i].Height = 60;
            }
        }
        #endregion

        #region Interações com GridView
        private void gvExibirSaidasEstoque_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            double valor;
            DateTime data, hora;
            data = Convert.ToDateTime(gvExibirSaidasEstoque.Rows[gvExibirSaidasEstoque.CurrentCell.RowIndex].Cells[1].Value.ToString());
            hora = Convert.ToDateTime(gvExibirSaidasEstoque.Rows[gvExibirSaidasEstoque.CurrentCell.RowIndex].Cells[2].Value.ToString());
            valor = Convert.ToDouble(gvExibirSaidasEstoque.Rows[gvExibirSaidasEstoque.CurrentCell.RowIndex].Cells[3].Value.ToString().TrimStart("R$ ".ToCharArray()));
            frmGerenciarSaidaEstoque telaSaidaEst = new frmGerenciarSaidaEstoque
                (lblNomeUsuAtivo.Text,
                Convert.ToInt32(
                    gvExibirSaidasEstoque.Rows[gvExibirSaidasEstoque.CurrentCell.RowIndex].Cells[0].Value.ToString()),
                data, hora, valor);
            telaSaidaEst.ShowDialog();
        }

        private void gvExibirSaidasEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                frmObsSaidaEstoque telaOBS = new frmObsSaidaEstoque(saiEstDAO.saidaPorID(Convert.ToInt32(gvExibirSaidasEstoque.Rows[gvExibirSaidasEstoque.CurrentCell.RowIndex].Cells[0].Value)).Obs_saiEst.ToString());
                telaOBS.ShowDialog();
            }
            if (e.ColumnIndex == 5)
            {
                frmVerProdutosSaidaEstoque telaVerProd = new frmVerProdutosSaidaEstoque(gvExibirSaidasEstoque.Rows[gvExibirSaidasEstoque.CurrentCell.RowIndex].Cells[0].Value.ToString());
                telaVerProd.ShowDialog();
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            gvExibirSaidasEstoque.Columns.Clear();
            gvExibirSaidasEstoque.DataSource = saiEstDAO.listarSaidas();
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
            for (int i = 0; i < gvExibirSaidasEstoque.RowCount; i++)
            {
                gvExibirSaidasEstoque.Rows[i].DataGridView.Columns.Clear();
            }
        }
        #endregion

        #region Pesquisar Saidas de Estoque
        private void btnPesqID_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text != String.Empty)
                {
                    gvExibirSaidasEstoque.Columns.Clear();
                    gvExibirSaidasEstoque.DataSource = saiEstDAO.pesquisarPorIDGV(Convert.ToInt32(txtID.Text));
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
                    gvExibirSaidasEstoque.Columns.Clear();
                    gvExibirSaidasEstoque.DataSource = saiEstDAO.pesquisarPorData(Convert.ToDateTime(dtpDataInicio.Value).ToString("yyyy/MM/dd"), Convert.ToDateTime(dtpDataTermino.Value).ToString("yyyy/MM/dd"));
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
                    gvExibirSaidasEstoque.Columns.Clear();
                    gvExibirSaidasEstoque.DataSource = saiEstDAO.pesquisarPorValor(comando);
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
                comando = "s.valor_saiEst <= 25";
            } // MENOS DE 10
            if (cmbPesqPorValor.SelectedIndex == 1)
            {
                comando = "s.valor_saiEst >= 25 and s.valor_saiEst <= 50";
            } // ENTRE 10 E 50
            if (cmbPesqPorValor.SelectedIndex == 2)
            {
                comando = "s.valor_saiEst >= 50 and s.valor_saiEst <= 100";
            } // ENTRE 50 E 100
            if (cmbPesqPorValor.SelectedIndex == 3)
            {
                comando = "s.valor_saiEst >= 100";
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
