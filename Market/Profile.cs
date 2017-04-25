using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop.App;
using Shop.Models;

namespace Shop {

    public partial class FormProfile : Form {

        private FormMain Main;
        private Customer Customer;

        public FormProfile(FormMain main) {
            Main = main;

            InitializeComponent();
        }

        private void FormProfile_Load(object sender, EventArgs e) {
            Customer = (Customer) Session.User;

            object[] Cities = DAO.Cities.List().ToArray();
            object[] States = DAO.States.List().ToArray();

            ComboBoxAddressCity.Items.AddRange(Cities);
            ComboBoxAddressState.Items.AddRange(States);

            LabelNameHeader.Text = Customer.Name;
            LabelUsernameHeader.Text = Customer.Username;

            TextBoxUsername.Text = Customer.Username;
            TextBoxCreatedAt.Text = Customer.CreatedAt.ToString("ddMMyyyy");

            TextBoxName.Text = Customer.Name;
            TextBoxDocument.Text = Customer.Document;
            TextBoxEmail.Text = Customer.Email;
            TextBoxPhone.Text = Customer.Phone;

            TextBoxAddressName.Text = Customer.Address.Name;
            TextBoxAddressZipCode.Text = Customer.Address.ZipCode;
            ComboBoxAddressCity.SelectedIndex = ComboBoxAddressCity.FindStringExact(Customer.Address.City);
            ComboBoxAddressState.SelectedIndex = ComboBoxAddressState.FindStringExact(Customer.Address.State);

        }

        private void ButtonSave_Click(object sender, EventArgs e) {

            if (!ValidateProfile()) {
                MessageBox.Show("Preencha os campos necessários.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TextBoxUsername.Focus();

                return;
            }

            if (!ValidateLogin()) {
                return;
            }

            if (!ValidateInfo()) {
                return;
            }

            Customer.Username = TextBoxUsername.Text;
            
            if(!TextBoxNewPassword.Text.Equals("") && TextBoxNewPassword.Text != null) {
                Customer.Password = Util.Encryptor.MD5Hash(TextBoxNewPassword.Text);
            }

            Customer.Name = TextBoxName.Text;
            Customer.Document = TextBoxDocument.Text;
            Customer.Email = TextBoxEmail.Text;
            Customer.Phone = TextBoxPhone.Text;

            Customer.Address.Name = TextBoxAddressName.Text;
            Customer.Address.ZipCode = TextBoxAddressZipCode.Text;
            Customer.Address.City = ComboBoxAddressCity.GetItemText(ComboBoxAddressCity.SelectedItem);
            Customer.Address.State = ComboBoxAddressState.GetItemText(ComboBoxAddressState.SelectedItem);

            try {

                DAO.Customers.Update(Customer);

                Main.Menu.Customer = Customer;
                Main.Menu.UpdateView();

                Close();

            } catch {

                MessageBox.Show("Ocorreu um erro interno, tente novamente mais tarde.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxUsername.Focus();

                return;

            }

        }

        private bool ValidateProfile() {

            return !TextBoxUsername.Text.Equals("") && TextBoxUsername.Text != null &&
                   (!TextBoxCurrentPassword.Text.Equals("") ? !TextBoxCurrentPassword.Text.Equals("") && TextBoxCurrentPassword.Text != null && !TextBoxNewPassword.Text.Equals("") && TextBoxNewPassword.Text != null : true) &&
                   !TextBoxName.Text.Equals("") && TextBoxName.Text != null &&
                   !TextBoxDocument.Text.Equals("") && TextBoxDocument.Text != null &&
                   TextBoxDocument.MaskFull &&
                   !TextBoxEmail.Text.Equals("") && TextBoxEmail.Text != null &&
                   !TextBoxPhone.Text.Equals("") && TextBoxPhone.Text != null &&
                   !TextBoxAddressName.Text.Equals("") && TextBoxAddressName.Text != null &&
                   !TextBoxAddressZipCode.Text.Equals("") && TextBoxAddressZipCode.Text != null &&
                   TextBoxAddressZipCode.MaskFull &&
                   !ComboBoxAddressCity.GetItemText(ComboBoxAddressCity.SelectedItem).Equals("") &&
                   !ComboBoxAddressState.GetItemText(ComboBoxAddressState.SelectedItem).Equals("");

        }

        private bool ValidateLogin() {

            try {

                if (!ValidateUsername()) {
                    MessageBox.Show("Nome de usuário indisponível.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TextBoxUsername.Focus();

                    return false;
                }

            } catch {

                MessageBox.Show("Ocorreu um erro interno, tente novamente mais tarde.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxUsername.Focus();

                return false;

            }

            if (!ValidateCurrentPassword()) {
                MessageBox.Show("A senha atual não confere.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextBoxUsername.Focus();

                return false;
            }

            return true;

        }

        private bool ValidateUsername() {
            return !TextBoxUsername.Text.Equals(Customer.Username) ? (DAO.Customers.FindOneByUsername(TextBoxUsername.Text) == null ? true : false) : true;
        }

        private bool ValidateCurrentPassword() {
            return !TextBoxCurrentPassword.Text.Equals("") ? Util.Encryptor.MD5Hash(TextBoxCurrentPassword.Text).Equals(Customer.Password) : true;
        }

        private bool ValidateInfo() {

            try {

                if (!ValidateDocument()) {
                    MessageBox.Show("CPF já cadastrado.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TextBoxName.Focus();

                    return false;
                }

            } catch {

                MessageBox.Show("Ocorreu um erro interno, tente novamente mais tarde.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxName.Focus();

                return false;

            }

            return true;

        }

        private bool ValidateDocument() {
            return !TextBoxDocument.Text.Equals(Customer.Document) ? (DAO.Customers.FindOneByDocument(TextBoxDocument.Text) == null ? true : false) : true;
        }

        private void TextBoxName_KeyUp(object sender, KeyEventArgs e) {

            if (!TextBoxName.Text.Equals("")) {
                LabelNameHeader.Text = TextBoxName.Text;
            } else {
                LabelNameHeader.Text = "Sem Nome";
            }

        }

        private void TextBoxUsername_KeyUp(object sender, KeyEventArgs e) {

            if (!TextBoxUsername.Text.Equals("")) {
                LabelUsernameHeader.Text = TextBoxUsername.Text;
            } else {
                LabelUsernameHeader.Text = "sem.nome";
            }
            
        }

        private void TextBoxUsername_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

    }
}
