using SisAutoBal.BusinessObjects.AutoBal;

namespace SisAutoBal.Web.Services.Reporte
{
    public interface IReporteAperturaService
    {
        Task<IList<CAuditoriaBalanza>> Listar();
        Task<IList<CAuditoriaBalanza>> ListarPorFecha(String Estado, String FechaInicio, String FechaFinal);
        Task<IList<CAuditoriaBalazaGenaral>> Listar_X_Fecha(String FechaInicio, String FechaFinal, String Balanza, String Estado);
    }
}
