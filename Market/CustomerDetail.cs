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

    public partial class FormCustomerDetail : Form {

        private Customer Customer;

        public FormCustomerDetail(Customer customer) {
            Customer = customer;

            InitializeComponent();
        }

        private void FormProfile_Load(object sender, EventArgs e) {

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

    }

}
