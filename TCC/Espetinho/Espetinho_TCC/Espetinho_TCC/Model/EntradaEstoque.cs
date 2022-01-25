using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espetinho_TCC.Model
{
    class EntradaEstoque
    {
        String obs_entEst;
        int id_entEst, id_prod, id_fin;
        Double valor_entEst;
        DateTime data_entEst, hora_entEst;

        public int Id_entEst { get => id_entEst; set => id_entEst = value; }
        public int Id_prod { get => id_prod; set => id_prod = value; }
        public DateTime Data_entEst { get => data_entEst; set => data_entEst = value; }
        public DateTime Hora_entEst { get => hora_entEst; set => hora_entEst = value; }
        public string Obs_entEst { get => obs_entEst; set => obs_entEst = value; }
        public double Valor_entEst { get => valor_entEst; set => valor_entEst = value; }
        public int Id_fin { get => id_fin; set => id_fin = value; }
    }
}
