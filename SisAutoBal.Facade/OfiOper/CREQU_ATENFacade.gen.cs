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
    public partial class CREQU_ATENFacade
    {
        
        private CREQU_ATENDao cREQU_ATEN;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public CREQU_ATENFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: cREQU_ATEN = new CREQU_ATENDao();
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
        public virtual bool Grabar(CCREQU_ATEN oCREQU_ATEN)
        {
            Error = "";
            hayError = false;
            //---Validando campos no nulos
            if (oCREQU_ATEN.ID_REQU_ATEN<=0)
            {
            	Error = "ID_REQU_ATEN no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oCREQU_ATEN.FE_REQU<=0)
            {
            	Error = "FE_REQU no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oCREQU_ATEN.TI_SITU.Trim() == "")
            {
            	Error = "TI_SITU no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oCREQU_ATEN.CA_CAMI<=0)
            {
            	Error = "CA_CAMI no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oCREQU_ATEN.ST_SOLI_SERV.Trim() == "")
            {
            	Error = "ST_SOLI_SERV no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oCREQU_ATEN.ID_USUA_CREA<=0)
            {
            	Error = "ID_USUA_CREA no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oCREQU_ATEN.ID_USUA_MODI<=0)
            {
            	Error = "ID_USUA_MODI no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else
            	return cREQU_ATEN.Grabar(oCREQU_ATEN);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CCREQU_ATEN oCREQU_ATEN, out string error)
        {
            bool rpta = Grabar(oCREQU_ATEN);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar()
        {
            return cREQU_ATEN.Eliminar();
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CCREQU_ATEN Recuperar()
        {
            return cREQU_ATEN.Recuperar();
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe()
        {
            return cREQU_ATEN.Existe();
        }
        
        public virtual bool Existe(out CCREQU_ATEN oCREQU_ATEN)
        {
            return cREQU_ATEN.Existe(, out oCREQU_ATEN);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CCREQU_ATEN> Listar()
        {
            return cREQU_ATEN.Listar();
        }
        #endregion
    }
}
