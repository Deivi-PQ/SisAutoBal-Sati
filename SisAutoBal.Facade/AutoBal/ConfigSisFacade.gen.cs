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
    public partial class ConfigSisFacade
    {
        
        private ConfigSisDao ConfigSis;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public ConfigSisFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: ConfigSis = new ConfigSisDao();
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
        public virtual bool Grabar(CConfigSis oconfigSis)
        {
            Error = "";
            hayError = false;
            //---Validando campos no nulos
            if (oconfigSis.Nombre_Variable.Trim() == "")
            {
            	Error = "Nombre_Variable no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else
            	return ConfigSis.Grabar(oconfigSis);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CConfigSis oconfigSis, out string error)
        {
            bool rpta = Grabar(oconfigSis);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(String Nombre_Variable)
        {
            return ConfigSis.Eliminar(Nombre_Variable);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CConfigSis Recuperar(String Nombre_Variable)
        {
            return ConfigSis.Recuperar(Nombre_Variable);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(String Nombre_Variable)
        {
            return ConfigSis.Existe(Nombre_Variable);
        }
        
        public virtual bool Existe(String Nombre_Variable, out CConfigSis oconfigSis)
        {
            return ConfigSis.Existe(Nombre_Variable, out oconfigSis);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CConfigSis> Listar()
        {
            return ConfigSis.Listar();
        }
        #endregion
    }
}
