using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espetinho_TCC.Model
{
    class Comanda
    {
        int id_com, id_func, id_pagto, id_cli, id_fin;
        double valor_com;
        DateTime data_com, hora_com;

        public int Id_com { get => id_com; set => id_com = value; }
        public int Id_func { get => id_func; set => id_func = value; }
        public int Id_pagto { get => id_pagto; set => id_pagto = value; }
        public double Valor_com { get => valor_com; set => valor_com = value; }
        public DateTime Data_com { get => data_com; set => data_com = value; }
        public DateTime Hora_com { get => hora_com; set => hora_com = value; }
        public int Id_cli { get => id_cli; set => id_cli = value; }
        public int Id_fin { get => id_fin; set => id_fin = value; }
    }
}
