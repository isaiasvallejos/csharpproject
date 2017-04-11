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
            this.PanelProducts = new System.Windows.Forms.Panel();
            this.GroupBoxSearch = new System.Windows.Forms.GroupBox();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.PanelSearch = new System.Windows.Forms.Panel();
            this.ComboBoxOrderBy = new System.Windows.Forms.ComboBox();
            this.LabelOrderBy = new System.Windows.Forms.Label();
            this.GroupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelProducts
            // 
            this.PanelProducts.AutoScroll = true;
            this.PanelProducts.Location = new System.Drawing.Point(12, 98);
            this.PanelProducts.Name = "PanelProducts";
            this.PanelProducts.Size = new System.Drawing.Size(557, 514);
            this.PanelProducts.TabIndex = 7;
            // 
            // GroupBoxSearch
            // 
            this.GroupBoxSearch.Controls.Add(this.TextBoxSearch);
            this.GroupBoxSearch.Controls.Add(this.PanelSearch);
            this.GroupBoxSearch.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxSearch.Name = "GroupBoxSearch";
            this.GroupBoxSearch.Size = new System.Drawing.Size(537, 68);
            this.GroupBoxSearch.TabIndex = 11;
            this.GroupBoxSearch.TabStop = false;
            this.GroupBoxSearch.Text = "Procurar por nome ou categoria de produto";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxSearch.Location = new System.Drawing.Point(25, 32);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(482, 13);
            this.TextBoxSearch.TabIndex = 1;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // PanelSearch
            // 
            this.PanelSearch.BackColor = System.Drawing.Color.White;
            this.PanelSearch.Location = new System.Drawing.Point(18, 25);
            this.PanelSearch.Name = "PanelSearch";
            this.PanelSearch.Size = new System.Drawing.Size(502, 28);
            this.PanelSearch.TabIndex = 10;
            // 
            // ComboBoxOrderBy
            // 
            this.ComboBoxOrderBy.Cursor = System.Windows.Forms.Cursors.Default;
            this.ComboBoxOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxOrderBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxOrderBy.FormattingEnabled = true;
            this.ComboBoxOrderBy.Items.AddRange(new object[] {
            "Ordem alfabética",
            "Maior preço",
            "Menor preço"});
            this.ComboBoxOrderBy.Location = new System.Drawing.Point(375, 71);
            this.ComboBoxOrderBy.Name = "ComboBoxOrderBy";
            this.ComboBoxOrderBy.Size = new System.Drawing.Size(157, 21);
            this.ComboBoxOrderBy.TabIndex = 99;
            this.ComboBoxOrderBy.TabStop = false;
            this.ComboBoxOrderBy.SelectedIndexChanged += new System.EventHandler(this.ComboBoxOrderBy_SelectedIndexChanged);
            // 
            // LabelOrderBy
            // 
            this.LabelOrderBy.AutoSize = true;
            this.LabelOrderBy.Location = new System.Drawing.Point(305, 71);
            this.LabelOrderBy.Name = "LabelOrderBy";
            this.LabelOrderBy.Size = new System.Drawing.Size(63, 13);
            this.LabelOrderBy.TabIndex = 13;
            this.LabelOrderBy.Text = "Ordenar por";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(796, 624);
            this.Controls.Add(this.LabelOrderBy);
            this.Controls.Add(this.ComboBoxOrderBy);
            this.Controls.Add(this.GroupBoxSearch);
            this.Controls.Add(this.PanelProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Market";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.GroupBoxSearch.ResumeLayout(false);
            this.GroupBoxSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PanelProducts;
        private System.Windows.Forms.GroupBox GroupBoxSearch;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Panel PanelSearch;
        private System.Windows.Forms.ComboBox ComboBoxOrderBy;
        private System.Windows.Forms.Label LabelOrderBy;
    }
}