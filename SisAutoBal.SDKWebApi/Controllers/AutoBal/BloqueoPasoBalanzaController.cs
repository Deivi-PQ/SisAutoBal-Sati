//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: martes, 7 de marzo de 2023
// </Auto Generado>
//------------------------------------------------------------------------------
using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LibreriaBSNetCore.Exceptions;
using Microsoft.AspNetCore.Http;
using SisAutoBal.BusinessObjects.AutoBal;
using SisAutoBal.Facade.AutoBal;

namespace SisAutoBalWebApi.Controllers.AutoBal
{
    
    
    [Route("api/BloqueoPasoBalanza")]
    [ApiController()]
    public partial class BloqueoPasoBalanzaController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CBloqueoPasoBalanza oBloqueoPasoBalanza)
        {
            try
            {
                BloqueoPasoBalanzaFacade faBloqueoPasoBalanza = new BloqueoPasoBalanzaFacade();
                bool result = faBloqueoPasoBalanza.Grabar(oBloqueoPasoBalanza);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faBloqueoPasoBalanza.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }
        
        [Route("Eliminar/{IDBloqueBal}")]
        [HttpGet()]
        public virtual int Eliminar(String IDBloqueBal)
        {
            try
            {
                BloqueoPasoBalanzaFacade faBloqueoPasoBalanza = new BloqueoPasoBalanzaFacade();
                return faBloqueoPasoBalanza.Eliminar(IDBloqueBal);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }
        
        [Route("Recuperar/{IDBloqueBal}")]
        [HttpGet()]
        public virtual CBloqueoPasoBalanza Recuperar(String IDBloqueBal)
        {
            try
            {
                BloqueoPasoBalanzaFacade faBloqueoPasoBalanza = new BloqueoPasoBalanzaFacade();
                return faBloqueoPasoBalanza.Recuperar(IDBloqueBal);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }
        
        [Route("Existe/{IDBloqueBal}")]
        [HttpGet()]
        public virtual bool Existe(String IDBloqueBal)
        {
            try
            {
                BloqueoPasoBalanzaFacade faBloqueoPasoBalanza = new BloqueoPasoBalanzaFacade();
                return faBloqueoPasoBalanza.Existe(IDBloqueBal);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }

        [Route("Listar/{Fecha}/{Estado}")]
        [HttpGet()]
        public virtual IList<CBloqueoPasoBalanza> Listar(DateTime Fecha, char Estado)
        {
            try
            {
                BloqueoPasoBalanzaFacade faBloqueoPasoBalanza = new BloqueoPasoBalanzaFacade();
                return faBloqueoPasoBalanza.Listar(Fecha, Estado);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                return new List<CBloqueoPasoBalanza>();
            }
        }
        [Route("Actualizar/{ID_REQU_ATEN}/{Nro_Placa}/{EstadoBloqueo}/{ID_USUA}")]
        [HttpGet()]
        public ActionResult<System.Boolean> Actualizar(int ID_REQU_ATEN, string Nro_Placa, string EstadoBloqueo, int ID_USUA)
        {
            try
            {
                BloqueoPasoBalanzaFacade faBloqueoPasoBalanza = new BloqueoPasoBalanzaFacade();
                return faBloqueoPasoBalanza.Actualizar(ID_REQU_ATEN, Nro_Placa, EstadoBloqueo, ID_USUA);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }
    }
}
