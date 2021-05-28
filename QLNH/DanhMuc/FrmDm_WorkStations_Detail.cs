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
    public partial class FrmDm_WorkStations_Detail : FrmEditDetail
    {
        public FrmDm_WorkStations_Detail(NHMain nhmain, DataSet dataset, string nametable, bool isnew, int pos)
            : base(nhmain, nametable, dataset, pos, isnew)
        {
            InitializeComponent();
            BinControls();
            SetControls();
        }
        public override void BinControls()
        {
            this.txtMaChiNhanh.TextBoxEdit.DataBindings.Add("EditValue", this.DataSet, this.NameTable + ".WORKSTATION_ID");
            this.txtTenChiNhanh.TextBoxEdit.DataBindings.Add("EditValue", this.DataSet, this.NameTable + ".WORKSTATION_NAME");
            this.txtDiaChi.TextBoxEdit.DataBindings.Add("EditValue", this.DataSet, this.NameTable + ".ADDRESS");
            this.txtSDTChiNhanh.TextBoxEdit.DataBindings.Add("EditValue", this.DataSet, this.NameTable + ".PHONE");
            this.txtEmail.TextBoxEdit.DataBindings.Add("EditValue", this.DataSet, this.NameTable + ".EMAIL");
            this.cboManagerMen.ComboBoxEdit.DataBindings.Add("EditValue", this.DataSet, this.NameTable + ".MANAGER_ID");
        }
        public override void SetControls()
        {
            this.cboManagerMen.SetData(NHMain, "", this.DataSet.Tables["DM_EMPLOYEES"], "USER_ID", "USER_NAME", ComboBoxTypeView.NameID);
            this.cboManagerMen.FrmDetail = new FrmDm_Employees_List(NHMain);
        }

        public override void LoadDm()
        {
            try
            {

                if (this.DataSet.Tables.IndexOf("DM_EMPLOYEES") > 0) this.DataSet.Tables.Remove("DM_EMPLOYEES");
                this.DataSet.Tables.Add(NHMain.GetDataByQuery("select * from DM_EMPLOYEES", "DM_EMPLOYEES"));
            }
            catch
            {
            }

        }
    }
}
