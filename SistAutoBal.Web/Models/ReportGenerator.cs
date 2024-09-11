
using PdfSharpCore.Pdf;
using PdfSharpCore.Drawing;
using SisAutoBal.BusinessObjects.AutoBal;

namespace SisAutoBal.Web.Models
{
    public partial class ReportGenerator
    {
        public String GenerateReport(String FilePath, IList<CAuditoriaBalanza> cAuditoriaBalanzas)
        {
            String FilePath_ = "";
            var document = new PdfDocument();
            var page = document.AddPage();
            var graphics = XGraphics.FromPdfPage(page);
            DrawReportContent(graphics, cAuditoriaBalanzas);
            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);
                document.Save(FilePath);
                FilePath_ = FilePath;
            }
            else
            {
                document.Save(FilePath);
                FilePath_ = FilePath;
            }
            return FilePath_;
        }
        private void DrawReportContent(XGraphics graphics, IList<CAuditoriaBalanza> cAuditoriaBalanzas)
        {
            var fontTitle = new XFont("Arial", 18, XFontStyle.Bold);
            var fontText = new XFont("Arial", 12);
            var brushTitle = XBrushes.Black;
            var brushText = XBrushes.Gray;
            var title = "Reporte Apertura Barrera";
            var titlePoint = new XPoint(50, 50);
            graphics.DrawString(title, fontTitle, brushTitle, titlePoint);
            var content = "Este es un informe de ventas generado en PDF.";
            var contentPoint = new XPoint(50, 100);
            graphics.DrawString(content, fontText, brushText, contentPoint);
        }
    }
}
