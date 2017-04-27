using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop.Models;
using Shop.App;

namespace Shop {

    public partial class FormDashboard : Form {

        public FormDashboard() {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e) {
            LabelWelcome.Text = "Bem-vindo " + (Session.User as Manager).Name + "!";

            RefreshPendingOrders();
        }

        public void RefreshPendingOrders() {

            int numberOfPendingOrders = DAO.Orders.List().Where(order => order.Status.Equals("Pendente")).ToList().Count();

            if (numberOfPendingOrders > 0) {
                LabelPendingOrdersNumber.Text = numberOfPendingOrders.ToString();
            } else {
                LabelPendingOrdersNumber.Visible = false;
            }

        }

        private void PanelOrdersButton_Click(object sender, EventArgs e) {

            FormOrders orders = new FormOrders(this);
            orders.ShowDialog();

        }

        private void PanelProductsButton_Click(object sender, EventArgs e) {

            FormProducts products = new FormProducts(this);
            products.ShowDialog();

        }

        private void PanelCustomersButton_Click(object sender, EventArgs e) {

            FormCustomers customers = new FormCustomers(this);
            customers.ShowDialog();

        }

        private void PanelOrdersButton_MouseEnter(object sender, EventArgs e) {
            LabelOrdersButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void PanelOrdersButton_MouseLeave(object sender, EventArgs e) {
            LabelOrdersButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void PanelProductsButton_MouseEnter(object sender, EventArgs e) {
            LabelProductsButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void PanelProductsButton_MouseLeave(object sender, EventArgs e) {
            LabelProductsButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void PanelCustomersButton_MouseEnter(object sender, EventArgs e) {
            LabelCustomersButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void PanelCustomersButton_MouseLeave(object sender, EventArgs e) {
            LabelCustomersButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void ButtonLogout_Click(object sender, EventArgs e) {
            Close();
        }

        private void FormDashboard_FormClosing(object sender, FormClosingEventArgs e) {

            if (MessageBox.Show("Deseja deslogar sua conta e voltar a loja?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes)) {
                Session.Logout();
            } else {
                e.Cancel = true;
            }

        }

    }

}
