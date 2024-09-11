using SisAutoBal.BusinessObjects.AutoBal;

namespace SisAutoBal.Web.Services.AutoBal
{
    public interface IUsuarioService
    {
        Task<bool> Grabar(CUsuario oUsuario);
        Task<int> Eliminar(String CodUsuario);
        Task<CUsuario> Recuperar(String CodUsuario);
        Task<bool> Existe(String CodUsuario);
        Task<IList<CUsuario>> Listar(String CodUsuario, String Nombre_Usuario, String IDPerfil);
    }
}
