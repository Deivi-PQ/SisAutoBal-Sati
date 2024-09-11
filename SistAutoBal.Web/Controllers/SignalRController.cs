using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SisAutoBal.Web.Services.SignalR;
using SisAutoBal.BusinessObjects.AutoBal;
using SisAutoBal.Web.Services.OfiSegu;
using SisAutoBal.BusinessObjects.OfiOper;
using SisAutoBal.Web.Models;
using System.Text.Json;
using NuGet.Protocol;
using SisAutoBal.Web.Services.AutoBal;
using AspNetCore.ReportingServices.ReportProcessing.ReportObjectModel;

namespace SisAutoBal.Web.Controllers
{
    [VerifySession]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    public class SignalRController : Controller
    {
        private readonly IHubContext<SignalRHub> _hubContext;
        private readonly ISignalRService _signalRServices;
        private readonly IHttpContextAccessor contxt;
        private readonly UserTracker _userTracker;
        private readonly IAuditoriaBalanzaService _auditoriaBalanzaService;
        private readonly IBala_ContService _bala_ContService;
        public SignalRController(ISignalRService signalRServices, IHubContext<SignalRHub> hubContext, IHttpContextAccessor httpContextAccessor, UserTracker userTracker, IAuditoriaBalanzaService auditoriaBalanzaService, IBala_ContService bala_ContService)
        {
            _signalRServices = signalRServices;
            _hubContext = hubContext;
            contxt = httpContextAccessor;
            _userTracker = userTracker;
            _auditoriaBalanzaService = auditoriaBalanzaService;
            _bala_ContService = bala_ContService;
        }

        public IActionResult SignalR()
        {
           return View();
        }

        public async Task<IActionResult> SendMessage(string user, string message, string motivo)
        {
            await _hubContext.Clients.All.SendAsync("ReceiveMessage", user, message);
            CAuditoriaBalanza Auditoria=new CAuditoriaBalanza(1,user,message,DateTime.Now, contxt.HttpContext!.Session.GetString("NO_USUA"), motivo);
            await _auditoriaBalanzaService.Grabar(Auditoria);
            return Ok();
        }

        public async Task<IActionResult> SendMessageToGroup(string groupName, string message)
        {
            await _hubContext.Clients.Group(groupName).SendAsync("ReceiveMessage", "Servidor", message);
            return Ok();
        }
        public async Task<IActionResult> SendMessageToUser(string userId, string message)
        {
            await _hubContext.Clients.User(userId).SendAsync("ReceiveMessage", "Servidor", message);
            return Ok();
        }
        public async Task<JsonResult> Listar(String Estado)
        {
            DateTime dateTime= DateTime.Now;
            IList<ClientesActivos> Lista  = (_userTracker.GetActiveUsers()) ?? new List<ClientesActivos>();
            foreach (var elemento in Lista.Where(e => (int)(dateTime.Subtract(e.fecha).TotalSeconds) > 30).ToList())
            {
                _userTracker.RemoveUser(elemento.userId, Lista.IndexOf(elemento));
            }
            IList<CTTIPO_BALA> ListaTipo_Bala  = (await _signalRServices.Listar()) ?? new List<CTTIPO_BALA>();
            if (ListaTipo_Bala != null && Lista != null)
            {  
                return Json((from tipoBala in ListaTipo_Bala
                                   join item in Lista on tipoBala.ID_BALA equals item.connectionId
                                   select new CTTIPO_BALA
                                   {
                                       ID_BALA = tipoBala.ID_BALA,
                                       ID_CLAS_BALA = tipoBala.ID_CLAS_BALA,
                                       ID_EMPR = tipoBala.ID_EMPR,
                                       DE_TIPO = tipoBala.DE_TIPO,
                                       IP_MAQU = tipoBala.IP_MAQU,
                                       IP_CA01 = tipoBala.IP_CA01,
                                       CO_USUA_CA01 = tipoBala.CO_USUA_CA01,
                                       CO_CONT_CA01 = tipoBala.CO_CONT_CA01,
                                       IP_CA02 = tipoBala.IP_CA02,
                                       CO_USUA_CA02 = tipoBala.CO_USUA_CA02,
                                       CO_CONT_CA02 = tipoBala.CO_CONT_CA02,
                                       ID_USUA_CREA = tipoBala.ID_USUA_CREA,
                                       FE_USUA_CREA = tipoBala.FE_USUA_CREA,
                                       ID_USUA_MODI = tipoBala.ID_USUA_MODI,
                                       FE_USUA_MODI = tipoBala.FE_USUA_MODI,
                                       ST_TRAF_CONT = tipoBala.ST_TRAF_CONT
                                   }).ToList());               
            }
            else
            {
                return Json(new List<CBloqueoPasoBalanza>());
            }
        }
        public String[]? GetConnectedUsers()
        {
            return null ;
        }
        public async Task<IActionResult> AperturaRemota(String TBala,String Tipo ,String  Sentido,String Mensaje, String Motivo)
        {
            CBala_Cont cBala_Cont = await  _bala_ContService.Recuperar(TBala);
            if (cBala_Cont != null)
            {
                String RespuestaApertura = await _signalRServices.AperturaBarrera(TBala,cBala_Cont.SNContr,Tipo,Sentido);
                String RespuestaSemaforo = await _signalRServices.EncendidoSemaforo(TBala, cBala_Cont.SNContr, Tipo, Sentido);
                CAuditoriaBalanza Auditoria = new CAuditoriaBalanza(1, TBala, Mensaje, DateTime.Now, contxt.HttpContext!.Session.GetString("NO_USUA")!, Motivo);
                await _auditoriaBalanzaService.Grabar(Auditoria);
            }

            return Ok();
        }

    }
}
