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
    class FuncionarioDAO
    {
        Funcionario func = new Funcionario();

        MySqlDataAdapter comando_sql;
        MySqlCommandBuilder executar_comando;
        DataTable tabela_memoria;

        internal Funcionario Func { get => func; set => func = value; }

        private void executarComando(string comando)
        {
            tabela_memoria = new DataTable();

            comando_sql = new MySqlDataAdapter(comando, Conexao.Conectar);

            executar_comando = new MySqlCommandBuilder(comando_sql);

            comando_sql.Fill(tabela_memoria);
        }

        public DataTable listarFuncGerenciarPedido()
        {
            executarComando("select f.id_func, c.tipo_cargo, f.nome_func from funcionario f inner join cargo c on f.id_cargo = c.id_cargo;");
            return tabela_memoria;
        }

        public Funcionario funcPorID(int idFunc)
        {
            executarComando("select * from funcionario where id_func=" + idFunc + ";");

            func.Id_func = idFunc;
            func.Sal_func = Convert.ToDouble(tabela_memoria.Rows[0]["sal_func"].ToString());
            func.Nome_func = tabela_memoria.Rows[0]["nome_func"].ToString();
            func.Cpf_func = tabela_memoria.Rows[0]["cpf_func"].ToString();
            func.Sexo_func = tabela_memoria.Rows[0]["sexo_func"].ToString();
            func.RG_func1 = tabela_memoria.Rows[0]["RG_func"].ToString();
            func.Dtnasc_func = Convert.ToDateTime(tabela_memoria.Rows[0]["dtnasc_func"].ToString());
            func.Estcivil_func = tabela_memoria.Rows[0]["estcivil_func"].ToString();
            func.Tel_func = tabela_memoria.Rows[0]["tel_func"].ToString();
            func.Email_func = tabela_memoria.Rows[0]["email_func"].ToString();
            func.Endereco_func = tabela_memoria.Rows[0]["endereco_func"].ToString();
            func.Cep_func = tabela_memoria.Rows[0]["cep_func"].ToString();
            func.Uf_func = tabela_memoria.Rows[0]["uf_func"].ToString();
            func.Cid_func = tabela_memoria.Rows[0]["cid_func"].ToString();
            func.Bairro_func = tabela_memoria.Rows[0]["bairro_func"].ToString();
            func.Compl_func = tabela_memoria.Rows[0]["compl_func"].ToString();
            func.Num_func = Convert.ToInt32(tabela_memoria.Rows[0]["num_func"].ToString());
            func.DiaPagto_func = tabela_memoria.Rows[0]["diaPagto_func"].ToString();
            func.Id_fin = Convert.ToInt32(tabela_memoria.Rows[0]["id_fin"].ToString());

            return func;
        }

        public DataTable listarFuncionario()
        {
            executarComando("select f.id_func, f.id_usu, f.id_cargo, c.tipo_cargo , f.sal_func, Concat((Format(f.comissao_func, 0)), '%'), f.nome_func, f.cpf_func, f.sexo_func, f.RG_func, f.dtnasc_func, f.estcivil_func, f.tel_func, f.email_func, f.endereco_func, f.cep_func, f.uf_func, f.cid_func, f.bairro_func, f.compl_func, f.num_func, f.diaPagto_func, f.id_fin from funcionario f inner join cargo c on c.id_cargo = f.id_cargo;");
            return tabela_memoria;
        }

        public DataTable pesqFuncionarioPorNome(String nomeFunc)
        {
            executarComando("select f.id_func, f.id_usu, f.id_cargo, c.tipo_cargo , f.sal_func, f.comissao_func, f.nome_func, f.cpf_func, f.sexo_func, f.RG_func, f.dtnasc_func, f.estcivil_func, f.tel_func, f.email_func, f.endereco_func, f.cep_func, f.uf_func, f.cid_func, f.bairro_func, f.compl_func, f.num_func, f.diaPagto_func, f.id_fin from funcionario f inner join cargo c on c.id_cargo = f.id_cargo where f.nome_func LIKE '%" + nomeFunc + "%';");
            return tabela_memoria;
        }

        public void inserirFunc(Funcionario funcionario, bool temCompl)
        {
            if (temCompl == true)
            {
                executarComando("insert into funcionario values (0,'" + funcionario.Id_usu + "','" + funcionario.Id_cargo + "','" + funcionario.Sal_func.ToString().Replace(",", ".") + "','" + funcionario.Comissao_func.ToString().Replace(",", ".") + "','" + funcionario.Nome_func + "','" + funcionario.Cpf_func + "', '" + funcionario.Sexo_func + "','" + funcionario.RG_func1 + "','" + funcionario.Dtnasc_func.ToString("yyyy/MM/dd") + "','" + funcionario.Estcivil_func + "','" + funcionario.Tel_func + "','" + funcionario.Email_func + "','" + funcionario.Endereco_func + "','" + funcionario.Cep_func + "','" + funcionario.Uf_func + "','" + funcionario.Cid_func + "','" + funcionario.Bairro_func + "','" + funcionario.Compl_func + "','" + funcionario.Num_func + "','" + funcionario.DiaPagto_func + "','" + funcionario.Id_fin + "',0);");
            }
            else
            {
                executarComando("insert into funcionario values (0,'" + funcionario.Id_usu + "','" + funcionario.Id_cargo + "','" + funcionario.Sal_func.ToString().Replace(",", ".") + "','" + funcionario.Comissao_func.ToString().Replace(",", ".") + "','" + funcionario.Nome_func + "','" + funcionario.Cpf_func + "', '" + funcionario.Sexo_func + "','" + funcionario.RG_func1 + "','" + funcionario.Dtnasc_func.ToString("yyyy/MM/dd") + "','" + funcionario.Estcivil_func + "','" + funcionario.Tel_func + "','" + funcionario.Email_func + "','" + funcionario.Endereco_func + "','" + funcionario.Cep_func + "','" + funcionario.Uf_func + "','" + funcionario.Cid_func + "','" + funcionario.Bairro_func + "',NULL,'" + funcionario.Num_func + "','" + funcionario.DiaPagto_func + "','" + funcionario.Id_fin + "',0);");
            }
        }

        public void ExcluirFunc(String codFunc)
        {
            executarComando("update funcionario set status_func=1 where id_func='" + codFunc + "';");
        }

        public void AlterarFunc(Funcionario func, int id)
        {
            executarComando("update funcionario set id_usu='" + func.Id_usu + "', id_cargo='" + func.Id_cargo + "', sal_func='" + func.Sal_func.ToString().Replace(',', '.') + "', comissao_func='" + func.Comissao_func.ToString().Replace(',', '.') + "',nome_func='" + func.Nome_func + "', cpf_func='" + func.Cpf_func + "', sexo_func='" + func.Sexo_func + "',RG_func='" + func.RG_func1 + "',dtnasc_func='" + func.Dtnasc_func.ToString("yyyy/MM/dd") + "',estcivil_func='" + func.Estcivil_func + "',tel_func='" + func.Tel_func + "',email_func='" + func.Email_func + "',endereco_func='" + func.Endereco_func + "',cep_func='" + func.Cep_func + "',uf_func='" + func.Uf_func + "',cid_func='" + func.Cid_func + "',bairro_func='" + func.Bairro_func + "',compl_Func='" + func.Compl_func + "',num_func='" + func.Num_func + "', diaPagto_func='" + func.DiaPagto_func + "' where id_func ='" + id + "';");
        }

        public int ultimoID()
        {
            executarComando("select max(id_func) as id from funcionario;");
            if (Convert.ToInt32(tabela_memoria.Rows[0]["id"].ToString()) > 0)
            {
                return Convert.ToInt32(tabela_memoria.Rows[0]["id"].ToString());
            }
            else
            {
                return 0;
            }
        }

        public int quantidadeTotalFuncionarios()
        {
            executarComando("select count(id_func) as qtd from funcionario;");
            return Convert.ToInt32(tabela_memoria.Rows[0]["qtd"].ToString());
        }
    }
}


