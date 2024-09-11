using Microsoft.AspNetCore.Mvc;
using System.Data;
using SisAutoBal.Web.Services.Zoe;
using ClosedXML.Excel;
using SisAutoBal.Web.Controllers;
using SisAutoBal.Web.Models;
using SisAutoZoe.BusinessObjects.Zoe;
using DocumentFormat.OpenXml.Spreadsheet;

namespace SisAutoBal.Web.Controllers
{
    [VerifySession]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    public class AtencionUsuarioReportController : BaseController
    {
        private readonly IDato_rfid_pasoService dato_rfid_pasoService;
        private readonly ITipo_OperService operService;
        public AtencionUsuarioReportController(IDato_rfid_pasoService dato_rfid_pasoService_, ITipo_OperService operService_, IWebHostEnvironment webHostEnv) : base(webHostEnv)
        {
            dato_rfid_pasoService = dato_rfid_pasoService_;
            operService = operService_;
        }
        public async Task<IActionResult> Index()
        {
            ViewData["FechaInicio"] = DateTime.Now.ToString("dd/MM/yyyy");
            ViewData["FechaFinal"] = DateTime.Now.ToString("dd/MM/yyyy");
            ViewData["Tipo_Oper"] = await operService.Listar("*" , "*");
            return View();
        }
        public async Task<IActionResult> Report(String FechaInicio, String FechaFinal,String Nro_Placa,String Tipo_Oper)
        {
            DataTable AtencionReporte = await dato_rfid_pasoService.AtencionReporte(FechaInicio ,FechaFinal, Nro_Placa==null?"*": Nro_Placa, Tipo_Oper == "todo" ? "*" : Tipo_Oper);
            Dictionary<String, DataTable> ListDatos = new Dictionary<String, DataTable>()
            {
                { "DSDatos_DTDatos" ,AtencionReporte }
            };
            Dictionary<String, String> Parametros = new Dictionary<String, String>()
            {
                {"paFechaIn","  Del "+ FechaInicio +"  Al "}, {"paFechaFi",FechaFinal.ToString()}
            };
            return Procesar_Reporte(ListDatos, "AtencionUsuario.rdlc", Parametros, getFormato("Pdf"));
        }

        public async Task<IActionResult> ExportarExcel(String FechaInicio, String FechaFinal, String Nro_Placa, String Tipo_Oper)
        {
            DataTable AtencionReporte = await dato_rfid_pasoService.AtencionReporte(FechaInicio, FechaFinal, Nro_Placa == null ? "*" : Nro_Placa, Tipo_Oper == "todo" ? "*" : Tipo_Oper);
            using (var libro = new XLWorkbook())
            {
                AtencionReporte.TableName = "Atencion Usuarios ZOE";
                var hoja = libro.Worksheets.Add(AtencionReporte);
                hoja.ColumnsUsed().AdjustToContents();
                using (var memoria = new MemoryStream())
                {
                    libro.SaveAs(memoria);

                    var nombreexcel = String.Concat("Atencion Usuarios ZOE", FechaInicio, FechaFinal, ".xlsx");

                    return File(memoria.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", nombreexcel);
                }
            }
        }
            
    }
}
