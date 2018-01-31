using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography
{
    class SteganographyCPU : ISteganography
    {
        private MainForm mainForm;
        private Thread processingTherad;

        private int bitIndex;

        public SteganographyCPU(Form form)
        {
            mainForm = (MainForm)form;
        }

        ~SteganographyCPU()
        {
            if (processingTherad != null)
                processingTherad.Abort();
        }

        public void Pack(String imagePath, String filePath)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            String extension = Path.GetExtension(imagePath);
            String destinationPath = null;
            dialog.Filter = extension.TrimStart('.') + "|*" + extension;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                destinationPath = dialog.FileName;
            }
            else
                return;

            processingTherad = new Thread(new ThreadStart(() => PackWork(imagePath, filePath, destinationPath)));
            processingTherad.Name = "Packing thread";
            processingTherad.Start();
        }

        private void PackWork(String imagePath, String filePath, String destinationPath)
        {
            try
            {
                if (!File.Exists(imagePath))
                    throw new Exception("Slika ne postoji.");
                if (!File.Exists(filePath))
                    throw new Exception("Fajl koji se pakuje nepostoji.");

                FileStream dataFile = new FileStream(filePath, FileMode.Open);
                Bitmap bitmap = new Bitmap(imagePath);

                //2B code pakovanja "C0DE"  , 24B su za ekstenziju i 4B su za duzinu fajla sto zahteva 80pix
                //Pakovanje koda od 2B
                Byte[] dataByteArray = new Byte[30];
                dataByteArray[0] = Convert.ToByte(192);
                dataByteArray[1] = Convert.ToByte(222);

                //Pakovanje stringa extenzije
                String extensionString = Path.GetExtension(filePath);
                for (int i = 2; i < 26; i++) 
                    if (i < extensionString.Length + 2)
                        dataByteArray[i] = Convert.ToByte(extensionString[i-2]);

                //Pakovanje velicine fajla koji se kodira
                UInt32 fileSize = Convert.ToUInt32(dataFile.Length);
                Byte[] fileSizeByteArray = BitConverter.GetBytes(fileSize);
                Array.Reverse(fileSizeByteArray);
                for (int i = 26; i < 30; i++) 
                    dataByteArray[i] = fileSizeByteArray[i - 26];

                //Pakovanje podataka u sliku
                bitIndex = 0;
                for (int i=0;i<30;i++)
                    PackByteToImage(bitmap, dataByteArray[i]);

                //Pakovanje samih podataka
                while (dataFile.Position < dataFile.Length)
                    PackByteToImage(bitmap, Convert.ToByte(dataFile.ReadByte()));

                dataFile.Close();
                bitmap.Save(destinationPath);
                bitmap.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            mainForm.PackFinished(destinationPath);
        }

        private void PackByteToImage(Bitmap bitmap, Byte data)
        {
            Byte bitData = 0;
            int x,y;
            for (int i = 0; i < 8; i++)
            {
                x = (bitIndex / 3) % bitmap.Width;
                y = (bitIndex / 3) / bitmap.Width; 
                Color pixel = bitmap.GetPixel(x, y);

                //Ekstrakcija bitova
                bitData = Convert.ToByte(((Convert.ToUInt32(data)) << (24 + i)) >> 31);
                switch (bitIndex % 3)
                {
                    //R
                    case 0:
                        Byte R = Convert.ToByte((((Convert.ToUInt32(pixel.R)) >> 1) << 1) | bitData);
                        bitmap.SetPixel(x, y, Color.FromArgb(R, pixel.G, pixel.B));
                        break;
                    //G
                    case 1:
                        Byte G = Convert.ToByte((((Convert.ToUInt32(pixel.G)) >> 1) << 1) | bitData);
                        bitmap.SetPixel(x, y, Color.FromArgb(pixel.R, G, pixel.B));
                        break;
                    //B
                    case 2:
                        Byte B = Convert.ToByte((((Convert.ToUInt32(pixel.B)) >> 1) << 1) | bitData);
                        bitmap.SetPixel(x, y, Color.FromArgb(pixel.R, pixel.G, B));
                        break;
                }
                bitIndex++;
            }
        }

        public void Unpack(String imagePath)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            String extension = Path.GetExtension(imagePath);
            String destinationPath = null;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                destinationPath = dialog.FileName;
            }
            else
                return;

            processingTherad = new Thread(new ThreadStart(() => UnpackWork(imagePath,destinationPath)));
            processingTherad.Name = "Unpacking thread";
            processingTherad.Start();
        }

        private void UnpackWork(String imagePath, String destinationPath)
        {
            try
            {
                if (!File.Exists(imagePath))
                    throw new Exception("Slika ne postoji.");
                Bitmap bitmap = new Bitmap(imagePath);

                bitIndex = 0;

                //Extracting code 2B
                UnpackByteFromImage(bitmap);
                UnpackByteFromImage(bitmap);

                String extension = "";
                //Extracting extension
                for (int i = 0; i < 24; i++)
                    extension += (Char)UnpackByteFromImage(bitmap);
                extension = extension.Substring(0, extension.IndexOf('\0'));

                //Ekstrakcija velicine fajla
                Byte[] fileSizeByteArray = new Byte[4];
                for (int i = 0; i < 4; i++)
                    fileSizeByteArray[i] = UnpackByteFromImage(bitmap);
                Array.Reverse(fileSizeByteArray);
                UInt32 fileSize = BitConverter.ToUInt32(fileSizeByteArray, 0);

                //Ekstraktovanje podataka i upisivanje u fajl
                String outputPath = destinationPath + extension;
                FileStream outputFile = new FileStream(outputPath, FileMode.Create);

                for (int i=0; i<fileSize;i++)
                    outputFile.WriteByte(UnpackByteFromImage(bitmap));

                outputFile.Close();
                bitmap.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            mainForm.UnpackFinished();
        }

        private Byte UnpackByteFromImage(Bitmap bitmap)
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

        public bool CheckIsImageHidingData(String imagePath)
        {
            Byte[] code = new Byte[2];
            try
            {
                if (!File.Exists(imagePath))
                    throw new Exception("Slika ne postoji.");
                Bitmap bitmap = new Bitmap(imagePath);

                bitIndex = 0;
                code[0] = UnpackByteFromImage(bitmap);
                code[1] = UnpackByteFromImage(bitmap);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            if (code[0] == 192 && code[1] == 222)
                return true;
            return false;
        }
    }
}
