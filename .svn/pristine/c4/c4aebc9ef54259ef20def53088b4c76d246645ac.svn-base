using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using QLNH.CoSo;

namespace QLNH.DanhMuc
{
    public partial class FrmDm_Floors_Detail : FrmEditDetail
    {
        public FrmDm_Floors_Detail(NHMain nhmain, DataSet dataset, string nametable, bool isnew, int pos)
            : base(nhmain, nametable, dataset, pos, isnew)
        {
            InitializeComponent();
            BinControls();
            SetControls();
        }
        public override void BinControls()
        {
            this.txtValue_Id.DataBindings.Add("Text", this.DataSet, this.NameTable + ".VALUE_ID");
            this.txtValue_Name.DataBindings.Add("Text", this.DataSet, this.NameTable + ".VALUE_NAME");
            this.picFloor.DataBindings.Add("EditValue", this.DataSet, this.NameTable + ".IMAGE_FLOOR");
        }
        public byte[] photo
        {
            get
            {
                if ((this.DataTable.Rows.Count > 0) && (this.DataTable.Rows[0]["IMAGE_FLOOR"] != DBNull.Value))
                {
                    return (byte[])this.DataTable.Rows[0]["IMAGE_FLOOR"];
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
                    this.DataTable.Rows[0]["IMAGE_FLOOR"] = value;
                }
            }
        }
        public ImageSource LoadImage(string ImageSource)
        {
            BitmapImage src = new BitmapImage();
            src.BeginInit();
            src.UriSource = new Uri(ImageSource, UriKind.Relative);
            src.EndInit();
            return src;
        }
        private void btnChooseImage_Click(object sender, EventArgs e)
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
            picFloor.Image = img;
            photo = imageToByteArray(img);
        }
        public override void SaveRecord()
        {
            object a = this.DataTable.Rows[0]["IMAGE_FLOOR"];
            this.DataTable.Rows[0]["IMAGE_FLOOR"] = 0;
            base.SaveRecord();
            if (this.txtFileName.TextBoxEdit.EditValue != null)
            {
                string up = "UPDATE DM_FLOORS set IMAGE_FLOOR = (SELECT * FROM OPENROWSET(BULK N'" + this.txtFileName.TextBoxEdit.EditValue + "', SINGLE_BLOB) a) where VALUE_ID = '" + this.txtValue_Id.Text + "'";
                this.NHMain.ExecuteNonQuery(up);
            }
            this.DataTable.Rows[0]["IMAGE_FLOOR"] = a;
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
