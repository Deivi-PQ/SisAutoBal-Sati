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
    
    
    public partial class Acceso_PerfilDao :  DataAccessBase
    {
        
        public virtual CAcceso_Perfil getTAcceso_Perfil(DataRow dr)
        {
            return new CAcceso_Perfil(Convert.ToString(dr["Cod_Acceso"]),Convert.ToInt32(dr["IDPerfil"]));
        }
        
        public virtual CAcceso_Perfil getTAcceso_Perfil(IDataReader dr)
        {
            return new CAcceso_Perfil(Convert.ToString(dr["Cod_Acceso"]),Convert.ToInt32(dr["IDPerfil"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CAcceso_Perfil oTAcceso_Perfil)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("AutoBal.TS_Acceso_Perfil_I01")){
            Db.AddInParameter(dbCmd, "Cod_Acceso", DbType.String, oTAcceso_Perfil.Cod_Acceso);
            Db.AddInParameter(dbCmd, "IDPerfil", DbType.Int32, oTAcceso_Perfil.IDPerfil);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(String Cod_Acceso, Int32 IDPerfil)
        {
            return Db.ExecuteNonQuery("AutoBal.TS_Acceso_Perfil_D01", Cod_Acceso,IDPerfil);
        }
        
        public virtual CAcceso_Perfil Recuperar(String Cod_Acceso, Int32 IDPerfil)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.TAcceso_Perfil_Recuperar",Cod_Acceso,IDPerfil).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getTAcceso_Perfil(dtDatos.Rows[0]);
            else
            return new CAcceso_Perfil();
        }
        
        public virtual bool Existe(String Cod_Acceso, Int32 IDPerfil)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.TAcceso_Perfil_Recuperar",Cod_Acceso,IDPerfil).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(String Cod_Acceso, Int32 IDPerfil, out CAcceso_Perfil oTAcceso_Perfil)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.TAcceso_Perfil_Recuperar",Cod_Acceso,IDPerfil).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oTAcceso_Perfil = getTAcceso_Perfil(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oTAcceso_Perfil = new CAcceso_Perfil();
            return false;
            }
        }
        
        public virtual IList<CAcceso_Perfil> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure,"AutoBal.TAcceso_Perfil_Listar")){
            IList<CAcceso_Perfil> list = new List<CAcceso_Perfil>();
            while (dr.Read())
            list.Add(getTAcceso_Perfil(dr));
            return list;
            }
        }
        public virtual IList<CAcceso_Perfil> ListarXPerfil(int IDPerfil)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.TS_Acceso_Perfil_Q01", IDPerfil).Tables[0];
            {
                IList<CAcceso_Perfil> list = new List<CAcceso_Perfil>();
                if (dtDatos.Rows.Count > 0)
                {
                    for (int i = 0; i < dtDatos.Rows.Count; i++)
                    {
                        list.Add(getTAcceso_Perfil(dtDatos.Rows[i]));
                    }
                }
                return list;
            }
        }
        #endregion
    }
}
