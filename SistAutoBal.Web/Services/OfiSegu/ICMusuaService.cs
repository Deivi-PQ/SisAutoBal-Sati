using SisAutoBal.BusinessObjects.OfiSegu;

namespace SisAutoBal.Web.Services.OfiSegu
{
    public interface ICMusuaService
    {
        Task<CMUSUA> RecuperarUsuario(String NO_USUA);
        Task<bool> ExisteUsuario(String NO_USUA);
    }
}
