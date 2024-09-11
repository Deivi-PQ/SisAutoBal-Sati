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
    
    public class MantUsuarioController : Controller
    {
        private readonly IPerfilService perfilService;
        private readonly IUsuarioService usuarioService;
        private readonly IHttpContextAccessor contxt;
        public MantUsuarioController(IPerfilService perfilService_, IUsuarioService usuarioService_, IHttpContextAccessor httpContextAccessor)
        {
            perfilService = perfilService_;
            usuarioService = usuarioService_;
            contxt = httpContextAccessor;
        }
        public async Task<IActionResult> Index()
        {
            ViewData["Perfil"] = await perfilService.Listar("*" , "*" , "A");
            return View();
        }
        [HttpPost]
        public async Task<JsonResult> Grabar(CUsuario usuario)
        {
            
            try
            {
                usuario.Passwd = LibreriaBSNet.LComun.EncriptarMD5(usuario.Passwd);
                usuario.UserEdit = contxt.HttpContext!.Session.GetString("IDUser")!;
                usuario.UserNew = contxt.HttpContext!.Session.GetString("IDUser")!;
                usuario.Mail=usuario.Mail==null?"":usuario.Mail;
                if (await usuarioService.Grabar(usuario))
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
        public async Task<JsonResult> Buscar(String CodUsuario, String Nombre_Usuario, String IDPerfil)
        {
            IList<CUsuario> lectura_Punto_Paso = await usuarioService.Listar(CodUsuario==null?"*":CodUsuario, Nombre_Usuario == null ? "*" : Nombre_Usuario, IDPerfil);
            if (lectura_Punto_Paso != null)
            {
                return Json(lectura_Punto_Paso);
            }
            else
            {
                return Json(new List<CLectura_Punto_Paso>());
            }
        }
        public async Task<JsonResult> Editar(String CodUsuario)
        {
            CUsuario usuario = await usuarioService.Recuperar(CodUsuario == null ? "*" : CodUsuario);
            if (usuario != null)
            {
                return Json(usuario);
            }
            else
            {
                return Json(new CUsuario());
            }
        }
    }
}
