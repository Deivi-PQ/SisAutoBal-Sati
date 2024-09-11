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
    public partial class CPROG_ATENFacade
    {
        
        private CPROG_ATENDao cPROG_ATEN;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public CPROG_ATENFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: cPROG_ATEN = new CPROG_ATENDao();
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
        public virtual bool Grabar(CCPROG_ATEN oCPROG_ATEN)
        {
            Error = "";
            hayError = false;
            //---Validando campos no nulos
            if (oCPROG_ATEN.ID_PROG_ATEN<=0)
            {
            	Error = "ID_PROG_ATEN no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oCPROG_ATEN.ST_SOLI_SERV.Trim() == "")
            {
            	Error = "ST_SOLI_SERV no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oCPROG_ATEN.TI_SITU.Trim() == "")
            {
            	Error = "TI_SITU no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oCPROG_ATEN.FE_PROG_INIC<=0)
            {
            	Error = "FE_PROG_INIC no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oCPROG_ATEN.HO_PROG_INIC.Trim() == "")
            {
            	Error = "HO_PROG_INIC no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oCPROG_ATEN.FE_PROG_FINA<=0)
            {
            	Error = "FE_PROG_FINA no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oCPROG_ATEN.HO_PROG_FINA.Trim() == "")
            {
            	Error = "HO_PROG_FINA no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oCPROG_ATEN.ST_REAL.Trim() == "")
            {
            	Error = "ST_REAL no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oCPROG_ATEN.ST_HABI_DETA.Trim() == "")
            {
            	Error = "ST_HABI_DETA no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oCPROG_ATEN.ID_USUA_CREA<=0)
            {
            	Error = "ID_USUA_CREA no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oCPROG_ATEN.ID_USUA_MODI<=0)
            {
            	Error = "ID_USUA_MODI no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else
            	return cPROG_ATEN.Grabar(oCPROG_ATEN);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CCPROG_ATEN oCPROG_ATEN, out string error)
        {
            bool rpta = Grabar(oCPROG_ATEN);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar()
        {
            return cPROG_ATEN.Eliminar();
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CCPROG_ATEN Recuperar()
        {
            return cPROG_ATEN.Recuperar();
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe()
        {
            return cPROG_ATEN.Existe();
        }
        
        public virtual bool Existe(out CCPROG_ATEN oCPROG_ATEN)
        {
            return cPROG_ATEN.Existe(, out oCPROG_ATEN);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CCPROG_ATEN> Listar()
        {
            return cPROG_ATEN.Listar();
        }
        #endregion
    }
}
