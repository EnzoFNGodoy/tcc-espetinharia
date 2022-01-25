using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espetinho_TCC.Model
{
    class ItensComanda
    {
        int id_its, id_com, id_prod, qtd_itens;

        public int Id_its { get => id_its; set => id_its = value; }
        public int Id_com { get => id_com; set => id_com = value; }
        public int Id_prod { get => id_prod; set => id_prod = value; }
        public int Qtd_itens { get => qtd_itens; set => qtd_itens = value; }
    }
}
