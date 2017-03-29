using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alea;
using Alea.CSharp;

namespace Steganography
{
    public class Autocorrelation
    {
        [GpuManaged]
        public void Run()
        {
            var gpu = Gpu.Default;
            var gpus = Device.Devices;
        }
    }
}
