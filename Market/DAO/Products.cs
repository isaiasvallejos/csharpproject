using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using System.Data.Entity;
using Shop.Models;
using Shop.App;

namespace Shop.DAO
{
    class Products
    {

        public static void Add(Product Product)
        {
            MarketContext db = MarketSingleContext.Context;

            db.Products.Add(Product);
            db.SaveChanges();
        }

        public static List<Product> List()
        {
            MarketContext db = MarketSingleContext.Context;

            return db.Products
                .Include("Category")
                .ToList();       
        }

    }
}
