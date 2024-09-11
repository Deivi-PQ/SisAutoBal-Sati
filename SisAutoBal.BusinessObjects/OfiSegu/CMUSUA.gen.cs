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

namespace SisAutoBal.BusinessObjects.OfiSegu
{
    
    
    // Propiedades AutoImplementadas
    [DataContract()]
    [Serializable()]
    public partial class CMUSUA
    {
        
        [DataMember()]
        public Int32 ID_USUA {get;set;}
        
        [DataMember()]
        public String NO_USUA {get;set;}
        
        [DataMember()]
        public String ST_USUA_WIND {get;set;}
        
        [DataMember()]
        public String NO_CLAV {get;set;}
        
        [DataMember()]
        public String FE_MODI_CLAV {get;set;}
        
        [DataMember()]
        public String DE_DIRE_MAIL {get;set;}
        
        [DataMember()]
        public String ST_ACTI {get;set;}
        
        [DataMember()]
        public String ST_BLOQ_IFAL {get;set;}
        
        [DataMember()]
        public String ST_CACL_INGR {get;set;}
        
        [DataMember()]
        public String ST_EXPI_CLAV {get;set;}
        
        [DataMember()]
        public String ST_EXPI_USUA {get;set;}
        
        [DataMember()]
        public String FE_EXPI_USUA {get;set;}
        
        [DataMember()]
        public String TI_CONE {get;set;}
        
        [DataMember()]
        public Int32 ID_EMPR {get;set;}
        
        [DataMember()]
        public Int32 ID_UNID {get;set;}
        
        [DataMember()]
        public Int32 NU_VECE_CONE {get;set;}
        
        [DataMember()]
        public DateTime FE_ULTI_CONE {get;set;}
        
        [DataMember()]
        public String ST_HORA {get;set;}
        
        [DataMember()]
        public String HO_INIC {get;set;}
        
        [DataMember()]
        public String HO_FINA {get;set;}
        
        [DataMember()]
        public String ST_DOMI {get;set;}
        
        [DataMember()]
        public String ST_LUNE {get;set;}
        
        [DataMember()]
        public String ST_MART {get;set;}
        
        [DataMember()]
        public String ST_MIER {get;set;}
        
        [DataMember()]
        public String ST_JUEV {get;set;}
        
        [DataMember()]
        public String ST_VIER {get;set;}
        
        [DataMember()]
        public String ST_SABA {get;set;}
        
        [DataMember()]
        public Int32 ID_USUA_CREA {get;set;}
        
        [DataMember()]
        public DateTime FE_USUA_CREA {get;set;}
        
        [DataMember()]
        public Int32 ID_USUA_MODI {get;set;}
        
        [DataMember()]
        public DateTime FE_USUA_MODI {get;set;}
        
        [DataMember()]
        public String DE_USUA {get;set;}
        
        #region Constructores
        // Constructores
        public CMUSUA()
        {
        }
        
        public CMUSUA(
                    Int32 ID_USUA_, 
                    String NO_USUA_, 
                    String ST_USUA_WIND_, 
                    String NO_CLAV_, 
                    String FE_MODI_CLAV_, 
                    String DE_DIRE_MAIL_, 
                    String ST_ACTI_, 
                    String ST_BLOQ_IFAL_, 
                    String ST_CACL_INGR_, 
                    String ST_EXPI_CLAV_, 
                    String ST_EXPI_USUA_, 
                    String FE_EXPI_USUA_, 
                    String TI_CONE_, 
                    Int32 ID_EMPR_, 
                    Int32 ID_UNID_, 
                    Int32 NU_VECE_CONE_, 
                    DateTime FE_ULTI_CONE_, 
                    String ST_HORA_, 
                    String HO_INIC_, 
                    String HO_FINA_, 
                    String ST_DOMI_, 
                    String ST_LUNE_, 
                    String ST_MART_, 
                    String ST_MIER_, 
                    String ST_JUEV_, 
                    String ST_VIER_, 
                    String ST_SABA_, 
                    Int32 ID_USUA_CREA_, 
                    DateTime FE_USUA_CREA_, 
                    Int32 ID_USUA_MODI_, 
                    DateTime FE_USUA_MODI_, 
                    String DE_USUA_)
        {
            ID_USUA = ID_USUA_;
            NO_USUA = NO_USUA_;
            ST_USUA_WIND = ST_USUA_WIND_;
            NO_CLAV = NO_CLAV_;
            FE_MODI_CLAV = FE_MODI_CLAV_;
            DE_DIRE_MAIL = DE_DIRE_MAIL_;
            ST_ACTI = ST_ACTI_;
            ST_BLOQ_IFAL = ST_BLOQ_IFAL_;
            ST_CACL_INGR = ST_CACL_INGR_;
            ST_EXPI_CLAV = ST_EXPI_CLAV_;
            ST_EXPI_USUA = ST_EXPI_USUA_;
            FE_EXPI_USUA = FE_EXPI_USUA_;
            TI_CONE = TI_CONE_;
            ID_EMPR = ID_EMPR_;
            ID_UNID = ID_UNID_;
            NU_VECE_CONE = NU_VECE_CONE_;
            FE_ULTI_CONE = FE_ULTI_CONE_;
            ST_HORA = ST_HORA_;
            HO_INIC = HO_INIC_;
            HO_FINA = HO_FINA_;
            ST_DOMI = ST_DOMI_;
            ST_LUNE = ST_LUNE_;
            ST_MART = ST_MART_;
            ST_MIER = ST_MIER_;
            ST_JUEV = ST_JUEV_;
            ST_VIER = ST_VIER_;
            ST_SABA = ST_SABA_;
            ID_USUA_CREA = ID_USUA_CREA_;
            FE_USUA_CREA = FE_USUA_CREA_;
            ID_USUA_MODI = ID_USUA_MODI_;
            FE_USUA_MODI = FE_USUA_MODI_;
            DE_USUA = DE_USUA_;
        }
        #endregion
    }
}
