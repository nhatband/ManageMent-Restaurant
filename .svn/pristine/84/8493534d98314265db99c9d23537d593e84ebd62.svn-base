using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLNH.CoSo
{
    public partial class FrmFinding : Form
    {
        public FrmFinding()
        {
            InitializeComponent();
        }
        DataTable DataTable;
        DataTable DataStruct;
        NHMain NHMain;
        public FrmFinding(NHMain nhmain)
        {

            NHMain = nhmain;
            InitializeComponent();
            LoadDm();
        }

        private void iComboBox1_ComboChange(object sender, EventArgs e)
        {
            this.gridControl1.DataSource = DataTable;
            this.gridView1.RefreshData();
        }
        public void LoadDm()
        {
           DataStruct = NHMain.GetDataByQuery("select name from sys.tables","TABLES");
        }
        public void SetControls()
        {
            iComboBox1.SetData(NHMain, "", DataStruct, "name", "name", CauTruc.ComboBoxTypeView.NameOnly);
        }
    }
}
