using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Resources;

namespace FreeWatermarker
{
    public partial class frmWatermark : Form
    {
        public frmWatermark()
        {
            InitializeComponent();

            loadImages();
        }

        private void loadImages()
        {
            //Put one image no the tab
            ImageList il = new ImageList();
            IContainer ic = new Container();
            il.Images.Add(Properties.Resources.save);
            tabControl1.ImageList = il;
            tabPage1.ImageIndex = 0;
            //-----------------------------------------
            
            lvImages.AllowColumnReorder = true;
            lvImages.FullRowSelect = true;

            // Create three items and three sets of subitems for each item.
            clsListViewImage item1 = new clsListViewImage("item1", 0, "ah ha!");
            item1.Text = "Text 1";
            item1.ImageIndex = 0;
            item1.Teste = "Ha! Ha! Ha! 2.0";
            //---
            clsListViewImage item2 = new clsListViewImage("item2", 0, "ah ha2!");
            item2.Text = "Text 2";
            item2.ImageIndex = 1;
            item2.Teste = "TESTE www";
            //---
            clsListViewImage item3 = new clsListViewImage("item3", 0, "ah ha3!");
            item3.Text = "Text 3";
            item3.ImageIndex = 2;
            item3.Teste = "TESTE qqq";
            //---
            clsListViewImage item4 = new clsListViewImage("item4", 0, "ah ha4!");
            item4.Text = "Text 4";
            item4.ImageIndex = 3;
            item4.Teste = "TESTE xxx";
            //--

            lvImages.Items.AddRange(new ListViewItem[] { item1, item2, item3, item4 });
            
            ImageList imageListLarge = new ImageList();
            imageListLarge.ImageSize = new Size(75, 75);

            item1.ImagemOriginal = new Bitmap("..\\..\\..\\..\\1.jpg");
            item2.ImagemOriginal = new Bitmap("..\\..\\..\\..\\2.jpg");
            item3.ImagemOriginal = new Bitmap("..\\..\\..\\..\\3.jpg");
            item4.ImagemOriginal = new Bitmap("..\\..\\..\\..\\4.jpg");

            imageListLarge.Images.Add(item1.ImagemOriginal);
            imageListLarge.Images.Add(item2.ImagemOriginal);
            imageListLarge.Images.Add(item3.ImagemOriginal);
            imageListLarge.Images.Add(item4.ImagemOriginal);

            /*
            imageListLarge.Images.Add(Bitmap.FromFile("..\\..\\..\\..\\1.jpg"));
            imageListLarge.Images.Add(Bitmap.FromFile("..\\..\\..\\..\\2.jpg"));
            imageListLarge.Images.Add(Bitmap.FromFile("..\\..\\..\\..\\3.jpg"));
            imageListLarge.Images.Add(Bitmap.FromFile("..\\..\\..\\..\\4.jpg"));
            */
            lvImages.LargeImageList = imageListLarge;

            insertWaterMark();
        }

        private void insertWaterMark()
        {
            Bitmap w = new Bitmap("..\\..\\..\\..\\Watermark.bmp");
            Bitmap img = new Bitmap("..\\..\\..\\..\\1.jpg");
            int x, y, r, g, b;
            uint teste = 4294506744;// 4294967295;// ;//16316664;
            int transparente = (int)teste;//4294967295;
            float a;
            a = 0.5f;

            for (y = 0; y < w.Height; y++)
            {
                for (x = 0; x < w.Width; x++)
                {
                    
                    //if (!((w.GetPixel(x, y).ToArgb() > Color.FromArgb(240, 240, 240).ToArgb()) && (w.GetPixel(x, y).ToArgb() < Color.FromArgb(255, 255, 255).ToArgb())))
                    if (w.GetPixel(x, y).ToArgb() < transparente)
                    {
                        r = (int)((1 - a) * img.GetPixel(x + 30, y + 120).R + a * w.GetPixel(x, y).R);
                        g = (int)((1 - a) * img.GetPixel(x + 30, y + 120).G + a * w.GetPixel(x, y).G);
                        b = (int)((1 - a) * img.GetPixel(x + 30, y + 120).B + a * w.GetPixel(x, y).B);
                        img.SetPixel(x+30, y+120, Color.FromArgb(r, g, b));   
                    }
                }
            }
            pbImage.Image = img;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            System.IO.Stream myStream = null;
            OpenFileDialog ofdOpen = new OpenFileDialog();
            ofdOpen.Filter = "Imagens|*.bmp;*.jpg;*.png|Imagens Bitmap|*.bmp|Imagens jpg|*.jpg|Imagens png|*.png"; 
            //ofdOpen.ShowDialog();

            if (ofdOpen.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = ofdOpen.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: Não foi possível ler os arquivos do disco: " + ex.Message);
                }
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmSave f = new frmSave();
            f.ShowDialog();
        }

        private void lvImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lvImages.SelectedItems[0].ImageIndex
            if (lvImages.SelectedItems.Count > 0)
            {
                //pbImage.Image = lvImages.LargeImageList.Images[lvImages.SelectedItems[0].ImageIndex];
                pbImage.Image = ((clsListViewImage)lvImages.SelectedItems[0]).ImagemOriginal;
                this.Text = ((clsListViewImage)lvImages.SelectedItems[0]).Teste;
            }
        }

        private void lvImages_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                cmsMenu.Show(lvImages, e.X, e.Y);
            }
        }

        private void selecionarTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem i in lvImages.Items)
            {
                i.Selected = true;
                i.Checked = true;
            }
        }

        private void limparSeleçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in lvImages.Items)
            {
                i.Selected = false;
                i.Checked = false;
            }
        }
    }
}
