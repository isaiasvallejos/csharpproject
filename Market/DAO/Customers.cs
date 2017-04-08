using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Market.Models;
using Market.App;

namespace Market.DAO
{
    class Customers
    {

        /// <summary>
        /// Seleciona um usuário baseado no seu nº de documento.
        /// </summary>
        public static Customer FindOneByDocument(string document)
        {
            MarketContext db = new MarketContext();

            return (Customer) db.Users.FirstOrDefault(customer => (customer as Customer).Document.Equals(document));
        }

    }
}
