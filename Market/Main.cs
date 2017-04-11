using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Market.App;
using Market.Models;
using Market.Util;
using Market.DAO;

namespace Market
{
    public partial class FormMain : Form
    {
        // Listas de armazenamento dos panéis para gerenciamento de filtro
        private List<Panel> ProductPanels = new List<Panel>();
        private List<Panel> CurrentProductPanels = new List<Panel>();

        // Configurações do painéis
        private int NumberOfColumns = 3;
        private int PanelSizeHeight = 251;
        private int PanelSizeWidth = 171;
        private int PanelMargin = 10;

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

            TextBoxSearch.Focus();
        }

        private bool ResultsAsChanged()
        {
            return CurrentProductPanels.Count() > 0 && CurrentProductPanels.SequenceEqual(SearchProducts());
        }

        private void UpdateItems()
        {

            List<Panel> ProductPanelsFiltered = SearchProducts();

            if (ResultsAsChanged()){
                return;
            }

            PanelProducts.Controls.Clear();

            CurrentProductPanels = ProductPanelsFiltered;

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

            // Ordem alfabética 
            if(ComboBoxOrderBy.SelectedIndex == 0) {
                UnorderedPanels = UnorderedPanels.OrderBy(Panel => (Panel.Tag as Product).Name).ToList();
            }

            // Ordem por menor preço
            if (ComboBoxOrderBy.SelectedIndex == 1) {
                UnorderedPanels = UnorderedPanels.OrderByDescending(Panel => (Panel.Tag as Product).Value).ToList();
            }

            // Order por maior preço
            if (ComboBoxOrderBy.SelectedIndex == 2) {
                UnorderedPanels = UnorderedPanels.OrderBy(Panel => (Panel.Tag as Product).Value).ToList();
            }

            return UnorderedPanels;

        }

        private void LoadItemsAndGroups()
        {
            List<Product> products = Products.List().OrderBy(product => product.Name).ToList();

            for (var index = 0; index < products.Count(); index++)
            {
                Panel Panel = new Panel();

                Product product = products[index];

                Panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
                Panel.Name = "PanelProduct" + index.ToString();
                Panel.Padding = new System.Windows.Forms.Padding(5);
                Panel.Size = new System.Drawing.Size(PanelSizeWidth, PanelSizeHeight);
                Panel.Tag = product;

                Label Name = new Label();
                Panel.Controls.Add(Name);

                Name.Location = new System.Drawing.Point(9, 166);
                Name.Name = "LabelProduct" + index.ToString() + "Name";
                Name.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Name.Size = new System.Drawing.Size(154, 19);
                Name.Text = product.Name;
                Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                Name.AutoEllipsis = true;

                Label Value = new Label();
                Panel.Controls.Add(Value);

                Value.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Value.Location = new System.Drawing.Point(8, 184);
                Value.Name = "LabelProduct" + index.ToString() + "Value";
                Value.Size = new System.Drawing.Size(154, 32);
                Value.Text = "$" + product.Value.ToString("#.00");
                Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                PictureBox Image = new PictureBox();
                Panel.Controls.Add(Image);

                Image.BackColor = System.Drawing.SystemColors.Control;
                Image.Location = new System.Drawing.Point(8, 8);
                Image.Size = new System.Drawing.Size(155, 155);

                if (product.Image != null)
                {
                    Image.Image = ImageBytefy.ByteArrayToImage(product.Image);
                    Image.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                Button Buy = new Button();
                Panel.Controls.Add(Buy);

                Buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                Buy.Location = new System.Drawing.Point(49, 218);
                Buy.Name = "ButtonProduct" + index.ToString();
                Buy.Size = new System.Drawing.Size(75, 23);
                Buy.Cursor = System.Windows.Forms.Cursors.Hand;
                Buy.Text = "Comprar";
                Buy.UseVisualStyleBackColor = true;
                Buy.Click += new EventHandler(ButtonProduct_Click);
                Buy.TabStop = false;

                if (product.Quantity == 0)
                {
                    Buy.Enabled = false;
                }

                PanelProducts.Controls.Add(Panel);
                ProductPanels.Add(Panel);

            }

        }

        private void ComboBoxOrderBy_SelectedIndexChanged(object sender, EventArgs e) {
            TextBoxSearch.Focus();
            UpdateItems();
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateItems();
        }
    }
}
