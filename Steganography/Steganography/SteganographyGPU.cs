using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography.Steganography
{
    class SteganographyGPU : ISteganography
    {
        public SteganographyGPU(Form form)
        {
            mainForm = (MainForm)form;
        }

        public override bool CheckIsImageHidingData(string imagePath)
        {
            try
            {
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        protected override void PackWork(string imagePath, string filePath, string destinationPath)
        {
            try
            {

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        protected override void UnpackWork(string imagePath, string destinationPath)
        {
            try
            {

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
