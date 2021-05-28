using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLNH.CoSo;
using QLNH.CauTruc;
using System.IO;

namespace QLNH.DanhMuc
{
    public partial class FrmDm_Table_Detail : FrmEditDetail
    {
        public FrmDm_Table_Detail(NHMain nhmain, DataSet dataset, string nametable, bool isnew, int pos)
            : base(nhmain, nametable, dataset, pos, isnew)
        {

            InitializeComponent();
            BinControls();
            SetControls();
        }
        public override void SetControls()
        {
            //this.txtValue_Id.SetData(NHMain, "", NHMain.GetDataByQuery("select * from DM_CAMERA", "DM_CAMERA"), "CAMERA_ID", "CAMERA_NAME", ComboBoxTypeView.NameID);
            //this.txtValue_Id.FrmDetail = new FrmDm_Camera(MQMain);
        }
        public override void BinControls()
        {
            this.txtTable_Id.DataBindings.Add("Text", this.DataSet, this.NameTable + ".TABLE_ID");
            this.txtTable_Name.DataBindings.Add("Text", this.DataSet, this.NameTable + ".TABLE_NAME");
            this.txtTotal_Chair.DataBindings.Add("Value", this.DataSet, this.NameTable + ".TOTAL_CHAIR");
            this.picTable.DataBindings.Add("EditValue", this.DataSet, this.NameTable + ".TABLE_IMAGE");
        }
        public byte[] photo
        {
            get
            {
                if ((this.DataTable.Rows.Count > 0) && (this.DataTable.Rows[0]["TABLE_IMAGE"] != DBNull.Value))
                {
                    return (byte[])this.DataTable.Rows[0]["TABLE_IMAGE"];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (this.DataTable.Rows.Count > 0)
                {
                    this.DataTable.Rows[0]["TABLE_IMAGE"] = value;
                }
            }
        }
        private void btnChoose_Click(object sender, EventArgs e)
        {
            Image img = null;
            OpenFileDialog getFile = new OpenFileDialog();
            getFile.Filter = "Bitmap(*.bmp)|*.bmp|Jpeg(*.jpg)|*.jpg|Gif(*.gif)|*.gif";
            getFile.FilterIndex = 2;
            DialogResult result = getFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(getFile.FileName);
                img = Image.FromFile(getFile.FileName);
                this.txtFileName.TextBoxEdit.EditValue = getFile.FileName;
            }
            picTable.Image = img;
            photo = imageToByteArray(img);
        }
        public override void SaveRecord()
        {
            object a = this.DataTable.Rows[0]["TABLE_IMAGE"];
            this.DataTable.Rows[0]["TABLE_IMAGE"] = 0;
            base.SaveRecord();
            if (this.txtFileName.TextBoxEdit.EditValue != null)
            {
                string up = "UPDATE DM_TABLES set TABLE_IMAGE = (SELECT * FROM OPENROWSET(BULK N'" + this.txtFileName.TextBoxEdit.EditValue + "', SINGLE_BLOB) a) where TABLE_ID = '" + this.txtTable_Id.Text + "'";
                this.NHMain.ExecuteNonQuery(up);
            }
            this.DataTable.Rows[0]["TABLE_IMAGE"] = a;
            this.DataTable.Rows[0].EndEdit();
            this.DataTable.AcceptChanges();
        }
        public byte[] imageToByteArray(Image imageIn)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(imageIn, typeof(byte[]));
        }
    }
}
