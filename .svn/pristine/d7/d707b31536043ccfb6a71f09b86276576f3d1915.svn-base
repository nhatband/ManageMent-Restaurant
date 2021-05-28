using QLNH.CoSo;
using System;
using System.Windows.Forms;

namespace QLNH.BanHang
{
    public partial class FrmNhapNguyenLieu_Listing : FrmDataList
    {
        public FrmNhapNguyenLieu_Listing(NHMain nhmain)
            : base(nhmain, "VOUCHER_VIEW")
        {
            InitializeComponent();
        }

        public override void EditRecord()
        {
            try
            {
                FrmNhapNguyenLieu f = new FrmNhapNguyenLieu(NHMain, this.DataSet, "VOUCHER", "VOUCHER_DETAIL", double.Parse(this.GetDataRow()["FR_KEY"].ToString().Replace(",0000", "")));
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
            FrmNhapNguyenLieu f = new FrmNhapNguyenLieu(NHMain, this.DataSet, "VOUCHER", "VOUCHER_DETAIL", true);
            f.isNew = true;
            f.ShowDialog();

        }
    }
}

