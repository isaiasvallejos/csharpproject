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
using Market.DAO;

namespace Market
{
    public partial class FormMain : Form
    {
        private List<Panel> ProductPanels = new List<Panel>();
        private int NumberOfColumns = 2;
        private int PanelSizeHeight = 70;
        private int PanelSizeWidth = 165;
        private int PanelMargin = 5;

        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonLoginOpen_Click(object sender, EventArgs e)
        {
            FormLogin Login = new FormLogin(this);
            Login.ShowDialog();
        }

        private void ButtonSignUpOpen_Click(object sender, EventArgs e)
        {
            FormSignUp SignUp = new FormSignUp(this);
            SignUp.ShowDialog();
        }

        private void TextBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateItems();
        }

        private void ButtonProduct_Click(object sender, EventArgs e)
        {
            Button Button = (Button) sender;
            Product Product = (Button.Parent.Tag as Product);

            FormProductBuy ProductBuy = new FormProductBuy(this, Product);
            ProductBuy.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ComboBoxOrderBy.SelectedIndex = 0;

            LoadItemsAndGroups();
            UpdateItems();
        }

        private void UpdateItems()
        {
            PanelProducts.Controls.Clear();

            List<Panel> ProductPanelsFiltered = SearchProducts();

            for (var index = 0; index < ProductPanelsFiltered.Count(); index++)
            {
                Panel Panel = ProductPanelsFiltered[index];

                if (index != 0)
                {
                    Panel lastPanel = ProductPanelsFiltered[index - 1];

                    int x = index % NumberOfColumns == 0 ? 0 : lastPanel.Location.X + PanelSizeWidth + PanelMargin;
                    int y = index % NumberOfColumns == 0 ? lastPanel.Location.Y + PanelSizeHeight + PanelMargin : lastPanel.Location.Y;

                    Panel.Location = new System.Drawing.Point(x, y);
                }
                else
                {
                    Panel.Location = new System.Drawing.Point(0, 0);
                }

                PanelProducts.Controls.Add(Panel);
            }

            if (ProductPanelsFiltered.Count() == 0) {
                Label message = new Label();

                message.Location = new System.Drawing.Point(75, 3);
                message.Name = "LabelNoProduct";
                message.Size = new System.Drawing.Size(350, 20);
                message.TabIndex = 1;
                message.Text = "Nenhum produto encontrado.";
                message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                message.Location = new System.Drawing.Point(0, 0);

                PanelProducts.Controls.Add(message);
            }

        }

        private List<Panel> SearchProducts()
        {
            List<Panel> UnorderedPanels = ProductPanels.Where(
                Panel => (Panel.Tag as Product).Name.IndexOf(TextBoxSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0 || ((Panel.Tag as Product).Category != null ? (Panel.Tag as Product).Category.Name.IndexOf(TextBoxSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0 : false)
            ).ToList();

            // Alphabetical
            if(ComboBoxOrderBy.SelectedIndex == 0) {
                return UnorderedPanels.OrderBy(Panel => (Panel.Tag as Product).Name).ToList();
            }

            // Lowest price
            if (ComboBoxOrderBy.SelectedIndex == 1) {
                return UnorderedPanels.OrderByDescending(Panel => (Panel.Tag as Product).Value).ToList();
            }

            // Biggest price
            if (ComboBoxOrderBy.SelectedIndex == 2) {
                return UnorderedPanels.OrderBy(Panel => (Panel.Tag as Product).Value).ToList();
            }

            return UnorderedPanels;

        }

        private void LoadItemsAndGroups()
        {
            List<Product> products = Products.List();

            for (var index = 0; index < products.Count(); index++)
            {
                Panel Panel = new Panel();

                Product product = products[index];

                Panel.BackColor = System.Drawing.SystemColors.Window;
                Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                Panel.Name = "PanelProduct" + index.ToString();
                Panel.Size = new System.Drawing.Size(PanelSizeWidth, PanelSizeHeight);
                Panel.TabIndex = index;
                Panel.Tag = product;

                Label Name = new Label();
                Panel.Controls.Add(Name);

                Name.Location = new System.Drawing.Point(75, 3);
                Name.Name = "LabelProduct" + index.ToString() + "Name";
                Name.Size = new System.Drawing.Size(84, 19);
                Name.TabIndex = 1;
                Name.Text = product.Name;
                Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                Name.AutoEllipsis = true;

                Label Value = new Label();
                Panel.Controls.Add(Value);

                Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Value.Location = new System.Drawing.Point(74, 25);
                Value.Name = "LabelProduct" + index.ToString() + "Value";
                Value.Size = new System.Drawing.Size(82, 14);
                Value.TabIndex = 2;
                Value.Text = "$" + product.Value.ToString();
                Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

                PictureBox Image = new PictureBox();
                Panel.Controls.Add(Image);

                Image.Location = new System.Drawing.Point(0, 0);
                Image.Size = new System.Drawing.Size(70, 70);

                if (product.Image != null)
                {
                    Image.Image = ImageBytefy.ByteArrayToImage(product.Image);
                    Image.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                Button Buy = new Button();
                Panel.Controls.Add(Buy);

                Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
                Buy.Location = new System.Drawing.Point(100, 42);
                Buy.Name = "ButtonProduct" + index.ToString();
                Buy.Size = new System.Drawing.Size(59, 22);
                Buy.TabIndex = 3;
                Buy.Text = "Comprar";
                Buy.UseVisualStyleBackColor = true;
                Buy.Click += new EventHandler(ButtonProduct_Click);

                PanelProducts.Controls.Add(Panel);
                ProductPanels.Add(Panel);

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateItems();
        }
    }
}
