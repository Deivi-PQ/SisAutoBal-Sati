//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: lunes, 6 de marzo de 2023
// </Auto Generado>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace SisAutoBal.BusinessObjects.OfiOper
{
    
    
    // Propiedades AutoImplementadas
    [DataContract()]
    [Serializable()]
    public partial class CMCLIE
    {
        
        [DataMember()]
        public Double CO_ROLE {get;set;}
        
        [DataMember()]
        public Double NU_RUCS {get;set;}
        
        [DataMember()]
        public Double CO_CLIE {get;set;}
        
        [DataMember()]
        public String DE_CLIE {get;set;}
        
        [DataMember()]
        public Double TI_DOID_SUNA {get;set;}
        
        [DataMember()]
        public String TI_SITU {get;set;}
        
        [DataMember()]
        public String CLIE_EMAIL {get;set;}
        
        [DataMember()]
        public String F8 {get;set;}
        
        [DataMember()]
        public String F9 {get;set;}
        
        [DataMember()]
        public String F10 {get;set;}
        
        [DataMember()]
        public String F11 {get;set;}
        
        [DataMember()]
        public String F12 {get;set;}
        
        [DataMember()]
        public String F13 {get;set;}
        
        [DataMember()]
        public String F14 {get;set;}
        
        #region Constructores
        // Constructores
        public CMCLIE()
        {
        }
        
        public CMCLIE(Double CO_ROLE_, Double NU_RUCS_, Double CO_CLIE_, String DE_CLIE_, Double TI_DOID_SUNA_, String TI_SITU_, String CLIE_EMAIL_, String F8_, String F9_, String F10_, String F11_, String F12_, String F13_, String F14_)
        {
            CO_ROLE = CO_ROLE_;
            NU_RUCS = NU_RUCS_;
            CO_CLIE = CO_CLIE_;
            DE_CLIE = DE_CLIE_;
            TI_DOID_SUNA = TI_DOID_SUNA_;
            TI_SITU = TI_SITU_;
            CLIE_EMAIL = CLIE_EMAIL_;
            F8 = F8_;
            F9 = F9_;
            F10 = F10_;
            F11 = F11_;
            F12 = F12_;
            F13 = F13_;
            F14 = F14_;
        }
        #endregion
    }
}
