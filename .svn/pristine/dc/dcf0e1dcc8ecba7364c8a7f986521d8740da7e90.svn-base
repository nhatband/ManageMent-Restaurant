using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLNH.CoSo;

namespace QLNH.BanHang
{
    public partial class FrmSale_Price_Nearest_List : FrmDataList
    {
        public FrmSale_Price_Nearest_List(NHMain nhmain)
            : base(nhmain, "SALE_PRICE_NEAREST_VIEW")
        {
            InitializeComponent();
        }
        public override void PrintRecord()
        {
            this.NHMain.Xml = new XmlExecute(NHMain, NameTable);
            base.PrintRecord();
        }
    }
}
