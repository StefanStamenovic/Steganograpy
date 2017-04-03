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

        public Chart(int[] firstDataSet, int[] secondDataSet)
        {
            InitializeComponent();

            for (int i = 0; i < firstDataSet.Length; i++)
                Chart_Autocorrelation.Series[0].Points.AddY(firstDataSet[i]);

            for (int i = 0; i < secondDataSet.Length; i++)
                Chart_Autocorrelation.Series[1].Points.AddY(secondDataSet[i]);
        }
    }
}
