using SisAutoZoe.BusinessObjects.Zoe;

namespace SisAutoBal.Web.Services.Zoe
{
    public interface IReco_OperService
    {
        Task<bool> Grabar(CReco_Oper oReco_Oper);
        Task<int> Eliminar(String Cod_TipoOper, Int32 Cod_Punto);
        Task<CReco_Oper> Recuperar(String Cod_TipoOper, Int32 Cod_Punto);
        Task<bool> Existe(String Cod_TipoOper, Int32 Cod_Punto);
        Task<IList<CReco_Oper>> Listar(CReco_Oper oReco_Oper);
    }
}
