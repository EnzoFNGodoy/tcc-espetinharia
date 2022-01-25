using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espetinho_TCC.Model
{
    class Auditoria
    {
        #region Variáveis
        String acao_aud, tabela_aud, obs_aud;
        int id_aud, id_func;
        DateTime data_aud, hora_aud;
        #endregion

        #region Encapsulamento
        public string Acao_aud { get => acao_aud; set => acao_aud = value; }
        public string Tabela_aud { get => tabela_aud; set => tabela_aud = value; }
        public string Obs_aud { get => obs_aud; set => obs_aud = value; }
        public int Id_aud { get => id_aud; set => id_aud = value; }
        public int Id_func { get => id_func; set => id_func = value; }
        public DateTime Data_aud { get => data_aud; set => data_aud = value; }
        public DateTime Hora_aud { get => hora_aud; set => hora_aud = value; }
        #endregion
    }
}
