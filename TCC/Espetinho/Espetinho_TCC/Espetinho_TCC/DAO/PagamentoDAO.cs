 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Espetinho_TCC.Model;
using Espetinho_TCC.Utils;
using MySql.Data.MySqlClient;
using System.Data;


namespace Espetinho_TCC.DAO
{
    class PagamentoDAO
    {
        Pagamento pag = new Pagamento();

        MySqlDataAdapter comando_sql;
        MySqlCommandBuilder executar_comando;
        DataTable tabela_memoria;

        private void executarComando(string comando)
        {
            tabela_memoria = new DataTable();

            comando_sql = new MySqlDataAdapter(comando, Conexao.Conectar);

            executar_comando = new MySqlCommandBuilder(comando_sql);

            comando_sql.Fill(tabela_memoria);
        }

        public DataTable listarPagamento()
        {
            executarComando("select * from pagamento;");
            return tabela_memoria;
        }

        public void inserirPagamento(Pagamento pag)
        {
            executarComando("insert into pagamento values (0,'" + pag.Tipo_pagto + "',0);");
        }

        public Pagamento pagtoPorID(int idPagto)
        {
            executarComando("select * from pagamento where id_pagto=" + idPagto + ";");

            pag.Id_pagto = idPagto;
            pag.Tipo_pagto = tabela_memoria.Rows[0]["tipo_pagto"].ToString();

            return pag;
        }
    }
}
