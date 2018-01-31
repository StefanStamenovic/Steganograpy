using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steganography
{
    public interface ISteganography
    {
        void Pack(String imagePath, String filePath);
        void Unpack(String imagePath);
        bool CheckIsImageHidingData(String imagePath);
    }
}
