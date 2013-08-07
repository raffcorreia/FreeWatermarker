using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace FreeWatermarker
{
    public class clsImageWaterMark : clsWaterMark
    {
        private Bitmap _imgWaterMark;
        public Bitmap ImgWaterMark
        {
            get { return _imgWaterMark; }
            set { _imgWaterMark = value; }
        }

        private bool _HasTransparentColor;
        public bool HasTransparentColor
        {
            get { return _HasTransparentColor; }
            set { _HasTransparentColor = value; }
        }

        private Color _TransparentColor;
        public Color TransparentColor
        {
            get { return _TransparentColor; }
            set { _TransparentColor = value; }
        }

        public override int Width
        {
            get { return _imgWaterMark.Width; }
            set { throw new NotImplementedException(); }
        }

        public override int Height
        {
            get { return _imgWaterMark.Height; }
            set { throw new NotImplementedException(); }
        }

        public clsImageWaterMark()
        {
            
        }
    }
}
