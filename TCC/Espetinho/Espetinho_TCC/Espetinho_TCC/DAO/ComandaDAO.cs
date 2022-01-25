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
    class ComandaDAO
    {
        double valor;

        Comanda comanda = new Comanda();
        Funcionario func = new Funcionario();
        Pagamento pag = new Pagamento();

        MySqlDataAdapter comando_sql;
        MySqlCommandBuilder executar_comando;
        DataTable tabela_memoria;
        List<int> qtdVendas = new List<int>();
        List<Double> receitasVendas = new List<double>();

        public List<int> QtdVendas { get => qtdVendas; set => qtdVendas = value; }
        public List<double> ReceitasVendas { get => receitasVendas; set => receitasVendas = value; }

        private void executarComando(string comando)
        {
            tabela_memoria = new DataTable();

            comando_sql = new MySqlDataAdapter(comando, Conexao.Conectar);

            executar_comando = new MySqlCommandBuilder(comando_sql);

            comando_sql.Fill(tabela_memoria);
        }

        public DataTable listarComanda()
        {
            executarComando("select c.id_com, p.tipo_pagto, c.valor_com, c.data_com, c.hora_com from comanda c inner join pagamento p on c.id_pagto = p.id_pagto where status_com=0;");
            return tabela_memoria;
        }

        public int verificarUltComanda()
        {
            executarComando("select max(id_com) as ultID from comanda;");
            int ultId = Convert.ToInt32(tabela_memoria.Rows[0]["ultID"]);
            return ultId;
        }

        public void validar(Comanda com)
        {
            executarComando("insert into comanda values (0,'" + com.Id_pagto + "','"+com.Id_cli+ "','" + com.Id_func + "','" + com.Valor_com.ToString().Replace(",", ".") + "','" + com.Data_com.ToString("yyyy/MM/dd") + "','" + com.Hora_com.ToString("HH:mm") + "','"+com.Id_fin.ToString()+"',0);");
        }

        public int quantidadeTotalComandas()
        {
            executarComando("select count(id_com) as qtd from comanda;");
            return Convert.ToInt32(tabela_memoria.Rows[0]["qtd"].ToString());
        }

        public DateTime buscarDataPrimeiraVenda()
        {
            executarComando("select min(data_com) as dataPrimeira from comanda;");
            return Convert.ToDateTime(tabela_memoria.Rows[0]["dataPrimeira"].ToString());
        }

        public DateTime buscarDataUltimaVenda()
        {
            executarComando("select max(data_com) as dataUltima from comanda;");
            return Convert.ToDateTime(tabela_memoria.Rows[0]["dataUltima"].ToString());
        }

        public Comanda buscarComandaPorID(int id)
        {
            executarComando("select*from comanda c inner join funcionario f on f.id_func=c.id_func inner join clientes cli on cli.id_cli = c.id_cli;");
            comanda.Data_com = Convert.ToDateTime(tabela_memoria.Rows[0]["data_com"].ToString());
            comanda.Hora_com = Convert.ToDateTime(tabela_memoria.Rows[0]["hora_com"].ToString());
            comanda.Id_cli = Convert.ToInt32(tabela_memoria.Rows[0]["id_cli"].ToString()); ;
            comanda.Id_func = Convert.ToInt32(tabela_memoria.Rows[0]["id_func"].ToString()); ;
            comanda.Id_pagto = Convert.ToInt32(tabela_memoria.Rows[0]["id_pagto"].ToString()); ;
            comanda.Valor_com = Convert.ToDouble(tabela_memoria.Rows[0]["valor_com"].ToString()); ;
            return comanda;
        }

        public void excluirItensComanda(int id)
        {
            executarComando("delete from its_comanda where id_com='" + id + "';");
        }

        public void alterarComanda(Comanda com, int id)
        {
            executarComando("update comanda set data_com='" + com.Data_com.ToString("yyyy/MM/dd") + "', hora_com='" + com.Hora_com.ToString("HH:mm") + "', valor_com='" + com.Valor_com.ToString().Replace(',', '.') + "', id_func='" + com.Id_func + "', id_cli='" + com.Id_cli + "', id_pagto='" + com.Id_pagto + "' where id_com='" + id + "';");
        }

        public void excluirComanda(int id)
        {
            executarComando("update comanda set status_com=1 where id_com='" + id + "';");
        }

        public DataTable pesquisarPorData(string dataInicio, string dataTermino)
        {
            executarComando("select comanda, dia, hora, concat('R$ ',    Replace   (Replace  (Replace  (Format(valorTotal, 2), '.', '|'), ',', '.'), '|', ',')) as valorTotal from (select c.id_com as comanda, c.data_com as dia, c.hora_com as hora, c.valor_com as valorTotal from comanda c inner join its_comanda it on c.id_com = it.id_com where c.data_com between '" + Convert.ToDateTime(dataInicio).ToString("yyyy/MM/dd") + "' and '" + Convert.ToDateTime(dataTermino).ToString("yyyy/MM/dd") + "' group by c.id_com) as ItensVendidos;");
            return tabela_memoria;
        }

        #region Consultar Valor do Caixa
        public double valorCaixaDia(DateTime data)
        {
            try
            {
                executarComando("select sum(valor_com) as valorTotal from comanda where data_com ='" + data.ToString("yyyy/MM/dd") + "';");
                if (tabela_memoria.Rows[0]["valorTotal"] == null)
                {
                    valor = 0;
                }
                else
                {
                    valor = Convert.ToDouble(tabela_memoria.Rows[0]["valorTotal"]);
                }
            }
            catch
            {
                valor = 0;
            }
            return valor;
        }

        public double valorCaixaSemana(DateTime data1, DateTime data2)
        {
            try
            {
                executarComando("select sum(valor_com) as valorTotal from comanda where data_com between '" + data1.ToString("yyyy/MM/dd") + "' and '" + data2.ToString("yyyy/MM/dd") + "'; ");
                if (tabela_memoria.Rows[0]["valorTotal"] == null)
                {
                    valor = 0;
                }
                else
                {
                    valor = Convert.ToDouble(tabela_memoria.Rows[0]["valorTotal"]);
                }
            }
            catch
            {
                valor = 0;
            }
            return valor;
        }

        public double valorCaixaMes(int mes)
        {
            try
            {
                executarComando("select sum(valor_com) as valorTotal from comanda where month(data_com)='" + mes + "';");
                if (tabela_memoria.Rows[0]["valorTotal"] == null)
                {
                    valor = 0;
                }
                else
                {
                    valor = Convert.ToDouble(tabela_memoria.Rows[0]["valorTotal"]);
                }
            }
            catch
            {
                valor = 0;
            }
            return valor;
        }

        public double valorCaixaAno(int ano)
        {
            try
            {
                executarComando("select sum(valor_com) as valorTotal from comanda where year(data_com)='" + ano + "';");
                if (tabela_memoria.Rows[0]["valorTotal"] == null)
                {
                    valor = 0;
                }
                else
                {
                    valor = Convert.ToDouble(tabela_memoria.Rows[0]["valorTotal"]);
                }
            }
            catch
            {
                valor = 0;
            }
            return valor;
        }
        #endregion

        #region Lancar Valor no Caixa do Dia
        public void lancarValor(Comanda com)
        {
            executarComando("insert into comanda values (0,'1',NULL,NULL,'" + com.Valor_com.ToString().Replace(",", ".") + "','" + DateTime.Now.ToString("yyyy/MM/dd") + "','" + DateTime.Now.ToString("HH:mm") + "');");
        }
        #endregion

        #region Tela Análise de Vendas
        public DataTable listarAnosVendas()
        {
            executarComando("select * from (select year(data_com) as Ano from comanda group by year(data_com)) as VerAnosDasCompras group by Ano;");
            return tabela_memoria;
        }

        public void quantidadeDeVendasNoAno(int ano)
        {
            executarComando("select sum(qtd) as qtdTotal,mes as mes from (select count(id_com) as qtd,month(data_com) as mes from comanda where year(data_com) = '" + ano + "' group by month(data_com)) as qtdVendas group by mes;");
            QtdVendas.Clear();
            for (int h = 0; h < 12; h++)
            {
                QtdVendas.Add(0);
            }
            for (int i = 0; i < tabela_memoria.Rows.Count; i++)
            {
                QtdVendas[Convert.ToInt32(tabela_memoria.Rows[i]["mes"].ToString()) - 1] = Convert.ToInt32(tabela_memoria.Rows[i]["qtdTotal"].ToString());
            }
        }

        public void receitaTotalVendasNoAno(int ano)
        {
            executarComando("select (Format(sum(soma), 0)) as soma,mes from(select sum(valor_com) as soma, month(data_com) as mes from comanda as c where year(data_com) = '"+ano+"' group by month(data_com)) as Receita group by mes; ");
            ReceitasVendas.Clear();
            for (int h = 0; h < 12; h++)

            {
                ReceitasVendas.Add(0);
            }
            for (int i = 0; i < tabela_memoria.Rows.Count; i++)
            {
                ReceitasVendas[Convert.ToInt32(tabela_memoria.Rows[i]["mes"].ToString()) - 1] = Convert.ToDouble(tabela_memoria.Rows[i]["soma"].ToString());
            }
        }

        public void quantidadeDeVendasNoMes(int mes)
        {
            executarComando("select sum(qtd) as qtdTotal, dia from (select count(id_com) as qtd, day(data_com) as dia from comanda where month(data_com) = '"+mes+"' group by dia) as qtdVendas group by dia;");
            QtdVendas.Clear();
            for (int h = 0; h < 31; h++)
            {
                QtdVendas.Add(0);
            }
            for (int i = 0; i < tabela_memoria.Rows.Count; i++)
            {
                QtdVendas[Convert.ToInt32(tabela_memoria.Rows[i]["dia"].ToString()) - 1] = Convert.ToInt32(tabela_memoria.Rows[i]["qtdTotal"].ToString());
            }
        }

        public void receitaTotalVendasNoMes(int mes)
        {
            executarComando("select (Format(sum(soma), 0)) as soma,dia from (select sum(valor_com) as soma, day(data_com) as dia from comanda as c where month(data_com) = '"+mes+"' group by dia) as Receita group by dia; ");
            ReceitasVendas.Clear();
            for (int h = 0; h < 31; h++)
            {
                ReceitasVendas.Add(0);
            }
            for (int i = 0; i < tabela_memoria.Rows.Count; i++)
            {
                ReceitasVendas[Convert.ToInt32(tabela_memoria.Rows[i]["dia"].ToString()) - 1] = Convert.ToDouble(tabela_memoria.Rows[i]["soma"].ToString());
            }
        }
        #endregion
    }
}
