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
using QLNH.DanhMuc;
using DevExpress.XtraGrid.Columns;

namespace QLNH.BanHang
{
    public partial class FrmSale : FrmTransaction
    {
        public FrmSale()
        {
            InitializeComponent();
        }

        public FrmSale(NHMain nhmain, DataSet dataset, string nametable, string nametable_n, double pr_key)
            : base(nhmain, dataset, nametable, nametable_n, pr_key)
        {
            InitializeComponent();
            LoadDm();
            //LoadDataByPr_Key(pr_key);
            this.BindGrid();
            SetControls();
            this.BindHearderControls();
            //AddColumns();
        }
        public FrmSale(NHMain nhmain, DataSet dataset, string nametable, string nametable_n, bool isnew)
            : base(nhmain, dataset, nametable, nametable_n, isnew)
        {
            InitializeComponent();

            this.BindGrid();
            SetControls();
            this.BindHearderControls();
            if (NHMain.UserInfo != null)
                this.txtUser_Id.TextBoxEdit.EditValue = NHMain.UserInfo.User_Id;
            this.txtUser_Id.Enabled = false;
            this.txtTranDate.Enabled = false;
        }
        public override void BindHearderControls()
        {
            this.txtTranNo.TextBoxEdit.DataBindings.Add("EditValue", this.DataSet, this.NameTable_1 + ".TRAN_NO");
            this.txtUser_Id.TextBoxEdit.DataBindings.Add("EditValue", this.DataSet, this.NameTable_1 + ".USER_ID");
            this.txtTranDate.DateEdit.DataBindings.Add("EditValue", this.DataSet, this.NameTable_1 + ".TRAN_DATE");
            this.txtComment.TextBoxEdit.DataBindings.Add("EditValue", this.DataSet, this.NameTable_1 + ".COMMENT");
            this.cboCustomer_id.ComboBoxEdit.DataBindings.Add("EditValue", this.DataSet, this.NameTable_1 + ".CUSTOMER_ID");
            this.cboExportType_Id.ComboBoxEdit.DataBindings.Add("EditValue", this.DataSet, this.NameTable_1 + ".EXPORT_TYPE_ID");
            this.cboPayType_Id.ComboBoxEdit.DataBindings.Add("EditValue", this.DataSet, this.NameTable_1 + ".PAY_TYPE_ID");
            this.cboTable_Id.ComboBoxEdit.DataBindings.Add("EditValue", this.DataSet, this.NameTable_1 + ".TABLE_ID");
            this.txtCus_Tra.SpinEdit.DataBindings.Add("EditValue", this.DataSet, this.NameTable_1 + ".TOTAL_CUSTOMER_PAY");
            this.ckPro.DataBindings.Add("EditValue", this.DataSet, this.NameTable_1 + ".IS_PROVISIONAL");
        }
        public override void LoadDataByPr_Key(double pr_key)
        {
            try
            {
                if (this.DataSet.Tables.IndexOf(NameTable_1) >= 0) this.DataSet.Tables.Remove(NameTable_1);
                if (this.DataSet.Tables.IndexOf(NameTable_n) >= 0) this.DataSet.Tables.Remove(NameTable_n);
                this.DataSet.Tables.Add(this.NHMain.GetDataByQuery("select * from " + NameTable_1 + " where PR_KEY = " + pr_key, NameTable_1));
                this.DataSet.Tables.Add(this.NHMain.GetDataByQuery("select " + NameTable_n + ".*, ITEM_NAME from " + NameTable_n + " INNER JOIN DM_ITEM ON " + NameTable_n + ".ITEM_ID = DM_ITEM.ITEM_ID where FR_KEY = " + pr_key, NameTable_n));
                this.DataTable = this.DataSet.Tables[NameTable_1];
                this.DataTable.TableName = NameTable_1;
                this.DataTable_n = this.DataSet.Tables[NameTable_n];
                this.DataTable_n.TableName = NameTable_n;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public override void SetControls()
        {
            this.cboCustomer_id.SetData(NHMain, "", this.DataSet.Tables["DM_CUSTOMERS"], "CUSTOMER_ID", "CUSTOMER_NAME", ComboBoxTypeView.NameID);
            this.cboCustomer_id.FrmDetail = new FrmDm_Custumer_List(NHMain);
            this.cboExportType_Id.SetData(NHMain, "", this.DataSet.Tables["DM_EXPORT_TYPE"], "EXPORT_TYPE_ID", "EXPORT_TYPE_NAME", ComboBoxTypeView.NameID);
            this.cboExportType_Id.FrmDetail = new FrmDm_ExportType_List(NHMain);
            this.cboPayType_Id.SetData(NHMain, "", this.DataSet.Tables["DM_PAY_TYPE"], "PAY_TYPE_ID", "PAY_TYPE_NAME", ComboBoxTypeView.NameID);
            this.cboPayType_Id.FrmDetail = new FrmDm_Pay_List(NHMain);
            this.cboTable_Id.SetData(NHMain, "", this.DataSet.Tables["DM_TABLES"], "TABLE_ID", "TABLE_NAME", ComboBoxTypeView.NameID);
            this.cboTable_Id.FrmDetail = new FrmDm_Table_List(NHMain);
        }
        public override void LoadDm()
        {
            try
            {
                if (this.DataSet.Tables.IndexOf("DM_EXPORT_TYPE") >= 0) this.DataSet.Tables.Remove("DM_EXPORT_TYPE");
                if (this.DataSet.Tables.IndexOf("DM_PAY_TYPE") >= 0) this.DataSet.Tables.Remove("DM_PAY_TYPE");
                if (this.DataSet.Tables.IndexOf("DM_CUSTOMERS") >= 0) this.DataSet.Tables.Remove("DM_CUSTOMERS");
                if (this.DataSet.Tables.IndexOf("DM_TABLES") >= 0) this.DataSet.Tables.Remove("DM_TABLES");
                if (this.DataSet.Tables.IndexOf("DM_ITEM") >= 0) this.DataSet.Tables.Remove("DM_ITEM");
                this.DataSet.Tables.Add(NHMain.GetDataByQuery("select * from DM_EXPORT_TYPE", "DM_EXPORT_TYPE"));
                this.DataSet.Tables.Add(NHMain.GetDataByQuery("select * from DM_PAY_TYPE", "DM_PAY_TYPE"));
                this.DataSet.Tables.Add(NHMain.GetDataByQuery("select * from DM_CUSTOMERS", "DM_CUSTOMERS"));
                this.DataSet.Tables.Add(NHMain.GetDataByQuery("select * from DM_TABLES", "DM_TABLES"));
                this.DataSet.Tables.Add(NHMain.GetDataByQuery("select * from DM_ITEM", "DM_ITEM"));
                this.DataSet.Tables["DM_ITEM"].PrimaryKey = new[] { this.DataSet.Tables["DM_ITEM"].Columns["ITEM_ID"] };
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public override void GridChanged(DevExpress.XtraGrid.Columns.GridColumn column, object value)
        {
            switch (column.FieldName)
            {
                case "ITEM_ID":
                    DataRow dr = this.DataSet.Tables["DM_ITEM"].Rows.Find(value);
                    if (dr == null)
                    {
                        FrmDm_Item_List f = new FrmDm_Item_List(NHMain);
                        f.isSelect = true;
                        f.ShowDialog();
                       DataRow d =  this.gridView1.GetFocusedDataRow();
                       d["ITEM_ID"] = f.GetDataRow()["ITEM_ID"];
                       try
                       {
                       d["ITEM_NAME"] = f.GetDataRow()["ITEM_NAME"];
                       }
                       catch
                       {
                       }

                    }
                    break;
                default:
                    break;
            }
        }
        void AddColumns()
        {
            GridColumn c = new GridColumn();
            c.Name = "ITEM_NAME";
            c.FieldName = "ITEM_NAME";
            c.Caption = "Tên món";
            c.BestFit();
            c.Visible = true;
            c.VisibleIndex = 3;
            this.gridView1.Columns.Add(c);
        }
    }
}
