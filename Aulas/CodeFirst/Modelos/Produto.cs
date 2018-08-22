using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Modelos
{
    class Produto
    {
        public int ProdutoID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public decimal Impoosto { get; set; }

        //Relacionamento Produto === Categoria
        //FK - msm nome
        public int CategoriaID { get; set; }
        //NAvigation propertie
        public virtual Categoria _Categoria { get; set; }

    }
}
