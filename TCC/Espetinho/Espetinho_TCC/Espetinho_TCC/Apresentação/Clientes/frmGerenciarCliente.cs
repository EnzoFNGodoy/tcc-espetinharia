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

namespace Espetinho_TCC.Apresentação.Clientes
{
    public partial class frmGerenciarCliente : Form
    {
        #region Instâncias
        ClientesDAO cliDAO = new ClientesDAO();
        Espetinho_TCC.Model.Clientes cli = new Espetinho_TCC.Model.Clientes();
        #endregion

        #region Carregar Tela
        public frmGerenciarCliente()
        {
            InitializeComponent();
        }

        private void frmGerenciarCliente_Load(object sender, EventArgs e)
        {
            gvExibirClientes.DataSource = cliDAO.listarClientes();
            atualizarGV();
            try
            {
                txtID.Text = gvExibirClientes.Rows[gvExibirClientes.CurrentCell.RowIndex].Cells[0].Value.ToString();
                txtNome.Text = gvExibirClientes.Rows[gvExibirClientes.CurrentCell.RowIndex].Cells[1].Value.ToString();
                if (gvExibirClientes.Rows[gvExibirClientes.CurrentCell.RowIndex].Cells[2].Value.ToString() == String.Empty)
                {
                    txtCNPJ.Text = gvExibirClientes.Rows[gvExibirClientes.CurrentCell.RowIndex].Cells[3].Value.ToString();
                    txtCPF.Text = "NÃO POSSUI CPF!";
                }
                else
                {
                    txtCPF.Text = gvExibirClientes.Rows[gvExibirClientes.CurrentCell.RowIndex].Cells[2].Value.ToString();
                    txtCNPJ.Text = "NÃO POSSUI CNPJ!";
                }
                txtTelefone.Text = gvExibirClientes.Rows[gvExibirClientes.CurrentCell.RowIndex].Cells[4].Value.ToString();
                txtEmail.Text = gvExibirClientes.Rows[gvExibirClientes.CurrentCell.RowIndex].Cells[5].Value.ToString();
            }
            catch { }
        }
        #endregion

        #region Atualizar GridView
        private void atualizarGV()
        {
            try
            {
                if (cliDAO.listarClientes().Rows.Count > 0)
                {
                    gvExibirClientes.Columns[0].HeaderText = "Código";
                    gvExibirClientes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    gvExibirClientes.Columns[1].HeaderText = "Cliente";
                    gvExibirClientes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    gvExibirClientes.Columns[2].Visible = false; // CPF
                    gvExibirClientes.Columns[3].Visible = false; // CNPJ
                    gvExibirClientes.Columns[4].Visible = false; // TELEFONE
                    gvExibirClientes.Columns[5].HeaderText = "Email";
                    gvExibirClientes.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    gvExibirClientes.Columns[6].Visible = false; // STATUS
                    for (int i = 0; i < gvExibirClientes.Rows.Count; i++)
                    {
                        gvExibirClientes.Rows[i].Height = 60;
                    }
                }
                else
                    gvExibirClientes.DataSource = null;
            }
            catch { }
        }
        #endregion

        #region Pesquisar Cliente GridView
        private void txtPesquisarPorNome_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cliDAO.listarClientesPorNome(txtPesquisarPorNome.Text).Rows.Count > 0)
                {
                    gvExibirClientes.Columns.Clear();
                    gvExibirClientes.DataSource = cliDAO.listarClientesPorNome(txtPesquisarPorNome.Text);
                    atualizarGV();
                }
                else
                    gvExibirClientes.DataSource = null;
            }
            catch { }
        }
        #endregion

        #region Verificar CPF ou CPNJ
        private void txtCPF_Enter(object sender, EventArgs e)
        {
            txtCPF.ReadOnly = false;
            txtCNPJ.ReadOnly = true;
            txtCNPJ.Clear();
        }

        private void txtCNPJ_Enter(object sender, EventArgs e)
        {
            txtCNPJ.ReadOnly = false;
            txtCPF.ReadOnly = true;
            txtCPF.Clear();
        }
        #endregion

        #region Exibir Informações do Cliente ao Clicar no GridView
        private void gvExibirClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                limpar();

                txtID.Text = gvExibirClientes.Rows[gvExibirClientes.CurrentCell.RowIndex].Cells[0].Value.ToString();
                txtNome.Text = gvExibirClientes.Rows[gvExibirClientes.CurrentCell.RowIndex].Cells[1].Value.ToString();
                if (gvExibirClientes.Rows[gvExibirClientes.CurrentCell.RowIndex].Cells[2].Value.ToString() == String.Empty)
                {
                    txtCNPJ.Text = gvExibirClientes.Rows[gvExibirClientes.CurrentCell.RowIndex].Cells[3].Value.ToString();
                    txtCPF.Text = "NÃO POSSUI CPF!";
                }
                else
                {
                    txtCPF.Text = gvExibirClientes.Rows[gvExibirClientes.CurrentCell.RowIndex].Cells[2].Value.ToString();
                    txtCNPJ.Text = "NÃO POSSUI CNPJ!";
                }
                txtTelefone.Text = gvExibirClientes.Rows[gvExibirClientes.CurrentCell.RowIndex].Cells[4].Value.ToString();
                txtEmail.Text = gvExibirClientes.Rows[gvExibirClientes.CurrentCell.RowIndex].Cells[5].Value.ToString();

                #region BOTOES
                btnNovoCliente.Enabled = true;
                btnNovoCliente.Visible = true;
                btnNovoCliente.BringToFront();
                btnAlterar.Enabled = true;
                btnAlterar.Visible = true;
                btnAlterar.BringToFront();
                btnExcluir.Enabled = true;
                btnExcluir.Visible = true;
                btnExcluir.BringToFront();

                btnCadastrar.Enabled = false;
                btnCadastrar.Visible = false;
                btnCadastrar.SendToBack();
                btnCancelar.Enabled = false;
                btnCancelar.Visible = false;
                btnCancelar.SendToBack();
                #endregion
            }
            catch { }
        }
        #endregion

        #region Cadastrar Cliente
        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (Dados.Permissao == "ADMIN" || Dados.Permissao == "FUNCIONARIO" || Dados.Permissao == "CAIXA")
            {
                if (txtNome.Text == String.Empty || txtTelefone.Text == String.Empty ||
                txtEmail.Text == String.Empty || txtCNPJ.Text == String.Empty && txtCPF.Text == String.Empty)
                {
                    if (txtNome.Text == String.Empty)
                    {
                        txtNome.BackColor = Color.Tomato;
                    }
                    if (txtTelefone.Text == String.Empty)
                    {
                        txtTelefone.BackColor = Color.Tomato;
                    }
                    if (txtEmail.Text == String.Empty)
                    {
                        txtEmail.BackColor = Color.Tomato;
                    }

                    MessageBox.Show("Preencher todos os campos!", "ALERTA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    if (txtCNPJ.Text == String.Empty && txtCPF.Text == String.Empty)
                    {
                        txtCNPJ.BackColor = Color.Tomato;
                        txtCPF.BackColor = Color.Tomato;

                        MessageBox.Show("Preencha o CPF ou o CNPJ!", "ALERTA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    try
                    {
                        bool cnpj = false;
                        cli.Nome_cli = txtNome.Text;
                        if (txtCNPJ.ReadOnly == true)
                        {
                            cnpj = false;
                            cli.Cpf_cli = txtCPF.Text;
                        }
                        else
                        {
                            cnpj = true;
                            cli.Cnpj_cli = txtCNPJ.Text;
                        }
                        cli.Tel_cli = txtTelefone.Text;
                        cli.Email_cli = txtEmail.Text;

                        cliDAO.inserirClientes(cli, cnpj);

                        limpar();
                        gvExibirClientes.DataSource = cliDAO.listarClientes();
                        atualizarGV();

                        MessageBox.Show("Cliente cadastrado com sucesso", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Verificar todos os campos digitados!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Você não possui permissões para cadastrar um novo Cliente!", "SEM PERMISSÃO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region Alterar Cliente
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (Dados.Permissao == "ADMIN" || Dados.Permissao == "FUNCIONARIO" || Dados.Permissao == "CAIXA")
            {
                if (txtNome.Text == String.Empty || txtTelefone.Text == String.Empty ||
                   txtEmail.Text == String.Empty || txtCNPJ.Text == String.Empty && txtCPF.Text == String.Empty)
                {
                    if (txtNome.Text == String.Empty)
                    {
                        txtNome.BackColor = Color.Tomato;
                    }
                    if (txtTelefone.Text == String.Empty)
                    {
                        txtTelefone.BackColor = Color.Tomato;
                    }
                    if (txtEmail.Text == String.Empty)
                    {
                        txtEmail.BackColor = Color.Tomato;
                    }

                    MessageBox.Show("Preencher todos os campos!", "ALERTA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    if (txtCNPJ.Text == String.Empty && txtCPF.Text == String.Empty)
                    {
                        txtCNPJ.BackColor = Color.Tomato;
                        txtCPF.BackColor = Color.Tomato;

                        MessageBox.Show("Preencha o CPF ou o CNPJ!", "ALERTA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    bool cnpj = false;
                    cli.Nome_cli = txtNome.Text;
                    if (txtCNPJ.Text != String.Empty && txtCPF.Text == String.Empty ||
                        txtCNPJ.ReadOnly == false && txtCPF.ReadOnly == true && txtCNPJ.Text != String.Empty ||
                        txtCPF.Text == "NÃO POSSUI CPF!" && txtCNPJ.Text != String.Empty)
                    {
                        cnpj = true;
                        cli.Cnpj_cli = txtCNPJ.Text;
                    }
                    else
                    {
                        cnpj = false;
                        cli.Cpf_cli = txtCPF.Text;
                    }
                    cli.Tel_cli = txtTelefone.Text;
                    cli.Email_cli = txtEmail.Text;

                    cliDAO.alterarCliente(cli, Convert.ToInt32(txtID.Text), cnpj);

                    limpar();
                    gvExibirClientes.DataSource = cliDAO.listarClientes();
                    atualizarGV();

                    MessageBox.Show("As informações do Cliente foram alteradas com sucesso!", "SUCESSO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Você não possui permissões para alterar informações do Cliente!", "SEM PERMISSÃO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region Excluir Cliente
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Dados.Permissao == "ADMIN" || Dados.Permissao == "FUNCIONARIO")
            {
                DialogResult opcao;

                opcao = MessageBox.Show("Deseja realmente excluir o Cliente?", "Excluir?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcao == DialogResult.Yes)
                {
                    cliDAO.excluirCliente(Convert.ToInt32(txtID.Text));
                    MessageBox.Show("Cliente excluido com sucesso!", "SUCESSO!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpar();
                    gvExibirClientes.DataSource = cliDAO.listarClientes();
                    atualizarGV();
                }
                else
                {
                    MessageBox.Show("Cliente não excluido!", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Você não possui permissões para alterar informações do Cliente!", "SEM PERMISSÃO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region Método Limpar
        private void limpar()
        {
            #region BOTOES
            btnNovoCliente.Enabled = false;
            btnNovoCliente.Visible = false;
            btnNovoCliente.SendToBack();
            btnAlterar.Enabled = false;
            btnAlterar.Visible = false;
            btnAlterar.SendToBack();
            btnExcluir.Enabled = false;
            btnExcluir.Visible = false;
            btnExcluir.SendToBack();

            btnCadastrar.Enabled = true;
            btnCadastrar.Visible = true;
            btnCadastrar.BringToFront();
            btnCancelar.Enabled = true;
            btnCancelar.Visible = true;
            btnCancelar.BringToFront();
            #endregion

            #region OUTROS OBJETOS
            txtID.Text = (cliDAO.ultimoID()+1).ToString();
            txtID.ReadOnly = true;
            txtNome.Clear();
            txtNome.ReadOnly = false;
            txtCPF.Clear();
            txtCPF.ReadOnly = false;
            txtCNPJ.Clear();
            txtCNPJ.ReadOnly = false;
            txtTelefone.Clear();
            txtTelefone.ReadOnly = false;
            txtEmail.Clear();
            txtEmail.ReadOnly = false;
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
