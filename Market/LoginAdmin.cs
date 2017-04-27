﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop.Models;
using Shop.App;
using Shop.Util;

namespace Shop {

    public partial class FormLoginAdmin : Form {

        private FormMain Main;

        public FormLoginAdmin(FormMain main) {
            Main = main;

            InitializeComponent();
        }

        private void TextBoxPassword_Enter(object sender, EventArgs e) {

            if (TextBoxPassword.Text.Equals("Senha")) {
                TextBoxPassword.Text = "";
                TextBoxPassword.ForeColor = System.Drawing.SystemColors.WindowText;
                TextBoxPassword.UseSystemPasswordChar = true;
            }

        }

        private void TextBoxPassword_Leave(object sender, EventArgs e) {

            if (TextBoxPassword.Text.Equals("")) {
                TextBoxPassword.UseSystemPasswordChar = false;
                TextBoxPassword.Text = "Senha";
                TextBoxPassword.ForeColor = System.Drawing.SystemColors.ControlDark;
            }

        }

        private void ButtonLogin_Click(object sender, EventArgs e) {

            if (!ValidateUsername()) {
                MessageBox.Show("Insira seu nome de usuário.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TextBoxUsername.Focus();

                return;
            }

            if (!ValidatePassword()) {
                MessageBox.Show("Insira sua senha.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TextBoxUsername.Focus();

                return;
            }

            try {

                Manager manager = DAO.Managers.FindOneByLogin(TextBoxUsername.Text, TextBoxPassword.Text);

                if (manager != null) {

                    Session.Login(manager);

                    FormDashboard dashboard = new FormDashboard();

                    Main.Hide();
                    Hide();

                    dashboard.ShowDialog();

                    Main.Reset();
                    Main.Show();
                    Close();

                } else {
                    MessageBox.Show("Nome de usuário e/ou senha inválidos.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } catch {
                MessageBox.Show("Ocorreu um erro interno, tente novamente mais tarde.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            TextBoxUsername.Focus();

        }

        private bool ValidateUsername() {
            return !TextBoxUsername.Text.Equals("") && TextBoxUsername.Text != null;
        }

        private bool ValidatePassword() {
            return !TextBoxPassword.Text.Equals("") && TextBoxPassword.Text != null;
        }

        private void TextBoxUsername_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = (e.KeyChar == (char) Keys.Space);
        }

    }
}