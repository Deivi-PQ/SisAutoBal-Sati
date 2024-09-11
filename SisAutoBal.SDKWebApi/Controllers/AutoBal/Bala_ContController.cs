     //------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: martes, 7 de mayo de 2024
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
    
    
    [Route("api/Bala_Cont")]
    [ApiController()]
    public partial class Bala_ContController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CBala_Cont oBala_Cont)
        {
            try
            {
                Bala_ContFacade faBala_Cont = new Bala_ContFacade();
                bool result = faBala_Cont.Grabar(oBala_Cont);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faBala_Cont.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }
        
        [Route("Eliminar/{ID_BALA}")]
        [HttpGet()]
        public virtual int Eliminar(String ID_BALA)
        {
            try
            {
                Bala_ContFacade faBala_Cont = new Bala_ContFacade();
                return faBala_Cont.Eliminar(ID_BALA);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }
        
        [Route("Recuperar/{ID_BALA}")]
        [HttpGet()]
        public virtual CBala_Cont Recuperar(String ID_BALA)
        {
            try
            {
                Bala_ContFacade faBala_Cont = new Bala_ContFacade();
                return faBala_Cont.Recuperar(ID_BALA);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }
        
        [Route("Existe/{ID_BALA}")]
        [HttpGet()]
        public virtual bool Existe(String ID_BALA)
        {
            try
            {
                Bala_ContFacade faBala_Cont = new Bala_ContFacade();
                return faBala_Cont.Existe(ID_BALA);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CBala_Cont> Listar()
        {
            try
            {
                Bala_ContFacade faBala_Cont = new Bala_ContFacade();
                return faBala_Cont.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }
        [Route("Buscar/{ID_BALA}/{SNContr}")]
        [HttpGet()]
        public virtual IList<CBala_ContDet> Buscar(String ID_Bala, String SNContr)
        {
            try 
            {
                if (ID_Bala == "*") { ID_Bala = ""; }
                if (SNContr == "*") { SNContr = ""; }
                Bala_ContFacade faBala_Cont = new Bala_ContFacade();
                return faBala_Cont.Buscar(ID_Bala,SNContr);
            }
            catch (System.Exception e) {
                Logger.Fatal(e);
                throw;
            }
        }
    }
}
