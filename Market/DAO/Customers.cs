using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Shop.Models;
using Shop.App;

namespace Shop.DAO
{
    class Customers
    {

        public static void Add(Customer customer)
        {
            MarketContext db = MarketSingleContext.Context;

            customer.Password = Util.Encryptor.MD5Hash(customer.Password);

            db.Users.Add(customer);
            db.SaveChanges();
        }

        public static Customer FindOneByUsername(string username)
        {
            MarketContext db = MarketSingleContext.Context;

            return db.Customers
                .Include("Address")
                .FirstOrDefault(user => user.Username.Equals(username));
        }

        public static Customer FindOneByDocument(string document) 
        {
            MarketContext db = MarketSingleContext.Context;

            return db.Customers
                .Include("Address")
                .FirstOrDefault(user => user.Document.Equals(document));
        }

    }
}
