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
    class ClientesDAO
    {
        Clientes cli = new Clientes();

        MySqlDataAdapter comando_sql;
        MySqlCommandBuilder executar_comando;
        DataTable tabela_memoria;

        internal Clientes Cli { get => cli; set => cli = value; }

        private void executarComando(string comando)
        {
            tabela_memoria = new DataTable();

            comando_sql = new MySqlDataAdapter(comando, Conexao.Conectar);

            executar_comando = new MySqlCommandBuilder(comando_sql);

            comando_sql.Fill(tabela_memoria);
        }

        public DataTable listarClientes()
        {
            executarComando("select*from clientes;");
            return tabela_memoria;
        }

        public void inserirClientes(Clientes cli, bool cnpj)
        {
            if (cnpj == true)
            {
                executarComando("insert into clientes values(0,'" + cli.Nome_cli + "',NULL,'" + cli.Cnpj_cli + "','" + cli.Tel_cli + "','" + cli.Email_cli + "',0)");
            }
            else
            {
                executarComando("insert into clientes values(0,'" + cli.Nome_cli + "','" + cli.Cpf_cli + "',NULL,'" + cli.Tel_cli + "','" + cli.Email_cli + "',0)");
            }
        }

        public void alterarCliente(Clientes cli, int id, bool cnpj)
        {
            if (cnpj == true)
            {
                executarComando("update clientes set nome_cli='" + cli.Nome_cli + "', cpf_cli=NULL, cnpj_cli='" + cli.Cnpj_cli + "', tel_cli='" + cli.Tel_cli + "', email_cli='" + cli.Email_cli + "' where id_cli='" + id + "';");
            }
            else
            {
                executarComando("update clientes set nome_cli='" + cli.Nome_cli + "', cpf_cli='" + cli.Cpf_cli + "', cnpj_cli=NULL, tel_cli='" + cli.Tel_cli + "', email_cli='" + cli.Email_cli + "' where id_cli='" + id + "';");
            }
        }

        public void excluirCliente(int idCli)
        {
            executarComando("update clientes set status_cli=1 where id_cli='" + idCli + "';");
        }

        public int quantidadeClientes()
        {
            executarComando("select count(id_cli) as qtd from clientes;");
            return Convert.ToInt32(tabela_memoria.Rows[0]["qtd"].ToString());
        }

        public DataTable listarClientesPorNome(string nomeCli)
        {
            executarComando("select*from clientes where nome_cli like'%" + nomeCli + "%';");
            return tabela_memoria;
        }

        public int ultimoID()
        {
            executarComando("select max(id_cli) as id from clientes;");
            return Convert.ToInt32(tabela_memoria.Rows[0]["id"].ToString());
        }

        public Clientes clientePorID(int idCli)
        {
            executarComando("select * from clientes where id_cli=" + idCli + ";");

            cli.Id_cli = idCli;
            cli.Nome_cli = tabela_memoria.Rows[0]["nome_cli"].ToString();
            cli.Tel_cli = tabela_memoria.Rows[0]["tel_cli"].ToString();
            cli.Email_cli = tabela_memoria.Rows[0]["email_cli"].ToString();
            cli.Cpf_cli = tabela_memoria.Rows[0]["cpf_cli"].ToString();
            cli.Cnpj_cli = tabela_memoria.Rows[0]["cnpj_cli"].ToString();

            return cli;
        }
    }
}
