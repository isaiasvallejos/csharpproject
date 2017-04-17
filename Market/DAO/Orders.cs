using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Shop.Models;
using Shop.App;

namespace Shop.DAO {

    class Orders {

        public static void Add(Order order) 
        {
            MarketContext db = MarketSingleContext.Context;

            db.Orders.Add(order);
            db.SaveChanges();
        }

    }

}
