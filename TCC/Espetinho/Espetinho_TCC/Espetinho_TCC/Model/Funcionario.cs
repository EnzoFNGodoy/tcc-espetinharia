using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espetinho_TCC.Model
{
    class Funcionario
    {
        string nome_func, cpf_func, sexo_func, RG_func, estcivil_func, tel_func, email_func, endereco_func, cep_func,
            uf_func, cid_func, bairro_func, compl_func, comissao_func, diaPagto_func;
        int id_func, num_func, id_usu, id_cargo, id_fin;
        double sal_func;
        DateTime dtnasc_func;

        public string Nome_func { get => nome_func; set => nome_func = value; }
        public string Cpf_func { get => cpf_func; set => cpf_func = value; }
        public string Sexo_func { get => sexo_func; set => sexo_func = value; }
        public string RG_func1 { get => RG_func; set => RG_func = value; }
        public string Estcivil_func { get => estcivil_func; set => estcivil_func = value; }
        public string Tel_func { get => tel_func; set => tel_func = value; }
        public string Email_func { get => email_func; set => email_func = value; }
        public string Endereco_func { get => endereco_func; set => endereco_func = value; }
        public string Cep_func { get => cep_func; set => cep_func = value; }
        public string Uf_func { get => uf_func; set => uf_func = value; }
        public string Cid_func { get => cid_func; set => cid_func = value; }
        public string Bairro_func { get => bairro_func; set => bairro_func = value; }
        public string Compl_func { get => compl_func; set => compl_func = value; }
        public string Comissao_func { get => comissao_func; set => comissao_func = value; }
        public int Id_func { get => id_func; set => id_func = value; }
        public int Num_func { get => num_func; set => num_func = value; }
        public int Id_usu { get => id_usu; set => id_usu = value; }
        public int Id_cargo { get => id_cargo; set => id_cargo = value; }
        public double Sal_func { get => sal_func; set => sal_func = value; }
        public DateTime Dtnasc_func { get => dtnasc_func; set => dtnasc_func = value; }
        public int Id_fin { get => id_fin; set => id_fin = value; }
        public string DiaPagto_func { get => diaPagto_func; set => diaPagto_func = value; }
    }
}
