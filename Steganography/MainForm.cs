using Steganography.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography
{
    public partial class MainForm : Form
    {
        private Steganography packer;
        private Autocorrelation autocorrelation;

        public MainForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

            packer = new Steganography(this);
            autocorrelation = new Autocorrelation();

            //Inicijalno je zakljucano biranje fajla jer ne postoji izabrana slika i pack dugmeta i unpack dugme je sakriveno
            this.FilePath_PackGroup.Enabled = false;
            this.GroupBox_PackFileInfo.Enabled = false;
            this.Button_Pack.Enabled = false;
            this.Button_Unpack.Visible = false;
            this.GroupBox_UnpackInfo.Enabled = false;

        }

        #region Buttons

        //Pack button
        private void Button_Pack_Click(object sender, EventArgs e)
        {
            String imagePath = this.ImagePath_PackTextBox.Text;
            String filePath = this.FilePath_PackTextBox.Text;

            packer.Pack(imagePath, filePath);
        }

        //Unpack button
        private void Button_Unpack_Click(object sender, EventArgs e)
        {
            String imagePath = this.ImagePath_UnpackTextBox.Text;
            packer.Unpack(imagePath);
        }

        //Select image for pack button
        private void ImagePath_PackTextButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog filePath = new OpenFileDialog();
            filePath.Filter = "PNG (*.png)|*.png|BMP (*.bmp)|*.bmp";
            DialogResult result = filePath.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.ImagePath_PackTextBox.Text = filePath.FileName;
                Image image = Image.FromStream(new MemoryStream(File.ReadAllBytes(filePath.FileName)));

                this.Image_Before.Image.Dispose();
                this.Image_Before.Image = image;

                this.Label_PackImageSizeValue.Text = image.Width.ToString() + "x" + image.Height.ToString();
                this.Label_PackAvailableSpaceValue.Text = (((float)(image.Width * image.Height * 3 / 8)) / 1024).ToString("0.00") + " KB";
                this.Image_Before.SizeMode = PictureBoxSizeMode.Zoom;

                this.Image_After.Image = Resources.imgphw;

                //Posto je slika izabrana omogucavam biranje fajla
                this.FilePath_PackGroup.Enabled = true;
                this.GroupBox_PackFileInfo.Enabled = true;

                CheckIfPackIsPosible();
            }
        }

        //Select file for pack button
        private void FilePath_PackButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog filePath = new OpenFileDialog();
            DialogResult result = filePath.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.FilePath_PackTextBox.Text = filePath.FileName;
                long fileSize = new FileInfo(filePath.FileName).Length;
                this.Label_PackFileSizeValue.Text = (fileSize + 30).ToString() + " B";
                CheckIfPackIsPosible();
            }
        }

        //Select image for unpack button
        private void ImagePath_UnpackTextButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog filePath = new OpenFileDialog();
            filePath.Filter = "PNG (*.png)|*.png|BMP (*.bmp)|*.bmp";
            DialogResult result = filePath.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.ImagePath_UnpackTextBox.Text = filePath.FileName;
                Image image = Image.FromStream(new MemoryStream(File.ReadAllBytes(filePath.FileName)));
                this.Image_UnpackSource.Image = image;
                this.Image_UnpackSource.SizeMode = PictureBoxSizeMode.Zoom;

                if (packer.CheckIsImageHidingData(filePath.FileName))
                {
                    this.Label_UnpackImagePackedVal.Text = "Yes";
                    this.Button_Unpack.Visible = true;
                }
                else
                {
                    this.Label_UnpackImagePackedVal.Text = "No";
                    this.Button_Unpack.Visible = false;
                }
                this.GroupBox_UnpackInfo.Enabled = true;               
            }
        }

        //Preracunavanje autokorelacije
        private void Button_Calculate_Click(object sender, EventArgs e)
        {
            String imagePath = this.ImagePath_AutocorrelationTextBox.Text;
            String compareImagePath = this.CompareImagePath_AutocorrelationTextBox.Text;

            //autocorrelation.Calculate(imagePath, compareImagePath);
            Random randNum = new Random();
            int[] test1 = Enumerable.Repeat(0, 1000).Select(i => randNum.Next(90, 100)).ToArray();
            int[] test2 = Enumerable.Repeat(0, 1000).Select(i => randNum.Next(70, 80)).ToArray();
            Form chart = new Chart(test1, test2);
            DialogResult result = chart.ShowDialog();
        }

        //Select image for autocorrelation button
        private void ImagePath_AutocorrelationTextButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog filePath = new OpenFileDialog();
            filePath.Filter = "PNG (*.png)|*.png|BMP (*.bmp)|*.bmp";
            DialogResult result = filePath.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.ImagePath_AutocorrelationTextBox.Text = filePath.FileName;
                Image image = Image.FromStream(new MemoryStream(File.ReadAllBytes(filePath.FileName)));
                this.Image_Autocorrelation.Image.Dispose();
                this.Image_Autocorrelation.Image = image;
                this.Image_Autocorrelation.SizeMode = PictureBoxSizeMode.Zoom;
                this.CompareImage_Autocorrelation.Image = Resources.imgphw;

            }
        }

        //Select compare image for autocorrelation button
        private void CompareImagePath_AutocorrelationTextButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog filePath = new OpenFileDialog();
            filePath.Filter = "PNG (*.png)|*.png|BMP (*.bmp)|*.bmp";
            DialogResult result = filePath.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.CompareImagePath_AutocorrelationTextBox.Text = filePath.FileName;
                Image image = Image.FromStream(new MemoryStream(File.ReadAllBytes(filePath.FileName)));
                this.CompareImage_Autocorrelation.Image = image;
                this.CompareImage_Autocorrelation.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        #endregion

        #region UI update functions
        private void CheckIfPackIsPosible()
        {
            if (String.IsNullOrEmpty(this.FilePath_PackTextBox.Text))
                return;
            long fileSize = new FileInfo(this.FilePath_PackTextBox.Text).Length;
            if (this.Image_Before.Image.Width * this.Image_Before.Image.Height * 3 / 8 >= fileSize)
            {
                this.Label_PackFileStatus_Value.Text = "Packable";
                this.Button_Pack.Enabled = true;
            }
            else
            {
                this.Label_PackFileStatus_Value.Text = "Unpackable";
                this.Button_Pack.Enabled = false;
            }
        }

        public void UnpackFinished()
        {
            this.ImagePath_UnpackTextBox.Text = "";
            this.Label_UnpackImagePackedVal.Text = "-";
            this.Button_Unpack.Visible = false;
            this.GroupBox_UnpackInfo.Enabled = false;
            this.Image_UnpackSource.Dispose();
            this.Image_UnpackSource.Image = Resources.imgphw;
        }

        public void PackFinished(String afterImagePath)
        {
            Image image = Image.FromStream(new MemoryStream(File.ReadAllBytes(afterImagePath)));
            this.Image_After.Image = image;
        }

        public void AutocorrelationFinished()
        {

        }
        #endregion
    }
}
