namespace Shop.Components {
    partial class OrderPanel {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.LabelID = new System.Windows.Forms.Label();
            this.PanelStatus = new System.Windows.Forms.Panel();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.LabelByNameInDate = new System.Windows.Forms.Label();
            this.LabelTotalValue = new System.Windows.Forms.Label();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.OrderPanelProductImageBox = new Shop.Components.OrderPanelProductImageBox();
            this.PanelStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.BackColor = System.Drawing.SystemColors.Control;
            this.LabelID.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.LabelID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LabelID.Location = new System.Drawing.Point(7, 8);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(22, 19);
            this.LabelID.TabIndex = 1;
            this.LabelID.Text = "#?";
            // 
            // PanelStatus
            // 
            this.PanelStatus.Controls.Add(this.LabelStatus);
            this.PanelStatus.Location = new System.Drawing.Point(313, 8);
            this.PanelStatus.Name = "PanelStatus";
            this.PanelStatus.Size = new System.Drawing.Size(119, 18);
            this.PanelStatus.TabIndex = 2;
            this.PanelStatus.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelStatus_Paint);
            // 
            // LabelStatus
            // 
            this.LabelStatus.BackColor = System.Drawing.Color.White;
            this.LabelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.LabelStatus.ForeColor = System.Drawing.Color.Black;
            this.LabelStatus.Location = new System.Drawing.Point(3, 2);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(113, 13);
            this.LabelStatus.TabIndex = 0;
            this.LabelStatus.Text = "Status";
            this.LabelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelByNameInDate
            // 
            this.LabelByNameInDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.LabelByNameInDate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelByNameInDate.Location = new System.Drawing.Point(32, 11);
            this.LabelByNameInDate.Name = "LabelByNameInDate";
            this.LabelByNameInDate.Size = new System.Drawing.Size(96, 13);
            this.LabelByNameInDate.TabIndex = 4;
            this.LabelByNameInDate.Text = "17 abr. 2017";
            this.LabelByNameInDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelTotalValue
            // 
            this.LabelTotalValue.Location = new System.Drawing.Point(312, 46);
            this.LabelTotalValue.Name = "LabelTotalValue";
            this.LabelTotalValue.Size = new System.Drawing.Size(119, 18);
            this.LabelTotalValue.TabIndex = 8;
            this.LabelTotalValue.Text = "$123";
            this.LabelTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold);
            this.LabelTotal.Location = new System.Drawing.Point(357, 39);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(34, 7);
            this.LabelTotal.TabIndex = 9;
            this.LabelTotal.Text = "TOTAL:";
            // 
            // OrderPanelProductImageBox
            // 
            this.OrderPanelProductImageBox.BackColor = System.Drawing.Color.White;
            this.OrderPanelProductImageBox.Location = new System.Drawing.Point(8, 33);
            this.OrderPanelProductImageBox.Name = "OrderPanelProductImageBox";
            this.OrderPanelProductImageBox.Size = new System.Drawing.Size(300, 35);
            this.OrderPanelProductImageBox.TabIndex = 10;
            // 
            // OrderPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.OrderPanelProductImageBox);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.LabelTotalValue);
            this.Controls.Add(this.LabelByNameInDate);
            this.Controls.Add(this.PanelStatus);
            this.Controls.Add(this.LabelID);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "OrderPanel";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(443, 76);
            this.PanelStatus.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.Panel PanelStatus;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.Label LabelByNameInDate;
        private System.Windows.Forms.Label LabelTotalValue;
        private System.Windows.Forms.Label LabelTotal;
        private OrderPanelProductImageBox OrderPanelProductImageBox;
    }
}
