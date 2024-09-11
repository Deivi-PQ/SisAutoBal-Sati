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
using SisAutoBal.BusinessObjects.OfiOper;
using SisAutoBal.Facade.OfiOper;

namespace SisAutoBalWebApi.Controllers.OfiOper
{
    
    
    [Route("api/CBALA")]
    [ApiController()]
    public partial class CBALAController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CCBALA oCBALA)
        {
            try
            {
                CBALAFacade faCBALA = new CBALAFacade();
                bool result = faCBALA.Grabar(oCBALA);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faCBALA.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }
        
        [Route("Eliminar/{ID_MOVI_BALA}")]
        [HttpGet()]
        public virtual int Eliminar(Int64 ID_MOVI_BALA)
        {
            try
            {
                CBALAFacade faCBALA = new CBALAFacade();
                return faCBALA.Eliminar(ID_MOVI_BALA);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }
        
        [Route("Recuperar/{ID_MOVI_BALA}")]
        [HttpGet()]
        public virtual CCBALA Recuperar(Int64 ID_MOVI_BALA)
        {
            try
            {
                CBALAFacade faCBALA = new CBALAFacade();
                return faCBALA.Recuperar(ID_MOVI_BALA);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }
        
        [Route("Existe/{ID_MOVI_BALA}")]
        [HttpGet()]
        public virtual bool Existe(Int64 ID_MOVI_BALA)
        {
            try
            {
                CBALAFacade faCBALA = new CBALAFacade();
                return faCBALA.Existe(ID_MOVI_BALA);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CCBALA> Listar()
        {
            try
            {
                CBALAFacade faCBALA = new CBALAFacade();
                return faCBALA.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }


        #region Validaciones y Bloqueos
        [Route("Tiene_Pesaje/{Nro_Placa}")]
        [HttpGet()]
        public CCBALA Tiene_Pesaje(string Nro_Placa)
        {
            try
            {
                CBALAFacade faCBALA = new CBALAFacade();
                return faCBALA.Tiene_Pesaje(Nro_Placa);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }
        #endregion Validaciones y Bloqueos
    }
}
