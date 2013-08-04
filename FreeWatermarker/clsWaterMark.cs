using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace FreeWatermarker
{
    static class clsWaterMark
    {
        private static Bitmap _waterMark;
        public static Bitmap WaterMark
        {
            get { return clsWaterMark._waterMark; }
            set { clsWaterMark._waterMark = value; }
        }

        static clsWaterMark()
        {

        }

        public static Image insertWaterMark(Bitmap img)
        {
            if (_waterMark != null && img != null)
            {
                int x, y, r, g, b;
                uint traspUnit = 4294506744;        // 4294967295;// ;//16316664;
                int transparent = (int)traspUnit;   //4294967295;
                float a;
                a = 0.5f;

                for (y = 0; y < _waterMark.Height; y++)
                {
                    for (x = 0; x < _waterMark.Width; x++)
                    {

                        //if (!((w.GetPixel(x, y).ToArgb() > Color.FromArgb(240, 240, 240).ToArgb()) && (w.GetPixel(x, y).ToArgb() < Color.FromArgb(255, 255, 255).ToArgb())))
                        if (_waterMark.GetPixel(x, y).ToArgb() < transparent)
                        {
                            r = (int)((1 - a) * img.GetPixel(x + 30, y + 120).R + a * _waterMark.GetPixel(x, y).R);
                            g = (int)((1 - a) * img.GetPixel(x + 30, y + 120).G + a * _waterMark.GetPixel(x, y).G);
                            b = (int)((1 - a) * img.GetPixel(x + 30, y + 120).B + a * _waterMark.GetPixel(x, y).B);
                            img.SetPixel(x + 30, y + 120, Color.FromArgb(r, g, b));
                        }
                    }
                }
            }
            return img;
        }

    }
}
