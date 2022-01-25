using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espetinho_TCC.Model
{
    class Fornecedor
    {
        int id_forn;
        string nome_forn, cpf_forn, cnpj_forn, tel_forn, email_forn;

        public int Id_forn { get => id_forn; set => id_forn = value; }
        public string Nome_forn { get => nome_forn; set => nome_forn = value; }
        public string Cpf_forn { get => cpf_forn; set => cpf_forn = value; }
        public string Cnpj_forn { get => cnpj_forn; set => cnpj_forn = value; }
        public string Tel_forn { get => tel_forn; set => tel_forn = value; }
        public string Email_forn { get => email_forn; set => email_forn = value; }
    }
}
