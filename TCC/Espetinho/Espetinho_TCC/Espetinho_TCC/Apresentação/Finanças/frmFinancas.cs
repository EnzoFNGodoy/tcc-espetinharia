using Espetinho_TCC.DAO;
using Espetinho_TCC.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Espetinho_TCC.Apresentação.Finanças
{
    public partial class frmFinancas : Form
    {
        #region Instâncias
        Financas fin = new Financas();
        FinancasDAO finDAO = new FinancasDAO();

        DataGridViewButtonColumn colunaBotao = new DataGridViewButtonColumn();
        #endregion

        #region Variáveis
        int ano = 0, mes = 0;
        #endregion

        #region Carregar Tela
        public frmFinancas()
        {
            InitializeComponent();
        }

        private void carregarInfos()
        {
            lblValorEntrada.Text = "R$ " + finDAO.valorTotalEntradas().ToString("#0.00");
            lblValorSaida.Text = "R$ " + finDAO.valorTotalSaidas().ToString("#0.00");
            if (finDAO.valorTotalLucro() < 0)
            {
                lblValorLucro.ForeColor = Color.IndianRed;
            }
            else
            {
                if (finDAO.valorTotalLucro() == 0)
                {
                    lblValorLucro.ForeColor = Color.White;
                }
                else
                {
                    lblValorLucro.ForeColor = Color.YellowGreen;
                }
            }
            lblValorLucro.Text = "R$ " + finDAO.valorTotalLucro().ToString("#0.00").TrimStart("-".ToCharArray());

            if (Convert.ToDouble(lblValorEntrada.Text.TrimStart("R$ ".ToCharArray()).TrimEnd(",00".ToCharArray())) > Convert.ToDouble(lblValorSaida.Text.TrimStart("R$ ".ToCharArray()).TrimEnd(",00".ToCharArray())))
            {
                pbBomRuimLucro.Image = Properties.Resources.bom;
            }
            else
            {
                pbBomRuimLucro.Image = Properties.Resources.ruim;
            }
        }

        private void frmFinancas_Load(object sender, EventArgs e)
        {
            carregarInfos();
            // ======== // 
            gvExibirFinancas.DataSource = finDAO.listarFinancas();
            atualizarGV();
            atualizarColunaBotao();
            // ======== // 
            carregarAnosFinancas();
        }
        #endregion

        #region Atualizar GridView
        private void atualizarGV()
        {
            try
            {
                gvExibirFinancas.Columns[0].HeaderText = "Código";
                gvExibirFinancas.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirFinancas.Columns[1].HeaderText = "Tipo";
                gvExibirFinancas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirFinancas.Columns[2].HeaderText = "Data";
                gvExibirFinancas.Columns[3].DefaultCellStyle.Format = "d";
                gvExibirFinancas.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirFinancas.Columns[3].HeaderText = "Valor";
                gvExibirFinancas.Columns[3].DefaultCellStyle.Format = "c";
                gvExibirFinancas.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirFinancas.Columns[4].Visible = false; // OBSERVAÇÃO
                gvExibirFinancas.Columns[5].Visible = false; // STATUS
                gvExibirFinancas.Columns.Add(colunaBotao);
                colunaBotao.HeaderText = "Observações";
                colunaBotao.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch { }
        }

        private void atualizarColunaBotao()
        {
            for (int i = 0; i < gvExibirFinancas.Rows.Count; i++)
            {
                gvExibirFinancas.Rows[i].Cells[6].Value = "Observações ...";
                gvExibirFinancas.Rows[i].Height = 60;
            }
        }
        #endregion

        #region Carregar Combo Anos
        private void carregarAnosFinancas()
        {
            cmbAno.ValueMember = "Ano";
            cmbAno.DisplayMember = "Ano";
            cmbAno.DataSource = finDAO.carregarAnosFinancas();
            cmbAno.SelectedItem = null;
        }
        #endregion

        #region Redirecionamento de Telas
        private void btnAddSaidas_Click(object sender, EventArgs e)
        {
             frmGerenciarSaidas telaSaidas = new frmGerenciarSaidas(
                finDAO.saidasPorID(finDAO.buscarUltIDSaidaAtiva()).Obs_fin,
                 finDAO.saidasPorID(finDAO.buscarUltIDSaidaAtiva()).Id_fin,
                  finDAO.saidasPorID(finDAO.buscarUltIDSaidaAtiva()).Valor_fin,
                   finDAO.saidasPorID(finDAO.buscarUltIDSaidaAtiva()).Data_fin);
            telaSaidas.ShowDialog();
        }

        private void btnAddEntradas_Click(object sender, EventArgs e)
        {
            frmGerenciarEntradas telaEntradas = new frmGerenciarEntradas(
                finDAO.entradasPorID(finDAO.buscarUltIDEntradaAtiva()).Obs_fin,
                 finDAO.entradasPorID(finDAO.buscarUltIDEntradaAtiva()).Id_fin,
                  finDAO.entradasPorID(finDAO.buscarUltIDEntradaAtiva()).Valor_fin,
                   finDAO.entradasPorID(finDAO.buscarUltIDEntradaAtiva()).Data_fin);
            telaEntradas.ShowDialog();
        }
        #endregion

        #region Botões Mostrar e Limpar
        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                gvExibirFinancas.Columns.Clear();
                gvExibirFinancas.DataSource = finDAO.listarFinancas();
                atualizarGV();
                atualizarColunaBotao();
            }
            catch { }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rbEntradas.Checked = false;
            rbSaidas.Checked = false;
            rbTudo.Checked = false;
            cmbAno.Text = String.Empty;
            cmbAno.SelectedItem = null;
            cmbMes.Text = String.Empty;
            cmbMes.SelectedItem = null;
            cmbMes.Enabled = false;
            for (int i = 0; i < gvExibirFinancas.RowCount; i++)
            {
                gvExibirFinancas.Rows[i].DataGridView.Columns.Clear();
            }
        }
        #endregion

        #region RadioButtons
        private void rbEntradas_CheckedChanged(object sender, EventArgs e)
        {
            rbSaidas.Checked = false;
            rbTudo.Checked = false;
            if (ano > 0 && cmbAno.SelectedItem != null)
            {
                if (mes > 0 && cmbMes.SelectedItem != null)
                {
                    gvExibirFinancas.DataSource = finDAO.listarEntradasPorMes(ano, mes);
                }
                else
                {
                    gvExibirFinancas.DataSource = finDAO.listarTodasFinancasEntradas();
                }
            }
            else
            {
                gvExibirFinancas.DataSource = finDAO.listarTodasFinancasEntradas();
            }
            atualizarGV();
            atualizarColunaBotao();
        }

        private void rbSaidas_CheckedChanged(object sender, EventArgs e)
        {
            rbEntradas.Checked = false;
            rbTudo.Checked = false;
            if (ano > 0 && cmbAno.SelectedItem != null)
            {
                if (mes > 0 && cmbMes.SelectedItem != null)
                {
                    gvExibirFinancas.DataSource = finDAO.listarSaidasPorMes(ano, mes);
                }
                else
                {
                    gvExibirFinancas.DataSource = finDAO.listarTodasFinancasSaidas();
                }
            }
            else
            {
                gvExibirFinancas.DataSource = finDAO.listarTodasFinancasSaidas();
            }
            atualizarGV();
            atualizarColunaBotao();
        }

        private void rbTudo_CheckedChanged(object sender, EventArgs e)
        {
            rbSaidas.Checked = false;
            rbEntradas.Checked = false;
            if (ano > 0 && cmbAno.SelectedItem != null)
            {
                if (mes > 0 && cmbMes.SelectedItem != null)
                {
                    gvExibirFinancas.DataSource = finDAO.listarPorMes(ano, mes);
                }
                else
                {
                    gvExibirFinancas.DataSource = finDAO.listarFinancas();
                }
            }
            else
            {
                gvExibirFinancas.DataSource = finDAO.listarFinancas();
            }
            atualizarGV();
            atualizarColunaBotao();
        }
        #endregion

        #region Combos 
        private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMes.SelectedItem != null)
            {
                mes = cmbMes.SelectedIndex + 1;
                if (ano > 0)
                {
                    if (rbEntradas.Checked == true &&
                    rbSaidas.Checked == false &&
                    rbTudo.Checked == false)
                    {
                        gvExibirFinancas.DataSource = finDAO.listarEntradasPorMes(ano, mes);
                    }
                    else
                    {
                        if (rbEntradas.Checked == false &&
                        rbSaidas.Checked == true &&
                        rbTudo.Checked == false)
                        {
                            gvExibirFinancas.DataSource = finDAO.listarSaidasPorMes(ano, mes);
                        }
                        else
                        {
                            if (rbEntradas.Checked == false &&
                            rbSaidas.Checked == false &&
                            rbTudo.Checked == true)
                            {
                                gvExibirFinancas.DataSource = finDAO.listarPorMes(ano, mes);
                            }
                        }
                    }
                }
            }
            atualizarGV();
            atualizarColunaBotao();
        }

        private void cmbAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAno.SelectedItem != null && cmbMes.SelectedItem != null)
            {
                ano = Convert.ToInt32(cmbMes.SelectedValue.ToString());
                cmbMes.Enabled = true;
            }
        }
        #endregion

        #region Interações com o GridView
        private void gvExibirFinancas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                frmObsFinanca telaObs = new frmObsFinanca(gvExibirFinancas.Rows[gvExibirFinancas.CurrentCell.RowIndex].Cells[4].Value.ToString());
                telaObs.ShowDialog();
            }
        }

        private void gvExibirFinancas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvExibirFinancas.Rows[gvExibirFinancas.CurrentCell.RowIndex].Cells[1].Value.ToString() == "ENTRADA")
            {
                frmGerenciarEntradas telaEntradas = new frmGerenciarEntradas(
                    gvExibirFinancas.Rows[gvExibirFinancas.CurrentCell.RowIndex].Cells[4].Value.ToString(), // OBSERVAÇÕES
                    Convert.ToInt32(gvExibirFinancas.Rows[gvExibirFinancas.CurrentCell.RowIndex].Cells[0].Value.ToString()), // ID
                    Convert.ToDouble(gvExibirFinancas.Rows[gvExibirFinancas.CurrentCell.RowIndex].Cells[3].Value.ToString()), // VALOR
                    Convert.ToDateTime(gvExibirFinancas.Rows[gvExibirFinancas.CurrentCell.RowIndex].Cells[2].Value.ToString())); // DATA
                telaEntradas.ShowDialog();
            }
            else
            {
                frmGerenciarSaidas telaSaidas = new frmGerenciarSaidas(
                    gvExibirFinancas.Rows[gvExibirFinancas.CurrentCell.RowIndex].Cells[4].Value.ToString(), // OBSERVAÇÕES
                    Convert.ToInt32(gvExibirFinancas.Rows[gvExibirFinancas.CurrentCell.RowIndex].Cells[0].Value.ToString()), // ID
                    Convert.ToDouble(gvExibirFinancas.Rows[gvExibirFinancas.CurrentCell.RowIndex].Cells[3].Value.ToString()), // VALOR
                    Convert.ToDateTime(gvExibirFinancas.Rows[gvExibirFinancas.CurrentCell.RowIndex].Cells[2].Value.ToString())); // DATA
                telaSaidas.ShowDialog();
            }
            carregarInfos();
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
