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
    public partial class FrmDm_Item_Detail : FrmEditDetail
    {
        public FrmDm_Item_Detail(NHMain nhmain, DataSet dataset, string nametable, bool isnew, int pos)
            : base(nhmain, nametable, dataset, pos, isnew)
        {
            InitializeComponent();
            LoadDm();
            BinControls();
            SetControls();
        }
        public override void BinControls()
        {
            this.txtItem_Id.DataBindings.Add("Text", this.DataSet, this.NameTable + ".ITEM_ID");
            this.txtItem_Name.DataBindings.Add("Text", this.DataSet, this.NameTable + ".ITEM_NAME");
            this.chkActive.DataBindings.Add("EditValue", this.DataSet, this.NameTable + ".ACTIVE");
            this.cboItem_Class_Id.ComboBoxEdit.DataBindings.Add("EditValue", this.DataSet, this.NameTable + ".ITEM_CLASS_ID");
            this.cboUnit_Id.ComboBoxEdit.DataBindings.Add("EditValue", this.DataSet, this.NameTable + ".UNIT_ID");
            this.cboVat_Id.ComboBoxEdit.DataBindings.Add("EditValue", this.DataSet, this.NameTable + ".VAT_TAX_ID");
        }
        public override void SetControls()
        {
            this.cboItem_Class_Id.SetData(NHMain, "", this.DataSet.Tables["DM_ITEM_CLASS"], "ITEM_CLASS_ID", "ITEM_CLASS_NAME", ComboBoxTypeView.NameID);
            this.cboItem_Class_Id.FrmDetail = new FrmDm_Item_Class_List(NHMain);
            this.cboUnit_Id.SetData(NHMain, "", this.DataSet.Tables["DM_UNIT"], "UNIT_ID", "UNIT_NAME", ComboBoxTypeView.NameID);
            this.cboUnit_Id.FrmDetail = new FrmDm_Unit_List(NHMain);
            this.cboVat_Id.SetData(NHMain, "", this.DataSet.Tables["DM_VAT_TAX"], "VAT_TAX_ID", "VAT_TAX_NAME", ComboBoxTypeView.NameID);
            this.cboVat_Id.FrmDetail = new FrmDm_Vat_Tax_List(NHMain);
        }
        public override void LoadDm()
        {
            try
            {

                if (this.DataSet.Tables.IndexOf("DM_ITEM_CLASS") >= 0) this.DataSet.Tables.Remove("DM_ITEM_CLASS");
                if (this.DataSet.Tables.IndexOf("DM_UNIT") >= 0) this.DataSet.Tables.Remove("DM_UNIT");
                if (this.DataSet.Tables.IndexOf("DM_VAT_TAX") >= 0) this.DataSet.Tables.Remove("DM_VAT_TAX");
                this.DataSet.Tables.Add(NHMain.GetDataByQuery("select * from DM_ITEM_CLASS", "DM_ITEM_CLASS"));
                this.DataSet.Tables.Add(NHMain.GetDataByQuery("select * from DM_UNIT", "DM_UNIT"));
                this.DataSet.Tables.Add(NHMain.GetDataByQuery("select * from DM_VAT_TAX", "DM_VAT_TAX"));
            }
            catch
            {
            }

        }
    }
}
