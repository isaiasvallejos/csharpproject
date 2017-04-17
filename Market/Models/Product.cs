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

        public DateTime CreatedAt {
            get;
            set;
        }

        public DateTime UpdatedAt {
            get;
            set;
        }

        public Category Category {
            get;
            set;
        }

        [NotMapped]
        public double PromotionValue {

            get {
                double adjustment = Math.Pow(10, 1);
                double value = Value - (Value * PromotionPercentage / 100);

                return Math.Floor(value * adjustment) / adjustment; 
            }

            set { }
        }

    }
}