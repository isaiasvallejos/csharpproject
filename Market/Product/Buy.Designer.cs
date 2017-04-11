namespace Market {
    partial class FormProductBuy {
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
            this.PictureBoxImage = new System.Windows.Forms.PictureBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.ButtonBuy = new System.Windows.Forms.Button();
            this.LabelValue = new System.Windows.Forms.Label();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.NumericQuantity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxImage
            // 
            this.PictureBoxImage.BackColor = System.Drawing.SystemColors.Control;
            this.PictureBoxImage.Location = new System.Drawing.Point(12, 12);
            this.PictureBoxImage.Name = "PictureBoxImage";
            this.PictureBoxImage.Size = new System.Drawing.Size(140, 140);
            this.PictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxImage.TabIndex = 0;
            this.PictureBoxImage.TabStop = false;
            // 
            // LabelName
            // 
            this.LabelName.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.Location = new System.Drawing.Point(159, 12);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(281, 23);
            this.LabelName.TabIndex = 1;
            // 
            // ButtonBuy
            // 
            this.ButtonBuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBuy.Location = new System.Drawing.Point(365, 129);
            this.ButtonBuy.Name = "ButtonBuy";
            this.ButtonBuy.Size = new System.Drawing.Size(75, 23);
            this.ButtonBuy.TabIndex = 3;
            this.ButtonBuy.Text = "Comprar";
            this.ButtonBuy.UseVisualStyleBackColor = true;
            // 
            // LabelValue
            // 
            this.LabelValue.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelValue.Location = new System.Drawing.Point(229, 129);
            this.LabelValue.Name = "LabelValue";
            this.LabelValue.Size = new System.Drawing.Size(87, 23);
            this.LabelValue.TabIndex = 4;
            this.LabelValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.BackColor = System.Drawing.Color.White;
            this.TextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxDescription.Location = new System.Drawing.Point(163, 38);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.ReadOnly = true;
            this.TextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TextBoxDescription.Size = new System.Drawing.Size(276, 85);
            this.TextBoxDescription.TabIndex = 5;
            // 
            // NumericQuantity
            // 
            this.NumericQuantity.Location = new System.Drawing.Point(322, 131);
            this.NumericQuantity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericQuantity.Name = "NumericQuantity";
            this.NumericQuantity.Size = new System.Drawing.Size(38, 20);
            this.NumericQuantity.TabIndex = 6;
            this.NumericQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericQuantity.ValueChanged += new System.EventHandler(this.NumericQuantity_ValueChanged);
            // 
            // FormProductBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(451, 162);
            this.Controls.Add(this.NumericQuantity);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.LabelValue);
            this.Controls.Add(this.ButtonBuy);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.PictureBoxImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProductBuy";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto – Visualização";
            this.Load += new System.EventHandler(this.FormProductBuy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxImage;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Button ButtonBuy;
        private System.Windows.Forms.Label LabelValue;
        private System.Windows.Forms.TextBox TextBoxDescription;
        private System.Windows.Forms.NumericUpDown NumericQuantity;
    }
}