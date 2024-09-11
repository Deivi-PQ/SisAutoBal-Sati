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
    public partial class CTARJFacade
    {
        
        private CTARJDao cTARJ;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public CTARJFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: cTARJ = new CTARJDao();
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
        public virtual bool Grabar(CCTARJ oCTARJ)
        {
            Error = "";
            hayError = false;
            //---Validando campos no nulos
            if (oCTARJ.ID_MOVI_TARJ<=0)
            {
            	Error = "ID_MOVI_TARJ no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oCTARJ.ID_UNID<=0)
            {
            	Error = "ID_UNID no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oCTARJ.ID_EMPR<=0)
            {
            	Error = "ID_EMPR no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oCTARJ.TI_DOCU_TARJ.Trim() == "")
            {
            	Error = "TI_DOCU_TARJ no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oCTARJ.NU_DOCU_TARJ.Trim() == "")
            {
            	Error = "NU_DOCU_TARJ no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oCTARJ.ID_MOVI.Trim() == "")
            {
            	Error = "ID_MOVI no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oCTARJ.ID_DOCU_ORIG<=0)
            {
            	Error = "ID_DOCU_ORIG no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oCTARJ.NU_SECU_ITEM<=0)
            {
            	Error = "NU_SECU_ITEM no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oCTARJ.ID_ALMA.Trim() == "")
            {
            	Error = "ID_ALMA no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oCTARJ.ID_REGI.Trim() == "")
            {
            	Error = "ID_REGI no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oCTARJ.ID_TIPO_JORN.Trim() == "")
            {
            	Error = "ID_TIPO_JORN no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oCTARJ.ST_FINA_REDE.Trim() == "")
            {
            	Error = "ST_FINA_REDE no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oCTARJ.ST_REDE_ORIG.Trim() == "")
            {
            	Error = "ST_REDE_ORIG no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oCTARJ.ST_SALD.Trim() == "")
            {
            	Error = "ST_SALD no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oCTARJ.ST_CIER_OPER.Trim() == "")
            {
            	Error = "ST_CIER_OPER no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oCTARJ.ID_USUA_CREA<=0)
            {
            	Error = "ID_USUA_CREA no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oCTARJ.ID_USUA_MODI<=0)
            {
            	Error = "ID_USUA_MODI no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else
            	return cTARJ.Grabar(oCTARJ);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CCTARJ oCTARJ, out string error)
        {
            bool rpta = Grabar(oCTARJ);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar()
        {
            return cTARJ.Eliminar();
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CCTARJ Recuperar()
        {
            return cTARJ.Recuperar();
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe()
        {
            return cTARJ.Existe();
        }
        
        public virtual bool Existe(out CCTARJ oCTARJ)
        {
            return cTARJ.Existe(, out oCTARJ);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CCTARJ> Listar()
        {
            return cTARJ.Listar();
        }
        #endregion
    }
}
