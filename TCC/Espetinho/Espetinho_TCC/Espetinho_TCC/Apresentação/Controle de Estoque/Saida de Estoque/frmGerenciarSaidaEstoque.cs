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
using Espetinho_TCC.Model;
using Espetinho_TCC.Utils;

namespace Espetinho_TCC.Apresentação.Controle_de_Estoque.Saida_de_Estoque
{
    public partial class frmGerenciarSaidaEstoque : Form
    {
        #region Instâncias
        SaidaEstoqueDAO saiDAO = new SaidaEstoqueDAO();
        SaidaEstoque saiEst = new SaidaEstoque();
        ItensSaidaEstoqueDAO itSaiDAO = new ItensSaidaEstoqueDAO();
        ItensSaidaEstoque itSaiEst = new ItensSaidaEstoque();
        ProdutoDAO prodDAO = new ProdutoDAO();
        Produto prod = new Produto();
        Financas fin = new Financas();
        FinancasDAO finDAO = new FinancasDAO();
        #endregion

        #region Variáveis
        int id;
        double valor;
        DateTime data, hora;

        DataGridViewButtonColumn colunaBotaoOBS = new DataGridViewButtonColumn();
        DataGridViewButtonColumn colunaBotaoProdutos = new DataGridViewButtonColumn();
        DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
        #endregion

        #region Carregar Form
        public frmGerenciarSaidaEstoque(string nomeUsu, int idSaida, DateTime dataSaida, DateTime horaSaida, double valorSaida)
        {
            InitializeComponent();
            lblNomeUsuAtivo.Text = nomeUsu;
            lblNomeUsuAtivo.ForeColor = Color.LawnGreen;
            id = idSaida;
            valor = valorSaida;
            data = dataSaida;
            hora = horaSaida;
        }

        private void frmGerenciarSaidaEstoque_Load(object sender, EventArgs e)
        {
            txtID.Text = id.ToString();
            dtpData.Value = data;
            mskHora.Text = hora.ToShortTimeString();
            txtValor.Text = "R$ " + valor.ToString("#0.00");
            // GV PRODUTOS
            atualizarGVProdutos(id);
            //
            txtObs.Text = saiDAO.saidaPorID(Convert.ToInt32(txtID.Text)).Obs_saiEst.ToString();
            // GV SAIDAS
            gvExibirSaidas.DataSource = saiDAO.listarSaidas();
            atualizarGV();
            atualizarColunaBotaoOBS();
            atualizarColunaBotaoProdutos();
            //
        }
        #endregion

        #region GridView Saidas
        #region Atualizar GridView Saidas
        private void atualizarGV()
        {
            try
            {
                gvExibirSaidas.Columns[0].HeaderText = "Código";
                gvExibirSaidas.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirSaidas.Columns[1].HeaderText = "Data";
                gvExibirSaidas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirSaidas.Columns[2].HeaderText = "Hora";
                gvExibirSaidas.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirSaidas.Columns[3].HeaderText = "Valor";
                gvExibirSaidas.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirSaidas.Columns.Add(colunaBotaoOBS);
                colunaBotaoOBS.HeaderText = "Observações";
                colunaBotaoOBS.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirSaidas.Columns.Add(colunaBotaoProdutos);
                colunaBotaoProdutos.HeaderText = "Ver Produtos";
                colunaBotaoProdutos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch { }
        }

        private void atualizarColunaBotaoOBS()
        {
            for (int i = 0; i < gvExibirSaidas.Rows.Count; i++)
            {
                gvExibirSaidas.Rows[i].Cells[4].Value = "Observações ...";
                gvExibirSaidas.Rows[i].Height = 60;
            }
        }

        private void atualizarColunaBotaoProdutos()
        {
            for (int i = 0; i < gvExibirSaidas.Rows.Count; i++)
            {
                gvExibirSaidas.Rows[i].Cells[5].Value = "Produtos ...";
                gvExibirSaidas.Rows[i].Height = 60;
            }
        }
        #endregion

        #region Interações com GridView Saidas
        private void btnOKPesquisa_Click(object sender, EventArgs e)
        {
            gvExibirSaidas.Columns.Clear();
            gvExibirSaidas.DataSource = saiDAO.pesquisarPorData(dtpPesqInicio.Value.ToString(), dtpPesqTermino.Value.ToString());
            atualizarGV();
            atualizarColunaBotaoOBS();
            atualizarColunaBotaoProdutos();
        }

        private void gvExibirSaidas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            limpar();
            for (int i = 0; i < gvExibirSaidas.RowCount; i++)
            {
                txtID.Text = gvExibirSaidas.Rows[gvExibirSaidas.CurrentCell.RowIndex].Cells[0].Value.ToString();
                dtpData.Value = Convert.ToDateTime(gvExibirSaidas.Rows[gvExibirSaidas.CurrentCell.RowIndex].Cells[1].Value.ToString());
                mskHora.Text = Convert.ToDateTime(gvExibirSaidas.Rows[gvExibirSaidas.CurrentCell.RowIndex].Cells[2].Value.ToString()).ToShortTimeString();
                txtValor.Text = gvExibirSaidas.Rows[gvExibirSaidas.CurrentCell.RowIndex].Cells[3].Value.ToString();
                txtObs.Text = saiDAO.saidaPorID(Convert.ToInt32(txtID.Text)).Obs_saiEst.ToString();
            }
            atualizarGVProdutos(Convert.ToInt32(txtID.Text));

            btnNovaSaida.BringToFront();
            btnNovaSaida.Visible = true;
            btnCadastrarSaidaEstoque.SendToBack();
            btnCadastrarSaidaEstoque.Visible = false;
            btnAlterarSaidaEstoque.SendToBack();
            btnAlterarSaidaEstoque.Visible = true;
            btnExcluirSaidaEstoque.SendToBack();
            btnExcluirSaidaEstoque.Visible = true;
            btnCancelarSaidaEstoque.SendToBack();
            btnCancelarSaidaEstoque.Visible = false;
        }

        private void gvExibirSaidas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                frmObsSaidaEstoque telaOBS = new frmObsSaidaEstoque(saiDAO.saidaPorID(Convert.ToInt32(gvExibirSaidas.Rows[gvExibirSaidas.CurrentCell.RowIndex].Cells[0].Value)).Obs_saiEst.ToString());
                telaOBS.ShowDialog();
            }
            if (e.ColumnIndex == 5)
            {
                frmVerProdutosSaidaEstoque telaVerProd = new frmVerProdutosSaidaEstoque(gvExibirSaidas.Rows[gvExibirSaidas.CurrentCell.RowIndex].Cells[0].Value.ToString());
                telaVerProd.ShowDialog();
            }
        }
        #endregion
        #endregion

        #region GridView Produtos
        #region Atualizar GridView Produtos
        private void atualizarGVProdutos(int idSaida)
        {
            try
            {
                for (int i = 0; i < itSaiDAO.listarProdutosSaidaEstoque(idSaida).Rows.Count; i++)
                {
                    gvExibirProdutos.Rows.Add(idSaida,
                        itSaiDAO.listarProdutosSaidaEstoque(idSaida).Rows[i][0].ToString(),
                        itSaiDAO.listarProdutosSaidaEstoque(idSaida).Rows[i][1].ToString(),
                        "R$ " + Convert.ToDouble(itSaiDAO.listarProdutosSaidaEstoque(idSaida).Rows[i][2].ToString()).ToString("#0.00").Replace('.', ','),
                        "R$ " + Convert.ToDouble(itSaiDAO.listarProdutosSaidaEstoque(idSaida).Rows[i][4].ToString()).ToString("#0.00").Replace('.', ','),
                        itSaiDAO.listarProdutosSaidaEstoque(idSaida).Rows[i][3].ToString()
                        );
                }
            }
            catch { }
        }
        #endregion

        #region Interações no GridView Produtos
        private void btnAddProdutos_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddProdutosListaSaida telaAddProdutos = new frmAddProdutosListaSaida();
                telaAddProdutos.ShowDialog();
                if (telaAddProdutos.gvExibirProdutos.Rows[telaAddProdutos.gvExibirProdutos.CurrentCell.RowIndex].DefaultCellStyle.SelectionBackColor == Color.GreenYellow)
                {
                    bool prodNaLista = false;
                    if (gvExibirProdutos.Rows.Count > 0)
                    {
                        for (int j = 0; j < gvExibirProdutos.Rows.Count; j++)
                        {
                            if (gvExibirProdutos.Rows[j].Cells[1].Value.ToString() == telaAddProdutos.gvExibirProdutos.Rows[telaAddProdutos.gvExibirProdutos.CurrentCell.RowIndex].Cells[0].Value.ToString())
                            {
                                prodNaLista = true;
                            }
                        }
                    }

                    if (prodNaLista == true)
                    {
                        MessageBox.Show("Esse produto já está incluso na lista, por favor escolha outro produto!", "ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        double precoTotal = Convert.ToDouble(telaAddProdutos.gvExibirProdutos.Rows[telaAddProdutos.gvExibirProdutos.CurrentCell.RowIndex].Cells[4].Value.ToString()) * Convert.ToInt32(telaAddProdutos.telaQtdProd.txtQtdProd.Text);

                        gvExibirProdutos.Rows.Add(txtID.ToString(),
                            telaAddProdutos.gvExibirProdutos.Rows[telaAddProdutos.gvExibirProdutos.CurrentCell.RowIndex].Cells[0].Value.ToString(),
                          telaAddProdutos.gvExibirProdutos.Rows[telaAddProdutos.gvExibirProdutos.CurrentCell.RowIndex].Cells[1].Value.ToString(),
                          "R$ " + Convert.ToDouble(telaAddProdutos.gvExibirProdutos.Rows[telaAddProdutos.gvExibirProdutos.CurrentCell.RowIndex].Cells[4].Value).ToString("#0.00").Replace('.', ','),
                          "R$ " + precoTotal.ToString("#0.00").Replace('.', ','),
                          telaAddProdutos.telaQtdProd.txtQtdProd.Text
                          );

                        double valorAtual = Convert.ToDouble(txtValor.Text.TrimStart("R$ ".ToCharArray()).Replace('.', ','));
                        double valorTotalNovo = valorAtual + precoTotal;
                        txtValor.Text = "R$ " + valorTotalNovo.ToString("#0.00");
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum produto foi escolhido!", "Sem produto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Algum erro ocorreu, por favor repita o processo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvExibirProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                frmQtdProdutoSaida telaQtdProdSaida = new frmQtdProdutoSaida(Convert.ToInt32(gvExibirProdutos.Rows[gvExibirProdutos.CurrentCell.RowIndex].Cells[0].Value.ToString()));
                telaQtdProdSaida.ShowDialog();
                if (telaQtdProdSaida.btnCancelar.Enabled == true)
                {
                    gvExibirProdutos.Rows[gvExibirProdutos.CurrentCell.RowIndex].Cells[5].Value = telaQtdProdSaida.txtQtdProd.Text;
                    double precoNovo = Convert.ToInt32(gvExibirProdutos.Rows[gvExibirProdutos.CurrentCell.RowIndex].Cells[5].Value) * Convert.ToDouble(gvExibirProdutos.Rows[gvExibirProdutos.CurrentCell.RowIndex].Cells[3].Value.ToString().TrimStart("R$ ".ToCharArray()).TrimEnd(",00".ToCharArray()));
                    gvExibirProdutos.Rows[gvExibirProdutos.CurrentCell.RowIndex].Cells[4].Value = "R$ " + precoNovo.ToString("#0.00");
                }
                else
                {
                    MessageBox.Show("A quantidade não foi escolhida!", "Sem sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        #endregion
        #endregion

        #region Método Limpar
        public void limpar()
        {
            txtID.Text = (saiDAO.verificarUltSaida() + 1).ToString();
            txtObs.Clear();
            txtValor.Text = "R$ 0,00";
            mskHora.Clear();
            dtpData.Value = DateTime.Now;
            for (int i = 0; i < gvExibirProdutos.Rows.Count; i++)
            {
                gvExibirProdutos.Rows.Clear();
            }
            gvExibirProdutos.ClearSelection();
            btnRemoverProdLista.Visible = false;
            btnRemoverProdLista.Enabled = false;
        }
        #endregion

        #region Verificar Mudança nos Objetos
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            txtID.BackColor = Color.Empty;
        }

        private void mskHora_TextChanged(object sender, EventArgs e)
        {
            if (mskHora.MaskFull == true)
            {
                String hora = mskHora.Text;
                String[] hms = hora.Split(":".ToCharArray());
                int horas = Convert.ToInt32(hms[0]);
                int minutos = Convert.ToInt32(hms[1]);
                if (horas > 23 || minutos > 59)
                {
                    mskHora.BackColor = Color.Tomato;
                }
                else
                {
                    mskHora.BackColor = Color.GreenYellow;
                }
            }
            else
            {
                if (mskHora.Text != String.Empty)
                {
                    mskHora.BackColor = Color.Empty;
                }
            }
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            txtValor.BackColor = Color.Empty;
        }
        #endregion

        #region Cadastrar Saidas
        private void btnNovaSaida_Click(object sender, EventArgs e)
        {
            limpar();
            btnNovaSaida.SendToBack();
            btnNovaSaida.Visible = false;
            btnCadastrarSaidaEstoque.BringToFront();
            btnCadastrarSaidaEstoque.Visible = true;
            btnAlterarSaidaEstoque.SendToBack();
            btnAlterarSaidaEstoque.Visible = false;
            btnExcluirSaidaEstoque.SendToBack();
            btnExcluirSaidaEstoque.Visible = false;
            btnCancelarSaidaEstoque.BringToFront();
            btnCancelarSaidaEstoque.Visible = true;
        }

        private void btnCadastrarSaidaEstoque_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == String.Empty || txtObs.Text == String.Empty || txtValor.Text == String.Empty ||
                 mskHora.MaskFull == false || dtpData.Value == null)
                {
                    if (txtID.Text == String.Empty)
                    {
                        txtID.BackColor = Color.Tomato;
                    }
                    if (txtObs.Text == String.Empty)
                    {
                        txtObs.BackColor = Color.Tomato;
                    }
                    if (txtValor.Text == String.Empty)
                    {
                        txtValor.BackColor = Color.Tomato;
                    }
                    if (mskHora.MaskFull == false || mskHora.BackColor == Color.Tomato)
                    {
                        mskHora.BackColor = Color.Tomato;
                    }
                    if (dtpData.Value == null)
                    {
                        dtpData.BackColor = Color.Tomato;
                    }

                    MessageBox.Show("Preencher todos os campos!", "ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    // INSERIR FINANÇA
                    fin.Data_fin = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    fin.Obs_fin = "Saida de Estoque";
                    fin.Valor_fin = Convert.ToDouble(txtValor.Text.Replace(',', '.').TrimStart("R$ ".ToCharArray()).TrimEnd(",00".ToCharArray())); ;

                    finDAO.inserirEntradas(fin);
                    // ============ //

                    saiEst.Valor_saiEst = Convert.ToDouble(txtValor.Text.Replace(',', '.').TrimStart("R$ ".ToCharArray()).TrimEnd(",00".ToCharArray()));
                    saiEst.Data_saiEst = Convert.ToDateTime(dtpData.Value.ToShortDateString());
                    saiEst.Hora_saiEst = Convert.ToDateTime(mskHora.Text);
                    saiEst.Obs_saiEst = txtObs.Text;
                    saiEst.Id_fin = finDAO.buscarUltID();

                    saiDAO.inserirSaidas(saiEst);

                    int qtdItens = gvExibirProdutos.RowCount;
                    for (int i = 0; i < qtdItens; i++)
                    {
                        itSaiEst.Id_saiEst = itSaiDAO.buscarUltSaida();
                        itSaiEst.Id_prod = Convert.ToInt32(gvExibirProdutos.Rows[i].Cells[1].Value.ToString());
                        itSaiEst.Qtd_itens = Convert.ToInt32(gvExibirProdutos.Rows[i].Cells[5].Value.ToString());

                        itSaiDAO.inserirItensSaida(itSaiEst);
                        prodDAO.retirarEstoque(Convert.ToInt32(gvExibirProdutos.Rows[i].Cells[1].Value.ToString()), Convert.ToInt32(gvExibirProdutos.Rows[i].Cells[5].Value.ToString()));
                    }

                    limpar();
                    gvExibirSaidas.Columns.Clear();
                    gvExibirSaidas.DataSource = saiDAO.listarSaidas();
                    atualizarGV();
                    atualizarColunaBotaoOBS();
                    atualizarColunaBotaoProdutos();
                    MessageBox.Show("Saida de Estoque cadastrada!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Verifique os campos digitados!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelarSaidaEstoque_Click(object sender, EventArgs e)
        {
            limpar();
        }
        #endregion

        #region Alterar
        private void gvExibirProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvExibirProdutos.SelectedRows.Count > 0)
            {
                btnRemoverProdLista.Visible = true;
                btnRemoverProdLista.Enabled = true;
            }
        }

        private void btnRemoverProdLista_Click(object sender, EventArgs e)
        {
            if (gvExibirProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Escolha um produto para ser removido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                gvExibirProdutos.Rows.RemoveAt(gvExibirProdutos.CurrentCell.RowIndex);

                MessageBox.Show("Produto excluído da lista com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAlterarSaidaEstoque_Click(object sender, EventArgs e)
        {
            if (Dados.Permissao == "ADMIN" || Dados.Permissao == "FUNCIONARIO")
            {
                if (dtpData.Value == null || mskHora.MaskFull == false ||
                    txtValor.Text == String.Empty || txtValor.Text == "R$ 0,00" ||
                    txtObs.Text == String.Empty)
                {
                    if (dtpData.Value == null)
                    {
                        MessageBox.Show("Favor preencher o campo de data", "Sem Data!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if (mskHora.MaskFull == false)
                    {
                        mskHora.BackColor = Color.Tomato;
                    }
                    if (txtValor.Text == String.Empty || txtValor.Text == "R$ 0,00")
                    {
                        txtValor.BackColor = Color.Tomato;
                    }
                    if (txtObs.Text == String.Empty)
                    {
                        txtValor.BackColor = Color.Tomato;
                    }
                    MessageBox.Show("Favor preencher todos os campos!", "Campos vazios!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    saiEst.Valor_saiEst = Convert.ToDouble(txtValor.Text.Replace(',', '.').TrimStart("R$ ".ToCharArray()).TrimEnd(",00".ToCharArray()));
                    saiEst.Data_saiEst = Convert.ToDateTime(dtpData.Value.ToShortDateString());
                    saiEst.Hora_saiEst = Convert.ToDateTime(mskHora.Text);
                    saiEst.Obs_saiEst = txtObs.Text;

                    saiDAO.alterarSaidas(saiEst, Convert.ToInt32(txtID.Text));

                    for (int i = 0; i < itSaiDAO.listarProdutosSaidaEstoque(Convert.ToInt32(txtID.Text)).Rows.Count; i++)
                    {
                        DataTable produtos = itSaiDAO.listarProdutosSaidaEstoque(Convert.ToInt32(txtID.Text));
                        produtos.Rows[i]["QtdItens"].ToString();
                        prodDAO.adicionarEstoque(Convert.ToInt32(produtos.Rows[i]["codigo"].ToString()), Convert.ToInt32(produtos.Rows[i]["QtdItens"].ToString()));
                    }

                    itSaiDAO.excluirItensSaida(Convert.ToInt32(txtID.Text));
                    int qtdItens = gvExibirProdutos.RowCount;
                    for (int i = 0; i < qtdItens; i++)
                    {
                        itSaiEst.Id_saiEst = Convert.ToInt32(txtID.Text);
                        itSaiEst.Id_prod = Convert.ToInt32(gvExibirProdutos.Rows[i].Cells[1].Value.ToString());
                        itSaiEst.Qtd_itens = Convert.ToInt32(gvExibirProdutos.Rows[i].Cells[5].Value.ToString());

                        itSaiDAO.inserirItensSaida(itSaiEst);
                        prodDAO.retirarEstoque(Convert.ToInt32(gvExibirProdutos.Rows[i].Cells[1].Value.ToString()), Convert.ToInt32(gvExibirProdutos.Rows[i].Cells[5].Value.ToString()));
                    }

                    limpar();
                    gvExibirSaidas.Columns.Clear();
                    gvExibirSaidas.DataSource = saiDAO.listarSaidas();
                    atualizarGV();
                    atualizarColunaBotaoOBS();
                    atualizarColunaBotaoProdutos();
                    MessageBox.Show("Saida de Estoque alterada!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Você não possui permissões para alterar uma Saída!", "SEM PERMISSÃO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region Excluir
        private void btnExcluirSaidaEstoque_Click(object sender, EventArgs e)
        {
            if (Dados.Permissao == "ADMIN" || Dados.Permissao == "FUNCIONARIO")
            {
                DialogResult opcao;

                opcao = MessageBox.Show("Deseja realmente excluir a Saída?", "Excluir?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcao == DialogResult.Yes)
                {
                    saiDAO.excluirSaida(Convert.ToInt32(txtID.Text));

                    limpar();
                    gvExibirSaidas.Columns.Clear();
                    gvExibirSaidas.DataSource = saiDAO.listarSaidas();
                    atualizarGV();
                    atualizarColunaBotaoOBS();
                    atualizarColunaBotaoProdutos();

                    MessageBox.Show("Saída excluido com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        #region Fechar Tela
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
