using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espetinho_TCC.Model
{
    class TipoProduto
    {
        int id_tipoprod;
        string tipo_produto;

        public int Id_tipoprod { get => id_tipoprod; set => id_tipoprod = value; }
        public string Tipo_produto { get => tipo_produto; set => tipo_produto = value; }
    }
}
