using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Shop.Models;

namespace Shop 
{

    public partial class FormProductSave : Form {

        public FormProducts Products;
        public Product Product;
        public List<Category> Categories;

        public FormProductSave(FormProducts products, Product product) {

            Products = products;
            Product = product;

            InitializeComponent();
        }

        private void FormProductAdd_Load(object sender, EventArgs e) {

            Categories = DAO.Categories.List();
            ComboBoxCategory.Items.AddRange(Categories.Select(Category => Category.Name).ToArray());

            if(Product == null) {

                Product = new Product();
                ProductPanelPreview.Product = Product;

            } else {

                ProductPanelPreview.Product = Product;

                TextBoxName.Text = Product.Name;
                TextBoxDescription.Text = Product.Description;
                NumericQuantity.Value = Product.Quantity;
                NumericValue.Value = Convert.ToDecimal(Product.Value);
                NumericPromotionPercentage.Value = Product.PromotionPercentage;
                CheckBoxPromotion.Checked = Product.Promotion;
                ComboBoxCategory.SelectedIndex = ComboBoxCategory.FindStringExact(Product.Category.Name);

            }

        }

        private void TextBoxName_KeyUp(object sender, KeyEventArgs e) {
            ProductPanelPreview.ProductName = TextBoxName.Text;
        }

        private void ComboBoxCategory_SelectedIndexChanged(object sender, EventArgs e) {
            ProductPanelPreview.Product.Category = Categories[ComboBoxCategory.SelectedIndex];
        }

        private void NumericQuantity_ValueChanged(object sender, EventArgs e) {
            ProductPanelPreview.ProductQuantity = Convert.ToInt16(NumericQuantity.Value);   
        }

        private void NumericValue_ValueChanged(object sender, EventArgs e) {
            ProductPanelPreview.ProductValue = Convert.ToDouble(NumericValue.Value);
        }

        private void NumericPromotionPercentage_ValueChanged(object sender, EventArgs e) {
            ProductPanelPreview.ProductPromotionPercentage = Convert.ToInt16(NumericPromotionPercentage.Value);
        }

        private void CheckBoxPromotion_CheckedChanged(object sender, EventArgs e) {
            ProductPanelPreview.ProductPromotion = CheckBoxPromotion.Checked;
        }

        private void LabelImage_Click(object sender, EventArgs e) {

            OpenFileDialog FileDialog = new OpenFileDialog();

            FileDialog.Title = "Selecionar Imagem";
            FileDialog.Filter = "Arquivos de Imagem (*.bmp; *.jpg; *.jpeg,*.png)| *.BMP; *.JPG; *.JPEG; *.PNG";

            if (FileDialog.ShowDialog() == DialogResult.OK) {
                ProductPanelPreview.ProductImage = Util.ImageConverter.ImageToByteArray(Image.FromFile(FileDialog.FileName));
            }
                
        }

        private void ButtonSave_Click(object sender, EventArgs e) {

            Product.Description = TextBoxDescription.Text;

            if (!ValidateCategory()) {
                MessageBox.Show("Selecione uma categoria para o produto.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidateName()) {
                MessageBox.Show("Insira um nome para o produto.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidateDescription()) {
                MessageBox.Show("Insira uma descrição para o produto.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidateValue()) {
                MessageBox.Show("O preço do produto deve ser maior que zero.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Product.Promotion) {

                if (!ValidatePromotion()) {
                    MessageBox.Show("O produto em promoção deve ter uma porcentagem maior que zero.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }

            try {

                if(ComboBoxCategory.SelectedIndex < 0) {

                    Product.Category = new Category();

                    Product.Category.Name = ComboBoxCategory.Text;
                    Product.Category.CreatedAt = DateTime.Now;
                    Product.Category.UpdatedAt = DateTime.Now;

                    DAO.Categories.Add(Product.Category);

                }

                if(Product.ID == 0) {

                    Product.CreatedAt = DateTime.Now;
                    Product.UpdatedAt = DateTime.Now;
                    Product.Enabled = true;

                    DAO.Products.Add(Product);

                    MessageBox.Show("Produto cadastrado com sucesso!", "", MessageBoxButtons.OK);

                } else {

                    Product.UpdatedAt = DateTime.Now;

                    DAO.Products.Update(Product);

                    MessageBox.Show("Produto atualizado com sucesso!", "", MessageBoxButtons.OK);
                }    

                Products.InitializeOrResetAndSearchDataGrid();

                Close();

            } catch {
                MessageBox.Show("Ocorreu um erro interno, tente novamente mais tarde.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private bool ValidateDescription() {
            return Product.Description != null && !Product.Description.Equals("");
        }

        private bool ValidateName() {
            return Product.Name != null && !Product.Name.Equals("");
        }

        private bool ValidateCategory() {
            return !ComboBoxCategory.Text.Equals("");
        }

        private bool ValidateValue() {
            return Product.Value > 0;
        }

        private bool ValidatePromotion() { 
            return Product.PromotionPercentage > 0;
        }

        private void FormProductSave_FormClosed(object sender, FormClosedEventArgs e) {

            Products.InitializeOrResetAndSearchDataGrid();

        }

    }
}
