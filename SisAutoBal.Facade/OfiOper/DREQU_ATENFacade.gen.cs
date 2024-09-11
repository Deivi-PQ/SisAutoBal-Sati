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
    public partial class DREQU_ATENFacade
    {
        
        private DREQU_ATENDao dREQU_ATEN;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public DREQU_ATENFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: dREQU_ATEN = new DREQU_ATENDao();
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
        public virtual bool Grabar(CDREQU_ATEN oDREQU_ATEN)
        {
            Error = "";
            hayError = false;
            //---Validando campos no nulos
            if (oDREQU_ATEN.ID_REQU_ATEN<=0)
            {
            	Error = "ID_REQU_ATEN no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oDREQU_ATEN.NU_SECU<=0)
            {
            	Error = "NU_SECU no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oDREQU_ATEN.TI_NACI_EXTR.Trim() == "")
            {
            	Error = "TI_NACI_EXTR no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oDREQU_ATEN.FE_SOLI<=0)
            {
            	Error = "FE_SOLI no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oDREQU_ATEN.HO_SOLI.Trim() == "")
            {
            	Error = "HO_SOLI no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oDREQU_ATEN.ID_USUA_CREA<=0)
            {
            	Error = "ID_USUA_CREA no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oDREQU_ATEN.ID_USUA_MODI<=0)
            {
            	Error = "ID_USUA_MODI no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else
            	return dREQU_ATEN.Grabar(oDREQU_ATEN);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CDREQU_ATEN oDREQU_ATEN, out string error)
        {
            bool rpta = Grabar(oDREQU_ATEN);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar()
        {
            return dREQU_ATEN.Eliminar();
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CDREQU_ATEN Recuperar()
        {
            return dREQU_ATEN.Recuperar();
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe()
        {
            return dREQU_ATEN.Existe();
        }
        
        public virtual bool Existe(out CDREQU_ATEN oDREQU_ATEN)
        {
            return dREQU_ATEN.Existe(, out oDREQU_ATEN);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CDREQU_ATEN> Listar()
        {
            return dREQU_ATEN.Listar();
        }
        #endregion
    }
}
