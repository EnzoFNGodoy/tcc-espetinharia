using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Espetinho_TCC.Apresentação;
using Espetinho_TCC.Apresentação.Controle_de_Estoque;
using Espetinho_TCC.DAO;
using Espetinho_TCC.Apresentação.Usuarios;

namespace Espetinho_TCC.Apresentação.Fornecedor
{
    public partial class frmControleDeFornecedor : Form
    {
        FornecedorDAO fornDAO = new FornecedorDAO();
        UsuarioDAO usuDAO = new UsuarioDAO();

        public frmControleDeFornecedor(string nomeUsu)
        {
            InitializeComponent();
            lblNomeUsuAtivo.Text = nomeUsu;
            lblNomeUsuAtivo.ForeColor = Color.LawnGreen;

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            gvExibirForn.Columns.Clear();
            gvExibirForn.DataSource = fornDAO.listarFornecedor();
            txtID.Clear();
            txtPesqNome.Clear();
            txtCpfCnpj.Clear();
            atualizarGV();
        }
        private void atualizarGV()
        {
            try
            {
                gvExibirForn.Columns[0].HeaderText = "Código";
                gvExibirForn.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirForn.Columns[1].HeaderText = "Nome";
                gvExibirForn.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirForn.Columns[2].HeaderText = "Cpf";
                gvExibirForn.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirForn.Columns[3].HeaderText = "Cnpj";
                gvExibirForn.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirForn.Columns[5].HeaderText = "Email";
                gvExibirForn.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirForn.Columns[4].Visible = false;

                for (int i = 0; i < gvExibirForn.Rows.Count; i++)
                {
                    gvExibirForn.Rows[i].Height = 60;
                }

            }
            catch { }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtPesqNome.Clear();
            txtCpfCnpj.Clear();
            for (int i = 0; i < gvExibirForn.RowCount; i++)
            {
                gvExibirForn.Rows[i].DataGridView.Columns.Clear();
            }
        }

        private void btnPesquisarPorID_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text != String.Empty)
                {
                    gvExibirForn.Columns.Clear();
                    gvExibirForn.DataSource = fornDAO.fornPorIDGV(Convert.ToInt32(txtID.Text));
                    atualizarGV();
                }
            }
            catch { }
        }

        private void btnPesqCnpjCpf_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCpfCnpj.Text != String.Empty)
                {
                    gvExibirForn.Columns.Clear();
                    gvExibirForn.DataSource = fornDAO.fornPorCpfCnpj(txtCpfCnpj.Text);
                    atualizarGV();

                }
            }
            catch { }
        }

        private void btnPesqNome_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPesqNome.Text != String.Empty)
                {
                    gvExibirForn.Columns.Clear();
                    gvExibirForn.DataSource = fornDAO.fornPorNome(txtPesqNome.Text);
                    atualizarGV();
                }
            }
            catch { }
        }

        private void frmControleDeFornecedor_Load(object sender, EventArgs e)
        {
            gvExibirForn.DataSource = fornDAO.listarFornsGV();
            atualizarGV();
        }

        private void btnPedidosForn_Click(object sender, EventArgs e)
        {
            frmPedidosForn telaPedidos = new frmPedidosForn();
            telaPedidos.ShowDialog();
        }

        private void gvExibirForn_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmGerenciarFornecedor telaGerenciarForn = new frmGerenciarFornecedor(lblNomeUsuAtivo.Text);
            telaGerenciarForn.ShowDialog();
        }
    }
}
