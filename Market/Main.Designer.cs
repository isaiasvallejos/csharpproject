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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBoxSearch = new System.Windows.Forms.GroupBox();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.PanelSearch = new System.Windows.Forms.Panel();
            this.ComboBoxOrderBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.GroupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelProducts
            // 
            this.PanelProducts.AutoScroll = true;
            this.PanelProducts.Location = new System.Drawing.Point(223, 118);
            this.PanelProducts.Name = "PanelProducts";
            this.PanelProducts.Size = new System.Drawing.Size(355, 295);
            this.PanelProducts.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 425);
            this.panel1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 313);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carrinho";
            // 
            // GroupBoxSearch
            // 
            this.GroupBoxSearch.Controls.Add(this.TextBoxSearch);
            this.GroupBoxSearch.Controls.Add(this.PanelSearch);
            this.GroupBoxSearch.Location = new System.Drawing.Point(222, 12);
            this.GroupBoxSearch.Name = "GroupBoxSearch";
            this.GroupBoxSearch.Size = new System.Drawing.Size(337, 68);
            this.GroupBoxSearch.TabIndex = 11;
            this.GroupBoxSearch.TabStop = false;
            this.GroupBoxSearch.Text = "Procurar por nome ou categoria de produto";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxSearch.Location = new System.Drawing.Point(25, 32);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(294, 13);
            this.TextBoxSearch.TabIndex = 9;
            this.TextBoxSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxSearch_KeyUp);
            // 
            // PanelSearch
            // 
            this.PanelSearch.BackColor = System.Drawing.Color.White;
            this.PanelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelSearch.Location = new System.Drawing.Point(18, 25);
            this.PanelSearch.Name = "PanelSearch";
            this.PanelSearch.Size = new System.Drawing.Size(306, 28);
            this.PanelSearch.TabIndex = 10;
            // 
            // ComboBoxOrderBy
            // 
            this.ComboBoxOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxOrderBy.FormattingEnabled = true;
            this.ComboBoxOrderBy.Items.AddRange(new object[] {
            "Ordem alfabética",
            "Maior preço",
            "Menor preço"});
            this.ComboBoxOrderBy.Location = new System.Drawing.Point(441, 87);
            this.ComboBoxOrderBy.Name = "ComboBoxOrderBy";
            this.ComboBoxOrderBy.Size = new System.Drawing.Size(118, 21);
            this.ComboBoxOrderBy.TabIndex = 12;
            this.ComboBoxOrderBy.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ordenar por";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxOrderBy);
            this.Controls.Add(this.GroupBoxSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Market";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.GroupBoxSearch.ResumeLayout(false);
            this.GroupBoxSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PanelProducts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox GroupBoxSearch;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Panel PanelSearch;
        private System.Windows.Forms.ComboBox ComboBoxOrderBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}