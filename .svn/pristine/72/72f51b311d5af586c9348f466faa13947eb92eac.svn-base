using System;
using System.Windows;

namespace QLNH.CoSo
{
    public static class Functions
    {
        public static double IsNull(object value)
        {
            return value == null ? 0 : double.Parse(value.ToString());
        }

        public static Visibility IsVisible(object value)
        {
            if (value == null) return Visibility.Visible;
            return int.Parse(value.ToString()) == 0 ? Visibility.Hidden : Visibility.Visible;
        }

        public static double PasteDouble(object value)
        {
            return value == null ? 0 : double.Parse(value.ToString());
        }

        public static int PasteInt(object value)
        {
            return value == null ? 0 : int.Parse(value.ToString());
        }
        public static string ParseDate(DateTime d)
        {
            string year = d.Year.ToString();
            string month = d.Month.ToString();
            string day = d.Day.ToString();
            if (month.Length == 1)
            {
                month = "0" + month;
            }
            if (day.Length == 1)
            {
                day = "0" + day;
            }
            return "'" + month + "/" + day + "/" + year + "'";
        }
        public static string PasteString(object value)
        {
            if (value == null)
                return "";
            return value.ToString();
        }
        public static bool IsBoolVisible(object value)
        {
            if (value == null)
                return true;
            if ((int)value == 0)
                return false;
            return true;
        }
    }
}
