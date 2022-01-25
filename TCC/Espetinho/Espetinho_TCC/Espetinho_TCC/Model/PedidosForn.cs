using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espetinho_TCC.Model
{
    class PedidosForn
    {
        int id_ped, id_forn;
        Double valor_ped;
        DateTime data_ped, hora_ped;

        public int Id_ped { get => id_ped; set => id_ped = value; }
        public int Id_forn { get => id_forn; set => id_forn = value; }
        public double Valor_ped { get => valor_ped; set => valor_ped = value; }
        public DateTime Data_ped { get => data_ped; set => data_ped = value; }
        public DateTime Hora_ped { get => hora_ped; set => hora_ped = value; }
    }
}
