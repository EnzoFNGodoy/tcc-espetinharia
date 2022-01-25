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
using Espetinho_TCC.DAO;
using Espetinho_TCC.Model;
using Espetinho_TCC.Utils;

namespace Espetinho_TCC.Apresentação.Fornecedor
{
    public partial class frmGerenciarFornecedor : Form
    {
        #region Instâncias
        UsuarioDAO usuDAO = new UsuarioDAO();
        FornecedorDAO fornDAO = new FornecedorDAO();
        Espetinho_TCC.Model.Fornecedor forn = new Espetinho_TCC.Model.Fornecedor();
        #endregion

        #region Carregar Tela
        public frmGerenciarFornecedor(string nomeUsu)
        {
            InitializeComponent();
            lblNomeUsuAtivo.Text = nomeUsu;
            lblNomeUsuAtivo.ForeColor = Color.LawnGreen;
        }

        private void frmGerenciarForn_Load(object sender, EventArgs e)
        {
            gvExibirForn.DataSource = fornDAO.listarFornecedor();
            atualizarGV();
            txtIDForn.Text = gvExibirForn.Rows[gvExibirForn.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtNomeForn.Text = gvExibirForn.Rows[gvExibirForn.CurrentCell.RowIndex].Cells[1].Value.ToString();
            if (gvExibirForn.Rows[gvExibirForn.CurrentCell.RowIndex].Cells[2].Value.ToString() == "")
            {
                txtCnpjForn.Text = gvExibirForn.Rows[gvExibirForn.CurrentCell.RowIndex].Cells[3].Value.ToString();
                txtCpfForn.Text = "NÃO POSSUI CPF!";
            }
            else
            {
                txtCnpjForn.Text = "NÃO POSSUI CNPJ!";
                txtCpfForn.Text = gvExibirForn.Rows[gvExibirForn.CurrentCell.RowIndex].Cells[2].Value.ToString();
            }
            txtTelForn.Text = gvExibirForn.Rows[gvExibirForn.CurrentCell.RowIndex].Cells[4].Value.ToString(); ;
            txtEmailForn.Text = gvExibirForn.Rows[gvExibirForn.CurrentCell.RowIndex].Cells[5].Value.ToString();

            #region BOTOES
            btnNovoFornecedor.Enabled = true;
            btnNovoFornecedor.Visible = true;
            btnNovoFornecedor.BringToFront();
            btnAlterar.Enabled = true;
            btnAlterar.Visible = true;
            btnAlterar.BringToFront();
            btnExcluir.Enabled = true;
            btnExcluir.Visible = true;
            btnExcluir.BringToFront();

            btnCadastrarFornecedor.Enabled = false;
            btnCadastrarFornecedor.Visible = false;
            btnCadastrarFornecedor.SendToBack();
            btnCancelar.Enabled = false;
            btnCancelar.Visible = false;
            btnCancelar.SendToBack();
            #endregion
        }
        #endregion

        #region Atualizar GridView
        private void atualizarGV()
        {
            try
            {
                gvExibirForn.Columns[0].HeaderText = "Código";
                gvExibirForn.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirForn.Columns[1].HeaderText = "Nome";
                gvExibirForn.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirForn.Columns[2].Visible = false;
                gvExibirForn.Columns[3].Visible = false;
                gvExibirForn.Columns[4].Visible = false;
                gvExibirForn.Columns[5].HeaderText = "Email";
                gvExibirForn.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                for (int i = 0; i < gvExibirForn.Rows.Count; i++)
                {
                    gvExibirForn.Rows[i].Height = 80;
                }
            }
            catch { }
        }
        #endregion

        #region Pesquisar GridView
        private void txtPesquisaPorNome_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (fornDAO.pesquisarFornGV(txtPesquisaPorNome.Text).Rows.Count > 0)
            //    {
            //        gvExibirForn.DataSource = fornDAO.pesquisarFornGV(txtPesquisaPorNome.Text);
            //        atualizarGV();
            //    }
            //    else
            //        gvExibirForn.DataSource = null;
            //}
            //catch { }
        }
        #endregion

        #region Cadastrar Fornecedor
        private void btnNovoFornecedor_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            if (Dados.Permissao == "ADMIN" || Dados.Permissao == "FUNCIONARIO")
            {
                if (txtNomeForn.Text == String.Empty || txtTelForn.Text == String.Empty ||
                txtEmailForn.Text == String.Empty)
                {
                    if (txtNomeForn.Text == String.Empty)
                    {
                        txtNomeForn.BackColor = Color.Tomato;
                    }
                    if (txtTelForn.Text == String.Empty)
                    {
                        txtTelForn.BackColor = Color.Tomato;
                    }
                    if (txtEmailForn.Text == String.Empty)
                    {
                        txtEmailForn.BackColor = Color.Tomato;
                    }

                    MessageBox.Show("Preencher todos os campos!", "ALERTA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        bool cnpj = false;
                        forn.Nome_forn = txtNomeForn.Text;
                        if (txtCnpjForn.ReadOnly == true)
                        {
                            cnpj = false;
                            forn.Cpf_forn = txtCpfForn.Text;
                        }
                        else
                        {
                            cnpj = true;
                            forn.Cnpj_forn = txtCnpjForn.Text;
                        }
                        forn.Tel_forn = txtTelForn.Text; 
                        forn.Email_forn = txtEmailForn.Text;

                        fornDAO.inserirForn(forn, cnpj);

                        limpar();
                        gvExibirForn.DataSource = fornDAO.listarFornecedor();
                        atualizarGV();

                        MessageBox.Show("Fornecedor cadastrado com sucesso", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Verificar todos os campos digitados!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Você não possui permissões para cadastrar um novo Fornecedor!", "SEM PERMISSÃO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region Alterar Fornecedor
        private void btnAlterarFornecedor_Click(object sender, EventArgs e)
        {
            if (Dados.Permissao == "ADMIN" || Dados.Permissao == "FUNCIONARIO")
            {
                if (txtNomeForn.Text == String.Empty ||
                     txtEmailForn.Text == String.Empty ||
                    txtTelForn.Text == String.Empty)

                {
                    if (txtNomeForn.Text == String.Empty)
                    {
                        txtNomeForn.BackColor = Color.Tomato;
                    }
                    if (txtEmailForn.Text == String.Empty)
                    {
                        txtEmailForn.BackColor = Color.Tomato;
                    }
                    if (txtTelForn.Text == String.Empty)
                    {
                        txtTelForn.BackColor = Color.Tomato;
                    }


                    MessageBox.Show("Preencher todos os campos!", "ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    bool cnpj = false;
                    forn.Nome_forn = txtNomeForn.Text;
                    if (txtCnpjForn.Text != String.Empty && txtCpfForn.Text == String.Empty ||
                        txtCnpjForn.ReadOnly == false && txtCpfForn.ReadOnly == true && txtCnpjForn.Text != String.Empty ||
                        txtCpfForn.Text == "NÃO POSSUI CPF!" && txtCnpjForn.Text != String.Empty)
                    {
                        cnpj = true;
                        forn.Cnpj_forn = txtCnpjForn.Text;
                    }
                    else
                    {
                        cnpj = false;
                        forn.Cpf_forn = txtCpfForn.Text;
                    }
                    forn.Tel_forn = txtTelForn.Text;
                    forn.Email_forn = txtEmailForn.Text;

                    //fornDAO.AlterarForn(forn, Convert.ToInt32(txtIDForn.Text), cnpj);

                    limpar();
                    gvExibirForn.DataSource = fornDAO.listarFornecedor();
                    atualizarGV();

                    MessageBox.Show("As informações do Fornecedor foram alteradas com sucesso!", "SUCESSO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Você não possui permissões para alterar informações do Fornecedor!", "SEM PERMISSÃO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region Excluir Fornecedor
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Dados.Permissao == "ADMIN" || Dados.Permissao == "FUNCIONARIO")
            {
                DialogResult opcao;

                opcao = MessageBox.Show("Deseja realmente excluir o Fornecedor?", "Excluir?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcao == DialogResult.Yes)
                {
                    fornDAO.ExcluirForn(txtIDForn.Text);
                    MessageBox.Show("Fornecedor excluido com sucesso!", "SUCESSO!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpar();
                    gvExibirForn.DataSource = fornDAO.listarFornecedor();
                    atualizarGV();
                }
                else
                {
                    MessageBox.Show("Fornecedor não excluido!", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Você não possui permissões para alterar informações do Fornecedor!", "SEM PERMISSÃO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region Verificar CPF ou CPNJ
        private void txtCpfForn_Enter(object sender, EventArgs e)
        {
            txtCpfForn.ReadOnly = false;
            txtCnpjForn.ReadOnly = true;
            txtCnpjForn.Clear();
        }

        private void txtCnpjForn_Enter(object sender, EventArgs e)
        {
            txtCnpjForn.ReadOnly = false;
            txtCpfForn.ReadOnly = true;
            txtCpfForn.Clear();
        }
        #endregion

        #region Método Limpar
        private void limpar()
        {
            btnNovoFornecedor.Enabled = false;
            btnNovoFornecedor.Visible = false;
            btnNovoFornecedor.SendToBack();
            btnAlterar.Enabled = false;
            btnAlterar.Visible = false;
            btnAlterar.SendToBack();
            btnExcluir.Enabled = false;
            btnExcluir.Visible = false;
            btnExcluir.SendToBack();

            btnCadastrarFornecedor.Enabled = true;
            btnCadastrarFornecedor.Visible = true;
            btnCadastrarFornecedor.BringToFront();
            btnCancelar.Enabled = true;
            btnCancelar.Visible = true;
            btnCancelar.BringToFront();

            txtIDForn.Clear();
            txtCpfForn.Clear();
            txtCnpjForn.Clear();
            txtNomeForn.Clear();
            txtTelForn.Clear();
            txtEmailForn.Clear();

            txtIDForn.Text = Convert.ToInt32((fornDAO.verificarUltimoID() + 1)).ToString();
        }
        #endregion

        #region Exibir Informações do Fornecedor ao Clicar no GridView
        private void gvExibirForn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                limpar();

                txtIDForn.Text = gvExibirForn.Rows[gvExibirForn.CurrentCell.RowIndex].Cells[0].Value.ToString();
                txtNomeForn.Text = gvExibirForn.Rows[gvExibirForn.CurrentCell.RowIndex].Cells[1].Value.ToString();
                if (gvExibirForn.Rows[gvExibirForn.CurrentCell.RowIndex].Cells[2].Value.ToString() == "")
                {
                    txtCnpjForn.Text = gvExibirForn.Rows[gvExibirForn.CurrentCell.RowIndex].Cells[3].Value.ToString();
                    txtCpfForn.Text = "NÃO POSSUI CPF!";
                }
                else
                {
                    txtCnpjForn.Text = "NÃO POSSUI CNPJ!";
                    txtCpfForn.Text = gvExibirForn.Rows[gvExibirForn.CurrentCell.RowIndex].Cells[2].Value.ToString();
                }
                txtTelForn.Text = gvExibirForn.Rows[gvExibirForn.CurrentCell.RowIndex].Cells[4].Value.ToString(); ;
                txtEmailForn.Text = gvExibirForn.Rows[gvExibirForn.CurrentCell.RowIndex].Cells[5].Value.ToString();

                #region BOTOES
                btnNovoFornecedor.Enabled = true;
                btnNovoFornecedor.Visible = true;
                btnNovoFornecedor.BringToFront();
                btnAlterar.Enabled = true;
                btnAlterar.Visible = true;
                btnAlterar.BringToFront();
                btnExcluir.Enabled = true;
                btnExcluir.Visible = true;
                btnExcluir.BringToFront();

                btnCadastrarFornecedor.Enabled = false;
                btnCadastrarFornecedor.Visible = false;
                btnCadastrarFornecedor.SendToBack();
                btnCancelar.Enabled = false;
                btnCancelar.Visible = false;
                btnCancelar.SendToBack();
                #endregion
            }
            catch { }
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