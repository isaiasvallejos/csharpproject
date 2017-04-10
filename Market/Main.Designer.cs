namespace Market
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.PanelLoginOrSignUp = new System.Windows.Forms.Panel();
            this.ButtonSignUpOpen = new System.Windows.Forms.Button();
            this.ButtonLoginOpen = new System.Windows.Forms.Button();
            this.LabelOr = new System.Windows.Forms.Label();
            this.ListViewProducts = new System.Windows.Forms.ListView();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.PanelProducts = new System.Windows.Forms.Panel();
            this.PanelLoginOrSignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLoginOrSignUp
            // 
            this.PanelLoginOrSignUp.Controls.Add(this.ButtonSignUpOpen);
            this.PanelLoginOrSignUp.Controls.Add(this.ButtonLoginOpen);
            this.PanelLoginOrSignUp.Controls.Add(this.LabelOr);
            this.PanelLoginOrSignUp.Location = new System.Drawing.Point(184, 312);
            this.PanelLoginOrSignUp.Name = "PanelLoginOrSignUp";
            this.PanelLoginOrSignUp.Size = new System.Drawing.Size(170, 26);
            this.PanelLoginOrSignUp.TabIndex = 4;
            // 
            // ButtonSignUpOpen
            // 
            this.ButtonSignUpOpen.Location = new System.Drawing.Point(85, 2);
            this.ButtonSignUpOpen.Name = "ButtonSignUpOpen";
            this.ButtonSignUpOpen.Size = new System.Drawing.Size(80, 22);
            this.ButtonSignUpOpen.TabIndex = 7;
            this.ButtonSignUpOpen.Text = "&Cadastre-se";
            this.ButtonSignUpOpen.UseVisualStyleBackColor = true;
            this.ButtonSignUpOpen.Click += new System.EventHandler(this.ButtonSignUpOpen_Click);
            // 
            // ButtonLoginOpen
            // 
            this.ButtonLoginOpen.Location = new System.Drawing.Point(7, 2);
            this.ButtonLoginOpen.Name = "ButtonLoginOpen";
            this.ButtonLoginOpen.Size = new System.Drawing.Size(55, 22);
            this.ButtonLoginOpen.TabIndex = 6;
            this.ButtonLoginOpen.Text = "&Login";
            this.ButtonLoginOpen.UseVisualStyleBackColor = true;
            this.ButtonLoginOpen.Click += new System.EventHandler(this.ButtonLoginOpen_Click);
            // 
            // LabelOr
            // 
            this.LabelOr.AutoSize = true;
            this.LabelOr.Location = new System.Drawing.Point(65, 6);
            this.LabelOr.Name = "LabelOr";
            this.LabelOr.Size = new System.Drawing.Size(19, 13);
            this.LabelOr.TabIndex = 5;
            this.LabelOr.Text = "ou";
            // 
            // ListViewProducts
            // 
            this.ListViewProducts.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.ListViewProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListViewProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListViewProducts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ListViewProducts.Location = new System.Drawing.Point(12, 261);
            this.ListViewProducts.MultiSelect = false;
            this.ListViewProducts.Name = "ListViewProducts";
            this.ListViewProducts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ListViewProducts.Size = new System.Drawing.Size(340, 10);
            this.ListViewProducts.TabIndex = 5;
            this.ListViewProducts.TileSize = new System.Drawing.Size(160, 30);
            this.ListViewProducts.UseCompatibleStateImageBehavior = false;
            this.ListViewProducts.ItemActivate += new System.EventHandler(this.ListViewProducts_ItemActivate);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(12, 51);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(335, 20);
            this.TextBoxSearch.TabIndex = 6;
            this.TextBoxSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxSearch_KeyUp);
            // 
            // PanelProducts
            // 
            this.PanelProducts.AutoScroll = true;
            this.PanelProducts.Location = new System.Drawing.Point(12, 81);
            this.PanelProducts.Name = "PanelProducts";
            this.PanelProducts.Size = new System.Drawing.Size(355, 224);
            this.PanelProducts.TabIndex = 7;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 350);
            this.Controls.Add(this.PanelProducts);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.ListViewProducts);
            this.Controls.Add(this.PanelLoginOrSignUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Market";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.PanelLoginOrSignUp.ResumeLayout(false);
            this.PanelLoginOrSignUp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Panel PanelLoginOrSignUp;
        private System.Windows.Forms.Button ButtonSignUpOpen;
        private System.Windows.Forms.Button ButtonLoginOpen;
        private System.Windows.Forms.Label LabelOr;
        private System.Windows.Forms.ListView ListViewProducts;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Panel PanelProducts;
    }
}