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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWatermark));
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridImages = new System.Windows.Forms.DataGridView();
            this.ColumnImg = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnAbout = new System.Windows.Forms.Button();
            this.nudOffSetY = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudTransparency = new System.Windows.Forms.NumericUpDown();
            this.nudOffSetX = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelPosition = new System.Windows.Forms.Panel();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWMTransparentColor = new System.Windows.Forms.Label();
            this.btnSelectColor = new System.Windows.Forms.Button();
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
            this.cmsImages = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClearSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.removeSelectedImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTransparentColor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmSelectColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRemoveColor = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffSetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTransparency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffSetX)).BeginInit();
            this.panelPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWatermark)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.ssStatus.SuspendLayout();
            this.cmsImages.SuspendLayout();
            this.cmsTransparentColor.SuspendLayout();
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
            this.pBar.Visible = false;
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
            this.splitContainer2.Panel1.Controls.Add(this.btnAbout);
            this.splitContainer2.Panel1.Controls.Add(this.nudOffSetY);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.nudTransparency);
            this.splitContainer2.Panel1.Controls.Add(this.nudOffSetX);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.panelPosition);
            this.splitContainer2.Panel1.Controls.Add(this.lblWMTransparentColor);
            this.splitContainer2.Panel1.Controls.Add(this.btnSelectColor);
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
            // btnAbout
            // 
            this.btnAbout.BackgroundImage = global::FreeWatermarker.Properties.Resources.Info32x32;
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAbout.Location = new System.Drawing.Point(3, 118);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(30, 30);
            this.btnAbout.TabIndex = 20;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // nudOffSetY
            // 
            this.nudOffSetY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudOffSetY.Location = new System.Drawing.Point(119, 72);
            this.nudOffSetY.Name = "nudOffSetY";
            this.nudOffSetY.Size = new System.Drawing.Size(42, 20);
            this.nudOffSetY.TabIndex = 18;
            this.nudOffSetY.ValueChanged += new System.EventHandler(this.nudOffSetY_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "OffSet Y %";
            // 
            // nudTransparency
            // 
            this.nudTransparency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudTransparency.Location = new System.Drawing.Point(119, 30);
            this.nudTransparency.Name = "nudTransparency";
            this.nudTransparency.Size = new System.Drawing.Size(42, 20);
            this.nudTransparency.TabIndex = 16;
            this.nudTransparency.ValueChanged += new System.EventHandler(this.nudTransparency_ValueChanged);
            // 
            // nudOffSetX
            // 
            this.nudOffSetX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudOffSetX.Location = new System.Drawing.Point(119, 51);
            this.nudOffSetX.Name = "nudOffSetX";
            this.nudOffSetX.Size = new System.Drawing.Size(42, 20);
            this.nudOffSetX.TabIndex = 14;
            this.nudOffSetX.ValueChanged += new System.EventHandler(this.nudOffSetX_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Transparency %";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "OffSet X %";
            // 
            // panelPosition
            // 
            this.panelPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPosition.Controls.Add(this.checkBox9);
            this.panelPosition.Controls.Add(this.checkBox8);
            this.panelPosition.Controls.Add(this.checkBox7);
            this.panelPosition.Controls.Add(this.checkBox6);
            this.panelPosition.Controls.Add(this.checkBox5);
            this.panelPosition.Controls.Add(this.checkBox3);
            this.panelPosition.Controls.Add(this.checkBox2);
            this.panelPosition.Controls.Add(this.checkBox1);
            this.panelPosition.Controls.Add(this.checkBox4);
            this.panelPosition.Controls.Add(this.label1);
            this.panelPosition.Location = new System.Drawing.Point(163, 3);
            this.panelPosition.Name = "panelPosition";
            this.panelPosition.Size = new System.Drawing.Size(100, 115);
            this.panelPosition.TabIndex = 13;
            // 
            // checkBox9
            // 
            this.checkBox9.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox9.Location = new System.Drawing.Point(65, 78);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(30, 30);
            this.checkBox9.TabIndex = 25;
            this.checkBox9.Tag = "1024";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.Click += new System.EventHandler(this.checkBoxPosition_Click);
            // 
            // checkBox8
            // 
            this.checkBox8.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox8.Location = new System.Drawing.Point(34, 78);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(30, 30);
            this.checkBox8.TabIndex = 24;
            this.checkBox8.Tag = "512";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.Click += new System.EventHandler(this.checkBoxPosition_Click);
            // 
            // checkBox7
            // 
            this.checkBox7.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox7.Location = new System.Drawing.Point(3, 78);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(30, 30);
            this.checkBox7.TabIndex = 23;
            this.checkBox7.Tag = "256";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.Click += new System.EventHandler(this.checkBoxPosition_Click);
            // 
            // checkBox6
            // 
            this.checkBox6.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox6.Location = new System.Drawing.Point(65, 47);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(30, 30);
            this.checkBox6.TabIndex = 22;
            this.checkBox6.Tag = "64";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.Click += new System.EventHandler(this.checkBoxPosition_Click);
            // 
            // checkBox5
            // 
            this.checkBox5.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox5.Location = new System.Drawing.Point(34, 47);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(30, 30);
            this.checkBox5.TabIndex = 21;
            this.checkBox5.Tag = "32";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.Click += new System.EventHandler(this.checkBoxPosition_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox3.Location = new System.Drawing.Point(65, 16);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(30, 30);
            this.checkBox3.TabIndex = 20;
            this.checkBox3.Tag = "4";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Click += new System.EventHandler(this.checkBoxPosition_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.Location = new System.Drawing.Point(34, 16);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(30, 30);
            this.checkBox2.TabIndex = 19;
            this.checkBox2.Tag = "2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Click += new System.EventHandler(this.checkBoxPosition_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.Location = new System.Drawing.Point(3, 16);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(30, 30);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Tag = "1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBoxPosition_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox4.Location = new System.Drawing.Point(3, 47);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(30, 30);
            this.checkBox4.TabIndex = 17;
            this.checkBox4.Tag = "16";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.Click += new System.EventHandler(this.checkBoxPosition_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 11);
            this.label1.TabIndex = 5;
            this.label1.Text = "Position";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWMTransparentColor
            // 
            this.lblWMTransparentColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWMTransparentColor.BackColor = System.Drawing.Color.White;
            this.lblWMTransparentColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWMTransparentColor.Location = new System.Drawing.Point(265, 118);
            this.lblWMTransparentColor.Name = "lblWMTransparentColor";
            this.lblWMTransparentColor.Size = new System.Drawing.Size(30, 30);
            this.lblWMTransparentColor.TabIndex = 12;
            this.lblWMTransparentColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWMTransparentColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblWMTransparentColor_MouseDown);
            // 
            // btnSelectColor
            // 
            this.btnSelectColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectColor.BackgroundImage = global::FreeWatermarker.Properties.Resources.ColorPicker32x32;
            this.btnSelectColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSelectColor.Location = new System.Drawing.Point(295, 118);
            this.btnSelectColor.Name = "btnSelectColor";
            this.btnSelectColor.Size = new System.Drawing.Size(30, 30);
            this.btnSelectColor.TabIndex = 11;
            this.btnSelectColor.UseVisualStyleBackColor = true;
            this.btnSelectColor.Visible = false;
            // 
            // btnOpenWaterMark
            // 
            this.btnOpenWaterMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenWaterMark.BackgroundImage = global::FreeWatermarker.Properties.Resources.Open32x32;
            this.btnOpenWaterMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpenWaterMark.Location = new System.Drawing.Point(436, 118);
            this.btnOpenWaterMark.Name = "btnOpenWaterMark";
            this.btnOpenWaterMark.Size = new System.Drawing.Size(30, 30);
            this.btnOpenWaterMark.TabIndex = 9;
            this.btnOpenWaterMark.UseVisualStyleBackColor = true;
            this.btnOpenWaterMark.Click += new System.EventHandler(this.btnOpenWaterMark_Click);
            // 
            // btnViewWaterMark
            // 
            this.btnViewWaterMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewWaterMark.BackgroundImage = global::FreeWatermarker.Properties.Resources.Preview32x32;
            this.btnViewWaterMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnViewWaterMark.Location = new System.Drawing.Point(398, 118);
            this.btnViewWaterMark.Name = "btnViewWaterMark";
            this.btnViewWaterMark.Size = new System.Drawing.Size(30, 30);
            this.btnViewWaterMark.TabIndex = 8;
            this.btnViewWaterMark.UseVisualStyleBackColor = true;
            this.btnViewWaterMark.Click += new System.EventHandler(this.btnViewWaterMark_Click);
            // 
            // pbWatermark
            // 
            this.pbWatermark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbWatermark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbWatermark.Location = new System.Drawing.Point(265, 3);
            this.pbWatermark.Name = "pbWatermark";
            this.pbWatermark.Size = new System.Drawing.Size(200, 115);
            this.pbWatermark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWatermark.TabIndex = 7;
            this.pbWatermark.TabStop = false;
            this.pbWatermark.DoubleClick += new System.EventHandler(this.pbWatermark_DoubleClick);
            // 
            // btnSaveImages
            // 
            this.btnSaveImages.BackgroundImage = global::FreeWatermarker.Properties.Resources.Save32x32;
            this.btnSaveImages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveImages.Location = new System.Drawing.Point(3, 38);
            this.btnSaveImages.Name = "btnSaveImages";
            this.btnSaveImages.Size = new System.Drawing.Size(30, 30);
            this.btnSaveImages.TabIndex = 5;
            this.btnSaveImages.UseVisualStyleBackColor = true;
            this.btnSaveImages.Click += new System.EventHandler(this.btnSaveImages_Click);
            // 
            // btnOpenImages
            // 
            this.btnOpenImages.BackgroundImage = global::FreeWatermarker.Properties.Resources.Open32x32;
            this.btnOpenImages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpenImages.Location = new System.Drawing.Point(2, 2);
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
            this.pbImage.Click += new System.EventHandler(this.pbImage_Click);
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
            this.btnCancel.Visible = false;
            // 
            // cmsImages
            // 
            this.cmsImages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSelectAll,
            this.tsmClearSelection,
            this.toolStripSeparator1,
            this.removeSelectedImagesToolStripMenuItem});
            this.cmsImages.Name = "cmsMenu";
            this.cmsImages.Size = new System.Drawing.Size(194, 76);
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
            // cmsTransparentColor
            // 
            this.cmsTransparentColor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSelectColor,
            this.tsmRemoveColor});
            this.cmsTransparentColor.Name = "cmsMenu";
            this.cmsTransparentColor.Size = new System.Drawing.Size(142, 48);
            // 
            // tsmSelectColor
            // 
            this.tsmSelectColor.Name = "tsmSelectColor";
            this.tsmSelectColor.Size = new System.Drawing.Size(141, 22);
            this.tsmSelectColor.Text = "Select Color";
            this.tsmSelectColor.Click += new System.EventHandler(this.tsmSelectColor_Click);
            // 
            // tsmRemoveColor
            // 
            this.tsmRemoveColor.Name = "tsmRemoveColor";
            this.tsmRemoveColor.Size = new System.Drawing.Size(141, 22);
            this.tsmRemoveColor.Text = "Remove Color";
            this.tsmRemoveColor.Click += new System.EventHandler(this.tsmRemoveColor_Click);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(570, 360);
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
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudOffSetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTransparency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffSetX)).EndInit();
            this.panelPosition.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbWatermark)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.cmsImages.ResumeLayout(false);
            this.cmsTransparentColor.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip cmsImages;
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
        private System.Windows.Forms.Label lblWMTransparentColor;
        private System.Windows.Forms.Button btnSelectColor;
        private System.Windows.Forms.ContextMenuStrip cmsTransparentColor;
        private System.Windows.Forms.ToolStripMenuItem tsmSelectColor;
        private System.Windows.Forms.ToolStripMenuItem tsmRemoveColor;
        private System.Windows.Forms.Panel panelPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudOffSetX;
        private System.Windows.Forms.NumericUpDown nudTransparency;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown nudOffSetY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAbout;
    }
}

