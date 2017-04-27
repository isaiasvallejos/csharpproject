namespace Shop {

    partial class FormStart {
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
            this.LabelPassword = new System.Windows.Forms.Label();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.PanelUsername = new System.Windows.Forms.Panel();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.PanelPassword = new System.Windows.Forms.Panel();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.LabelWelcomeTitle = new System.Windows.Forms.Label();
            this.LabelInformation = new System.Windows.Forms.Label();
            this.ButtonRegister = new System.Windows.Forms.Button();
            this.LabelName = new System.Windows.Forms.Label();
            this.PanelName = new System.Windows.Forms.Panel();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.PanelUsername.SuspendLayout();
            this.PanelPassword.SuspendLayout();
            this.PanelName.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.LabelPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LabelPassword.Location = new System.Drawing.Point(13, 171);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(31, 12);
            this.LabelPassword.TabIndex = 146;
            this.LabelPassword.Text = "Senha";
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.LabelUsername.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LabelUsername.Location = new System.Drawing.Point(13, 128);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(76, 12);
            this.LabelUsername.TabIndex = 145;
            this.LabelUsername.Text = "Nome de Usuário";
            // 
            // PanelUsername
            // 
            this.PanelUsername.BackColor = System.Drawing.Color.White;
            this.PanelUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelUsername.Controls.Add(this.TextBoxUsername);
            this.PanelUsername.Location = new System.Drawing.Point(15, 144);
            this.PanelUsername.Name = "PanelUsername";
            this.PanelUsername.Size = new System.Drawing.Size(170, 23);
            this.PanelUsername.TabIndex = 2;
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.TextBoxUsername.Location = new System.Drawing.Point(5, 4);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(159, 13);
            this.TextBoxUsername.TabIndex = 2;
            this.TextBoxUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxUsername_KeyPress);
            // 
            // PanelPassword
            // 
            this.PanelPassword.BackColor = System.Drawing.Color.White;
            this.PanelPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelPassword.Controls.Add(this.TextBoxPassword);
            this.PanelPassword.Location = new System.Drawing.Point(15, 188);
            this.PanelPassword.Name = "PanelPassword";
            this.PanelPassword.Size = new System.Drawing.Size(170, 23);
            this.PanelPassword.TabIndex = 3;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPassword.Location = new System.Drawing.Point(5, 4);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(159, 13);
            this.TextBoxPassword.TabIndex = 3;
            // 
            // LabelWelcomeTitle
            // 
            this.LabelWelcomeTitle.AutoSize = true;
            this.LabelWelcomeTitle.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWelcomeTitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelWelcomeTitle.Location = new System.Drawing.Point(11, 11);
            this.LabelWelcomeTitle.Name = "LabelWelcomeTitle";
            this.LabelWelcomeTitle.Size = new System.Drawing.Size(205, 22);
            this.LabelWelcomeTitle.TabIndex = 147;
            this.LabelWelcomeTitle.Text = "Bem-vindo ao Prophet Shop!";
            // 
            // LabelInformation
            // 
            this.LabelInformation.Location = new System.Drawing.Point(12, 47);
            this.LabelInformation.Name = "LabelInformation";
            this.LabelInformation.Size = new System.Drawing.Size(441, 32);
            this.LabelInformation.TabIndex = 148;
            this.LabelInformation.Text = "Antes de começar a usar a loja, é necessário cadastrar um usuário administrador p" +
    "ara utilizar todas as funcionalidades da administração:";
            // 
            // ButtonRegister
            // 
            this.ButtonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRegister.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ButtonRegister.FlatAppearance.BorderSize = 0;
            this.ButtonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRegister.Location = new System.Drawing.Point(378, 215);
            this.ButtonRegister.Name = "ButtonRegister";
            this.ButtonRegister.Size = new System.Drawing.Size(75, 23);
            this.ButtonRegister.TabIndex = 150;
            this.ButtonRegister.TabStop = false;
            this.ButtonRegister.Text = "Registrar";
            this.ButtonRegister.UseVisualStyleBackColor = true;
            this.ButtonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.LabelName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LabelName.Location = new System.Drawing.Point(12, 85);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(30, 12);
            this.LabelName.TabIndex = 152;
            this.LabelName.Text = "Nome";
            // 
            // PanelName
            // 
            this.PanelName.BackColor = System.Drawing.Color.White;
            this.PanelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelName.Controls.Add(this.TextBoxName);
            this.PanelName.Location = new System.Drawing.Point(14, 101);
            this.PanelName.Name = "PanelName";
            this.PanelName.Size = new System.Drawing.Size(170, 23);
            this.PanelName.TabIndex = 1;
            // 
            // TextBoxName
            // 
            this.TextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxName.Location = new System.Drawing.Point(5, 4);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(159, 13);
            this.TextBoxName.TabIndex = 1;
            // 
            // FormStart
            // 
            this.AcceptButton = this.ButtonRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 250);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.PanelName);
            this.Controls.Add(this.ButtonRegister);
            this.Controls.Add(this.LabelInformation);
            this.Controls.Add(this.LabelWelcomeTitle);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.PanelUsername);
            this.Controls.Add(this.PanelPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStart";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormStart_FormClosing);
            this.PanelUsername.ResumeLayout(false);
            this.PanelUsername.PerformLayout();
            this.PanelPassword.ResumeLayout(false);
            this.PanelPassword.PerformLayout();
            this.PanelName.ResumeLayout(false);
            this.PanelName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Panel PanelUsername;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.Panel PanelPassword;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label LabelWelcomeTitle;
        private System.Windows.Forms.Label LabelInformation;
        private System.Windows.Forms.Button ButtonRegister;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Panel PanelName;
        private System.Windows.Forms.TextBox TextBoxName;
    }

}