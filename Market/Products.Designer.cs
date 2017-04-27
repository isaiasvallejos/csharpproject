namespace Shop {
    partial class FormProducts {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducts));
            this.LabelProductsHeader = new System.Windows.Forms.Label();
            this.PanelDataGridProducts = new System.Windows.Forms.Panel();
            this.DataGridProducts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.PanelSearch = new System.Windows.Forms.Panel();
            this.TextBoxSearch = new Shop.Components.TextBoxPlaceHolder();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.PanelDataGridProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProducts)).BeginInit();
            this.PanelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelProductsHeader
            // 
            this.LabelProductsHeader.AutoSize = true;
            this.LabelProductsHeader.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProductsHeader.Location = new System.Drawing.Point(8, 11);
            this.LabelProductsHeader.Name = "LabelProductsHeader";
            this.LabelProductsHeader.Size = new System.Drawing.Size(111, 32);
            this.LabelProductsHeader.TabIndex = 2;
            this.LabelProductsHeader.Text = "Produtos";
            // 
            // PanelDataGridProducts
            // 
            this.PanelDataGridProducts.BackColor = System.Drawing.Color.White;
            this.PanelDataGridProducts.Controls.Add(this.DataGridProducts);
            this.PanelDataGridProducts.Location = new System.Drawing.Point(15, 94);
            this.PanelDataGridProducts.Name = "PanelDataGridProducts";
            this.PanelDataGridProducts.Size = new System.Drawing.Size(364, 272);
            this.PanelDataGridProducts.TabIndex = 141;
            // 
            // DataGridProducts
            // 
            this.DataGridProducts.AllowUserToAddRows = false;
            this.DataGridProducts.AllowUserToDeleteRows = false;
            this.DataGridProducts.AllowUserToResizeColumns = false;
            this.DataGridProducts.AllowUserToResizeRows = false;
            this.DataGridProducts.BackgroundColor = System.Drawing.Color.White;
            this.DataGridProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridProducts.ColumnHeadersHeight = 30;
            this.DataGridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataGridProducts.GridColor = System.Drawing.Color.White;
            this.DataGridProducts.Location = new System.Drawing.Point(11, 9);
            this.DataGridProducts.MultiSelect = false;
            this.DataGridProducts.Name = "DataGridProducts";
            this.DataGridProducts.ReadOnly = true;
            this.DataGridProducts.RowHeadersVisible = false;
            this.DataGridProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.DataGridProducts.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridProducts.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DataGridProducts.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DataGridProducts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridProducts.Size = new System.Drawing.Size(343, 253);
            this.DataGridProducts.TabIndex = 133;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(208, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 39);
            this.label1.TabIndex = 143;
            this.label1.Text = "Utilize o clique direito do mouse em cada produto para realizar ações.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Location = new System.Drawing.Point(12, 65);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(50, 13);
            this.LabelSearch.TabIndex = 145;
            this.LabelSearch.Text = "Filtrar por";
            // 
            // PanelSearch
            // 
            this.PanelSearch.BackColor = System.Drawing.Color.White;
            this.PanelSearch.Controls.Add(this.TextBoxSearch);
            this.PanelSearch.Location = new System.Drawing.Point(66, 61);
            this.PanelSearch.Name = "PanelSearch";
            this.PanelSearch.Size = new System.Drawing.Size(129, 23);
            this.PanelSearch.TabIndex = 144;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxSearch.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TextBoxSearch.IsPassword = false;
            this.TextBoxSearch.Location = new System.Drawing.Point(5, 5);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.PlaceHolderText = "Nome ou categoria...";
            this.TextBoxSearch.Size = new System.Drawing.Size(121, 13);
            this.TextBoxSearch.TabIndex = 114;
            this.TextBoxSearch.Text = "Nome ou categoria...";
            this.TextBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxSearch_KeyDown);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.Location = new System.Drawing.Point(304, 61);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 146;
            this.ButtonAdd.Text = "Adicionar";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 383);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.LabelSearch);
            this.Controls.Add(this.PanelSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelDataGridProducts);
            this.Controls.Add(this.LabelProductsHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProducts";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos – Listagem";
            this.Load += new System.EventHandler(this.FormOrders_Load);
            this.PanelDataGridProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProducts)).EndInit();
            this.PanelSearch.ResumeLayout(false);
            this.PanelSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelProductsHeader;
        private System.Windows.Forms.Panel PanelDataGridProducts;
        private System.Windows.Forms.DataGridView DataGridProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelSearch;
        private System.Windows.Forms.Panel PanelSearch;
        private Components.TextBoxPlaceHolder TextBoxSearch;
        private System.Windows.Forms.Button ButtonAdd;
    }
}