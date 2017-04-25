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

    public partial class ProductBox : UserControl {

        public List<Product> Products = new List<Product>();

        public EventHandler ClickProductBuy;
        public int NumberOfColumns = 0;

        public ProductBox() {
            InitializeComponent();
        }

        private void ProductBox_Load(object sender, EventArgs e) {

            if(NumberOfColumns == 0) {
                NumberOfColumns = Convert.ToInt32(Width / new ProductPanel().Width);
            }

        }

        private void AddProduct(Product product) {

            ProductPanel productPanel = new ProductPanel();

            productPanel.Product = product;
            productPanel.Name = "ProductPanel" + product.ID.ToString();
            productPanel.ClickBuy += ClickProductBuy;

            Controls.Add(productPanel);

        }

        public void UpdateView() {

            Controls.Clear();

            Cursor.Current = Cursors.WaitCursor;

            if (Products.Count() > 0) {
           
                List<Product> disabledProducts = Products.Where(Product => Product.Quantity == 0).ToList();

                foreach (Product disabledProduct in disabledProducts) {
                    Products.Remove(disabledProduct);
                    Products.Add(disabledProduct);
                }

                foreach (Product product in Products) {
                    AddProduct(product);
                }

                List<ProductPanel> productPanels = Controls.Cast<ProductPanel>().ToList();

                Populate(productPanels);

            } else {

                Label message = new Label();

                message.Name = "LabelNoProduct";
                message.Size = new System.Drawing.Size(Width, Height);
                message.Text = "Nenhum produto encontrado.";
                message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                message.Location = new System.Drawing.Point(0, 0);

                Controls.Add(message);

            }

            Cursor.Current = Cursors.Default;

        }

        public void Populate(List<ProductPanel> productPanels) {

            for (var index = 0; index < productPanels.Count(); index++) {

                ProductPanel productPanel = productPanels[index];
                
                if (index != 0) {

                    ProductPanel lastProductPanel = productPanels[index - 1];

                    int x = index % NumberOfColumns == 0 ? 0 : lastProductPanel.Location.X + productPanel.Width + productPanel.Margin.Horizontal;
                    int y = index % NumberOfColumns == 0 ? lastProductPanel.Location.Y + productPanel.Height + productPanel.Margin.Vertical : lastProductPanel.Location.Y;

                    productPanel.Location = new System.Drawing.Point(x, y);

                } else {

                    productPanel.Location = new System.Drawing.Point(0, 0);

                }

                Controls.Add(productPanel);

            }

        }

    }

}
