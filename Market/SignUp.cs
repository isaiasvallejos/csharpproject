using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Market.Models;
using Market.DAO;
using Market.App;

namespace Market
{
    public partial class FormSignUp : Form
    {
        private FormMain Main;

        public FormSignUp(FormMain _Main)
        {
            Main = _Main;

            InitializeComponent();
        }

        /// <summary>
        /// Evento ao pressionar uma clicar no Button de continuar.
        /// <para>Valida e atualiza a view para o próximo passo.</para>
        /// </summary>
        private void ButtonContinue_Click(object sender, EventArgs e)
        {
            if (!ValidateStep1Fill())
            {
                MessageBox.Show(
                    "Por favor, preencha os campos solicitados.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (!ValidateStep1Password())
            {
                MessageBox.Show(
                    "Senha e confirmação de senha não coincidem.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            string username = TextBoxUsername.Text;
            string password = TextBoxPassword.Text;

            if (Users.FindOneByUsername(username) != null) 
            {
                MessageBox.Show(
                    "Nome de usuário já cadastrado, verifique e tente novamente.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            PanelStep1.Visible = false;
            PanelStep2.Visible = true;
            AcceptButton = ButtonRegister;

            TextBoxName.Focus();

        }

        /// <summary>
        /// Evento ao pressionar uma clicar no Button de cadastrar-se.
        /// <para>Valida, insere um novo cliente, realiza login baseado no cadastro realizado.</para>
        /// </summary>
        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            if (!ValidateStep2Fill())
            {
                MessageBox.Show(
                    "Por favor, preencha os campos solicitados.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (!ValidateStep2Document())
            {
                MessageBox.Show(
                    "No. Documento inválido, verifique e tente novamente.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            Customer customer = new Customer();

            customer.Username = TextBoxUsername.Text;
            customer.Password = TextBoxPassword.Text;
            customer.Name = TextBoxName.Text;
            customer.Document = MaskedTextBoxDocument.Text;
            customer.Phone = MaskedTextBoxPhone.Text;
            customer.Email = TextBoxEmail.Text;
            customer.CreatedAt = DateTime.Now;
            customer.UpdatedAt = DateTime.Now;

            if (Customers.FindOneByDocument(customer.Document) != null)
            {
                MessageBox.Show(
                    "No. Documento já cadastrado, verifique e tente novamente.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                Users.Add(customer);

                MessageBox.Show(
                    "Seu cadastro foi realizado com sucesso!",
                    "Bem-vindo",
                    MessageBoxButtons.OK
                );

                Session.Login(customer);

                ClearForm();
                Close();
            }
            catch
            {
                MessageBox.Show(
                    "Problemas ao inserir cadastro, tente novamente mais tarde.",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

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
        /// Validação de preenchimento dos campos do "Passo 1".
        /// </summary>
        private bool ValidateStep1Fill()
        {
            return !TextBoxUsername.Text.Trim().Equals("") && !TextBoxPassword.Text.Trim().Equals("") && !TextBoxConfirmPassword.Text.Trim().Equals("");
        }

        /// <summary>
        /// Validação da igualdade de senha e confirmação de senha do "Passo 1".
        /// </summary>
        private bool ValidateStep1Password()
        {
            return TextBoxPassword.Text.Trim().Equals(TextBoxConfirmPassword.Text.Trim());
        }

        /// <summary>
        /// Validação de preenchimento dos campos do "Passo 2".
        /// </summary>
        private bool ValidateStep2Fill()
        {
            return !TextBoxName.Text.Trim().Equals("") && !MaskedTextBoxDocument.Text.Trim().Equals("") && !MaskedTextBoxPhone.Text.Trim().Equals("") && !TextBoxEmail.Text.Trim().Equals("");
        }

        /// <summary>
        /// Validação de nº de documento do "Passo 2".
        /// </summary>
        private bool ValidateStep2Document()
        {
            Regex regex = new Regex(@"[0-9]{3}\.?[0-9]{3}\.?[0-9]{3}\-?[0-9]{2}");

            return regex.IsMatch(MaskedTextBoxDocument.Text);
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
