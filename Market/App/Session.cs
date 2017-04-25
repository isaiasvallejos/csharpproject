using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Models;

namespace Shop.App {

    class Session {

        static public User User;

        /// <summary>
        /// Realiza o login de um usuário na sessão.
        /// </summary>
        /// <param name="user"></param>
        public static void Login(User user) {
            User = user;
        }

        /// <summary>
        /// Realiza o logout de um usuário na sessão.
        /// </summary>
        public static void Logout() {
            User = null;
        }

    }

}
