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
    public partial class OrderPanelProductImage : UserControl {

        public OrderProduct orderProduct;

        public OrderProduct OrderProduct {

            get {
                return orderProduct;
            }

            set {

                if(value != null) {
                    PictureBox.Image = Util.ImageConverter.ByteArrayToImage(value.Product.Image);
                    LabelQuantity.Text = value.Quantity.ToString() + "x";
                }

                orderProduct = value;
                
            }

        }

        public OrderPanelProductImage() {
            InitializeComponent();
        }

    }
}
