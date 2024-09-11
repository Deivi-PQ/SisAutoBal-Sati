using Microsoft.AspNetCore.Mvc;
using SisAutoBal.BusinessObjects.AutoBal;
using SisAutoBal.Web.Models;
using SisAutoBal.Web.Services.AutoBal;

namespace SisAutoBal.Web.Controllers
{
    [VerifySession]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    public class MantPerfilController : Controller
    {
        private readonly IHttpContextAccessor contxt;
        private readonly IPerfilService perfilService;
        public MantPerfilController(IHttpContextAccessor contxt_, IPerfilService perfilService_)
        {
            contxt = contxt_;
            perfilService = perfilService_;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<JsonResult> Grabar(CPerfil cPerfil)
        {
            try
            {
                if (await perfilService.Grabar(cPerfil))
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

        public async Task<JsonResult> Recuperar(Int32 IDPerfil)
        {
            CPerfil perfil = await perfilService.Recuperar(IDPerfil);
            if (perfil != null)
            {
                return Json(perfil);
            }
            else
            {
                return Json(new CPerfil());
            }
        }

        public async Task<JsonResult> Buscar(String IDPerfil, String Des_Perfil, String Estado)
        {
            IList<CPerfil> perfil = await perfilService.Listar(IDPerfil==null?"*":IDPerfil, Des_Perfil==null?"*":Des_Perfil, Estado);
            if (perfil != null)
            {
                return Json(perfil);
            }
            else
            {
                return Json(new List<CPerfil>());
            }
        }
    }
}
