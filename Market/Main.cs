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
        private List<ListViewItem> items = new List<ListViewItem>();
        private List<ListViewGroup> groups = new List<ListViewGroup>();

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

        private void FormMain_Load(object sender, EventArgs e)
        {
            ListViewProducts.LargeImageList = new ImageList();

            LoadItemsAndGroups();
            UpdateItems();
        }

        private void UpdateItems()
        {
            ListViewProducts.Items.Clear();

            foreach (ListViewItem item in SearchItems())
            {
                ListViewProducts.Items.Add((ListViewItem) item.Clone());
            }

        }

        private List<ListViewItem> SearchItems()
        {
            return items.Where(
                item => item.Text.IndexOf(TextBoxSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0 || (item.Group != null ? item.Group.Name.IndexOf(TextBoxSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0 : false)
            ).ToList();
        }

        private void LoadItemsAndGroups()
        {
            List<Product> products = Products.List();

            foreach (Product product in products)
            {
                ListViewItem item = new ListViewItem();

                ListViewProducts.LargeImageList.Images.Add(product.ID.ToString(), ImageBytefy.ByteArrayToImage(product.Image));              

                item.Tag = product;
                item.Text = product.Name;
                item.ImageKey = product.ID.ToString();

                ListViewGroup group = groups.FirstOrDefault(_group => _group.Name.Equals(product.Category.Name));

                if (group == null)
                {
                    group = new ListViewGroup();

                    group.Tag = product.Category;
                    group.Name = product.Category.Name;
                    group.Header = product.Category.Name;
                    group.HeaderAlignment = HorizontalAlignment.Center;

                    groups.Add(group);
                    ListViewProducts.Groups.Add(group);               
                }

                item.Group = group;

                items.Add(item);
            }

        }

    }
}
