using System;
using System.Data;
using System.Windows.Forms;
using QLNH.CoSo;

namespace QLNH.HeThong
{
    public partial class FrmChangePass : FrmEditDetail
    {
        public FrmChangePass(NHMain nhmain, DataSet datarow, string nametable)
            : base(nhmain, nametable, datarow, 0, false)
        {
            InitializeComponent();
            this.isNew = false;
            SetControls();
        }
        public override void LoadData()
        {
            try
            {
                LoadDm();
                if (NHMain.WorkingMode == WorkingMode.Online)
                {
                    this.DataSet.Tables.Add(this.NHMain.GetDataByQuery("select top 1 * from " + NameTable + " WHERE USER_ID = '" + NHMain.UserInfo.User_Id + "'", NameTable));
                    this.DataTable = this.DataSet.Tables[NameTable];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public override void SetControls()
        {
            this.txtUser.DataBindings.Add("Text", this.DataSet, NameTable + ".USER_ID");
        }
        public override void SaveRecord()
        {
            if (this.DataTable.Rows[0]["PASSWORD"].ToString() == this.txtCurr.Text)
                if (this.txtReNew.Text == this.txtReNew.Text)
                {
                    this.DataTable.Rows[0]["PASSWORD"] = this.txtReNew.Text;
                    base.SaveRecord();
                }
                else
                {
                    MessageBox.Show("Mật khẩu không khớp hoặc không trùng");
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu cũ");
                }
        }
    }
}
