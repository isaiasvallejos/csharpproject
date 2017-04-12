namespace Shop
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.PanelProducts = new System.Windows.Forms.Panel();
            this.ModelPanelProduct = new System.Windows.Forms.Panel();
            this.ModelButtonProductBuy = new System.Windows.Forms.Button();
            this.ModelPictureBoxProductImage = new System.Windows.Forms.PictureBox();
            this.ModelLabelProductValue = new System.Windows.Forms.Label();
            this.ModelLabelProductName = new System.Windows.Forms.Label();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.ComboBoxOrderBy = new System.Windows.Forms.ComboBox();
            this.PanelCart = new System.Windows.Forms.Panel();
            this.ModelPanelCartProduct = new System.Windows.Forms.Panel();
            this.ModelButtonCartProductRemove = new System.Windows.Forms.Button();
            this.ModelNumericCartProductQuantity = new System.Windows.Forms.NumericUpDown();
            this.ModelLabelCartProductValue = new System.Windows.Forms.Label();
            this.ModelLabelCartProductName = new System.Windows.Forms.Label();
            this.ModelPictureBoxCartProductImage = new System.Windows.Forms.PictureBox();
            this.LabelCartSubtotal = new System.Windows.Forms.Label();
            this.LabelCartSubtotalValue = new System.Windows.Forms.Label();
            this.LabelOrderBy = new System.Windows.Forms.Label();
            this.PanelSearch = new System.Windows.Forms.Panel();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.PanelCartContainer = new System.Windows.Forms.Panel();
            this.PictureBoxCartIcon = new System.Windows.Forms.PictureBox();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.PanelUsername = new System.Windows.Forms.Panel();
            this.PanelPassword = new System.Windows.Forms.Panel();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.GroupBoxLogin = new System.Windows.Forms.GroupBox();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.PanelCartSubtotal = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelCartShipping = new System.Windows.Forms.Label();
            this.LabelCartShippingValue = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabelCartDiscount = new System.Windows.Forms.Label();
            this.LabelCartDiscountValue = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LabelCartTotal = new System.Windows.Forms.Label();
            this.LabelCartTotalValue = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PanelProducts.SuspendLayout();
            this.ModelPanelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModelPictureBoxProductImage)).BeginInit();
            this.PanelCart.SuspendLayout();
            this.ModelPanelCartProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModelNumericCartProductQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelPictureBoxCartProductImage)).BeginInit();
            this.PanelCartContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCartIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.GroupBoxLogin.SuspendLayout();
            this.PanelCartSubtotal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelProducts
            // 
            this.PanelProducts.AutoScroll = true;
            this.PanelProducts.Controls.Add(this.ModelPanelProduct);
            this.PanelProducts.Location = new System.Drawing.Point(12, 142);
            this.PanelProducts.Name = "PanelProducts";
            this.PanelProducts.Size = new System.Drawing.Size(550, 514);
            this.PanelProducts.TabIndex = 7;
            // 
            // ModelPanelProduct
            // 
            this.ModelPanelProduct.BackColor = System.Drawing.Color.White;
            this.ModelPanelProduct.Controls.Add(this.ModelButtonProductBuy);
            this.ModelPanelProduct.Controls.Add(this.ModelPictureBoxProductImage);
            this.ModelPanelProduct.Controls.Add(this.ModelLabelProductValue);
            this.ModelPanelProduct.Controls.Add(this.ModelLabelProductName);
            this.ModelPanelProduct.Location = new System.Drawing.Point(9, 8);
            this.ModelPanelProduct.Name = "ModelPanelProduct";
            this.ModelPanelProduct.Padding = new System.Windows.Forms.Padding(5);
            this.ModelPanelProduct.Size = new System.Drawing.Size(171, 251);
            this.ModelPanelProduct.TabIndex = 0;
            // 
            // ModelButtonProductBuy
            // 
            this.ModelButtonProductBuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModelButtonProductBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModelButtonProductBuy.Location = new System.Drawing.Point(49, 218);
            this.ModelButtonProductBuy.Name = "ModelButtonProductBuy";
            this.ModelButtonProductBuy.Size = new System.Drawing.Size(75, 23);
            this.ModelButtonProductBuy.TabIndex = 4;
            this.ModelButtonProductBuy.TabStop = false;
            this.ModelButtonProductBuy.Text = "Comprar";
            this.ModelButtonProductBuy.UseVisualStyleBackColor = true;
            // 
            // ModelPictureBoxProductImage
            // 
            this.ModelPictureBoxProductImage.BackColor = System.Drawing.SystemColors.Control;
            this.ModelPictureBoxProductImage.Image = ((System.Drawing.Image)(resources.GetObject("ModelPictureBoxProductImage.Image")));
            this.ModelPictureBoxProductImage.Location = new System.Drawing.Point(9, 9);
            this.ModelPictureBoxProductImage.Name = "ModelPictureBoxProductImage";
            this.ModelPictureBoxProductImage.Size = new System.Drawing.Size(153, 154);
            this.ModelPictureBoxProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ModelPictureBoxProductImage.TabIndex = 3;
            this.ModelPictureBoxProductImage.TabStop = false;
            // 
            // ModelLabelProductValue
            // 
            this.ModelLabelProductValue.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLabelProductValue.Location = new System.Drawing.Point(8, 184);
            this.ModelLabelProductValue.Name = "ModelLabelProductValue";
            this.ModelLabelProductValue.Size = new System.Drawing.Size(154, 32);
            this.ModelLabelProductValue.TabIndex = 2;
            this.ModelLabelProductValue.Text = "$ 123";
            this.ModelLabelProductValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelLabelProductName
            // 
            this.ModelLabelProductName.AutoEllipsis = true;
            this.ModelLabelProductName.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLabelProductName.Location = new System.Drawing.Point(9, 166);
            this.ModelLabelProductName.Name = "ModelLabelProductName";
            this.ModelLabelProductName.Size = new System.Drawing.Size(154, 19);
            this.ModelLabelProductName.TabIndex = 1;
            this.ModelLabelProductName.Text = "Nome do Produto";
            this.ModelLabelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxSearch.Location = new System.Drawing.Point(376, 112);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(181, 13);
            this.TextBoxSearch.TabIndex = 1;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // ComboBoxOrderBy
            // 
            this.ComboBoxOrderBy.Cursor = System.Windows.Forms.Cursors.Default;
            this.ComboBoxOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxOrderBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxOrderBy.FormattingEnabled = true;
            this.ComboBoxOrderBy.Items.AddRange(new object[] {
            "A-Z",
            "Maior preço",
            "Menor preço"});
            this.ComboBoxOrderBy.Location = new System.Drawing.Point(81, 107);
            this.ComboBoxOrderBy.Name = "ComboBoxOrderBy";
            this.ComboBoxOrderBy.Size = new System.Drawing.Size(157, 21);
            this.ComboBoxOrderBy.TabIndex = 99;
            this.ComboBoxOrderBy.TabStop = false;
            this.ComboBoxOrderBy.SelectedIndexChanged += new System.EventHandler(this.ComboBoxOrderBy_SelectedIndexChanged);
            // 
            // PanelCart
            // 
            this.PanelCart.AutoScroll = true;
            this.PanelCart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PanelCart.Controls.Add(this.ModelPanelCartProduct);
            this.PanelCart.Location = new System.Drawing.Point(576, 159);
            this.PanelCart.Name = "PanelCart";
            this.PanelCart.Size = new System.Drawing.Size(221, 253);
            this.PanelCart.TabIndex = 100;
            // 
            // ModelPanelCartProduct
            // 
            this.ModelPanelCartProduct.BackColor = System.Drawing.SystemColors.Control;
            this.ModelPanelCartProduct.Controls.Add(this.ModelButtonCartProductRemove);
            this.ModelPanelCartProduct.Controls.Add(this.ModelNumericCartProductQuantity);
            this.ModelPanelCartProduct.Controls.Add(this.ModelLabelCartProductValue);
            this.ModelPanelCartProduct.Controls.Add(this.ModelLabelCartProductName);
            this.ModelPanelCartProduct.Controls.Add(this.ModelPictureBoxCartProductImage);
            this.ModelPanelCartProduct.Location = new System.Drawing.Point(6, 5);
            this.ModelPanelCartProduct.Name = "ModelPanelCartProduct";
            this.ModelPanelCartProduct.Size = new System.Drawing.Size(197, 59);
            this.ModelPanelCartProduct.TabIndex = 0;
            // 
            // ModelButtonCartProductRemove
            // 
            this.ModelButtonCartProductRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModelButtonCartProductRemove.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ModelButtonCartProductRemove.FlatAppearance.BorderSize = 0;
            this.ModelButtonCartProductRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModelButtonCartProductRemove.Image = ((System.Drawing.Image)(resources.GetObject("ModelButtonCartProductRemove.Image")));
            this.ModelButtonCartProductRemove.Location = new System.Drawing.Point(181, 1);
            this.ModelButtonCartProductRemove.Name = "ModelButtonCartProductRemove";
            this.ModelButtonCartProductRemove.Size = new System.Drawing.Size(15, 15);
            this.ModelButtonCartProductRemove.TabIndex = 1;
            this.ModelButtonCartProductRemove.TabStop = false;
            this.ModelButtonCartProductRemove.UseVisualStyleBackColor = true;
            // 
            // ModelNumericCartProductQuantity
            // 
            this.ModelNumericCartProductQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModelNumericCartProductQuantity.Location = new System.Drawing.Point(158, 33);
            this.ModelNumericCartProductQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ModelNumericCartProductQuantity.Name = "ModelNumericCartProductQuantity";
            this.ModelNumericCartProductQuantity.Size = new System.Drawing.Size(34, 20);
            this.ModelNumericCartProductQuantity.TabIndex = 3;
            this.ModelNumericCartProductQuantity.TabStop = false;
            this.ModelNumericCartProductQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ModelNumericCartProductQuantity.ValueChanged += new System.EventHandler(this.NumericCartProductQuantity_ValueChanged);
            // 
            // ModelLabelCartProductValue
            // 
            this.ModelLabelCartProductValue.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLabelCartProductValue.Location = new System.Drawing.Point(59, 36);
            this.ModelLabelCartProductValue.Name = "ModelLabelCartProductValue";
            this.ModelLabelCartProductValue.Size = new System.Drawing.Size(98, 12);
            this.ModelLabelCartProductValue.TabIndex = 2;
            this.ModelLabelCartProductValue.Text = "$123";
            this.ModelLabelCartProductValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ModelLabelCartProductName
            // 
            this.ModelLabelCartProductName.AutoEllipsis = true;
            this.ModelLabelCartProductName.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLabelCartProductName.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ModelLabelCartProductName.Location = new System.Drawing.Point(57, 7);
            this.ModelLabelCartProductName.Name = "ModelLabelCartProductName";
            this.ModelLabelCartProductName.Size = new System.Drawing.Size(117, 15);
            this.ModelLabelCartProductName.TabIndex = 1;
            this.ModelLabelCartProductName.Text = "Nome do Produto";
            // 
            // ModelPictureBoxCartProductImage
            // 
            this.ModelPictureBoxCartProductImage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ModelPictureBoxCartProductImage.Image = ((System.Drawing.Image)(resources.GetObject("ModelPictureBoxCartProductImage.Image")));
            this.ModelPictureBoxCartProductImage.Location = new System.Drawing.Point(5, 5);
            this.ModelPictureBoxCartProductImage.Name = "ModelPictureBoxCartProductImage";
            this.ModelPictureBoxCartProductImage.Size = new System.Drawing.Size(50, 50);
            this.ModelPictureBoxCartProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ModelPictureBoxCartProductImage.TabIndex = 0;
            this.ModelPictureBoxCartProductImage.TabStop = false;
            // 
            // LabelCartSubtotal
            // 
            this.LabelCartSubtotal.AutoSize = true;
            this.LabelCartSubtotal.BackColor = System.Drawing.Color.White;
            this.LabelCartSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LabelCartSubtotal.Location = new System.Drawing.Point(8, 6);
            this.LabelCartSubtotal.Name = "LabelCartSubtotal";
            this.LabelCartSubtotal.Size = new System.Drawing.Size(49, 13);
            this.LabelCartSubtotal.TabIndex = 102;
            this.LabelCartSubtotal.Text = "Subtotal:";
            // 
            // LabelCartSubtotalValue
            // 
            this.LabelCartSubtotalValue.BackColor = System.Drawing.Color.White;
            this.LabelCartSubtotalValue.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.LabelCartSubtotalValue.Location = new System.Drawing.Point(74, 2);
            this.LabelCartSubtotalValue.Name = "LabelCartSubtotalValue";
            this.LabelCartSubtotalValue.Size = new System.Drawing.Size(143, 20);
            this.LabelCartSubtotalValue.TabIndex = 103;
            this.LabelCartSubtotalValue.Text = "$123";
            this.LabelCartSubtotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelOrderBy
            // 
            this.LabelOrderBy.AutoSize = true;
            this.LabelOrderBy.Location = new System.Drawing.Point(12, 110);
            this.LabelOrderBy.Name = "LabelOrderBy";
            this.LabelOrderBy.Size = new System.Drawing.Size(63, 13);
            this.LabelOrderBy.TabIndex = 13;
            this.LabelOrderBy.Text = "Ordenar por";
            // 
            // PanelSearch
            // 
            this.PanelSearch.BackColor = System.Drawing.Color.White;
            this.PanelSearch.Location = new System.Drawing.Point(370, 107);
            this.PanelSearch.Name = "PanelSearch";
            this.PanelSearch.Size = new System.Drawing.Size(192, 23);
            this.PanelSearch.TabIndex = 10;
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Location = new System.Drawing.Point(301, 112);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(65, 13);
            this.LabelSearch.TabIndex = 104;
            this.LabelSearch.Text = "Procurar por";
            // 
            // PanelCartContainer
            // 
            this.PanelCartContainer.BackColor = System.Drawing.Color.White;
            this.PanelCartContainer.Controls.Add(this.PictureBoxCartIcon);
            this.PanelCartContainer.Location = new System.Drawing.Point(576, 107);
            this.PanelCartContainer.Name = "PanelCartContainer";
            this.PanelCartContainer.Size = new System.Drawing.Size(221, 305);
            this.PanelCartContainer.TabIndex = 105;
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
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxLogo.Image")));
            this.PictureBoxLogo.Location = new System.Drawing.Point(215, 25);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(161, 52);
            this.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxLogo.TabIndex = 106;
            this.PictureBoxLogo.TabStop = false;
            // 
            // PanelUsername
            // 
            this.PanelUsername.BackColor = System.Drawing.Color.White;
            this.PanelUsername.Location = new System.Drawing.Point(10, 24);
            this.PanelUsername.Name = "PanelUsername";
            this.PanelUsername.Size = new System.Drawing.Size(137, 23);
            this.PanelUsername.TabIndex = 12;
            // 
            // PanelPassword
            // 
            this.PanelPassword.BackColor = System.Drawing.Color.White;
            this.PanelPassword.Location = new System.Drawing.Point(10, 55);
            this.PanelPassword.Name = "PanelPassword";
            this.PanelPassword.Size = new System.Drawing.Size(137, 23);
            this.PanelPassword.TabIndex = 108;
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxUsername.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TextBoxUsername.Location = new System.Drawing.Point(16, 29);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(126, 13);
            this.TextBoxUsername.TabIndex = 11;
            this.TextBoxUsername.Text = "Nome de Usuário";
            this.TextBoxUsername.Enter += new System.EventHandler(this.TextBoxUsername_Enter);
            this.TextBoxUsername.Leave += new System.EventHandler(this.TextBoxUsername_Leave);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPassword.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TextBoxPassword.HideSelection = false;
            this.TextBoxPassword.Location = new System.Drawing.Point(16, 60);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(126, 13);
            this.TextBoxPassword.TabIndex = 107;
            this.TextBoxPassword.Text = "Senha";
            this.TextBoxPassword.Enter += new System.EventHandler(this.TextBoxPassword_Enter);
            this.TextBoxPassword.Leave += new System.EventHandler(this.TextBoxPassword_Leave);
            // 
            // GroupBoxLogin
            // 
            this.GroupBoxLogin.Controls.Add(this.ButtonLogin);
            this.GroupBoxLogin.Controls.Add(this.TextBoxPassword);
            this.GroupBoxLogin.Controls.Add(this.TextBoxUsername);
            this.GroupBoxLogin.Controls.Add(this.PanelPassword);
            this.GroupBoxLogin.Controls.Add(this.PanelUsername);
            this.GroupBoxLogin.Location = new System.Drawing.Point(576, 4);
            this.GroupBoxLogin.Name = "GroupBoxLogin";
            this.GroupBoxLogin.Size = new System.Drawing.Size(218, 92);
            this.GroupBoxLogin.TabIndex = 109;
            this.GroupBoxLogin.TabStop = false;
            this.GroupBoxLogin.Text = "Autenticar ou Registrar";
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.ButtonLogin.Location = new System.Drawing.Point(153, 55);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(55, 22);
            this.ButtonLogin.TabIndex = 110;
            this.ButtonLogin.Text = "Entrar!";
            this.ButtonLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonLogin.UseVisualStyleBackColor = true;
            // 
            // PanelCartSubtotal
            // 
            this.PanelCartSubtotal.BackColor = System.Drawing.Color.White;
            this.PanelCartSubtotal.Controls.Add(this.LabelCartSubtotal);
            this.PanelCartSubtotal.Controls.Add(this.LabelCartSubtotalValue);
            this.PanelCartSubtotal.Location = new System.Drawing.Point(576, 417);
            this.PanelCartSubtotal.Name = "PanelCartSubtotal";
            this.PanelCartSubtotal.Size = new System.Drawing.Size(221, 25);
            this.PanelCartSubtotal.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.LabelCartShipping);
            this.panel1.Controls.Add(this.LabelCartShippingValue);
            this.panel1.Location = new System.Drawing.Point(576, 442);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 25);
            this.panel1.TabIndex = 104;
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
            this.LabelCartShippingValue.Text = "$123";
            this.LabelCartShippingValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.LabelCartDiscount);
            this.panel2.Controls.Add(this.LabelCartDiscountValue);
            this.panel2.Location = new System.Drawing.Point(576, 467);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 25);
            this.panel2.TabIndex = 105;
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
            this.LabelCartDiscountValue.Text = "$123";
            this.LabelCartDiscountValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.LabelCartTotal);
            this.panel3.Controls.Add(this.LabelCartTotalValue);
            this.panel3.Location = new System.Drawing.Point(576, 497);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(221, 31);
            this.panel3.TabIndex = 106;
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
            this.LabelCartTotalValue.Text = "$123";
            this.LabelCartTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(576, 534);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 23);
            this.button1.TabIndex = 104;
            this.button1.Text = "Fechar Carrinho";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(809, 668);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GroupBoxLogin);
            this.Controls.Add(this.PictureBoxLogo);
            this.Controls.Add(this.LabelSearch);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.PanelSearch);
            this.Controls.Add(this.PanelCart);
            this.Controls.Add(this.LabelOrderBy);
            this.Controls.Add(this.ComboBoxOrderBy);
            this.Controls.Add(this.PanelProducts);
            this.Controls.Add(this.PanelCartContainer);
            this.Controls.Add(this.PanelCartSubtotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prophet Shop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.PanelProducts.ResumeLayout(false);
            this.ModelPanelProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ModelPictureBoxProductImage)).EndInit();
            this.PanelCart.ResumeLayout(false);
            this.ModelPanelCartProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ModelNumericCartProductQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelPictureBoxCartProductImage)).EndInit();
            this.PanelCartContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCartIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.GroupBoxLogin.ResumeLayout(false);
            this.GroupBoxLogin.PerformLayout();
            this.PanelCartSubtotal.ResumeLayout(false);
            this.PanelCartSubtotal.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PanelProducts;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.ComboBox ComboBoxOrderBy;
        private System.Windows.Forms.Panel PanelCart;
        private System.Windows.Forms.Panel ModelPanelProduct;
        private System.Windows.Forms.Label ModelLabelProductName;
        private System.Windows.Forms.Label ModelLabelProductValue;
        private System.Windows.Forms.PictureBox ModelPictureBoxProductImage;
        private System.Windows.Forms.Button ModelButtonProductBuy;
        private System.Windows.Forms.PictureBox ModelPictureBoxCartProductImage;
        private System.Windows.Forms.Label ModelLabelCartProductName;
        private System.Windows.Forms.Label ModelLabelCartProductValue;
        private System.Windows.Forms.NumericUpDown ModelNumericCartProductQuantity;
        private System.Windows.Forms.Button ModelButtonCartProductRemove;
        private System.Windows.Forms.Panel ModelPanelCartProduct;
        private System.Windows.Forms.Label LabelCartSubtotal;
        private System.Windows.Forms.Label LabelCartSubtotalValue;
        private System.Windows.Forms.Label LabelOrderBy;
        private System.Windows.Forms.Panel PanelSearch;
        private System.Windows.Forms.Label LabelSearch;
        private System.Windows.Forms.Panel PanelCartContainer;
        private System.Windows.Forms.PictureBox PictureBoxCartIcon;
        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.Panel PanelUsername;
        private System.Windows.Forms.Panel PanelPassword;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.GroupBox GroupBoxLogin;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Panel PanelCartSubtotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelCartShipping;
        private System.Windows.Forms.Label LabelCartShippingValue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LabelCartDiscount;
        private System.Windows.Forms.Label LabelCartDiscountValue;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LabelCartTotal;
        private System.Windows.Forms.Label LabelCartTotalValue;
        private System.Windows.Forms.Button button1;
    }
}