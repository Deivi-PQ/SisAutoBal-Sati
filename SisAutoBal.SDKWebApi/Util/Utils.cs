using System.Data;
using System.IO.Compression;
using System.Xml.Serialization;

namespace SisAutoBal.SDKWebApi.Util
{
    public partial class Utils
    {
        #region Metodos Principales

        public virtual bool Verificar(string input)
        {
            // Remover prefijos comunes de hexadecimal (0x o 0X) si están presentes
            if (input.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
            {
                input = input.Substring(2);
            }

            // Verificar si la cadena está vacía
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            // Intentar convertir la cadena a un número hexadecimal
            foreach (char c in input)
            {
                bool isHexDigit = c >= '0' && c <= '9' ||
                                  c >= 'A' && c <= 'F' ||
                                  c >= 'a' && c <= 'f';

                if (!isHexDigit)
                {
                    return false;
                }
            }

            return true;
        }
        public static DataTable DecompressDataTable(byte[] compressedData)
        {
            if (compressedData == null)
                throw new ArgumentNullException(nameof(compressedData));

            // Descomprimir XML
            using (MemoryStream compressedStream = new MemoryStream(compressedData))
            {
                using (GZipStream gzipStream = new GZipStream(compressedStream, CompressionMode.Decompress))
                {
                    using (MemoryStream xmlStream = new MemoryStream())
                    {
                        gzipStream.CopyTo(xmlStream);
                        xmlStream.Position = 0;

                        // Deserializar DataTable desde XML
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(DataTable));
                        return (DataTable)xmlSerializer.Deserialize(xmlStream);
                    }
                }
            }
        }
        #endregion
    }
}
