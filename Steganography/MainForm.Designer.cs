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
            this.tab = new System.Windows.Forms.TabControl();
            this.tab_Pack = new System.Windows.Forms.TabPage();
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
            this.tab_Unpack = new System.Windows.Forms.TabPage();
            this.ImagePath_UnpackGroup = new System.Windows.Forms.GroupBox();
            this.ImagePath_UnpackTextBox = new System.Windows.Forms.TextBox();
            this.ImagePath_UnpackTextButton = new System.Windows.Forms.Button();
            this.Button_Unpack = new System.Windows.Forms.Button();
            this.GroupBox_UnpackInfo = new System.Windows.Forms.GroupBox();
            this.Label_UnpackImagePacked = new System.Windows.Forms.Label();
            this.Label_UnpackImagePackedVal = new System.Windows.Forms.Label();
            this.Image_UnpackSource = new System.Windows.Forms.PictureBox();
            this.tab_Autocorrelation = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CompareImagePath_AutocorrelationGroup = new System.Windows.Forms.GroupBox();
            this.CompareImagePath_AutocorrelationTextBox = new System.Windows.Forms.TextBox();
            this.CompareImagePath_AutocorrelationTextButton = new System.Windows.Forms.Button();
            this.ImagePath_AutocorrelationGroup = new System.Windows.Forms.GroupBox();
            this.ImagePath_AutocorrelationTextBox = new System.Windows.Forms.TextBox();
            this.ImagePath_AutocorrelationTextButton = new System.Windows.Forms.Button();
            this.Button_Calculate = new System.Windows.Forms.Button();
            this.CompareImage_Autocorrelation = new System.Windows.Forms.PictureBox();
            this.Image_Autocorrelation = new System.Windows.Forms.PictureBox();
            this.Tab_Cuda = new System.Windows.Forms.TabPage();
            this.Cuda_ModeGrupBox = new System.Windows.Forms.GroupBox();
            this.Enable_CUDALabel = new System.Windows.Forms.Label();
            this.CheckBox_EnableCuda = new System.Windows.Forms.CheckBox();
            this.GrupBox_CudaGPUInfo = new System.Windows.Forms.GroupBox();
            this.CudaClockRate = new System.Windows.Forms.Label();
            this.Label_CudaClockRate = new System.Windows.Forms.Label();
            this.CudaNumOfCores = new System.Windows.Forms.Label();
            this.Label_CudaCoresNum = new System.Windows.Forms.Label();
            this.CudaMemBusWidth = new System.Windows.Forms.Label();
            this.Label_CudaMemBusWidth = new System.Windows.Forms.Label();
            this.CudaL2CashSize = new System.Windows.Forms.Label();
            this.Label_CudaL2 = new System.Windows.Forms.Label();
            this.CudaMemClockRate = new System.Windows.Forms.Label();
            this.Label_CudaMemClockRate = new System.Windows.Forms.Label();
            this.CudaGlobalMem = new System.Windows.Forms.Label();
            this.Label_CudaGlobalMemory = new System.Windows.Forms.Label();
            this.CudaCapabilityVersion = new System.Windows.Forms.Label();
            this.Label_CudaVersion = new System.Windows.Forms.Label();
            this.CudaRuntimeVersion = new System.Windows.Forms.Label();
            this.Label_CudaRunTimeDriver = new System.Windows.Forms.Label();
            this.CudaDriverVersion = new System.Windows.Forms.Label();
            this.CudaName = new System.Windows.Forms.Label();
            this.Label_CudaDriver = new System.Windows.Forms.Label();
            this.Label_CudaName = new System.Windows.Forms.Label();
            this.tab.SuspendLayout();
            this.tab_Pack.SuspendLayout();
            this.FilePath_PackGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_After)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image_Before)).BeginInit();
            this.GroupBox_PackInfo.SuspendLayout();
            this.GroupBox_PackImageInfo.SuspendLayout();
            this.GroupBox_PackFileInfo.SuspendLayout();
            this.ImagePath_PackGroup.SuspendLayout();
            this.tab_Unpack.SuspendLayout();
            this.ImagePath_UnpackGroup.SuspendLayout();
            this.GroupBox_UnpackInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_UnpackSource)).BeginInit();
            this.tab_Autocorrelation.SuspendLayout();
            this.CompareImagePath_AutocorrelationGroup.SuspendLayout();
            this.ImagePath_AutocorrelationGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompareImage_Autocorrelation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image_Autocorrelation)).BeginInit();
            this.Tab_Cuda.SuspendLayout();
            this.Cuda_ModeGrupBox.SuspendLayout();
            this.GrupBox_CudaGPUInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tab_Pack);
            this.tab.Controls.Add(this.tab_Unpack);
            this.tab.Controls.Add(this.tab_Autocorrelation);
            this.tab.Controls.Add(this.Tab_Cuda);
            this.tab.Location = new System.Drawing.Point(14, 12);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(413, 546);
            this.tab.TabIndex = 1;
            // 
            // tab_Pack
            // 
            this.tab_Pack.Controls.Add(this.FilePath_PackGroup);
            this.tab_Pack.Controls.Add(this.Image_After);
            this.tab_Pack.Controls.Add(this.Image_Before);
            this.tab_Pack.Controls.Add(this.Button_Pack);
            this.tab_Pack.Controls.Add(this.GroupBox_PackInfo);
            this.tab_Pack.Controls.Add(this.ImagePath_PackGroup);
            this.tab_Pack.Location = new System.Drawing.Point(4, 26);
            this.tab_Pack.Name = "tab_Pack";
            this.tab_Pack.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Pack.Size = new System.Drawing.Size(405, 516);
            this.tab_Pack.TabIndex = 0;
            this.tab_Pack.Text = "Pack";
            this.tab_Pack.UseVisualStyleBackColor = true;
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
            this.FilePath_PackTextBox.Size = new System.Drawing.Size(280, 24);
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
            this.Label_PackAvailableSpace.Size = new System.Drawing.Size(119, 17);
            this.Label_PackAvailableSpace.TabIndex = 5;
            this.Label_PackAvailableSpace.Text = "Available space:";
            // 
            // Label_PackAvailableSpaceValue
            // 
            this.Label_PackAvailableSpaceValue.AutoSize = true;
            this.Label_PackAvailableSpaceValue.Location = new System.Drawing.Point(113, 52);
            this.Label_PackAvailableSpaceValue.Name = "Label_PackAvailableSpaceValue";
            this.Label_PackAvailableSpaceValue.Size = new System.Drawing.Size(15, 17);
            this.Label_PackAvailableSpaceValue.TabIndex = 4;
            this.Label_PackAvailableSpaceValue.Text = "-";
            // 
            // Label_PackImageSize
            // 
            this.Label_PackImageSize.AutoSize = true;
            this.Label_PackImageSize.Location = new System.Drawing.Point(6, 26);
            this.Label_PackImageSize.Name = "Label_PackImageSize";
            this.Label_PackImageSize.Size = new System.Drawing.Size(89, 17);
            this.Label_PackImageSize.TabIndex = 3;
            this.Label_PackImageSize.Text = "Image size:";
            // 
            // Label_PackImageSizeValue
            // 
            this.Label_PackImageSizeValue.AutoSize = true;
            this.Label_PackImageSizeValue.Location = new System.Drawing.Point(87, 26);
            this.Label_PackImageSizeValue.Name = "Label_PackImageSizeValue";
            this.Label_PackImageSizeValue.Size = new System.Drawing.Size(15, 17);
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
            this.Label_PackFileStatus.Size = new System.Drawing.Size(61, 17);
            this.Label_PackFileStatus.TabIndex = 5;
            this.Label_PackFileStatus.Text = "Status:";
            // 
            // Label_PackFileStatus_Value
            // 
            this.Label_PackFileStatus_Value.AutoSize = true;
            this.Label_PackFileStatus_Value.Location = new System.Drawing.Point(243, 26);
            this.Label_PackFileStatus_Value.Name = "Label_PackFileStatus_Value";
            this.Label_PackFileStatus_Value.Size = new System.Drawing.Size(15, 17);
            this.Label_PackFileStatus_Value.TabIndex = 4;
            this.Label_PackFileStatus_Value.Text = "-";
            // 
            // Label_PackFileSize
            // 
            this.Label_PackFileSize.AutoSize = true;
            this.Label_PackFileSize.Location = new System.Drawing.Point(6, 26);
            this.Label_PackFileSize.Name = "Label_PackFileSize";
            this.Label_PackFileSize.Size = new System.Drawing.Size(68, 17);
            this.Label_PackFileSize.TabIndex = 3;
            this.Label_PackFileSize.Text = "File size:";
            // 
            // Label_PackFileSizeValue
            // 
            this.Label_PackFileSizeValue.AutoSize = true;
            this.Label_PackFileSizeValue.Location = new System.Drawing.Point(69, 26);
            this.Label_PackFileSizeValue.Name = "Label_PackFileSizeValue";
            this.Label_PackFileSizeValue.Size = new System.Drawing.Size(15, 17);
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
            this.ImagePath_PackTextBox.Size = new System.Drawing.Size(280, 24);
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
            // tab_Unpack
            // 
            this.tab_Unpack.Controls.Add(this.ImagePath_UnpackGroup);
            this.tab_Unpack.Controls.Add(this.Button_Unpack);
            this.tab_Unpack.Controls.Add(this.GroupBox_UnpackInfo);
            this.tab_Unpack.Controls.Add(this.Image_UnpackSource);
            this.tab_Unpack.Location = new System.Drawing.Point(4, 26);
            this.tab_Unpack.Name = "tab_Unpack";
            this.tab_Unpack.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Unpack.Size = new System.Drawing.Size(405, 516);
            this.tab_Unpack.TabIndex = 1;
            this.tab_Unpack.Text = "Unpack";
            this.tab_Unpack.UseVisualStyleBackColor = true;
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
            this.ImagePath_UnpackTextBox.Size = new System.Drawing.Size(280, 24);
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
            this.Label_UnpackImagePacked.Size = new System.Drawing.Size(88, 17);
            this.Label_UnpackImagePacked.TabIndex = 5;
            this.Label_UnpackImagePacked.Text = "Hides data:";
            // 
            // Label_UnpackImagePackedVal
            // 
            this.Label_UnpackImagePackedVal.AutoSize = true;
            this.Label_UnpackImagePackedVal.Location = new System.Drawing.Point(87, 28);
            this.Label_UnpackImagePackedVal.Name = "Label_UnpackImagePackedVal";
            this.Label_UnpackImagePackedVal.Size = new System.Drawing.Size(15, 17);
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
            // tab_Autocorrelation
            // 
            this.tab_Autocorrelation.Controls.Add(this.groupBox2);
            this.tab_Autocorrelation.Controls.Add(this.CompareImagePath_AutocorrelationGroup);
            this.tab_Autocorrelation.Controls.Add(this.ImagePath_AutocorrelationGroup);
            this.tab_Autocorrelation.Controls.Add(this.Button_Calculate);
            this.tab_Autocorrelation.Controls.Add(this.CompareImage_Autocorrelation);
            this.tab_Autocorrelation.Controls.Add(this.Image_Autocorrelation);
            this.tab_Autocorrelation.Location = new System.Drawing.Point(4, 26);
            this.tab_Autocorrelation.Name = "tab_Autocorrelation";
            this.tab_Autocorrelation.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Autocorrelation.Size = new System.Drawing.Size(405, 516);
            this.tab_Autocorrelation.TabIndex = 2;
            this.tab_Autocorrelation.Text = "Autocorrelation";
            this.tab_Autocorrelation.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(6, 312);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 173);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Callculation info";
            // 
            // CompareImagePath_AutocorrelationGroup
            // 
            this.CompareImagePath_AutocorrelationGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CompareImagePath_AutocorrelationGroup.Controls.Add(this.CompareImagePath_AutocorrelationTextBox);
            this.CompareImagePath_AutocorrelationGroup.Controls.Add(this.CompareImagePath_AutocorrelationTextButton);
            this.CompareImagePath_AutocorrelationGroup.Location = new System.Drawing.Point(7, 258);
            this.CompareImagePath_AutocorrelationGroup.Name = "CompareImagePath_AutocorrelationGroup";
            this.CompareImagePath_AutocorrelationGroup.Size = new System.Drawing.Size(335, 48);
            this.CompareImagePath_AutocorrelationGroup.TabIndex = 21;
            this.CompareImagePath_AutocorrelationGroup.TabStop = false;
            this.CompareImagePath_AutocorrelationGroup.Text = "Image to compare";
            // 
            // CompareImagePath_AutocorrelationTextBox
            // 
            this.CompareImagePath_AutocorrelationTextBox.Location = new System.Drawing.Point(7, 19);
            this.CompareImagePath_AutocorrelationTextBox.Name = "CompareImagePath_AutocorrelationTextBox";
            this.CompareImagePath_AutocorrelationTextBox.ReadOnly = true;
            this.CompareImagePath_AutocorrelationTextBox.Size = new System.Drawing.Size(280, 24);
            this.CompareImagePath_AutocorrelationTextBox.TabIndex = 6;
            // 
            // CompareImagePath_AutocorrelationTextButton
            // 
            this.CompareImagePath_AutocorrelationTextButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CompareImagePath_AutocorrelationTextButton.Location = new System.Drawing.Point(295, 19);
            this.CompareImagePath_AutocorrelationTextButton.Name = "CompareImagePath_AutocorrelationTextButton";
            this.CompareImagePath_AutocorrelationTextButton.Size = new System.Drawing.Size(29, 23);
            this.CompareImagePath_AutocorrelationTextButton.TabIndex = 7;
            this.CompareImagePath_AutocorrelationTextButton.Text = "...";
            this.CompareImagePath_AutocorrelationTextButton.UseVisualStyleBackColor = false;
            this.CompareImagePath_AutocorrelationTextButton.Click += new System.EventHandler(this.CompareImagePath_AutocorrelationTextButton_Click);
            // 
            // ImagePath_AutocorrelationGroup
            // 
            this.ImagePath_AutocorrelationGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImagePath_AutocorrelationGroup.Controls.Add(this.ImagePath_AutocorrelationTextBox);
            this.ImagePath_AutocorrelationGroup.Controls.Add(this.ImagePath_AutocorrelationTextButton);
            this.ImagePath_AutocorrelationGroup.Location = new System.Drawing.Point(7, 204);
            this.ImagePath_AutocorrelationGroup.Name = "ImagePath_AutocorrelationGroup";
            this.ImagePath_AutocorrelationGroup.Size = new System.Drawing.Size(335, 48);
            this.ImagePath_AutocorrelationGroup.TabIndex = 20;
            this.ImagePath_AutocorrelationGroup.TabStop = false;
            this.ImagePath_AutocorrelationGroup.Text = "Image";
            // 
            // ImagePath_AutocorrelationTextBox
            // 
            this.ImagePath_AutocorrelationTextBox.Location = new System.Drawing.Point(7, 19);
            this.ImagePath_AutocorrelationTextBox.Name = "ImagePath_AutocorrelationTextBox";
            this.ImagePath_AutocorrelationTextBox.ReadOnly = true;
            this.ImagePath_AutocorrelationTextBox.Size = new System.Drawing.Size(280, 24);
            this.ImagePath_AutocorrelationTextBox.TabIndex = 6;
            // 
            // ImagePath_AutocorrelationTextButton
            // 
            this.ImagePath_AutocorrelationTextButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ImagePath_AutocorrelationTextButton.Location = new System.Drawing.Point(295, 19);
            this.ImagePath_AutocorrelationTextButton.Name = "ImagePath_AutocorrelationTextButton";
            this.ImagePath_AutocorrelationTextButton.Size = new System.Drawing.Size(29, 23);
            this.ImagePath_AutocorrelationTextButton.TabIndex = 7;
            this.ImagePath_AutocorrelationTextButton.Text = "...";
            this.ImagePath_AutocorrelationTextButton.UseVisualStyleBackColor = false;
            this.ImagePath_AutocorrelationTextButton.Click += new System.EventHandler(this.ImagePath_AutocorrelationTextButton_Click);
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
            // CompareImage_Autocorrelation
            // 
            this.CompareImage_Autocorrelation.Image = global::Steganography.Properties.Resources.imgphw;
            this.CompareImage_Autocorrelation.Location = new System.Drawing.Point(205, 6);
            this.CompareImage_Autocorrelation.Name = "CompareImage_Autocorrelation";
            this.CompareImage_Autocorrelation.Size = new System.Drawing.Size(192, 192);
            this.CompareImage_Autocorrelation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CompareImage_Autocorrelation.TabIndex = 18;
            this.CompareImage_Autocorrelation.TabStop = false;
            // 
            // Image_Autocorrelation
            // 
            this.Image_Autocorrelation.Image = global::Steganography.Properties.Resources.imgphw;
            this.Image_Autocorrelation.Location = new System.Drawing.Point(7, 6);
            this.Image_Autocorrelation.Name = "Image_Autocorrelation";
            this.Image_Autocorrelation.Size = new System.Drawing.Size(192, 192);
            this.Image_Autocorrelation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Image_Autocorrelation.TabIndex = 17;
            this.Image_Autocorrelation.TabStop = false;
            // 
            // Tab_Cuda
            // 
            this.Tab_Cuda.Controls.Add(this.Cuda_ModeGrupBox);
            this.Tab_Cuda.Controls.Add(this.GrupBox_CudaGPUInfo);
            this.Tab_Cuda.Location = new System.Drawing.Point(4, 26);
            this.Tab_Cuda.Name = "Tab_Cuda";
            this.Tab_Cuda.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Cuda.Size = new System.Drawing.Size(405, 516);
            this.Tab_Cuda.TabIndex = 3;
            this.Tab_Cuda.Text = "CUDA GPU";
            this.Tab_Cuda.UseVisualStyleBackColor = true;
            // 
            // Cuda_ModeGrupBox
            // 
            this.Cuda_ModeGrupBox.Controls.Add(this.Enable_CUDALabel);
            this.Cuda_ModeGrupBox.Controls.Add(this.CheckBox_EnableCuda);
            this.Cuda_ModeGrupBox.Location = new System.Drawing.Point(6, 6);
            this.Cuda_ModeGrupBox.Name = "Cuda_ModeGrupBox";
            this.Cuda_ModeGrupBox.Size = new System.Drawing.Size(390, 62);
            this.Cuda_ModeGrupBox.TabIndex = 25;
            this.Cuda_ModeGrupBox.TabStop = false;
            this.Cuda_ModeGrupBox.Text = "CUDA GPU Mode";
            // 
            // Enable_CUDALabel
            // 
            this.Enable_CUDALabel.AutoSize = true;
            this.Enable_CUDALabel.Location = new System.Drawing.Point(6, 30);
            this.Enable_CUDALabel.Name = "Enable_CUDALabel";
            this.Enable_CUDALabel.Size = new System.Drawing.Size(106, 17);
            this.Enable_CUDALabel.TabIndex = 0;
            this.Enable_CUDALabel.Text = "Enable CUDA:";
            // 
            // CheckBox_EnableCuda
            // 
            this.CheckBox_EnableCuda.AutoSize = true;
            this.CheckBox_EnableCuda.Location = new System.Drawing.Point(118, 31);
            this.CheckBox_EnableCuda.Name = "CheckBox_EnableCuda";
            this.CheckBox_EnableCuda.Size = new System.Drawing.Size(18, 17);
            this.CheckBox_EnableCuda.TabIndex = 1;
            this.CheckBox_EnableCuda.UseVisualStyleBackColor = true;
            this.CheckBox_EnableCuda.CheckedChanged += new System.EventHandler(this.CheckBox_EnableCuda_CheckedChanged);
            // 
            // GrupBox_CudaGPUInfo
            // 
            this.GrupBox_CudaGPUInfo.Controls.Add(this.CudaClockRate);
            this.GrupBox_CudaGPUInfo.Controls.Add(this.Label_CudaClockRate);
            this.GrupBox_CudaGPUInfo.Controls.Add(this.CudaNumOfCores);
            this.GrupBox_CudaGPUInfo.Controls.Add(this.Label_CudaCoresNum);
            this.GrupBox_CudaGPUInfo.Controls.Add(this.CudaMemBusWidth);
            this.GrupBox_CudaGPUInfo.Controls.Add(this.Label_CudaMemBusWidth);
            this.GrupBox_CudaGPUInfo.Controls.Add(this.CudaL2CashSize);
            this.GrupBox_CudaGPUInfo.Controls.Add(this.Label_CudaL2);
            this.GrupBox_CudaGPUInfo.Controls.Add(this.CudaMemClockRate);
            this.GrupBox_CudaGPUInfo.Controls.Add(this.Label_CudaMemClockRate);
            this.GrupBox_CudaGPUInfo.Controls.Add(this.CudaGlobalMem);
            this.GrupBox_CudaGPUInfo.Controls.Add(this.Label_CudaGlobalMemory);
            this.GrupBox_CudaGPUInfo.Controls.Add(this.CudaCapabilityVersion);
            this.GrupBox_CudaGPUInfo.Controls.Add(this.Label_CudaVersion);
            this.GrupBox_CudaGPUInfo.Controls.Add(this.CudaRuntimeVersion);
            this.GrupBox_CudaGPUInfo.Controls.Add(this.Label_CudaRunTimeDriver);
            this.GrupBox_CudaGPUInfo.Controls.Add(this.CudaDriverVersion);
            this.GrupBox_CudaGPUInfo.Controls.Add(this.CudaName);
            this.GrupBox_CudaGPUInfo.Controls.Add(this.Label_CudaDriver);
            this.GrupBox_CudaGPUInfo.Controls.Add(this.Label_CudaName);
            this.GrupBox_CudaGPUInfo.Location = new System.Drawing.Point(6, 74);
            this.GrupBox_CudaGPUInfo.Name = "GrupBox_CudaGPUInfo";
            this.GrupBox_CudaGPUInfo.Size = new System.Drawing.Size(391, 250);
            this.GrupBox_CudaGPUInfo.TabIndex = 24;
            this.GrupBox_CudaGPUInfo.TabStop = false;
            this.GrupBox_CudaGPUInfo.Text = "Graphic card info";
            // 
            // CudaClockRate
            // 
            this.CudaClockRate.AutoEllipsis = true;
            this.CudaClockRate.AutoSize = true;
            this.CudaClockRate.Location = new System.Drawing.Point(237, 47);
            this.CudaClockRate.MaximumSize = new System.Drawing.Size(200, 35);
            this.CudaClockRate.Name = "CudaClockRate";
            this.CudaClockRate.Size = new System.Drawing.Size(15, 17);
            this.CudaClockRate.TabIndex = 0;
            this.CudaClockRate.Text = "-";
            // 
            // Label_CudaClockRate
            // 
            this.Label_CudaClockRate.AutoSize = true;
            this.Label_CudaClockRate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CudaClockRate.Location = new System.Drawing.Point(237, 30);
            this.Label_CudaClockRate.Name = "Label_CudaClockRate";
            this.Label_CudaClockRate.Size = new System.Drawing.Size(119, 17);
            this.Label_CudaClockRate.TabIndex = 0;
            this.Label_CudaClockRate.Text = "Gpu clock rate";
            // 
            // CudaNumOfCores
            // 
            this.CudaNumOfCores.AutoEllipsis = true;
            this.CudaNumOfCores.AutoSize = true;
            this.CudaNumOfCores.Location = new System.Drawing.Point(10, 207);
            this.CudaNumOfCores.MaximumSize = new System.Drawing.Size(200, 35);
            this.CudaNumOfCores.Name = "CudaNumOfCores";
            this.CudaNumOfCores.Size = new System.Drawing.Size(15, 17);
            this.CudaNumOfCores.TabIndex = 0;
            this.CudaNumOfCores.Text = "-";
            // 
            // Label_CudaCoresNum
            // 
            this.Label_CudaCoresNum.AutoSize = true;
            this.Label_CudaCoresNum.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CudaCoresNum.Location = new System.Drawing.Point(10, 190);
            this.Label_CudaCoresNum.Name = "Label_CudaCoresNum";
            this.Label_CudaCoresNum.Size = new System.Drawing.Size(179, 17);
            this.Label_CudaCoresNum.TabIndex = 0;
            this.Label_CudaCoresNum.Text = "Number of cuda cores";
            // 
            // CudaMemBusWidth
            // 
            this.CudaMemBusWidth.AutoEllipsis = true;
            this.CudaMemBusWidth.AutoSize = true;
            this.CudaMemBusWidth.Location = new System.Drawing.Point(237, 167);
            this.CudaMemBusWidth.MaximumSize = new System.Drawing.Size(200, 35);
            this.CudaMemBusWidth.Name = "CudaMemBusWidth";
            this.CudaMemBusWidth.Size = new System.Drawing.Size(15, 17);
            this.CudaMemBusWidth.TabIndex = 0;
            this.CudaMemBusWidth.Text = "-";
            // 
            // Label_CudaMemBusWidth
            // 
            this.Label_CudaMemBusWidth.AutoSize = true;
            this.Label_CudaMemBusWidth.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CudaMemBusWidth.Location = new System.Drawing.Point(237, 150);
            this.Label_CudaMemBusWidth.Name = "Label_CudaMemBusWidth";
            this.Label_CudaMemBusWidth.Size = new System.Drawing.Size(152, 17);
            this.Label_CudaMemBusWidth.TabIndex = 0;
            this.Label_CudaMemBusWidth.Text = "Memory bus width";
            // 
            // CudaL2CashSize
            // 
            this.CudaL2CashSize.AutoEllipsis = true;
            this.CudaL2CashSize.AutoSize = true;
            this.CudaL2CashSize.Location = new System.Drawing.Point(237, 207);
            this.CudaL2CashSize.MaximumSize = new System.Drawing.Size(200, 35);
            this.CudaL2CashSize.Name = "CudaL2CashSize";
            this.CudaL2CashSize.Size = new System.Drawing.Size(15, 17);
            this.CudaL2CashSize.TabIndex = 0;
            this.CudaL2CashSize.Text = "-";
            // 
            // Label_CudaL2
            // 
            this.Label_CudaL2.AutoSize = true;
            this.Label_CudaL2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CudaL2.Location = new System.Drawing.Point(237, 190);
            this.Label_CudaL2.Name = "Label_CudaL2";
            this.Label_CudaL2.Size = new System.Drawing.Size(101, 17);
            this.Label_CudaL2.TabIndex = 0;
            this.Label_CudaL2.Text = "L2 cash size";
            // 
            // CudaMemClockRate
            // 
            this.CudaMemClockRate.AutoEllipsis = true;
            this.CudaMemClockRate.AutoSize = true;
            this.CudaMemClockRate.Location = new System.Drawing.Point(237, 127);
            this.CudaMemClockRate.MaximumSize = new System.Drawing.Size(200, 35);
            this.CudaMemClockRate.Name = "CudaMemClockRate";
            this.CudaMemClockRate.Size = new System.Drawing.Size(15, 17);
            this.CudaMemClockRate.TabIndex = 0;
            this.CudaMemClockRate.Text = "-";
            // 
            // Label_CudaMemClockRate
            // 
            this.Label_CudaMemClockRate.AutoSize = true;
            this.Label_CudaMemClockRate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CudaMemClockRate.Location = new System.Drawing.Point(237, 110);
            this.Label_CudaMemClockRate.Name = "Label_CudaMemClockRate";
            this.Label_CudaMemClockRate.Size = new System.Drawing.Size(150, 17);
            this.Label_CudaMemClockRate.TabIndex = 0;
            this.Label_CudaMemClockRate.Text = "Memory clock rate";
            // 
            // CudaGlobalMem
            // 
            this.CudaGlobalMem.AutoEllipsis = true;
            this.CudaGlobalMem.AutoSize = true;
            this.CudaGlobalMem.Location = new System.Drawing.Point(237, 87);
            this.CudaGlobalMem.MaximumSize = new System.Drawing.Size(200, 35);
            this.CudaGlobalMem.Name = "CudaGlobalMem";
            this.CudaGlobalMem.Size = new System.Drawing.Size(15, 17);
            this.CudaGlobalMem.TabIndex = 0;
            this.CudaGlobalMem.Text = "-";
            // 
            // Label_CudaGlobalMemory
            // 
            this.Label_CudaGlobalMemory.AutoSize = true;
            this.Label_CudaGlobalMemory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CudaGlobalMemory.Location = new System.Drawing.Point(237, 70);
            this.Label_CudaGlobalMemory.Name = "Label_CudaGlobalMemory";
            this.Label_CudaGlobalMemory.Size = new System.Drawing.Size(124, 17);
            this.Label_CudaGlobalMemory.TabIndex = 0;
            this.Label_CudaGlobalMemory.Text = "Global memory";
            // 
            // CudaCapabilityVersion
            // 
            this.CudaCapabilityVersion.AutoEllipsis = true;
            this.CudaCapabilityVersion.AutoSize = true;
            this.CudaCapabilityVersion.Location = new System.Drawing.Point(10, 167);
            this.CudaCapabilityVersion.MaximumSize = new System.Drawing.Size(200, 35);
            this.CudaCapabilityVersion.Name = "CudaCapabilityVersion";
            this.CudaCapabilityVersion.Size = new System.Drawing.Size(15, 17);
            this.CudaCapabilityVersion.TabIndex = 0;
            this.CudaCapabilityVersion.Text = "-";
            // 
            // Label_CudaVersion
            // 
            this.Label_CudaVersion.AutoSize = true;
            this.Label_CudaVersion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CudaVersion.Location = new System.Drawing.Point(10, 150);
            this.Label_CudaVersion.Name = "Label_CudaVersion";
            this.Label_CudaVersion.Size = new System.Drawing.Size(146, 17);
            this.Label_CudaVersion.TabIndex = 0;
            this.Label_CudaVersion.Text = "Capability version";
            // 
            // CudaRuntimeVersion
            // 
            this.CudaRuntimeVersion.AutoEllipsis = true;
            this.CudaRuntimeVersion.AutoSize = true;
            this.CudaRuntimeVersion.Location = new System.Drawing.Point(10, 127);
            this.CudaRuntimeVersion.MaximumSize = new System.Drawing.Size(200, 35);
            this.CudaRuntimeVersion.Name = "CudaRuntimeVersion";
            this.CudaRuntimeVersion.Size = new System.Drawing.Size(15, 17);
            this.CudaRuntimeVersion.TabIndex = 0;
            this.CudaRuntimeVersion.Text = "-";
            // 
            // Label_CudaRunTimeDriver
            // 
            this.Label_CudaRunTimeDriver.AutoSize = true;
            this.Label_CudaRunTimeDriver.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CudaRunTimeDriver.Location = new System.Drawing.Point(10, 110);
            this.Label_CudaRunTimeDriver.Name = "Label_CudaRunTimeDriver";
            this.Label_CudaRunTimeDriver.Size = new System.Drawing.Size(134, 17);
            this.Label_CudaRunTimeDriver.TabIndex = 0;
            this.Label_CudaRunTimeDriver.Text = "Runtime version";
            // 
            // CudaDriverVersion
            // 
            this.CudaDriverVersion.AutoEllipsis = true;
            this.CudaDriverVersion.AutoSize = true;
            this.CudaDriverVersion.Location = new System.Drawing.Point(10, 87);
            this.CudaDriverVersion.MaximumSize = new System.Drawing.Size(200, 35);
            this.CudaDriverVersion.Name = "CudaDriverVersion";
            this.CudaDriverVersion.Size = new System.Drawing.Size(15, 17);
            this.CudaDriverVersion.TabIndex = 0;
            this.CudaDriverVersion.Text = "-";
            // 
            // CudaName
            // 
            this.CudaName.AutoEllipsis = true;
            this.CudaName.AutoSize = true;
            this.CudaName.Location = new System.Drawing.Point(10, 47);
            this.CudaName.MaximumSize = new System.Drawing.Size(200, 35);
            this.CudaName.Name = "CudaName";
            this.CudaName.Size = new System.Drawing.Size(15, 17);
            this.CudaName.TabIndex = 0;
            this.CudaName.Text = "-";
            // 
            // Label_CudaDriver
            // 
            this.Label_CudaDriver.AutoSize = true;
            this.Label_CudaDriver.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CudaDriver.Location = new System.Drawing.Point(10, 70);
            this.Label_CudaDriver.Name = "Label_CudaDriver";
            this.Label_CudaDriver.Size = new System.Drawing.Size(121, 17);
            this.Label_CudaDriver.TabIndex = 0;
            this.Label_CudaDriver.Text = "Driver verision";
            // 
            // Label_CudaName
            // 
            this.Label_CudaName.AutoSize = true;
            this.Label_CudaName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CudaName.Location = new System.Drawing.Point(10, 30);
            this.Label_CudaName.Name = "Label_CudaName";
            this.Label_CudaName.Size = new System.Drawing.Size(51, 17);
            this.Label_CudaName.TabIndex = 0;
            this.Label_CudaName.Text = "Name";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(439, 570);
            this.Controls.Add(this.tab);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Steganography";
            this.tab.ResumeLayout(false);
            this.tab_Pack.ResumeLayout(false);
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
            this.tab_Unpack.ResumeLayout(false);
            this.ImagePath_UnpackGroup.ResumeLayout(false);
            this.ImagePath_UnpackGroup.PerformLayout();
            this.GroupBox_UnpackInfo.ResumeLayout(false);
            this.GroupBox_UnpackInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_UnpackSource)).EndInit();
            this.tab_Autocorrelation.ResumeLayout(false);
            this.CompareImagePath_AutocorrelationGroup.ResumeLayout(false);
            this.CompareImagePath_AutocorrelationGroup.PerformLayout();
            this.ImagePath_AutocorrelationGroup.ResumeLayout(false);
            this.ImagePath_AutocorrelationGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompareImage_Autocorrelation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image_Autocorrelation)).EndInit();
            this.Tab_Cuda.ResumeLayout(false);
            this.Cuda_ModeGrupBox.ResumeLayout(false);
            this.Cuda_ModeGrupBox.PerformLayout();
            this.GrupBox_CudaGPUInfo.ResumeLayout(false);
            this.GrupBox_CudaGPUInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tab_Pack;
        private System.Windows.Forms.PictureBox Image_After;
        private System.Windows.Forms.PictureBox Image_Before;
        private System.Windows.Forms.Button Button_Pack;
        private System.Windows.Forms.GroupBox GroupBox_PackInfo;
        private System.Windows.Forms.GroupBox ImagePath_PackGroup;
        private System.Windows.Forms.TextBox ImagePath_PackTextBox;
        private System.Windows.Forms.Button ImagePath_PackTextButton;
        private System.Windows.Forms.TabPage tab_Unpack;
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
        private System.Windows.Forms.TabPage tab_Autocorrelation;
        private System.Windows.Forms.Button Button_Calculate;
        private System.Windows.Forms.PictureBox CompareImage_Autocorrelation;
        private System.Windows.Forms.PictureBox Image_Autocorrelation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox CompareImagePath_AutocorrelationGroup;
        private System.Windows.Forms.TextBox CompareImagePath_AutocorrelationTextBox;
        private System.Windows.Forms.Button CompareImagePath_AutocorrelationTextButton;
        private System.Windows.Forms.GroupBox ImagePath_AutocorrelationGroup;
        private System.Windows.Forms.TextBox ImagePath_AutocorrelationTextBox;
        private System.Windows.Forms.Button ImagePath_AutocorrelationTextButton;
        private System.Windows.Forms.TabPage Tab_Cuda;
        private System.Windows.Forms.GroupBox GrupBox_CudaGPUInfo;
        private System.Windows.Forms.GroupBox Cuda_ModeGrupBox;
        private System.Windows.Forms.Label Enable_CUDALabel;
        private System.Windows.Forms.CheckBox CheckBox_EnableCuda;
        private System.Windows.Forms.Label Label_CudaRunTimeDriver;
        private System.Windows.Forms.Label Label_CudaDriver;
        private System.Windows.Forms.Label Label_CudaName;
        private System.Windows.Forms.Label Label_CudaClockRate;
        private System.Windows.Forms.Label Label_CudaCoresNum;
        private System.Windows.Forms.Label Label_CudaMemBusWidth;
        private System.Windows.Forms.Label Label_CudaL2;
        private System.Windows.Forms.Label Label_CudaMemClockRate;
        private System.Windows.Forms.Label Label_CudaGlobalMemory;
        private System.Windows.Forms.Label Label_CudaVersion;
        private System.Windows.Forms.Label CudaClockRate;
        private System.Windows.Forms.Label CudaNumOfCores;
        private System.Windows.Forms.Label CudaMemBusWidth;
        private System.Windows.Forms.Label CudaL2CashSize;
        private System.Windows.Forms.Label CudaMemClockRate;
        private System.Windows.Forms.Label CudaGlobalMem;
        private System.Windows.Forms.Label CudaCapabilityVersion;
        private System.Windows.Forms.Label CudaRuntimeVersion;
        private System.Windows.Forms.Label CudaDriverVersion;
        private System.Windows.Forms.Label CudaName;
    }
}

