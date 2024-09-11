using SisAutoBal.BusinessObjects.AutoBal;
using SisAutoBal.BusinessObjects.OfiOper;

namespace SisAutoBal.Web.Services.SignalR
{
    public interface ISignalRService
    {
        Task<IList<CTTIPO_BALA>> Listar();
        Task<String> AperturaBarrera(String TBala, String SN_Contr, String Tipo, String Sentido);
        Task<String> EncendidoSemaforo(String TBala,String SN_Contr, String Tipo, String Sentido);
    }
}
