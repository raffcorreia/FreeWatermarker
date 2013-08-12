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
        public clsWaterMarker()
        {
            
        }

        private Point CalculateWMPosition(WaterMarkLayout Layout, Size WMSize, Size WMOffSet, Size ImgSize)
        {
            Point position = new Point(0, 0);

            //Special Layout REPEAT
            if (Layout == WaterMarkLayout.Repeat)
            {
                return position;
            }

            //Height
            if (Layout == WaterMarkLayout.TopLeft ||
                Layout == WaterMarkLayout.TopCenter ||
                Layout == WaterMarkLayout.TopRight)
            {
                position.Y = Calculate3PointPosition(1, ImgSize.Height, WMSize.Height, WMOffSet.Height);
            }
            else if (Layout == WaterMarkLayout.MiddleLeft ||
                     Layout == WaterMarkLayout.MiddleCenter ||
                     Layout == WaterMarkLayout.MiddleRight ||
                     Layout == WaterMarkLayout.Fill ||
                     Layout == WaterMarkLayout.Ajust)
            {
                position.Y = Calculate3PointPosition(2, ImgSize.Height, WMSize.Height, WMOffSet.Height);
            }
            else if (Layout == WaterMarkLayout.BottomLeft ||
                     Layout == WaterMarkLayout.BottomCenter ||
                     Layout == WaterMarkLayout.BottomRight)
            {
                position.Y = Calculate3PointPosition(3, ImgSize.Height, WMSize.Height, WMOffSet.Height);
            }
            //Width
            if (Layout == WaterMarkLayout.TopLeft ||
                Layout == WaterMarkLayout.MiddleLeft ||
                Layout == WaterMarkLayout.BottomLeft)
            {
                position.X = Calculate3PointPosition(1, ImgSize.Width, WMSize.Width, WMOffSet.Width);
            }
            else if (Layout == WaterMarkLayout.TopCenter ||
                     Layout == WaterMarkLayout.MiddleCenter ||
                     Layout == WaterMarkLayout.BottomCenter ||
                     Layout == WaterMarkLayout.Fill ||
                     Layout == WaterMarkLayout.Ajust)
            {
                position.X = Calculate3PointPosition(2, ImgSize.Width, WMSize.Width, WMOffSet.Width);
            }
            else if (Layout == WaterMarkLayout.TopRight ||
                     Layout == WaterMarkLayout.MiddleRight ||
                     Layout == WaterMarkLayout.BottomRight)
            {
                position.X = Calculate3PointPosition(3, ImgSize.Width, WMSize.Width, WMOffSet.Width);
            }
            return position;
        }

        private int Calculate3PointPosition(int pos, int field, int size, int offSet)
        {
            double percentOffSet;
            if ((field - size) == 0)
            {
                percentOffSet = (field * offSet / 100.0);
            }
            else 
            {
                percentOffSet = ((field - size) * offSet / 100.0);
            }
            switch (pos)
            {
                case 1:
                    return (int)percentOffSet;
                case 2:
                    return (int)((field / 2) - (size / 2) - percentOffSet);
                case 3:
                    return (int)(field - size - percentOffSet);
            }
            return 0;
        }

        public void CreateWaterMark(clsImageItem item)
        {
            CreateWMImagePiece(item, (clsImageWaterMark)item.WaterMarks[0]);
        }

        public Bitmap CreateAndInsertWaterMark(clsImageItem item)
        {
            return CreateAndInsertWaterMark(item, item.WaterMarks[0]);
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
            Point WMPosition;
            Point SrcPosition = new Point();
            WMPosition = CalculateWMPosition(WM.Layout, WM.ImgWaterMark.Size, WM.OffSet, item.Image.Size);

            Bitmap img = new Bitmap(item.Image);
            Graphics grPhoto = Graphics.FromImage(img);

            if (WM.Layout == WaterMarkLayout.Fill)
            {
                SrcPosition.X = Math.Abs(WMPosition.X);
                SrcPosition.Y = Math.Abs(WMPosition.Y);
                WMPosition = new Point();
            }

            grPhoto.DrawImage(
                WM.ImgWaterMark,
                new Rectangle(WMPosition.X, WMPosition.Y, img.Width, img.Height),
                SrcPosition.X,
                SrcPosition.Y,
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
            Size NewWMSize = new Size();
            Point WMPosition = new Point();

            NewWMSize = CalculateWMSize(WM.Layout, WM.ImgWaterMark.Size, item.Image.Size);
            WMPosition = CalculateWMPosition(WM.Layout, NewWMSize, WM.OffSet, item.Image.Size);

            Bitmap imgPiece = new Bitmap(NewWMSize.Width, NewWMSize.Height, PixelFormat.Format24bppRgb);
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

            if (WM.Layout == WaterMarkLayout.Repeat)
            {
                DrawWaterMarkRepetition(ref WM, NewWMSize);
            }

            grPiece.DrawImage(
                WM.ImgWaterMark,
                new Rectangle(0, 0, NewWMSize.Width, NewWMSize.Height),
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

        private void DrawWaterMarkRepetition(ref clsImageWaterMark WM, Size NewWMSize)
        {
            Bitmap img = new Bitmap(NewWMSize.Width, NewWMSize.Height);
            Size aux = new Size();
            Size gap = new Size();
            double ratioWidth = ((double)NewWMSize.Width / (double)(WM.ImgWaterMark.Width * WM.Columns));
            double ratioHeight = ((double)NewWMSize.Height / (double)(WM.ImgWaterMark.Height * WM.Rows));


            //NewSize.Width = ImgSize.Width;
            //NewSize.Height = (int)(((double)ImgSize.Width / (double)WMSize.Width) * (double)WMSize.Height);

            if (ratioWidth > ratioHeight)
            {
                aux.Height = (int)((double)WM.Height * (double)ratioHeight);
                aux.Width = (int)((double)WM.Width * ((double)aux.Height / (double)WM.Height));
            }
            else 
            {
                aux.Width = (int)((double)WM.Width * (double)ratioWidth);
                aux.Height = (int)((double)WM.Height * ((double)aux.Width / (double)WM.Width));
            }

            gap.Width = (int)((NewWMSize.Width - (aux.Width * WM.Columns)) / WM.Columns);
            gap.Height = (int)((NewWMSize.Height - (aux.Height * WM.Rows)) / WM.Rows);
            
            Graphics grPiece = Graphics.FromImage(img);
            int posX = 0;
            int posY;
            for (int x = 0; x < WM.Columns; x++)
            {
                posY = 0;
                for (int y = 0; y < WM.Rows; y++)
                {

                    grPiece.DrawImage(
                        WM.ImgWaterMark,
                        new Rectangle(posX, posY, aux.Width, aux.Height),
                        0,
                        0,
                        WM.ImgWaterMark.Width,
                        WM.ImgWaterMark.Height,
                        GraphicsUnit.Pixel
                    );

                    posY += gap.Height + aux.Height;
                }
                posX += gap.Width + aux.Width;
            }
            WM.ImgWaterMark = img;
        }

        private Size CalculateWMSize(WaterMarkLayout Layout, Size WMSize, Size ImgSize)
        {
            Size NewSize = new Size(WMSize.Width, WMSize.Height);

            if (Layout == WaterMarkLayout.Zoom || Layout == WaterMarkLayout.Repeat)
            { 
                NewSize.Width = ImgSize.Width;
                NewSize.Height = ImgSize.Height;
            }
            else
            {
                if (WMSize.Width > WMSize.Height)
                {
                    if (Layout == WaterMarkLayout.Ajust)
                    {
                        NewSize.Width = ImgSize.Width;
                        NewSize.Height = (int)(((double)ImgSize.Width / (double)WMSize.Width) * (double)WMSize.Height);
                    }
                    else if (Layout == WaterMarkLayout.Fill)
                    {
                        NewSize.Width = (int)(((double)ImgSize.Height / (double)WMSize.Height) * (double)WMSize.Width);
                        NewSize.Height = ImgSize.Height;
                    }
                }
                else
                {
                    if (Layout == WaterMarkLayout.Ajust)
                    {
                        NewSize.Width = (int)(((double)ImgSize.Height) / (double)WMSize.Height * (double)WMSize.Width);
                        NewSize.Height = ImgSize.Height;
                    }
                    else if (Layout == WaterMarkLayout.Fill)
                    {
                        NewSize.Width = ImgSize.Width;
                        NewSize.Height = (int)(((double)ImgSize.Width) / (double)WMSize.Width * (double)WMSize.Height);
                    }
                }
            }

            return NewSize;
        }

    }
}
