using SisAutoBal.BusinessObjects.AutoBal;
using System.Data;

namespace SisAutoBal.Web.Models
{
    public partial class tools
    {
        public DataTable ToDataTable(IList<CAuditoriaBalanza> list)
        {
            DataTable dataTable = new DataTable();
            var properties = typeof(CAuditoriaBalanza).GetProperties();
            foreach (var property in properties)
            {
                dataTable.Columns.Add(property.Name, property.PropertyType);
            }
            foreach (var item in list)
            {
                var row = dataTable.NewRow();
                foreach (var property in properties)
                {
                    row[property.Name] = property.GetValue(item);
                }
                dataTable.Rows.Add(row);
            }
            return dataTable;
        }
        public DataTable ToDataTableGeneral(IList<CAuditoriaBalazaGenaral> list)
        {
            DataTable dataTable = new DataTable();
            var properties = typeof(CAuditoriaBalazaGenaral).GetProperties();
            foreach (var property in properties)
            {
                dataTable.Columns.Add(property.Name, property.PropertyType);
            }
            foreach (var item in list)
            {
                var row = dataTable.NewRow();
                foreach (var property in properties)
                {
                    row[property.Name] = property.GetValue(item);
                }
                dataTable.Rows.Add(row);
            }
            return dataTable;
        }

    }
}
