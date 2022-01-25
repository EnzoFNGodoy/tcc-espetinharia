using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espetinho_TCC.Model
{
    class Cargo
    {
        string tipo_cargo;
        int id_cargo;

        public string Tipo_cargo { get => tipo_cargo; set => tipo_cargo = value; }
        public int Id_cargo { get => id_cargo; set => id_cargo = value; }
    }
}
