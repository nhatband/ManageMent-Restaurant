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
    public partial class FrmDm_Vat_Tax_Detail : FrmEditDetail
    {
        public FrmDm_Vat_Tax_Detail(NHMain nhmain, DataSet dataset, string nametable, bool isnew, int pos)
            : base(nhmain, nametable, dataset, pos, isnew)
        {
            InitializeComponent();
            BinControls();
            SetControls();
        }
        public override void BinControls()
        {
            this.txtVat_Tax_Id.DataBindings.Add("Text", this.DataSet, this.NameTable + ".VAT_TAX_ID");
            this.txtVat_Tax_Name.DataBindings.Add("Text", this.DataSet, this.NameTable + ".VAT_TAX_NAME");
            this.txtRate.DataBindings.Add("Value", this.DataSet, this.NameTable + ".RATE");
        }
    }
          
}
