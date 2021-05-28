using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLNH.ThietKe.Design
{
    public class MapPoint
    {
        private string mTagItem;
        public string TagItem
        {
            get { return mTagItem; }
            set { mTagItem = value; }
        }
        private int mPoint;
        public int Point
        {
            get { return mPoint; }
            set { mPoint = value; }
        }
        private int mItem_ID;
        public int Item_ID
        {
            get { return mItem_ID; }
            set { mItem_ID = value; }
        }
        private int mX;
        public int X
        {
            get { return mX; }
            set { mX = value; }
        }
        private int mY;
        public int Y
        {
            get { return mY; }
            set { mY = value; }
        }
        private int mWidth;
        public int Width
        {
            get { return mWidth; }
            set { mWidth = value; }
        }
        private int mHeight;
        public int Height
        {
            get { return mHeight; }
            set { mHeight = value; }
        }
        private float mOpacity;
        public float Opacity
        {
            get { return mOpacity; }
            set { mOpacity = value; }
        }
        private float mRadian;
        public float Radian
        {
            get { return mRadian; }
            set { mRadian = value; }
        }
        private int mStatus_Use;
        public int Status_Use
        {
            get { return mStatus_Use; }
            set { mStatus_Use = value; }
        }
        private int mMap_ID;
        public int Map_ID
        {
            get { return mMap_ID; }
            set { mMap_ID = value; }
        }
        private int mMineral;
        public int Mineral_ID
        {
            get { return mMineral; }
            set { mMineral = value; }
        }
        private int mLayer;
        public int Layer
        {
            get { return mLayer; }
            set { mLayer = value; }
        }
        private byte[] mImageStore;
        public byte[] ImageStore
        {
            get { return mImageStore; }
            set { mImageStore = value; }
        }
        private string mUserName;
        public string UserName
        {
            get { return mUserName; }
            set { mUserName = value; }
        }
        private DateTime mDateCreate;
        public DateTime DateCreate
        {
            get { return mDateCreate; }
            set
            {
                mDateCreate = value;
            }
        }
    }
}
