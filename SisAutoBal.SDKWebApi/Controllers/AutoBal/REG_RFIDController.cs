using Microsoft.AspNetCore.Mvc;
using SisAutoBal.BusinessObjects.AutoBal;
using SisAutoBal.Facade.AutoBal;
using LibreriaBSNetCore.Exceptions;
using LibreriaBSNetCore;
using Microsoft.Extensions.Configuration;
using SisAutoBal.SDKWebApi.Util;

namespace SisAutoBal.WebApi.Controllers.AutoBal
{
    [Route("api/REGRFID")]
    [ApiController()]
    public partial class REG_RFIDController:ControllerBase
    {
        IConfiguration configuration;
        public REG_RFIDController(IConfiguration configuration_)
        {
            configuration = configuration_;
        }

        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CREGI_RFID  cREGI_RFID)
        {
            try
            {
                REGI_RFIDFacade faREGI_RFID = new REGI_RFIDFacade();
                bool result = faREGI_RFID.Grabar(cREGI_RFID);
                if (!result)
                {
                    return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faREGI_RFID.getError() }));
                }
                return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }

        [Route("Eliminar/{Cod_RFID}")]
        [HttpGet()]
        public virtual int Eliminar(String Cod_RFID)
        {
            try
            {
                REGI_RFIDFacade faREGI_RFID = new REGI_RFIDFacade();
                return faREGI_RFID.Eliminar(Cod_RFID);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }

        [Route("Existe/{Cod_RFID}")]
        [HttpGet()]
        public virtual bool Existe(String Cod_RFID)
        {
            try
            {
                REGI_RFIDFacade faREGI_RFID = new REGI_RFIDFacade();
                return faREGI_RFID.Existe(Cod_RFID);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }

        [Route("Listar/{ID_REGI_PLAC}/{Cod_RFID}/{VigenciaIni}/{VigenciaFin}")]
        [HttpGet()]
        public virtual IList<CREGI_RFID> Listar(String ID_REGI_PLAC, String Cod_RFID, String VigenciaIni, String VigenciaFin)
        {
            try
            {
                REGI_RFIDFacade faREGI_RFID = new REGI_RFIDFacade();
                return faREGI_RFID.Listar(ID_REGI_PLAC=="*"?"": ID_REGI_PLAC, Cod_RFID == "*" ? "" : Cod_RFID, VigenciaIni, VigenciaFin);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }

        [Route("Existe_Placa/{ID_REGI_PLAC}")]
        [HttpGet()]
        public virtual bool Existe_Placa(String ID_REGI_PLAC)
        {
            try
            {
                REGI_RFIDFacade faREGI_RFID = new REGI_RFIDFacade();
                return faREGI_RFID.Existe_Placa(ID_REGI_PLAC);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }
        [Route("PlacaRFID/{ID_REGI_PLAC}")]
        [HttpGet()]
        public virtual CREGI_RFID PlacaRFID(String ID_REGI_PLAC)
        {
            try
            {
                REGI_RFIDFacade faREGI_RFID = new REGI_RFIDFacade();
                return faREGI_RFID.PlacaRFID(ID_REGI_PLAC);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }

        [Route("Recuperar/{Cod_RFID}")]
        [HttpGet()]
        public virtual CREGI_RFID Recuperar(String Cod_RFID)
        {
            try
            {
                REGI_RFIDFacade faREGI_RFID = new REGI_RFIDFacade();
                return faREGI_RFID.Recuperar(Cod_RFID);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }

        [Route("ProcesarArchivo")]
        [HttpPost()]
        public virtual IList<CEnroladoT> ProcesarArchivo(CArchivo cREGI_RFID)
        {
            try
            {
                String Filename = configuration["SaveDoc"] + cREGI_RFID.FileName;
                ProcesarDoc procesarDoc = new ProcesarDoc();
                IList<CEnroladoT> result = procesarDoc.get_Datos(cREGI_RFID, Filename);
                return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }
    }
}
