namespace FreeWatermarker
{
    partial class frmSave
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
            this.label1 = new System.Windows.Forms.Label();
            this.chkChangeNames = new System.Windows.Forms.CheckBox();
            this.txtSeqName = new System.Windows.Forms.TextBox();
            this.gpbSerieName = new System.Windows.Forms.GroupBox();
            this.chkCreateFolder = new System.Windows.Forms.CheckBox();
            this.gpbCreateFolder = new System.Windows.Forms.GroupBox();
            this.txtFolderName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gpbKeep = new System.Windows.Forms.GroupBox();
            this.gpbReplace = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbReplace = new System.Windows.Forms.RadioButton();
            this.rbKeep = new System.Windows.Forms.RadioButton();
            this.gpbSerieName.SuspendLayout();
            this.gpbCreateFolder.SuspendLayout();
            this.gpbKeep.SuspendLayout();
            this.gpbReplace.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose the name of the image sequence, watermarked images will be saved as the na" +
    "med defined followed by the sequence.\r\ne.g: image_1, image_2, etc.";
            // 
            // chkChangeNames
            // 
            this.chkChangeNames.AutoSize = true;
            this.chkChangeNames.Location = new System.Drawing.Point(20, 25);
            this.chkChangeNames.Name = "chkChangeNames";
            this.chkChangeNames.Size = new System.Drawing.Size(133, 17);
            this.chkChangeNames.TabIndex = 0;
            this.chkChangeNames.Text = "Change original names";
            this.chkChangeNames.UseVisualStyleBackColor = true;
            this.chkChangeNames.CheckedChanged += new System.EventHandler(this.chkChangeNames_CheckedChanged);
            // 
            // txtSeqName
            // 
            this.txtSeqName.Location = new System.Drawing.Point(9, 60);
            this.txtSeqName.Name = "txtSeqName";
            this.txtSeqName.Size = new System.Drawing.Size(345, 20);
            this.txtSeqName.TabIndex = 1;
            this.txtSeqName.Text = "image";
            // 
            // gpbSerieName
            // 
            this.gpbSerieName.Controls.Add(this.txtSeqName);
            this.gpbSerieName.Controls.Add(this.label1);
            this.gpbSerieName.Enabled = false;
            this.gpbSerieName.Location = new System.Drawing.Point(9, 28);
            this.gpbSerieName.Name = "gpbSerieName";
            this.gpbSerieName.Size = new System.Drawing.Size(360, 85);
            this.gpbSerieName.TabIndex = 5;
            this.gpbSerieName.TabStop = false;
            // 
            // chkCreateFolder
            // 
            this.chkCreateFolder.AutoSize = true;
            this.chkCreateFolder.Checked = true;
            this.chkCreateFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCreateFolder.Location = new System.Drawing.Point(20, 122);
            this.chkCreateFolder.Name = "chkCreateFolder";
            this.chkCreateFolder.Size = new System.Drawing.Size(233, 17);
            this.chkCreateFolder.TabIndex = 2;
            this.chkCreateFolder.Text = "Create a folder to save watermarked images";
            this.chkCreateFolder.UseVisualStyleBackColor = true;
            this.chkCreateFolder.CheckedChanged += new System.EventHandler(this.chkCreateFolder_CheckedChanged);
            // 
            // gpbCreateFolder
            // 
            this.gpbCreateFolder.Controls.Add(this.txtFolderName);
            this.gpbCreateFolder.Controls.Add(this.label2);
            this.gpbCreateFolder.Location = new System.Drawing.Point(9, 125);
            this.gpbCreateFolder.Name = "gpbCreateFolder";
            this.gpbCreateFolder.Size = new System.Drawing.Size(360, 52);
            this.gpbCreateFolder.TabIndex = 7;
            this.gpbCreateFolder.TabStop = false;
            // 
            // txtFolderName
            // 
            this.txtFolderName.Location = new System.Drawing.Point(81, 22);
            this.txtFolderName.Name = "txtFolderName";
            this.txtFolderName.Size = new System.Drawing.Size(273, 20);
            this.txtFolderName.TabIndex = 3;
            this.txtFolderName.Text = "Watermarked";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Create Folder:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(362, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Obs: If you keep the original names and don\'t create a folder then all original f" +
    "iles will be replaced.";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::FreeWatermarker.Properties.Resources.save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.Location = new System.Drawing.Point(351, 308);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(30, 30);
            this.btnSave.TabIndex = 5;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::FreeWatermarker.Properties.Resources.imagesCA2B2D53;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(309, 308);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(30, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCalcelar_Click);
            // 
            // gpbKeep
            // 
            this.gpbKeep.Controls.Add(this.chkChangeNames);
            this.gpbKeep.Controls.Add(this.gpbSerieName);
            this.gpbKeep.Controls.Add(this.chkCreateFolder);
            this.gpbKeep.Controls.Add(this.gpbCreateFolder);
            this.gpbKeep.Controls.Add(this.label3);
            this.gpbKeep.Location = new System.Drawing.Point(5, 76);
            this.gpbKeep.Name = "gpbKeep";
            this.gpbKeep.Size = new System.Drawing.Size(376, 226);
            this.gpbKeep.TabIndex = 8;
            this.gpbKeep.TabStop = false;
            // 
            // gpbReplace
            // 
            this.gpbReplace.Controls.Add(this.label4);
            this.gpbReplace.Enabled = false;
            this.gpbReplace.Location = new System.Drawing.Point(5, 12);
            this.gpbReplace.Name = "gpbReplace";
            this.gpbReplace.Size = new System.Drawing.Size(376, 58);
            this.gpbReplace.TabIndex = 9;
            this.gpbReplace.TabStop = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(15, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(343, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Obs: If you choose this option all original files will be replaced in their origi" +
    "nal folder.";
            // 
            // rbReplace
            // 
            this.rbReplace.AutoSize = true;
            this.rbReplace.Enabled = false;
            this.rbReplace.Location = new System.Drawing.Point(10, 10);
            this.rbReplace.Name = "rbReplace";
            this.rbReplace.Size = new System.Drawing.Size(122, 17);
            this.rbReplace.TabIndex = 0;
            this.rbReplace.Text = "Replace original files";
            this.rbReplace.UseVisualStyleBackColor = true;
            this.rbReplace.CheckedChanged += new System.EventHandler(this.rbReplace_CheckedChanged);
            // 
            // rbKeep
            // 
            this.rbKeep.AutoSize = true;
            this.rbKeep.Checked = true;
            this.rbKeep.Location = new System.Drawing.Point(10, 74);
            this.rbKeep.Name = "rbKeep";
            this.rbKeep.Size = new System.Drawing.Size(107, 17);
            this.rbKeep.TabIndex = 1;
            this.rbKeep.TabStop = true;
            this.rbKeep.Text = "Keep original files";
            this.rbKeep.UseVisualStyleBackColor = true;
            this.rbKeep.CheckedChanged += new System.EventHandler(this.rbKeep_CheckedChanged);
            // 
            // frmSave
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(386, 341);
            this.Controls.Add(this.rbKeep);
            this.Controls.Add(this.rbReplace);
            this.Controls.Add(this.gpbReplace);
            this.Controls.Add(this.gpbKeep);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSave";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "How do you like to save?";
            this.gpbSerieName.ResumeLayout(false);
            this.gpbSerieName.PerformLayout();
            this.gpbCreateFolder.ResumeLayout(false);
            this.gpbCreateFolder.PerformLayout();
            this.gpbKeep.ResumeLayout(false);
            this.gpbKeep.PerformLayout();
            this.gpbReplace.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkChangeNames;
        private System.Windows.Forms.TextBox txtSeqName;
        private System.Windows.Forms.GroupBox gpbSerieName;
        private System.Windows.Forms.CheckBox chkCreateFolder;
        private System.Windows.Forms.GroupBox gpbCreateFolder;
        private System.Windows.Forms.TextBox txtFolderName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpbKeep;
        private System.Windows.Forms.RadioButton rbKeep;
        private System.Windows.Forms.GroupBox gpbReplace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbReplace;
    }
}