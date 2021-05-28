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
    public partial class FrmDm_Parts_Detail : FrmEditDetail
    {
        public FrmDm_Parts_Detail(NHMain nhmain, DataSet dataset, string nametable, bool isnew, int pos)
            : base(nhmain, nametable, dataset, pos, isnew)
        {
            InitializeComponent();
            BinControls();
            SetControls();
        }
        public override void BinControls()
        {
            this.txtPart_Id.DataBindings.Add("Text", this.DataSet, this.NameTable + ".PART_ID");
            this.txtPart_Name.DataBindings.Add("Text", this.DataSet, this.NameTable + ".PART_NAME");
            this.txtTo_Time.DataBindings.Add("Text", this.DataSet, this.NameTable + ".TO_TIME");
            this.txtFrom_Time.DataBindings.Add("Text", this.DataSet, this.NameTable + ".FROM_TIME");
        }
    }
}
