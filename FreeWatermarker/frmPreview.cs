﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FreeWatermarker
{
    public partial class frmPreview : Form
    {
        public frmPreview(Image img)
        {
            InitializeComponent();
            pbImage.Image = img;
        }

        private void frmPreview_KeyDown(object sender, KeyEventArgs e)
        {
              if( e.KeyCode  == Keys.Escape)
                  this.Close();
        }

        private void pbImage_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
