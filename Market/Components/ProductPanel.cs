using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop.Util;
using Shop.Models;

namespace Shop.Components {

    public partial class ProductPanel : UserControl {

        private Product product;

        public Product Product {

            get {
                return product;
            }

            set {

                if(value != null) {

                    product = value;
                    ProductName = value.Name;
                    ProductValue = value.Value;
                    ProductImage = value.Image;
                    ProductQuantity = value.Quantity;
                    ProductPromotion = value.Promotion;
                    ProductPromotionPercentage = value.PromotionPercentage;

                }  

            }

        }

        public new string ProductName {

            set {

                if (value != null && !value.Equals("")) {
                    LabelProductName.Text = value;
                } else {
                    LabelProductName.Text = "Sem Nome";
                }

                product.Name = value;

            }

        }

        public double ProductValue {

            set {

                if (value > 0) {
                    LabelProductValue.Text = "$" + value.ToString("0.00");                      
                } else {
                    LabelProductValue.Text = "$0,00";
                }

                product.Value = value;
                SetPromotion();

            }

        }

        public byte[] ProductImage {

            set {

                if (value != null) {
                    PictureBoxProductImage.Image = Util.ImageConverter.ByteArrayToImage(value);
                }

                product.Image = value;

            }

        }

        public int ProductQuantity {

            set {

                if (value > 0) {

                    if (ClickBuy != null) {
                        ButtonProductBuy.Enabled = true;
                    }

                    ButtonProductBuy.Text = "Comprar";
                    ButtonProductBuy.FlatAppearance.BorderColor = Color.Black;

                } else {

                    ButtonProductBuy.Enabled = false;
                    ButtonProductBuy.Text = "Indisponível";
                    ButtonProductBuy.FlatAppearance.BorderColor = Color.White;

                }

                product.Quantity = value;
                SetPromotion();

            }

        }

        public bool ProductPromotion {

            set {

                product.Promotion = value;
                SetPromotion();

            }

        }

        public int ProductPromotionPercentage {

            set {

                product.PromotionPercentage = value;
                SetPromotion();

            }

        }

        public event EventHandler ClickBuy;

        public ProductPanel() {
            InitializeComponent();
        }

        private void SetPromotion() {

            if (product.Promotion && product.Quantity > 0) {

                LabelProductValue.Text = "$" + product.PromotionValue.ToString("0.00");
                LabelProductPromotion.Visible = true;
                LabelProductPromotionValue.Visible = true;
                LabelProductPromotionValue.Text = "de $" + product.Value.ToString("0.00");
                LabelProductPromotion.Text = product.PromotionPercentage.ToString() + "%";

                LabelProductPromotion.Location = new Point(LabelProductPromotionValue.Location.X + LabelProductPromotionValue.Width, LabelProductPromotionValue.Location.Y);

                if (product.PromotionPercentage <= 15) {
                    LabelProductPromotion.BackColor = System.Drawing.Color.Silver;
                } else if (product.PromotionPercentage <= 30) {
                    LabelProductPromotion.BackColor = System.Drawing.Color.DeepSkyBlue;
                } else if (product.PromotionPercentage <= 50) {
                    LabelProductPromotion.BackColor = System.Drawing.Color.Gold;
                } else {
                    LabelProductPromotion.BackColor = System.Drawing.Color.OrangeRed;
                }

            } else {

                LabelProductValue.Text = "$" + product.Value.ToString("0.00");
                LabelProductPromotion.Visible = false;
                LabelProductPromotionValue.Visible = false;

            }

        }

        private void ButtonProductBuy_Click(object sender, EventArgs e) {
            if (ClickBuy != null) ClickBuy(sender, e);
        }

        private void ProductPanel_Load(object sender, EventArgs e) {
            if (!this.DesignMode) {
                if (ClickBuy == null) ButtonProductBuy.Enabled = false;
            }
        }
    }

}
