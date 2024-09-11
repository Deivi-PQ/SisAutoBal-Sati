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
    public partial class CDREQU_ATEN
    {
        
        [DataMember()]
        public Int64 ID_REQU_ATEN {get;set;}
        
        [DataMember()]
        public Int16 NU_SECU {get;set;}
        
        [DataMember()]
        public String ID_REGI_PLAC {get;set;}
        
        [DataMember()]
        public String ID_PLAC_CLIE {get;set;}
        
        [DataMember()]
        public String ID_REGI_COND {get;set;}
        
        [DataMember()]
        public String NU_DOCU_IDEN {get;set;}
        
        [DataMember()]
        public String NO_COND {get;set;}
        
        [DataMember()]
        public String AP_COND {get;set;}
        
        [DataMember()]
        public String NU_BREV {get;set;}
        
        [DataMember()]
        public String ID_TRAN {get;set;}
        
        [DataMember()]
        public String ID_TRAN_CLIE {get;set;}
        
        [DataMember()]
        public String NO_TRAN {get;set;}
        
        [DataMember()]
        public String TI_NACI_EXTR {get;set;}
        
        [DataMember()]
        public String DE_NUME_TRAC {get;set;}
        
        [DataMember()]
        public String ID_TIPO_EMBA {get;set;}
        
        [DataMember()]
        public Int16 CA_BULT {get;set;}
        
        [DataMember()]
        public Decimal CA_TONE {get;set;}
        
        [DataMember()]
        public String CO_UNME {get;set;}
        
        [DataMember()]
        public String FE_SOLI {get;set;}
        
        [DataMember()]
        public String HO_SOLI {get;set;}
        
        [DataMember()]
        public Int32 ID_USUA_CREA {get;set;}
        
        [DataMember()]
        public DateTime FE_USUA_CREA {get;set;}
        
        [DataMember()]
        public Int32 ID_USUA_MODI {get;set;}
        
        [DataMember()]
        public DateTime FE_USUA_MODI {get;set;}
        
        [DataMember()]
        public DateTime FE_SOAT {get;set;}
        
        [DataMember()]
        public DateTime FE_REVI_TECN_TRAC {get;set;}
        
        [DataMember()]
        public DateTime FE_REVI_TECN_RANF {get;set;}
        
        [DataMember()]
        public Boolean IN_TARJ_PROP_TRAC {get;set;}
        
        [DataMember()]
        public Boolean IN_TARJ_PROP_RANF {get;set;}
        
        [DataMember()]
        public Boolean IN_SCTR {get;set;}
        
        [DataMember()]
        public DateTime FE_SCTR {get;set;}
        
        [DataMember()]
        public Boolean IN_CURS_PORT {get;set;}
        
        [DataMember()]
        public DateTime FE_CURS_PORT {get;set;}
        
        [DataMember()]
        public String DE_CONT {get;set;}
        
        [DataMember()]
        public String DE_PREC_1 {get;set;}
        
        [DataMember()]
        public String DE_PREC_2 {get;set;}
        
        [DataMember()]
        public String DE_PREC_3 {get;set;}
        
        [DataMember()]
        public String DE_NUME_RANF {get;set;}
        
        [DataMember()]
        public Boolean IN_REVI_TECN {get;set;}
        
        [DataMember()]
        public String NU_DOCU_TRANS {get;set;}
        
        [DataMember()]
        public Char IN_TIPO_OPER {get;set;}
        
        [DataMember()]
        public Decimal CA_CAPA_MAX {get;set;}
        
        [DataMember()]
        public String NU_PEDI {get;set;}
        
        [DataMember()]
        public Decimal PE_VACI_ORIG {get;set;}
        
        [DataMember()]
        public Decimal PE_LLEN_ORIG {get;set;}
        
        [DataMember()]
        public Decimal PE_NETO_ORIG {get;set;}
        
        [DataMember()]
        public String NO_COND_DOS {get;set;}
        
        [DataMember()]
        public String NU_DNI_COND_DOS {get;set;}
        
        [DataMember()]
        public String NU_BREV_COND_DOS {get;set;}
        
        [DataMember()]
        public String NU_GUIA_REMI {get;set;}
        
        [DataMember()]
        public String UB_ASIG {get;set;}
        
        [DataMember()]
        public String DE_OBSE {get;set;}
        
        [DataMember()]
        public String NU_RUC_CLIE {get;set;}
        
        [DataMember()]
        public String ID_UBIG {get;set;}
        
        [DataMember()]
        public String DE_DIRE {get;set;}
        
        [DataMember()]
        public String TIPO_MRB {get;set;}
        
        #region Constructores
        // Constructores
        public CDREQU_ATEN()
        {
        }
        
        public CDREQU_ATEN(
                    Int64 ID_REQU_ATEN_, 
                    Int16 NU_SECU_, 
                    String ID_REGI_PLAC_, 
                    String ID_PLAC_CLIE_, 
                    String ID_REGI_COND_, 
                    String NU_DOCU_IDEN_, 
                    String NO_COND_, 
                    String AP_COND_, 
                    String NU_BREV_, 
                    String ID_TRAN_, 
                    String ID_TRAN_CLIE_, 
                    String NO_TRAN_, 
                    String TI_NACI_EXTR_, 
                    String DE_NUME_TRAC_, 
                    String ID_TIPO_EMBA_, 
                    Int16 CA_BULT_, 
                    Decimal CA_TONE_, 
                    String CO_UNME_, 
                    String FE_SOLI_, 
                    String HO_SOLI_, 
                    Int32 ID_USUA_CREA_, 
                    DateTime FE_USUA_CREA_, 
                    Int32 ID_USUA_MODI_, 
                    DateTime FE_USUA_MODI_, 
                    DateTime FE_SOAT_, 
                    DateTime FE_REVI_TECN_TRAC_, 
                    DateTime FE_REVI_TECN_RANF_, 
                    Boolean IN_TARJ_PROP_TRAC_, 
                    Boolean IN_TARJ_PROP_RANF_, 
                    Boolean IN_SCTR_, 
                    DateTime FE_SCTR_, 
                    Boolean IN_CURS_PORT_, 
                    DateTime FE_CURS_PORT_, 
                    String DE_CONT_, 
                    String DE_PREC_1_, 
                    String DE_PREC_2_, 
                    String DE_PREC_3_, 
                    String DE_NUME_RANF_, 
                    Boolean IN_REVI_TECN_, 
                    String NU_DOCU_TRANS_, 
                    Char IN_TIPO_OPER_, 
                    Decimal CA_CAPA_MAX_, 
                    String NU_PEDI_, 
                    Decimal PE_VACI_ORIG_, 
                    Decimal PE_LLEN_ORIG_, 
                    Decimal PE_NETO_ORIG_, 
                    String NO_COND_DOS_, 
                    String NU_DNI_COND_DOS_, 
                    String NU_BREV_COND_DOS_, 
                    String NU_GUIA_REMI_, 
                    String UB_ASIG_, 
                    String DE_OBSE_, 
                    String NU_RUC_CLIE_, 
                    String ID_UBIG_, 
                    String DE_DIRE_, 
                    String TIPO_MRB_)
        {
            ID_REQU_ATEN = ID_REQU_ATEN_;
            NU_SECU = NU_SECU_;
            ID_REGI_PLAC = ID_REGI_PLAC_;
            ID_PLAC_CLIE = ID_PLAC_CLIE_;
            ID_REGI_COND = ID_REGI_COND_;
            NU_DOCU_IDEN = NU_DOCU_IDEN_;
            NO_COND = NO_COND_;
            AP_COND = AP_COND_;
            NU_BREV = NU_BREV_;
            ID_TRAN = ID_TRAN_;
            ID_TRAN_CLIE = ID_TRAN_CLIE_;
            NO_TRAN = NO_TRAN_;
            TI_NACI_EXTR = TI_NACI_EXTR_;
            DE_NUME_TRAC = DE_NUME_TRAC_;
            ID_TIPO_EMBA = ID_TIPO_EMBA_;
            CA_BULT = CA_BULT_;
            CA_TONE = CA_TONE_;
            CO_UNME = CO_UNME_;
            FE_SOLI = FE_SOLI_;
            HO_SOLI = HO_SOLI_;
            ID_USUA_CREA = ID_USUA_CREA_;
            FE_USUA_CREA = FE_USUA_CREA_;
            ID_USUA_MODI = ID_USUA_MODI_;
            FE_USUA_MODI = FE_USUA_MODI_;
            FE_SOAT = FE_SOAT_;
            FE_REVI_TECN_TRAC = FE_REVI_TECN_TRAC_;
            FE_REVI_TECN_RANF = FE_REVI_TECN_RANF_;
            IN_TARJ_PROP_TRAC = IN_TARJ_PROP_TRAC_;
            IN_TARJ_PROP_RANF = IN_TARJ_PROP_RANF_;
            IN_SCTR = IN_SCTR_;
            FE_SCTR = FE_SCTR_;
            IN_CURS_PORT = IN_CURS_PORT_;
            FE_CURS_PORT = FE_CURS_PORT_;
            DE_CONT = DE_CONT_;
            DE_PREC_1 = DE_PREC_1_;
            DE_PREC_2 = DE_PREC_2_;
            DE_PREC_3 = DE_PREC_3_;
            DE_NUME_RANF = DE_NUME_RANF_;
            IN_REVI_TECN = IN_REVI_TECN_;
            NU_DOCU_TRANS = NU_DOCU_TRANS_;
            IN_TIPO_OPER = IN_TIPO_OPER_;
            CA_CAPA_MAX = CA_CAPA_MAX_;
            NU_PEDI = NU_PEDI_;
            PE_VACI_ORIG = PE_VACI_ORIG_;
            PE_LLEN_ORIG = PE_LLEN_ORIG_;
            PE_NETO_ORIG = PE_NETO_ORIG_;
            NO_COND_DOS = NO_COND_DOS_;
            NU_DNI_COND_DOS = NU_DNI_COND_DOS_;
            NU_BREV_COND_DOS = NU_BREV_COND_DOS_;
            NU_GUIA_REMI = NU_GUIA_REMI_;
            UB_ASIG = UB_ASIG_;
            DE_OBSE = DE_OBSE_;
            NU_RUC_CLIE = NU_RUC_CLIE_;
            ID_UBIG = ID_UBIG_;
            DE_DIRE = DE_DIRE_;
            TIPO_MRB = TIPO_MRB_;
        }
        #endregion
    }
}
