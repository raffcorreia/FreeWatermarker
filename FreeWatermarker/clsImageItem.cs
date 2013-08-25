using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace FreeWatermarker
{

    public class clsImageItem
    {
        private Bitmap _image;
        public Bitmap Image
        {
            get { return _image; }
            set { _image = value; }
        }

        private string _url;
        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }

        private List<clsWaterMark> _WaterMarks;
        public List<clsWaterMark> WaterMarks
        {
            get { return _WaterMarks; }
            set { _WaterMarks = value; }
        }
            
        public clsImageItem(string url)
        {
            try
            {
                _url = url;
                FileStream fs = new FileStream(_url, FileMode.Open);
                _image = new Bitmap(fs);
                fs.Close();

                _WaterMarks = new List<clsWaterMark>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Image ResizeToFill(int squareSize)
        {
            if (_image != null)
            {
                int width, height;
                if (_image.Height > _image.Width)
                {
                    height = squareSize;
                    width = (int)((double)_image.Width * (double)squareSize / (double)_image.Width);
                }
                else 
                {
                    width = squareSize;
                    height = (int)((double)_image.Height * (double)squareSize / (double)_image.Width);
                }
                return new Bitmap(_image, width, height);
            }
            else
            {
                return null;
            }
        }

        public string FileName()
        {
            return _url.Substring(_url.LastIndexOf("\\") + 1, (_url.Length - _url.LastIndexOf("\\") - 1));
        }

        public string FileExtension()
        {
            return _url.Substring(_url.LastIndexOf("."), (_url.Length - _url.LastIndexOf(".")));
        }

        public string Description()
        {
            return FileName() + "\r\n" + "Size: w" + _image.Width.ToString() + ", h" + _image.Height.ToString();
        }
    }
}
