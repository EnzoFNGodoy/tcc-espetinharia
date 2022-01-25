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
    class EntradaEstoqueDAO
    {
        EntradaEstoque entradaEst = new EntradaEstoque();

        MySqlDataAdapter comando_sql;
        MySqlCommandBuilder executar_comando;
        DataTable tabela_memoria;

        internal EntradaEstoque EntradaEst { get => entradaEst; set => entradaEst = value; }

        private void executarComando(string comando)
        {
            tabela_memoria = new DataTable();

            comando_sql = new MySqlDataAdapter(comando, Conexao.Conectar);

            executar_comando = new MySqlCommandBuilder(comando_sql);

            comando_sql.Fill(tabela_memoria);
        }

        public DataTable listarEntradas()
        {
            executarComando("select entradaEstoque, dia, hora, concat('R$ ',    Replace   (Replace  (Replace  (Format(valorTotal, 2), '.', '|'), ',', '.'), '|', ',')) as valorTotal from (select e.id_entEst as entradaEstoque, e.data_entEst as dia, e.hora_entEst as hora, e.valor_entEst as valorTotal from entradaEstoque e inner join its_EntradaEstoque it on e.id_entEst = it.id_entEst group by e.id_entEst) as ItensVendidos;");
            return tabela_memoria;
        }

        public int verificarUltEntrada()
        {
            executarComando("select max(id_entEst) as ultID from entradaEstoque;");
            int ultId = Convert.ToInt32(tabela_memoria.Rows[0]["ultID"]);
            return ultId;
        }

        public void inserirEntEst(EntradaEstoque entEst)
        {
            executarComando("insert into entradaEstoque values('" + entEst.Id_entEst.ToString() + "','" + entEst.Data_entEst.ToString("yyyy/MM/dd") + "','" + entEst.Hora_entEst.ToString("HH:mm") + "','" + entEst.Valor_entEst.ToString().Replace(',', '.') + "','" + entEst.Obs_entEst.ToString() + "', '" + entradaEst.Id_fin + "',0);");
        }


        public DataTable pesquisarPorID(int id)
        {
            executarComando("select e.id_entEst, e.data_entEst, e.hora_entEst, it.qtd_itens, e.valor_entEst, e.obs_entEst from entradaEstoque e inner join its_EntradaEstoque it on e.id_entEst = it.id_entEst where e.id_entEst='" + id + "' group by e.id_entEst;");
            return tabela_memoria;
        }

        public DataTable pesquisarPorQtdEstoque(string comando)
        {
            executarComando("select e.id_entEst, e.data_entEst, e.hora_entEst, it.qtd_itens, e.valor_entEst, e.obs_entEst from entradaEstoque e inner join its_EntradaEstoque it on e.id_entEst = it.id_entEst where " + comando + " group by e.id_entEst;");
            return tabela_memoria;
        }

        public EntradaEstoque entradaPorID(int idEntEst)
        {
            executarComando("select*from entradaEstoque where id_entEst=" + idEntEst + ";");

            entradaEst.Id_entEst = idEntEst;
            entradaEst.Data_entEst = Convert.ToDateTime(tabela_memoria.Rows[0]["data_entEst"].ToString());
            entradaEst.Hora_entEst = Convert.ToDateTime(tabela_memoria.Rows[0]["hora_entEst"].ToString());
            entradaEst.Valor_entEst = Convert.ToDouble(tabela_memoria.Rows[0]["valor_entEst"].ToString());
            entradaEst.Obs_entEst = tabela_memoria.Rows[0]["obs_entEst"].ToString();

            return entradaEst;
        }

        public DataTable pesquisarPorIDGV(int id)
        {
            executarComando("select entradaEstoque, dia, hora, concat('R$ ',    Replace   (Replace  (Replace  (Format(valorTotal, 2), '.', '|'), ',', '.'), '|', ',')) as valorTotal from (select e.id_entEst as entradaEstoque, e.data_entEst as dia, e.hora_entEst as hora, e.valor_entEst as valorTotal from entradaEstoque e inner join its_EntradaEstoque it on e.id_entEst = it.id_entEst where e.id_entEst=" + id + " group by e.id_entEst) as ItensVendidos;");
            return tabela_memoria;
        }

        public DataTable pesquisarPorData(string dataInicio, string dataTermino)
        {
            executarComando("select entradaEstoque, dia, hora, concat('R$ ',    Replace   (Replace  (Replace  (Format(valorTotal, 2), '.', '|'), ',', '.'), '|', ',')) as valorTotal from (select e.id_entEst as entradaEstoque, e.data_entEst as dia, e.hora_entEst as hora, e.valor_entEst as valorTotal from entradaEstoque e inner join its_EntradaEstoque it on e.id_entEst = it.id_entEst where e.data_entEst between '" + Convert.ToDateTime(dataInicio).ToString("yyyy/MM/dd") + "' and '" + Convert.ToDateTime(dataTermino).ToString("yyyy/MM/dd") + "' group by e.id_entEst) as ItensVendidos;");
            return tabela_memoria;
        }

        public DataTable pesquisarPorValor(string comando)
        {
            executarComando("select entradaEstoque, dia, hora, concat('R$ ',    Replace   (Replace  (Replace  (Format(valorTotal, 2), '.', '|'), ',', '.'), '|', ',')) as valorTotal from (select e.id_entEst as entradaEstoque, e.data_entEst as dia, e.hora_entEst as hora, e.valor_entEst as valorTotal from entradaEstoque s inner join its_EntradaEstoque it on e.id_entEst = it.id_entEst where " + comando + " group by e.id_entEst) as ItensVendidos;");
            return tabela_memoria;
        }

        public void excluirEntrada(int idEntrada)
        {
            executarComando("update entradaEstoque set status_entEst=1 where id_entEst='" + idEntrada + "';");
        }

        public void alterarEntradas(EntradaEstoque entradaEst, int idEntrada)
        {
            executarComando("update entradaEstoque set data_entEst='" + entradaEst.Data_entEst.ToString("yyyy/MM/dd") + "', hora_entEst='" + entradaEst.Hora_entEst.ToString("HH:mm") + "', valor_entEst='" + entradaEst.Valor_entEst.ToString().Replace(',', '.') + "', obs_entEst='" + entradaEst.Obs_entEst.ToString() + "' where id_entEst='" + idEntrada + "';");
        }
    }
}
