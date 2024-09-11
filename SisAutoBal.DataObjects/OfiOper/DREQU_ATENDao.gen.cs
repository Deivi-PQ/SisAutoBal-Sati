//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: lunes, 6 de marzo de 2023
// </Auto Generado>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using SisAutBal.BusinessObjects.OfiOper;
using Microsoft.Practices.EnterpriseLibrary.Data;
using LibreriaBSNet;

namespace SisAutBal.DataObjects.OfiOper
{
    
    
    public partial class DREQU_ATENDao : DataAccessBase
    {
        
        public virtual CDREQU_ATEN getDREQU_ATEN(DataRow dr)
        {
            return new CDREQU_ATEN(Convert.ToInt64(dr["ID_REQU_ATEN"]),Convert.ToInt16(dr["NU_SECU"]),Convert.ToString(dr["ID_REGI_PLAC"]),Convert.ToString(dr["ID_PLAC_CLIE"]),Convert.ToString(dr["ID_REGI_COND"]),Convert.ToString(dr["NU_DOCU_IDEN"]),Convert.ToString(dr["NO_COND"]),Convert.ToString(dr["AP_COND"]),Convert.ToString(dr["NU_BREV"]),Convert.ToString(dr["ID_TRAN"]),Convert.ToString(dr["ID_TRAN_CLIE"]),Convert.ToString(dr["NO_TRAN"]),Convert.ToString(dr["TI_NACI_EXTR"]),Convert.ToString(dr["DE_NUME_TRAC"]),Convert.ToString(dr["ID_TIPO_EMBA"]),Convert.ToInt16(dr["CA_BULT"]),Convert.ToDecimal(dr["CA_TONE"]),Convert.ToString(dr["CO_UNME"]),Convert.ToString(dr["FE_SOLI"]),Convert.ToString(dr["HO_SOLI"]),Convert.ToInt32(dr["ID_USUA_CREA"]),Convert.ToDateTime(dr["FE_USUA_CREA"]),Convert.ToInt32(dr["ID_USUA_MODI"]),Convert.ToDateTime(dr["FE_USUA_MODI"]),Convert.ToDateTime(dr["FE_SOAT"]),Convert.ToDateTime(dr["FE_REVI_TECN_TRAC"]),Convert.ToDateTime(dr["FE_REVI_TECN_RANF"]),Convert.ToBoolean(dr["IN_TARJ_PROP_TRAC"]),Convert.ToBoolean(dr["IN_TARJ_PROP_RANF"]),Convert.ToBoolean(dr["IN_SCTR"]),Convert.ToDateTime(dr["FE_SCTR"]),Convert.ToBoolean(dr["IN_CURS_PORT"]),Convert.ToDateTime(dr["FE_CURS_PORT"]),Convert.ToString(dr["DE_CONT"]),Convert.ToString(dr["DE_PREC_1"]),Convert.ToString(dr["DE_PREC_2"]),Convert.ToString(dr["DE_PREC_3"]),Convert.ToString(dr["DE_NUME_RANF"]),Convert.ToBoolean(dr["IN_REVI_TECN"]),Convert.ToString(dr["NU_DOCU_TRANS"]),Convert.ToChar(dr["IN_TIPO_OPER"]),Convert.ToDecimal(dr["CA_CAPA_MAX"]),Convert.ToString(dr["NU_PEDI"]),Convert.ToDecimal(dr["PE_VACI_ORIG"]),Convert.ToDecimal(dr["PE_LLEN_ORIG"]),Convert.ToDecimal(dr["PE_NETO_ORIG"]),Convert.ToString(dr["NO_COND_DOS"]),Convert.ToString(dr["NU_DNI_COND_DOS"]),Convert.ToString(dr["NU_BREV_COND_DOS"]),Convert.ToString(dr["NU_GUIA_REMI"]),Convert.ToString(dr["UB_ASIG"]),Convert.ToString(dr["DE_OBSE"]),Convert.ToString(dr["NU_RUC_CLIE"]),Convert.ToString(dr["ID_UBIG"]),Convert.ToString(dr["DE_DIRE"]),Convert.ToString(dr["TIPO_MRB"]));
        }
        
        public virtual CDREQU_ATEN getDREQU_ATEN(IDataReader dr)
        {
            return new CDREQU_ATEN(Convert.ToInt64(dr["ID_REQU_ATEN"]),Convert.ToInt16(dr["NU_SECU"]),Convert.ToString(dr["ID_REGI_PLAC"]),Convert.ToString(dr["ID_PLAC_CLIE"]),Convert.ToString(dr["ID_REGI_COND"]),Convert.ToString(dr["NU_DOCU_IDEN"]),Convert.ToString(dr["NO_COND"]),Convert.ToString(dr["AP_COND"]),Convert.ToString(dr["NU_BREV"]),Convert.ToString(dr["ID_TRAN"]),Convert.ToString(dr["ID_TRAN_CLIE"]),Convert.ToString(dr["NO_TRAN"]),Convert.ToString(dr["TI_NACI_EXTR"]),Convert.ToString(dr["DE_NUME_TRAC"]),Convert.ToString(dr["ID_TIPO_EMBA"]),Convert.ToInt16(dr["CA_BULT"]),Convert.ToDecimal(dr["CA_TONE"]),Convert.ToString(dr["CO_UNME"]),Convert.ToString(dr["FE_SOLI"]),Convert.ToString(dr["HO_SOLI"]),Convert.ToInt32(dr["ID_USUA_CREA"]),Convert.ToDateTime(dr["FE_USUA_CREA"]),Convert.ToInt32(dr["ID_USUA_MODI"]),Convert.ToDateTime(dr["FE_USUA_MODI"]),Convert.ToDateTime(dr["FE_SOAT"]),Convert.ToDateTime(dr["FE_REVI_TECN_TRAC"]),Convert.ToDateTime(dr["FE_REVI_TECN_RANF"]),Convert.ToBoolean(dr["IN_TARJ_PROP_TRAC"]),Convert.ToBoolean(dr["IN_TARJ_PROP_RANF"]),Convert.ToBoolean(dr["IN_SCTR"]),Convert.ToDateTime(dr["FE_SCTR"]),Convert.ToBoolean(dr["IN_CURS_PORT"]),Convert.ToDateTime(dr["FE_CURS_PORT"]),Convert.ToString(dr["DE_CONT"]),Convert.ToString(dr["DE_PREC_1"]),Convert.ToString(dr["DE_PREC_2"]),Convert.ToString(dr["DE_PREC_3"]),Convert.ToString(dr["DE_NUME_RANF"]),Convert.ToBoolean(dr["IN_REVI_TECN"]),Convert.ToString(dr["NU_DOCU_TRANS"]),Convert.ToChar(dr["IN_TIPO_OPER"]),Convert.ToDecimal(dr["CA_CAPA_MAX"]),Convert.ToString(dr["NU_PEDI"]),Convert.ToDecimal(dr["PE_VACI_ORIG"]),Convert.ToDecimal(dr["PE_LLEN_ORIG"]),Convert.ToDecimal(dr["PE_NETO_ORIG"]),Convert.ToString(dr["NO_COND_DOS"]),Convert.ToString(dr["NU_DNI_COND_DOS"]),Convert.ToString(dr["NU_BREV_COND_DOS"]),Convert.ToString(dr["NU_GUIA_REMI"]),Convert.ToString(dr["UB_ASIG"]),Convert.ToString(dr["DE_OBSE"]),Convert.ToString(dr["NU_RUC_CLIE"]),Convert.ToString(dr["ID_UBIG"]),Convert.ToString(dr["DE_DIRE"]),Convert.ToString(dr["TIPO_MRB"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CDREQU_ATEN oDREQU_ATEN)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("OfiOper.spu_DREQU_ATEN_Guardar")){
            Db.AddInParameter(dbCmd, "ID_REQU_ATEN", DbType.Int64, oDREQU_ATEN.ID_REQU_ATEN);
            Db.AddInParameter(dbCmd, "NU_SECU", DbType.Int16, oDREQU_ATEN.NU_SECU);
            Db.AddInParameter(dbCmd, "ID_REGI_PLAC", DbType.String, oDREQU_ATEN.ID_REGI_PLAC);
            Db.AddInParameter(dbCmd, "ID_PLAC_CLIE", DbType.String, oDREQU_ATEN.ID_PLAC_CLIE);
            Db.AddInParameter(dbCmd, "ID_REGI_COND", DbType.String, oDREQU_ATEN.ID_REGI_COND);
            Db.AddInParameter(dbCmd, "NU_DOCU_IDEN", DbType.String, oDREQU_ATEN.NU_DOCU_IDEN);
            Db.AddInParameter(dbCmd, "NO_COND", DbType.String, oDREQU_ATEN.NO_COND);
            Db.AddInParameter(dbCmd, "AP_COND", DbType.String, oDREQU_ATEN.AP_COND);
            Db.AddInParameter(dbCmd, "NU_BREV", DbType.String, oDREQU_ATEN.NU_BREV);
            Db.AddInParameter(dbCmd, "ID_TRAN", DbType.String, oDREQU_ATEN.ID_TRAN);
            Db.AddInParameter(dbCmd, "ID_TRAN_CLIE", DbType.String, oDREQU_ATEN.ID_TRAN_CLIE);
            Db.AddInParameter(dbCmd, "NO_TRAN", DbType.String, oDREQU_ATEN.NO_TRAN);
            Db.AddInParameter(dbCmd, "TI_NACI_EXTR", DbType.String, oDREQU_ATEN.TI_NACI_EXTR);
            Db.AddInParameter(dbCmd, "DE_NUME_TRAC", DbType.String, oDREQU_ATEN.DE_NUME_TRAC);
            Db.AddInParameter(dbCmd, "ID_TIPO_EMBA", DbType.String, oDREQU_ATEN.ID_TIPO_EMBA);
            Db.AddInParameter(dbCmd, "CA_BULT", DbType.Int16, oDREQU_ATEN.CA_BULT);
            Db.AddInParameter(dbCmd, "CA_TONE", DbType.Decimal, oDREQU_ATEN.CA_TONE);
            Db.AddInParameter(dbCmd, "CO_UNME", DbType.String, oDREQU_ATEN.CO_UNME);
            Db.AddInParameter(dbCmd, "FE_SOLI", DbType.String, oDREQU_ATEN.FE_SOLI);
            Db.AddInParameter(dbCmd, "HO_SOLI", DbType.String, oDREQU_ATEN.HO_SOLI);
            Db.AddInParameter(dbCmd, "ID_USUA_CREA", DbType.Int32, oDREQU_ATEN.ID_USUA_CREA);
            Db.AddInParameter(dbCmd, "FE_USUA_CREA", DbType.DateTime, oDREQU_ATEN.FE_USUA_CREA);
            Db.AddInParameter(dbCmd, "ID_USUA_MODI", DbType.Int32, oDREQU_ATEN.ID_USUA_MODI);
            Db.AddInParameter(dbCmd, "FE_USUA_MODI", DbType.DateTime, oDREQU_ATEN.FE_USUA_MODI);
            Db.AddInParameter(dbCmd, "FE_SOAT", DbType.DateTime, oDREQU_ATEN.FE_SOAT);
            Db.AddInParameter(dbCmd, "FE_REVI_TECN_TRAC", DbType.DateTime, oDREQU_ATEN.FE_REVI_TECN_TRAC);
            Db.AddInParameter(dbCmd, "FE_REVI_TECN_RANF", DbType.DateTime, oDREQU_ATEN.FE_REVI_TECN_RANF);
            Db.AddInParameter(dbCmd, "IN_TARJ_PROP_TRAC", DbType.Boolean, oDREQU_ATEN.IN_TARJ_PROP_TRAC);
            Db.AddInParameter(dbCmd, "IN_TARJ_PROP_RANF", DbType.Boolean, oDREQU_ATEN.IN_TARJ_PROP_RANF);
            Db.AddInParameter(dbCmd, "IN_SCTR", DbType.Boolean, oDREQU_ATEN.IN_SCTR);
            Db.AddInParameter(dbCmd, "FE_SCTR", DbType.DateTime, oDREQU_ATEN.FE_SCTR);
            Db.AddInParameter(dbCmd, "IN_CURS_PORT", DbType.Boolean, oDREQU_ATEN.IN_CURS_PORT);
            Db.AddInParameter(dbCmd, "FE_CURS_PORT", DbType.DateTime, oDREQU_ATEN.FE_CURS_PORT);
            Db.AddInParameter(dbCmd, "DE_CONT", DbType.String, oDREQU_ATEN.DE_CONT);
            Db.AddInParameter(dbCmd, "DE_PREC_1", DbType.String, oDREQU_ATEN.DE_PREC_1);
            Db.AddInParameter(dbCmd, "DE_PREC_2", DbType.String, oDREQU_ATEN.DE_PREC_2);
            Db.AddInParameter(dbCmd, "DE_PREC_3", DbType.String, oDREQU_ATEN.DE_PREC_3);
            Db.AddInParameter(dbCmd, "DE_NUME_RANF", DbType.String, oDREQU_ATEN.DE_NUME_RANF);
            Db.AddInParameter(dbCmd, "IN_REVI_TECN", DbType.Boolean, oDREQU_ATEN.IN_REVI_TECN);
            Db.AddInParameter(dbCmd, "NU_DOCU_TRANS", DbType.String, oDREQU_ATEN.NU_DOCU_TRANS);
            Db.AddInParameter(dbCmd, "IN_TIPO_OPER", DbType.String, oDREQU_ATEN.IN_TIPO_OPER);
            Db.AddInParameter(dbCmd, "CA_CAPA_MAX", DbType.Decimal, oDREQU_ATEN.CA_CAPA_MAX);
            Db.AddInParameter(dbCmd, "NU_PEDI", DbType.String, oDREQU_ATEN.NU_PEDI);
            Db.AddInParameter(dbCmd, "PE_VACI_ORIG", DbType.Decimal, oDREQU_ATEN.PE_VACI_ORIG);
            Db.AddInParameter(dbCmd, "PE_LLEN_ORIG", DbType.Decimal, oDREQU_ATEN.PE_LLEN_ORIG);
            Db.AddInParameter(dbCmd, "PE_NETO_ORIG", DbType.Decimal, oDREQU_ATEN.PE_NETO_ORIG);
            Db.AddInParameter(dbCmd, "NO_COND_DOS", DbType.String, oDREQU_ATEN.NO_COND_DOS);
            Db.AddInParameter(dbCmd, "NU_DNI_COND_DOS", DbType.String, oDREQU_ATEN.NU_DNI_COND_DOS);
            Db.AddInParameter(dbCmd, "NU_BREV_COND_DOS", DbType.String, oDREQU_ATEN.NU_BREV_COND_DOS);
            Db.AddInParameter(dbCmd, "NU_GUIA_REMI", DbType.String, oDREQU_ATEN.NU_GUIA_REMI);
            Db.AddInParameter(dbCmd, "UB_ASIG", DbType.String, oDREQU_ATEN.UB_ASIG);
            Db.AddInParameter(dbCmd, "DE_OBSE", DbType.String, oDREQU_ATEN.DE_OBSE);
            Db.AddInParameter(dbCmd, "NU_RUC_CLIE", DbType.String, oDREQU_ATEN.NU_RUC_CLIE);
            Db.AddInParameter(dbCmd, "ID_UBIG", DbType.String, oDREQU_ATEN.ID_UBIG);
            Db.AddInParameter(dbCmd, "DE_DIRE", DbType.String, oDREQU_ATEN.DE_DIRE);
            Db.AddInParameter(dbCmd, "TIPO_MRB", DbType.String, oDREQU_ATEN.TIPO_MRB);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar()
        {
            return Db.ExecuteNonQuery("OfiOper.spu_DREQU_ATEN_Eliminar",);
        }
        
        public virtual CDREQU_ATEN Recuperar()
        {
            DataTable dtDatos = Db.ExecuteDataSet("OfiOper.spu_DREQU_ATEN_Recuperar",).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getDREQU_ATEN(dtDatos.Rows[0]);
            else
            return new CDREQU_ATEN();
        }
        
        public virtual bool Existe()
        {
            DataTable dtDatos = Db.ExecuteDataSet("OfiOper.spu_DREQU_ATEN_Recuperar",).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(out CDREQU_ATEN oDREQU_ATEN)
        {
            DataTable dtDatos = Db.ExecuteDataSet("OfiOper.spu_DREQU_ATEN_Recuperar",).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oDREQU_ATEN = getDREQU_ATEN(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oDREQU_ATEN = new CDREQU_ATEN();
            return false;
            }
        }
        
        public virtual IList<CDREQU_ATEN> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure,"OfiOper.spu_DREQU_ATEN_Listar")){
            IList<CDREQU_ATEN> list = new List<CDREQU_ATEN>();
            while (dr.Read())
            list.Add(getDREQU_ATEN(dr));
            return list;
            }
        }
        #endregion
    }
}
