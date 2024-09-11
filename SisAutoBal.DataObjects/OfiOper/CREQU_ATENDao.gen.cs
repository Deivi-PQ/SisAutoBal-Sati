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
    
    
    public partial class CREQU_ATENDao : DataAccessBase
    {
        
        public virtual CCREQU_ATEN getCREQU_ATEN(DataRow dr)
        {
            return new CCREQU_ATEN(Convert.ToInt64(dr["ID_REQU_ATEN"]),Convert.ToInt32(dr["ID_UNID"]),Convert.ToInt32(dr["ID_EMPR"]),Convert.ToString(dr["NU_REQU_ATEN"]),Convert.ToString(dr["CO_CLIE"]),Convert.ToString(dr["FE_REQU"]),Convert.ToString(dr["TI_SERV"]),Convert.ToString(dr["TI_SITU"]),Convert.ToString(dr["DE_OTRO_SERV"]),Convert.ToString(dr["DE_CARG"]),Convert.ToString(dr["DE_MERC"]),Convert.ToInt16(dr["CA_CAMI"]),Convert.ToString(dr["ST_SOLI_SERV"]),Convert.ToString(dr["FE_SOLI"]),Convert.ToString(dr["HO_SOLI"]),Convert.ToString(dr["ID_CIUD"]),Convert.ToInt16(dr["CA_BULT"]),Convert.ToDecimal(dr["CA_TONE"]),Convert.ToString(dr["CO_UNME"]),Convert.ToString(dr["DE_OBSE"]),Convert.ToInt32(dr["ID_USUA_CREA"]),Convert.ToDateTime(dr["FE_USUA_CREA"]),Convert.ToInt32(dr["ID_USUA_MODI"]),Convert.ToDateTime(dr["FE_USUA_MODI"]),Convert.ToString(dr["DE_MOTI_PCON"]),Convert.ToString(dr["NU_SALI"]),Convert.ToString(dr["ID_REGI"]),Convert.ToString(dr["ID_CLAS_CARG"]),Convert.ToString(dr["ID_TIPO_CARG"]),Convert.ToString(dr["ID_TIPO_EMBA"]),Convert.ToChar(dr["ST_POLI"]),Convert.ToChar(dr["ST_OPER"]),Convert.ToInt64(dr["ID_DOCU_ORIG"]),Convert.ToInt16(dr["NU_SECU_ITEM"]),Convert.ToString(dr["DE_DEST"]));
        }
        
        public virtual CCREQU_ATEN getCREQU_ATEN(IDataReader dr)
        {
            return new CCREQU_ATEN(Convert.ToInt64(dr["ID_REQU_ATEN"]),Convert.ToInt32(dr["ID_UNID"]),Convert.ToInt32(dr["ID_EMPR"]),Convert.ToString(dr["NU_REQU_ATEN"]),Convert.ToString(dr["CO_CLIE"]),Convert.ToString(dr["FE_REQU"]),Convert.ToString(dr["TI_SERV"]),Convert.ToString(dr["TI_SITU"]),Convert.ToString(dr["DE_OTRO_SERV"]),Convert.ToString(dr["DE_CARG"]),Convert.ToString(dr["DE_MERC"]),Convert.ToInt16(dr["CA_CAMI"]),Convert.ToString(dr["ST_SOLI_SERV"]),Convert.ToString(dr["FE_SOLI"]),Convert.ToString(dr["HO_SOLI"]),Convert.ToString(dr["ID_CIUD"]),Convert.ToInt16(dr["CA_BULT"]),Convert.ToDecimal(dr["CA_TONE"]),Convert.ToString(dr["CO_UNME"]),Convert.ToString(dr["DE_OBSE"]),Convert.ToInt32(dr["ID_USUA_CREA"]),Convert.ToDateTime(dr["FE_USUA_CREA"]),Convert.ToInt32(dr["ID_USUA_MODI"]),Convert.ToDateTime(dr["FE_USUA_MODI"]),Convert.ToString(dr["DE_MOTI_PCON"]),Convert.ToString(dr["NU_SALI"]),Convert.ToString(dr["ID_REGI"]),Convert.ToString(dr["ID_CLAS_CARG"]),Convert.ToString(dr["ID_TIPO_CARG"]),Convert.ToString(dr["ID_TIPO_EMBA"]),Convert.ToChar(dr["ST_POLI"]),Convert.ToChar(dr["ST_OPER"]),Convert.ToInt64(dr["ID_DOCU_ORIG"]),Convert.ToInt16(dr["NU_SECU_ITEM"]),Convert.ToString(dr["DE_DEST"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CCREQU_ATEN oCREQU_ATEN)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("OfiOper.spu_CREQU_ATEN_Guardar")){
            Db.AddInParameter(dbCmd, "ID_REQU_ATEN", DbType.Int64, oCREQU_ATEN.ID_REQU_ATEN);
            Db.AddInParameter(dbCmd, "ID_UNID", DbType.Int32, oCREQU_ATEN.ID_UNID);
            Db.AddInParameter(dbCmd, "ID_EMPR", DbType.Int32, oCREQU_ATEN.ID_EMPR);
            Db.AddInParameter(dbCmd, "NU_REQU_ATEN", DbType.String, oCREQU_ATEN.NU_REQU_ATEN);
            Db.AddInParameter(dbCmd, "CO_CLIE", DbType.String, oCREQU_ATEN.CO_CLIE);
            Db.AddInParameter(dbCmd, "FE_REQU", DbType.String, oCREQU_ATEN.FE_REQU);
            Db.AddInParameter(dbCmd, "TI_SERV", DbType.String, oCREQU_ATEN.TI_SERV);
            Db.AddInParameter(dbCmd, "TI_SITU", DbType.String, oCREQU_ATEN.TI_SITU);
            Db.AddInParameter(dbCmd, "DE_OTRO_SERV", DbType.String, oCREQU_ATEN.DE_OTRO_SERV);
            Db.AddInParameter(dbCmd, "DE_CARG", DbType.String, oCREQU_ATEN.DE_CARG);
            Db.AddInParameter(dbCmd, "DE_MERC", DbType.String, oCREQU_ATEN.DE_MERC);
            Db.AddInParameter(dbCmd, "CA_CAMI", DbType.Int16, oCREQU_ATEN.CA_CAMI);
            Db.AddInParameter(dbCmd, "ST_SOLI_SERV", DbType.String, oCREQU_ATEN.ST_SOLI_SERV);
            Db.AddInParameter(dbCmd, "FE_SOLI", DbType.String, oCREQU_ATEN.FE_SOLI);
            Db.AddInParameter(dbCmd, "HO_SOLI", DbType.String, oCREQU_ATEN.HO_SOLI);
            Db.AddInParameter(dbCmd, "ID_CIUD", DbType.String, oCREQU_ATEN.ID_CIUD);
            Db.AddInParameter(dbCmd, "CA_BULT", DbType.Int16, oCREQU_ATEN.CA_BULT);
            Db.AddInParameter(dbCmd, "CA_TONE", DbType.Decimal, oCREQU_ATEN.CA_TONE);
            Db.AddInParameter(dbCmd, "CO_UNME", DbType.String, oCREQU_ATEN.CO_UNME);
            Db.AddInParameter(dbCmd, "DE_OBSE", DbType.String, oCREQU_ATEN.DE_OBSE);
            Db.AddInParameter(dbCmd, "ID_USUA_CREA", DbType.Int32, oCREQU_ATEN.ID_USUA_CREA);
            Db.AddInParameter(dbCmd, "FE_USUA_CREA", DbType.DateTime, oCREQU_ATEN.FE_USUA_CREA);
            Db.AddInParameter(dbCmd, "ID_USUA_MODI", DbType.Int32, oCREQU_ATEN.ID_USUA_MODI);
            Db.AddInParameter(dbCmd, "FE_USUA_MODI", DbType.DateTime, oCREQU_ATEN.FE_USUA_MODI);
            Db.AddInParameter(dbCmd, "DE_MOTI_PCON", DbType.String, oCREQU_ATEN.DE_MOTI_PCON);
            Db.AddInParameter(dbCmd, "NU_SALI", DbType.String, oCREQU_ATEN.NU_SALI);
            Db.AddInParameter(dbCmd, "ID_REGI", DbType.String, oCREQU_ATEN.ID_REGI);
            Db.AddInParameter(dbCmd, "ID_CLAS_CARG", DbType.String, oCREQU_ATEN.ID_CLAS_CARG);
            Db.AddInParameter(dbCmd, "ID_TIPO_CARG", DbType.String, oCREQU_ATEN.ID_TIPO_CARG);
            Db.AddInParameter(dbCmd, "ID_TIPO_EMBA", DbType.String, oCREQU_ATEN.ID_TIPO_EMBA);
            Db.AddInParameter(dbCmd, "ST_POLI", DbType.String, oCREQU_ATEN.ST_POLI);
            Db.AddInParameter(dbCmd, "ST_OPER", DbType.String, oCREQU_ATEN.ST_OPER);
            Db.AddInParameter(dbCmd, "ID_DOCU_ORIG", DbType.Int64, oCREQU_ATEN.ID_DOCU_ORIG);
            Db.AddInParameter(dbCmd, "NU_SECU_ITEM", DbType.Int16, oCREQU_ATEN.NU_SECU_ITEM);
            Db.AddInParameter(dbCmd, "DE_DEST", DbType.String, oCREQU_ATEN.DE_DEST);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar()
        {
            return Db.ExecuteNonQuery("OfiOper.spu_CREQU_ATEN_Eliminar",);
        }
        
        public virtual CCREQU_ATEN Recuperar()
        {
            DataTable dtDatos = Db.ExecuteDataSet("OfiOper.spu_CREQU_ATEN_Recuperar",).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getCREQU_ATEN(dtDatos.Rows[0]);
            else
            return new CCREQU_ATEN();
        }
        
        public virtual bool Existe()
        {
            DataTable dtDatos = Db.ExecuteDataSet("OfiOper.spu_CREQU_ATEN_Recuperar",).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(out CCREQU_ATEN oCREQU_ATEN)
        {
            DataTable dtDatos = Db.ExecuteDataSet("OfiOper.spu_CREQU_ATEN_Recuperar",).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oCREQU_ATEN = getCREQU_ATEN(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oCREQU_ATEN = new CCREQU_ATEN();
            return false;
            }
        }
        
        public virtual IList<CCREQU_ATEN> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure,"OfiOper.spu_CREQU_ATEN_Listar")){
            IList<CCREQU_ATEN> list = new List<CCREQU_ATEN>();
            while (dr.Read())
            list.Add(getCREQU_ATEN(dr));
            return list;
            }
        }
        #endregion
    }
}
