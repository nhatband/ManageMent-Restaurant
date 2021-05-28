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
    public partial class FrmDm_Employees_List : FrmDataList
    {
        public FrmDm_Employees_List(NHMain nhmain)
            : base(nhmain, "DM_EMPLOYEES")
        {
            InitializeComponent();
        }
        public override void EditRecord()
        {
            try
            {
                this.FrmEditDetail = new FrmDm_Employees_Detail(NHMain, this.DataSet, "DM_EMPLOYEES", false, this.DataSet.Tables[NameTable].Rows.IndexOf(this.GetDataRow()));
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
            this.FrmEditDetail = new FrmDm_Employees_Detail(NHMain, this.DataSet, "DM_EMPLOYEES", true, 0);
            this.FrmEditDetail.ShowDialog();
        }
        public override void PrintRecord()
        {
            this.NHMain.Xml = new XmlExecute(NHMain, NameTable);
            base.PrintRecord();
        }
    }

}
