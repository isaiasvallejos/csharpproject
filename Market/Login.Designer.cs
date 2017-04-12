namespace Shop
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.PanelPassword = new System.Windows.Forms.Panel();
            this.PanelUsername = new System.Windows.Forms.Panel();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.AcceptsTab = true;
            this.TextBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.TextBoxUsername.Location = new System.Drawing.Point(54, 42);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(148, 13);
            this.TextBoxUsername.TabIndex = 1;
            this.TextBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxUsername_KeyPress);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPassword.Location = new System.Drawing.Point(54, 92);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(148, 13);
            this.TextBoxPassword.TabIndex = 2;
            this.TextBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxPassword.UseSystemPasswordChar = true;
            // 
            // LabelPassword
            // 
            this.LabelPassword.Location = new System.Drawing.Point(57, 68);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(145, 13);
            this.LabelPassword.TabIndex = 2;
            this.LabelPassword.Text = "Senha";
            this.LabelPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelUsername
            // 
            this.LabelUsername.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LabelUsername.Location = new System.Drawing.Point(54, 18);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(148, 13);
            this.LabelUsername.TabIndex = 3;
            this.LabelUsername.Text = "Nome de usuário";
            this.LabelUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PanelPassword
            // 
            this.PanelPassword.BackColor = System.Drawing.Color.White;
            this.PanelPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelPassword.Location = new System.Drawing.Point(47, 86);
            this.PanelPassword.Name = "PanelPassword";
            this.PanelPassword.Size = new System.Drawing.Size(161, 25);
            this.PanelPassword.TabIndex = 4;
            // 
            // PanelUsername
            // 
            this.PanelUsername.BackColor = System.Drawing.Color.White;
            this.PanelUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelUsername.Location = new System.Drawing.Point(47, 36);
            this.PanelUsername.Name = "PanelUsername";
            this.PanelUsername.Size = new System.Drawing.Size(161, 25);
            this.PanelUsername.TabIndex = 5;
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLogin.FlatAppearance.BorderSize = 0;
            this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonLogin.Location = new System.Drawing.Point(90, 124);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(79, 26);
            this.ButtonLogin.TabIndex = 3;
            this.ButtonLogin.Text = "&Conectar-se";
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // FormLogin
            // 
            this.AcceptButton = this.ButtonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(264, 171);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.PanelPassword);
            this.Controls.Add(this.PanelUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Panel PanelPassword;
        private System.Windows.Forms.Panel PanelUsername;
        private System.Windows.Forms.Button ButtonLogin;
    }
}