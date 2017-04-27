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
using Shop.Components;

namespace Shop {

    public partial class FormProfileOrder : Form {

        public FormProfileOrder() {
            InitializeComponent();
        }

        private void FormProfileOrder_Load(object sender, EventArgs e) {

            OrderBox.Orders = (Session.User as Customer).Orders;
            OrderBox.Orders = OrderBox.Orders.OrderByDescending(order => order.UpdatedAt).ToList();
            OrderBox.UpdateView();

        }

        private void ComboBoxFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

            OrderBox.Focus();

            if (ComboBoxFilterStatus.SelectedIndex == 0) {
                OrderBox.Orders = (Session.User as Customer).Orders.OrderByDescending(order => order.UpdatedAt).ToList();
            }

            if (ComboBoxFilterStatus.SelectedIndex == 1)
            {
                OrderBox.Orders = (Session.User as Customer).Orders.Where(order => order.Status.Equals("Pendente")).ToList();
            }

            if (ComboBoxFilterStatus.SelectedIndex == 2)
            {
                OrderBox.Orders = (Session.User as Customer).Orders.Where(order => order.Status.Equals("Aprovado")).ToList();
            }

            if (ComboBoxFilterStatus.SelectedIndex == 3)
            {
                OrderBox.Orders = (Session.User as Customer).Orders.Where(order => order.Status.Equals("Entregue")).ToList();
            }

            if (ComboBoxFilterStatus.SelectedIndex == 4)
            {
                OrderBox.Orders = (Session.User as Customer).Orders.Where(order => order.Status.Equals("Cancelado")).ToList();
            }

            OrderBox.UpdateView();

        }
    }

}
