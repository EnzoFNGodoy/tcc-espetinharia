using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espetinho_TCC.Model
{
    class Financas
    {
        #region Declaração
        String obs_fin, tipo_fin;
        int id_fin;
        double valor_fin;
        DateTime data_fin;
        #endregion

        #region Encapsulamento
        public string Obs_fin { get => obs_fin; set => obs_fin = value; }
        public string Tipo_fin { get => tipo_fin; set => tipo_fin = value; }
        public int Id_fin { get => id_fin; set => id_fin = value; }
        public double Valor_fin { get => valor_fin; set => valor_fin = value; }
        public DateTime Data_fin { get => data_fin; set => data_fin = value; }
        #endregion
    }
}
