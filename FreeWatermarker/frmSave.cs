using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FreeWatermarker
{
    public partial class frmSave : Form
    {
        public clsWaterMarker WaterMark;
        public List<clsImageItem> images;

        public frmSave(ref List<clsImageItem> imageList, clsWaterMarker WMark)
        {
            InitializeComponent();

            WaterMark = WMark;
            images = imageList;

            if (images == null)
            {
                impossibleToSave("There is no images to save!");
            }
            else if (images.Count <= 0)
            {
                impossibleToSave("There is no images to save!");
            }
            else
            {
                bool applied = true;
                int x = 0;
                while (x < images.Count && images[x].WaterMarkerApplied == false)
                {
                    applied = images[x].WaterMarkerApplied;
                    x++;
                }
                if (!applied)
                {
                    impossibleToSave("You never applied your WaterMarks changes. You need to apply before save!");
                }
            }

        }

        private void impossibleToSave(string msg)
        {
            MessageBox.Show(msg, "What images?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.btnSave.Enabled = false;
            this.rbReplace.Enabled = false;
            this.rbReplace.Checked = false;
            this.rbKeep.Enabled = false;
            this.rbKeep.Checked = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int ret = prepareAndSave();
            if (ret > 0)
            {
                MessageBox.Show(ret.ToString() + " of " + images.Count.ToString() + " images was saved!", "Finish!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private int prepareAndSave()
        {
            if (rbReplace.Checked)
            {
                DialogResult res = MessageBox.Show("This operation will replace the original files.\n\rDo you want to continue?", "Replace?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == System.Windows.Forms.DialogResult.Yes)
                {
                    return SaveFiles("", "") - 1;
                }
            }
            else
            {
                string seqName = "";
                if (chkChangeNames.Checked)
                {
                    seqName = txtSeqName.Text;
                }

                string folder = "";
                if (chkCreateFolder.Checked)
                {
                    folder = txtFolderName.Text;
                    try
                    {
                        folder = images[0].Url.Substring(0, images[0].Url.LastIndexOf("\\") + 1) + folder;
                        if (Directory.CreateDirectory(folder) != null)
                        {
                            return SaveFiles(folder, seqName) - 1;
                        }
                        else
                        {
                            MessageBox.Show("Erro creating folder.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erro creating folder.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (chkChangeNames.Checked == false)
                    {
                        MessageBox.Show("You must change the original names or create a folder or both, otherwise your files will be replaced.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        return SaveFiles("", seqName) - 1;
                    }
                }
            }
            return 0;
        }

        private int SaveFiles(string folder, string seqName)
        {
            string fileName;
            int count = 1;
            
            foreach (clsImageItem item in images)
            {
                if (folder != "")
                {
                    if (folder[folder.Length - 1] != '\\')
                    {
                        folder += "\\";
                    }

                }
                if (seqName != "")
                {
                    fileName = seqName + "_" + count.ToString() + item.FileExtension();
                }
                else if(folder == "")
                {
                    fileName = item.Url;
                }
                else
                {
                    fileName = item.FileName();
                }
                try
                {
                    if (File.Exists(folder + fileName))
                    {
                        File.Delete(folder + fileName);
                    }
                    Bitmap teste = new Bitmap(item.Image);
                    teste.Save(folder + fileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro saving file.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                count++;
            }
            return count;
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

        private void rbReplace_CheckedChanged(object sender, EventArgs e)
        {
            gpbReplace.Enabled = rbReplace.Checked;
        }

        private void rbKeep_CheckedChanged(object sender, EventArgs e)
        {
            gpbKeep.Enabled = rbKeep.Checked;
        }

    }
}
