using Microsoft.AspNetCore.Mvc;
using SisAutoZoe.BusinessObjects.Zoe;
using SisAutoBal.Web.Services.Zoe;
using SisAutoBal.Web.Models;

namespace SisAutoBal.Web.Controllers
{
    [VerifySession]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    public class MantRecoOperController : Controller
    {
        private readonly IHttpContextAccessor contxt;
        private readonly IReco_OperService reco_OperService;
        public MantRecoOperController(IHttpContextAccessor contxt_, IReco_OperService reco_OperService_)
        {
            contxt = contxt_;
            reco_OperService = reco_OperService_;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> Grabar(CReco_Oper cReco_Oper)
        {
            try
            {
                if (await reco_OperService.Grabar(cReco_Oper))
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
