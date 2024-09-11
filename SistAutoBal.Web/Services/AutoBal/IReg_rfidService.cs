using SisAutoBal.BusinessObjects.AutoBal;

namespace SisAutoBal.Web.Services.AutoBal
{
    public interface IReg_rfidService
    {
        Task<bool> Grabar(CREGI_RFID cREGI_RFID);
        Task<int> Eliminar(String Cod_RFID);
        Task<bool> Existe(String Cod_RFID);
        Task<IList<CREGI_RFID>> Listar(string ID_REGI_PLAC, string Cod_RFID, String VigenciaIni, String VigenciaFin);
        Task<bool> Existe_Placa(String ID_REGI_PLAC);
        Task<CREGI_RFID> Recuperar(String Cod_RFID);
        Task<IList<CEnroladoT>> ProcesarArchivo(CArchivo cArchivo);
        Task<CREGI_RFID> PlacaRFID(String ID_REGI_PLAC);
    }
}
