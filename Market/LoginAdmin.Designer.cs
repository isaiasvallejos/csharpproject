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
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.PanelLogin = new System.Windows.Forms.Panel();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.PanelUsername = new System.Windows.Forms.Panel();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.PanelPassword = new System.Windows.Forms.Panel();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.LabelLoginTitle = new System.Windows.Forms.Label();
            this.PanelLogin.SuspendLayout();
            this.PanelUsername.SuspendLayout();
            this.PanelPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLogin.FlatAppearance.BorderSize = 0;
            this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.ButtonLogin.Location = new System.Drawing.Point(148, 155);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(55, 22);
            this.ButtonLogin.TabIndex = 0;
            this.ButtonLogin.TabStop = false;
            this.ButtonLogin.Text = "Entrar";
            this.ButtonLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // PanelLogin
            // 
            this.PanelLogin.BackColor = System.Drawing.Color.White;
            this.PanelLogin.Controls.Add(this.LabelPassword);
            this.PanelLogin.Controls.Add(this.LabelUsername);
            this.PanelLogin.Controls.Add(this.PanelUsername);
            this.PanelLogin.Controls.Add(this.PanelPassword);
            this.PanelLogin.Controls.Add(this.LabelLoginTitle);
            this.PanelLogin.Location = new System.Drawing.Point(12, 12);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.Size = new System.Drawing.Size(191, 133);
            this.PanelLogin.TabIndex = 137;
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.LabelPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LabelPassword.Location = new System.Drawing.Point(9, 81);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(31, 12);
            this.LabelPassword.TabIndex = 141;
            this.LabelPassword.Text = "Senha";
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.LabelUsername.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LabelUsername.Location = new System.Drawing.Point(9, 37);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(76, 12);
            this.LabelUsername.TabIndex = 140;
            this.LabelUsername.Text = "Nome de Usuário";
            // 
            // PanelUsername
            // 
            this.PanelUsername.BackColor = System.Drawing.Color.White;
            this.PanelUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelUsername.Controls.Add(this.TextBoxUsername);
            this.PanelUsername.Location = new System.Drawing.Point(11, 53);
            this.PanelUsername.Name = "PanelUsername";
            this.PanelUsername.Size = new System.Drawing.Size(170, 23);
            this.PanelUsername.TabIndex = 1;
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.TextBoxUsername.Location = new System.Drawing.Point(5, 4);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(159, 13);
            this.TextBoxUsername.TabIndex = 1;
            this.TextBoxUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxUsername_KeyPress);
            // 
            // PanelPassword
            // 
            this.PanelPassword.BackColor = System.Drawing.Color.White;
            this.PanelPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelPassword.Controls.Add(this.TextBoxPassword);
            this.PanelPassword.Location = new System.Drawing.Point(11, 97);
            this.PanelPassword.Name = "PanelPassword";
            this.PanelPassword.Size = new System.Drawing.Size(170, 23);
            this.PanelPassword.TabIndex = 2;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPassword.Location = new System.Drawing.Point(5, 4);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(159, 13);
            this.TextBoxPassword.TabIndex = 2;
            // 
            // LabelLoginTitle
            // 
            this.LabelLoginTitle.AutoSize = true;
            this.LabelLoginTitle.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLoginTitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelLoginTitle.Location = new System.Drawing.Point(8, 7);
            this.LabelLoginTitle.Name = "LabelLoginTitle";
            this.LabelLoginTitle.Size = new System.Drawing.Size(97, 22);
            this.LabelLoginTitle.TabIndex = 136;
            this.LabelLoginTitle.Text = "Autenticação";
            // 
            // FormLoginAdmin
            // 
            this.AcceptButton = this.ButtonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 188);
            this.Controls.Add(this.PanelLogin);
            this.Controls.Add(this.ButtonLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLoginAdmin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador – Login";
            this.PanelLogin.ResumeLayout(false);
            this.PanelLogin.PerformLayout();
            this.PanelUsername.ResumeLayout(false);
            this.PanelUsername.PerformLayout();
            this.PanelPassword.ResumeLayout(false);
            this.PanelPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Panel PanelLogin;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Panel PanelUsername;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.Panel PanelPassword;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label LabelLoginTitle;
    }
}