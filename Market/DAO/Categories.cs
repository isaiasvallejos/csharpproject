using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Models;
using Shop.App;

namespace Shop.DAO {

    class Categories {

        /// <summary>
        /// Adiciona uma nova categoria.
        /// </summary>
        /// <param name="category"></param>
        public static void Add(Category category) {

            using (ShopContext db = new ShopContext()) {

                if (category.Products != null) {

                    // Remove os produtos da categoria do contexto
                    category.Products = null;

                }

                db.Categories.Add(category);
                db.SaveChanges();

            }

        }

        /// <summary>
        /// Encontra uma categoria pelo seu nome.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static Category FindOneByName(string name) {

            using (ShopContext db = new ShopContext()) {

                return db.Categories
                    .Include("Products")
                    .FirstOrDefault(category => category.Name.Equals(name));

            }

        }

        /// <summary>
        /// Lista todas as categorias.
        /// </summary>
        /// <returns></returns>
        public static List<Category> List() {

            using (ShopContext db = new ShopContext()) {

                return db.Categories
                    .Include("Products")
                    .ToList();

            }

        }

    }
}
