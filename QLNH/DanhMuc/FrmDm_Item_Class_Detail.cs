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
    public partial class FrmDm_Item_Class_Detail : FrmEditDetail
    {
        public FrmDm_Item_Class_Detail(NHMain nhmain, DataSet dataset, string nametable, bool isnew, int pos)
            : base(nhmain, nametable, dataset, pos, isnew)
        {
            InitializeComponent();
            BinControls();
            SetControls();
        }
        public override void BinControls()
        {
            this.txtItem_Class_id.DataBindings.Add("Text", this.DataSet, this.NameTable + ".ITEM_CLASS_ID");
            this.txtItem_Class_Name.DataBindings.Add("Text", this.DataSet, this.NameTable + ".ITEM_CLASS_NAME");
        }
    }
}
