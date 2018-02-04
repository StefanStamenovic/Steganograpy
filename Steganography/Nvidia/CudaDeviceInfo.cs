using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steganography.Nvidia
{
    public class CudaDeviceInfo
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public float DriverVersion { get; set; }
        public float RuntimeVersion { get; set; }
        public float CapabilityVersion { get; set; }
        public int GlobalMemory { get; set; }
        public int MemoryClockRate { get; set; }
        public int MultyprocessorsNum { get; set; }
        public int MemoryBusWidth { get; set; }
        public int CudaCoresNum { get; set; }
        public int ClockRate { get; set; }
    }
}
