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
    
    
    [Route("api/TTIPO_BALA")]
    [ApiController()]
    public partial class TTIPO_BALAController : ControllerBase
    {
        [Route("Recuperar/{ID_BALA}")]
        [HttpGet()]
        public virtual CTTIPO_BALA Recuperar(String ID_BALA)
        {
            try
            {
                TTIPO_BALAFacade faTTIPO_BALA = new TTIPO_BALAFacade();
                return faTTIPO_BALA.Recuperar(ID_BALA);
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
                TTIPO_BALAFacade faTTIPO_BALA = new TTIPO_BALAFacade();
                return faTTIPO_BALA.Existe(ID_BALA);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw ;
            }
        } 
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CTTIPO_BALA> Listar()
        {
            try
            {
                TTIPO_BALAFacade faTTIPO_BALA = new TTIPO_BALAFacade();
                return faTTIPO_BALA.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }
    }
}
