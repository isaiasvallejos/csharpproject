using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models
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

    }
}
