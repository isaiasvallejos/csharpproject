using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Shop.Models;

namespace Shop.App
{
    public class MarketContext : DbContext {

        public MarketContext() : base("MarketContext")
        {          
        }

        public DbSet<User> Users 
        {
            get;
            set;
        }

        public DbSet<Customer> Customers {
            get;
            set;
        }

        public DbSet<Category> Categories
        {
            get;
            set;
        }

        public DbSet<Product> Products
        {
            get;
            set;
        }

        public DbSet<Order> Orders {
            get;
            set;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
