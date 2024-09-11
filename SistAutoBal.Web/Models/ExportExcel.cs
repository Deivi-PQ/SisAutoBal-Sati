using System.Data;
using System.Text;
using System.Xml;

namespace SisAutoBal.Web.Models
{
    public class ExportExcel
    {
        public String ExportToExcel(DataTable dataTable, string filePath)
        {
            XmlDocument xmlDoc = GenerateExcelXml(dataTable);
            xmlDoc.Save(filePath);
            return "true";
        }

        // Método para generar el XML compatible con Excel para un DataTable
        private static XmlDocument GenerateExcelXml(DataTable dataTable)
        {
            XmlDocument xmlDoc = new XmlDocument();
            StringBuilder sb = new StringBuilder();

            // Crear la cabecera del archivo XML
            sb.AppendLine("<?xml version=\"1.0\"?>");
            sb.AppendLine("<?mso-application progid=\"Excel.Sheet\"?>");
            sb.AppendLine("<Workbook xmlns=\"urn:schemas-microsoft-com:office:spreadsheet\"");
            sb.AppendLine(" xmlns:o=\"urn:schemas-microsoft-com:office:office\"");
            sb.AppendLine(" xmlns:x=\"urn:schemas-microsoft-com:office:excel\"");
            sb.AppendLine(" xmlns:ss=\"urn:schemas-microsoft-com:office:spreadsheet\">");

            // Definir estilos (opcional)
            sb.AppendLine("<Styles>");
            sb.AppendLine("<Style ss:ID=\"HeaderStyle\">");
            sb.AppendLine("<Font ss:Bold=\"1\"/>");
            sb.AppendLine("</Style>");
            sb.AppendLine("</Styles>");

            // Agregar contenido de la hoja
            sb.AppendLine("<Worksheet ss:Name=\"" + dataTable.TableName + "\">");
            sb.AppendLine("<Table>");

            // Agregar encabezados de columna con estilo
            sb.AppendLine("<Row>");
            foreach (DataColumn column in dataTable.Columns)
            {
                sb.AppendLine("<Cell ss:StyleID=\"HeaderStyle\"><Data ss:Type=\"String\">" + column.ColumnName + "</Data></Cell>");
            }
            sb.AppendLine("</Row>");

            // Agregar datos de filas
            foreach (DataRow row in dataTable.Rows)
            {
                sb.AppendLine("<Row>");
                foreach (DataColumn column in dataTable.Columns)
                {
                    string cellValue = row[column].ToString();
                    string cellType = GetExcelDataType(column.DataType);
                    sb.AppendLine($"<Cell><Data ss:Type=\"{cellType}\">{cellValue}</Data></Cell>");
                }
                sb.AppendLine("</Row>");
            }

            sb.AppendLine("</Table>");
            sb.AppendLine("</Worksheet>");
            sb.AppendLine("</Workbook>");

            xmlDoc.LoadXml(sb.ToString());
            return xmlDoc;
        }

        // Método para obtener el tipo de dato de Excel basado en el tipo de dato de .NET
        private static string GetExcelDataType(Type type)
        {
            switch (Type.GetTypeCode(type))
            {
                case TypeCode.String:
                    return "String";
                case TypeCode.DateTime:
                    return "DateTime";
                case TypeCode.Boolean:
                    return "Boolean";
                case TypeCode.Int32:
                case TypeCode.Double:
                case TypeCode.Decimal:
                    return "Number";
                default:
                    return "String";
            }
        }
    }
}
