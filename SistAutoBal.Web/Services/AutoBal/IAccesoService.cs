using SisAutoBal.BusinessObjects.AutoBal;

namespace SisAutoBal.Web.Services.AutoBal
{
    public interface IAccesoService
    {
        Task<bool> Grabar(CAcceso oAcceso);
        Task<int> Eliminar(String Cod_Acceso);
        Task<CAcceso> Recuperar(String Cod_Acceso);
        Task<bool> Existe(String Cod_Acceso);
        Task<IList<CAcceso>> Listar(String Cod_Acceso, String Nombre_Acceso, String Descripcion);
        Task<IList<CAcceso>> BuscarAcceso(String IDPerfil);
        Task<IList<CAcceso>> Menu(int IDPerfil);
    }
}
