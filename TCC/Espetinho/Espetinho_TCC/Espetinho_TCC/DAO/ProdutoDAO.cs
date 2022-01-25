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
    class ProdutoDAO
    {
        Produto prod = new Produto();
        Fornecedor forn = new Fornecedor();
        TipoProduto tipoprod = new TipoProduto();

        MySqlDataAdapter comando_sql;
        MySqlCommandBuilder executar_comando;
        DataTable tabela_memoria;

        internal Produto Prod { get => prod; set => prod = value; }
        internal Fornecedor Forn { get => forn; set => forn = value; }
        internal TipoProduto Tipoprod { get => tipoprod; set => tipoprod = value; }

        private void executarComando(string comando)
        {
            tabela_memoria = new DataTable();

            comando_sql = new MySqlDataAdapter(comando, Conexao.Conectar);

            executar_comando = new MySqlCommandBuilder(comando_sql);

            comando_sql.Fill(tabela_memoria);
        }

        public DataTable listarProduto()
        {
            executarComando("SELECT P.ID_PROD, P.NOME_PROD, P.DESC_PROD,  P.CUSTO_PROD, P.PRECO_PROD, P.QTDEST_PROD, T.TIPO_PRODUTO, F.NOME_FORN,  P.FOTO_PROD FROM TIPO_PRODUTO T INNER JOIN PRODUTO P  ON P.ID_TIPOPROD = T.ID_TIPOPROD  INNER JOIN FORNECEDOR F ON F.ID_FORN = P.ID_FORN WHERE STATUS_PROD=0 ORDER BY P.ID_PROD ASC;");
            return tabela_memoria;
        }

        public DataTable listarProdutoPorTipo(int id)
        {
            executarComando("select*from produto where id_tipoprod = '" + id + "'; ");
            return tabela_memoria;
        }

        public void inserirProduto(Produto prod)
        {
            executarComando("insert into produto values (0,'" + prod.Id_tipoprod + "','" + prod.Id_forn + "','" + prod.Nome_prod + "','" + prod.Desc_prod + "','" + prod.Custo_prod.ToString().Replace(",", ".") + "','" + prod.Preco_prod.ToString().Replace(",", ".") + "','" + prod.QtdEst_prod.ToString() + "','" + prod.Foto_prod + "','" + prod.Foto_prod + "', 0);");
        }

        public Boolean PesquisarProd(String nomeProd)
        {
            try
            {
                executarComando("SELECT P.ID_PROD, P.NOME_PROD, P.DESC_PROD,  P.CUSTO_PROD, P.PRECO_PROD, P.QTDEST_PROD, T.TIPO_PRODUTO, F.NOME_FORN,  P.FOTO_PROD FROM TIPO_PRODUTO T INNER JOIN PRODUTO P  ON P.ID_TIPOPROD = T.ID_TIPOPROD  INNER JOIN FORNECEDOR F ON F.ID_FORN = P.ID_FORN WHERE P.NOME_PROD LIKE '%" + nomeProd + "%';");

                Prod.Id_prod = Convert.ToInt32(tabela_memoria.Rows[0]["ID_PROD"].ToString());
                Prod.Nome_prod = tabela_memoria.Rows[0]["NOME_PROD"].ToString();
                Prod.Preco_prod = Convert.ToDouble(tabela_memoria.Rows[0]["PRECO_PROD"].ToString());
                Prod.QtdEst_prod = Convert.ToInt32(tabela_memoria.Rows[0]["QTDEST_PROD"].ToString());
                Tipoprod.Tipo_produto = tabela_memoria.Rows[0]["TIPO_PRODUTO"].ToString();
                Forn.Nome_forn = tabela_memoria.Rows[0]["NOME_FORN"].ToString();
                Prod.Custo_prod = Convert.ToDouble(tabela_memoria.Rows[0]["CUSTO_PROD"].ToString());
                Prod.Foto_prod = tabela_memoria.Rows[0]["FOTO_PROD"].ToString();
                Prod.Desc_prod = tabela_memoria.Rows[0]["DESC_PROD"].ToString();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable PesquisarProdNomeGV(string nomeProd)
        {
            executarComando("SELECT P.ID_PROD, P.NOME_PROD, P.DESC_PROD,  P.CUSTO_PROD, P.PRECO_PROD, P.QTDEST_PROD, T.TIPO_PRODUTO, F.NOME_FORN,  P.FOTO_PROD FROM TIPO_PRODUTO T INNER JOIN PRODUTO P  ON P.ID_TIPOPROD = T.ID_TIPOPROD  INNER JOIN FORNECEDOR F ON F.ID_FORN = P.ID_FORN WHERE P.NOME_PROD LIKE '%" + nomeProd + "%' ORDER BY P.ID_PROD ASC;");
            return tabela_memoria;
        }

        public DataTable ProdutosMaisVendidos(String tipoProd)
        {
            executarComando("select p.nome_prod, sum(it.qtd_itens) as qtdItens from comanda c inner join its_comanda it on it.id_com = c.id_com inner join produto p on p.id_prod = it.id_prod inner join tipo_produto t on t.id_tipoprod = p.id_tipoprod where t.tipo_produto='" + tipoProd + "' group by p.id_prod order by qtdItens desc;");
            return tabela_memoria;
        }

        public DataTable produtoPorIDGV(int id)
        {
            executarComando("SELECT P.ID_PROD, P.NOME_PROD, P.DESC_PROD,  P.CUSTO_PROD, P.PRECO_PROD, P.QTDEST_PROD, T.TIPO_PRODUTO, F.NOME_FORN,  P.FOTO_PROD FROM TIPO_PRODUTO T INNER JOIN PRODUTO P  ON P.ID_TIPOPROD = T.ID_TIPOPROD  INNER JOIN FORNECEDOR F ON F.ID_FORN = P.ID_FORN WHERE P.ID_PROD ='" + id + "' ORDER BY P.ID_PROD ASC;");
            return tabela_memoria;
        }

        public Produto produtoPorID(int id)
        {
            executarComando("SELECT P.ID_PROD, P.ID_FORN, P.NOME_PROD, P.DESC_PROD,  P.CUSTO_PROD, P.PRECO_PROD, P.QTDEST_PROD, T.TIPO_PRODUTO, F.NOME_FORN,  P.FOTO_PROD, P.FOTORELATORIO_PROD FROM TIPO_PRODUTO T INNER JOIN PRODUTO P  ON P.ID_TIPOPROD = T.ID_TIPOPROD  INNER JOIN FORNECEDOR F ON F.ID_FORN = P.ID_FORN WHERE P.ID_PROD ='" + id + "';");

            prod.Id_prod = Convert.ToInt32(tabela_memoria.Rows[0]["ID_PROD"].ToString());
            prod.Nome_prod = tabela_memoria.Rows[0]["NOME_PROD"].ToString();
            prod.Preco_prod = Convert.ToDouble(tabela_memoria.Rows[0]["PRECO_PROD"].ToString());
            prod.QtdEst_prod = Convert.ToInt32(tabela_memoria.Rows[0]["QTDEST_PROD"].ToString());
            tipoprod.Tipo_produto = tabela_memoria.Rows[0]["TIPO_PRODUTO"].ToString();
            prod.Id_forn = Convert.ToInt32(tabela_memoria.Rows[0]["ID_FORN"].ToString());
            forn.Nome_forn = tabela_memoria.Rows[0]["NOME_FORN"].ToString();
            prod.Custo_prod = Convert.ToDouble(tabela_memoria.Rows[0]["CUSTO_PROD"].ToString());
            prod.Foto_prod = tabela_memoria.Rows[0]["FOTO_PROD"].ToString();
            prod.Desc_prod = tabela_memoria.Rows[0]["DESC_PROD"].ToString();

            return prod;
        }

        public DataTable produtoPorEstoque(string comando)
        {
            executarComando("SELECT P.ID_PROD, P.NOME_PROD, P.DESC_PROD,  P.CUSTO_PROD, P.PRECO_PROD, P.QTDEST_PROD, T.TIPO_PRODUTO, F.NOME_FORN,  P.FOTO_PROD FROM TIPO_PRODUTO T INNER JOIN PRODUTO P  ON P.ID_TIPOPROD = T.ID_TIPOPROD  INNER JOIN FORNECEDOR F ON F.ID_FORN = P.ID_FORN WHERE " + comando + " ORDER BY P.ID_PROD ASC;");
            return tabela_memoria;
        }

        public void adicionarEstoque(int id, int qtdAdd)
        {
            executarComando("update produto set qtdEst_prod=(qtdEst_prod+" + qtdAdd + ") where id_prod='" + id + "';");
        }

        public void retirarEstoque(int id, int qtdSubtrair)
        {
            executarComando("update produto set qtdEst_prod=(qtdEst_prod-" + qtdSubtrair + ") where id_prod='" + id + "';");
        }

        public void alterarProduto(Produto prod, int id)
        {
            executarComando("update produto set id_tipoprod='" + prod.Id_tipoprod.ToString() + "', id_forn='" + prod.Id_forn.ToString() + "',nome_prod='" + prod.Nome_prod.ToString() + "', desc_prod='" + prod.Desc_prod.ToString() + "', custo_prod='" + prod.Custo_prod.ToString().Replace(',', '.') + "', preco_prod='" + prod.Preco_prod.ToString().Replace(',', '.') + "', qtdEst_prod='" + prod.QtdEst_prod.ToString() + "', foto_prod='" + prod.Foto_prod.ToString() + "' where id_prod='" + id + "';");
        }

        public void excluirProduto(int id)
        {
            executarComando("update produto set status_prod=1 where id_prod='" + id.ToString() + "';");
        }

        public int ultimoID()
        {
            executarComando("select max(id_prod) as id from produto;");
            return Convert.ToInt32(tabela_memoria.Rows[0]["id"].ToString());
        }

        public int quantidadeTotalProdutos()
        {
            executarComando("select count(id_prod) as qtd from produto;");
            return Convert.ToInt32(tabela_memoria.Rows[0]["qtd"].ToString());
        }

        public void atualizarFotoRelatorio(string fotoProd, int idProd)
        {
            executarComando("update produto set fotoRelatorio_prod='" + fotoProd.ToString() + "' where id_prod='" + idProd + "'");
        }

        #region Tela Analise de Vendas
        public int qtdVendasProduto(int id)
        {
            executarComando("select count(id_prod) as QtdProdVendida from its_comanda where id_prod='" + id + "';;");
            return Convert.ToInt32(tabela_memoria.Rows[0][0].ToString());
        }

        public int qtdVendasProdutoPorData(int id, DateTime dataInicio, DateTime dataTermino)
        {
            executarComando("select count(it.id_prod) as QtdProdVendida from its_comanda it inner join comanda c on c.id_com = it.id_com where it.id_prod='" + id + "' and c.data_com between '" + dataInicio.ToString("yyyy/MM/dd") + "' and '" + dataTermino.ToString("yyyy/MM/dd") + "';");
            return Convert.ToInt32(tabela_memoria.Rows[0][0].ToString());
        }

        public Double ReceitaTotalVendasProduto(int id)
        {
            executarComando("select sum(it.qtd_itens*p.preco_prod) as ValorTotalProd from its_comanda it inner join produto p on p.id_prod = it.id_prod where it.id_prod='" + id + "';");
            if (tabela_memoria.Rows[0][0].ToString() != "")
                return Convert.ToDouble(tabela_memoria.Rows[0][0].ToString());
            else
                return 0;
        }

        public Double ReceitaTotalVendasProdutoPorData(int id, DateTime dataInicio, DateTime dataTermino)
        {
            executarComando("select sum(it.qtd_itens*p.preco_prod) as ValorTotalProd from its_comanda it inner join comanda c on c.id_com = it.id_com inner join produto p on p.id_prod = it.id_prod where it.id_prod='" + id + "' and c.data_com between '" + dataInicio.ToString("yyyy/MM/dd") + "' and '" + dataTermino.ToString("yyyy/MM/dd") + "';");
            if (tabela_memoria.Rows[0][0].ToString() != "")
                return Convert.ToDouble(tabela_memoria.Rows[0][0].ToString());
            else
                return 0;
        }

        #endregion
    }
}
