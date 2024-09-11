using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using SisAutoBal.BusinessObjects.AutoBal;
using LibreriaBSNetCore.Exceptions;
using System.Data;
using DocumentFormat.OpenXml.Bibliography;
using LibreriaBSNetCore;
using System.Text;

namespace SisAutoBal.SDKWebApi.Util
{
    public partial class ProcesarDoc
    {
        DateTime getCellValueDate(WorkbookPart wbPart, WorksheetPart wsPart, string CellName)
        {
            DateTime res = new DateTime();
            Cell theCell = wsPart.Worksheet.Descendants<Cell>().Where(c => c.CellReference == CellName).FirstOrDefault();
            if (theCell != null && theCell.CellValue != null)
            {
                if (theCell.StyleIndex != null)
                {
                    res = DateTime.FromOADate(double.Parse(theCell.CellValue.Text));
                }
            }
            return res;
        }
        // lectura de datos != a fechas
        string getCellValue(WorkbookPart wbPart, WorksheetPart wsPart, string CellName, bool IsNumeric = true)
        {
            string value = "";
            if (IsNumeric)
                value = "0";
            Cell theCell = wsPart.Worksheet.Descendants<Cell>().Where(c => c.CellReference == CellName).FirstOrDefault();
            if (theCell != null && theCell.CellValue != null)
            {
                value = theCell.CellValue.InnerText;
                if (theCell.DataType != null)
                {
                    switch (theCell.DataType.Value)
                    {
                        case CellValues.SharedString:

                            var stringTable = wbPart.GetPartsOfType<SharedStringTablePart>().FirstOrDefault();
                            if (stringTable != null)
                            {
                                value = stringTable.SharedStringTable.ElementAt(int.Parse(value)).InnerText;
                            }
                            break;

                        case CellValues.Boolean:
                            switch (value)
                            {
                                case "0":
                                    value = "FALSE";
                                    break;
                                default:
                                    value = "TRUE";
                                    break;
                            }
                            break;
                    }
                }
            }
            return value;
        }

        public IList<CEnroladoT> get_Datos(CArchivo Archivo, string Filename)
        {
            if (File.Exists(Filename))
            {
                File.Delete(Filename);
                byte[] byteArray = Encoding.UTF8.GetBytes(Archivo.ContentAsBase64String);
                using (MemoryStream stream = new MemoryStream())
                {
                    stream.Write(byteArray, 0, byteArray.Length);
                    File.WriteAllBytes(Filename.ToString(), stream.ToArray());
                }
            }
            else
            {
                byte[] byteArray = Encoding.UTF8.GetBytes(Archivo.ContentAsBase64String);
                using (MemoryStream stream = new MemoryStream())
                {
                    stream.Write(byteArray, 0, byteArray.Length);
                    File.WriteAllBytes(Filename.ToString(), stream.ToArray());
                }
            }

            string[] Columnas = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BQ,BR,BS,BT,BU,BV,BW,BX,BY,BZ".Split(',');
            // --- Abrir archivo excel
            string nombre_archivo = Filename;
            //creamos nuestra tabla para mostar en la vista 
            IList<CEnroladoT> cEnroladoTs = new List<CEnroladoT>();
            // --- Recorriendo hojas
            int NroHoja = 0;
            try
            {
                using (SpreadsheetDocument spreadSheetDocument = SpreadsheetDocument.Open(nombre_archivo, false))
                {
                    WorkbookPart workbookPart = spreadSheetDocument.WorkbookPart;
                    IEnumerable<Sheet> sheets = spreadSheetDocument.WorkbookPart.Workbook.GetFirstChild<Sheets>().Elements<Sheet>();
                    string relationshipId = sheets.ToList()[NroHoja].Id.Value;
                    string NombreHoja = sheets.ToList()[NroHoja].Name.Value;

                    if (NroHoja == 0 && NombreHoja.Trim() == "Sheet1")
                    {
                        WorksheetPart worksheetPart = (WorksheetPart)spreadSheetDocument.WorkbookPart.GetPartById(relationshipId);
                        Worksheet workSheet = worksheetPart.Worksheet;
                        SheetData sheetData = workSheet.GetFirstChild<SheetData>();
                        //Confirmamos la marca de reconocimiento del archivo
                        string ID_REGI_PLAC = getCellValue(workbookPart, worksheetPart, Columnas[0] + 1.ToString(), false).Trim();
                        string Cod_RFID = getCellValue(workbookPart, worksheetPart, Columnas[1] + 1.ToString(), false).Trim();
                        // Fila inicial
                        int fila = 2;
                        int maxVacios = 2;
                        int Vacios = 0;
                        bool HayEnsayo = true;
                        while (Vacios < maxVacios)
                        {
                            //verificamos si hay filas vacias concecutivos  para detener el bucle vasta  con 2 filas vacias  
                            HayEnsayo = getCellValue(workbookPart, worksheetPart, Columnas[0] + fila.ToString(), false).Trim() != "" ? true : false;
                            if (!HayEnsayo)
                            {
                                Vacios++;
                            }
                            else
                            {
                                // lectura de datos por filas 
                                string ID_REGI_PLAC_ = getCellValue(workbookPart, worksheetPart, Columnas[0] + fila.ToString(), false).Trim();
                                string Cod_RFID_ = getCellValue(workbookPart, worksheetPart, Columnas[1] + fila.ToString(), false).Trim();
                                DateTime Fecha_Valida_ = getCellValueDate(workbookPart, worksheetPart, Columnas[2] + fila.ToString());
                                if (Fecha_Valida_.ToString() != "31/12/9999 00:00:00")
                                {
                                    CEnroladoT cEnrolado = new CEnroladoT(ID_REGI_PLAC_, Cod_RFID_, Fecha_Valida_.ToString() != "" ? Convert.ToString(Fecha_Valida_) : "", "");
                                    cEnroladoTs.Add(cEnrolado);
                                    //cuardamos el registro  en  la base de datos
                                }
                                Vacios = 0;
                            }
                            fila++;
                        }
                    }
                }
                return cEnroladoTs;
            }
            catch (Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }
    }
}
