using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAS.Archives.RarArchive
{
    interface IUnzippingRarFile
    {
        void UnzippingRarFileAndDelete(string pathFile, string fullPath);
    }
}
