namespace Shop
{
    partial class FormSignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelStep1 = new System.Windows.Forms.Panel();
            this.ButtonContinue = new System.Windows.Forms.Button();
            this.LabelConfirmPassword = new System.Windows.Forms.Label();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.TextBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.PanelStep2 = new System.Windows.Forms.Panel();
            this.MaskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.MaskedTextBoxDocument = new System.Windows.Forms.MaskedTextBox();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.ButtonRegister = new System.Windows.Forms.Button();
            this.LabelPhone = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelDocument = new System.Windows.Forms.Label();
            this.PanelStep1.SuspendLayout();
            this.PanelStep2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelStep1
            // 
            this.PanelStep1.Controls.Add(this.ButtonContinue);
            this.PanelStep1.Controls.Add(this.LabelConfirmPassword);
            this.PanelStep1.Controls.Add(this.TextBoxUsername);
            this.PanelStep1.Controls.Add(this.TextBoxConfirmPassword);
            this.PanelStep1.Controls.Add(this.LabelUsername);
            this.PanelStep1.Controls.Add(this.LabelPassword);
            this.PanelStep1.Controls.Add(this.TextBoxPassword);
            this.PanelStep1.Location = new System.Drawing.Point(0, -1);
            this.PanelStep1.Name = "PanelStep1";
            this.PanelStep1.Size = new System.Drawing.Size(263, 282);
            this.PanelStep1.TabIndex = 11;
            // 
            // ButtonContinue
            // 
            this.ButtonContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonContinue.Location = new System.Drawing.Point(172, 248);
            this.ButtonContinue.Name = "ButtonContinue";
            this.ButtonContinue.Size = new System.Drawing.Size(79, 22);
            this.ButtonContinue.TabIndex = 4;
            this.ButtonContinue.Text = "&Continuar";
            this.ButtonContinue.UseVisualStyleBackColor = true;
            this.ButtonContinue.Click += new System.EventHandler(this.ButtonContinue_Click);
            // 
            // LabelConfirmPassword
            // 
            this.LabelConfirmPassword.Location = new System.Drawing.Point(58, 144);
            this.LabelConfirmPassword.Name = "LabelConfirmPassword";
            this.LabelConfirmPassword.Size = new System.Drawing.Size(145, 13);
            this.LabelConfirmPassword.TabIndex = 17;
            this.LabelConfirmPassword.Text = "Confirmar Senha";
            this.LabelConfirmPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.AcceptsTab = true;
            this.TextBoxUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.TextBoxUsername.Location = new System.Drawing.Point(55, 75);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(148, 20);
            this.TextBoxUsername.TabIndex = 1;
            this.TextBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxUsername_KeyPress);
            // 
            // TextBoxConfirmPassword
            // 
            this.TextBoxConfirmPassword.Location = new System.Drawing.Point(55, 161);
            this.TextBoxConfirmPassword.Name = "TextBoxConfirmPassword";
            this.TextBoxConfirmPassword.Size = new System.Drawing.Size(148, 20);
            this.TextBoxConfirmPassword.TabIndex = 3;
            this.TextBoxConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // LabelUsername
            // 
            this.LabelUsername.Location = new System.Drawing.Point(55, 58);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(148, 13);
            this.LabelUsername.TabIndex = 13;
            this.LabelUsername.Text = "Nome de usuário";
            this.LabelUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelPassword
            // 
            this.LabelPassword.Location = new System.Drawing.Point(58, 101);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(145, 13);
            this.LabelPassword.TabIndex = 15;
            this.LabelPassword.Text = "Senha";
            this.LabelPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(55, 118);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(148, 20);
            this.TextBoxPassword.TabIndex = 2;
            this.TextBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxPassword.UseSystemPasswordChar = true;
            // 
            // PanelStep2
            // 
            this.PanelStep2.Controls.Add(this.MaskedTextBoxPhone);
            this.PanelStep2.Controls.Add(this.MaskedTextBoxDocument);
            this.PanelStep2.Controls.Add(this.LabelEmail);
            this.PanelStep2.Controls.Add(this.TextBoxEmail);
            this.PanelStep2.Controls.Add(this.ButtonRegister);
            this.PanelStep2.Controls.Add(this.LabelPhone);
            this.PanelStep2.Controls.Add(this.TextBoxName);
            this.PanelStep2.Controls.Add(this.LabelName);
            this.PanelStep2.Controls.Add(this.LabelDocument);
            this.PanelStep2.Location = new System.Drawing.Point(1, 0);
            this.PanelStep2.Name = "PanelStep2";
            this.PanelStep2.Size = new System.Drawing.Size(263, 282);
            this.PanelStep2.TabIndex = 19;
            this.PanelStep2.Visible = false;
            // 
            // MaskedTextBoxPhone
            // 
            this.MaskedTextBoxPhone.Location = new System.Drawing.Point(54, 147);
            this.MaskedTextBoxPhone.Mask = "(##) #####-####";
            this.MaskedTextBoxPhone.Name = "MaskedTextBoxPhone";
            this.MaskedTextBoxPhone.Size = new System.Drawing.Size(148, 20);
            this.MaskedTextBoxPhone.TabIndex = 7;
            this.MaskedTextBoxPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MaskedTextBoxPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // MaskedTextBoxDocument
            // 
            this.MaskedTextBoxDocument.Location = new System.Drawing.Point(54, 102);
            this.MaskedTextBoxDocument.Mask = "###\\.###\\.###-##";
            this.MaskedTextBoxDocument.Name = "MaskedTextBoxDocument";
            this.MaskedTextBoxDocument.Size = new System.Drawing.Size(148, 20);
            this.MaskedTextBoxDocument.TabIndex = 6;
            this.MaskedTextBoxDocument.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MaskedTextBoxDocument.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // LabelEmail
            // 
            this.LabelEmail.Location = new System.Drawing.Point(57, 170);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(145, 13);
            this.LabelEmail.TabIndex = 29;
            this.LabelEmail.Text = "E-mail";
            this.LabelEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(54, 187);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(148, 20);
            this.TextBoxEmail.TabIndex = 8;
            this.TextBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ButtonRegister
            // 
            this.ButtonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRegister.Location = new System.Drawing.Point(172, 248);
            this.ButtonRegister.Name = "ButtonRegister";
            this.ButtonRegister.Size = new System.Drawing.Size(79, 22);
            this.ButtonRegister.TabIndex = 9;
            this.ButtonRegister.Text = "&Cadastrar-se";
            this.ButtonRegister.UseVisualStyleBackColor = true;
            this.ButtonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);
            // 
            // LabelPhone
            // 
            this.LabelPhone.Location = new System.Drawing.Point(57, 129);
            this.LabelPhone.Name = "LabelPhone";
            this.LabelPhone.Size = new System.Drawing.Size(145, 13);
            this.LabelPhone.TabIndex = 26;
            this.LabelPhone.Text = "Telefone";
            this.LabelPhone.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TextBoxName
            // 
            this.TextBoxName.AcceptsTab = true;
            this.TextBoxName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxName.Location = new System.Drawing.Point(54, 60);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(148, 20);
            this.TextBoxName.TabIndex = 5;
            this.TextBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelName
            // 
            this.LabelName.Location = new System.Drawing.Point(54, 43);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(148, 13);
            this.LabelName.TabIndex = 22;
            this.LabelName.Text = "Nome";
            this.LabelName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelDocument
            // 
            this.LabelDocument.Location = new System.Drawing.Point(57, 86);
            this.LabelDocument.Name = "LabelDocument";
            this.LabelDocument.Size = new System.Drawing.Size(145, 13);
            this.LabelDocument.TabIndex = 24;
            this.LabelDocument.Text = "No. Documento";
            this.LabelDocument.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormSignUp
            // 
            this.AcceptButton = this.ButtonContinue;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 281);
            this.Controls.Add(this.PanelStep2);
            this.Controls.Add(this.PanelStep1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSignUp";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar-se";
            this.PanelStep1.ResumeLayout(false);
            this.PanelStep1.PerformLayout();
            this.PanelStep2.ResumeLayout(false);
            this.PanelStep2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelStep1;
        private System.Windows.Forms.Button ButtonContinue;
        private System.Windows.Forms.Label LabelConfirmPassword;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.TextBox TextBoxConfirmPassword;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Panel PanelStep2;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.Button ButtonRegister;
        private System.Windows.Forms.Label LabelPhone;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelDocument;
        private System.Windows.Forms.MaskedTextBox MaskedTextBoxPhone;
        private System.Windows.Forms.MaskedTextBox MaskedTextBoxDocument;
    }
}