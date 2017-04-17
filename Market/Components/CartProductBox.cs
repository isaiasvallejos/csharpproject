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

    public partial class CartProductBox : UserControl {

        public List<OrderProduct> CartProducts = new List<OrderProduct>();

        public EventHandler ClickProductRemove;
        public EventHandler ChangeProductQuantity;

        public CartProductBox() {
            InitializeComponent();
        }

        private void AddProduct(OrderProduct cartProduct) {
            CartProductPanel cartProductPanel = new CartProductPanel();

            cartProductPanel.CartProduct = cartProduct;
            cartProductPanel.Name = "CartProductPanel" + cartProduct.Product.ID.ToString();
            cartProductPanel.Remove += ClickProductRemove;
            cartProductPanel.ChangeQuantity += ChangeProductQuantity;

            Controls.Add(cartProductPanel);
        }

        public void UpdateView() {

            Controls.Clear();

            if (CartProducts.Count() > 0) {

                foreach (OrderProduct cartProduct in CartProducts) {
                    AddProduct(cartProduct);
                }

                List<CartProductPanel> cartProductPanels = Controls.Cast<CartProductPanel>().ToList();

                Populate(cartProductPanels);

            } else {

                Label message = new Label();

                message.Name = "LabelNoProduct";
                message.Size = new System.Drawing.Size(Width, Height);
                message.Text = "Carrinho vazio";
                message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                message.Location = new System.Drawing.Point(0, 0);

                Controls.Add(message);

            }

        }

        public void Populate(List<CartProductPanel> cartProductPanels) {

            for (var index = 0; index < cartProductPanels.Count(); index++) {

                CartProductPanel cartProductPanel = cartProductPanels[index];

                if (index != 0) {

                    CartProductPanel lastCartProductPanel = cartProductPanels[index - 1];

                    int x = lastCartProductPanel.Location.X;
                    int y = lastCartProductPanel.Location.Y + cartProductPanel.Height + cartProductPanel.Margin.Vertical;

                    cartProductPanel.Location = new System.Drawing.Point(x, y);

                } else {

                    cartProductPanel.Location = new System.Drawing.Point(0, 0);

                }

                Controls.Add(cartProductPanel);

            }

        }

    }

}
