using LibreriaBSNet.InfoApp;
using SisAutoBal.BusinessObjects.AutoBal;
using SisAutoBal.DataObjects.AutoBal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisAutoBal.Facade.AutoBal
{
    [DataObject(true)]
    public partial class AuditoriaBalanzaFacade
    {
        private AuditoriaBalanzaDao auditoriaBalanza;

        private string Error = "";

        private bool hayError = false;

        #region Constructores
        public AuditoriaBalanzaFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
                default:
                    auditoriaBalanza = new AuditoriaBalanzaDao();
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
        public virtual bool Grabar(CAuditoriaBalanza oAuditoriaBalanza)
        {
            Error = "";
            hayError = false;
            if (oAuditoriaBalanza.IDAudBal < 0)
            {
                Error = "IDBloqueBal no puede ser vacío.";
                hayError = true;
                return false;
            }
            else
                return auditoriaBalanza.Grabar(oAuditoriaBalanza);
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CAuditoriaBalanza oAuditoriaBalanza, out string error)
        {
            bool rpta = Grabar(oAuditoriaBalanza);
            error = Error;
            return rpta;
        }
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CAuditoriaBalanza> Listar()
        {
            return auditoriaBalanza.Listar();
        }
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CAuditoriaBalanza> ListarPorFecha(String Estado, String FechaInicio, String FechaFinal)
        {
            return auditoriaBalanza.ListarPorFecha( Estado, FechaInicio, FechaFinal);
        }
        public virtual IList<CAuditoriaBalazaGenaral> Listar_X_Fecha(String FechaInicio, String FechaFinal, String Balanza, String Estado)
        {
            return auditoriaBalanza.Listar_X_Fecha(FechaInicio, FechaFinal, Balanza, Estado);
        }
        #endregion
    }
}
