using SisAutoBal.BusinessObjects.AutoBal;

namespace SisAutoBal.Web.Services.AutoBal
{
    public interface IAcceso_PerfilService
    {
        Task<bool> Grabar(CAcceso_Perfil oTAcceso_Perfil);
        Task<int> Eliminar(String Cod_Acceso, Int32 IDPerfil);
        Task<CAcceso_Perfil> Recuperar(String Cod_Acceso, Int32 IDPerfil);
        Task<bool> Existe(String Cod_Acceso, Int32 IDPerfil);
        Task<IList<CAcceso_Perfil>> Listar();
    }
}
