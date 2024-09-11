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
    
    
    public partial class CTARJDao : DataAccessBase
    {
        
        public virtual CCTARJ getCTARJ(DataRow dr)
        {
            return new CCTARJ(Convert.ToInt64(dr["ID_MOVI_TARJ"]),Convert.ToInt64(dr["ID_MOVI_TORI"]),Convert.ToInt32(dr["ID_UNID"]),Convert.ToInt32(dr["ID_EMPR"]),Convert.ToString(dr["TI_DOCU_TARJ"]),Convert.ToString(dr["NU_DOCU_TARJ"]),Convert.ToInt64(dr["ID_MOVI_TRFR"]),Convert.ToString(dr["ID_MOVI"]),Convert.ToInt64(dr["ID_MOVI_BALA"]),Convert.ToString(dr["ST_INGR_SALI"]),Convert.ToString(dr["NU_SALI"]),Convert.ToString(dr["ID_REGI_PLAC"]),Convert.ToString(dr["NU_VAGO"]),Convert.ToString(dr["NU_RECA"]),Convert.ToInt64(dr["ID_DOCU_ORIG"]),Convert.ToInt16(dr["NU_SECU_ITEM"]),Convert.ToString(dr["ID_ALMA"]),Convert.ToString(dr["ID_UBIC_ALMA"]),Convert.ToString(dr["ID_REGI"]),Convert.ToString(dr["ID_CLAS_CARG"]),Convert.ToString(dr["ID_TIPO_CARG"]),Convert.ToString(dr["ID_TIPO_EMBA"]),Convert.ToString(dr["ID_TIPO_JORN"]),Convert.ToString(dr["CO_BODE"]),Convert.ToString(dr["FE_TARJ"]),Convert.ToInt64(dr["ID_PROG_ATEN"]),Convert.ToInt64(dr["ID_REQU_ATEN"]),Convert.ToDecimal(dr["CA_TOTA"]),Convert.ToDecimal(dr["CA_TOTA_SIGN"]),Convert.ToDecimal(dr["CA_PESO"]),Convert.ToDecimal(dr["CA_PESO_SIGN"]),Convert.ToString(dr["CO_RESP_TARJ"]),Convert.ToString(dr["CO_RESP_OPER"]),Convert.ToString(dr["ST_FINA_REDE"]),Convert.ToString(dr["ST_REDE_ORIG"]),Convert.ToString(dr["FE_OPER_INIC"]),Convert.ToString(dr["HO_OPER_INIC"]),Convert.ToString(dr["FE_OPER_FINA"]),Convert.ToString(dr["HO_OPER_FINA"]),Convert.ToString(dr["DE_NUME_CHAS"]),Convert.ToString(dr["DE_NUME_ACTA"]),Convert.ToString(dr["ST_SALD"]),Convert.ToString(dr["ST_CIER_OPER"]),Convert.ToInt32(dr["ID_USUA_CREA"]),Convert.ToDateTime(dr["FE_USUA_CREA"]),Convert.ToInt32(dr["ID_USUA_MODI"]),Convert.ToDateTime(dr["FE_USUA_MODI"]),Convert.ToString(dr["ST_TRAF"]),Convert.ToString(dr["NU_DOCU_ANTE"]),Convert.ToString(dr["NU_TARJ_ANTE"]),Convert.ToString(dr["CO_CUAD"]),Convert.ToString(dr["NU_TRAF_MIGRA"]),Convert.ToDecimal(dr["CA_MODI"]),Convert.ToString(dr["ID_OBSE"]),Convert.ToString(dr["ID_MAQU"]),Convert.ToInt64(dr["ID_SERV"]),Convert.ToString(dr["TI_MANI"]),Convert.ToInt32(dr["CO_RECU_TERC"]),Convert.ToString(dr["TI_TRAC"]),Convert.ToInt32(dr["CO_TRAC_TERC"]),Convert.ToDateTime(dr["FE_INI_OBSE_TARJ"]),Convert.ToDateTime(dr["FE_FIN_OBSE_TARJ"]),Convert.ToString(dr["ID_OBSE_TARJ"]));
        }
        
        public virtual CCTARJ getCTARJ(IDataReader dr)
        {
            return new CCTARJ(Convert.ToInt64(dr["ID_MOVI_TARJ"]),Convert.ToInt64(dr["ID_MOVI_TORI"]),Convert.ToInt32(dr["ID_UNID"]),Convert.ToInt32(dr["ID_EMPR"]),Convert.ToString(dr["TI_DOCU_TARJ"]),Convert.ToString(dr["NU_DOCU_TARJ"]),Convert.ToInt64(dr["ID_MOVI_TRFR"]),Convert.ToString(dr["ID_MOVI"]),Convert.ToInt64(dr["ID_MOVI_BALA"]),Convert.ToString(dr["ST_INGR_SALI"]),Convert.ToString(dr["NU_SALI"]),Convert.ToString(dr["ID_REGI_PLAC"]),Convert.ToString(dr["NU_VAGO"]),Convert.ToString(dr["NU_RECA"]),Convert.ToInt64(dr["ID_DOCU_ORIG"]),Convert.ToInt16(dr["NU_SECU_ITEM"]),Convert.ToString(dr["ID_ALMA"]),Convert.ToString(dr["ID_UBIC_ALMA"]),Convert.ToString(dr["ID_REGI"]),Convert.ToString(dr["ID_CLAS_CARG"]),Convert.ToString(dr["ID_TIPO_CARG"]),Convert.ToString(dr["ID_TIPO_EMBA"]),Convert.ToString(dr["ID_TIPO_JORN"]),Convert.ToString(dr["CO_BODE"]),Convert.ToString(dr["FE_TARJ"]),Convert.ToInt64(dr["ID_PROG_ATEN"]),Convert.ToInt64(dr["ID_REQU_ATEN"]),Convert.ToDecimal(dr["CA_TOTA"]),Convert.ToDecimal(dr["CA_TOTA_SIGN"]),Convert.ToDecimal(dr["CA_PESO"]),Convert.ToDecimal(dr["CA_PESO_SIGN"]),Convert.ToString(dr["CO_RESP_TARJ"]),Convert.ToString(dr["CO_RESP_OPER"]),Convert.ToString(dr["ST_FINA_REDE"]),Convert.ToString(dr["ST_REDE_ORIG"]),Convert.ToString(dr["FE_OPER_INIC"]),Convert.ToString(dr["HO_OPER_INIC"]),Convert.ToString(dr["FE_OPER_FINA"]),Convert.ToString(dr["HO_OPER_FINA"]),Convert.ToString(dr["DE_NUME_CHAS"]),Convert.ToString(dr["DE_NUME_ACTA"]),Convert.ToString(dr["ST_SALD"]),Convert.ToString(dr["ST_CIER_OPER"]),Convert.ToInt32(dr["ID_USUA_CREA"]),Convert.ToDateTime(dr["FE_USUA_CREA"]),Convert.ToInt32(dr["ID_USUA_MODI"]),Convert.ToDateTime(dr["FE_USUA_MODI"]),Convert.ToString(dr["ST_TRAF"]),Convert.ToString(dr["NU_DOCU_ANTE"]),Convert.ToString(dr["NU_TARJ_ANTE"]),Convert.ToString(dr["CO_CUAD"]),Convert.ToString(dr["NU_TRAF_MIGRA"]),Convert.ToDecimal(dr["CA_MODI"]),Convert.ToString(dr["ID_OBSE"]),Convert.ToString(dr["ID_MAQU"]),Convert.ToInt64(dr["ID_SERV"]),Convert.ToString(dr["TI_MANI"]),Convert.ToInt32(dr["CO_RECU_TERC"]),Convert.ToString(dr["TI_TRAC"]),Convert.ToInt32(dr["CO_TRAC_TERC"]),Convert.ToDateTime(dr["FE_INI_OBSE_TARJ"]),Convert.ToDateTime(dr["FE_FIN_OBSE_TARJ"]),Convert.ToString(dr["ID_OBSE_TARJ"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CCTARJ oCTARJ)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("OfiOper.spu_CTARJ_Guardar")){
            Db.AddInParameter(dbCmd, "ID_MOVI_TARJ", DbType.Int64, oCTARJ.ID_MOVI_TARJ);
            Db.AddInParameter(dbCmd, "ID_MOVI_TORI", DbType.Int64, oCTARJ.ID_MOVI_TORI);
            Db.AddInParameter(dbCmd, "ID_UNID", DbType.Int32, oCTARJ.ID_UNID);
            Db.AddInParameter(dbCmd, "ID_EMPR", DbType.Int32, oCTARJ.ID_EMPR);
            Db.AddInParameter(dbCmd, "TI_DOCU_TARJ", DbType.String, oCTARJ.TI_DOCU_TARJ);
            Db.AddInParameter(dbCmd, "NU_DOCU_TARJ", DbType.String, oCTARJ.NU_DOCU_TARJ);
            Db.AddInParameter(dbCmd, "ID_MOVI_TRFR", DbType.Int64, oCTARJ.ID_MOVI_TRFR);
            Db.AddInParameter(dbCmd, "ID_MOVI", DbType.String, oCTARJ.ID_MOVI);
            Db.AddInParameter(dbCmd, "ID_MOVI_BALA", DbType.Int64, oCTARJ.ID_MOVI_BALA);
            Db.AddInParameter(dbCmd, "ST_INGR_SALI", DbType.String, oCTARJ.ST_INGR_SALI);
            Db.AddInParameter(dbCmd, "NU_SALI", DbType.String, oCTARJ.NU_SALI);
            Db.AddInParameter(dbCmd, "ID_REGI_PLAC", DbType.String, oCTARJ.ID_REGI_PLAC);
            Db.AddInParameter(dbCmd, "NU_VAGO", DbType.String, oCTARJ.NU_VAGO);
            Db.AddInParameter(dbCmd, "NU_RECA", DbType.String, oCTARJ.NU_RECA);
            Db.AddInParameter(dbCmd, "ID_DOCU_ORIG", DbType.Int64, oCTARJ.ID_DOCU_ORIG);
            Db.AddInParameter(dbCmd, "NU_SECU_ITEM", DbType.Int16, oCTARJ.NU_SECU_ITEM);
            Db.AddInParameter(dbCmd, "ID_ALMA", DbType.String, oCTARJ.ID_ALMA);
            Db.AddInParameter(dbCmd, "ID_UBIC_ALMA", DbType.String, oCTARJ.ID_UBIC_ALMA);
            Db.AddInParameter(dbCmd, "ID_REGI", DbType.String, oCTARJ.ID_REGI);
            Db.AddInParameter(dbCmd, "ID_CLAS_CARG", DbType.String, oCTARJ.ID_CLAS_CARG);
            Db.AddInParameter(dbCmd, "ID_TIPO_CARG", DbType.String, oCTARJ.ID_TIPO_CARG);
            Db.AddInParameter(dbCmd, "ID_TIPO_EMBA", DbType.String, oCTARJ.ID_TIPO_EMBA);
            Db.AddInParameter(dbCmd, "ID_TIPO_JORN", DbType.String, oCTARJ.ID_TIPO_JORN);
            Db.AddInParameter(dbCmd, "CO_BODE", DbType.String, oCTARJ.CO_BODE);
            Db.AddInParameter(dbCmd, "FE_TARJ", DbType.String, oCTARJ.FE_TARJ);
            Db.AddInParameter(dbCmd, "ID_PROG_ATEN", DbType.Int64, oCTARJ.ID_PROG_ATEN);
            Db.AddInParameter(dbCmd, "ID_REQU_ATEN", DbType.Int64, oCTARJ.ID_REQU_ATEN);
            Db.AddInParameter(dbCmd, "CA_TOTA", DbType.Decimal, oCTARJ.CA_TOTA);
            Db.AddInParameter(dbCmd, "CA_TOTA_SIGN", DbType.Decimal, oCTARJ.CA_TOTA_SIGN);
            Db.AddInParameter(dbCmd, "CA_PESO", DbType.Decimal, oCTARJ.CA_PESO);
            Db.AddInParameter(dbCmd, "CA_PESO_SIGN", DbType.Decimal, oCTARJ.CA_PESO_SIGN);
            Db.AddInParameter(dbCmd, "CO_RESP_TARJ", DbType.String, oCTARJ.CO_RESP_TARJ);
            Db.AddInParameter(dbCmd, "CO_RESP_OPER", DbType.String, oCTARJ.CO_RESP_OPER);
            Db.AddInParameter(dbCmd, "ST_FINA_REDE", DbType.String, oCTARJ.ST_FINA_REDE);
            Db.AddInParameter(dbCmd, "ST_REDE_ORIG", DbType.String, oCTARJ.ST_REDE_ORIG);
            Db.AddInParameter(dbCmd, "FE_OPER_INIC", DbType.String, oCTARJ.FE_OPER_INIC);
            Db.AddInParameter(dbCmd, "HO_OPER_INIC", DbType.String, oCTARJ.HO_OPER_INIC);
            Db.AddInParameter(dbCmd, "FE_OPER_FINA", DbType.String, oCTARJ.FE_OPER_FINA);
            Db.AddInParameter(dbCmd, "HO_OPER_FINA", DbType.String, oCTARJ.HO_OPER_FINA);
            Db.AddInParameter(dbCmd, "DE_NUME_CHAS", DbType.String, oCTARJ.DE_NUME_CHAS);
            Db.AddInParameter(dbCmd, "DE_NUME_ACTA", DbType.String, oCTARJ.DE_NUME_ACTA);
            Db.AddInParameter(dbCmd, "ST_SALD", DbType.String, oCTARJ.ST_SALD);
            Db.AddInParameter(dbCmd, "ST_CIER_OPER", DbType.String, oCTARJ.ST_CIER_OPER);
            Db.AddInParameter(dbCmd, "ID_USUA_CREA", DbType.Int32, oCTARJ.ID_USUA_CREA);
            Db.AddInParameter(dbCmd, "FE_USUA_CREA", DbType.DateTime, oCTARJ.FE_USUA_CREA);
            Db.AddInParameter(dbCmd, "ID_USUA_MODI", DbType.Int32, oCTARJ.ID_USUA_MODI);
            Db.AddInParameter(dbCmd, "FE_USUA_MODI", DbType.DateTime, oCTARJ.FE_USUA_MODI);
            Db.AddInParameter(dbCmd, "ST_TRAF", DbType.String, oCTARJ.ST_TRAF);
            Db.AddInParameter(dbCmd, "NU_DOCU_ANTE", DbType.String, oCTARJ.NU_DOCU_ANTE);
            Db.AddInParameter(dbCmd, "NU_TARJ_ANTE", DbType.String, oCTARJ.NU_TARJ_ANTE);
            Db.AddInParameter(dbCmd, "CO_CUAD", DbType.String, oCTARJ.CO_CUAD);
            Db.AddInParameter(dbCmd, "NU_TRAF_MIGRA", DbType.String, oCTARJ.NU_TRAF_MIGRA);
            Db.AddInParameter(dbCmd, "CA_MODI", DbType.Decimal, oCTARJ.CA_MODI);
            Db.AddInParameter(dbCmd, "ID_OBSE", DbType.String, oCTARJ.ID_OBSE);
            Db.AddInParameter(dbCmd, "ID_MAQU", DbType.String, oCTARJ.ID_MAQU);
            Db.AddInParameter(dbCmd, "ID_SERV", DbType.Int64, oCTARJ.ID_SERV);
            Db.AddInParameter(dbCmd, "TI_MANI", DbType.String, oCTARJ.TI_MANI);
            Db.AddInParameter(dbCmd, "CO_RECU_TERC", DbType.Int32, oCTARJ.CO_RECU_TERC);
            Db.AddInParameter(dbCmd, "TI_TRAC", DbType.String, oCTARJ.TI_TRAC);
            Db.AddInParameter(dbCmd, "CO_TRAC_TERC", DbType.Int32, oCTARJ.CO_TRAC_TERC);
            Db.AddInParameter(dbCmd, "FE_INI_OBSE_TARJ", DbType.DateTime, oCTARJ.FE_INI_OBSE_TARJ);
            Db.AddInParameter(dbCmd, "FE_FIN_OBSE_TARJ", DbType.DateTime, oCTARJ.FE_FIN_OBSE_TARJ);
            Db.AddInParameter(dbCmd, "ID_OBSE_TARJ", DbType.String, oCTARJ.ID_OBSE_TARJ);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar()
        {
            return Db.ExecuteNonQuery("OfiOper.spu_CTARJ_Eliminar",);
        }
        
        public virtual CCTARJ Recuperar()
        {
            DataTable dtDatos = Db.ExecuteDataSet("OfiOper.spu_CTARJ_Recuperar",).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getCTARJ(dtDatos.Rows[0]);
            else
            return new CCTARJ();
        }
        
        public virtual bool Existe()
        {
            DataTable dtDatos = Db.ExecuteDataSet("OfiOper.spu_CTARJ_Recuperar",).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(out CCTARJ oCTARJ)
        {
            DataTable dtDatos = Db.ExecuteDataSet("OfiOper.spu_CTARJ_Recuperar",).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oCTARJ = getCTARJ(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oCTARJ = new CCTARJ();
            return false;
            }
        }
        
        public virtual IList<CCTARJ> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure,"OfiOper.spu_CTARJ_Listar")){
            IList<CCTARJ> list = new List<CCTARJ>();
            while (dr.Read())
            list.Add(getCTARJ(dr));
            return list;
            }
        }
        #endregion
    }
}
