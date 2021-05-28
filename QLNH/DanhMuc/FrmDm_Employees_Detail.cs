using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLNH.CauTruc;
using QLNH.CoSo;

namespace QLNH.DanhMuc
{
    public partial class FrmDm_Employees_Detail : FrmEditDetail
    {
        public FrmDm_Employees_Detail(NHMain nhmain, DataSet dataset, string nametable, bool isnew, int pos)
            : base(nhmain, nametable, dataset, pos, isnew)
        {
            InitializeComponent();
            LoadDm();
            BinControls();
            SetControls();
        }
        public override void BinControls()
        {
            this.txtMaNV.DataBindings.Add("Text", this.DataSet, this.NameTable + ".USER_ID");
            this.txtTenNV.DataBindings.Add("Text", this.DataSet, this.NameTable + ".USER_NAME");
            this.txtMaCapBac.ComboBoxEdit.DataBindings.Add("EditValue", this.DataSet, this.NameTable + ".LEVEL_ID");
            this.txtSDT.DataBindings.Add("Text", this.DataSet, this.NameTable + ".PHONE");
            this.txtSoCMT.DataBindings.Add("Text", this.DataSet, this.NameTable + ".PASSPORT");
            this.txtMatKhau.DataBindings.Add("Text", this.DataSet, this.NameTable + ".PASSWORD");
            this.chkActive.DataBindings.Add("Checked", this.DataSet, this.NameTable + ".IS_ONLINE");
        }

        public override void SetControls()
        {
            this.txtMaCapBac.SetData(NHMain, "", this.DataSet.Tables["DM_LEVELS"], "LEVEL_ID", "LEVEL_NAME", ComboBoxTypeView.NameID);
            this.txtMaCapBac.FrmDetail = new FrmDm_CustomerType_List(NHMain);
        }
        public override void LoadDm()
        {
            if (this.DataSet.Tables.IndexOf("DM_LEVELS") > 0) this.DataSet.Tables.Remove("DM_LEVELS");
            this.DataSet.Tables.Add(NHMain.GetDataByQuery("select * from DM_LEVELS", "DM_LEVELS"));
        }
    }
}
