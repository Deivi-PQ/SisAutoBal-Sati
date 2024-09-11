//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: martes, 10 de octubre de 2023
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


    public partial class REGI_RFIDDao : DataAccessBase
    {

        public virtual CREGI_RFID getREGI_RFID(DataRow dr)
        {
            return new CREGI_RFID(Convert.ToString(dr["ID_REGI_PLAC"]), Convert.ToString(dr["Cod_RFID"]), Convert.ToDateTime(dr["Vigencia"]), Convert.ToDateTime(dr["DateNew"]),
                Convert.ToDateTime(dr["DateEdit"]),
                Convert.ToInt32(LComun.IsDbNull(dr["UserNew"], 0)),
                Convert.ToInt32(LComun.IsDbNull(dr["UserEdit"], 0)),
                Convert.ToChar(LComun.IsDbNull(dr["Estado"],' ')));
        }

        public virtual CREGI_RFID getREGI_RFID(IDataReader dr)
        {
            return new CREGI_RFID(Convert.ToString(dr["ID_REGI_PLAC"]), Convert.ToString(dr["Cod_RFID"]), Convert.ToDateTime(dr["Vigencia"]), Convert.ToDateTime(dr["DateNew"]),
                Convert.ToDateTime(dr["DateEdit"]),
                Convert.ToInt32(LComun.IsDbNull(dr["UserNew"], 0)),
                Convert.ToInt32(LComun.IsDbNull(dr["UserEdit"], 0)), Convert.ToChar(LComun.IsDbNull(dr["Estado"], ' ')));
        }

        #region Metodos Principales
        public virtual bool Grabar(CREGI_RFID oREGI_RFID)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("AutoBal.TS_REGI_RFID_I01"))
            {
                Db.AddInParameter(dbCmd, "ID_REGI_PLAC", DbType.String, oREGI_RFID.ID_REGI_PLAC);
                Db.AddInParameter(dbCmd, "Cod_RFID", DbType.String, oREGI_RFID.Cod_RFID);
                Db.AddInParameter(dbCmd, "Vigencia", DbType.DateTime, oREGI_RFID.Vigencia);
                Db.AddInParameter(dbCmd, "UserNew", DbType.String, oREGI_RFID.UserNew);
                Db.AddInParameter(dbCmd, "UserEdit", DbType.String, oREGI_RFID.UserEdit);
                Db.AddInParameter(dbCmd, "Estado", DbType.String, oREGI_RFID.Estado);
                return Db.ExecuteNonQuery(dbCmd) > 0;
            }
        }

        public virtual int Eliminar(String Cod_RFID)
        {
            return Db.ExecuteNonQuery("AutoBal.TS_REGI_RFID_D01", Cod_RFID);
        }

        public virtual CREGI_RFID Recuperar(String Cod_RFID)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.TS_REGI_RFID_Q01", Cod_RFID).Tables[0];
            if (dtDatos.Rows.Count > 0)
                return getREGI_RFID(dtDatos.Rows[0]);
            else
                return new CREGI_RFID();
        }

        public virtual bool Existe(String Cod_RFID)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.TS_REGI_RFID_Q01", Cod_RFID).Tables[0];
            return dtDatos.Rows.Count > 0;
        }

        public bool Existe(String Cod_RFID, out CREGI_RFID oREGI_RFID)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.TS_REGI_RFID_Q01", Cod_RFID).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
                oREGI_RFID = getREGI_RFID(dtDatos.Rows[0]);
                return true;
            }
            else
            {
                oREGI_RFID = new CREGI_RFID();
                return false;
            }
        }
        public CREGI_RFID PlacaRFID(String ID_REGI_PLAC)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.TS_REGI_RFID_Q03", ID_REGI_PLAC).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
                return getREGI_RFID(dtDatos.Rows[0]); ;
            }
            else
            {
                return new CREGI_RFID();
            }
        }

        public IList<CREGI_RFID> Listar(String ID_REGI_PLAC, String Cod_RFID, String? VigenciaIni, String? VigenciaFin)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.TS_REGI_RFID_Q02", ID_REGI_PLAC, Cod_RFID, VigenciaIni, VigenciaFin).Tables[0];
            {
                IList<CREGI_RFID> list = new List<CREGI_RFID>();
                if (dtDatos.Rows.Count > 0)
                {
                    for (int i = 0; i < dtDatos.Rows.Count; i++)
                    {
                        list.Add(getREGI_RFID(dtDatos.Rows[i]));
                    }
                }
                return list;
            }
        }
        #endregion

        public bool Existe_Placa(String ID_REGI_PLAC)
        {
            DataTable dtDatos = Db.ExecuteDataSet("AutoBal.TS_REGI_PLAC_Q01", ID_REGI_PLAC).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
    }
}
