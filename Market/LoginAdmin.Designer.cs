namespace Shop {

    partial class FormLoginAdmin {
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
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.PanelPassword = new System.Windows.Forms.Panel();
            this.PanelUsername = new System.Windows.Forms.Panel();
            this.TextBoxUsername = new Shop.Components.TextBoxPlaceHolder();
            this.TextBoxPassword = new Shop.Components.TextBoxPlaceHolder();
            this.GroupBoxLogin.SuspendLayout();
            this.PanelPassword.SuspendLayout();
            this.PanelUsername.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxLogin
            // 
            this.GroupBoxLogin.Controls.Add(this.ButtonLogin);
            this.GroupBoxLogin.Controls.Add(this.PanelPassword);
            this.GroupBoxLogin.Controls.Add(this.PanelUsername);
            this.GroupBoxLogin.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxLogin.Name = "GroupBoxLogin";
            this.GroupBoxLogin.Size = new System.Drawing.Size(218, 92);
            this.GroupBoxLogin.TabIndex = 110;
            this.GroupBoxLogin.TabStop = false;
            this.GroupBoxLogin.Text = "Autenticação";
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLogin.FlatAppearance.BorderSize = 0;
            this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.ButtonLogin.Location = new System.Drawing.Point(153, 55);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(55, 22);
            this.ButtonLogin.TabIndex = 110;
            this.ButtonLogin.Text = "Entrar";
            this.ButtonLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // PanelPassword
            // 
            this.PanelPassword.BackColor = System.Drawing.Color.White;
            this.PanelPassword.Controls.Add(this.TextBoxPassword);
            this.PanelPassword.Location = new System.Drawing.Point(10, 55);
            this.PanelPassword.Name = "PanelPassword";
            this.PanelPassword.Size = new System.Drawing.Size(137, 23);
            this.PanelPassword.TabIndex = 108;
            // 
            // PanelUsername
            // 
            this.PanelUsername.BackColor = System.Drawing.Color.White;
            this.PanelUsername.Controls.Add(this.TextBoxUsername);
            this.PanelUsername.Location = new System.Drawing.Point(10, 24);
            this.PanelUsername.Name = "PanelUsername";
            this.PanelUsername.Size = new System.Drawing.Size(137, 23);
            this.PanelUsername.TabIndex = 12;
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxUsername.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TextBoxUsername.IsPassword = false;
            this.TextBoxUsername.Location = new System.Drawing.Point(6, 5);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.PlaceHolderText = "Nome de Usuário";
            this.TextBoxUsername.Size = new System.Drawing.Size(126, 13);
            this.TextBoxUsername.TabIndex = 111;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPassword.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TextBoxPassword.IsPassword = true;
            this.TextBoxPassword.Location = new System.Drawing.Point(6, 5);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PlaceHolderText = "Senha";
            this.TextBoxPassword.Size = new System.Drawing.Size(126, 13);
            this.TextBoxPassword.TabIndex = 112;
            // 
            // FormLoginAdmin
            // 
            this.AcceptButton = this.ButtonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 114);
            this.Controls.Add(this.GroupBoxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLoginAdmin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prophet Shop";
            this.GroupBoxLogin.ResumeLayout(false);
            this.PanelPassword.ResumeLayout(false);
            this.PanelPassword.PerformLayout();
            this.PanelUsername.ResumeLayout(false);
            this.PanelUsername.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxLogin;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Panel PanelPassword;
        private System.Windows.Forms.Panel PanelUsername;
        private Components.TextBoxPlaceHolder TextBoxPassword;
        private Components.TextBoxPlaceHolder TextBoxUsername;
    }
}