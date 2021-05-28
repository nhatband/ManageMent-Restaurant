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
    public partial class FrmDmSale_Price_Detail : FrmEditDetail
    {
        public FrmDmSale_Price_Detail(NHMain nhmain, DataSet dataset, string nametable, bool isnew, int pos)
            : base(nhmain, nametable, dataset, pos, isnew)
        {
            InitializeComponent();
            LoadDm();
            BinControls();
            SetControls();
        }
        public override void BinControls()
        {
            this.txtMaPhieu.TextBoxEdit.DataBindings.Add("Text", this.DataSet, this.NameTable + ".PR_KEY");
            this.cboImplyess_Id.ComboBoxEdit.DataBindings.Add("EditValue", this.DataSet, this.NameTable + ".ITEM_ID");
            this.txtGia.TextBoxEdit.DataBindings.Add("Text", this.DataSet, this.NameTable + ".PRICE");
            this.iCdlValidDate.DateEdit.DataBindings.Add("EditValue", this.DataSet, this.NameTable + ".VALID_DATE");
            this.cboNhanVien.ComboBoxEdit.DataBindings.Add("EditValue", this.DataSet, this.NameTable + ".USER_ID");
            this.chkActive.DataBindings.Add("EditValue", this.DataSet, this.NameTable + ".ACTIVE");
        }
        public override void SetControls()
        {
            this.cboImplyess_Id.SetData(NHMain, "", this.DataSet.Tables["DM_ITEM"], "ITEM_ID", "ITEM_NAME", ComboBoxTypeView.NameID);
            this.cboImplyess_Id.FrmDetail = new FrmDm_Item_List(NHMain);
            this.cboNhanVien.SetData(NHMain, "", this.DataSet.Tables["DM_EMPLOYEES"], "USER_ID", "USER_NAME", ComboBoxTypeView.NameID);
            this.cboNhanVien.FrmDetail = new FrmDm_Employees_List(NHMain);

        }
        public override void LoadDm()
        {
            try
            {
                if (this.DataSet.Tables.IndexOf("DM_ITEM") > 0) this.DataSet.Tables.Remove("DM_ITEM");
                if (this.DataSet.Tables.IndexOf("DM_EMPLOYEES") > 0) this.DataSet.Tables.Remove("DM_EMPLOYEES");

                this.DataSet.Tables.Add(NHMain.GetDataByQuery("select * from DM_ITEM", "DM_ITEM"));
                this.DataSet.Tables.Add(NHMain.GetDataByQuery("select * from DM_EMPLOYEES", "DM_EMPLOYEES"));
             
            }
            catch
            {
            }

        }
    }
}
