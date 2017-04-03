using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography
{
    public partial class Chart : Form
    {
        public Chart()
        {
            InitializeComponent();

        }

        public Chart(int[] dataSet)
        {
            InitializeComponent();

            for (int i = 0; i < dataSet.Length; i++)
                Chart_Autocorrelation.Series[0].Points.AddY(dataSet[i]);
        }
    }
}
