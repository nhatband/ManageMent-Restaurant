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
    public partial class FrmDm_Warehouses_List : FrmDataList
    {
        public FrmDm_Warehouses_List(NHMain nhmain)
            : base(nhmain, "DM_WAREHOUSES")
        {
            InitializeComponent();
        }
        public override void EditRecord()
        {
            try
            {
                this.FrmEditDetail = new FrmDm_Warehouses_Detail(NHMain, this.DataSet, "DM_WAREHOUSES", false, this.DataSet.Tables[NameTable].Rows.IndexOf(this.GetDataRow()));
                this.FrmEditDetail.isNew = false;
                this.FrmEditDetail.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }

        }
        public override void NewRecord()
        {
            this.FrmEditDetail = new FrmDm_Warehouses_Detail(NHMain, this.DataSet, "DM_WAREHOUSES", true, 0);
            this.FrmEditDetail.ShowDialog();
        }
    }
}
