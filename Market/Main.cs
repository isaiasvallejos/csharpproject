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
        private int numberOfColumns = 2;
        private int panelSizeHeight = 70;
        private int panelSizeWidth = 165;
        private int panelMargin = 5;

        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonLoginOpen_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin(this);
            login.ShowDialog();
        }

        private void ButtonSignUpOpen_Click(object sender, EventArgs e)
        {
            FormSignUp signUp = new FormSignUp(this);
            signUp.ShowDialog();
        }

        private void ListViewProducts_ItemActivate(object sender, EventArgs e)
        {
            MessageBox.Show(ListViewProducts.FocusedItem.Name);
        }

        private void TextBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateItems();
        }

        private void ButtonProduct_Click(object sender, EventArgs e)
        {
            Button button = (Button) sender;

            MessageBox.Show((button.Parent.Tag as Product).Name);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ListViewProducts.LargeImageList = new ImageList();

            LoadItemsAndGroups();
            UpdateItems();
        }

        private void UpdateItems()
        {
            PanelProducts.Controls.Clear();

            List<Panel> ProductPanelsFiltered = SearchProducts();

            for (var index = 0; index < ProductPanelsFiltered.Count(); index++)
            {
                Panel panel = ProductPanelsFiltered[index];

                if (index != 0)
                {
                    Panel lastPanel = ProductPanelsFiltered[index - 1];

                    int x = index % numberOfColumns == 0 ? 0 : lastPanel.Location.X + panelSizeWidth + panelMargin;
                    int y = index % numberOfColumns == 0 ? lastPanel.Location.Y + panelSizeHeight + panelMargin : lastPanel.Location.Y;

                    panel.Location = new System.Drawing.Point(x, y);
                }
                else
                {
                    panel.Location = new System.Drawing.Point(0, 0);
                }

                PanelProducts.Controls.Add(panel);
            }

        }

        private List<Panel> SearchProducts()
        {
            return ProductPanels.Where(
                product => (product.Tag as Product).Name.IndexOf(TextBoxSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0 || ((product.Tag as Product).Category != null ? (product.Tag as Product).Category.Name.IndexOf(TextBoxSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0 : false)
            ).ToList();
        }

        private void LoadItemsAndGroups()
        {
            List<Product> products = Products.List();

            for (var index = 0; index < products.Count(); index++)
            {
                Panel panel = new Panel();

                Product product = products[index];

                panel.BackColor = System.Drawing.SystemColors.Window;
                panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                panel.Name = "PanelProduct" + index.ToString();
                panel.Size = new System.Drawing.Size(panelSizeWidth, panelSizeHeight);
                panel.TabIndex = index;
                panel.Tag = product;

                Label name = new Label();
                panel.Controls.Add(name);

                name.Location = new System.Drawing.Point(75, 3);
                name.Name = "LabelProduct" + index.ToString() + "Name";
                name.Size = new System.Drawing.Size(84, 19);
                name.TabIndex = 1;
                name.Text = product.Name;
                name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

                Label value = new Label();
                panel.Controls.Add(value);

                value.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                value.Location = new System.Drawing.Point(74, 25);
                value.Name = "LabelProduct" + index.ToString() + "Value";
                value.Size = new System.Drawing.Size(82, 14);
                value.TabIndex = 2;
                value.Text = "$" + product.Value.ToString();
                value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

                PictureBox image = new PictureBox();
                panel.Controls.Add(image);

                image.Location = new System.Drawing.Point(0, 0);
                image.Size = new System.Drawing.Size(70, 70);

                if (product.Image != null)
                {
                    image.Image = ImageBytefy.ByteArrayToImage(product.Image);
                    image.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                Button buy = new Button();
                panel.Controls.Add(buy);

                buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
                buy.Location = new System.Drawing.Point(100, 42);
                buy.Name = "ButtonProduct" + index.ToString();
                buy.Size = new System.Drawing.Size(59, 22);
                buy.TabIndex = 3;
                buy.Text = "Comprar";
                buy.UseVisualStyleBackColor = true;
                buy.Click += new EventHandler(ButtonProduct_Click);

                PanelProducts.Controls.Add(panel);
                ProductPanels.Add(panel);

            }

        }

    }
}
