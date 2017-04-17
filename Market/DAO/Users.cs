using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.App;
using Shop.Models;
using Shop.Components;

namespace Shop.DAO {

    class Users {

        public static User FindOneByLogin(string username, string password) {
            MarketContext db = MarketSingleContext.Context;

            password = Util.Encryptor.MD5Hash(password);

            return db.Users
                .FirstOrDefault(user => user.Username.Equals(username) && user.Password.Equals(password));
        }

    }

}
