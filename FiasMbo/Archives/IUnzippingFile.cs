using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAS.Archives
{
    interface IUnzippingFile
    {
        void UnzipFile(string pathFile, string unzippingFileName);
    }
}
