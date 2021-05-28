using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLNH.CoSo;

namespace QLNH.DanhMuc
{
    public partial class FrmDmSale_Price_List : FrmDataList
    {
        public FrmDmSale_Price_List(NHMain nhmain)
            : base(nhmain, "SALE_PRICE")
        {
            InitializeComponent();
        }
        public override void EditRecord()
        {
            try
            {
                this.FrmEditDetail = new FrmDmSale_Price_Detail(NHMain, this.DataSet, "SALE_PRICE", false, this.DataSet.Tables[NameTable].Rows.IndexOf(this.GetDataRow()));
                this.FrmEditDetail.isNew = false;
                this.FrmEditDetail.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }

        }
        public override void NewRecord()
        {
            this.FrmEditDetail = new FrmDmSale_Price_Detail(NHMain, this.DataSet, "SALE_PRICE", true, 0);
            this.FrmEditDetail.ShowDialog();
        }
    }
}
