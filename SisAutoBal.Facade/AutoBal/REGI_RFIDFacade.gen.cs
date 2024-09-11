//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: martes, 10 de octubre de 2023
// </Auto Generado>
//------------------------------------------------------------------------------
using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using LibreriaBSNet.InfoApp;
using SisAutoBal.BusinessObjects.AutoBal;
using SisAutoBal.DataObjects.AutoBal;
using SisAutoBal.Facade.OfiOper;

namespace SisAutoBal.Facade.AutoBal
{
    
    
    [DataObject(true)]
    public partial class REGI_RFIDFacade
    {
        
        private REGI_RFIDDao rEGI_RFID;
        
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public REGI_RFIDFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: rEGI_RFID = new REGI_RFIDDao();
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
        public virtual bool Grabar(CREGI_RFID oREGI_RFID)
        {
            Error = "";
            hayError = false;

            if (oREGI_RFID.Cod_RFID.Trim() == "")
            {
                Error = "Cod. RFID no puede ser vacío.";
                hayError = true;
                return false;
            }
            else if ((oREGI_RFID.ID_REGI_PLAC.Trim() != "" && (!rEGI_RFID.Existe_Placa(oREGI_RFID.ID_REGI_PLAC))))
            {
                Error = string.Concat("El valor ", oREGI_RFID.ID_REGI_PLAC, " en ID_REGI_PLAC no existe. (TREGI_PLAC, ID_REGI_PLAC)");
                hayError = true;
                return false;
            }
            else
                return rEGI_RFID.Grabar(oREGI_RFID);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CREGI_RFID oREGI_RFID, out string error)
        {
            bool rpta = Grabar(oREGI_RFID);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(String Cod_RFID)
        {
            return rEGI_RFID.Eliminar(Cod_RFID);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CREGI_RFID Recuperar(String Cod_RFID)
        {
            return rEGI_RFID.Recuperar(Cod_RFID);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(String Cod_RFID)
        {
            return rEGI_RFID.Existe(Cod_RFID);
        }
        
        public virtual bool Existe(String Cod_RFID, out CREGI_RFID oREGI_RFID)
        {
            return rEGI_RFID.Existe(Cod_RFID, out oREGI_RFID);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CREGI_RFID> Listar(string ID_REGI_PLAC, string Cod_RFID, String? VigenciaIni, String? VigenciaFin)
        {
            return rEGI_RFID.Listar(ID_REGI_PLAC, Cod_RFID, VigenciaIni, VigenciaFin);
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CREGI_RFID PlacaRFID(String ID_REGI_PLAC)
        {
            return rEGI_RFID.PlacaRFID(ID_REGI_PLAC);
        }
        #endregion

        public bool Existe_Placa(String ID_REGI_PLAC)
        {
            return rEGI_RFID.Existe_Placa(ID_REGI_PLAC);
        }
    }
}
