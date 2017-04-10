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

namespace Market {
    public partial class FormProductBuy : Form {

        private FormMain Main;
        private Product Product;

        public FormProductBuy(FormMain _Main, Product _Product) {
            Main = _Main;
            Product = _Product;

            InitializeComponent();
        }
    }
}
