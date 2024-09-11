using SisAutoBal.BusinessObjects.AutoBal;

namespace SisAutoBal.Web.Services.AutoBal
{
    public interface IEvento_ModuloService
    {
        Task<bool> Grabar(CEvento_Modulo oTEvento_Modulo);
        Task<int> Eliminar(Int64 IDEvento);
        Task<CEvento_Modulo> Recuperar(Int64 IDEvento);
        Task<bool> Existe(Int64 IDEvento);
        Task<IList<CEvento_Modulo>> Listar();
    }
}
