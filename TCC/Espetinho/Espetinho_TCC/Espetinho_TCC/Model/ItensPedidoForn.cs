using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espetinho_TCC.Model
{
    class ItensPedidoForn
    {
        int id_ped, id_itsped, id_prod, qtd_itens;

        public int Id_ped { get => id_ped; set => id_ped = value; }
        public int Id_itsped { get => id_itsped; set => id_itsped = value; }
        public int Id_prod { get => id_prod; set => id_prod = value; }
        public int Qtd_itens { get => qtd_itens; set => qtd_itens = value; }
    }
}
