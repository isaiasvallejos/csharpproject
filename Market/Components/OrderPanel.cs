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

    public partial class OrderPanel : UserControl {

        private Order order;

        public Order Order {

            get {
                return order;
            }

            set {

                if (value != null) {

                    order = value;

                    if (value.ID > 0) {
                        LabelID.Text = "#" + value.ID.ToString();
                    } else {
                        LabelID.Text = "#?";
                    }

                    if (value.Customer != null && value.CreatedAt != null) {
                        LabelByNameInDate.Text = value.CreatedAt.ToString("d MMM. yyyy");
                    } else {
                        LabelByNameInDate.Text = "por desconhecido em ??/??";
                    }

                    if(value.Products.Count() > 0) {
                        LabelTotalValue.Text = "$" + (value.ProductsValue + value.ShippingValue - value.DiscountValue).ToString("0.00");
                    } else {
                        LabelTotalValue.Text = "$0";
                    }

                    if(value.Products.Count() > 0) {

                        OrderPanelProductImageBox.Products = value.Products;
                        OrderPanelProductImageBox.UpdateView();

                    }

                    LabelByNameInDate.Location = new Point(LabelID.Location.X + LabelID.Size.Width, LabelByNameInDate.Location.Y);

                    if(value.Status != null) {
                        PanelStatus.Refresh();
                    }

                }

            }

        }

        public OrderPanel() {
            InitializeComponent();
        }

        private void PanelStatus_Paint(object sender, PaintEventArgs e) {

            if (!this.DesignMode) {

                if (order != null && order.Status != null) {

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

                    ControlPaint.DrawBorder(e.Graphics, PanelStatus.ClientRectangle, color, ButtonBorderStyle.Solid);

                    LabelStatus.Text = order.Status;
                    LabelStatus.ForeColor = color;

                }

            }
            
        }

    }
}
