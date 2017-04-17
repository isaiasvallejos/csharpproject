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

        private Product Product;
        private List<Category> Categories;

        public FormProductSave() {
            InitializeComponent();
        }

        private void FormProductAdd_Load(object sender, EventArgs e) {

            ProductPanelPreview.Product = new Product();
            Product = ProductPanelPreview.Product;

            Categories = DAO.Categories.List();
            ComboBoxCategory.Items.AddRange(Categories.Select(Category => Category.Name).ToArray());

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

            Product.CreatedAt = DateTime.Now;
            Product.UpdatedAt = DateTime.Now;

            try {
                DAO.Products.Add(Product);
                MessageBox.Show("Produto cadastrado com sucesso!", "", MessageBoxButtons.OK);

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

            return Product.Category != null;

        }

        private bool ValidateValue() {

            return Product.Value > 0;

        }

        private bool ValidatePromotion() {

            return Product.PromotionPercentage > 0;

        }

    }
}
