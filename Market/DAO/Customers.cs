using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Shop.Models;
using Shop.App;

namespace Shop.DAO {

    class Customers {

        /// <summary>
        /// Adiciona um novo cliente.
        /// </summary>
        /// <param name="customer"></param>
        public static void Add(Customer customer) {

            using (ShopContext db = new ShopContext()) {

                // Encripta a senha para MD5
                customer.Password = Util.Encryptor.MD5Hash(customer.Password);

                db.Users.Add(customer);
                db.SaveChanges();

            }

        }

        /// <summary>
        /// Atualiza um cliente.
        /// </summary>
        /// <param name="customer"></param>
        public static void Update(Customer customer) {

            using (ShopContext db = new ShopContext()) {

                // Vincula o cliente ao contexto
                db.Customers.Attach(customer);

                // Altera seu estado para modificado
                db.Entry(customer).State = EntityState.Modified;
                db.Entry(customer.Address).State = EntityState.Modified;

                db.SaveChanges();

            }

        }

        /// <summary>
        /// Encontra um cliente pelo seu nome de usuário.
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static Customer FindOneByUsername(string username) {

            using (ShopContext db = new ShopContext()) {

                return db.Customers
                    .Include("Address")
                    .Include("Orders.Products.Product")
                    .FirstOrDefault(user => user.Username.Equals(username));

            }

        }

        /// <summary>
        /// Encontra um cliente pelo seu nº de documento (CPF).
        /// </summary>
        /// <param name="document"></param>
        /// <returns></returns>
        public static Customer FindOneByDocument(string document) {

            using (ShopContext db = new ShopContext()) {

                return db.Customers
                    .Include("Address")
                    .Include("Orders.Products.Product")
                    .FirstOrDefault(user => user.Document.Equals(document));

            }

        }

        /// <summary>
        /// Encontra um cliente pelo seu nome de usuário e senha (login).
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static Customer FindOneByLogin(string username, string password) {

            using (ShopContext db = new ShopContext()) {

                password = Util.Encryptor.MD5Hash(password);

                return db.Customers
                    .Include("Address")
                    .Include("Orders.Products.Product")
                    .FirstOrDefault(customer => customer.Username.Equals(username) && customer.Password.Equals(password));

            }

        }

        /// <summary>
        /// Lista todos os clientes.
        /// </summary>
        /// <returns></returns>
        public static List<Customer> ListEnableds() {

            using (ShopContext db = new ShopContext()) {

                return db.Customers
                    .Include("Address")
                    .Include("Orders.Products.Product")
                    .Where(customer => customer.Enabled)
                    .ToList();

            }

        }

        /// <summary>
        /// Desabilita um cliente.
        /// </summary>
        /// <param name="customer"></param>
        public static void Disable(Customer customer) {

            using (ShopContext db = new ShopContext()) {
                customer.Enabled = false;

                db.Customers.Attach(customer);
                db.Entry(customer).Property(p => p.Enabled).IsModified = true;
                db.SaveChanges();

            }

        }

    }
}
