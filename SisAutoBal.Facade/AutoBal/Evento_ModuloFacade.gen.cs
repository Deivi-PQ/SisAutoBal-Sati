//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: martes, 27 de agosto de 2024
// </Auto Generado>
//------------------------------------------------------------------------------
using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using LibreriaBSNet.InfoApp;
using SisAutoBal.BusinessObjects.AutoBal;
using SisAutoBal.DataObjects.AutoBal;

namespace SisAutoBal.Facade.AutoBal
{
    
    
    [DataObject(true)]
    public partial class Evento_ModuloFacade
    {
        
        private Evento_ModuloDao tEvento_Modulo;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public Evento_ModuloFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: tEvento_Modulo = new Evento_ModuloDao();
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
        public virtual bool Grabar(CEvento_Modulo oTEvento_Modulo)
        {
            Error = "";
            hayError = false;
            //---Validando campos no nulos
            if (oTEvento_Modulo.IDEvento<=0)
            {
            	Error = "IDEvento no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else
            	return tEvento_Modulo.Grabar(oTEvento_Modulo);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CEvento_Modulo oTEvento_Modulo, out string error)
        {
            bool rpta = Grabar(oTEvento_Modulo);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(Int64 IDEvento)
        {
            return tEvento_Modulo.Eliminar(IDEvento);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CEvento_Modulo Recuperar(Int64 IDEvento)
        {
            return tEvento_Modulo.Recuperar(IDEvento);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(Int64 IDEvento)
        {
            return tEvento_Modulo.Existe(IDEvento);
        }
        
        public virtual bool Existe(Int64 IDEvento, out CEvento_Modulo oTEvento_Modulo)
        {
            return tEvento_Modulo.Existe(IDEvento, out oTEvento_Modulo);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CEvento_Modulo> Listar()
        {
            return tEvento_Modulo.Listar();
        }
        #endregion
    }
}
