using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espetinho_TCC.Model
{
    class SaidaEstoque
    {
        string obs_saiEst;
        int id_saiEst, id_fin;
        double valor_saiEst;
        DateTime data_saiEst, hora_saiEst;

        public int Id_saiEst { get => id_saiEst; set => id_saiEst = value; }
        public DateTime Data_saiEst { get => data_saiEst; set => data_saiEst = value; }
        public DateTime Hora_saiEst { get => hora_saiEst; set => hora_saiEst = value; }
        public string Obs_saiEst { get => obs_saiEst; set => obs_saiEst = value; }
        public double Valor_saiEst { get => valor_saiEst; set => valor_saiEst = value; }
        public int Id_fin { get => id_fin; set => id_fin = value; }
    }
}
