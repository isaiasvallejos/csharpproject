﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Models;

namespace Shop.Business {

    class Orders {

        /// <summary>
        /// Calcula o valor total de desconto de um pedido.
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public static double CalculateDiscountValue(Order order) {

            return (CalculateProductsValue(order) + CalculateShippingValue(order)) * order.DiscountPercentage / 100;

        }

        /// <summary>
        /// Calcula o valor total em produtos de um pedido.
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public static double CalculateProductsValue(Order order) {

            return order.Products.Aggregate(0.00, (sum, cartProduct) => sum + (cartProduct.Value * cartProduct.Quantity));

        }

        /// <summary>
        /// Calcula o valor total em frete de um pedido.
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public static double CalculateShippingValue(Order order) {

            double valuePerProduct = 1.50;

            return order.Products.Aggregate(0.00, (sum, cartProduct) => sum + (cartProduct.Quantity * valuePerProduct));

        }

    }

}