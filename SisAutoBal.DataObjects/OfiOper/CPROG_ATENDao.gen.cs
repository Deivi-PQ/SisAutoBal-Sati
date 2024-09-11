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
    
    
    public partial class CPROG_ATENDao : DataAccessBase
    {
        
        public virtual CCPROG_ATEN getCPROG_ATEN(DataRow dr)
        {
            return new CCPROG_ATEN(Convert.ToInt64(dr["ID_PROG_ATEN"]),Convert.ToInt64(dr["ID_PROG_ORIG"]),Convert.ToInt64(dr["ID_REQU_ATEN"]),Convert.ToInt32(dr["ID_UNID"]),Convert.ToInt32(dr["ID_EMPR"]),Convert.ToString(dr["NU_PROG_ATEN"]),Convert.ToString(dr["TI_MOVI_INDI"]),Convert.ToString(dr["CO_CLIE"]),Convert.ToString(dr["DE_OTRO_SERV"]),Convert.ToString(dr["TI_SERV"]),Convert.ToInt16(dr["CA_CAMI"]),Convert.ToString(dr["ST_SOLI_SERV"]),Convert.ToString(dr["TI_SITU"]),Convert.ToString(dr["FE_SOLI"]),Convert.ToString(dr["HO_SOLI"]),Convert.ToString(dr["FE_PROG_INIC"]),Convert.ToString(dr["HO_PROG_INIC"]),Convert.ToString(dr["FE_PROG_FINA"]),Convert.ToString(dr["HO_PROG_FINA"]),Convert.ToString(dr["ST_REAL"]),Convert.ToString(dr["FE_REAL_INIC"]),Convert.ToString(dr["HO_REAL_INIC"]),Convert.ToString(dr["FE_REAL_FINA"]),Convert.ToString(dr["HO_REAL_FINA"]),Convert.ToString(dr["ID_CIUD"]),Convert.ToString(dr["NU_RECA"]),Convert.ToString(dr["DE_MOTI_REPR"]),Convert.ToString(dr["ST_CIER_PROG"]),Convert.ToString(dr["ID_TIPO_PLAN"]),Convert.ToString(dr["CO_PERS_PLAN"]),Convert.ToString(dr["ST_HABI_DETA"]),Convert.ToInt32(dr["ID_USUA_CREA"]),Convert.ToDateTime(dr["FE_USUA_CREA"]),Convert.ToInt32(dr["ID_USUA_MODI"]),Convert.ToDateTime(dr["FE_USUA_MODI"]),Convert.ToString(dr["DE_DEST"]),Convert.ToString(dr["CO_BOOK"]),Convert.ToString(dr["ID_BALA"]));
        }
        
        public virtual CCPROG_ATEN getCPROG_ATEN(IDataReader dr)
        {
            return new CCPROG_ATEN(Convert.ToInt64(dr["ID_PROG_ATEN"]),Convert.ToInt64(dr["ID_PROG_ORIG"]),Convert.ToInt64(dr["ID_REQU_ATEN"]),Convert.ToInt32(dr["ID_UNID"]),Convert.ToInt32(dr["ID_EMPR"]),Convert.ToString(dr["NU_PROG_ATEN"]),Convert.ToString(dr["TI_MOVI_INDI"]),Convert.ToString(dr["CO_CLIE"]),Convert.ToString(dr["DE_OTRO_SERV"]),Convert.ToString(dr["TI_SERV"]),Convert.ToInt16(dr["CA_CAMI"]),Convert.ToString(dr["ST_SOLI_SERV"]),Convert.ToString(dr["TI_SITU"]),Convert.ToString(dr["FE_SOLI"]),Convert.ToString(dr["HO_SOLI"]),Convert.ToString(dr["FE_PROG_INIC"]),Convert.ToString(dr["HO_PROG_INIC"]),Convert.ToString(dr["FE_PROG_FINA"]),Convert.ToString(dr["HO_PROG_FINA"]),Convert.ToString(dr["ST_REAL"]),Convert.ToString(dr["FE_REAL_INIC"]),Convert.ToString(dr["HO_REAL_INIC"]),Convert.ToString(dr["FE_REAL_FINA"]),Convert.ToString(dr["HO_REAL_FINA"]),Convert.ToString(dr["ID_CIUD"]),Convert.ToString(dr["NU_RECA"]),Convert.ToString(dr["DE_MOTI_REPR"]),Convert.ToString(dr["ST_CIER_PROG"]),Convert.ToString(dr["ID_TIPO_PLAN"]),Convert.ToString(dr["CO_PERS_PLAN"]),Convert.ToString(dr["ST_HABI_DETA"]),Convert.ToInt32(dr["ID_USUA_CREA"]),Convert.ToDateTime(dr["FE_USUA_CREA"]),Convert.ToInt32(dr["ID_USUA_MODI"]),Convert.ToDateTime(dr["FE_USUA_MODI"]),Convert.ToString(dr["DE_DEST"]),Convert.ToString(dr["CO_BOOK"]),Convert.ToString(dr["ID_BALA"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CCPROG_ATEN oCPROG_ATEN)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("OfiOper.spu_CPROG_ATEN_Guardar")){
            Db.AddInParameter(dbCmd, "ID_PROG_ATEN", DbType.Int64, oCPROG_ATEN.ID_PROG_ATEN);
            Db.AddInParameter(dbCmd, "ID_PROG_ORIG", DbType.Int64, oCPROG_ATEN.ID_PROG_ORIG);
            Db.AddInParameter(dbCmd, "ID_REQU_ATEN", DbType.Int64, oCPROG_ATEN.ID_REQU_ATEN);
            Db.AddInParameter(dbCmd, "ID_UNID", DbType.Int32, oCPROG_ATEN.ID_UNID);
            Db.AddInParameter(dbCmd, "ID_EMPR", DbType.Int32, oCPROG_ATEN.ID_EMPR);
            Db.AddInParameter(dbCmd, "NU_PROG_ATEN", DbType.String, oCPROG_ATEN.NU_PROG_ATEN);
            Db.AddInParameter(dbCmd, "TI_MOVI_INDI", DbType.String, oCPROG_ATEN.TI_MOVI_INDI);
            Db.AddInParameter(dbCmd, "CO_CLIE", DbType.String, oCPROG_ATEN.CO_CLIE);
            Db.AddInParameter(dbCmd, "DE_OTRO_SERV", DbType.String, oCPROG_ATEN.DE_OTRO_SERV);
            Db.AddInParameter(dbCmd, "TI_SERV", DbType.String, oCPROG_ATEN.TI_SERV);
            Db.AddInParameter(dbCmd, "CA_CAMI", DbType.Int16, oCPROG_ATEN.CA_CAMI);
            Db.AddInParameter(dbCmd, "ST_SOLI_SERV", DbType.String, oCPROG_ATEN.ST_SOLI_SERV);
            Db.AddInParameter(dbCmd, "TI_SITU", DbType.String, oCPROG_ATEN.TI_SITU);
            Db.AddInParameter(dbCmd, "FE_SOLI", DbType.String, oCPROG_ATEN.FE_SOLI);
            Db.AddInParameter(dbCmd, "HO_SOLI", DbType.String, oCPROG_ATEN.HO_SOLI);
            Db.AddInParameter(dbCmd, "FE_PROG_INIC", DbType.String, oCPROG_ATEN.FE_PROG_INIC);
            Db.AddInParameter(dbCmd, "HO_PROG_INIC", DbType.String, oCPROG_ATEN.HO_PROG_INIC);
            Db.AddInParameter(dbCmd, "FE_PROG_FINA", DbType.String, oCPROG_ATEN.FE_PROG_FINA);
            Db.AddInParameter(dbCmd, "HO_PROG_FINA", DbType.String, oCPROG_ATEN.HO_PROG_FINA);
            Db.AddInParameter(dbCmd, "ST_REAL", DbType.String, oCPROG_ATEN.ST_REAL);
            Db.AddInParameter(dbCmd, "FE_REAL_INIC", DbType.String, oCPROG_ATEN.FE_REAL_INIC);
            Db.AddInParameter(dbCmd, "HO_REAL_INIC", DbType.String, oCPROG_ATEN.HO_REAL_INIC);
            Db.AddInParameter(dbCmd, "FE_REAL_FINA", DbType.String, oCPROG_ATEN.FE_REAL_FINA);
            Db.AddInParameter(dbCmd, "HO_REAL_FINA", DbType.String, oCPROG_ATEN.HO_REAL_FINA);
            Db.AddInParameter(dbCmd, "ID_CIUD", DbType.String, oCPROG_ATEN.ID_CIUD);
            Db.AddInParameter(dbCmd, "NU_RECA", DbType.String, oCPROG_ATEN.NU_RECA);
            Db.AddInParameter(dbCmd, "DE_MOTI_REPR", DbType.String, oCPROG_ATEN.DE_MOTI_REPR);
            Db.AddInParameter(dbCmd, "ST_CIER_PROG", DbType.String, oCPROG_ATEN.ST_CIER_PROG);
            Db.AddInParameter(dbCmd, "ID_TIPO_PLAN", DbType.String, oCPROG_ATEN.ID_TIPO_PLAN);
            Db.AddInParameter(dbCmd, "CO_PERS_PLAN", DbType.String, oCPROG_ATEN.CO_PERS_PLAN);
            Db.AddInParameter(dbCmd, "ST_HABI_DETA", DbType.String, oCPROG_ATEN.ST_HABI_DETA);
            Db.AddInParameter(dbCmd, "ID_USUA_CREA", DbType.Int32, oCPROG_ATEN.ID_USUA_CREA);
            Db.AddInParameter(dbCmd, "FE_USUA_CREA", DbType.DateTime, oCPROG_ATEN.FE_USUA_CREA);
            Db.AddInParameter(dbCmd, "ID_USUA_MODI", DbType.Int32, oCPROG_ATEN.ID_USUA_MODI);
            Db.AddInParameter(dbCmd, "FE_USUA_MODI", DbType.DateTime, oCPROG_ATEN.FE_USUA_MODI);
            Db.AddInParameter(dbCmd, "DE_DEST", DbType.String, oCPROG_ATEN.DE_DEST);
            Db.AddInParameter(dbCmd, "CO_BOOK", DbType.String, oCPROG_ATEN.CO_BOOK);
            Db.AddInParameter(dbCmd, "ID_BALA", DbType.String, oCPROG_ATEN.ID_BALA);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar()
        {
            return Db.ExecuteNonQuery("OfiOper.spu_CPROG_ATEN_Eliminar",);
        }
        
        public virtual CCPROG_ATEN Recuperar()
        {
            DataTable dtDatos = Db.ExecuteDataSet("OfiOper.spu_CPROG_ATEN_Recuperar",).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getCPROG_ATEN(dtDatos.Rows[0]);
            else
            return new CCPROG_ATEN();
        }
        
        public virtual bool Existe()
        {
            DataTable dtDatos = Db.ExecuteDataSet("OfiOper.spu_CPROG_ATEN_Recuperar",).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(out CCPROG_ATEN oCPROG_ATEN)
        {
            DataTable dtDatos = Db.ExecuteDataSet("OfiOper.spu_CPROG_ATEN_Recuperar",).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oCPROG_ATEN = getCPROG_ATEN(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oCPROG_ATEN = new CCPROG_ATEN();
            return false;
            }
        }
        
        public virtual IList<CCPROG_ATEN> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure,"OfiOper.spu_CPROG_ATEN_Listar")){
            IList<CCPROG_ATEN> list = new List<CCPROG_ATEN>();
            while (dr.Read())
            list.Add(getCPROG_ATEN(dr));
            return list;
            }
        }
        #endregion
    }
}
