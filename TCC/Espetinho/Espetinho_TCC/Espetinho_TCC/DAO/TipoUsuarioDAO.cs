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
    class TipoUsuarioDAO
    {
        TipoUsuario tipoUsu = new TipoUsuario();
        MySqlDataAdapter comando_sql;
        MySqlCommandBuilder executar_comando;
        DataTable tabela_memoria;
        internal TipoUsuario TipoUsu { get => tipoUsu; set => tipoUsu = value; }

        private void executarComando(string comando)
        {
            tabela_memoria = new DataTable();

            comando_sql = new MySqlDataAdapter(comando, Conexao.Conectar);

            executar_comando = new MySqlCommandBuilder(comando_sql);

            comando_sql.Fill(tabela_memoria);
        }

        public void inserirTipoUsuario(TipoUsuario tipoUsu)
        {
            executarComando("insert into tipo_usuario values (0,'" + tipoUsu.Tipo_usu + "',0);");
        }

        public DataTable listarPerfilUsuario()
        {
            executarComando("select*from tipo_usuario;");
            return tabela_memoria;
        }

        public TipoUsuario getTipoUsuById(int id)
        {
            executarComando("select * from tipo_usuario where id_tipousu = '" + id + "';");
            tipoUsu.Id_tipousu = id;
            tipoUsu.Tipo_usu = tabela_memoria.Rows[0]["tipo_usu"].ToString();
            return tipoUsu;
        }

        public void verificarTipoUsuPorNomeUsu(string nomeUsu)
        {
            executarComando("select t.id_tipousu, t.tipo_usu from tipo_usuario t inner join usuario u on t.id_tipousu = u.id_tipousu where u.nome_usu = '" +nomeUsu + "';");
            TipoUsu.Id_tipousu = Convert.ToInt32(tabela_memoria.Rows[0]["id_tipousu"].ToString());
            TipoUsu.Tipo_usu = tabela_memoria.Rows[0]["tipo_usu"].ToString();
        }
    }
}
