using SisAutoBal.BusinessObjects.AutoBal;

namespace SisAutoBal.Web.Services.AutoBal
{
    public interface IPerfilService
    {
        Task<bool> Grabar(CPerfil cPerfil);
        Task<int> Eliminar(Int32 IDPerfil);
        Task<CPerfil> Recuperar(Int32 IDPerfil);
        Task<bool> Existe(Int32 IDPerfil);
        Task<IList<CPerfil>> Listar(String IDPerfil, String Des_Perfil, String Estado);
    }
}
