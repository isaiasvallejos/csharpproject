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

namespace Shop {

    public partial class FormOrderDetail : Form {

        public Order Order;
        public FormOrders Orders;

        public FormOrderDetail(FormOrders orders, Order order) {
            Order = order;
            Orders = orders;

            InitializeComponent();
        }

        private void FormOrderDetail_Load(object sender, EventArgs e) {

            CartProductBox.CartProducts = Order.Products;
            CartProductBox.UpdateView();

            LabelIdHeader.Text = "#" + Order.ID.ToString();
            LabelCustomer.Text = Order.Customer.Name;
            LabelPayment.Text = Order.Payment;
            LabelCreatedAt.Text = Order.CreatedAt.ToString("d MMM. yyyy");
            LabelProductsValue.Text = "$" + Order.ProductsValue.ToString("0.00");
            LabelShippingValue.Text = "$" + Order.ShippingValue.ToString("0.00");
            LabelDiscountValue.Text = "-$" + Order.DiscountValue.ToString("0.00");
            LabelTotalValue.Text = "$" + (Order.ProductsValue + Order.ShippingValue - Order.DiscountValue).ToString("0.00");

            ComboBoxStatus.SelectedIndex = ComboBoxStatus.FindStringExact(Order.Status);

            if (Order.Status.Equals("Entregue") || Order.Status.Equals("Cancelado")) {
                ComboBoxStatus.Enabled = false;
            }

        }

        private void ComboBoxStatus_SelectedIndexChanged(object sender, EventArgs e) {
            ButtonSave.Focus();
        }

        private void ButtonSave_Click(object sender, EventArgs e) {

            if (!Order.Status.Equals("Pendente") && ComboBoxStatus.GetItemText(ComboBoxStatus.SelectedItem).Equals("Pendente")) {
                MessageBox.Show("O status do pedido não pode ser retrocedido como pendente.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            Order.Status = ComboBoxStatus.GetItemText(ComboBoxStatus.SelectedItem);
            Order.UpdatedAt = DateTime.Now;

            try {

                DAO.Orders.Update(Order);
                MessageBox.Show("Pedido atualizado com sucesso.");

                Orders.InitializeOrResetDataGrid();
                Close();

            } catch {
                MessageBox.Show("Ocorreu um erro interno, tente novamente mais tarde.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }

}
