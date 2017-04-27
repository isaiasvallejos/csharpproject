namespace Shop {
    partial class FormOrderDetail {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrderDetail));
            this.PanelDetails = new System.Windows.Forms.Panel();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.LabelTotalValue = new System.Windows.Forms.Label();
            this.LabelDiscount = new System.Windows.Forms.Label();
            this.LabelDiscountValue = new System.Windows.Forms.Label();
            this.LabelShipping = new System.Windows.Forms.Label();
            this.LabelShippingValue = new System.Windows.Forms.Label();
            this.LabelProducts = new System.Windows.Forms.Label();
            this.LabelProductsValue = new System.Windows.Forms.Label();
            this.LabelSubtotalTitle = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.LabelIdHeader = new System.Windows.Forms.Label();
            this.LabelCreatedAt = new System.Windows.Forms.Label();
            this.LabelCreatedAtTitle = new System.Windows.Forms.Label();
            this.LabelPayment = new System.Windows.Forms.Label();
            this.LabelPaymentTitle = new System.Windows.Forms.Label();
            this.LabelCustomer = new System.Windows.Forms.Label();
            this.LabelCustomerTitle = new System.Windows.Forms.Label();
            this.PanelStatus = new System.Windows.Forms.Panel();
            this.ComboBoxStatus = new System.Windows.Forms.ComboBox();
            this.PanelCartProductBox = new System.Windows.Forms.Panel();
            this.CartProductBox = new Shop.Components.CartProductBox();
            this.LabelItemsHeader = new System.Windows.Forms.Label();
            this.LabelDetailHeader = new System.Windows.Forms.Label();
            this.PanelDetails.SuspendLayout();
            this.PanelStatus.SuspendLayout();
            this.PanelCartProductBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelDetails
            // 
            this.PanelDetails.BackColor = System.Drawing.Color.White;
            this.PanelDetails.Controls.Add(this.LabelTotal);
            this.PanelDetails.Controls.Add(this.LabelTotalValue);
            this.PanelDetails.Controls.Add(this.LabelDiscount);
            this.PanelDetails.Controls.Add(this.LabelDiscountValue);
            this.PanelDetails.Controls.Add(this.LabelShipping);
            this.PanelDetails.Controls.Add(this.LabelShippingValue);
            this.PanelDetails.Controls.Add(this.LabelProducts);
            this.PanelDetails.Controls.Add(this.LabelProductsValue);
            this.PanelDetails.Controls.Add(this.LabelSubtotalTitle);
            this.PanelDetails.Controls.Add(this.ButtonSave);
            this.PanelDetails.Controls.Add(this.LabelIdHeader);
            this.PanelDetails.Controls.Add(this.LabelCreatedAt);
            this.PanelDetails.Controls.Add(this.LabelCreatedAtTitle);
            this.PanelDetails.Controls.Add(this.LabelPayment);
            this.PanelDetails.Controls.Add(this.LabelPaymentTitle);
            this.PanelDetails.Controls.Add(this.LabelCustomer);
            this.PanelDetails.Controls.Add(this.LabelCustomerTitle);
            this.PanelDetails.Controls.Add(this.PanelStatus);
            this.PanelDetails.Location = new System.Drawing.Point(276, 55);
            this.PanelDetails.Name = "PanelDetails";
            this.PanelDetails.Size = new System.Drawing.Size(298, 288);
            this.PanelDetails.TabIndex = 0;
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold);
            this.LabelTotal.Location = new System.Drawing.Point(170, 177);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(34, 7);
            this.LabelTotal.TabIndex = 165;
            this.LabelTotal.Text = "TOTAL:";
            // 
            // LabelTotalValue
            // 
            this.LabelTotalValue.Location = new System.Drawing.Point(209, 170);
            this.LabelTotalValue.Name = "LabelTotalValue";
            this.LabelTotalValue.Size = new System.Drawing.Size(76, 18);
            this.LabelTotalValue.TabIndex = 164;
            this.LabelTotalValue.Text = "-$123";
            this.LabelTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelDiscount
            // 
            this.LabelDiscount.AutoSize = true;
            this.LabelDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold);
            this.LabelDiscount.Location = new System.Drawing.Point(151, 153);
            this.LabelDiscount.Name = "LabelDiscount";
            this.LabelDiscount.Size = new System.Drawing.Size(54, 7);
            this.LabelDiscount.TabIndex = 163;
            this.LabelDiscount.Text = "DESCONTO:";
            // 
            // LabelDiscountValue
            // 
            this.LabelDiscountValue.Location = new System.Drawing.Point(209, 147);
            this.LabelDiscountValue.Name = "LabelDiscountValue";
            this.LabelDiscountValue.Size = new System.Drawing.Size(76, 18);
            this.LabelDiscountValue.TabIndex = 162;
            this.LabelDiscountValue.Text = "-$123";
            this.LabelDiscountValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelShipping
            // 
            this.LabelShipping.AutoSize = true;
            this.LabelShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold);
            this.LabelShipping.Location = new System.Drawing.Point(170, 130);
            this.LabelShipping.Name = "LabelShipping";
            this.LabelShipping.Size = new System.Drawing.Size(35, 7);
            this.LabelShipping.TabIndex = 161;
            this.LabelShipping.Text = "FRETE:";
            // 
            // LabelShippingValue
            // 
            this.LabelShippingValue.Location = new System.Drawing.Point(209, 123);
            this.LabelShippingValue.Name = "LabelShippingValue";
            this.LabelShippingValue.Size = new System.Drawing.Size(76, 18);
            this.LabelShippingValue.TabIndex = 160;
            this.LabelShippingValue.Text = "$123";
            this.LabelShippingValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelProducts
            // 
            this.LabelProducts.AutoSize = true;
            this.LabelProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold);
            this.LabelProducts.Location = new System.Drawing.Point(151, 107);
            this.LabelProducts.Name = "LabelProducts";
            this.LabelProducts.Size = new System.Drawing.Size(54, 7);
            this.LabelProducts.TabIndex = 159;
            this.LabelProducts.Text = "PRODUTOS:";
            // 
            // LabelProductsValue
            // 
            this.LabelProductsValue.Location = new System.Drawing.Point(209, 100);
            this.LabelProductsValue.Name = "LabelProductsValue";
            this.LabelProductsValue.Size = new System.Drawing.Size(76, 18);
            this.LabelProductsValue.TabIndex = 158;
            this.LabelProductsValue.Text = "$123";
            this.LabelProductsValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelSubtotalTitle
            // 
            this.LabelSubtotalTitle.AutoSize = true;
            this.LabelSubtotalTitle.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.LabelSubtotalTitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelSubtotalTitle.Location = new System.Drawing.Point(234, 80);
            this.LabelSubtotalTitle.Name = "LabelSubtotalTitle";
            this.LabelSubtotalTitle.Size = new System.Drawing.Size(54, 17);
            this.LabelSubtotalTitle.TabIndex = 157;
            this.LabelSubtotalTitle.Text = "Subtotal";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSave.Location = new System.Drawing.Point(209, 251);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 0;
            this.ButtonSave.Text = "Salvar";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // LabelIdHeader
            // 
            this.LabelIdHeader.AutoSize = true;
            this.LabelIdHeader.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIdHeader.Location = new System.Drawing.Point(13, 14);
            this.LabelIdHeader.Name = "LabelIdHeader";
            this.LabelIdHeader.Size = new System.Drawing.Size(63, 32);
            this.LabelIdHeader.TabIndex = 154;
            this.LabelIdHeader.Text = "#123";
            // 
            // LabelCreatedAt
            // 
            this.LabelCreatedAt.AutoSize = true;
            this.LabelCreatedAt.Location = new System.Drawing.Point(12, 191);
            this.LabelCreatedAt.Name = "LabelCreatedAt";
            this.LabelCreatedAt.Size = new System.Drawing.Size(67, 13);
            this.LabelCreatedAt.TabIndex = 153;
            this.LabelCreatedAt.Text = "17 abr. 2017";
            // 
            // LabelCreatedAtTitle
            // 
            this.LabelCreatedAtTitle.AutoSize = true;
            this.LabelCreatedAtTitle.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.LabelCreatedAtTitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelCreatedAtTitle.Location = new System.Drawing.Point(13, 170);
            this.LabelCreatedAtTitle.Name = "LabelCreatedAtTitle";
            this.LabelCreatedAtTitle.Size = new System.Drawing.Size(35, 17);
            this.LabelCreatedAtTitle.TabIndex = 152;
            this.LabelCreatedAtTitle.Text = "Data";
            // 
            // LabelPayment
            // 
            this.LabelPayment.AutoSize = true;
            this.LabelPayment.Location = new System.Drawing.Point(14, 142);
            this.LabelPayment.Name = "LabelPayment";
            this.LabelPayment.Size = new System.Drawing.Size(76, 13);
            this.LabelPayment.TabIndex = 151;
            this.LabelPayment.Text = "Desconhecido";
            // 
            // LabelPaymentTitle
            // 
            this.LabelPaymentTitle.AutoSize = true;
            this.LabelPaymentTitle.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.LabelPaymentTitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelPaymentTitle.Location = new System.Drawing.Point(13, 121);
            this.LabelPaymentTitle.Name = "LabelPaymentTitle";
            this.LabelPaymentTitle.Size = new System.Drawing.Size(72, 17);
            this.LabelPaymentTitle.TabIndex = 150;
            this.LabelPaymentTitle.Text = "Pagamento";
            // 
            // LabelCustomer
            // 
            this.LabelCustomer.AutoSize = true;
            this.LabelCustomer.Location = new System.Drawing.Point(14, 91);
            this.LabelCustomer.Name = "LabelCustomer";
            this.LabelCustomer.Size = new System.Drawing.Size(76, 13);
            this.LabelCustomer.TabIndex = 149;
            this.LabelCustomer.Text = "Desconhecido";
            // 
            // LabelCustomerTitle
            // 
            this.LabelCustomerTitle.AutoSize = true;
            this.LabelCustomerTitle.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.LabelCustomerTitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelCustomerTitle.Location = new System.Drawing.Point(13, 70);
            this.LabelCustomerTitle.Name = "LabelCustomerTitle";
            this.LabelCustomerTitle.Size = new System.Drawing.Size(48, 17);
            this.LabelCustomerTitle.TabIndex = 148;
            this.LabelCustomerTitle.Text = "Cliente";
            // 
            // PanelStatus
            // 
            this.PanelStatus.BackColor = System.Drawing.Color.White;
            this.PanelStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelStatus.Controls.Add(this.ComboBoxStatus);
            this.PanelStatus.Location = new System.Drawing.Point(153, 19);
            this.PanelStatus.Name = "PanelStatus";
            this.PanelStatus.Size = new System.Drawing.Size(132, 23);
            this.PanelStatus.TabIndex = 155;
            // 
            // ComboBoxStatus
            // 
            this.ComboBoxStatus.DropDownHeight = 68;
            this.ComboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxStatus.FormattingEnabled = true;
            this.ComboBoxStatus.IntegralHeight = false;
            this.ComboBoxStatus.Items.AddRange(new object[] {
            "Pendente",
            "Aprovado",
            "Entregue",
            "Cancelado"});
            this.ComboBoxStatus.Location = new System.Drawing.Point(0, 0);
            this.ComboBoxStatus.Name = "ComboBoxStatus";
            this.ComboBoxStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ComboBoxStatus.Size = new System.Drawing.Size(130, 21);
            this.ComboBoxStatus.TabIndex = 1;
            this.ComboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.ComboBoxStatus_SelectedIndexChanged);
            // 
            // PanelCartProductBox
            // 
            this.PanelCartProductBox.BackColor = System.Drawing.Color.White;
            this.PanelCartProductBox.Controls.Add(this.CartProductBox);
            this.PanelCartProductBox.Location = new System.Drawing.Point(15, 55);
            this.PanelCartProductBox.Name = "PanelCartProductBox";
            this.PanelCartProductBox.Size = new System.Drawing.Size(247, 288);
            this.PanelCartProductBox.TabIndex = 150;
            // 
            // CartProductBox
            // 
            this.CartProductBox.AutoScroll = true;
            this.CartProductBox.BackColor = System.Drawing.Color.White;
            this.CartProductBox.Location = new System.Drawing.Point(14, 14);
            this.CartProductBox.Name = "CartProductBox";
            this.CartProductBox.Size = new System.Drawing.Size(217, 260);
            this.CartProductBox.TabIndex = 150;
            // 
            // LabelItemsHeader
            // 
            this.LabelItemsHeader.AutoSize = true;
            this.LabelItemsHeader.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelItemsHeader.Location = new System.Drawing.Point(9, 10);
            this.LabelItemsHeader.Name = "LabelItemsHeader";
            this.LabelItemsHeader.Size = new System.Drawing.Size(67, 32);
            this.LabelItemsHeader.TabIndex = 151;
            this.LabelItemsHeader.Text = "Itens";
            // 
            // LabelDetailHeader
            // 
            this.LabelDetailHeader.AutoSize = true;
            this.LabelDetailHeader.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDetailHeader.Location = new System.Drawing.Point(270, 10);
            this.LabelDetailHeader.Name = "LabelDetailHeader";
            this.LabelDetailHeader.Size = new System.Drawing.Size(108, 32);
            this.LabelDetailHeader.TabIndex = 152;
            this.LabelDetailHeader.Text = "Detalhes";
            // 
            // FormOrderDetail
            // 
            this.AcceptButton = this.ButtonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 357);
            this.Controls.Add(this.LabelDetailHeader);
            this.Controls.Add(this.LabelItemsHeader);
            this.Controls.Add(this.PanelDetails);
            this.Controls.Add(this.PanelCartProductBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOrderDetail";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido – Detalhes";
            this.Load += new System.EventHandler(this.FormOrderDetail_Load);
            this.PanelDetails.ResumeLayout(false);
            this.PanelDetails.PerformLayout();
            this.PanelStatus.ResumeLayout(false);
            this.PanelCartProductBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelDetails;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Label LabelTotalValue;
        private System.Windows.Forms.Label LabelDiscount;
        private System.Windows.Forms.Label LabelDiscountValue;
        private System.Windows.Forms.Label LabelShipping;
        private System.Windows.Forms.Label LabelShippingValue;
        private System.Windows.Forms.Label LabelProducts;
        private System.Windows.Forms.Label LabelProductsValue;
        private System.Windows.Forms.Label LabelSubtotalTitle;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Label LabelIdHeader;
        private System.Windows.Forms.Label LabelCreatedAt;
        private System.Windows.Forms.Label LabelCreatedAtTitle;
        private System.Windows.Forms.Label LabelPayment;
        private System.Windows.Forms.Label LabelPaymentTitle;
        private System.Windows.Forms.Label LabelCustomer;
        private System.Windows.Forms.Label LabelCustomerTitle;
        private System.Windows.Forms.Panel PanelStatus;
        private System.Windows.Forms.ComboBox ComboBoxStatus;
        private System.Windows.Forms.Panel PanelCartProductBox;
        private Components.CartProductBox CartProductBox;
        private System.Windows.Forms.Label LabelItemsHeader;
        private System.Windows.Forms.Label LabelDetailHeader;
    }
}