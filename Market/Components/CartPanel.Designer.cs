using Shop.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

namespace Shop.Components {

    partial class CartPanel {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartPanel));
            this.ComboBoxPayment = new System.Windows.Forms.ComboBox();
            this.ButtonCartFinish = new System.Windows.Forms.Button();
            this.PanelCartTotal = new System.Windows.Forms.Panel();
            this.LabelCartTotal = new System.Windows.Forms.Label();
            this.LabelCartTotalValue = new System.Windows.Forms.Label();
            this.PanelCartDiscount = new System.Windows.Forms.Panel();
            this.LabelCartDiscount = new System.Windows.Forms.Label();
            this.LabelCartDiscountValue = new System.Windows.Forms.Label();
            this.PanelCartShipping = new System.Windows.Forms.Panel();
            this.LabelCartShipping = new System.Windows.Forms.Label();
            this.LabelCartShippingValue = new System.Windows.Forms.Label();
            this.PanelCartContainer = new System.Windows.Forms.Panel();
            this.PictureBoxCartIcon = new System.Windows.Forms.PictureBox();
            this.CartProductBox = new Shop.Components.CartProductBox();
            this.PanelCartSubtotal = new System.Windows.Forms.Panel();
            this.LabelCartProducts = new System.Windows.Forms.Label();
            this.LabelCartProductsValue = new System.Windows.Forms.Label();
            this.LabelPayment = new System.Windows.Forms.Label();
            this.PanelPayment = new System.Windows.Forms.Panel();
            this.PanelCartTotal.SuspendLayout();
            this.PanelCartDiscount.SuspendLayout();
            this.PanelCartShipping.SuspendLayout();
            this.PanelCartContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCartIcon)).BeginInit();
            this.PanelCartSubtotal.SuspendLayout();
            this.PanelPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboBoxPayment
            // 
            this.ComboBoxPayment.Cursor = System.Windows.Forms.Cursors.Default;
            this.ComboBoxPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxPayment.FormattingEnabled = true;
            this.ComboBoxPayment.Items.AddRange(new object[] {
            "À vista (15% OFF)",
            "1x",
            "2x",
            "3x"});
            this.ComboBoxPayment.Location = new System.Drawing.Point(84, 5);
            this.ComboBoxPayment.Name = "ComboBoxPayment";
            this.ComboBoxPayment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBoxPayment.Size = new System.Drawing.Size(131, 21);
            this.ComboBoxPayment.TabIndex = 111;
            this.ComboBoxPayment.TabStop = false;
            this.ComboBoxPayment.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPayment_SelectedIndexChanged);
            // 
            // ButtonCartFinish
            // 
            this.ButtonCartFinish.BackColor = System.Drawing.Color.White;
            this.ButtonCartFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCartFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCartFinish.Location = new System.Drawing.Point(0, 468);
            this.ButtonCartFinish.Name = "ButtonCartFinish";
            this.ButtonCartFinish.Size = new System.Drawing.Size(221, 23);
            this.ButtonCartFinish.TabIndex = 109;
            this.ButtonCartFinish.Text = "Fechar Pedido";
            this.ButtonCartFinish.UseVisualStyleBackColor = false;
            this.ButtonCartFinish.Click += new System.EventHandler(this.ButtonCartFinish_Click);
            // 
            // PanelCartTotal
            // 
            this.PanelCartTotal.BackColor = System.Drawing.Color.White;
            this.PanelCartTotal.Controls.Add(this.LabelCartTotal);
            this.PanelCartTotal.Controls.Add(this.LabelCartTotalValue);
            this.PanelCartTotal.Location = new System.Drawing.Point(0, 390);
            this.PanelCartTotal.Name = "PanelCartTotal";
            this.PanelCartTotal.Size = new System.Drawing.Size(221, 31);
            this.PanelCartTotal.TabIndex = 113;
            // 
            // LabelCartTotal
            // 
            this.LabelCartTotal.AutoSize = true;
            this.LabelCartTotal.BackColor = System.Drawing.Color.White;
            this.LabelCartTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LabelCartTotal.Location = new System.Drawing.Point(8, 9);
            this.LabelCartTotal.Name = "LabelCartTotal";
            this.LabelCartTotal.Size = new System.Drawing.Size(34, 13);
            this.LabelCartTotal.TabIndex = 102;
            this.LabelCartTotal.Text = "Total:";
            this.LabelCartTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelCartTotalValue
            // 
            this.LabelCartTotalValue.BackColor = System.Drawing.Color.White;
            this.LabelCartTotalValue.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCartTotalValue.Location = new System.Drawing.Point(77, 4);
            this.LabelCartTotalValue.Name = "LabelCartTotalValue";
            this.LabelCartTotalValue.Size = new System.Drawing.Size(143, 20);
            this.LabelCartTotalValue.TabIndex = 103;
            this.LabelCartTotalValue.Text = "$0,00";
            this.LabelCartTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PanelCartDiscount
            // 
            this.PanelCartDiscount.BackColor = System.Drawing.Color.White;
            this.PanelCartDiscount.Controls.Add(this.LabelCartDiscount);
            this.PanelCartDiscount.Controls.Add(this.LabelCartDiscountValue);
            this.PanelCartDiscount.Location = new System.Drawing.Point(0, 365);
            this.PanelCartDiscount.Name = "PanelCartDiscount";
            this.PanelCartDiscount.Size = new System.Drawing.Size(221, 25);
            this.PanelCartDiscount.TabIndex = 111;
            // 
            // LabelCartDiscount
            // 
            this.LabelCartDiscount.AutoSize = true;
            this.LabelCartDiscount.BackColor = System.Drawing.Color.White;
            this.LabelCartDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LabelCartDiscount.Location = new System.Drawing.Point(8, 5);
            this.LabelCartDiscount.Name = "LabelCartDiscount";
            this.LabelCartDiscount.Size = new System.Drawing.Size(56, 13);
            this.LabelCartDiscount.TabIndex = 102;
            this.LabelCartDiscount.Text = "Desconto:";
            this.LabelCartDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelCartDiscountValue
            // 
            this.LabelCartDiscountValue.BackColor = System.Drawing.Color.White;
            this.LabelCartDiscountValue.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.LabelCartDiscountValue.Location = new System.Drawing.Point(75, 2);
            this.LabelCartDiscountValue.Name = "LabelCartDiscountValue";
            this.LabelCartDiscountValue.Size = new System.Drawing.Size(143, 20);
            this.LabelCartDiscountValue.TabIndex = 103;
            this.LabelCartDiscountValue.Text = "$0,00";
            this.LabelCartDiscountValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PanelCartShipping
            // 
            this.PanelCartShipping.BackColor = System.Drawing.Color.White;
            this.PanelCartShipping.Controls.Add(this.LabelCartShipping);
            this.PanelCartShipping.Controls.Add(this.LabelCartShippingValue);
            this.PanelCartShipping.Location = new System.Drawing.Point(0, 340);
            this.PanelCartShipping.Name = "PanelCartShipping";
            this.PanelCartShipping.Size = new System.Drawing.Size(221, 25);
            this.PanelCartShipping.TabIndex = 110;
            // 
            // LabelCartShipping
            // 
            this.LabelCartShipping.AutoSize = true;
            this.LabelCartShipping.BackColor = System.Drawing.Color.White;
            this.LabelCartShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LabelCartShipping.Location = new System.Drawing.Point(8, 6);
            this.LabelCartShipping.Name = "LabelCartShipping";
            this.LabelCartShipping.Size = new System.Drawing.Size(34, 13);
            this.LabelCartShipping.TabIndex = 102;
            this.LabelCartShipping.Text = "Frete:";
            // 
            // LabelCartShippingValue
            // 
            this.LabelCartShippingValue.BackColor = System.Drawing.Color.White;
            this.LabelCartShippingValue.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.LabelCartShippingValue.Location = new System.Drawing.Point(75, 2);
            this.LabelCartShippingValue.Name = "LabelCartShippingValue";
            this.LabelCartShippingValue.Size = new System.Drawing.Size(143, 18);
            this.LabelCartShippingValue.TabIndex = 103;
            this.LabelCartShippingValue.Text = "$0,00";
            this.LabelCartShippingValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PanelCartContainer
            // 
            this.PanelCartContainer.BackColor = System.Drawing.Color.White;
            this.PanelCartContainer.Controls.Add(this.PictureBoxCartIcon);
            this.PanelCartContainer.Location = new System.Drawing.Point(0, 0);
            this.PanelCartContainer.Name = "PanelCartContainer";
            this.PanelCartContainer.Size = new System.Drawing.Size(221, 310);
            this.PanelCartContainer.TabIndex = 112;
            // 
            // PictureBoxCartIcon
            // 
            this.PictureBoxCartIcon.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxCartIcon.Image")));
            this.PictureBoxCartIcon.Location = new System.Drawing.Point(91, 9);
            this.PictureBoxCartIcon.Name = "PictureBoxCartIcon";
            this.PictureBoxCartIcon.Size = new System.Drawing.Size(35, 35);
            this.PictureBoxCartIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxCartIcon.TabIndex = 105;
            this.PictureBoxCartIcon.TabStop = false;
            // 
            // CartProductBox
            // 
            this.CartProductBox.AutoScroll = true;
            this.CartProductBox.BackColor = System.Drawing.Color.White;
            this.CartProductBox.Location = new System.Drawing.Point(2, 50);
            this.CartProductBox.Name = "CartProductBox";
            this.CartProductBox.Size = new System.Drawing.Size(217, 260);
            this.CartProductBox.TabIndex = 111;
            // 
            // PanelCartSubtotal
            // 
            this.PanelCartSubtotal.BackColor = System.Drawing.Color.White;
            this.PanelCartSubtotal.Controls.Add(this.LabelCartProducts);
            this.PanelCartSubtotal.Controls.Add(this.LabelCartProductsValue);
            this.PanelCartSubtotal.Location = new System.Drawing.Point(0, 315);
            this.PanelCartSubtotal.Name = "PanelCartSubtotal";
            this.PanelCartSubtotal.Size = new System.Drawing.Size(221, 25);
            this.PanelCartSubtotal.TabIndex = 108;
            // 
            // LabelCartProducts
            // 
            this.LabelCartProducts.AutoSize = true;
            this.LabelCartProducts.BackColor = System.Drawing.Color.White;
            this.LabelCartProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LabelCartProducts.Location = new System.Drawing.Point(8, 6);
            this.LabelCartProducts.Name = "LabelCartProducts";
            this.LabelCartProducts.Size = new System.Drawing.Size(49, 13);
            this.LabelCartProducts.TabIndex = 102;
            this.LabelCartProducts.Text = "Subtotal:";
            // 
            // LabelCartProductsValue
            // 
            this.LabelCartProductsValue.BackColor = System.Drawing.Color.White;
            this.LabelCartProductsValue.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.LabelCartProductsValue.Location = new System.Drawing.Point(74, 2);
            this.LabelCartProductsValue.Name = "LabelCartProductsValue";
            this.LabelCartProductsValue.Size = new System.Drawing.Size(143, 20);
            this.LabelCartProductsValue.TabIndex = 103;
            this.LabelCartProductsValue.Text = "$0,00";
            this.LabelCartProductsValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelPayment
            // 
            this.LabelPayment.AutoSize = true;
            this.LabelPayment.BackColor = System.Drawing.Color.White;
            this.LabelPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LabelPayment.Location = new System.Drawing.Point(8, 9);
            this.LabelPayment.Name = "LabelPayment";
            this.LabelPayment.Size = new System.Drawing.Size(64, 13);
            this.LabelPayment.TabIndex = 102;
            this.LabelPayment.Text = "Pagamento:";
            this.LabelPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelPayment
            // 
            this.PanelPayment.BackColor = System.Drawing.Color.White;
            this.PanelPayment.Controls.Add(this.ComboBoxPayment);
            this.PanelPayment.Controls.Add(this.LabelPayment);
            this.PanelPayment.Location = new System.Drawing.Point(0, 429);
            this.PanelPayment.Name = "PanelPayment";
            this.PanelPayment.Size = new System.Drawing.Size(221, 31);
            this.PanelPayment.TabIndex = 114;
            // 
            // CartPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CartProductBox);
            this.Controls.Add(this.PanelCartContainer);
            this.Controls.Add(this.PanelPayment);
            this.Controls.Add(this.ButtonCartFinish);
            this.Controls.Add(this.PanelCartTotal);
            this.Controls.Add(this.PanelCartDiscount);
            this.Controls.Add(this.PanelCartShipping);
            this.Controls.Add(this.PanelCartSubtotal);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CartPanel";
            this.Size = new System.Drawing.Size(221, 501);
            this.Load += new System.EventHandler(this.CartPanel_Load);
            this.PanelCartTotal.ResumeLayout(false);
            this.PanelCartTotal.PerformLayout();
            this.PanelCartDiscount.ResumeLayout(false);
            this.PanelCartDiscount.PerformLayout();
            this.PanelCartShipping.ResumeLayout(false);
            this.PanelCartShipping.PerformLayout();
            this.PanelCartContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCartIcon)).EndInit();
            this.PanelCartSubtotal.ResumeLayout(false);
            this.PanelCartSubtotal.PerformLayout();
            this.PanelPayment.ResumeLayout(false);
            this.PanelPayment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxPayment;
        private System.Windows.Forms.Button ButtonCartFinish;
        private System.Windows.Forms.Panel PanelCartTotal;
        private System.Windows.Forms.Label LabelCartTotal;
        private System.Windows.Forms.Label LabelCartTotalValue;
        private System.Windows.Forms.Panel PanelCartDiscount;
        private System.Windows.Forms.Label LabelCartDiscount;
        private System.Windows.Forms.Label LabelCartDiscountValue;
        private System.Windows.Forms.Panel PanelCartShipping;
        private System.Windows.Forms.Label LabelCartShipping;
        private System.Windows.Forms.Label LabelCartShippingValue;
        private System.Windows.Forms.Panel PanelCartContainer;  
        private System.Windows.Forms.PictureBox PictureBoxCartIcon;
        private System.Windows.Forms.Panel PanelCartSubtotal;
        private System.Windows.Forms.Label LabelCartProducts;
        private System.Windows.Forms.Label LabelCartProductsValue;
        private System.Windows.Forms.Label LabelPayment;
        private System.Windows.Forms.Panel PanelPayment;

        public Shop.Components.CartProductBox CartProductBox;
    }
}
