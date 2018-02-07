using Steganography.Nvidia;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography.Autocorrelation
{
    class AutocorrelationGPU : IAutocorrelation
    {
        public AutocorrelationGPU(Form form)
        {
            mainForm = (MainForm)form;
        }

        protected override void CalculateWork(String imagePath, String compareImagePath)
        {
            mainForm.Enabled = false;
            try
            {
                byte[] imageBytesOriginal = GetImageBytes(imagePath);
                byte[] imageBytesPacked = GetImageBytes(compareImagePath);
                int[] returnData = new int[imageBytesOriginal.Length];

                CudaAPI.CalculateAutoCorrelation(imageBytesOriginal, imageBytesPacked, returnData);

                Form chart = new Chart(returnData);
                DialogResult result = chart.ShowDialog();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
            finally
            {
                this.mainForm.Enabled = true;
            }
        }

        private byte[] GetImageBytes(String imagePath)
        {
            byte[] imageBytes = null;
            BitmapData bmpdata = null;
            Bitmap bitmap = new Bitmap(imagePath);

            bmpdata = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, bitmap.PixelFormat);
            int numbytes = bmpdata.Stride * bitmap.Height;
            imageBytes = new byte[numbytes];
            IntPtr ptr = bmpdata.Scan0;
            Marshal.Copy(ptr, imageBytes, 0, numbytes);
            bitmap.UnlockBits(bmpdata);

            return imageBytes;
        }
    }
}
