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
    public partial class FrmDm_Parts_List : FrmDataList
    {
        public FrmDm_Parts_List(NHMain nhmain)
            : base(nhmain, "DM_PARTS")
        {
            InitializeComponent();
        }
        public override void EditRecord()
        {
            this.FrmEditDetail = new FrmDm_Parts_Detail(NHMain, this.DataSet, "DM_PARTS", false, this.DataSet.Tables[NameTable].Rows.IndexOf(this.GetDataRow()));
            this.FrmEditDetail.isNew = false;
            this.FrmEditDetail.ShowDialog();
        }
        public override void NewRecord()
        {
            this.FrmEditDetail = new FrmDm_Parts_Detail(NHMain, this.DataSet, "DM_PARTS", true, 0);
            this.FrmEditDetail.ShowDialog();
        }
    }
}
