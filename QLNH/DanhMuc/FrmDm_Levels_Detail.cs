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
    public partial class FrmDm_Levels_Detail : FrmEditDetail
    {
        public FrmDm_Levels_Detail(NHMain nhmain, DataSet dataset, string nametable, bool isnew, int pos)
            : base(nhmain, nametable, dataset, pos, isnew)
        {
            InitializeComponent();
            BinControls();
            SetControls();
        }
        public override void BinControls()
        {
            this.txtLevesID.DataBindings.Add("Text", this.DataSet, this.NameTable + ".LEVEL_ID");
            this.txtLevesName.DataBindings.Add("Text", this.DataSet, this.NameTable + ".LEVEL_NAME");
        }

       
    }
}
