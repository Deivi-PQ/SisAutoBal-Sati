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
    
    
    public partial class UsuarioDao :  DataAccessBase
    {
        
        public virtual CUsuario getTUsuario(DataRow dr)
        {
            return new CUsuario(Convert.ToString(dr["CodUsuario"]),Convert.ToString(dr["Nombre_Usuario"]),Convert.ToBoolean(dr["flagActDir"]),Convert.ToString(dr["Passwd"]),Convert.ToChar(dr["Estado"]),Convert.ToInt32(dr["IDPerfil"]),Convert.ToString(dr["UserNew"]),Convert.ToDateTime(dr["DateNew"]),Convert.ToString(dr["UserEdit"]),Convert.ToDateTime(dr["DateEdit"]),Convert.ToString(dr["Mail"]));
        }
        
        public virtual CUsuario getTUsuario(IDataReader dr)
        {
            return new CUsuario(Convert.ToString(dr["CodUsuario"]),Convert.ToString(dr["Nombre_Usuario"]),Convert.ToBoolean(dr["flagActDir"]),Convert.ToString(dr["Passwd"]),Convert.ToChar(dr["Estado"]),Convert.ToInt32(dr["IDPerfil"]),Convert.ToString(dr["UserNew"]),Convert.ToDateTime(dr["DateNew"]),Convert.ToString(dr["UserEdit"]),Convert.ToDateTime(dr["DateEdit"]),Convert.ToString(dr["Mail"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CUsuario oTUsuario)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("AutoBal.TS_Usuario_I01")){
            Db.AddInParameter(dbCmd, "CodUsuario", DbType.String, oTUsuario.CodUsuario);
            Db.AddInParameter(dbCmd, "Nombre_Usuario", DbType.String, oTUsuario.Nombre_Usuario);
            Db.AddInParameter(dbCmd, "flagActDir", DbType.Boolean, oTUsuario.flagActDir);
            Db.AddInParameter(dbCmd, "Passwd", DbType.String, oTUsuario.Passwd);
            Db.AddInParameter(dbCmd, "Estado", DbType.String, oTUsuario.Estado);
            Db.AddInParameter(dbCmd, "IDPerfil", DbType.Int32, oTUsuario.IDPerfil);
            Db.AddInParameter(dbCmd, "UserNew", DbType.String, oTUsuario.UserNew);
            Db.AddInParameter(dbCmd, "UserEdit", DbType.String, oTUsuario.UserEdit);
            Db.AddInParameter(dbCmd, "Mail", DbType.String, oTUsuario.Mail);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(String CodUsuario)
        {
            return Db.ExecuteNonQuery("AutoBal.TUsuario_Eliminar",CodUsuario);
        }
        
        public virtual CUsuario Recuperar(String CodUsuario)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.TS_Usuario_Q01", CodUsuario).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getTUsuario(dtDatos.Rows[0]);
            else
            return new CUsuario();
        }
        
        public virtual bool Existe(String CodUsuario)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.TS_Usuario_Q01", CodUsuario).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(String CodUsuario, out CUsuario oTUsuario)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.TS_Usuario_Q01", CodUsuario).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
                oTUsuario = getTUsuario(dtDatos.Rows[0]);
                return true;
            }
            else
            {
                oTUsuario = new CUsuario();
                return false;
            }
        }
        
        public virtual IList<CUsuario> Listar(String CodUsuario, String Nombre_Usuario, String IDPerfil)
        {
            CodUsuario = string.IsNullOrWhiteSpace(CodUsuario) ? "*" : CodUsuario;
            Nombre_Usuario = string.IsNullOrWhiteSpace(Nombre_Usuario) ? "*" : Nombre_Usuario;
            IDPerfil = string.IsNullOrWhiteSpace(IDPerfil) ? "todo" : IDPerfil;
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.TS_Usuario_Q02", CodUsuario == "*" ? "" : CodUsuario, Nombre_Usuario == "*" ? "" : Nombre_Usuario, IDPerfil == "todo"?DBNull.Value: IDPerfil).Tables[0];
            {
                IList<CUsuario> list = new List<CUsuario>();
                if (dtDatos.Rows.Count > 0)
                {
                    for (int i = 0; i < dtDatos.Rows.Count; i++)
                    {
                        list.Add(getTUsuario(dtDatos.Rows[i]));
                    }
                }
                return list;
            }
        }
        #endregion
    }
}
