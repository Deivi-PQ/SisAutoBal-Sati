using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SisAutoBal.BusinessObjects.OfiSegu;
using SisAutoBal.Web.Services.AutoBal;
using SisAutoBal.Web.Services.OfiSegu;
using Ofisis_ = Ofisis.Ofisegu.Seguridad.FuncionesGlobales;
using SisAutoBal.BusinessObjects.AutoBal;
using LibreriaBSNet;
using SisAutoBal.Web.Models;

namespace SisAutoBal.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly ICMusuaService CMUSUAService;
        private readonly IHttpContextAccessor contxt;
        private readonly IUsuarioService usuarioService;
        private readonly IConfiguration configuration;
        private readonly IAccesoService accesoService;
        public LoginController(ICMusuaService CMUSUAService_, IUsuarioService usuarioService_, IConfiguration configuration_, IAccesoService accesoService_, IHttpContextAccessor httpContextAccessor)
        {
            CMUSUAService = CMUSUAService_;
            usuarioService = usuarioService_;
            contxt = httpContextAccessor;
            accesoService = accesoService_;
            configuration = configuration_;
        }
        public IActionResult Login()
        {
            Utils util = new Utils();
            IList<Menu> ListMenu = new List<Menu>();
            if (contxt.HttpContext is not null)
            {
                contxt.HttpContext.Session.SetString("NombreUser", "");
                contxt.HttpContext!.Session.Set("ListaMenu", util.ConvertByte(ListMenu));
            }
            return View();
        }
        public async Task<IActionResult> LoginInicio(String Usuario, String Password)
        {
            if (await usuarioService.Existe(Usuario))
            {
                CUsuario usuario = await usuarioService.Recuperar(Usuario);
                if (usuario.flagActDir)
                {
                    String DomainController = configuration["DomainController"];
                    String Error;
                    if (LComun.ValidarUsuarioDominio(DomainController, Usuario, Password, out Error))
                    {
                        if (contxt.HttpContext is not null)
                        {
                            contxt.HttpContext.Session.SetString("NombreUser", usuario.Nombre_Usuario);
                            contxt.HttpContext.Session.SetString("IDUser", usuario.CodUsuario);
                            contxt.HttpContext.Session.SetString("NO_USUA", usuario.CodUsuario);
                        }
                        IList<CAcceso> ListaMenu = await accesoService.Menu(usuario.IDPerfil);
                        Utils util = new Utils();
                        IList<Menu> ListMenu = util.Menu(ListaMenu);
                        contxt.HttpContext!.Session.Set("ListaMenu", util.ConvertByte(ListMenu));
                        return RedirectToAction("SignalR", "SignalR");
                    }
                    else
                    {
                        TempData["MensajeLogin"] = Error;
                        return View("Login");
                    }
                }
                else
                {
                    if (LComun.EncriptarMD5(Password) == usuario.Passwd)
                    {
                        if (contxt.HttpContext is not null)
                        {
                            contxt.HttpContext.Session.SetString("NombreUser", usuario.Nombre_Usuario);
                            contxt.HttpContext.Session.SetString("IDUser", usuario.CodUsuario);
                            contxt.HttpContext.Session.SetString("NO_USUA", usuario.CodUsuario);
                        }
                        IList<CAcceso> ListaMenu = await accesoService.Menu(usuario.IDPerfil);
                        Utils util= new Utils();
                        IList<Menu> ListMenu = util.Menu(ListaMenu);
                        contxt.HttpContext!.Session.Set("ListaMenu", util.ConvertByte(ListMenu));
                        return RedirectToAction("SignalR", "SignalR");
                    }
                    else
                    {
                        TempData["MensajeLogin"] = "Contraseña incorrecta.";
                        return View("Login");
                    }
                }
            }
            else
            {
                TempData["MensajeLogin"] = "Usuario o password incorrecto";
                return View("Login");
            }  
        }
    }
}
