using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLNH.CoSo;
using System.Windows.Forms.Integration;

namespace QLNH.HeThong
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        NHMain NHMain;
        public FrmLogin(NHMain nhmain)
        {
            NHMain = nhmain;
            InitializeComponent();
            this.uLogin1.CreateConstruct(NHMain);
            this.uLogin1.Visibility = System.Windows.Visibility.Visible;
            this.uLogin1.IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(uLogin1_IsVisibleChanged);
        }

        void uLogin1_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            //if (e.NewValue == "false")
            //    this.Close();
        }

        private void elementHost1_ChildChanged(object sender, ChildChangedEventArgs e)
        {

        }

    }
}
