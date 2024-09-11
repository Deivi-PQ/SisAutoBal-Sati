using SisAutoZoe.BusinessObjects.Zoe;

namespace SisAutoBal.Web.Services.Zoe
{
    public interface ITipo_OperService
    {
        Task<bool> Grabar(CTipo_Oper oTipo_Oper);
        Task<int> Eliminar(String Cod_TipoOper);
        Task<CTipo_Oper> Recuperar(String Cod_TipoOper);
        Task<bool> Existe(String Cod_TipoOper);
        Task<IList<CTipo_Oper>> Listar(String Cod_TipoOper, String Nom_TipoOper);
    }
}
