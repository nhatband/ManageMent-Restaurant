using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;

namespace QLNH.CoSo
{
    /// <summary>
    /// Interaction logic for uLogin.xaml
    /// </summary>
    public partial class uLogin : UserControl
    {
        DataTable data;
        public NHMain NHMain;
        public uLogin()
        {
            InitializeComponent();
        }
        public uLogin(NHMain nhmain)
        {
            NHMain = nhmain;
            NHMain.UserInfo = new UserInfo();
            InitializeComponent();
            data = NHMain.GetDataByQuery("select * from DM_EMPLOYEES", "DM_EMPLOYEES");
        }
        public void CreateConstruct(NHMain nhmain)
        {
            NHMain = nhmain;
            data = NHMain.GetDataByQuery("select * from DM_EMPLOYEES", "DM_EMPLOYEES");
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (this.txtUserName.Text == "")
            {
                this.lblFailed.Text = "Tên đăng nhập trống.";
                this.lblFailed.Visibility = System.Windows.Visibility.Visible;
            }
            else if (this.txtPassword.Password == "")
            {
                this.lblFailed.Text = "Mật khẩu trống.";
                this.lblFailed.Visibility = System.Windows.Visibility.Visible;
            }
            else if (IsCheckLogin(this.txtUserName.Text, this.txtPassword.Password))
            {
                this.lblFailed.Visibility = System.Windows.Visibility.Hidden;
                this.Visibility = System.Windows.Visibility.Hidden;
                this.NHMain.MainForm.Close();
                //MainForm mf = new MainForm();
                //mf.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                //mf.ShowDialog();
                //this.Visibility = System.Windows.Visibility.Hidden;
            }
            else
            {
                this.lblFailed.Text = "Sai mật khẩu hoặc tên ĐN.";
                this.lblFailed.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private bool IsCheckLogin(string user, string pass)
        {
            data = NHMain.GetDataByQuery("select top 1 * from DM_EMPLOYEES where USER_ID = '" + user.Trim() + "' and Password = '" + pass + "'", "");
            if (data != null)
                if (data.Rows.Count > 0)
                {
                    if (NHMain.UserInfo != null)
                        NHMain.UserInfo.User_Id = data.Rows[0]["USER_ID"].ToString();
                    else
                    {
                        NHMain.UserInfo = new UserInfo();
                        NHMain.UserInfo.User_Id = data.Rows[0]["USER_ID"].ToString();
                    }
                    return true;
                }
            return false;
        }
    }
}
