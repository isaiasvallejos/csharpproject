using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Customer : User
    {

        public string Phone
        {
            get;
            set;
        }

        public string Document
        {
            get;
            set;
        }

        public Address Address {
            get;
            set;
        }

        public List<Order> Orders {
            get;
        }

        public Customer() {
            Orders = new List<Order>();
        }

    }
}
