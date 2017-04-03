using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alea;
using Alea.Parallel;
using Alea.CSharp;
using System.Collections;
using System.Drawing;

namespace Steganography
{
    public class Autocorrelation
    {
        private int bitIndex;

        public void Calculate(String imagePath, String compareImagePath)
        { 
            try
            {
                //Ucitavanje bitmapa
                Bitmap bitmap = new Bitmap(imagePath);
                Bitmap compareBitmap = new Bitmap(compareImagePath);
                
                //Alokacija niza bajtova
                int arrayWidth = Convert.ToInt32(Math.Ceiling(Math.Log(bitmap.Width * 3, 2)));

                Byte[] byteArrayOffImage = new Byte[arrayWidth];

                //Preracunavanje autokorelacije prve slike
                int[][] imageAutocor = new int[bitmap.Height][];
                bitIndex = 0;
                for (int i = 0; i < bitmap.Height; i++)
                {
                    //Ucitavanje bytova slike
                    for (int j = 0; j < arrayWidth; j++)
                        byteArrayOffImage[j] = ByteFromImage(bitmap);
                    imageAutocor[i] = Autocorrelation(byteArrayOffImage);
                }

                arrayWidth = Convert.ToInt32(Math.Ceiling(Math.Log(compareBitmap.Width * 3, 2)));
                byteArrayOffImage = new Byte[arrayWidth];

                //Preracunavanje autokorelacije druge slike
                int[][] compareAutocor = new int[compareBitmap.Height][];
                bitIndex = 0;
                for (int i = 0; i < compareBitmap.Height; i++)
                {
                    for (int j = 0; j < arrayWidth; j++)
                        byteArrayOffImage[j] = ByteFromImage(compareBitmap);
                    compareAutocor[i] = Autocorrelation(byteArrayOffImage);
                }

                //TODO: Ovde iskoristiti podatke i nacrtati grafik 

                bitmap.Dispose();
                compareBitmap.Dispose();
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

        public int[] Autocorrelation(Byte[] bytes)
        {
            return null;
        }

        private Byte ByteFromImage(Bitmap bitmap)
        {
            Byte result = 0;
            int x, y;
            for (int i = 0; i < 8; i++)
            {
                x = (bitIndex / 3) % bitmap.Width;
                y = (bitIndex / 3) / bitmap.Width;
                Color pixel = bitmap.GetPixel(x, y);

                //Ekstrakcija bitova
                switch (bitIndex % 3)
                {
                    //R
                    case 0:
                        result = Convert.ToByte(result | (((Convert.ToUInt32(pixel.R)) << 31) >> (24 + i)));
                        break;
                    //G
                    case 1:
                        result = Convert.ToByte(result | (((Convert.ToUInt32(pixel.G)) << 31) >> (24 + i)));
                        break;
                    //B
                    case 2:
                        result = Convert.ToByte(result | (((Convert.ToUInt32(pixel.B)) << 31) >> (24 + i)));
                        break;
                }
                bitIndex++;
            }
            return result;
        }
    }
}
