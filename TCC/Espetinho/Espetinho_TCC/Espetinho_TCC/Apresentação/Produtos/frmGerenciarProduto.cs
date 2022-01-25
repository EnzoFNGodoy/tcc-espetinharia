using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Espetinho_TCC.Apresentação.Controle_de_Estoque;
using Espetinho_TCC.Apresentação.Fornecedor;
using Espetinho_TCC.DAO;
using Espetinho_TCC.Model;
using Espetinho_TCC.Utils;

namespace Espetinho_TCC.Apresentação
{
    public partial class frmGerenciarProduto : Form
    {
        #region Instâncias
        UsuarioDAO usuDAO = new UsuarioDAO();
        ProdutoDAO prodDAO = new ProdutoDAO();
        Produto prod = new Produto();
        TipoProdutoDAO tipoProdDAO = new TipoProdutoDAO();
        frmSelecionarForn telaGerFornEstoque = new frmSelecionarForn();
        FornecedorDAO fornDAO = new FornecedorDAO();
        #endregion

        #region Variáveis
        DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
        String nomeProd, imgProd, nomeForn, tipoProd;
        int idProd, qtdEstProd;
        double custoProd, precoProd;
        #endregion

        #region Carregar Tela
        public frmGerenciarProduto(string nomeUsu, int id, int qtd, string Prod, double custo, double preco, string Forn, string tipo, string img)
        {
            InitializeComponent();
            lblNomeUsuAtivo.Text = nomeUsu;
            lblNomeUsuAtivo.ForeColor = Color.LawnGreen;
            nomeProd = Prod;
            imgProd = img;
            nomeForn = Forn;
            tipoProd = tipo;
            idProd = id;
            qtdEstProd = qtd;
            custoProd = custo;
            precoProd = preco;
        }

        private void frmGerenciarProduto_Load(object sender, EventArgs e)
        {
            gvExibirProdutos.DataSource = prodDAO.listarProduto();
            atualizarGV();
            atualizarColunaFoto();

            carregarCmbTipoProd();
            prodDAO.produtoPorID(idProd);
            txtIDProd.Text = idProd.ToString();
            txtQtdEstoqueProd.Text = qtdEstProd.ToString();
            txtNomeProd.Text = nomeProd.ToString();
            txtDescProd.Text = prodDAO.Prod.Desc_prod.ToString();
            txtCustoProd.Text = "R$ " + custoProd.ToString("#0.00").Replace('.', ',');
            txtPrecoProd.Text = "R$ " + precoProd.ToString("#0.00").Replace('.', ',');
            atualizarMargemLucro();
            txtFornecedorProd.Text = nomeForn.ToString();
            cmbTipoProd.Text = tipoProd.ToString();
            pbFotoProd.Image = Image.FromFile(imgProd.ToString());

            #region BOTOES
            btnNovoProduto.Enabled = true;
            btnNovoProduto.Visible = true;
            btnNovoProduto.BringToFront();
            btnAlterarProd.Enabled = true;
            btnAlterarProd.Visible = true;
            btnAlterarProd.BringToFront();
            btnExcluirProd.Enabled = true;
            btnExcluirProd.Visible = true;
            btnExcluirProd.BringToFront();

            btnCadastrarProd.Enabled = false;
            btnCadastrarProd.Visible = false;
            btnCadastrarProd.SendToBack();
            btnCancelarProd.Enabled = false;
            btnCancelarProd.Visible = false;
            btnCancelarProd.SendToBack();
            #endregion
        }
        #endregion

        #region Cadastrar Tipo de Produto
        private void btnCadastrarTipoProd_Click(object sender, EventArgs e)
        {
            frmCadastrarTipoProd telaCadTipoProd = new frmCadastrarTipoProd(lblNomeUsuAtivo.Text);
            telaCadTipoProd.ShowDialog();
            carregarCmbTipoProd();
            cmbTipoProd.Text = "";
            cmbTipoProd.SelectedItem = null;
        }
        #endregion

        #region Excluir Produto
        private void btnExcluirProd_Click(object sender, EventArgs e)
        {
            if (Dados.Permissao == "ADMIN" || Dados.Permissao == "FUNCIONARIO")
            {
                DialogResult opcao;

                opcao = MessageBox.Show("Deseja realmente excluir o Produto?", "Excluir?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcao == DialogResult.Yes)
                {
                    prodDAO.excluirProduto(Convert.ToInt32(txtIDProd.Text));
                    MessageBox.Show("Produto excluido com sucesso!", "SUCESSO!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpar();
                    gvExibirProdutos.Columns.Clear();
                    gvExibirProdutos.DataSource = prodDAO.listarProduto();
                    atualizarGV();
                    atualizarColunaFoto();
                }
                else
                {
                    MessageBox.Show("Produto não excluido!", "ERRO!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Você não possui permissões para excluir um Produto!", "SEM PERMISSÃO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region Alterar Produto
        private void btnAlterarProd_Click(object sender, EventArgs e)
        {
            if (Dados.Permissao == "ADMIN" || Dados.Permissao == "FUNCIONARIO")
            {
                if (txtQtdEstoqueProd.Text == String.Empty ||
                    cmbTipoProd.Text == String.Empty || cmbTipoProd.SelectedItem == null ||
                    txtNomeProd.Text == String.Empty || txtDescProd.Text == String.Empty ||
                    txtCustoProd.Text == String.Empty || txtPrecoProd.Text == String.Empty ||
                    txtFornecedorProd.Text == String.Empty || pbFotoProd.ImageLocation == null)
                {
                    if (txtQtdEstoqueProd.Text == String.Empty)
                    {
                        txtQtdEstoqueProd.BackColor = Color.Tomato;
                    }
                    if (cmbTipoProd.Text == String.Empty || cmbTipoProd.SelectedItem == null)
                    {
                        cmbTipoProd.BackColor = Color.Tomato;
                    }
                    if (txtNomeProd.Text == String.Empty)
                    {
                        txtNomeProd.BackColor = Color.Tomato;
                    }
                    if (txtDescProd.Text == String.Empty)
                    {
                        txtDescProd.BackColor = Color.Tomato;
                    }
                    if (txtCustoProd.Text == String.Empty)
                    {
                        txtCustoProd.BackColor = Color.Tomato;
                    }
                    if (txtPrecoProd.Text == String.Empty)
                    {
                        txtPrecoProd.BackColor = Color.Tomato;
                    }
                    if (txtFornecedorProd.Text == String.Empty)
                    {
                        txtFornecedorProd.BackColor = Color.Tomato;
                    }
                    if (pbFotoProd.ImageLocation == null)
                    {
                        pbFotoProd.Image = pbFotoProd.ErrorImage;
                    }

                    MessageBox.Show("Preencher todos os campos!", "ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    prod.Id_tipoprod = Convert.ToInt32(cmbTipoProd.SelectedValue.ToString());
                    if (telaGerFornEstoque.idForn > 0)
                    {
                        prod.Id_forn = telaGerFornEstoque.idForn;
                    }
                    else
                    {
                        prod.Id_forn = prodDAO.produtoPorID(Convert.ToInt32(txtIDProd.Text)).Id_forn;
                    }
                    prod.Nome_prod = txtNomeProd.Text;
                    prod.Preco_prod = Convert.ToDouble(txtPrecoProd.Text.TrimStart("R$ ".ToCharArray()));
                    prod.Custo_prod = Convert.ToDouble(txtCustoProd.Text.TrimStart("R$ ".ToCharArray()));
                    prod.QtdEst_prod = Convert.ToInt32(txtQtdEstoqueProd.Text);
                    prod.Desc_prod = txtDescProd.Text;
                    prod.Foto_prod = pbFotoProd.ImageLocation.Replace(@"\",@"\\");

                    prodDAO.alterarProduto(prod, Convert.ToInt32(txtIDProd.Text));

                    limpar();
                    gvExibirProdutos.Columns.Clear();
                    gvExibirProdutos.DataSource = prodDAO.listarProduto();
                    atualizarGV();
                    atualizarColunaFoto();

                    MessageBox.Show("As informações do Produto foram alterads com sucesso!", "SUCESSO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Você não possui permissões para alterar informações do Produto!", "SEM PERMISSÃO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region Cadastrar Produto
        private void btnCadastrarProd_Click(object sender, EventArgs e)
        {
            if (Dados.Permissao == "ADMIN" || Dados.Permissao == "FUNCIONARIO")
            {
                if (txtQtdEstoqueProd.Text == String.Empty ||
                    cmbTipoProd.Text == String.Empty || cmbTipoProd.SelectedItem == null ||
                    txtNomeProd.Text == String.Empty || txtDescProd.Text == String.Empty ||
                    txtCustoProd.Text == String.Empty || txtPrecoProd.Text == String.Empty ||
                    txtFornecedorProd.Text == String.Empty || pbFotoProd.ImageLocation == String.Empty)
                {
                    if (txtQtdEstoqueProd.Text == String.Empty)
                    {
                        txtQtdEstoqueProd.BackColor = Color.Tomato;
                    }
                    if (cmbTipoProd.Text == String.Empty || cmbTipoProd.SelectedItem == null)
                    {
                        cmbTipoProd.BackColor = Color.Tomato;
                    }
                    if (txtNomeProd.Text == String.Empty)
                    {
                        txtNomeProd.BackColor = Color.Tomato;
                    }
                    if (txtDescProd.Text == String.Empty)
                    {
                        txtDescProd.BackColor = Color.Tomato;
                    }
                    if (txtCustoProd.Text == String.Empty)
                    {
                        txtCustoProd.BackColor = Color.Tomato;
                    }
                    if (txtPrecoProd.Text == String.Empty)
                    {
                        txtPrecoProd.BackColor = Color.Tomato;
                    }
                    if (txtFornecedorProd.Text == String.Empty)
                    {
                        txtFornecedorProd.BackColor = Color.Tomato;
                    }
                    if (pbFotoProd.ImageLocation == String.Empty)
                    {
                        pbFotoProd.Image = pbFotoProd.ErrorImage;
                    }

                    MessageBox.Show("Preencher todos os campos!", "ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    prod.Id_tipoprod = Convert.ToInt32(cmbTipoProd.SelectedValue.ToString());
                    prod.Id_forn = telaGerFornEstoque.idForn;
                    prod.Nome_prod = txtNomeProd.Text;
                    prod.Preco_prod = Convert.ToDouble(txtPrecoProd.Text.TrimStart("R$ ".ToCharArray()));
                    prod.Custo_prod = Convert.ToDouble(txtCustoProd.Text.TrimStart("R$ ".ToCharArray()));
                    prod.QtdEst_prod = Convert.ToInt32(txtQtdEstoqueProd.Text);
                    prod.Desc_prod = txtDescProd.Text;
                    prod.Foto_prod = pbFotoProd.ImageLocation.Replace(@"\", @"\\");

                    prodDAO.inserirProduto(prod);

                    limpar();
                    gvExibirProdutos.Columns.Clear();
                    gvExibirProdutos.DataSource = prodDAO.listarProduto();
                    atualizarGV();
                    atualizarColunaFoto();

                    MessageBox.Show("Produto cadastrado com sucesso!", "SUCESSO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                 MessageBox.Show("Você não possui permissões para cadastrar um novo Produto!", "SEM PERMISSÃO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region Botão Upload Foto
        private void btnUploadFoto_Click(object sender, EventArgs e)
        {
            string diretorioImg;
            if (fldlgFotoUsuario.ShowDialog() == DialogResult.OK)
            {
                diretorioImg = fldlgFotoUsuario.FileName;
                pbFotoProd.ImageLocation = diretorioImg;
                pbFotoProd.Load();
            }
        }
        #endregion

        #region Selecionar Fornecedor
        private void btnPesqForn_Click(object sender, EventArgs e)
        {
            telaGerFornEstoque.ShowDialog();
            if (telaGerFornEstoque.idForn > 0)
            {
                fornDAO.fornPorID(telaGerFornEstoque.idForn);
                txtFornecedorProd.Text = fornDAO.fornPorID(telaGerFornEstoque.idForn).Nome_forn;
            }
            else
            {
                txtFornecedorProd.Text = txtFornecedorProd.Text;
            }
        }
        #endregion

        #region Atualizar Margem de Lucro
        private void atualizarMargemLucro()
        {
            double custo, preco, margemLucro;
            custo = Convert.ToDouble(txtCustoProd.Text.TrimStart("R$ ".ToCharArray()).TrimEnd(",".ToCharArray()).ToString());
            preco = Convert.ToDouble(txtPrecoProd.Text.TrimStart("R$ ".ToCharArray()).TrimEnd(",".ToCharArray()).ToString());
            margemLucro = ((preco - custo) / custo) * 100;
            txtMargemLucroProd.Text = margemLucro.ToString("#0.00") + "%";
        }

        private void txtPrecoProd_TextChanged(object sender, EventArgs e)
        {
            try
            {
                atualizarMargemLucro();
            }
            catch { }
        }

        private void txtCustoProd_TextChanged(object sender, EventArgs e)
        {
            try
            {
                atualizarMargemLucro();
            }
            catch { }
        }
        #endregion

        #region Pesquisar Produtos no GridView
        private void txtPesquisaPorNome_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (prodDAO.PesquisarProdNomeGV(txtPesquisaPorNome.Text).Rows.Count > 0)
                {
                    gvExibirProdutos.Columns.Clear();
                    gvExibirProdutos.DataSource = prodDAO.PesquisarProdNomeGV(txtPesquisaPorNome.Text);
                    atualizarGV();
                    atualizarColunaFoto();
                }
                else
                    gvExibirProdutos.DataSource = null;
            }
            catch { }
        }
        #endregion

        #region Atualizar GridView
        private void atualizarGV()
        {
            try
            {
                gvExibirProdutos.Columns[0].HeaderText = "Código";
                gvExibirProdutos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirProdutos.Columns[1].HeaderText = "Produto";
                gvExibirProdutos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirProdutos.Columns[2].Visible = false; // DESCRIÇÃO
                gvExibirProdutos.Columns[3].Visible = false; // CUSTO
                gvExibirProdutos.Columns[4].Visible = false; // PREÇO
                gvExibirProdutos.Columns[5].Visible = false; // QUANTIDADE
                gvExibirProdutos.Columns[6].Visible = false; // TIPO DE PRODUTO
                gvExibirProdutos.Columns[7].Visible = false; // NOME DO FORNECEDOR
                gvExibirProdutos.Columns[8].Visible = false; // FOTO
                gvExibirProdutos.Columns.Add(imgCol);
                imgCol.HeaderText = "Foto";
                imgCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                imgCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            catch { }
        }

        private void atualizarColunaFoto()
        {
            for (int i = 0; i < gvExibirProdutos.Rows.Count; i++)
            {
                Image imgProd = Image.FromFile(gvExibirProdutos.Rows[i].Cells[8].Value.ToString());
                gvExibirProdutos.Rows[i].Cells[9].Value = imgProd;
                gvExibirProdutos.Rows[i].Height = 100;
            }
        }

        private void gvExibirProdutos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                atualizarGV();
                atualizarColunaFoto();
            }
            catch { }
        }
        #endregion

        #region Exibir Produto no Clique do GridView
        private void gvExibirProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            limpar();

            txtIDProd.Text = gvExibirProdutos.Rows[gvExibirProdutos.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtQtdEstoqueProd.Text = gvExibirProdutos.Rows[gvExibirProdutos.CurrentCell.RowIndex].Cells[5].Value.ToString();
            txtNomeProd.Text = gvExibirProdutos.Rows[gvExibirProdutos.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtDescProd.Text = gvExibirProdutos.Rows[gvExibirProdutos.CurrentCell.RowIndex].Cells[2].Value.ToString();
            double custo = Convert.ToDouble(gvExibirProdutos.Rows[gvExibirProdutos.CurrentCell.RowIndex].Cells[3].Value.ToString());
            txtCustoProd.Text = "R$ " + custo.ToString("#0.00").Replace('.', ',');
            double preco = Convert.ToDouble(gvExibirProdutos.Rows[gvExibirProdutos.CurrentCell.RowIndex].Cells[4].Value.ToString());
            txtPrecoProd.Text = "R$ " + preco.ToString("#0.00").Replace('.', ',');
            atualizarMargemLucro();
            txtFornecedorProd.Text = gvExibirProdutos.Rows[gvExibirProdutos.CurrentCell.RowIndex].Cells[7].Value.ToString();
            cmbTipoProd.Text = gvExibirProdutos.Rows[gvExibirProdutos.CurrentCell.RowIndex].Cells[6].Value.ToString();
            pbFotoProd.Image = Image.FromFile(gvExibirProdutos.Rows[gvExibirProdutos.CurrentCell.RowIndex].Cells[8].Value.ToString());

            #region BOTOES
            btnNovoProduto.Enabled = true;
            btnNovoProduto.Visible = true;
            btnNovoProduto.BringToFront();
            btnAlterarProd.Enabled = true;
            btnAlterarProd.Visible = true;
            btnAlterarProd.BringToFront();
            btnExcluirProd.Enabled = true;
            btnExcluirProd.Visible = true;
            btnExcluirProd.BringToFront();

            btnCadastrarProd.Enabled = false;
            btnCadastrarProd.Visible = false;
            btnCadastrarProd.SendToBack();
            btnCancelarProd.Enabled = false;
            btnCancelarProd.Visible = false;
            btnCancelarProd.SendToBack();
            #endregion
        }
        #endregion

        #region Botão Cancelar
        private void btnCancelarProd_Click(object sender, EventArgs e)
        {
            limpar();
        }
        #endregion

        #region Carregar Combo Tipo de Produto
        private void carregarCmbTipoProd()
        {
            cmbTipoProd.DataSource = tipoProdDAO.listarTipoProd();
            cmbTipoProd.ValueMember = "id_tipoprod";
            cmbTipoProd.DisplayMember = "tipo_produto";
        }
        #endregion

        #region Limpar Tela e Começar um Novo Produto
        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void limpar()
        {
            #region BOTOES
            btnNovoProduto.Enabled = false;
            btnNovoProduto.Visible = false;
            btnNovoProduto.SendToBack();
            btnAlterarProd.Enabled = false;
            btnAlterarProd.Visible = false;
            btnAlterarProd.SendToBack();
            btnExcluirProd.Enabled = false;
            btnExcluirProd.Visible = false;
            btnExcluirProd.SendToBack();

            btnCadastrarProd.Enabled = true;
            btnCadastrarProd.Visible = true;
            btnCadastrarProd.BringToFront();
            btnCancelarProd.Enabled = true;
            btnCancelarProd.Visible = true;
            btnCancelarProd.BringToFront();
            #endregion

            #region OUTROS OBJETOS
            txtIDProd.Clear();
            txtIDProd.Text = (prodDAO.ultimoID()+1).ToString();
            txtQtdEstoqueProd.Clear();
            txtQtdEstoqueProd.ReadOnly = false;
            cmbTipoProd.Text = String.Empty;
            cmbTipoProd.SelectedItem = null;
            txtNomeProd.Clear();
            txtNomeProd.ReadOnly = false;
            txtDescProd.Clear();
            txtDescProd.ReadOnly = false;
            txtCustoProd.Clear();
            txtCustoProd.ReadOnly = false;
            txtPrecoProd.Clear();
            txtPrecoProd.ReadOnly = false;
            txtMargemLucroProd.Clear();
            txtFornecedorProd.Clear();
            pbFotoProd.Image = pbFotoProd.ErrorImage;
            #endregion
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