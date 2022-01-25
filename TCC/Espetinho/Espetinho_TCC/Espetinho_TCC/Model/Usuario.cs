using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espetinho_TCC.Model
{
    class Usuario
    {
        #region VARIAVEIS
        String nome_usu, senha_usu, foto_usu;
        int id_usu, id_tipousu;
        #endregion

        #region ENCAPSULAMENTO
        public string Nome_usu { get => nome_usu; set => nome_usu = value; }
        public string Senha_usu { get => senha_usu; set => senha_usu = value; }
        public int Id_usu { get => id_usu; set => id_usu = value; }
        public int Id_tipousu { get => id_tipousu; set => id_tipousu = value; }
        public string Foto_usu { get => foto_usu; set => foto_usu = value; }
        #endregion
    }
}
