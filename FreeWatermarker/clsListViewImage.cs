using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace FreeWatermarker
{
    class clsListViewImage : ListViewItem
    {
        public clsListViewImage(String caption, int imageIndex, string texto) : base(caption, imageIndex) 
        {
            this.teste = texto;
        }

        private String teste;
        public String Teste
        {
            get { return teste; }
            set { teste = value; }
        }

        private Bitmap imagemOriginal;
        public Bitmap ImagemOriginal
        {
            get { return imagemOriginal; }
            set { imagemOriginal = value; }
        }

    }
}
