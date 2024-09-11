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
    public partial class CCTARJ
    {
        
        [DataMember()]
        public Int64 ID_MOVI_TARJ {get;set;}
        
        [DataMember()]
        public Int64 ID_MOVI_TORI {get;set;}
        
        [DataMember()]
        public Int32 ID_UNID {get;set;}
        
        [DataMember()]
        public Int32 ID_EMPR {get;set;}
        
        [DataMember()]
        public String TI_DOCU_TARJ {get;set;}
        
        [DataMember()]
        public String NU_DOCU_TARJ {get;set;}
        
        [DataMember()]
        public Int64 ID_MOVI_TRFR {get;set;}
        
        [DataMember()]
        public String ID_MOVI {get;set;}
        
        [DataMember()]
        public Int64 ID_MOVI_BALA {get;set;}
        
        [DataMember()]
        public String ST_INGR_SALI {get;set;}
        
        [DataMember()]
        public String NU_SALI {get;set;}
        
        [DataMember()]
        public String ID_REGI_PLAC {get;set;}
        
        [DataMember()]
        public String NU_VAGO {get;set;}
        
        [DataMember()]
        public String NU_RECA {get;set;}
        
        [DataMember()]
        public Int64 ID_DOCU_ORIG {get;set;}
        
        [DataMember()]
        public Int16 NU_SECU_ITEM {get;set;}
        
        [DataMember()]
        public String ID_ALMA {get;set;}
        
        [DataMember()]
        public String ID_UBIC_ALMA {get;set;}
        
        [DataMember()]
        public String ID_REGI {get;set;}
        
        [DataMember()]
        public String ID_CLAS_CARG {get;set;}
        
        [DataMember()]
        public String ID_TIPO_CARG {get;set;}
        
        [DataMember()]
        public String ID_TIPO_EMBA {get;set;}
        
        [DataMember()]
        public String ID_TIPO_JORN {get;set;}
        
        [DataMember()]
        public String CO_BODE {get;set;}
        
        [DataMember()]
        public String FE_TARJ {get;set;}
        
        [DataMember()]
        public Int64 ID_PROG_ATEN {get;set;}
        
        [DataMember()]
        public Int64 ID_REQU_ATEN {get;set;}
        
        [DataMember()]
        public Decimal CA_TOTA {get;set;}
        
        [DataMember()]
        public Decimal CA_TOTA_SIGN {get;set;}
        
        [DataMember()]
        public Decimal CA_PESO {get;set;}
        
        [DataMember()]
        public Decimal CA_PESO_SIGN {get;set;}
        
        [DataMember()]
        public String CO_RESP_TARJ {get;set;}
        
        [DataMember()]
        public String CO_RESP_OPER {get;set;}
        
        [DataMember()]
        public String ST_FINA_REDE {get;set;}
        
        [DataMember()]
        public String ST_REDE_ORIG {get;set;}
        
        [DataMember()]
        public String FE_OPER_INIC {get;set;}
        
        [DataMember()]
        public String HO_OPER_INIC {get;set;}
        
        [DataMember()]
        public String FE_OPER_FINA {get;set;}
        
        [DataMember()]
        public String HO_OPER_FINA {get;set;}
        
        [DataMember()]
        public String DE_NUME_CHAS {get;set;}
        
        [DataMember()]
        public String DE_NUME_ACTA {get;set;}
        
        [DataMember()]
        public String ST_SALD {get;set;}
        
        [DataMember()]
        public String ST_CIER_OPER {get;set;}
        
        [DataMember()]
        public Int32 ID_USUA_CREA {get;set;}
        
        [DataMember()]
        public DateTime FE_USUA_CREA {get;set;}
        
        [DataMember()]
        public Int32 ID_USUA_MODI {get;set;}
        
        [DataMember()]
        public DateTime FE_USUA_MODI {get;set;}
        
        [DataMember()]
        public String ST_TRAF {get;set;}
        
        [DataMember()]
        public String NU_DOCU_ANTE {get;set;}
        
        [DataMember()]
        public String NU_TARJ_ANTE {get;set;}
        
        [DataMember()]
        public String CO_CUAD {get;set;}
        
        [DataMember()]
        public String NU_TRAF_MIGRA {get;set;}
        
        [DataMember()]
        public Decimal CA_MODI {get;set;}
        
        [DataMember()]
        public String ID_OBSE {get;set;}
        
        [DataMember()]
        public String ID_MAQU {get;set;}
        
        [DataMember()]
        public Int64 ID_SERV {get;set;}
        
        [DataMember()]
        public String TI_MANI {get;set;}
        
        [DataMember()]
        public Int32 CO_RECU_TERC {get;set;}
        
        [DataMember()]
        public String TI_TRAC {get;set;}
        
        [DataMember()]
        public Int32 CO_TRAC_TERC {get;set;}
        
        [DataMember()]
        public DateTime FE_INI_OBSE_TARJ {get;set;}
        
        [DataMember()]
        public DateTime FE_FIN_OBSE_TARJ {get;set;}
        
        [DataMember()]
        public String ID_OBSE_TARJ {get;set;}
        
        #region Constructores
        // Constructores
        public CCTARJ()
        {
        }
        
        public CCTARJ(
                    Int64 ID_MOVI_TARJ_, 
                    Int64 ID_MOVI_TORI_, 
                    Int32 ID_UNID_, 
                    Int32 ID_EMPR_, 
                    String TI_DOCU_TARJ_, 
                    String NU_DOCU_TARJ_, 
                    Int64 ID_MOVI_TRFR_, 
                    String ID_MOVI_, 
                    Int64 ID_MOVI_BALA_, 
                    String ST_INGR_SALI_, 
                    String NU_SALI_, 
                    String ID_REGI_PLAC_, 
                    String NU_VAGO_, 
                    String NU_RECA_, 
                    Int64 ID_DOCU_ORIG_, 
                    Int16 NU_SECU_ITEM_, 
                    String ID_ALMA_, 
                    String ID_UBIC_ALMA_, 
                    String ID_REGI_, 
                    String ID_CLAS_CARG_, 
                    String ID_TIPO_CARG_, 
                    String ID_TIPO_EMBA_, 
                    String ID_TIPO_JORN_, 
                    String CO_BODE_, 
                    String FE_TARJ_, 
                    Int64 ID_PROG_ATEN_, 
                    Int64 ID_REQU_ATEN_, 
                    Decimal CA_TOTA_, 
                    Decimal CA_TOTA_SIGN_, 
                    Decimal CA_PESO_, 
                    Decimal CA_PESO_SIGN_, 
                    String CO_RESP_TARJ_, 
                    String CO_RESP_OPER_, 
                    String ST_FINA_REDE_, 
                    String ST_REDE_ORIG_, 
                    String FE_OPER_INIC_, 
                    String HO_OPER_INIC_, 
                    String FE_OPER_FINA_, 
                    String HO_OPER_FINA_, 
                    String DE_NUME_CHAS_, 
                    String DE_NUME_ACTA_, 
                    String ST_SALD_, 
                    String ST_CIER_OPER_, 
                    Int32 ID_USUA_CREA_, 
                    DateTime FE_USUA_CREA_, 
                    Int32 ID_USUA_MODI_, 
                    DateTime FE_USUA_MODI_, 
                    String ST_TRAF_, 
                    String NU_DOCU_ANTE_, 
                    String NU_TARJ_ANTE_, 
                    String CO_CUAD_, 
                    String NU_TRAF_MIGRA_, 
                    Decimal CA_MODI_, 
                    String ID_OBSE_, 
                    String ID_MAQU_, 
                    Int64 ID_SERV_, 
                    String TI_MANI_, 
                    Int32 CO_RECU_TERC_, 
                    String TI_TRAC_, 
                    Int32 CO_TRAC_TERC_, 
                    DateTime FE_INI_OBSE_TARJ_, 
                    DateTime FE_FIN_OBSE_TARJ_, 
                    String ID_OBSE_TARJ_)
        {
            ID_MOVI_TARJ = ID_MOVI_TARJ_;
            ID_MOVI_TORI = ID_MOVI_TORI_;
            ID_UNID = ID_UNID_;
            ID_EMPR = ID_EMPR_;
            TI_DOCU_TARJ = TI_DOCU_TARJ_;
            NU_DOCU_TARJ = NU_DOCU_TARJ_;
            ID_MOVI_TRFR = ID_MOVI_TRFR_;
            ID_MOVI = ID_MOVI_;
            ID_MOVI_BALA = ID_MOVI_BALA_;
            ST_INGR_SALI = ST_INGR_SALI_;
            NU_SALI = NU_SALI_;
            ID_REGI_PLAC = ID_REGI_PLAC_;
            NU_VAGO = NU_VAGO_;
            NU_RECA = NU_RECA_;
            ID_DOCU_ORIG = ID_DOCU_ORIG_;
            NU_SECU_ITEM = NU_SECU_ITEM_;
            ID_ALMA = ID_ALMA_;
            ID_UBIC_ALMA = ID_UBIC_ALMA_;
            ID_REGI = ID_REGI_;
            ID_CLAS_CARG = ID_CLAS_CARG_;
            ID_TIPO_CARG = ID_TIPO_CARG_;
            ID_TIPO_EMBA = ID_TIPO_EMBA_;
            ID_TIPO_JORN = ID_TIPO_JORN_;
            CO_BODE = CO_BODE_;
            FE_TARJ = FE_TARJ_;
            ID_PROG_ATEN = ID_PROG_ATEN_;
            ID_REQU_ATEN = ID_REQU_ATEN_;
            CA_TOTA = CA_TOTA_;
            CA_TOTA_SIGN = CA_TOTA_SIGN_;
            CA_PESO = CA_PESO_;
            CA_PESO_SIGN = CA_PESO_SIGN_;
            CO_RESP_TARJ = CO_RESP_TARJ_;
            CO_RESP_OPER = CO_RESP_OPER_;
            ST_FINA_REDE = ST_FINA_REDE_;
            ST_REDE_ORIG = ST_REDE_ORIG_;
            FE_OPER_INIC = FE_OPER_INIC_;
            HO_OPER_INIC = HO_OPER_INIC_;
            FE_OPER_FINA = FE_OPER_FINA_;
            HO_OPER_FINA = HO_OPER_FINA_;
            DE_NUME_CHAS = DE_NUME_CHAS_;
            DE_NUME_ACTA = DE_NUME_ACTA_;
            ST_SALD = ST_SALD_;
            ST_CIER_OPER = ST_CIER_OPER_;
            ID_USUA_CREA = ID_USUA_CREA_;
            FE_USUA_CREA = FE_USUA_CREA_;
            ID_USUA_MODI = ID_USUA_MODI_;
            FE_USUA_MODI = FE_USUA_MODI_;
            ST_TRAF = ST_TRAF_;
            NU_DOCU_ANTE = NU_DOCU_ANTE_;
            NU_TARJ_ANTE = NU_TARJ_ANTE_;
            CO_CUAD = CO_CUAD_;
            NU_TRAF_MIGRA = NU_TRAF_MIGRA_;
            CA_MODI = CA_MODI_;
            ID_OBSE = ID_OBSE_;
            ID_MAQU = ID_MAQU_;
            ID_SERV = ID_SERV_;
            TI_MANI = TI_MANI_;
            CO_RECU_TERC = CO_RECU_TERC_;
            TI_TRAC = TI_TRAC_;
            CO_TRAC_TERC = CO_TRAC_TERC_;
            FE_INI_OBSE_TARJ = FE_INI_OBSE_TARJ_;
            FE_FIN_OBSE_TARJ = FE_FIN_OBSE_TARJ_;
            ID_OBSE_TARJ = ID_OBSE_TARJ_;
        }
        #endregion
    }
}
