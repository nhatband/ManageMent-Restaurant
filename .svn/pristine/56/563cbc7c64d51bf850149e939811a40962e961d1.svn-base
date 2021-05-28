using System;

namespace QLNH.CauTruc
{
    public class ItemCombobox : object, IConvertible
    {
        private string mId = string.Empty;
        private string mName = string.Empty;
        private object mTag = null;

        public ItemCombobox(string id, string name)
        {
            this.mId = id;
            this.mName = name;
        }

        public ItemCombobox(string id, string name, object tag)
            : this(id, name)
        {
            this.mTag = tag;
        }

        public string Id
        {
            get { return this.mId; }
        }

        public string Name
        {
            get { return this.mName; }
        }

        public object Tag
        {
            get { return this.mTag; }
        }

        public override string ToString()
        {
            return this.mName;
        }

        public override bool Equals(object obj)
        {
            ItemCombobox item = obj as ItemCombobox;
            if (item != null)
            {
                return item.Id == this.Id ? true : false;
            }
            else
            {
                return false;
            }
        }

        #region IConvertible Members

        public TypeCode GetTypeCode()
        {
            return this.mId.GetTypeCode();
        }

        public bool ToBoolean(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public byte ToByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public char ToChar(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public DateTime ToDateTime(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public decimal ToDecimal(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public double ToDouble(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public short ToInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public int ToInt32(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public long ToInt64(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public sbyte ToSByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public float ToSingle(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public string ToString(IFormatProvider provider)
        {
            return this.mId;
        }

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public ushort ToUInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public uint ToUInt32(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public ulong ToUInt64(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}