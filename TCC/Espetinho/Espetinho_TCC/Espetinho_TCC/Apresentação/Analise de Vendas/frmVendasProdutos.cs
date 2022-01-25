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
using System.Windows.Forms.DataVisualization.Charting;

namespace Espetinho_TCC.Apresentação.Analise_de_Vendas
{
    public partial class frmVendasProdutos : Form
    {
        #region Instâncias
        ProdutoDAO prodDAO = new ProdutoDAO();
        ComandaDAO comDAO = new ComandaDAO();
        #endregion

        #region Variáveis
        public string dado;
        public SeriesChartType tipoGrafico;
        List<int> listaIdProd = new List<int>();
        #endregion

        #region Carregar Tela
        public frmVendasProdutos()
        {
            InitializeComponent();
        }

        private void frmVendasProdutos_Load(object sender, EventArgs e)
        {
            dtpDataInicio.Value = comDAO.buscarDataPrimeiraVenda();
            dtpDataTermino.Value = comDAO.buscarDataUltimaVenda();
        }
        #endregion

        #region Atualizar Gráfico Produtos
        private void atualizarChartProduto()
        {
            if (listaIdProd.Count != 0 && dado != "" && tipoGrafico != 0)
            {
                chtProdutos.Series["Número de Vendas"].Points.Clear();
                chtProdutos.Series["Receita Total"].Points.Clear();
                if (dtpDataInicio.Value != comDAO.buscarDataPrimeiraVenda() &&
                    dtpDataTermino.Value != comDAO.buscarDataUltimaVenda())
                {
                    try
                    {
                        if (dado == "Número de Vendas")
                        {
                            chtProdutos.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
                            chtProdutos.ChartAreas[0].AxisX.Interval = 1;
                            chtProdutos.Series["Receita Total"].Enabled = false;
                            chtProdutos.Series["Número de Vendas"].Enabled = true;
                            chtProdutos.Series["Número de Vendas"].ChartType = tipoGrafico;
                            foreach (int id in listaIdProd)
                            {
                                chtProdutos.Series["Número de Vendas"].Points.AddXY(prodDAO.produtoPorID(id).Nome_prod, prodDAO.qtdVendasProdutoPorData(id, Convert.ToDateTime(dtpDataInicio.Text), Convert.ToDateTime(dtpDataTermino.Text)));
                            }
                        }
                        else
                        {
                            chtProdutos.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
                            chtProdutos.ChartAreas[0].AxisX.Interval = 1;
                            chtProdutos.Series["Receita Total"].Enabled = true;
                            chtProdutos.Series["Número de Vendas"].Enabled = false;
                            chtProdutos.Series["Receita Total"].ChartType = tipoGrafico;
                            foreach (int id in listaIdProd)
                            {
                                chtProdutos.Series["Receita Total"].Points.AddXY(prodDAO.produtoPorID(id).Nome_prod, prodDAO.ReceitaTotalVendasProdutoPorData(id, Convert.ToDateTime(dtpDataInicio.Text), Convert.ToDateTime(dtpDataTermino.Text)));
                            }
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Verifique a data digitada!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dtpDataInicio.BackColor = Color.IndianRed;
                        dtpDataTermino.BackColor = Color.IndianRed;
                    }
                }
                else
                {
                    if (dado == "Número de Vendas")
                    {
                        chtProdutos.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
                        chtProdutos.ChartAreas[0].AxisX.Interval = 1;
                        chtProdutos.Series["Receita Total"].Enabled = false;
                        chtProdutos.Series["Número de Vendas"].Enabled = true;
                        chtProdutos.Series["Número de Vendas"].ChartType = tipoGrafico;
                        foreach (int id in listaIdProd)
                        {
                            chtProdutos.Series["Número de Vendas"].Points.AddXY(prodDAO.produtoPorID(id).Nome_prod, prodDAO.qtdVendasProduto(id));
                        }
                    }
                    else
                    {
                        chtProdutos.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
                        chtProdutos.ChartAreas[0].AxisX.Interval = 1;
                        chtProdutos.Series["Receita Total"].Enabled = true;
                        chtProdutos.Series["Número de Vendas"].Enabled = false;
                        chtProdutos.Series["Receita Total"].ChartType = tipoGrafico;
                        foreach (int id in listaIdProd)
                        {
                            chtProdutos.Series["Receita Total"].Points.AddXY(prodDAO.produtoPorID(id).Nome_prod, prodDAO.ReceitaTotalVendasProduto(id));
                        }
                    }
                }
            }
        }
        #endregion

        #region Adicionar Produto ao Gráfico
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmSelecionarProdAnaliseVendas telaSelecionarProd = new frmSelecionarProdAnaliseVendas();
            telaSelecionarProd.ShowDialog();
            if (telaSelecionarProd.txtIDProd.Text != "")
            {
                listaIdProd.Add(Convert.ToInt32(telaSelecionarProd.txtIDProd.Text));
                atualizarChartProduto();
                btnLimpar.Enabled = true;
            }
            if (listaIdProd.Count == 3)
                btnAdicionar.Enabled = false;
        }
        #endregion

        #region Habilitar/Desabilitar Botões
        private void HabilitarDesabilitarBotoes()
        {
            if (dado != "" && tipoGrafico != 0)
            {
                btnAdicionar.Enabled = true;
                btnLimpar.Enabled = false;
            }
            else
            {
                btnAdicionar.Enabled = false;
                btnLimpar.Enabled = false;
            }
        }
        #endregion

        #region Verificar Combos
        private void cmbTipoGraficoProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoGraficoProduto.SelectedIndex == 0)
                tipoGrafico = SeriesChartType.Column;
            if (cmbTipoGraficoProduto.SelectedIndex == 1)
                tipoGrafico = SeriesChartType.Pie;
            if (btnAdicionar.Enabled == false && btnLimpar.Enabled == false)
                HabilitarDesabilitarBotoes();
            else
                atualizarChartProduto();
        }

        private void cmbDadoProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDadoProduto.SelectedIndex == 0)
                dado = "Numero de Vendas";
            if (cmbDadoProduto.SelectedIndex == 1)
                dado = "Receita Total";
            if (btnAdicionar.Enabled == false && btnLimpar.Enabled == false)
                HabilitarDesabilitarBotoes();
            else
                atualizarChartProduto();
        }
        #endregion

        #region Verificar Datas
        private void dtpDataInicio_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDataInicio.Value != null &&
                dtpDataTermino.Value != null)
            {
                atualizarChartProduto();
            }
        }

        private void dtpDataTermino_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDataInicio.Value != null &&
                dtpDataTermino.Value != null)
            {
                atualizarChartProduto();
            }
        }
        #endregion

        #region Métodos Limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparTudo();
        }

        private void limparTudo()
        {
            dado = "";
            tipoGrafico = 0;
            chtProdutos.Series["Número de Vendas"].Points.Clear();
            chtProdutos.Series["Receita Total"].Points.Clear();
            btnLimpar.Enabled = false;
            btnAdicionar.Enabled = true;
            cmbTipoGraficoProduto.SelectedItem = null;
            cmbDadoProduto.SelectedItem = null;
            dtpDataInicio.Value = comDAO.buscarDataPrimeiraVenda();
            dtpDataTermino.Value = comDAO.buscarDataUltimaVenda();
            listaIdProd.Clear();
        }

        private void limparParcial()
        {
            chtProdutos.Series["Número de Vendas"].Points.Clear();
            chtProdutos.Series["Receita Total"].Points.Clear();
            cmbTipoGraficoProduto.SelectedItem = null;
            cmbDadoProduto.SelectedItem = null;
        }
        #endregion
    }
}
