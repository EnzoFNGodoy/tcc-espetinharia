using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Espetinho_TCC.Apresentação.Caixa
{
    public partial class frmAlterarItemCarrinho : Form
    {
        #region Carregar Tela
        public frmAlterarItemCarrinho(int QtdProd, double precoAtual)
        {
            InitializeComponent();
            txtQtdProd.Text = QtdProd.ToString();
            txtPrecoUnit.Text = "R$ " + (precoAtual / QtdProd).ToString("#0.00").Replace('.', ',');
            btnAlterar.Enabled = true;
            btnExcluirItem.Enabled = true;
        }

        private void frmAlterarItemCarrinho_Load(object sender, EventArgs e)
        {
            this.Size = new Size(586, 323);
            btnAlterar.Location = new Point(159, 225);
        }
        #endregion

        #region Painel Add Desconto 
        private void btnAddDesconto_Click(object sender, EventArgs e)
        {
            this.Size = new Size(586, 358);
            pnlAddDesconto.Visible = true;
            pnlAddDesconto.BringToFront();
        }

        private void btnFecharPnlAddDesc_Click(object sender, EventArgs e)
        {
            pnlAddDesconto.Visible = false;
            btnAlterar.Visible = true;
            btnAlterar.BringToFront();
        }

        private void btnAddDesc_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescEmRS.Text == String.Empty &&
                   txtDescEmPorcentagem.Text == String.Empty)
                {
                    if (txtDescEmRS.Text == String.Empty || txtDescEmRS.Text == "R$0,00")
                    {
                        txtDescEmRS.BackColor = Color.Red;
                    }
                    if (txtDescEmPorcentagem.Text == String.Empty)
                    {
                        txtDescEmPorcentagem.BackColor = Color.Red;
                    }

                    MessageBox.Show("Favor preencher os campos em vermelho!", "Campos vazios!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (txtDescEmPorcentagem.Text == String.Empty)
                    {
                        if (txtDescEmRS.Text == String.Empty)
                        {
                            txtDescEmPorcentagem.Clear();
                            txtDescEmRS.Clear();
                            MessageBox.Show("Digite um valor válido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            if (valorValido(Convert.ToDouble(txtDescEmRS.Text.TrimStart("R$ ".ToCharArray()).TrimEnd(",00".ToCharArray())).ToString()) == false && Convert.ToDouble(txtDescEmRS.Text.TrimStart("R$ ".ToCharArray()).TrimEnd(",00".ToCharArray())) > Convert.ToDouble(txtPrecoUnit.Text.TrimStart("R$ ".ToCharArray()).TrimEnd(",00".ToCharArray())))
                            {
                                txtDescEmRS.Clear();
                                MessageBox.Show("Desconto maior que o Valor Total ou valor inválido!", "Impossível realizar a ação!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                if (Convert.ToDouble(txtPrecoUnit.Text.TrimStart("R$ ".ToCharArray()).TrimEnd(",00".ToCharArray())) <= 0)
                                {
                                    txtDescEmPorcentagem.Clear();
                                    txtDescEmRS.Clear();
                                    MessageBox.Show("Digite um valor válido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                                else
                                {
                                    txtPrecoUnit.Text = "R$ " + (Convert.ToDouble(txtPrecoUnit.Text.TrimStart("R$ ".ToCharArray()).TrimEnd(",00".ToCharArray())) -
                                    (Convert.ToDouble(txtDescEmRS.Text.TrimStart("R$ ".ToCharArray()).TrimEnd(",00".ToCharArray())))).ToString("#0.00").Replace('.', ',');
                                }
                            }
                        }
                    }
                    else
                    {
                        if (valorValido(Convert.ToDouble(txtDescEmPorcentagem.Text.TrimStart("R$ ".ToCharArray()).TrimEnd(",00".ToCharArray())).ToString()) == false)
                        {
                            txtDescEmPorcentagem.Clear();
                            txtDescEmRS.Clear();
                            MessageBox.Show("Digite um valor válido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            if (Convert.ToDouble(txtDescEmPorcentagem.Text) <= 100 || Convert.ToDouble(txtDescEmPorcentagem.Text) > 0 && txtDescEmPorcentagem.Text != String.Empty)
                            {
                                txtPrecoUnit.Text = "R$ " + (Convert.ToDouble(txtPrecoUnit.Text.TrimStart("R$ ".ToCharArray())) -
                                 (Convert.ToDouble(txtPrecoUnit.Text.TrimStart("R$ ".ToCharArray()).TrimEnd(",00".ToCharArray())) *
                                 ((Convert.ToDouble(txtDescEmPorcentagem.Text)) / 100))).ToString("#0.00").Replace('.', ',');
                            }
                            else
                            {
                                txtDescEmPorcentagem.Clear();
                                txtDescEmRS.Clear();
                                MessageBox.Show("Digite um valor válido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }

                    txtDescEmPorcentagem.Text = "";
                    txtDescEmRS.Text = "";
                    txtDescEmPorcentagem.Enabled = true;
                    txtDescEmRS.Enabled = true;
                    pnlAddDesconto.Visible = false;
                    btnAlterar.Visible = true;
                    btnAlterar.SendToBack();
                }
            }
            catch { }
        }

        private void txtDescEmRS_Click(object sender, EventArgs e)
        {
            txtDescEmPorcentagem.Clear();
            txtDescEmRS.Enabled = true;
        }

        private void txtDescEmPorcentagem_Click(object sender, EventArgs e)
        {
            txtDescEmRS.Clear();
            txtDescEmPorcentagem.Enabled = true;
        }
        #endregion

        #region Aumentar e Diminuir Quantidades
        private void btnAumentarQtd_Click(object sender, EventArgs e)
        {
            try
            {
                txtQtdProd.Text = (Convert.ToInt32(txtQtdProd.Text) + 1).ToString();
                if (Convert.ToInt32(txtQtdProd.Text) != 0)
                {
                    if (Convert.ToInt32(txtQtdProd.Text) == 1)
                    {
                        btnDiminuirQtd.Enabled = false;
                    }
                    if (Convert.ToInt32(txtQtdProd.Text) < 1)
                    {
                        txtQtdProd.Text = (Convert.ToInt32(txtQtdProd.Text) + 1).ToString();
                        MessageBox.Show("Quantidade negativa ou igual a zero!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        btnDiminuirQtd.Enabled = true;
                    }
                }
            }
            catch { }
        }

        private void btnDiminuirQtd_Click(object sender, EventArgs e)
        {
            try
            {
                txtQtdProd.Text = (Convert.ToInt32(txtQtdProd.Text) - 1).ToString();
                if (Convert.ToInt32(txtQtdProd.Text) != 0)
                {
                    if (Convert.ToInt32(txtQtdProd.Text) == 1)
                    {
                        btnDiminuirQtd.Enabled = false;
                    }
                    if (Convert.ToInt32(txtQtdProd.Text) < 1)
                    {
                        txtQtdProd.Text = (Convert.ToInt32(txtQtdProd.Text) + 1).ToString();
                        MessageBox.Show("Quantidade negativa ou igual a zero!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        btnDiminuirQtd.Enabled = true;
                    }
                }
            }
            catch { }
        }
        #endregion

        #region Método Valor Valido
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
        #endregion

        #region Alterar Item
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPrecoUnit.Text == String.Empty || txtPrecoUnit.Text == "R$ 0,00")
                {
                    txtPrecoUnit.BackColor = Color.Red;
                    MessageBox.Show("Digite um valor válido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (valorValido(Convert.ToDouble(txtPrecoUnit.Text.TrimStart("R$ ".ToCharArray()).TrimEnd(",00".ToCharArray())).ToString()) == false)
                    {
                        txtPrecoUnit.Text = String.Empty;
                        MessageBox.Show("Digite um valor válido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (Convert.ToDouble(txtPrecoUnit.Text.TrimStart("R$ ".ToCharArray()).TrimEnd(",00".ToCharArray())) <= 0)
                        {
                            txtPrecoUnit.Text = String.Empty;
                            MessageBox.Show("Digite um valor válido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            Close();
                            btnAlterar.Enabled = false;
                        }
                    }
                }
            }
            catch { }
        }
        #endregion

        #region Excluir Item
        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
            Close();
            btnExcluirItem.Enabled = false;
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
