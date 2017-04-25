using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Models {

    public class Order {

        [Key]
        public int ID {
            get;
            set;
        }

        [ForeignKey("Customer")]
        public int CustomerID {
            get;
            set;
        }

        public Customer Customer {
            get;
            set;
        }

        public List<OrderProduct> Products {
            get;
            set;
        }

        public string Payment {
            get;
            set;
        }

        public string Status {
            get;
            set;
        }

        public DateTime CreatedAt {
            get;
            set;
        }

        public DateTime UpdatedAt {
            get;
            set;
        }

        public double DiscountValue {

            get {

                return Business.Orders.CalculateDiscountValue(this);

            }

        }

        public double ShippingValue {

            get {

                return Business.Orders.CalculateShippingValue(this);

            }

        }

        [NotMapped]
        public double ProductsValue {

            get {

                return Business.Orders.CalculateProductsValue(this);

            }

        }

        [NotMapped]
        public int DiscountPercentage {
            get;
            set;
        }

        public Order() {
            Products = new List<OrderProduct>();
        }

    }

}

