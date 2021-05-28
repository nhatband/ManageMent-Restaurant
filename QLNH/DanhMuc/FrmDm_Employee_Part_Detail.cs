using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLNH.CoSo;
using QLNH.CauTruc;

namespace QLNH.DanhMuc
{
    public partial class FrmDm_Employee_Part_Detail : FrmEditDetail
    {
        public FrmDm_Employee_Part_Detail(NHMain nhmain, DataSet dataset, string nametable, bool isnew, int pos)
            : base(nhmain, nametable, dataset, pos, isnew)
        {
            InitializeComponent();
            LoadDm();
            BinControls();
            SetControls();
        }
        public override void BinControls()
        {
            this.cboImplyess_Id.ComboBoxEdit.DataBindings.Add("EditValue", this.DataSet, this.NameTable + ".USER_ID");
            this.cboPartword_Id.ComboBoxEdit.DataBindings.Add("EditValue", this.DataSet, this.NameTable + ".PART_ID");
            this.txtGhiChu.DataBindings.Add("Text", this.DataSet, this.NameTable + ".COMMENT");
            this.iCdlStartTime.DateEdit.DataBindings.Add("EditValue", this.DataSet, this.NameTable + ".START_TIME");
            this.iCdlEndTime.DateEdit.DataBindings.Add("EditValue", this.DataSet, this.NameTable + ".END_TIME");
        }

        public override void SetControls()
        {
            this.cboImplyess_Id.SetData(NHMain, "", this.DataSet.Tables["DM_EMPLOYEES"], "USER_ID", "USER_NAME", ComboBoxTypeView.NameID);
            this.cboImplyess_Id.FrmDetail = new FrmDm_Employees_List(NHMain);
            this.cboPartword_Id.SetData(NHMain, "", this.DataSet.Tables["DM_PARTS"], "PART_ID", "PART_NAME", ComboBoxTypeView.NameID);
            this.cboPartword_Id.FrmDetail = new FrmDm_Parts_List(NHMain);
             
        }
        public override void LoadDm()
        {
            try
            {
                if (this.DataSet.Tables.IndexOf("DM_EMPLOYEES") > 0) this.DataSet.Tables.Remove("DM_EMPLOYEES");
                if (this.DataSet.Tables.IndexOf("DM_PARTS") > 0) this.DataSet.Tables.Remove("DM_PARTS");

                this.DataSet.Tables.Add(NHMain.GetDataByQuery("select * from DM_EMPLOYEES", "DM_EMPLOYEES"));
                this.DataSet.Tables.Add(NHMain.GetDataByQuery("select * from DM_PARTS", "DM_PARTS"));

            }
            catch
            {
            }

        }
    }
}
