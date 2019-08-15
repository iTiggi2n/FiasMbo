using System;
using System.Data;
using System.Reflection;

namespace FIAS.DataTableFromXmlEntity
{
    public class DataTableFromXmlEntity
    {
        public static DataTable CreateDataTableFromEntity<T>(T obj) where T : class
        {
            DataTable dataTable = new DataTable();
            foreach (PropertyInfo info in obj.GetType().GetProperties())
            {
                dataTable.Columns.Add(new DataColumn(info.Name, Nullable.GetUnderlyingType(info.PropertyType) ?? info.PropertyType));
            }
            return dataTable;
        }
        public static void SetDataRow<T>(DataTable dataTable, T obj) where T : class
        {
            var properties = obj.GetType().GetProperties();
            int length = obj.GetType().GetProperties().Length;
            object[] values = new object[length];
            for (int i = 0; i < length; i++)
            {
                values[i] = properties[i].GetValue(obj);
            }
            dataTable.Rows.Add(values);
        }
    }
}
