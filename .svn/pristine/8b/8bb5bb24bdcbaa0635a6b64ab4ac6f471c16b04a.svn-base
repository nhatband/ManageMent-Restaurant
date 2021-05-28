using System;
using System.Data;
using System.Windows.Forms;

namespace QLNH.CoSo
{
    public partial class FrmEditDetail : Form
    {
        public NHMain NHMain;
        public DataTable DataTable;
        public DataSet DataSet;
        public DataRow DataRow;
        public string NameTable;
        public bool isNew = false;
        private BindingManagerBase bMgr;
        public FrmEditDetail()
        {
            InitializeComponent();
        }
        public FrmEditDetail(NHMain nhmain, string nametable, DataSet dataset, int postion, bool isnew)
        {
            isNew = isnew;
            NHMain = nhmain;
            NameTable = nametable;
            this.DataSet = dataset;
            this.DataTable = this.DataSet.Tables[NameTable];
            //LoadData();
            InitializeComponent();
            try
            {
                if (isnew)
                {
                    DataRow = this.DataSet.Tables[NameTable].NewRow();
                    DataTable dt = NHMain.GetTables(NameTable);
                    foreach (DataRow item in dt.Rows)
                    {
                        if (item["NameTP"].Equals("smallint") || item["NameTP"].Equals("int")
                            || item["NameTP"].Equals("bigint") || item["NameTP"].Equals("money"))
                            DataRow[item["nameCL"].ToString()] = 0;
                        if (item["NameTP"].Equals("smalldatetime") || item["NameTP"].Equals("date") ||
                            item["NameTP"].Equals("datetime"))
                            DataRow[item["nameCL"].ToString()] = DateTime.Now.ToShortDateString();
                    }
                    bMgr = this.BindingContext[dataset, nametable];
                    this.DataSet.Tables[nametable].Rows.Add(DataRow);
                    bMgr.Position = this.DataSet.Tables[nametable].Rows.Count - 1;
                }
                else
                {
                    bMgr = this.BindingContext[DataSet, nametable];
                    bMgr.Position = postion;
                }
            }
            catch
            {
            }

        }
        public FrmEditDetail(NHMain nhmain, string nametable)
        {
            NHMain = nhmain;
            NameTable = nametable;
            this.DataSet = new System.Data.DataSet();
            LoadData();
            InitializeComponent();
            //SetControl();
        }
        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        public virtual void EndEdit()
        {
            foreach (Control item in this.Controls)
            {
                if (!item.ContainsFocus)
                {
                    item.Select();
                    break;
                }
            }
            bMgr = this.BindingContext[this.DataSet, this.NameTable];
            bMgr.EndCurrentEdit();
        }
        public virtual void SaveRecord()
        {
            try
            {
                this.EndEdit();
                if (this.NHMain.WorkingMode != WorkingMode.Offline)
                    if (!isNew)
                    {
                        string listsql = string.Empty;
                        foreach (DataRow item in this.DataSet.Tables[NameTable].Rows)
                        {
                            if (item.RowState == DataRowState.Modified)
                            {
                                listsql += NHMain.UpdateTo(NameTable, item, "");
                            }
                        }
                        if (listsql != "")
                        {
                            NHMain.ExecuteNonQuery(listsql);
                            int index = 0;
                            NHMain.Xml = new XmlExecute(NHMain, this.DataSet.Tables[NameTable]);
                            NHMain.Xml.NameTable = NameTable;
                            foreach (DataRow item in this.DataSet.Tables[NameTable].Rows)
                            {
                                if (item.RowState == DataRowState.Modified)
                                {
                                    NHMain.Xml.Edit(item, index, NHMain.ColumnPrimaryKey(NameTable));
                                    index++;
                                }
                            }
                        }
                    }
                    else
                    {
                        //this.DataTable.AcceptChanges();
                        NHMain.ExecuteNonQuery(NHMain.InsertTo(NameTable, this.DataSet.Tables[NameTable].Rows[bMgr.Position]));
                        NHMain.Xml = new XmlExecute(NHMain, this.DataSet.Tables[NameTable]);
                        NHMain.Xml.NameTable = NameTable;
                        foreach (DataRow item in this.DataSet.Tables[NameTable].Rows)
                        {
                            if (item.RowState == DataRowState.Added)
                            {
                                NHMain.Xml.AddNew(item);
                            }
                        }
                    }
                else
                    if (!isNew)
                    {
                        string listsql = string.Empty;
                        //int index = 0;
                        NHMain.Xml = new XmlExecute(NHMain, this.DataSet.Tables[NameTable]);
                        NHMain.Xml.Save();
                        //foreach (DataRow item in this.DataSet.Tables[NameTable].Rows)
                        //{
                        //    if (item.RowState == DataRowState.Modified || item.RowState == DataRowState.Added)
                        //    {
                        //        NHMain.Xml.Edit(item, index);
                        //        index++;
                        //    }
                        //}
                    }
                    else
                    {
                        this.DataSet.Tables[NameTable].WriteXml(NHMain.StartUpPath + "//XmlData//" + NameTable + ".xml");
                        foreach (DataRow item in this.DataSet.Tables[NameTable].Rows)
                        {
                            if (item.RowState == DataRowState.Added)
                            {
                                NHMain.Xml.AddNew(item);
                            }
                        }

                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public virtual void SetControls()
        {

        }
        public virtual void BinControls()
        {

        }
        public virtual void LoadDm()
        {

        }
        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveRecord();
        }
        public virtual void LoadData()
        {
            try
            {
                LoadDm();
                if (NHMain.WorkingMode == WorkingMode.Online)
                {
                    this.DataSet.Tables.Add(this.NHMain.GetDataByQuery("select * from " + NameTable, NameTable));
                    this.DataTable = this.DataSet.Tables[NameTable];
                }
                else
                {
                    NHMain.Xml = new XmlExecute(NHMain, NameTable);
                    this.DataTable = NHMain.Xml.DataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btnNap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadDm();
            SetControls();
        }

        private void btnSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.SaveRecord();
            this.Close();
        }
    }
}
