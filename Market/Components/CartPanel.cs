using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop.Models;

namespace Shop.Components {

    public partial class CartPanel : UserControl {

        public Order Order;
        public EventHandler ClickFinishOrder;

        public CartPanel() {
            InitializeComponent();
        }

        private void CartPanel_Load(object sender, EventArgs e) {
            Order = new Order();

            Order.Products = CartProductBox.CartProducts;
            CartProductBox.UpdateView();
        }

        public void UpdateView() {
            LabelCartProductsValue.Text = "$" + Order.ProductsValue.ToString("0.00");
            LabelCartShippingValue.Text = "$" + Order.ShippingValue.ToString("0.00");
            LabelCartDiscountValue.Text = "-$" + Order.DiscountValue.ToString("0.00");
            LabelCartTotalValue.Text = "$" + (Order.ProductsValue + Order.ShippingValue - Order.DiscountValue).ToString("0.00");
        }

        private void ComboBoxPayment_SelectedIndexChanged(object sender, EventArgs e) {
            ComboBox PaymentType = (ComboBox)sender;

            if(PaymentType.SelectedIndex == 0) {
                Order.Payment = Payment.InCash;
                Order.DiscountPercentage = 15;
            }

            if(PaymentType.SelectedIndex == 1) {
                Order.Payment = Payment.Installment1X;
                Order.DiscountPercentage = 0;
            }

            if (PaymentType.SelectedIndex == 2) {
                Order.Payment = Payment.Installment2X;
                Order.DiscountPercentage = 0;
            }

            if (PaymentType.SelectedIndex == 3) {
                Order.Payment = Payment.Installment3X;
                Order.DiscountPercentage = 0;
            }

            ButtonCartFinish.Focus();
            UpdateView();

        }

        private void ButtonCartFinish_Click(object sender, EventArgs e) {
            if (ClickFinishOrder != null) ClickFinishOrder(sender, e);
        }

        public bool ValidateProducts() {
            return CartProductBox.CartProducts.Count() > 0;
        }

        public bool ValidatePayment() {
            return Order.Payment != null && !Order.Payment.Equals("");
        }

    }

}
