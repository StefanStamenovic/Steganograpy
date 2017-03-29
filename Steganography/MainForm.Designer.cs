namespace Steganography
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.FilePath_PackGroup = new System.Windows.Forms.GroupBox();
            this.FilePath_PackTextBox = new System.Windows.Forms.TextBox();
            this.FilePath_PackButton = new System.Windows.Forms.Button();
            this.Image_After = new System.Windows.Forms.PictureBox();
            this.Image_Before = new System.Windows.Forms.PictureBox();
            this.Button_Pack = new System.Windows.Forms.Button();
            this.GroupBox_PackInfo = new System.Windows.Forms.GroupBox();
            this.GroupBox_PackImageInfo = new System.Windows.Forms.GroupBox();
            this.Label_PackAvailableSpace = new System.Windows.Forms.Label();
            this.Label_PackAvailableSpaceValue = new System.Windows.Forms.Label();
            this.Label_PackImageSize = new System.Windows.Forms.Label();
            this.Label_PackImageSizeValue = new System.Windows.Forms.Label();
            this.GroupBox_PackFileInfo = new System.Windows.Forms.GroupBox();
            this.Label_PackFileStatus = new System.Windows.Forms.Label();
            this.Label_PackFileStatus_Value = new System.Windows.Forms.Label();
            this.Label_PackFileSize = new System.Windows.Forms.Label();
            this.Label_PackFileSizeValue = new System.Windows.Forms.Label();
            this.ImagePath_PackGroup = new System.Windows.Forms.GroupBox();
            this.ImagePath_PackTextBox = new System.Windows.Forms.TextBox();
            this.ImagePath_PackTextButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ImagePath_UnpackGroup = new System.Windows.Forms.GroupBox();
            this.ImagePath_UnpackTextBox = new System.Windows.Forms.TextBox();
            this.ImagePath_UnpackTextButton = new System.Windows.Forms.Button();
            this.Button_Unpack = new System.Windows.Forms.Button();
            this.GroupBox_UnpackInfo = new System.Windows.Forms.GroupBox();
            this.Label_UnpackImagePacked = new System.Windows.Forms.Label();
            this.Label_UnpackImagePackedVal = new System.Windows.Forms.Label();
            this.Image_UnpackSource = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Button_Calculate = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.FilePath_PackGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_After)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image_Before)).BeginInit();
            this.GroupBox_PackInfo.SuspendLayout();
            this.GroupBox_PackImageInfo.SuspendLayout();
            this.GroupBox_PackFileInfo.SuspendLayout();
            this.ImagePath_PackGroup.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.ImagePath_UnpackGroup.SuspendLayout();
            this.GroupBox_UnpackInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_UnpackSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(14, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(413, 546);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.FilePath_PackGroup);
            this.tabPage1.Controls.Add(this.Image_After);
            this.tabPage1.Controls.Add(this.Image_Before);
            this.tabPage1.Controls.Add(this.Button_Pack);
            this.tabPage1.Controls.Add(this.GroupBox_PackInfo);
            this.tabPage1.Controls.Add(this.ImagePath_PackGroup);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(405, 520);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pack";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // FilePath_PackGroup
            // 
            this.FilePath_PackGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FilePath_PackGroup.Controls.Add(this.FilePath_PackTextBox);
            this.FilePath_PackGroup.Controls.Add(this.FilePath_PackButton);
            this.FilePath_PackGroup.Location = new System.Drawing.Point(7, 258);
            this.FilePath_PackGroup.Name = "FilePath_PackGroup";
            this.FilePath_PackGroup.Size = new System.Drawing.Size(335, 48);
            this.FilePath_PackGroup.TabIndex = 13;
            this.FilePath_PackGroup.TabStop = false;
            this.FilePath_PackGroup.Text = "File to embed";
            // 
            // FilePath_PackTextBox
            // 
            this.FilePath_PackTextBox.Location = new System.Drawing.Point(7, 19);
            this.FilePath_PackTextBox.Name = "FilePath_PackTextBox";
            this.FilePath_PackTextBox.ReadOnly = true;
            this.FilePath_PackTextBox.Size = new System.Drawing.Size(280, 21);
            this.FilePath_PackTextBox.TabIndex = 6;
            // 
            // FilePath_PackButton
            // 
            this.FilePath_PackButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FilePath_PackButton.Location = new System.Drawing.Point(295, 19);
            this.FilePath_PackButton.Name = "FilePath_PackButton";
            this.FilePath_PackButton.Size = new System.Drawing.Size(29, 23);
            this.FilePath_PackButton.TabIndex = 7;
            this.FilePath_PackButton.Text = "...";
            this.FilePath_PackButton.UseVisualStyleBackColor = false;
            this.FilePath_PackButton.Click += new System.EventHandler(this.FilePath_PackButton_Click);
            // 
            // Image_After
            // 
            this.Image_After.Image = global::Steganography.Properties.Resources.imgphw;
            this.Image_After.Location = new System.Drawing.Point(205, 6);
            this.Image_After.Name = "Image_After";
            this.Image_After.Size = new System.Drawing.Size(192, 192);
            this.Image_After.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Image_After.TabIndex = 16;
            this.Image_After.TabStop = false;
            // 
            // Image_Before
            // 
            this.Image_Before.Image = global::Steganography.Properties.Resources.imgphw;
            this.Image_Before.Location = new System.Drawing.Point(7, 6);
            this.Image_Before.Name = "Image_Before";
            this.Image_Before.Size = new System.Drawing.Size(192, 192);
            this.Image_Before.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Image_Before.TabIndex = 15;
            this.Image_Before.TabStop = false;
            // 
            // Button_Pack
            // 
            this.Button_Pack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_Pack.Location = new System.Drawing.Point(312, 491);
            this.Button_Pack.Name = "Button_Pack";
            this.Button_Pack.Size = new System.Drawing.Size(87, 23);
            this.Button_Pack.TabIndex = 14;
            this.Button_Pack.Text = "Pack";
            this.Button_Pack.UseVisualStyleBackColor = false;
            this.Button_Pack.Click += new System.EventHandler(this.Button_Pack_Click);
            // 
            // GroupBox_PackInfo
            // 
            this.GroupBox_PackInfo.Controls.Add(this.GroupBox_PackImageInfo);
            this.GroupBox_PackInfo.Controls.Add(this.GroupBox_PackFileInfo);
            this.GroupBox_PackInfo.Location = new System.Drawing.Point(7, 312);
            this.GroupBox_PackInfo.Name = "GroupBox_PackInfo";
            this.GroupBox_PackInfo.Size = new System.Drawing.Size(390, 173);
            this.GroupBox_PackInfo.TabIndex = 13;
            this.GroupBox_PackInfo.TabStop = false;
            this.GroupBox_PackInfo.Text = "Info";
            // 
            // GroupBox_PackImageInfo
            // 
            this.GroupBox_PackImageInfo.Controls.Add(this.Label_PackAvailableSpace);
            this.GroupBox_PackImageInfo.Controls.Add(this.Label_PackAvailableSpaceValue);
            this.GroupBox_PackImageInfo.Controls.Add(this.Label_PackImageSize);
            this.GroupBox_PackImageInfo.Controls.Add(this.Label_PackImageSizeValue);
            this.GroupBox_PackImageInfo.Location = new System.Drawing.Point(6, 20);
            this.GroupBox_PackImageInfo.Name = "GroupBox_PackImageInfo";
            this.GroupBox_PackImageInfo.Size = new System.Drawing.Size(378, 81);
            this.GroupBox_PackImageInfo.TabIndex = 6;
            this.GroupBox_PackImageInfo.TabStop = false;
            this.GroupBox_PackImageInfo.Text = "Image info";
            // 
            // Label_PackAvailableSpace
            // 
            this.Label_PackAvailableSpace.AutoSize = true;
            this.Label_PackAvailableSpace.Location = new System.Drawing.Point(6, 52);
            this.Label_PackAvailableSpace.Name = "Label_PackAvailableSpace";
            this.Label_PackAvailableSpace.Size = new System.Drawing.Size(101, 13);
            this.Label_PackAvailableSpace.TabIndex = 5;
            this.Label_PackAvailableSpace.Text = "Available space:";
            // 
            // Label_PackAvailableSpaceValue
            // 
            this.Label_PackAvailableSpaceValue.AutoSize = true;
            this.Label_PackAvailableSpaceValue.Location = new System.Drawing.Point(113, 52);
            this.Label_PackAvailableSpaceValue.Name = "Label_PackAvailableSpaceValue";
            this.Label_PackAvailableSpaceValue.Size = new System.Drawing.Size(12, 13);
            this.Label_PackAvailableSpaceValue.TabIndex = 4;
            this.Label_PackAvailableSpaceValue.Text = "-";
            // 
            // Label_PackImageSize
            // 
            this.Label_PackImageSize.AutoSize = true;
            this.Label_PackImageSize.Location = new System.Drawing.Point(6, 26);
            this.Label_PackImageSize.Name = "Label_PackImageSize";
            this.Label_PackImageSize.Size = new System.Drawing.Size(75, 13);
            this.Label_PackImageSize.TabIndex = 3;
            this.Label_PackImageSize.Text = "Image size:";
            // 
            // Label_PackImageSizeValue
            // 
            this.Label_PackImageSizeValue.AutoSize = true;
            this.Label_PackImageSizeValue.Location = new System.Drawing.Point(87, 26);
            this.Label_PackImageSizeValue.Name = "Label_PackImageSizeValue";
            this.Label_PackImageSizeValue.Size = new System.Drawing.Size(12, 13);
            this.Label_PackImageSizeValue.TabIndex = 2;
            this.Label_PackImageSizeValue.Text = "-";
            // 
            // GroupBox_PackFileInfo
            // 
            this.GroupBox_PackFileInfo.Controls.Add(this.Label_PackFileStatus);
            this.GroupBox_PackFileInfo.Controls.Add(this.Label_PackFileStatus_Value);
            this.GroupBox_PackFileInfo.Controls.Add(this.Label_PackFileSize);
            this.GroupBox_PackFileInfo.Controls.Add(this.Label_PackFileSizeValue);
            this.GroupBox_PackFileInfo.Location = new System.Drawing.Point(6, 107);
            this.GroupBox_PackFileInfo.Name = "GroupBox_PackFileInfo";
            this.GroupBox_PackFileInfo.Size = new System.Drawing.Size(378, 60);
            this.GroupBox_PackFileInfo.TabIndex = 5;
            this.GroupBox_PackFileInfo.TabStop = false;
            this.GroupBox_PackFileInfo.Text = "File info";
            // 
            // Label_PackFileStatus
            // 
            this.Label_PackFileStatus.AutoSize = true;
            this.Label_PackFileStatus.Location = new System.Drawing.Point(189, 26);
            this.Label_PackFileStatus.Name = "Label_PackFileStatus";
            this.Label_PackFileStatus.Size = new System.Drawing.Size(48, 13);
            this.Label_PackFileStatus.TabIndex = 5;
            this.Label_PackFileStatus.Text = "Status:";
            // 
            // Label_PackFileStatus_Value
            // 
            this.Label_PackFileStatus_Value.AutoSize = true;
            this.Label_PackFileStatus_Value.Location = new System.Drawing.Point(243, 26);
            this.Label_PackFileStatus_Value.Name = "Label_PackFileStatus_Value";
            this.Label_PackFileStatus_Value.Size = new System.Drawing.Size(12, 13);
            this.Label_PackFileStatus_Value.TabIndex = 4;
            this.Label_PackFileStatus_Value.Text = "-";
            // 
            // Label_PackFileSize
            // 
            this.Label_PackFileSize.AutoSize = true;
            this.Label_PackFileSize.Location = new System.Drawing.Point(6, 26);
            this.Label_PackFileSize.Name = "Label_PackFileSize";
            this.Label_PackFileSize.Size = new System.Drawing.Size(57, 13);
            this.Label_PackFileSize.TabIndex = 3;
            this.Label_PackFileSize.Text = "File size:";
            // 
            // Label_PackFileSizeValue
            // 
            this.Label_PackFileSizeValue.AutoSize = true;
            this.Label_PackFileSizeValue.Location = new System.Drawing.Point(69, 26);
            this.Label_PackFileSizeValue.Name = "Label_PackFileSizeValue";
            this.Label_PackFileSizeValue.Size = new System.Drawing.Size(12, 13);
            this.Label_PackFileSizeValue.TabIndex = 2;
            this.Label_PackFileSizeValue.Text = "-";
            // 
            // ImagePath_PackGroup
            // 
            this.ImagePath_PackGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImagePath_PackGroup.Controls.Add(this.ImagePath_PackTextBox);
            this.ImagePath_PackGroup.Controls.Add(this.ImagePath_PackTextButton);
            this.ImagePath_PackGroup.Location = new System.Drawing.Point(7, 204);
            this.ImagePath_PackGroup.Name = "ImagePath_PackGroup";
            this.ImagePath_PackGroup.Size = new System.Drawing.Size(335, 48);
            this.ImagePath_PackGroup.TabIndex = 12;
            this.ImagePath_PackGroup.TabStop = false;
            this.ImagePath_PackGroup.Text = "Image";
            // 
            // ImagePath_PackTextBox
            // 
            this.ImagePath_PackTextBox.Location = new System.Drawing.Point(7, 19);
            this.ImagePath_PackTextBox.Name = "ImagePath_PackTextBox";
            this.ImagePath_PackTextBox.ReadOnly = true;
            this.ImagePath_PackTextBox.Size = new System.Drawing.Size(280, 21);
            this.ImagePath_PackTextBox.TabIndex = 6;
            // 
            // ImagePath_PackTextButton
            // 
            this.ImagePath_PackTextButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ImagePath_PackTextButton.Location = new System.Drawing.Point(295, 19);
            this.ImagePath_PackTextButton.Name = "ImagePath_PackTextButton";
            this.ImagePath_PackTextButton.Size = new System.Drawing.Size(29, 23);
            this.ImagePath_PackTextButton.TabIndex = 7;
            this.ImagePath_PackTextButton.Text = "...";
            this.ImagePath_PackTextButton.UseVisualStyleBackColor = false;
            this.ImagePath_PackTextButton.Click += new System.EventHandler(this.ImagePath_PackTextButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ImagePath_UnpackGroup);
            this.tabPage2.Controls.Add(this.Button_Unpack);
            this.tabPage2.Controls.Add(this.GroupBox_UnpackInfo);
            this.tabPage2.Controls.Add(this.Image_UnpackSource);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(405, 520);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Unpack";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ImagePath_UnpackGroup
            // 
            this.ImagePath_UnpackGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImagePath_UnpackGroup.Controls.Add(this.ImagePath_UnpackTextBox);
            this.ImagePath_UnpackGroup.Controls.Add(this.ImagePath_UnpackTextButton);
            this.ImagePath_UnpackGroup.Location = new System.Drawing.Point(7, 258);
            this.ImagePath_UnpackGroup.Name = "ImagePath_UnpackGroup";
            this.ImagePath_UnpackGroup.Size = new System.Drawing.Size(335, 48);
            this.ImagePath_UnpackGroup.TabIndex = 16;
            this.ImagePath_UnpackGroup.TabStop = false;
            this.ImagePath_UnpackGroup.Text = "Image";
            // 
            // ImagePath_UnpackTextBox
            // 
            this.ImagePath_UnpackTextBox.Location = new System.Drawing.Point(7, 19);
            this.ImagePath_UnpackTextBox.Name = "ImagePath_UnpackTextBox";
            this.ImagePath_UnpackTextBox.ReadOnly = true;
            this.ImagePath_UnpackTextBox.Size = new System.Drawing.Size(280, 21);
            this.ImagePath_UnpackTextBox.TabIndex = 6;
            // 
            // ImagePath_UnpackTextButton
            // 
            this.ImagePath_UnpackTextButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ImagePath_UnpackTextButton.Location = new System.Drawing.Point(295, 19);
            this.ImagePath_UnpackTextButton.Name = "ImagePath_UnpackTextButton";
            this.ImagePath_UnpackTextButton.Size = new System.Drawing.Size(29, 23);
            this.ImagePath_UnpackTextButton.TabIndex = 7;
            this.ImagePath_UnpackTextButton.Text = "...";
            this.ImagePath_UnpackTextButton.UseVisualStyleBackColor = false;
            this.ImagePath_UnpackTextButton.Click += new System.EventHandler(this.ImagePath_UnpackTextButton_Click);
            // 
            // Button_Unpack
            // 
            this.Button_Unpack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_Unpack.Location = new System.Drawing.Point(310, 491);
            this.Button_Unpack.Name = "Button_Unpack";
            this.Button_Unpack.Size = new System.Drawing.Size(87, 23);
            this.Button_Unpack.TabIndex = 18;
            this.Button_Unpack.Text = "Unpack";
            this.Button_Unpack.UseVisualStyleBackColor = false;
            this.Button_Unpack.Click += new System.EventHandler(this.Button_Unpack_Click);
            // 
            // GroupBox_UnpackInfo
            // 
            this.GroupBox_UnpackInfo.Controls.Add(this.Label_UnpackImagePacked);
            this.GroupBox_UnpackInfo.Controls.Add(this.Label_UnpackImagePackedVal);
            this.GroupBox_UnpackInfo.Location = new System.Drawing.Point(7, 312);
            this.GroupBox_UnpackInfo.Name = "GroupBox_UnpackInfo";
            this.GroupBox_UnpackInfo.Size = new System.Drawing.Size(390, 62);
            this.GroupBox_UnpackInfo.TabIndex = 17;
            this.GroupBox_UnpackInfo.TabStop = false;
            this.GroupBox_UnpackInfo.Text = "Info";
            // 
            // Label_UnpackImagePacked
            // 
            this.Label_UnpackImagePacked.AutoSize = true;
            this.Label_UnpackImagePacked.Location = new System.Drawing.Point(6, 28);
            this.Label_UnpackImagePacked.Name = "Label_UnpackImagePacked";
            this.Label_UnpackImagePacked.Size = new System.Drawing.Size(72, 13);
            this.Label_UnpackImagePacked.TabIndex = 5;
            this.Label_UnpackImagePacked.Text = "Hides data:";
            // 
            // Label_UnpackImagePackedVal
            // 
            this.Label_UnpackImagePackedVal.AutoSize = true;
            this.Label_UnpackImagePackedVal.Location = new System.Drawing.Point(87, 28);
            this.Label_UnpackImagePackedVal.Name = "Label_UnpackImagePackedVal";
            this.Label_UnpackImagePackedVal.Size = new System.Drawing.Size(12, 13);
            this.Label_UnpackImagePackedVal.TabIndex = 4;
            this.Label_UnpackImagePackedVal.Text = "-";
            // 
            // Image_UnpackSource
            // 
            this.Image_UnpackSource.Image = global::Steganography.Properties.Resources.imgphw;
            this.Image_UnpackSource.Location = new System.Drawing.Point(72, 6);
            this.Image_UnpackSource.Name = "Image_UnpackSource";
            this.Image_UnpackSource.Size = new System.Drawing.Size(246, 246);
            this.Image_UnpackSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Image_UnpackSource.TabIndex = 2;
            this.Image_UnpackSource.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Button_Calculate);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(405, 520);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Autocorrelation";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Steganography.Properties.Resources.imgphw;
            this.pictureBox1.Location = new System.Drawing.Point(205, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Steganography.Properties.Resources.imgphw;
            this.pictureBox2.Location = new System.Drawing.Point(7, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(192, 192);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // Button_Calculate
            // 
            this.Button_Calculate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_Calculate.Location = new System.Drawing.Point(312, 491);
            this.Button_Calculate.Name = "Button_Calculate";
            this.Button_Calculate.Size = new System.Drawing.Size(87, 23);
            this.Button_Calculate.TabIndex = 19;
            this.Button_Calculate.Text = "Calculate";
            this.Button_Calculate.UseVisualStyleBackColor = false;
            this.Button_Calculate.Click += new System.EventHandler(this.Button_Calculate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(439, 570);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Steganography";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.FilePath_PackGroup.ResumeLayout(false);
            this.FilePath_PackGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_After)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image_Before)).EndInit();
            this.GroupBox_PackInfo.ResumeLayout(false);
            this.GroupBox_PackImageInfo.ResumeLayout(false);
            this.GroupBox_PackImageInfo.PerformLayout();
            this.GroupBox_PackFileInfo.ResumeLayout(false);
            this.GroupBox_PackFileInfo.PerformLayout();
            this.ImagePath_PackGroup.ResumeLayout(false);
            this.ImagePath_PackGroup.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ImagePath_UnpackGroup.ResumeLayout(false);
            this.ImagePath_UnpackGroup.PerformLayout();
            this.GroupBox_UnpackInfo.ResumeLayout(false);
            this.GroupBox_UnpackInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_UnpackSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox Image_After;
        private System.Windows.Forms.PictureBox Image_Before;
        private System.Windows.Forms.Button Button_Pack;
        private System.Windows.Forms.GroupBox GroupBox_PackInfo;
        private System.Windows.Forms.GroupBox ImagePath_PackGroup;
        private System.Windows.Forms.TextBox ImagePath_PackTextBox;
        private System.Windows.Forms.Button ImagePath_PackTextButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox Image_UnpackSource;
        private System.Windows.Forms.GroupBox FilePath_PackGroup;
        private System.Windows.Forms.TextBox FilePath_PackTextBox;
        private System.Windows.Forms.Button FilePath_PackButton;
        private System.Windows.Forms.GroupBox ImagePath_UnpackGroup;
        private System.Windows.Forms.TextBox ImagePath_UnpackTextBox;
        private System.Windows.Forms.Button ImagePath_UnpackTextButton;
        private System.Windows.Forms.Button Button_Unpack;
        private System.Windows.Forms.GroupBox GroupBox_UnpackInfo;
        private System.Windows.Forms.GroupBox GroupBox_PackImageInfo;
        private System.Windows.Forms.Label Label_PackAvailableSpace;
        private System.Windows.Forms.Label Label_PackAvailableSpaceValue;
        private System.Windows.Forms.Label Label_PackImageSize;
        private System.Windows.Forms.Label Label_PackImageSizeValue;
        private System.Windows.Forms.GroupBox GroupBox_PackFileInfo;
        private System.Windows.Forms.Label Label_PackFileSize;
        private System.Windows.Forms.Label Label_PackFileSizeValue;
        private System.Windows.Forms.Label Label_PackFileStatus;
        private System.Windows.Forms.Label Label_PackFileStatus_Value;
        private System.Windows.Forms.Label Label_UnpackImagePacked;
        private System.Windows.Forms.Label Label_UnpackImagePackedVal;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button Button_Calculate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

