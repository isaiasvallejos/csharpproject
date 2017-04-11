using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models
{
    public class Product
    {

        public int ID
        {
            get;
            set;
        }

        public int CategoryID
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public double Value
        {
            get;
            set;
        }

        public int Quantity
        {
            get;
            set;
        }

        public byte[] Image
        {
            get;
            set;
        }

        public DateTime CreatedAt
        {
            get;
            set;
        }

        public DateTime UpdatedAt
        {
            get;
            set;
        }

        public Category Category {
            get;
            set;
        }

    }
}
