using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espetinho_TCC.Utils
{
    class Dados
    {
        static string permissao;
        static int idUsu;

        public static int IdUsu { get => idUsu; set => idUsu = value; }
        public static string Permissao { get => permissao; set => permissao = value; }
    }
}
