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
using SisAutoBal.BusinessObjects.AutoBal;
using Microsoft.Practices.EnterpriseLibrary.Data;
using LibreriaBSNet;

namespace SisAutoBal.DataObjects.AutoBal
{


    public partial class BloqueoPasoBalanzaDao : DataAccessBase
    {

        public virtual CBloqueoPasoBalanza getBloqueoPasoBalanza(DataRow dr)
        {
            return new CBloqueoPasoBalanza(
                Convert.ToInt32(dr["IDBloqueBal"]), 
                Convert.ToInt64(dr["ID_REQU_ATEN"]),
                Convert.ToString(dr["Nro_Placa"]),
                Convert.ToString(dr["MotivoBloqueo"]),
                Convert.ToChar(dr["EstadoBloqueo"]),
                Convert.ToDateTime(LComun.IsDbNull(dr["FechaAprobacion"], DateTime.Now)),
                Convert.ToInt32(dr["ID_USUA"]));
        }

        public virtual CBloqueoPasoBalanza getBloqueoPasoBalanza(IDataReader dr)
        {
            return new CBloqueoPasoBalanza(
                Convert.ToInt32(dr["IDBloqueBal"]), 
                Convert.ToInt64(dr["ID_REQU_ATEN"]),
                Convert.ToString(dr["Nro_Placa"]),
                Convert.ToString(dr["MotivoBloqueo"]), 
                Convert.ToChar(dr["EstadoBloqueo"]),
                Convert.ToDateTime(LComun.IsDbNull(dr["FechaAprobacion"], DateTime.Now)),
                Convert.ToInt32(dr["ID_USUA"]));
        }

        #region Metodos Principales
        public virtual bool Grabar(CBloqueoPasoBalanza oBloqueoPasoBalanza)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("AutoBal.TS_TTBLOQ_BALA_I01"))
            {
                Db.AddInParameter(dbCmd, "ID_REQU_ATEN", DbType.Int64, oBloqueoPasoBalanza.ID_REQU_ATEN);
                Db.AddInParameter(dbCmd, "MotivoBloqueo", DbType.String, oBloqueoPasoBalanza.MotivoBloqueo);
                Db.AddInParameter(dbCmd, "EstadoBloqueo", DbType.String, oBloqueoPasoBalanza.EstadoBloqueo);

                if (oBloqueoPasoBalanza.EstadoBloqueo == 'P')
                    Db.AddInParameter(dbCmd, "FechaAprobacion", DbType.DateTime, DBNull.Value);
                else
                    Db.AddInParameter(dbCmd, "FechaAprobacion", DbType.DateTime, oBloqueoPasoBalanza.FechaAprobacion);

                Db.AddInParameter(dbCmd, "ID_USUA", DbType.Int32, oBloqueoPasoBalanza.ID_USUA);
                return Db.ExecuteNonQuery(dbCmd) > 0;
            }
        }

        public virtual int Eliminar(String IDBloqueBal)
        {
            return Db.ExecuteNonQuery("AutoBal.TS_TTBLOQ_BALA_D01", IDBloqueBal);
        }

        public virtual CBloqueoPasoBalanza Recuperar(String IDBloqueBal)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.TS_TTBLOQ_BALA_Q01", IDBloqueBal).Tables[0];
            if (dtDatos.Rows.Count > 0)
                return getBloqueoPasoBalanza(dtDatos.Rows[0]);
            else
                return new CBloqueoPasoBalanza();
        }

        public virtual bool Existe(String IDBloqueBal)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.TS_TTBLOQ_BALA_Q01", IDBloqueBal).Tables[0];
            return dtDatos.Rows.Count > 0;
        }

        public virtual bool Existe(String IDBloqueBal, out CBloqueoPasoBalanza oBloqueoPasoBalanza)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.TS_TTBLOQ_BALA_Q01", IDBloqueBal).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
                oBloqueoPasoBalanza = getBloqueoPasoBalanza(dtDatos.Rows[0]);
                return true;
            }
            else
            {
                oBloqueoPasoBalanza = new CBloqueoPasoBalanza();
                return false;
            }
        }

        public virtual IList<CBloqueoPasoBalanza> Listar(DateTime Fecha, char Estado)
        {
            using (IDataReader dr = Db.ExecuteReader("AutoBal.TS_TTBLOQ_BALA_Q02", Fecha, Estado))
            {
                IList<CBloqueoPasoBalanza> list = new List<CBloqueoPasoBalanza>();
                while (dr.Read())
                    list.Add(getBloqueoPasoBalanza(dr));
                return list;
            }
        }

        /*public virtual IList<CBloqueoPasoBalanza> Listar_X_Estado(String Estado)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.spu_BloqueoPasoBalanza_Listar_X_Estado", Estado).Tables[0];
            {
                IList<CBloqueoPasoBalanza> list = new List<CBloqueoPasoBalanza>();
                if (dtDatos.Rows.Count > 0)
                {
                    for (int i = 0; i < dtDatos.Rows.Count; i++)
                    {
                        list.Add(getBloqueoPasoBalanza(dtDatos.Rows[i]));
                    }
                }
                return list;
            }
        }
        public virtual IList<CBloqueoPasoBalanza> Listar_X_EstadoFecha(String Estado, String FechaInicio, String FechaFinal)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.spu_BloqueoPasoBalanza_Listar_X_EstadoFecha", Estado, FechaInicio, FechaFinal).Tables[0];
            {
                IList<CBloqueoPasoBalanza> list = new List<CBloqueoPasoBalanza>();
                if (dtDatos.Rows.Count > 0)
                {
                    for (int i = 0; i < dtDatos.Rows.Count; i++)
                    {
                        list.Add(getBloqueoPasoBalanza(dtDatos.Rows[i]));
                    }
                }
                return list;
            }
        }*/
        public Boolean Actualizar(int ID_REQU_ATEN, string Nro_Placa, string EstadoBloqueo, int ID_USUA)
        {
            return Db.ExecuteNonQuery("AutoBal.TS_TTBLOQ_BALA_U02", ID_REQU_ATEN, Nro_Placa, EstadoBloqueo, ID_USUA) > 0;
        }
        #endregion
    }
}
