using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLNH.CoSo;
 

namespace QLNH.DanhMuc
{
    public partial class FrmDm_CustomerType_Detail : FrmEditDetail
    {
    
        public FrmDm_CustomerType_Detail(NHMain nhmain, DataSet dataset, string nametable, bool isnew, int pos)
            : base(nhmain, nametable, dataset, pos, isnew)
        {
            InitializeComponent();
            BinControls();
            SetControls();
        }
        public override void BinControls()
        {
            this.txtMaLoaiKhach.DataBindings.Add("Text", this.DataSet, this.NameTable + ".CUSTOMER_TYPE_ID");
            this.txtTenLoaiKhach.DataBindings.Add("Text", this.DataSet, this.NameTable + ".CUSTOMER_TYPE_NAME");
        }
    }

}
