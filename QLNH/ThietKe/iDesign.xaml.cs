using System;
using System.Windows;
using System.Windows.Input;
using System.Data;
using QLNH.CoSo;
using QLNH.ThietKe.ObjectClass;

namespace QLNH.ThietKe
{
    /// <summary>
    /// Interaction logic for iDesign.xaml
    /// </summary>
    public partial class iDesign
    {
        #region Khởi động
        public string Map_ID;
        public string UserName;
        public DataSet DataSet;
        public NHMain MPMain;
        public string DataLayers;
        public string DataItems;
        Point pointCur;
        public iDesign()
        {
            InitializeComponent();
            MC.GridDesign.MouseMove += this.GridDesign_MouseMove;
        }

        public iDesign(NHMain mqmain, DataSet dataset, string datalayers, string dataitems, string MapID, string User)
        {
            try
            {
                MPMain = mqmain;
                DataSet = dataset;
                DataLayers = datalayers;
                DataItems = dataitems;
                InitializeComponent();
                Map_ID = MapID;
                UserName = User;
                MC.GridDesign.MouseMove += this.GridDesign_MouseMove;
                LoadingMap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        void GridDesign_MouseMove(object sender, MouseEventArgs e)
        {
            pointCur = new Point(e.GetPosition(MC.GridDesign).X, e.GetPosition(MC.GridDesign).Y);
        }
        public Point GetPointMouse()
        {
            return pointCur;
        }
        #endregion

        #region Tải dữ liệu
        public void LoadingMap()
        {
            foreach (DataRow i in this.DataSet.Tables[DataLayers].Rows)
                this.MC.Layers.Add(new Layer()
                                       {
                                           Layer_Id = Functions.PasteDouble(i["Layer_Id"]),
                                           Layer_Name = Functions.PasteString(i["Layer_Name"]),
                                           Width = Functions.PasteDouble(i["Width"]),
                                           Height = Functions.PasteDouble(i["Height"]),
                                           Opacity = Functions.PasteDouble(i["Opacity"]),
                                           Isvisible = Functions.PasteInt(i["Isvisible"])
                                       });
            foreach (DataRow i in this.DataSet.Tables[DataItems].Rows)
            {
                this.MC.Items.Add(new Item(i));
                // Trạng thái binding giữa datarow và item
            }
            this.MC.LoadLayers();
            this.MC.LoadItems();
        }
        #endregion

        #region Load Items for tab panel items


        #endregion

        #region Load layout
        public void LoadLayout()
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
        #endregion
    }
}
