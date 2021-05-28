using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using QLNH.CoSo;

namespace QLNH.CauTruc
{

    public partial class iCandenla : UserControl
    {
       
        public NHMain NHMain;
        public iCandenla()
        {
            InitializeComponent();
        }
        public iCandenla(NHMain nhmain)
        {
            NHMain = nhmain;
            InitializeComponent();
        }
        [DefaultValue(80)]
        public int LabelLengh
        {
            get { return this.Label.Width; }
            set { this.Label.Width = value; }
        }
        [DefaultValue(80)]
        public int TextLengh
        {
            get { return this.TextBox.Width; }
            set { this.TextBox.Width = value; }
        }
        public string Caption
        {
            get { return this.Label.Text; }
            set { this.Label.Text = value; }
        }
        public DateEdit DateEdit
        {
            get { return this.TextBox; }
            set { this.TextBox = value; }
        }
        
        private void lookUp_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void lookUp_Leave(object sender, EventArgs e)
        {
            
        }

        public void EndEdit()
        {
            if (this.TextBox.DataBindings.Count > 0)
            {
                this.Label.Select();
                this.TextBox.DataBindings[0].BindingManagerBase.EndCurrentEdit();
            }
        }
    }
}
