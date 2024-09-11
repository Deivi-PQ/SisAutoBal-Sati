//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: lunes, 6 de mayo de 2024
// </Auto Generado>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace SisAutoBal.BusinessObjects.AutoBal
{
    
    
    // Propiedades AutoImplementadas
    [DataContract()]
    [Serializable()]
    public partial class CBala_Cont
    {
        
        [DataMember()]
        public String ID_BALA {get;set;}
        
        [DataMember()]
        public String SNContr {get;set;}
        
        #region Constructores
        // Constructores
        public CBala_Cont()
        {
        }
        
        public CBala_Cont(String ID_BALA_, String SNContr_)
        {
            ID_BALA = ID_BALA_;
            SNContr = SNContr_;
        }
        #endregion
    }
}
