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
    public partial class CCPROG_ATEN
    {
        
        [DataMember()]
        public Int64 ID_PROG_ATEN {get;set;}
        
        [DataMember()]
        public Int64 ID_PROG_ORIG {get;set;}
        
        [DataMember()]
        public Int64 ID_REQU_ATEN {get;set;}
        
        [DataMember()]
        public Int32 ID_UNID {get;set;}
        
        [DataMember()]
        public Int32 ID_EMPR {get;set;}
        
        [DataMember()]
        public String NU_PROG_ATEN {get;set;}
        
        [DataMember()]
        public String TI_MOVI_INDI {get;set;}
        
        [DataMember()]
        public String CO_CLIE {get;set;}
        
        [DataMember()]
        public String DE_OTRO_SERV {get;set;}
        
        [DataMember()]
        public String TI_SERV {get;set;}
        
        [DataMember()]
        public Int16 CA_CAMI {get;set;}
        
        [DataMember()]
        public String ST_SOLI_SERV {get;set;}
        
        [DataMember()]
        public String TI_SITU {get;set;}
        
        [DataMember()]
        public String FE_SOLI {get;set;}
        
        [DataMember()]
        public String HO_SOLI {get;set;}
        
        [DataMember()]
        public String FE_PROG_INIC {get;set;}
        
        [DataMember()]
        public String HO_PROG_INIC {get;set;}
        
        [DataMember()]
        public String FE_PROG_FINA {get;set;}
        
        [DataMember()]
        public String HO_PROG_FINA {get;set;}
        
        [DataMember()]
        public String ST_REAL {get;set;}
        
        [DataMember()]
        public String FE_REAL_INIC {get;set;}
        
        [DataMember()]
        public String HO_REAL_INIC {get;set;}
        
        [DataMember()]
        public String FE_REAL_FINA {get;set;}
        
        [DataMember()]
        public String HO_REAL_FINA {get;set;}
        
        [DataMember()]
        public String ID_CIUD {get;set;}
        
        [DataMember()]
        public String NU_RECA {get;set;}
        
        [DataMember()]
        public String DE_MOTI_REPR {get;set;}
        
        [DataMember()]
        public String ST_CIER_PROG {get;set;}
        
        [DataMember()]
        public String ID_TIPO_PLAN {get;set;}
        
        [DataMember()]
        public String CO_PERS_PLAN {get;set;}
        
        [DataMember()]
        public String ST_HABI_DETA {get;set;}
        
        [DataMember()]
        public Int32 ID_USUA_CREA {get;set;}
        
        [DataMember()]
        public DateTime FE_USUA_CREA {get;set;}
        
        [DataMember()]
        public Int32 ID_USUA_MODI {get;set;}
        
        [DataMember()]
        public DateTime FE_USUA_MODI {get;set;}
        
        [DataMember()]
        public String DE_DEST {get;set;}
        
        [DataMember()]
        public String CO_BOOK {get;set;}
        
        [DataMember()]
        public String ID_BALA {get;set;}
        
        #region Constructores
        // Constructores
        public CCPROG_ATEN()
        {
        }
        
        public CCPROG_ATEN(
                    Int64 ID_PROG_ATEN_, 
                    Int64 ID_PROG_ORIG_, 
                    Int64 ID_REQU_ATEN_, 
                    Int32 ID_UNID_, 
                    Int32 ID_EMPR_, 
                    String NU_PROG_ATEN_, 
                    String TI_MOVI_INDI_, 
                    String CO_CLIE_, 
                    String DE_OTRO_SERV_, 
                    String TI_SERV_, 
                    Int16 CA_CAMI_, 
                    String ST_SOLI_SERV_, 
                    String TI_SITU_, 
                    String FE_SOLI_, 
                    String HO_SOLI_, 
                    String FE_PROG_INIC_, 
                    String HO_PROG_INIC_, 
                    String FE_PROG_FINA_, 
                    String HO_PROG_FINA_, 
                    String ST_REAL_, 
                    String FE_REAL_INIC_, 
                    String HO_REAL_INIC_, 
                    String FE_REAL_FINA_, 
                    String HO_REAL_FINA_, 
                    String ID_CIUD_, 
                    String NU_RECA_, 
                    String DE_MOTI_REPR_, 
                    String ST_CIER_PROG_, 
                    String ID_TIPO_PLAN_, 
                    String CO_PERS_PLAN_, 
                    String ST_HABI_DETA_, 
                    Int32 ID_USUA_CREA_, 
                    DateTime FE_USUA_CREA_, 
                    Int32 ID_USUA_MODI_, 
                    DateTime FE_USUA_MODI_, 
                    String DE_DEST_, 
                    String CO_BOOK_, 
                    String ID_BALA_)
        {
            ID_PROG_ATEN = ID_PROG_ATEN_;
            ID_PROG_ORIG = ID_PROG_ORIG_;
            ID_REQU_ATEN = ID_REQU_ATEN_;
            ID_UNID = ID_UNID_;
            ID_EMPR = ID_EMPR_;
            NU_PROG_ATEN = NU_PROG_ATEN_;
            TI_MOVI_INDI = TI_MOVI_INDI_;
            CO_CLIE = CO_CLIE_;
            DE_OTRO_SERV = DE_OTRO_SERV_;
            TI_SERV = TI_SERV_;
            CA_CAMI = CA_CAMI_;
            ST_SOLI_SERV = ST_SOLI_SERV_;
            TI_SITU = TI_SITU_;
            FE_SOLI = FE_SOLI_;
            HO_SOLI = HO_SOLI_;
            FE_PROG_INIC = FE_PROG_INIC_;
            HO_PROG_INIC = HO_PROG_INIC_;
            FE_PROG_FINA = FE_PROG_FINA_;
            HO_PROG_FINA = HO_PROG_FINA_;
            ST_REAL = ST_REAL_;
            FE_REAL_INIC = FE_REAL_INIC_;
            HO_REAL_INIC = HO_REAL_INIC_;
            FE_REAL_FINA = FE_REAL_FINA_;
            HO_REAL_FINA = HO_REAL_FINA_;
            ID_CIUD = ID_CIUD_;
            NU_RECA = NU_RECA_;
            DE_MOTI_REPR = DE_MOTI_REPR_;
            ST_CIER_PROG = ST_CIER_PROG_;
            ID_TIPO_PLAN = ID_TIPO_PLAN_;
            CO_PERS_PLAN = CO_PERS_PLAN_;
            ST_HABI_DETA = ST_HABI_DETA_;
            ID_USUA_CREA = ID_USUA_CREA_;
            FE_USUA_CREA = FE_USUA_CREA_;
            ID_USUA_MODI = ID_USUA_MODI_;
            FE_USUA_MODI = FE_USUA_MODI_;
            DE_DEST = DE_DEST_;
            CO_BOOK = CO_BOOK_;
            ID_BALA = ID_BALA_;
        }
        #endregion
    }
}
