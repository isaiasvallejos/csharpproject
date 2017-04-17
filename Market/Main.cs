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
using Shop.Components;

namespace Shop
{
    public partial class FormMain : Form {
  
        public FormMain() {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e) { 

            ProductBox.Products = DAO.Products.List();  
            ProductBox.ClickProductBuy += ProductBox_ClickProductBuy;

            ProductBox.UpdateView();

            ComboBoxOrderBy.SelectedIndex = 1;
            ComboBoxOrderBy.SelectedIndex = 0;

            CartPanel.CartProductBox.ChangeProductQuantity += CartProductBox_ChangeProductQuantity;
            CartPanel.CartProductBox.ClickProductRemove += CartProductBox_ClickProductRemove;
            CartPanel.ClickFinishOrder += CartPanel_ClickFinishOrder;

            Menu.Login += Menu_Login;
            Menu.Logout += Menu_Logout;
            Menu.Admin += Menu_Admin;
            Menu.Register += Menu_Register;

        }

        private void Reset() {

            ProductBox.Products = DAO.Products.List();
            ProductBox.UpdateView();

            CartPanel.Order.Products.Clear();
            CartPanel.CartProductBox.UpdateView();

        }

        private void Reload() {

            ProductBox.Products = DAO.Products.List();
            ProductBox.UpdateView();

        }

        public void Menu_Login(object sender, EventArgs e) {

            FormLogin login = new FormLogin(this);
            login.ShowDialog();

        }

        public void Menu_Register(object sender, EventArgs e) {

            FormRegister login = new FormRegister(this);
            login.ShowDialog();

        }

        public void Menu_Admin(object sender, EventArgs e) {

            FormLoginAdmin login = new FormLoginAdmin(this);
            login.ShowDialog();

        }

        public void Menu_Logout(object sender, EventArgs e) {

            if (MessageBox.Show("Deseja deslogar sua conta?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes)) {

                Session.Logout();
                Menu.Customer = (Customer)Session.User;

                Menu.UpdateView();

            }

        }

        public void CartPanel_ClickFinishOrder(object sender, EventArgs e) {

            if (!CartPanel.ValidateProducts()) {
                MessageBox.Show("O carrinho está vazio.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!CartPanel.ValidatePayment()) {
                MessageBox.Show("Selecione um método de pagamento.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(Session.User == null) {
                FormLogin login = new FormLogin(this);
                login.Login += Login_OnLogin;
                login.ShowDialog();

                return;
            }

            CartPanel.Order.Customer = (Customer)Session.User;
            CartPanel.Order.Status = OrderStatus.Pending;
            CartPanel.Order.CreatedAt = DateTime.Now;
            CartPanel.Order.UpdatedAt = DateTime.Now;

            try {

                DAO.Orders.Add(CartPanel.Order);

                MessageBox.Show("Pedido inserido com sucesso.");

                Reset();

            } catch {
                MessageBox.Show("ERRO!");
            }            

        }

        private void Login_OnLogin(object sender, EventArgs e) {
            CartPanel_ClickFinishOrder(this, EventArgs.Empty);
        }

        public void ProductBox_ClickProductBuy(object sender, EventArgs e) {

            Button ButtonProductBuy = (Button)sender;
            Product Product = (ButtonProductBuy.Parent as ProductPanel).Product;

            FormProductBuy ProductBuy = new FormProductBuy(this, Product);
            ProductBuy.ShowDialog();

        }

        public void CartProductBox_ClickProductRemove(object sender, EventArgs e) {

            Button ButtonCartProductRemove = (Button)sender;
            OrderProduct CartProduct = (ButtonCartProductRemove.Parent as CartProductPanel).CartProduct;

            if (MessageBox.Show("Deseja excluir o produto (" + CartProduct.Product.Name +") do seu carrinho?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes)) {

                CartPanel.CartProductBox.CartProducts.Remove(CartProduct);
                CartPanel.CartProductBox.UpdateView();

            }

            CartPanel.UpdateCartTotals();

        }

        public void CartProductBox_ChangeProductQuantity(object sender, EventArgs e) {

            NumericUpDown NumericCartProductQuantity = (sender as NumericUpDown);
            CartProductPanel CartProductPanel = (NumericCartProductQuantity.Parent as CartProductPanel);

            OrderProduct CartProduct = CartProductPanel.CartProduct;
            CartProduct.Quantity = Convert.ToInt16(NumericCartProductQuantity.Value);

            if (CartProduct.Product.Promotion) {
                CartProductPanel.LabelCartProductValue.Text = "$" + (CartProduct.Quantity * CartProduct.Product.PromotionValue).ToString("0.00");
            } else {
                CartProductPanel.LabelCartProductValue.Text = "$" + (CartProduct.Quantity * CartProduct.Product.Value).ToString("0.00");
            }

            CartPanel.UpdateCartTotals();

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e) {

            if (MessageBox.Show("Deseja sair da Prophet Shop?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.No)) {
                e.Cancel = true;
            }

        }

        private void ComboBoxOrderBy_SelectedIndexChanged(object sender, EventArgs e) {
            TextBoxSearch.Focus();

            if (ComboBoxOrderBy.SelectedIndex == 0) {
                ProductBox.Products = ProductBox.Products.OrderBy(Product => !Product.Promotion).ThenByDescending(Product => Product.PromotionPercentage).ToList();
            }

            if (ComboBoxOrderBy.SelectedIndex == 1) {
                ProductBox.Products = ProductBox.Products.OrderBy(Product => Product.Name).ToList();
            }

            if (ComboBoxOrderBy.SelectedIndex == 2) {
                ProductBox.Products = ProductBox.Products.OrderByDescending(Product => Product.Promotion ? Product.PromotionValue : Product.Value).ToList();
            }

            if (ComboBoxOrderBy.SelectedIndex == 3) {
                ProductBox.Products = ProductBox.Products.OrderBy(Product => Product.Promotion ? Product.PromotionValue : Product.Value).ToList();
            }

            ProductBox.UpdateView();

        }

        private void TextBoxSearch_KeyDown(object sender, KeyEventArgs e) {

            if (e.KeyCode == Keys.Enter) {

                ProductBox.Products = DAO.Products.List().Where(
                    Product => Product.Name.IndexOf(TextBoxSearch.TextOnly, StringComparison.OrdinalIgnoreCase) >= 0 || Product.Category.Name.IndexOf(TextBoxSearch.TextOnly, StringComparison.OrdinalIgnoreCase) >= 0
                ).ToList();

                ComboBoxOrderBy_SelectedIndexChanged(ComboBoxOrderBy, EventArgs.Empty);

                ProductBox.UpdateView();

            }

        }

        private void PictureBoxLogo_Click(object sender, EventArgs e) {
            Reload();
        }
    }
}
