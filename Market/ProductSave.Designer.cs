namespace Shop {

    partial class FormProductSave {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductSave));
            this.GroupBoxPreview = new System.Windows.Forms.GroupBox();
            this.ProductPanelPreview = new Shop.Components.ProductPanel();
            this.ComboBoxCategory = new System.Windows.Forms.ComboBox();
            this.PanelName = new System.Windows.Forms.Panel();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.NumericPromotionPercentage = new System.Windows.Forms.NumericUpDown();
            this.CheckBoxPromotion = new System.Windows.Forms.CheckBox();
            this.NumericValue = new System.Windows.Forms.NumericUpDown();
            this.PanelDescription = new System.Windows.Forms.Panel();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.NumericQuantity = new System.Windows.Forms.NumericUpDown();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelCategory = new System.Windows.Forms.Label();
            this.LabelQuantity = new System.Windows.Forms.Label();
            this.LabelValue = new System.Windows.Forms.Label();
            this.LabelPromotionPercentage = new System.Windows.Forms.Label();
            this.LabelPromotion = new System.Windows.Forms.Label();
            this.LabelImage = new System.Windows.Forms.Label();
            this.LabelProductsHeader = new System.Windows.Forms.Label();
            this.GroupBoxPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPromotionPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericValue)).BeginInit();
            this.PanelDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxPreview
            // 
            this.GroupBoxPreview.Controls.Add(this.ProductPanelPreview);
            this.GroupBoxPreview.Location = new System.Drawing.Point(12, 62);
            this.GroupBoxPreview.Name = "GroupBoxPreview";
            this.GroupBoxPreview.Size = new System.Drawing.Size(190, 282);
            this.GroupBoxPreview.TabIndex = 15;
            this.GroupBoxPreview.TabStop = false;
            this.GroupBoxPreview.Text = "Pré-visualização";
            // 
            // ProductPanelPreview
            // 
            this.ProductPanelPreview.BackColor = System.Drawing.Color.White;
            this.ProductPanelPreview.Location = new System.Drawing.Point(9, 20);
            this.ProductPanelPreview.Margin = new System.Windows.Forms.Padding(5);
            this.ProductPanelPreview.Name = "ProductPanelPreview";
            this.ProductPanelPreview.Product = null;
            this.ProductPanelPreview.Size = new System.Drawing.Size(171, 251);
            this.ProductPanelPreview.TabIndex = 0;
            // 
            // ComboBoxCategory
            // 
            this.ComboBoxCategory.Cursor = System.Windows.Forms.Cursors.Default;
            this.ComboBoxCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxCategory.FormattingEnabled = true;
            this.ComboBoxCategory.Location = new System.Drawing.Point(214, 82);
            this.ComboBoxCategory.Name = "ComboBoxCategory";
            this.ComboBoxCategory.Size = new System.Drawing.Size(246, 21);
            this.ComboBoxCategory.TabIndex = 1;
            this.ComboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCategory_SelectedIndexChanged);
            // 
            // PanelName
            // 
            this.PanelName.BackColor = System.Drawing.Color.White;
            this.PanelName.Location = new System.Drawing.Point(214, 125);
            this.PanelName.Name = "PanelName";
            this.PanelName.Size = new System.Drawing.Size(245, 23);
            this.PanelName.TabIndex = 105;
            // 
            // TextBoxName
            // 
            this.TextBoxName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TextBoxName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextBoxName.Location = new System.Drawing.Point(220, 130);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(234, 13);
            this.TextBoxName.TabIndex = 2;
            this.TextBoxName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxName_KeyUp);
            // 
            // NumericPromotionPercentage
            // 
            this.NumericPromotionPercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumericPromotionPercentage.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumericPromotionPercentage.Location = new System.Drawing.Point(399, 259);
            this.NumericPromotionPercentage.Maximum = new decimal(new int[] {
            95,
            0,
            0,
            0});
            this.NumericPromotionPercentage.Name = "NumericPromotionPercentage";
            this.NumericPromotionPercentage.Size = new System.Drawing.Size(58, 20);
            this.NumericPromotionPercentage.TabIndex = 5;
            this.NumericPromotionPercentage.ValueChanged += new System.EventHandler(this.NumericPromotionPercentage_ValueChanged);
            // 
            // CheckBoxPromotion
            // 
            this.CheckBoxPromotion.AutoSize = true;
            this.CheckBoxPromotion.Location = new System.Drawing.Point(444, 287);
            this.CheckBoxPromotion.Name = "CheckBoxPromotion";
            this.CheckBoxPromotion.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxPromotion.TabIndex = 7;
            this.CheckBoxPromotion.UseVisualStyleBackColor = true;
            this.CheckBoxPromotion.CheckedChanged += new System.EventHandler(this.CheckBoxPromotion_CheckedChanged);
            // 
            // NumericValue
            // 
            this.NumericValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumericValue.DecimalPlaces = 2;
            this.NumericValue.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.NumericValue.Location = new System.Drawing.Point(215, 299);
            this.NumericValue.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.NumericValue.Name = "NumericValue";
            this.NumericValue.Size = new System.Drawing.Size(58, 20);
            this.NumericValue.TabIndex = 6;
            this.NumericValue.ValueChanged += new System.EventHandler(this.NumericValue_ValueChanged);
            // 
            // PanelDescription
            // 
            this.PanelDescription.BackColor = System.Drawing.Color.White;
            this.PanelDescription.Controls.Add(this.TextBoxDescription);
            this.PanelDescription.Location = new System.Drawing.Point(214, 170);
            this.PanelDescription.Name = "PanelDescription";
            this.PanelDescription.Size = new System.Drawing.Size(245, 67);
            this.PanelDescription.TabIndex = 106;
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TextBoxDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxDescription.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextBoxDescription.Location = new System.Drawing.Point(8, 8);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxDescription.Size = new System.Drawing.Size(228, 52);
            this.TextBoxDescription.TabIndex = 3;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSave.Location = new System.Drawing.Point(384, 338);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 9;
            this.ButtonSave.Text = "Salvar";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // NumericQuantity
            // 
            this.NumericQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumericQuantity.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericQuantity.Location = new System.Drawing.Point(214, 259);
            this.NumericQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericQuantity.Name = "NumericQuantity";
            this.NumericQuantity.Size = new System.Drawing.Size(58, 20);
            this.NumericQuantity.TabIndex = 4;
            this.NumericQuantity.ValueChanged += new System.EventHandler(this.NumericQuantity_ValueChanged);
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.LabelDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LabelDescription.Location = new System.Drawing.Point(212, 154);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(47, 12);
            this.LabelDescription.TabIndex = 141;
            this.LabelDescription.Text = "Descrição";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.LabelName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LabelName.Location = new System.Drawing.Point(212, 109);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(30, 12);
            this.LabelName.TabIndex = 142;
            this.LabelName.Text = "Nome";
            // 
            // LabelCategory
            // 
            this.LabelCategory.AutoSize = true;
            this.LabelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.LabelCategory.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LabelCategory.Location = new System.Drawing.Point(212, 67);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(45, 12);
            this.LabelCategory.TabIndex = 143;
            this.LabelCategory.Text = "Categoria";
            // 
            // LabelQuantity
            // 
            this.LabelQuantity.AutoSize = true;
            this.LabelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.LabelQuantity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LabelQuantity.Location = new System.Drawing.Point(212, 243);
            this.LabelQuantity.Name = "LabelQuantity";
            this.LabelQuantity.Size = new System.Drawing.Size(39, 12);
            this.LabelQuantity.TabIndex = 144;
            this.LabelQuantity.Text = "Estoque";
            // 
            // LabelValue
            // 
            this.LabelValue.AutoSize = true;
            this.LabelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.LabelValue.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LabelValue.Location = new System.Drawing.Point(213, 284);
            this.LabelValue.Name = "LabelValue";
            this.LabelValue.Size = new System.Drawing.Size(29, 12);
            this.LabelValue.TabIndex = 145;
            this.LabelValue.Text = "Preço";
            // 
            // LabelPromotionPercentage
            // 
            this.LabelPromotionPercentage.AutoSize = true;
            this.LabelPromotionPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.LabelPromotionPercentage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LabelPromotionPercentage.Location = new System.Drawing.Point(340, 244);
            this.LabelPromotionPercentage.Name = "LabelPromotionPercentage";
            this.LabelPromotionPercentage.Size = new System.Drawing.Size(120, 12);
            this.LabelPromotionPercentage.TabIndex = 146;
            this.LabelPromotionPercentage.Text = "Desconto em Promoção (%)";
            // 
            // LabelPromotion
            // 
            this.LabelPromotion.AutoSize = true;
            this.LabelPromotion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.LabelPromotion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LabelPromotion.Location = new System.Drawing.Point(388, 287);
            this.LabelPromotion.Name = "LabelPromotion";
            this.LabelPromotion.Size = new System.Drawing.Size(52, 12);
            this.LabelPromotion.TabIndex = 147;
            this.LabelPromotion.Text = "Promoção?";
            // 
            // LabelImage
            // 
            this.LabelImage.AutoSize = true;
            this.LabelImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.LabelImage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LabelImage.Location = new System.Drawing.Point(12, 349);
            this.LabelImage.Name = "LabelImage";
            this.LabelImage.Size = new System.Drawing.Size(69, 12);
            this.LabelImage.TabIndex = 8;
            this.LabelImage.Text = "Alterar Imagem";
            this.LabelImage.Click += new System.EventHandler(this.LabelImage_Click);
            // 
            // LabelProductsHeader
            // 
            this.LabelProductsHeader.AutoSize = true;
            this.LabelProductsHeader.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProductsHeader.Location = new System.Drawing.Point(7, 9);
            this.LabelProductsHeader.Name = "LabelProductsHeader";
            this.LabelProductsHeader.Size = new System.Drawing.Size(234, 32);
            this.LabelProductsHeader.TabIndex = 149;
            this.LabelProductsHeader.Text = "Cadastro de Produto";
            // 
            // FormProductSave
            // 
            this.AcceptButton = this.ButtonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 373);
            this.Controls.Add(this.LabelProductsHeader);
            this.Controls.Add(this.LabelImage);
            this.Controls.Add(this.LabelPromotion);
            this.Controls.Add(this.LabelPromotionPercentage);
            this.Controls.Add(this.LabelValue);
            this.Controls.Add(this.LabelQuantity);
            this.Controls.Add(this.LabelCategory);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.CheckBoxPromotion);
            this.Controls.Add(this.NumericQuantity);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.PanelDescription);
            this.Controls.Add(this.NumericValue);
            this.Controls.Add(this.NumericPromotionPercentage);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.PanelName);
            this.Controls.Add(this.ComboBoxCategory);
            this.Controls.Add(this.GroupBoxPreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProductSave";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto – Cadastro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormProductSave_FormClosed);
            this.Load += new System.EventHandler(this.FormProductAdd_Load);
            this.GroupBoxPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericPromotionPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericValue)).EndInit();
            this.PanelDescription.ResumeLayout(false);
            this.PanelDescription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.ProductPanel ProductPanelPreview;
        private System.Windows.Forms.GroupBox GroupBoxPreview;
        private System.Windows.Forms.ComboBox ComboBoxCategory;
        private System.Windows.Forms.Panel PanelName;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.NumericUpDown NumericPromotionPercentage;
        private System.Windows.Forms.CheckBox CheckBoxPromotion;
        private System.Windows.Forms.NumericUpDown NumericValue;
        private System.Windows.Forms.Panel PanelDescription;
        private System.Windows.Forms.TextBox TextBoxDescription;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.NumericUpDown NumericQuantity;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelCategory;
        private System.Windows.Forms.Label LabelQuantity;
        private System.Windows.Forms.Label LabelValue;
        private System.Windows.Forms.Label LabelPromotionPercentage;
        private System.Windows.Forms.Label LabelPromotion;
        private System.Windows.Forms.Label LabelImage;
        private System.Windows.Forms.Label LabelProductsHeader;
    }
}