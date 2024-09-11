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
    public partial class CTTIPO_BALA
    {
        
        [DataMember()]
        public String ID_BALA {get;set;}
        
        [DataMember()]
        public String ID_CLAS_BALA {get;set;}
        
        [DataMember()]
        public Int32 ID_EMPR {get;set;}
        
        [DataMember()]
        public String DE_TIPO {get;set;}
        
        [DataMember()]
        public String IP_MAQU {get;set;}
        
        [DataMember()]
        public String IP_CA01 {get;set;}
        
        [DataMember()]
        public String CO_USUA_CA01 {get;set;}
        
        [DataMember()]
        public String CO_CONT_CA01 {get;set;}
        
        [DataMember()]
        public String IP_CA02 {get;set;}
        
        [DataMember()]
        public String CO_USUA_CA02 {get;set;}
        
        [DataMember()]
        public String CO_CONT_CA02 {get;set;}
        
        [DataMember()]
        public Int32 ID_USUA_CREA {get;set;}
        
        [DataMember()]
        public DateTime FE_USUA_CREA {get;set;}
        
        [DataMember()]
        public Int32 ID_USUA_MODI {get;set;}
        
        [DataMember()]
        public DateTime FE_USUA_MODI {get;set;}
        
        [DataMember()]
        public String ST_TRAF_CONT {get;set;}
        
        #region Constructores
        // Constructores
        public CTTIPO_BALA()
        {
        }
        
        public CTTIPO_BALA(
                    String ID_BALA_, 
                    String ID_CLAS_BALA_, 
                    Int32 ID_EMPR_, 
                    String DE_TIPO_, 
                    String IP_MAQU_, 
                    String IP_CA01_, 
                    String CO_USUA_CA01_, 
                    String CO_CONT_CA01_, 
                    String IP_CA02_, 
                    String CO_USUA_CA02_, 
                    String CO_CONT_CA02_, 
                    Int32 ID_USUA_CREA_, 
                    DateTime FE_USUA_CREA_, 
                    Int32 ID_USUA_MODI_, 
                    DateTime FE_USUA_MODI_, 
                    String ST_TRAF_CONT_)
        {
            ID_BALA = ID_BALA_;
            ID_CLAS_BALA = ID_CLAS_BALA_;
            ID_EMPR = ID_EMPR_;
            DE_TIPO = DE_TIPO_;
            IP_MAQU = IP_MAQU_;
            IP_CA01 = IP_CA01_;
            CO_USUA_CA01 = CO_USUA_CA01_;
            CO_CONT_CA01 = CO_CONT_CA01_;
            IP_CA02 = IP_CA02_;
            CO_USUA_CA02 = CO_USUA_CA02_;
            CO_CONT_CA02 = CO_CONT_CA02_;
            ID_USUA_CREA = ID_USUA_CREA_;
            FE_USUA_CREA = FE_USUA_CREA_;
            ID_USUA_MODI = ID_USUA_MODI_;
            FE_USUA_MODI = FE_USUA_MODI_;
            ST_TRAF_CONT = ST_TRAF_CONT_;
        }
        #endregion
    }
}
