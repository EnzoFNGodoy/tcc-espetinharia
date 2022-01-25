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
    class TipoProdutoDAO
    {
        TipoProduto tipoprod = new TipoProduto();

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

        public DataTable listarTipoProd()
        {
            executarComando("select * from tipo_produto;");
            return tabela_memoria;
        }

        public void inserirTipoProd(TipoProduto tipoprod)
        {
            executarComando("insert into tipo_produto values (0,'" + tipoprod.Tipo_produto.ToString() + "',0);");
        }
    }
}
