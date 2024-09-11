using Microsoft.AspNetCore.Mvc;
using SisAutoBal.BusinessObjects.AutoBal;
using SisAutoBal.Web.Models;
using SisAutoBal.Web.Services.Reporte;
using SisAutoBal.Web.Services.SignalR;
using System.Collections.Generic;
using System.Data;
using System.Web;

namespace SisAutoBal.Web.Controllers
{
    [VerifySession]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    public class ReporteController : BaseController
    {
        private readonly IReporteAperturaService reporteAperturaService;
        private readonly ISignalRService _signalRServices;
        public ReporteController(IReporteAperturaService _reporteAperturaService, IWebHostEnvironment webHostEnv, ISignalRService signalRServices) : base(webHostEnv)
        {
            reporteAperturaService = _reporteAperturaService;
            _signalRServices = signalRServices;
        }
        public async Task<ActionResult> Reporte()
        {
            ViewData["Balanza"] = await _signalRServices.Listar();
            return View();
        }

        public async Task<IActionResult> Report( String FechaInicio, String FechaFinal, String Balanza, String Estado)
        {
            IList<CAuditoriaBalazaGenaral> cAuditoriaBalanzas = await reporteAperturaService.Listar_X_Fecha(FechaInicio + "T00:00:00", FechaFinal + "T23:59:00", Balanza, Estado);
            tools tools = new tools();
            DataTable dtDatos = tools.ToDataTableGeneral(cAuditoriaBalanzas);
            Dictionary<String, DataTable> ListDatos = new Dictionary<String, DataTable>()
            {
                { "DSDatos_DTDatos" ,dtDatos }
            };
            Dictionary<String, String> Parametros = new Dictionary<String, String>()
            {
                {"paFechaIn","Del: "+FechaInicio+"  Al: "}, {"paFechaFi",FechaFinal}
            };
            return Procesar_Reporte(ListDatos, "HistorialAper.rdlc", Parametros, getFormato("Pdf"));
        }
    }
}
