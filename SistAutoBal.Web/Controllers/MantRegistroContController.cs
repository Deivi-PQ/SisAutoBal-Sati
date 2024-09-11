using Microsoft.AspNetCore.Mvc;
using SisAutoZoe.BusinessObjects.Zoe;
using SisAutoBal.Web.Services.Zoe;
using SisAutoBal.Web.Models;

namespace SisAutoBal.Web.Controllers
{
    [VerifySession]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    public class MantRegistroContController : Controller
    {
        private readonly IHttpContextAccessor contxt;
        private readonly ITPunto_PasoService punto_PasoService;

        public MantRegistroContController(IHttpContextAccessor contxt_, ITPunto_PasoService punto_PasoService_)
        {
            contxt = contxt_;
            punto_PasoService = punto_PasoService_;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> Grabar(CTPunto_Paso cTPunto_Paso)
        {
            try
            {
                if (await punto_PasoService.Grabar(cTPunto_Paso))
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

        [HttpPost]
        public async Task<JsonResult> Buscar(CTPunto_Paso cTPunto_Paso)
        {
            cTPunto_Paso.SN = cTPunto_Paso.SN == null ? "" : cTPunto_Paso.SN;
            cTPunto_Paso.Des_Punto_Paso = cTPunto_Paso.Des_Punto_Paso == null ? "" : cTPunto_Paso.Des_Punto_Paso;
            IList<CTPunto_Paso> cpunto_Pasos = await punto_PasoService.Listar(cTPunto_Paso);
            if (cpunto_Pasos != null)
            {
                return Json(cpunto_Pasos);
            }
            else
            {
                return Json(new List<CTPunto_Paso>());
            }
        }
        public async Task<JsonResult> Recuperar(int cod_Punto)
        {
            CTPunto_Paso cpunto_Pasos = await punto_PasoService.Recuperar(cod_Punto);
            if (cpunto_Pasos != null)
            {
                return Json(cpunto_Pasos);
            }
            else
            {
                return Json(new CTPunto_Paso());
            }
        }
        public async Task<JsonResult> Next()
        {
            int  next = await punto_PasoService.Next();
            if (next > 0)
            {
                return Json(new {Next = next });
            }
            else
            {
                return Json(new { Next = 0 } );
            }
        }
    }
}
