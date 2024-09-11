//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: martes, 7 de marzo de 2023
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
    public partial class TTIPO_BALAFacade
    {
        
        private TTIPO_BALADao tTIPO_BALA;
 
        private string Error = "";
        
        private bool hayError= false;
        
        #region Constructores
        public TTIPO_BALAFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: tTIPO_BALA = new TTIPO_BALADao();
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
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CTTIPO_BALA Recuperar(String ID_BALA)
        {
            return tTIPO_BALA.Recuperar(ID_BALA);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(String ID_BALA)
        {
            return tTIPO_BALA.Existe(ID_BALA);
        }
        
        public virtual bool Existe(String ID_BALA, out CTTIPO_BALA oTTIPO_BALA)
        {
            return tTIPO_BALA.Existe(ID_BALA, out oTTIPO_BALA);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CTTIPO_BALA> Listar()
        {
            return tTIPO_BALA.Listar();
        }
        #endregion
    }
}
