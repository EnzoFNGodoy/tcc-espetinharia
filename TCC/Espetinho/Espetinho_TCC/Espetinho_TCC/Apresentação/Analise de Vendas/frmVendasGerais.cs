using Espetinho_TCC.Apresentação.Analise_de_Vendas;
using Espetinho_TCC.DAO;
using Espetinho_TCC.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Espetinho_TCC.Apresentação.Analise_de_Vendas
{
    public partial class frmVendasGerais : Form
    {
        #region Instâncias
        ComandaDAO comDAO = new ComandaDAO();
        #endregion

        #region Variáveis
        int anoVendas = 0, mesVendas = 0;
        public string dado;
        public SeriesChartType tipoGrafico;
        #endregion

        #region Carregar Tela
        public frmVendasGerais()
        {
            InitializeComponent();
        }

        private void frmVendasGerais_Load(object sender, EventArgs e)
        {
            chtVendas.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            carregarAnosVendas();
        }
        #endregion

        #region Método Carregar Itens Combos
        private void carregarAnosVendas()
        {
            cmbAno.ValueMember = "Ano";
            cmbAno.DisplayMember = "Ano";
            cmbAno.DataSource = comDAO.listarAnosVendas();
            cmbAno.SelectedItem = null;
        }
        #endregion

        #region Verificar Combos
        private void cmbTipoGraficoVendas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipoGraficoVendas.SelectedIndex == 0)
                    tipoGrafico = SeriesChartType.Column;
                if (cmbTipoGraficoVendas.SelectedIndex == 1)
                    tipoGrafico = SeriesChartType.Line;
                if (cmbPeriodo.Text == "Ano")
                    atualizarGraficoPorAno();
                else
                    atualizarGraficoPorMes();
            }
            catch { }
        }

        private void cmbDadoVendasGerais_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbDadoVendasGerais.SelectedIndex == 0)
                    dado = "Número de Vendas";
                if (cmbDadoVendasGerais.SelectedIndex == 1)
                    dado = "Receita Total";
                if (cmbPeriodo.Text == "Ano")
                    atualizarGraficoPorAno();
                else
                    atualizarGraficoPorMes();
            }
            catch { }
        }

        private void cmbMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                chtVendas.Series["Número de Vendas"].Points.Clear();
                chtVendas.Series["Receita Total"].Points.Clear();
                cmbTipoGraficoVendas.SelectedItem = null;
                cmbDadoVendasGerais.SelectedItem = null;
                cmbAno.SelectedItem = null;
                if (cmbMeses.SelectedItem != null)
                {
                    mesVendas = Convert.ToInt32(cmbMeses.SelectedIndex + 1);
                    if (cmbDadoVendasGerais.SelectedItem != null &&
                       cmbTipoGraficoVendas.SelectedItem != null)
                    {
                        atualizarGraficoPorMes();
                    }
                }
            }
            catch { }
        }

        private void cmbAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                chtVendas.Series["Número de Vendas"].Points.Clear();
                chtVendas.Series["Receita Total"].Points.Clear();
                cmbTipoGraficoVendas.SelectedItem = null;
                cmbDadoVendasGerais.SelectedItem = null;
                cmbMeses.SelectedItem = null;
                if (cmbAno.SelectedValue != null)
                {
                    anoVendas = Convert.ToInt32(cmbAno.SelectedValue.ToString());
                    if (cmbDadoVendasGerais.SelectedItem != null &&
                        cmbTipoGraficoVendas.SelectedItem != null)
                    {
                        atualizarGraficoPorAno();
                    }
                }
            }
            catch { }
        }

        private void cmbPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            limparParcial();
            cmbMeses.Enabled = true;
            cmbAno.Enabled = true;
            if (cmbPeriodo.Text == "Mês")
            {
                cmbAno.Visible = false;
                cmbAno.SendToBack();
                cmbMeses.Visible = true;
                cmbMeses.BringToFront();
                lblPeriodoDatas.Text = "Mês:";

                try
                {
                    atualizarGraficoPorMes();
                }
                catch { }
            }
            if (cmbPeriodo.Text == "Ano")
            {
                cmbAno.Visible = true;
                cmbAno.BringToFront();
                cmbMeses.Visible = false;
                cmbMeses.SendToBack();
                lblPeriodoDatas.Text = "Ano:";

                try
                {
                    atualizarGraficoPorAno();
                }
                catch { }
            }
        }
        #endregion

        #region Atualizar Gráfico
        private void atualizarGraficoPorAno()
        {
            chtVendas.Series["Número de Vendas"].Points.Clear();
            chtVendas.Series["Receita Total"].Points.Clear();
            if (anoVendas != 0 && dado != "" && tipoGrafico != 0)
            {
                if (dado == "Número de Vendas")
                {
                    chtVendas.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
                    chtVendas.ChartAreas[0].AxisX.Interval = 1;
                    chtVendas.Series["Receita Total"].Enabled = false;
                    chtVendas.Series["Número de Vendas"].Enabled = true;
                    comDAO.quantidadeDeVendasNoAno(anoVendas);
                    chtVendas.Series["Número de Vendas"].ChartType = tipoGrafico;
                    chtVendas.Series["Número de Vendas"].Points.AddXY("Jan", comDAO.QtdVendas[0]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("Fev", comDAO.QtdVendas[1]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("Mar", comDAO.QtdVendas[2]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("Abr", comDAO.QtdVendas[3]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("Mai", comDAO.QtdVendas[4]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("Jun", comDAO.QtdVendas[5]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("Jul", comDAO.QtdVendas[6]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("Ago", comDAO.QtdVendas[7]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("Set", comDAO.QtdVendas[8]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("Out", comDAO.QtdVendas[9]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("Nov", comDAO.QtdVendas[10]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("Dez", comDAO.QtdVendas[11]);
                }
                else
                {
                    chtVendas.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
                    chtVendas.ChartAreas[0].AxisX.Interval = 1;
                    chtVendas.Series["Receita Total"].Enabled = true;
                    chtVendas.Series["Número de Vendas"].Enabled = false;
                    comDAO.receitaTotalVendasNoAno(anoVendas);
                    chtVendas.Series["Receita Total"].ChartType = tipoGrafico;
                    chtVendas.Series["Receita Total"].Points.AddXY("Jan", "R$ " + comDAO.ReceitasVendas[0].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("Fev", "R$ " + comDAO.ReceitasVendas[1].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("Mar", "R$ " + comDAO.ReceitasVendas[2].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("Abr", "R$ " + comDAO.ReceitasVendas[3].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("Mai", "R$ " + comDAO.ReceitasVendas[4].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("Jun", "R$ " + comDAO.ReceitasVendas[5].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("Jul", "R$ " + comDAO.ReceitasVendas[6].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("Ago", "R$ " + comDAO.ReceitasVendas[7].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("Set", "R$ " + comDAO.ReceitasVendas[8].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("Out", "R$ " + comDAO.ReceitasVendas[9].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("Nov", "R$ " + comDAO.ReceitasVendas[10].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("Dez", "R$ " + comDAO.ReceitasVendas[11].ToString("#0.00"));
                }
            }
        }

        private void atualizarGraficoPorMes()
        {
            chtVendas.Series["Número de Vendas"].Points.Clear();
            chtVendas.Series["Receita Total"].Points.Clear();
            if (mesVendas != 0 && dado != "" && tipoGrafico != 0)
            {
                if (dado == "Número de Vendas")
                {
                    chtVendas.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
                    chtVendas.ChartAreas[0].AxisX.Interval = 1;
                    chtVendas.Series["Receita Total"].Enabled = false;
                    chtVendas.Series["Número de Vendas"].Enabled = true;
                    comDAO.quantidadeDeVendasNoMes(mesVendas);
                    chtVendas.Series["Número de Vendas"].ChartType = tipoGrafico;
                    chtVendas.Series["Número de Vendas"].Points.AddXY("01", comDAO.QtdVendas[0]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("02", comDAO.QtdVendas[1]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("03", comDAO.QtdVendas[2]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("04", comDAO.QtdVendas[3]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("05", comDAO.QtdVendas[4]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("06", comDAO.QtdVendas[5]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("07", comDAO.QtdVendas[6]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("08", comDAO.QtdVendas[7]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("09", comDAO.QtdVendas[8]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("10", comDAO.QtdVendas[9]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("11", comDAO.QtdVendas[10]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("12", comDAO.QtdVendas[11]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("13", comDAO.QtdVendas[12]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("14", comDAO.QtdVendas[13]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("15", comDAO.QtdVendas[14]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("16", comDAO.QtdVendas[15]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("17", comDAO.QtdVendas[16]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("18", comDAO.QtdVendas[17]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("19", comDAO.QtdVendas[18]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("20", comDAO.QtdVendas[19]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("21", comDAO.QtdVendas[20]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("22", comDAO.QtdVendas[21]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("23", comDAO.QtdVendas[22]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("24", comDAO.QtdVendas[23]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("25", comDAO.QtdVendas[24]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("26", comDAO.QtdVendas[25]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("27", comDAO.QtdVendas[26]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("28", comDAO.QtdVendas[27]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("29", comDAO.QtdVendas[28]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("30", comDAO.QtdVendas[29]);
                    chtVendas.Series["Número de Vendas"].Points.AddXY("31", comDAO.QtdVendas[30]);
                }
                else
                {
                    chtVendas.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
                    chtVendas.ChartAreas[0].AxisX.Interval = 1;
                    chtVendas.Series["Receita Total"].Enabled = true;
                    chtVendas.Series["Número de Vendas"].Enabled = false;
                    comDAO.receitaTotalVendasNoMes(mesVendas);
                    chtVendas.Series["Receita Total"].ChartType = tipoGrafico;
                    chtVendas.Series["Receita Total"].Points.AddXY("01", "R$ " + comDAO.ReceitasVendas[0].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("02", "R$ " + comDAO.ReceitasVendas[1].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("03", "R$ " + comDAO.ReceitasVendas[2].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("04", "R$ " + comDAO.ReceitasVendas[3].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("05", "R$ " + comDAO.ReceitasVendas[4].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("06", "R$ " + comDAO.ReceitasVendas[5].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("07", "R$ " + comDAO.ReceitasVendas[6].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("08", "R$ " + comDAO.ReceitasVendas[7].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("09", "R$ " + comDAO.ReceitasVendas[8].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("10", "R$ " + comDAO.ReceitasVendas[9].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("11", "R$ " + comDAO.ReceitasVendas[10].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("12", "R$ " + comDAO.ReceitasVendas[11].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("13", "R$ " + comDAO.ReceitasVendas[12].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("14", "R$ " + comDAO.ReceitasVendas[13].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("15", "R$ " + comDAO.ReceitasVendas[14].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("16", "R$ " + comDAO.ReceitasVendas[15].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("17", "R$ " + comDAO.ReceitasVendas[16].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("18", "R$ " + comDAO.ReceitasVendas[17].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("19", "R$ " + comDAO.ReceitasVendas[18].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("20", "R$ " + comDAO.ReceitasVendas[19].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("21", "R$ " + comDAO.ReceitasVendas[20].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("22", "R$ " + comDAO.ReceitasVendas[21].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("23", "R$ " + comDAO.ReceitasVendas[22].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("24", "R$ " + comDAO.ReceitasVendas[23].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("25", "R$ " + comDAO.ReceitasVendas[24].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("26", "R$ " + comDAO.ReceitasVendas[25].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("27", "R$ " + comDAO.ReceitasVendas[26].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("28", "R$ " + comDAO.ReceitasVendas[27].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("29", "R$ " + comDAO.ReceitasVendas[28].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("30", "R$ " + comDAO.ReceitasVendas[29].ToString("#0.00"));
                    chtVendas.Series["Receita Total"].Points.AddXY("31", "R$ " + comDAO.ReceitasVendas[30].ToString("#0.00"));
                }
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
            chtVendas.Series["Número de Vendas"].Points.Clear();
            chtVendas.Series["Receita Total"].Points.Clear();
            btnLimpar.Enabled = false;
            cmbTipoGraficoVendas.SelectedItem = null;
            cmbDadoVendasGerais.SelectedItem = null;
            cmbPeriodo.SelectedItem = null;
            cmbAno.SelectedItem = null;
            cmbMeses.SelectedItem = null;
            cmbMeses.Enabled = false;
            cmbAno.Enabled = false;
        }

        private void limparParcial()
        {
            chtVendas.Series["Número de Vendas"].Points.Clear();
            chtVendas.Series["Receita Total"].Points.Clear();
            cmbTipoGraficoVendas.SelectedItem = null;
            cmbDadoVendasGerais.SelectedItem = null;
            cmbAno.SelectedItem = null;
            cmbMeses.SelectedItem = null;
        }
        #endregion
    }
}
