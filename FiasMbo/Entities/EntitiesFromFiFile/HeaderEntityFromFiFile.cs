using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromFiFile
{
    public class HeaderEntityFromFiFile : ICreateDataTable
    {
        [XmlAttribute("Region")]
        public string Region { get; set; }
        [XmlAttribute("UpdateDate")]
        public string UpdateDate { get; set; }
        [XmlAttribute("Version")]
        public string Version { get; set; }

        public DataTable CreateDataTable<T>(List<T> listeEtities) where T : class
        {
            if (listeEtities.Count == 0)
            {
                return null;
            }
            DataTable dataTable = new DataTable();
            foreach (PropertyInfo info in new HeaderEntityFromFiFile().GetType().GetProperties())
            {
                dataTable.Columns.Add(new DataColumn(info.Name, Nullable.GetUnderlyingType(info.PropertyType) ?? info.PropertyType));
            }
            foreach (PropertyInfo info in listeEtities.FirstOrDefault().GetType().GetProperties())
            {
                dataTable.Columns.Add(new DataColumn(info.Name, Nullable.GetUnderlyingType(info.PropertyType) ?? info.PropertyType));
            }
            foreach (var entityItem in listeEtities)
            {
                List<object> value = new List<object>();
                foreach (var property in (new HeaderEntityFromFiFile()).GetType().GetProperties())
                {
                    value.Add(property.GetValue(this as HeaderEntityFromFiFile));
                }
                foreach (var property in entityItem.GetType().GetProperties())
                {
                    value.Add(property.GetValue(entityItem));
                }
                dataTable.Rows.Add(value.ToArray());
            }
            return dataTable;
        }
    }
}
