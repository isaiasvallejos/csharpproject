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

        public FormProductBuy(FormMain _Main, Product _Product)
        {
            Main = _Main;
            Product = _Product;

            InitializeComponent();
        }

        private void FormProductBuy_Load(object sender, EventArgs e)
        {
            Text = Product.Category.Name + " – " + Product.Name;

            LabelName.Text = Product.Name;
            LabelValue.Text = "$" + Product.Value.ToString("0.00");
            TextBoxDescription.Text = Product.Description;
            PictureBoxImage.Image = ImageBytefy.ByteArrayToImage(Product.Image);

            OrderProduct CartProduct = Main.Cart.CartProducts.FirstOrDefault(cartProduct => cartProduct.Product.Equals(Product));

            if(CartProduct == null) {
                NumericQuantity.Maximum = Product.Quantity;
            } else {
                int Quantity = Product.Quantity - CartProduct.Quantity;

                if (Quantity > 0) {
                    NumericQuantity.Maximum = Quantity;
                } else {
                    NumericQuantity.Maximum = 0;
                    NumericQuantity.Enabled = false;
                    ButtonBuy.Enabled = false;
                }
            }
                        
        }

        private void NumericQuantity_ValueChanged(object sender, EventArgs e)
        {
            if(Convert.ToInt16(NumericQuantity.Value) > 0) {
                LabelValue.Text = "$" + (Convert.ToInt16(NumericQuantity.Value) * Product.Value).ToString("0.00");
            }  
        }

        private void ButtonBuy_Click(object sender, EventArgs e) {

            OrderProduct CartProduct = new OrderProduct();
            CartProduct.Product = Product;
            CartProduct.Quantity = Convert.ToInt16(NumericQuantity.Value);

            Main.Cart.Add(CartProduct);
            Main.Cart.Update();
            Main.UpdateCartTotals();

            Main.Focus();

            Close();
        }
    }
}
