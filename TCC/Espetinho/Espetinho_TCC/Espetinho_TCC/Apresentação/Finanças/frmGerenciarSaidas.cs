using Espetinho_TCC.DAO;
using Espetinho_TCC.Model;
using Espetinho_TCC.Utils;
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
    public partial class frmGerenciarSaidas : Form
    {
        #region Instâncias
        Financas fin = new Financas();
        FinancasDAO finDAO = new FinancasDAO();

        DataGridViewButtonColumn colunaBotao = new DataGridViewButtonColumn();
        #endregion

        #region Variáveis
        String obs;
        int id, ano, mes;
        double valor;
        DateTime data;
        #endregion

        #region Carregar Tela
        public frmGerenciarSaidas(String obsSai, int idSai, double valorSai, DateTime dataSai)
        {
            InitializeComponent();
            obs = obsSai;
            id = idSai;
            valor = valorSai;
            data = dataSai;
        }

        private void frmGerenciarSaidas_Load(object sender, EventArgs e)
        {
            gvExibirSaidas.Columns.Clear();
            gvExibirSaidas.DataSource = finDAO.listarTodasFinancasSaidas();
            atualizarGV();
            atualizarColunaBotao();
            carregarAnosFinancas();
            txtID.Text = id.ToString();
            txtObs.Text = obs.ToString();
            txtValor.Text = "R$ " + valor.ToString("#0.00");
            dtpData.Value = data;
            cmbAno.SelectedItem = null;
            cmbAno.Text = String.Empty;
            cmbTipo.SelectedIndex = 0;
        }
        #endregion

        #region Atualizar GridView
        private void atualizarGV()
        {
            try
            {
                gvExibirSaidas.Columns[0].HeaderText = "Código";
                gvExibirSaidas.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirSaidas.Columns[1].HeaderText = "Tipo";
                gvExibirSaidas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirSaidas.Columns[2].HeaderText = "Data";
                gvExibirSaidas.Columns[2].DefaultCellStyle.Format = "d";
                gvExibirSaidas.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirSaidas.Columns[3].HeaderText = "Valor";
                gvExibirSaidas.Columns[3].DefaultCellStyle.Format = "c";
                gvExibirSaidas.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirSaidas.Columns[4].Visible = false; // OBSERVAÇÃO
                gvExibirSaidas.Columns[5].Visible = false; // STATUS
                gvExibirSaidas.Columns.Add(colunaBotao);
                colunaBotao.HeaderText = "Observações";
                colunaBotao.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch { }
        }

        private void atualizarColunaBotao()
        {
            for (int i = 0; i < gvExibirSaidas.Rows.Count; i++)
            {
                gvExibirSaidas.Rows[i].Cells[6].Value = "Observações ...";
                gvExibirSaidas.Rows[i].Height = 80;
            }
        }
        #endregion

        #region Interações com GridView
        private void gvExibirSaidas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                frmObsFinanca telaObs = new frmObsFinanca(gvExibirSaidas.Rows[gvExibirSaidas.CurrentCell.RowIndex].Cells[4].Value.ToString());
                telaObs.ShowDialog();
            }
        }

        private void gvExibirSaidas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            limpar();
            for (int i = 0; i < gvExibirSaidas.RowCount; i++)
            {
                txtID.Text = gvExibirSaidas.Rows[gvExibirSaidas.CurrentCell.RowIndex].Cells[0].Value.ToString();
                txtValor.Text = "R$ " + Convert.ToDouble(gvExibirSaidas.Rows[gvExibirSaidas.CurrentCell.RowIndex].Cells[3].Value.ToString()).ToString("#0.00");
                dtpData.Value = Convert.ToDateTime(gvExibirSaidas.Rows[gvExibirSaidas.CurrentCell.RowIndex].Cells[2].Value.ToString());
                txtObs.Text = gvExibirSaidas.Rows[gvExibirSaidas.CurrentCell.RowIndex].Cells[4].Value.ToString();
            }

            btnNovo.BringToFront();
            btnNovo.Visible = true;
            btnCadastrar.SendToBack();
            btnCadastrar.Visible = false;
            btnAlterar.SendToBack();
            btnAlterar.Visible = true;
            btnExcluir.SendToBack();
            btnExcluir.Visible = true;
            btnCancelar.SendToBack();
            btnCancelar.Visible = false;
        }

        private void gvExibirSaidas_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                gvExibirSaidas.DataSource = finDAO.listarTodasFinancasSaidas();
                atualizarGV();
                atualizarColunaBotao();
            }
            catch { }
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

        #region Combos 
        private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMes.SelectedItem != null)
            {
                mes = cmbMes.SelectedIndex + 1;
                if (ano > 0)
                {
                    gvExibirSaidas.Columns.Clear();
                    gvExibirSaidas.DataSource = finDAO.listarSaidasPorMes(ano, mes);
                    atualizarGV();
                    atualizarColunaBotao();
                }
            }
        }

        private void cmbAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAno.SelectedItem != null || cmbAno.Text != String.Empty)
            {
                ano = Convert.ToInt32(cmbAno.SelectedValue.ToString());
                cmbMes.Enabled = true;
            }
        }
        #endregion

        #region Método Limpar
        private void limpar()
        {
            txtID.Text = (finDAO.buscarUltID() + 1).ToString();
            txtObs.Clear();
            txtValor.Text = "R$ 0,00";
            dtpData.Value = DateTime.Now;
            gvExibirSaidas.ClearSelection();
        }
        #endregion

        #region Cadastrar Saída
        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpar();
            btnNovo.Visible = false;
            btnCadastrar.BringToFront();
            btnCadastrar.Visible = true;
            btnAlterar.SendToBack();
            btnAlterar.Visible = false;
            btnExcluir.SendToBack();
            btnExcluir.Visible = false;
            btnCancelar.BringToFront();
            btnCancelar.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtValor.Text != String.Empty || dtpData.Text != String.Empty ||
    dtpData.Value != null || txtObs.Text != String.Empty)
            {
                if (txtValor.Text != String.Empty)
                {
                    txtValor.BackColor = Color.Empty;
                }
                if (dtpData.Text != String.Empty || dtpData.Value != null)
                {
                    dtpData.BackColor = Color.Empty;
                }
                if (txtObs.Text != String.Empty)
                {
                    txtObs.BackColor = Color.Empty;
                }

                MessageBox.Show("Favor preencher todos os campos em vermelho.", "Campos vazios!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    fin.Data_fin = dtpData.Value;
                    fin.Valor_fin = Convert.ToDouble(txtValor.Text.TrimStart("R$ ".ToCharArray()).TrimEnd(",00".ToCharArray()));
                    fin.Obs_fin = txtObs.Text;

                    finDAO.inserirSaidas(fin);

                    MessageBox.Show("Saída cadastrada com sucesso.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Algum erro ocorreu, favor verificar os campos digitados.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        #endregion

        #region Alterar Saída
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtValor.Text != String.Empty || dtpData.Text != String.Empty ||
    dtpData.Value != null || txtObs.Text != String.Empty)
            {
                if (txtValor.Text != String.Empty)
                {
                    txtValor.BackColor = Color.Empty;
                }
                if (dtpData.Text != String.Empty || dtpData.Value != null)
                {
                    dtpData.BackColor = Color.Empty;
                }
                if (txtObs.Text != String.Empty)
                {
                    txtObs.BackColor = Color.Empty;
                }

                MessageBox.Show("Favor preencher todos os campos em vermelho.", "Campos vazios!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    fin.Data_fin = dtpData.Value;
                    fin.Valor_fin = Convert.ToDouble(txtValor.Text.TrimStart("R$ ".ToCharArray()).TrimEnd(",00".ToCharArray()));
                    fin.Obs_fin = txtObs.Text;

                    finDAO.alterarFinanca(fin);

                    MessageBox.Show("Saída alterada com sucesso.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Algum erro ocorreu, favor verificar os campos digitados.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        #endregion

        #region Excluir Saída
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Dados.Permissao == "ADMIN" || Dados.Permissao == "FUNCIONARIO")
            {
                DialogResult opcao;

                opcao = MessageBox.Show("Deseja realmente excluir a Saída?", "Excluir?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcao == DialogResult.Yes)
                {
                    finDAO.excluirFinanca(Convert.ToInt32(txtID.Text));

                    limpar();
                    gvExibirSaidas.Columns.Clear();
                    gvExibirSaidas.DataSource = finDAO.listarTodasFinancasSaidas();
                    atualizarGV();
                    atualizarColunaBotao();

                    btnNovo.PerformClick();

                    MessageBox.Show("Saída excluida com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Saída não excluida!", "ERRO!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Você não possui permissões para excluir uma Saída!", "SEM PERMISSÃO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region Descolorir Campos
        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            if (txtValor.Text != String.Empty)
            {
                txtValor.BackColor = Color.Empty;
            }
        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {
            if (dtpData.Text != String.Empty && dtpData.Value != null)
            {
                dtpData.BackColor = Color.Empty;
            }
        }

        private void gvExibirSaidas_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void txtObs_TextChanged(object sender, EventArgs e)
        {
            if (txtObs.Text != String.Empty)
            {
                txtObs.BackColor = Color.Empty;
            }
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
