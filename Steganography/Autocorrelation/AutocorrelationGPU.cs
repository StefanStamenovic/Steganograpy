using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            mainForm.Enabled = true;
        }
    }
}
