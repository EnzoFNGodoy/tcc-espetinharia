using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Espetinho_TCC.Model;
using Espetinho_TCC.DAO;
using Espetinho_TCC.Apresentação.Caixa;
using Espetinho_TCC.Utils;

namespace Espetinho_TCC.Apresentação
{
    public partial class frmCaixa : Form
    {
        #region Instancias
        Espetinho_TCC.Model.Funcionario func = new Espetinho_TCC.Model.Funcionario();
        FuncionarioDAO funcDAO = new FuncionarioDAO();
        Produto prod = new Produto();
        ProdutoDAO prodDAO = new ProdutoDAO();
        Comanda com = new Comanda();
        ComandaDAO comDAO = new ComandaDAO();
        ItensComanda itCom = new ItensComanda();
        ItensComandaDAO itComDAO = new ItensComandaDAO();
        Usuario usu = new Usuario();
        UsuarioDAO usuDAO = new UsuarioDAO();
        Pagamento pagto = new Pagamento();
        PagamentoDAO pagtoDAO = new PagamentoDAO();
        TipoProduto tipoProd = new TipoProduto();
        TipoProdutoDAO tipoProdDAO = new TipoProdutoDAO();
        Financas fin = new Financas();
        FinancasDAO finDAO = new FinancasDAO();
        #endregion

        #region Variaveis
        int qtdComp, qtdEst, qtdEstAtual, qtdItens;
        double precoProdTotal, preco, total, totalPedido, Troco, valReceb, subTotal, descontoTotal = 0;
        double valorDesc;
        #endregion

        #region Inicializar Form
        public frmCaixa(String nomeUsu)
        {
            InitializeComponent();
            lblNomeUsuAtivo.Text = nomeUsu;
            lblNomeUsuAtivo.ForeColor = Color.LawnGreen;
        }

        private void frmCaixa_Load(object sender, EventArgs e)
        {
            carregarCmbPagto();
            limparPedido();
        }
        #endregion

        #region Metódo Limpar
        public void limparPedido()
        {
            txtPrecoUnitProd.Clear();
            txtQtdEstoque.Clear();
            txtTotalCom.Text = "R$ 0,00";
            txtValReceb.Text = "R$ 0,00";
            txtTroco.Text = "R$ 0,00";
            txtProduto.Clear();
            txtQtdProd.Clear();
            gvCarrinho.Rows.Clear();
            pbFotoProd.Image = pbFotoProd.InitialImage;
            cmbPagto.SelectedItem = null;
            txtSubTotal.Text = "R$ 0,00";
        }
        #endregion

        #region Validar Pedido
        private void btnValidarPedido_Click(object sender, EventArgs e)
        {
            if (valorValido(Convert.ToDouble(txtValReceb.Text.TrimStart("R$ ".ToCharArray()).TrimEnd(",00".ToCharArray())).ToString()) == false)
            {
                if (txtTotalCom.Text != String.Empty)
                {
                    txtValReceb.Text = txtTotalCom.Text;
                }
                else
                {
                    txtValReceb.Text = "R$ 0,00";
                }
                MessageBox.Show("Valor recebido inválido!", "Valor inválido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (Convert.ToDouble(txtValReceb.Text.TrimStart("R$ ".ToCharArray())) >= Convert.ToDouble(txtTotalCom.Text.TrimStart("R$ ".ToCharArray()))
                    && gvCarrinho.Rows.Count > 0)
                {
                    frmValidarCompra telaValidarCompra = new frmValidarCompra(Dados.IdUsu);
                    telaValidarCompra.ShowDialog();
                    if (telaValidarCompra.validou == true)
                    {
                        try
                        {
                            if (txtTotalCom.Text == String.Empty ||
                                txtValReceb.Text == String.Empty || txtSubTotal.Text == String.Empty)
                            {
                                if (txtTotalCom.Text == String.Empty)
                                {
                                    txtTotalCom.BackColor = Color.Red;
                                }
                                if (txtValReceb.Text == String.Empty)
                                {
                                    txtValReceb.BackColor = Color.Red;
                                }
                                if (txtSubTotal.Text == String.Empty)
                                {
                                    txtSubTotal.BackColor = Color.Red;
                                }

                                MessageBox.Show("Preencher todos os campos!", "ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                if (cmbPagto.Text == "DINHEIRO")
                                {
                                    txtValReceb.Text = txtValReceb.Text.TrimStart("R$ ".ToCharArray());
                                    valReceb = Convert.ToDouble(txtValReceb.Text);
                                    Troco = valReceb - totalPedido;
                                    txtTroco.Text = "R$" + Troco.ToString("#0.00");

                                    if (valReceb <= 0 || valReceb < total)
                                    {
                                        txtValReceb.Text = "R$ 0,00";
                                        txtTroco.Text = "R$ 0,00";
                                        MessageBox.Show("Dinheiro insuficiente para pagar!", "DINHEIRO INSUFICIENTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                }
                                else
                                {
                                    txtTroco.Text = "R$ 0,00";
                                }

                                // INSERIR FINANÇA
                                fin.Data_fin = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                                fin.Obs_fin = "Comanda";
                                fin.Valor_fin = Convert.ToDouble(totalPedido.ToString().Replace(',', '.').TrimStart("R$ ".ToCharArray()).TrimEnd(",00".ToCharArray())); ;

                                finDAO.inserirEntradas(fin);
                                // ============ //

                                com.Id_pagto = Convert.ToInt32(cmbPagto.SelectedValue.ToString());
                                com.Id_cli = telaValidarCompra.idCli;
                                com.Id_func = telaValidarCompra.idFunc;
                                com.Valor_com = totalPedido;
                                com.Data_com = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                                com.Hora_com = Convert.ToDateTime(DateTime.Now.ToShortTimeString());
                                com.Id_fin = finDAO.buscarUltID();

                                comDAO.validar(com);

                                #region Cadastrar Itens
                                qtdItens = gvCarrinho.RowCount;
                                for (int i = 0; i < qtdItens; i++)
                                {
                                    itCom.Id_com = itComDAO.buscarUltCom();
                                    itCom.Id_prod = Convert.ToInt32(gvCarrinho.Rows[i].Cells[0].Value.ToString());
                                    itCom.Qtd_itens = Convert.ToInt32(gvCarrinho.Rows[i].Cells[4].Value.ToString());

                                    itComDAO.inserirItensComanda(itCom);
                                    prodDAO.retirarEstoque(Convert.ToInt32(gvCarrinho.Rows[i].Cells[0].Value.ToString()), Convert.ToInt32(gvCarrinho.Rows[i].Cells[4].Value.ToString()));
                                }
                                #endregion

                                MessageBox.Show("Comanda validada!", "!!! SUCESSO !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                limparPedido();
                                txtValReceb.Enabled = true;
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Algum erro ocorreu!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Você não validou a compra!", "Comanda não validada!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    if (Convert.ToDouble(txtValReceb.Text.TrimStart("R$ ".ToCharArray()).TrimEnd(",00".ToCharArray())) <= 0)
                    {
                        MessageBox.Show("O valor recebido é negativo ou igual a zero!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("O valor recebido é menor que o valor total da comanda ou você não adicionou nenhum produto ao carrinho!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
        #endregion

        #region Carregar ComboBox Pagamento
        private void carregarCmbPagto()
        {
            cmbPagto.DataSource = pagtoDAO.listarPagamento();
            cmbPagto.ValueMember = "id_pagto";
            cmbPagto.DisplayMember = "tipo_pagto";
            cmbPagto.Text = "";
        }
        #endregion

        #region Pesquisar e Selecionar Produtos
        private void btnPesqProd_Click(object sender, EventArgs e)
        {
            frmSelecionarProduto telaSelecProd = new frmSelecionarProduto();
            telaSelecProd.ShowDialog();
            for (int i = 0; i < telaSelecProd.gvExibirProdutos.Rows.Count; i++)
            {
                if (telaSelecProd.gvExibirProdutos.Rows[i].DefaultCellStyle.SelectionBackColor == Color.GreenYellow)
                {
                    bool prodNoCarrinho = false;
                    if (gvCarrinho.Rows.Count > 0)
                    {
                        for (int j = 0; j < gvCarrinho.Rows.Count; j++)
                        {
                            if (gvCarrinho.Rows[j].Cells[0].Value.ToString() == telaSelecProd.gvExibirProdutos.Rows[i].Cells[0].Value.ToString())
                            {
                                prodNoCarrinho = true;
                            }
                        }
                    }
                    if (prodNoCarrinho == false)
                    {
                        try
                        {
                            txtProduto.Text = telaSelecProd.gvExibirProdutos.Rows[i].Cells[1].Value.ToString();
                            prodDAO.PesquisarProd(txtProduto.Text);
                            txtPrecoUnitProd.Text = "R$" + prodDAO.Prod.Preco_prod.ToString("#0.00");
                            txtQtdProd.Text = "1";
                            txtQtdEstoque.Text = prodDAO.Prod.QtdEst_prod.ToString();
                            pbFotoProd.ImageLocation = prodDAO.Prod.Foto_prod.ToString();
                            pbFotoProd.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        catch { }
                    }
                    else
                    {
                        MessageBox.Show("Esse produto já está incluso na compra!", "ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
        #endregion

        #region Aumentar e Diminuir Quantidade
        private void txtQtdProd_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtQtdEstoque.Text = Convert.ToInt32(prodDAO.Prod.QtdEst_prod - Convert.ToInt32(txtQtdProd.Text)).ToString();
                if (Convert.ToInt32(txtQtdProd.Text) > prodDAO.Prod.QtdEst_prod)
                {
                    txtQtdProd.Text = (Convert.ToInt32(txtQtdProd.Text) - 1).ToString();
                    MessageBox.Show("Quantidade Insuficiente!", "Erro!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch { }
            txtQtdProd.BackColor = Color.Empty;
        }

        private void btnAumentarQtd_Click(object sender, EventArgs e)
        {
            try
            {
                txtQtdProd.Text = (Convert.ToInt32(txtQtdProd.Text) + 1).ToString();
                if (Convert.ToInt32(txtQtdProd.Text) != 0)
                {
                    if (Convert.ToInt32(txtQtdProd.Text) == 1)
                    {
                        btnDiminuirQtd.Enabled = false;
                    }
                    if (Convert.ToInt32(txtQtdProd.Text) < 1)
                    {
                        txtQtdProd.Text = (Convert.ToInt32(txtQtdProd.Text) + 1).ToString();
                        MessageBox.Show("Quantidade negativa ou igual a zero!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        btnDiminuirQtd.Enabled = true;
                    }
                }
            }
            catch { }
        }

        private void btnDiminuirQtd_Click(object sender, EventArgs e)
        {
            try
            {
                txtQtdProd.Text = (Convert.ToInt32(txtQtdProd.Text) - 1).ToString();
                if (Convert.ToInt32(txtQtdProd.Text) != 0)
                {
                    if (Convert.ToInt32(txtQtdProd.Text) == 1)
                    {
                        btnDiminuirQtd.Enabled = false;
                    }
                    if (Convert.ToInt32(txtQtdProd.Text) < 1)
                    {
                        txtQtdProd.Text = (Convert.ToInt32(txtQtdProd.Text) + 1).ToString();
                        MessageBox.Show("Quantidade negativa ou igual a zero!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        btnDiminuirQtd.Enabled = true;
                    }
                }
            }
            catch { }
        }
        #endregion

        #region Alterar Item no Carrinho
        private void gvCarrinho_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                frmAlterarItemCarrinho telaAlterarItemCarrinho = new frmAlterarItemCarrinho(Convert.ToInt32
                (gvCarrinho.Rows[gvCarrinho.CurrentCell.RowIndex].Cells[4].Value.ToString()),
                Convert.ToDouble(gvCarrinho.Rows[gvCarrinho.CurrentCell.RowIndex].Cells[3].Value.ToString().TrimStart("R$ ".ToCharArray())));
                telaAlterarItemCarrinho.ShowDialog();
                if (telaAlterarItemCarrinho.btnAlterar.Enabled == false)
                {
                    try
                    {
                        totalPedido = totalPedido - Convert.ToDouble
                            (gvCarrinho.Rows[gvCarrinho.CurrentCell.RowIndex].Cells[3].Value.ToString().TrimStart("R$ ".ToCharArray()));
                        double precoNovo = Convert.ToDouble(telaAlterarItemCarrinho.txtPrecoUnit.Text.TrimStart("R$ ".ToCharArray())) *
                            Convert.ToInt32(telaAlterarItemCarrinho.txtQtdProd.Text);
                        gvCarrinho.Rows[gvCarrinho.CurrentCell.RowIndex].Cells[2].Value = "R$ " + Convert.ToDouble(telaAlterarItemCarrinho.txtPrecoUnit.Text.TrimStart("R$ ".ToCharArray())).ToString("#0.00").Replace('.', ',');
                        gvCarrinho.Rows[gvCarrinho.CurrentCell.RowIndex].Cells[3].Value = "R$ " + precoNovo.ToString("#0.00").Replace('.', ',');
                        gvCarrinho.Rows[gvCarrinho.CurrentCell.RowIndex].Cells[4].Value = telaAlterarItemCarrinho.txtQtdProd.Text;
                        totalPedido = totalPedido + (Convert.ToInt32(telaAlterarItemCarrinho.txtQtdProd.Text) *
                            Convert.ToDouble(telaAlterarItemCarrinho.txtPrecoUnit.Text.TrimStart("R$ ".ToCharArray())));
                        total = totalPedido;
                        txtSubTotal.Text = "R$ " + totalPedido.ToString("#0.00").Replace('.', ',');
                        txtTotalCom.Text = txtSubTotal.Text;
                        if (cmbPagto.Text == "DÉBITO" || cmbPagto.Text == "CRÉDITO")
                        {
                            txtValReceb.Text = txtTotalCom.Text;
                        }
                        MessageBox.Show("Produto alterado com sucesso!", "SUCESSO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch { }
                }
                if (telaAlterarItemCarrinho.btnExcluirItem.Enabled == false)
                {
                    try
                    {
                        double valorProduto = Convert.ToDouble(gvCarrinho.Rows[gvCarrinho.CurrentCell.RowIndex].Cells[3].Value.ToString().TrimStart("R$ ".ToCharArray()).TrimEnd(",00".ToCharArray()));
                        totalPedido = totalPedido - valorProduto;
                        double precoNovo = Convert.ToDouble(telaAlterarItemCarrinho.txtPrecoUnit.Text.TrimStart("R$ ".ToCharArray())) *
                            Convert.ToInt32(telaAlterarItemCarrinho.txtQtdProd.Text);
                        gvCarrinho.Rows[gvCarrinho.CurrentCell.RowIndex].Cells[2].Value = "R$ " + Convert.ToDouble(telaAlterarItemCarrinho.txtPrecoUnit.Text.TrimStart("R$ ".ToCharArray())).ToString("#0.00").Replace('.', ',');
                        gvCarrinho.Rows[gvCarrinho.CurrentCell.RowIndex].Cells[3].Value = "R$ " + precoNovo.ToString("#0.00").Replace('.', ',');
                        gvCarrinho.Rows[gvCarrinho.CurrentCell.RowIndex].Cells[4].Value = telaAlterarItemCarrinho.txtQtdProd.Text;
                        total = totalPedido;
                        txtSubTotal.Text = "R$ " + totalPedido.ToString("#0.00").Replace('.', ',');
                        txtTotalCom.Text = txtSubTotal.Text;
                        if (cmbPagto.Text == "DÉBITO" || cmbPagto.Text == "CRÉDITO")
                        {
                            txtValReceb.Text = txtTotalCom.Text;
                        }
                        gvCarrinho.Rows.RemoveAt(gvCarrinho.CurrentCell.RowIndex);
                        MessageBox.Show("Produto excluído com sucesso!", "SUCESSO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch { }
                }
                for (int i = 0; i < gvCarrinho.Rows.Count; i++)
                {
                    gvCarrinho.Rows[i].Height = 100;
                }
            }
            catch { }
        }
        #endregion

        #region Enviar Carrinho
        private void btnEnviarCarrinho_Click(object sender, EventArgs e)
        {
            if (txtQtdProd.Text == String.Empty || txtProduto.Text == String.Empty)
            {
                if (txtQtdProd.Text == String.Empty)
                {
                    txtQtdProd.BackColor = Color.Red;
                }
                if (txtProduto.Text == String.Empty)
                {
                    txtProduto.BackColor = Color.Red;
                }

                MessageBox.Show("Preencha todos os campos!", "Preencher!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    CalcularVenda();
                    CalcularTotal();
                    if (qtdComp <= qtdEst)
                    {
                        prodDAO.Prod.QtdEst_prod = Convert.ToInt32(txtQtdEstoque.Text);
                        prodDAO.PesquisarProd(txtProduto.Text);
                        Double precoUnitProduto = Convert.ToDouble(txtPrecoUnitProd.Text.TrimStart("R$ ".ToCharArray()));
                        gvCarrinho.Rows.Add(
                            prodDAO.Prod.Id_prod.ToString(),
                            txtProduto.Text,
                            "R$ " + precoUnitProduto.ToString("#0.00").Replace('.', ','),
                            "R$ " + precoProdTotal.ToString("#0.00").Replace('.', ','),
                            qtdComp,
                            pbFotoProd.Image);
                        txtSubTotal.Text = "R$ " + totalPedido.ToString("#0.00");
                        txtTotalCom.Text = "R$ " + totalPedido.ToString("#0.00");
                        if (cmbPagto.Text == "DÉBITO" || cmbPagto.Text == "CRÉDITO")
                        {
                            txtValReceb.Text = txtTotalCom.Text;
                        }

                        txtProduto.Clear();
                        txtQtdProd.Clear();
                        txtQtdEstoque.Clear();
                        txtPrecoUnitProd.Clear();
                        pbFotoProd.Image = pbFotoProd.InitialImage;
                        gvCarrinho.ClearSelection();
                        pbFotoProd.SizeMode = PictureBoxSizeMode.CenterImage;
                    }
                    else
                    {
                        MessageBox.Show("Quantidade Insuficiente!", "Erro!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                catch { }

                for (int i = 0; i < gvCarrinho.Rows.Count; i++)
                {
                    gvCarrinho.Rows[i].Height = 100;
                }
            }
        }
        #endregion

        #region Novo Pedido
        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            limparPedido();
            gvCarrinho.Rows.Clear();
            total = 0;
            totalPedido = 0;
            subTotal = 0;
            descontoTotal = 0;
        }
        #endregion

        #region Calcular Venda e Total
        private void CalcularVenda()
        {
            try
            {
                preco = Convert.ToDouble(prodDAO.Prod.Preco_prod.ToString());
                qtdComp = Convert.ToInt32(txtQtdProd.Text);
                qtdEst = prodDAO.Prod.QtdEst_prod;

                if (qtdComp <= qtdEst)
                {
                    qtdEstAtual = qtdEst - qtdComp;

                    txtQtdEstoque.Text = qtdEstAtual.ToString();

                    precoProdTotal = qtdComp * preco;
                }
            }
            catch { }
        }

        private void CalcularTotal()
        {
            subTotal = precoProdTotal;
            total = subTotal + total;
            totalPedido = total;
        }

        private void txtValReceb_TextChanged(object sender, EventArgs e)
        {
            calcularTroco();
        }

        private void calcularTroco()
        {
            double troco = 0;
            try
            {
                troco = Convert.ToDouble(txtValReceb.Text.TrimStart("R$ ".ToCharArray())) -
                    Convert.ToDouble(txtTotalCom.Text.TrimStart("R$ ".ToCharArray()));
                txtTroco.Text = "R$ " + troco.ToString("#0.00");
            }
            catch { }
        }
        #endregion

        #region Adicionar Desconto

        #region Método Valor Valido
        private static bool valorValido(string texto)
        {
            bool eNumero = false;
            bool todosSaoNumeros = false;
            for (int i = 0; i < texto.Length; i++)
            {
                eNumero = Char.IsDigit(texto, i);
                if (eNumero != true)
                {
                    todosSaoNumeros = false;
                    return false;
                }
                else
                {
                    todosSaoNumeros = true;
                }
            }
            if (todosSaoNumeros == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        private void btnAddDesconto1_Click(object sender, EventArgs e)
        {
            pnlAddDesconto.Visible = true;
            pnlAddDesconto.BringToFront();
        }

        private void txtDescEmPorcentagem_TextChanged(object sender, EventArgs e)
        {
            txtDescEmRS.ReadOnly = true;
        }

        private void txtDescEmRS_TextChanged(object sender, EventArgs e)
        {
            txtDescEmPorcentagem.ReadOnly = true;
        }

        private void btnFecharPnlAddDesc_Click(object sender, EventArgs e)
        {
            pnlAddDesconto.Visible = false;
        }

        private void btnAddDesc_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescEmRS.Text == String.Empty &&
                   txtDescEmPorcentagem.Text == String.Empty)
                {
                    if (txtDescEmRS.Text == String.Empty)
                    {
                        txtDescEmRS.BackColor = Color.Red;
                    }
                    if (txtDescEmPorcentagem.Text == String.Empty)
                    {
                        txtDescEmPorcentagem.BackColor = Color.Red;
                    }

                    MessageBox.Show("Favor preencher os campos em vermelho!", "Campos vazios!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (txtDescEmPorcentagem.Text != String.Empty
                        || txtDescEmRS.Text != String.Empty)
                    {
                        if (txtDescEmPorcentagem.Text != String.Empty)
                        {
                            if (valorValido(Convert.ToDouble(txtDescEmPorcentagem.Text.TrimStart("R$ ".ToCharArray()).TrimEnd(",00".ToCharArray())).ToString()) == false)
                            {
                                txtDescEmPorcentagem.Clear();
                                MessageBox.Show("Digite um valor válido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                if (Convert.ToDouble(txtDescEmPorcentagem.Text) >= 100 || Convert.ToDouble(txtDescEmPorcentagem.Text) <= 0)
                                {
                                    txtDescEmPorcentagem.Clear();
                                    txtDescEmRS.Clear();
                                    MessageBox.Show("Digite um valor válido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                                else
                                {
                                    valorDesc = Convert.ToDouble(txtDescEmPorcentagem.Text);
                                    descontoTotal = total * (valorDesc / 100);
                                    totalPedido = (total - (descontoTotal));

                                    txtTotalCom.Text = "R$ " + totalPedido.ToString("#0.00");
                                }
                            }
                        }
                        else
                        {
                            if (txtDescEmRS.Text != String.Empty)
                            {
                                if (valorValido(Convert.ToDouble(txtDescEmRS.Text.TrimStart("R$ ".ToCharArray()).TrimEnd(",00".ToCharArray())).ToString()) == false)
                                {
                                    txtDescEmRS.Clear();
                                    MessageBox.Show("Digite um valor válido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                                else
                                {
                                    if (Convert.ToDouble(txtDescEmRS.Text.TrimStart("R$ ".ToCharArray()).TrimEnd(",00".ToCharArray())) > Convert.ToDouble(txtTotalCom.Text.TrimStart("R$ ".ToCharArray()).TrimEnd(",00".ToCharArray())))
                                    {
                                        txtDescEmRS.Clear();
                                        MessageBox.Show("Desconto maior que o Valor Total!", "Impossível realizar a ação!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                    else
                                    {
                                        descontoTotal = Convert.ToDouble(txtDescEmRS.Text);
                                        totalPedido = (total - (descontoTotal));

                                        txtTotalCom.Text = "R$ " + totalPedido.ToString("#0.00");
                                    }
                                }
                            }
                        }
                    }
                }

                txtDescEmPorcentagem.Text = String.Empty;
                txtDescEmRS.Text = String.Empty;
                txtDescEmPorcentagem.ReadOnly = false;
                txtDescEmRS.ReadOnly = false;
                descontoTotal = 0;
                pnlAddDesconto.Visible = false;
            }
            catch { }
        }
        #endregion

        #region Escolher Tipo de Pagamento
        private void cmbPagto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPagto.SelectedIndex != 0)
            {
                txtValReceb.Text = txtTotalCom.Text;
                txtValReceb.ReadOnly = true;
            }
            else
            {
                txtValReceb.ReadOnly = false;
                txtValReceb.Text = "R$ 0,00";
            }
        }
        #endregion

        #region Descolorir Campos
        private void txtTroco_TextChanged(object sender, EventArgs e)
        {
            txtTroco.BackColor = Color.Empty;
        }

        private void txtPrecoUnitProd_TextChanged(object sender, EventArgs e)
        {
            txtPrecoUnitProd.BackColor = Color.Empty;
        }

        private void txtQtdEstoque_TextChanged(object sender, EventArgs e)
        {
            txtQtdEstoque.BackColor = Color.Empty;
        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {
            txtProduto.BackColor = Color.Empty;
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
