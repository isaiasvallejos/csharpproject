namespace Shop {
    partial class FormLogin {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.GroupBoxLogin = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelAddressName = new System.Windows.Forms.Label();
            this.PanelPassword = new System.Windows.Forms.Panel();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.PanelUsername = new System.Windows.Forms.Panel();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.GroupBoxLogin.SuspendLayout();
            this.PanelPassword.SuspendLayout();
            this.PanelUsername.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxLogin
            // 
            this.GroupBoxLogin.Controls.Add(this.label1);
            this.GroupBoxLogin.Controls.Add(this.LabelAddressName);
            this.GroupBoxLogin.Controls.Add(this.PanelPassword);
            this.GroupBoxLogin.Controls.Add(this.PanelUsername);
            this.GroupBoxLogin.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxLogin.Name = "GroupBoxLogin";
            this.GroupBoxLogin.Size = new System.Drawing.Size(222, 117);
            this.GroupBoxLogin.TabIndex = 110;
            this.GroupBoxLogin.TabStop = false;
            this.GroupBoxLogin.Text = "Autenticação";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 12);
            this.label1.TabIndex = 114;
            this.label1.Text = "Nome de Usuário";
            // 
            // LabelAddressName
            // 
            this.LabelAddressName.AutoSize = true;
            this.LabelAddressName.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.LabelAddressName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LabelAddressName.Location = new System.Drawing.Point(8, 65);
            this.LabelAddressName.Name = "LabelAddressName";
            this.LabelAddressName.Size = new System.Drawing.Size(31, 12);
            this.LabelAddressName.TabIndex = 113;
            this.LabelAddressName.Text = "Senha";
            // 
            // PanelPassword
            // 
            this.PanelPassword.BackColor = System.Drawing.Color.White;
            this.PanelPassword.Controls.Add(this.TextBoxPassword);
            this.PanelPassword.Location = new System.Drawing.Point(10, 82);
            this.PanelPassword.Name = "PanelPassword";
            this.PanelPassword.Size = new System.Drawing.Size(202, 23);
            this.PanelPassword.TabIndex = 108;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPassword.Location = new System.Drawing.Point(6, 5);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(191, 13);
            this.TextBoxPassword.TabIndex = 1;
            // 
            // PanelUsername
            // 
            this.PanelUsername.BackColor = System.Drawing.Color.White;
            this.PanelUsername.Controls.Add(this.TextBoxUsername);
            this.PanelUsername.Location = new System.Drawing.Point(10, 36);
            this.PanelUsername.Name = "PanelUsername";
            this.PanelUsername.Size = new System.Drawing.Size(202, 23);
            this.PanelUsername.TabIndex = 12;
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxUsername.Location = new System.Drawing.Point(6, 5);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(191, 13);
            this.TextBoxUsername.TabIndex = 0;
            this.TextBoxUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxUsername_KeyPress);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLogin.FlatAppearance.BorderSize = 0;
            this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.ButtonLogin.Location = new System.Drawing.Point(169, 139);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(55, 22);
            this.ButtonLogin.TabIndex = 110;
            this.ButtonLogin.Text = "Entrar";
            this.ButtonLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // FormLogin
            // 
            this.AcceptButton = this.ButtonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 171);
            this.Controls.Add(this.GroupBoxLogin);
            this.Controls.Add(this.ButtonLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente – Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLogin_FormClosed);
            this.GroupBoxLogin.ResumeLayout(false);
            this.GroupBoxLogin.PerformLayout();
            this.PanelPassword.ResumeLayout(false);
            this.PanelPassword.PerformLayout();
            this.PanelUsername.ResumeLayout(false);
            this.PanelUsername.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxLogin;
        private System.Windows.Forms.Panel PanelPassword;
        private System.Windows.Forms.Panel PanelUsername;
        private System.Windows.Forms.Label LabelAddressName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Button ButtonLogin;
    }
}