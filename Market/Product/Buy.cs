using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop.App;
using Shop.Models;
using Shop.Util;

namespace Shop {

    public partial class FormProductBuy : Form {

        private FormMain Main;
        private Product Product;

        public FormProductBuy(FormMain main, Product product)
        {
            Main = main;
            Product = product;

            InitializeComponent();
        }

        private void FormProductBuy_Load(object sender, EventArgs e)
        {
            Text = Product.Category.Name + " – " + Product.Name;

            LabelName.Text = Product.Name;

            if (Product.Promotion) {
                LabelValue.Text = "$" + Product.PromotionValue.ToString("0.00");
            } else {
                LabelValue.Text = "$" + Product.Value.ToString("0.00");
            }

            TextBoxDescription.Text = Product.Description;
            PictureBoxImage.Image = Util.ImageConverter.ByteArrayToImage(Product.Image);

            OrderProduct existentCartProduct = Main.CartPanel.Order.Products.FirstOrDefault(cartProduct => cartProduct.Product.Equals(Product));

            if (existentCartProduct != null) {

                int quantity = Product.Quantity - existentCartProduct.Quantity;

                if (quantity > 0) {

                    NumericQuantity.Maximum = quantity;

                } else {

                    NumericQuantity.Maximum = 0;
                    NumericQuantity.Enabled = false;
                    ButtonBuy.Enabled = false;

                }

            } else {

                NumericQuantity.Maximum = Product.Quantity;

            }
                        
        }

        private void NumericQuantity_ValueChanged(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt16(NumericQuantity.Value);

            if (quantity > 0) {

                if (Product.Promotion) {
                    LabelValue.Text = "$" + (quantity * Product.PromotionValue).ToString("0.00");
                } else {
                    LabelValue.Text = "$" + (quantity * Product.Value).ToString("0.00");
                }

            }  
        }

        private void ButtonBuy_Click(object sender, EventArgs e) {

            OrderProduct cartProduct = new OrderProduct();
            cartProduct.Product = Product;
            cartProduct.Quantity = Convert.ToInt16(NumericQuantity.Value);

            if (Product.Promotion) {
                cartProduct.Value = Product.PromotionValue;
            } else {
                cartProduct.Value = Product.Value;
            }

            OrderProduct existentCartProduct = Main.CartPanel.Order.Products.FirstOrDefault(_cartProduct => _cartProduct.Product.Equals(cartProduct.Product));

            if (existentCartProduct == null) {
                Main.CartPanel.Order.Products.Add(cartProduct);
            } else {
                existentCartProduct.Quantity += cartProduct.Quantity;
            }

            Main.CartPanel.CartProductBox.UpdateView();
            Main.CartPanel.UpdateCartTotals();

            Close();
        }
    }
}
