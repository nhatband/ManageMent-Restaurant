using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using QLNH.CoSo;

namespace QLNH.CoSo
{
    public partial class FrmConfig : DevExpress.XtraEditors.XtraForm
    {
        public NHMain NHMain;
        public string NameTable;
        public FrmConfig(NHMain nhmain, string nametable)
        {
            NHMain = nhmain;
            NameTable = nametable;
            InitializeComponent();
            LoadData();
            addColumns();
        }
        private void addColumns()
        {
            GridColumn c = new GridColumn();
            c.FieldName = "FIELD_ID";
            c.Caption = "Cột";
            c.BestFit();
            c.Visible = true;
            this.gridView1.Columns.Add(c);
            c = new GridColumn();
            c.FieldName = "FIELD_NAME";
            c.Caption = "Tên cột";
            c.BestFit();
            c.Visible = true;
            this.gridView1.Columns.Add(c);
            c = new GridColumn();
            c.FieldName = "FIELD_TYPE";
            c.Caption = "Kiểu cột";
            c.BestFit();
            c.Visible = true;
            this.gridView1.Columns.Add(c);
            c = new GridColumn();
            c.FieldName = "FIELD_MAX";
            c.Caption = "Độ rộng";
            c.BestFit();
            c.Visible = true;
            this.gridView1.Columns.Add(c); 
            c = new GridColumn();
            c.FieldName = "VISIBLE";
            c.Caption = "Hiển thị";
            c.BestFit();
            c.Visible = true;
            this.gridView1.Columns.Add(c);
        }
        public void LoadData()
        {
            if (NHMain.WorkingMode == WorkingMode.Online)
            {
                string sql1 = @"
                        SELECT sys.tables.name as TABLE_ID,sys.columns.name as [FIELD_ID] 
                        ,'' as FIELD_NAME, sys.systypes.name as FIELD_TYPE, 0 AS FIELD_MAX
                        FROM sys.tables, SYS.COLUMNS, sys.systypes 
                        WHERE(sys.tables.object_id = SYS.COLUMNS.OBJECT_ID)
                        AND sys.COLUMNS.user_type_id = sys.systypes.xusertype
                        AND sys.tables.name = '{<NameTable>}'
                        ORDER BY TABLE_ID";
                sql1 = sql1.Replace("{<NameTable>}", NameTable);
                string sql = @"SELECT COUNT(*) as COUNT FROM [dbo].[SYS_FIELD] WHERE TABLE_ID = '" + NameTable + "'";
                int t = int.Parse(this.NHMain.GetDataByQuery(sql, "").Rows[0]["COUNT"].ToString());
                if (t == 0)
                {
                    this.Grid.DataSource = NHMain.GetDataByQuery(sql1, NameTable);
                    this.gridView1.RefreshData();
                }
                else
                {
                    sql = @"SELECT [FIELD_ID] ,[FIELD_NAME] ,[FIELD_TYPE] ,[FIELD_MAX],[VISIBLE] FROM [dbo].[SYS_FIELD] WHERE TABLE_ID = '" + NameTable + "'";
                    this.Grid.DataSource = this.NHMain.GetDataByQuery(sql, "SYS_FIELD");
                    this.gridView1.RefreshData();
                }
            }
            else
            {
                NHMain.Xml = new XmlExecute(NHMain, "struct_" + NameTable);
                this.Grid.DataSource = NHMain.Xml.DataTable;
                this.gridView1.RefreshData();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (NHMain.WorkingMode == WorkingMode.Online)
                {
                    string temp = "";
                    int i = 0;
                    string sql = @" IF (select count(*) from SYS_FIELD where table_id = '" + NameTable + "' and field_id = '{<FIELD_ID>}') > 0 ";
                    sql += @" UPDATE [dbo].[SYS_FIELD]
                            SET [FIELD_NAME] = N'{<fieldname>}'
                              ,[FIELD_TYPE] = N'{<FIELD_TYPE>}'
                              ,[FIELD_MAX] = {<FIELD_MAX>}
                              ,[VISIBLE] = {<VISIBLE>}
                            WHERE  [TABLE_ID] = '" + NameTable + "' and [FIELD_ID] = '{<FIELD_ID>}'";
                    sql += @" ELSE INSERT INTO [dbo].[SYS_FIELD] ([TABLE_ID] ,[FIELD_ID] ,[FIELD_NAME] ,[FIELD_TYPE] ,[FIELD_MAX],[VISIBLE]) VALUES
           ('" + NameTable + "' ,N'{<FIELD_ID>}' ,N'{<fieldname>}' ,N'{<FIELD_TYPE>}' ,{<FIELD_MAX>},{<VISIBLE>})";
                    foreach (DataRow dr in (this.Grid.DataSource as DataTable).Rows)
                    {
                        temp += sql.Replace("{<fieldname>}", dr["FIELD_NAME"].ToString())
                            .Replace("{<FIELD_TYPE>}", dr["FIELD_TYPE"].ToString())
                            .Replace("{<FIELD_ID>}", dr["FIELD_ID"].ToString())
                            .Replace("{<VISIBLE>}", dr["VISIBLE"].ToString());
                        temp = temp.Replace("{<FIELD_MAX>}", dr["FIELD_MAX"].ToString());
                        i++;
                    }
                    this.NHMain.ExecuteNonQuery(temp);
                }
                else
                {
                    //double index = 0;
                    NHMain.Xml = new XmlExecute(NHMain, (this.Grid.DataSource as DataTable));
                    NHMain.Xml.Save();
                    //foreach (DataRow item in (this.Grid.DataSource as DataTable).Rows)
                    //{
                    //    NHMain.Xml.Edit(item, index);
                    //    index++;
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}