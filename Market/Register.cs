using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Shop.Models;

namespace Shop {

    public partial class FormRegister : Form {

        private FormMain Main;
        private Customer Customer;

        public FormRegister(FormMain main) {
            Main = main;

            InitializeComponent();
        }

        private void FormRegister_Load(object sender, EventArgs e) {

            Customer = new Customer();

            object[] Cities = DAO.Cities.List().ToArray();
            object[] States = DAO.States.List().ToArray();

            ComboBoxAddressCity.Items.AddRange(Cities);
            ComboBoxAddressState.Items.AddRange(States);

            PanelStepOne.Visible = true;
            PanelStepTwo.Visible = false;
            PanelStepThree.Visible = false;

        }

        private void ButtonStepOne_Click(object sender, EventArgs e) {

            if (!ValidateStepOne()) {
                MessageBox.Show("Preencha os campos necessários.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TextBoxUsername.Focus();

                return;
            }

            try {

                if (!ValidateUsername()) {
                    MessageBox.Show("Nome de usuário indisponível.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TextBoxUsername.Focus();

                    return;
                }

            } catch {

                MessageBox.Show("Ocorreu um erro interno, tente novamente mais tarde.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxUsername.Focus();

                return;

            }

            if (!ValidateEqualityPasswords()) {
                MessageBox.Show("As senhas não conferem.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextBoxUsername.Focus();

                return;
            }

            Customer.Username = TextBoxUsername.Text;
            Customer.Password = TextBoxPassword.Text; 

            PanelStepOne.Visible = false;
            PanelStepTwo.Visible = true;

            AcceptButton = ButtonStepTwo;

        }

        private bool ValidateStepOne() {
            return !TextBoxUsername.Text.Equals("") && TextBoxUsername.Text != null && !TextBoxPassword.Text.Equals("") && TextBoxPassword.Text != null && !TextBoxConfirmPassword.Text.Equals("") && TextBoxConfirmPassword.Text != null;
        }

        private bool ValidateUsername() {
            return DAO.Customers.FindOneByUsername(TextBoxUsername.Text) == null ? true : false;
        }

        private bool ValidateEqualityPasswords() {
            return TextBoxPassword.Text.Equals(TextBoxConfirmPassword.Text);
        }

        private void TextBoxUsername_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void ButtonStepTwo_Click(object sender, EventArgs e) {

            if (!ValidateStepTwo()) {
                MessageBox.Show("Preencha os campos necessários.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TextBoxName.Focus();

                return;
            }

            try {

                if (!ValidateDocument()) {
                    MessageBox.Show("Cliente já cadastrado.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TextBoxName.Focus();

                    return;
                }

            } catch {

                MessageBox.Show("Ocorreu um erro interno, tente novamente mais tarde.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxName.Focus();

                return;

            }

            Customer.Name = TextBoxName.Text;
            Customer.Email = TextBoxEmail.Text;
            Customer.Document = TextBoxDocument.Text;
            Customer.Phone = TextBoxDocument.Text;

            PanelStepTwo.Visible = false;
            PanelStepThree.Visible = true;

            AcceptButton = ButtonRegister;

        }

        private bool ValidateStepTwo() {
            return !TextBoxName.Text.Equals("") && TextBoxName.Text != null && !TextBoxEmail.Text.Equals("") && TextBoxEmail.Text != null && !TextBoxDocument.Text.Equals("") && TextBoxDocument.Text != null && TextBoxDocument.MaskFull && !TextBoxPhone.Text.Equals("") && TextBoxPhone.Text != null;
        }

        private bool ValidateDocument() {
            return DAO.Customers.FindOneByDocument(TextBoxDocument.Text) == null ? true : false;
        }

        private void ButtonRegister_Click(object sender, EventArgs e) {

            if (!ValidateStepThree()) {
                MessageBox.Show("Preencha os campos necessários.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TextBoxAddressName.Focus();

                return;
            }

            TextBoxAddressName.Focus();

            Customer.Address = new Address();
            Customer.Address.Name = TextBoxAddressName.Text;
            Customer.Address.ZipCode = TextBoxAddressZipCode.Text;
            Customer.Address.City = ComboBoxAddressCity.GetItemText(ComboBoxAddressCity.SelectedItem);
            Customer.Address.State = ComboBoxAddressState.GetItemText(ComboBoxAddressState.SelectedItem);

            Customer.CreatedAt = DateTime.Now;
            Customer.UpdatedAt = DateTime.Now;

            try {

                DAO.Customers.Add(Customer);
                MessageBox.Show("Bem-vindo " + Customer.Name + "!", "", MessageBoxButtons.OK);

                Main.Menu.Customer = Customer;
                Main.Menu.UpdateView();

                Close();

            } catch {

                MessageBox.Show("Ocorreu um erro interno, tente novamente mais tarde.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxUsername.Focus();

                return;

            }

        }

        private bool ValidateStepThree() {
            return !TextBoxAddressName.Text.Equals("") && TextBoxAddressName.Text != null && !TextBoxAddressZipCode.Text.Equals("") && TextBoxAddressZipCode.Text != null && TextBoxAddressZipCode.MaskFull && !ComboBoxAddressCity.GetItemText(ComboBoxAddressCity.SelectedItem).Equals("") && !ComboBoxAddressState.GetItemText(ComboBoxAddressState.SelectedItem).Equals("");
        }

    }

}
