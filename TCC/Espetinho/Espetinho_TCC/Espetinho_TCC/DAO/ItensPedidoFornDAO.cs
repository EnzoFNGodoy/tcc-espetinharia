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
    class ItensPedidoFornDAO
    {
        Produto prod = new Produto();
        Fornecedor forn = new Fornecedor();
        PedidosForn pedforn = new PedidosForn();
        ItensPedidoForn itpedforn = new ItensPedidoForn();

        MySqlDataAdapter comando_sql;
        MySqlCommandBuilder executar_comando;
        DataTable tabela_memoria;

        internal Produto Prod { get => prod; set => prod = value; }
        internal Fornecedor Forn { get => forn; set => forn = value; }
        internal PedidosForn Pedforn { get => pedforn; set => pedforn = value; }
        internal ItensPedidoForn Itpedforn { get => itpedforn; set => itpedforn = value; }

        private void executarComando(string comando)
        {
            tabela_memoria = new DataTable();

            comando_sql = new MySqlDataAdapter(comando, Conexao.Conectar);

            executar_comando = new MySqlCommandBuilder(comando_sql);

            comando_sql.Fill(tabela_memoria);
        }

        public DataTable ListarItensPedidoDataTable(int IdPed)
        {
            executarComando("select pedido, produto, qtdComprada, precoUnit, valorTotal, foto from(select ped.id_ped as pedido, p.nome_prod as produto, it.qtd_itens as qtdComprada, ped.data_ped as dia, ped.hora_ped as hora, p.preco_prod as precoUnit, (it.qtd_itens * p.preco_prod) as valorTotal, p.foto_prod as foto from pedidos_forn ped inner join its_comanda it on ped.id_ped = it.id_com inner join produto p on it.id_prod = p.id_prod) as ItensVendidos where pedido = '" + IdPed + "';");
            return tabela_memoria;
        }

        public DataTable ListarItensPedido(int IdPed)
        {
            DataTable produtos = new DataTable();
            produtos.Columns.Add("codigo").DataType = typeof(int);
            produtos.Columns.Add("nome").DataType = typeof(String);
            produtos.Columns.Add("precoUnit").DataType = typeof(double);
            produtos.Columns.Add("QtdItens").DataType = typeof(int);
            produtos.Columns.Add("valorTotal").DataType = typeof(double);
            executarComando("select pedido, codigoProd, produto, qtdComprada, precoUnit, valorTotal, foto from(select ped.id_ped as pedido, p.id_prod as codigoProd, p.nome_prod as produto, it.qtd_itens as qtdComprada, ped.data_ped as dia, ped.hora_ped as hora, p.preco_prod as precoUnit, (it.qtd_itens * p.preco_prod) as valorTotal, p.foto_prod as foto from pedidos_forn ped inner join its_comanda it on ped.id_ped = it.id_com inner join produto p on it.id_prod = p.id_prod) as ItensVendidos where pedido = '" + IdPed + "';");
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

        public void InserirItensPedido(ItensPedidoForn ItensPedido)
        {
            executarComando("insert into its_pedidosForn values(0,'" + ItensPedido.Id_ped + "', '" + ItensPedido.Id_prod + "', '" + ItensPedido.Qtd_itens + "');");
        }

        public void excluirItensPedido(int id)
        {
            executarComando("delete from its_pedidosForn where id_ped='" + id + "';");
        }
    }
}
