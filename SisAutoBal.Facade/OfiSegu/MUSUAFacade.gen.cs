using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using LibreriaBSNet.InfoApp;
using SisAutoBal.BusinessObjects.OfiSegu;
using SisAutoBal.DataObjects.OfiSegu;

namespace SisAutoBal.Facade.OfiSegu
{
    
    
    [DataObject(true)]
    public partial class MUSUAFacade
    {
        
        private MUSUADao mUSUA;

        private string Error = "";
        
        private bool hayError = false;
        
        #region Constructores
        public MUSUAFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
                default: mUSUA = new MUSUADao();
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
        public virtual CMUSUA Recuperar(Int32 ID_USUA)
        {
            return mUSUA.Recuperar(ID_USUA);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(Int32 ID_USUA)
        {
            return mUSUA.Existe(ID_USUA);
        }
        
        public virtual bool Existe(Int32 ID_USUA, out CMUSUA oMUSUA)
        {
            return mUSUA.Existe(ID_USUA, out oMUSUA);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CMUSUA> Listar()
        {
            return mUSUA.Listar();
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CMUSUA RecuperarUsuario(String NO_USUA)
        {
            return mUSUA.RecuperarUsuario(NO_USUA);
        }

        public virtual bool ExisteUsuario(String NO_USUA)
        {
            return mUSUA.ExisteUsuario(NO_USUA);
        }
        #endregion
    }
}
