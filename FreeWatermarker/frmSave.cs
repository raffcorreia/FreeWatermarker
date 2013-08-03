using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FreeWatermarker
{
    public partial class frmSave : Form
    {
        public frmSave()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Save!");
        }

        private void btnCalcelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkChangeNames_CheckedChanged(object sender, EventArgs e)
        {
            gpbSerieName.Enabled = chkChangeNames.Checked;
        }

        private void chkCreateFolder_CheckedChanged(object sender, EventArgs e)
        {
            gpbCreateFolder.Enabled = chkCreateFolder.Checked;
        }

    }
}
