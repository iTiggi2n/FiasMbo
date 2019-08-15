using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAS.Archives.ZipArchive
{
    interface IUnzippingZipFile
    {
        void UnzippingZipFileAndDelete(string pathFile,string fullPath);
    }
}
