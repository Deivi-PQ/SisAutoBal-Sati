//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: martes, 27 de agosto de 2024
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
    
    
    [Route("api/Evento_Modulo")]
    [ApiController()]
    public partial class Evento_ModuloController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CEvento_Modulo oTEvento_Modulo)
        {
            try
            {
                Evento_ModuloFacade faTEvento_Modulo = new Evento_ModuloFacade();
                bool result = faTEvento_Modulo.Grabar(oTEvento_Modulo);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faTEvento_Modulo.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{IDEvento}")]
        [HttpGet()]
        public virtual int Eliminar(Int64 IDEvento)
        {
            try
            {
                Evento_ModuloFacade faTEvento_Modulo = new Evento_ModuloFacade();
                return faTEvento_Modulo.Eliminar(IDEvento);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{IDEvento}")]
        [HttpGet()]
        public virtual CEvento_Modulo Recuperar(Int64 IDEvento)
        {
            try
            {
                Evento_ModuloFacade faTEvento_Modulo = new Evento_ModuloFacade();
                return faTEvento_Modulo.Recuperar(IDEvento);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{IDEvento}")]
        [HttpGet()]
        public virtual bool Existe(Int64 IDEvento)
        {
            try
            {
                Evento_ModuloFacade faTEvento_Modulo = new Evento_ModuloFacade();
                return faTEvento_Modulo.Existe(IDEvento);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CEvento_Modulo> Listar()
        {
            try
            {
                Evento_ModuloFacade faTEvento_Modulo = new Evento_ModuloFacade();
                return faTEvento_Modulo.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
