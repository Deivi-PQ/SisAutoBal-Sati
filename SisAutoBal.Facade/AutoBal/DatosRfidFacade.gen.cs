//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: jueves, 16 de mayo de 2024
// </Auto Generado>
//------------------------------------------------------------------------------
using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using LibreriaBSNet.InfoApp;
using SisAutoBal.BusinessObjects.AutoBal;
using SisAutoBal.DataObjects.AutoBal;

namespace SisAutoBal.Facade
{
    
    
    [DataObject(true)]
    public partial class DatosRfidFacade
    {
        
        private DatosRfidDao datosRfid;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public DatosRfidFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: datosRfid = new DatosRfidDao();
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
        public virtual bool Grabar(CDatosRFID odatosRFID)
        {
            Error = "";
            hayError = false;
            //---Validando campos no nulos
            if (odatosRFID.SN == "")
            {
            	Error = "SN no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else
            	return datosRfid.Grabar(odatosRFID);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CDatosRFID odato, out string error)
        {
            bool rpta = Grabar(odato);
            error = Error;
            return rpta;
        }
        public virtual IList<CDatosRFID> Listar()
        {
            return datosRfid.Listar();
        }
        /*
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(Int32 id)
        {
            return datosRfid.Eliminar(id);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CDato Recuperar(Int32 id)
        {
            return datosRfid.Recuperar(id);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(Int32 id)
        {
            return datosRfid.Existe(id);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CDato> Listar()
        {
            return datosRfid.Listar();
        }*/
        #endregion
    }
}
