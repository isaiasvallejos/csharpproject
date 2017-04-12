using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using Shop.Models;
using Shop.App;
using Shop.Util;

namespace Shop.Components {

    public class Cart {

        public Panel MainPanel;
        public Panel ModelPanel;
        public List<OrderProduct> CartProducts = new List<OrderProduct>();

        public int PanelMargin = 5;

        public EventHandler OnRemove;
        public EventHandler OnClick;
        public EventHandler OnChangeQuantity;

        public bool PayInCash = false;

        public Cart(Panel _MainPanel) {
            MainPanel = _MainPanel;
        }

        public void Initialize() {
            ModelPanel = (Panel) MainPanel.Controls[0];
        }

        public void Update() {

            MainPanel.Controls.Clear();

            Panel LastPanel = null;

            for (var index = 0; index < CartProducts.Count(); index++) {

                Panel Panel = Transform(CartProducts[index]);

                if (index != 0) {

                    int x = LastPanel.Location.X;
                    int y = LastPanel.Location.Y + ModelPanel.Height + PanelMargin;

                    Panel.Location = new System.Drawing.Point(x, y);

                } else {

                    Panel.Location = new System.Drawing.Point(ModelPanel.Location.X, 0);

                }

                LastPanel = Panel;

                MainPanel.Controls.Add(Panel);

            }

            if (CartProducts.Count() == 0) {

                Label message = new Label();

                message.Name = "LabelNoCartProduct";
                message.Size = new System.Drawing.Size(MainPanel.Width, MainPanel.Height);
                message.AutoSize = false;
                message.TabIndex = 1;
                message.Text = "Nenhum produto no carrinho.";
                message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                message.Location = new System.Drawing.Point(0, 0);

                MainPanel.Controls.Add(message);

            }

        }

        public void Add(OrderProduct CartProduct) {

            OrderProduct ExistentCartProduct = CartProducts.FirstOrDefault(cartProduct => cartProduct.Product.Equals(CartProduct.Product));

            if (ExistentCartProduct == null){
                CartProducts.Add(CartProduct);
                Panel CartProductPanel = Transform(CartProduct);
            } else {
                ExistentCartProduct.Quantity += CartProduct.Quantity;
            }

        }

        public Panel Transform(OrderProduct CartProduct) {

            Panel Panel = new Panel();
            List<Control> Model = ModelPanel.Controls.Cast<Control>().ToList();

            int index = CartProducts.Count();

            Panel.BackColor = ModelPanel.BackColor;
            Panel.Padding = ModelPanel.Padding;
            Panel.Size = ModelPanel.Size;

            Panel.Name = "PanelCartProduct" + index.ToString();
            Panel.Tag = CartProduct;
            Panel.TabIndex = index;

            Label Name = new Label();
            Label ModelName = (Model.FirstOrDefault(control => control.Name.Equals("ModelLabelCartProductName")) as Label);

            Name.Location = ModelName.Location;
            Name.TextAlign = ModelName.TextAlign;
            Name.AutoEllipsis = ModelName.AutoEllipsis;
            Name.Font = ModelName.Font;
            Name.Size = ModelName.Size;

            Name.Name = "LabelCartProduct" + index.ToString() + "Name";
            Name.Text = CartProduct.Product.Name;

            Panel.Controls.Add(Name);

            Label Value = new Label();
            Label ModelValue = (Model.FirstOrDefault(control => control.Name.Equals("ModelLabelCartProductValue")) as Label);

            Value.Font = ModelValue.Font;
            Value.Location = ModelValue.Location;
            Value.TextAlign = ModelValue.TextAlign;
            Value.Size = ModelValue.Size;

            Value.Name = "LabelCartProduct" + index.ToString() + "Value";
            Value.Text = "$" + (Convert.ToInt16(CartProduct.Quantity) * CartProduct.Product.Value).ToString("0.00");

            Panel.Controls.Add(Value);

            PictureBox Image = new PictureBox();
            PictureBox ModelImage = (Model.FirstOrDefault(control => control.Name.Equals("ModelPictureBoxCartProductImage")) as PictureBox);

            Image.BackColor = ModelImage.BackColor;
            Image.Location = ModelImage.Location;
            Image.Size = ModelImage.Size;
            Image.SizeMode = ModelImage.SizeMode;

            if (CartProduct.Product.Image != null) {
                Image.Image = ImageBytefy.ByteArrayToImage(CartProduct.Product.Image);
            }

            Image.Name = "PictureBoxCartProduct" + index.ToString() + "Image";

            Panel.Controls.Add(Image);

            NumericUpDown Quantity = new NumericUpDown();
            NumericUpDown ModelQuantity = (Model.FirstOrDefault(control => control.Name.Equals("ModelNumericCartProductQuantity")) as NumericUpDown);

            Quantity.BorderStyle = ModelQuantity.BorderStyle;
            Quantity.Location = ModelQuantity.Location;
            Quantity.Minimum = 1;
            Quantity.Maximum = CartProduct.Product.Quantity;
            Quantity.Name = "NumericCartProduct" + index.ToString() + "Quantity";
            Quantity.Size = ModelQuantity.Size;
            Quantity.TabStop = ModelQuantity.TabStop;
            Quantity.Value = CartProduct.Quantity;
            Quantity.ValueChanged += OnChangeQuantity;

            Panel.Controls.Add(Quantity);

            Button Remove = new Button();
            Button ModelRemove = (Model.FirstOrDefault(control => control.Name.Equals("ModelButtonCartProductRemove")) as Button);

            Remove.Cursor = ModelRemove.Cursor;
            Remove.FlatAppearance.BorderColor = ModelRemove.FlatAppearance.BorderColor;
            Remove.FlatStyle = ModelRemove.FlatStyle;
            Remove.Image = ModelRemove.Image;
            Remove.Location = ModelRemove.Location;
            Remove.Name = "ButtonCartProduct" + index.ToString() + "Remove";
            Remove.Size = ModelRemove.Size;
            Remove.TabIndex = ModelRemove.TabIndex;
            Remove.TabStop = ModelRemove.TabStop;
            Remove.UseVisualStyleBackColor = ModelRemove.UseVisualStyleBackColor;
            Remove.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            Remove.Click += OnRemove;

            Panel.Controls.Add(Remove);

            return Panel;

        }

        public double TotalCartProducts() {
            return CartProducts.Aggregate(0.00, (acc, cartProduct) => acc + (cartProduct.Product.Value * cartProduct.Quantity));
        }

        public double TotalShipping() {
            return CartProducts.Aggregate(0.00, (acc, cartProduct) => acc + (cartProduct.Quantity * 1.50));
        }

    }

}
