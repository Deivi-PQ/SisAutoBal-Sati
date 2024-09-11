using Microsoft.AspNetCore.Mvc.Filters;
using SisAutoBal.Web.Controllers;

namespace SisAutoBal.Web.Models
{
    public sealed class VerifySession: ActionFilterAttribute
    {
        private readonly IHttpContextAccessor _context;
        public VerifySession()
        {
            _context = new HttpContextAccessor();
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string NombreUser = _context.HttpContext!.Session.GetString("NombreUser") ?? "";
            if (NombreUser == null || NombreUser == "")
            {
                if (filterContext.Controller is LoginController == false)
                {
                    filterContext.HttpContext.Response.Redirect(@"/Login");
                }
            }
            else
            {
                if (filterContext.Controller is LoginController == true)
                {
                    filterContext.HttpContext.Response.Redirect(@"/Inicio");
                }
            }
        }
    }
}
