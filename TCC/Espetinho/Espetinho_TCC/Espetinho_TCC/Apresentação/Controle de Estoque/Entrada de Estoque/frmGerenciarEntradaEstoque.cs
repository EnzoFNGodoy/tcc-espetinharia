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

namespace Espetinho_TCC.Apresentação.Controle_de_Estoque.Entrada_de_Estoque
{
    public partial class frmGerenciarEntradaEstoque : Form
    {
        #region Instâncias
        EntradaEstoqueDAO entDAO = new EntradaEstoqueDAO();
        EntradaEstoque entEst = new EntradaEstoque();
        ItensEntradaEstoqueDAO itEntDAO = new ItensEntradaEstoqueDAO();
        ItensEntradaEstoque itEntEst = new ItensEntradaEstoque();
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
        #endregion

        #region Carregar Form
        public frmGerenciarEntradaEstoque(string nomeUsu, int idEntrada, DateTime dataEntrada, DateTime horaEntrada, double valorEntrada)
        {
            InitializeComponent();
            lblNomeUsuAtivo.Text = nomeUsu;
            lblNomeUsuAtivo.ForeColor = Color.LawnGreen;
            id = idEntrada;
            valor = valorEntrada;
            data = dataEntrada;
            hora = horaEntrada;
        }

        private void frmGerenciarEntradaEstoque_Load(object sender, EventArgs e)
        {
            txtID.Text = id.ToString();
            dtpData.Value = data;
            mskHora.Text = hora.ToShortTimeString();
            txtValor.Text = "R$ " + valor.ToString("#0.00");
            // GV PRODUTOS
            atualizarGVProdutos(id);
            //
            txtObs.Text = entDAO.entradaPorID(Convert.ToInt32(txtID.Text)).Obs_entEst.ToString();
            // GV ENTRADAS
            gvExibirEntradas.DataSource = entDAO.listarEntradas();
            atualizarGV();
            atualizarColunaBotaoOBS();
            atualizarColunaBotaoProdutos();
            //
        }
        #endregion

        #region GridView Entradas
        #region Atualizar GridView Entradas
        private void atualizarGV()
        {
            try
            {
                gvExibirEntradas.Columns[0].HeaderText = "Código";
                gvExibirEntradas.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirEntradas.Columns[1].HeaderText = "Data";
                gvExibirEntradas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirEntradas.Columns[2].HeaderText = "Hora";
                gvExibirEntradas.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirEntradas.Columns[3].HeaderText = "Valor";
                gvExibirEntradas.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirEntradas.Columns.Add(colunaBotaoOBS);
                colunaBotaoOBS.HeaderText = "Observações";
                colunaBotaoOBS.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirEntradas.Columns.Add(colunaBotaoProdutos);
                colunaBotaoProdutos.HeaderText = "Ver Produtos";
                colunaBotaoProdutos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch { }
        }

        private void atualizarColunaBotaoOBS()
        {
            for (int i = 0; i < gvExibirEntradas.Rows.Count; i++)
            {
                gvExibirEntradas.Rows[i].Cells[4].Value = "Observações ...";
                gvExibirEntradas.Rows[i].Height = 60;
            }
        }

        private void atualizarColunaBotaoProdutos()
        {
            for (int i = 0; i < gvExibirEntradas.Rows.Count; i++)
            {
                gvExibirEntradas.Rows[i].Cells[5].Value = "Produtos ...";
                gvExibirEntradas.Rows[i].Height = 60;
            }
        }
        #endregion

        #region Interações com GridView Entradas
        private void btnOKPesquisa_Click(object sender, EventArgs e)
        {
            gvExibirEntradas.Columns.Clear();
            gvExibirEntradas.DataSource = entDAO.pesquisarPorData(dtpPesqInicio.Value.ToShortDateString(), dtpPesqTermino.Value.ToShortDateString());
            atualizarGV();
            atualizarColunaBotaoOBS();
            atualizarColunaBotaoProdutos();
        }

        private void gvExibirEntradas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            limpar();
            for (int i = 0; i < gvExibirEntradas.RowCount; i++)
            {
                txtID.Text = gvExibirEntradas.Rows[gvExibirEntradas.CurrentCell.RowIndex].Cells[0].Value.ToString();
                dtpData.Value = Convert.ToDateTime(gvExibirEntradas.Rows[gvExibirEntradas.CurrentCell.RowIndex].Cells[1].Value.ToString());
                mskHora.Text = Convert.ToDateTime(gvExibirEntradas.Rows[gvExibirEntradas.CurrentCell.RowIndex].Cells[2].Value.ToString()).ToShortTimeString();
                txtValor.Text = gvExibirEntradas.Rows[gvExibirEntradas.CurrentCell.RowIndex].Cells[3].Value.ToString();
                txtObs.Text = entDAO.entradaPorID(Convert.ToInt32(txtID.Text)).Obs_entEst.ToString();
            }
            atualizarGVProdutos(Convert.ToInt32(txtID.Text));

            btnNovaEntrada.BringToFront();
            btnNovaEntrada.Visible = true;
            btnCadastrarEntradaEstoque.SendToBack();
            btnCadastrarEntradaEstoque.Visible = false;
            btnAlterarEntradaEstoque.SendToBack();
            btnAlterarEntradaEstoque.Visible = true;
            btnExcluirEntradaEstoque.SendToBack();
            btnExcluirEntradaEstoque.Visible = true;
            btnCancelarEntradaEstoque.SendToBack();
            btnCancelarEntradaEstoque.Visible = false;
        }

        private void gvExibirEntradas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                frmObsEntradaEstoque telaOBS = new frmObsEntradaEstoque(entDAO.entradaPorID(Convert.ToInt32(gvExibirEntradas.Rows[gvExibirEntradas.CurrentCell.RowIndex].Cells[0].Value)).Obs_entEst.ToString());
                telaOBS.ShowDialog();
            }
            if (e.ColumnIndex == 5)
            {
                frmVerProdutosEntradaEstoque telaVerProd = new frmVerProdutosEntradaEstoque(gvExibirEntradas.Rows[gvExibirEntradas.CurrentCell.RowIndex].Cells[0].Value.ToString());
                telaVerProd.ShowDialog();
            }
        }
        #endregion
        #endregion

        #region GridView Produtos
        #region Atualizar GridView Produtos
        private void atualizarGVProdutos(int idEntrada)
        {
            try
            {
                for (int i = 0; i < itEntDAO.listarProdutosEntradaEstoque(idEntrada).Rows.Count; i++)
                {
                    gvExibirProdutos.Rows.Add(idEntrada,
                        itEntDAO.listarProdutosEntradaEstoque(idEntrada).Rows[i][0].ToString(),
                        itEntDAO.listarProdutosEntradaEstoque(idEntrada).Rows[i][1].ToString(),
                        "R$ " + Convert.ToDouble(itEntDAO.listarProdutosEntradaEstoque(idEntrada).Rows[i][2].ToString()).ToString("#0.00").Replace('.', ','),
                        "R$ " + Convert.ToDouble(itEntDAO.listarProdutosEntradaEstoque(idEntrada).Rows[i][4].ToString()).ToString("#0.00").Replace('.', ','),
                        itEntDAO.listarProdutosEntradaEstoque(idEntrada).Rows[i][3].ToString()
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
                frmAddProdutosListaEntrada telaAddProdutos = new frmAddProdutosListaEntrada();
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
                frmQtdProdutoEntrada telaQtdProdEntrada = new frmQtdProdutoEntrada(Convert.ToInt32(gvExibirProdutos.Rows[gvExibirProdutos.CurrentCell.RowIndex].Cells[0].Value.ToString()));
                telaQtdProdEntrada.ShowDialog();
                if (telaQtdProdEntrada.btnCancelar.Enabled == true)
                {
                    gvExibirProdutos.Rows[gvExibirProdutos.CurrentCell.RowIndex].Cells[5].Value = telaQtdProdEntrada.txtQtdProd.Text;
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
            txtID.Text = (entDAO.verificarUltEntrada() + 1).ToString();
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

        #region Cadastrar Entradas
        private void btnNovaEntrada_Click(object sender, EventArgs e)
        {
            limpar();
            btnNovaEntrada.Visible = false;
            btnCadastrarEntradaEstoque.BringToFront();
            btnCadastrarEntradaEstoque.Visible = true;
            btnAlterarEntradaEstoque.SendToBack();
            btnAlterarEntradaEstoque.Visible = false;
            btnExcluirEntradaEstoque.SendToBack();
            btnExcluirEntradaEstoque.Visible = false;
            btnCancelarEntradaEstoque.BringToFront();
            btnCancelarEntradaEstoque.Visible = true;
        }

        private void btnCadastrarEntradaEstoque_Click(object sender, EventArgs e)
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
                    fin.Obs_fin = "Entrada de Estoque";
                    fin.Valor_fin = Convert.ToDouble(txtValor.Text.Replace(',', '.').TrimStart("R$ ".ToCharArray()).TrimEnd(",00".ToCharArray()));

                    finDAO.inserirSaidas(fin);
                    // ============ //

                    entEst.Valor_entEst = Convert.ToDouble(txtValor.Text.Replace(',', '.').TrimStart("R$ ".ToCharArray()).TrimEnd(",00".ToCharArray()));
                    entEst.Data_entEst = Convert.ToDateTime(dtpData.Value.ToShortDateString());
                    entEst.Hora_entEst = Convert.ToDateTime(mskHora.Text);
                    entEst.Obs_entEst = txtObs.Text;
                    entEst.Id_fin = finDAO.buscarUltID();

                    entDAO.inserirEntEst(entEst);

                    int qtdItens = gvExibirProdutos.RowCount;
                    for (int i = 0; i < qtdItens; i++)
                    {
                        itEntEst.Id_entEst = itEntDAO.buscarUltEntrada();
                        itEntEst.Id_prod = Convert.ToInt32(gvExibirProdutos.Rows[i].Cells[1].Value.ToString());
                        itEntEst.Qtd_itens = Convert.ToInt32(gvExibirProdutos.Rows[i].Cells[5].Value.ToString());

                        itEntDAO.inserirItensEntrada(itEntEst);
                        prodDAO.adicionarEstoque(Convert.ToInt32(gvExibirProdutos.Rows[i].Cells[1].Value.ToString()), Convert.ToInt32(gvExibirProdutos.Rows[i].Cells[5].Value.ToString()));
                    }

                    limpar();
                    gvExibirEntradas.Columns.Clear();
                    gvExibirEntradas.DataSource = entDAO.listarEntradas();
                    atualizarGV();
                    atualizarColunaBotaoOBS();
                    atualizarColunaBotaoProdutos();
                    MessageBox.Show("Entrada de Estoque cadastrada!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Verifique os campos digitados!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelarEntradaEstoque_Click(object sender, EventArgs e)
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

        private void btnAlterarEntradaEstoque_Click(object sender, EventArgs e)
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
                    entEst.Valor_entEst = Convert.ToDouble(txtValor.Text.Replace(',', '.').TrimStart("R$ ".ToCharArray()).TrimEnd(",00".ToCharArray()));
                    entEst.Data_entEst = Convert.ToDateTime(dtpData.Value.ToShortDateString());
                    entEst.Hora_entEst = Convert.ToDateTime(mskHora.Text);
                    entEst.Obs_entEst = txtObs.Text;

                    entDAO.alterarEntradas(entEst, Convert.ToInt32(txtID.Text));

                    for (int i = 0; i < itEntDAO.listarProdutosEntradaEstoque(Convert.ToInt32(txtID.Text)).Rows.Count; i++)
                    {
                        DataTable produtos = itEntDAO.listarProdutosEntradaEstoque(Convert.ToInt32(txtID.Text));
                        produtos.Rows[i]["QtdItens"].ToString();
                        prodDAO.adicionarEstoque(Convert.ToInt32(produtos.Rows[i]["codigo"].ToString()), Convert.ToInt32(produtos.Rows[i]["QtdItens"].ToString()));
                    }

                    itEntDAO.excluirItensEntrada(Convert.ToInt32(txtID.Text));
                    int qtdItens = gvExibirProdutos.RowCount;
                    for (int i = 0; i < qtdItens; i++)
                    {
                        itEntEst.Id_entEst = Convert.ToInt32(txtID.Text);
                        itEntEst.Id_prod = Convert.ToInt32(gvExibirProdutos.Rows[i].Cells[1].Value.ToString());
                        itEntEst.Qtd_itens = Convert.ToInt32(gvExibirProdutos.Rows[i].Cells[5].Value.ToString());

                        itEntDAO.inserirItensEntrada(itEntEst);
                        prodDAO.adicionarEstoque(Convert.ToInt32(gvExibirProdutos.Rows[i].Cells[1].Value.ToString()), Convert.ToInt32(gvExibirProdutos.Rows[i].Cells[5].Value.ToString()));
                    }

                    limpar();
                    gvExibirEntradas.Columns.Clear();
                    gvExibirEntradas.DataSource = entDAO.listarEntradas();
                    atualizarGV();
                    atualizarColunaBotaoOBS();
                    atualizarColunaBotaoProdutos();
                    MessageBox.Show("Entrada de Estoque alterada!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Você não possui permissões para alterar uma Entrada!", "SEM PERMISSÃO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region Excluir
        private void btnExcluirEntradaEstoque_Click(object sender, EventArgs e)
        {
            if (Dados.Permissao == "ADMIN" || Dados.Permissao == "FUNCIONARIO")
            {
                DialogResult opcao;

                opcao = MessageBox.Show("Deseja realmente excluir a Entrada?", "Excluir?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcao == DialogResult.Yes)
                {
                    entDAO.excluirEntrada(Convert.ToInt32(txtID.Text));

                    limpar();
                    gvExibirEntradas.Columns.Clear();
                    gvExibirEntradas.DataSource = entDAO.listarEntradas();
                    atualizarGV();
                    atualizarColunaBotaoOBS();
                    atualizarColunaBotaoProdutos();

                    MessageBox.Show("Entrada excluida com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Entrada não excluida!", "ERRO!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Você não possui permissões para excluir uma Entrada!", "SEM PERMISSÃO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
