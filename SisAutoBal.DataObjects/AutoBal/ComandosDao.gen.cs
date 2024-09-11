using SisAutoBal.BusinessObjects.AutoBal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisAutoBal.DataObjects.AutoBal
{
    public partial class ComandosDao: DataAccessBase
    {
        public virtual CComandos getComandos(DataRow dr)
        {
            return new CComandos(
                dr["id"] == DBNull.Value ? -1 : Convert.ToInt16(dr["id"]),
                dr["sn"] == DBNull.Value ? "" : Convert.ToString(dr["sn"]),
                dr["comando"] == DBNull.Value ? "" : Convert.ToString(dr["comando"]),
                dr["estado"] == DBNull.Value ? "" : Convert.ToString(dr["estado"])
            );
        }

        #region Metodos Principales
        public virtual bool Grabar(CComandos comandos)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("AutoBal.spu_Comandos_Guardar"))
            {
                Db.AddInParameter(dbCmd, "id", DbType.String, comandos.Id);
                Db.AddInParameter(dbCmd, "sn", DbType.String, comandos.sn);
                Db.AddInParameter(dbCmd, "comando", DbType.String, comandos.Comando);
                Db.AddInParameter(dbCmd, "estado", DbType.String, comandos.Estado);
                return Db.ExecuteNonQuery(dbCmd) > 0;
            }
        }
        public virtual IList<CComandos> Lista()
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.spu_Comandos_Listar").Tables[0];
            {
                IList<CComandos> list = new List<CComandos>();
                if (dtDatos.Rows.Count > 0)
                {
                    for (int i = 0; i < dtDatos.Rows.Count; i++)
                    {
                        list.Add(getComandos(dtDatos.Rows[i]));
                    }
                }
                return list;
            }
        }
        public virtual CComandos Recuperar(String SN)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.spu_Comandos_Recuperar",SN).Tables[0];
            if (dtDatos.Rows.Count > 0)
                return getComandos(dtDatos.Rows[0]);
            else
                return new CComandos();
        }
        public virtual int Eliminar(String sn, String activo)
        {
            return Db.ExecuteNonQuery("AutoBal.spu_Comandos_Eliminar", sn, activo);
        }
        public virtual bool Existe(Int32 id)
        {
            DataTable dtDatos = Db.ExecuteDataSet(".omandos_Recuperar",id).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        #endregion
    }
}