using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steganography.Autocorrelation
{
    public interface IAutocorrelation
    {
        void Calculate(String imagePath, String compareImagePath);
    }
}
