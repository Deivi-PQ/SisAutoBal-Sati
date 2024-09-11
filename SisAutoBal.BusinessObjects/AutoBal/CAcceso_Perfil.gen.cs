using System.Runtime.Serialization;
using System;
using System.Collections.Generic;

namespace SisAutoBal.BusinessObjects.AutoBal
{
    
    
    // Propiedades AutoImplementadas
    public partial class CAcceso_Perfil
    {
        
        [DataMember()]
        public String Cod_Acceso {get;set;}
        
        [DataMember()]
        public Int32 IDPerfil {get;set;}
        
        #region Constructores
        // Constructores
        public CAcceso_Perfil()
        {
        }
        
        public CAcceso_Perfil(String Cod_Acceso_, Int32 IDPerfil_)
        {
            Cod_Acceso = Cod_Acceso_;
            IDPerfil = IDPerfil_;
        }
        #endregion
    }
}
