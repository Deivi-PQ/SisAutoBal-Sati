using Microsoft.AspNetCore.Mvc;
using SisAutoBal.Web.Models;
using SisAutoBal.Web.Services.Zoe;
using SisAutoZoe.BusinessObjects.Zoe;

namespace SisAutoBal.Web.Controllers
{
    [VerifySession]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    public class MantTipoOperController : Controller
    {
        private readonly IHttpContextAccessor contxt;
        private readonly ITipo_OperService tipo_OperService;

        public MantTipoOperController(IHttpContextAccessor contxt_, ITipo_OperService tipo_OperService_)
        {
            contxt = contxt_;
            tipo_OperService = tipo_OperService_;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<JsonResult> Grabar(CTipo_Oper cTPunto_Paso)
        {
            try
            {
                if (await tipo_OperService.Grabar(cTPunto_Paso))
                {
                    return new JsonResult(new { Error = true });
                }
                else
                {
                    return new JsonResult(new { Error = false });
                }
            }
            catch (Exception Ex)
            {
                return new JsonResult(new { Error = Ex.Message });
            }
        }

        public async Task<JsonResult> Buscar(String Cod_TipoOper, String Nom_TipoOper)
        {
            IList<CTipo_Oper> tipo_Oper = await tipo_OperService.Listar(Cod_TipoOper == null ? "*" : Cod_TipoOper, Nom_TipoOper == null ? "*" : Nom_TipoOper);
            if (tipo_Oper != null)
            {
                return Json(tipo_Oper);
            }
            else
            {
                return Json(new List<CTPunto_Paso>());
            }
        }
        public async Task<JsonResult> Recuperar(String Cod_TipoOper)
        {
            CTipo_Oper tipo_Oper = await tipo_OperService.Recuperar(Cod_TipoOper);
            if (tipo_Oper != null)
            {
                return Json(tipo_Oper);
            }
            else
            {
                return Json(new CTPunto_Paso());
            }
        }
    }
}
