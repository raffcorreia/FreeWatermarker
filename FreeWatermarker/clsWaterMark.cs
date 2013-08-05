using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace FreeWatermarker
{
    public class clsWaterMark
    {
        private Bitmap _imgWaterMark;
        public Bitmap ImgWaterMark
        {
            get { return _imgWaterMark; }
            set { _imgWaterMark = value; }
        }

        private ContentAlignment _Alignment;
        public ContentAlignment Alignment
        {
            get { return _Alignment; }
            set { _Alignment = value; }
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

        private int _Transparency;
        public int Transparency
        {
            get { return _Transparency; }
            set { _Transparency = value; }
        }

        public Size OffSet;

        public clsWaterMark()
        {
            
        }

        private bool IsWMPieceUpdated(clsImageItem item)
        {
            
            if (_imgWaterMark.GetHashCode() != item.WMHashCode)
            {
                return false;
            }
            if (HasTransparentColor != item.WMHasTransparency)
            {
                return false;
            }
            if (TransparentColor != item.WMTransparentColor)
            {
                return false;
            }
            if (Alignment != item.WMAlignment)
            {
                return false;
            }
            if (Transparency != item.WMTransparency)
            {
                return false;
            }
            if (OffSet != item.WMOffSet)
            {
                return false;
            }
            
            return true;
        }

        private void UpdatedWMItem(clsImageItem item)
        {
            item.WMHashCode = _imgWaterMark.GetHashCode();
            item.WMHasTransparency = HasTransparentColor;
            item.WMTransparentColor = TransparentColor;
            item.WMAlignment = Alignment;
            item.WMTransparency = Transparency;
            item.WMOffSet = OffSet;
            UpdateWMPiece(item);
        }

        private void UpdateWMPiece(clsImageItem item)
        {
            Point WMPosition = new Point();
            CalculateWMPosition(item.Image.Size, ref WMPosition, OffSet);

            Bitmap imgPiece = new Bitmap(ImgWaterMark.Width, ImgWaterMark.Height, PixelFormat.Format24bppRgb);
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

            if (HasTransparentColor)
            {
                ColorMap colorMap = new ColorMap();
                colorMap.OldColor = TransparentColor;
                colorMap.NewColor = Color.FromArgb(0, 0, 0, 0);
                ColorMap[] remapTable = { colorMap };
                imgAttrib.SetRemapTable(remapTable, ColorAdjustType.Bitmap);
            }

            float[][] colorMatrixElements = { 
                new float[] {1.0f,  0.0f,  0.0f,  0.0f, 0.0f},
                new float[] {0.0f,  1.0f,  0.0f,  0.0f, 0.0f},
                new float[] {0.0f,  0.0f,  1.0f,  0.0f, 0.0f},
                new float[] {0.0f,  0.0f,  0.0f,  (float)(1.0 - Transparency / 100.0), 0.0f},
                new float[] {0.0f,  0.0f,  0.0f,  0.0f, 1.0f}                                            
            };
            ColorMatrix wmColorMatrix = new ColorMatrix(colorMatrixElements);

            imgAttrib.SetColorMatrix(wmColorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            grPiece.DrawImage(
                _imgWaterMark,
                new Rectangle(0, 0, _imgWaterMark.Width, _imgWaterMark.Height),
                0,
                0,
                _imgWaterMark.Width,
                _imgWaterMark.Height,
                GraphicsUnit.Pixel,
                imgAttrib
            );

            grPiece.Dispose();

            item.ImgWMCut = imgPiece;
        }

        private void CalculateWMPosition(Size ImgSize, ref Point WMPosition, Size OffSet)
        {
            //Height
            if (Alignment == ContentAlignment.TopLeft ||
                Alignment == ContentAlignment.TopCenter ||
                Alignment == ContentAlignment.TopRight)
            {
                WMPosition.Y = Calculate3PointPosition(1, ImgSize.Height, ImgWaterMark.Height, OffSet.Height);
            }
            else if (Alignment == ContentAlignment.MiddleLeft ||
                     Alignment == ContentAlignment.MiddleCenter ||
                     Alignment == ContentAlignment.MiddleRight)
            {
                WMPosition.Y = Calculate3PointPosition(2, ImgSize.Height, ImgWaterMark.Height, OffSet.Height);
            }
            else if (Alignment == ContentAlignment.BottomLeft ||
                     Alignment == ContentAlignment.BottomCenter ||
                     Alignment == ContentAlignment.BottomRight)
            {
                WMPosition.Y = Calculate3PointPosition(3, ImgSize.Height, ImgWaterMark.Height, OffSet.Height);
            }
            //Width
            if (Alignment == ContentAlignment.TopLeft ||
                Alignment == ContentAlignment.MiddleLeft ||
                Alignment == ContentAlignment.BottomLeft)
            {
                WMPosition.X = Calculate3PointPosition(1, ImgSize.Width, ImgWaterMark.Width, OffSet.Width);
            }
            else if (Alignment == ContentAlignment.TopCenter ||
                     Alignment == ContentAlignment.MiddleCenter ||
                     Alignment == ContentAlignment.BottomCenter)
            {
                WMPosition.X = Calculate3PointPosition(2, ImgSize.Width, ImgWaterMark.Width, OffSet.Width);
            }
            else if (Alignment == ContentAlignment.TopRight ||
                     Alignment == ContentAlignment.MiddleRight ||
                     Alignment == ContentAlignment.BottomRight)
            {
                WMPosition.X = Calculate3PointPosition(3, ImgSize.Width, ImgWaterMark.Width, OffSet.Width);
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
        
        public Image insertWaterMark(clsImageItem item)
        {
            if (!IsWMPieceUpdated(item))
            {
                UpdatedWMItem(item);
            }

            Point WMPosition = new Point();
            CalculateWMPosition(item.Image.Size, ref WMPosition, OffSet);

            Bitmap img = new Bitmap(item.Image);
            Graphics grPhoto = Graphics.FromImage(img);

            grPhoto.DrawImage(
                item.ImgWMCut,
                new Rectangle(WMPosition.X, WMPosition.Y, img.Width, img.Height),
                0,
                0,
                img.Width,
                img.Height,
                GraphicsUnit.Pixel
            );

            return img;
        }
    }
}
