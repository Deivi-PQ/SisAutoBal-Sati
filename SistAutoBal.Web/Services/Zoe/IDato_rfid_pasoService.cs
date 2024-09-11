using SisAutoZoe.BusinessObjects.Zoe;
using System.Data;

namespace SisAutoBal.Web.Services.Zoe
{
    public interface IDato_rfid_pasoService
    {
        Task<DataTable> AtencionReporte(String FeIncial, String FeFinal, String Nro_Placa, String Tipo_Oper);
    }
}
