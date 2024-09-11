using SisAutoZoe.BusinessObjects.Zoe;

namespace SisAutoBal.Web.Services.Zoe
{
    public interface ILectura_Punto_PasoService
    {
        Task<IList<CLectura_Punto_Paso>> Listar(String SN, String Nro_Placa, String FechaInicio, String FechaFinal,String Tipo);
    }
}
