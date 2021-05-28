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
    public partial class FrmDm_Providers_Detail : FrmEditDetail
    {
        public FrmDm_Providers_Detail(NHMain nhmain, DataSet dataset, string nametable, bool isnew, int pos)
            : base(nhmain, nametable, dataset, pos, isnew)
        {
            InitializeComponent();
            BinControls();
            SetControls();
        }
        public override void BinControls()
        {
            this.txtProvider_Id.DataBindings.Add("Text", this.DataSet, this.NameTable + ".PROVIDER_ID");
            this.txtProvider_Name.DataBindings.Add("Text", this.DataSet, this.NameTable + ".PROVIDER_NAME");
            this.txtContact_Person.DataBindings.Add("Text", this.DataSet, this.NameTable + ".CONTACT_PERSON");
            this.txtPhone.DataBindings.Add("Text", this.DataSet, this.NameTable + ".PHONE");
            this.txtEmail.DataBindings.Add("Text", this.DataSet, this.NameTable + ".EMAIL");
            this.txtAddress.DataBindings.Add("Text", this.DataSet, this.NameTable + ".ADDRESS");
        }
    }
}
