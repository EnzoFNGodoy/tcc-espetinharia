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
using Espetinho_TCC.Utils;
using WebService.Utils;

namespace Espetinho_TCC.Apresentação.Funcionario
{
    public partial class frmGerenciarFuncionario : Form
    {
        #region Instâncias
        Cargo cargo = new Cargo();
        CargoDAO cargoDAO = new CargoDAO();
        UsuarioDAO usuDAO = new UsuarioDAO();
        FuncionarioDAO funcDAO = new FuncionarioDAO();
        Espetinho_TCC.Model.Funcionario func = new Espetinho_TCC.Model.Funcionario();
        frmSelecionarUsuario telaSelecUsu = new frmSelecionarUsuario();
        Financas fin = new Financas();
        FinancasDAO finDAO = new FinancasDAO();
        #endregion

        #region Carregar Tela
        public frmGerenciarFuncionario()
        {
            InitializeComponent();
        }

        private void frmGerenciarFuncionario_Load(object sender, EventArgs e)
        {
            gvExibirFuncionario.DataSource = funcDAO.listarFuncionario();
            atualizarGV();

            carregarCmbCargo();
            limpar();

            txtIDFunc.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtIDUsu.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[1].Value.ToString();
            cmbCargo.SelectedValue = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[2].Value.ToString();
            cmbCargo.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[3].Value.ToString();
            txtSal.Text = "R$ " + Convert.ToInt32(gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[4].Value).ToString("#0.00");
            txtCom.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[5].Value.ToString();
            txtNome.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[6].Value.ToString();
            txtCPF.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[7].Value.ToString();
            cmbSexo.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[8].Value.ToString();
            txtRG.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[9].Value.ToString();
            dtpDataNasc.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[10].Value.ToString();
            cmbEstCivil.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[11].Value.ToString();
            txtTelefone.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[12].Value.ToString();
            txtEmail.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[13].Value.ToString();
            txtEnd.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[14].Value.ToString();
            mskCEP.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[15].Value.ToString();
            txtUF.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[16].Value.ToString();
            txtCid.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[17].Value.ToString();
            txtBai.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[18].Value.ToString();
            txtComple.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[19].Value.ToString();
            txtNum.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[20].Value.ToString();
            txtDiaPagto.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[21].Value.ToString();

            #region BOTOES
            btnNovoFunc.Enabled = true;
            btnNovoFunc.Visible = true;
            btnNovoFunc.BringToFront();
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
        #endregion

        #region Carregar Combo Cargo
        private void carregarCmbCargo()
        {
            cmbCargo.DataSource = cargoDAO.listarCargo();
            cmbCargo.ValueMember = "id_cargo";
            cmbCargo.DisplayMember = "tipo_cargo";
        }
        #endregion

        #region Cadastrar Funcionário
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (Dados.Permissao == "ADMIN")
            {
                if (txtNome.Text == String.Empty || txtEmail.Text == String.Empty ||
                txtSal.Text == String.Empty || txtEnd.Text == String.Empty ||
                txtCPF.Text == String.Empty || mskCEP.MaskFull == false ||
                cmbSexo.Text == String.Empty || txtUF.Text == String.Empty ||
                cmbEstCivil.Text == String.Empty || txtCid.Text == String.Empty ||
                dtpDataNasc.Text == String.Empty || txtBai.Text == String.Empty ||
                txtRG.Text == String.Empty || txtCom.Text == String.Empty ||
                txtTelefone.Text == String.Empty || txtNum.Text == String.Empty ||
                txtDiaPagto.Text == String.Empty || Convert.ToInt32(txtDiaPagto.Text) <= 0 || Convert.ToInt32(txtDiaPagto.Text) >= 31)
                {
                    if (txtNome.Text == String.Empty)
                    {
                        txtNome.BackColor = Color.Red;
                    }
                    if (txtSal.Text == String.Empty)
                    {
                        txtSal.BackColor = Color.Red;
                    }
                    if (txtCPF.Text == String.Empty)
                    {
                        txtCPF.BackColor = Color.Red;
                    }
                    if (cmbSexo.Text == String.Empty)
                    {
                        cmbSexo.BackColor = Color.Red;
                    }
                    if (cmbEstCivil.Text == String.Empty)
                    {
                        cmbEstCivil.BackColor = Color.Red;
                    }
                    if (dtpDataNasc.Text == String.Empty)
                    {
                        dtpDataNasc.BackColor = Color.Red;
                    }
                    if (txtRG.Text == String.Empty)
                    {
                        txtRG.BackColor = Color.Red;
                    }
                    if (txtTelefone.Text == String.Empty)
                    {
                        txtTelefone.BackColor = Color.Red;
                    }
                    if (txtEmail.Text == String.Empty)
                    {
                        txtEmail.BackColor = Color.Red;
                    }
                    if (txtEnd.Text == String.Empty)
                    {
                        txtEnd.BackColor = Color.Red;
                    }
                    if (mskCEP.MaskFull == false)
                    {
                        mskCEP.BackColor = Color.Red;
                    }
                    if (txtUF.Text == String.Empty)
                    {
                        txtUF.BackColor = Color.Red;
                    }
                    if (txtCid.Text == String.Empty)
                    {
                        txtCid.BackColor = Color.Red;
                    }
                    if (txtBai.Text == String.Empty)
                    {
                        txtBai.BackColor = Color.Red;
                    }
                    if (txtNum.Text == String.Empty)
                    {
                        txtNum.BackColor = Color.Red;
                    }
                    if (txtCom.Text == String.Empty)
                    {
                        txtCom.BackColor = Color.Red;
                    }
                    if (txtDiaPagto.Text == String.Empty || Convert.ToInt32(txtDiaPagto.Text) <= 0 || Convert.ToInt32(txtDiaPagto.Text) >= 31)
                    {
                        txtDiaPagto.BackColor = Color.Red;
                    }

                    MessageBox.Show("Preencher todos os campos!", "ALERTA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        // INSERIR FINANÇA
                        DateTime dataFinanca;
                        if (Convert.ToInt32(txtDiaPagto.Text) > Convert.ToInt32(DateTime.Now.Day.ToString()))
                        {
                            dataFinanca = Convert.ToDateTime(txtDiaPagto.Text + @"/" + DateTime.Now.Month.ToString() + @"/" + DateTime.Now.Year.ToString());
                            fin.Data_fin = dataFinanca;
                        }
                        else
                        {
                            dataFinanca = Convert.ToDateTime(txtDiaPagto.Text + @"/" + (Convert.ToInt32(DateTime.Now.Month)+1).ToString() + @"/" + DateTime.Now.Year.ToString());
                            fin.Data_fin = dataFinanca;
                        }
                        fin.Obs_fin = "Salário de Funcionário";
                        fin.Valor_fin = Convert.ToDouble(txtSal.Text.Replace(',', '.').TrimStart("R$ ".ToCharArray()).TrimEnd(",00".ToCharArray()));

                        finDAO.inserirSaidas(fin);
                        // ============ //

                        bool temCompl = false;
                        func.Nome_func = txtNome.Text;
                        func.Sal_func = Convert.ToDouble(txtSal.Text);
                        func.Id_cargo = Convert.ToInt32(cmbCargo.SelectedValue);
                        func.Cpf_func = txtCPF.Text;
                        func.Sexo_func = cmbSexo.Text;
                        func.RG_func1 = txtRG.Text;
                        func.Dtnasc_func = Convert.ToDateTime(dtpDataNasc.Text);
                        func.Estcivil_func = cmbEstCivil.Text;
                        func.Tel_func = txtTelefone.Text;
                        func.Email_func = txtEmail.Text;
                        func.Endereco_func = txtEnd.Text;
                        func.Cep_func = mskCEP.Text;
                        func.Uf_func = txtUF.Text;
                        func.Cid_func = txtCid.Text;
                        func.Bairro_func = txtBai.Text;
                        if (txtComple.Text == String.Empty)
                        {
                            temCompl = false;
                        }
                        else
                        {
                            temCompl = true;
                            func.Compl_func = txtComple.Text;
                        }
                        func.Num_func = Convert.ToInt32(txtNum.Text);
                        func.Comissao_func = txtCom.Text;
                        func.Id_usu = Convert.ToInt32(txtIDUsu.Text);
                        func.Id_fin = finDAO.buscarUltID();
                        func.DiaPagto_func = txtDiaPagto.Text;

                        funcDAO.inserirFunc(func, temCompl);

                        MessageBox.Show("Funcionário cadastrado com sucesso!", "SUCESSO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpar();
                        gvExibirFuncionario.Columns.Clear();
                        gvExibirFuncionario.DataSource = funcDAO.listarFuncionario();
                        atualizarGV();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Algum erro ocorreu, verifique os campos digitados!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("Você não possui permissões para cadastrar um novo Funcionário!", "SEM PERMISSÃO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region Descolorir Campos ao Digitar
        private void txtDiaPagto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtDiaPagto.Text) <= 0 || Convert.ToInt32(txtDiaPagto.Text) >= 31)
                {
                    txtDiaPagto.ForeColor = Color.Tomato;
                }
                else
                {
                    txtDiaPagto.ForeColor = Color.Black;
                }
            }
            catch { }
            txtDiaPagto.BackColor = Color.Empty;
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            txtCPF.BackColor = Color.Empty;
        }

        private void txtRG_TextChanged(object sender, EventArgs e)
        {
            txtRG.BackColor = Color.Empty;
        }

        private void cmbEstCivil_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbEstCivil.BackColor = Color.Empty;
        }

        private void cmbSexo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbSexo.BackColor = Color.Empty;
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            txtTelefone.BackColor = Color.Empty;
        }

        private void txtCom_TextChanged(object sender, EventArgs e)
        {
            txtCom.BackColor = Color.Empty;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            txtNome.BackColor = Color.Empty;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.BackColor = Color.Empty;
        }

        private void txtEnd_TextChanged(object sender, EventArgs e)
        {
            txtEnd.BackColor = Color.Empty;
        }

        private void txtUF_TextChanged(object sender, EventArgs e)
        {
            txtUF.BackColor = Color.Empty;
        }

        private void txtCid_TextChanged(object sender, EventArgs e)
        {
            txtCid.BackColor = Color.Empty;
        }

        private void txtBai_TextChanged(object sender, EventArgs e)
        {
            txtBai.BackColor = Color.Empty;
        }

        private void txtComple_TextChanged(object sender, EventArgs e)
        {
            txtComple.BackColor = Color.Empty;
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            txtNum.BackColor = Color.Empty;
        }

        private void txtSal_TextChanged(object sender, EventArgs e)
        {
            txtSal.BackColor = Color.Empty;
        }
        #endregion

        #region Limpar Tela e Cadastrar um Novo Funcionário
        private void btnNovoFunc_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void limpar()
        {
            #region BOTOES
            btnNovoFunc.Enabled = false;
            btnNovoFunc.Visible = false;
            btnNovoFunc.SendToBack();
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

            btnSelecionarUsuario.Enabled = true;
            btnSelecionarUsuario.Visible = true;
            btnSelecionarUsuario.BringToFront();
            #endregion

            #region OUTROS OBJETOS
            txtIDFunc.Clear();
            txtIDFunc.Text = (funcDAO.ultimoID() + 1).ToString();
            txtIDUsu.Clear();
            txtNome.Clear();
            txtSal.Clear();
            txtCPF.Clear();
            txtRG.Clear();
            dtpDataNasc.Value = DateTime.Now;
            txtTelefone.Clear();
            txtEmail.Clear();
            txtEnd.Clear();
            mskCEP.Clear();
            txtUF.Clear();
            txtCid.Clear();
            txtCom.Clear();
            txtBai.Clear();
            txtComple.Clear();
            txtNum.Clear();
            cmbEstCivil.Text = "";
            cmbEstCivil.SelectedItem = null;
            cmbCargo.Text = "";
            cmbCargo.SelectedItem = null;
            cmbSexo.Text = "";
            cmbSexo.SelectedItem = null;
            #endregion
        }
        #endregion

        #region Cadastrar Cargo
        private void btnCadastrarCargo_Click(object sender, EventArgs e)
        {
            frmCadastrarCargo telaCadCargo = new frmCadastrarCargo(lblNomeUsuAtivo.Text);
            telaCadCargo.ShowDialog();
            carregarCmbCargo();
            cmbCargo.Text = "";
            cmbCargo.SelectedItem = null;
        }
        #endregion

        #region Alterar Funcionário
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (Dados.Permissao == "ADMIN" || Dados.Permissao == "FUNCIONARIO")
            {
                if (txtBai.Text == String.Empty || mskCEP.MaskFull == false || txtCid.Text == String.Empty ||
                    txtCom.Text == String.Empty || txtCPF.Text == String.Empty || cmbSexo.SelectedItem == null ||
                   txtEmail.Text == String.Empty || txtEnd.Text == String.Empty || txtNome.Text == String.Empty ||
                    txtNum.Text == String.Empty || txtRG.Text == String.Empty || txtSal.Text == String.Empty ||
                    txtTelefone.Text == String.Empty || txtUF.Text == String.Empty || dtpDataNasc.Text == String.Empty ||
                    cmbCargo.Text == String.Empty || cmbCargo.SelectedItem == null || cmbEstCivil.Text == String.Empty ||
                    cmbEstCivil.SelectedItem == null || cmbSexo.Text == String.Empty || txtDiaPagto.Text == String.Empty)
                {
                    if (txtBai.Text == String.Empty)
                    {
                        txtBai.BackColor = Color.Tomato;
                    }
                    if (cmbCargo.Text == String.Empty || cmbCargo.SelectedItem == null)
                    {
                        cmbCargo.BackColor = Color.Tomato;
                    }
                    if (cmbSexo.Text == String.Empty || cmbSexo.SelectedItem == null)
                    {
                        cmbSexo.BackColor = Color.Tomato;
                    }
                    if (cmbEstCivil.Text == String.Empty || cmbEstCivil.SelectedItem == null)
                    {
                        cmbEstCivil.BackColor = Color.Tomato;
                    }
                    if (mskCEP.MaskFull == false)
                    {
                        mskCEP.BackColor = Color.Tomato;
                    }
                    if (txtCid.Text == String.Empty)
                    {
                        txtCid.BackColor = Color.Tomato;
                    }
                    if (txtCom.Text == String.Empty)
                    {
                        txtCom.BackColor = Color.Tomato;
                    }
                    if (txtCPF.Text == String.Empty)
                    {
                        txtCPF.BackColor = Color.Tomato;
                    }
                    if (txtEmail.Text == String.Empty)
                    {
                        txtEmail.BackColor = Color.Tomato;
                    }
                    if (txtEnd.Text == String.Empty)
                    {
                        txtEnd.BackColor = Color.Tomato;
                    }
                    if (dtpDataNasc.Text == String.Empty)
                    {
                        dtpDataNasc.BackColor = Color.Tomato;
                    }
                    if (txtNome.Text == String.Empty)
                    {
                        txtNome.BackColor = Color.Tomato;
                    }
                    if (txtNum.Text == String.Empty)
                    {
                        txtNum.BackColor = Color.Tomato;
                    }
                    if (txtRG.Text == String.Empty)
                    {
                        txtRG.BackColor = Color.Tomato;
                    }
                    if (txtSal.Text == String.Empty)
                    {
                        txtSal.BackColor = Color.Tomato;
                    }
                    if (txtTelefone.Text == String.Empty)
                    {
                        txtTelefone.BackColor = Color.Tomato;
                    }
                    if (txtUF.Text == String.Empty)
                    {
                        txtUF.BackColor = Color.Tomato;
                    }
                    if (txtDiaPagto.Text == String.Empty)
                    {
                        txtDiaPagto.BackColor = Color.Tomato;
                    }

                    MessageBox.Show("Preencher todos os campos!", "ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    func.Id_cargo = Convert.ToInt32(cmbCargo.SelectedValue.ToString());

                    func.Sal_func = Convert.ToDouble(txtSal.Text.TrimStart("R$ ".ToCharArray()));
                    func.Comissao_func = txtCom.Text;
                    func.Nome_func = txtNome.Text;
                    func.Id_cargo = Convert.ToInt32(cmbCargo.SelectedValue);
                    func.Cpf_func = txtCPF.Text;
                    func.Sexo_func = cmbSexo.Text;
                    func.RG_func1 = txtRG.Text;
                    func.Dtnasc_func = Convert.ToDateTime(dtpDataNasc.Text);
                    func.Estcivil_func = cmbEstCivil.Text;
                    func.Tel_func = txtTelefone.Text;
                    func.Email_func = txtEmail.Text;
                    func.Endereco_func = txtEnd.Text;
                    func.Cep_func = mskCEP.Text;
                    func.Uf_func = txtUF.Text;
                    func.Cid_func = txtCid.Text;
                    func.Bairro_func = txtBai.Text;
                    func.Compl_func = txtComple.Text;
                    func.Num_func = Convert.ToInt32(txtNum.Text);
                    func.Id_usu = Convert.ToInt32(txtIDUsu.Text);
                    func.DiaPagto_func = txtDiaPagto.Text;

                    funcDAO.AlterarFunc(func, Convert.ToInt32(txtIDFunc.Text));

                    finDAO.alterarDiaPagtoSalarioFunc(funcDAO.funcPorID(Convert.ToInt32(txtIDFunc.Text)).Id_fin,
                        funcDAO.funcPorID(Convert.ToInt32(txtIDFunc.Text)).Sal_func,
                        Convert.ToDateTime(funcDAO.funcPorID(Convert.ToInt32(txtIDFunc.Text)).DiaPagto_func));

                    limpar();
                    gvExibirFuncionario.Columns.Clear();
                    gvExibirFuncionario.DataSource = funcDAO.listarFuncionario();
                    atualizarGV();

                    MessageBox.Show("As informações do Funcionário foram alteradas com sucesso!", "SUCESSO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Você não possui permissões para alterar informações do Funcionário!", "SEM PERMISSÃO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region Atualizar GridView
        private void atualizarGV()
        {
            try
            {
                gvExibirFuncionario.Columns[0].HeaderText = "Código";
                gvExibirFuncionario.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirFuncionario.Columns[6].HeaderText = "Funcionário";
                gvExibirFuncionario.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirFuncionario.Columns[3].HeaderText = "Cargo";
                gvExibirFuncionario.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirFuncionario.Columns[1].Visible = false; // código usuário
                gvExibirFuncionario.Columns[2].Visible = false; // código cargo
                gvExibirFuncionario.Columns[4].Visible = false; // salário
                gvExibirFuncionario.Columns[5].Visible = false; // comissão
                gvExibirFuncionario.Columns[7].Visible = false; // cpf
                gvExibirFuncionario.Columns[8].Visible = false; // sexo
                gvExibirFuncionario.Columns[9].Visible = false; // rg
                gvExibirFuncionario.Columns[10].Visible = false; // dt nasc
                gvExibirFuncionario.Columns[11].Visible = false; // estado civil
                gvExibirFuncionario.Columns[12].Visible = false; // telefone
                gvExibirFuncionario.Columns[13].Visible = false; // email
                gvExibirFuncionario.Columns[14].Visible = false; // endereço
                gvExibirFuncionario.Columns[15].Visible = false; // cep
                gvExibirFuncionario.Columns[16].Visible = false; // uf
                gvExibirFuncionario.Columns[17].Visible = false; // cidade
                gvExibirFuncionario.Columns[18].Visible = false; // bairro
                gvExibirFuncionario.Columns[19].Visible = false; // complemento
                gvExibirFuncionario.Columns[20].Visible = false; // numero
                gvExibirFuncionario.Columns[21].Visible = false; // dia de pagamento
                gvExibirFuncionario.Columns[22].Visible = false; // código finanças
                for (int i = 0; i < gvExibirFuncionario.Rows.Count; i++)
                {
                    gvExibirFuncionario.Rows[i].Height = 80;
                }
            }
            catch { }
        }

        private void gvExibirFuncionario_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                gvExibirFuncionario.DataSource = funcDAO.listarFuncionario();
                atualizarGV();
            }
            catch { }
        }
        #endregion

        #region Excluir Funcionário
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Dados.Permissao == "ADMIN" || Dados.Permissao == "FUNCIONARIO")
            {
                DialogResult opcao;

                opcao = MessageBox.Show("Deseja realmente excluir o Funcionário?", "Excluir?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcao == DialogResult.Yes)
                {
                    funcDAO.ExcluirFunc(txtIDFunc.Text);
                    MessageBox.Show("Funcionário excluido com sucesso!", "SUCESSO!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpar();
                    gvExibirFuncionario.Columns.Clear();
                    gvExibirFuncionario.DataSource = funcDAO.listarFuncionario();
                    atualizarGV();
                }
                else
                {
                    MessageBox.Show("Funcionário não excluido!", "ERRO!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Você não possui permissões para excluir um Funcionário!", "SEM PERMISSÃO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region Exibir Funcionário no Clique do GridView
        private void gvExibirFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            limpar();

            txtIDFunc.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtIDUsu.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[1].Value.ToString();
            cmbCargo.SelectedValue = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[2].Value.ToString();
            cmbCargo.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[3].Value.ToString();
            txtSal.Text = "R$ " + Convert.ToInt32(gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[4].Value).ToString("#0.00");
            txtCom.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[5].Value.ToString();
            txtNome.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[6].Value.ToString();
            txtCPF.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[7].Value.ToString();
            cmbSexo.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[8].Value.ToString();
            txtRG.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[9].Value.ToString();
            dtpDataNasc.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[10].Value.ToString();
            cmbEstCivil.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[11].Value.ToString();
            txtTelefone.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[12].Value.ToString();
            txtEmail.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[13].Value.ToString();
            txtEnd.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[14].Value.ToString();
            mskCEP.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[15].Value.ToString();
            txtUF.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[16].Value.ToString();
            txtCid.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[17].Value.ToString();
            txtBai.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[18].Value.ToString();
            txtComple.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[19].Value.ToString();
            txtNum.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[20].Value.ToString();
            txtDiaPagto.Text = gvExibirFuncionario.Rows[gvExibirFuncionario.CurrentCell.RowIndex].Cells[21].Value.ToString();
            
            #region BOTOES
            btnNovoFunc.Enabled = true;
            btnNovoFunc.Visible = true;
            btnNovoFunc.BringToFront();
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
        #endregion

        #region Pesquisar por Nome
        private void txtPesquisaPorNome_TextChanged(object sender, EventArgs e)
        {
            try
            {
                gvExibirFuncionario.DataSource = funcDAO.pesqFuncionarioPorNome(txtPesquisaPorNome.Text);
                atualizarGV();
            }
            catch { }
        }
        #endregion

        #region Selecionar Usuário
        private void btnSelecionarUsuario_Click(object sender, EventArgs e)
        {
            telaSelecUsu.ShowDialog();
            if (telaSelecUsu.idUsu > 0)
            {
                txtIDUsu.Text = usuDAO.UsuarioPorId(telaSelecUsu.idUsu).Id_usu.ToString();
            }
            else
            {
                txtIDUsu.Text = txtIDUsu.Text;
            }
        }
        #endregion

        #region Carregar Informações Correios
        private void mskCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mskCEP.BackColor = Color.Empty;
        }

        private void mskCEP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (mskCEP.Text != String.Empty)
                {
                    Correios correios = new Correios(mskCEP.Text);

                    if (correios.Endereco != String.Empty)
                    {
                        txtBai.Text = correios.Bairro;
                        txtCid.Text = correios.Cidade;
                        txtEnd.Text = correios.Endereco;
                        txtUF.Text = correios.Estado;
                    }
                }
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
