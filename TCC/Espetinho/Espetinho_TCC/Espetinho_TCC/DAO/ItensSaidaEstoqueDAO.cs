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
    class ItensSaidaEstoqueDAO
    {
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

        public DataTable listarProdutosSaidaEstoqueDataTable(int idSaiEst)
        {
            executarComando("select saidaEstoque, produto, qtdComprada,  precoUnit, valorTotal, foto from (select s.id_saiEst as saidaEstoque, p.nome_prod as produto, it.qtd_itens as qtdComprada, s.data_saiEst as dia, s.hora_saiEst as hora, p.preco_prod as precoUnit, (it.qtd_itens * p.preco_prod) as valorTotal, p.foto_prod as foto from saidaEstoque s inner join its_SaidaEstoque it on s.id_saiEst = it.id_saiEst inner join produto p on it.id_prod = p.id_prod) as ItensVendidos where saidaEstoque='" + idSaiEst + "'; ");
            return tabela_memoria;
        }

        public DataTable listarProdutosSaidaEstoque(int idSaiEst)
        {
            DataTable produtos = new DataTable();
            produtos.Columns.Add("codigo").DataType = typeof(int);
            produtos.Columns.Add("nome").DataType = typeof(String);
            produtos.Columns.Add("precoUnit").DataType = typeof(double);
            produtos.Columns.Add("QtdItens").DataType = typeof(int);
            produtos.Columns.Add("valorTotal").DataType = typeof(double);
            executarComando("select saidaEstoque, codigoProd, produto, qtdComprada,  precoUnit, valorTotal, foto from (select s.id_saiEst as saidaEstoque, p.id_prod as codigoProd, p.nome_prod as produto, it.qtd_itens as qtdComprada, s.data_saiEst as dia, s.hora_saiEst as hora, p.preco_prod as precoUnit, (it.qtd_itens * p.preco_prod) as valorTotal, p.foto_prod as foto from saidaEstoque s inner join its_SaidaEstoque it on s.id_saiEst = it.id_saiEst inner join produto p on it.id_prod = p.id_prod) as ItensVendidos where saidaEstoque='" + idSaiEst + "'; ");
            for (int i = 0; i < tabela_memoria.Rows.Count; i++)
            {
                produtos.Rows.Add(Convert.ToInt32(tabela_memoria.Rows[i]["codigoProd"].ToString()),
                    tabela_memoria.Rows[i]["produto"].ToString(),
                    Convert.ToDouble(tabela_memoria.Rows[i]["precoUnit"].ToString()),
                    Convert.ToInt32(tabela_memoria.Rows[i]["qtdComprada"].ToString()),
                    Convert.ToDouble(tabela_memoria.Rows[i]["valorTotal"].ToString())
                    );
            }
            return produtos;
        }

        public int buscarUltSaida()
        {
            executarComando("select max(id_saiEst) as id from saidaEstoque");
            return Convert.ToInt32(tabela_memoria.Rows[0]["id"].ToString());
        }

        public void inserirItensSaida(ItensSaidaEstoque itSaiEst)
        {
            executarComando("insert into its_SaidaEstoque values (0,'" + itSaiEst.Id_saiEst + "','" + itSaiEst.Id_prod + "','" + itSaiEst.Qtd_itens + "');");
        }

        public void excluirItensSaida(int id)
        {
            executarComando("delete from its_SaidaEstoque where id_saiEst='" + id + "';");  
        }
    }
}
