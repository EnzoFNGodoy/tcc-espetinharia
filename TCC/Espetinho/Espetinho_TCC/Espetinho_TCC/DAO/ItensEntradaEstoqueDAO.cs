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
    class ItensEntradaEstoqueDAO
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


        public DataTable listarProdutosEntradaEstoqueDataTable(int idEntEst)
        {
            executarComando("select entradaEstoque, produto, qtdComprada, precoUnit, valorTotal, foto from(select e.id_entEst as entradaEstoque, p.nome_prod as produto, it.qtd_itens as qtdComprada, e.data_entEst as dia, e.hora_entEst as hora, p.preco_prod as precoUnit, (it.qtd_itens * p.preco_prod) as valorTotal, p.foto_prod as foto from entradaEstoque e inner join its_EntradaEstoque it on e.id_entEst = it.id_entEst inner join produto p on it.id_prod = p.id_prod) as ItensVendidos where entradaEstoque = '"+ idEntEst + "'; ");
            return tabela_memoria;
        }

        public DataTable listarProdutosEntradaEstoque(int idEntEst)
        {
            DataTable produtos = new DataTable();
            produtos.Columns.Add("codigo").DataType = typeof(int);
            produtos.Columns.Add("nome").DataType = typeof(String);
            produtos.Columns.Add("precoUnit").DataType = typeof(double);
            produtos.Columns.Add("QtdItens").DataType = typeof(int);
            produtos.Columns.Add("valorTotal").DataType = typeof(double);
            executarComando("select entradaEstoque, codigoProd, produto, qtdComprada,  precoUnit, valorTotal, foto from (select e.id_entEst as entradaEstoque, p.id_prod as codigoProd, p.nome_prod as produto, it.qtd_itens as qtdComprada, e.data_entEst as dia, e.hora_entEst as hora, p.preco_prod as precoUnit, (it.qtd_itens * p.preco_prod) as valorTotal, p.foto_prod as foto from entradaEstoque e inner join its_EntradaEstoque it on e.id_entEst = it.id_entEst inner join produto p on it.id_prod = p.id_prod) as ItensVendidos where entradaEstoque='" + idEntEst + "'; ");
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

        public int buscarUltEntrada()
        {
            executarComando("select max(id_entEst) as id from entradaEstoque");
            return Convert.ToInt32(tabela_memoria.Rows[0]["id"].ToString());
        }

        public void inserirItensEntrada(ItensEntradaEstoque itEntEst)
        {
            executarComando("insert into its_EntradaEstoque values (0,'" + itEntEst.Id_entEst + "','" + itEntEst.Id_prod + "','" + itEntEst.Qtd_itens + "');");
        }

        public void excluirItensEntrada(int id)
        {
            executarComando("delete from its_EntradaEstoque where id_entEst='" + id + "';");
        }
    }
}
