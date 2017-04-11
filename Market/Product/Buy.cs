using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Market.App;
using Market.Models;
using Market.Util;

namespace Market {
    public partial class FormProductBuy : Form {

        private FormMain Main;
        private Product Product;

        public FormProductBuy(FormMain _Main, Product _Product)
        {
            Main = _Main;
            Product = _Product;

            InitializeComponent();
        }

        private void FormProductBuy_Load(object sender, EventArgs e)
        {
            LabelName.Text = Product.Name;
            LabelValue.Text = "$" + Product.Value.ToString("#.00");
            TextBoxDescription.Text = Product.Description;
            PictureBoxImage.Image = ImageBytefy.ByteArrayToImage(Product.Image);
            NumericQuantity.Maximum = Product.Quantity;
        }

        private void NumericQuantity_ValueChanged(object sender, EventArgs e)
        {
            LabelValue.Text = "$" + (Convert.ToInt16(NumericQuantity.Value) * Product.Value).ToString("#.00");
        }
    }
}
