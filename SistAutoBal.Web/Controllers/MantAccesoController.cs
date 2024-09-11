using DocumentFormat.OpenXml.InkML;
using Microsoft.AspNetCore.Mvc;
using SisAutoBal.BusinessObjects.AutoBal;
using SisAutoBal.Web.Models;
using SisAutoBal.Web.Services.AutoBal;
using SisAutoBal.Web.Services.Zoe;
using SisAutoZoe.BusinessObjects.Zoe;

namespace SisAutoBal.Web.Controllers
{
    [VerifySession]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    public class MantAccesoController : Controller
    {
        private readonly IHttpContextAccessor contxt;
        private readonly IAccesoService accesoService;
        public MantAccesoController(IHttpContextAccessor contxt_, IAccesoService accesoService_)
        {
            contxt = contxt_;
            accesoService = accesoService_;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<JsonResult> Grabar(CAcceso cAcceso)
        {
            try
            {
                cAcceso.Comando = cAcceso.Comando == null ? "" : cAcceso.Comando;
                if (await accesoService.Grabar(cAcceso))
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

        public async Task<JsonResult> Recuperar(String Cod_Acceso)
        {
            CAcceso cAcceso = await accesoService.Recuperar(Cod_Acceso);
            if (cAcceso != null)
            {
                return Json(cAcceso);
            }
            else
            {
                return Json(new CAcceso());
            }
        }

        public async Task<JsonResult> Buscar(String Cod_Acceso, String Nombre_Acceso, String Descripcion)
        {
            IList<CAcceso> cpunto_Pasos = await accesoService.Listar(Cod_Acceso==null?"*":Cod_Acceso,Nombre_Acceso == null ? "*" :Nombre_Acceso, Descripcion == null ? "*" :Descripcion);
            if (cpunto_Pasos != null)
            {
                return Json(cpunto_Pasos);
            }
            else
            {
                return Json(new List<CAcceso>());
            }
        }
    }
}
