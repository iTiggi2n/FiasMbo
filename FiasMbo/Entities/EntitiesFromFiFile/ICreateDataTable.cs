using System.Collections.Generic;
using System.Data;

namespace FIAS.Entities.EntitiesFromFiFile
{
    interface ICreateDataTable
    {
        DataTable CreateDataTable<T>(List<T> listeEtities) where T : class;
    }
}
