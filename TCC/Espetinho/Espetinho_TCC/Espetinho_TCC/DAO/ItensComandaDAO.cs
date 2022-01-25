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
    class ItensComandaDAO
    {
        ItensComanda itcom = new ItensComanda();
        Comanda com = new Comanda();
        Produto prod = new Produto();

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

        public DataTable listarProdutosComanda(int idCom)
        {
            executarComando("select comanda, produto, qtdComprada,  precoUnit, valorTotal, foto from (select c.id_com as comanda, p.nome_prod as produto, it.qtd_itens as qtdComprada, c.data_com as dia, c.hora_com as hora, p.preco_prod as precoUnit, (it.qtd_itens * p.preco_prod) as valorTotal, p.foto_prod as foto from comanda c inner join its_comanda it on c.id_com = it.id_com inner join produto p on it.id_prod = p.id_prod) as ItensVendidos where comanda='"+idCom+"'; ");
            return tabela_memoria;
        }

        public void inserirItensComanda(ItensComanda itcom)
        {
            executarComando("insert into its_comanda values (0,'" + itcom.Id_com + "','" + itcom.Id_prod + "','" + itcom.Qtd_itens.ToString() +  "');");
        }

        public int buscarUltCom()
        {
            executarComando("select max(id_com) from comanda;");
            return Convert.ToInt32(tabela_memoria.Rows[0][0].ToString());
        }

        public DataTable listarProdutosItensComanda(int idPed)
        {
            DataTable produtos = new DataTable();
            produtos.Columns.Add("codigo").DataType = typeof(int);
            produtos.Columns.Add("nome").DataType = typeof(String);
            produtos.Columns.Add("precoUnit").DataType = typeof(double);
            produtos.Columns.Add("QtdItens").DataType = typeof(int);
            produtos.Columns.Add("valorTotal").DataType = typeof(double);
            executarComando("select comanda, codigoProd, produto, qtdComprada,  precoUnit, valorTotal, foto from (select c.id_com as comanda, p.id_prod as codigoProd, p.nome_prod as produto, it.qtd_itens as qtdComprada, c.data_com as dia, c.hora_com as hora, p.preco_prod as precoUnit, (it.qtd_itens * p.preco_prod) as valorTotal, p.foto_prod as foto from comanda c inner join its_comanda it on c.id_com = it.id_com inner join produto p on it.id_prod = p.id_prod) as ItensVendidos where comanda='" + idPed + "'; ");
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
    }
}
