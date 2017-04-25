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

    public partial class CartProductPanel : UserControl {

        private OrderProduct cartProduct;

        public OrderProduct CartProduct {

            get {
                return cartProduct;
            }

            set {

                if (value != null) {

                    cartProduct = value;

                    if (value.Product.Name != null || value.Product.Name.Equals("")) {
                        LabelCartProductName.Text = value.Product.Name;
                    } else {
                        LabelCartProductName.Text = "Sem Nome";
                    }

                    if (value.Product.Value > 0) {
                        LabelCartProductValue.Text = "$" + (value.Quantity * value.Value).ToString("0.00");
                    } else {
                        LabelCartProductValue.Text = "$0";
                    }

                    if (value.Product.Image != null || value.Product.Image.Count() == 0) {
                        PictureBoxCartProductImage.Image = Util.ImageConverter.ByteArrayToImage(value.Product.Image);
                    }

                    NumericCartProductQuantity.Value = value.Quantity;
                    NumericCartProductQuantity.Maximum = value.Product.Quantity + value.Quantity;

                }

            }

        }

        public event EventHandler ChangeQuantity;
        public event EventHandler Remove;

        public CartProductPanel() {
            InitializeComponent();
        }

        private void NumericCartProductQuantity_ValueChanged(object sender, EventArgs e) {
            if(ChangeQuantity != null) ChangeQuantity(sender, e);
        }

        private void ButtonCartProductRemove_Click(object sender, EventArgs e) {
            if (Remove != null) Remove(sender, e);
        }

        private void CartProductPanel_Load(object sender, EventArgs e) {
            if (!this.DesignMode) {
                if (Remove == null) ButtonCartProductRemove.Visible = false;
                if (ChangeQuantity == null) NumericCartProductQuantity.Enabled = false;
            }
        }
    }

}
