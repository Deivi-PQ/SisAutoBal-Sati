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
    public partial class CCBALA
    {
        
        [DataMember()]
        public Int64 ID_MOVI_BALA {get;set;}
        
        [DataMember()]
        public Int64 ID_MOVI_DUES {get;set;}
        
        [DataMember()]
        public Int64 ID_MOVI_OPER {get;set;}
        
        [DataMember()]
        public String NU_MOVI {get;set;}
        
        [DataMember()]
        public String TI_MOVI_INDI {get;set;}
        
        [DataMember()]
        public Int64 ID_TICK_ANTE {get;set;}
        
        [DataMember()]
        public Int32 ID_UNID {get;set;}
        
        [DataMember()]
        public Int32 ID_EMPR {get;set;}
        
        [DataMember()]
        public String ID_BALA {get;set;}
        
        [DataMember()]
        public String CO_CLIE {get;set;}
        
        [DataMember()]
        public DateTime FE_ENTR {get;set;}
        
        [DataMember()]
        public String HO_ENTR {get;set;}
        
        [DataMember()]
        public DateTime? FE_SALI {get;set;}
        
        [DataMember()]
        public String HO_SALI {get;set;}
        
        [DataMember()]
        public String ID_TRAN {get;set;}
        
        [DataMember()]
        public String ID_REGI_PLAC {get;set;}
        
        [DataMember()]
        public String ID_REGI_COND {get;set;}
        
        [DataMember()]
        public String DE_NUME_TRAC {get;set;}
        
        [DataMember()]
        public String DE_NUME_TAUX {get;set;}
        
        [DataMember()]
        public String NU_RECA {get;set;}
        
        [DataMember()]
        public String NU_SALI {get;set;}
        
        [DataMember()]
        public Int64 ID_DOCU_ORIG {get;set;}
        
        [DataMember()]
        public Int16 NU_SECU_ITEM {get;set;}
        
        [DataMember()]
        public String DE_OBSE {get;set;}
        
        [DataMember()]
        public Decimal CA_PES1 {get;set;}
        
        [DataMember()]
        public Decimal CA_PES2 {get;set;}
        
        [DataMember()]
        public Decimal CA_PESO_SECO {get;set;}
        
        [DataMember()]
        public String DE_MICS {get;set;}
        
        [DataMember()]
        public Decimal NU_PESO_MICS {get;set;}
        
        [DataMember()]
        public String NU_CART_PORT {get;set;}
        
        [DataMember()]
        public String NU_DUES {get;set;}
        
        [DataMember()]
        public String NU_FACT {get;set;}
        
        [DataMember()]
        public String NU_GUIA_REMI {get;set;}
        
        [DataMember()]
        public String ID_CIUD {get;set;}
        
        [DataMember()]
        public String ST_CIER {get;set;}
        
        [DataMember()]
        public Int64 ID_EJES {get;set;}
        
        [DataMember()]
        public String ID_TIPO_JORN {get;set;}
        
        [DataMember()]
        public String TI_SITU {get;set;}
        
        [DataMember()]
        public String NU_CHAS {get;set;}
        
        [DataMember()]
        public Int16 NU_VUEL {get;set;}
        
        [DataMember()]
        public String NU_NOTA_ENTR {get;set;}
        
        [DataMember()]
        public String NU_MESA_PART {get;set;}
        
        [DataMember()]
        public String NU_CORR_CONT {get;set;}
        
        [DataMember()]
        public String FE_CONT {get;set;}
        
        [DataMember()]
        public String ST_CERT_CESO {get;set;}
        
        [DataMember()]
        public String CO_BODE {get;set;}
        
        [DataMember()]
        public String FE_TRAN_BDLO {get;set;}
        
        [DataMember()]
        public String HO_TRAN_BDLO {get;set;}
        
        [DataMember()]
        public Int64 ID_MOVI_BDLO {get;set;}
        
        [DataMember()]
        public String CO_PERS_PES1 {get;set;}
        
        [DataMember()]
        public String CO_PERS_PES2 {get;set;}
        
        [DataMember()]
        public String CO_REGU_PESO {get;set;}
        
        [DataMember()]
        public String CO_EDIT_PESO {get;set;}
        
        [DataMember()]
        public String ST_EDIT_PESO {get;set;}
        
        [DataMember()]
        public String ST_CIER_JORN {get;set;}
        
        [DataMember()]
        public String DE_MOTI_ANUL {get;set;}
        
        [DataMember()]
        public Int32 ID_USUA_CREA {get;set;}
        
        [DataMember()]
        public DateTime FE_USUA_CREA {get;set;}
        
        [DataMember()]
        public Int32 ID_USUA_MODI {get;set;}
        
        [DataMember()]
        public DateTime FE_USUA_MODI {get;set;}
        
        [DataMember()]
        public DateTime FE_PRIM_PESA {get;set;}
        
        [DataMember()]
        public DateTime FE_SEGU_PESA {get;set;}
        
        [DataMember()]
        public String CO_REGU_PES1 {get;set;}
        
        [DataMember()]
        public String CO_REGU_PES2 {get;set;}
        
        [DataMember()]
        public String ST_MOVI_TRAF {get;set;}
        
        [DataMember()]
        public String NU_MOVI_BDLO {get;set;}
        
        [DataMember()]
        public String ID_BAL2 {get;set;}
        
        [DataMember()]
        public String DE_MOTI_ROLE {get;set;}
        
        [DataMember()]
        public String DE_MOTI_REGU {get;set;}
                
        [DataMember()]
        public Boolean FI_Estado {get;set;}
        
        
        
        #region Constructores
        // Constructores
        public CCBALA()
        {
        }
        
        public CCBALA(
                    Int64 ID_MOVI_BALA_, 
                    Int64 ID_MOVI_DUES_, 
                    Int64 ID_MOVI_OPER_, 
                    String NU_MOVI_, 
                    String TI_MOVI_INDI_, 
                    Int64 ID_TICK_ANTE_, 
                    Int32 ID_UNID_, 
                    Int32 ID_EMPR_, 
                    String ID_BALA_, 
                    String CO_CLIE_,
                    DateTime FE_ENTR_, 
                    String HO_ENTR_,
                    DateTime? FE_SALI_, 
                    String HO_SALI_, 
                    String ID_TRAN_, 
                    String ID_REGI_PLAC_, 
                    String ID_REGI_COND_, 
                    String DE_NUME_TRAC_, 
                    String DE_NUME_TAUX_, 
                    String NU_RECA_, 
                    String NU_SALI_, 
                    Int64 ID_DOCU_ORIG_, 
                    Int16 NU_SECU_ITEM_, 
                    String DE_OBSE_, 
                    Decimal CA_PES1_, 
                    Decimal CA_PES2_, 
                    Decimal CA_PESO_SECO_, 
                    String DE_MICS_, 
                    Decimal NU_PESO_MICS_, 
                    String NU_CART_PORT_, 
                    String NU_DUES_, 
                    String NU_FACT_, 
                    String NU_GUIA_REMI_, 
                    String ID_CIUD_, 
                    String ST_CIER_, 
                    Int64 ID_EJES_, 
                    String ID_TIPO_JORN_, 
                    String TI_SITU_, 
                    String NU_CHAS_, 
                    Int16 NU_VUEL_, 
                    String NU_NOTA_ENTR_, 
                    String NU_MESA_PART_, 
                    String NU_CORR_CONT_, 
                    String FE_CONT_, 
                    String ST_CERT_CESO_, 
                    String CO_BODE_, 
                    String FE_TRAN_BDLO_, 
                    String HO_TRAN_BDLO_, 
                    Int64 ID_MOVI_BDLO_, 
                    String CO_PERS_PES1_, 
                    String CO_PERS_PES2_, 
                    String CO_REGU_PESO_, 
                    String CO_EDIT_PESO_, 
                    String ST_EDIT_PESO_, 
                    String ST_CIER_JORN_, 
                    String DE_MOTI_ANUL_, 
                    Int32 ID_USUA_CREA_, 
                    DateTime FE_USUA_CREA_, 
                    Int32 ID_USUA_MODI_, 
                    DateTime FE_USUA_MODI_, 
                    DateTime FE_PRIM_PESA_, 
                    DateTime FE_SEGU_PESA_, 
                    String CO_REGU_PES1_, 
                    String CO_REGU_PES2_, 
                    String ST_MOVI_TRAF_, 
                    String NU_MOVI_BDLO_, 
                    String ID_BAL2_, 
                    String DE_MOTI_ROLE_, 
                    String DE_MOTI_REGU_, 
                    //Char ST_ENVIO_ADUA_, 
                    Boolean FI_Estado_)
        {
            ID_MOVI_BALA = ID_MOVI_BALA_;
            ID_MOVI_DUES = ID_MOVI_DUES_;
            ID_MOVI_OPER = ID_MOVI_OPER_;
            NU_MOVI = NU_MOVI_;
            TI_MOVI_INDI = TI_MOVI_INDI_;
            ID_TICK_ANTE = ID_TICK_ANTE_;
            ID_UNID = ID_UNID_;
            ID_EMPR = ID_EMPR_;
            ID_BALA = ID_BALA_;
            CO_CLIE = CO_CLIE_;
            FE_ENTR = FE_ENTR_;
            HO_ENTR = HO_ENTR_;
            FE_SALI = FE_SALI_;
            HO_SALI = HO_SALI_;
            ID_TRAN = ID_TRAN_;
            ID_REGI_PLAC = ID_REGI_PLAC_;
            ID_REGI_COND = ID_REGI_COND_;
            DE_NUME_TRAC = DE_NUME_TRAC_;
            DE_NUME_TAUX = DE_NUME_TAUX_;
            NU_RECA = NU_RECA_;
            NU_SALI = NU_SALI_;
            ID_DOCU_ORIG = ID_DOCU_ORIG_;
            NU_SECU_ITEM = NU_SECU_ITEM_;
            DE_OBSE = DE_OBSE_;
            CA_PES1 = CA_PES1_;
            CA_PES2 = CA_PES2_;
            CA_PESO_SECO = CA_PESO_SECO_;
            DE_MICS = DE_MICS_;
            NU_PESO_MICS = NU_PESO_MICS_;
            NU_CART_PORT = NU_CART_PORT_;
            NU_DUES = NU_DUES_;
            NU_FACT = NU_FACT_;
            NU_GUIA_REMI = NU_GUIA_REMI_;
            ID_CIUD = ID_CIUD_;
            ST_CIER = ST_CIER_;
            ID_EJES = ID_EJES_;
            ID_TIPO_JORN = ID_TIPO_JORN_;
            TI_SITU = TI_SITU_;
            NU_CHAS = NU_CHAS_;
            NU_VUEL = NU_VUEL_;
            NU_NOTA_ENTR = NU_NOTA_ENTR_;
            NU_MESA_PART = NU_MESA_PART_;
            NU_CORR_CONT = NU_CORR_CONT_;
            FE_CONT = FE_CONT_;
            ST_CERT_CESO = ST_CERT_CESO_;
            CO_BODE = CO_BODE_;
            FE_TRAN_BDLO = FE_TRAN_BDLO_;
            HO_TRAN_BDLO = HO_TRAN_BDLO_;
            ID_MOVI_BDLO = ID_MOVI_BDLO_;
            CO_PERS_PES1 = CO_PERS_PES1_;
            CO_PERS_PES2 = CO_PERS_PES2_;
            CO_REGU_PESO = CO_REGU_PESO_;
            CO_EDIT_PESO = CO_EDIT_PESO_;
            ST_EDIT_PESO = ST_EDIT_PESO_;
            ST_CIER_JORN = ST_CIER_JORN_;
            DE_MOTI_ANUL = DE_MOTI_ANUL_;
            ID_USUA_CREA = ID_USUA_CREA_;
            FE_USUA_CREA = FE_USUA_CREA_;
            ID_USUA_MODI = ID_USUA_MODI_;
            FE_USUA_MODI = FE_USUA_MODI_;
            FE_PRIM_PESA = FE_PRIM_PESA_;
            FE_SEGU_PESA = FE_SEGU_PESA_;
            CO_REGU_PES1 = CO_REGU_PES1_;
            CO_REGU_PES2 = CO_REGU_PES2_;
            ST_MOVI_TRAF = ST_MOVI_TRAF_;
            NU_MOVI_BDLO = NU_MOVI_BDLO_;
            ID_BAL2 = ID_BAL2_;
            DE_MOTI_ROLE = DE_MOTI_ROLE_;
            DE_MOTI_REGU = DE_MOTI_REGU_;
            //ST_ENVIO_ADUA = ST_ENVIO_ADUA_;
            FI_Estado = FI_Estado_;

        }
        #endregion
    }
}
