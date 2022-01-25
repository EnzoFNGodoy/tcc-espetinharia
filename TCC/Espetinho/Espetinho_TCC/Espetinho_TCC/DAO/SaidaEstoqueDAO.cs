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
    class SaidaEstoqueDAO
    {
        SaidaEstoque saidaEst = new SaidaEstoque();

        MySqlDataAdapter comando_sql;
        MySqlCommandBuilder executar_comando;
        DataTable tabela_memoria;

        internal SaidaEstoque SaidaEst { get => saidaEst; set => saidaEst = value; }

        private void executarComando(string comando)
        {
            tabela_memoria = new DataTable();

            comando_sql = new MySqlDataAdapter(comando, Conexao.Conectar);

            executar_comando = new MySqlCommandBuilder(comando_sql);

            comando_sql.Fill(tabela_memoria);
        }

        public DataTable listarSaidas()
        {
            executarComando("select saidaEstoque, dia, hora, concat('R$ ',    Replace   (Replace  (Replace  (Format(valorTotal, 2), '.', '|'), ',', '.'), '|', ',')) as valorTotal from (select s.id_saiEst as saidaEstoque, s.data_saiEst as dia, s.hora_saiEst as hora, s.valor_saiEst as valorTotal from saidaEstoque s inner join its_SaidaEstoque it on s.id_saiEst = it.id_saiEst inner join produto p on it.id_prod = p.id_prod group by s.id_saiEst ) as ItensVendidos;");
            return tabela_memoria;
        }

        public void inserirSaidas(SaidaEstoque saidaEst)
        {
            executarComando("insert into saidaEstoque values (0,'" + saidaEst.Data_saiEst.ToString("yyyy/MM/dd") + "','" + saidaEst.Hora_saiEst.ToString("HH:mm") + "','" + saidaEst.Valor_saiEst.ToString().Replace(',', '.') + "','" + saidaEst.Obs_saiEst.ToString() + "', '"+saidaEst.Id_fin+ "',0);");
        }

        public int verificarUltSaida()
        {
            executarComando("select max(id_saiEst) as ultID from saidaEstoque;");
            int ultId = Convert.ToInt32(tabela_memoria.Rows[0]["ultID"]);
            return ultId;
        }

        public DataTable pesquisarPorValor(string comando)
        {
            executarComando("select saidaEstoque, dia, hora, concat('R$ ',    Replace   (Replace  (Replace  (Format(valorTotal, 2), '.', '|'), ',', '.'), '|', ',')) as valorTotal from (select s.id_saiEst as saidaEstoque, s.data_saiEst as dia, s.hora_saiEst as hora, s.valor_saiEst as valorTotal from saidaEstoque s inner join its_SaidaEstoque it on s.id_saiEst = it.id_saiEst inner join produto p on it.id_prod = p.id_prod where " + comando + " group by s.id_saiEst) as ItensVendidos;");
            return tabela_memoria;
        }

        public DataTable pesquisarPorIDGV(int id)
        {
            executarComando("select saidaEstoque, dia, hora, concat('R$ ',    Replace   (Replace  (Replace  (Format(valorTotal, 2), '.', '|'), ',', '.'), '|', ',')) as valorTotal from (select s.id_saiEst as saidaEstoque, s.data_saiEst as dia, s.hora_saiEst as hora, s.valor_saiEst as valorTotal from saidaEstoque s inner join its_SaidaEstoque it on s.id_saiEst = it.id_saiEst inner join produto p on it.id_prod = p.id_prod where s.id_saiEst=" + id + " group by s.id_saiEst) as ItensVendidos;");
            return tabela_memoria;
        }

        public DataTable pesquisarPorData(string dataInicio, string dataTermino)
        {
            executarComando("select saidaEstoque, dia, hora, concat('R$ ',    Replace   (Replace  (Replace  (Format(valorTotal, 2), '.', '|'), ',', '.'), '|', ',')) as valorTotal from (select s.id_saiEst as saidaEstoque, s.data_saiEst as dia, s.hora_saiEst as hora, s.valor_saiEst as valorTotal from saidaEstoque s inner join its_SaidaEstoque it on s.id_saiEst = it.id_saiEst inner join produto p on it.id_prod = p.id_prod where s.data_saiEst between '" + Convert.ToDateTime(dataInicio).ToString("yyyy/MM/dd") + "' and '" + Convert.ToDateTime(dataTermino).ToString("yyyy/MM/dd") + "' group by s.id_saiEst) as ItensVendidos;");
            return tabela_memoria;
        }

        public SaidaEstoque saidaPorID(int idSaiEst)
        {
            executarComando("select*from saidaEstoque where id_saiEst=" + idSaiEst + ";");

            saidaEst.Id_saiEst = idSaiEst;
            saidaEst.Data_saiEst = Convert.ToDateTime(tabela_memoria.Rows[0]["data_saiEst"].ToString());
            saidaEst.Hora_saiEst = Convert.ToDateTime(tabela_memoria.Rows[0]["hora_saiEst"].ToString());
            saidaEst.Valor_saiEst = Convert.ToDouble(tabela_memoria.Rows[0]["valor_saiEst"].ToString());
            saidaEst.Obs_saiEst = tabela_memoria.Rows[0]["obs_saiEst"].ToString();

            return saidaEst;
        }

        public void excluirSaida(int idSaida)
        {
            executarComando("update saidaEstoque set status_saiEst=1 where id_saiEst='" + idSaida + "';");
        }

        public void alterarSaidas(SaidaEstoque saidaEst, int idSaida)
        {
            executarComando("update saidaEstoque set data_saiEst='" + saidaEst.Data_saiEst.ToString("yyyy/MM/dd") + "', hora_saiEst='" + saidaEst.Hora_saiEst.ToString("HH:mm") + "', valor_saiEst='" + saidaEst.Valor_saiEst.ToString().Replace(',', '.') + "', obs_saiEst='" + saidaEst.Obs_saiEst.ToString() + "' where id_saiEst='"+idSaida+"';");
        }
    }
}
