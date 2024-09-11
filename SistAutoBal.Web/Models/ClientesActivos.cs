namespace SisAutoBal.Web.Models
{
    public partial class ClientesActivos
    {
        public String connectionId { get; set; }
        public String userId { get; set; }
        public DateTime fecha { get; set; }

        public ClientesActivos()
        { }
        public ClientesActivos(String _connectionId, String _userId, DateTime _fecha)
        {
            connectionId = _connectionId;
            userId = _userId;
            fecha = _fecha;
        }
    }
}
