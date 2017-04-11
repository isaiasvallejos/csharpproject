using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Market.Util;
using Market.DAO;
using Market.Models;

namespace Market {

    public partial class FormProductAdd : Form {

        public FormProductAdd() {
            InitializeComponent();
        }

        private void PictureBoxProductImage_Click(object sender, EventArgs e) {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Selecione uma imagem de produto";
            DialogResult result = dialog.ShowDialog();

            if(result == DialogResult.OK) {
                PictureBoxProductImage.SizeMode = PictureBoxSizeMode.StretchImage;
                PictureBoxProductImage.Image = new Bitmap(dialog.FileName);
                PictureBoxProductImage.Tag = ImageBytefy.ImageToByteArray(PictureBoxProductImage.Image);

                LabelProductImage.Visible = false;
            }

        }

        private void FormProductAdd_Load(object sender, EventArgs e) {

            List<Category> categories = Categories.List();
            ComboBoxProductCategory.Tag = categories;

            for (var index = 0; index < categories.Count(); index++) {
                ComboBoxProductCategory.Items.Add(categories[index].Name);
            }

        }

        private void ButtonLogin_Click(object sender, EventArgs e) {

            Product product = new Product();

            Category category = (ComboBoxProductCategory.Tag as List<Category>)[ComboBoxProductCategory.SelectedIndex];

            product.CategoryID = category.ID;
            product.Name = TextBoxProductName.Text;
            product.Value = Convert.ToDouble(NumericProductValue.Value);
            product.Image = (PictureBoxProductImage.Tag as byte[]);
            product.Description = TextBoxDescription.Text;
            product.CreatedAt = DateTime.Now;
            product.UpdatedAt = DateTime.Now;

            Products.Add(product);

        }
    }
}
