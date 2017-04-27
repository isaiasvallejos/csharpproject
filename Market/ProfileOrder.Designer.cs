namespace Shop {
    partial class FormProfileOrder {
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
            this.LabelNameHeader = new System.Windows.Forms.Label();
            this.LabelFilterStatus = new System.Windows.Forms.Label();
            this.ComboBoxFilterStatus = new Shop.Components.ComboBoxPlaceHolder();
            this.OrderBox = new Shop.Components.OrderBox();
            this.SuspendLayout();
            // 
            // LabelNameHeader
            // 
            this.LabelNameHeader.AutoSize = true;
            this.LabelNameHeader.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNameHeader.Location = new System.Drawing.Point(4, 9);
            this.LabelNameHeader.Name = "LabelNameHeader";
            this.LabelNameHeader.Size = new System.Drawing.Size(98, 32);
            this.LabelNameHeader.TabIndex = 3;
            this.LabelNameHeader.Text = "Pedidos";
            // 
            // LabelFilterStatus
            // 
            this.LabelFilterStatus.AutoSize = true;
            this.LabelFilterStatus.Location = new System.Drawing.Point(8, 78);
            this.LabelFilterStatus.Name = "LabelFilterStatus";
            this.LabelFilterStatus.Size = new System.Drawing.Size(50, 13);
            this.LabelFilterStatus.TabIndex = 100;
            this.LabelFilterStatus.Text = "Filtrar por";
            // 
            // ComboBoxFilterStatus
            // 
            this.ComboBoxFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFilterStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxFilterStatus.FormattingEnabled = true;
            this.ComboBoxFilterStatus.Items.AddRange(new object[] {
            "Todos",
            "Pendente",
            "Aprovado",
            "Entregue",
            "Cancelado"});
            this.ComboBoxFilterStatus.Location = new System.Drawing.Point(62, 75);
            this.ComboBoxFilterStatus.Name = "ComboBoxFilterStatus";
            this.ComboBoxFilterStatus.PlaceHolderText = "Status";
            this.ComboBoxFilterStatus.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxFilterStatus.TabIndex = 101;
            this.ComboBoxFilterStatus.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFilterStatus_SelectedIndexChanged);
            // 
            // OrderBox
            // 
            this.OrderBox.AutoScroll = true;
            this.OrderBox.BackColor = System.Drawing.SystemColors.Control;
            this.OrderBox.Location = new System.Drawing.Point(12, 108);
            this.OrderBox.Name = "OrderBox";
            this.OrderBox.Size = new System.Drawing.Size(460, 233);
            this.OrderBox.TabIndex = 0;
            // 
            // FormProfileOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 354);
            this.Controls.Add(this.ComboBoxFilterStatus);
            this.Controls.Add(this.LabelFilterStatus);
            this.Controls.Add(this.LabelNameHeader);
            this.Controls.Add(this.OrderBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProfileOrder";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente – Pedidos";
            this.Load += new System.EventHandler(this.FormProfileOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.OrderBox OrderBox;
        private System.Windows.Forms.Label LabelNameHeader;
        private System.Windows.Forms.Label LabelFilterStatus;
        private Components.ComboBoxPlaceHolder ComboBoxFilterStatus;
    }
}