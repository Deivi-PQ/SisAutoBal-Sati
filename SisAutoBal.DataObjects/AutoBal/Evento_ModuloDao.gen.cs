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
    
    
    public partial class Evento_ModuloDao :  DataAccessBase
    {
        
        public virtual CEvento_Modulo getTEvento_Modulo(DataRow dr)
        {
            return new CEvento_Modulo(Convert.ToInt64(dr["IDEvento"]),Convert.ToString(dr["Modulo"]),Convert.ToString(dr["Des_Evento"]),Convert.ToString(dr["Usuario"]),Convert.ToDateTime(dr["FechaHora"]),Convert.ToChar(dr["Tipo_Evento"]));
        }
        
        public virtual CEvento_Modulo getTEvento_Modulo(IDataReader dr)
        {
            return new CEvento_Modulo(Convert.ToInt64(dr["IDEvento"]),Convert.ToString(dr["Modulo"]),Convert.ToString(dr["Des_Evento"]),Convert.ToString(dr["Usuario"]),Convert.ToDateTime(dr["FechaHora"]),Convert.ToChar(dr["Tipo_Evento"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CEvento_Modulo oTEvento_Modulo)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("AutoBal.TEvento_Modulo_Guardar")){
            Db.AddInParameter(dbCmd, "IDEvento", DbType.Int64, oTEvento_Modulo.IDEvento);
            Db.AddInParameter(dbCmd, "Modulo", DbType.String, oTEvento_Modulo.Modulo);
            Db.AddInParameter(dbCmd, "Des_Evento", DbType.String, oTEvento_Modulo.Des_Evento);
            Db.AddInParameter(dbCmd, "Usuario", DbType.String, oTEvento_Modulo.Usuario);
            Db.AddInParameter(dbCmd, "FechaHora", DbType.DateTime, oTEvento_Modulo.FechaHora);
            Db.AddInParameter(dbCmd, "Tipo_Evento", DbType.String, oTEvento_Modulo.Tipo_Evento);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(Int64 IDEvento)
        {
            return Db.ExecuteNonQuery("AutoBal.TEvento_Modulo_Eliminar",IDEvento);
        }
        
        public virtual CEvento_Modulo Recuperar(Int64 IDEvento)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.TEvento_Modulo_Recuperar",IDEvento).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getTEvento_Modulo(dtDatos.Rows[0]);
            else
            return new CEvento_Modulo();
        }
        
        public virtual bool Existe(Int64 IDEvento)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.TEvento_Modulo_Recuperar",IDEvento).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(Int64 IDEvento, out CEvento_Modulo oTEvento_Modulo)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.TEvento_Modulo_Recuperar",IDEvento).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oTEvento_Modulo = getTEvento_Modulo(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oTEvento_Modulo = new CEvento_Modulo();
            return false;
            }
        }
        
        public virtual IList<CEvento_Modulo> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure,"AutoBal.TEvento_Modulo_Listar")){
            IList<CEvento_Modulo> list = new List<CEvento_Modulo>();
            while (dr.Read())
            list.Add(getTEvento_Modulo(dr));
            return list;
            }
        }
        #endregion
    }
}
