using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Models;
using Shop.App;

namespace Shop.DAO
{
    class Users
    {
        /// <summary>
        /// Adiciona um novo usuário.
        /// </summary>
        public static void Add(User user)
        {
            MarketContext db = new MarketContext();

            db.Users.Add(user);
            db.SaveChanges();
        }

        /// <summary>
        /// Seleciona um usuário baseado no seus dados de login (nome de usuário e senha).
        /// </summary>
        public static User FindOneByLogin(string username, string password)
        {
            MarketContext db = new MarketContext();

            return db.Users.FirstOrDefault(user => user.Username.Equals(username) && user.Password.Equals(password));
        }

        /// <summary>
        /// Seleciona um usuário baseado no seu nome de usuário.
        /// </summary>
        public static User FindOneByUsername(string username)
        {
            MarketContext db = new MarketContext();

            return db.Users.FirstOrDefault(user => user.Username.Equals(username));
        }

    }
}
