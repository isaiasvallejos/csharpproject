using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Shop.Models;
using Shop.App;

namespace Shop.DAO {

    class Orders {

        /// <summary>
        /// Adiciona um novo pedido.
        /// </summary>
        /// <param name="order"></param>
        public static void Add(Order order) {

            using (ShopContext db = new ShopContext()) {
 
                if(order.Customer != null) {

                    // Referencia o cliente ao pedido
                    order.CustomerID = order.Customer.ID;

                    // Remove o cliente do pedido do contexto
                    order.Customer = null;

                }

                if(order.Products != null) {

                    order.Products.ForEach(delegate (OrderProduct orderProduct) {

                        // Vincula o produto ao contexto
                        db.Products.Attach(orderProduct.Product);

                        // Altera o estado do atributo de estoque para modificado
                        db.Entry(orderProduct.Product).Property(p => p.Quantity).IsModified = true;

                    });

                }

                db.Orders.Add(order);
                db.SaveChanges();

            }

        }

        /// <summary>
        /// Adiciona um novo pedido.
        /// </summary>
        /// <param name="order"></param>
        public static void Update(Order order) {

            using (ShopContext db = new ShopContext()) {

                if (order.Customer != null) {

                    // Referencia o cliente ao pedido
                    order.CustomerID = order.Customer.ID;

                    // Remove o cliente do pedido do contexto
                    order.Customer = null;

                }

                if (order.Products != null) {

                    if (order.Status.Equals("Cancelado")) {

                        order.Products.ForEach(delegate (OrderProduct orderProduct) {

                            // Retrocede o estoque do produto
                            orderProduct.Product.Quantity = orderProduct.Quantity + orderProduct.Product.Quantity;

                            // Vincula o produto ao contexto
                            db.Products.Attach(orderProduct.Product);

                            // Altera o estado do atributo de estoque para modificado
                            db.Entry(orderProduct.Product).Property(p => p.Quantity).IsModified = true;

                        });

                    } else {   
                        order.Products = null;
                    }

                }

                db.Orders.Attach(order);
                db.Entry(order).State = EntityState.Modified;

                db.SaveChanges();

            }

        }

        /// <summary>
        /// Lista todos os pedidos.
        /// </summary>
        /// <returns></returns>
        public static List<Order> List() {

            using (ShopContext db = new ShopContext()) {

                return db.Orders
                    .Include("Customer.Address")
                    .Include("Products.Product")
                    .ToList();

            }

        }

        /// <summary>
        /// Lista todos os pedidos de um cliente.
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public static List<Order> ListByCustomer(Customer customer) {

            using (ShopContext db = new ShopContext()) {

                return db.Orders
                    .Include("Customer.Address")
                    .Include("Products.Product")
                    .Where(order => order.Customer.ID == customer.ID)
                    .ToList();

            }

        }

    }

}
