using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Models {

    public class Address {

        [Key]
        [ForeignKey("Customer")]
        public int CustomerID {
            get;
            set;
        }

        public string Name {
            get;
            set;
        }

        public string City {
            get;
            set;
        }

        public string State {
            get;
            set;
        }

        public string ZipCode {
            get;
            set;
        }
       
        public Customer Customer {
            get;
            set;
        }

    }

}
