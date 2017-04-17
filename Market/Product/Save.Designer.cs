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
            this.LabelCategory = new System.Windows.Forms.Label();
            this.ComboBoxCategory = new System.Windows.Forms.ComboBox();
            this.PanelName = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.LabelPromotionPercentage = new System.Windows.Forms.Label();
            this.NumericPromotionPercentage = new System.Windows.Forms.NumericUpDown();
            this.CheckBoxPromotion = new System.Windows.Forms.CheckBox();
            this.LabelValue = new System.Windows.Forms.Label();
            this.NumericValue = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.PanelDescription = new System.Windows.Forms.Panel();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.LabelImage = new System.Windows.Forms.Label();
            this.LabelQuantity = new System.Windows.Forms.Label();
            this.NumericQuantity = new System.Windows.Forms.NumericUpDown();
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
            this.GroupBoxPreview.Location = new System.Drawing.Point(12, 12);
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
            // LabelCategory
            // 
            this.LabelCategory.Location = new System.Drawing.Point(214, 12);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(237, 15);
            this.LabelCategory.TabIndex = 101;
            this.LabelCategory.Text = "Categoria";
            this.LabelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComboBoxCategory
            // 
            this.ComboBoxCategory.Cursor = System.Windows.Forms.Cursors.Default;
            this.ComboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxCategory.FormattingEnabled = true;
            this.ComboBoxCategory.Location = new System.Drawing.Point(214, 32);
            this.ComboBoxCategory.Name = "ComboBoxCategory";
            this.ComboBoxCategory.Size = new System.Drawing.Size(246, 21);
            this.ComboBoxCategory.TabIndex = 100;
            this.ComboBoxCategory.TabStop = false;
            this.ComboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCategory_SelectedIndexChanged);
            // 
            // PanelName
            // 
            this.PanelName.BackColor = System.Drawing.Color.White;
            this.PanelName.Location = new System.Drawing.Point(214, 78);
            this.PanelName.Name = "PanelName";
            this.PanelName.Size = new System.Drawing.Size(245, 23);
            this.PanelName.TabIndex = 105;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(215, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 15);
            this.label2.TabIndex = 103;
            this.label2.Text = "Nome";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextBoxName
            // 
            this.TextBoxName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TextBoxName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextBoxName.Location = new System.Drawing.Point(220, 83);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(234, 13);
            this.TextBoxName.TabIndex = 104;
            this.TextBoxName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxName_KeyUp);
            // 
            // LabelPromotionPercentage
            // 
            this.LabelPromotionPercentage.Location = new System.Drawing.Point(214, 265);
            this.LabelPromotionPercentage.Name = "LabelPromotionPercentage";
            this.LabelPromotionPercentage.Size = new System.Drawing.Size(139, 15);
            this.LabelPromotionPercentage.TabIndex = 107;
            this.LabelPromotionPercentage.Text = "Desconto em Promoção (%)";
            this.LabelPromotionPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NumericPromotionPercentage
            // 
            this.NumericPromotionPercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumericPromotionPercentage.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumericPromotionPercentage.Location = new System.Drawing.Point(402, 263);
            this.NumericPromotionPercentage.Maximum = new decimal(new int[] {
            95,
            0,
            0,
            0});
            this.NumericPromotionPercentage.Name = "NumericPromotionPercentage";
            this.NumericPromotionPercentage.Size = new System.Drawing.Size(58, 20);
            this.NumericPromotionPercentage.TabIndex = 106;
            this.NumericPromotionPercentage.ValueChanged += new System.EventHandler(this.NumericPromotionPercentage_ValueChanged);
            // 
            // CheckBoxPromotion
            // 
            this.CheckBoxPromotion.AutoSize = true;
            this.CheckBoxPromotion.Location = new System.Drawing.Point(219, 295);
            this.CheckBoxPromotion.Name = "CheckBoxPromotion";
            this.CheckBoxPromotion.Size = new System.Drawing.Size(80, 17);
            this.CheckBoxPromotion.TabIndex = 108;
            this.CheckBoxPromotion.Text = "Promoção?";
            this.CheckBoxPromotion.UseVisualStyleBackColor = true;
            this.CheckBoxPromotion.CheckedChanged += new System.EventHandler(this.CheckBoxPromotion_CheckedChanged);
            // 
            // LabelValue
            // 
            this.LabelValue.Location = new System.Drawing.Point(215, 237);
            this.LabelValue.Name = "LabelValue";
            this.LabelValue.Size = new System.Drawing.Size(50, 15);
            this.LabelValue.TabIndex = 110;
            this.LabelValue.Text = "Preço ($)";
            this.LabelValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.NumericValue.Location = new System.Drawing.Point(402, 235);
            this.NumericValue.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.NumericValue.Name = "NumericValue";
            this.NumericValue.Size = new System.Drawing.Size(58, 20);
            this.NumericValue.TabIndex = 109;
            this.NumericValue.ValueChanged += new System.EventHandler(this.NumericValue_ValueChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(214, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 15);
            this.label5.TabIndex = 112;
            this.label5.Text = "Descrição";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PanelDescription
            // 
            this.PanelDescription.BackColor = System.Drawing.Color.White;
            this.PanelDescription.Controls.Add(this.TextBoxDescription);
            this.PanelDescription.Location = new System.Drawing.Point(214, 128);
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
            this.TextBoxDescription.Size = new System.Drawing.Size(228, 52);
            this.TextBoxDescription.TabIndex = 112;
            // 
            // ButtonSave
            // 
            this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSave.Location = new System.Drawing.Point(384, 312);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 113;
            this.ButtonSave.Text = "Salvar";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // LabelImage
            // 
            this.LabelImage.AutoSize = true;
            this.LabelImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelImage.Location = new System.Drawing.Point(13, 302);
            this.LabelImage.Name = "LabelImage";
            this.LabelImage.Size = new System.Drawing.Size(77, 13);
            this.LabelImage.TabIndex = 114;
            this.LabelImage.Text = "Alterar Imagem";
            this.LabelImage.Click += new System.EventHandler(this.LabelImage_Click);
            // 
            // LabelQuantity
            // 
            this.LabelQuantity.Location = new System.Drawing.Point(208, 209);
            this.LabelQuantity.Name = "LabelQuantity";
            this.LabelQuantity.Size = new System.Drawing.Size(52, 15);
            this.LabelQuantity.TabIndex = 116;
            this.LabelQuantity.Text = "Estoque";
            this.LabelQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NumericQuantity
            // 
            this.NumericQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumericQuantity.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericQuantity.Location = new System.Drawing.Point(402, 207);
            this.NumericQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericQuantity.Name = "NumericQuantity";
            this.NumericQuantity.Size = new System.Drawing.Size(58, 20);
            this.NumericQuantity.TabIndex = 115;
            this.NumericQuantity.ValueChanged += new System.EventHandler(this.NumericQuantity_ValueChanged);
            // 
            // FormProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 347);
            this.Controls.Add(this.CheckBoxPromotion);
            this.Controls.Add(this.LabelQuantity);
            this.Controls.Add(this.NumericQuantity);
            this.Controls.Add(this.LabelImage);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.PanelDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LabelValue);
            this.Controls.Add(this.NumericValue);
            this.Controls.Add(this.LabelPromotionPercentage);
            this.Controls.Add(this.NumericPromotionPercentage);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.PanelName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelCategory);
            this.Controls.Add(this.ComboBoxCategory);
            this.Controls.Add(this.GroupBoxPreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProductAdd";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto – Novo";
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
        private System.Windows.Forms.Label LabelCategory;
        private System.Windows.Forms.ComboBox ComboBoxCategory;
        private System.Windows.Forms.Panel PanelName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label LabelPromotionPercentage;
        private System.Windows.Forms.NumericUpDown NumericPromotionPercentage;
        private System.Windows.Forms.CheckBox CheckBoxPromotion;
        private System.Windows.Forms.Label LabelValue;
        private System.Windows.Forms.NumericUpDown NumericValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel PanelDescription;
        private System.Windows.Forms.TextBox TextBoxDescription;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Label LabelImage;
        private System.Windows.Forms.Label LabelQuantity;
        private System.Windows.Forms.NumericUpDown NumericQuantity;
    }
}