using Espetinho_TCC.Model;
using Espetinho_TCC.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espetinho_TCC.DAO
{
    class AuditoriaDAO
    {
        Auditoria aud = new Auditoria();

        MySqlDataAdapter comando_sql;
        MySqlCommandBuilder executar_comando;
        DataTable tabela_memoria;

        internal Auditoria Aud { get => aud; set => aud = value; }

        private void executarComando(string comando)
        {
            tabela_memoria = new DataTable();

            comando_sql = new MySqlDataAdapter(comando, Conexao.Conectar);

            executar_comando = new MySqlCommandBuilder(comando_sql);

            comando_sql.Fill(tabela_memoria);
        }

        public DataTable listarAuditoria()
        {
            executarComando("select*from auditoria order by data_aud asc;");
            return tabela_memoria;
        }

        public DataTable listarAuditoriaData(DateTime data)
        {
            executarComando("select*from auditoria where data_aud = '"+ data.ToString("yyyy/MM/dd")+ "';");
            return tabela_memoria;
        }

        public DataTable listarAuditoriaTabela(DateTime data, String nomeTabela)
        {
            executarComando("select*from auditoria where data_aud = '" + data.ToString("yyyy/MM/dd") + "' and tabela_aud='"+nomeTabela+"';");
            return tabela_memoria;
        }

        public DataTable listarAuditoriaAcao(DateTime data, String Acao)
        {
            executarComando("select*from auditoria where data_aud = '" + data.ToString("yyyy/MM/dd") + "' and acao_aud='" + Acao + "';");
            return tabela_memoria;
        }

        public DataTable listarAuditoriaTabelaAcao(DateTime data, String nomeTabela, String Acao)
        {
            executarComando("select*from auditoria where data_aud = '" + data.ToString("yyyy/MM/dd") + "' and tabela_aud='" + nomeTabela + "' and acao_aud='" + Acao + "';");
            return tabela_memoria;
        }

    }
}
