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
    class PedidosFornDAO
    {
        double valor;

        PedidosForn pedidosforn = new PedidosForn();
        Fornecedor forn = new Fornecedor();

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

        public DataTable listarPedidos()
        {
            executarComando("select p.id_ped, f.nome_forn, p.valor_ped, p.data_ped, p.hora_ped from pedidos_forn p inner join fornecedor f on p.id_forn = f.id_forn where status_ped=0 order by p.id_ped asc;");
            return tabela_memoria;
        }

        public DataTable listarPedidosPorId(int id)
        {
            executarComando("select p.id_ped, f.nome_forn, p.valor_ped, p.data_ped, p.hora_ped from pedidos_forn p inner join fornecedor f on p.id_forn = f.id_forn where id_ped = " + id + " where status_ped=0 order by p.id_ped asc;");
            return tabela_memoria;
        }

        public DataTable listarPedidosPorForn(string forn)
        {
            executarComando("select p.id_ped, f.nome_forn, p.valor_ped, p.data_ped, p.hora_ped from pedidos_forn p inner join fornecedor f on p.id_forn = f.id_forn where nome_forn like '%" + forn + "%' where status_ped=0 order by f.nome_forn asc;");
            return tabela_memoria;
        }

        public DataTable listarPedidosPorValor(string comando)
        {
            executarComando("select p.id_ped, f.nome_forn, p.valor_ped, p.data_ped, p.hora_ped from pedidos_forn p inner join fornecedor f on p.id_forn = f.id_forn where " + comando + " order by p.id_ped asc where status_ped=0 order by p.valor_ped asc;");
            return tabela_memoria;
        }

        public void inserirPedido(PedidosForn pedForn)
        {
            executarComando("insert into pedidos_forn values(0, " + pedForn.Id_forn + ", " + pedForn.Valor_ped.ToString().Replace(',', '.') + ", '" + pedForn.Data_ped.ToString("yyyy/MM/dd") + "', '" + pedForn.Hora_ped.ToString("HH:mm") + "',0);");
        }

        public void alterarPedido(int id, PedidosForn pedForn)
        {
            executarComando("update pedidos_forn set id_forn='"+ pedForn .Id_forn+ "', valor_ped='"+pedForn.Valor_ped.ToString().Replace(',','.')+"', data_ped='"+ pedForn.Data_ped.ToString("yyyy/MM/dd") + "', hora_ped='"+ pedForn.Hora_ped.ToString("HH:mm") + "' where id_ped='" + id + "';");
        }

        public void excluirPedido(int id)
        {
            executarComando("update pedidos_forn set status_ped=1 where id_ped='"+id+"';");
        }

        public int ultimoID()
        {
            executarComando("select max(id_ped) as id from pedidos_forn;");
            return Convert.ToInt32(tabela_memoria.Rows[0]["id"].ToString());
        }
    }
}
