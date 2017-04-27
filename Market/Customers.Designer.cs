namespace Shop {
    partial class FormCustomers {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomers));
            this.LabelProductsHeader = new System.Windows.Forms.Label();
            this.PanelDataGridCustomers = new System.Windows.Forms.Panel();
            this.DataGridCustomers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.PanelSearch = new System.Windows.Forms.Panel();
            this.TextBoxSearch = new Shop.Components.TextBoxPlaceHolder();
            this.PanelDataGridCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCustomers)).BeginInit();
            this.PanelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelProductsHeader
            // 
            this.LabelProductsHeader.AutoSize = true;
            this.LabelProductsHeader.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProductsHeader.Location = new System.Drawing.Point(8, 11);
            this.LabelProductsHeader.Name = "LabelProductsHeader";
            this.LabelProductsHeader.Size = new System.Drawing.Size(100, 32);
            this.LabelProductsHeader.TabIndex = 2;
            this.LabelProductsHeader.Text = "Clientes";
            // 
            // PanelDataGridCustomers
            // 
            this.PanelDataGridCustomers.BackColor = System.Drawing.Color.White;
            this.PanelDataGridCustomers.Controls.Add(this.DataGridCustomers);
            this.PanelDataGridCustomers.Location = new System.Drawing.Point(15, 94);
            this.PanelDataGridCustomers.Name = "PanelDataGridCustomers";
            this.PanelDataGridCustomers.Size = new System.Drawing.Size(364, 272);
            this.PanelDataGridCustomers.TabIndex = 141;
            // 
            // DataGridCustomers
            // 
            this.DataGridCustomers.AllowUserToAddRows = false;
            this.DataGridCustomers.AllowUserToDeleteRows = false;
            this.DataGridCustomers.AllowUserToResizeColumns = false;
            this.DataGridCustomers.AllowUserToResizeRows = false;
            this.DataGridCustomers.BackgroundColor = System.Drawing.Color.White;
            this.DataGridCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridCustomers.ColumnHeadersHeight = 30;
            this.DataGridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataGridCustomers.GridColor = System.Drawing.Color.White;
            this.DataGridCustomers.Location = new System.Drawing.Point(11, 9);
            this.DataGridCustomers.MultiSelect = false;
            this.DataGridCustomers.Name = "DataGridCustomers";
            this.DataGridCustomers.ReadOnly = true;
            this.DataGridCustomers.RowHeadersVisible = false;
            this.DataGridCustomers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.DataGridCustomers.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridCustomers.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DataGridCustomers.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DataGridCustomers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridCustomers.Size = new System.Drawing.Size(343, 253);
            this.DataGridCustomers.TabIndex = 133;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(208, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 39);
            this.label1.TabIndex = 143;
            this.label1.Text = "Utilize o clique direito do mouse em cada cliente para realizar ações.";
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
            this.TextBoxSearch.PlaceHolderText = "Nome ou CPF...";
            this.TextBoxSearch.Size = new System.Drawing.Size(121, 13);
            this.TextBoxSearch.TabIndex = 114;
            this.TextBoxSearch.Text = "Nome ou CPF...";
            this.TextBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxSearch_KeyDown);
            // 
            // FormCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 383);
            this.Controls.Add(this.LabelSearch);
            this.Controls.Add(this.PanelSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelDataGridCustomers);
            this.Controls.Add(this.LabelProductsHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCustomers";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes – Listagem";
            this.Load += new System.EventHandler(this.FormOrders_Load);
            this.PanelDataGridCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCustomers)).EndInit();
            this.PanelSearch.ResumeLayout(false);
            this.PanelSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelProductsHeader;
        private System.Windows.Forms.Panel PanelDataGridCustomers;
        private System.Windows.Forms.DataGridView DataGridCustomers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelSearch;
        private System.Windows.Forms.Panel PanelSearch;
        private Components.TextBoxPlaceHolder TextBoxSearch;
    }
}