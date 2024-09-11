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
    public partial class CCREQU_ATEN
    {
        
        [DataMember()]
        public Int64 ID_REQU_ATEN {get;set;}
        
        [DataMember()]
        public Int32 ID_UNID {get;set;}
        
        [DataMember()]
        public Int32 ID_EMPR {get;set;}
        
        [DataMember()]
        public String NU_REQU_ATEN {get;set;}
        
        [DataMember()]
        public String CO_CLIE {get;set;}
        
        [DataMember()]
        public String FE_REQU {get;set;}
        
        [DataMember()]
        public String TI_SERV {get;set;}
        
        [DataMember()]
        public String TI_SITU {get;set;}
        
        [DataMember()]
        public String DE_OTRO_SERV {get;set;}
        
        [DataMember()]
        public String DE_CARG {get;set;}
        
        [DataMember()]
        public String DE_MERC {get;set;}
        
        [DataMember()]
        public Int16 CA_CAMI {get;set;}
        
        [DataMember()]
        public String ST_SOLI_SERV {get;set;}
        
        [DataMember()]
        public String FE_SOLI {get;set;}
        
        [DataMember()]
        public String HO_SOLI {get;set;}
        
        [DataMember()]
        public String ID_CIUD {get;set;}
        
        [DataMember()]
        public Int16 CA_BULT {get;set;}
        
        [DataMember()]
        public Decimal CA_TONE {get;set;}
        
        [DataMember()]
        public String CO_UNME {get;set;}
        
        [DataMember()]
        public String DE_OBSE {get;set;}
        
        [DataMember()]
        public Int32 ID_USUA_CREA {get;set;}
        
        [DataMember()]
        public DateTime FE_USUA_CREA {get;set;}
        
        [DataMember()]
        public Int32 ID_USUA_MODI {get;set;}
        
        [DataMember()]
        public DateTime FE_USUA_MODI {get;set;}
        
        [DataMember()]
        public String DE_MOTI_PCON {get;set;}
        
        [DataMember()]
        public String NU_SALI {get;set;}
        
        [DataMember()]
        public String ID_REGI {get;set;}
        
        [DataMember()]
        public String ID_CLAS_CARG {get;set;}
        
        [DataMember()]
        public String ID_TIPO_CARG {get;set;}
        
        [DataMember()]
        public String ID_TIPO_EMBA {get;set;}
        
        [DataMember()]
        public Char ST_POLI {get;set;}
        
        [DataMember()]
        public Char ST_OPER {get;set;}
        
        [DataMember()]
        public Int64 ID_DOCU_ORIG {get;set;}
        
        [DataMember()]
        public Int16 NU_SECU_ITEM {get;set;}
        
        [DataMember()]
        public String DE_DEST {get;set;}
        
        #region Constructores
        // Constructores
        public CCREQU_ATEN()
        {
        }
        
        public CCREQU_ATEN(
                    Int64 ID_REQU_ATEN_, 
                    Int32 ID_UNID_, 
                    Int32 ID_EMPR_, 
                    String NU_REQU_ATEN_, 
                    String CO_CLIE_, 
                    String FE_REQU_, 
                    String TI_SERV_, 
                    String TI_SITU_, 
                    String DE_OTRO_SERV_, 
                    String DE_CARG_, 
                    String DE_MERC_, 
                    Int16 CA_CAMI_, 
                    String ST_SOLI_SERV_, 
                    String FE_SOLI_, 
                    String HO_SOLI_, 
                    String ID_CIUD_, 
                    Int16 CA_BULT_, 
                    Decimal CA_TONE_, 
                    String CO_UNME_, 
                    String DE_OBSE_, 
                    Int32 ID_USUA_CREA_, 
                    DateTime FE_USUA_CREA_, 
                    Int32 ID_USUA_MODI_, 
                    DateTime FE_USUA_MODI_, 
                    String DE_MOTI_PCON_, 
                    String NU_SALI_, 
                    String ID_REGI_, 
                    String ID_CLAS_CARG_, 
                    String ID_TIPO_CARG_, 
                    String ID_TIPO_EMBA_, 
                    Char ST_POLI_, 
                    Char ST_OPER_, 
                    Int64 ID_DOCU_ORIG_, 
                    Int16 NU_SECU_ITEM_, 
                    String DE_DEST_)
        {
            ID_REQU_ATEN = ID_REQU_ATEN_;
            ID_UNID = ID_UNID_;
            ID_EMPR = ID_EMPR_;
            NU_REQU_ATEN = NU_REQU_ATEN_;
            CO_CLIE = CO_CLIE_;
            FE_REQU = FE_REQU_;
            TI_SERV = TI_SERV_;
            TI_SITU = TI_SITU_;
            DE_OTRO_SERV = DE_OTRO_SERV_;
            DE_CARG = DE_CARG_;
            DE_MERC = DE_MERC_;
            CA_CAMI = CA_CAMI_;
            ST_SOLI_SERV = ST_SOLI_SERV_;
            FE_SOLI = FE_SOLI_;
            HO_SOLI = HO_SOLI_;
            ID_CIUD = ID_CIUD_;
            CA_BULT = CA_BULT_;
            CA_TONE = CA_TONE_;
            CO_UNME = CO_UNME_;
            DE_OBSE = DE_OBSE_;
            ID_USUA_CREA = ID_USUA_CREA_;
            FE_USUA_CREA = FE_USUA_CREA_;
            ID_USUA_MODI = ID_USUA_MODI_;
            FE_USUA_MODI = FE_USUA_MODI_;
            DE_MOTI_PCON = DE_MOTI_PCON_;
            NU_SALI = NU_SALI_;
            ID_REGI = ID_REGI_;
            ID_CLAS_CARG = ID_CLAS_CARG_;
            ID_TIPO_CARG = ID_TIPO_CARG_;
            ID_TIPO_EMBA = ID_TIPO_EMBA_;
            ST_POLI = ST_POLI_;
            ST_OPER = ST_OPER_;
            ID_DOCU_ORIG = ID_DOCU_ORIG_;
            NU_SECU_ITEM = NU_SECU_ITEM_;
            DE_DEST = DE_DEST_;
        }
        #endregion
    }
}
