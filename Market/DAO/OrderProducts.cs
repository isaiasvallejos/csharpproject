using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using System.Data.Entity;
using Shop.Models;
using Shop.App;

namespace Shop.DAO {

    class OrderProducts {

        /// <summary>
        /// Lista todos os produtos de pedidos.
        /// </summary>
        /// <returns></returns>
        public static List<OrderProduct> List() {

            using (ShopContext db = new ShopContext()) {

                return db.OrderProducts
                    .Include("Order")
                    .Include("Product")
                    .ToList();

            }

        }

    }
}
