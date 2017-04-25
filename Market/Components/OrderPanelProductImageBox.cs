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

    public partial class OrderPanelProductImageBox : UserControl {

        public List<OrderProduct> Products = new List<OrderProduct>();

        public OrderPanelProductImageBox() {
            InitializeComponent();
        }

        private void AddImage(OrderProduct orderProduct) {
            OrderPanelProductImage productImage = new OrderPanelProductImage();

            productImage.OrderProduct = orderProduct;

            Controls.Add(productImage);
        }

        public void UpdateView() {

            Controls.Clear();

            if (Products.Count() > 0) {

                foreach (OrderProduct product in Products) {
                    AddImage(product);
                }

                List<OrderPanelProductImage> imagePanels = Controls.Cast<OrderPanelProductImage>().ToList();

                Populate(imagePanels);

            } else {

                Label message = new Label();

                message.Name = "LabelNoProduct";
                message.Size = new System.Drawing.Size(Width, Height);
                message.Text = "Nenhum produto.";
                message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                message.Location = new System.Drawing.Point(0, 0);

                Controls.Add(message);

            }

        }

        public void Populate(List<OrderPanelProductImage> imagePanels) {

            for (var index = 0; index < imagePanels.Count(); index++) {

                OrderPanelProductImage imagePanel = imagePanels[index];

                if (index != 0) {

                    OrderPanelProductImage lastImagePanel = imagePanels[index - 1];

                    int x = lastImagePanel.Location.X + imagePanel.Width + imagePanel.Margin.Horizontal;
                    int y = lastImagePanel.Location.Y;

                    imagePanel.Location = new System.Drawing.Point(x, y);

                } else {

                    imagePanel.Location = new System.Drawing.Point(0, 0);

                }

                Controls.Add(imagePanel);

            }

        }

    }
}
