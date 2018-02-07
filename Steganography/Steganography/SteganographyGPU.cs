using Steganography.Nvidia;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography.Steganography
{
    class SteganographyGPU : ISteganography
    {
        public SteganographyGPU(Form form)
        {
            mainForm = (MainForm)form;
        }

        public override bool CheckIsImageHidingData(string imagePath)
        {
            try
            {
                byte[] code = new byte[2];

                try
                {
                    if (!File.Exists(imagePath))
                        throw new Exception("Slika ne postoji.");

                    return new SteganographyCPU(mainForm).CheckIsImageHidingData(imagePath);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
           }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        protected override void PackWork(string imagePath, string filePath, string destinationPath)
        {
            this.mainForm.Enabled = false;
            try
            {
                if (!File.Exists(imagePath))
                    throw new Exception("Slika ne postoji.");

                if (!File.Exists(filePath))
                    throw new Exception("Fajl koji se pakuje nepostoji.");

                FileStream dataFile = new FileStream(filePath, FileMode.Open);

                //2B code pakovanja "C0DE"  , 24B su za ekstenziju i 4B su za duzinu fajla
                //Pakovanje koda od 2B
                byte[] fileBytes = new byte[dataFile.Length + 30];
                fileBytes[0] = Convert.ToByte(192);
                fileBytes[1] = Convert.ToByte(222);

                //Pakovanje stringa extenzije
                String extensionString = Path.GetExtension(filePath);
                for (int i = 2; i < 26; i++)
                    if (i < extensionString.Length + 2)
                        fileBytes[i] = Convert.ToByte(extensionString[i - 2]);

                //Pakovanje velicine fajla koji se kodira
                UInt32 fileSize = Convert.ToUInt32(dataFile.Length);
                Byte[] fileSizeByteArray = BitConverter.GetBytes(fileSize);
                Array.Reverse(fileSizeByteArray);
                for (int i = 26; i < 30; i++)
                    fileBytes[i] = fileSizeByteArray[i - 26];

                dataFile.Read(fileBytes, 30, (int)dataFile.Length);
                dataFile.Close();

                byte[] imageBytes = null;
                BitmapData bmpdata = null;
                Bitmap bitmap = new Bitmap(imagePath);

                try
                {
                    bmpdata = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, bitmap.PixelFormat);
                    int numbytes = bmpdata.Stride * bitmap.Height;
                    imageBytes = new byte[numbytes];
                    IntPtr ptr = bmpdata.Scan0;

                    Marshal.Copy(ptr, imageBytes, 0, numbytes);
                    CudaAPI.PackBytes(imageBytes, fileBytes);
                    Marshal.Copy(imageBytes, 0, ptr, numbytes);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return;
                }
                finally
                {
                    if (bmpdata != null)
                        bitmap.UnlockBits(bmpdata);
                }

                bitmap.Save(destinationPath);
                bitmap.Dispose();
                mainForm.PackFinished(destinationPath);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
            finally
            {
                this.mainForm.Enabled = true;
            }
        }

        protected override void UnpackWork(string imagePath, string destinationPath)
        {
            this.mainForm.Enabled = false;
            try
            {
                if (!File.Exists(imagePath))
                    throw new Exception("Slika ne postoji.");

                byte[] imageBytes = null;
                BitmapData bmpdata = null;
                Bitmap bitmap = new Bitmap(imagePath);

                try
                {
                    bmpdata = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, bitmap.PixelFormat);
                    int numbytes = bmpdata.Stride * bitmap.Height;
                    imageBytes = new byte[numbytes];

                    IntPtr ptrStart = bmpdata.Scan0;
                    Marshal.Copy(ptrStart, imageBytes, 0, numbytes);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return;
                }
                finally
                {
                    if (bmpdata != null)
                        bitmap.UnlockBits(bmpdata);
                    bitmap.Dispose();
                }

                byte[] unpackBytes = new byte[imageBytes.Length];
                CudaAPI.UnpackBytes(imageBytes, unpackBytes);
                
                //Extracting extension and filesize
                StringBuilder extension = new StringBuilder();
                Byte[] fileSizeByteArray = new Byte[4];

                for (int i = 2; i < 30; i++)
                {
                    if (i < 26)
                        extension.Append(Convert.ToChar(unpackBytes[i]));
                    else
                        fileSizeByteArray[i - 26] = unpackBytes[i];
                }

                string extensionString = extension.ToString();
                extensionString = extensionString.Substring(0, extensionString.IndexOf('\0'));
                Array.Reverse(fileSizeByteArray);
                UInt32 fileSize = BitConverter.ToUInt32(fileSizeByteArray, 0);

                //Ekstraktovanje podataka i upisivanje u fajl
                String outputPath = destinationPath + extensionString;
                FileStream outputFile = new FileStream(outputPath, FileMode.Create);

                byte[] fileBytes = new byte[fileSize];

                outputFile.Write(unpackBytes, 30, (int)fileSize);
                outputFile.Close();

                mainForm.UnpackFinished();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
            finally
            {
                this.mainForm.Enabled = true;
            }
        }
    }
}
