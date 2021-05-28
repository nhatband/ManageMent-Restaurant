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
    public partial class FrmDm_Employee_Part_List : FrmDataList
    {
        public FrmDm_Employee_Part_List(NHMain nhmain)
            : base(nhmain, "DM_EMPLOYEE_PART")
        {
            InitializeComponent();
        }

        public override void EditRecord()
        {
            try
            {
                this.FrmEditDetail = new FrmDm_Employee_Part_Detail(NHMain, this.DataSet, "DM_EMPLOYEE_PART", false, this.DataSet.Tables[NameTable].Rows.IndexOf(this.GetDataRow()));
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
            this.FrmEditDetail = new FrmDm_Employee_Part_Detail(NHMain, this.DataSet, "DM_EMPLOYEE_PART", true, 0);
            this.FrmEditDetail.ShowDialog();

        }
    }
}
