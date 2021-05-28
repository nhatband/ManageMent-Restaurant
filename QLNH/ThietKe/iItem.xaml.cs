using QLNH.CoSo;
using System.Windows.Controls;
using QLNH.ThietKe.ObjectClass;
using System.Windows.Data;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.IO;

namespace QLNH.ThietKe
{
    /// <summary>
    /// Interaction logic for iItem.xaml
    /// </summary>
    public partial class iItem
    {
        public NHMain MPMain;
        public string NameTable;
        public bool isNew = false;
        public Item Item;
        public iItem(Item item)
        {
            InitializeComponent();
            Item = item;
            LoadProperties(item);
            BindingItem(item);
        }
        private void LoadProperties(Item item)
        {
            this.Name = "Item_" + Functions.PasteString(item.Item_Id);
            this.Tag = item.Tagitem;
            this.Height = item.Height;
            this.Width = item.Width;
            this.Visibility = Visibility.Visible;
        }
        public BitmapImage Image(byte[] source)
        {
            if (source.Length > 0)
            {
                MemoryStream ms = new MemoryStream(source);
                BitmapImage bi = new BitmapImage();
                //bi.SetSource(ms);
                return bi;
            }
            return null;
        }
        public void BindingItem(Item item)
        {
            Binding binding = new Binding("X") {Source = item, Mode = BindingMode.TwoWay};
            this.SetBinding(Canvas.TopProperty, binding);
            //////////////////
            binding = new Binding("Y") {Source = item, Mode = BindingMode.TwoWay};
            this.SetBinding(Canvas.LeftProperty, binding);
        }
        public double LenWidth
        {
            get { return this.LayoutRoot.Width; }
            set { this.LayoutRoot.Width = value; }
        }

        public double LenHeight
        {
            get { return this.LayoutRoot.Height; }
            set { this.LayoutRoot.Height = value; }
        }
        private void LayoutRoot_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Brush b = new SolidColorBrush(Colors.Black);
            this.Background = b;
        }

        private void LayoutRoot_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Brush b = new SolidColorBrush(Colors.White);
            this.Background = b;
        }

        private void LayoutRoot_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            Item.Height = this.Height;
            Item.Width = this.Width;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
