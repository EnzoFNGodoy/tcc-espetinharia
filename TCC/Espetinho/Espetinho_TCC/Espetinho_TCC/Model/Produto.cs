using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espetinho_TCC.Model
{
    class Produto
    {
        #region Declaração
        int id_prod, id_tipoprod, id_forn, qtdEst_prod;
        string nome_prod, foto_prod, desc_prod, fotoRelatorio_prod;
        double preco_prod, custo_prod;
        #endregion

        #region Encapsulamento
        public int Id_prod { get => id_prod; set => id_prod = value; }
        public int Id_tipoprod { get => id_tipoprod; set => id_tipoprod = value; }
        public int Id_forn { get => id_forn; set => id_forn = value; }
        public int QtdEst_prod { get => qtdEst_prod; set => qtdEst_prod = value; }
        public string Nome_prod { get => nome_prod; set => nome_prod = value; }
        public double Preco_prod { get => preco_prod; set => preco_prod = value; }
        public string Foto_prod { get => foto_prod; set => foto_prod = value; }
        public double Custo_prod { get => custo_prod; set => custo_prod = value; }
        public string Desc_prod { get => desc_prod; set => desc_prod = value; }
        #endregion
    }
}

