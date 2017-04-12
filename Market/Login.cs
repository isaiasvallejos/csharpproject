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
using Shop.DAO;

namespace Shop
{
    public partial class FormLogin : Form
    {
        private FormMain Main;

        public FormLogin(FormMain _Main)
        {
            Main = _Main;

            InitializeComponent(); 
        }

        /// <summary>
        /// Evento ao pressionar uma clicar no Button de conectar-se.
        /// <para>Valida, busca o usuário e realiza login baseado no usuário encontrado.</para>
        /// </summary>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            TextBoxUsername.Focus();

            if (!ValidateFill())
            {
                MessageBox.Show(
                    "Por favor, preencha os campos solicitados.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            string username = TextBoxUsername.Text;
            string password = TextBoxPassword.Text;

            User user = Users.FindOneByLogin(username, password);

            if(user == null)
            {
                MessageBox.Show(
                    "Usuário e/ou senha inválidos, tente novamente.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            Session.Login(user);

            ClearForm();
            Close();
        }


        /// <summary>
        /// Evento ao pressionar uma tecla no TextBox de nome de usuário.
        /// <para>Remove caractere de espaço.</para>
        /// </summary>
        private void TextBoxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        /// <summary>
        /// Validação de preenchimento dos campos.
        /// </summary>
        private bool ValidateFill()
        {
            return !TextBoxUsername.Text.Trim().Equals("") && !TextBoxPassword.Text.Trim().Equals("");
        }

        /// <summary>
        /// Limpa os campos do formulário.
        /// </summary>
        private void ClearForm()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    (control as TextBox).Text = "";
                }
            }
        }
    }
}
