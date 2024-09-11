//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: lunes, 6 de marzo de 2023
// </Auto Generado>
//------------------------------------------------------------------------------
using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using LibreriaBSNet.InfoApp;
using SisAutoBal.BusinessObjects.OfiOper;
using SisAutoBal.DataObjects.OfiOper;

namespace SisAutoBal.Facade.OfiOper
{
    
    
    [DataObject(true)]
    public partial class MCLIEFacade
    {
        
        private MCLIEDao mCLIE;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public MCLIEFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: mCLIE = new MCLIEDao();
            break;
            }
        }
        #endregion
        
        #region Metodos de Control de Errores
        public virtual string getError()
        {
            return Error;
        }
        
        public virtual bool HayError()
        {
            return hayError;
        }
        #endregion
        
        #region Metodos Basicos
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CMCLIE oMCLIE)
        {
            Error = "";
            hayError = false;
            //---Validando campos no nulos
            //---Validando referencias foraneas
            else
            	return mCLIE.Grabar(oMCLIE);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CMCLIE oMCLIE, out string error)
        {
            bool rpta = Grabar(oMCLIE);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar()
        {
            return mCLIE.Eliminar();
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CMCLIE Recuperar()
        {
            return mCLIE.Recuperar();
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe()
        {
            return mCLIE.Existe();
        }
        
        public virtual bool Existe(out CMCLIE oMCLIE)
        {
            return mCLIE.Existe(, out oMCLIE);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CMCLIE> Listar()
        {
            return mCLIE.Listar();
        }
        #endregion
    }
}
