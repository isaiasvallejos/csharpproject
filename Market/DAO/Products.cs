using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using System.Data.Entity;
using Shop.Models;
using Shop.App;

namespace Shop.DAO {

    class Products {

        /// <summary>
        /// Adiciona um novo produto.
        /// </summary>
        /// <param name="product"></param>
        public static void Add(Product product) {

            using (ShopContext db = new ShopContext()) {

                if (product.Category != null) {

                    // Referencia a categoria ao produto
                    product.CategoryID = product.Category.ID;

                    // Remove a categoria do produto do contexto
                    product.Category = null;

                }

                db.Products.Add(product);
                db.SaveChanges();

            }

        }

        /// <summary>
        /// Atualiza um produto.
        /// </summary>
        /// <param name="product"></param>
        public static void Update(Product product) {

            using (ShopContext db = new ShopContext()) {

                if (product.Category != null) {

                    // Referencia a categoria ao produto
                    product.CategoryID = product.Category.ID;

                    // Remove a categoria do produto do contexto
                    product.Category = null;

                }

                db.Products.Attach(product);
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();

            }

        }

        /// <summary>
        /// Desabilita um produto.
        /// </summary>
        /// <param name="product"></param>
        public static void Disable(Product product) {

            using (ShopContext db = new ShopContext()) {

                if (product.Category != null) {

                    // Remove a categoria do produto do contexto
                    product.Category = null;

                }

                product.Enabled = false;

                db.Products.Attach(product);
                db.Entry(product).Property(p => p.Enabled).IsModified = true;
                db.SaveChanges();

            }

        }

        /// <summary>
        /// Lista todos os produtos.
        /// </summary>
        /// <returns></returns>
        public static List<Product> List() {

            using (ShopContext db = new ShopContext()) {

                return db.Products
                    .Include("Category")
                    .ToList();

            }

        }

        /// <summary>
        /// Lista todos os produtos ativos.
        /// </summary>
        /// <returns></returns>
        public static List<Product> ListEnableds() {

            using (ShopContext db = new ShopContext()) {

                return db.Products
                    .Include("Category")
                    .Where(product => product.Enabled)
                    .ToList();

            }

        }

    }

}
