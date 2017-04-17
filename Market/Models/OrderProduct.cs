using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Models {

    public class OrderProduct {

        [Key]
        public int ID {
            get;
            set;
        }

        [ForeignKey("Order")]
        public int OrderID {
            get;
            set;
        }

        public Order Order {
            get;
            set;
        }

        [ForeignKey("Product")]
        public int ProductID {
            get;
            set;
        }

        public Product Product {
            get;
            set;
        }

        public int Quantity {
            get;
            set;
        }

        public double Value {
            get;
            set;
        }

        public OrderProduct() {
            Product = new Product();
        }

    }

}
