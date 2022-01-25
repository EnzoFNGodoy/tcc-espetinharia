using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Espetinho_TCC.Model;
using Espetinho_TCC.Utils;
using MySql.Data.MySqlClient;

namespace Espetinho_TCC.DAO
{
    class UsuarioDAO
    {
        Usuario usu = new Usuario();
        TipoUsuario tipoUsu = new TipoUsuario();

        Criptografia cripto = new Criptografia("@!ESPETINHO123");

        MySqlDataAdapter comando_sql;
        MySqlCommandBuilder executar_comando;
        DataTable tabela_memoria;

        internal Usuario Usu { get => usu; set => usu = value; }
        internal TipoUsuario TipoUsu { get => tipoUsu; set => tipoUsu = value; }

        private void executarComando(string comando)
        {
            tabela_memoria = new DataTable();

            comando_sql = new MySqlDataAdapter(comando, Conexao.Conectar);

            executar_comando = new MySqlCommandBuilder(comando_sql);

            comando_sql.Fill(tabela_memoria);
        }

        public DataTable listarUsuarios()
        {
            executarComando("select u.id_usu, t.tipo_usu, u.nome_usu, u.senha_usu, u.foto_usu from usuario u inner join tipo_usuario t on u.id_tipousu = t.id_tipousu where status_usu=0 order by id_usu asc;");
            return tabela_memoria;
        }

        public void inserirUsuario(Usuario usu)
        {
            executarComando("insert into usuario values (0,'" + usu.Id_tipousu + "','" + usu.Nome_usu + "','" + usu.Senha_usu + "','" + usu.Foto_usu + "',0);");
        }

        public DataTable listarPerfilUsuario()
        {
            executarComando("select*from tipo_usuario;");
            return tabela_memoria;
        }

        public DataTable pesquisarPorNomeGV(string nomeUsuario)
        {
            executarComando("select u.id_usu, t.tipo_usu, u.nome_usu, u.senha_usu, u.foto_usu from usuario u inner join tipo_usuario t on u.id_tipousu = t.id_tipousu where u.nome_usu like '%" + nomeUsuario + "%' and where status_usu=0 order by id_usu asc;");
            return tabela_memoria;
        }

        public Boolean loginUsuario(String nome, String senha)
        {
            try
            {
                executarComando("select*from usuario where nome_usu='" + nome + "' and senha_usu='" + senha + "';");

                Usu.Id_tipousu = Convert.ToInt32(tabela_memoria.Rows[0]["id_tipousu"].ToString());
                Usu.Nome_usu = tabela_memoria.Rows[0]["nome_usu"].ToString();
                Usu.Foto_usu = tabela_memoria.Rows[0]["foto_usu"].ToString();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public void alterarSenha(int id, String senhaNova)
        {
            executarComando("update usuario set senha_usu='" + senhaNova + "' where id_usu='" + id + "';");
        }

        public Usuario UsuarioPorId(int id)
        {
            executarComando("select * from usuario where id_usu = '" + id + "';");
            Usu.Id_usu = id;
            Usu.Id_tipousu = Convert.ToInt32(tabela_memoria.Rows[0]["id_tipousu"].ToString());
            Usu.Nome_usu = tabela_memoria.Rows[0]["nome_usu"].ToString();
            Usu.Senha_usu = tabela_memoria.Rows[0]["senha_usu"].ToString();
            Usu.Foto_usu = tabela_memoria.Rows[0]["foto_usu"].ToString();
            return Usu;
        }

        public Boolean pesqUsuPorNome(String usuario)
        {
            try
            {
                executarComando("select * from usuario where nome_usu = '" + usuario + "';");

                Usu.Id_usu = Convert.ToInt32(tabela_memoria.Rows[0]["id_usu"].ToString());
                Usu.Id_tipousu = Convert.ToInt32(tabela_memoria.Rows[0]["id_tipousu"].ToString());
                Usu.Nome_usu = tabela_memoria.Rows[0]["nome_usu"].ToString();
                Usu.Senha_usu = tabela_memoria.Rows[0]["senha_usu"].ToString();
                Usu.Foto_usu = tabela_memoria.Rows[0]["foto_usu"].ToString();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void alterarUsuario(Usuario usu, int id)
        {
            executarComando("update usuario set id_tipousu='" + usu.Id_tipousu.ToString() + "', nome_usu='" + usu.Nome_usu.ToString() + "', foto_usu='" + usu.Foto_usu.ToString() + "' where id_usu='" + id.ToString() + "'");
        }

        public void excluirUsuario(int id)
        {
            executarComando("update usuario set status_usu=1 where id_usu='" + id.ToString()  + "';"); 
        }

        public int buscarUltID()
        {
            executarComando("select max(id_usu) as id from usuario;");
            return Convert.ToInt32(tabela_memoria.Rows[0]["id"].ToString());
        }

        #region VERIFICAR PERMISSÃO
        public string permissao(string usuario)
        {
            executarComando("select t.tipo_usu from usuario u inner join tipo_usuario t on t.id_tipousu = u.id_tipousu where u.nome_usu = '" + usuario + "';");
            return tabela_memoria.Rows[0]["tipo_usu"].ToString();
        }
        #endregion

        public int quantidadeTotalUsuario()
        {
            executarComando("select count(id_usu) as qtd from usuario;");
            return Convert.ToInt32(tabela_memoria.Rows[0]["qtd"].ToString());
        }

        public Usuario UsuarioPorNome(string nomeUsu)
        {
            executarComando("select * from usuario where nome_usu = '" + nomeUsu + "';");
            Usu.Id_usu = Convert.ToInt32(tabela_memoria.Rows[0]["id_tipousu"].ToString());
            Usu.Id_tipousu = Convert.ToInt32(tabela_memoria.Rows[0]["id_tipousu"].ToString());
            Usu.Nome_usu = tabela_memoria.Rows[0]["nome_usu"].ToString();
            Usu.Senha_usu = tabela_memoria.Rows[0]["senha_usu"].ToString();
            Usu.Foto_usu = tabela_memoria.Rows[0]["foto_usu"].ToString();
            return Usu;
        }
    }
}

