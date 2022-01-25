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

namespace Espetinho_TCC.Apresentação.Usuarios
{
    public partial class frmGerenciarUsuario : Form
    {
        #region Instâncias
        UsuarioDAO usuDAO = new UsuarioDAO();
        TipoUsuarioDAO tipoUsuDAO = new TipoUsuarioDAO();
        Usuario usu = new Usuario();
        Criptografia cripto = new Criptografia("@!ESPETINHO123");
        #endregion

        #region Variáveis
        DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
        int qtdMai, qtdMin;
        public string nomeUsuario;
        #endregion

        #region Verificar Caracteres
        public bool carEspecial(string text)
        {
            if (text.Where(c => char.IsSymbol(c)).Count() > 0)
                return true;
            else
                 if (text.Where(c => char.IsSeparator(c)).Count() > 0)
                return true;
            else
                 if (text.Where(c => char.IsPunctuation(c)).Count() > 0)
                return true;
            else
                return false;
        }

        public bool carNumerico(string text)
        {
            if (text.Where(c => char.IsNumber(c)).Count() > 0)
                return true;
            else
                return false;
        }
        #endregion

        #region Carregar Tela
        public frmGerenciarUsuario(string nomeUsu)
        {
            InitializeComponent();
            lblNomeUsuAtivo.Text = nomeUsu;
            lblNomeUsuAtivo.ForeColor = Color.LawnGreen;
            btnFechar.Visible = true;
        }

        private void frmGerenciarUsuario_Load(object sender, EventArgs e)
        {
            usuDAO.pesqUsuPorNome(lblNomeUsuAtivo.Text.TrimEnd("  ".ToCharArray()));
            txtIDUsu.Text = usuDAO.Usu.Id_usu.ToString();
            txtNomeUsu.Text = (usuDAO.Usu.Nome_usu);
            carregarCmbTipoUsuario();
            tipoUsuDAO.verificarTipoUsuPorNomeUsu(lblNomeUsuAtivo.Text.TrimEnd("  ".ToCharArray()));
            cmbTipoUsu.Text = tipoUsuDAO.TipoUsu.Tipo_usu.ToString();
            pbFotoUsu.Image = Image.FromFile(usuDAO.Usu.Foto_usu.ToString());
            pbFotoUsu.ImageLocation = usuDAO.Usu.Foto_usu.ToString();
            // ATUALIZAR GRIDVIEW
            gvExibirUsuarios.DataSource = usuDAO.listarUsuarios();
            atualizarGV();
            atualizarColunaFoto();
            //
            txtSenhaUsu.Visible = false;
            apagarForcaSenha();
            #region BOTOES
            btnNovoUsuario.Enabled = true;
            btnNovoUsuario.Visible = true;
            btnNovoUsuario.BringToFront();
            btnAlterarUsu.Enabled = true;
            btnAlterarUsu.Visible = true;
            btnAlterarUsu.BringToFront();
            btnAlterarSenhaUsu.Enabled = true;
            btnExcluirUsu.Enabled = true;
            btnExcluirUsu.Visible = true;
            btnExcluirUsu.BringToFront();

            btnCadastrarUsu.Enabled = false;
            btnCadastrarUsu.Visible = false;
            btnCadastrarUsu.SendToBack();
            btnCancelarUsu.Enabled = false;
            btnCancelarUsu.Visible = false;
            btnCancelarUsu.SendToBack();
            #endregion
        }
        #endregion

        #region Méotodo Apagar lblForca
        private void apagarForcaSenha()
        {
            if (txtSenhaUsu.Visible == false)
            {
                lblForca.Text = "";
            }
        }
        #endregion

        #region Carregar Combo Tipo de Usuário
        private void carregarCmbTipoUsuario()
        {
            cmbTipoUsu.DataSource = tipoUsuDAO.listarPerfilUsuario();
            cmbTipoUsu.ValueMember = "id_tipousu";
            cmbTipoUsu.DisplayMember = "tipo_usu";
        }
        #endregion

        #region Cadastrar Tipo de Usuário
        private void btnCadastrarTipoUsu_Click(object sender, EventArgs e)
        {
            if (Dados.Permissao == "ADMIN")
            {
                frmCadastrarTipoUsuario telaCadTipoUsu = new frmCadastrarTipoUsuario(lblNomeUsuAtivo.Text);
                telaCadTipoUsu.ShowDialog();
                carregarCmbTipoUsuario();
                cmbTipoUsu.Text = "";
                cmbTipoUsu.SelectedItem = null;
            }
            else
            {
                MessageBox.Show("Você não possui permissões para cadastrar um novo Tipo de Usuário!", "SEM PERMISSÃO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region Alterar Senha
        private void btnAlterarSenhaUsu_Click(object sender, EventArgs e)
        {
            frmAlterarSenha telaAlterarSenha = new frmAlterarSenha(lblNomeUsuAtivo.Text);
            telaAlterarSenha.ShowDialog();
        }
        #endregion

        #region Limpar e Criar Novo Usuário
        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            txtSenhaUsu.Visible = true;
            txtSenhaUsu.UseSystemPasswordChar = true;
            limpar();
            txtIDUsu.Text = Convert.ToInt32(usuDAO.buscarUltID() + 1).ToString();
        }

        private void limpar()
        {
            #region BOTOES
            btnNovoUsuario.Enabled = false;
            btnNovoUsuario.Visible = false;
            btnNovoUsuario.SendToBack();
            btnAlterarUsu.Enabled = false;
            btnAlterarUsu.Visible = false;
            btnAlterarUsu.SendToBack();
            btnAlterarSenhaUsu.Enabled = false;
            btnExcluirUsu.Enabled = false;
            btnExcluirUsu.Visible = false;
            btnExcluirUsu.SendToBack();

            btnCadastrarUsu.Enabled = true;
            btnCadastrarUsu.Visible = true;
            btnCadastrarUsu.BringToFront();
            btnCancelarUsu.Enabled = true;
            btnCancelarUsu.Visible = true;
            btnCancelarUsu.BringToFront();
            #endregion

            #region OUTROS OBJETOS
            txtIDUsu.Clear();
            txtNomeUsu.Clear();
            txtNomeUsu.Enabled = true;
            txtSenhaUsu.Clear();
            txtSenhaUsu.Enabled = true;
            txtSenhaUsu.BringToFront();
            txtSenhaUsu.Visible = true;
            cmbTipoUsu.Text = String.Empty;
            cmbTipoUsu.SelectedItem = null;
            cmbTipoUsu.Enabled = true;
            btnAlterarSenhaUsu.Enabled = false;
            pbFotoUsu.Image = pbFotoUsu.ErrorImage;
            #endregion
        }
        #endregion

        #region Excluir Usuário
        private void btnExcluirUsu_Click(object sender, EventArgs e)
        {
            if (Dados.Permissao == "ADMIN")
            {
                DialogResult opcao;

                opcao = MessageBox.Show("Deseja realmente excluir o Usuário?", "Excluir?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcao == DialogResult.Yes)
                {
                    usuDAO.excluirUsuario(Convert.ToInt32(txtIDUsu.Text));
                    MessageBox.Show("Usuário excluido com sucesso!", "SUCESSO!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpar();
                    gvExibirUsuarios.Columns.Clear();
                    gvExibirUsuarios.DataSource = usuDAO.listarUsuarios();
                    atualizarGV();
                    atualizarColunaFoto();
                }
                else
                {
                    MessageBox.Show("Usuário não excluido!", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Você não possui permissões para excluir o Usuário!", "SEM PERMISSÃO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region Alterar Usuário
        private void btnAlterarUsu_Click(object sender, EventArgs e)
        {
            if (Dados.Permissao == "ADMIN")
            {
                if (cmbTipoUsu.Text == "" || cmbTipoUsu.SelectedItem == null ||
                    txtNomeUsu.Text == String.Empty || pbFotoUsu.ImageLocation == String.Empty)
                {
                    if (txtNomeUsu.Text == String.Empty)
                    {
                        txtNomeUsu.BackColor = Color.Tomato;
                    }
                    if (pbFotoUsu.ImageLocation == String.Empty)
                    {
                        pbFotoUsu.Image = pbFotoUsu.ErrorImage;
                    }
                    if (cmbTipoUsu.Text == "" || cmbTipoUsu.SelectedItem == null)
                    {
                        cmbTipoUsu.BackColor = Color.Tomato;
                    }

                    MessageBox.Show("Preencher todos os campos!", "ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    usu.Nome_usu = txtNomeUsu.Text;
                    usu.Id_tipousu = Convert.ToInt32(cmbTipoUsu.SelectedValue.ToString());
                    usu.Foto_usu = pbFotoUsu.ImageLocation.Replace(@"\", @"\\");

                    usuDAO.alterarUsuario(usu, Convert.ToInt32(txtIDUsu.Text));
                    nomeUsuario = txtNomeUsu.Text;

                    limpar();
                    gvExibirUsuarios.Columns.Clear();
                    gvExibirUsuarios.DataSource = usuDAO.listarUsuarios();
                    atualizarGV();
                    atualizarColunaFoto();
                }
            }
            else
            {
                MessageBox.Show("Você não possui permissões para alterar as informações do Usuário!", "SEM PERMISSÃO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region Cadastrar Usuário
        private void btnCadastrarUsu_Click(object sender, EventArgs e)
        {
            if (Dados.Permissao == "ADMIN")
            {
                if (txtSenhaUsu.Text == String.Empty || cmbTipoUsu.Text == "" ||
                    cmbTipoUsu.SelectedItem == null || txtNomeUsu.Text == String.Empty ||
                    pbFotoUsu.ImageLocation == String.Empty)
                {
                    if (txtNomeUsu.Text == String.Empty)
                    {
                        txtNomeUsu.BackColor = Color.Tomato;
                    }
                    if (txtSenhaUsu.Text == String.Empty)
                    {
                        txtSenhaUsu.BackColor = Color.Tomato;
                    }
                    if (pbFotoUsu.ImageLocation == String.Empty)
                    {
                        pbFotoUsu.Image = pbFotoUsu.ErrorImage;
                    }
                    if (cmbTipoUsu.Text == "" || cmbTipoUsu.SelectedItem == null)
                    {
                        cmbTipoUsu.BackColor = Color.Tomato;
                    }


                    MessageBox.Show("Preencher todos os campos!", "ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (txtSenhaUsu.TextLength < 5 || txtSenhaUsu.TextLength > 8)
                    {
                        MessageBox.Show("A senha deve conter entre 5 a 8 caractéres", "!!! DADOS INCORRETOS !!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (lblForca.Text == "Senha Fraca")
                        {
                            MessageBox.Show("A senha deve atender a pelo menos dois dos requisitos listados.", "!!! DADOS INCORRETOS !!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            usu.Nome_usu = txtNomeUsu.Text;
                            usu.Senha_usu = cripto.Encrypt(txtSenhaUsu.Text);
                            usu.Id_tipousu = Convert.ToInt32(cmbTipoUsu.SelectedValue.ToString());
                            usu.Foto_usu = pbFotoUsu.ImageLocation.Replace(@"\", @"\\");

                            usuDAO.inserirUsuario(usu);

                            limpar();
                            gvExibirUsuarios.Columns.Clear();
                            gvExibirUsuarios.DataSource = usuDAO.listarUsuarios();
                            atualizarGV();
                            atualizarColunaFoto();

                            MessageBox.Show("Usuário cadastrado com sucesso!", "SUCESSO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Você não possui permissões para cadastrar um novo Usuário!", "SEM PERMISSÃO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }
        }

        private void txtSenhaUsu_TextChanged(object sender, EventArgs e)
        {
            apagarForcaSenha();
            qtdMai = 0;
            qtdMin = 0;
            if (txtSenhaUsu.Text != string.Empty)
            {
                txtSenhaUsu.BackColor = Color.Empty;
            }

            for (int i = 0; i < txtSenhaUsu.Text.Length; i++)
            {
                if (char.IsUpper(txtSenhaUsu.Text[i]))
                {
                    qtdMai++;
                }
                else
                {
                    if (char.IsLower(txtSenhaUsu.Text[i]))
                    {
                        qtdMin++;
                    }
                }
            }

            if (qtdMai > 0)
            {
                chkListGerSenha.SetItemChecked(0, true);
            }
            else
            {
                chkListGerSenha.SetItemChecked(0, false);
            }
            //
            if (qtdMin > 0)
            {
                chkListGerSenha.SetItemChecked(1, true);
            }
            else
            {
                chkListGerSenha.SetItemChecked(1, false);
            }
            //


            if (carEspecial(txtSenhaUsu.Text) == true)
            {
                chkListGerSenha.SetItemChecked(2, true);
            }
            else
            {
                chkListGerSenha.SetItemChecked(2, false);
            }
            //


            if (carNumerico(txtSenhaUsu.Text) == true)
            {
                chkListGerSenha.SetItemChecked(3, true);
            }
            else
            {
                chkListGerSenha.SetItemChecked(3, false);
            }

            if (chkListGerSenha.CheckedItems.Count == 4)
            {
                lblForca.Text = "Senha Forte";
                lblForca.ForeColor = Color.LawnGreen;
            }
            else
            {
                if (chkListGerSenha.CheckedItems.Count == 3)
                {
                    lblForca.Text = "Senha Média";
                    lblForca.ForeColor = Color.Orange;
                }
                else
                {
                    if (txtSenhaUsu.Text == String.Empty)
                    {

                        lblForca.Text = String.Empty;
                    }
                    else
                    {
                        lblForca.Text = "Senha Fraca";
                        lblForca.ForeColor = Color.Tomato;
                    }
                }
            }
        }
        #endregion

        #region Upload das Fotos
        private void btnUploadFoto_Click(object sender, EventArgs e)
        {
            string diretorioImg;
            if (fldlgFotoUsuario.ShowDialog() == DialogResult.OK)
            {
                diretorioImg = fldlgFotoUsuario.FileName;
                pbFotoUsu.ImageLocation = diretorioImg;
                pbFotoUsu.Load();
            }
        }
        #endregion

        #region Cancelar e Limpar
        private void btnCancelarUsu_Click(object sender, EventArgs e)
        {
            limpar();
            txtIDUsu.Text = Convert.ToInt32(usuDAO.buscarUltID() + 1).ToString();
        }
        #endregion

        #region Atualizar GridView
        private void atualizarGV()
        {
            try
            {
                gvExibirUsuarios.Columns[0].HeaderText = "Código";
                gvExibirUsuarios.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirUsuarios.Columns[1].HeaderText = "Tipo";
                gvExibirUsuarios.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirUsuarios.Columns[2].HeaderText = "Nome";
                gvExibirUsuarios.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirUsuarios.Columns[3].Visible = false; // SENHA
                gvExibirUsuarios.Columns[4].Visible = false; // FOTO
                gvExibirUsuarios.Columns.Add(imgCol);
                imgCol.HeaderText = "Foto";
                imgCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                imgCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            catch { }
        }

        private void atualizarColunaFoto()
        {
            for (int i = 0; i < gvExibirUsuarios.Rows.Count; i++)
            {
                Image imgProd = Image.FromFile(gvExibirUsuarios.Rows[i].Cells[4].Value.ToString());
                gvExibirUsuarios.Rows[i].Cells[5].Value = imgProd;
                gvExibirUsuarios.Rows[i].Height = 100;
            }
        }

        private void gvExibirUsuarios_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            atualizarGV();
            atualizarColunaFoto();
        }
        #endregion

        #region Exibir Usuário no Clique do GridView
        private void gvExibirUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSenhaUsu.Visible = false;
            apagarForcaSenha();
            limpar();

            txtIDUsu.Text = gvExibirUsuarios.Rows[gvExibirUsuarios.CurrentCell.RowIndex].Cells[0].Value.ToString();
            cmbTipoUsu.Text = gvExibirUsuarios.Rows[gvExibirUsuarios.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtNomeUsu.Text = gvExibirUsuarios.Rows[gvExibirUsuarios.CurrentCell.RowIndex].Cells[2].Value.ToString();
            txtSenhaUsu.Text = gvExibirUsuarios.Rows[gvExibirUsuarios.CurrentCell.RowIndex].Cells[3].Value.ToString();
            txtSenhaUsu.UseSystemPasswordChar = false;
            pbFotoUsu.ImageLocation = gvExibirUsuarios.Rows[gvExibirUsuarios.CurrentCell.RowIndex].Cells[4].Value.ToString();

            #region BOTOES
            btnNovoUsuario.Enabled = true;
            btnNovoUsuario.Visible = true;
            btnNovoUsuario.BringToFront();
            btnAlterarUsu.Enabled = true;
            btnAlterarUsu.Visible = true;
            btnAlterarUsu.BringToFront();
            btnExcluirUsu.Enabled = true;
            btnExcluirUsu.Visible = true;
            btnExcluirUsu.BringToFront();

            btnAlterarSenhaUsu.Enabled = true;
            btnAlterarSenhaUsu.Visible = true;
            btnAlterarSenhaUsu.BringToFront();

            btnCadastrarUsu.Enabled = false;
            btnCadastrarUsu.Visible = false;
            btnCadastrarUsu.SendToBack();
            btnCancelarUsu.Enabled = false;
            btnCancelarUsu.Visible = false;
            btnCancelarUsu.SendToBack();
            #endregion
        }
        #endregion

        #region Pesquisar Usuário
        private void txtPesquisaPorNome_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (usuDAO.pesquisarPorNomeGV(txtPesquisaPorNome.Text).Rows.Count > 0)
                {
                    gvExibirUsuarios.Columns.Clear();
                    gvExibirUsuarios.DataSource = usuDAO.pesquisarPorNomeGV(txtPesquisaPorNome.Text);
                    atualizarGV();
                    atualizarColunaFoto();
                }
                else
                    gvExibirUsuarios.DataSource = null;
            }
            catch { }
        }
        #endregion

        #region Limpar Cores
        private void txtNomeUsu_TextChanged(object sender, EventArgs e)
        {
            if(txtNomeUsu.Text != String.Empty)
            {
                txtNomeUsu.BackColor = Color.Empty;
            }
        }

        private void cmbTipoUsu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbTipoUsu.Text != String.Empty && cmbTipoUsu.SelectedItem != null)
            {
                cmbTipoUsu.BackColor = Color.Empty;
            }
        }

        #endregion

        #region Fechar Tela
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
            btnFechar.Visible = false;
        }
        #endregion
    }
}
