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
    public partial class FrmDm_ExportType_List : FrmDataList
    {
        public FrmDm_ExportType_List(NHMain nhmain)
            : base(nhmain, "DM_EXPORT_TYPE")
        {
            InitializeComponent();
        }

        public override void EditRecord()
        {
            this.FrmEditDetail = new FrmDm_ExportType_Detail(NHMain, this.DataSet, "DM_EXPORT_TYPE", false, this.DataSet.Tables[NameTable].Rows.IndexOf(this.GetDataRow()));
            this.FrmEditDetail.isNew = false;
            this.FrmEditDetail.ShowDialog();
        }
        public override void NewRecord()
        {
            this.FrmEditDetail = new FrmDm_ExportType_Detail(NHMain, this.DataSet, "DM_EXPORT_TYPE", true, 0);
            this.FrmEditDetail.ShowDialog();
        }
    }
}
