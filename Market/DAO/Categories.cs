using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Models;
using Shop.App;

namespace Shop.DAO
{
    class Categories
    {

        public static void Add(Category Category)
        {
            MarketContext db = MarketSingleContext.Context;

            db.Categories.Add(Category);
            db.SaveChanges();
        }

        public static Category FindOneByName(string Name)
        {
            MarketContext db = MarketSingleContext.Context;

            return db.Categories
                .Include("Products")
                .FirstOrDefault(category => category.Name.Equals(Name));            
        }

        public static List<Category> List() {

            MarketContext db = MarketSingleContext.Context;

            return db.Categories
                .Include("Products")
                .ToList();
        }

    }
}
