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

    public partial class FormOrders : Form {

        public FormDashboard Dashboard;

        public FormOrders(FormDashboard dashboard) {
            Dashboard = dashboard;

            InitializeComponent();
        }

        public void DataGridRow_ContextMenu_Opened(object sender, EventArgs e) {
            Order order = (sender as ContextMenuStrip).Tag as Order;
            DataGridViewRow row = DataGridOrders.Rows.Cast<DataGridViewRow>().ToList().FirstOrDefault(r => (r.Tag as Order).ID.Equals(order.ID));

            row.Selected = true;
        }

        public void DataGridRow_ContextMenu_Closed(object sender, EventArgs e) {
            Order order = (sender as ContextMenuStrip).Tag as Order;
            DataGridViewRow row = DataGridOrders.Rows.Cast<DataGridViewRow>().ToList().FirstOrDefault(r => (r.Tag as Order).ID.Equals(order.ID));

            row.Selected = false;
        }

        private void ToolStripItem_ClickView(object sender, EventArgs e) {
            Order order = ((sender as ToolStripItem).Owner as ContextMenuStrip).Tag as Order;

            FormOrderDetail orderDetail = new FormOrderDetail(this, order);
            orderDetail.ShowDialog();
        }

        public void InitializeOrResetDataGrid() {
            UpdateDataGrid(DAO.Orders.List().OrderByDescending(order => order.ID).ToList());
            ComboBoxFilterOrderStatus.SelectedIndex = 0;
        }

        public void UpdateDataGrid(List<Order> orders) {

            if(orders.Count() > 0) {

                DataGridOrders.Visible = true;

                DataGridOrders.Columns.Clear();
                DataGridOrders.Rows.Clear();

                DataGridOrders.Columns.Add("id", "#");
                DataGridOrders.Columns.Add("customer", "Cliente");
                DataGridOrders.Columns.Add("status", "Status");
                DataGridOrders.Columns.Add("total", "Total");

                DataGridOrders.Columns[0].Width = 40;
                DataGridOrders.Columns[3].DefaultCellStyle.Format = "$0.00";

                foreach (Order order in orders) {

                    var index = DataGridOrders.Rows.Add();

                    ContextMenuStrip menu = new ContextMenuStrip();

                    menu.Tag = order;
                    menu.Opened += new EventHandler(DataGridRow_ContextMenu_Opened);
                    menu.Closed += new ToolStripDropDownClosedEventHandler(DataGridRow_ContextMenu_Closed);

                    ToolStripItem view = menu.Items.Add("Visualizar", Image.FromFile(@"..\..\..\images\view.png"));

                    view.Click += new EventHandler(ToolStripItem_ClickView);

                    DataGridOrders.Rows[index].Tag = order;
                    DataGridOrders.Rows[index].ContextMenuStrip = menu;
                    DataGridOrders.Rows[index].Cells[0].Value = order.ID;
                    DataGridOrders.Rows[index].Cells[1].Value = order.Customer.Name;
                    DataGridOrders.Rows[index].Cells[2].Value = order.Status;

                    Color color = new Color();

                    if (order.Status.Equals("Pendente")) {
                        color = Color.Orange;
                    }

                    if (order.Status.Equals("Cancelado")) {
                        color = Color.Red;
                    }

                    if (order.Status.Equals("Aprovado")) {
                        color = Color.YellowGreen;
                    }

                    if (order.Status.Equals("Entregue")) {
                        color = Color.DodgerBlue;
                    }

                    DataGridOrders.Rows[index].Cells[2].Style.ForeColor = color;
                    DataGridOrders.Rows[index].Cells[2].Style.SelectionForeColor = color;

                    DataGridOrders.Rows[index].Cells[3].Value = (order.ProductsValue + order.ShippingValue - order.DiscountValue);

                }

                Dashboard.RefreshPendingOrders();

            } else {

                DataGridOrders.Visible = false;

                Label message = new Label();

                message.Name = "LabelNoOrders";
                message.Size = new System.Drawing.Size(PanelDataGridOrders.Width, PanelDataGridOrders.Height);
                message.Text = "Nenhum pedido encontrado.";
                message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                message.Location = new System.Drawing.Point(0, 0);

                message.BringToFront();

                PanelDataGridOrders.Controls.Add(message);

            }

        }


        private void ComboBoxFilterOrderStatus_SelectedIndexChanged(object sender, EventArgs e) {

            DataGridOrders.Focus();

            List<Order> orders = DAO.Orders.List().OrderByDescending(order => order.ID).ToList();

            if (ComboBoxFilterOrderStatus.SelectedIndex == 1) {
                orders = orders.Where(order => order.Status.Equals("Pendente")).ToList();
            }

            if (ComboBoxFilterOrderStatus.SelectedIndex == 2) {
                orders = orders.Where(order => order.Status.Equals("Aprovado")).ToList();
            }

            if (ComboBoxFilterOrderStatus.SelectedIndex == 3) {
                orders = orders.Where(order => order.Status.Equals("Entregue")).ToList();
            }

            if (ComboBoxFilterOrderStatus.SelectedIndex == 4) {
                orders = orders.Where(order => order.Status.Equals("Cancelado")).ToList();
            }

            UpdateDataGrid(orders);

        }

        private void FormOrders_Load(object sender, EventArgs e) {
            InitializeOrResetDataGrid();
        }

    }
}

