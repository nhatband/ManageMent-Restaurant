using QLNH.CoSo;
using System;
using System.Windows.Forms;

namespace QLNH.BanHang
{
    public partial class FrmCheBienMonAn_Listing : FrmDataList
    {
        public FrmCheBienMonAn_Listing(NHMain nhmain)
            : base(nhmain, "ITEM_JOIN_VIEW")
        {
            InitializeComponent();
        }

        public override void EditRecord()
        {
            try
            {
                FrmCheBienMonAn f = new FrmCheBienMonAn(NHMain, this.DataSet, "ITEM_JOIN", "ITEM_JOIN_DETAIL", double.Parse(this.GetDataRow()["FR_KEY"].ToString().Replace(",0000", "")));
                f.isNew = false;
                f.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public override void NewRecord()
        {
            FrmCheBienMonAn f = new FrmCheBienMonAn(NHMain, this.DataSet, "ITEM_JOIN", "ITEM_JOIN_DETAIL", true);
            f.isNew = true;
            f.ShowDialog();

        }
    }
}

