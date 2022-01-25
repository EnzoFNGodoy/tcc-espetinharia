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

namespace Espetinho_TCC.Apresentação.Fornecedor
{
    public partial class frmPedidosForn : Form
    {
        PedidosFornDAO pedfornDAO = new PedidosFornDAO();
        DataGridViewImageColumn imgCol = new DataGridViewImageColumn();

        public frmPedidosForn()
        {
            InitializeComponent();
        }

        string comando = "";

        DataGridViewButtonColumn colunaBotao = new DataGridViewButtonColumn();

        private void atualizarGV()
        {
            try
            {
                gvExibirPedForn.Columns[0].HeaderText = "Código";
                gvExibirPedForn.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                gvExibirPedForn.Columns[1].HeaderText = "Fornecedor";
                gvExibirPedForn.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                gvExibirPedForn.Columns[2].HeaderText = "Valor";
                gvExibirPedForn.Columns[2].DefaultCellStyle.Format = "c";
                gvExibirPedForn.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                gvExibirPedForn.Columns[3].HeaderText = "Data";
                gvExibirPedForn.Columns[3].DefaultCellStyle.Format = "d";
                gvExibirPedForn.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                gvExibirPedForn.Columns[4].HeaderText = "Hora";
                gvExibirPedForn.Columns[4].DefaultCellStyle.Format = "t";
                gvExibirPedForn.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                gvExibirPedForn.Columns.Add(colunaBotao);
                colunaBotao.HeaderText = "Ver Itens";
                colunaBotao.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            catch { }
        }

        private void frmPedidosForn_Load(object sender, EventArgs e)
        {
            gvExibirPedForn.DataSource = pedfornDAO.listarPedidos();
            atualizarGV();
            atualizarColunaBotao();
        }

        private void atualizarColunaBotao()
        {
            try
            {
                for (int i = 0; i < gvExibirPedForn.Rows.Count; i++)
                {
                    gvExibirPedForn.Rows[i].Cells[5].Value = "Pedidos ...";
                    gvExibirPedForn.Rows[i].Height = 60;
                }
            }
            catch { }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisarPorID_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPesqPorId.Text != String.Empty)
                {
                    txtPesqPorForn.Clear();
                    cmbPesqPorValor.Text = "";
                    cmbPesqPorValor.SelectedItem = null;
                    

                    gvExibirPedForn.Columns.Clear();
                    gvExibirPedForn.DataSource = pedfornDAO.listarPedidosPorId(Convert.ToInt32(txtPesqPorId.Text));
                    atualizarGV();
                    atualizarColunaBotao();
                }
            }
            catch { }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            gvExibirPedForn.Columns.Clear();
            gvExibirPedForn.DataSource = pedfornDAO.listarPedidos();
            txtPesqPorId.Clear();
            txtPesqPorForn.Clear();
            cmbPesqPorValor.Text = "";
            cmbPesqPorValor.SelectedItem = null;
            atualizarGV();
            atualizarColunaBotao();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPesqPorId.Clear();
            txtPesqPorForn.Clear();
            cmbPesqPorValor.SelectedItem = null;
            for (int i = 0; i < gvExibirPedForn.RowCount; i++)
            {
                gvExibirPedForn.Rows[i].DataGridView.Columns.Clear();
            }
        }

        // Pesquisar por Fornecedor
        private void btnPesqPorData_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPesqPorForn.Text != String.Empty)
                {
                    txtPesqPorId.Clear();
                    cmbPesqPorValor.Text = "";
                    cmbPesqPorValor.SelectedItem = null;

                    gvExibirPedForn.Columns.Clear();
                    gvExibirPedForn.DataSource = pedfornDAO.listarPedidosPorForn(txtPesqPorForn.Text);
                    atualizarGV();
                    atualizarColunaBotao();
                }
            }
            catch { }
        }

        private void cmbPesqPorValor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPesqPorId.Clear();
            txtPesqPorForn.Clear();
            if (cmbPesqPorValor.SelectedIndex == 0)
            {
                comando = "p.valor_ped <= 100";
            } // MENOS DE 10
            if (cmbPesqPorValor.SelectedIndex == 1)
            {
                comando = "p.valor_ped >= 100 and p.valor_ped < 500";
            } // ENTRE 10 E 50
            if (cmbPesqPorValor.SelectedIndex == 2)
            {
                comando = "p.valor_ped >= 500.0 and p.valor_ped < 1000.0";
            } // ENTRE 50 E 100
            if (cmbPesqPorValor.SelectedIndex == 3)
            {
                comando = "p.valor_ped >= 1000";
            } // MAIS DE 100
        }

        private void btnPesqPorPreco_Click(object sender, EventArgs e)
        {
            if (cmbPesqPorValor.SelectedItem != null)
            {
                gvExibirPedForn.Columns.Clear();
                gvExibirPedForn.DataSource = pedfornDAO.listarPedidosPorValor(comando);
                atualizarGV();
                atualizarColunaBotao();
            }
        }

        private void gvExibirPedForn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                frmItPedidosForn TelaItPedidos = new frmItPedidosForn(gvExibirPedForn.Rows[gvExibirPedForn.CurrentCell.RowIndex].Cells[0].Value.ToString());
                TelaItPedidos.ShowDialog();

                atualizarColunaBotao();
            }
        }

        private void gvExibirPedForn_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string nomeForn;
            double valor;
            DateTime data, hora;


            data = Convert.ToDateTime(gvExibirPedForn.Rows[gvExibirPedForn.CurrentCell.RowIndex].Cells[3].Value.ToString());
            hora = Convert.ToDateTime(gvExibirPedForn.Rows[gvExibirPedForn.CurrentCell.RowIndex].Cells[4].Value.ToString());
            valor = Convert.ToDouble(gvExibirPedForn.Rows[gvExibirPedForn.CurrentCell.RowIndex].Cells[2].Value.ToString().TrimStart("R$ ".ToCharArray()));
            nomeForn = Convert.ToString(gvExibirPedForn.Rows[gvExibirPedForn.CurrentCell.RowIndex].Cells[1].Value.ToString());

            frmGerenciarPedidosForn telaSaidaEst = new frmGerenciarPedidosForn(Convert.ToInt32(gvExibirPedForn.Rows[gvExibirPedForn.CurrentCell.RowIndex].Cells[0].Value.ToString()),
                data, hora, valor, nomeForn);
            telaSaidaEst.ShowDialog();
        }

        private void gvExibirPedForn_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            atualizarGV();
            atualizarColunaBotao();
        }
    }
}
