using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Espetinho_TCC.WebServiceCorreios;
using System.Text.RegularExpressions;

namespace WebService.Utils
{
    class Correios
    {
        private String endereco, bairro, estado, cidade;

        public Correios(String cep)
        {
            cep = cep.Replace(".", "");
            cep = cep.Replace("-", "");
            cep = cep.Replace(" ", "");
            Regex Rgx = new Regex(@"^\d{8}$");
            if (Rgx.IsMatch(cep))
            {
                AtendeClienteClient webservice = new AtendeClienteClient("AtendeClientePort");
                try
                {
                    var resp = webservice.consultaCEP(cep);

                    if (resp != null)
                    {
                        endereco = resp.end;
                        estado = resp.uf;
                        cidade = resp.cidade;
                        bairro = resp.bairro;
                    }
                }
                catch { }
            }
        }

        public string Endereco { get => endereco; set => endereco = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Cidade { get => cidade; set => cidade = value; }
    }
}
