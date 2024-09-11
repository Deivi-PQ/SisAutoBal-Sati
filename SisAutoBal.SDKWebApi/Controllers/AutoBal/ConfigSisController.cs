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
    
    
    [Route("api/ConfigSis")]
    [ApiController()]
    public partial class ConfigSisController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CConfigSis oconfigSis)
        {
            try
            {
                ConfigSisFacade faConfigSis = new ConfigSisFacade();
                bool result = faConfigSis.Grabar(oconfigSis);
                if (!result)
                {
                    return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faConfigSis.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{Nombre_Variable}")]
        [HttpGet()]
        public virtual int Eliminar(String Nombre_Variable)
        {
            try
            {
                ConfigSisFacade faConfigSis = new ConfigSisFacade();
                return faConfigSis.Eliminar(Nombre_Variable);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{Nombre_Variable}")]
        [HttpGet()]
        public virtual CConfigSis Recuperar(String Nombre_Variable)
        {
            try
            {
                ConfigSisFacade faConfigSis = new ConfigSisFacade();
                return faConfigSis.Recuperar(Nombre_Variable);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{Nombre_Variable}")]
        [HttpGet()]
        public virtual bool Existe(String Nombre_Variable)
        {
            try
            {
                ConfigSisFacade faConfigSis = new ConfigSisFacade();
                return faConfigSis.Existe(Nombre_Variable);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CConfigSis> Listar()
        {
            try
            {
                ConfigSisFacade faTCONFIGSIS = new ConfigSisFacade();
                return faTCONFIGSIS.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
