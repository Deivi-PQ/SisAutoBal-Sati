using log4net.Repository.Hierarchy;
using Microsoft.AspNetCore.Mvc;
using SisAutoBal.BusinessObjects.AutoBal;
using SisAutoBal.Web.Services.AutoBal;
using SisAutoBal.Web.Models;
using SisAutoBal.Web.Services.AutoBal;
using SisAutoBal.Web.Services.SignalR;

namespace SisAutoBal.Web.Controllers
{
    [VerifySession]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    public class TBala_ContController : Controller
    {
        private readonly IHttpContextAccessor contxt;
        private readonly IBala_ContService bala_ContService;
        private readonly ISignalRService signalRServices;

        public TBala_ContController(IHttpContextAccessor contxt_, IBala_ContService bala_ContService_, ISignalRService signalRServices_)
        {
            contxt = contxt_;
            bala_ContService = bala_ContService_;
            signalRServices= signalRServices_;
        }
        public async Task<ActionResult> Index()
        {
            ViewData["Balanza"] = await signalRServices.Listar();
            return View();
        }

        public async Task<JsonResult> Buscar(String ID_Bala, String SNContr)
        {
            if(ID_Bala=="todo")
            {
                ID_Bala = "*";
            }
            if(SNContr==null) { SNContr = "*"; }
            IList<CBala_ContDet> ListaBloqueoPasoBalanzas = new List<CBala_ContDet>();
            ListaBloqueoPasoBalanzas = await bala_ContService.Buscar(ID_Bala, SNContr);
            if (ListaBloqueoPasoBalanzas != null)
            {
                return Json(ListaBloqueoPasoBalanzas);
            }
            else
            {
                return Json(new List<CBala_Cont>());
            }
        }
        public async Task<JsonResult> Listar()
        {
            IList<CBala_Cont> ListaBloqueoPasoBalanzas = new List<CBala_Cont>();
            ListaBloqueoPasoBalanzas = await bala_ContService.Listar();
            if (ListaBloqueoPasoBalanzas != null)
            {
                return Json(ListaBloqueoPasoBalanzas);
            }
            else
            {
                return Json(new List<CBala_Cont>());
            }
        }
        [HttpPost]
        public async Task<JsonResult> Grabar(CBala_Cont oBala_Cont)
        {
            try
            {
                if (await bala_ContService.Grabar(oBala_Cont))
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
        public async Task<JsonResult> Eliminar(String IDBala)
        {
            try
            {
                if (await bala_ContService.Eliminar(IDBala) >0)
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
