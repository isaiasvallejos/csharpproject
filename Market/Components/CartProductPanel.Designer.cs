namespace Shop.Components {
    partial class CartProductPanel {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartProductPanel));
            this.ButtonCartProductRemove = new System.Windows.Forms.Button();
            this.NumericCartProductQuantity = new System.Windows.Forms.NumericUpDown();
            this.LabelCartProductValue = new System.Windows.Forms.Label();
            this.LabelCartProductName = new System.Windows.Forms.Label();
            this.PictureBoxCartProductImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumericCartProductQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCartProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonCartProductRemove
            // 
            this.ButtonCartProductRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCartProductRemove.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ButtonCartProductRemove.FlatAppearance.BorderSize = 0;
            this.ButtonCartProductRemove.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.ButtonCartProductRemove.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.ButtonCartProductRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCartProductRemove.Image = ((System.Drawing.Image)(resources.GetObject("ButtonCartProductRemove.Image")));
            this.ButtonCartProductRemove.Location = new System.Drawing.Point(179, 2);
            this.ButtonCartProductRemove.Name = "ButtonCartProductRemove";
            this.ButtonCartProductRemove.Size = new System.Drawing.Size(15, 15);
            this.ButtonCartProductRemove.TabIndex = 5;
            this.ButtonCartProductRemove.TabStop = false;
            this.ButtonCartProductRemove.UseVisualStyleBackColor = true;
            this.ButtonCartProductRemove.Click += new System.EventHandler(this.ButtonCartProductRemove_Click);
            // 
            // NumericCartProductQuantity
            // 
            this.NumericCartProductQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumericCartProductQuantity.Location = new System.Drawing.Point(159, 34);
            this.NumericCartProductQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericCartProductQuantity.Name = "NumericCartProductQuantity";
            this.NumericCartProductQuantity.Size = new System.Drawing.Size(34, 20);
            this.NumericCartProductQuantity.TabIndex = 8;
            this.NumericCartProductQuantity.TabStop = false;
            this.NumericCartProductQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericCartProductQuantity.ValueChanged += new System.EventHandler(this.NumericCartProductQuantity_ValueChanged);
            // 
            // LabelCartProductValue
            // 
            this.LabelCartProductValue.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCartProductValue.Location = new System.Drawing.Point(60, 37);
            this.LabelCartProductValue.Name = "LabelCartProductValue";
            this.LabelCartProductValue.Size = new System.Drawing.Size(98, 12);
            this.LabelCartProductValue.TabIndex = 7;
            this.LabelCartProductValue.Text = "$123";
            this.LabelCartProductValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelCartProductName
            // 
            this.LabelCartProductName.AutoEllipsis = true;
            this.LabelCartProductName.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCartProductName.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.LabelCartProductName.Location = new System.Drawing.Point(58, 5);
            this.LabelCartProductName.Name = "LabelCartProductName";
            this.LabelCartProductName.Size = new System.Drawing.Size(117, 15);
            this.LabelCartProductName.TabIndex = 6;
            this.LabelCartProductName.Text = "Nome do Produto";
            // 
            // PictureBoxCartProductImage
            // 
            this.PictureBoxCartProductImage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PictureBoxCartProductImage.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxCartProductImage.Image")));
            this.PictureBoxCartProductImage.Location = new System.Drawing.Point(6, 6);
            this.PictureBoxCartProductImage.Name = "PictureBoxCartProductImage";
            this.PictureBoxCartProductImage.Size = new System.Drawing.Size(50, 50);
            this.PictureBoxCartProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxCartProductImage.TabIndex = 4;
            this.PictureBoxCartProductImage.TabStop = false;
            // 
            // CartProductPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.ButtonCartProductRemove);
            this.Controls.Add(this.NumericCartProductQuantity);
            this.Controls.Add(this.LabelCartProductValue);
            this.Controls.Add(this.LabelCartProductName);
            this.Controls.Add(this.PictureBoxCartProductImage);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "CartProductPanel";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(200, 63);
            this.Load += new System.EventHandler(this.CartProductPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericCartProductQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCartProductImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonCartProductRemove;
        private System.Windows.Forms.NumericUpDown NumericCartProductQuantity;
        public System.Windows.Forms.Label LabelCartProductValue;
        private System.Windows.Forms.Label LabelCartProductName;
        private System.Windows.Forms.PictureBox PictureBoxCartProductImage;
    }
}
