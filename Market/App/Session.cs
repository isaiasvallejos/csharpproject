using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Market.Models;

namespace Market.App
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
