using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Espetinho_TCC.DAO;
using Espetinho_TCC.Model;
using Espetinho_TCC.Utils;

namespace Espetinho_TCC.Apresentação.Fornecedor
{
    public partial class frmGerenciarPedidosForn : Form
    {
        #region Instâncias
        Fornecedor.frmPesqFPedidosForn telaPesqfPedForn = new Fornecedor.frmPesqFPedidosForn();

        UsuarioDAO usuDAO = new UsuarioDAO();
        DAO.PedidosFornDAO pedfornDAO = new DAO.PedidosFornDAO();
        Model.PedidosForn pedForn = new Model.PedidosForn();
        DAO.ItensPedidoFornDAO ItPedDAO = new DAO.ItensPedidoFornDAO();
        Model.ItensPedidoForn itPed = new Model.ItensPedidoForn();
        DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
        DAO.FornecedorDAO fornDAO = new DAO.FornecedorDAO();
        Produto prod = new Produto();
        DAO.ProdutoDAO prodDAO = new DAO.ProdutoDAO();
        #endregion

        #region Variáveis
        string fornecedor;
        int id, qtdItens;
        double valor;
        DateTime data, hora;
        #endregion

        #region Carregar Tela
        public frmGerenciarPedidosForn(int idPed, DateTime dataPed, DateTime horaPed, double valorPed, String nomeForn)
        {
            InitializeComponent();
            id = idPed;
            fornecedor = nomeForn;
            valor = valorPed;
            data = dataPed;
            hora = horaPed;
        }

        private void frmGerenciarPedidosForn_Load(object sender, EventArgs e)
        {
            txtID.Text = id.ToString();
            txtValor.Text = "R$ " + valor.ToString("#0.00");
            dtpData.Value = data;
            mskHora.Text = hora.ToShortTimeString();
            txtFornecedor.Text = fornecedor;

            gvExibirEntradas.DataSource = pedfornDAO.listarPedidos();
            atualizarGV();
            atualizarGVProdutos(id);
        }
        #endregion

        #region GridView Pedidos
        #region Atualizar GridView
        private void atualizarGV()
        {
            try
            {
                gvExibirEntradas.Columns[0].HeaderText = "Código";
                gvExibirEntradas.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirEntradas.Columns[1].HeaderText = "Fornecedor";
                gvExibirEntradas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirEntradas.Columns[2].HeaderText = "Valor R$";
                gvExibirEntradas.Columns[2].DefaultCellStyle.Format = "c";
                gvExibirEntradas.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirEntradas.Columns[3].HeaderText = "Data";
                gvExibirEntradas.Columns[3].DefaultCellStyle.Format = "d";
                gvExibirEntradas.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirEntradas.Columns[4].HeaderText = "Hora";
                gvExibirEntradas.Columns[4].DefaultCellStyle.Format = "t";
                gvExibirEntradas.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                for (int i = 0; i < gvExibirEntradas.Rows.Count; i++)
                {
                    gvExibirEntradas.Rows[i].Height = 80;
                }
            }
            catch { }
        }
        #endregion

        #region Interações com GridView
        private void gvExibirEntradas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            limpar();
            txtID.Text = gvExibirEntradas.Rows[gvExibirEntradas.CurrentCell.RowIndex].Cells[0].Value.ToString();
            dtpData.Value = Convert.ToDateTime(gvExibirEntradas.Rows[gvExibirEntradas.CurrentCell.RowIndex].Cells[3].Value.ToString());
            mskHora.Text = Convert.ToDateTime(gvExibirEntradas.Rows[gvExibirEntradas.CurrentCell.RowIndex].Cells[4].Value.ToString()).ToShortTimeString();
            txtValor.Text = "R$ " + Convert.ToDouble(gvExibirEntradas.Rows[gvExibirEntradas.CurrentCell.RowIndex].Cells[2].Value).ToString("#0.00");
            txtFornecedor.Text = gvExibirEntradas.Rows[gvExibirEntradas.CurrentCell.RowIndex].Cells[1].Value.ToString();

            atualizarGVProdutos(Convert.ToInt32(txtID.Text));
        }
        #endregion
        #endregion

        #region GridView Produtos
        #region Atualizar GridView Produtos
        private void atualizarGVProdutos(int idPedido)
        {
            try
            {
                for (int i = 0; i < ItPedDAO.ListarItensPedido(idPedido).Rows.Count; i++)
                {
                    gvExibirProdutos.Rows.Add(idPedido,
                        ItPedDAO.ListarItensPedido(idPedido).Rows[i][0].ToString(),
                        ItPedDAO.ListarItensPedido(idPedido).Rows[i][1].ToString(),
                        "R$ " + Convert.ToDouble(ItPedDAO.ListarItensPedido(idPedido).Rows[i][2].ToString()).ToString("#0.00").Replace('.', ','),
                        "R$ " + Convert.ToDouble(ItPedDAO.ListarItensPedido(idPedido).Rows[i][4].ToString()).ToString("#0.00").Replace('.', ','),
                        ItPedDAO.ListarItensPedido(idPedido).Rows[i][3].ToString()
                        );
                }
            }
            catch { }
        }
        #endregion

        #region Interações com GridView
        private void btnAddProdutos_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddProdPedForn telaAddProdPedForn = new frmAddProdPedForn();
                telaAddProdPedForn.ShowDialog();

                if (telaAddProdPedForn.gvExibirProdutos.Rows[telaAddProdPedForn.gvExibirProdutos.CurrentCell.RowIndex].DefaultCellStyle.SelectionBackColor == Color.GreenYellow)
                {
                    bool prodNaLista = false;
                    if (gvExibirProdutos.Rows.Count > 0)
                    {
                        for (int j = 0; j < gvExibirProdutos.Rows.Count; j++)
                        {
                            if (gvExibirProdutos.Rows[j].Cells[1].Value.ToString() == telaAddProdPedForn.gvExibirProdutos.Rows[telaAddProdPedForn.gvExibirProdutos.CurrentCell.RowIndex].Cells[0].Value.ToString())
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
                        double precoTotal = Convert.ToDouble(telaAddProdPedForn.gvExibirProdutos.Rows[telaAddProdPedForn.gvExibirProdutos.CurrentCell.RowIndex].Cells[4].Value.ToString()) * Convert.ToInt32(telaAddProdPedForn.telaQtdProd.txtQtdProd.Text);

                        gvExibirProdutos.Rows.Add(txtID.ToString(),
                            telaAddProdPedForn.gvExibirProdutos.Rows[telaAddProdPedForn.gvExibirProdutos.CurrentCell.RowIndex].Cells[0].Value.ToString(),
                          telaAddProdPedForn.gvExibirProdutos.Rows[telaAddProdPedForn.gvExibirProdutos.CurrentCell.RowIndex].Cells[1].Value.ToString(),
                          "R$ " + Convert.ToDouble(telaAddProdPedForn.gvExibirProdutos.Rows[telaAddProdPedForn.gvExibirProdutos.CurrentCell.RowIndex].Cells[4].Value).ToString("#0.00").Replace('.', ','),
                          "R$ " + precoTotal.ToString("#0.00").Replace('.', ','),
                          telaAddProdPedForn.telaQtdProd.txtQtdProd.Text
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
                frmQtdPedForn telaQtdPedForn = new frmQtdPedForn(Convert.ToInt32(gvExibirProdutos.Rows[gvExibirProdutos.CurrentCell.RowIndex].Cells[0].Value.ToString()));
                telaQtdPedForn.ShowDialog();
                if (telaQtdPedForn.btnCancelar.Enabled == true)
                {
                    gvExibirProdutos.Rows[gvExibirProdutos.CurrentCell.RowIndex].Cells[5].Value = telaQtdPedForn.txtQtdProd.Text;
                    double precoNovo = Convert.ToInt32(gvExibirProdutos.Rows[gvExibirProdutos.CurrentCell.RowIndex].Cells[5].Value) * Convert.ToDouble(gvExibirProdutos.Rows[gvExibirProdutos.CurrentCell.RowIndex].Cells[3].Value.ToString().TrimStart("R$ ".ToCharArray()).TrimEnd(",00".ToCharArray()));
                    gvExibirProdutos.Rows[gvExibirProdutos.CurrentCell.RowIndex].Cells[4].Value = "R$ " + precoNovo.ToString("#0.00");
                }
                else
                {
                    MessageBox.Show("A quantidade não foi escolhida!", "Sem sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

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
                double valorAtual = Convert.ToDouble(txtValor.Text.TrimStart("R$ ".ToCharArray()).TrimEnd(",00".ToCharArray()));
                double valorProduto = Convert.ToDouble(gvExibirProdutos.Rows[gvExibirProdutos.CurrentCell.RowIndex].Cells[4].Value.ToString().TrimStart("R$ ".ToCharArray()).TrimEnd(",00".ToCharArray()));
                txtValor.Text = "R$ " + (valorAtual - valorProduto).ToString("#0.00");

                gvExibirProdutos.Rows.RemoveAt(gvExibirProdutos.CurrentCell.RowIndex);

                MessageBox.Show("Produto excluído da lista com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #endregion

        #region Método Limpar
        public void limpar()
        {
            txtID.Clear();
            dtpData.Value = DateTime.Now;
            mskHora.Clear();
            txtValor.Clear();
            txtFornecedor.Clear();
            txtID.Text = (pedfornDAO.ultimoID() + 1).ToString();
            for (int i = 0; i < gvExibirProdutos.RowCount; i++)
            {
                gvExibirProdutos.Rows.Clear();
            }
        }
        #endregion

        #region Cadastrar Pedido
        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            btnCadastrarPedido.BringToFront();
            btnCadastrarPedido.Enabled = true;
            btnCancelarPedido.BringToFront();
            btnCancelarPedido.Enabled = true;

            btnNovoPedido.SendToBack();
            btnNovoPedido.Enabled = false;

            btnAlterarPedido.SendToBack();
            btnAlterarPedido.Enabled = false;

            btnExcluirPedido.SendToBack();
            btnExcluirPedido.Enabled = false;

            btnCancelarPedido.Visible = true;



            limpar();
        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            btnCadastrarPedido.SendToBack();
            btnCadastrarPedido.Enabled = false;
            btnCancelarPedido.SendToBack();
            btnCancelarPedido.Enabled = false;

            btnNovoPedido.BringToFront();
            btnNovoPedido.Enabled = true;

            btnAlterarPedido.BringToFront();
            btnAlterarPedido.Enabled = true;

            btnExcluirPedido.BringToFront();
            btnExcluirPedido.Enabled = true;

            btnCancelarPedido.Visible = false;

            txtID.Text = (pedfornDAO.ultimoID() + 1).ToString();

            limpar();
        }

        private void btnCadastrarPedido_Click(object sender, EventArgs e)
        {
            if (txtFornecedor.Text == String.Empty || txtID.Text == String.Empty || txtValor.Text == String.Empty ||
                mskHora.MaskFull == false || dtpData.Value == null)
            {
                if (txtFornecedor.Text == String.Empty)
                {
                    txtFornecedor.BackColor = Color.Tomato;
                }
                if (txtID.Text == String.Empty)
                {
                    txtID.BackColor = Color.Tomato;
                }
                if (txtValor.Text == String.Empty)
                {
                    txtValor.BackColor = Color.Tomato;
                }
                if (mskHora.MaskFull == false)
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
                pedForn.Id_forn = Convert.ToInt32(telaPesqfPedForn.idFornecedor);
                pedForn.Valor_ped = Convert.ToDouble(txtValor.Text);
                pedForn.Hora_ped = Convert.ToDateTime(mskHora.Text);
                pedForn.Data_ped = Convert.ToDateTime(dtpData.Text);

                pedfornDAO.inserirPedido(pedForn);

                qtdItens = gvExibirProdutos.RowCount;
                for (int i = 0; i < qtdItens; i++)
                {
                    itPed.Id_ped = pedfornDAO.ultimoID();
                    itPed.Id_prod = Convert.ToInt32(gvExibirProdutos.Rows[i].Cells[0].Value.ToString());
                    itPed.Qtd_itens = Convert.ToInt32(gvExibirProdutos.Rows[i].Cells[3].Value.ToString());

                    ItPedDAO.InserirItensPedido(itPed);
                    prodDAO.adicionarEstoque(Convert.ToInt32(gvExibirProdutos.Rows[i].Cells[1].Value.ToString()), Convert.ToInt32(gvExibirProdutos.Rows[i].Cells[5].Value.ToString()));
                }

                MessageBox.Show("Pedido de Fornecedor cadastrado!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpar();

            }
        }
        #endregion

        #region Excluir Pedido
        private void btnExcluirPedido_Click(object sender, EventArgs e)
        {
            if (Dados.Permissao == "ADMIN" || Dados.Permissao == "FUNCIONARIO")
            {
                DialogResult opcao;

                opcao = MessageBox.Show("Deseja realmente excluir o Pedido de Fornecedor?", "Excluir?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcao == DialogResult.Yes)
                {
                    pedfornDAO.excluirPedido(Convert.ToInt32(txtID.Text));

                    limpar();
                    gvExibirEntradas.Columns.Clear();
                    gvExibirEntradas.DataSource = pedfornDAO.listarPedidos();
                    atualizarGV();

                    MessageBox.Show("Pedido de Fornecedor excluido com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Pedido de Fornecedor não excluido!", "ERRO!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Você não possui permissões para excluir um Pedido de Fornecedor!", "SEM PERMISSÃO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region Alterar Pedido
        private void btnAlterarPedido_Click(object sender, EventArgs e)
        {
            if (txtFornecedor.Text == String.Empty || txtID.Text == String.Empty || txtValor.Text == String.Empty ||
              mskHora.MaskFull == false || dtpData.Value == null)
            {
                if (txtFornecedor.Text == String.Empty)
                {
                    txtFornecedor.BackColor = Color.Tomato;
                }
                if (txtID.Text == String.Empty)
                {
                    txtID.BackColor = Color.Tomato;
                }
                if (txtValor.Text == String.Empty)
                {
                    txtValor.BackColor = Color.Tomato;
                }
                if (mskHora.MaskFull == false)
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
                pedForn.Id_forn = Convert.ToInt32(telaPesqfPedForn.idFornecedor);
                pedForn.Valor_ped = Convert.ToDouble(txtValor.Text.TrimStart("R$ ".ToCharArray()).TrimEnd(",00".ToCharArray()));
                pedForn.Hora_ped = Convert.ToDateTime(mskHora.Text);
                pedForn.Data_ped = Convert.ToDateTime(dtpData.Text);

                pedfornDAO.alterarPedido(Convert.ToInt32(txtID.Text), pedForn);

                for (int i = 0; i < ItPedDAO.ListarItensPedido(Convert.ToInt32(txtID.Text)).Rows.Count; i++)
                {
                    DataTable produtos = ItPedDAO.ListarItensPedido(Convert.ToInt32(txtID.Text));
                    produtos.Rows[i]["QtdItens"].ToString();
                    prodDAO.retirarEstoque(Convert.ToInt32(produtos.Rows[i]["codigo"].ToString()), Convert.ToInt32(produtos.Rows[i]["QtdItens"].ToString()));
                }

                ItPedDAO.excluirItensPedido(Convert.ToInt32(txtID.Text));
                int qtdItens = gvExibirProdutos.RowCount;
                for (int i = 0; i < qtdItens; i++)
                {
                    itPed.Id_ped = pedfornDAO.ultimoID();
                    itPed.Id_prod = Convert.ToInt32(gvExibirProdutos.Rows[i].Cells[0].Value.ToString());
                    itPed.Qtd_itens = Convert.ToInt32(gvExibirProdutos.Rows[i].Cells[3].Value.ToString());

                    ItPedDAO.InserirItensPedido(itPed);
                    prodDAO.adicionarEstoque(Convert.ToInt32(gvExibirProdutos.Rows[i].Cells[1].Value.ToString()), Convert.ToInt32(gvExibirProdutos.Rows[i].Cells[5].Value.ToString()));
                }

                MessageBox.Show("Pedido alterado!", "!!! SUCESSO !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpar();
            }
        }
        #endregion

        #region Selecionar Fornecedor
        private void btnSelecionarForn_Click(object sender, EventArgs e)
        {
            telaPesqfPedForn.ShowDialog();

            if (telaPesqfPedForn.idFornecedor > 0)
            {
                fornDAO.fornPorID(telaPesqfPedForn.idFornecedor);
                txtFornecedor.Text = fornDAO.fornPorID(telaPesqfPedForn.idFornecedor).Nome_forn;
            }
            else
            {
                txtFornecedor.Text = txtFornecedor.Text;
            }
        }
        #endregion

        #region Fechar Tela
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
