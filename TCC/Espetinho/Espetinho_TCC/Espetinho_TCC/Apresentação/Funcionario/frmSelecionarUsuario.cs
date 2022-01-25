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

namespace Espetinho_TCC.Apresentação.Funcionario
{
    public partial class frmSelecionarUsuario : Form
    {
        #region Instâncias
        UsuarioDAO usuDAO = new UsuarioDAO();
        #endregion

        #region Variáveis
        DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
        public int idUsu;
        #endregion

        #region Carregar Tela
        public frmSelecionarUsuario()
        {
            InitializeComponent();
        }

        private void frmSelecionarUsuario_Load(object sender, EventArgs e)
        {
            idUsu = 0;
            gvExibirUsuarios.DataSource = usuDAO.listarUsuarios();
            atualizarGV();
            atualizarColunaFoto();
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

        #region Selecionar o Usuário
        private void gvExibirUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idUsu = Convert.ToInt32(gvExibirUsuarios.Rows[gvExibirUsuarios.CurrentCell.RowIndex].Cells[0].Value.ToString());
            Close();
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
