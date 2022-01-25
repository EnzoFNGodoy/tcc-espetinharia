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
    class FornecedorDAO
    {
        Fornecedor forn = new Fornecedor();

        MySqlDataAdapter comando_sql;
        MySqlCommandBuilder executar_comando;
        DataTable tabela_memoria;

        internal Fornecedor Forn { get => forn; set => forn = value; }

        private void executarComando(string comando)
        {
            tabela_memoria = new DataTable();

            comando_sql = new MySqlDataAdapter(comando, Conexao.Conectar);

            executar_comando = new MySqlCommandBuilder(comando_sql);

            comando_sql.Fill(tabela_memoria);
        }

        public DataTable listarFornecedor()
        {
            executarComando("select id_forn, nome_forn, cpf_forn, cnpj_forn, tel_forn, email_forn from fornecedor;");
            return tabela_memoria;
        }

        public void inserirForn(Fornecedor forn, bool cnpj)
        {
            if (cnpj == true)
            {
                executarComando("insert into fornecedor values (0,'" + forn.Nome_forn + "',NULL,'" + forn.Cnpj_forn + "','" + forn.Tel_forn + "','" + forn.Email_forn + "',0);");
            }
            else
            {
                executarComando("insert into fornecedor values (0,'" + forn.Nome_forn + "','" + forn.Cpf_forn + "',NULL,'" + forn.Tel_forn + "','" + forn.Email_forn + "',0);");
            }
        }
        public Boolean pesquisarForn(String nomeFornPesq)
        {
            executarComando("select * from fornecedor where nome_forn LIKE '%" + nomeFornPesq + "%';");
            try
            {
                forn.Id_forn = Convert.ToInt32(tabela_memoria.Rows[0]["id_forn"].ToString());
                forn.Nome_forn = tabela_memoria.Rows[0]["nome_forn"].ToString();
                forn.Cpf_forn = tabela_memoria.Rows[0]["cpf_forn"].ToString();
                forn.Cnpj_forn = tabela_memoria.Rows[0]["cnpj_forn"].ToString();
                forn.Tel_forn = tabela_memoria.Rows[0]["tel_forn"].ToString();
                forn.Email_forn = tabela_memoria.Rows[0]["email_forn"].ToString();
   

                return true;
            }
            catch
            {
                return false;
            }
        }

        public Fornecedor fornPorID(int id)
        {
            executarComando("select * from fornecedor where id_forn = '" + id + "';");

            Forn.Id_forn = Convert.ToInt32(tabela_memoria.Rows[0]["id_forn"].ToString());
            Forn.Nome_forn = tabela_memoria.Rows[0]["nome_forn"].ToString();
            Forn.Cpf_forn = tabela_memoria.Rows[0]["cpf_forn"].ToString();
            Forn.Cnpj_forn = tabela_memoria.Rows[0]["cnpj_forn"].ToString();
            Forn.Tel_forn = tabela_memoria.Rows[0]["tel_forn"].ToString();
            Forn.Email_forn = tabela_memoria.Rows[0]["email_forn"].ToString();

            return Forn;
        }

        public DataTable listarFornsGV()
        {
            executarComando("select id_forn, nome_forn, cpf_forn, cnpj_forn, tel_forn, email_forn from fornecedor;");
            return tabela_memoria;
        }

        public void ExcluirForn(String codForn)
        {
            executarComando("update fornecedor set status_forn=1 where id_forn='" + codForn.ToString() + "';");
        }

        public void AlterarForn(Fornecedor forn, int id)
        {
            executarComando("update fornecedor set nome_forn='" + forn.Nome_forn + "', cpf_forn='" + forn.Cpf_forn + "',cnpj_forn='" + forn.Cnpj_forn + "', tel_forn='" + forn.Tel_forn + "', email_forn='" + forn.Email_forn +"' where id_forn='"+id+ "' ;");
        }


        public DataTable fornPorIDGV(int id)
        {
            executarComando("select * from fornecedor WHERE ID_forn ='" + id + "' ORDER BY id_forn ASC;");
            return tabela_memoria;
        }

        public DataTable fornPorCpfCnpj(string cpfcnpj)
        {
            executarComando("select * from  fornecedor where cpf_forn like '%"+cpfcnpj+ "%' or cnpj_forn like '%" + cpfcnpj + "%';");
            return tabela_memoria;
        }

        public DataTable fornPorNome(string nome)
        {
            executarComando("select * from fornecedor WHERE nome_forn LIKE '%" + nome + "%' ORDER BY nome_forn ASC;");
            return tabela_memoria;
        }

        public int verificarUltimoID ()
        {
            executarComando("select max(id_forn) as id from fornecedor;");
            return Convert.ToInt32(tabela_memoria.Rows[0]["id"]);
            
        }

    }
}
