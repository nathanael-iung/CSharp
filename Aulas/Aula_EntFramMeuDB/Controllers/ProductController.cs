using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_EntFramMeuDB.Controllers
{
    class ProductController
    {
        void Insert(Product prod)
        {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            contexto.Product.Add(prod);
            contexto.SaveChanges();
        }

        List<Product> TodosProducts()
        {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            return contexto.Product.ToList();
        }

        Product BuscaPorId(int id)
        {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            return contexto.Product.Find();
        }

        void Excluir(int id)
        {
            Product prodExcluir = BuscaPorId(id);

            if(prodExcluir != null)
            {
                AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
                contexto.Product.Remove(prodExcluir);
                contexto.SaveChanges();
            }
        }

        void Edit(int id, Product novosDadosProduct)
        {
            Product productAntigo = BuscaPorId(id);

            if(productAntigo != null)
            {
                productAntigo.Weight = novosDadosProduct.Weight;
                productAntigo.Color = novosDadosProduct.Color;
                productAntigo.BillOfMaterials = novosDadosProduct.BillOfMaterials;

                AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
                contexto.Entry(productAntigo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        List<Product> PesquisarPorCor(string cor)
        {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            var list = from prod in contexto.Product
                       where prod.Color == cor
                       select prod;

            return list.ToList();
        }






    }
}
