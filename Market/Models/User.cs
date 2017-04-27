using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Models {

    public class User {

        [Key]
        public int ID {
            get;
            set;
        }

        public string Username {
            get;
            set;
        }

        public string Password {
            get;
            set;
        }

        public string Name {
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

    }
}
