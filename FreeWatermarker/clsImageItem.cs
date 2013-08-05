using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace FreeWatermarker
{

    public class clsImageItem : ListViewItem
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

        private bool _WMHasTransparency;
        public bool WMHasTransparency
        {
            get { return _WMHasTransparency; }
            set { _WMHasTransparency = value; }
        }

        private Color _WMTransparentColor;
        public Color WMTransparentColor
        {
            get { return _WMTransparentColor; }
            set { _WMTransparentColor = value; }
        }

        private ContentAlignment _WMAlignment;
        public ContentAlignment WMAlignment
        {
            get { return _WMAlignment; }
            set { _WMAlignment = value; }
        }

        private int _WMTransparency;
        public int WMTransparency
        {
            get { return _WMTransparency; }
            set { _WMTransparency = value; }
        }

        private int _WMHashCode;
        public int WMHashCode
        {
            get { return _WMHashCode; }
            set { _WMHashCode = value; }
        }

        private Bitmap _imgWMCut;
        public Bitmap ImgWMCut
        {
            get { return _imgWMCut; }
            set { _imgWMCut = value; }
        }

        public Size WMOffSet;
            
        public clsImageItem(string url)
        {
            try
            {
                _url = url;
                FileStream fs = new FileStream(_url, FileMode.Open);
                _image = new Bitmap(fs);
                fs.Close();
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
