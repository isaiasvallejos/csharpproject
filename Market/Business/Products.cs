using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Models;

namespace Shop.Business {

    class Products {

        /// <summary>
        /// Calcula o valor de promoção de um produto.
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public static double CalculatePromotionValue(Product product) {

            double adjustment = Math.Pow(10, 1);
            double value = product.Value - (product.Value * product.PromotionPercentage / 100);

            return Math.Floor(value * adjustment) / adjustment;

        }

    }

}
