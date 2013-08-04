namespace FreeWatermarker
{
    partial class frmWatermark
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridImages = new System.Windows.Forms.DataGridView();
            this.ColumnImg = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnOpenWaterMark = new System.Windows.Forms.Button();
            this.btnViewWaterMark = new System.Windows.Forms.Button();
            this.pbWatermark = new System.Windows.Forms.PictureBox();
            this.btnSaveImages = new System.Windows.Forms.Button();
            this.btnOpenImages = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClearSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.removeSelectedImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWatermark)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.ssStatus.SuspendLayout();
            this.cmsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBar
            // 
            this.pBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBar.Location = new System.Drawing.Point(400, 433);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(135, 19);
            this.pBar.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gridImages);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel1MinSize = 160;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel2MinSize = 300;
            this.splitContainer1.Size = new System.Drawing.Size(632, 428);
            this.splitContainer1.SplitterDistance = 160;
            this.splitContainer1.TabIndex = 3;
            // 
            // gridImages
            // 
            this.gridImages.AllowUserToAddRows = false;
            this.gridImages.AllowUserToResizeColumns = false;
            this.gridImages.AllowUserToResizeRows = false;
            this.gridImages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridImages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridImages.ColumnHeadersVisible = false;
            this.gridImages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnImg,
            this.ColumnDesc});
            this.gridImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridImages.Location = new System.Drawing.Point(0, 0);
            this.gridImages.Name = "gridImages";
            this.gridImages.ReadOnly = true;
            this.gridImages.RowHeadersVisible = false;
            this.gridImages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridImages.Size = new System.Drawing.Size(160, 428);
            this.gridImages.TabIndex = 0;
            this.gridImages.SelectionChanged += new System.EventHandler(this.gridImages_SelectionChanged);
            this.gridImages.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.gridImages_UserDeletingRow);
            this.gridImages.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridImages_MouseClick);
            // 
            // ColumnImg
            // 
            this.ColumnImg.HeaderText = "Image";
            this.ColumnImg.Name = "ColumnImg";
            this.ColumnImg.ReadOnly = true;
            // 
            // ColumnDesc
            // 
            this.ColumnDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.ColumnDesc.HeaderText = "Description";
            this.ColumnDesc.Name = "ColumnDesc";
            this.ColumnDesc.ReadOnly = true;
            this.ColumnDesc.Width = 5;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnOpenWaterMark);
            this.splitContainer2.Panel1.Controls.Add(this.btnViewWaterMark);
            this.splitContainer2.Panel1.Controls.Add(this.pbWatermark);
            this.splitContainer2.Panel1.Controls.Add(this.btnSaveImages);
            this.splitContainer2.Panel1.Controls.Add(this.btnOpenImages);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer2.Panel2.Controls.Add(this.pbImage);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer2.Size = new System.Drawing.Size(468, 428);
            this.splitContainer2.SplitterDistance = 150;
            this.splitContainer2.TabIndex = 2;
            // 
            // btnOpenWaterMark
            // 
            this.btnOpenWaterMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenWaterMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpenWaterMark.Location = new System.Drawing.Point(436, 118);
            this.btnOpenWaterMark.Name = "btnOpenWaterMark";
            this.btnOpenWaterMark.Size = new System.Drawing.Size(30, 30);
            this.btnOpenWaterMark.TabIndex = 9;
            this.btnOpenWaterMark.Text = "O";
            this.btnOpenWaterMark.UseVisualStyleBackColor = true;
            this.btnOpenWaterMark.Click += new System.EventHandler(this.btnOpenWaterMark_Click);
            // 
            // btnViewWaterMark
            // 
            this.btnViewWaterMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewWaterMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnViewWaterMark.Location = new System.Drawing.Point(398, 118);
            this.btnViewWaterMark.Name = "btnViewWaterMark";
            this.btnViewWaterMark.Size = new System.Drawing.Size(30, 30);
            this.btnViewWaterMark.TabIndex = 8;
            this.btnViewWaterMark.Text = "V";
            this.btnViewWaterMark.UseVisualStyleBackColor = true;
            this.btnViewWaterMark.Click += new System.EventHandler(this.btnViewWaterMark_Click);
            // 
            // pbWatermark
            // 
            this.pbWatermark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbWatermark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbWatermark.Location = new System.Drawing.Point(253, 3);
            this.pbWatermark.Name = "pbWatermark";
            this.pbWatermark.Size = new System.Drawing.Size(212, 115);
            this.pbWatermark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWatermark.TabIndex = 7;
            this.pbWatermark.TabStop = false;
            this.pbWatermark.DoubleClick += new System.EventHandler(this.pbWatermark_DoubleClick);
            // 
            // btnSaveImages
            // 
            this.btnSaveImages.BackgroundImage = global::FreeWatermarker.Properties.Resources.save;
            this.btnSaveImages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveImages.Location = new System.Drawing.Point(41, 3);
            this.btnSaveImages.Name = "btnSaveImages";
            this.btnSaveImages.Size = new System.Drawing.Size(30, 30);
            this.btnSaveImages.TabIndex = 5;
            this.btnSaveImages.UseVisualStyleBackColor = true;
            this.btnSaveImages.Click += new System.EventHandler(this.btnSaveImages_Click);
            // 
            // btnOpenImages
            // 
            this.btnOpenImages.BackgroundImage = global::FreeWatermarker.Properties.Resources.imagesCAWN35C4;
            this.btnOpenImages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpenImages.Location = new System.Drawing.Point(5, 3);
            this.btnOpenImages.Name = "btnOpenImages";
            this.btnOpenImages.Size = new System.Drawing.Size(30, 30);
            this.btnOpenImages.TabIndex = 4;
            this.btnOpenImages.UseVisualStyleBackColor = true;
            this.btnOpenImages.Click += new System.EventHandler(this.btnOpenImages_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(300, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(165, 124);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(157, 98);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.trackBar1);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(157, 98);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(157, 40);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 42);
            this.trackBar1.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(99, 59);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(157, 98);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pbImage
            // 
            this.pbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImage.Location = new System.Drawing.Point(0, 0);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(466, 272);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            this.pbImage.DoubleClick += new System.EventHandler(this.pbImage_DoubleClick);
            this.pbImage.MouseEnter += new System.EventHandler(this.pbImage_MouseEnter);
            this.pbImage.MouseLeave += new System.EventHandler(this.pbImage_MouseLeave);
            // 
            // ssStatus
            // 
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.ssStatus.Location = new System.Drawing.Point(0, 431);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(632, 22);
            this.ssStatus.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(539, 433);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 19);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cmsMenu
            // 
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSelectAll,
            this.tsmClearSelection,
            this.toolStripSeparator1,
            this.removeSelectedImagesToolStripMenuItem});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(194, 76);
            // 
            // tsmSelectAll
            // 
            this.tsmSelectAll.Name = "tsmSelectAll";
            this.tsmSelectAll.Size = new System.Drawing.Size(193, 22);
            this.tsmSelectAll.Text = "Select all";
            this.tsmSelectAll.Click += new System.EventHandler(this.selecionarTodasToolStripMenuItem_Click);
            // 
            // tsmClearSelection
            // 
            this.tsmClearSelection.Name = "tsmClearSelection";
            this.tsmClearSelection.Size = new System.Drawing.Size(193, 22);
            this.tsmClearSelection.Text = "Clear selection";
            this.tsmClearSelection.Click += new System.EventHandler(this.limparSeleçãoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(190, 6);
            // 
            // removeSelectedImagesToolStripMenuItem
            // 
            this.removeSelectedImagesToolStripMenuItem.Name = "removeSelectedImagesToolStripMenuItem";
            this.removeSelectedImagesToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.removeSelectedImagesToolStripMenuItem.Text = "Remove selected images";
            this.removeSelectedImagesToolStripMenuItem.Click += new System.EventHandler(this.removeSelectedImagesToolStripMenuItem_Click);
            // 
            // frmWatermark
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(460, 360);
            this.Name = "frmWatermark";
            this.Text = "Free Watermarker";
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmWatermark_DragEnter);
            this.DragLeave += new System.EventHandler(this.frmWatermark_DragLeave);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridImages)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbWatermark)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.cmsMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnOpenImages;
        private System.Windows.Forms.Button btnSaveImages;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmSelectAll;
        private System.Windows.Forms.ToolStripMenuItem tsmClearSelection;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.PictureBox pbWatermark;
        private System.Windows.Forms.DataGridView gridImages;
        private System.Windows.Forms.DataGridViewImageColumn ColumnImg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDesc;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedImagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btnOpenWaterMark;
        private System.Windows.Forms.Button btnViewWaterMark;
    }
}

