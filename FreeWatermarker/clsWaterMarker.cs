using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace FreeWatermarker
{
    public class clsWaterMarker
    {
        //private Bitmap _imgWaterMark;
        //public Bitmap ImgWaterMark
        //{
        //    get { return _imgWaterMark; }
        //    set { _imgWaterMark = value; }
        //}

        //private ContentAlignment _Alignment;
        //public ContentAlignment Alignment
        //{
        //    get { return _Alignment; }
        //    set { _Alignment = value; }
        //}

        //private bool _HasTransparentColor;
        //public bool HasTransparentColor
        //{
        //    get { return _HasTransparentColor; }
        //    set { _HasTransparentColor = value; }
        //}

        //private Color _TransparentColor;
        //public Color TransparentColor
        //{
        //    get { return _TransparentColor; }
        //    set { _TransparentColor = value; }
        //}

        //private int _Transparency;
        //public int Transparency
        //{
        //    get { return _Transparency; }
        //    set { _Transparency = value; }
        //}

        //public Size OffSet;

        public clsWaterMarker()
        {
            
        }

        //private bool IsWMPieceUpdated(clsImageItem item)
        //{
            
        //    if (_imgWaterMark.GetHashCode() != item.WMHashCode)
        //    {
        //        return false;
        //    }
        //    if (HasTransparentColor != item.WMHasTransparency)
        //    {
        //        return false;
        //    }
        //    if (TransparentColor != item.WMTransparentColor)
        //    {
        //        return false;
        //    }
        //    if (Alignment != item.WMAlignment)
        //    {
        //        return false;
        //    }
        //    if (Transparency != item.WMTransparency)
        //    {
        //        return false;
        //    }
        //    if (OffSet != item.WMOffSet)
        //    {
        //        return false;
        //    }
            
        //    return true;
        //}

        //private void UpdatedWMItem(clsImageItem item)
        //{
        //    item.WMHashCode = _imgWaterMark.GetHashCode();
        //    item.WMHasTransparency = HasTransparentColor;
        //    item.WMTransparentColor = TransparentColor;
        //    item.WMAlignment = Alignment;
        //    item.WMTransparency = Transparency;
        //    item.WMOffSet = OffSet;
        //    UpdateWMPiece(item);
        //}

        private void CalculateWMPosition(ref Point WMPosition, clsWaterMark WM, Size ImgSize)
        {
            //Height
            if (WM.Alignment == ContentAlignment.TopLeft ||
                WM.Alignment == ContentAlignment.TopCenter ||
                WM.Alignment == ContentAlignment.TopRight)
            {
                WMPosition.Y = Calculate3PointPosition(1, ImgSize.Height, WM.Height, WM.OffSet.Height);
            }
            else if (WM.Alignment == ContentAlignment.MiddleLeft ||
                     WM.Alignment == ContentAlignment.MiddleCenter ||
                     WM.Alignment == ContentAlignment.MiddleRight)
            {
                WMPosition.Y = Calculate3PointPosition(2, ImgSize.Height, WM.Height, WM.OffSet.Height);
            }
            else if (WM.Alignment == ContentAlignment.BottomLeft ||
                     WM.Alignment == ContentAlignment.BottomCenter ||
                     WM.Alignment == ContentAlignment.BottomRight)
            {
                WMPosition.Y = Calculate3PointPosition(3, ImgSize.Height, WM.Height, WM.OffSet.Height);
            }
            //Width
            if (WM.Alignment == ContentAlignment.TopLeft ||
                WM.Alignment == ContentAlignment.MiddleLeft ||
                WM.Alignment == ContentAlignment.BottomLeft)
            {
                WMPosition.X = Calculate3PointPosition(1, ImgSize.Width, WM.Width, WM.OffSet.Width);
            }
            else if (WM.Alignment == ContentAlignment.TopCenter ||
                     WM.Alignment == ContentAlignment.MiddleCenter ||
                     WM.Alignment == ContentAlignment.BottomCenter)
            {
                WMPosition.X = Calculate3PointPosition(2, ImgSize.Width, WM.Width, WM.OffSet.Width);
            }
            else if (WM.Alignment == ContentAlignment.TopRight ||
                     WM.Alignment == ContentAlignment.MiddleRight ||
                     WM.Alignment == ContentAlignment.BottomRight)
            {
                WMPosition.X = Calculate3PointPosition(3, ImgSize.Width, WM.Width, WM.OffSet.Width);
            }
        }
        private int Calculate3PointPosition(int pos, int field, int size, int offSet)
        {
            switch (pos)
            {
                case 1:
                    return (int)((field - size) * offSet / 100.0);
                case 2:
                    return (int)((field / 2) - (size / 2) - ((field - size) * offSet / 100.0));
                case 3:
                    return (int)(field - size - ((field - size) * offSet / 100.0));
            }
            return 0;
        }

        public Bitmap CreateAndInsertWaterMark(clsImageItem item, clsWaterMark WM)
        {
            ///
            /// THIS IS WRONG, Should be in an IF because of textWaterMark
            ///
            CreateWMImagePiece(item, (clsImageWaterMark)WM);
            return insertImageWaterMark(item, (clsImageWaterMark)WM);
        }

        public Bitmap insertWaterMark(clsImageItem item)
        {
            ///THIS IS WRONG, Should be in a LOOP
            return insertImageWaterMark(item, (clsImageWaterMark)item.WaterMarks[0]);
        }

        public Bitmap insertWaterMark(clsImageItem item, int WMIndex)
        {
            ///THIS IS WRONG, Should be in an IF because of textWaterMark
            return insertImageWaterMark(item, (clsImageWaterMark)item.WaterMarks[WMIndex]);
        }

        public Bitmap insertImageWaterMark(clsImageItem item, clsImageWaterMark WM)
        {
            Point WMPosition = new Point();
            CalculateWMPosition(ref WMPosition, WM, item.Image.Size);
            
            Bitmap img = new Bitmap(item.Image);
            Graphics grPhoto = Graphics.FromImage(img);

            grPhoto.DrawImage(
                WM.ImgWaterMark,
                new Rectangle(WMPosition.X, WMPosition.Y, img.Width, img.Height),
                0,
                0,
                img.Width,
                img.Height,
                GraphicsUnit.Pixel
            );

            return img;
        }

        private void CreateWMImagePiece(clsImageItem item, int WMIndex)
        {
            CreateWMImagePiece(item, (clsImageWaterMark)item.WaterMarks[WMIndex]);
        }

        private void CreateWMImagePiece(clsImageItem item, clsImageWaterMark WM)
        {
            Point WMPosition = new Point();
            CalculateWMPosition(ref WMPosition, WM, item.Image.Size);

            Bitmap imgPiece = new Bitmap(WM.Width, WM.Height, PixelFormat.Format24bppRgb);
            imgPiece.SetResolution(item.Image.HorizontalResolution, item.Image.VerticalResolution);
            Graphics grPiece = Graphics.FromImage(imgPiece);

            grPiece.DrawImage(
                item.Image,
                new Rectangle(0, 0, imgPiece.Width, imgPiece.Height),
                WMPosition.X,
                WMPosition.Y,
                imgPiece.Width,
                imgPiece.Height,
                GraphicsUnit.Pixel
            );

            ImageAttributes imgAttrib = new ImageAttributes();

            if (WM.HasTransparentColor)
            {
                ColorMap colorMap = new ColorMap();
                colorMap.OldColor = WM.TransparentColor;
                colorMap.NewColor = Color.FromArgb(0, 0, 0, 0);
                ColorMap[] remapTable = { colorMap };
                imgAttrib.SetRemapTable(remapTable, ColorAdjustType.Bitmap);
            }

            float[][] colorMatrixElements = { 
                new float[] {1.0f,  0.0f,  0.0f,  0.0f, 0.0f},
                new float[] {0.0f,  1.0f,  0.0f,  0.0f, 0.0f},
                new float[] {0.0f,  0.0f,  1.0f,  0.0f, 0.0f},
                new float[] {0.0f,  0.0f,  0.0f,  (float)(1.0 - WM.Transparency / 100.0), 0.0f},
                new float[] {0.0f,  0.0f,  0.0f,  0.0f, 1.0f}                                            
            };
            ColorMatrix wmColorMatrix = new ColorMatrix(colorMatrixElements);

            imgAttrib.SetColorMatrix(wmColorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            grPiece.DrawImage(
                WM.ImgWaterMark,
                new Rectangle(0, 0, WM.Width, WM.Height),
                0,
                0,
                WM.Width,
                WM.Height,
                GraphicsUnit.Pixel,
                imgAttrib
            );

            grPiece.Dispose();

            WM.ImgWaterMark = imgPiece;
        }

    }
}
