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

    public partial class FormCustomers : Form {

        public FormDashboard Dashboard;

        public FormCustomers(FormDashboard dashboard) {
            Dashboard = dashboard;

            InitializeComponent();
        }

        public void DataGridRow_ContextMenu_Opened(object sender, EventArgs e) {
            Customer customer = (sender as ContextMenuStrip).Tag as Customer;
            DataGridViewRow row = DataGridCustomers.Rows.Cast<DataGridViewRow>().ToList().FirstOrDefault(r => (r.Tag as Customer).ID.Equals(customer.ID));

            row.Selected = true;
        }

        public void DataGridRow_ContextMenu_Closed(object sender, EventArgs e) {
            Customer customer = (sender as ContextMenuStrip).Tag as Customer;
            DataGridViewRow row = DataGridCustomers.Rows.Cast<DataGridViewRow>().ToList().FirstOrDefault(r => (r.Tag as Customer).ID.Equals(customer.ID));

            row.Selected = false;
        }

        private void ToolStripItem_ClickView(object sender, EventArgs e) {
            Customer customer = ((sender as ToolStripItem).Owner as ContextMenuStrip).Tag as Customer;

            FormCustomerDetail customerDetail = new FormCustomerDetail(customer);
            customerDetail.ShowDialog();
        }

        private void ToolStripItem_ClickDelete(object sender, EventArgs e) {
            Customer customer = ((sender as ToolStripItem).Owner as ContextMenuStrip).Tag as Customer;

            if (MessageBox.Show("Tem certeza que deseja remover o cliente (" + customer.Name + ")?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes)) {

                DAO.Customers.Disable(customer);
                InitializeOrResetAndSearchDataGrid();

            }

        }

        public void InitializeOrResetAndSearchDataGrid() {

            List<Customer> customers = DAO.Customers.ListEnableds().Where(
                Customer => Customer.Name.IndexOf(TextBoxSearch.TextOnly, StringComparison.OrdinalIgnoreCase) >= 0 || Customer.Document.IndexOf(TextBoxSearch.TextOnly, StringComparison.OrdinalIgnoreCase) >= 0
            ).OrderBy(customer => customer.Name).ToList();

            UpdateDataGrid(customers);

        }

        public void UpdateDataGrid(List<Customer> customers) {

            if(customers.Count() > 0) {

                DataGridCustomers.Visible = true;

                DataGridCustomers.Columns.Clear();
                DataGridCustomers.Rows.Clear();

                DataGridCustomers.Columns.Add("id", "#");
                DataGridCustomers.Columns.Add("username", "Nome de Usuário");
                DataGridCustomers.Columns.Add("name", "Nome");
                DataGridCustomers.Columns.Add("document", "CPF");

                DataGridCustomers.Columns[0].Width = 40;

                foreach (Customer customer in customers) {

                    var index = DataGridCustomers.Rows.Add();

                    ContextMenuStrip menu = new ContextMenuStrip();

                    menu.Tag = customer;
                    menu.Opened += new EventHandler(DataGridRow_ContextMenu_Opened);
                    menu.Closed += new ToolStripDropDownClosedEventHandler(DataGridRow_ContextMenu_Closed);

                    ToolStripItem view = menu.Items.Add("Visualizar", Image.FromFile(@"..\..\..\images\view.png"));
                    ToolStripItem delete = menu.Items.Add("Remover", Image.FromFile(@"..\..\..\images\delete.png"));

                    delete.Click += new EventHandler(ToolStripItem_ClickDelete);
                    view.Click += new EventHandler(ToolStripItem_ClickView);

                    DataGridCustomers.Rows[index].Tag = customer;
                    DataGridCustomers.Rows[index].ContextMenuStrip = menu;
                    DataGridCustomers.Rows[index].Cells[0].Value = customer.ID;
                    DataGridCustomers.Rows[index].Cells[1].Value = customer.Username;
                    DataGridCustomers.Rows[index].Cells[2].Value = customer.Name;
                    DataGridCustomers.Rows[index].Cells[3].Value = customer.Document;

                }

            } else {

                DataGridCustomers.Visible = false;

                Label message = new Label();

                message.Name = "LabelNoCustomers";
                message.Size = new System.Drawing.Size(PanelDataGridCustomers.Width, PanelDataGridCustomers.Height);
                message.Text = "Nenhum cliente encontrado.";
                message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                message.Location = new System.Drawing.Point(0, 0);

                message.BringToFront();

                PanelDataGridCustomers.Controls.Add(message);

            }

        }

        private void FormOrders_Load(object sender, EventArgs e) {
            InitializeOrResetAndSearchDataGrid();
        }

        private void TextBoxSearch_KeyDown(object sender, KeyEventArgs e) {

            if (e.KeyCode == Keys.Enter) {
                InitializeOrResetAndSearchDataGrid();
            }

        }

    }
}

