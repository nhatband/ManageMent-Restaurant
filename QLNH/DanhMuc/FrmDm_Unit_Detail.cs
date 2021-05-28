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
    public partial class FrmDm_Unit_Detail : FrmEditDetail
    {
        public FrmDm_Unit_Detail(NHMain nhmain, DataSet dataset, string nametable, bool isnew, int pos)
            : base(nhmain, nametable, dataset, pos, isnew)
        {
            InitializeComponent();
            BinControls();
            SetControls();
        }
        public override void BinControls()
        {
            this.txtUnit_Id.DataBindings.Add("Text", this.DataSet, this.NameTable + ".UNIT_ID");
            this.txtUnit_Name.DataBindings.Add("Text", this.DataSet, this.NameTable + ".UNIT_NAME");
        }

        
    }
}
