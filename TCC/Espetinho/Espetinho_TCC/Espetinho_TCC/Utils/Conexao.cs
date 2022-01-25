using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Espetinho_TCC.Utils
{
    class Conexao
    {
        static MySqlConnection conectar;

        public static MySqlConnection Conectar
        {
            get { return Conexao.conectar; }
            set { Conexao.conectar = value; }
        }

        public static String criar_Conexao()
        {
            if (conectar != null)
            {
                conectar.Close();
            }

            string configuracao = string.Format("server={0};user id={1}; password={2};database=mysql; pooling=false", "127.0.0.1", "root", "godoy");

            try
            {
                conectar = new MySqlConnection(configuracao);
                conectar.Open();
            }
            catch (MySqlException erro)
            {
                return ("Erro ao conectar " + erro);
            }

            MySqlDataReader banco = null;

            MySqlCommand usar = new MySqlCommand("use Espetinho", conectar);

            try
            {
                banco = usar.ExecuteReader();
            }
            catch (MySqlException erro)
            {
                return ("Failed to populate database list: " + erro);
            }
            finally
            {
                if (banco != null)
                {
                    banco.Close();
                }
            }

            return ("Conexão OK!!!");
        }
    }
}
