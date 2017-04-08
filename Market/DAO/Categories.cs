using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Market.Models;
using Market.App;

namespace Market.DAO
{
    class Categories
    {
        /// <summary>
        /// Adiciona uma nova categoria.
        /// </summary>
        public static void Add(Category category)
        {
            MarketContext db = new MarketContext();

            db.Categories.Add(category);
            db.SaveChanges();
        }

        /// <summary>
        /// Seleciona uma categoria baseada no seu nome.
        /// </summary>
        public static Category FindOneByName(string name)
        {
            MarketContext db = new MarketContext();

            return db.Categories.FirstOrDefault(category => category.Name.Equals(name));
        }

    }
}
