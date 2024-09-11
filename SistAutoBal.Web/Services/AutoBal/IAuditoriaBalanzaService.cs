using SisAutoBal.BusinessObjects.AutoBal;

namespace SisAutoBal.Web.Services.AutoBal
{
    public interface IAuditoriaBalanzaService
    {
        Task<bool> Grabar(CAuditoriaBalanza oAuditoriaBalanza);
        Task<IList<CAuditoriaBalanza>> Listar();
    }
}