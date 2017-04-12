using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Shop.App;
using Shop.Models;
using Shop.Util;
using Shop.DAO;
using Shop.Components;

namespace Shop
{
    public partial class FormMain : Form {
        public ProductBox ProductBox;
        public Cart Cart;

        public FormMain() {
            InitializeComponent();
        }

        private void ButtonLoginOpen_Click(object sender, EventArgs e) {
            FormLogin Login = new FormLogin(this);
            Login.ShowDialog();
        }

        private void ButtonSignUpOpen_Click(object sender, EventArgs e) {
            FormSignUp SignUp = new FormSignUp(this);
            SignUp.ShowDialog();
        }

        private void ButtonProduct_Click(object sender, EventArgs e) {
            Button Button = (Button)sender;
            Product Product = (Button.Parent.Tag as Product);

            FormProductBuy ProductBuy = new FormProductBuy(this, Product);
            ProductBuy.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e) {
            LoadProductBox();
            LoadCart();

            ComboBoxOrderBy.SelectedIndex = 0;
            TextBoxSearch.Focus();

            SetProductBox();
            ProductBox.Update();
        }

        private void LoadProductBox() {
            ProductBox = new ProductBox(PanelProducts);

            ProductBox.OnBuy = ButtonProduct_Click;

            ProductBox.Products = Products.List();
            ProductBox.Initialize();
        }

        private void LoadCart() {
            Cart = new Cart(PanelCart);
            Cart.OnChangeQuantity = NumericCartProductQuantity_ValueChanged;
            Cart.OnRemove = ButtonCartProductRemove_Click;

            Cart.Initialize();
            UpdateCartTotals();
            Cart.Update();
        }

        private void ComboBoxOrderBy_SelectedIndexChanged(object sender, EventArgs e) {
            TextBoxSearch.Focus();

            SetProductBox();
            ProductBox.Update();
        }

        private void SetProductBox() {

            ProductBox.Search(TextBoxSearch.Text);

            if (ComboBoxOrderBy.SelectedIndex == 0) {
                ProductBox.OrderByAlphabetical();
            }

            if (ComboBoxOrderBy.SelectedIndex == 1) {
                ProductBox.OrderByLowestPrice();
            }

            if (ComboBoxOrderBy.SelectedIndex == 2) {
                ProductBox.OrderByBiggestPrice();
            }

            ProductBox.MoveDisabledProductsToEnd();

        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e) {
            SetProductBox();

            if (!ProductBox.LastProductPanels.SequenceEqual(ProductBox.CurrentProductPanels)) {
                ProductBox.Update();
            }
        }

        private void NumericCartProductQuantity_ValueChanged(object sender, EventArgs e) {

            NumericUpDown Quantity = (sender as NumericUpDown);
            Panel Panel = (Quantity.Parent as Panel);

            CartProduct CartProduct = (Panel.Tag as CartProduct);
            CartProduct.Quantity = Convert.ToInt16(Quantity.Value);

            Label Value = (Panel.Controls.Find("LabelCartProduct" + Panel.TabIndex.ToString() + "Value", true)[0] as Label);
            Value.Text = "$" + (Convert.ToInt16(CartProduct.Quantity) * CartProduct.Product.Value).ToString("0.00");

            UpdateCartTotals();

        }

        private void ButtonCartProductRemove_Click(object sender, EventArgs e) {

            if (MessageBox.Show("Deseja excluir o produto do seu carrinho?", "Produto", MessageBoxButtons.OKCancel, MessageBoxIcon.Information).Equals(DialogResult.OK)) {
                Panel Panel = ((sender as Button).Parent as Panel);
                CartProduct CartProduct = (Panel.Tag as CartProduct);

                Cart.CartProducts.Remove(CartProduct);
                Cart.Update();
            }

            UpdateCartTotals();

        }

        public void UpdateCartTotals() {

            double discount = 0;

            double totalProducts = Cart.TotalCartProducts();

            if (totalProducts > 0) {
                LabelCartSubtotalValue.Text = "$" + totalProducts.ToString("0.00");
            } else {
                LabelCartSubtotalValue.Text = "$0";
            }

            double totalShipping = Cart.TotalShipping();

            if (totalShipping > 0) {
                LabelCartShippingValue.Text = "$" + totalShipping.ToString("0.00");
            } else {
                LabelCartShippingValue.Text = "$0";
            }

            if(discount > 0) {
                LabelCartDiscountValue.Text = "-$" + discount.ToString("0.00");
            } else {
                LabelCartDiscountValue.Text = "$0";
            }

            double total = (totalProducts + totalShipping) - discount;

            if (total > 0) {
                LabelCartTotalValue.Text = "$" + total.ToString("0.00");
            } else {
                LabelCartTotalValue.Text = "$0";
            }

        }

        private void TextBoxUsername_Enter(object sender, EventArgs e) {
            if (TextBoxUsername.Text.Equals("Nome de Usuário")) {
                TextBoxUsername.Text = "";
                TextBoxUsername.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }

        private void TextBoxUsername_Leave(object sender, EventArgs e) {
            if (TextBoxUsername.Text.Equals("")) {
                TextBoxUsername.Text = "Nome de Usuário";
                TextBoxUsername.ForeColor = System.Drawing.SystemColors.ControlDark;
            }
        }

        private void TextBoxPassword_Enter(object sender, EventArgs e) {
            if (TextBoxPassword.Text.Equals("Senha")) {
                TextBoxPassword.Text = "";
                TextBoxPassword.ForeColor = System.Drawing.SystemColors.WindowText;
                TextBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void TextBoxPassword_Leave(object sender, EventArgs e) {
            if (TextBoxPassword.Text.Equals("")) {
                TextBoxPassword.UseSystemPasswordChar = false;
                TextBoxPassword.Text = "Senha";
                TextBoxPassword.ForeColor = System.Drawing.SystemColors.ControlDark;
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("Deseja sair da Prophet Shop?", "Sair", MessageBoxButtons.OKCancel, MessageBoxIcon.Information).Equals(DialogResult.Cancel)) {
                e.Cancel = true;
            }
        }

    }
}
