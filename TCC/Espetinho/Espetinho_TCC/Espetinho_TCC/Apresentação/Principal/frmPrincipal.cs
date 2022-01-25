using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Resolucao;
using Espetinho_TCC.DAO;
using Espetinho_TCC.Model;
using Espetinho_TCC.Utils;
using Espetinho_TCC.Apresentação.Usuarios;
using Espetinho_TCC.Apresentação.Fornecedor;
using Espetinho_TCC.Apresentação.Clientes;
using Espetinho_TCC.Apresentação.Funcionario;
using Espetinho_TCC.Apresentação.Finanças;
using Espetinho_TCC.Apresentação.Auditoria;
using Espetinho_TCC.Apresentação.Principal;

namespace Espetinho_TCC.Apresentação
{
    public partial class frmPrincipal : Form
    {
        #region Instâncias
        Usuario usu = new Usuario();
        UsuarioDAO usuDAO = new UsuarioDAO();
        Comanda com = new Comanda();
        ComandaDAO comDAO = new ComandaDAO();
        Produto prod = new Produto();
        ProdutoDAO prodDAO = new ProdutoDAO();
        TipoProdutoDAO tipoProdDAO = new TipoProdutoDAO();
        FornecedorDAO fornDAO = new FornecedorDAO();
        FuncionarioDAO funcDAO = new FuncionarioDAO();
        ClientesDAO cliDAO = new ClientesDAO();
        Financas fin = new Financas();
        FinancasDAO finDAO = new FinancasDAO();
        Criptografia cripto = new Criptografia("@!ESPETINHO123");
        BackupBD backup = new BackupBD();
        #endregion

        #region Imagens
        Image imgNomeUsuAtivoVerificado = Image.FromFile("Icones\\carraca.png");
        Image imgNomeUsuAtivoErro = Image.FromFile("Icones\\fechar(1).png");
        #endregion

        #region Coluna de Botão
        DataGridViewButtonColumn colunaBotao = new DataGridViewButtonColumn();
        #endregion

        #region Variáveis
        double valorEmCaixa = 0;
        int contMenu, contMenuCaixaTotal, contVerPedido;
        int contProdMaisVendidosESPETOS, contProdMaisVendidosBEBIDAS, contProdMaisVendidosCERVEJAS;
        #endregion

        #region Inicializar Form
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            pnlLogin.BringToFront();
            lblTitulo.Visible = false;
            lblNomeUsuAtivo.Text = "Nenhum   ";
            lblNomeUsuAtivo.Image = imgNomeUsuAtivoErro;
            lblNomeUsuAtivo.ForeColor = Color.Red;
            lblNomeUsuAtivo.Enabled = false;
        }
        #endregion

        #region Abrir Menu Toggle
        private void btnAbrirMenu_Click(object sender, EventArgs e)
        {
            contMenu++;

            if (contMenu % 2 != 0)
            {
                //ÍMPAR
                pnlMenu.Visible = true;
            }
            else
            {
                //PAR
                pnlMenu.Visible = false;
            }
        }
        #endregion

        #region Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == String.Empty || txtSenha.Text == String.Empty)
            {
                if (txtUsuario.Text == String.Empty)
                {
                    txtUsuario.BackColor = Color.Red;
                }
                if (txtSenha.Text == String.Empty)
                {
                    txtSenha.BackColor = Color.Red;
                }

                MessageBox.Show("Preencher os campos obrigatórios!", "Campos Obrigatórios!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // NÃO CRIPTOGRAFADO
                if (usuDAO.loginUsuario(txtUsuario.Text, cripto.Encrypt(txtSenha.Text)) == true)
                {
                    lblBemVindo.Text = "Bem-vindo Sr(a), " + txtUsuario.Text + "!";
                    pbFotoUsuario.Visible = true;
                    pbFotoUsuario.ImageLocation = usuDAO.Usu.Foto_usu;
                    lblNomeUsuAtivo.ForeColor = Color.LawnGreen;
                    lblNomeUsuAtivo.Text = txtUsuario.Text + "   ";
                    Dados.IdUsu = usuDAO.UsuarioPorNome(lblNomeUsuAtivo.Text.TrimEnd(" ".ToCharArray())).Id_usu;
                    lblNomeUsuAtivo.Image = imgNomeUsuAtivoVerificado;
                    lblNomeUsuAtivo.Enabled = true;
                    pnlLogin.Visible = false;
                    btnAbrirMenu.Enabled = true;
                    lblTitulo.Visible = true;

                    // VERIFICAR PERMISSAO USUARIO //
                    Dados.Permissao = usuDAO.permissao(txtUsuario.Text);
                    // ========================== //

                    // PAINEL DE DADOS //
                    pnlDados.Visible = true;
                    pnlDados.BringToFront();
                    lblUsuarios.Text = usuDAO.quantidadeTotalUsuario().ToString();
                    lblProdutos.Text = prodDAO.quantidadeTotalProdutos().ToString();
                    lblVendas.Text = comDAO.quantidadeTotalComandas().ToString();
                    lblFuncionarios.Text = funcDAO.quantidadeTotalFuncionarios().ToString();
                    lblQtdClientes.Text = cliDAO.quantidadeClientes().ToString();
                    if (lblNomeUsuAtivo.ForeColor == Color.LawnGreen)
                    {
                        lblConectado.Text = "SIM";
                        lblConectado.ForeColor = Color.LawnGreen;
                    }
                    else
                    {
                        lblConectado.Text = "NÃO";
                        lblConectado.ForeColor = Color.Tomato;
                    }
                    // ============== //

                    MessageBox.Show("Login efetuado com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuário ou senha não correspondem!", "Informações erradas!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparTudoLogin();
        }

        private void btnRecSenha_Click(object sender, EventArgs e)
        {
            frmRecSenha telaRecSenha = new frmRecSenha();
            telaRecSenha.ShowDialog();
        }

        public void limparTudoLogin()
        {
            lblBemVindo.Text = "";
            lblNomeUsuAtivo.ForeColor = Color.Red;
            lblNomeUsuAtivo.Text = "Nenhum   ";
            lblNomeUsuAtivo.Image = imgNomeUsuAtivoErro;
            txtUsuario.Clear();
            txtSenha.Clear();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            txtUsuario.BackColor = Color.Empty;
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.BackColor = Color.Empty;
        }
        #endregion

        #region Abrir e Fechar Panel Calculadora
        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            pnlCalculadora.Visible = true;
        }

        private void btnFecharPnlCalculadora_Click(object sender, EventArgs e)
        {
            pnlCalculadora.Visible = false;
        }
        #endregion

        #region Horário em Tempo Real
        private void tmrDataHora_Tick(object sender, EventArgs e)
        {
            DateTime data = DateTime.Now;
            CultureInfo cultura = new CultureInfo("pt-BR");
            DateTimeFormatInfo formata = cultura.DateTimeFormat;
            string diaDaSemana = formata.GetDayName(data.DayOfWeek);
            var diaDaSemanaFORMATA = char.ToUpper(diaDaSemana[0]) + diaDaSemana.Substring(1);

            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblDiaSemana.Text = diaDaSemanaFORMATA.ToString();
            #region MESES
            String mes = "";
            if (DateTime.Now.Month == 1)
            {
                mes = "Janeiro";
            }
            if (DateTime.Now.Month == 2)
            {
                mes = "Fevereiro";
            }
            if (DateTime.Now.Month == 3)
            {
                mes = "Março";
            }
            if (DateTime.Now.Month == 4)
            {
                mes = "Abril";
            }
            if (DateTime.Now.Month == 5)
            {
                mes = "Maio";
            }
            if (DateTime.Now.Month == 6)
            {
                mes = "Junho";
            }
            if (DateTime.Now.Month == 7)
            {
                mes = "Julho";
            }
            if (DateTime.Now.Month == 8)
            {
                mes = "Agosto";
            }
            if (DateTime.Now.Month == 9)
            {
                mes = "Setembro";
            }
            if (DateTime.Now.Month == 10)
            {
                mes = "Outubro";
            }
            if (DateTime.Now.Month == 11)
            {
                mes = "Novembro";
            }
            if (DateTime.Now.Month == 12)
            {
                mes = "Dezembro";
            }
            #endregion
            lblDiaMes.Text = DateTime.Now.Day.ToString() + " de " + mes.ToString() + " de " + DateTime.Now.Year.ToString();


        }
        #endregion

        #region Backup Banco
        private void btnFazerBackup_Click(object sender, EventArgs e)
        {
            try
            {
                backup.backup();

                MessageBox.Show("Backup Efetuado! Data: " + backup.data, "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }
        }
        #endregion

        #region MENU TOGGLE

        #region Mostrar Caixa Total Por Tempo 
        private void btnCaixaDia_Click(object sender, EventArgs e)
        {
            grpCaixaTotalPorTempo.Text = "Caixa do Dia";
            valorEmCaixa = finDAO.valorCaixaDia(DateTime.Now);
            lblValorCaixa.Text = "R$ " + Convert.ToDouble(valorEmCaixa).ToString("#0.00");
            btnAddValor.Enabled = true;
        }

        private void btnCaixaMes_Click(object sender, EventArgs e)
        {
            grpCaixaTotalPorTempo.Text = "Caixa do Mês";
            valorEmCaixa = finDAO.valorCaixaMes(DateTime.Now.Month, DateTime.Now.Year);
            lblValorCaixa.Text = "R$ " + Convert.ToDouble(valorEmCaixa).ToString("#0.00");
            btnAddValor.Enabled = true;
        }

        private void btnCaixaSemana_Click(object sender, EventArgs e)
        {
            grpCaixaTotalPorTempo.Text = "Caixa da Semana";
            DateTime dataHoje = DateTime.Now;
            CultureInfo cultura = new CultureInfo("pt-BR");
            DateTimeFormatInfo formata = cultura.DateTimeFormat;
            string diaDaSemana = formata.GetDayName(dataHoje.DayOfWeek);

            #region Dias da Semana
            if (diaDaSemana == "domingo")
            {
                valorEmCaixa = finDAO.valorCaixaSemana(dataHoje, dataHoje);
            }
            if (diaDaSemana == "segunda-feira")
            {
                valorEmCaixa = finDAO.valorCaixaSemana(dataHoje.AddDays(-1), dataHoje);
            }
            if (diaDaSemana == "terça-feira")
            {
                valorEmCaixa = finDAO.valorCaixaSemana(dataHoje.AddDays(-2), dataHoje);
            }
            if (diaDaSemana == "quarta-feira")
            {
                valorEmCaixa = finDAO.valorCaixaSemana(dataHoje.AddDays(-3), dataHoje);
            }
            if (diaDaSemana == "quinta-feira")
            {
                valorEmCaixa = finDAO.valorCaixaSemana(dataHoje.AddDays(-4), dataHoje);
            }
            if (diaDaSemana == "sexta-feira")
            {
                valorEmCaixa = finDAO.valorCaixaSemana(dataHoje.AddDays(-5), dataHoje);
            }
            if (diaDaSemana == "sábado")
            {
                valorEmCaixa = finDAO.valorCaixaSemana(dataHoje.AddDays(-6), dataHoje);
            }
            #endregion
            lblValorCaixa.Text = "R$ " + Convert.ToDouble(valorEmCaixa).ToString("#0.00");
            btnAddValor.Enabled = true;
        }

        private void btnCaixaAno_Click(object sender, EventArgs e)
        {
            grpCaixaTotalPorTempo.Text = "Caixa do Ano";
            valorEmCaixa = finDAO.valorCaixaAno(DateTime.Now.Year);
            lblValorCaixa.Text = "R$ " + Convert.ToDouble(valorEmCaixa).ToString("#0.00");
            btnAddValor.Enabled = true;
        }

        private void btnCaixaTotalPorTempo_Click(object sender, EventArgs e)
        {
            contMenuCaixaTotal++;
            if (contMenuCaixaTotal % 2 != 0)
            {
                grpCaixaTotalPorTempo.Visible = true;
            }
            else
            {
                grpCaixaTotalPorTempo.Visible = false;
            }
            DateTime dataHoje;
            dataHoje = DateTime.Now;

            valorEmCaixa = finDAO.valorCaixaDia(dataHoje);
            lblValorCaixa.Text = "R$ " + Convert.ToDouble(valorEmCaixa).ToString("#0.00");
        }
        #endregion

        #region Mostrar Produtos Mais Vendidos
        private void gvMaisVendidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (prodDAO.PesquisarProd(gvMaisVendidos.Rows[gvMaisVendidos.CurrentCell.RowIndex].Cells[0].Value.ToString()) == true)
                {
                    frmGerenciarProduto telaGerProd = new frmGerenciarProduto(lblNomeUsuAtivo.Text, prodDAO.Prod.Id_prod, prodDAO.Prod.QtdEst_prod, prodDAO.Prod.Nome_prod, prodDAO.Prod.Custo_prod, prodDAO.Prod.Preco_prod, prodDAO.Forn.Nome_forn, prodDAO.Tipoprod.Tipo_produto, prodDAO.Prod.Foto_prod);
                    telaGerProd.ShowDialog();
                }
            }
        }

        private void btnFecharGvMaisVendidos_Click(object sender, EventArgs e)
        {
            contProdMaisVendidosBEBIDAS++;
            contProdMaisVendidosCERVEJAS++;
            contProdMaisVendidosESPETOS++;
            pbTipoProd.Visible = false;
            lblTipoProduto.Visible = false;
            cmbTipoProd.Visible = false;
            btnFecharGvMaisVendidos.Visible = false;
            gvMaisVendidos.Visible = false;
        }

        private void atualizarGvProdMaisVendidos(String tipoProd)
        {
            pbTipoProd.Visible = true;
            lblTipoProduto.Visible = true;
            cmbTipoProd.Visible = true;
            gvMaisVendidos.Visible = true;
            btnFecharGvMaisVendidos.Visible = true;
            btnFecharGvMaisVendidos.BringToFront();
            gvMaisVendidos.DataSource = prodDAO.ProdutosMaisVendidos(tipoProd);

            gvMaisVendidos.Columns[0].HeaderText = "Produto";
            gvMaisVendidos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gvMaisVendidos.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            gvMaisVendidos.Columns[1].HeaderText = "Quantidade Vendida";
            gvMaisVendidos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gvMaisVendidos.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            for (int i = 0; i < gvMaisVendidos.Rows.Count; i++)
            {
                gvMaisVendidos.Rows[i].Height = 60;
            }
        }

        private void btnEspetosMaisVendidos_Click(object sender, EventArgs e)
        {
            try
            {
                pbTipoProd.Visible = true;
                lblTipoProduto.Visible = true;
                cmbTipoProd.Visible = true;
                gvMaisVendidos.Visible = true;
                btnFecharGvMaisVendidos.Visible = true;
                atualizarGvProdMaisVendidos("ESPETOS");
                cmbTipoProd.SelectedIndex = 0;
            }
            catch { }
        }

        private void btnBebidasMaisVendidas_Click(object sender, EventArgs e)
        {
            try
            {
                pbTipoProd.Visible = true;
                lblTipoProduto.Visible = true;
                cmbTipoProd.Visible = true;
                gvMaisVendidos.Visible = true;
                btnFecharGvMaisVendidos.Visible = true;
                atualizarGvProdMaisVendidos("BEBIDAS");
                cmbTipoProd.SelectedIndex = 1;
            }
            catch { }
        }

        private void btnCervejasMaisVendidas_Click(object sender, EventArgs e)
        {
            try
            {
                pbTipoProd.Visible = true;
                lblTipoProduto.Visible = true;
                cmbTipoProd.Visible = true;
                gvMaisVendidos.Visible = true;
                btnFecharGvMaisVendidos.Visible = true;
                atualizarGvProdMaisVendidos("CERVEJAS");
                cmbTipoProd.SelectedIndex = 2;
            }
            catch { }
        }

        private void cmbTipoProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoProd.SelectedIndex == 0)
            {
                atualizarGvProdMaisVendidos("ESPETOS");
            }
            if (cmbTipoProd.SelectedIndex == 1)
            {
                atualizarGvProdMaisVendidos("BEBIDAS");
            }
            if (cmbTipoProd.SelectedIndex == 2)
            {
                atualizarGvProdMaisVendidos("CERVEJAS");
            }
        }
        #endregion

        #region Calculadora
        double acumula = 0;
        string operacao = "";

        private void btnApagarTudoCalc_Click(object sender, EventArgs e)
        {
            try
            {
                acumula = 0;
                txtDisplay.Text = "";
            }
            catch { }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            try
            {
                txtDisplay.Text = "";
                operacao = "";
            }
            catch { }
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            try
            {
                txtDisplay.Text += "0";
            }
            catch { }
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            try
            {
                txtDisplay.Text += "1";
            }
            catch { }
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            try
            {
                txtDisplay.Text += "2";
            }
            catch { }
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            try
            {
                txtDisplay.Text += "3";
            }
            catch { }
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            try
            {
                txtDisplay.Text += "4";
            }
            catch { }
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            try
            {
                txtDisplay.Text += "5";
            }
            catch { }
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            try
            {
                txtDisplay.Text += "6";
            }
            catch { }
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            try
            {
                txtDisplay.Text += "7";
            }
            catch { }
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            try
            {
                txtDisplay.Text += "8";
            }
            catch { }
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            try
            {
                txtDisplay.Text += "9";
            }
            catch { }
        }

        private void btnExcluirCalc_Click(object sender, EventArgs e)
        {
            try
            {
                int x = txtDisplay.Text.Length - 1;
                if (x >= 0)
                {
                    txtDisplay.Text = txtDisplay.Text.Substring(0, x);
                }
            }
            catch { }
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            try
            {
                txtDisplay.Text += ",";
            }
            catch { }
        }

        private void btnSomarCalc_Click(object sender, EventArgs e)
        {
            try
            {
                if (operacao == "*" || operacao == "-" || operacao == "/")
                {
                    operacao = "+";
                }
                else
                {
                    acumula += double.Parse(txtDisplay.Text);
                    txtDisplay.Text = "";
                    operacao = "+";
                }
            }
            catch { }
        }

        private void btnSubtrairCalc_Click(object sender, EventArgs e)
        {
            try
            {
                if (operacao == "*" || operacao == "+" || operacao == "/")
                {
                    operacao = "-";
                }
                else
                {
                    acumula = double.Parse(txtDisplay.Text);
                    txtDisplay.Text = "";
                    operacao = "-";
                }
            }
            catch { }
        }

        private void btnMultiplicarCalc_Click(object sender, EventArgs e)
        {
            try
            {
                if (operacao == "-" || operacao == "+" || operacao == "/")
                {
                    operacao = "*";
                }
                else
                {
                    acumula = double.Parse(txtDisplay.Text);
                    txtDisplay.Text = "";
                    operacao = "*";
                }
            }
            catch { }
        }

        private void btnDividirCalc_Click(object sender, EventArgs e)
        {
            try
            {
                if (operacao == "*" || operacao == "+" || operacao == "-")
                {
                    operacao = "/";
                }
                else
                {
                    acumula = double.Parse(txtDisplay.Text);
                    txtDisplay.Text = "";
                    operacao = "/";
                }
            }
            catch { }
        }

        private void btnResultadoCalc_Click(object sender, EventArgs e)
        {
            try
            {
                if (operacao == "+")
                {
                    acumula += double.Parse(txtDisplay.Text);
                    txtDisplay.Text = acumula.ToString();
                }
                else if (operacao == "-")
                {
                    acumula -= double.Parse(txtDisplay.Text);
                    txtDisplay.Text = acumula.ToString();
                }
                else if (operacao == "*")
                {
                    acumula *= double.Parse(txtDisplay.Text);
                    txtDisplay.Text = acumula.ToString();
                }
                else if (operacao == "/")
                {
                    if (double.Parse(txtDisplay.Text) != 0)
                    {
                        acumula /= double.Parse(txtDisplay.Text);
                        txtDisplay.Text = acumula.ToString();
                    }
                    else
                    {
                        txtDisplay.Text = "Dividindo por zero";
                    }
                }
            }
            catch { }
        }
        #endregion

        #region LogOff
        private void btnLogoff_Click(object sender, EventArgs e)
        {
            pnlLogin.Enabled = true;
            pnlLogin.Visible = true;
            pnlLogin.BringToFront();
            limparTudoLogin();
            contMenu = 0;
            contMenuCaixaTotal = 0;
            contProdMaisVendidosBEBIDAS = 0;
            contProdMaisVendidosCERVEJAS = 0;
            contProdMaisVendidosESPETOS = 0;
            pnlAddValorCaixa.Visible = false;
            pnlCalculadora.Visible = false;
            pnlMenu.Visible = false;
            gvExibirPedidos.Visible = false;
            gvMaisVendidos.Visible = false;
            grpCaixaTotalPorTempo.Visible = false;
            lblTitulo.Visible = false;
            lblNomeUsuAtivo.Text = "Nenhum   ";
            lblNomeUsuAtivo.Image = imgNomeUsuAtivoErro;
            lblNomeUsuAtivo.ForeColor = Color.Red;
            lblNomeUsuAtivo.Enabled = false;
            pbFotoUsuario.Visible = false;
        }
        #endregion

        private void btnDesligarProg_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Redirecionamento para as Telas
        private void btnAuditoria_Click(object sender, EventArgs e)
        {
            if (Dados.Permissao == "ADMIN")
            {
                frmAuditoria telaAuditoria = new frmAuditoria();
                telaAuditoria.ShowDialog();
            }
            else
            {
                MessageBox.Show("Você não possui permissões suficientes para acessar a Auditoria!", "Sem permissão!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnRegPedido_Click(object sender, EventArgs e)
        {
            frmCaixa telaCaixa = new frmCaixa(lblNomeUsuAtivo.Text);
            telaCaixa.ShowDialog();
        }

        private void btnGraficos_Click(object sender, EventArgs e)
        {
            frmAnaliseVendas telaAnalise = new frmAnaliseVendas(lblNomeUsuAtivo.Text);
            telaAnalise.ShowDialog();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            if (Dados.Permissao == "ADMIN" || Dados.Permissao == "FUNCIONARIO")
            {
                frmControleEstoque telaEstoque = new frmControleEstoque(lblNomeUsuAtivo.Text);
                telaEstoque.ShowDialog();
            }
            else
            {
                MessageBox.Show("Você não possui permissões para acessar o módulo Controle de Estoque!", "SEM PERMISSÃO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmGerenciarCliente telaClientes = new frmGerenciarCliente();
            telaClientes.ShowDialog();
        }


        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            frmGerenciarFuncionario telaFunc = new frmGerenciarFuncionario();
            telaFunc.ShowDialog();
        }

        private void btnFinancas_Click(object sender, EventArgs e)
        {
            frmFinancas telaFin = new frmFinancas();
            telaFin.ShowDialog();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            frmControleDeFornecedor telaForn = new frmControleDeFornecedor(lblNomeUsuAtivo.Text);
            telaForn.ShowDialog();
        }
        #endregion

        #region Usuario Label
        private void lblNomeUsuAtivo_MouseHover(object sender, EventArgs e)
        {
            float tamanhoFonte;
            tamanhoFonte = 15.75F;
            lblNomeUsuAtivo.Font = new Font("Segoe UI Semibold", tamanhoFonte, FontStyle.Underline);
        }

        private void lblNomeUsuAtivo_MouseLeave(object sender, EventArgs e)
        {
            float tamanhoFonte;
            tamanhoFonte = 15.75F;
            lblNomeUsuAtivo.Font = new Font("Segoe UI Semibold", tamanhoFonte);
        }

        private void lblNomeUsuAtivo_Click(object sender, EventArgs e)
        {
            frmGerenciarUsuario telaGerenciarUsu = new frmGerenciarUsuario(lblNomeUsuAtivo.Text);
            telaGerenciarUsu.ShowDialog();
            if (telaGerenciarUsu.btnFechar.Visible == false)
            {
                // PAINEL DE DADOS //
                lblUsuarios.Text = usuDAO.quantidadeTotalUsuario().ToString();
                if (lblNomeUsuAtivo.ForeColor == Color.LawnGreen)
                {
                    lblConectado.Text = "SIM";
                    lblConectado.ForeColor = Color.LawnGreen;
                }
                else
                {
                    lblConectado.Text = "NÃO";
                    lblConectado.ForeColor = Color.Tomato;
                }
                // ============== //
                // CARREGAR INFOS DO USUÁRIO //    
                lblBemVindo.Text = "Bem-vindo Sr(a), " + telaGerenciarUsu.nomeUsuario + "!";
                pbFotoUsuario.Visible = true;
                pbFotoUsuario.ImageLocation = usuDAO.UsuarioPorNome(telaGerenciarUsu.nomeUsuario).Foto_usu;
                lblNomeUsuAtivo.ForeColor = Color.LawnGreen;
                lblNomeUsuAtivo.Text = txtUsuario.Text + "   ";
                Dados.IdUsu = usuDAO.UsuarioPorNome(telaGerenciarUsu.nomeUsuario).Id_usu;
                lblNomeUsuAtivo.Image = imgNomeUsuAtivoVerificado;
                lblNomeUsuAtivo.Enabled = true;
                pnlLogin.Visible = false;
                btnAbrirMenu.Enabled = true;
                lblTitulo.Visible = true;
                // VERIFICAR PERMISSAO USUARIO //
                Dados.Permissao = usuDAO.permissao(telaGerenciarUsu.nomeUsuario);
                // ============== //
            }
        }
        #endregion

        #region Panel Add Valor
        private static bool valorValido(string texto)
        {
            bool eNumero = false;
            bool todosSaoNumeros = false;
            for (int i = 0; i < texto.Length; i++)
            {
                eNumero = Char.IsDigit(texto, i);
                if (eNumero != true)
                {
                    todosSaoNumeros = false;
                    return false;
                }
                else
                {
                    todosSaoNumeros = true;
                }
            }
            if (todosSaoNumeros == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnLancarValor_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInserirValor.Text == String.Empty)
                {
                    txtInserirValor.BackColor = Color.Red;
                    MessageBox.Show("Digite um valor válido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (valorValido(txtInserirValor.Text) == false)
                    {
                        txtInserirValor.Text = String.Empty;
                        MessageBox.Show("Digite um valor válido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (Convert.ToDouble(txtInserirValor.Text) <= 0)
                        {
                            txtInserirValor.Text = String.Empty;
                            MessageBox.Show("Digite um valor válido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            fin.Valor_fin = Convert.ToDouble(txtInserirValor.Text);
                            fin.Data_fin = Convert.ToDateTime(DateTime.Now);
                            fin.Obs_fin = "Valor lançado";

                            finDAO.inserirEntradas(fin);

                            txtInserirValor.Text = "";
                            pnlAddValorCaixa.Visible = false;

                            // Atualiza Caixa do Dia
                            grpCaixaTotalPorTempo.Text = "Caixa do Dia";
                            DateTime dataHoje;
                            dataHoje = DateTime.Now;

                            valorEmCaixa = finDAO.valorCaixaDia(dataHoje);
                            lblValorCaixa.Text = "R$ " + Convert.ToDouble(valorEmCaixa).ToString("#0.00");

                            MessageBox.Show("Valor lançado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch { }
        }

        private void txtInserirValor_TextChanged(object sender, EventArgs e)
        {
            txtInserirValor.BackColor = Color.Empty;
        }

        private void btnAddValor_Click(object sender, EventArgs e)
        {
            pnlAddValorCaixa.BringToFront();
            txtInserirValor.Text = String.Empty;
            pnlAddValorCaixa.Visible = true;
        }

        private void btnFecharAddValor_Click(object sender, EventArgs e)
        {
            txtInserirValor.Text = String.Empty;
            pnlAddValorCaixa.Visible = false;
        }
        #endregion

        #region Ver Pedidos/Comandas
        private void gvExibirPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                frmVerProdutosComanda telaVerProdCom = new frmVerProdutosComanda(gvExibirPedidos.Rows[gvExibirPedidos.CurrentCell.RowIndex].Cells[0].Value.ToString());
                telaVerProdCom.ShowDialog();
            }
        }

        private void gvExibirPedidos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            atualizarGVPedidos();
            atualizarColunaBotao();
        }

        private void btnVerPedidos_Click(object sender, EventArgs e)
        {
            contVerPedido++;

            if (contVerPedido % 2 != 0)
            {
                //ÍMPAR
                gvExibirPedidos.Visible = true;
                btnFecharGvVerPedidos.Visible = true;
                btnFecharGvVerPedidos.BringToFront();
                gvExibirPedidos.Columns.Clear();
                gvExibirPedidos.DataSource = comDAO.listarComanda();
                atualizarGVPedidos();
                atualizarColunaBotao();
            }
            else
            {
                // PAR
                btnFecharGvVerPedidos.Visible = false;
                gvExibirPedidos.Visible = false;
            }
        }

        private void gvExibirPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idCom, idFunc, idCli, idPagto;
            double valor;
            DateTime data, hora;

            idCom = Convert.ToInt32(gvExibirPedidos.Rows[gvExibirPedidos.CurrentCell.RowIndex].Cells[0].Value.ToString());
            idCli = comDAO.buscarComandaPorID(Convert.ToInt32(gvExibirPedidos.Rows[gvExibirPedidos.CurrentCell.RowIndex].Cells[0].Value.ToString())).Id_cli;
            idFunc = comDAO.buscarComandaPorID(Convert.ToInt32(gvExibirPedidos.Rows[gvExibirPedidos.CurrentCell.RowIndex].Cells[0].Value.ToString())).Id_func;
            idPagto = comDAO.buscarComandaPorID(Convert.ToInt32(gvExibirPedidos.Rows[gvExibirPedidos.CurrentCell.RowIndex].Cells[0].Value.ToString())).Id_pagto;
            valor = Convert.ToDouble(gvExibirPedidos.Rows[gvExibirPedidos.CurrentCell.RowIndex].Cells[2].Value.ToString().TrimStart("R$ ".ToCharArray()));
            data = Convert.ToDateTime(gvExibirPedidos.Rows[gvExibirPedidos.CurrentCell.RowIndex].Cells[3].Value.ToString());
            hora = Convert.ToDateTime(gvExibirPedidos.Rows[gvExibirPedidos.CurrentCell.RowIndex].Cells[4].Value.ToString());
            frmGerenciarPedidos telaGerenciarPed = new frmGerenciarPedidos
                (idCom, idCli, idFunc, idPagto, valor, data, hora);
            telaGerenciarPed.ShowDialog();
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
                gvExibirPedidos.Columns.Add(colunaBotao);
                colunaBotao.HeaderText = "Ver Produtos";
                colunaBotao.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch { }
        }

        private void atualizarColunaBotao()
        {
            try
            {
                for (int i = 0; i < gvExibirPedidos.Rows.Count; i++)
                {
                    gvExibirPedidos.Rows[i].Cells[5].Value = "Produtos ...";
                    gvExibirPedidos.Rows[i].Height = 60;
                }
            }
            catch { }
        }

        private void btnFecharGvVerPedidos1_Click(object sender, EventArgs e)
        {
            contVerPedido++;
            btnFecharGvVerPedidos.Visible = false;
            gvExibirPedidos.Visible = false;
        }
        #endregion

        #region Redirecionamento das Redes Sociais
        private void btnInstagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/aestacaodoespetinho/");
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/aestacaodoespetinho/?ti=as");
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Atualizar
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Visible == false)
            {
                btnAbrirMenu.PerformClick();
            }
            if (grpCaixaTotalPorTempo.Visible == false)
            {
                btnCaixaTotalPorTempo.PerformClick();
            }
            else
            {
                btnCaixaTotalPorTempo.PerformClick();
                btnCaixaTotalPorTempo.PerformClick();
            }
            if (gvMaisVendidos.Visible == false)
            {
                btnEspetosMaisVendidos.PerformClick();
            }
            else
            {
                btnEspetosMaisVendidos.PerformClick();
                btnEspetosMaisVendidos.PerformClick();
            }
            if (gvExibirPedidos.Visible == false)
            {
                btnVerPedidos.PerformClick();
            }
            else
            {
                btnVerPedidos.PerformClick();
                btnVerPedidos.PerformClick();
            }
        }
        #endregion

        #region Fechar Aplicação
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}