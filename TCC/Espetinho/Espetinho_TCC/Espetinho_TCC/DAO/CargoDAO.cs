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
    class CargoDAO
    {
        Cargo cargo = new Cargo();

        MySqlDataAdapter comando_sql;
        MySqlCommandBuilder executar_comando;
        DataTable tabela_memoria;

        internal Cargo Cargo { get => cargo; set => cargo = value; }

        private void executarComando(string comando)
        {
            tabela_memoria = new DataTable();

            comando_sql = new MySqlDataAdapter(comando, Conexao.Conectar);

            executar_comando = new MySqlCommandBuilder(comando_sql);

            comando_sql.Fill(tabela_memoria);
        }

        public DataTable listarCargo()
        {
            executarComando("select*from cargo;");
            return tabela_memoria;
        }

        public void inserirCargo(Cargo cargo)
        {
            executarComando("insert into cargo values(0,'"+ cargo.Tipo_cargo+"',0)");
        }
    }
}
