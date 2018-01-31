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
using System.Windows.Forms;

namespace Steganography.Autocorrelation
{
    public class AutocorrelationCPU : IAutocorrelation
    {
        private int byteIndex;

        public void Calculate(String imagePath, String compareImagePath)
        { 
            try
            {
                //Ucitavanje bitmapa
                Bitmap bitmap = new Bitmap(imagePath);
                Bitmap compareBitmap = new Bitmap(compareImagePath);
                
                //Alokacija niza bajtova
                int arrayLevel = Convert.ToInt32(Math.Ceiling(Math.Log(bitmap.Width * 3, 2)));
                int arrayWidth = Convert.ToInt32(Math.Pow(2, arrayLevel));

                int[] byteArrayOffImage = new int[arrayWidth];

                //Preracunavanje autokorelacije prve slike
                int[] imageAutocor = new int[bitmap.Height * arrayWidth];
                byteIndex = 0;
                for (int i = 0; i < bitmap.Height; i++)
                {
                    //Ucitavanje bytova slike
                    for (int j = 0; j < bitmap.Width * 3; j++)
                        byteArrayOffImage[j] = ByteFromImage(bitmap);
                    CalcAutocorrelation(byteArrayOffImage).CopyTo(imageAutocor, byteArrayOffImage.Length * i);
                }

                arrayLevel = Convert.ToInt32(Math.Ceiling(Math.Log(compareBitmap.Width * 3, 2)));
                arrayWidth = Convert.ToInt32(Math.Pow(2, arrayLevel));

                //Preracunavanje autokorelacije druge slike
                int[] compareAutocor = new int[compareBitmap.Height * arrayWidth];
                byteArrayOffImage = new int[arrayWidth];
                byteIndex = 0;
                for (int i = 0; i < compareBitmap.Height; i++)
                {
                    for (int j = 0; j < compareBitmap.Width * 3; j++)
                        byteArrayOffImage[j] = ByteFromImage(compareBitmap);
                    CalcAutocorrelation(byteArrayOffImage).CopyTo(compareAutocor, byteArrayOffImage.Length * i);
                }

                int[] diff = imageAutocor;

                for (int i = 0; i < imageAutocor.Length; i++)
                    diff[i] -= compareAutocor[i];
                    //diff[i] = Math.Abs(diff[i] - compareAutocor[i]);


                Form chart = new Chart(diff);
                DialogResult result = chart.ShowDialog();

                bitmap.Dispose();
                compareBitmap.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public int[] fwhd(int n , int[]  src)
        {
            int[] a = new int[n];
            int[] b = new int[n];
            int[] tmp;
            Array.Copy(src, a, n);

            // Fast Walsh Hadamard Transform.
            int i, j, s;
            for (i = n >> 1; i > 0; i >>= 1)
            {
                for (j = 0; j < n; j++)
                {
                    s = j / i % 2;

                    b[j] = a[(s == 1 ? -i : 0) + j] + (s == 1 ? -1 : 1) * a[(s == 1 ? 0 : i) + j];
                }
                tmp = a;
                a = b;
                b = tmp;
            }

            return a;
        }

        private int[] CalcAutocorrelation(int[] bytes)
        {
            int[] rezfir = fwhd(bytes.Length, bytes);
            for (int i = 0; i < rezfir.Length; i++)
                rezfir[i] = rezfir[i] * rezfir[i];
            int[] rezsq = fwhd(rezfir.Length, rezfir);

            int level = Convert.ToInt32(Math.Pow(2, Math.Log(bytes.Length, 2)));
            for (int i = 0; i < rezsq.Length; i++)
                rezsq[i] = rezsq[i] * level;
            return rezsq;
        }

        private int ByteFromImage(Bitmap bitmap)
        {
            Byte result = 0;
            int x, y;
            for (int i = 0; i < 8; i++)
            {
                x = (byteIndex / 3) % bitmap.Width;
                y = (byteIndex / 3) / bitmap.Width;
                Color pixel = bitmap.GetPixel(x, y);

                //Ekstrakcija bitova
                switch (byteIndex % 3)
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
            }
            byteIndex++;
            return Convert.ToInt32(result);
        }
    }
}
