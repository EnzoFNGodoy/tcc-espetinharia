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
    class FinancasDAO
    {
        double valor;
        Financas fin = new Financas();

        MySqlDataAdapter comando_sql;
        MySqlCommandBuilder executar_comando;
        DataTable tabela_memoria;

        internal Financas Fin { get => fin; set => fin = value; }

        private void executarComando(string comando)
        {
            tabela_memoria = new DataTable();

            comando_sql = new MySqlDataAdapter(comando, Conexao.Conectar);

            executar_comando = new MySqlCommandBuilder(comando_sql);

            comando_sql.Fill(tabela_memoria);
        }

        public DataTable listarFinancas()
        {
            executarComando("select*from financas where status_fin=0;");
            return tabela_memoria;
        }

        public DataTable listarTodasFinancasEntradas()
        {
            executarComando("select*from financas where tipo_fin='ENTRADA' and status_fin=0;");
            return tabela_memoria;
        }

        public DataTable listarTodasFinancasSaidas()
        {
            executarComando("select*from financas where tipo_fin='SAIDA' and status_fin=0;");
            return tabela_memoria;
        }

        public Financas entradasPorID(int id)
        {
            executarComando("select*from financas where tipo_fin='ENTRADA' and status_fin=0 and id_fin='" + id + "';");
            fin.Id_fin = Convert.ToInt32(tabela_memoria.Rows[0]["id_fin"].ToString());
            fin.Tipo_fin = tabela_memoria.Rows[0]["tipo_fin"].ToString();
            fin.Data_fin = Convert.ToDateTime(tabela_memoria.Rows[0]["data_fin"].ToString());
            fin.Valor_fin = Convert.ToDouble(tabela_memoria.Rows[0]["valor_fin"].ToString());
            fin.Obs_fin = tabela_memoria.Rows[0]["obs_fin"].ToString();

            return fin;
        }

        public int buscarUltIDEntradaAtiva()
        {
            executarComando("select max(id_fin) as id_fin from financas where tipo_fin='ENTRADA' and status_fin=0;");
            return Convert.ToInt32(tabela_memoria.Rows[0]["id_fin"].ToString());
        }

        public Financas saidasPorID(int id)
        {
            executarComando("select*from financas where tipo_fin='SAIDA' and status_fin=0 and id_fin='" + id + "';");
            fin.Tipo_fin = tabela_memoria.Rows[0]["tipo_fin"].ToString();
            fin.Data_fin = Convert.ToDateTime(tabela_memoria.Rows[0]["data_fin"].ToString());
            fin.Valor_fin = Convert.ToDouble(tabela_memoria.Rows[0]["valor_fin"].ToString()); ;
            fin.Obs_fin = tabela_memoria.Rows[0]["obs_fin"].ToString();

            return fin;
        }

        public int buscarUltIDSaidaAtiva()
        {
            executarComando("select max(id_fin) as id_fin from financas where tipo_fin='SAIDA' and status_fin=0;");
            return Convert.ToInt32(tabela_memoria.Rows[0]["id_fin"].ToString());
        }

        public DataTable listarPorMes(int ano, int mes)
        {
            executarComando("select * from financas where year(data_fin) = '" + ano + "' and month(data_fin)='" + mes + "' and status_fin=0;");
            return tabela_memoria;
        }

        public DataTable listarEntradasPorMes(int ano, int mes)
        {
            executarComando("select * from financas where year(data_fin) = '" + ano + "' and month(data_fin)='" + mes + "' and tipo_fin='ENTRADA' and status_fin=0;");
            return tabela_memoria;
        }

        public DataTable listarSaidasPorMes(int ano, int mes)
        {
            executarComando("select * from financas where year(data_fin) = '" + ano + "' and month(data_fin)='" + mes + "' and tipo_fin='SAIDA' and status_fin=0;");
            return tabela_memoria;
        }

        public void inserirEntradas(Financas fin)
        {
            executarComando("insert into financas values (0,'ENTRADA','" + fin.Data_fin.ToString("yyyy/MM/dd") + "','" + fin.Valor_fin.ToString().Replace(",", ".") + "','" + fin.Obs_fin.ToString() + "', 0);");
        }

        public void inserirSaidas(Financas fin)
        {
            executarComando("insert into financas values (0,'SAIDA','" + fin.Data_fin.ToString("yyyy/MM/dd") + "','" + fin.Valor_fin.ToString().Replace(",", ".") + "','" + fin.Obs_fin.ToString() + "', 0);");
        }

        public void alterarFinanca(Financas fin)
        {
            executarComando("update financas set data_fin='" + fin.Data_fin.ToString("yyyy/MM/dd") + "', valor_fin='" + fin.Valor_fin.ToString().Replace(',', '.') + "', obs_fin='" + fin.Obs_fin.ToString() + "';");
        }

        public void excluirFinanca(int id)
        {
            executarComando("update financas set status_fin=1 where id_fin='" + id + "';");
        }

        public double valorTotalEntradas()
        {
            executarComando("select sum(valor_fin) as valorTotal from financas where tipo_fin='ENTRADA' and status_fin=0;");
            return Convert.ToDouble(tabela_memoria.Rows[0]["valorTotal"].ToString());
        }

        public double valorTotalSaidas()
        {
            executarComando("select sum(valor_fin) as valorTotal from financas where tipo_fin='SAIDA' and status_fin=0;");
            return Convert.ToDouble(tabela_memoria.Rows[0]["valorTotal"].ToString());
        }

        public double valorTotalLucro()
        {
            executarComando("SELECT (LUCRO.ENTRADAS - LUCRO.SAIDAS) as Lucro FROM ( SELECT (select sum(financas.valor_fin) FROM financas where tipo_fin='ENTRADA' and status_fin=0) as ENTRADAS, (select sum(financas.valor_fin) FROM financas where tipo_fin='SAIDA' and status_fin=0) AS SAIDAS ) as LUCRO;");
            return Convert.ToDouble(tabela_memoria.Rows[0]["Lucro"].ToString());
        }

        public void alterarDiaPagtoSalarioFunc(int id, double valor, DateTime dia)
        {
            executarComando("update financas set data_fin='" + dia.ToString("yyyy/MM/dd") + "', valor_fin'" + valor.ToString().Replace(",", ".") + "' where id_fin='" + id + "';");
        }

        public int buscarUltID()
        {
            executarComando("select max(id_fin) as id_fin from financas;");
            return Convert.ToInt32(tabela_memoria.Rows[0]["id_fin"].ToString());
        }

        public DataTable carregarAnosFinancas()
        {
            executarComando("select * from (select year(data_fin) as Ano from financas where status_fin=0 group by year(data_fin)) as VerAnosDasFinancas group by Ano;");
            return tabela_memoria;
        }

        #region Consultar Valor do Caixa
        public double valorCaixaDia(DateTime data)
        {
            try
            {
                executarComando("select (sum(valor_fin)) as valorTotal from financas where data_fin ='" + data.ToString("yyyy/MM/dd") + "' and tipo_fin='ENTRADA' and status_fin=0;");
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
                executarComando("select sum(valor_fin) as valorTotal from financas where data_fin between '" + data1.ToString("yyyy/MM/dd") + "' and '" + data2.ToString("yyyy/MM/dd") + "' and tipo_fin='ENTRADA' and status_fin=0;");
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

        public double valorCaixaMes(int mes, int ano)
        {
            try
            {
                executarComando("select sum(valor_fin) as valorTotal from financas where month(data_fin)='" + mes + "' and year(data_fin)='" + ano + "' and tipo_fin='ENTRADA' and status_fin=0;");
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
                executarComando("select sum(valor_fin) as valorTotal from financas where year(data_fin)='" + ano + "' and tipo_fin='ENTRADA' and status_fin=0;");
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
    }
}
