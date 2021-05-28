using System;
using System.ComponentModel;
using System.Data;
using QLNH.CoSo;

namespace QLNH.ThietKe.ObjectClass
{
    public class Item : INotifyPropertyChanged
    {
        public DataRow DataRow;
        public Item(DataRow record)
        {
            DataRow = record;
            _Item_Id = Functions.PasteDouble(record["TABLE_ID"]);
            _Layer = Functions.PasteDouble(record["EX_LAYER"]);
            _Opacity = Functions.PasteDouble(record["EX_OPACITY"]);
            _Height = Functions.PasteDouble(record["EX_HEIGHT"]);
            _Width = Functions.PasteDouble(record["EX_WIDTH"]);
            _Parent_Id = 100;
            _Tagitem = Functions.PasteString(record["EX_TAGITEM"]);
            _X = Functions.PasteDouble(record["X"]);
            _Y = Functions.PasteDouble(record["Y"]);
        }
        private DateTime _Datecreate;
        public DateTime Datecreate
        {
            get { return _Datecreate; }
            set
            {
                _Datecreate = value;
                DataRow["Datecreate"] = value;
                NotifyPropertyChange("Datecreate");
            }
        }
        private double _Height;
        public double Height
        {
            get { return _Height; }
            set
            {
                _Height = value;
                DataRow["EX_Height"] = value;
                NotifyPropertyChange("HEIGHT");
            }
        }
        private double _Item_Id;
        public double Item_Id
        {
            get { return _Item_Id; }
            set
            {
                _Item_Id = value;
                DataRow["table_Id"] = value;
                NotifyPropertyChange("Item_Id");
            }
        }
        private double _Layer;
        public double Layer
        {
            get { return _Layer; }
            set
            {
                _Layer = value;
                DataRow["ex_Layer"] = value;
                NotifyPropertyChange("Layer");
            }
        }
        private string _Map_Id;
        public string Map_Id
        {
            get { return _Map_Id; }
            set
            {
                _Map_Id = value;
                DataRow["Map_Id"] = value;
                NotifyPropertyChange("Map_Id");
            }
        }
        private double _Opacity;
        public double Opacity
        {
            get { return _Opacity; }
            set
            {
                _Opacity = value;
                DataRow["ex_Opacity"] = value;
                NotifyPropertyChange("Opacity");
            }
        }
        private int _Parent_Id;
        public int Parent_Id
        {
            get { return _Parent_Id; }
            set
            {
                _Parent_Id = value;
                DataRow["Parent_Id"] = value;
                NotifyPropertyChange("Parent_Id");
            }
        }
        private string _Tagitem;
        public string Tagitem
        {
            get { return _Tagitem; }
            set
            {
                _Tagitem = value;
                DataRow["ex_Tagitem"] = value;
                NotifyPropertyChange("Tagitem");
            }
        }
        private double _Width;
        public double Width
        {
            get { return _Width; }
            set
            {
                _Width = value;
                DataRow["ex_Width"] = value;
                NotifyPropertyChange("WIDTH");
            }
        }
        private double _X;
        public double X
        {
            get { return _X; }
            set
            {
                _X = value;
                DataRow["X"] = value;
                NotifyPropertyChange("");
            }
        }
        private double _Y;
        public double Y
        {
            get { return _Y; }
            set
            {
                _Y = value;
                DataRow["Y"] = value;
                NotifyPropertyChange("Y");
            }
        }
        #region INotifyPropertyChanged Members
        protected void NotifyPropertyChange(string propertyName)
        {
            var propertyChanged = PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
