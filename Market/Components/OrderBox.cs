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

    public partial class OrderBox : UserControl {

        public List<Order> Orders = new List<Order>();
        public EventHandler OnClickDetail;

        public OrderBox() {
            InitializeComponent();
        }

        private void AddOrder(Order order) {
            OrderPanel orderPanel = new OrderPanel();

            orderPanel.Order = order;
            orderPanel.Name = "OrderPanel" + order.ID.ToString();

            Controls.Add(orderPanel);
        }

        public void UpdateView() {

            Controls.Clear();

            if (Orders.Count() > 0) {

                foreach (Order order in Orders) {
                    AddOrder(order);
                }

                List<OrderPanel> orderPanels = Controls.Cast<OrderPanel>().ToList();

                Populate(orderPanels);

            } else {

                Label message = new Label();

                message.Name = "LabelNoProduct";
                message.Size = new System.Drawing.Size(Width, Height);
                message.Text = "Ainda não há nenhum pedido.";
                message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                message.Location = new System.Drawing.Point(0, 0);

                Controls.Add(message);

            }

        }

        public void Populate(List<OrderPanel> orderPanels) {

            for (var index = 0; index < orderPanels.Count(); index++) {

                OrderPanel orderPanel = orderPanels[index];

                if (index != 0) {

                    OrderPanel lastCartProductPanel = orderPanels[index - 1];

                    int x = lastCartProductPanel.Location.X;
                    int y = lastCartProductPanel.Location.Y + orderPanel.Height + orderPanel.Margin.Vertical;

                    orderPanel.Location = new System.Drawing.Point(x, y);

                } else {

                    orderPanel.Location = new System.Drawing.Point(0, 0);

                }

                Controls.Add(orderPanel);

            }

        }

    }

}
