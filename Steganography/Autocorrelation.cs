using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alea;
using Alea.Parallel;
using Alea.CSharp;
using System.Collections;

namespace Steganography
{
    public class Autocorrelation
    {
        [GpuManaged]
        public void Run()
        {
            try
            {
                var gpu = Gpu.Default;
                var gpus = Device.Devices;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
        [GpuManaged]
        public int[] fwhd(int n , int[]  src)
        {
            

            int[] a = new int[n];
            int[] b = new int[n];
            int[] tmp;
            Array.Copy(src, a, n);

            var gpu = Gpu.Default;
            // Fast Walsh Hadamard Transform.
            //int i, j, s;
            //for (i = n>>1; i > 0; i >>= 1)

            //{
            //    for (j = 0; j < n; j++)
            //    {
            //        s = j / i % 2;

            //        b[j] = a[(s == 1 ? -i : 0) + j] + (s == 1 ? -1 : 1) * a[(s == 1 ? 0 : i) + j];
            //    }
            //    tmp = a;
            //    a = b;
            //    b = tmp;
            //}
            int i, s;
            for (i = n; i > 0; i >>= 1)
            {
                gpu.For(0, n, j => b[j] = a[((j / i % 2) == 1 ? -i : 0) + j] + ((j / i % 2) == 1 ? -1 : 1) * a[((j / i % 2) == 1 ? 0 : i) + j]);

                tmp = a;
                a = b;
                b = tmp;
            }

            return b;
        }
    }
}
