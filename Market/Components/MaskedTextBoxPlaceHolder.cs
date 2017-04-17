using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop.Components {

    public partial class MaskedTextBoxPlaceHolder : MaskedTextBox {

        public string PlaceHolderText { get; set; }
        public bool IsPassword { get; set; }

        private string mask { get; set; }

        public string TextOnly {

            get {
                return base.Text.Equals(PlaceHolderText) ? "" : base.Text;
            }

        }

        public MaskedTextBoxPlaceHolder() {
            InitializeComponent();
        }

        protected override void OnCreateControl() {
            base.OnCreateControl();

            if (!this.DesignMode) {

                mask = String.Copy(Mask);

                base.UseSystemPasswordChar = false;
                base.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                Mask = String.Empty;

                if (base.Text.Equals("") || base.Text.Equals(PlaceHolderText)) {

                    base.Text = PlaceHolderText;
                    base.ForeColor = System.Drawing.SystemColors.ControlDark;

                    if (IsPassword) {
                        base.PasswordChar = '\0';
                    }

                } else {

                    if (IsPassword) {
                        base.PasswordChar = '*';
                    }

                }

            }

        }

        protected override void OnPaint(PaintEventArgs pe) {
            base.OnPaint(pe);
        }

        protected override void OnEnter(EventArgs e) {
            base.OnEnter(e);

            if (base.Text.Equals(PlaceHolderText)) {

                if (IsPassword) {
                    base.PasswordChar = '*';
                }

                base.Mask = mask;
                base.Text = "";
                base.ForeColor = System.Drawing.SystemColors.WindowText;

            }

        }

        protected override void OnLeave(EventArgs e) {
            base.OnLeave(e);

            if (base.Text.Equals("")) {

                if (IsPassword) {
                    base.PasswordChar = '\0';
                }

                base.Mask = String.Empty;
                base.Text = PlaceHolderText;
                base.ForeColor = System.Drawing.SystemColors.ControlDark;

            }

        }

    }
}
