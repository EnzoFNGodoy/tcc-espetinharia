using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Espetinho_TCC.DAO;
using Espetinho_TCC.Model;
using Espetinho_TCC.Utils;

namespace Espetinho_TCC.Apresentação
{
    public partial class frmAlterarSenha : Form
    {
        UsuarioDAO usuDAO = new UsuarioDAO();
        Usuario usu = new Usuario();
        Criptografia cripto = new Criptografia("@!ESPETINHO123");

        int qtdMai, qtdMin;

        public frmAlterarSenha(string nomeUsu)
        {
            InitializeComponent();
            lblNomeUsuAtivo.Text = nomeUsu;
        }
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

        public void limparCampos()
        {
            txtEmail.Text = "";
            txtUsuario.Text = "";
            txtSenhaAtual.Text = "";
            txtSenhaNova.Text = "";
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            String senhaNova = txtSenhaNova.Text;

            if (txtSenhaAtual.Text == txtSenhaNova.Text)
            {
                txtSenhaAtual.BackColor = Color.Red;
                txtSenhaNova.BackColor = Color.Red;
                limparCampos();

                MessageBox.Show("A senha atual é igual à senha nova!", "!!! SENHAS IGUAIS !!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (usuDAO.loginUsuario(txtUsuario.Text, cripto.Encrypt(txtSenhaAtual.Text)) == false)
            {
                txtUsuario.BackColor = Color.Red;
                txtSenhaAtual.BackColor = Color.Red;
                limparCampos();

                MessageBox.Show("Usuário ou senha não correspondem!", "!!! DADOS INCORRETOS !!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (txtSenhaNova.TextLength < 5 || txtSenhaNova.TextLength > 8)
                {
                    MessageBox.Show("A senha deve conter entre 5 a 8 caractéres", "!!! DADOS INCORRETOS !!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    if (usuDAO.pesqUsuPorNome(txtUsuario.Text) == true)
                    {
                        if (lblForca.Text == "Senha Fraca")
                        {
                            MessageBox.Show("A senha deve atender a pelo menos dois dos requisitos listados.", "!!! DADOS INCORRETOS !!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            if (txtEmail.Text != String.Empty)
                            {
                                usuDAO.alterarSenha(Dados.IdUsu, cripto.Encrypt(txtSenhaNova.Text));

                                MailMessage email = new MailMessage();
                                email.To.Add(new MailAddress(txtEmail.Text));
                                email.From = new MailAddress("EstacaoEspeto@outlook.com");
                                email.Subject = "Alteração de Senha - Concluída";
                                email.IsBodyHtml = true;
                                email.Body = "Caro Sr(a) " + txtUsuario.Text + ", sua nova senha é " + senhaNova.ToString();
                                SmtpClient cliente = new SmtpClient("smtp.live.com", 587);
                                try
                                {
                                    using (cliente)
                                    {
                                        cliente.Credentials = new System.Net.NetworkCredential("EstacaoEspeto@outlook.com", "espetodoseuZE123");
                                        cliente.EnableSsl = true;
                                        cliente.Send(email);
                                    }

                                    limparCampos();
                                    MessageBox.Show("Senha alterada com sucesso!", "!!! SUCESSO !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Usuário ou email não existe!", "Informações incorretas!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                usuDAO.alterarSenha(Dados.IdUsu, cripto.Encrypt(txtSenhaNova.Text));

                                limparCampos();
                                MessageBox.Show("Senha alterada com sucesso!", "!!! SUCESSO !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuário não correpondente!", "!!! DADOS INCORRETOS !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsuario.BackColor = Color.Red;
                        limparCampos();
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void frmAlterarSenha_KeyDown(object sender, KeyEventArgs e)
        {
            String senhaNova = txtSenhaNova.Text;

            switch (e.KeyCode)
            {
                case Keys.Enter:

                    if (txtSenhaAtual.Text == txtSenhaNova.Text)
                    {
                        txtSenhaAtual.BackColor = Color.Red;
                        txtSenhaNova.BackColor = Color.Red;
                        limparCampos();

                        MessageBox.Show("A senha atual é igual à senha nova!", "!!! SENHAS IGUAIS !!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if (usuDAO.loginUsuario(txtUsuario.Text, cripto.Encrypt(txtSenhaAtual.Text)) == false)
                    {
                        txtUsuario.BackColor = Color.Red;
                        txtSenhaAtual.BackColor = Color.Red;
                        limparCampos();

                        MessageBox.Show("Usuário ou senha não correspondem!", "!!! DADOS INCORRETOS !!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (usuDAO.pesqUsuPorNome(txtUsuario.Text) == true)
                        {
                            usuDAO.alterarSenha(usu.Id_usu, cripto.Encrypt(txtSenhaNova.Text));

                            MessageBox.Show("Senha alterada com sucesso!", "!!! SUCESSO !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            MailMessage email = new MailMessage();
                            email.To.Add(new MailAddress(txtEmail.Text));
                            email.From = new MailAddress("EstacaoEspeto@outlook.com");
                            email.Subject = "Alteração de Senha - Concluída";
                            email.IsBodyHtml = true;
                            email.Body = "Caro Sr(a) " + txtUsuario.Text + ", sua nova senha é " + senhaNova.ToString();
                            SmtpClient cliente = new SmtpClient("smtp.live.com", 587);
                            try
                            {
                                using (cliente)
                                {
                                    cliente.Credentials = new System.Net.NetworkCredential("EstacaoEspeto@outlook.com", "estacaoespeto");
                                    cliente.EnableSsl = true;
                                    cliente.Send(email);
                                }
                                MessageBox.Show("Sucesso ao enviar a nova senha!", "Verifique seu email!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Usuário ou email não existe!", "Informações incorretas!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuário não correpondente!", "!!! DADOS INCORRETOS !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtUsuario.BackColor = Color.Red;
                            limparCampos();
                        }
                    }

                    break;

                case Keys.Escape:

                    this.Close();

                    break;

                case Keys.F12:

                    limparCampos();

                    break;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if(txtUsuario.Text != String.Empty)
            {
                txtUsuario.BackColor = Color.Empty;
            }
        }

        private void txtSenhaAtual_TextChanged(object sender, EventArgs e)
        {
            if (txtSenhaAtual.Text != String.Empty)
            {
                txtSenhaAtual.BackColor = Color.Empty;
            }
        }

        private void txtSenhaNova_TextChanged(object sender, EventArgs e)
        {
            if (txtSenhaNova.Text != String.Empty)
            {
                txtSenhaNova.BackColor = Color.Empty;
            }
            qtdMai = 0;
            qtdMin = 0;

            for (int i = 0; i < txtSenhaNova.Text.Length; i++)
            {
                if (char.IsUpper(txtSenhaNova.Text[i]))
                {
                    qtdMai++;
                }
                else
                {
                    if (char.IsLower(txtSenhaNova.Text[i]))
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


            if (carEspecial(txtSenhaNova.Text) == true)
            {
                chkListGerSenha.SetItemChecked(2, true);
            }
            else
            {
                chkListGerSenha.SetItemChecked(2, false);
            }
            //


            if (carNumerico(txtSenhaNova.Text) == true)
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
                    if (txtSenhaNova.Text == String.Empty)
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
    }
}
