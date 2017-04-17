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

        public string Payment {
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

        public double DiscountValue {
            get {

                return (ProductsValue + ShippingValue) * DiscountPercentage / 100;

            }

            set {
                DiscountValue = value;
            }
        }

        public double ShippingValue {

            get {

                double ShippingValuePerProduct = 1.50;
                return Products.Aggregate(0.00, (Sum, CartProduct) => Sum + (CartProduct.Quantity * ShippingValuePerProduct));

            }

            set {
                ShippingValue = value;
            }
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

        [NotMapped]
        public double ProductsValue {
            
            get {

                return Products.Aggregate(0.00, (Sum, CartProduct) => Sum + (CartProduct.Value * CartProduct.Quantity));

            }

            set { }
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

