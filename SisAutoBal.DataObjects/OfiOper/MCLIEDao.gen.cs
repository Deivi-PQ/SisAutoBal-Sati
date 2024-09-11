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
    
    
    public partial class MCLIEDao : DataAccessBase
    {
        
        public virtual CMCLIE getMCLIE(DataRow dr)
        {
            return new CMCLIE(Convert.ToDouble(dr["CO_ROLE"]),Convert.ToDouble(dr["NU_RUCS"]),Convert.ToDouble(dr["CO_CLIE"]),Convert.ToString(dr["DE_CLIE"]),Convert.ToDouble(dr["TI_DOID_SUNA"]),Convert.ToString(dr["TI_SITU"]),Convert.ToString(dr["CLIE_EMAIL"]),Convert.ToString(dr["F8"]),Convert.ToString(dr["F9"]),Convert.ToString(dr["F10"]),Convert.ToString(dr["F11"]),Convert.ToString(dr["F12"]),Convert.ToString(dr["F13"]),Convert.ToString(dr["F14"]));
        }
        
        public virtual CMCLIE getMCLIE(IDataReader dr)
        {
            return new CMCLIE(Convert.ToDouble(dr["CO_ROLE"]),Convert.ToDouble(dr["NU_RUCS"]),Convert.ToDouble(dr["CO_CLIE"]),Convert.ToString(dr["DE_CLIE"]),Convert.ToDouble(dr["TI_DOID_SUNA"]),Convert.ToString(dr["TI_SITU"]),Convert.ToString(dr["CLIE_EMAIL"]),Convert.ToString(dr["F8"]),Convert.ToString(dr["F9"]),Convert.ToString(dr["F10"]),Convert.ToString(dr["F11"]),Convert.ToString(dr["F12"]),Convert.ToString(dr["F13"]),Convert.ToString(dr["F14"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CMCLIE oMCLIE)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("OfiOper.spu_MCLIE_Guardar")){
            Db.AddInParameter(dbCmd, "CO_ROLE", DbType.Double, oMCLIE.CO_ROLE);
            Db.AddInParameter(dbCmd, "NU_RUCS", DbType.Double, oMCLIE.NU_RUCS);
            Db.AddInParameter(dbCmd, "CO_CLIE", DbType.Double, oMCLIE.CO_CLIE);
            Db.AddInParameter(dbCmd, "DE_CLIE", DbType.String, oMCLIE.DE_CLIE);
            Db.AddInParameter(dbCmd, "TI_DOID_SUNA", DbType.Double, oMCLIE.TI_DOID_SUNA);
            Db.AddInParameter(dbCmd, "TI_SITU", DbType.String, oMCLIE.TI_SITU);
            Db.AddInParameter(dbCmd, "CLIE_EMAIL", DbType.String, oMCLIE.CLIE_EMAIL);
            Db.AddInParameter(dbCmd, "F8", DbType.String, oMCLIE.F8);
            Db.AddInParameter(dbCmd, "F9", DbType.String, oMCLIE.F9);
            Db.AddInParameter(dbCmd, "F10", DbType.String, oMCLIE.F10);
            Db.AddInParameter(dbCmd, "F11", DbType.String, oMCLIE.F11);
            Db.AddInParameter(dbCmd, "F12", DbType.String, oMCLIE.F12);
            Db.AddInParameter(dbCmd, "F13", DbType.String, oMCLIE.F13);
            Db.AddInParameter(dbCmd, "F14", DbType.String, oMCLIE.F14);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar()
        {
            return Db.ExecuteNonQuery("OfiOper.spu_MCLIE_Eliminar",);
        }
        
        public virtual CMCLIE Recuperar()
        {
            DataTable dtDatos = Db.ExecuteDataSet("OfiOper.spu_MCLIE_Recuperar",).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getMCLIE(dtDatos.Rows[0]);
            else
            return new CMCLIE();
        }
        
        public virtual bool Existe()
        {
            DataTable dtDatos = Db.ExecuteDataSet("OfiOper.spu_MCLIE_Recuperar",).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(out CMCLIE oMCLIE)
        {
            DataTable dtDatos = Db.ExecuteDataSet("OfiOper.spu_MCLIE_Recuperar",).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oMCLIE = getMCLIE(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oMCLIE = new CMCLIE();
            return false;
            }
        }
        
        public virtual IList<CMCLIE> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure,"OfiOper.spu_MCLIE_Listar")){
            IList<CMCLIE> list = new List<CMCLIE>();
            while (dr.Read())
            list.Add(getMCLIE(dr));
            return list;
            }
        }
        #endregion
    }
}
