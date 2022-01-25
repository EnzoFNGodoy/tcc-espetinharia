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
using Espetinho_TCC.Model;
using System.Net.Mail;
using Espetinho_TCC.Utils;

namespace Espetinho_TCC.Apresentação
{
    public partial class frmRecSenha : Form
    {
        #region Instâncias
        Usuario usu = new Usuario();
        UsuarioDAO usuDAO = new UsuarioDAO();
        Criptografia cripto = new Criptografia("@!ESPETINHO123");
        #endregion

        #region Carregar Tela
        public frmRecSenha()
        {
            InitializeComponent();
        }
        #endregion

        #region Método Limpar
        public void limparCampos()
        {
            txtUsuario.Text = "";
            txtEmail.Text = "";
        }
        #endregion

        #region Método para Gerar Senha Aleatória
        public static string gerarSenha(int tamanho)
        {
            var caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            var random = new Random();
            var senhaNova = new string(Enumerable.Repeat(caracteres, tamanho).Select(s => s[random.Next(s.Length)]).ToArray());

            return senhaNova;
        }
        #endregion

        #region Recuperar Senha
        private void btnOK_Click(object sender, EventArgs e)
        {
            String senhaNova = gerarSenha(8).ToString();

            if (txtEmail.Text == String.Empty ||
                txtUsuario.Text == String.Empty)
            {
                if (txtEmail.Text == String.Empty)
                {
                    txtEmail.BackColor = Color.Tomato;
                }
                if (txtUsuario.Text == String.Empty)
                {
                    txtUsuario.BackColor = Color.Tomato;
                }

                MessageBox.Show("Favor preencher os campos em vermelho!", "Campos Vazios!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (usuDAO.pesqUsuPorNome(txtUsuario.Text) == true)
                {
                    MailMessage email = new MailMessage();
                    email.To.Add(new MailAddress(txtEmail.Text));
                    email.From = new MailAddress("EstacaoEspeto@outlook.com");
                    email.Subject = "Alteração de Senha - Concluída";
                    email.IsBodyHtml = true;
                    email.Body = "Caro Sr(a) " + txtUsuario.Text + ", sua nova senha é " + senhaNova;
                    SmtpClient cliente = new SmtpClient("smtp.office365.com", 587);
                    try
                    {
                        using (cliente)
                        {
                            cliente.Credentials = new System.Net.NetworkCredential("EstacaoEspeto@outlook.com", "espetodoseuZE123");
                            cliente.EnableSsl = true;
                            cliente.Send(email);
                        }
                        usuDAO.alterarSenha(usuDAO.Usu.Id_usu, cripto.Encrypt(senhaNova));
                        MessageBox.Show("A sua nova senha foi enviada! Verifique seu email!", "RECUPERAR SENHA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("O Email não pode ser enviado:" + ex.Message, "Informações incorretas!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void frmRecSenha_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:

                    MessageBox.Show("A sua nova senha é : " + gerarSenha(8).ToString() + "!", "RECUPERAR SENHA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (usuDAO.pesqUsuPorNome(txtUsuario.Text) == true)
                    {
                        MailMessage email = new MailMessage();
                        email.To.Add(new MailAddress(txtEmail.Text));
                        email.From = new MailAddress("EstacaoEspeto@outlook.com");
                        email.Subject = "Alteração de Senha - Concluída";
                        email.IsBodyHtml = true;
                        email.Body = "Caro Sr(a) " + txtUsuario.Text + ", sua nova senha é " + gerarSenha(8).ToString();
                        SmtpClient cliente = new SmtpClient("smtp.office365.com", 587);
                        try
                        {
                            using (cliente)
                            {
                                cliente.Credentials = new System.Net.NetworkCredential("EstacaoEspeto@outlook.com", "espetodoseuZE123");
                                cliente.EnableSsl = true;
                                cliente.Send(email);
                            }
                            usuDAO.alterarSenha(usu.Id_usu, gerarSenha(8));
                            MessageBox.Show("Sucesso ao enviar a nova senha!", "Verifique seu email!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Usuário ou email não existe!", "Informações incorretas!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        #endregion

        #region Descolorir Campos
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.BackColor = Color.Empty;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            txtUsuario.BackColor = Color.Empty;
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
