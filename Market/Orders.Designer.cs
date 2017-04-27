namespace Shop {
    partial class FormOrders {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrders));
            this.LabelOrdersHeader = new System.Windows.Forms.Label();
            this.PanelDataGridOrders = new System.Windows.Forms.Panel();
            this.DataGridOrders = new System.Windows.Forms.DataGridView();
            this.LabelFilterOrderStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxFilterOrderStatus = new Shop.Components.ComboBoxPlaceHolder();
            this.PanelDataGridOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelOrdersHeader
            // 
            this.LabelOrdersHeader.AutoSize = true;
            this.LabelOrdersHeader.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOrdersHeader.Location = new System.Drawing.Point(8, 11);
            this.LabelOrdersHeader.Name = "LabelOrdersHeader";
            this.LabelOrdersHeader.Size = new System.Drawing.Size(98, 32);
            this.LabelOrdersHeader.TabIndex = 2;
            this.LabelOrdersHeader.Text = "Pedidos";
            // 
            // PanelDataGridOrders
            // 
            this.PanelDataGridOrders.BackColor = System.Drawing.Color.White;
            this.PanelDataGridOrders.Controls.Add(this.DataGridOrders);
            this.PanelDataGridOrders.Location = new System.Drawing.Point(15, 94);
            this.PanelDataGridOrders.Name = "PanelDataGridOrders";
            this.PanelDataGridOrders.Size = new System.Drawing.Size(364, 272);
            this.PanelDataGridOrders.TabIndex = 141;
            // 
            // DataGridOrders
            // 
            this.DataGridOrders.AllowUserToAddRows = false;
            this.DataGridOrders.AllowUserToDeleteRows = false;
            this.DataGridOrders.AllowUserToResizeColumns = false;
            this.DataGridOrders.AllowUserToResizeRows = false;
            this.DataGridOrders.BackgroundColor = System.Drawing.Color.White;
            this.DataGridOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridOrders.ColumnHeadersHeight = 30;
            this.DataGridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataGridOrders.GridColor = System.Drawing.Color.White;
            this.DataGridOrders.Location = new System.Drawing.Point(11, 9);
            this.DataGridOrders.MultiSelect = false;
            this.DataGridOrders.Name = "DataGridOrders";
            this.DataGridOrders.ReadOnly = true;
            this.DataGridOrders.RowHeadersVisible = false;
            this.DataGridOrders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.DataGridOrders.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridOrders.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DataGridOrders.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DataGridOrders.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridOrders.Size = new System.Drawing.Size(343, 253);
            this.DataGridOrders.TabIndex = 133;
            // 
            // LabelFilterOrderStatus
            // 
            this.LabelFilterOrderStatus.AutoSize = true;
            this.LabelFilterOrderStatus.Location = new System.Drawing.Point(12, 65);
            this.LabelFilterOrderStatus.Name = "LabelFilterOrderStatus";
            this.LabelFilterOrderStatus.Size = new System.Drawing.Size(50, 13);
            this.LabelFilterOrderStatus.TabIndex = 140;
            this.LabelFilterOrderStatus.Text = "Filtrar por";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(210, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 39);
            this.label1.TabIndex = 143;
            this.label1.Text = "Utilize o clique direito do mouse em cada pedido para realizar ações.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ComboBoxFilterOrderStatus
            // 
            this.ComboBoxFilterOrderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFilterOrderStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxFilterOrderStatus.FormattingEnabled = true;
            this.ComboBoxFilterOrderStatus.Items.AddRange(new object[] {
            "Todos",
            "Pendente",
            "Aprovado",
            "Entregue",
            "Cancelado"});
            this.ComboBoxFilterOrderStatus.Location = new System.Drawing.Point(66, 62);
            this.ComboBoxFilterOrderStatus.Name = "ComboBoxFilterOrderStatus";
            this.ComboBoxFilterOrderStatus.PlaceHolderText = "Status";
            this.ComboBoxFilterOrderStatus.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxFilterOrderStatus.TabIndex = 142;
            this.ComboBoxFilterOrderStatus.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFilterOrderStatus_SelectedIndexChanged);
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 383);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxFilterOrderStatus);
            this.Controls.Add(this.PanelDataGridOrders);
            this.Controls.Add(this.LabelFilterOrderStatus);
            this.Controls.Add(this.LabelOrdersHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOrders";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos – Listagem";
            this.Load += new System.EventHandler(this.FormOrders_Load);
            this.PanelDataGridOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelOrdersHeader;
        private Components.ComboBoxPlaceHolder ComboBoxFilterOrderStatus;
        private System.Windows.Forms.Panel PanelDataGridOrders;
        private System.Windows.Forms.DataGridView DataGridOrders;
        private System.Windows.Forms.Label LabelFilterOrderStatus;
        private System.Windows.Forms.Label label1;
    }
}