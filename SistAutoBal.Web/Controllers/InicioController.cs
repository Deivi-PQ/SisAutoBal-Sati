using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SisAutoBal.BusinessObjects.AutoBal;
using SisAutoBal.Web.Services.AutoBal;
using SisAutoBal.Web.Services.OfiSegu;
using SisAutoBal.Web.Models;

namespace SisAutoBal.Web.Controllers
{
    [VerifySession]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    public class InicioController : Controller
    {
        private readonly IBloqueoPasoBalanzaService _bloqueoPasoBalanzaService;
        private readonly ICMusuaService _musuaservice;
        private readonly IHttpContextAccessor contxt;

        public InicioController(IBloqueoPasoBalanzaService bloqueoPasoBalanzaService, ICMusuaService musuaservice, IHttpContextAccessor httpContextAccessor)
        {
            _bloqueoPasoBalanzaService = bloqueoPasoBalanzaService;
            _musuaservice = musuaservice;
             contxt = httpContextAccessor;

        }
        public IActionResult Inicio()
        {
            return View();
        }
        public async Task<JsonResult> Listar(DateTime Fecha, char Estado)
        {
            char Estado_ = 'P';
            if (Estado == '0')
                Estado_ = 'P';
            else if (Estado == '1')
                Estado_ = 'A';
            else if (Estado == '2')
                Estado_ = 'D';
            IList<CBloqueoPasoBalanza> ListaBloqueoPasoBalanzas = new List<CBloqueoPasoBalanza>();
            ListaBloqueoPasoBalanzas = await _bloqueoPasoBalanzaService.Listar(Fecha, Estado_);
            if (ListaBloqueoPasoBalanzas != null)
            {
                return Json(ListaBloqueoPasoBalanzas);
            }
            else
            {
                return Json(new List<CBloqueoPasoBalanza>());
            }
        }

        public async Task<JsonResult> Actualizar(int ID_REQU_ATEN, string Nro_Placa, String EstadoBloqueo)
        {
            String ID_USUA = contxt.HttpContext!.Session.GetString("IDUser")!;
            await _bloqueoPasoBalanzaService.Actualizar(ID_REQU_ATEN, Nro_Placa, EstadoBloqueo, Convert.ToInt32(ID_USUA));
            IList<CBloqueoPasoBalanza> ListaBloqueoPasoBalanzas = await _bloqueoPasoBalanzaService.Listar(DateTime.Now, 'P');
            if (ListaBloqueoPasoBalanzas != null)
            {
                return Json(ListaBloqueoPasoBalanzas);
            }
            else
            {
                return Json(new List<CBloqueoPasoBalanza>());
            }
        }
    }
}
