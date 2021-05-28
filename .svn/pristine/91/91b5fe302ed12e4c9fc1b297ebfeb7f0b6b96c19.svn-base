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
    public partial class FrmDm_Warehouses_Detail : FrmEditDetail
    {
        public FrmDm_Warehouses_Detail(NHMain nhmain, DataSet dataset, string nametable, bool isnew, int pos)
            : base(nhmain, nametable, dataset, pos, isnew)
        {
            InitializeComponent();
            LoadDm();
            BinControls();
            SetControls();
        }
        public override void BinControls()
        {
            this.txtMaKho.DataBindings.Add("Text", this.DataSet, this.NameTable + ".WAREHOUSE_ID");
            this.txtTenKho.DataBindings.Add("Text", this.DataSet, this.NameTable + ".WAREHOUSE_NAME");
            this.cboWordStation_Id.DataBindings.Add("Text", this.DataSet, this.NameTable + ".WORKSTATION_ID");
        }
        public override void SetControls()
        {
            this.cboWordStation_Id.SetData(NHMain, "", this.DataSet.Tables["DM_WORKSTATIONS"], "WORKSTATION_ID", "WORKSTATION_NAME", ComboBoxTypeView.NameID);
            this.cboWordStation_Id.FrmDetail = new FrmDm_WorkStations_List(NHMain);
        }
        public override void LoadDm()
        {
            try
            {

                if (this.DataSet.Tables.IndexOf("DM_WORKSTATIONS") > 0) this.DataSet.Tables.Remove("DM_WORKSTATIONS");
                this.DataSet.Tables.Add(NHMain.GetDataByQuery("select * from DM_WORKSTATIONS", "DM_WORKSTATIONS")); 
            }
            catch
            {
            }

        }

    }
}
