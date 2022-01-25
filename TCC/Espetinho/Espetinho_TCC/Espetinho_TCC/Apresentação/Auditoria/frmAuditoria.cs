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

namespace Espetinho_TCC.Apresentação.Auditoria
{
    public partial class frmAuditoria : Form
    {
        #region Instâncias
        FuncionarioDAO funcDAO = new FuncionarioDAO();
        AuditoriaDAO audDAO = new AuditoriaDAO();
        #endregion

        #region Carregar Tela
        public frmAuditoria()
        {
            InitializeComponent();
        }

        private void frmAuditoria_Load(object sender, EventArgs e)
        {
            dtpDataAuditoria.Value = DateTime.Now;
            gvAuditoria.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
        #endregion

        #region Atualizar GridView
        private void atualizarGV()
        {
            try
            {
                gvAuditoria.Columns[0].Visible = false; // id_aud
                gvAuditoria.Columns[1].Visible = false; // acao_aud
                gvAuditoria.Columns[2].Visible = false; // tabela_aud
                gvAuditoria.Columns[3].Visible = false; // data_aud
                gvAuditoria.Columns[4].Visible = false; // hora_aud
                gvAuditoria.Columns[5].HeaderText = "AUDITORIA"; // obs_aud
                gvAuditoria.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                for (int i = 0; i < gvAuditoria.RowCount; i++)
                {
                    gvAuditoria.Rows[i].Height = 80;
                }
            }
            catch { }
        }
        #endregion

        #region Atualizar Grid por Tabela ou Ação
        private void cmbTabela_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAcoes.SelectedItem == null &&
               cmbTabela.SelectedItem == null)
            {
                gvAuditoria.DataSource = audDAO.listarAuditoria();
                atualizarGV();
            }
            else
            {
                #region Pegar Nome da Tabela
                string nomeTabela = "";
                //
                if (cmbTabela.SelectedIndex == 0)
                {
                    nomeTabela = "usuario";
                }
                if (cmbTabela.SelectedIndex == 1)
                {
                    nomeTabela = "clientes";
                }
                if (cmbTabela.SelectedIndex == 2)
                {
                    nomeTabela = "funcionario";
                }
                if (cmbTabela.SelectedIndex == 3)
                {
                    nomeTabela = "fornecedor";
                }
                if (cmbTabela.SelectedIndex == 4)
                {
                    nomeTabela = "produto";
                }
                if (cmbTabela.SelectedIndex == 5)
                {
                    nomeTabela = "comanda";
                }
                if (cmbTabela.SelectedIndex == 6)
                {
                    nomeTabela = "saidaEstoque";
                }
                if (cmbTabela.SelectedIndex == 7)
                {
                    nomeTabela = "entradaEstoque";
                }
                if (cmbTabela.SelectedIndex == 8)
                {
                    nomeTabela = "pedidos_forn";
                }
                if (cmbTabela.SelectedIndex == 9)
                {
                    nomeTabela = "tipo_usuario";
                }
                if (cmbTabela.SelectedIndex == 10)
                {
                    nomeTabela = "tipo_produto";
                }
                if (cmbTabela.SelectedIndex == 11)
                {
                    nomeTabela = "cargo";
                }
                if (cmbTabela.SelectedIndex == 12)
                {
                    nomeTabela = "financas";
                }
                if (cmbTabela.SelectedIndex == 13)
                {
                    nomeTabela = "pagamento";
                }
                //
                #endregion

                #region Atualizar GridView após Escolher Item
                if (cmbAcoes.SelectedItem == null
                    && cmbTabela.SelectedItem != null)
                {
                    gvAuditoria.DataSource = audDAO.listarAuditoriaTabela(dtpDataAuditoria.Value, nomeTabela);
                    atualizarGV();
                }
                else
                {
                    if (cmbAcoes.SelectedItem != null
                    && cmbTabela.SelectedItem != null)
                    {
                        string Acao = "";
                        if (cmbAcoes.SelectedIndex == 0)
                        {
                            Acao = "INSERT";
                        }
                        if (cmbAcoes.SelectedIndex == 1)
                        {
                            Acao = "UPDATE";
                        }
                        if (cmbAcoes.SelectedIndex == 2)
                        {
                            Acao = "DELETE";
                        }
                        gvAuditoria.DataSource = audDAO.listarAuditoriaTabelaAcao(dtpDataAuditoria.Value, nomeTabela, Acao);
                        atualizarGV();
                    }
                }
                #endregion
            }
        }

        private void cmbAcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAcoes.SelectedItem == null &&
               cmbTabela.SelectedItem == null)
            {
                gvAuditoria.DataSource = audDAO.listarAuditoria();
                atualizarGV();
            }
            else
            {
                #region Pegar Ação
                string Acao = "";
                if (cmbAcoes.SelectedIndex == 0)
                {
                    Acao = "INSERT";
                }
                if (cmbAcoes.SelectedIndex == 1)
                {
                    Acao = "UPDATE";
                }
                if (cmbAcoes.SelectedIndex == 2)
                {
                    Acao = "DELETE";
                }
                //
                #endregion

                #region Atualizar GridView após Escolher Item
                if (cmbAcoes.SelectedItem != null
                    && cmbTabela.SelectedItem == null)
                {
                    gvAuditoria.DataSource = audDAO.listarAuditoriaAcao(dtpDataAuditoria.Value, Acao);
                    atualizarGV();
                }
                else
                {
                    if (cmbAcoes.SelectedItem != null
                    && cmbTabela.SelectedItem != null)
                    {
                        #region Pegar Nome da Tabela
                        string nomeTabela = "";
                        //
                        if (cmbTabela.SelectedIndex == 0)
                        {
                            nomeTabela = "usuario";
                        }
                        if (cmbTabela.SelectedIndex == 1)
                        {
                            nomeTabela = "clientes";
                        }
                        if (cmbTabela.SelectedIndex == 2)
                        {
                            nomeTabela = "funcionario";
                        }
                        if (cmbTabela.SelectedIndex == 3)
                        {
                            nomeTabela = "fornecedor";
                        }
                        if (cmbTabela.SelectedIndex == 4)
                        {
                            nomeTabela = "produto";
                        }
                        if (cmbTabela.SelectedIndex == 5)
                        {
                            nomeTabela = "comanda";
                        }
                        if (cmbTabela.SelectedIndex == 6)
                        {
                            nomeTabela = "saidaEstoque";
                        }
                        if (cmbTabela.SelectedIndex == 7)
                        {
                            nomeTabela = "entradaEstoque";
                        }
                        if (cmbTabela.SelectedIndex == 8)
                        {
                            nomeTabela = "pedidos_forn";
                        }
                        if (cmbTabela.SelectedIndex == 9)
                        {
                            nomeTabela = "tipo_usuario";
                        }
                        if (cmbTabela.SelectedIndex == 10)
                        {
                            nomeTabela = "tipo_produto";
                        }
                        if (cmbTabela.SelectedIndex == 11)
                        {
                            nomeTabela = "cargo";
                        }
                        if (cmbTabela.SelectedIndex == 12)
                        {
                            nomeTabela = "financas";
                        }
                        if (cmbTabela.SelectedIndex == 13)
                        {
                            nomeTabela = "pagamento";
                        }
                        //
                        #endregion

                        gvAuditoria.DataSource = audDAO.listarAuditoriaTabelaAcao(dtpDataAuditoria.Value, nomeTabela, Acao);
                        atualizarGV();
                    }
                }
                #endregion
            }
        }
        #endregion

        #region Atualizar Grid por Data
        private void dtpDataAuditoria_ValueChanged(object sender, EventArgs e)
        {
            if (cmbAcoes.SelectedItem == null &&
                cmbTabela.SelectedItem == null)
            {
                gvAuditoria.DataSource = audDAO.listarAuditoriaData(dtpDataAuditoria.Value);
                atualizarGV();
            }
            else
            {
                #region Pegar Nome da Tabela
                string nomeTabela = "";
                //
                if (cmbTabela.SelectedIndex == 0)
                {
                    nomeTabela = "usuario";
                }
                if (cmbTabela.SelectedIndex == 1)
                {
                    nomeTabela = "clientes";
                }
                if (cmbTabela.SelectedIndex == 2)
                {
                    nomeTabela = "funcionario";
                }
                if (cmbTabela.SelectedIndex == 3)
                {
                    nomeTabela = "fornecedor";
                }
                if (cmbTabela.SelectedIndex == 4)
                {
                    nomeTabela = "produto";
                }
                if (cmbTabela.SelectedIndex == 5)
                {
                    nomeTabela = "comanda";
                }
                if (cmbTabela.SelectedIndex == 6)
                {
                    nomeTabela = "saidaEstoque";
                }
                if (cmbTabela.SelectedIndex == 7)
                {
                    nomeTabela = "entradaEstoque";
                }
                if (cmbTabela.SelectedIndex == 8)
                {
                    nomeTabela = "pedidos_forn";
                }
                if (cmbTabela.SelectedIndex == 9)
                {
                    nomeTabela = "tipo_usuario";
                }
                if (cmbTabela.SelectedIndex == 10)
                {
                    nomeTabela = "tipo_produto";
                }
                if (cmbTabela.SelectedIndex == 11)
                {
                    nomeTabela = "cargo";
                }
                if (cmbTabela.SelectedIndex == 12)
                {
                    nomeTabela = "financas";
                }
                if (cmbTabela.SelectedIndex == 13)
                {
                    nomeTabela = "pagamento";
                }
                //
                #endregion

                #region Atualizar GridView após Escolher Item
                string Acao = "";
                if (cmbAcoes.SelectedItem == null
                    && cmbTabela.SelectedItem != null)
                {
                    gvAuditoria.DataSource = audDAO.listarAuditoriaTabela(dtpDataAuditoria.Value, nomeTabela);
                    atualizarGV();
                }
                else
                {
                    if (cmbAcoes.SelectedItem != null
                    && cmbTabela.SelectedItem == null)
                    {
                        if (cmbAcoes.SelectedIndex == 0)
                        {
                            Acao = "INSERT";
                        }
                        if (cmbAcoes.SelectedIndex == 1)
                        {
                            Acao = "UPDATE";
                        }
                        if (cmbAcoes.SelectedIndex == 2)
                        {
                            Acao = "DELETE";
                        }
                        gvAuditoria.DataSource = audDAO.listarAuditoriaAcao(dtpDataAuditoria.Value, Acao);
                        atualizarGV();
                    }
                    else
                    {
                        gvAuditoria.DataSource = audDAO.listarAuditoriaTabelaAcao(dtpDataAuditoria.Value, nomeTabela, Acao);
                        atualizarGV();
                    }
                }
                #endregion
            }
        }
        #endregion

        #region Botões
        private void btnMostrarTudo_Click(object sender, EventArgs e)
        {
            gvAuditoria.DataSource = audDAO.listarAuditoria();
            atualizarGV();

            #region Apagar Combos
            cmbAcoes.SelectedItem = null;
            cmbAcoes.Text = String.Empty;
            cmbTabela.SelectedItem = null;
            cmbTabela.Text = String.Empty;
            #endregion
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dtpDataAuditoria.Value = DateTime.Now;
            cmbAcoes.SelectedItem = null;
            cmbAcoes.Text = "";
            cmbTabela.SelectedItem = null;
            cmbTabela.Text = "";
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
