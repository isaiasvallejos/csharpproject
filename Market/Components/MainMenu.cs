using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop.Models;
using Shop.App;

namespace Shop.Components {

    public partial class MainMenu : UserControl {

        public Customer Customer;

        public event EventHandler Login;
        public event EventHandler Register;
        public event EventHandler Profile;
        public event EventHandler Order;
        public event EventHandler Logout;
        public event EventHandler Admin;

        public MainMenu() {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e) {
            UpdateView();
        }

        public void UpdateView() {

            if (Customer != null) {

                PanelLoginOrRegister.Visible = false;
                PanelProfile.Visible = true;

                LabelWelcome.Text = "Bem-vindo " + Customer.Name + "!";

            } else {

                PanelLoginOrRegister.Visible = true;
                PanelProfile.Visible = false;

            }

        }

        private void ButtonLogin_Click(object sender, EventArgs e) {
            if (Login != null) Login(sender, e);
        }

        private void ButtonRegister_Click(object sender, EventArgs e) {
            if (Register != null) Register(sender, e);
        }

        private void ButtonProfile_Click(object sender, EventArgs e) {
            if (Profile != null) Profile(sender, e);
        }

        private void ButtonOrders_Click(object sender, EventArgs e) {
            if (Order != null) Order(sender, e);
        }

        private void ButtonLogout_Click(object sender, EventArgs e) {
            if (Logout != null) Logout(sender, e);
        }

        private void ButtonAdmin_Click(object sender, EventArgs e) {
            if (Admin != null) Admin(sender, e);
        }
    }
}
