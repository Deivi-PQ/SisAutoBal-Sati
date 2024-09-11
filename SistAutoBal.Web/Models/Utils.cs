using SisAutoBal.BusinessObjects.AutoBal;
using System.Data;
using System.IO.Compression;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;
using System.Text.Json;

namespace SisAutoBal.Web.Models
{
    public partial  class Utils
    {
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
                        return (DataTable)xmlSerializer.Deserialize(xmlStream)!;
                    }
                }
            }
        }

        public IList<Menu> Menu(IList<CAcceso> ListMenu)
        {
            try
            {
                IList<Menu> MenuList = new List<Menu>();
                var ListBase = ListMenu.Where(lMenu => lMenu.Nivel == 0);
                var ListSubBAse = ListMenu.Where(lMenu => lMenu.Nivel != 0);
                foreach (var Base in ListBase)
                {
                    IList<CAcceso> SubMenu = new List<CAcceso>();
                    Menu _Menu = new Menu();
                    string SBase = Base.Cod_Acceso.Substring(0, 1);
                    foreach (var SubBase in ListSubBAse)
                    {
                        string SBaseSub = SubBase.Cod_Acceso.Substring(0, 1);
                        if (SBase == SBaseSub && SubBase.Nivel == 1 && SubBase.Comando != "")
                        {
                            CAcceso acceso = new CAcceso();
                            acceso.Cod_Sistema = SubBase.Cod_Sistema;
                            acceso.Cod_Acceso = SubBase.Cod_Acceso;
                            acceso.Descripcion = SubBase.Descripcion;
                            acceso.Nombre_Acceso = SubBase.Nombre_Acceso;
                            acceso.Comando = SubBase.Comando;
                            acceso.Nivel = SubBase.Nivel;
                            acceso.Estado = SubBase.Estado;
                            SubMenu.Add(acceso);
                        }
                    }
                    _Menu.Cod_Sistema = Base.Cod_Sistema;
                    _Menu.Cod_Acceso = Base.Cod_Acceso;
                    _Menu.Descripcion = Base.Descripcion;
                    _Menu.Nombre_Acceso = Base.Nombre_Acceso;
                    _Menu.Comando = Base.Comando;
                    _Menu.Nivel = Base.Nivel;
                    _Menu.Estado = Base.Estado;
                    _Menu.SubMenu = SubMenu;
                    _Menu.Target = Target(Base.Nombre_Acceso);
                    _Menu.Class = Class(Base.Nombre_Acceso);
                    MenuList.Add(_Menu);
                }
                return MenuList;
            }
            catch (Exception ex)
            {
                return new List<Menu>();
            }
        }
        public String Target(String Tipo)
        {
            String Target_ = "";
            if (Tipo == "Mantenimientos")
            {
                Target_ = "mantenimiento-nav";
            }
            if (Tipo == "Procesos")
            {
                Target_ = "Procesos-nav";
            }
            if (Tipo == "Configuraciones")
            {
                Target_ = "Configuraciones-nav";
            }
            if (Tipo == "Reportes")
            {
                Target_ = "Reportes-nav";
            }
            return Target_;
        }
        public String Class(String Tipo)
        {
            String Class_ = "";
            if (Tipo == "Mantenimientos")
            {
                Class_ = "bi bi-menu-button-wide";
            }
            if (Tipo == "Procesos")
            {
                Class_ = "bi bi-layout-text-window-reverse";
            }
            if (Tipo == "Configuraciones")
            {
                Class_ = "bi bi-grid";
            }
            if (Tipo == "Reportes")
            {
                Class_ = "bi bi-journal-text";
            }
            return Class_;
        }
        public byte[] ConvertByte(IList<Menu> ListMenu)
        {
            byte[] ListaMenu;
            string jsonString = JsonSerializer.Serialize(ListMenu);
            ListaMenu = Encoding.UTF8.GetBytes(jsonString);
            return ListaMenu;
        }
        public IList<Menu> RecuperarListaMenu(Byte[] ListaMenu)
        {
            string jsonString = Encoding.UTF8.GetString(ListaMenu);
            // Deserializar la cadena JSON en una lista
            List<Menu> ListMenu_ = JsonSerializer.Deserialize<List<Menu>>(jsonString);
            return ListMenu_;
        }
       
        public T Decompress<T>(byte[] compressedData) where T : class
        {
            T val = null;
            string jsonString = Encoding.UTF8.GetString(compressedData);
            return JsonSerializer.Deserialize<T>(jsonString) as T;
        }

        public byte[] Compress<T>(T data)
        {
            byte[] result = null;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (GZipStream serializationStream = new GZipStream(memoryStream, CompressionMode.Compress, leaveOpen: true))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    binaryFormatter.Serialize(serializationStream, data);
                }

                result = memoryStream.ToArray();
            }

            return result;
        }
    }
}
