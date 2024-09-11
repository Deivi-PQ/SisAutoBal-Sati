//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: martes, 27 de agosto de 2024
// </Auto Generado>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using SisAutoBal.BusinessObjects.AutoBal;
using Microsoft.Practices.EnterpriseLibrary.Data;
using LibreriaBSNet;

namespace SisAutoBal.DataObjects.AutoBal
{
    
    
    public partial class ConfigSisDao :  DataAccessBase
    {
        
        public virtual CConfigSis getTCONFIGSIS(DataRow dr)
        {
            return new CConfigSis(Convert.ToString(dr["Nombre_Variable"])!,Convert.ToString(dr["Valor_Variable"])!);
        }
        
        public virtual CConfigSis getTCONFIGSIS(IDataReader dr)
        {
            return new CConfigSis(Convert.ToString(dr["Nombre_Variable"])!,Convert.ToString(dr["Valor_Variable"])!);
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CConfigSis oTCONFIGSIS)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("AutoBal.TS_CONFIGSIS_I01")){
            Db.AddInParameter(dbCmd, "Nombre_Variable", DbType.String, oTCONFIGSIS.Nombre_Variable);
            Db.AddInParameter(dbCmd, "Valor_Variable", DbType.String, oTCONFIGSIS.Valor_Variable);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(String Nombre_Variable)
        {
            return Db.ExecuteNonQuery("AutoBal.TS_CONFIGSIS_D01", Nombre_Variable);
        }
        
        public virtual CConfigSis Recuperar(String Nombre_Variable)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.TS_CONFIGSIS_Q01", Nombre_Variable).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getTCONFIGSIS(dtDatos.Rows[0]);
            else
            return new CConfigSis();
        }
        
        public virtual bool Existe(String Nombre_Variable)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.TS_CONFIGSIS_Q01", Nombre_Variable).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(String Nombre_Variable, out CConfigSis oTCONFIGSIS)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.TS_CONFIGSIS_Q01", Nombre_Variable).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oTCONFIGSIS = getTCONFIGSIS(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oTCONFIGSIS = new CConfigSis();
            return false;
            }
        }
        
        public virtual IList<CConfigSis> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure, "AutoBal.TS_CONFIGSIS_Q02")){
            IList<CConfigSis> list = new List<CConfigSis>();
            while (dr.Read())
            list.Add(getTCONFIGSIS(dr));
            return list;
            }
        }
        #endregion
    }
}
