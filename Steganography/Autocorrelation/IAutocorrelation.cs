using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Steganography.Autocorrelation
{
    public abstract class IAutocorrelation
    {
        protected MainForm mainForm;
        protected Thread processingThread;

        ~IAutocorrelation()
        {
            if (processingThread != null)
                processingThread.Abort();
        }

        public void Calculate(String imagePath, String compareImagePath)
        {
            processingThread = new Thread(new ThreadStart(() => CalculateWork(imagePath, compareImagePath)));
            processingThread.Name = "Autocorellation thread";
            processingThread.Start();
        }

        protected abstract void CalculateWork(String imagePath, String compareImagePath);
    }
}
