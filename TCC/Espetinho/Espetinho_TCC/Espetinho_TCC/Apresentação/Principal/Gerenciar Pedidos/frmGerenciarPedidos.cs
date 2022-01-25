using Espetinho_TCC.DAO;
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
using Espetinho_TCC.Utils;

namespace Espetinho_TCC.Apresentação.Principal
{
    public partial class frmGerenciarPedidos : Form
    {
        ProdutoDAO prodDAO = new ProdutoDAO();
        ItensComanda itCom = new ItensComanda();
        Comanda com = new Comanda();
        ComandaDAO comDAO = new ComandaDAO();
        FuncionarioDAO funcDAO = new FuncionarioDAO();
        ClientesDAO cliDAO = new ClientesDAO();
        PagamentoDAO pagtoDAO = new PagamentoDAO();
        ItensComandaDAO itComDAO = new ItensComandaDAO();

        DataGridViewButtonColumn colunaBotao = new DataGridViewButtonColumn();

        static int idFunc, idCli, idPagto;
        int id;
        double valor;
        DateTime data, hora;

        public frmGerenciarPedidos(int idCom, int idCliCom, int idFuncCom, int idPagtoCom, Double valorCom, DateTime dataCom, DateTime horaCom)
        {
            InitializeComponent();
            id = idCom;
            idFunc = idFuncCom;
            idCli = idCliCom;
            idPagto = idPagtoCom;
            valor = valorCom;
            data = dataCom;
            hora = horaCom;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmBuscarCliente telaCliente = new frmBuscarCliente();
            telaCliente.ShowDialog();
            if (telaCliente.gvExibirClientes.Rows[telaCliente.gvExibirClientes.CurrentCell.RowIndex].DefaultCellStyle.SelectionBackColor == Color.GreenYellow)
            {
                idCli = Convert.ToInt32(telaCliente.gvExibirClientes.Rows[telaCliente.gvExibirClientes.CurrentCell.RowIndex].Cells[0].Value.ToString());
                txtCli.Text = telaCliente.gvExibirClientes.Rows[telaCliente.gvExibirClientes.CurrentCell.RowIndex].Cells[1].Value.ToString();
            }
            else
            {
                MessageBox.Show("Você não escolheu nenhum cliente", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnAtualizarHora_Click(object sender, EventArgs e)
        {
            mskHora.Text = DateTime.Now.ToLocalTime().ToShortTimeString();
        }

        private void frmGerenciarPedidos_Load(object sender, EventArgs e)
        {
            gvExibirPedidos.DataSource = comDAO.listarComanda();
            atualizarGVPedidos();
            atualizarGVProdutos(id);

            txtID.Text = id.ToString();
            txtCli.Text = cliDAO.clientePorID(idCli).Nome_cli;
            txtFunc.Text = funcDAO.funcPorID(idFunc).Nome_func;
            txtPagto.Text = pagtoDAO.pagtoPorID(idPagto).Tipo_pagto;
            txtValor.Text = "R$ " + valor.ToString("#0.00");
            mskHora.Text = hora.ToShortTimeString();
            dtpData.Text = data.ToShortDateString();
        }

        private void atualizarGVPedidos()
        {
            try
            {
                gvExibirPedidos.Columns[0].HeaderText = "Código";
                gvExibirPedidos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirPedidos.Columns[1].HeaderText = "Forma de Pagamento";
                gvExibirPedidos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirPedidos.Columns[2].HeaderText = "Valor R$";
                gvExibirPedidos.Columns[2].DefaultCellStyle.Format = "c";
                gvExibirPedidos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirPedidos.Columns[3].HeaderText = "Data";
                gvExibirPedidos.Columns[3].DefaultCellStyle.Format = "d";
                gvExibirPedidos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirPedidos.Columns[4].HeaderText = "Hora";
                gvExibirPedidos.Columns[4].DefaultCellStyle.Format = "t";
                gvExibirPedidos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                for (int i = 0; i < gvExibirPedidos.RowCount; i++)
                {
                    gvExibirPedidos.Rows[i].Height = 80;
                }
            }
            catch { }
        }

        private void atualizarGVProdutos(int idPedido)
        {
            try
            {
                for (int i = 0; i < itComDAO.listarProdutosItensComanda(idPedido).Rows.Count; i++)
                {
                    gvExibirProdutos.Rows.Add(idPedido,
                        itComDAO.listarProdutosItensComanda(idPedido).Rows[i][0].ToString(),
                        itComDAO.listarProdutosItensComanda(idPedido).Rows[i][1].ToString(),
                        "R$ " + Convert.ToDouble(itComDAO.listarProdutosItensComanda(idPedido).Rows[i][2].ToString()).ToString("#0.00").Replace('.', ','),
                        "R$ " + Convert.ToDouble(itComDAO.listarProdutosItensComanda(idPedido).Rows[i][4].ToString()).ToString("#0.00").Replace('.', ','),
                        itComDAO.listarProdutosItensComanda(idPedido).Rows[i][3].ToString()
                        );
                }
            }
            catch { }
        }

        private void gvExibirPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            limpar();
            txtID.Text = gvExibirPedidos.Rows[gvExibirPedidos.CurrentCell.RowIndex].Cells[0].Value.ToString();
            dtpData.Value = Convert.ToDateTime(gvExibirPedidos.Rows[gvExibirPedidos.CurrentCell.RowIndex].Cells[3].Value.ToString());
            mskHora.Text = Convert.ToDateTime(gvExibirPedidos.Rows[gvExibirPedidos.CurrentCell.RowIndex].Cells[4].Value.ToString()).ToShortTimeString();
            txtValor.Text = "R$ " + Convert.ToDouble(gvExibirPedidos.Rows[gvExibirPedidos.CurrentCell.RowIndex].Cells[2].Value).ToString("#0.00");
            txtCli.Text = cliDAO.clientePorID(idCli).Nome_cli;
            txtFunc.Text = funcDAO.funcPorID(idFunc).Nome_func;
            txtPagto.Text = pagtoDAO.pagtoPorID(idPagto).Tipo_pagto;

            atualizarGVProdutos(Convert.ToInt32(txtID.Text));
        }

        public void limpar()
        {
            txtID.Clear();
            txtValor.Clear();
            mskHora.Clear();
            dtpData.Value = DateTime.Now;
            txtPagto.Clear();
            txtFunc.Clear();
            txtValor.Clear();
            for (int i = 0; i < gvExibirProdutos.Rows.Count; i++)
            {
                gvExibirProdutos.Rows.Clear();
            }
            gvExibirProdutos.ClearSelection();
            btnRemoverProdLista.Visible = false;
            btnRemoverProdLista.Enabled = false;
        }

        private void atualizarGV()
        {
            try
            {
                gvExibirPedidos.Columns[0].HeaderText = "Código";
                gvExibirPedidos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirPedidos.Columns[1].HeaderText = "Forma de Pagamento";
                gvExibirPedidos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirPedidos.Columns[2].HeaderText = "Valor R$";
                gvExibirPedidos.Columns[2].DefaultCellStyle.Format = "c";
                gvExibirPedidos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirPedidos.Columns[3].HeaderText = "Data";
                gvExibirPedidos.Columns[3].DefaultCellStyle.Format = "d";
                gvExibirPedidos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvExibirPedidos.Columns[4].HeaderText = "Hora";
                gvExibirPedidos.Columns[4].DefaultCellStyle.Format = "t";
                gvExibirPedidos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch { }
        }

        private void btnExcluirPedidos_Click(object sender, EventArgs e)
        {
            if (Dados.Permissao == "ADMIN" || Dados.Permissao == "FUNCIONARIO")
            {
                DialogResult opcao;

                opcao = MessageBox.Show("Deseja realmente excluir o Pedido?", "Excluir?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcao == DialogResult.Yes)
                {
                    comDAO.excluirComanda(Convert.ToInt32(txtID.Text));

                    limpar();
                    gvExibirPedidos.Columns.Clear();
                    gvExibirPedidos.DataSource = comDAO.listarComanda();
                    atualizarGV();

                    MessageBox.Show("Comanda excluida com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Comanda não excluida!", "ERRO!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Você não possui permissões para excluir uma Comanda!", "SEM PERMISSÃO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            txtID.BackColor = Color.Empty;
        }

        private void txtPagto_TextChanged(object sender, EventArgs e)
        {
            txtPagto.BackColor = Color.Empty;
        }

        private void txtCli_TextChanged(object sender, EventArgs e)
        {
            txtCli.BackColor = Color.Empty;
        }

        private void txtFunc_TextChanged(object sender, EventArgs e)
        {
            txtFunc.BackColor = Color.Empty;
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            txtValor.BackColor = Color.Empty;
        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {
            dtpData.BackColor = Color.Empty;
        }

        private void mskHora_TextChanged(object sender, EventArgs e)
        {
            if (mskHora.MaskFull == true)
            {
                String hora = mskHora.Text;
                String[] hms = hora.Split(":".ToCharArray());
                int horas = Convert.ToInt32(hms[0]);
                int minutos = Convert.ToInt32(hms[1]);
                if (horas > 23 || minutos > 59)
                {
                    mskHora.BackColor = Color.Tomato;
                }
                else
                {
                    mskHora.BackColor = Color.GreenYellow;
                }
            }
            else
            {
                if (mskHora.Text != String.Empty)
                {
                    mskHora.BackColor = Color.Empty;
                }
            }
        }

        private void btnOKPesquisa_Click(object sender, EventArgs e)
        {
            gvExibirPedidos.Columns.Clear();
            gvExibirPedidos.DataSource = comDAO.pesquisarPorData(dtpPesqInicio.Value.ToShortDateString(), dtpPesqTermino.Value.ToShortDateString());
            atualizarGV();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
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

        private void gvExibirProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAlterarEntradaEstoque_Click(object sender, EventArgs e)
        {
            if (Dados.Permissao == "ADMIN" || Dados.Permissao == "FUNCIONARIO")
            {
                if (dtpData.Value == null || mskHora.MaskFull == false ||
                    txtValor.Text == String.Empty || txtValor.Text == "R$ 0,00" ||
                    txtFunc.Text == String.Empty || txtCli.Text == String.Empty ||
                    txtPagto.Text == String.Empty)
                {
                    if (dtpData.Value == null)
                    {
                        MessageBox.Show("Favor preencher o campo de data", "Sem Data!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if (mskHora.MaskFull == false)
                    {
                        mskHora.BackColor = Color.Tomato;
                    }
                    if (txtValor.Text == String.Empty || txtValor.Text == "R$ 0,00")
                    {
                        txtValor.BackColor = Color.Tomato;
                    }
                    if (txtFunc.Text == String.Empty)
                    {
                        txtFunc.BackColor = Color.Tomato;
                    }
                    if (txtCli.Text == String.Empty)
                    {
                        txtCli.BackColor = Color.Tomato;
                    }
                    if (txtPagto.Text == String.Empty)
                    {
                        txtPagto.BackColor = Color.Tomato;
                    }
                    MessageBox.Show("Favor preencher todos os campos!", "Campos vazios!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    com.Id_func = idFunc;
                    com.Id_pagto = idPagto;
                    com.Id_cli = idCli;
                    com.Valor_com = Convert.ToDouble(txtValor.Text);
                    com.Data_com = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    com.Hora_com = Convert.ToDateTime(DateTime.Now.ToShortTimeString());

                    comDAO.alterarComanda(com, Convert.ToInt32(txtID.Text));

                    for (int i = 0; i < itComDAO.listarProdutosItensComanda(Convert.ToInt32(txtID.Text)).Rows.Count; i++)
                    {
                        DataTable produtos = itComDAO.listarProdutosItensComanda(Convert.ToInt32(txtID.Text));
                        produtos.Rows[i]["QtdItens"].ToString();
                        prodDAO.adicionarEstoque(Convert.ToInt32(produtos.Rows[i]["codigo"].ToString()), Convert.ToInt32(produtos.Rows[i]["QtdItens"].ToString()));
                    }

                    comDAO.excluirItensComanda(Convert.ToInt32(txtID.Text));
                    int qtdItens = gvExibirProdutos.RowCount;
                    for (int i = 0; i < qtdItens; i++)
                    {
                        itCom.Id_com = Convert.ToInt32(txtID.Text);
                        itCom.Id_prod = Convert.ToInt32(gvExibirProdutos.Rows[i].Cells[1].Value.ToString());
                        itCom.Qtd_itens = Convert.ToInt32(gvExibirProdutos.Rows[i].Cells[5].Value.ToString());

                        itComDAO.inserirItensComanda(itCom);
                        prodDAO.retirarEstoque(Convert.ToInt32(gvExibirProdutos.Rows[i].Cells[1].Value.ToString()), Convert.ToInt32(gvExibirProdutos.Rows[i].Cells[5].Value.ToString()));
                    }

                    limpar();
                    MessageBox.Show("Comanda alterada!", "!!! SUCESSO !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnBuscarPagto_Click(object sender, EventArgs e)
        {
            frmBuscarPagto telaBuscarPagto = new frmBuscarPagto();
            telaBuscarPagto.ShowDialog();
            if (telaBuscarPagto.gvExibirPagamentos.Rows[telaBuscarPagto.gvExibirPagamentos.CurrentCell.RowIndex].DefaultCellStyle.SelectionBackColor == Color.GreenYellow)
            {
                idPagto = Convert.ToInt32(telaBuscarPagto.gvExibirPagamentos.Rows[telaBuscarPagto.gvExibirPagamentos.CurrentCell.RowIndex].Cells[0].Value.ToString());
                txtPagto.Text = telaBuscarPagto.gvExibirPagamentos.Rows[telaBuscarPagto.gvExibirPagamentos.CurrentCell.RowIndex].Cells[1].Value.ToString();
            }
            else
            {
                MessageBox.Show("Você não escolheu nenhuma forma de pagamento", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnBuscarFunc_Click(object sender, EventArgs e)
        {
            frmBuscarFunc telaBuscarFunc = new frmBuscarFunc();
            telaBuscarFunc.ShowDialog();
            if (telaBuscarFunc.gvExibirFuncionarios.Rows[telaBuscarFunc.gvExibirFuncionarios.CurrentCell.RowIndex].DefaultCellStyle.SelectionBackColor == Color.GreenYellow)
            {
                idPagto = Convert.ToInt32(telaBuscarFunc.gvExibirFuncionarios.Rows[telaBuscarFunc.gvExibirFuncionarios.CurrentCell.RowIndex].Cells[0].Value.ToString());
                txtPagto.Text = telaBuscarFunc.gvExibirFuncionarios.Rows[telaBuscarFunc.gvExibirFuncionarios.CurrentCell.RowIndex].Cells[1].Value.ToString();
            }
            else
            {
                MessageBox.Show("Você não escolheu nenhum funcionário", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
