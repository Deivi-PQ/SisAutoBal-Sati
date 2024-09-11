//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: viernes, 20 de octubre de 2023
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
using SisAutoBal.DataObjects;

namespace SisAutoBal.DataObjects.AutoBal
{


    public partial class DatosRfidDao : DataAccessBase
    {
        public virtual CDatosRFID getatosRFID(DataRow dr)
        {
            return new CDatosRFID(Convert.ToInt32(dr["id"]), Convert.ToString(dr["sn"])!, Convert.ToDateTime(dr["ttime"])!, Convert.ToString(dr["pin"])!, Convert.ToString(dr["cardno"])!, Convert.ToString(dr["eventaddr"])!, Convert.ToString(dr["evento"])!, Convert.ToString(dr["inoutstatus"])!, Convert.ToString(dr["verifytype"])!, Convert.ToString(dr["iindex"])!, Convert.ToBoolean(dr["flagProcesado"] != DBNull.Value? dr["flagProcesado"] : 0));
        }

        public virtual CDatosRFID getatosRFID(IDataReader dr)
        {
            return new CDatosRFID(Convert.ToInt32(dr["id"]), Convert.ToString(dr["sn"])!, Convert.ToDateTime(dr["ttime"])!, Convert.ToString(dr["pin"])!, Convert.ToString(dr["cardno"])!, Convert.ToString(dr["eventaddr"])!, Convert.ToString(dr["evento"])!, Convert.ToString(dr["inoutstatus"])!, Convert.ToString(dr["verifytype"])!, Convert.ToString(dr["iindex"])!, Convert.ToBoolean(dr["flagProcesado"] != DBNull.Value ? dr["flagProcesado"] : 0));
        }

        #region Metodos Principales
        public virtual bool Grabar(CDatosRFID oDatosRFID)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("AutoBal.spu_DatosRFID_Guardar"))
            {
                Db.AddInParameter(dbCmd, "sn", DbType.String, oDatosRFID.SN);
                Db.AddInParameter(dbCmd, "TTime", DbType.DateTime, oDatosRFID.TTime);
                Db.AddInParameter(dbCmd, "Pin", DbType.String, oDatosRFID.Pin);
                Db.AddInParameter(dbCmd, "Cardno", DbType.String, oDatosRFID.Cardno);
                Db.AddInParameter(dbCmd, "Eventaddr", DbType.String, oDatosRFID.Eventaddr);
                Db.AddInParameter(dbCmd, "Evento", DbType.String, oDatosRFID.Evento);
                Db.AddInParameter(dbCmd, "Inoutstatus", DbType.String, oDatosRFID.Inoutstatus);
                Db.AddInParameter(dbCmd, "Verifytype", DbType.String, oDatosRFID.Verifytype);
                Db.AddInParameter(dbCmd, "IIndex", DbType.String, oDatosRFID.IIndex);
                // --- Ejecutando procedimiento almacenado
                return Db.ExecuteNonQuery(dbCmd) > 0;
            }
        }

        public virtual int Eliminar(Int32 id)
        {
            return Db.ExecuteNonQuery("AutoBal.spu_DatosRFID_Eliminar", id);
        }

        public virtual CDatosRFID Recuperar(Int32 id)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.spu_DatosRFID_Recuperar", id).Tables[0];
            if (dtDatos.Rows.Count > 0)
                return getatosRFID(dtDatos.Rows[0]);
            else
                return new CDatosRFID();
        }

        public virtual bool Existe(Int32 id)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.spu_DatosRFID_Recuperar", id).Tables[0];
            return dtDatos.Rows.Count > 0;
        }

        public virtual bool Existe(Int32 id, out CDatosRFID oatosRFID)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.spu_DatosRFID_Recuperar", id).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
                oatosRFID = getatosRFID(dtDatos.Rows[0]);
                return true;
            }
            else
            {
                oatosRFID = new CDatosRFID();
                return false;
            }
        }

        public virtual IList<CDatosRFID> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure, "AutoBal.TS_TDatosRFID_Q03"))
            {
                IList<CDatosRFID> list = new List<CDatosRFID>();
                while (dr.Read())
                    list.Add(getatosRFID(dr));
                return list;
            }
        }
        #endregion
    }
}
