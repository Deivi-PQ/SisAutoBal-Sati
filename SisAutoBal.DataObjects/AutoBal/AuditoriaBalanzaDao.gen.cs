using SisAutoBal.BusinessObjects.AutoBal;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisAutoBal.DataObjects.AutoBal
{
    public partial class AuditoriaBalanzaDao : DataAccessBase
    {
        public virtual CAuditoriaBalanza getAuditoriaBalanza(DataRow dr)
        {
            return new CAuditoriaBalanza(
                           dr["IDAudBal"] == DBNull.Value ? -1 : Convert.ToInt64(dr["IDAudBal"]),
                           dr["ID_BALA"] == DBNull.Value ? "" : Convert.ToString(dr["ID_BALA"])!,
                           dr["Accion"] == DBNull.Value ? "" : Convert.ToString(dr["Accion"])!,
                           dr["Fecha"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr["Fecha"]),
                           dr["Usuario"] == DBNull.Value ? "" : Convert.ToString(dr["Usuario"])!,
                           dr["Motivo"] == DBNull.Value ? "" : Convert.ToString(dr["Motivo"])!
                       );
        }

        public virtual CAuditoriaBalanza getAuditoriaBalanza(IDataReader dr)
        {
            return new CAuditoriaBalanza(
                           dr["IDAudBal"] == DBNull.Value ? -1 : Convert.ToInt64(dr["IDAudBal"]),
                           dr["ID_BALA"] == DBNull.Value ? "" : Convert.ToString(dr["ID_BALA"])!,
                           dr["Accion"] == DBNull.Value ? "" : Convert.ToString(dr["Accion"])!,
                           dr["Fecha"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr["Fecha"]),
                           dr["Usuario"] == DBNull.Value ? "" : Convert.ToString(dr["Usuario"])!,
                           dr["Motivo"] == DBNull.Value ? "" : Convert.ToString(dr["Motivo"])!
                );
        }
        public virtual CAuditoriaBalazaGenaral getAuditoriaBalanzaGeneral(DataRow dr)
        {
            return new CAuditoriaBalazaGenaral(
                           dr["Nro"] == DBNull.Value ? -1 : Convert.ToInt16(dr["Nro"]),
                           dr["ID_BALA"] == DBNull.Value ? "" : Convert.ToString(dr["ID_BALA"])!,
                           dr["DE_TIPO"] == DBNull.Value ? "" : Convert.ToString(dr["DE_TIPO"])!,
                           dr["Accion"] == DBNull.Value ? "" : Convert.ToString(dr["Accion"])!,
                           dr["DE_USUA"] == DBNull.Value ? "" : Convert.ToString(dr["DE_USUA"])!,
                           dr["Fecha"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr["Fecha"])
                );
        }

        #region Metodos Principales
        public virtual bool Grabar(CAuditoriaBalanza oAuditoriaBalanza)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("AutoBal.TS_TMAUD_BALA_I01"))
            {
                Db.AddInParameter(dbCmd, "ID_BALA", DbType.String, oAuditoriaBalanza.ID_BALA);
                Db.AddInParameter(dbCmd, "Accion", DbType.String, oAuditoriaBalanza.Accion);
                Db.AddInParameter(dbCmd, "Usuario", DbType.String, oAuditoriaBalanza.Usuario);
                Db.AddInParameter(dbCmd, "Motivo", DbType.String, oAuditoriaBalanza.Motivo);
                return Db.ExecuteNonQuery(dbCmd) > 0;
            }
        }
        public virtual IList<CAuditoriaBalanza> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure, "AutoBal.TS_TMAUD_BALA_Q01"))
            {
                IList<CAuditoriaBalanza> list = new List<CAuditoriaBalanza>();
                while (dr.Read())
                    list.Add(getAuditoriaBalanza(dr));
                return list;
            }
        }
        public virtual IList<CAuditoriaBalanza> ListarPorFecha(String Estado, String FechaInicio, String FechaFinal)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.TS_TMAUD_BALA_Q03", Estado, FechaInicio, FechaFinal).Tables[0];
            {
                IList<CAuditoriaBalanza> list = new List<CAuditoriaBalanza>();
                if (dtDatos.Rows.Count > 0)
                {
                    for (int i = 0; i < dtDatos.Rows.Count; i++)
                    {
                        list.Add(getAuditoriaBalanza(dtDatos.Rows[i]));
                    }
                }
                return list;
            }
        }
        public virtual IList<CAuditoriaBalazaGenaral> Listar_X_Fecha(String FechaInicio, String FechaFinal, String Balanza, String Estado)
        {
            if (Estado == "todo")
                Estado = "";
            if (Balanza == "todo")
                Balanza = "";
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.TS_TMAUD_BALA_Q02", FechaInicio, FechaFinal, Balanza, Estado).Tables[0];
            {
                IList<CAuditoriaBalazaGenaral> list = new List<CAuditoriaBalazaGenaral>();
                if (dtDatos.Rows.Count > 0)
                {
                    for (int i = 0; i < dtDatos.Rows.Count; i++)
                    {
                        list.Add(getAuditoriaBalanzaGeneral(dtDatos.Rows[i]));
                    }
                }
                return list;
            }
        }
        #endregion
    }
}