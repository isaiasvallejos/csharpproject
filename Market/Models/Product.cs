using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Models {

    public class Product {

        [Key]
        public int ID {
            get;
            set;
        }

        [ForeignKey("Category")]
        public int CategoryID {
            get;
            set;
        }

        public Category Category {
            get;
            set;
        }

        public string Name {
            get;
            set;
        }

        public string Description {
            get;
            set;
        }

        public double Value {
            get;
            set;
        }

        public bool Promotion {
            get;
            set;
        }

        public int PromotionPercentage {
            get;
            set;
        }

        public int Quantity {
            get;
            set;
        }

        public byte[] Image {
            get;
            set;
        }

        public bool Enabled {
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
        public double PromotionValue {

            get {

                return Business.Products.CalculatePromotionValue(this);

            }

        }

    }
}