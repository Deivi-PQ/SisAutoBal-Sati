using SisAutoBal.BusinessObjects.AutoBal;

namespace SisAutoBal.Web.Services.AutoBal
{
    public interface IBloqueoPasoBalanzaService
    {
        Task<IList<CBloqueoPasoBalanza>> Listar(DateTime Fecha, char Estado);
        Task<CBloqueoPasoBalanza> Recuperar(String IDBloqueBal);
        Task<bool> Actualizar(int ID_REQU_ATEN, string Nro_Placa, string EstadoBloqueo, int ID_USUA);
    }
}
