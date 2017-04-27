using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Shop.Models;
using Shop.App;

namespace Shop.DAO {

    class Managers {

        /// <summary>
        /// Adiciona um novo administrador.
        /// </summary>
        /// <param name="manager"></param>
        public static void Add(Manager manager) {

            using (ShopContext db = new ShopContext()) {

                // Encripta a senha para MD5
                manager.Password = Util.Encryptor.MD5Hash(manager.Password);

                db.Users.Add(manager);
                db.SaveChanges();

            }

        }

        /// <summary>
        /// Lista todos os administradores.
        /// </summary>
        /// <returns></returns>
        public static List<Manager> List() {

            using (ShopContext db = new ShopContext()) {

                return db.Managers.ToList();

            }

        }

        /// <summary>
        /// Encontra um administrador pelo seu nome de usuário e senha (login).
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static Manager FindOneByLogin(string username, string password) {

            using (ShopContext db = new ShopContext()) {

                password = Util.Encryptor.MD5Hash(password);

                return db.Managers
                    .FirstOrDefault(manager => manager.Username.Equals(username) && manager.Password.Equals(password));

            }

        }

    }
}
