using Microsoft.AspNetCore.Mvc;
using SisAutoBal.BusinessObjects.AutoBal;
using SisAutoBal.Facade.AutoBal;
using LibreriaBSNetCore.Exceptions;

namespace SisAutoBal.WebApi.Controllers.AutoBal
{
    [Route("api/AuditoriaBalanza")]
    [ApiController()]
    public partial class AuditoriaBalanzaController:ControllerBase
    {
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CAuditoriaBalanza oAuditoriaBalanza)
        {
            try
            {
                AuditoriaBalanzaFacade faAuditoriaBalanza = new AuditoriaBalanzaFacade();
                bool result = faAuditoriaBalanza.Grabar(oAuditoriaBalanza);
                if (!result)
                {
                    return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faAuditoriaBalanza.getError() }));
                }
                return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }

        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CAuditoriaBalanza> Listar()
        {
            try
            {
                AuditoriaBalanzaFacade faAuditoriaBalanza = new AuditoriaBalanzaFacade();
                return faAuditoriaBalanza.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }

        [Route("ListarPorFecha/{Estado}/{FechaInicio}/{FechaFinal}")]
        [HttpGet()]
        public virtual IList<CAuditoriaBalanza> ListarPorFecha(String Estado, String FechaInicio, String FechaFinal)
        {
            try
            {
                AuditoriaBalanzaFacade faAuditoriaBalanza = new AuditoriaBalanzaFacade();
                return faAuditoriaBalanza.ListarPorFecha( Estado, FechaInicio, FechaFinal);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }

        [Route("Listar_X_Fecha/{FechaInicio}/{FechaFinal}/{Balanza}/{Estado}")]
        [HttpGet()]
        public virtual IList<CAuditoriaBalazaGenaral> Listar_X_Fecha(String FechaInicio, String FechaFinal, String Balanza, String Estado)
        {
            try
            {
                AuditoriaBalanzaFacade faAuditoriaBalanza = new AuditoriaBalanzaFacade();
                return faAuditoriaBalanza.Listar_X_Fecha(FechaInicio, FechaFinal,Balanza,Estado);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }
    }
}
