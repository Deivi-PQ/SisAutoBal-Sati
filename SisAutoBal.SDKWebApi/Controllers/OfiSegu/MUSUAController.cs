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
using SisAutoBal.BusinessObjects.OfiSegu;
using SisAutoBal.Facade.OfiSegu;

namespace SisAutoBalWebApi.Controllers.OfiSegu
{
    
    
    [Route("api/MUSUA")]
    [ApiController()]
    public partial class MUSUAController : ControllerBase
    {    
        [Route("Recuperar/{ID_USUA}")]
        [HttpGet()]
        public virtual CMUSUA Recuperar(Int32 ID_USUA)
        {
            try
            {
                MUSUAFacade faMUSUA = new MUSUAFacade();
                return faMUSUA.Recuperar(ID_USUA);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }
        
        [Route("Existe/{ID_USUA}")]
        [HttpGet()]
        public virtual bool Existe(Int32 ID_USUA)
        {
            try
            {
                MUSUAFacade faMUSUA = new MUSUAFacade();
                return faMUSUA.Existe(ID_USUA);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CMUSUA> Listar()
        {
            try
            {
                MUSUAFacade faMUSUA = new MUSUAFacade();
                return faMUSUA.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }

        [Route("RecuperarUsuario/{NO_USUA}")]
        [HttpGet()]
        public virtual CMUSUA RecuperarUsuario(String NO_USUA)
        {
            try
            {
                MUSUAFacade faMUSUA = new MUSUAFacade();
                return faMUSUA.RecuperarUsuario(NO_USUA);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }

        [Route("ExisteUsuario/{NO_USUA}")]
        [HttpGet()]
        public virtual bool ExisteUsuario(String NO_USUA)
        {
            try
            {
                MUSUAFacade faMUSUA = new MUSUAFacade();
                return faMUSUA.ExisteUsuario(NO_USUA);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }
    }
}
