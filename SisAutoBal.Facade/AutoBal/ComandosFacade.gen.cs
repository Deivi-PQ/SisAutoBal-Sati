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

namespace SisAutoBal.Facade.AutoBal
{
    
    
    [DataObject(true)]
    public partial class ComandosFacade
    {
        
        private ComandosDao comandos;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public ComandosFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: comandos = new ComandosDao();
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
        public virtual bool Grabar(CComandos oComandos)
        {
            Error = "";
            hayError = false;
            //---Validando campos no nulos
            if (oComandos.Id<=0)
            {
            	Error = "id no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else
            	return comandos.Grabar(oComandos);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CComandos oComandos, out string error)
        {
            bool rpta = Grabar(oComandos);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(String sn, String activo)
        {
            return comandos.Eliminar(sn,activo);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CComandos Recuperar(String SN)
        {
            return comandos.Recuperar(SN);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(Int32 id)
        {
            return comandos.Existe(id);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CComandos> Listar()
        {
            return comandos.Lista();
        }
        #endregion
    }
}
