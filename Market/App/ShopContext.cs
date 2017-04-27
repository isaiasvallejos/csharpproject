using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Shop.Models;

namespace Shop.App {

    public class ShopContext : DbContext {

        public ShopContext() : base("ShopContext") { }

        public DbSet<User> Users {
            get;
            set;
        }

        public DbSet<Customer> Customers {
            get;
            set;
        }

        public DbSet<Manager> Managers {
            get;
            set;
        }

        public DbSet<Category> Categories {
            get;
            set;
        }

        public DbSet<Product> Products {
            get;
            set;
        }

        public DbSet<Order> Orders {
            get;
            set;
        }

        public DbSet<OrderProduct> OrderProducts {
            get;
            set;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {

            // Indica a convenção de pluralização das tabelas em inglês (e.g. Order => Orders)
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }

    }
}
