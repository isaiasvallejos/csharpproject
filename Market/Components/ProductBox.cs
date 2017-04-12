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

    public class ProductBox {

        public Panel MainPanel;
        public Panel ModelPanel;

        public int NumberOfColumns = 3;
        public int PanelMargin = 10;

        public List<Product> Products;

        public List<Panel> InitialProductPanels = new List<Panel>();
        public List<Panel> CurrentProductPanels = new List<Panel>();
        public List<Panel> LastProductPanels = new List<Panel>();

        public EventHandler OnBuy;

        public ProductBox(Panel _MainPanel) {
            MainPanel = _MainPanel;      
        }

        public void Initialize() {

            ModelPanel = (Panel) MainPanel.Controls[0];

            foreach(Product Product in Products) {
                InitialProductPanels.Add(Add(Product));
            }

        }

        public void Update() {

            MainPanel.Controls.Clear();

            for (var index = 0; index < CurrentProductPanels.Count(); index++) {

                Panel Panel = CurrentProductPanels[index];

                if (index != 0) {
                    Panel lastPanel = CurrentProductPanels[index - 1];

                    int x = index % NumberOfColumns == 0 ? 0 : lastPanel.Location.X + ModelPanel.Width + PanelMargin;
                    int y = index % NumberOfColumns == 0 ? lastPanel.Location.Y + ModelPanel.Height + PanelMargin : lastPanel.Location.Y;

                    Panel.Location = new System.Drawing.Point(x, y);
                } else {
                    Panel.Location = new System.Drawing.Point(0, 0);
                }

                MainPanel.Controls.Add(Panel);

            }

            if (CurrentProductPanels.Count() == 0) {

                Label message = new Label();

                message.Name = "LabelNoProduct";
                message.Size = new System.Drawing.Size(MainPanel.Width, MainPanel.Height);
                message.TabIndex = 1;
                message.Text = "Nenhum produto encontrado.";
                message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                message.Location = new System.Drawing.Point(0, 0);

                MainPanel.Controls.Add(message);

            }

            LastProductPanels = CurrentProductPanels;

        }

        public void Search(string search) {

            CurrentProductPanels = InitialProductPanels.Where(
                Panel => (Panel.Tag as Product).Name.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0 || ((Panel.Tag as Product).Category != null ? (Panel.Tag as Product).Category.Name.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0 : false)
            ).ToList();

        }

        public void OrderByAlphabetical() {
            CurrentProductPanels = CurrentProductPanels.OrderBy(Panel => (Panel.Tag as Product).Name).ToList();
        }

        public void OrderByLowestPrice() {
            CurrentProductPanels = CurrentProductPanels.OrderByDescending(Panel => (Panel.Tag as Product).Value).ToList();
        }

        public void OrderByBiggestPrice() {
            CurrentProductPanels = CurrentProductPanels.OrderBy(Panel => (Panel.Tag as Product).Value).ToList();
        }

        public void MoveDisabledProductsToEnd() {

            List<Panel> DisabledPanels = CurrentProductPanels.Where(panel => (panel.Tag as Product).Quantity == 0).ToList();

            foreach (Panel Panel in DisabledPanels) {
                CurrentProductPanels.Remove(Panel);
                CurrentProductPanels.Add(Panel);
            }

        }

        public Panel Add(Product Product) {
            Panel ProductPanel = Transform(Product);
            MainPanel.Controls.Add(ProductPanel);

            return ProductPanel;
        }

        public Panel Transform(Product Product) {

            Panel Panel = new Panel();
            List<Control> Model = ModelPanel.Controls.Cast<Control>().ToList();

            int index = InitialProductPanels.Count();

            Panel.BackColor = ModelPanel.BackColor;
            Panel.Padding = ModelPanel.Padding;
            Panel.Size = ModelPanel.Size;

            Panel.Name = "PanelProduct" + index.ToString();
            Panel.Tag = Product;

            Label Name = new Label();
            Label ModelName = (Model.FirstOrDefault(control => control.Name.Equals("ModelLabelProductName")) as Label);

            Name.Location = ModelName.Location;
            Name.TextAlign = ModelName.TextAlign;
            Name.AutoEllipsis = ModelName.AutoEllipsis;
            Name.Font = ModelName.Font;
            Name.Size = ModelName.Size;

            Name.Name = "LabelProduct" + index.ToString() + "Name";
            Name.Text = Product.Name;

            Panel.Controls.Add(Name); 

            Label Value = new Label();
            Label ModelValue = (Model.FirstOrDefault(control => control.Name.Equals("ModelLabelProductValue")) as Label);

            Value.Font = ModelValue.Font;
            Value.Location = ModelValue.Location;
            Value.TextAlign = ModelValue.TextAlign;
            Value.Size = ModelValue.Size;

            Value.Name = "LabelProduct" + index.ToString() + "Value";
            Value.Text = "$" + Product.Value.ToString("#.00");

            Panel.Controls.Add(Value);

            PictureBox Image = new PictureBox();
            PictureBox ModelImage = (Model.FirstOrDefault(control => control.Name.Equals("ModelPictureBoxProductImage")) as PictureBox);

            Image.BackColor = ModelImage.BackColor;
            Image.Location = ModelImage.Location;
            Image.Size = ModelImage.Size;
            Image.SizeMode = ModelImage.SizeMode;

            if (Product.Image != null) {
                Image.Image = ImageBytefy.ByteArrayToImage(Product.Image);
            }

            Image.Name = "PictureBoxProduct" + index.ToString() + "Image";

            Panel.Controls.Add(Image);

            Button Buy = new Button();
            Button ModelBuy = (Model.FirstOrDefault(control => control.Name.Equals("ModelButtonProductBuy")) as Button);

            Buy.FlatStyle = ModelBuy.FlatStyle;
            Buy.Location = ModelBuy.Location; 
            Buy.Size = ModelBuy.Size;
            Buy.Cursor = ModelBuy.Cursor;
            Buy.UseVisualStyleBackColor = ModelBuy.UseVisualStyleBackColor;
            Buy.TabStop = ModelBuy.TabStop;

            Buy.Name = "ButtonProduct" + index.ToString();
            Buy.Click += OnBuy;

            if (Product.Quantity > 0) {
                Buy.Text = ModelBuy.Text;
            } else {
                Buy.Enabled = false;
                Buy.Text = "Indisponível";
                Buy.FlatAppearance.BorderColor = Color.White;
            }

            Panel.Controls.Add(Buy);

            return Panel;

        }

    }

}
