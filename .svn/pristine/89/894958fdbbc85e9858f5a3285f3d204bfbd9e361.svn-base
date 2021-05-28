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
    public partial class FrmDm_Vat_Tax_List : FrmDataList
    {
        public FrmDm_Vat_Tax_List(NHMain nhmain)
            : base(nhmain, "DM_VAT_TAX")
        {
            InitializeComponent();
        }
        public override void EditRecord()
        {
            this.FrmEditDetail = new FrmDm_Vat_Tax_Detail(NHMain, this.DataSet, "DM_VAT_TAX", false, this.DataSet.Tables[NameTable].Rows.IndexOf(this.GetDataRow()));
            this.FrmEditDetail.isNew = false;
            this.FrmEditDetail.ShowDialog();
        }
        public override void NewRecord()
        {
            this.FrmEditDetail = new FrmDm_Vat_Tax_Detail(NHMain, this.DataSet, "DM_VAT_TAX", true, 0);
            this.FrmEditDetail.ShowDialog();
        }
    }
}
