using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espetinho_TCC.Model
{
    class Clientes
    {
        string nome_cli, cpf_cli, cnpj_cli, email_cli, tel_cli;
        int id_cli;

        public string Nome_cli { get => nome_cli; set => nome_cli = value; }
        public string Cpf_cli { get => cpf_cli; set => cpf_cli = value; }
        public string Cnpj_cli { get => cnpj_cli; set => cnpj_cli = value; }
        public string Email_cli { get => email_cli; set => email_cli = value; }
        public int Id_cli { get => id_cli; set => id_cli = value; }
        public string Tel_cli { get => tel_cli; set => tel_cli = value; }
    }
}
