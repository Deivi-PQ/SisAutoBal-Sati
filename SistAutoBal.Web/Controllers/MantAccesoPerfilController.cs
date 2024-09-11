using Microsoft.AspNetCore.Mvc;
using SisAutoBal.BusinessObjects.AutoBal;
using SisAutoBal.Web.Models;
using SisAutoBal.Web.Services.AutoBal;
using SisAutoZoe.BusinessObjects.Zoe;

namespace SisAutoBal.Web.Controllers
{
    [VerifySession]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    public class MantAccesoPerfilController : Controller
    {
        private readonly IAcceso_PerfilService acceso_PerfilService;
        private readonly IUsuarioService usuarioService;
        private readonly IPerfilService perfilService;
        private readonly IHttpContextAccessor contxt;
        private readonly IAccesoService accesoService;
        public MantAccesoPerfilController(IAcceso_PerfilService acceso_PerfilService_,IUsuarioService usuarioService_, IHttpContextAccessor httpContextAccessor, IPerfilService perfilService_, IAccesoService accesoService_)
        {
            acceso_PerfilService = acceso_PerfilService_;
            usuarioService = usuarioService_;
            contxt = httpContextAccessor;
            perfilService = perfilService_;
            accesoService = accesoService_;
        }
        public async Task<IActionResult> Index()
        {
            ViewData["Perfil"] = await perfilService.Listar("*", "*", "A");
            return View();
        }
        public async Task<JsonResult> Buscar(String Cod_Acceso, String Nombre_Acceso, String Descripcion)
        {
            IList<CAcceso> cpunto_Pasos = await accesoService.Listar(Cod_Acceso == null ? "*" : Cod_Acceso, Nombre_Acceso == null ? "*" : Nombre_Acceso, Descripcion == null ? "*" : Descripcion);
            if (cpunto_Pasos != null)
            {
                return Json(cpunto_Pasos);
            }
            else
            {
                return Json(new List<CAcceso>());
            }
        }
        public async Task<JsonResult>  BuscarAcceso(String IDPerfil)
        {
            IList<CAcceso> cpunto_Pasos = await accesoService.BuscarAcceso(IDPerfil == null ? "*" : IDPerfil);
            if (cpunto_Pasos != null)
            {
                return Json(cpunto_Pasos);
            }
            else
            {
                return Json(new List<CAcceso>());
            }
        }

        public async Task<JsonResult> Eliminar(String CodAcceso, int IDPerfil)
        {
            int cpunto_Pasos = await acceso_PerfilService.Eliminar(CodAcceso, IDPerfil);
            if (cpunto_Pasos > 0)
            {
                return new JsonResult(new { Error = true });
            }
            else
            {
                return new JsonResult(new { Error = false });
            }
        }
        [HttpPost]
        public async Task<JsonResult> Grabar(CAcceso_Perfil acceso_Perfil)
        {
            try
            {
                if (await acceso_PerfilService.Grabar(acceso_Perfil))
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
    }
}
