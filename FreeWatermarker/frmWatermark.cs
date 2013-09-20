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
    public partial class frmWatermark : Form
    {
        clsImageWaterMark imgWM;
        clsWaterMarker WaterMarker;
        public List<clsImageItem> images;
        bool WaterMarkHasTransparentColor;

        public frmWatermark()
        {
            InitializeComponent();

            WaterMarker = new clsWaterMarker();
            images = new List<clsImageItem>();
            WaterMarkHasTransparentColor = true;
            checkBox5.Checked = true;

            //TAB Pictures
            ImageList il = new ImageList();
            il.Images.Add(Properties.Resources.Image16x16);
            il.Images.Add(Properties.Resources.Text16x16);
            tabControl1.ImageList = il;
            tabPage1.ImageIndex = 0;
            tabPage2.ImageIndex = 1;
            //

            //loadImages(new string[] { "..\\..\\..\\..\\1.jpg", "..\\..\\..\\..\\2.jpg", "..\\..\\..\\..\\3.jpg", "..\\..\\..\\..\\4.jpg" });
            //LoadWaterMark("..\\..\\Images\\watermark.png");

            this.pbWatermark.AllowDrop = true;
            this.pbWatermark.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbWatermark_DragEnter);
            this.pbWatermark.DragLeave += new System.EventHandler(this.pbWatermark_DragLeave);
            this.pbWatermark.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbWatermark_DragDrop);
        }

        private void CreateOrUpdateImageWaterMark(Bitmap img = null)
        {
            if (img != null)
            {
                if (imgWM == null)
                {
                    imgWM = new clsImageWaterMark();
                }
                imgWM.ImgWaterMark = img;
            }
            if (imgWM != null)
            {
                imgWM.HasTransparentColor = WaterMarkHasTransparentColor;
                imgWM.TransparentColor = lblWMTransparentColor.BackColor;
                imgWM.Transparency = (int)nudTransparency.Value;
                imgWM.Layout = GetSelectedLayout();
                imgWM.OffSet.Width = (int)nudOffSetX.Value;
                imgWM.OffSet.Height = (int)nudOffSetY.Value;
                imgWM.Columns = (int)nudColumns.Value;
                imgWM.Rows = (int)nudRows.Value;

                SelectImageFromGrid();
                EnableDisableButtons(true);
            }
            else
            {
                EnableDisableButtons(false);
            }
        }

        private WaterMarkLayout GetSelectedLayout()
        {
            foreach (object obj in panelPosition.Controls)
            {
                if (obj.GetType() == typeof(CheckBox))
                {
                    CheckBox ck = (CheckBox)obj;
                    if (ck.Checked)
                    {
                        return  (WaterMarkLayout)(int.Parse(ck.Tag.ToString()));
                    }
                }
            }
            return WaterMarkLayout.MiddleCenter;
        }

        private void LoadWaterMark(string FileName)
        {
            try
            {
                Bitmap img  = new Bitmap(FileName);
                CreateOrUpdateImageWaterMark(img);
                pbWatermark.Image = img;
            }
            catch (Exception)
            {
                MessageBox.Show("There is a problem reading the watermark image: " + FileName, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadImages(string[] files)
        {
            if (files != null)
            {
                int index;
                gridImages.Enabled = false;

                foreach (string file in files)
                {
                    try
                    {
                        index = images.Count;
                    
                        images.Add(new clsImageItem(file));

                        gridImages.Rows.Add();
                        gridImages.Rows[index].Height = 100;
                        gridImages.Rows[index].Cells[0].Value = images[index].ResizeToFill(95);
                        gridImages.Rows[index].Cells[1].Value = images[index].Description();
                        gridImages.Enabled = true;                        	
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("There is a problem reading this image: " + file, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                gridImages.Enabled = true;
                gridImages.AutoResizeColumn(1);
            }
        }

        private void btnOpenImages_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdOpen = new OpenFileDialog();
            ofdOpen.Filter = "Imagens|*.bmp;*.jpg;*.png|Imagens Bitmap|*.bmp|Imagens jpg|*.jpg|Imagens png|*.png";
            ofdOpen.Multiselect = true;
            ofdOpen.Title = "Open original images";

            if (ofdOpen.ShowDialog() == DialogResult.OK)
            {
                loadImages(ofdOpen.FileNames);
            }
        }

        private void btnSaveImages_Click(object sender, EventArgs e)
        {
            if (imgWM != null)
            {
                for (int x = 0; x < images.Count; x++)
                {
                    if (images[x].WaterMarks.Count == 0)
                    {
                        images[x].WaterMarks.Add(imgWM.Clone());
                    }
                    else
                    {
                        images[x].WaterMarks[0] = imgWM.Clone();
                    }
                }

                frmSave f = new frmSave(ref images);
                f.ShowDialog();
                f.Dispose();
            }
            else
            {
                MessageBox.Show("I order to save you need to create a watermark first!", "`Nothing to do!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void selecionarTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
                gridImages.SelectAll();
        }

        private void limparSeleçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridImages.ClearSelection();
        }

        private void pbImage_MouseEnter(object sender, EventArgs e)
        {
            lblStatus.Text = "Double click to preview in full screen";
        }

        private void pbImage_MouseLeave(object sender, EventArgs e)
        {
            lblStatus.Text = "";
        }

        private void pbImage_DoubleClick(object sender, EventArgs e)
        {
            frmPreview f = new frmPreview(pbImage.Image);
            f.ShowDialog(this);
            f.Dispose();
        }

        private void frmWatermark_DragLeave(object sender, EventArgs e)
        {
            pbWatermark.BorderStyle = BorderStyle.FixedSingle;
            gridImages.BorderStyle = BorderStyle.None;
        }

        private void frmWatermark_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
            pbWatermark.BorderStyle = BorderStyle.FixedSingle;
            gridImages.BorderStyle = BorderStyle.FixedSingle;
        }

        private void frmWatermark_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            loadImages(files);
        }

        private void pbWatermark_DragLeave(object sender, EventArgs e)
        {
            //this.Cursor = Cursors.Default;
            pbWatermark.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pbWatermark_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            //this.Cursor = Cursors.Hand;
            pbWatermark.BorderStyle = BorderStyle.Fixed3D;

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            //((string[])e.Data.GetData(DataFormats.FileDrop)).Count()
        }

        private void pbWatermark_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            LoadWaterMark(files[0]);
        }

        private void gridImages_SelectionChanged(object sender, EventArgs e)
        {
            SelectImageFromGrid();
        }

        private void SelectImageFromGrid()
        {
            if (gridImages.SelectedCells.Count > 0)
            {
                SelectImage(gridImages.SelectedCells[0].RowIndex);
            }
            else
            {
                SelectImage(-1);
            }        
        }

        private void SelectImage(int index)
        {
            if (index < 0 || images.Count == 0)
            {
                pbImage.Image = null;
            }
            else if (imgWM == null) 
            {
                pbImage.Image = images[index].Image;
            }
            else
            {
                if (images[index].WaterMarks.Count <= 0)
                {
                    images[index].WaterMarks.Add(imgWM.Clone());
                    WaterMarker.CreateWaterMark(images[index]);
                }
                else if (images[index].WaterMarks[0] != imgWM)
                {
                    images[index].WaterMarks[0] = imgWM.Clone();
                    WaterMarker.CreateWaterMark(images[index]);
                }
                pbImage.Image = WaterMarker.insertWaterMark(images[index]);
            }
        }

        private void gridImages_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (!deleteImage(e.Row.Index))
            {
                e.Cancel = true;
            }
        }

        private bool deleteImage(int index)
        {
            try
            {
                images.RemoveAt(index);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void gridImages_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                cmsImages.Show(gridImages, e.X, e.Y);
            }
        }

        private void removeSelectedImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in gridImages.SelectedRows)
            {
                deleteImage(r.Index);
                gridImages.Rows.Remove(r);
            }
        }

        private void btnOpenWaterMark_Click(object sender, EventArgs e)
        {
            OpeWaterMark();
            SelectImageFromGrid();
        }

        private void pbWatermark_DoubleClick(object sender, EventArgs e)
        {
            OpeWaterMark();
            SelectImageFromGrid();
        }

        private void OpeWaterMark()
        {
            OpenFileDialog ofdOpen = new OpenFileDialog();
            ofdOpen.Filter = "Imagens|*.bmp;*.jpg;*.png|Imagens Bitmap|*.bmp|Imagens jpg|*.jpg|Imagens png|*.png";
            ofdOpen.Multiselect = false;
            ofdOpen.Title = "Open Watermark";

            if (ofdOpen.ShowDialog() == DialogResult.OK)
            {
                LoadWaterMark(ofdOpen.FileName);
            }
        }

        private void btnViewWaterMark_Click(object sender, EventArgs e)
        {
            if (imgWM != null)
            {
                frmPreview f = new frmPreview(imgWM.ImgWaterMark);
                f.ShowDialog(this);
                f.Dispose();
            }
        }

        private void SelectWMTransparentColor()
        {           
            ColorDialog cdSelectColor = new System.Windows.Forms.ColorDialog();
            DialogResult res = cdSelectColor.ShowDialog();
            if (res == DialogResult.OK)
            {
                WaterMarkHasTransparentColor = true;
                lblWMTransparentColor.BackColor = cdSelectColor.Color;
                CreateOrUpdateImageWaterMark();
            }
        }

        private void lblWMTransparentColor_MouseDown(object sender, MouseEventArgs e)
        {
            cmsTransparentColor.Show(lblWMTransparentColor, e.X, e.Y);
        }

        private void tsmSelectColor_Click(object sender, EventArgs e)
        {
            SelectWMTransparentColor();
        }

        private void tsmRemoveColor_Click(object sender, EventArgs e)
        {
            WaterMarkHasTransparentColor = false;
            lblWMTransparentColor.BackColor = SystemColors.InactiveCaption;
            lblWMTransparentColor.Text = "N";
            CreateOrUpdateImageWaterMark();
        }

        private void checkBoxPosition_Click(object sender, EventArgs e)
        {
            foreach (object obj in panelPosition.Controls)
            {
                if (obj.GetType() == typeof(CheckBox))
                {
                    CheckBox ck = (CheckBox)obj;
                    ck.Checked = ck == (CheckBox)sender;
                    if (imgWM != null)
                    {
                        if (ck.Checked)
                        {
                            imgWM.Layout = (WaterMarkLayout)(int.Parse(((CheckBox)sender).Tag.ToString()));
                            lblColumns.Enabled = imgWM.Layout == WaterMarkLayout.Repeat;
                            lblRows.Enabled = imgWM.Layout == WaterMarkLayout.Repeat;
                            nudColumns.Enabled = imgWM.Layout == WaterMarkLayout.Repeat;
                            nudRows.Enabled = imgWM.Layout == WaterMarkLayout.Repeat;

                            CreateOrUpdateImageWaterMark();
                        }
                    }
                }
            }
        }

        private void nud_ValueChanged(object sender, EventArgs e)
        {
            CreateOrUpdateImageWaterMark();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout f = new frmAbout();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnRemoveImageWaterMark_Click(object sender, EventArgs e)
        {
            imgWM = null;
            pbWatermark.Image = null;
            EnableDisableButtons(false);
            SelectImageFromGrid();
        }

        private void EnableDisableButtons(bool enabled) 
        {
            panelWMImage.Enabled = enabled;
        }
    }
}
