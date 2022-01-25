using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espetinho_TCC.Model
{
    class Pagamento
    {
        int id_pagto;
        string tipo_pagto;

        public int Id_pagto { get => id_pagto; set => id_pagto = value; }
        public string Tipo_pagto { get => tipo_pagto; set => tipo_pagto = value; }
    }
}
