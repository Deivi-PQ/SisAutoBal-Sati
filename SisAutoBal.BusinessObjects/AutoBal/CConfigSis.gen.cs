//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: miércoles, 30 de agosto de 2023
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
    public partial class CConfigSis
    {
        
        [DataMember()]
        public String Nombre_Variable {get;set;}
        
        [DataMember()]
        public String Valor_Variable {get;set;}
        
        #region Constructores
        // Constructores
        public CConfigSis()
        {
        }
        
        public CConfigSis(String Nombre_Variable_, String Valor_Variable_)
        {
            Nombre_Variable = Nombre_Variable_;
            Valor_Variable = Valor_Variable_;
        }
        #endregion
    }
}
