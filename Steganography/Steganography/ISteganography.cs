using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography.Steganography
{
    public abstract class ISteganography
    {
        protected MainForm mainForm;
        protected Thread processingThread;

        ~ISteganography()
        {
            if (processingThread != null)
                processingThread.Abort();
        }

        public void Pack(String imagePath, String filePath)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            String extension = Path.GetExtension(imagePath);
            String destinationPath = null;
            dialog.Filter = extension.TrimStart('.') + "|*" + extension;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                destinationPath = dialog.FileName;
            }
            else
                return;

            processingThread = new Thread(new ThreadStart(() => PackWork(imagePath, filePath, destinationPath)));
            processingThread.Name = "Packing thread";
            processingThread.Start();
        }

        protected abstract void PackWork(String imagePath, String filePath, String destinationPath);

        public void Unpack(String imagePath)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            String extension = Path.GetExtension(imagePath);
            String destinationPath = null;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                destinationPath = dialog.FileName;
            }
            else
                return;

            processingThread = new Thread(new ThreadStart(() => UnpackWork(imagePath, destinationPath)));
            processingThread.Name = "Unpacking thread";
            processingThread.Start();
        }

        protected abstract void UnpackWork(String imagePath, String destinationPath);

        public abstract bool CheckIsImageHidingData(String imagePath);

    }
}
