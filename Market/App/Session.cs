using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Models;

namespace Shop.App
{
    class Session
    {
        static public User User;

        public static void Login(User _user)
        {
            User = _user;
        }
    }
}
