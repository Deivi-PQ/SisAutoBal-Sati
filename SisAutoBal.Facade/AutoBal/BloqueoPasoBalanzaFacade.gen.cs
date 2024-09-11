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
using SisAutoBal.BusinessObjects.AutoBal;
using SisAutoBal.DataObjects.AutoBal;

namespace SisAutoBal.Facade.AutoBal
{
    
    
    [DataObject(true)]
    public partial class BloqueoPasoBalanzaFacade
    {
        
        private BloqueoPasoBalanzaDao bloqueoPasoBalanza;

        private string Error = "";
        
        private bool hayError = false;
        
        #region Constructores
        public BloqueoPasoBalanzaFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: bloqueoPasoBalanza = new BloqueoPasoBalanzaDao();
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
        public virtual bool Grabar(CBloqueoPasoBalanza oBloqueoPasoBalanza)
        {
            Error = "";
            hayError = false;
            if (oBloqueoPasoBalanza.IDBloqueBal.ToString() == "")
            {
            	Error = "IDBloqueBal no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else
            	return bloqueoPasoBalanza.Grabar(oBloqueoPasoBalanza);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CBloqueoPasoBalanza oBloqueoPasoBalanza, out string error)
        {
            bool rpta = Grabar(oBloqueoPasoBalanza);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(String IDBloqueBal)
        {
            return bloqueoPasoBalanza.Eliminar(IDBloqueBal);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CBloqueoPasoBalanza Recuperar(String IDBloqueBal)
        {
            return bloqueoPasoBalanza.Recuperar(IDBloqueBal);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(String IDBloqueBal)
        {
            return bloqueoPasoBalanza.Existe(IDBloqueBal);
        }
        
        public virtual bool Existe(String IDBloqueBal, out CBloqueoPasoBalanza oBloqueoPasoBalanza)
        {
            return bloqueoPasoBalanza.Existe(IDBloqueBal, out oBloqueoPasoBalanza);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CBloqueoPasoBalanza> Listar(DateTime Fecha, char Estado)
        {
            return bloqueoPasoBalanza.Listar(Fecha, Estado);
        }
        /*[DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CBloqueoPasoBalanza> Listar_X_Estado(String Estado)
        {
            return bloqueoPasoBalanza.Listar_X_Estado(Estado);
        }
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CBloqueoPasoBalanza> Listar_X_EstadoFecha(String Estado, String FechaInicio, String FechaFinal)
        {
            return bloqueoPasoBalanza.Listar_X_EstadoFecha(Estado, FechaInicio, FechaFinal);
        }*/
        public Boolean Actualizar(int ID_REQU_ATEN, string Nro_Placa, string EstadoBloqueo, int ID_USUA)
        {
            return bloqueoPasoBalanza.Actualizar(ID_REQU_ATEN, Nro_Placa, EstadoBloqueo, ID_USUA);
        }
        #endregion
    }
}
