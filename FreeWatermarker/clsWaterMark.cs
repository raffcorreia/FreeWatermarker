using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace FreeWatermarker
{
    public class clsWaterMark : ICloneable
    {
        private WaterMarkLayout _Layout;
        public WaterMarkLayout Layout
        {
            get { return _Layout; }
            set { _Layout = value; }
        }

        private int _Transparency;
        public int Transparency
        {
            get { return _Transparency; }
            set { _Transparency = value; }
        }

        public Size OffSet;

        private int _Width;
        public virtual int Width
        {
            get { return _Width; }
            set { _Width = value; }
        }

        private int _Height;
        public virtual int Height
        {
            get { return _Height; }
            set { _Height = value; }
        }

        public clsWaterMark()
        {

        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public clsWaterMark Clone()
        {
            return (clsWaterMark)this.MemberwiseClone();
        }
    }

    public enum WaterMarkLayout
    {
        TopLeft,
        TopCenter,
        TopRight,
        MiddleLeft,
        MiddleCenter,
        MiddleRight,
        BottomLeft,
        BottomCenter,
        BottomRight,
        Ajust,
        Zoom,
        Fill,
        Repeat
    }
}
