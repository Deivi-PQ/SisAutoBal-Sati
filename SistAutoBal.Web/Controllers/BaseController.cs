using AspNetCore.Reporting;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace SisAutoBal.Web.Controllers
{
    public class BaseController : Controller
    {
        public enum ExportFormat : int { PDF = 1, Excel = 2, Word = 3, Image = 4, CSV = 5, PDFExport = 6 };

        public ExportFormat getFormato(string Tipo)
        {
            if (Tipo == null)
                Tipo = "PDF";

            if (Tipo.ToUpper() == "PDF")
                return ExportFormat.PDF;
            else if (Tipo.ToUpper() == "EXCEL")
                return ExportFormat.Excel;
            else if (Tipo.ToUpper() == "WORD")
                return ExportFormat.Word;
            else if (Tipo.ToUpper() == "IMAGE")
                return ExportFormat.Image;
            else if (Tipo.ToUpper() == "CSV")
                return ExportFormat.CSV;
            else if (Tipo.ToUpper() == "PDFEXPORT")
                return ExportFormat.PDFExport;
            else
                return ExportFormat.PDF;
        }

        protected readonly IWebHostEnvironment _webHostEnv;

        public BaseController(
            IWebHostEnvironment webHostEnv)
        {
            _webHostEnv = webHostEnv;
        }

        public IActionResult Procesar_Reporte(Dictionary<string, DataTable> liDatos, string NombreReporte,Dictionary<string, string> parameters, ExportFormat idTipo)
        {
            try
            {
                if (idTipo != ExportFormat.CSV)
                {
                    string mimeTypoe = "";
                    int extension = 1;
                    var RutaReporte = $"{_webHostEnv.WebRootPath}\\Reports\\" + NombreReporte;
                    System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                    LocalReport localRep = new LocalReport(RutaReporte);
                    foreach (var oDatos in liDatos)
                    {
                        localRep.AddDataSource(oDatos.Key, oDatos.Value);
                    }               
                    if (idTipo == ExportFormat.PDF)
                    {
                        var res = localRep.Execute(RenderType.Pdf, extension, parameters, mimeTypoe);
                        return File(res.MainStream, "application/pdf");
                    }
                    else if (idTipo == ExportFormat.PDFExport)
                    {
                        var res = localRep.Execute(RenderType.Pdf, extension, parameters, mimeTypoe);
                        return File(res.MainStream, "application/pdf", NombreReporte.Replace("rdlc", "pdf"));
                    }
                    else if (idTipo == ExportFormat.Excel)
                    {
                        var res = localRep.Execute(RenderType.Excel, extension, parameters, mimeTypoe);
                        return File(res.MainStream, "application/msexcel", NombreReporte.Replace("rdlc", "xls"));
                    }
                    else if (idTipo == ExportFormat.Word)
                    {
                        var res = localRep.Execute(RenderType.Word, extension, parameters, mimeTypoe);
                        return File(res.MainStream, "application/msword", NombreReporte.Replace("rdlc", "doc"));
                    }
                    else if (idTipo == ExportFormat.Image)
                    {
                        var res = localRep.Execute(RenderType.Image, extension, parameters, mimeTypoe);
                        return File(res.MainStream, "application/jpg", NombreReporte.Replace("rdlc", "jpg"));
                    }
                }
                return View();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
