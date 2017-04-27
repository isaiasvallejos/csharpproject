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

    public partial class FormProducts : Form {

        public FormDashboard Dashboard;

        public FormProducts(FormDashboard dashboard) {
            Dashboard = dashboard;

            InitializeComponent();
        }

        public void DataGridRow_ContextMenu_Opened(object sender, EventArgs e) {
            Product product = (sender as ContextMenuStrip).Tag as Product;
            DataGridViewRow row = DataGridProducts.Rows.Cast<DataGridViewRow>().ToList().FirstOrDefault(r => (r.Tag as Product).ID.Equals(product.ID));

            row.Selected = true;
        }

        public void DataGridRow_ContextMenu_Closed(object sender, EventArgs e) {
            Product product = (sender as ContextMenuStrip).Tag as Product;
            DataGridViewRow row = DataGridProducts.Rows.Cast<DataGridViewRow>().ToList().FirstOrDefault(r => (r.Tag as Product).ID.Equals(product.ID));

            row.Selected = false;
        }

        private void ToolStripItem_ClickView(object sender, EventArgs e) {
            Product product = ((sender as ToolStripItem).Owner as ContextMenuStrip).Tag as Product;

            FormProductSave productSave = new FormProductSave(this, product);
            productSave.ShowDialog();
        }

        private void ToolStripItem_ClickDelete(object sender, EventArgs e) {
            Product product = ((sender as ToolStripItem).Owner as ContextMenuStrip).Tag as Product;

            if (MessageBox.Show("Tem certeza que deseja remover o produto (" + product.Name + ")?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes)) {

                DAO.Products.Disable(product);
                InitializeOrResetAndSearchDataGrid();

            }

        }

        public void InitializeOrResetAndSearchDataGrid() {

            List<Product> products = DAO.Products.ListEnableds().Where(
                Product => Product.Name.IndexOf(TextBoxSearch.TextOnly, StringComparison.OrdinalIgnoreCase) >= 0 || Product.Category.Name.IndexOf(TextBoxSearch.TextOnly, StringComparison.OrdinalIgnoreCase) >= 0
            ).OrderBy(order => order.Name).ToList();

            UpdateDataGrid(products);

        }

        public void UpdateDataGrid(List<Product> products) {

            if(products.Count() > 0) {

                DataGridProducts.Visible = true;

                DataGridProducts.Columns.Clear();
                DataGridProducts.Rows.Clear();

                DataGridProducts.Columns.Add("id", "#");
                DataGridProducts.Columns.Add("name", "Nome");
                DataGridProducts.Columns.Add("quantity", "Estoque");
                DataGridProducts.Columns.Add("value", "Preço");

                DataGridProducts.Columns[0].Width = 40;
                DataGridProducts.Columns[3].DefaultCellStyle.Format = "$0.00";

                foreach (Product product in products) {

                    var index = DataGridProducts.Rows.Add();

                    ContextMenuStrip menu = new ContextMenuStrip();

                    menu.Tag = product;
                    menu.Opened += new EventHandler(DataGridRow_ContextMenu_Opened);
                    menu.Closed += new ToolStripDropDownClosedEventHandler(DataGridRow_ContextMenu_Closed);

                    ToolStripItem view = menu.Items.Add("Visualizar", Image.FromFile(@"..\..\..\images\view.png"));
                    ToolStripItem delete = menu.Items.Add("Remover", Image.FromFile(@"..\..\..\images\delete.png"));

                    delete.Click += new EventHandler(ToolStripItem_ClickDelete);
                    view.Click += new EventHandler(ToolStripItem_ClickView);

                    DataGridProducts.Rows[index].Tag = product;
                    DataGridProducts.Rows[index].ContextMenuStrip = menu;
                    DataGridProducts.Rows[index].Cells[0].Value = product.ID;
                    DataGridProducts.Rows[index].Cells[1].Value = product.Name;
                    DataGridProducts.Rows[index].Cells[2].Value = product.Quantity;
                    DataGridProducts.Rows[index].Cells[3].Value = product.Value;

                }

            } else {

                DataGridProducts.Visible = false;

                Label message = new Label();

                message.Name = "LabelNoProducts";
                message.Size = new System.Drawing.Size(PanelDataGridProducts.Width, PanelDataGridProducts.Height);
                message.Text = "Nenhum produto encontrado.";
                message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                message.Location = new System.Drawing.Point(0, 0);

                message.BringToFront();

                PanelDataGridProducts.Controls.Add(message);

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

        private void ButtonAdd_Click(object sender, EventArgs e) {
            FormProductSave productSave = new FormProductSave(this, null);
            productSave.ShowDialog();
        }

    }
}

