namespace Shop
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
            this.ComboBoxOrderBy = new System.Windows.Forms.ComboBox();
            this.LabelOrderBy = new System.Windows.Forms.Label();
            this.PanelSearch = new System.Windows.Forms.Panel();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.GroupBoxFooter = new System.Windows.Forms.GroupBox();
            this.Menu = new Shop.Components.MainMenu();
            this.CartPanel = new Shop.Components.CartPanel();
            this.ProductBox = new Shop.Components.ProductBox();
            this.TextBoxSearch = new Shop.Components.TextBoxPlaceHolder();
            this.PanelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBoxOrderBy
            // 
            this.ComboBoxOrderBy.Cursor = System.Windows.Forms.Cursors.Default;
            this.ComboBoxOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxOrderBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxOrderBy.FormattingEnabled = true;
            this.ComboBoxOrderBy.Items.AddRange(new object[] {
            "Promoção",
            "A-Z",
            "Maior preço",
            "Menor preço"});
            this.ComboBoxOrderBy.Location = new System.Drawing.Point(80, 128);
            this.ComboBoxOrderBy.Name = "ComboBoxOrderBy";
            this.ComboBoxOrderBy.Size = new System.Drawing.Size(157, 21);
            this.ComboBoxOrderBy.TabIndex = 99;
            this.ComboBoxOrderBy.TabStop = false;
            this.ComboBoxOrderBy.SelectedIndexChanged += new System.EventHandler(this.ComboBoxOrderBy_SelectedIndexChanged);
            // 
            // LabelOrderBy
            // 
            this.LabelOrderBy.AutoSize = true;
            this.LabelOrderBy.Location = new System.Drawing.Point(11, 131);
            this.LabelOrderBy.Name = "LabelOrderBy";
            this.LabelOrderBy.Size = new System.Drawing.Size(63, 13);
            this.LabelOrderBy.TabIndex = 13;
            this.LabelOrderBy.Text = "Ordenar por";
            // 
            // PanelSearch
            // 
            this.PanelSearch.BackColor = System.Drawing.Color.White;
            this.PanelSearch.Controls.Add(this.TextBoxSearch);
            this.PanelSearch.Location = new System.Drawing.Point(370, 126);
            this.PanelSearch.Name = "PanelSearch";
            this.PanelSearch.Size = new System.Drawing.Size(192, 23);
            this.PanelSearch.TabIndex = 10;
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Location = new System.Drawing.Point(301, 129);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(65, 13);
            this.LabelSearch.TabIndex = 104;
            this.LabelSearch.Text = "Procurar por";
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxLogo.Image")));
            this.PictureBoxLogo.Location = new System.Drawing.Point(316, 49);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(161, 52);
            this.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxLogo.TabIndex = 106;
            this.PictureBoxLogo.TabStop = false;
            // 
            // GroupBoxFooter
            // 
            this.GroupBoxFooter.Location = new System.Drawing.Point(0, 677);
            this.GroupBoxFooter.Name = "GroupBoxFooter";
            this.GroupBoxFooter.Size = new System.Drawing.Size(816, 32);
            this.GroupBoxFooter.TabIndex = 112;
            this.GroupBoxFooter.TabStop = false;
            // 
            // Menu
            // 
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(814, 25);
            this.Menu.TabIndex = 113;
            // 
            // CartPanel
            // 
            this.CartPanel.Location = new System.Drawing.Point(575, 128);
            this.CartPanel.Margin = new System.Windows.Forms.Padding(0);
            this.CartPanel.Name = "CartPanel";
            this.CartPanel.Size = new System.Drawing.Size(224, 493);
            this.CartPanel.TabIndex = 111;
            // 
            // ProductBox
            // 
            this.ProductBox.AutoScroll = true;
            this.ProductBox.BackColor = System.Drawing.Color.Transparent;
            this.ProductBox.Location = new System.Drawing.Point(12, 167);
            this.ProductBox.Name = "ProductBox";
            this.ProductBox.Size = new System.Drawing.Size(550, 511);
            this.ProductBox.TabIndex = 110;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxSearch.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TextBoxSearch.IsPassword = false;
            this.TextBoxSearch.Location = new System.Drawing.Point(5, 5);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.PlaceHolderText = "Nome de produto ou categoria...";
            this.TextBoxSearch.Size = new System.Drawing.Size(183, 13);
            this.TextBoxSearch.TabIndex = 114;
            this.TextBoxSearch.Text = "Nome de produto ou categoria...";
            this.TextBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxSearch_KeyDown);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(809, 707);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.GroupBoxFooter);
            this.Controls.Add(this.CartPanel);
            this.Controls.Add(this.ProductBox);
            this.Controls.Add(this.PictureBoxLogo);
            this.Controls.Add(this.LabelSearch);
            this.Controls.Add(this.PanelSearch);
            this.Controls.Add(this.LabelOrderBy);
            this.Controls.Add(this.ComboBoxOrderBy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prophet Shop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.PanelSearch.ResumeLayout(false);
            this.PanelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ComboBoxOrderBy;
        private System.Windows.Forms.Label LabelOrderBy;
        private System.Windows.Forms.Panel PanelSearch;
        private System.Windows.Forms.Label LabelSearch;
        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.GroupBox GroupBoxFooter;

        public Components.ProductBox ProductBox;
        public Components.MainMenu Menu;
        public Components.CartPanel CartPanel;
        private Components.TextBoxPlaceHolder TextBoxSearch;
    }
}