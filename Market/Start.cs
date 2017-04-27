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

namespace Shop {

    public partial class FormStart : Form {

        public Manager Manager = new Manager();

        public FormStart() {
            InitializeComponent();
        }

        private void ButtonRegister_Click(object sender, EventArgs e) {

            if (!ValidateRegister()) {
                MessageBox.Show("Preencha os campos necessários.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TextBoxName.Focus();

                return;
            }

            Manager.Name = TextBoxName.Text;
            Manager.Username = TextBoxUsername.Text;
            Manager.Password = TextBoxPassword.Text;
            Manager.Enabled = true;

            Manager.CreatedAt = DateTime.Now;
            Manager.UpdatedAt = DateTime.Now;

            try {

                DAO.Managers.Add(Manager);

                MessageBox.Show("Bem-vindo a Prophet Shop, " + Manager.Name + "!", "", MessageBoxButtons.OK);

                Close();

            } catch {

                MessageBox.Show("Ocorreu um erro interno, tente novamente mais tarde.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxUsername.Focus();

                return;

            }

        }

        private bool ValidateRegister() {

            return !TextBoxUsername.Text.Equals("") && TextBoxUsername.Text != null &&
                   !TextBoxName.Text.Equals("") && TextBoxName.Text != null &&
                   !TextBoxPassword.Text.Equals("") && TextBoxPassword.Text != null;

        }

        private void TextBoxUsername_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void FormStart_FormClosing(object sender, FormClosingEventArgs e) {

            if(Manager.ID == 0) {
                e.Cancel = true;
            }
            
        }

    }
}
