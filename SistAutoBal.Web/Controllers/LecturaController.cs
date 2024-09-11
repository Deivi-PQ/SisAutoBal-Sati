using Microsoft.AspNetCore.Mvc;
using SisAutoBal.Web.Models;
using SisAutoBal.Web.Services.OfiSegu;
using SisAutoBal.Web.Services.Zoe;
using SisAutoZoe.BusinessObjects.Zoe;

namespace SisAutoBal.Web.Controllers
{
    [VerifySession]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    public class LecturaController : Controller
    {
        private readonly ILectura_Punto_PasoService lectura_Punto_PasoService;
        private readonly ITPunto_PasoService punto_PasoService;
        public LecturaController(ILectura_Punto_PasoService _lectura_Punto_PasoService, ITPunto_PasoService _punto_PasoService, IHttpContextAccessor httpContextAccessor)
        {
            lectura_Punto_PasoService = _lectura_Punto_PasoService;
            punto_PasoService = _punto_PasoService;
        }
        public async Task<IActionResult> Index()
        {
            ViewData["FechaInicio"] = DateTime.Now.ToString("dd/MM/yyyy");
            ViewData["FechaFinal"] = DateTime.Now.ToString("dd/MM/yyyy");
            ViewData["Punto_Paso"] = await punto_PasoService.Listar(new CTPunto_Paso { Cod_Punto = 0, SN = "", Des_Punto_Paso = "", Estado = 'A' });
            return View();
        }
        public async Task<JsonResult> Listar(String SN, String Nro_Placa, String FechaInicio, String FechaFinal,String Tipo)
        {
            IList<CLectura_Punto_Paso> lectura_Punto_Paso = await lectura_Punto_PasoService.Listar(SN,Nro_Placa==null?"*": Nro_Placa, FechaInicio,FechaFinal,Tipo);
            if (lectura_Punto_Paso != null)
            {
                return Json(lectura_Punto_Paso);
            }
            else
            {
                return Json(new List<CLectura_Punto_Paso>());
            }
        }
    }
}
