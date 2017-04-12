using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Models;
using Shop.App;

namespace Shop.DAO
{
    class Products
    {
        /// <summary>
        /// Adiciona um novo produto.
        /// </summary>
        public static void Add(Product product)
        {
            MarketContext db = new MarketContext();

            db.Products.Add(product);
            db.SaveChanges();
        }

        /// <summary>
        /// Lista todos os produtos.
        /// </summary>
        public static List<Product> List()
        {
            using (MarketContext db = new MarketContext()) {
                return db.Products
                        .Include("Category")
                        .ToList();
            }
        }

    }
}
