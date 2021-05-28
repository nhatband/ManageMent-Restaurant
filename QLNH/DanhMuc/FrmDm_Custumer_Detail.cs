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
    public partial class FrmDm_Custumer_Detail : FrmEditDetail
    {
        public FrmDm_Custumer_Detail(NHMain nhmain, DataSet dataset, string nametable, bool isnew, int pos)
            : base(nhmain, nametable, dataset, pos, isnew)
        {
            InitializeComponent();
            LoadDm();
            BinControls();
            SetControls();
        }
        public override void BinControls()
        {
            this.txtMaKhach.DataBindings.Add("Text", this.DataSet, this.NameTable + ".CUSTOMER_ID");
            this.txtTenKhach.DataBindings.Add("Text", this.DataSet, this.NameTable + ".CUSTOMER_NAME");
            this.txtDiaChi.DataBindings.Add("Text", this.DataSet, this.NameTable + ".ADDRESS");
            this.txtSoDT.DataBindings.Add("Text", this.DataSet, this.NameTable + ".PHONE");
            this.txtSoGhiNo.DataBindings.Add("Text", this.DataSet, this.NameTable + ".CREDIT_CARD");
            this.cboLoaiKhach.ComboBoxEdit.DataBindings.Add("EditValue", this.DataSet, this.NameTable + ".CUSTOMER_TYPE_ID");
            this.cboLoaiTT.ComboBoxEdit.DataBindings.Add("EditValue", this.DataSet, this.NameTable + ".PAY_TYPE_ID");
        }
        public override void SetControls()
        {
            this.cboLoaiTT.SetData(NHMain, "", this.DataSet.Tables["DM_PAY_TYPE"], "PAY_TYPE_ID", "PAY_TYPE_NAME", ComboBoxTypeView.NameID);
            this.cboLoaiKhach.SetData(NHMain, "", this.DataSet.Tables["DM_CUSTOMER_TYPE"], "CUSTOMER_TYPE_ID", "CUSTOMER_TYPE_NAME", ComboBoxTypeView.NameID);
            this.cboLoaiTT.FrmDetail = new FrmDm_Pay_List(NHMain);
            this.cboLoaiKhach.FrmDetail = new FrmDm_CustomerType_List(NHMain);
        }
        public override void LoadDm()
        {
            if (this.DataSet.Tables.IndexOf("DM_CUSTOMER_TYPE") > 0) this.DataSet.Tables.Remove("DM_CUSTOMER_TYPE");
            if (this.DataSet.Tables.IndexOf("DM_PAY_TYPE") > 0) this.DataSet.Tables.Remove("DM_PAY_TYPE");
            this.DataSet.Tables.Add(NHMain.GetDataByQuery("select * from DM_CUSTOMER_TYPE", "DM_CUSTOMER_TYPE"));
            this.DataSet.Tables.Add(NHMain.GetDataByQuery("select * from DM_PAY_TYPE", "DM_PAY_TYPE"));
        }
    }
}
