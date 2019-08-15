using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAS.WebRequests.Its
{
    interface IIts
    {
        Dictionary<Uri, string> GetUriesFileIts1C(List<string> names);
    }
}
