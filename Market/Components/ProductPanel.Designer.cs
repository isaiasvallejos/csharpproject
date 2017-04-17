namespace Shop.Components {
    partial class ProductPanel {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductPanel));
            this.PictureBoxProductImage = new System.Windows.Forms.PictureBox();
            this.LabelProductValue = new System.Windows.Forms.Label();
            this.ButtonProductBuy = new System.Windows.Forms.Button();
            this.LabelProductName = new System.Windows.Forms.Label();
            this.LabelProductPromotionValue = new System.Windows.Forms.Label();
            this.LabelProductPromotion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxProductImage
            // 
            this.PictureBoxProductImage.BackColor = System.Drawing.SystemColors.Control;
            this.PictureBoxProductImage.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxProductImage.Image")));
            this.PictureBoxProductImage.Location = new System.Drawing.Point(9, 9);
            this.PictureBoxProductImage.Name = "PictureBoxProductImage";
            this.PictureBoxProductImage.Size = new System.Drawing.Size(153, 154);
            this.PictureBoxProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxProductImage.TabIndex = 7;
            this.PictureBoxProductImage.TabStop = false;
            // 
            // LabelProductValue
            // 
            this.LabelProductValue.BackColor = System.Drawing.Color.Transparent;
            this.LabelProductValue.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProductValue.Location = new System.Drawing.Point(9, 183);
            this.LabelProductValue.Name = "LabelProductValue";
            this.LabelProductValue.Size = new System.Drawing.Size(154, 32);
            this.LabelProductValue.TabIndex = 6;
            this.LabelProductValue.Text = "$123";
            this.LabelProductValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonProductBuy
            // 
            this.ButtonProductBuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonProductBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonProductBuy.Location = new System.Drawing.Point(49, 218);
            this.ButtonProductBuy.Name = "ButtonProductBuy";
            this.ButtonProductBuy.Size = new System.Drawing.Size(75, 23);
            this.ButtonProductBuy.TabIndex = 8;
            this.ButtonProductBuy.TabStop = false;
            this.ButtonProductBuy.Text = "Comprar";
            this.ButtonProductBuy.UseVisualStyleBackColor = true;
            this.ButtonProductBuy.Click += new System.EventHandler(this.ButtonProductBuy_Click);
            // 
            // LabelProductName
            // 
            this.LabelProductName.AutoEllipsis = true;
            this.LabelProductName.BackColor = System.Drawing.Color.Transparent;
            this.LabelProductName.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProductName.Location = new System.Drawing.Point(8, 166);
            this.LabelProductName.Name = "LabelProductName";
            this.LabelProductName.Size = new System.Drawing.Size(154, 19);
            this.LabelProductName.TabIndex = 5;
            this.LabelProductName.Text = "Nome do Produto";
            this.LabelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelProductPromotionValue
            // 
            this.LabelProductPromotionValue.AutoSize = true;
            this.LabelProductPromotionValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.LabelProductPromotionValue.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LabelProductPromotionValue.Location = new System.Drawing.Point(13, 147);
            this.LabelProductPromotionValue.Name = "LabelProductPromotionValue";
            this.LabelProductPromotionValue.Padding = new System.Windows.Forms.Padding(2);
            this.LabelProductPromotionValue.Size = new System.Drawing.Size(41, 16);
            this.LabelProductPromotionValue.TabIndex = 11;
            this.LabelProductPromotionValue.Text = "de $100";
            this.LabelProductPromotionValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelProductPromotion
            // 
            this.LabelProductPromotion.BackColor = System.Drawing.Color.Silver;
            this.LabelProductPromotion.ForeColor = System.Drawing.Color.White;
            this.LabelProductPromotion.Location = new System.Drawing.Point(54, 147);
            this.LabelProductPromotion.Name = "LabelProductPromotion";
            this.LabelProductPromotion.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.LabelProductPromotion.Size = new System.Drawing.Size(27, 16);
            this.LabelProductPromotion.TabIndex = 9;
            this.LabelProductPromotion.Text = "50%";
            // 
            // ProductPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LabelProductName);
            this.Controls.Add(this.LabelProductPromotionValue);
            this.Controls.Add(this.LabelProductPromotion);
            this.Controls.Add(this.ButtonProductBuy);
            this.Controls.Add(this.PictureBoxProductImage);
            this.Controls.Add(this.LabelProductValue);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ProductPanel";
            this.Size = new System.Drawing.Size(171, 251);
            this.Load += new System.EventHandler(this.ProductPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PictureBoxProductImage;
        private System.Windows.Forms.Label LabelProductValue;
        private System.Windows.Forms.Button ButtonProductBuy;
        private System.Windows.Forms.Label LabelProductName;
        private System.Windows.Forms.Label LabelProductPromotionValue;
        private System.Windows.Forms.Label LabelProductPromotion;
    }
}
