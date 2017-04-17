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

    public partial class ComboBoxPlaceHolder : ComboBox {

        public string PlaceHolderText { get; set; }

        public ComboBoxPlaceHolder() {
            InitializeComponent();
        }

        protected override void OnCreateControl() {
            base.OnCreateControl();

            if (!this.DesignMode) {
                base.Items.Clear();

                base.ForeColor = System.Drawing.SystemColors.ControlDark;
                base.Items.Insert(0, PlaceHolderText);
                base.SelectedIndex = 0;
            }

        }

        protected override void OnEnter(EventArgs e) {
            base.OnEnter(e);

            if (base.SelectedItem == null || base.GetItemText(base.SelectedItem).Equals(PlaceHolderText)) {
                base.Items.RemoveAt(0);
                base.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }

        protected override void OnLeave(EventArgs e) {
            base.OnLeave(e);

            if (base.SelectedItem == null || base.GetItemText(base.SelectedItem).Equals(PlaceHolderText)) {
                base.Items.Insert(0, PlaceHolderText);
                base.ForeColor = System.Drawing.SystemColors.ControlDark;
                base.SelectedIndex = 0;
            }

        }

        protected override void OnPaint(PaintEventArgs pe) {
            base.OnPaint(pe);
        }

    }
}
