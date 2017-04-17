using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Models
{
    public class Category
    {

        [Key]
        public int ID
        {
            get;
            set;
        }

        public string Name
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

        public List<Product> Products {
            get;
            set;
        }

        public Category() {
            Products = new List<Product>();
        }

    }
}
